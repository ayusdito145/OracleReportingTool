Imports System.Configuration
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Public Class cls_hourlyPOS

    Public Function GetHourlyData(fromDate As Date, toDate As Date) As DataTable
        Dim resultTable As New DataTable()

        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim query As String = "
                SELECT 
                    CONVERT(varchar(10), [DetailPostingTime], 101) AS [BusinessDate],
                    DATEPART(HOUR, [DetailPostingTime]) AS [HourOfDay],
                    [Category],
                    ObjectNumber as itemcode,
                    [itemname],
                    SUM([qty]) AS TotalQty,
                    SUM([amt]) AS TotalAmt
                FROM [dbo].[v_itemdetail]
                WHERE 
                    [Category] IN ('SHELL', 'RING') 
                    AND [DetailPostingTime] >= @FromDate 
                    AND [DetailPostingTime] < @ToDate  AND (rvc_type <> 'FOC Waste')
                   
                GROUP BY 
                    CONVERT(varchar(10), [DetailPostingTime], 101),
                    DATEPART(HOUR, [DetailPostingTime]),
                    [Category],
                    ObjectNumber,
                    [itemname]
                ORDER BY
                    [BusinessDate],
                    [HourOfDay],
                    [Category],
                    itemcode,
                    [itemname];"

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

    Public Function SaveProducedDonut(grid As Guna.UI2.WinForms.Guna2DataGridView) As Boolean
        Try
            Dim hasError As Boolean = False
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            ' --- Reset cell styles before validation ---
            For Each row As DataGridViewRow In grid.Rows
                For Each cell As DataGridViewCell In row.Cells
                    cell.Style.BackColor = Color.White
                Next
            Next

            ' --- Step 1: Validation check before saving ---
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Continue For

                ' Time Mixing
                If row.Cells("time_mixing").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("time_mixing").Value.ToString()) Then
                    row.Cells("time_mixing").Style.BackColor = Color.LightCoral
                    hasError = True
                End If

                ' Date
                If row.Cells("date").Value Is Nothing OrElse Not IsDate(row.Cells("date").Value) Then
                    row.Cells("date").Style.BackColor = Color.LightCoral
                    hasError = True
                End If

                ' Qty validations
                If row.Cells("shell_qty").Value Is Nothing OrElse Not IsNumeric(row.Cells("shell_qty").Value) Then
                    row.Cells("shell_qty").Style.BackColor = Color.LightCoral
                    hasError = True
                End If
                If row.Cells("ring_qty").Value Is Nothing OrElse Not IsNumeric(row.Cells("ring_qty").Value) Then
                    row.Cells("ring_qty").Style.BackColor = Color.LightCoral
                    hasError = True
                End If
                If row.Cells("jpops_qty").Value Is Nothing OrElse Not IsNumeric(row.Cells("jpops_qty").Value) Then
                    row.Cells("jpops_qty").Style.BackColor = Color.LightCoral
                    hasError = True
                End If

                ' Remarks
                If row.Cells("remarks").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("remarks").Value.ToString()) Then
                    row.Cells("remarks").Style.BackColor = Color.LightCoral
                    hasError = True
                End If
            Next

            ' --- Stop if validation failed ---
            If hasError Then
                MessageBox.Show("Please complete all required fields. Highlighted cells are missing or invalid.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            ' --- Step 2: Check duplicates INSIDE the grid ---
            Dim seen As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Continue For

                Dim timeMix As String = row.Cells("time_mixing").Value.ToString()
                Dim dateMix As Date = CDate(row.Cells("date").Value)
                Dim key As String = timeMix & "|" & dateMix.ToString("yyyy-MM-dd")

                If seen.Contains(key) Then
                    MessageBox.Show("Duplicate detected inside the grid for Time Mixing: " & timeMix &
                                    " and Date: " & dateMix.ToShortDateString() &
                                    vbCrLf & "Please remove the duplicate before saving.",
                                    "Duplicate Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                Else
                    seen.Add(key)
                End If
            Next

            ' --- Step 3: Check duplicates against the database ---
            Using con As New SqlConnection(connectionString)
                con.Open()

                For Each row As DataGridViewRow In grid.Rows
                    If row.IsNewRow Then Continue For

                    Dim timeMix As String = row.Cells("time_mixing").Value.ToString()
                    Dim dateMix As Date = CDate(row.Cells("date").Value)

                    Dim checkQuery As String = "SELECT COUNT(*) FROM dts_produce WHERE time_mixing = @time_mixing AND date_mix = @date_mix"
                    Using checkCmd As New SqlCommand(checkQuery, con)
                        checkCmd.Parameters.AddWithValue("@time_mixing", timeMix)
                        checkCmd.Parameters.AddWithValue("@date_mix", dateMix)

                        Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If exists > 0 Then
                            MessageBox.Show("Duplicate entry already exists in database for Time Mixing: " & timeMix &
                                            " on Date: " & dateMix.ToShortDateString() &
                                            vbCrLf & "Save process cancelled.",
                                            "Duplicate Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                    End Using
                Next

                ' --- Step 4: Insert rows ---
                For Each row As DataGridViewRow In grid.Rows
                    If row.IsNewRow Then Continue For

                    Dim query As String = "INSERT INTO dts_produce (time_mixing, date_mix, shell_qty, ring_qty, jpops_qty, remarks, locationname) 
                                       VALUES (@time_mixing, @date_mix, @shell_qty, @ring_qty, @jpops_qty, @remarks, @locationname)"

                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@time_mixing", row.Cells("time_mixing").Value.ToString())
                        cmd.Parameters.AddWithValue("@date_mix", CDate(row.Cells("date").Value))
                        cmd.Parameters.AddWithValue("@shell_qty", CInt(row.Cells("shell_qty").Value))
                        cmd.Parameters.AddWithValue("@ring_qty", CInt(row.Cells("ring_qty").Value))
                        cmd.Parameters.AddWithValue("@jpops_qty", CInt(row.Cells("jpops_qty").Value))


                        Dim remarksValue As Object = row.Cells("remarks").Value
                        If remarksValue Is Nothing OrElse String.IsNullOrWhiteSpace(remarksValue.ToString()) Then
                            cmd.Parameters.AddWithValue("@remarks", DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@remarks", remarksValue.ToString())
                        End If

                        If mdl_variable.IsOfflineMode Then
                            cmd.Parameters.AddWithValue("@locationname", mdl_variable.OfflineLocationName)
                        Else
                            cmd.Parameters.AddWithValue("@locationname", login_name)
                        End If

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            MessageBox.Show("Records saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form.ActiveForm.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function SaveWasteDonut(grid As Guna.UI2.WinForms.Guna2DataGridView) As Boolean
        Try
            Dim hasError As Boolean = False
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

            ' --- Reset cell styles before validation ---
            For Each row As DataGridViewRow In grid.Rows
                For Each cell As DataGridViewCell In row.Cells
                    cell.Style.BackColor = Color.White
                Next
            Next

            ' --- Step 1: Validation check before saving ---
            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Continue For

                ' Time Mixing
                If row.Cells("time_waste").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("time_waste").Value.ToString()) Then
                    row.Cells("time_waste").Style.BackColor = Color.LightCoral
                    hasError = True
                End If

                ' Date
                If row.Cells("date").Value Is Nothing OrElse Not IsDate(row.Cells("date").Value) Then
                    row.Cells("date").Style.BackColor = Color.LightCoral
                    hasError = True
                End If

                ' Qty validations
                If row.Cells("shell_qty").Value Is Nothing OrElse Not IsNumeric(row.Cells("shell_qty").Value) Then
                    row.Cells("shell_qty").Style.BackColor = Color.LightCoral
                    hasError = True
                End If
                If row.Cells("ring_qty").Value Is Nothing OrElse Not IsNumeric(row.Cells("ring_qty").Value) Then
                    row.Cells("ring_qty").Style.BackColor = Color.LightCoral
                    hasError = True
                End If
                If row.Cells("jpops_qty").Value Is Nothing OrElse Not IsNumeric(row.Cells("jpops_qty").Value) Then
                    row.Cells("jpops_qty").Style.BackColor = Color.LightCoral
                    hasError = True
                End If


                ' Remarks
                If row.Cells("remarks").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("remarks").Value.ToString()) Then
                    row.Cells("remarks").Style.BackColor = Color.LightCoral
                    hasError = True
                End If
            Next

            ' --- Stop if validation failed ---
            If hasError Then
                MessageBox.Show("Please complete all required fields. Highlighted cells are missing or invalid.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            ' --- Step 2: Check duplicates INSIDE the grid ---
            Dim seen As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

            For Each row As DataGridViewRow In grid.Rows
                If row.IsNewRow Then Continue For

                Dim timeMix As String = If(row.Cells("time_waste").Value, "").ToString()
                Dim dateMix As Date = If(row.Cells("date").Value, Date.MinValue)
                Dim wasteRemark As String = If(row.Cells("remarks").Value, "").ToString()

                ' Include remark in uniqueness if needed
                Dim key As String = timeMix & "|" & dateMix.ToString("yyyy-MM-dd") & "|" & wasteRemark.Trim()

                If seen.Contains(key) Then
                    MessageBox.Show("Duplicate detected inside the grid:" & vbCrLf &
                        "Time Waste: " & timeMix & vbCrLf &
                        "Date: " & dateMix.ToShortDateString() & vbCrLf &
                        "Remarks: " & wasteRemark & vbCrLf &
                        "Please remove the duplicate before saving.",
                        "Duplicate Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                Else
                    seen.Add(key)
                End If
            Next
            ' --- Step 3: Check duplicates against the database ---
            Using con As New SqlConnection(connectionString)
                con.Open()

                For Each row As DataGridViewRow In grid.Rows
                    If row.IsNewRow Then Continue For

                    Dim timeMix As String = row.Cells("time_waste").Value.ToString()
                    Dim dateMix As Date = CDate(row.Cells("date").Value)
                    Dim wasteRemark As String = row.Cells("remarks").Value.ToString()

                    Dim checkQuery As String = "SELECT COUNT(*) FROM dts_waste WHERE time_waste = @time_mixing AND date_waste = @date_mix AND remarks =@remarks"
                    Using checkCmd As New SqlCommand(checkQuery, con)
                        checkCmd.Parameters.AddWithValue("@time_mixing", timeMix)
                        checkCmd.Parameters.AddWithValue("@date_mix", dateMix)
                        checkCmd.Parameters.AddWithValue("@remarks", wasteRemark)

                        Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If exists > 0 Then
                            MessageBox.Show("Duplicate entry already exists in database for Time Waste: " & timeMix &
                                            " on Date: " & dateMix.ToShortDateString() &
                                            vbCrLf & "Save process cancelled.",
                                            "Duplicate Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return False
                        End If
                    End Using
                Next

                ' --- Step 4: Insert rows ---
                For Each row As DataGridViewRow In grid.Rows
                    If row.IsNewRow Then Continue For

                    Dim query As String = "INSERT INTO dts_waste (time_waste, date_waste, shell_qty, ring_qty, jpops_qty, remarks, locationname) 
                                       VALUES (@time_mixing, @date_mix, @shell_qty, @ring_qty, @jpops_qty, @remarks, @locationname)"

                    Using cmd As New SqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@time_mixing", row.Cells("time_waste").Value.ToString())
                        cmd.Parameters.AddWithValue("@date_mix", CDate(row.Cells("date").Value))
                        cmd.Parameters.AddWithValue("@shell_qty", CInt(row.Cells("shell_qty").Value))
                        cmd.Parameters.AddWithValue("@ring_qty", CInt(row.Cells("ring_qty").Value))
                        cmd.Parameters.AddWithValue("@jpops_qty", CInt(row.Cells("jpops_qty").Value))

                        Dim remarksValue As Object = row.Cells("remarks").Value
                        If remarksValue Is Nothing OrElse String.IsNullOrWhiteSpace(remarksValue.ToString()) Then
                            cmd.Parameters.AddWithValue("@remarks", DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@remarks", remarksValue.ToString())
                        End If

                        If mdl_variable.IsOfflineMode Then
                            cmd.Parameters.AddWithValue("@locationname", mdl_variable.OfflineLocationName)
                        Else
                            cmd.Parameters.AddWithValue("@locationname", login_name)
                        End If

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            MessageBox.Show("Records saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form.ActiveForm.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function








End Class
