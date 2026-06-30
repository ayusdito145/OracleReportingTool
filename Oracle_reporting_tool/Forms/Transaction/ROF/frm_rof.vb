Imports System.Threading
Imports System.Threading.Tasks
Imports System.Drawing
Imports System.Configuration
Imports System.Data.SqlClient

Public Class frm_rof

    Private addRofForm As frm_add_rof
    Private _cls As New cls_rof
    Private _cts As CancellationTokenSource

#Region "Form Load"

    Private Sub frm_rof_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader1.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)
        loader2.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        ApplyGridTheme(dgvsum_rof)
        ApplyGridTheme(dgvrof_cash)
        ApplyGridTheme(dgvrof_noncash)

        ShowOverlay1(False)
        ShowOverlay2(False)

        Dim today As Date = Date.Today
        dtFrom.Value = today
        dtFrom.MaxDate = today
        dtTo.Value = today
        dtTo.MaxDate = today
        dtp_busidate.Value = today
        dtp_busidate.MaxDate = today

        UpdateStatus("Ready — select a date range or business date and load the report.")
        AddHandler Me.Resize, Sub(s, ev)
                                  CenterOverlay(pnlOverlay1, loader1, lblLoading1)
                                  CenterOverlay(pnlOverlay2, loader2, lblLoading2)
                              End Sub
    End Sub

#End Region

#Region "Tab 1 — Summary ROF  (btngenerate — previously wired to nothing)"

    Private Async Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        ShowOverlay1(True)
        SetTabButtonsEnabled(False)
        UpdateStatus("Generating summary  ·  " &
                     dtFrom.Value.ToString("MMM dd, yyyy") & " – " &
                     dtTo.Value.ToString("MMM dd, yyyy") & "...")
        Try
            Dim dt As DataTable = Await Task.Run(Function() _cls.loadROFSummary(dtFrom.Value.Date, dtTo.Value.Date))
            LoadSummaryGrid(dt)   ' status updated inside LoadSummaryGrid
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay1(False)
            SetTabButtonsEnabled(True)
        End Try
    End Sub

    Private Sub LoadSummaryGrid(data As DataTable)
        dgvsum_rof.Columns.Clear()
        dgvsum_rof.Rows.Clear()

        If data Is Nothing OrElse data.Rows.Count = 0 Then
            UpdateStatus("No summary records found for the selected date range.")
            Return
        End If

        With dgvsum_rof
            .Columns.Add("busidate", "Business Date")
            .Columns.Add("netsales_vat", "Net Sales w/ VAT")
            .Columns.Add("vat", "VAT")
            .Columns.Add("netsales", "Net Sales")
            .Columns.Add("gc_sales", "GC / Srvc Charge")
            .Columns.Add("cash", "Cash Remitted")
            .Columns.Add("noncash", "Non-Cash Remitted")
            .Columns.Add("variance", "Variance")
            .Columns.Add("cash_remarks", "Cash Remarks")
            .Columns.Add("noncash_remarks", "Non-Cash Remarks")

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To .ColumnCount - 1
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(i).ReadOnly = True
                .Columns(i).Width = 148
            Next

            ' Numeric columns — standard width
            .Columns("busidate").Width = 120
            .Columns("netsales_vat").Width = 155
            .Columns("netsales").Width = 140
            ' Remarks columns — wide, left-aligned
            .Columns("cash_remarks").Width = 300
            .Columns("cash_remarks").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns("cash_remarks").DefaultCellStyle.WrapMode = DataGridViewTriState.True
            .Columns("noncash_remarks").Width = 300
            .Columns("noncash_remarks").DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            .Columns("noncash_remarks").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        End With

        ApplyGridTheme(dgvsum_rof)
        dgvsum_rof.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' ── Accumulators for TOTAL row ──────────────────────────────
        Dim sumNetsalesVat As Decimal = 0
        Dim sumVat As Decimal = 0
        Dim sumNetsales As Decimal = 0
        Dim sumGcSales As Decimal = 0
        Dim sumCash As Decimal = 0
        Dim sumNonCash As Decimal = 0
        Dim sumVariance As Decimal = 0

        For Each row As DataRow In data.Rows
            Dim netsalesVat As Decimal = If(IsDBNull(row("netsales_vat")), 0D, CDec(row("netsales_vat")))
            Dim vat As Decimal = If(IsDBNull(row("vat")), 0D, CDec(row("vat")))
            Dim netsales As Decimal = If(IsDBNull(row("netsales")), 0D, CDec(row("netsales")))
            Dim gcSales As Decimal = If(IsDBNull(row("gc_sales")), 0D, CDec(row("gc_sales")))
            Dim cash As Decimal = If(IsDBNull(row("cash")), 0D, CDec(row("cash")))
            Dim noncash As Decimal = If(IsDBNull(row("noncash")), 0D, CDec(row("noncash")))
            Dim variance As Decimal = If(IsDBNull(row("variance")), 0D, CDec(row("variance")))
            Dim cashRem As String = If(IsDBNull(row("cash_remarks")), "", row("cash_remarks").ToString())
            Dim nonCashRem As String = If(IsDBNull(row("noncash_remarks")), "", row("noncash_remarks").ToString())

            Dim idx As Integer = dgvsum_rof.Rows.Add(
                Convert.ToDateTime(row("busidate")).ToString("MM/dd/yyyy"),
                FormatNumber(netsalesVat, 2),
                FormatNumber(vat, 2),
                FormatNumber(netsales, 2),
                FormatNumber(gcSales, 2),
                FormatNumber(cash, 2),
                FormatNumber(noncash, 2),
                FormatNumber(variance, 2),
                cashRem,
                nonCashRem
            )
            ColorVarianceCell(dgvsum_rof.Rows(idx).Cells("variance"), variance)

            sumNetsalesVat += netsalesVat
            sumVat += vat
            sumNetsales += netsales
            sumGcSales += gcSales
            sumCash += cash
            sumNonCash += noncash
            sumVariance += variance
        Next

        ' ── TOTAL row ───────────────────────────────────────────────
        Dim totalIdx As Integer = dgvsum_rof.Rows.Add(
            "TOTAL",
            FormatNumber(sumNetsalesVat, 2),
            FormatNumber(sumVat, 2),
            FormatNumber(sumNetsales, 2),
            FormatNumber(sumGcSales, 2),
            FormatNumber(sumCash, 2),
            FormatNumber(sumNonCash, 2),
            FormatNumber(sumVariance, 2),
            "", ""
        )
        With dgvsum_rof.Rows(totalIdx)
            .DefaultCellStyle = BuildTotalRowStyle()
            .ReadOnly = True
        End With
        ColorVarianceCell(dgvsum_rof.Rows(totalIdx).Cells("variance"), sumVariance)

        UpdateStatus("Summary loaded  ·  " & data.Rows.Count & " day(s).")
    End Sub

