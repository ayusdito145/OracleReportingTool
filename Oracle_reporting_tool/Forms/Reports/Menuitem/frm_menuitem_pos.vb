Imports System.ComponentModel
Imports OfficeOpenXml
Imports System.IO

Public Class frm_menuitem_pos

    ' ── State ────────────────────────────────────────────────────────
    Dim cls_menuitem As New cls_menuitem
    Dim resultData   As DataTable

#Region "Form Load"

    Private Sub frm_menuitem_pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Defaults
        dtFrom.Value = DateTime.Today
        dtto.Value   = DateTime.Today

        ' Wire up background worker
        AddHandler BackgroundWorker1.DoWork,            AddressOf BW_DoWork
        AddHandler BackgroundWorker1.RunWorkerCompleted, AddressOf BW_Completed

        ' ── Properties unsafe for VS Designer — set at runtime ──
        loader.ProgressColor2 = Color.FromArgb(255, 224, 192)
        btngenerate.DisabledState.FillColor      = Color.FromArgb(220, 205, 185)
        btngenerate.DisabledState.ForeColor      = Color.FromArgb(180, 155, 120)
        btnExportToExcel.DisabledState.FillColor = Color.FromArgb(140, 175, 145)
        btnExportToExcel.DisabledState.ForeColor = Color.FromArgb(200, 225, 200)

        ' Overlay hidden until work starts
        pnlOverlay.Visible = False

        ' DPI-aware card repositioning on resize
        AddHandler Me.Resize, Sub(s, ev)
            RepositionKpiCards()
            CenterOverlay()
            lblRecordCount.Location  = New Point(pnlToolbar.Width - lblRecordCount.Width - 20, 26)
            lblStatusRight.Location  = New Point(pnlStatus.Width  - lblStatusRight.Width - 16, 10)
        End Sub

        UpdateStatus("Ready — pick a date range and click Generate.")
    End Sub

#End Region

