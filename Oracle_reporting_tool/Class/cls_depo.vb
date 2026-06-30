Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Imports System.Threading.Tasks
Imports System.Configuration
Public Class cls_depo

    Public Sub save_depo(ByVal busidate As Date,
                          ByVal datedepo As Date,
                         ByVal txtDepoRef As String,
                     ByVal txtpos As String,
                     ByVal txtdepo As String,
                     ByVal txtpetty As String,
                     ByVal txtbir As String,
                     ByVal txtopensales As String,
                     ByVal txtotherdept As String,
                     ByVal txtfilename As String
                     )
        Dim connectionString As String =
             ConfigurationManager.ConnectionStrings("HQDB").ConnectionString
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Try
                ' Helper function to safely convert string to Decimal
                Dim ToDecimal As Func(Of String, Decimal) = Function(value)
                                                                Dim result As Decimal = 0
                                                                Decimal.TryParse(value, result)
                                                                Return result
                                                            End Function

                Using cmd As New SqlCommand("INSERT INTO dts_depo 
                                    (locationname, busidate, pos, datedepo, deporef, deposit, pettycash, bir2307, opensales, otherdeptexp, filename) 
                                    VALUES 
                                    (@locationname, @busidate, @pos, @datedepo , @deporef, @deposit, @pettycash, @bir2307, @opensales, @otherdeptexp, @filename)", conn)

                    cmd.Parameters.Add("@locationname", SqlDbType.VarChar).Value = login_name
                    cmd.Parameters.Add("@busidate", SqlDbType.Date).Value = busidate
                    cmd.Parameters.Add("@datedepo", SqlDbType.Date).Value = datedepo
                    cmd.Parameters.Add("@deporef", SqlDbType.VarChar).Value = txtDepoRef
                    ' Numeric parameters
                    cmd.Parameters.Add("@pos", SqlDbType.Decimal).Value = ToDecimal(txtpos)
                    cmd.Parameters.Add("@deposit", SqlDbType.Decimal).Value = ToDecimal(txtdepo)
                    cmd.Parameters.Add("@pettycash", SqlDbType.Decimal).Value = ToDecimal(txtpetty)
                    cmd.Parameters.Add("@bir2307", SqlDbType.Decimal).Value = ToDecimal(txtbir)
                    cmd.Parameters.Add("@opensales", SqlDbType.Decimal).Value = ToDecimal(txtopensales)
                    cmd.Parameters.Add("@otherdeptexp", SqlDbType.Decimal).Value = ToDecimal(txtotherdept)

                    ' Text parameter
                    cmd.Parameters.Add("@filename", SqlDbType.VarChar).Value = txtfilename

                    cmd.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                Throw   ' re-throw so UploadAndSaveAsync catches it and shows the error
            End Try
        End Using
    End Sub
    Public Sub update_depo(ByVal depodate As String, ByVal txtdeporef As String, ByVal txtpetty As String, ByVal txtbir As String, ByVal txtopensales As String, ByVal txtotherdept As String)
        ConnDB()
        Try
            Using cmd As New SqlCommand("Update dts_depo set DateDepo =@DateDepo ,Deporef =@Deporef, pettycash =@pettycash ,bir2307=@bir2307,opensales=@opensales,otherdeptexp=@otherdeptexp where locationname=@locationname and depo_id=@id", con)
                cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = holddepoid
                cmd.Parameters.Add("@locationname", SqlDbType.VarChar).Value = login_name
                cmd.Parameters.Add("@DateDepo", SqlDbType.VarChar).Value = depodate
                cmd.Parameters.Add("@Deporef", SqlDbType.VarChar).Value = txtdeporef
                cmd.Parameters.Add("@pettycash", SqlDbType.Decimal).Value = txtpetty
                cmd.Parameters.Add("@bir2307", SqlDbType.Decimal).Value = txtbir
                cmd.Parameters.Add("@opensales", SqlDbType.Decimal).Value = txtopensales
                cmd.Parameters.Add("@otherdeptexp", SqlDbType.Decimal).Value = txtotherdept
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message)
        End Try
    End Sub
    ' ── Connection string helper — callable from any thread ─────────────────────
    Private ReadOnly Property HQConnStr As String
        Get
            Return ConfigurationManager.ConnectionStrings("HQDB").ConnectionString
        End Get
    End Property

    ' ── STEP 1: Pure data fetch — safe to call from Task.Run / any thread ────────
    ' Uses its OWN SqlConnection — never touches the shared module-level "con".
    ' Parameters filterMonth / filterYear: pass 0 to skip month/year filtering.
    Public Function fetch_depo(ByVal offset      As Integer,
                               ByVal limit       As Integer,
                               Optional ByVal keyword     As String  = "",
                               Optional ByVal filterMonth As Integer = 0,
                               Optional ByVal filterYear  As Integer = 0) As DataTable
        Dim dt As New DataTable
        Try
            Using conn As New SqlConnection(HQConnStr)
                conn.Open()

                Dim sql As String =
                    "SELECT * FROM (
                         SELECT *, ROW_NUMBER() OVER (ORDER BY busidate DESC) AS RowNum
                         FROM OracleDB.dbo.dts_depo
                         WHERE locationname = @locationname"

                If Not String.IsNullOrEmpty(keyword) Then
                    sql &= " AND (CAST(depo_id AS VARCHAR) LIKE @search
                                  OR Deporef LIKE @search
                                  OR filename LIKE @search
                                  OR CAST(deposit AS VARCHAR) LIKE @search)"
                End If

                If filterMonth > 0 Then
                    sql &= " AND MONTH(busidate) = @filterMonth"
                End If

                If filterYear > 0 Then
                    sql &= " AND YEAR(busidate) = @filterYear"
                End If

                sql &= ") AS RowConstrainedResult
                     WHERE RowNum > @offset AND RowNum <= (@offset + @limit)
                     ORDER BY RowNum"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.Add("@locationname", SqlDbType.VarChar).Value = login_name
                    cmd.Parameters.Add("@offset", SqlDbType.Int).Value = offset
                    cmd.Parameters.Add("@limit", SqlDbType.Int).Value = limit
                    If Not String.IsNullOrEmpty(keyword) Then
                        cmd.Parameters.Add("@search", SqlDbType.VarChar).Value = "%" & keyword & "%"
                    End If
                    If filterMonth > 0 Then
                        cmd.Parameters.Add("@filterMonth", SqlDbType.Int).Value = filterMonth
                    End If
                    If filterYear > 0 Then
                        cmd.Parameters.Add("@filterYear", SqlDbType.Int).Value = filterYear
                    End If

                    Dim adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            Throw New Exception("fetch_depo: " & ex.Message, ex)
        End Try
        Return dt
    End Function

    ' ── STEP 2: UI bind — must be called on the UI thread after awaiting fetch_depo ─
    ' Sets up columns (once) and populates rows from the DataTable returned by fetch_depo.
    Public Sub bind_depo(ByVal grid As Guna2DataGridView, ByVal dt As DataTable)
        ' Build columns only on first load
        If grid.Columns.Count = 0 Then
            With grid
                .Columns.Add("depo_id", "Depo ID")

                Dim btnView As New DataGridViewButtonColumn()
                btnView.Name = "View"
                btnView.HeaderText = "Action"
                btnView.Text = "View"
                btnView.Width = 80
                btnView.UseColumnTextForButtonValue = True
                .Columns.Add(btnView)

                Dim btnEdit As New DataGridViewButtonColumn()
                btnEdit.Name = "Edit"
                btnEdit.HeaderText = "Action"
                btnEdit.Text = "Edit"
                btnEdit.Width = 80
                btnEdit.UseColumnTextForButtonValue = True
                .Columns.Add(btnEdit)

                Dim btnDelete As New DataGridViewButtonColumn()
                btnDelete.Name = "Delete"
                btnDelete.HeaderText = "Action"
                btnDelete.Text = "Delete"
                btnDelete.Width = 80
                btnDelete.UseColumnTextForButtonValue = True
                .Columns.Add(btnDelete)

                .Columns.Add("busidate",     "Business Date")
                .Columns.Add("DateDepo",     "Deposit Date")
                .Columns.Add("Deporef",      "Depo. Ref#")
                .Columns.Add("pos",          "POS Amount")
                .Columns.Add("deposit",      "Deposit")
                .Columns.Add("pettycash",    "Petty Cash")
                .Columns.Add("bir2307",      "BIR 2307")
                .Columns.Add("opensales",    "Open Sales")
                .Columns.Add("otherdeptexp", "Other Dept. Exp.")
                .Columns.Add("variance",     "Variance")
                .Columns.Add("filename",     "Filename")

                .SelectionMode     = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Width    = 80
                .Columns(0).ReadOnly = True
                .Columns(0).Frozen   = True
                .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable

                For ctr = 4 To .ColumnCount - 1
                    .Columns(ctr).Width = 120
                    .Columns(ctr).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(ctr).SortMode = DataGridViewColumnSortMode.NotSortable
                    .Columns(ctr).ReadOnly = True
                Next

                .Columns("filename").Width = 350

                ' Peach palette (matches frm_depo ApplyGridTheme)
                .Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
                .ThemeStyle.HeaderStyle.BackColor       = Color.FromArgb(255, 224, 192)
                .ThemeStyle.HeaderStyle.ForeColor       = Color.FromArgb(60, 35, 10)
                .ThemeStyle.HeaderStyle.Font            = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
                .ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                .ThemeStyle.HeaderStyle.BorderStyle     = DataGridViewHeaderBorderStyle.Single
                .ThemeStyle.RowsStyle.BackColor         = Color.FromArgb(255, 255, 250)
                .ThemeStyle.RowsStyle.ForeColor         = Color.FromArgb(40, 25, 8)
                .ThemeStyle.RowsStyle.Font              = New Font("Segoe UI", 9.0!)
                .ThemeStyle.RowsStyle.Height            = 32
                .ThemeStyle.RowsStyle.SelectionBackColor  = Color.FromArgb(255, 224, 192)
                .ThemeStyle.RowsStyle.SelectionForeColor  = Color.FromArgb(60, 35, 10)
                .ThemeStyle.RowsStyle.BorderStyle       = DataGridViewCellBorderStyle.Single
                .ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(255, 243, 230)
                .ThemeStyle.AlternatingRowsStyle.ForeColor = Color.FromArgb(40, 25, 8)
                .ThemeStyle.BackColor = Color.FromArgb(255, 245, 235)
                .ThemeStyle.GridColor = Color.FromArgb(230, 195, 155)
            End With
        End If

        grid.SuspendLayout()
        grid.Rows.Clear()

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim r As DataRow = dt.Rows(i)
            Dim pos          As Decimal = Convert.ToDecimal(r("pos"))
            Dim deposit      As Decimal = Convert.ToDecimal(r("deposit"))
            Dim pettycash    As Decimal = Convert.ToDecimal(r("pettycash"))
            Dim bir2307      As Decimal = Convert.ToDecimal(r("bir2307"))
            Dim opensales    As Decimal = Convert.ToDecimal(r("opensales"))
            Dim otherdeptexp As Decimal = Convert.ToDecimal(r("otherdeptexp"))
            Dim variance As Decimal = (deposit + pettycash + bir2307 + opensales + otherdeptexp) - pos

            Dim idx As Integer = grid.Rows.Add()
            grid.Rows(idx).Cells(0).Value  = r("depo_id").ToString()
            grid.Rows(idx).Cells(4).Value = FormatDateTime(r("busidate").ToString(), DateFormat.ShortDate)
            grid.Rows(idx).Cells(5).Value = FormatDateTime(r("DateDepo").ToString(), DateFormat.ShortDate)
            grid.Rows(idx).Cells(6).Value = r("Deporef").ToString()
            grid.Rows(idx).Cells(7).Value = FormatNumber(pos, 2)
            grid.Rows(idx).Cells(8).Value = FormatNumber(deposit, 2)
            grid.Rows(idx).Cells(9).Value = FormatNumber(pettycash, 2)
            grid.Rows(idx).Cells(10).Value = FormatNumber(bir2307, 2)
            grid.Rows(idx).Cells(11).Value = FormatNumber(opensales, 2)
            grid.Rows(idx).Cells(12).Value = FormatNumber(otherdeptexp, 2)
            grid.Rows(idx).Cells(13).Value = FormatNumber(variance, 2)
            grid.Rows(idx).Cells(14).Value = r("filename").ToString()

            ' Highlight non-zero variance
            If variance <> 0D Then
                grid.Rows(idx).Cells(12).Style.ForeColor =
                    If(variance > 0D,
                       Color.FromArgb(180, 100, 20),
                       Color.FromArgb(180, 50, 50))
                grid.Rows(idx).Cells(12).Style.Font =
                    New Font("Segoe UI Semibold", 9.0!, FontStyle.Bold)
            End If
        Next

        grid.ResumeLayout()
    End Sub

    ' ── Thread-safe record count — own connection, called from Task.Run ──────────
    Public Function GetTotalRecordCount(Optional keyword     As String  = "",
                                        Optional filterMonth As Integer = 0,
                                        Optional filterYear  As Integer = 0) As Integer
        Dim count As Integer = 0
        Try
            Using conn As New SqlConnection(HQConnStr)
                conn.Open()
                Dim sql As String =
                    "SELECT COUNT(*) FROM OracleDB.dbo.dts_depo
                     WHERE locationname = @locationname"

                If Not String.IsNullOrEmpty(keyword) Then
                    sql &= " AND (CAST(depo_id AS VARCHAR) LIKE @search
                                  OR Deporef LIKE @search
                                  OR filename LIKE @search
                                  OR CAST(deposit AS VARCHAR) LIKE @search)"
                End If
                If filterMonth > 0 Then
                    sql &= " AND MONTH(busidate) = @filterMonth"
                End If
                If filterYear > 0 Then
                    sql &= " AND YEAR(busidate) = @filterYear"
                End If

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.Add("@locationname", SqlDbType.VarChar).Value = login_name
                    If Not String.IsNullOrEmpty(keyword) Then
                        cmd.Parameters.Add("@search", SqlDbType.VarChar).Value = "%" & keyword & "%"
                    End If
                    If filterMonth > 0 Then
                        cmd.Parameters.Add("@filterMonth", SqlDbType.Int).Value = filterMonth
                    End If
                    If filterYear > 0 Then
                        cmd.Parameters.Add("@filterYear", SqlDbType.Int).Value = filterYear
                    End If
                    count = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("GetTotalRecordCount: " & ex.Message, ex)
        End Try
        Return count
    End Function


    ' Calls fetch then bind synchronously on the calling thread.
    ' WARNING: do NOT call this from Task.Run — use fetch_depo + bind_depo instead.
    Public Sub load_depo(ByVal Guna2DataGridView1 As Guna2DataGridView,
                         ByVal offset As Integer,
                         ByVal limit As Integer,
                         Optional ByVal keyword As String = "")
        Dim dt As DataTable = fetch_depo(offset, limit, keyword)
        bind_depo(Guna2DataGridView1, dt)
    End Sub
    Public Sub LoadDepo(ByVal DTDepo As Guna2DateTimePicker, ByVal txtdeporef As Guna2TextBox, ByVal txtpetty As Guna2TextBox, ByVal txtbir As Guna2TextBox, ByVal txtopensales As Guna2TextBox, ByVal txtotherdept As Guna2TextBox)
        Try
            Using conn As New SqlConnection(HQConnStr)
                conn.Open()
                Using cmd As New SqlCommand("SELECT * FROM OracleDB.dbo.dts_depo WHERE depo_id = @id order by busidate", conn)
                    cmd.Parameters.AddWithValue("@id", holddepoid)
                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            DTDepo.Text = rdr("DateDepo").ToString()
                            txtdeporef.Text = rdr("Deporef").ToString()
                            txtpetty.Text = rdr("pettycash").ToString()
                            txtbir.Text = rdr("bir2307").ToString()
                            txtopensales.Text = rdr("opensales").ToString()
                            txtotherdept.Text = rdr("otherdeptexp").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading depo: " & ex.Message)
        End Try
    End Sub
    Public Async Function IsBusinessDateExists(busidate As Date, locationname As String) As Task(Of Boolean)
        Dim connectionString As String =
        ConfigurationManager.ConnectionStrings("HQDB").ConnectionString

        Dim query As String =
        "SELECT COUNT(1)
         FROM dbo.dts_depo
         WHERE busidate = @busidate and locationname = @locationname"

        Using con As New SqlConnection(connectionString)
            Await con.OpenAsync()

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.Add("@busidate", SqlDbType.Date).Value = busidate
                cmd.Parameters.Add("@locationname", SqlDbType.VarChar).Value = locationname
                Dim count As Integer =
                Convert.ToInt32(Await cmd.ExecuteScalarAsync())

                Return count > 0
            End Using
        End Using
    End Function
    Public Async Function loadPOSamt(busidate As Date) As Task(Of (Decimal, Decimal))

        Dim posTotal As Decimal = 0
        Dim actualTotal As Decimal = 0

        Dim connectionString As String =
        ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
        Dim query As String =
        "SELECT ISNULL(SUM(posamt),0) AS posamt,
                ISNULL(SUM(actualamt),0) AS actualamt
         FROM dbo.dts_rof_cash
         WHERE busidate = @busidate"

        Using con As New SqlConnection(connectionString)
            Await con.OpenAsync()

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.Add("@busidate", SqlDbType.Date).Value = busidate

                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    If Await reader.ReadAsync() Then
                        posTotal = Convert.ToDecimal(reader("posamt"))
                        actualTotal = Convert.ToDecimal(reader("actualamt"))
                    End If
                End Using
            End Using
        End Using

        Return (posTotal, actualTotal)

    End Function

    ''' <summary>
    ''' Deletes a deposit record by depo_id.
    ''' Thread-safe — own connection, safe to call from Task.Run.
    ''' </summary>
    Public Sub delete_depo(depoId As Integer)
        Using conn As New SqlConnection(HQConnStr)
            conn.Open()
            Using tran As SqlTransaction = conn.BeginTransaction()
                Try
                    Using cmd As New SqlCommand(
                        "DELETE FROM OracleDB.dbo.dts_depo WHERE depo_id = @id",
                        conn, tran)
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = depoId
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

End Class
