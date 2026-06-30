Imports System.Configuration
Imports System.Data.SqlClient
Public Class cls_POS
    Public Function LoadPOS() As DataTable
        Dim resultTable As New DataTable()
        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT DISTINCT(Workstation) from v_salesdetails"
                Using cmd As New SqlCommand(query, con)
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