#Region "Generate"
    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        If dtFrom.Value.Date > dtto.Value.Date Then
            MessageBox.Show("'From' date cannot be later than 'To' date.",
                            "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not BackgroundWorker1.IsBusy Then
            ShowOverlay(True)
            btngenerate.Enabled       = False
            btnExportToExcel.Enabled  = False
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BW_DoWork(sender As Object, e As DoWorkEventArgs)
        ' Runs on thread pool — safe to call DB here
        Dim fromDate As Date = dtFrom.Value.Date
        Dim toDate   As Date = dtto.Value.Date
        resultData = cls_menuitem.Getmenuitemdata(fromDate, toDate)
    End Sub

    Private Sub BW_Completed(sender As Object, e As RunWorkerCompletedEventArgs)
        ShowOverlay(False)
        btngenerate.Enabled      = True
        btnExportToExcel.Enabled = True

        If e.Error IsNot Nothing Then
            MessageBox.Show("Error loading data:" & Environment.NewLine & e.Error.Message,
                            "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & e.Error.Message)
            Return
        End If

        LoadGridWithData(resultData)
    End Sub

#End Region

#Region "Grid Binding"

    Private Sub LoadGridWithData(data As DataTable)
        dgvmenuitem.Columns.Clear()
        dgvmenuitem.Rows.Clear()

        ' ── Column definitions ────────────────────────────────────────
        Dim cols() As (key As String, header As String, width As Integer, align As DataGridViewContentAlignment) = {
            ("itemnumber",    "Item No.",        100, DataGridViewContentAlignment.MiddleCenter),
            ("itemname",      "Menu Item Name",  230, DataGridViewContentAlignment.MiddleLeft),
            ("qty",           "Qty Sold",        100, DataGridViewContentAlignment.MiddleCenter),
            ("grossamt",      "Gross Amount",    140, DataGridViewContentAlignment.MiddleRight),
            ("itemdiscount",  "Item Discount",   140, DataGridViewContentAlignment.MiddleRight),
            ("Netsales",      "Net Sales",       140, DataGridViewContentAlignment.MiddleRight),
            ("salestype",     "Sales Type",      140, DataGridViewContentAlignment.MiddleCenter)
        }

        With dgvmenuitem
            For Each col In cols
                Dim c As New DataGridViewTextBoxColumn()
                c.Name    = col.key
                c.HeaderText = col.header
                c.Width   = col.width
                c.ReadOnly = True
                c.SortMode = DataGridViewColumnSortMode.NotSortable
                c.DefaultCellStyle.Alignment = col.align
                .Columns.Add(c)
            Next

            .SelectionMode                            = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows                       = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
            .ThemeStyle.HeaderStyle.BackColor         = Color.FromArgb(255, 224, 192)
            .ThemeStyle.HeaderStyle.ForeColor         = Color.FromArgb(60, 35, 10)
            .ThemeStyle.HeaderStyle.Font              = New Font("Segoe UI Semibold", 9.5!)
            .ThemeStyle.HeaderStyle.HeaightSizeMode   = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .ThemeStyle.HeaderStyle.BorderStyle       = DataGridViewHeaderBorderStyle.Single
            .ThemeStyle.RowsStyle.BackColor           = Color.FromArgb(255, 255, 250)
            .ThemeStyle.RowsStyle.ForeColor           = Color.FromArgb(60, 35, 10)
            .ThemeStyle.RowsStyle.Font                = New Font("Segoe UI", 9.5!)
            .ThemeStyle.RowsStyle.SelectionBackColor  = Color.FromArgb(255, 224, 192)
            .ThemeStyle.RowsStyle.SelectionForeColor  = Color.FromArgb(60, 35, 10)
            .ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 245, 228)
        End With

        ' ── Populate rows & accumulate KPI totals ─────────────────────
        Dim totalQty      As Long    = 0
        Dim totalGross    As Decimal = 0
        Dim totalDiscount As Decimal = 0
        Dim totalNet      As Decimal = 0

        For Each row As DataRow In data.Rows
            Dim qty      As Integer = If(IsDBNull(row("qty")),           0,  CInt(row("qty")))
            Dim gross    As Decimal = If(IsDBNull(row("grossamt")),      0D, CDec(row("grossamt")))
            Dim disc     As Decimal = If(IsDBNull(row("itemdiscount")),  0D, CDec(row("itemdiscount")))
            Dim net      As Decimal = If(IsDBNull(row("Netsales")),      0D, CDec(row("Netsales")))

            dgvmenuitem.Rows.Add(
                row("itemnumber").ToString(),
                row("itemname").ToString(),
                qty.ToString("#,##0"),
                FormatNumber(gross, 2),
                FormatNumber(disc,  2),
                FormatNumber(net,   2),
                row("Salestype").ToString()
            )

            totalQty      += qty
            totalGross    += gross
            totalDiscount += disc
            totalNet      += net
        Next

        ' ── Update KPI cards ──────────────────────────────────────────
        lblTotalQtyVal.Text  = totalQty.ToString("#,##0")
        lblGrossVal.Text     = FormatPeso(totalGross)
        lblDiscountVal.Text  = FormatPeso(totalDiscount)
        lblNetSalesVal.Text  = FormatPeso(totalNet)

        ' ── Record count + status ─────────────────────────────────────
        Dim rc = data.Rows.Count
        lblRecordCount.Text = rc.ToString("#,##0") & " record" & If(rc = 1, "", "s")
        UpdateStatus($"Loaded {rc:#,##0} records  ·  " &
                     $"{dtFrom.Value:MMM dd, yyyy}  –  {dtto.Value:MMM dd, yyyy}  ·  " &
                     $"Last refreshed: {DateTime.Now:hh:mm:ss tt}")

        RepositionKpiCards()
    End Sub

    Private Function FormatPeso(v As Decimal) As String
        Return "P " & v.ToString("#,##0.00")
    End Function

#End Region

#Region "Export"

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        ExportToExcel_EPPlus(dgvmenuitem)
    End Sub

    Private Sub ExportToExcel_EPPlus(dgv As DataGridView)
        If dgv.Rows.Count = 0 Then
            MessageBox.Show("No data to export.", "Export",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter   = "Excel Files (*.xlsx)|*.xlsx"
            sfd.FileName = $"menuitem_report_{dtFrom.Value:yyyyMMdd}_{dtto.Value:yyyyMMdd}.xlsx"

            If sfd.ShowDialog() <> DialogResult.OK Then Return

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial

            Using pkg As New ExcelPackage()
                Dim ws = pkg.Workbook.Worksheets.Add("MenuItem Sales")

                ' ── Title rows ────────────────────────────────────────
                ws.Cells(1, 1).Value = "MenuItem Sales Report"
                ws.Cells(1, 1, 1, dgv.Columns.Count).Merge = True
                ws.Cells(1, 1).Style.Font.Size = 14
                ws.Cells(1, 1).Style.Font.Bold = True

                ws.Cells(2, 1).Value = $"Period: {dtFrom.Value:MMM dd, yyyy}  –  {dtto.Value:MMM dd, yyyy}"
                ws.Cells(2, 1, 2, dgv.Columns.Count).Merge = True

                ' ── Column headers (row 4) ────────────────────────────
                For col = 0 To dgv.Columns.Count - 1
                    Dim cell = ws.Cells(4, col + 1)
                    cell.Value = dgv.Columns(col).HeaderText
                    cell.Style.Font.Bold = True
                    cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                    cell.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 224, 192))
                    cell.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin
                Next

                ' ── Data rows ─────────────────────────────────────────
                For r = 0 To dgv.Rows.Count - 1
                    For col = 0 To dgv.Columns.Count - 1
                        ws.Cells(r + 5, col + 1).Value = dgv.Rows(r).Cells(col).Value?.ToString()
                    Next
                Next

                ' ── KPI summary at bottom ─────────────────────────────
                Dim summaryRow = dgv.Rows.Count + 6
                ws.Cells(summaryRow, 1).Value = "TOTALS"
                ws.Cells(summaryRow, 1).Style.Font.Bold = True
                ws.Cells(summaryRow, 3).Value = lblTotalQtyVal.Text   ' Qty
                ws.Cells(summaryRow, 4).Value = lblGrossVal.Text       ' Gross
                ws.Cells(summaryRow, 5).Value = lblDiscountVal.Text    ' Discount
                ws.Cells(summaryRow, 6).Value = lblNetSalesVal.Text    ' Net Sales

                ws.Cells.AutoFitColumns()
                pkg.SaveAs(New FileInfo(sfd.FileName))
            End Using
        End Using

        MessageBox.Show("Export successful!", "Export to Excel",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

#End Region

#Region "Layout & Overlay Helpers"

    ''' <summary>Evenly space 4 KPI cards across pnlSummary width.</summary>
    Private Sub RepositionKpiCards()
        Dim usable = pnlSummary.Width - 40
        Dim gap    = 14
        Dim w      = (usable - gap * 3) \ 4

        cardTotalQty.Width  = w : cardTotalQty.Location  = New Point(20, 12)
        cardGross.Width     = w : cardGross.Location     = New Point(20 + (w + gap),     12)
        cardDiscount.Width  = w : cardDiscount.Location  = New Point(20 + (w + gap) * 2, 12)
        cardNetSales.Width  = w : cardNetSales.Location  = New Point(20 + (w + gap) * 3, 12)
    End Sub

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
        loader.Location     = New Point((pnlOverlay.Width  - loader.Width)     \ 2,
                                        (pnlOverlay.Height - loader.Height)    \ 2 - 20)
        lblLoading.Location = New Point((pnlOverlay.Width  - lblLoading.Width) \ 2,
                                         loader.Bottom + 10)
    End Sub

    Private Sub UpdateStatus(msg As String)
        lblLastRefresh.Text = msg
    End Sub

#End Region

#Region "Menu Navigation"

    Private Sub MenuitemSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuitemSummaryToolStripMenuItem.Click
        frm_dashboard_new.loadform(New frm_menuitem_summary())
    End Sub

#End Region

End Class
