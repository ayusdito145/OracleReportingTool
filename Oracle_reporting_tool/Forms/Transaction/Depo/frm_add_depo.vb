Imports System.IO
Imports FluentFTP
Imports Guna.UI2.WinForms
Imports System.Threading
Imports System.Threading.Tasks

Public Class frm_add_depo

    Private filePath As String
    Dim _cls As New cls_depo
    Private _cts As CancellationTokenSource

    Private Class UploadInfo
        Public Property FilePath As String
        Public Property DepoRef As String
        Public Property DateDepo As Date
        Public Property DateFrom As Date
        Public Property POSamount As String
        Public Property Depoamount As String
        Public Property pettyamount As String
        Public Property BIRamount As String
        Public Property Openamount As String
        Public Property otherdeptamt As String
        Public Property Filename As String
    End Class

#Region "Form Load"

    Private Sub frm_add_depo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        SetupNumericTextbox(txtpos)
        SetupNumericTextbox(txtdepo)
        SetupNumericTextbox(txtpetty)
        SetupNumericTextbox(txtbir)
        SetupNumericTextbox(txtopensales)
        SetupNumericTextbox(txtotherdept)

        lblstatus.Visible = False
        ShowOverlay(False)

        dtfrom.Value = Date.Today
        dtfrom.MaxDate = Date.Today
        DTdepo.Value = Date.Today
        DTdepo.MaxDate = Date.Today

        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()
    End Sub

#End Region

#Region "Browse"

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff"
        If ofd.ShowDialog() = DialogResult.OK Then
            filePath = ofd.FileName
            txtfilename.Text = Path.GetFileName(filePath)
        End If
    End Sub

#End Region

