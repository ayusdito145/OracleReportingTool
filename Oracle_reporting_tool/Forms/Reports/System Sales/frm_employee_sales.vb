Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frm_employee_sales

    Dim _cls As New cls_emp_salesreport

#Region "Form Load"

    Private Sub frm_employee_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        lblStore.Text = "Store: " & login_name
        dtFrom.Value  = Date.Today
        dtTo.Value    = Date.Today

        ShowOverlay(False)
        UpdateStatus("Ready — select a date range and employee, then click Generate Report.")
        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()

        rv_employee.RefreshReport()
        PopulateEmployeeCombo()
    End Sub

    Private Sub PopulateEmployeeCombo()
        Try
            Dim dt As DataTable = _cls.LoadEmployees()
            cbemployee.Items.Clear()
            For Each row As DataRow In dt.Rows
                cbemployee.Items.Add(row("CheckName").ToString())
            Next
            If cbemployee.Items.Count > 0 Then cbemployee.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Error loading employees: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Generate — Async (replaces BackgroundWorker)"

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReportAsync()
    End Sub

    Private Async Sub GenerateReportAsync()
        If String.IsNullOrEmpty(cbemployee.Text) Then
            MessageBox.Show("Please select an employee.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim empname  As String = cbemployee.Text
        Dim dateFrom As String = dtFrom.Value.ToString("yyyy-MM-dd")
        Dim dateTo   As String = dtTo.Value.ToString("yyyy-MM-dd")

        ShowOverlay(True)
        btnGenerate.Enabled = False
        UpdateStatus("Querying data for " & empname & "  ·  " &
                     dtFrom.Value.ToString("MMM dd, yyyy") & " – " &
                     dtTo.Value.ToString("MMM dd, yyyy") & "...")

        Try
            Dim result As Tuple(Of DataTable, DataTable) =
                Await Task.Run(Function() FetchReportData(empname, dateFrom, dateTo))

            BindReport(result.Item1, result.Item2, empname, dateFrom, dateTo)

            UpdateStatus("Report generated  ·  " & empname & "  ·  " &
                         dtFrom.Value.ToString("MMM dd, yyyy") & " – " &
                         dtTo.Value.ToString("MMM dd, yyyy"))
            MessageBox.Show("Report generated successfully.", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay(False)
            btnGenerate.Enabled = True
        End Try
    End Sub

    ''' <summary>Background-safe — no UI access.</summary>
    Private Function FetchReportData(empname  As String,
                                     dateFrom  As String,
                                     dateTo    As String) As Tuple(Of DataTable, DataTable)
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable

        Dim connStr As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

        Using conn As New SqlConnection(connStr)
            conn.Open()

            ' ── Sales metrics ─────────────────────────────────────────
            Dim q1 As String =
                "SELECT SUM(Netsales)          as netsales,
                        SUM(taxcollected)       as taxcollected,
                        SUM(lessvat)            as lessvat,
                        SUM(LessSC)             as lessSC,
                        SUM(LessPWD)            as lessPWD,
                        SUM(lessemp)            as lessEmp,
                        SUM(lessNationalAth)    as lessNationalAth,
                        SUM(lessSoloparent)     as lessSoloparent,
                        SUM(srvc_amt)           as srvc_amt,
                        SUM(other_disc)         as other_disc,
                        SUM(CASE WHEN amt < 0 AND Transtype = 'Item Sale'
                                 THEN amt ELSE 0 END) as void,
                        SUM(CASE WHEN checkclose IS NULL
                                 THEN amt ELSE 0 END) as outstanding
                 FROM   dbo.v_salesdetails
                 WHERE  emp_name = @empname
                   AND  BusinessDate BETWEEN @dtfrom AND @dtto
                 GROUP BY emp_name"

            Using cmd As New SqlCommand(q1, conn)
                cmd.Parameters.Add("@empname", SqlDbType.VarChar).Value = empname
                cmd.Parameters.Add("@dtfrom",  SqlDbType.VarChar).Value = dateFrom
                cmd.Parameters.Add("@dtto",    SqlDbType.VarChar).Value = dateTo
                cmd.CommandTimeout = 500
                Dim adp As New SqlDataAdapter(cmd)
                adp.Fill(dt1)
            End Using

            ' ── Tender breakdown ─────────────────────────────────────
            Dim q2 As String =
                "SELECT itemname,
                        SUM(qty) as qty,
                        SUM(amt) as amt
                 FROM   dbo.v_salesdetails
                 WHERE  Transtype = 'Tender'
                   AND  emp_name  = @empname
                   AND  BusinessDate BETWEEN @dtfrom AND @dtto
                 GROUP BY Transtype, itemname"

            Using cmd As New SqlCommand(q2, conn)
                cmd.Parameters.Add("@empname", SqlDbType.VarChar).Value = empname
                cmd.Parameters.Add("@dtfrom",  SqlDbType.VarChar).Value = dateFrom
                cmd.Parameters.Add("@dtto",    SqlDbType.VarChar).Value = dateTo
                cmd.CommandTimeout = 500
                Dim adp As New SqlDataAdapter(cmd)
                adp.Fill(dt2)
            End Using
        End Using

        Return Tuple.Create(dt1, dt2)
    End Function

    ''' <summary>UI thread — bind DataTable to ReportViewer.</summary>
    Private Sub BindReport(dt1 As DataTable, dt2 As DataTable,
                            empname As String, dateFrom As String, dateTo As String)

        With rv_employee.LocalReport
            .DataSources.Clear()
            .ReportPath = Application.StartupPath & "\emp_sales.rdlc"
            .DataSources.Add(New ReportDataSource("emp_sales_metric", dt1))
            .DataSources.Add(New ReportDataSource("emp_tender",       dt2))
        End With

        Dim startDate As String = dtFrom.Value.ToString("MM/dd/yyyy")
        Dim endDate   As String = dtTo.Value.ToString("MM/dd/yyyy")

        rv_employee.LocalReport.SetParameters(New ReportParameter() {
            New ReportParameter("DTFrom",       startDate),
            New ReportParameter("DTto",         endDate),
            New ReportParameter("ComboBoxValue", empname)
        })

        rv_employee.RefreshReport()
    End Sub

#End Region

#Region "Menu navigation (preserved)"

    Private Sub VarianceCheckingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VarianceCheckingToolStripMenuItem.Click
        frm_variance.Show()
    End Sub

#End Region

#Region "Form Closed (preserved)"

    Private Sub frm_employee_sales_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rv_employee.Dispose()
        Application.Exit()
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
