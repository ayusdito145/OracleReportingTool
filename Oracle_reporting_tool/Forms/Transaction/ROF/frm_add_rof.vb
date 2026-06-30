Imports System.Threading
Imports System.Threading.Tasks
Imports System.Drawing
Imports System.Configuration
Imports System.Data.SqlClient

Public Class frm_add_rof

    Public Event RofFormClosed()

    Private _cls          As New cls_rof
    Private _businessDate As Date
    Private _cts          As CancellationTokenSource

    Public Property BusinessDate As Date
        Get
            Return _businessDate
        End Get
        Set(value As Date)
            If _businessDate <> value Then
                _businessDate = value
                ' Update header badge if form is already visible
                If Me.IsHandleCreated Then
                    lblDateBadge.Text = "Business Date: " & value.ToString("MMMM dd, yyyy")
                End If
            End If
        End Set
    End Property

#Region "Form Load"

    Private Async Sub frm_add_rof_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        ' Show business date in header
        lblDateBadge.Text = "Business Date: " & _businessDate.ToString("MMMM dd, yyyy")

        ApplyGridTheme(dgvrof_cash)
        ApplyGridTheme(dgvrof_noncash)

        ShowOverlay(False)
        UpdateStatus("Loading POS data for " & _businessDate.ToString("MMMM dd, yyyy") & "...")
        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()

        Await ReloadDataAsync()
    End Sub

#End Region

#Region "Data load — Async"

    Private Async Function ReloadDataAsync() As Task
        _cts?.Cancel()
        _cts = New CancellationTokenSource()
        Dim token = _cts.Token

        ShowOverlay(True)
        Try
            Dim data1 As DataTable = Await _cls.LoadCashamtAsync(_businessDate)
            Dim data2 As DataTable = Await _cls.LoadTenderamtAsync(_businessDate)
            If token.IsCancellationRequested Then Return

            LoadGridWithCashData(data1)
            LoadGridWithTenderData(data2)

            Dim cashRows    As Integer = Math.Max(0, dgvrof_cash.Rows.Count - 1)
            Dim noncashRows As Integer = Math.Max(0, dgvrof_noncash.Rows.Count - 2)
            UpdateStatus($"Data loaded  ·  {cashRows} cashier(s)  ·  {noncashRows} tender type(s)  ·  Enter actual amounts then click Save ROF.")

        Catch ex As OperationCanceledException
            ' Silently ignore
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error loading data — " & ex.Message)
        Finally
            ShowOverlay(False)
        End Try
    End Function

#End Region

