Imports System.Configuration
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Imports System.Drawing
Imports WinFont = System.Drawing.Font

Public Class frm__view_variance

    Public Property HoldCheckNumber As String
    Private receiptLines As List(Of String)

#Region "Form Load"

    Private Sub frm__view_variance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Runtime-only Guna2 property
        loader.ProgressColor2 = Color.FromArgb(255, 224, 192)

        ' ListView setup
        ListView1.View         = View.Details
        ListView1.FullRowSelect = False
        ListView1.GridLines    = False
        ListView1.Columns.Add("Receipt", ListView1.Width - 4)
        ListView1.Font         = New WinFont("Courier New", 9, FontStyle.Regular)

        AddHandler Me.Resize, Sub(s, ev)
            If ListView1.Columns.Count > 0 Then
                ListView1.Columns(0).Width = ListView1.Width - 4
            End If
            CenterOverlay()
        End Sub

        ShowOverlay(False)

        If String.IsNullOrEmpty(HoldCheckNumber) Then
            MessageBox.Show("No check number received.", "Variance",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Return
        End If

        ' Show check number in header badge
        lblChkBadge.Text = "Check Number: " & HoldCheckNumber
        UpdateStatus("Loading receipt for check # " & HoldCheckNumber & "...")

        LoadReceiptVarianceAsync()
    End Sub

#End Region

#Region "Load — Async (replaces BackgroundWorker)"

    Public Async Sub LoadReceiptVarianceAsync()
        ShowOverlay(True)

        Try
            Dim chk As String = HoldCheckNumber
            receiptLines = Await Task.Run(Function() cls_menuitem.GetReceipts_Variance(chk))
            BindListView(receiptLines)
            UpdateStatus("Loaded " & receiptLines.Count & " line(s)  ·  Check #: " & HoldCheckNumber)
        Catch ex As Exception
            MessageBox.Show("Error loading receipt:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay(False)
        End Try
    End Sub

    Private Sub BindListView(lines As List(Of String))
        ListView1.BeginUpdate()
        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        ListView1.Columns.Add("Receipt", ListView1.Width - 4)
        ListView1.Font = New WinFont("Courier New", 9, FontStyle.Regular)

        If lines IsNot Nothing AndAlso lines.Count > 0 Then
            For Each line As String In lines
                ListView1.Items.Add(line)
            Next
        Else
            ListView1.Items.Add("No results found.")
        End If

        ListView1.EndUpdate()
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
        loader.Location     = New Point((pnlOverlay.Width  - loader.Width)    \ 2,
                                        (pnlOverlay.Height - loader.Height)   \ 2 - 20)
        lblLoading.Location = New Point((pnlOverlay.Width  - lblLoading.Width) \ 2,
                                         loader.Bottom + 10)
    End Sub

    Private Sub UpdateStatus(msg As String)
        lblStatus.Text = msg
    End Sub

#End Region

End Class