#End Region

#Region "Tab 2 — Details ROF"

    Private Sub dtp_busidate_ValueChanged(sender As Object, e As EventArgs) Handles dtp_busidate.ValueChanged
        If addRofForm IsNot Nothing AndAlso Not addRofForm.IsDisposed Then
            addRofForm.BusinessDate = dtp_busidate.Value.Date
        End If
    End Sub

    Private Async Sub btnGenerateROF_Click(sender As Object, e As EventArgs) Handles btnGenerateROF.Click
        Await ReloadROFAsync()
    End Sub

    Private Async Function ReloadROFAsync() As Task
        _cts?.Cancel()
        _cts = New CancellationTokenSource()
        Dim token = _cts.Token

        ShowOverlay2(True)
        SetTabButtonsEnabled(False)
        UpdateStatus("Loading ROF details for " & dtp_busidate.Value.ToString("MMMM dd, yyyy") & "...")

        Try
            Dim data1 As DataTable = Await _cls.loadROFCash(dtp_busidate.Value.Date)
            Dim data2 As DataTable = Await _cls.loadROFNonCash(dtp_busidate.Value.Date)
            If token.IsCancellationRequested Then Return

            LoadGridWithCashData(data1)
            LoadGridWithTenderData(data2)

            Dim cashRows As Integer = If(dgvrof_cash.Rows.Count > 1, dgvrof_cash.Rows.Count - 1, 0)
            Dim nonCashRows As Integer = If(dgvrof_noncash.Rows.Count > 1, dgvrof_noncash.Rows.Count - 1, 0)
            UpdateStatus($"ROF loaded  ·  {cashRows} cash cashier(s)  ·  {nonCashRows} tender type(s).")

        Catch ex As OperationCanceledException
            ' Silently ignore
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay2(False)
            SetTabButtonsEnabled(True)
        End Try
    End Function

    Private Sub btnOpenAddRof_Click(sender As Object, e As EventArgs) Handles btnAdd_Rof.Click
        If addRofForm Is Nothing OrElse addRofForm.IsDisposed Then
            addRofForm = New frm_add_rof()
            addRofForm.BusinessDate = dtp_busidate.Value.Date
            AddHandler addRofForm.RofFormClosed, AddressOf OnAddRofClosed
            addRofForm.Show()
        Else
            addRofForm.BringToFront()
        End If
    End Sub

    Private Sub OnAddRofClosed()
        ' Refresh details grid when the Add form closes
        ReloadROFAsync()
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim busiDate As Date = dtp_busidate.Value.Date

        If MessageBox.Show(
            "Delete ALL ROF records for " & busiDate.ToString("MMMM dd, yyyy") & " ?" &
            Environment.NewLine & "This cannot be undone.",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If

        ShowOverlay2(True)
        SetTabButtonsEnabled(False)
        UpdateStatus("Deleting ROF records for " & busiDate.ToString("MMMM dd, yyyy") & "...")

        Try
            Await Task.Run(Sub() DeleteROF(busiDate))
            dgvrof_cash.Rows.Clear()
            dgvrof_noncash.Rows.Clear()
            UpdateStatus("ROF records deleted for " & busiDate.ToString("MMMM dd, yyyy") & ".")
            MessageBox.Show("ROF records successfully deleted.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Delete error — " & ex.Message)
        Finally
            ShowOverlay2(False)
            SetTabButtonsEnabled(True)
        End Try
    End Sub

    ''' <summary>Background-safe — no UI access.</summary>
    Private Sub DeleteROF(busiDate As Date)
        Dim cs As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
        Using conn As New SqlConnection(cs)
            conn.Open()
            Using tran As SqlTransaction = conn.BeginTransaction()
                Try
                    ' Delete cash details
                    Using cmd As New SqlCommand(
                        "DELETE d FROM dts_rof_cash d
                         INNER JOIN dts_rof_header h ON d.rof_id = h.rof_id
                         WHERE CAST(h.busidate AS DATE) = @businessdate", conn, tran)
                        cmd.Parameters.AddWithValue("@businessdate", busiDate)
                        cmd.ExecuteNonQuery()
                    End Using
                    ' Delete non-cash details
                    Using cmd As New SqlCommand(
                        "DELETE d FROM dts_rof_noncash d
                         INNER JOIN dts_rof_header h ON d.rof_id = h.rof_id
                         WHERE CAST(h.busidate AS DATE) = @businessdate", conn, tran)
                        cmd.Parameters.AddWithValue("@businessdate", busiDate)
                        cmd.ExecuteNonQuery()
                    End Using
                    ' Delete header
                    Using cmd As New SqlCommand(
                        "DELETE FROM dts_rof_header
                         WHERE CAST(busidate AS DATE) = @businessdate", conn, tran)
                        cmd.Parameters.AddWithValue("@businessdate", busiDate)
                        cmd.ExecuteNonQuery()
                    End Using
                    tran.Commit()
                Catch
                    tran.Rollback()
                    Throw
                End Try
            End Using
        End Using
    End Sub

#End Region

#Region "Grid load — Cash (Tab 2, preserved + tweaked)"

    Private Sub LoadGridWithCashData(data As DataTable)
        dgvrof_cash.Columns.Clear()
        dgvrof_cash.Rows.Clear()

        With dgvrof_cash
            .Columns.Add("cashiername", "Cashier Name")
            .Columns.Add("posamt", "POS Amount")
            .Columns.Add("actualamt", "Actual Amount")
            .Columns.Add("colVariance", "Variance")
            .Columns.Add("remarks", "Remarks")
            .Columns.Add("mod", "MOD")

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To .ColumnCount - 1
                .Columns(i).Width = 150
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(i).ReadOnly = True
            Next
            .Columns("remarks").Width = 350
            .Columns("mod").Width = 200
        End With

        ApplyGridTheme(dgvrof_cash)

        For Each row As DataRow In data.Rows
            Dim posAmt As Decimal = If(IsDBNull(row("posamt")), 0D, CDec(row("posamt")))
            Dim actAmt As Decimal = If(IsDBNull(row("actualamt")), 0D, CDec(row("actualamt")))
            Dim variance As Decimal = actAmt - posAmt
            Dim idx As Integer = dgvrof_cash.Rows.Add(
                row("cashiername").ToString(),
                FormatNumber(posAmt, 2),
                FormatNumber(actAmt, 2),
                FormatNumber(variance, 2),
                row("remarks").ToString(),
                row("mod").ToString()
            )
            ColorVarianceCell(dgvrof_cash.Rows(idx).Cells("colVariance"), variance)
        Next
        ComputeSubtotalCash()
    End Sub

    Private Sub ComputeSubtotalCash()
        ' Remove existing TOTAL row
        If dgvrof_cash.Rows.Count > 0 Then
            Dim last As Integer = dgvrof_cash.Rows.Count - 1
            If dgvrof_cash.Rows(last).Cells("cashiername").Value?.ToString() = "TOTAL" Then
                dgvrof_cash.Rows.RemoveAt(last)
            End If
        End If

        Dim totalPOS As Decimal = 0, totalActual As Decimal = 0, totalVar As Decimal = 0
        For Each row As DataGridViewRow In dgvrof_cash.Rows
            If row.IsNewRow Then Continue For
            Dim v1 As Decimal, v2 As Decimal, v3 As Decimal
            Decimal.TryParse(Convert.ToString(row.Cells("posamt").Value), v1)
            Decimal.TryParse(Convert.ToString(row.Cells("actualamt").Value), v2)
            Decimal.TryParse(Convert.ToString(row.Cells("colVariance").Value), v3)
            totalPOS += v1
            totalActual += v2
            totalVar += v3
        Next

        Dim idx As Integer = dgvrof_cash.Rows.Add()
        With dgvrof_cash.Rows(idx)
            .Cells("cashiername").Value = "TOTAL"
            .Cells("posamt").Value = FormatNumber(totalPOS, 2)
            .Cells("actualamt").Value = FormatNumber(totalActual, 2)
            .Cells("colVariance").Value = FormatNumber(totalVar, 2)
            .Cells("remarks").Value = ""
            .Cells("mod").Value = ""
            .DefaultCellStyle = BuildTotalRowStyle()
            .ReadOnly = True
        End With
        ColorVarianceCell(dgvrof_cash.Rows(idx).Cells("colVariance"), totalVar)
    End Sub

#End Region

#Region "Grid load — Non-Cash (Tab 2, preserved + tweaked)"

    Private Sub LoadGridWithTenderData(data As DataTable)
        dgvrof_noncash.Columns.Clear()
        dgvrof_noncash.Rows.Clear()

        With dgvrof_noncash
            .Columns.Add("tendername", "Tender Name")
            .Columns.Add("tenderamt", "POS Amount")
            .Columns.Add("actualtender", "Actual Amount")
            .Columns.Add("colVariance", "Variance")
            .Columns.Add("remarks", "Remarks")

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To .ColumnCount - 1
                .Columns(i).Width = 150
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(i).ReadOnly = True
            Next
            .Columns("remarks").Width = 350
        End With

        ApplyGridTheme(dgvrof_noncash)

        For Each row As DataRow In data.Rows
            Dim posAmt As Decimal = If(IsDBNull(row("tenderamt")), 0D, CDec(row("tenderamt")))
            Dim actAmt As Decimal = If(IsDBNull(row("actualtender")), 0D, CDec(row("actualtender")))
            Dim variance As Decimal = actAmt - posAmt
            Dim idx As Integer = dgvrof_noncash.Rows.Add(
                row("tendername").ToString(),
                FormatNumber(posAmt, 2),
                FormatNumber(actAmt, 2),
                FormatNumber(variance, 2),
                row("remarks").ToString()
            )
            ColorVarianceCell(dgvrof_noncash.Rows(idx).Cells("colVariance"), variance)
        Next
        ComputeSubtotalNonCash()
    End Sub

    Private Sub ComputeSubtotalNonCash()
        ' Remove existing TOTAL row
        For i As Integer = dgvrof_noncash.Rows.Count - 1 To 0 Step -1
            If dgvrof_noncash.Rows(i).IsNewRow Then Continue For
            If dgvrof_noncash.Rows(i).Cells("tendername").Value?.ToString() = "TOTAL" Then
                dgvrof_noncash.Rows.RemoveAt(i)
                Exit For
            End If
        Next

        Dim totalPOS As Decimal = 0, totalActual As Decimal = 0, totalVar As Decimal = 0
        For Each row As DataGridViewRow In dgvrof_noncash.Rows
            If row.IsNewRow Then Continue For
            Dim v1 As Decimal, v2 As Decimal, v3 As Decimal
            Decimal.TryParse(Convert.ToString(row.Cells("tenderamt").Value), v1)
            Decimal.TryParse(Convert.ToString(row.Cells("actualtender").Value), v2)
            Decimal.TryParse(Convert.ToString(row.Cells("colVariance").Value), v3)
            totalPOS += v1
            totalActual += v2
            totalVar += v3
        Next

        Dim insertIndex As Integer = dgvrof_noncash.Rows.Count
        dgvrof_noncash.Rows.Insert(insertIndex)
        With dgvrof_noncash.Rows(insertIndex)
            .Cells("tendername").Value = "TOTAL"
            .Cells("tenderamt").Value = FormatNumber(totalPOS, 2)
            .Cells("actualtender").Value = FormatNumber(totalActual, 2)
            .Cells("colVariance").Value = FormatNumber(totalVar, 2)
            .Cells("remarks").Value = ""
            .DefaultCellStyle = BuildTotalRowStyle()
            .ReadOnly = True
        End With
        ColorVarianceCell(dgvrof_noncash.Rows(insertIndex).Cells("colVariance"), totalVar)
    End Sub

#End Region

#Region "Grid theme helpers"

    Private Sub ApplyGridTheme(grid As Guna.UI2.WinForms.Guna2DataGridView)
        With grid
            .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
            .ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(255, 224, 192)
            .ThemeStyle.HeaderStyle.ForeColor = Color.FromArgb(60, 35, 10)
            .ThemeStyle.HeaderStyle.Font = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
            .ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single
            .ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .ThemeStyle.RowsStyle.BackColor = Color.FromArgb(255, 255, 250)
            .ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(40, 25, 8)
            .ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9.0!)
            .ThemeStyle.RowsStyle.Height = 32
            .ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(255, 224, 192)
            .ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(60, 35, 10)
            .ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.Single
            .ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 243, 230)
            .ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(40, 25, 8)
            .ThemeStyle.BackColor = Color.FromArgb(255, 245, 235)
            .ThemeStyle.GridColor = Color.FromArgb(230, 195, 155)
        End With
    End Sub

    Private Function BuildTotalRowStyle() As DataGridViewCellStyle
        Dim s As New DataGridViewCellStyle()
        s.Font = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
        s.BackColor = Color.FromArgb(255, 224, 192)
        s.ForeColor = Color.FromArgb(60, 35, 10)
        s.Alignment = DataGridViewContentAlignment.MiddleCenter
        Return s
    End Function

    Private Sub ColorVarianceCell(cell As DataGridViewCell, variance As Decimal)
        If variance > 0D Then
            cell.Style.ForeColor = Color.FromArgb(180, 100, 20)   ' amber — overage
            cell.Style.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        ElseIf variance < 0D Then
            cell.Style.ForeColor = Color.FromArgb(180, 50, 50)    ' red — shortage
            cell.Style.Font = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        End If
    End Sub

#End Region

#Region "Overlay, Status helpers"

    Private Sub SetTabButtonsEnabled(enabled As Boolean)
        btngenerate.Enabled = enabled
        btnGenerateROF.Enabled = enabled
        btnAdd_Rof.Enabled = enabled
        btnDelete.Enabled = enabled
    End Sub

    Private Sub ShowOverlay1(show As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ShowOverlay1(show))
            Return
        End If
        pnlOverlay1.Visible = show
        If show Then
            pnlOverlay1.BringToFront()
            CenterOverlay(pnlOverlay1, loader1, lblLoading1)
        End If
    End Sub

    Private Sub ShowOverlay2(show As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ShowOverlay2(show))
            Return
        End If
        pnlOverlay2.Visible = show
        If show Then
            pnlOverlay2.BringToFront()
            CenterOverlay(pnlOverlay2, loader2, lblLoading2)
        End If
    End Sub

    Private Sub CenterOverlay(pnl As Guna.UI2.WinForms.Guna2Panel,
                               spin As Guna.UI2.WinForms.Guna2CircleProgressBar,
                               lbl As Guna.UI2.WinForms.Guna2HtmlLabel)
        spin.Location = New Point((pnl.Width - spin.Width) \ 2,
                                  (pnl.Height - spin.Height) \ 2 - 20)
        lbl.Location = New Point((pnl.Width - lbl.Width) \ 2,
                                   spin.Bottom + 10)
    End Sub

    Private Sub UpdateStatus(msg As String)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() lblStatus.Text = msg)
        Else
            lblStatus.Text = msg
        End If
    End Sub



#End Region

End Class
