Imports System.Text.RegularExpressions
Imports System.Configuration
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class cls_menuitem
    Public Function Getmenuitemdata(fromDate As Date, toDate As Date) As DataTable
        Dim resultTable As New DataTable()

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                SELECT [itemnumber]
                     ,[itemname]
                     ,SUM([qty]) as qty  
                     ,SUM(CASE WHEN salestype IN ('DEL-FP','DEL-GRB','FOC','NORMAL') THEN netsales ELSE grossamt END) as grossamt
                     ,SUM([itemdiscount]) as itemdiscount
                     ,SUM([netsales]) as netsales
                     ,[Salestype]
                FROM [dbo].[v_menuitem_summary]
                WHERE Businessdate between @FromDate and @ToDate and (qty <> 0 OR grossamt <> 0) 
                
                Group by [itemnumber],[itemname], [Salestype]
                ORDER BY salestype, itemnumber
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

    Public Function Getmenuitemsummary(fromDate As Date, toDate As Date) As DataTable
        Dim resultTable As New DataTable()

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                SELECT [itemnumber]
                     ,[itemname]
                     ,SUM([qty]) as qty
                     ,SUM([grossamt]) as grossamt
                     ,SUM([itemdiscount]) as itemdiscount
                     ,SUM([netsales]) as netsales
                     ,[Majorgroup]
                     ,[Familygroup]
                FROM [dbo].[v_menuitem_summary]
                WHERE Businessdate between @FromDate and @ToDate and (qty <> 0 OR grossamt <> 0) 
                Group by [itemnumber],[itemname],[Majorgroup],[Familygroup]
                ORDER BY itemnumber
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
    Public Function Getvariance(fromDate As Date, toDate As Date) As DataTable
        Dim resultTable As New DataTable()

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()
                Dim query As String = "
                SELECT 
	CheckNumber,
	[BusinessDate],
    SUM(CASE WHEN [Transtype] = 'Item Sale' THEN NetSales + TaxCollected ELSE 0 END) AS gross,
    SUM(CASE WHEN [Transtype] = 'Tender' THEN [amt] ELSE 0 END) AS Total_Tender,
    SUM(CASE WHEN [Transtype] = 'Item Sale' THEN NetSales + TaxCollected ELSE 0 END) - 
    SUM(CASE WHEN [Transtype] = 'Tender' THEN [amt] ELSE 0 END) AS Variance
FROM v_salesdetails
WHERE [Transtype] IN ('Item Sale', 'Tender') and BusinessDate Between @fromDate and @toDate
GROUP BY businessdate,CheckNumber
HAVING 
    SUM(CASE WHEN [Transtype] = 'Item Sale' THEN [Netsales] + [taxcollected] ELSE 0 END) - 
    SUM(CASE WHEN [Transtype] = 'Tender' THEN [amt] ELSE 0 END) <> 0 