#Region "Grid load — Cash"

    Private Sub LoadGridWithCashData(data As DataTable)
        dgvrof_cash.Columns.Clear()
        dgvrof_cash.Rows.Clear()

        With dgvrof_cash
            .Columns.Add("emp_name",   "Cashier Name")
            .Columns.Add("Itemname",   "Tender Name")
            .Columns.Add("posreading", "POS Amount")
            .Columns.Add("colActual",  "Actual Amount")
            .Columns.Add("colVariance","Variance")
            .Columns.Add("colMOD",     "MOD")
            .Columns.Add("colRemarks", "Remarks")

            .SelectionMode     = DataGridViewSelectionMode.CellSelect
            .AllowUserToAddRows = False
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To .ColumnCount - 1
                .Columns(i).Width    = 150
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(i).ReadOnly = True
            Next

            ' Editable columns — white background as visual cue
            With .Columns("colActual")
                .ReadOnly = False
                .DefaultCellStyle.BackColor = Color.White
                .DefaultCellStyle.Font      = New Font("Segoe UI", 9.0!)
            End With
            With .Columns("colMOD")
                .ReadOnly = False
                .DefaultCellStyle.BackColor = Color.White
            End With
            With .Columns("colRemarks")
                .ReadOnly = False
                .DefaultCellStyle.BackColor = Color.White
                .Width = 300
            End With
        End With

        ApplyGridTheme(dgvrof_cash)

        For Each row As DataRow In data.Rows
            Dim posAmt As Decimal = If(IsDBNull(row("posreading")), 0D, CDec(row("posreading")))
            dgvrof_cash.Rows.Add(
                row("emp_name").ToString(),
                row("Itemname").ToString(),
                FormatNumber(posAmt, 2),
                "0.00", "0.00", "", "")
        Next
        ComputeSubtotalCash()
    End Sub

    Private Sub dgvrof_cash_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrof_cash.CellEndEdit
        Try
            If dgvrof_cash.Columns(e.ColumnIndex).Name = "colActual" Then
                Dim currentRow As DataGridViewRow = dgvrof_cash.Rows(e.RowIndex)
                Dim posAmt    As Decimal = 0
                Dim actualAmt As Decimal = 0
                Decimal.TryParse(Convert.ToString(currentRow.Cells("posreading").Value), posAmt)
                Decimal.TryParse(Convert.ToString(currentRow.Cells("colActual").Value),  actualAmt)
                Dim variance As Decimal = actualAmt - posAmt
                currentRow.Cells("colActual").Value   = FormatNumber(actualAmt, 2)
                currentRow.Cells("colVariance").Value = FormatNumber(variance,  2)
                ColorVarianceCell(currentRow.Cells("colVariance"), variance)
                ComputeSubtotalCash()
            End If
        Catch
        End Try
    End Sub

    Private Sub dgvrof_cash_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvrof_cash.EditingControlShowing
        Dim txt As TextBox = TryCast(e.Control, TextBox)
        If txt IsNot Nothing Then
            RemoveHandler txt.KeyPress, AddressOf NumericOnly_KeyPress
            If dgvrof_cash.CurrentCell.OwningColumn.Name = "colActual" Then
                AddHandler txt.KeyPress, AddressOf NumericOnly_KeyPress
            End If
        End If
    End Sub

    Private Sub ComputeSubtotalCash()
        ' Remove existing TOTAL row
        If dgvrof_cash.Rows.Count > 0 Then
            Dim last As Integer = dgvrof_cash.Rows.Count - 1
            If dgvrof_cash.Rows(last).Cells("emp_name").Value?.ToString() = "TOTAL" Then
                dgvrof_cash.Rows.RemoveAt(last)
            End If
        End If

        Dim totalPOS As Decimal = 0, totalActual As Decimal = 0, totalVar As Decimal = 0
        For Each row As DataGridViewRow In dgvrof_cash.Rows
            If row.IsNewRow Then Continue For
            Dim v1 As Decimal, v2 As Decimal, v3 As Decimal
            Decimal.TryParse(Convert.ToString(row.Cells("posreading").Value),  v1)
            Decimal.TryParse(Convert.ToString(row.Cells("colActual").Value),   v2)
            Decimal.TryParse(Convert.ToString(row.Cells("colVariance").Value), v3)
            totalPOS += v1 : totalActual += v2 : totalVar += v3
        Next

        Dim idx As Integer = dgvrof_cash.Rows.Add()
        With dgvrof_cash.Rows(idx)
            .Cells("emp_name").Value   = "TOTAL"
            .Cells("Itemname").Value   = ""
            .Cells("posreading").Value = FormatNumber(totalPOS,    2)
            .Cells("colActual").Value  = FormatNumber(totalActual, 2)
            .Cells("colVariance").Value = FormatNumber(totalVar,   2)
            .Cells("colMOD").Value     = ""
            .Cells("colRemarks").Value = ""
            .DefaultCellStyle          = BuildTotalRowStyle()
            .ReadOnly                  = True
        End With
        ColorVarianceCell(dgvrof_cash.Rows(idx).Cells("colVariance"), totalVar)
    End Sub

#End Region

