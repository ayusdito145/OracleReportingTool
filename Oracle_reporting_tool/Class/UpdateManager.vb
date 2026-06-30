Imports System.ComponentModel
Imports Guna.UI2.WinForms
Imports ADODB
Imports System.Data.SqlClient
Imports System.Net.NetworkInformation ' Add this for network detection
Imports System.Reflection
Imports System.Configuration
Imports System.IO.Compression
Imports System.IO
Imports System.Net
Public Class UpdateManager
    Private ReadOnly HQConnection As String
    Private ReadOnly DownloadZipPath As String

    Public Event StatusChanged(message As String, color As Color)
    Public Event UpdateProgress(percent As Integer)

    Public Sub New(connectionString As String)
        HQConnection = connectionString
        DownloadZipPath = Path.Combine(Application.StartupPath, "OracleReportingTool.zip")
    End Sub

    Public Async Function GetAppUpdateUrlAsync() As Task(Of String)
        Return Await Task.Run(Function()
                                  Try
                                      Using conn As New SqlConnection(HQConnection)
                                          conn.Open()
                                          Using cmd As New SqlCommand(
                                              "SELECT TOP 1 LatestVersion, UpdateUrl FROM AppVersionControl ORDER BY ID DESC", conn)
                                              Using reader As SqlDataReader = cmd.ExecuteReader()
                                                  If reader.Read() Then
                                                      Dim serverVersion As String = reader("LatestVersion").ToString().Trim()
                                                      Dim updateUrl As String = reader("UpdateUrl").ToString().Trim()

                                                      If String.IsNullOrEmpty(serverVersion) Then Return ""

                                                      Dim current As New Version(
                                                          Assembly.GetExecutingAssembly().GetName().Version.ToString())
                                                      Dim latest As New Version(serverVersion)

                                                      If latest > current Then Return updateUrl
                                                  End If
                                              End Using
                                          End Using
                                      End Using
                                  Catch ex As Exception
                                      Debug.WriteLine("[UpdateManager] App version check failed: " & ex.Message)
                                  End Try
                                  Return ""
                              End Function)
    End Function
    Public Function GetCurrentVersionString() As String
        Return "v" & Assembly.GetExecutingAssembly().GetName().Version.ToString()
    End Function
    Public Async Function DownloadUpdateAsync(updateUrl As String) As Task
        ' Clean up any previous failed download
        If File.Exists(DownloadZipPath) Then File.Delete(DownloadZipPath)

        RaiseEvent StatusChanged("Starting download...", Color.DodgerBlue)

        Using wc As New WebClient()
            AddHandler wc.DownloadProgressChanged,
                Sub(s, ev)
                    RaiseEvent UpdateProgress(ev.ProgressPercentage)
                    RaiseEvent StatusChanged($"Downloading update... {ev.ProgressPercentage}%", Color.DodgerBlue)
                End Sub

            Await wc.DownloadFileTaskAsync(New Uri(updateUrl), DownloadZipPath)
        End Using
    End Function
    Public Async Function InstallAppUpdateAsync() As Task(Of (Success As Boolean, Message As String))
        Return Await Task.Run(Function()
                                  Dim extractFolder As String = Path.Combine(Application.StartupPath, "UpdateTemp")
                                  Try
                                      RaiseEvent StatusChanged("Extracting update files...", Color.Orange)

                                      If Directory.Exists(extractFolder) Then Directory.Delete(extractFolder, True)
                                      ZipFile.ExtractToDirectory(DownloadZipPath, extractFolder)

                                      Dim myExeName As String = Path.GetFileName(Application.ExecutablePath)
                                      Dim sourcePath As String = FindSourcePath(extractFolder, myExeName)

                                      If String.IsNullOrEmpty(sourcePath) Then
                                          CleanupTempFiles(extractFolder)
                                          Return (False, $"Update ZIP does not contain '{myExeName}'. Please contact support.")
                                      End If

                                      RaiseEvent StatusChanged("Installing files...", Color.Orange)
                                      Dim updatedCount As Integer = SwapFiles(sourcePath, Application.StartupPath)
                                      CleanupTempFiles(extractFolder)

                                      If updatedCount > 0 Then
                                          Return (True, $"Update installed ({updatedCount} files updated). Restarting...")
                                      Else
                                          Return (False, "No files were updated. Please verify the ZIP structure.")
                                      End If

                                  Catch ex As Exception
                                      CleanupTempFiles(extractFolder)
                                      Return (False, "Install error: " & ex.Message)
                                  End Try
                              End Function)
    End Function

    Private Function FindSourcePath(extractFolder As String, exeName As String) As String
        If File.Exists(Path.Combine(extractFolder, exeName)) Then Return extractFolder
        Dim found() As String = Directory.GetFiles(extractFolder, exeName, SearchOption.AllDirectories)
        If found.Length > 0 Then Return Path.GetDirectoryName(found(0))
        Return ""
    End Function

    Private Function SwapFiles(sourcePath As String, destPath As String) As Integer
        Dim count As Integer = 0
        For Each srcFile As String In Directory.GetFiles(sourcePath)
            Dim fileName As String = Path.GetFileName(srcFile)
            Dim destFile As String = Path.Combine(destPath, fileName)

            If fileName.ToLower().EndsWith(".config") Then Continue For ' Preserve user config

            If File.Exists(destFile) Then
                Dim bakPath As String = GetSafeBakPath(destFile)
                File.Move(destFile, bakPath)
            End If

            File.Move(srcFile, destFile)
            count += 1
        Next
        Return count
    End Function

    Private Function GetSafeBakPath(filePath As String) As String
        Dim bak As String = filePath & ".bak"
        Try
            If File.Exists(bak) Then File.Delete(bak)
            Return bak
        Catch
            Return filePath & "." & Guid.NewGuid().ToString("N").Substring(0, 6) & ".bak"
        End Try
    End Function

    Private Sub CleanupTempFiles(extractFolder As String)
        Try
            If Directory.Exists(extractFolder) Then Directory.Delete(extractFolder, True)
            If File.Exists(DownloadZipPath) Then File.Delete(DownloadZipPath)
        Catch ex As Exception
            Debug.WriteLine("[UpdateManager] Cleanup warning: " & ex.Message)
        End Try
    End Sub

    ' ─────────────────────────────────────────────────────────
    ' STEP 5: Apply database structure patches (SQL scripts)
    ' ─────────────────────────────────────────────────────────
    Public Async Function ApplyDatabasePatchesAsync() As Task(Of (Success As Boolean, Message As String))
        Return Await Task.Run(Function()
                                  Try
                                      If Not DatabasePatcher.IsDatabaseUpdateAvailable() Then
                                          Return (True, "Database is up to date.")
                                      End If

                                      RaiseEvent StatusChanged("Applying database patches...", Color.Orange)
                                      DatabasePatcher.RunSqlUpdate()
                                      RaiseEvent StatusChanged("Database patched successfully.", Color.Green)

                                      Return (True, "Database patches applied successfully.")
                                  Catch ex As Exception
                                      Return (False, "Database patch failed: " & ex.Message)
                                  End Try
                              End Function)
    End Function

    ' ─────────────────────────────────────────────────────────
    ' NETWORK CHECK (async ping)
    ' ─────────────────────────────────────────────────────────
    Public Async Function IsNetworkAvailableAsync() As Task(Of Boolean)
        Try
            Dim ping As New Ping()
            Dim reply As PingReply = Await ping.SendPingAsync("8.8.8.8", 1500)
            Return reply.Status = IPStatus.Success
        Catch
            Return False
        End Try
    End Function

    ' ─────────────────────────────────────────────────────────
    ' AUTHENTICATE USER (async SQL)
    ' ─────────────────────────────────────────────────────────
    Public Async Function AuthenticateUserAsync(username As String, password As String) As Task(Of DataRow)
        Return Await Task.Run(Function()
                                  Using conn As New SqlConnection(HQConnection)
                                      Using cmd As New SqlCommand(
                    "SELECT locationname, access, username, locationid
                     FROM dts_location
                     WHERE username=@username AND password=@password", conn)

                                          cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username
                                          cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = password

                                          Dim ds As New DataSet()
                                          Dim adapter As New SqlDataAdapter(cmd)
                                          adapter.Fill(ds, "dts_location")

                                          If ds.Tables(0).Rows.Count > 0 Then
                                              Return ds.Tables(0).Rows(0)
                                          End If
                                          Return Nothing
                                      End Using
                                  End Using
                              End Function)
    End Function


End Class
