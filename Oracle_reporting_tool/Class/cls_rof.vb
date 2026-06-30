Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Public Class cls_rof
    Public Async Function LoadCashamtAsync(busidate As Date) As Task(Of DataTable)

        Dim resultTable As New DataTable()
        Dim connectionString As String =
            ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
        Dim query As String =
            "SELECT emp_name,
                    Itemname,
                    SUM(amt) AS posreading
             FROM dbo.v_salesdetails
             WHERE transtype = 'Tender'
               AND itemname = 'Cash'
               AND businessdate = @busidate
             GROUP BY emp_name, Itemname
                HAVING SUM(amt) <> 0;"

        Using con As New SqlConnection(connectionString)
            Await con.OpenAsync()

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.Add("@busidate", SqlDbType.Date).Value = busidate

                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    resultTable.Load(reader)
                End Using
            End Using
        End Using

        Return resultTable
    End Function

    Public Async Function LoadTenderamtAsync(busidate As Date) As Task(Of DataTable)

        Dim resultTable As New DataTable()
        Dim connectionString As String =
            ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
        Dim query As String =
            "select 
             Itemname,
             SUM (amt) as posreading
             from dbo.v_salesdetails
              where transtype = 'Tender' and itemname <>  'Cash'
              AND businessdate = @busidate
             GROUP BY Itemname
             HAVING SUM(amt) <> 0;"
        Using con As New SqlConnection(connectionString)
            Await con.OpenAsync()

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.Add("@busidate", SqlDbType.Date).Value = busidate

                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    resultTable.Load(reader)
                End Using
            End Using
        End Using
        Return resultTable
    End Function
    Public Async Function loadROFCash(busidate As Date) As Task(Of DataTable)

        Dim resultTable As New DataTable()
        Dim connectionString As String =
            ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

        Dim query As String =
            "SELECT rof_id,
                    cashiername,
                    posamt,
                    actualamt,
                    mod,
                    remarks
             FROM dbo.dts_rof_cash
             WHERE busidate = @busidate"

        Using con As New SqlConnection(connectionString)
            Await con.OpenAsync()

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.Add("@busidate", SqlDbType.Date).Value = busidate

                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    resultTable.Load(reader)
                End Using
            End Using
        End Using

        Return resultTable
    End Function
    Public Async Function loadROFNonCash(busidate As Date) As Task(Of DataTable)
        Dim resultTable As New DataTable()
        Dim connectionString As String =
            ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

        Dim query As String =
            "SELECT rof_id,
                    tendername,
                    tenderamt,
                    actualtender,
                    remarks
             FROM dbo.dts_rof_noncash
             WHERE busidate = @busidate"

        Using con As New SqlConnection(connectionString)
            Await con.OpenAsync()

            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.Add("@busidate", SqlDbType.Date).Value = busidate
                Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                    resultTable.Load(reader)
                End Using
            End Using
        End Using
        Return resultTable
    End Function

    ''' <summary>
    ''' Loads ROF summary from v_summary_ROF for a date range.
    ''' Thread-safe — own connection, safe to call from Task.Run.
    ''' </summary>
    Public Function loadROFSummary(dateFrom As Date, dateTo As Date) As DataTable
        Dim resultTable As New DataTable()
        Dim connectionString As String =
            ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

        Dim query As String =
            "SELECT busidate," &
            "       locationname," &
            "       netsales_vat," &
            "       vat," &
            "       netsales," &
            "       gc_sales," &
            "       cash," &
            "       noncash," &
            "       variance," &
            "       cash_remarks," &
            "       noncash_remarks" &
            " FROM   dbo.v_summary_ROF" &
            " WHERE  busidate     BETWEEN @dateFrom AND @dateTo" &
            "   AND  locationname = @locationname" &
            " ORDER  BY busidate ASC"

        Using con As New SqlConnection(connectionString)
            con.Open()
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.Add("@dateFrom",     SqlDbType.Date).Value    = dateFrom
                cmd.Parameters.Add("@dateTo",       SqlDbType.Date).Value    = dateTo
                cmd.Parameters.Add("@locationname", SqlDbType.VarChar).Value = login_name
                cmd.CommandTimeout = 120
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    resultTable.Load(reader)
                End Using
            End Using
        End Using

        Return resultTable
    End Function


End Class