#Region "Grid load — Non-Cash"

    Private Sub LoadGridWithTenderData(data As DataTable)
        dgvrof_noncash.Columns.Clear()
        dgvrof_noncash.Rows.Clear()

        With dgvrof_noncash
            .Columns.Add("itemname",   "Tender Name")
            .Columns.Add("posreading", "POS Amount")
            .Columns.Add("colActual",  "Actual Amount")
            .Columns.Add("colVariance","Variance")
            .Columns.Add("colRemarks", "Remarks")

            .SelectionMode     = DataGridViewSelectionMode.CellSelect
            .AllowUserToAddRows = True
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            For i As Integer = 0 To .ColumnCount - 1
                .Columns(i).Width    = 200
                .Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns(i).ReadOnly = True
            Next

            With .Columns("colActual")
                .ReadOnly = False
                .DefaultCellStyle.BackColor = Color.White
            End With
            With .Columns("colRemarks")
                .ReadOnly = False
                .DefaultCellStyle.BackColor = Color.White
                .Width = 350
            End With
            With .Columns("itemname")
                .ReadOnly = False
            End With
        End With

        ApplyGridTheme(dgvrof_noncash)

        For Each row As DataRow In data.Rows
            Dim posAmt As Decimal = If(IsDBNull(row("posreading")), 0D, CDec(row("posreading")))
            dgvrof_noncash.Rows.Add(
                row("Itemname").ToString(),
                FormatNumber(posAmt, 2),
                "0.00", "0.00", "")
        Next
        ComputeSubtotalNonCash()
    End Sub

    Private Sub dgvrof_noncash_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrof_noncash.CellEndEdit
        Try
            If dgvrof_noncash.Columns(e.ColumnIndex).Name = "colActual" Then
                Dim currentRow As DataGridViewRow = dgvrof_noncash.Rows(e.RowIndex)
                Dim posAmt    As Decimal = 0
                Dim actualAmt As Decimal = 0
                Decimal.TryParse(Convert.ToString(currentRow.Cells("posreading").Value), posAmt)
                Decimal.TryParse(Convert.ToString(currentRow.Cells("colActual").Value),  actualAmt)
                Dim variance As Decimal = actualAmt - posAmt
                currentRow.Cells("colActual").Value   = FormatNumber(actualAmt, 2)
                currentRow.Cells("colVariance").Value = FormatNumber(variance,  2)
                ColorVarianceCell(currentRow.Cells("colVariance"), variance)
                ComputeSubtotalNonCash()
            End If
        Catch
        End Try
    End Sub

    Private Sub dgvrof_noncash_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvrof_noncash.EditingControlShowing
        Dim txt As TextBox = TryCast(e.Control, TextBox)
        If txt IsNot Nothing Then
            RemoveHandler txt.KeyPress, AddressOf NumericOnly_KeyPress
            If dgvrof_noncash.CurrentCell.OwningColumn.Name = "colActual" Then
                AddHandler txt.KeyPress, AddressOf NumericOnly_KeyPress
            End If
        End If
    End Sub

    Private Sub ComputeSubtotalNonCash()
        For i As Integer = dgvrof_noncash.Rows.Count - 1 To 0 Step -1
            If dgvrof_noncash.Rows(i).IsNewRow Then Continue For
            If dgvrof_noncash.Rows(i).Cells("itemname").Value?.ToString() = "TOTAL" Then
                dgvrof_noncash.Rows.RemoveAt(i)
                Exit For
            End If
        Next

        Dim totalPOS As Decimal = 0, totalActual As Decimal = 0, totalVar As Decimal = 0
        For Each row As DataGridViewRow In dgvrof_noncash.Rows
            If row.IsNewRow Then Continue For
            Dim v1 As Decimal, v2 As Decimal, v3 As Decimal
            Decimal.TryParse(Convert.ToString(row.Cells("posreading").Value),  v1)
            Decimal.TryParse(Convert.ToString(row.Cells("colActual").Value),   v2)
            Decimal.TryParse(Convert.ToString(row.Cells("colVariance").Value), v3)
            totalPOS += v1 : totalActual += v2 : totalVar += v3
        Next

        Dim insertIndex As Integer = dgvrof_noncash.Rows.Count
        If dgvrof_noncash.AllowUserToAddRows Then insertIndex -= 1
        dgvrof_noncash.Rows.Insert(insertIndex)
        With dgvrof_noncash.Rows(insertIndex)
            .Cells("itemname").Value    = "TOTAL"
            .Cells("posreading").Value  = FormatNumber(totalPOS,    2)
            .Cells("colActual").Value   = FormatNumber(totalActual, 2)
            .Cells("colVariance").Value = FormatNumber(totalVar,    2)
            .Cells("colRemarks").Value  = ""
            .DefaultCellStyle           = BuildTotalRowStyle()
            .ReadOnly                   = True
        End With
        ColorVarianceCell(dgvrof_noncash.Rows(insertIndex).Cells("colVariance"), totalVar)
    End Sub

