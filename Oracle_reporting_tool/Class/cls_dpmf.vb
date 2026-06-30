Imports System.Text.RegularExpressions
Imports System.Configuration
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Public Class cls_dpmf

    Public Function loadProduceDonut(fromDate As Date, toDate As Date) As DataTable
        Dim resultTable As New DataTable()
        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                SELECT time_mixing,shell_qty,ring_qty,jpops_qty,remarks 
                FROM dts_produce
                WHERE date_mix between @FromDate and @ToDate 
                "
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate
                    cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(resultTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return resultTable
    End Function

    Public Function loadWasteDonut(fromDate As Date, toDate As Date) As DataTable
        Dim resultTable As New DataTable()
        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                SELECT time_waste,shell_qty,ring_qty,jpops_qty,remarks 
                FROM dts_waste
                WHERE date_waste between @FromDate and @ToDate 
                "
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate
                    cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(resultTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return resultTable
    End Function

    Public Function loadSoldDonut(fromDate As Date, toDate As Date) As DataTable
        Dim resultTable As New DataTable()
        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                SELECT HourRange,ShellSold,RingSold,JpopsSold
                FROM v_donutsold
                WHERE DateSold between @FromDate and @ToDate ORDER BY Datesold
                "
                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate
                    cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(resultTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return resultTable
    End Function
    Public Function loadPOSwaste(fromDate As Date, toDate As Date) As DataTable
        Dim resultTable As New DataTable()

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
               SELECT        
SUM(CASE WHEN Category = 'Ring' THEN qty ELSE 0 END) AS RingWaste,
SUM(CASE WHEN Category = 'Shell' THEN qty ELSE 0 END) AS ShellWaste, 
SUM(CASE WHEN Category = 'Jpops' THEN qty ELSE 0 END) AS JpopsWaste
FROM            dbo.v_itemdetail
WHERE        (rvc_type = 'FOC Waste') and CAST(DetailPostingTime AS DATE) between @FromDate and @ToDate"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate
                    cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(resultTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return resultTable
    End Function
End Class
