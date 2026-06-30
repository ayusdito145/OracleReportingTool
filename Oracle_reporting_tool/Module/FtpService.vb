Imports FluentFTP
Imports System.IO
Imports System.Text

Module FtpService

    ' ---------------------------------------------------------------------------
    '  Storage path: ftp_config.txt lives beside the running executable.
    '  Format (one entry per line):
    '      Host=ftp.cfi.com.ph
    '      Username=cfiftp@cfi.com.ph
    '      Password=<Base64-encoded>
    ' ---------------------------------------------------------------------------
    Private ReadOnly ConfigPath As String =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ftp_config.txt")

    Private ReadOnly DefaultHost As String = "ftp.cfi.com.ph"
    Private ReadOnly DefaultUsername As String = "cfiftp@cfi.com.ph"
    Private ReadOnly DefaultPassword As String = "9%%0ngTq;vYB@-_g"

    ' ── FtpConfig DTO ──────────────────────────────────────────────────────────
    Public Class FtpConfig
        Public Property Host As String
        Public Property Username As String
        Public Property Password As String
    End Class

    ' ── Read ftp_config.txt ────────────────────────────────────────────────────
    Public Function GetSavedFtpConfig() As FtpConfig
        Dim cfg As New FtpConfig With {
            .Host = DefaultHost,
            .Username = DefaultUsername,
            .Password = DefaultPassword
        }

        If Not File.Exists(ConfigPath) Then Return cfg

        Try
            For Each line As String In File.ReadAllLines(ConfigPath)
                Dim parts = line.Split({"="c}, 2)
                If parts.Length <> 2 Then Continue For

                Dim key = parts(0).Trim()
                Dim val = parts(1).Trim()

                Select Case key.ToLower()
                    Case "host" : cfg.Host = val
                    Case "username" : cfg.Username = val
                    Case "password" : cfg.Password = DecodePassword(val)
                End Select
            Next
        Catch
            ' Return defaults on any read error
        End Try

        Return cfg
    End Function

    ' ── Write ftp_config.txt ───────────────────────────────────────────────────
    Public Sub SaveFtpConfig(config As FtpConfig)
        Dim lines() As String = {
            "Host=" & config.Host,
            "Username=" & config.Username,
            "Password=" & EncodePassword(config.Password)
        }
        File.WriteAllLines(ConfigPath, lines, Encoding.UTF8)
    End Sub

    ' ── Test + Save (called from btnSave) ─────────────────────────────────────
    Public Async Function SaveAndTestAsync(config As FtpConfig) As Task(Of Boolean)
        Return Await Task.Run(Function()
                                  Try
                                      Using client As New FtpClient(config.Host,
                                                                    config.Username,
                                                                    config.Password)
                                          client.Connect()
                                          If client.IsConnected Then
                                              client.GetNameListing()
                                              Return True
                                          End If
                                          Return False
                                      End Using
                                  Catch
                                      Return False
                                  End Try
                              End Function)
    End Function

    ' ── Password helpers (Base64 obfuscation) ─────────────────────────────────
    Private Function EncodePassword(plainText As String) As String
        If String.IsNullOrEmpty(plainText) Then Return String.Empty
        Return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText))
    End Function

    Private Function DecodePassword(encoded As String) As String
        If String.IsNullOrEmpty(encoded) Then Return String.Empty
        Try
            Return Encoding.UTF8.GetString(Convert.FromBase64String(encoded))
        Catch
            Return encoded   ' If not Base64, treat as plain (migration fallback)
        End Try
    End Function

End Module
