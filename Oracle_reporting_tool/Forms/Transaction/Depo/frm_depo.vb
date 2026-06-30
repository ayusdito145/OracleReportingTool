Imports Guna.UI2.WinForms
Imports System.Data.SqlClient

Public Class frm_depo

    Dim _cls             As New cls_depo
    Private currentPage  As Integer = 1
    Private pageSize     As Integer = 31
    Private totalRecords As Integer = 0
    Private totalPages   As Integer = 0

    ' Active filter state
    Private _filterMonth As Integer = 0   ' 0 = no filter
    Private _filterYear  As Integer = 0   ' 0 = no filter

#Region "Form Load"

    Public Async Sub frm_depo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)
        ApplyGridTheme()
        ShowOverlay(False)
        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()
        PopulateMonthYearCombos()
        Await LoadPaginatedDataAsync()
    End Sub

    Private Sub PopulateMonthYearCombos()
        ' Month combo — index 0 = "All Months"
        cmbMonth.Items.Clear()
        cmbMonth.Items.Add("All Months")
        Dim monthNames As String() = {"January", "February", "March", "April",
                                      "May", "June", "July", "August",
                                      "September", "October", "November", "December"}
        For Each m As String In monthNames
            cmbMonth.Items.Add(m)
        Next
        cmbMonth.SelectedIndex = 0

        ' Year combo — current year back 5 years, index 0 = "All Years"
        cmbYear.Items.Clear()
        cmbYear.Items.Add("All Years")
        Dim thisYear As Integer = Date.Today.Year
        For y As Integer = thisYear To thisYear - 5 Step -1
            cmbYear.Items.Add(y.ToString())
        Next
        cmbYear.SelectedIndex = 0
    End Sub

#End Region

