Imports System.IO
Imports FluentFTP

Public Class frmViewImage

    Private remoteFilePath As String

    Public Sub New(filePath As String)
        InitializeComponent()
        remoteFilePath = filePath
    End Sub

#Region "Form Load"

    Private Sub frmViewImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progressIndicator.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        ' Show filename in header subtitle
        lblFilename.Text = "File: " & Path.GetFileName(remoteFilePath)

        ShowOverlay(True, "Loading image...")
        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()

        If Not bgWorker.IsBusy Then bgWorker.RunWorkerAsync()
    End Sub

#End Region

#Region "Load image — BackgroundWorker (preserved)"

    Private Sub bgWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorker.DoWork
        Try
            Dim localPath As String = Path.Combine(Path.GetTempPath(), Path.GetFileName(remoteFilePath))
            Dim config As FtpConfig = GetSavedFtpConfig()
            Using client As New FtpClient(config.Host, config.Username, config.Password)
                client.Connect()
                If client.DownloadFile(localPath, remoteFilePath, FtpLocalExists.Overwrite) Then
                    e.Result = localPath
                Else
                    e.Result = Nothing
                End If
            End Using
        Catch ex As Exception
            e.Result = Nothing
        End Try
    End Sub

    Private Sub bgWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorker.RunWorkerCompleted
        ShowOverlay(False)
        If e.Result IsNot Nothing Then
            pbImage.Image = Image.FromFile(e.Result.ToString())
        Else
            MessageBox.Show("Failed to load image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Download — BackgroundWorker (preserved)"

    Private Sub btndownload_Click(sender As Object, e As EventArgs) Handles btndownload.Click
        Try
            Using sfd As New SaveFileDialog()
                sfd.Filter   = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
                sfd.FileName = Path.GetFileName(remoteFilePath)
                If sfd.ShowDialog() = DialogResult.OK Then
                    If Not bgWorkerDownload.IsBusy Then
                        ShowOverlay(True, "Downloading...")
                        btndownload.Enabled = False
                        bgWorkerDownload.RunWorkerAsync(sfd.FileName)
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgWorkerDownload_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgWorkerDownload.DoWork
        Try
            Dim savePath As String = e.Argument.ToString()
            Dim config As FtpConfig = GetSavedFtpConfig()
            Using client As New FtpClient(config.Host, config.Username, config.Password)
                client.Connect()
                If client.DownloadFile(savePath, remoteFilePath, FtpLocalExists.Overwrite) Then
                    e.Result = savePath
                Else
                    e.Result = Nothing
                End If
            End Using
        Catch ex As Exception
            e.Result = Nothing
        End Try
    End Sub

    Private Sub bgWorkerDownload_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgWorkerDownload.RunWorkerCompleted
        ShowOverlay(False)
        btndownload.Enabled = True
        If e.Result IsNot Nothing Then
            MessageBox.Show("Downloaded successfully!" & vbCrLf & "Saved to: " & e.Result.ToString(),
                            "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to download the image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

#End Region

#Region "Re-upload (preserved)"

    Private Sub btnReupload_Click(sender As Object, e As EventArgs) Handles btnReupload.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim newFilePath As String = ofd.FileName
                Try
                    ShowOverlay(True, "Uploading new image...")
                    btnReupload.Enabled = False
                    Dim config As FtpConfig = GetSavedFtpConfig()
                    Using client As New FtpClient(config.Host, config.Username, config.Password)
                        client.Connect()
                        client.UploadFile(newFilePath, remoteFilePath, FtpRemoteExists.Overwrite)
                    End Using
                    If pbImage.Image IsNot Nothing Then pbImage.Image.Dispose()
                    pbImage.Image = Image.FromFile(newFilePath)
                    lblFilename.Text = "File: " & Path.GetFileName(newFilePath)
                    MessageBox.Show("Image re-uploaded successfully.", "Upload Complete",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Upload Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ShowOverlay(False)
                    btnReupload.Enabled = True
                End Try
            End If
        End Using
    End Sub

#End Region

#Region "Close"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

#End Region

#Region "Overlay helpers"

    Private Sub ShowOverlay(show As Boolean, Optional msg As String = "")
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ShowOverlay(show, msg))
            Return
        End If
        If show AndAlso msg <> "" Then lblLoadingImg.Text = msg
        pnlOverlay.Visible = show
        If show Then
            pnlOverlay.BringToFront()
            CenterOverlay()
        End If
    End Sub

    Private Sub CenterOverlay()
        progressIndicator.Location = New System.Drawing.Point(
            (pnlOverlay.Width  - progressIndicator.Width)  \ 2,
            (pnlOverlay.Height - progressIndicator.Height) \ 2 - 20)
        lblLoadingImg.Location = New System.Drawing.Point(
            (pnlOverlay.Width  - lblLoadingImg.Width) \ 2,
             progressIndicator.Bottom + 10)
    End Sub

#End Region

End Class
