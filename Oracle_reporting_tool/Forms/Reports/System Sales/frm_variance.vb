Imports System.IO

Public Class frm_variance

    Private _resultData As DataTable = Nothing
    Private _cls As New cls_menuitem

#Region "Form Load"

    Private Sub frm_variance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Runtime-only Guna2 property — avoids Designer E_INVALIDARG
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)
        dtFrom.Value = Date.Today
        dtTo.Value = Date.Today
        ApplyGridTheme()
        ShowOverlay(False)
        UpdateStatus("Ready — select a date range and click Filter.")
        LoadVarianceAsync()
        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()
    End Sub

#End Region

#Region "Load data — Async (replaces BackgroundWorker)"

    Private Async Sub LoadVarianceAsync()
        Dim fromDate As Date = dtFrom.Value.Date
        Dim toDate As Date = dtTo.Value.Date


        ShowOverlay(True)
        btnRefresh.Enabled = False
        lblRecCount.Text = ""
        UpdateStatus("Loading variance data for " &
                     fromDate.ToString("MMM dd, yyyy"))

        Try
            _resultData = Await Task.Run(Function() _cls.Getvariance(fromDate, toDate))
            LoadGridWithData(_resultData)

            Dim count As Integer = If(_resultData IsNot Nothing, _resultData.Rows.Count, 0)
            lblRecCount.Text = count & " record(s)"
            UpdateStatus("Loaded " & count & " record(s)  ·  " &
                         fromDate.ToString("MMM dd, yyyy") + toDate.ToString("MMM dd, yyyy") &
                         "  ·  Double-click a row to view the full receipt.")
        Catch ex As Exception
            MessageBox.Show("Error loading variance data:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay(False)
            btnRefresh.Enabled = True
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadVarianceAsync()
    End Sub

#End Region

#Region "Grid binding"

    Private Sub LoadGridWithData(data As DataTable)
        dgvvariance.SuspendLayout()
        dgvvariance.Columns.Clear()
        dgvvariance.Rows.Clear()

        With dgvvariance
            ' ── Columns ──────────────────────────────────────────────
            .Columns.Add("CheckNumber", "Check Number")
            .Columns.Add("BusinessDate", "Business Date")
            .Columns.Add("gross", "Gross Sales (Net + Tax)")
            .Columns.Add("Total_Tender", "Total Tender")
            .Columns.Add("Variance", "Variance")

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            ' Column widths — distribute to fill
            Dim colW As Integer = Math.Max(140, (dgvvariance.Width - 4) \ 5)
            For i As Integer = 0 To .ColumnCount - 1
                .Columns(i).Width = colW
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(i).ReadOnly = True
            Next

            ' Amount columns right-align
            .Columns("gross").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Total_Tender").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Variance").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns("Variance").Width = 110
            ApplyGridTheme()
        End With

        If data IsNot Nothing Then
            For Each row As DataRow In data.Rows
                Dim gross As Decimal = If(IsDBNull(row("gross")), 0D, CDec(row("gross")))
                Dim tender As Decimal = If(IsDBNull(row("Total_Tender")), 0D, CDec(row("Total_Tender")))
                Dim variance As Decimal = If(IsDBNull(row("Variance")), 0D, CDec(row("Variance")))

                Dim idx As Integer = dgvvariance.Rows.Add(
                    row("CheckNumber").ToString(),
                    CDate(row("BusinessDate")).ToString("yyyy-MM-dd"),
                    FormatNumber(gross, 2),
                    FormatNumber(tender, 2),
                    FormatNumber(variance, 2)
                )

                ' Highlight non-zero variance rows — amber text for positive, red for negative
                If variance <> 0D Then
                    Dim varCell As DataGridViewCell = dgvvariance.Rows(idx).Cells("Variance")
                    varCell.Style.ForeColor = If(variance > 0D,
                        System.Drawing.Color.FromArgb(180, 100, 20),
                        System.Drawing.Color.FromArgb(180, 50, 50))
                    varCell.Style.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
                End If
            Next
        End If

        dgvvariance.ResumeLayout()
    End Sub

    ''' <summary>
    ''' Grid palette — moved out of Designer to avoid ThemeStyle E_INVALIDARG.
    ''' </summary>
    Private Sub ApplyGridTheme()
        With dgvvariance
            .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
            .ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
            .ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
            .ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            .ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single
            .ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            .ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(255, 255, 250)
            .ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(40, 25, 8)
            .ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
            .ThemeStyle.RowsStyle.Height = 32
            .ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 224, 192)
            .ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
            .ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single

            .ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 230)
            .ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(40, 25, 8)

            .ThemeStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 235)
            .ThemeStyle.GridColor = System.Drawing.Color.FromArgb(230, 195, 155)
            .ThemeStyle.ReadOnly = False
        End With
    End Sub

#End Region

#Region "Search / Filter — date range is applied on btnRefresh click (no live filter needed)"
    ' Date pickers drive the query directly via LoadVarianceAsync().
    ' No in-memory filter is required; each Filter click re-fetches from the DB
    ' with the selected BusinessDate range passed to cls_menuitem.Getvariance().
    '
    ' NOTE: If cls_menuitem.Getvariance() does not yet accept date parameters,
    ' add Overload:  Function Getvariance(fromDate As Date, toDate As Date) As DataTable
    ' and apply:    WHERE BusinessDate BETWEEN @from AND @to  in the SQL.
#End Region

#Region "Row interaction (preserved exactly)"

    ''' <summary>
    ''' Double-click → open frm__view_variance with the selected check number.
    ''' </summary>
    Private Sub dgvvariance_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvvariance.CellMouseDoubleClick
        If dgvvariance.CurrentRow Is Nothing Then Return
        Dim f As New frm__view_variance()
        f.HoldCheckNumber = dgvvariance.CurrentRow.Cells(0).Value.ToString()
        f.Show()
    End Sub

    ''' <summary>
    ''' Single click — pre-loads check number (original behaviour preserved).
    ''' </summary>
    Private Sub dgvvariance_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvvariance.CellMouseClick
        If dgvvariance.CurrentRow Is Nothing Then Return
        Dim f As New frm__view_variance()
        f.HoldCheckNumber = dgvvariance.CurrentRow.Cells(0).Value.ToString()
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

    Private Sub UpdateStatus(msg As String)
        lblStatus.Text = msg
    End Sub

#End Region

End Class