#Region "Paginated data — Async"

    Private Async Function LoadPaginatedDataAsync(Optional keyword As String = "") As Task
        ShowOverlay(True)
        UpdateStatus("Loading records...")
        BtnPrevious.Enabled = False
        btnNext.Enabled     = False

        Try
            ' Both count and fetch use their own connections — safe on any thread
            totalRecords = Await Task.Run(Function()
                                              Return _cls.GetTotalRecordCount(keyword, _filterMonth, _filterYear)
                                          End Function)
            totalPages = Math.Max(1, CInt(Math.Ceiling(totalRecords / pageSize)))

            If currentPage < 1 Then currentPage = 1
            If currentPage > totalPages Then currentPage = totalPages

            Dim offset As Integer = (currentPage - 1) * pageSize

            ' Step 1 — pure data, background thread
            Dim dt As DataTable = Await Task.Run(Function()
                                                     Return _cls.fetch_depo(offset, pageSize, keyword, _filterMonth, _filterYear)
                                                 End Function)

            ' Step 2 — bind on UI thread
            _cls.bind_depo(dgvdepo, dt)

            lblPageInfo.Text = $"Page {currentPage} of {totalPages}"
            lblRecCount.Text = totalRecords & " record(s)"

            Dim filterDesc As String = BuildFilterDesc(keyword)
            UpdateStatus($"Page {currentPage} of {totalPages}  ·  {totalRecords} record(s){filterDesc}")

        Catch ex As Exception
            MessageBox.Show("Error loading records: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay(False)
            BtnPrevious.Enabled = currentPage > 1
            btnNext.Enabled     = currentPage < totalPages
        End Try
    End Function

    Private Function BuildFilterDesc(keyword As String) As String
        Dim parts As New List(Of String)
        If Not String.IsNullOrEmpty(keyword) Then parts.Add("Search: """ & keyword & """")
        If _filterMonth > 0 Then parts.Add(System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(_filterMonth))
        If _filterYear  > 0 Then parts.Add(_filterYear.ToString())
        If parts.Count = 0 Then Return ""
        Return "  ·  " & String.Join(", ", parts)
    End Function

#End Region

#Region "Toolbar — Add Deposit"

    Private Sub BtnAdddepo_Click(sender As Object, e As EventArgs) Handles BtnAdddepo.Click
        Dim f As New frm_add_depo()
        f.ShowDialog()
        currentPage = 1
        LoadPaginatedDataAsync(txtsearch.Text.Trim())
    End Sub

#End Region

#Region "Search"

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        currentPage = 1
        LoadPaginatedDataAsync(txtsearch.Text.Trim())
    End Sub

#End Region

#Region "Month / Year filter"

    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        ' Index 0 = "All Months" → no filter
        _filterMonth = If(cmbMonth.SelectedIndex <= 0, 0, cmbMonth.SelectedIndex)
        currentPage  = 1
        LoadPaginatedDataAsync(txtsearch.Text.Trim())
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        ' Index 0 = "All Years" → no filter
        If cmbYear.SelectedIndex <= 0 Then
            _filterYear = 0
        Else
            _filterYear = CInt(cmbYear.SelectedItem.ToString())
        End If
        currentPage = 1
        LoadPaginatedDataAsync(txtsearch.Text.Trim())
    End Sub

    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        ' Suppress change events while resetting
        RemoveHandler cmbMonth.SelectedIndexChanged, AddressOf cmbMonth_SelectedIndexChanged
        RemoveHandler cmbYear.SelectedIndexChanged,  AddressOf cmbYear_SelectedIndexChanged
        cmbMonth.SelectedIndex = 0
        cmbYear.SelectedIndex  = 0
        txtsearch.Text         = ""
        AddHandler cmbMonth.SelectedIndexChanged, AddressOf cmbMonth_SelectedIndexChanged
        AddHandler cmbYear.SelectedIndexChanged,  AddressOf cmbYear_SelectedIndexChanged

        _filterMonth = 0
        _filterYear  = 0
        currentPage  = 1
        LoadPaginatedDataAsync("")
    End Sub

#End Region

#Region "Pagination buttons"

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentPage < totalPages Then
            currentPage += 1
            LoadPaginatedDataAsync(txtsearch.Text.Trim())
        End If
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        If currentPage > 1 Then
            currentPage -= 1
            LoadPaginatedDataAsync(txtsearch.Text.Trim())
        End If
    End Sub

#End Region

#Region "Grid cell click — View image / Edit (preserved)"

    Private Sub dgvdepo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdepo.CellContentClick
        If e.RowIndex < 0 Then Return

        If dgvdepo.Columns(e.ColumnIndex).Name = "View" Then
            Dim fileName As String = dgvdepo.Rows(e.RowIndex).Cells("filename").Value.ToString()
            Dim remoteFilePath As String = "/" & fileName
            If fileName.ToLower().EndsWith(".jpg") OrElse
               fileName.ToLower().EndsWith(".jpeg") OrElse
               fileName.ToLower().EndsWith(".png") OrElse
               fileName.ToLower().EndsWith(".bmp") Then
                Dim imageViewer As New frmViewImage(remoteFilePath)
                imageViewer.ShowDialog()
            Else
                MessageBox.Show("Selected file is not an image.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

        If dgvdepo.Columns(e.ColumnIndex).Name = "Edit" Then
            holddepoid = dgvdepo.Rows(e.RowIndex).Cells("depo_id").Value.ToString()
            _cls.LoadDepo(frm_edit_depo.DTdepo, frm_edit_depo.txtdepoRef,
                          frm_edit_depo.txtpetty, frm_edit_depo.txtbir,
                          frm_edit_depo.txtopensales, frm_edit_depo.txtotherdept)
            frm_edit_depo.ShowDialog()
            LoadPaginatedDataAsync(txtsearch.Text.Trim())
        End If

        If dgvdepo.Columns(e.ColumnIndex).Name = "Delete" Then
            Dim depoId As Integer = CInt(dgvdepo.Rows(e.RowIndex).Cells("depo_id").Value.ToString())
            Dim depoRef As String = dgvdepo.Rows(e.RowIndex).Cells("Deporef").Value.ToString()
            DeleteDepoAsync(depoId, depoRef)
        End If
    End Sub

#End Region

#Region "Delete deposit"

    Private Async Sub DeleteDepoAsync(depoId As Integer, depoRef As String)
        Dim confirm As DialogResult = MessageBox.Show(
            "Delete deposit record?" & Environment.NewLine &
            "Ref#: " & depoRef & Environment.NewLine & Environment.NewLine &
            "This cannot be undone.",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm <> DialogResult.Yes Then Return

        ShowOverlay(True)
        UpdateStatus("Deleting deposit Ref# " & depoRef & "...")
        BtnAdddepo.Enabled = False

        Try
            Await Task.Run(Sub() _cls.delete_depo(depoId))
            UpdateStatus("Deposit Ref# " & depoRef & " deleted successfully.")
            MessageBox.Show("Deposit deleted successfully.", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            currentPage = 1
            Await LoadPaginatedDataAsync(txtsearch.Text.Trim())
        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Delete error — " & ex.Message)
        Finally
            ShowOverlay(False)
            BtnAdddepo.Enabled = True
        End Try
    End Sub

#End Region

#Region "Grid theme"

    Private Sub ApplyGridTheme()
        With dgvdepo
            .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
            .ThemeStyle.HeaderStyle.BackColor       = System.Drawing.Color.FromArgb(255, 224, 192)
            .ThemeStyle.HeaderStyle.ForeColor       = System.Drawing.Color.FromArgb(60, 35, 10)
            .ThemeStyle.HeaderStyle.Font            = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold)
            .ThemeStyle.HeaderStyle.BorderStyle     = DataGridViewHeaderBorderStyle.Single
            .ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .ThemeStyle.RowsStyle.BackColor         = System.Drawing.Color.FromArgb(255, 255, 250)
            .ThemeStyle.RowsStyle.ForeColor         = System.Drawing.Color.FromArgb(40, 25, 8)
            .ThemeStyle.RowsStyle.Font              = New System.Drawing.Font("Segoe UI", 9.0!)
            .ThemeStyle.RowsStyle.Height            = 32
            .ThemeStyle.RowsStyle.SelectionBackColor  = System.Drawing.Color.FromArgb(255, 224, 192)
            .ThemeStyle.RowsStyle.SelectionForeColor  = System.Drawing.Color.FromArgb(60, 35, 10)
            .ThemeStyle.RowsStyle.BorderStyle       = DataGridViewCellBorderStyle.Single
            .ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(255, 243, 230)
            .ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(40, 25, 8)
            .ThemeStyle.BackColor = System.Drawing.Color.FromArgb(255, 245, 235)
            .ThemeStyle.GridColor = System.Drawing.Color.FromArgb(230, 195, 155)
            .ThemeStyle.ReadOnly  = False
        End With
    End Sub

#End Region

#Region "Overlay, Status helpers"

    Public Sub RefreshGrid()
        currentPage = 1
        LoadPaginatedDataAsync(txtsearch.Text.Trim())
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