ORDER BY businessdate DESC"

                Using cmd As New SqlCommand(query, con)
                    Using adapter As New SqlDataAdapter(cmd)
                        cmd.Parameters.Add("@fromDate", SqlDbType.DateTime).Value = fromDate
                        cmd.Parameters.Add("@toDate", SqlDbType.DateTime).Value = toDate
                        adapter.Fill(resultTable)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return resultTable
    End Function

    Public Function getscpwd_details(dtfrom As Date, dtto As Date, discounttype As String) As DataTable
        Dim resultTable As New DataTable()

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String =
    "SELECT checkNum, BusinessDate, discountType, scpwd_id,
            scpwd_name, GrossSale, lessVat, lessDisc,
            payment, workstation
     FROM (
         SELECT *, ROW_NUMBER() OVER (
             PARTITION BY checkNum
             ORDER BY BusinessDate
         ) AS rn
         FROM v_scpwd_details
         WHERE discountType IS NOT NULL
           AND businessdate BETWEEN @dtfrom AND @dtto
           AND discountType = @type
     ) x
     WHERE rn = 1"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@dtfrom", SqlDbType.Date).Value = dtfrom
                    cmd.Parameters.Add("@dtto", SqlDbType.Date).Value = dtto
                    cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = discounttype
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
    Public Function gettender_details(dtfrom As Date, dtto As Date) As DataTable
        Dim resultTable As New DataTable()

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "SELECT * from v_tenderReference where businessdate between @dtfrom and @dtto order by businessdate, tendertype "

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@dtfrom", SqlDbType.DateTime).Value = dtfrom
                    cmd.Parameters.Add("@dtto", SqlDbType.DateTime).Value = dtto
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

    Public Sub loadreceipts(ByVal ListView1 As ListView, ByVal targetDate As DateTimePicker)

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                SELECT checkNum, transDateTime,journalText 
                FROM POS_JOURNAL_LOG 
                WHERE transDateTime >= @targetDate AND transDateTime < DATEADD(DAY, 1, @targetDate)
                  AND type = 128 
                ORDER BY transDateTime"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@targetDate", SqlDbType.DateTime).Value = targetDate.Value.Date

                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    ListView1.Clear()
                    ListView1.View = View.Details
                    ListView1.FullRowSelect = False
                    ListView1.GridLines = False
                    ListView1.Columns.Add("Receipt", 600) ' One wide column
                    ListView1.Font = New Font("Courier New", 9, FontStyle.Regular)
                    ListView1.OwnerDraw = True
                    ListView1.View = View.Details
                    Dim lastCheckNum As String = ""

                    While reader.Read()
                        Dim checkNum As String = reader("checkNum").ToString()
                        Dim rawText As String = reader("journalText").ToString()

                        If lastCheckNum <> checkNum Then
                            If lastCheckNum <> "" Then
                                ' Separator between receipts
                                ListView1.Items.Add(New String("="c, 60))
                                ListView1.Items.Add("")
                            End If
                            ListView1.Items.Add("CHECK #: " & checkNum)
                            ListView1.Items.Add("Date/Time: " & Convert.ToDateTime(reader("transDateTime")).ToString("MM/dd/yyyy HH:mm"))
                            ListView1.Items.Add(New String("-"c, 60))
                        End If

                        ' Split into lines and preserve formatting
                        Dim lines() As String = rawText.Split({vbCrLf, vbLf}, StringSplitOptions.None)

                        For Each line As String In lines
                            ListView1.Items.Add(line)
                        Next
                        lastCheckNum = checkNum

                    End While
                    reader.Close()

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Function GetReceipts(targetDate As DateTime) As List(Of String)
        Dim results As New List(Of String)

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                    SELECT checkNum, transDateTime, journalText 
                    FROM POS_JOURNAL_LOG 
                    WHERE CAST(transDateTime AS DATE) = @targetDate
                      AND type = 128 
                    ORDER BY transDateTime"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.Add("@targetDate", SqlDbType.Date).Value = targetDate.Date

                    Dim reader As SqlDataReader = cmd.ExecuteReader()
                    Dim lastCheckNum As String = ""

                    While reader.Read()
                        Dim checkNum As String = reader("checkNum").ToString()
                        Dim rawText As String = reader("journalText").ToString()
                        Dim transDate As DateTime = Convert.ToDateTime(reader("transDateTime"))

                        If lastCheckNum <> checkNum Then
                            If lastCheckNum <> "" Then
                                results.Add(New String("="c, 60))
                                results.Add("")
                            End If
                            results.Add("CHECK #: " & checkNum)
                            results.Add("Date/Time: " & transDate.ToString("MM/dd/yyyy HH:mm"))
                            results.Add(New String("-"c, 60))
                        End If

                        Dim lines() As String = rawText.Split({vbCrLf, vbLf}, StringSplitOptions.None)
                        For Each line As String In lines
                            results.Add(line)
                        Next

                        lastCheckNum = checkNum
                    End While
                    reader.Close()
                End Using
            End Using
        Catch ex As Exception
            results.Add("Error: " & ex.Message)
        End Try

        Return results
    End Function

    Public Shared Function GetReceipts_Reprint(checkNum As String) As List(Of String)
        Dim results As New List(Of String)

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand()
                    cmd.Connection = con
                    cmd.CommandText =
                        "SELECT checkNum, transDateTime, journalText " &
                        "FROM POS_JOURNAL_LOG " &
                        "WHERE checkNum = @checkNum " &
                        "AND type = 128 " &
                        "ORDER BY transDateTime"

                    cmd.Parameters.Add("@checkNum", SqlDbType.Int).Value = checkNum

                    con.Open()

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim lastCheckNum As String = ""

                        While reader.Read()
                            Dim currentCheckNum As String = reader("checkNum").ToString()
                            Dim rawText As String = reader("journalText").ToString()
                            Dim transDate As DateTime = CDate(reader("transDateTime"))

                            If lastCheckNum <> currentCheckNum Then
                                If lastCheckNum <> "" Then
                                    results.Add(New String("="c, 60))
                                    results.Add("")
                                End If
                                results.Add("CHECK #: " & currentCheckNum & " RE-PRINT COPY")
                                results.Add("Date/Time: " & transDate.ToString("MM/dd/yyyy HH:mm"))
                                results.Add(New String("-"c, 60))
                            End If

                            For Each line In rawText.Split({vbCrLf, vbLf}, StringSplitOptions.None)
                                results.Add(line)
                            Next

                            lastCheckNum = currentCheckNum
                        End While
                    End Using
                End Using
            End Using

            If results.Count = 0 Then
                results.Add("No receipt data found for Check #: " & checkNum)
            End If

        Catch ex As Exception
            results.Clear()
            results.Add("Error loading receipt: " & ex.Message)
        End Try

        Return results
    End Function

    Public Shared Function GetReceipts_Variance(checkNum As String) As List(Of String)
        Dim results As New List(Of String)

        Try


            Dim connectionString As String =
                ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand()
                    cmd.Connection = con
                    cmd.CommandText =
                        "SELECT checkNum, transDateTime, journalText " &
                        "FROM POS_JOURNAL_LOG " &
                        "WHERE checkNum = @checkNum " &
                        "AND type IN (128,5) " &
                        "ORDER BY transDateTime"
                    cmd.Parameters.Add("@checkNum", SqlDbType.Int).Value = Integer.Parse(checkNum)

                    con.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        Dim lastCheckNum As String = ""

                        While reader.Read()
                            Dim currentCheckNum As String = reader("checkNum").ToString()
                            Dim rawText As String = reader("journalText").ToString()
                            Dim transDate As DateTime = CDate(reader("transDateTime"))

                            If lastCheckNum <> currentCheckNum Then
                                If lastCheckNum <> "" Then
                                    results.Add(New String("="c, 60))
                                    results.Add("")
                                End If

                                results.Add("CHECK #: " & currentCheckNum & " (VARIANCE)")
                                results.Add("Date/Time: " & transDate.ToString("MM/dd/yyyy HH:mm"))
                                results.Add(New String("-"c, 60))
                            End If

                            For Each line In rawText.Split({vbCrLf, vbLf}, StringSplitOptions.None)
                                results.Add(line)
                            Next

                            lastCheckNum = currentCheckNum
                        End While
                    End Using
                End Using
            End Using

            If results.Count = 0 Then
                results.Add("No receipt data found for Check #: " & checkNum)
            End If

        Catch ex As Exception
            results.Clear()
            results.Add("Error loading receipt: " & ex.Message)
        End Try

        Return results
    End Function





End Class
