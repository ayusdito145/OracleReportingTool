Imports System.Configuration
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Module DatabasePatcher
    Public Function IsDatabaseUpdateAvailable() As Boolean
        Dim scriptPath As String = Path.Combine(Application.StartupPath, "Update.sql")
        ' Returns True if the file exists, False if not
        Return File.Exists(scriptPath)
    End Function
    Public Sub RunSqlUpdate()
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
        Dim scriptPath As String = Path.Combine(Application.StartupPath, "Update.sql")

        ' Double safety check
        If Not File.Exists(scriptPath) Then Return

        Try
            Dim scriptContent As String = File.ReadAllText(scriptPath)

            ' Split script by "GO" so SQL Server handles it correctly
            Dim commandBatches As String() = Regex.Split(scriptContent, "^\s*GO\s*$", RegexOptions.Multiline Or RegexOptions.IgnoreCase)

            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim transaction As SqlTransaction = conn.BeginTransaction()

                Try
                    For Each batch As String In commandBatches
                        ' Skip empty lines
                        If String.IsNullOrWhiteSpace(batch) Then Continue For

                        Using cmd As New SqlCommand(batch, conn, transaction)
                            cmd.CommandTimeout = 300 ' Allow 5 minutes for heavy updates
                            cmd.ExecuteNonQuery()
                        End Using
                    Next

                    ' Commit if all good
                    transaction.Commit()
                Catch sqlEx As Exception
                    ' Rollback if any error
                    transaction.Rollback()
                    Throw New Exception("SQL Logic Error: " & sqlEx.Message)
                End Try
            End Using

            ' Delete the file only after success so it doesn't run again
            File.Delete(scriptPath)

            MessageBox.Show("Database structure applied successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("CRITICAL ERROR: " & ex.Message, "Database Patch Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Force Exit because the App and DB are now out of sync
            Environment.Exit(1)
        End Try
    End Sub




End Module