#Region "Save — Async FTP upload"

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' ── Validation 1: POS and Deposit amounts must not be blank or zero ──
        Dim posVal As Decimal = 0
        Dim depoVal As Decimal = 0

        If String.IsNullOrWhiteSpace(txtdepoRef.Text) Then
            MsgBox("Deposit Ref# is required",
                   vbCritical + vbOKOnly, "Validation Error")
            txtdepoRef.Focus()
            Return
        End If
        If String.IsNullOrWhiteSpace(txtpos.Text) OrElse
           Not Decimal.TryParse(txtpos.Text.Replace(",", ""), posVal) OrElse posVal = 0 Then
            MsgBox("Depo Amount is required and must be entry in ROF.",
                   vbCritical + vbOKOnly, "Validation Error")
            txtpos.Focus()
            Return
        End If

        ' ── Validation 2: A file must be selected ────────────────────────────
        If String.IsNullOrEmpty(filePath) Then
            MsgBox("Please select a file first.", vbCritical + vbOKOnly, "Validation Error")
            Return
        End If

        ' ── Validation 3: Business date must not already exist in the DB ─────
        If Await _cls.IsBusinessDateExists(dtfrom.Value.Date, login_name) Then
            MessageBox.Show("This Business Date is already saved.",
                            "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim GetValue As Func(Of Guna2TextBox, String) =
            Function(txt) If(String.IsNullOrWhiteSpace(txt.Text), "0", txt.Text)

        Dim uploadInfo As New UploadInfo With {
            .FilePath = filePath,
            .DateFrom = dtfrom.Value.Date,
            .DateDepo = DTdepo.Value.Date,
            .DepoRef = GetValue(txtdepoRef),
            .POSamount = GetValue(txtpos),
            .Depoamount = GetValue(txtdepo),
            .pettyamount = GetValue(txtpetty),
            .BIRamount = GetValue(txtbir),
            .Openamount = GetValue(txtopensales),
            .otherdeptamt = GetValue(txtotherdept),
            .Filename = txtfilename.Text
        }

        _cts = New CancellationTokenSource()
        Try
            ToggleUI(False)
            ShowOverlay(True)
            SetStatus("Connecting to FTP...", System.Drawing.Color.FromArgb(60, 120, 60))

            Await UploadAndSaveAsync(uploadInfo, _cts.Token)

            MsgBox("Upload Completed", vbInformation + vbOKOnly, "System Message")
            Me.Close()

        Catch ex As OperationCanceledException
            SetStatus("Upload Cancelled", System.Drawing.Color.FromArgb(160, 80, 20))
            MsgBox("Upload Cancelled", vbExclamation, "System Message")

        Catch ex As Exception
            SetStatus("Error: " & ex.Message, System.Drawing.Color.FromArgb(160, 40, 40))
            MsgBox(ex.Message, vbCritical)

        Finally
            ShowOverlay(False)
            ToggleUI(True)
        End Try
    End Sub

    Private Async Function UploadAndSaveAsync(info As UploadInfo, token As CancellationToken) As Task
        Dim remotePath As String = "/" & Path.GetFileName(info.FilePath)
        Dim config As FtpConfig = GetSavedFtpConfig()

        Using client As New AsyncFtpClient(config.Host, config.Username, config.Password)
            Await client.Connect(token)

            ' ── Validation 4: Check if file already exists on FTP server ─────
            SetStatus("Checking FTP for existing file...", System.Drawing.Color.FromArgb(60, 100, 160))
            Dim fileExists As Boolean = Await client.FileExists(remotePath, token)
            If fileExists Then
                Throw New Exception(
                    $"The file ""{Path.GetFileName(info.FilePath)}"" already exists on the FTP server." &
                    Environment.NewLine & "Please rename the file or choose a different one.")
            End If

            Dim progressHandler As New Progress(Of FtpProgress)(
                Sub(p As FtpProgress)
                    If token.IsCancellationRequested Then Throw New OperationCanceledException()
                    SetStatus("Uploading... " & p.Progress.ToString("0") & "%",
                              System.Drawing.Color.FromArgb(60, 120, 60))
                    If Me.InvokeRequired Then
                        Me.Invoke(Sub() lblLoading.Text = "Uploading... " & p.Progress.ToString("0") & "%")
                    Else
                        lblLoading.Text = "Uploading... " & p.Progress.ToString("0") & "%"
                    End If
                End Sub)

            Dim status As FtpStatus = Await client.UploadFile(
                localPath:=info.FilePath,
                remotePath:=remotePath,
                existsMode:=FtpRemoteExists.NoCheck,   ' Safe — we already checked above
                createRemoteDir:=True,
                verifyOptions:=FtpVerify.None,
                progress:=progressHandler,
                token:=token)

            If status <> FtpStatus.Success Then Throw New Exception("Upload failed.")
            token.ThrowIfCancellationRequested()

            SetStatus("Saving record...", System.Drawing.Color.FromArgb(60, 120, 60))
            Await Task.Run(Sub()
                               _cls.save_depo(info.DateFrom, info.DateDepo, info.DepoRef,
                                              info.POSamount, info.Depoamount, info.pettyamount,
                                              info.BIRamount, info.Openamount, info.otherdeptamt,
                                              info.Filename)
                           End Sub, CancellationToken.None)

            Await client.Disconnect(CancellationToken.None)
        End Using
    End Function

#End Region

#Region "Cancel"

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If _cts IsNot Nothing Then _cts.Cancel()
        Me.Close()
    End Sub

#End Region

#Region "Date changed — auto-load POS amounts (preserved)"

    Private Async Sub dtfrom_ValueChanged(sender As Object, e As EventArgs) Handles dtfrom.ValueChanged
        Try
            Dim result = Await _cls.loadPOSamt(dtfrom.Value.Date)
            txtpos.Text = result.Item1.ToString("N2")
            txtdepo.Text = result.Item2.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Error loading amounts: " & ex.Message)
            txtpos.Text = "0.00"
            txtdepo.Text = "0.00"
        End Try
    End Sub

#End Region

#Region "Numeric input helpers (preserved)"

    Private Sub ToggleUI(enable As Boolean)
        dtfrom.Enabled = enable
        DTdepo.Enabled = enable
        txtdepoRef.Enabled = enable
        txtpetty.Enabled = enable
        txtbir.Enabled = enable
        txtopensales.Enabled = enable
        txtotherdept.Enabled = enable
        txtfilename.Enabled = enable
        btnBrowse.Enabled = enable
        btnSave.Enabled = enable
    End Sub

    Private Sub Numeric_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> "."c Then e.Handled = True
        Dim txt = CType(sender, Guna2TextBox)
        If e.KeyChar = "."c AndAlso txt.Text.Contains(".") Then e.Handled = True
    End Sub

    Private Sub Numeric_Leave(sender As Object, e As EventArgs)
        Dim txt = CType(sender, Guna2TextBox)
        Dim value As Decimal
        If Decimal.TryParse(txt.Text.Replace(",", ""), value) Then
            txt.Text = value.ToString("N2")
        End If
    End Sub

    Private Sub SetupNumericTextbox(txt As Guna2TextBox)
        txt.Text = "0.00"
        txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        AddHandler txt.KeyPress, AddressOf Numeric_KeyPress
        AddHandler txt.Leave, AddressOf Numeric_Leave
    End Sub

#End Region

#Region "Overlay, Status helpers"

    Private Sub ShowOverlay(show As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ShowOverlay(show))
            Return
        End If
        pnlOverlay.Visible = show
        If show Then
            pnlOverlay.BringToFront()
            CenterOverlay()
        End If
    End Sub

    Private Sub CenterOverlay()
        loader.Location = New System.Drawing.Point(
            (pnlOverlay.Width - loader.Width) \ 2,
            (pnlOverlay.Height - loader.Height) \ 2 - 20)
        lblLoading.Location = New System.Drawing.Point(
            (pnlOverlay.Width - lblLoading.Width) \ 2,
             loader.Bottom + 10)
    End Sub

    Private Sub SetStatus(msg As String, color As System.Drawing.Color)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() SetStatus(msg, color))
            Return
        End If
        lblstatus.Text = msg
        lblstatus.ForeColor = color
        lblstatus.Visible = True
    End Sub

#End Region

End Class
