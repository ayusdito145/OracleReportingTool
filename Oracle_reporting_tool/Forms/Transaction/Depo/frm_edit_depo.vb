Imports Guna.UI2.WinForms

Public Class frm_edit_depo

    Dim _cls As New cls_depo

    Private Class UploadInfo
        Public Property DateDepo As String
        Public Property Deporef As String
        Public Property pettyamount As String
        Public Property BIRamount As String
        Public Property Openamount As String
        Public Property otherdeptamt As String
    End Class

#Region "Form Load"

    Private Sub frm_edit_depo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        SetupNumericTextbox(txtpetty)
        SetupNumericTextbox(txtbir)
        SetupNumericTextbox(txtopensales)
        SetupNumericTextbox(txtotherdept)

        ShowOverlay(False)
        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()
    End Sub

#End Region

#Region "Cancel"

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

#End Region

#Region "Update — Async (replaces BackgroundWorker)"

    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim GetValue As Func(Of Guna2TextBox, String) =
            Function(txt)
                If String.IsNullOrWhiteSpace(txt.Text) Then
                    Return "0"
                Else
                    Return txt.Text.Replace(",", "").Trim()
                End If
            End Function

        Dim info As New UploadInfo With {
            .DateDepo = DTdepo.Text,
            .Deporef = GetValue(txtdepoRef),
            .pettyamount = GetValue(txtpetty),
            .BIRamount = GetValue(txtbir),
            .Openamount = GetValue(txtopensales),
            .otherdeptamt = GetValue(txtotherdept)
        }

        ShowOverlay(True)
        btnUpdate.Enabled = False

        Try
            Await Task.Run(Sub()
                               _cls.update_depo(info.DateDepo, info.Deporef,
                                                info.pettyamount, info.BIRamount,
                                                info.Openamount, info.otherdeptamt)
                           End Sub)

            MsgBox("Update Completed", vbInformation + vbOKOnly, "System Message")

            ' Refresh parent grid
            Dim activeForm As frm_depo = Application.OpenForms.OfType(Of frm_depo)().FirstOrDefault()
            If activeForm IsNot Nothing Then activeForm.RefreshGrid()

            Me.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbCritical, "Error")
        Finally
            ShowOverlay(False)
            btnUpdate.Enabled = True
        End Try
    End Sub

#End Region

#Region "Numeric helpers (preserved)"

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
        txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        AddHandler txt.KeyPress, AddressOf Numeric_KeyPress
        AddHandler txt.Leave, AddressOf Numeric_Leave
    End Sub

    Private Sub txtdepoRef_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdepoRef.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> "."c Then e.Handled = True
    End Sub

#End Region

#Region "Overlay helpers"

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

#End Region

End Class
