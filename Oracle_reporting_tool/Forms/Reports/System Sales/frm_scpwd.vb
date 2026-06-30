Imports System.IO
Imports System.Threading

Public Class frm_scpwd

    Private _cts         As CancellationTokenSource
    Private _cls         As New cls_menuitem

#Region "Form Load"

    Private Sub frm_scpwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        ApplyGridTheme(dgvvariance)
        ShowOverlay(False)

        Dim today As Date = Date.Today
        dtFrom.Value   = today
        dtFrom.MaxDate = today
        dtto.Value     = today
        dtto.MaxDate   = today

        ' Default to first item (OSCA)
        If cbtype.Items.Count > 0 Then cbtype.SelectedIndex = 0

        UpdateStatus("Ready — select date range and discount type, then click Generate.")
        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()
    End Sub

#End Region

#Region "Generate"

    Private Async Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        ' Validate selection
        If cbtype.SelectedIndex < 0 Then
            MessageBox.Show("Please select a discount type.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Cancel any previous task
        If _cts IsNot Nothing Then
            _cts.Cancel()
            _cts.Dispose()
        End If
        _cts = New CancellationTokenSource()

        ' Snapshot UI values before Await
        Dim fromDate     As Date   = dtFrom.Value.Date
        Dim toDate       As Date   = dtto.Value.Date
        Dim discountType As String = cbtype.Text

        ShowOverlay(True)
        btngenerate.Enabled = False
        lblRecCount.Text    = ""
        UpdateStatus("Loading " & discountType & " records  ·  " &
                     fromDate.ToString("MMM dd, yyyy") & " – " &
                     toDate.ToString("MMM dd, yyyy") & "...")
        Try
            Dim data As DataTable = Await Task.Run(
                Function()
                    _cts.Token.ThrowIfCancellationRequested()
                    Return _cls.getscpwd_details(fromDate, toDate, discountType)
                End Function, _cts.Token)

            LoadGridWithData(data, discountType)

        Catch ex As OperationCanceledException
            UpdateStatus("Operation cancelled.")
            MessageBox.Show("Operation cancelled.", "Cancelled",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            UpdateStatus("Error — " & ex.Message)
            MessageBox.Show(ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ShowOverlay(False)
            btngenerate.Enabled = True
        End Try
    End Sub

#End Region

#Region "Grid load"

    Private Sub LoadGridWithData(data As DataTable, discountType As String)
        dgvvariance.Columns.Clear()
        dgvvariance.Rows.Clear()

        If data Is Nothing OrElse data.Rows.Count = 0 Then
            UpdateStatus("No records found for " & discountType & ".")
            lblRecCount.Text = "0 records"
            Return
        End If

        ' ── Build columns ────────────────────────────────────────────
        With dgvvariance
            .Columns.Add("checkNum",     "Check Number")
            .Columns.Add("BusinessDate", "Business Date")
            .Columns.Add("discountType", "Discount Type")
            .Columns.Add("scpwd_id",     "SC/PWD ID")
            .Columns.Add("scpwd_name",   "SC/PWD Name")
            .Columns.Add("GrossSale",    "Gross Sale")
            .Columns.Add("lessVat",      "Less VAT")
            .Columns.Add("lessDisc",     "Less Disc.")
            .Columns.Add("payment",      "Net Sales")
            .Columns.Add("workstation",  "Workstation")

            .SelectionMode      = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To .ColumnCount - 1
                .Columns(i).Width    = 130
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(i).ReadOnly = True
            Next

            ' Wider columns for text-heavy fields
            .Columns("scpwd_name").Width  = 200
            .Columns("scpwd_name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("scpwd_id").Width    = 150
            .Columns("checkNum").Width    = 120
        End With

        ApplyGridTheme(dgvvariance)

        ' ── Sort by discountType then by date ────────────────────────
        Dim dv As DataView = data.DefaultView
        dv.Sort = "discountType ASC, BusinessDate ASC"
        Dim sorted As DataTable = dv.ToTable()

        ' ── Accumulator variables ────────────────────────────────────
        Dim lastCategory    As String  = ""
        Dim subtotalCount   As Integer = 0
        Dim subtotalAmount  As Decimal = 0
        Dim grandTotalCount As Integer = 0
        Dim grandTotalAmt As Decimal = 0
        Dim grandTotalDisc As Decimal = 0

        ' ── Row loop ─────────────────────────────────────────────────
        For Each row As DataRow In sorted.Rows
            Dim currentType    As String  = row("discountType").ToString()
            Dim currentPayment As Decimal = If(IsDBNull(row("payment")), 0D, CDec(row("payment")))

            ' Insert subtotal when category changes
            If currentType <> lastCategory AndAlso lastCategory <> "" Then
                AddSubtotalRow(lastCategory, subtotalCount, subtotalAmount)
                subtotalCount  = 0
                subtotalAmount = 0D
            End If

            ' Add data row
            dgvvariance.Rows.Add(
                row("checkNum").ToString(),
                Format(CDate(row("BusinessDate")), "MM/dd/yyyy"),
                row("discountType").ToString(),
                row("scpwd_id").ToString(),
                row("scpwd_name").ToString(),
                FormatNumber(If(IsDBNull(row("GrossSale")), 0D, CDec(row("GrossSale"))), 2),
                FormatNumber(If(IsDBNull(row("lessVat")),   0D, CDec(row("lessVat"))),   2),
                FormatNumber(If(IsDBNull(row("lessDisc")),  0D, CDec(row("lessDisc"))),  2),
                FormatNumber(currentPayment, 2),
                row("workstation").ToString()
            )

            subtotalCount   += 1
            subtotalAmount  += currentPayment
            Dim currentDisc As Decimal = If(IsDBNull(row("lessDisc")), 0D, CDec(row("lessDisc")))
            grandTotalCount += 1
            grandTotalAmt += currentPayment
            grandTotalDisc += currentDisc
            lastCategory     = currentType
        Next

        ' Insert final subtotal for last group
        If subtotalCount > 0 Then
            AddSubtotalRow(lastCategory, subtotalCount, subtotalAmount)
        End If

        ' ── Grand total row (amber palette) ──────────────────────────
        Dim gIdx As Integer        = dgvvariance.Rows.Add()
        With dgvvariance.Rows(gIdx)
            .Cells("discountType").Value = "GRAND TOTAL"
            .Cells("scpwd_id").Value = grandTotalCount & " Transaction(s)"
            .Cells("lessDisc").Value = FormatNumber(grandTotalDisc, 2)
            .Cells("payment").Value      = FormatNumber(grandTotalAmt, 2)

            Dim gs As New DataGridViewCellStyle()
            gs.BackColor  = System.Drawing.Color.FromArgb(210, 140, 80)
            gs.ForeColor  = System.Drawing.Color.White
            gs.Font       = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            gs.Alignment  = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle = gs
            .ReadOnly         = True
        End With

        ' ── Update record count label and status ─────────────────────
        Dim dataRowCount As Integer = sorted.Rows.Count
        lblRecCount.Text = dataRowCount & " record(s)"
        UpdateStatus("Loaded " & dataRowCount & " record(s)  ·  " &
                     discountType & "  ·  " &
                     dtFrom.Value.ToString("MMM dd, yyyy") & " – " &
                     dtto.Value.ToString("MMM dd, yyyy"))
    End Sub

    ''' <summary>Inserts a styled subtotal row using named columns.</summary>
    Private Sub AddSubtotalRow(category As String, count As Integer, amount As Decimal)
        Dim idx As Integer = dgvvariance.Rows.Add()
        With dgvvariance.Rows(idx)
            .Cells("discountType").Value = "TOTAL " & category.ToUpper()
            .Cells("scpwd_id").Value     = count & " Qty(s)"
            .Cells("payment").Value      = FormatNumber(amount, 2)

            Dim st As New DataGridViewCellStyle()
            st.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
            st.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
            st.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            st.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle = st
            .ReadOnly         = True
        End With
    End Sub

#End Region

#Region "Grid theme"

    Private Sub ApplyGridTheme(grid As Guna.UI2.WinForms.Guna2DataGridView)
        With grid
            .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
            .ThemeStyle.HeaderStyle.BackColor       = System.Drawing.Color.FromArgb(255, 224, 192)
            .ThemeStyle.HeaderStyle.ForeColor       = System.Drawing.Color.FromArgb(60, 35, 10)
            .ThemeStyle.HeaderStyle.Font            = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            .ThemeStyle.HeaderStyle.BorderStyle     = DataGridViewHeaderBorderStyle.Single
            .ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .ThemeStyle.RowsStyle.BackColor         = System.Drawing.Color.FromArgb(255, 255, 250)
            .ThemeStyle.RowsStyle.ForeColor         = System.Drawing.Color.FromArgb(40, 25, 8)
            .ThemeStyle.RowsStyle.Font              = New System.Drawing.Font("Segoe UI", 9.0!)
            .ThemeStyle.RowsStyle.Height            = 30
            .ThemeStyle.RowsStyle.SelectionBackColor  = System.Drawing.Color.FromArgb(255, 224, 192)
            .ThemeStyle.RowsStyle.SelectionForeColor  = System.Drawing.Color.FromArgb(60, 35, 10)
            .ThemeStyle.RowsStyle.BorderStyle       = DataGridViewCellBorderStyle.Single
            .ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 230)
            .ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(40, 25, 8)
            .ThemeStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 235)
            .ThemeStyle.GridColor = System.Drawing.Color.FromArgb(230, 195, 155)
        End With
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
        loader.Location     = New System.Drawing.Point(
            (pnlOverlay.Width  - loader.Width)    \ 2,
            (pnlOverlay.Height - loader.Height)   \ 2 - 20)
        lblLoading.Location = New System.Drawing.Point(
            (pnlOverlay.Width  - lblLoading.Width) \ 2,
             loader.Bottom + 10)
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
