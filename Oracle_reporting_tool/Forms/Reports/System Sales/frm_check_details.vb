Imports System.IO
Imports System.Threading

Public Class frm_check_details

    Private cts               As CancellationTokenSource
    Dim _cls                  As New cls_menuitem
    Private _cachedDataTable  As DataTable = Nothing

#Region "Form Load"

    Private Sub frm_check_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Runtime-only Guna2 properties (avoids Designer E_INVALIDARG)
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        ApplyGridTheme()

        dtFrom.Value = Date.Today
        dtto.Value   = Date.Today

        ShowOverlay(False)
        UpdateStatus("Ready — select a date range and click Generate.")

        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()
    End Sub

    ''' <summary>
    ''' Grid palette applied at runtime — avoids ThemeStyle sub-property
    ''' E_INVALIDARG issues in the Designer.
    ''' </summary>
    Private Sub ApplyGridTheme()
        With dgvvariance
            .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
            .ThemeStyle.HeaderStyle.BackColor      = System.Drawing.Color.FromArgb(255, 224, 192)
            .ThemeStyle.HeaderStyle.ForeColor      = System.Drawing.Color.FromArgb(60, 35, 10)
            .ThemeStyle.HeaderStyle.Font           = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            .ThemeStyle.HeaderStyle.BorderStyle    = DataGridViewHeaderBorderStyle.Single
            .ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

            .ThemeStyle.RowsStyle.BackColor        = System.Drawing.Color.FromArgb(255, 255, 250)
            .ThemeStyle.RowsStyle.ForeColor        = System.Drawing.Color.FromArgb(40, 25, 8)
            .ThemeStyle.RowsStyle.Font             = New System.Drawing.Font("Segoe UI", 9.0!)
            .ThemeStyle.RowsStyle.Height           = 30
            .ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 224, 192)
            .ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
            .ThemeStyle.RowsStyle.BorderStyle      = DataGridViewCellBorderStyle.Single

            .ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 230)
            .ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(40, 25, 8)

            .ThemeStyle.BackColor  = System.Drawing.Color.FromArgb(255, 245, 235)
            .ThemeStyle.GridColor  = System.Drawing.Color.FromArgb(230, 195, 155)
            .ThemeStyle.ReadOnly   = False
        End With
    End Sub

#End Region

#Region "Generate (Async — already async in original, preserved + improved)"

    Private Async Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        Try
            ' Cancel any prior running operation
            If cts IsNot Nothing Then
                cts.Cancel()
                cts.Dispose()
            End If
            cts = New CancellationTokenSource()

            Dim fromDate As Date = dtFrom.Value.Date
            Dim toDate   As Date = dtto.Value.Date

            ShowOverlay(True)
            btngenerate.Enabled  = False
            _cachedDataTable     = Nothing
            lblRecCount.Text     = ""
            UpdateStatus("Loading tender data for " &
                         fromDate.ToString("MMM dd, yyyy") & " – " &
                         toDate.ToString("MMM dd, yyyy") & "...")

            _cachedDataTable = Await Task.Run(Function()
                                                  cts.Token.ThrowIfCancellationRequested()
                                                  Return _cls.gettender_details(fromDate, toDate)
                                              End Function, cts.Token)

            LoadGridWithData(_cachedDataTable)
            Dim count As Integer = If(_cachedDataTable IsNot Nothing, _cachedDataTable.Rows.Count, 0)
            lblRecCount.Text = count & " record(s)"
            UpdateStatus("Loaded " & count & " record(s)  ·  " &
                         fromDate.ToString("MMM dd, yyyy") & " – " &
                         toDate.ToString("MMM dd, yyyy"))

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

#Region "Search / Filter (preserved exactly)"

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        FilterData(txtsearch.Text.Trim())
    End Sub

    Private Sub FilterData(keyword As String)
        If _cachedDataTable Is Nothing Then Return

        Try
            Dim dv As New DataView(_cachedDataTable)

            If Not String.IsNullOrEmpty(keyword) Then
                keyword = keyword.Replace("'", "''")

                If Not _cachedDataTable.Columns.Contains("checkNum") Then
                    MessageBox.Show("Column 'checkNum' not found in data. Check your SQL query.")
                    Return
                End If

                Dim sb As New System.Text.StringBuilder()
                sb.Append("Convert([checkNum], 'System.String') LIKE '%" & keyword & "%' OR ")
                sb.Append("ISNULL([reference], '') LIKE '%" & keyword & "%' OR ")
                sb.Append("ISNULL([tenderType], '') LIKE '%" & keyword & "%'")
                dv.RowFilter = sb.ToString()
            Else
                dv.RowFilter = String.Empty
            End If

            Dim filtered As DataTable = dv.ToTable()
            LoadGridWithData(filtered)
            lblRecCount.Text = filtered.Rows.Count & " record(s)"
            UpdateStatus(If(String.IsNullOrEmpty(keyword),
                            "Showing all records.",
                            "Filtered: " & filtered.Rows.Count & " match(es) for """ & keyword & """"))

        Catch ex As Exception
            MessageBox.Show("Search Error: " & ex.Message, "Debug Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Grid binding"

    Private Sub LoadGridWithData(data As DataTable)
        dgvvariance.SuspendLayout()
        dgvvariance.Columns.Clear()
        dgvvariance.Rows.Clear()

        With dgvvariance
            ' Column definitions
            .Columns.Add("checkNum",     "Check Number")
            .Columns.Add("BusinessDate", "Business Date")
            .Columns.Add("tenderType",   "Tender Type")
            .Columns.Add("amount",       "Amount")
            .Columns.Add("reference",    "Reference")

            .SelectionMode     = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False

            ' Column widths — distribute evenly across form width
            Dim colW As Integer = Math.Max(120, (dgvvariance.Width - 4) \ 5)
            For i As Integer = 0 To .ColumnCount - 1
                .Columns(i).Width = colW
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).SortMode  = DataGridViewColumnSortMode.NotSortable
                .Columns(i).ReadOnly  = True
            Next

            ' Amount column — right-align
            .Columns("amount").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            ' Re-apply theme after column rebuild
            ApplyGridTheme()
        End With

        ' Populate rows
        If data IsNot Nothing Then
            For Each row As DataRow In data.Rows
                dgvvariance.Rows.Add(
                    row("checkNum").ToString(),
                    row("BusinessDate").ToString(),
                    row("tenderType").ToString(),
                    row("amount").ToString(),
                    row("reference").ToString()
                )
            Next
        End If

        dgvvariance.ResumeLayout()
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
        lblStatus.Text = msg
    End Sub

#End Region

End Class