#End Region

#Region "Save  (preserved exactly — all validation, header, insert)"

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvrof_cash.Rows.Count = 0 AndAlso dgvrof_noncash.Rows.Count = 0 Then
            MessageBox.Show("No data to save.")
            Exit Sub
        End If

        Dim totalCashPOS    As Decimal = GetGridTotalPOS(dgvrof_cash,    "emp_name",  "posreading")
        Dim totalNonCashPOS As Decimal = GetGridTotalPOS(dgvrof_noncash, "itemname",  "posreading")

        If totalCashPOS = 0D Then
            MessageBox.Show("Cannot save — TOTAL POS Amount (CASH) is zero.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If totalNonCashPOS = 0D Then
            MessageBox.Show("Cannot save — TOTAL POS Amount (NONCASH) is zero.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validate CASH rows
        For Each row As DataGridViewRow In dgvrof_cash.Rows
            If row.IsNewRow Then Continue For
            If Convert.ToString(row.Cells("emp_name").Value) = "TOTAL" Then Continue For
            Dim v As Decimal
            If Not Decimal.TryParse(Convert.ToString(row.Cells("colActual").Value), v) OrElse v < 0 Then
                MessageBox.Show("Invalid Actual amount (cash).", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgvrof_cash.CurrentCell = row.Cells("colActual")
                dgvrof_cash.BeginEdit(True)
                Exit Sub
            End If
            If String.IsNullOrWhiteSpace(Convert.ToString(row.Cells("colMOD").Value)) Then
                MessageBox.Show("MOD required.", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dgvrof_cash.CurrentCell = row.Cells("colMOD")
                dgvrof_cash.BeginEdit(True)
                Exit Sub
            End If
        Next

        ' Validate NONCASH rows
        For Each row As DataGridViewRow In dgvrof_noncash.Rows
            If row.IsNewRow Then Continue For
            If Convert.ToString(row.Cells("itemname").Value) = "TOTAL" Then Continue For
            Dim v As Decimal
            If Not Decimal.TryParse(Convert.ToString(row.Cells("colActual").Value), v) OrElse v < 0 Then
                MessageBox.Show("Invalid Actual amount (noncash).", "Invalid Input",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        Dim cs As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
        Using conn As New SqlConnection(cs)
            conn.Open()
            Using trans = conn.BeginTransaction()
                Try
                    If RofAlreadyExists(conn, trans, _businessDate) Then
                        MessageBox.Show("ROF already saved for this business date.",
                                        "Duplicate Save", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        trans.Rollback()
                        Exit Sub
                    End If

                    Dim rofId As Integer = GetOrCreateRofHeader(conn, trans, _businessDate)

                    ' Insert CASH
                    For Each row As DataGridViewRow In dgvrof_cash.Rows
                        If row.IsNewRow Then Continue For
                        Dim cashier = Convert.ToString(row.Cells("emp_name").Value)
                        If cashier = "TOTAL" Then Continue For
                        Dim tender  = Convert.ToString(row.Cells("Itemname").Value)
                        Dim posAmt  As Decimal
                        Decimal.TryParse(Convert.ToString(row.Cells("posreading").Value), posAmt)
                        Dim actualAmt As Decimal = Convert.ToDecimal(row.Cells("colActual").Value)
                        Dim modVal    = Convert.ToString(row.Cells("colMOD").Value)
                        Dim remarks   = Convert.ToString(row.Cells("colRemarks").Value)
                        Using cmd As New SqlCommand(
                            "INSERT INTO dts_rof_cash
                             (rof_id,cashiername,tendername,posamt,actualamt,mod,remarks,busidate,locationname)
                             VALUES(@rof,@cash,@tender,@pos,@actual,@mod,@rem,@date,@locationname)",
                            conn, trans)
                            cmd.Parameters.AddWithValue("@rof",          rofId)
                            cmd.Parameters.AddWithValue("@cash",         cashier)
                            cmd.Parameters.AddWithValue("@tender",       tender)
                            cmd.Parameters.AddWithValue("@pos",          posAmt)
                            cmd.Parameters.AddWithValue("@actual",       actualAmt)
                            cmd.Parameters.AddWithValue("@mod",          modVal)
                            cmd.Parameters.AddWithValue("@rem",          remarks)
                            cmd.Parameters.AddWithValue("@date",         _businessDate)
                            cmd.Parameters.AddWithValue("@locationname", login_name)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    ' Insert NONCASH
                    For Each row As DataGridViewRow In dgvrof_noncash.Rows
                        If row.IsNewRow Then Continue For
                        Dim tender = Convert.ToString(row.Cells("itemname").Value)
                        If tender = "TOTAL" Then Continue For
                        Dim posAmt    As Decimal
                        Decimal.TryParse(Convert.ToString(row.Cells("posreading").Value), posAmt)
                        Dim actualAmt As Decimal = Convert.ToDecimal(row.Cells("colActual").Value)
                        Dim remarks   = Convert.ToString(row.Cells("colRemarks").Value)
                        Using cmd As New SqlCommand(
                            "INSERT INTO dts_rof_noncash
                             (rof_id,tendername,tenderamt,actualtender,remarks,busidate,locationname)
                             VALUES(@rof,@tender,@amt,@actual,@rem,@date,@locationname)",
                            conn, trans)
                            cmd.Parameters.AddWithValue("@rof",          rofId)
                            cmd.Parameters.AddWithValue("@tender",       tender)
                            cmd.Parameters.AddWithValue("@amt",          posAmt)
                            cmd.Parameters.AddWithValue("@actual",       actualAmt)
                            cmd.Parameters.AddWithValue("@rem",          remarks)
                            cmd.Parameters.AddWithValue("@date",         _businessDate)
                            cmd.Parameters.AddWithValue("@locationname", login_name)
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    trans.Commit()
                    MessageBox.Show("ROF saved successfully.", "System Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Catch ex As Exception
                    trans.Rollback()
                    MessageBox.Show("Save failed: " & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub

    Private Function GetGridTotalPOS(grid As DataGridView, nameColumn As String, posColumn As String) As Decimal
        For Each row As DataGridViewRow In grid.Rows
            If row.IsNewRow Then Continue For
            If Convert.ToString(row.Cells(nameColumn).Value) = "TOTAL" Then
                Dim total As Decimal
                Decimal.TryParse(Convert.ToString(row.Cells(posColumn).Value), total)
                Return total
            End If
        Next
        Return 0D
    End Function

    Private Function RofAlreadyExists(conn As SqlConnection, trans As SqlTransaction, bDate As Date) As Boolean
        Using cmd As New SqlCommand("SELECT 1 FROM dts_rof_header WHERE busidate = @d", conn, trans)
            cmd.Parameters.Add("@d", SqlDbType.Date).Value = bDate
            Return cmd.ExecuteScalar() IsNot Nothing
        End Using
    End Function

    Private Function GetOrCreateRofHeader(conn As SqlConnection, trans As SqlTransaction, bDate As Date) As Integer
        Using cmd As New SqlCommand("SELECT rof_id FROM dts_rof_header WHERE busidate = @d", conn, trans)
            cmd.Parameters.Add("@d", SqlDbType.Date).Value = bDate
            Dim r = cmd.ExecuteScalar()
            If r IsNot Nothing AndAlso Not IsDBNull(r) Then Return CInt(r)
        End Using
        Using cmd As New SqlCommand(
            "INSERT INTO dts_rof_header (busidate,locationname) VALUES(@d,@locationname);
             SELECT SCOPE_IDENTITY();", conn, trans)
            cmd.Parameters.Add("@d",            SqlDbType.Date).Value    = bDate
            cmd.Parameters.Add("@locationname", SqlDbType.VarChar).Value = login_name
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

#End Region

#Region "Numeric input helper (preserved)"

    Private Sub NumericOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim textBox    = TryCast(sender, TextBox)
        Dim currentText = textBox.Text
        Dim cursorPos   = textBox.SelectionStart
        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> "."c AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
        If e.KeyChar = "."c AndAlso currentText.IndexOf("."c) > -1 Then e.Handled = True
        If e.KeyChar = "-"c Then
            If cursorPos > 0 OrElse currentText.StartsWith("-") Then e.Handled = True
        End If
    End Sub

#End Region

#Region "Form Closed"

    Private Sub frm_add_rof_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _cts?.Cancel()
        RaiseEvent RofFormClosed()
    End Sub

#End Region

#Region "Grid theme helpers"

    Private Sub ApplyGridTheme(grid As Guna.UI2.WinForms.Guna2DataGridView)
        With grid
            .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
            .ThemeStyle.HeaderStyle.BackColor       = Color.FromArgb(255, 224, 192)
            .ThemeStyle.HeaderStyle.ForeColor       = Color.FromArgb(60, 35, 10)
            .ThemeStyle.HeaderStyle.Font            = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
            .ThemeStyle.HeaderStyle.BorderStyle     = DataGridViewHeaderBorderStyle.Single
            .ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            .ThemeStyle.RowsStyle.BackColor         = Color.FromArgb(255, 255, 250)
            .ThemeStyle.RowsStyle.ForeColor         = Color.FromArgb(40, 25, 8)
            .ThemeStyle.RowsStyle.Font              = New Font("Segoe UI", 9.0!)
            .ThemeStyle.RowsStyle.Height            = 32
            .ThemeStyle.RowsStyle.SelectionBackColor  = Color.FromArgb(255, 224, 192)
            .ThemeStyle.RowsStyle.SelectionForeColor  = Color.FromArgb(60, 35, 10)
            .ThemeStyle.RowsStyle.BorderStyle       = DataGridViewCellBorderStyle.Single
            .ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 243, 230)
            .ThemeStyle.BackColor = Color.FromArgb(255, 245, 235)
            .ThemeStyle.GridColor = Color.FromArgb(230, 195, 155)
        End With
    End Sub

    Private Function BuildTotalRowStyle() As DataGridViewCellStyle
        Dim s As New DataGridViewCellStyle()
        s.Font      = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
        s.BackColor = Color.FromArgb(255, 224, 192)
        s.ForeColor = Color.FromArgb(60, 35, 10)
        s.Alignment = DataGridViewContentAlignment.MiddleCenter
        Return s
    End Function

    Private Sub ColorVarianceCell(cell As DataGridViewCell, variance As Decimal)
        If variance > 0D Then
            cell.Style.ForeColor = Color.FromArgb(180, 100, 20)
            cell.Style.Font      = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        ElseIf variance < 0D Then
            cell.Style.ForeColor = Color.FromArgb(180, 50, 50)
            cell.Style.Font      = New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
        Else
            cell.Style.ForeColor = Color.FromArgb(40, 25, 8)
        End If
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
        loader.Location   = New Point((pnlOverlay.Width  - loader.Width)  \ 2,
                                      (pnlOverlay.Height - loader.Height) \ 2 - 20)
        lblLoading.Location = New Point((pnlOverlay.Width  - lblLoading.Width) \ 2,
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
