Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Configuration

Public Class frm_system_sales

#Region "Form Load"

    Private Sub frm_system_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Runtime-only Guna2 property (avoids Designer E_INVALIDARG)
        loader.ProgressColor2 = System.Drawing.Color.FromArgb(255, 224, 192)

        dtFrom.Value = Date.Today
        dtto.Value = Date.Today

        ' Show store name in toolbar
        lblStore.Text = "Store: " & login_name

        ' Initial blank report
        rv_salesreport.RefreshReport()

        ShowOverlay(False)
        UpdateStatus("Ready — select a date range and click Generate Report.")

        AddHandler Me.Resize, Sub(s, ev) CenterOverlay()
    End Sub

#End Region

#Region "Generate — Async (replaces BackgroundWorker)"

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        GenerateReportAsync()
    End Sub

    Private Async Sub GenerateReportAsync()
        Dim dateFrom As String = dtFrom.Value.ToString("yyyy-MM-dd")
        Dim dateTo As String = dtto.Value.ToString("yyyy-MM-dd")
        Dim storeName As String = login_name

        ShowOverlay(True)
        btnGenerate.Enabled = False
        UpdateStatus("Querying database for " & dtFrom.Value.ToString("MMM dd, yyyy") &
                     " to " & dtto.Value.ToString("MMM dd, yyyy") & "...")

        Try
            Dim result As Tuple(Of DataTable, DataTable) = Await Task.Run(
                Function() FetchReportData(storeName, dateFrom, dateTo))

            BindReport(result.Item1, result.Item2, storeName, dateFrom, dateTo)
            UpdateStatus("Report generated  ·  " &
                         dtFrom.Value.ToString("MMM dd, yyyy") & " – " &
                         dtto.Value.ToString("MMM dd, yyyy") & "  ·  Store: " & storeName)
            MessageBox.Show("Report generated successfully.", "Done",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generating report:" & Environment.NewLine & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay(False)
            btnGenerate.Enabled = True
        End Try
    End Sub

    ''' <summary>
    ''' Runs on a thread-pool thread via Task.Run — no UI access allowed here.
    ''' Returns (dt1=sales summary, dt2=tender breakdown).
    ''' </summary>
    Private Function FetchReportData(storeName As String,
                                     dateFrom As String,
                                     dateTo As String) As Tuple(Of DataTable, DataTable)

        Dim dt1 As New DataTable
        Dim dt2 As New DataTable

        Dim connStr As String = ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

        Using conn As New SqlConnection(connStr)
            conn.Open()

            ' ── Sales summary ─────────────────────────────────────────
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
                 WHERE  BusinessDate BETWEEN @dtfrom AND @dtto"

            Using cmd As New SqlCommand(q1, conn)
                cmd.Parameters.Add("@dtfrom", SqlDbType.VarChar).Value = dateFrom
                cmd.Parameters.Add("@dtto", SqlDbType.VarChar).Value = dateTo
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
                   AND  BusinessDate BETWEEN @dtfrom AND @dtto
                 GROUP BY Transtype, itemname"

            Using cmd As New SqlCommand(q2, conn)
                cmd.Parameters.Add("@dtfrom", SqlDbType.VarChar).Value = dateFrom
                cmd.Parameters.Add("@dtto", SqlDbType.VarChar).Value = dateTo
                cmd.CommandTimeout = 500
                Dim adp As New SqlDataAdapter(cmd)
                adp.Fill(dt2)
            End Using
        End Using

        Return Tuple.Create(dt1, dt2)
    End Function

    ''' <summary>
    ''' Binds data to the ReportViewer — must run on UI thread (called after Await).
    ''' </summary>
    Private Sub BindReport(dt1 As DataTable, dt2 As DataTable,
                            storeName As String, dateFrom As String, dateTo As String)

        With rv_salesreport.LocalReport
            .DataSources.Clear()
            .ReportPath = Application.StartupPath & "\system_sales.rdlc"
            .DataSources.Add(New ReportDataSource("system_sales", dt1))
            .DataSources.Add(New ReportDataSource("tender_system", dt2))
        End With

        ' Format dates for report parameters (MM/dd/yyyy — same as original)
        Dim startDate As String = dtFrom.Value.ToString("MM/dd/yyyy")
        Dim endDate As String = dtto.Value.ToString("MM/dd/yyyy")

        rv_salesreport.LocalReport.SetParameters(New ReportParameter() {
            New ReportParameter("DTFrom", startDate),
            New ReportParameter("DTto", endDate),
            New ReportParameter("ComboBoxValue", storeName)
        })

        rv_salesreport.RefreshReport()
    End Sub

#End Region

#Region "Menu navigation (preserved exactly)"

    Private Sub VarianceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VarianceToolStripMenuItem.Click
        frm_variance.Show()
    End Sub

    Private Sub EmployeeSalesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmployeeSalesToolStripMenuItem1.Click
        loadform(New frm_employee_sales())
    End Sub

    Private Sub POSSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSSalesToolStripMenuItem.Click
        loadform(New frm_POS_sales())
    End Sub

    Private Sub VATExemptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VATExemptToolStripMenuItem.Click
        loadform(New frm_scpwd())
    End Sub

    Private Sub NonCashToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NonCashToolStripMenuItem.Click
        loadform(New frm_check_details())
    End Sub

#End Region

#Region "Load child form helper (preserved)"

    Public Sub loadform(ByVal childForm As Form)
        If frm_dashboard_new.mainpanel.Controls.Count > 0 Then
            Dim old As Control = frm_dashboard_new.mainpanel.Controls(0)
            frm_dashboard_new.mainpanel.Controls.Remove(old)
            old.Dispose()
        End If
        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .AutoScaleMode = AutoScaleMode.Dpi
            .AutoSize = False
        End With
        frm_dashboard_new.mainpanel.Controls.Add(childForm)
        frm_dashboard_new.mainpanel.Tag = childForm
        childForm.Show()
        childForm.BringToFront()
    End Sub

#End Region

#Region "Overlay, Status, Resize helpers"

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
        loader.Location = New System.Drawing.Point(
            (pnlOverlay.Width - loader.Width) \ 2,
            (pnlOverlay.Height - loader.Height) \ 2 - 20)
        lblLoading.Location = New System.Drawing.Point(
            (pnlOverlay.Width - lblLoading.Width) \ 2,
             loader.Bottom + 10)
    End Sub

    Private Sub UpdateStatus(msg As String)
        lblStatus.Text = msg
    End Sub

    Private Sub frm_system_sales_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterOverlay()
    End Sub

    Private Sub ZreadingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZreadingToolStripMenuItem.Click
        frm_Zreading.Show()
    End Sub

#End Region

End Class
