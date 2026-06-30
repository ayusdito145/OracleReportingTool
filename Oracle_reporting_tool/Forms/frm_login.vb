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

Public Class frm_login

    Private isOfflineMode As Boolean = False
    Private updater As UpdateManager

    Private ReadOnly HQConnection As String =
        ConfigurationManager.ConnectionStrings("HQDB").ConnectionString

    Private Const OFFLINE_USERNAME As String = "OFFLINE"
    Private Const OFFLINE_ACCESS As String = "LIMITED"

    Public Sub New()
        InitializeComponent()
        Me.AutoScaleMode = AutoScaleMode.None
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updater = New UpdateManager(HQConnection)

        AddHandler updater.StatusChanged, AddressOf OnUpdaterStatusChanged
        AddHandler updater.UpdateProgress, AddressOf OnUpdaterProgress

        txtpass.UseSystemPasswordChar = True
        Me.KeyPreview = True
        Guna2ProgressIndicator1.Visible = False
        btnOfflineLogin.Visible = False
        lblstatus.Visible = False

        'lblUpdateStatus.Text = "System " & updater.GetCurrentVersionString()
        'lblUpdateStatus.ForeColor = Color.Gray

        progressBarUpdate.Minimum = 0
        progressBarUpdate.Maximum = 100
        progressBarUpdate.Value = 0
        progressBarUpdate.Visible = False   ' Hidden until download starts
        progressBarUpdate.Height = 20       ' Slim bar looks clean
    End Sub

    Private Async Sub frm_login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        getData()
        Await RunStartupChecksAsync()
    End Sub

    ' ─────────────────────────────────────────────────────────
    ' STARTUP CHECKS: Network → App Update → DB Patch → Ready
    ' ─────────────────────────────────────────────────────────
    Private Async Function RunStartupChecksAsync() As Task
        SetUIBusy(True)
        SetStatus("Checking network...", Color.Gray)

        ' ── 1. Network Check ──────────────────────────────────
        isOfflineMode = Not Await updater.IsNetworkAvailableAsync()

        If isOfflineMode Then
            SetStatus("Offline Mode — Limited Functionality", Color.OrangeRed)
            btnOfflineLogin.Visible = True
            SetUIBusy(False)
            Return
        End If
        ' ── 2. App Update Check ───────────────────────────────
        SetStatus("Checking for application updates...", Color.Gray)
        Dim appUpdateUrl As String = Await updater.GetAppUpdateUrlAsync()

        If Not String.IsNullOrEmpty(appUpdateUrl) Then
            Dim answer As DialogResult = MessageBox.Show(
                "A new version of the application is available." & vbCrLf &
                "You must update before logging in." & vbCrLf & vbCrLf &
                "Update now?",
                "Application Update Required",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If answer = DialogResult.Yes Then
                Await RunAppUpdateAsync(appUpdateUrl)
                Return ' App will restart — stop all further processing
            Else
                SetStatus("Warning: Running outdated version.", Color.OrangeRed)
            End If
        End If

        ' ── 3. Database Patch Check ───────────────────────────
        Await ApplyDatabasePatchesIfNeededAsync()

        ' ── 4. Ready ──────────────────────────────────────────
        SetStatus("System Ready  |  " & updater.GetCurrentVersionString(), Color.DimGray)
        SetUIBusy(False)
    End Function
    ' ─────────────────────────────────────────────────────────
    ' APP UPDATE: Download → Install → Restart
    ' ─────────────────────────────────────────────────────────
    Private Async Function RunAppUpdateAsync(updateUrl As String) As Task
        Try
            Guna2ProgressIndicator1.Visible = True
            Guna2ProgressIndicator1.Start()

            ' Download
            Await updater.DownloadUpdateAsync(updateUrl)

            ' Install
            SetStatus("Installing update...", Color.Orange)
            Dim result = Await updater.InstallAppUpdateAsync()

            Guna2ProgressIndicator1.Stop()
            Guna2ProgressIndicator1.Visible = False

            If result.Success Then
                MessageBox.Show(result.Message, "Update Complete",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Process.Start(Application.ExecutablePath)
                Environment.Exit(0)
            Else
                MessageBox.Show(result.Message, "Update Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                SetStatus("Update failed. Continuing with current version.", Color.OrangeRed)
                SetUIBusy(False)
            End If

        Catch ex As Exception
            Guna2ProgressIndicator1.Stop()
            Guna2ProgressIndicator1.Visible = False
            MessageBox.Show("Update error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            SetStatus("Update error. Continuing with current version.", Color.OrangeRed)
            SetUIBusy(False)
        End Try
    End Function

    ' ─────────────────────────────────────────────────────────
    ' DATABASE PATCH: Prompt and apply if needed
    ' ─────────────────────────────────────────────────────────
    Private Async Function ApplyDatabasePatchesIfNeededAsync() As Task
        If Not DatabasePatcher.IsDatabaseUpdateAvailable() Then Return

        Dim answer As DialogResult = MessageBox.Show(
            "Database structure changes are required to continue." & vbCrLf & vbCrLf &
            "Apply database update now?",
            "Database Update Required",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If answer = DialogResult.No Then
            MessageBox.Show(
                "The application cannot run without the database update." & vbCrLf & "System will exit.",
                "Mandatory Update", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(0)
        End If

        SetStatus("Applying database patches...", Color.Orange)
        Cursor = Cursors.WaitCursor

        Dim result = Await updater.ApplyDatabasePatchesAsync()

        Cursor = Cursors.Default

        If result.Success Then
            SetStatus("Database updated successfully.", Color.Green)
        Else
            MessageBox.Show(result.Message, "Patch Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SetStatus("Database patch failed. Please contact support.", Color.Red)
        End If
    End Function
    ' ─────────────────────────────────────────────────────────
    ' LOGIN BUTTON: Async SQL authentication
    ' ─────────────────────────────────────────────────────────
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If isOfflineMode Then
            MsgBox("No internet connection. Please use Offline Mode.",
                   vbExclamation + vbOKOnly, "Offline Mode")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtusername.Text) OrElse
           String.IsNullOrWhiteSpace(txtpass.Text) Then
            MsgBox("Please enter your username and password.",
                   vbCritical + vbOKOnly, "System Message")
            Return
        End If

        SetUIBusy(True)
        Guna2ProgressIndicator1.Visible = True
        Guna2ProgressIndicator1.Start()
        SetStatus("Authenticating...", Color.Gray)

        Try
            Dim userRow As DataRow = Await updater.AuthenticateUserAsync(
                txtusername.Text.Trim(), txtpass.Text)

            Guna2ProgressIndicator1.Stop()
            Guna2ProgressIndicator1.Visible = False

            If userRow IsNot Nothing Then
                ' ── Successful Login ──
                login_name = userRow("locationname").ToString()
                login_access = userRow("access").ToString()
                login_username = userRow("username").ToString()
                hold_locationid = userRow("locationid").ToString()
                mdl_variable.IsOfflineMode = False

                MsgBox("Welcome to CFI Oracle Micros Simphony",
                       vbInformation + vbOKOnly, "System Message")
                Me.Hide()
                txtusername.Clear()
                txtpass.Clear()
                frm_dashboard_new.Show()
            Else
                ' ── Failed Login ──
                SetStatus("System Ready  |  " & updater.GetCurrentVersionString(), Color.DimGray)
                SetUIBusy(False)
                MsgBox("Invalid username or password. Please try again.",
                       vbExclamation + vbOKOnly, "Login Failed")
            End If

        Catch ex As Exception
            Guna2ProgressIndicator1.Stop()
            Guna2ProgressIndicator1.Visible = False

            ' Detect network/connection errors → offer offline mode
            Dim msg As String = ex.Message.ToLower()
            If msg.Contains("connection") OrElse msg.Contains("network") OrElse
               msg.Contains("timeout") OrElse msg.Contains("server") Then

                SetStatus("Connection lost.", Color.OrangeRed)
                SetUIBusy(False)

                If MsgBox("Cannot reach the server. Enter Offline Mode?",
                          vbQuestion + vbYesNo, "Connection Lost") = vbYes Then
                    EnterOfflineMode()
                End If
            Else
                SetStatus("Login error.", Color.Red)
                SetUIBusy(False)
                MsgBox("Error: " & ex.Message, vbExclamation + vbOKOnly, "System Message")
            End If
        End Try
    End Sub

    ' ─────────────────────────────────────────────────────────
    ' OFFLINE MODE
    ' ─────────────────────────────────────────────────────────
    Private Sub btnOfflineLogin_Click(sender As Object, e As EventArgs) Handles btnOfflineLogin.Click
        EnterOfflineMode()
    End Sub

    Private Sub EnterOfflineMode()
        Using locationForm As New frm_offline_location()
            If locationForm.ShowDialog() = DialogResult.OK Then
                login_name = locationForm.SelectedLocation
                login_access = OFFLINE_ACCESS
                login_username = OFFLINE_USERNAME
                hold_locationid = locationForm.SelectedLocationID

                mdl_variable.IsOfflineMode = True
                mdl_variable.OfflineLocationName = locationForm.SelectedLocation
                mdl_variable.OfflineLocationID = locationForm.SelectedLocationID

                MsgBox("Welcome to CFI Oracle Micros Simphony (Offline Mode)" & vbCrLf &
                       "Location: " & locationForm.SelectedLocation & vbCrLf &
                       "Note: Some features will be limited until connection is restored.",
                       vbInformation + vbOKOnly, "System Message")
                Me.Hide()
                frm_dashboard_new.Show()
            End If
        End Using
    End Sub

    ' ─────────────────────────────────────────────────────────
    ' UpdateManager Event Handlers
    ' ─────────────────────────────────────────────────────────
    Private Sub OnUpdaterStatusChanged(message As String, color As Color)
        If InvokeRequired Then
            Invoke(Sub() OnUpdaterStatusChanged(message, color))
            Return
        End If
        SetStatus(message, color)
    End Sub

    Private Sub OnUpdaterProgress(percent As Integer)
        If InvokeRequired Then
            Invoke(Sub() OnUpdaterProgress(percent))
            Return
        End If

        ' Show bar on first progress tick
        If Not progressBarUpdate.Visible Then
            progressBarUpdate.Visible = True
            progressBarUpdate.BringToFront()
        End If

        progressBarUpdate.Value = Math.Min(percent, 100)
        SetStatus($"Downloading update... {percent}%", Color.DodgerBlue)

        ' Hide and reset when complete
        If percent >= 100 Then
            SetStatus("Download complete. Installing...", Color.Green)
            Task.Delay(600).ContinueWith(Sub()
                                             If InvokeRequired Then
                                                 Invoke(Sub()
                                                            progressBarUpdate.Visible = False
                                                            progressBarUpdate.Value = 0
                                                        End Sub)
                                             End If
                                         End Sub)
        End If
    End Sub

    ' ─────────────────────────────────────────────────────────
    ' UI HELPERS
    ' ─────────────────────────────────────────────────────────
    Private Sub SetStatus(message As String, color As Color)
        lblstatus.Text = message
        lblstatus.ForeColor = color
        lblstatus.Visible = True
    End Sub

    Private Sub SetUIBusy(busy As Boolean)
        btnLogin.Enabled = Not busy
        txtusername.Enabled = Not busy
        txtpass.Enabled = Not busy
    End Sub

    ' ─────────────────────────────────────────────────────────
    ' SHORTCUTS & MISC
    ' ─────────────────────────────────────────────────────────
    Private Sub frm_login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Dim frm As New frm_setup_database()
            frm.ShowDialog()
        End If
        If e.Control AndAlso e.KeyCode = Keys.O Then EnterOfflineMode()
    End Sub

    Private Sub txtpass_IconRightClick(sender As Object, e As EventArgs) Handles txtpass.IconRightClick
        If txtpass.UseSystemPasswordChar Then
            txtpass.UseSystemPasswordChar = False
            txtpass.IconRight = My.Resources.icons8_invisible_30
        Else
            txtpass.UseSystemPasswordChar = True
            txtpass.IconRight = My.Resources.icons8_eye_30
        End If
    End Sub
    Private Sub frm_login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class