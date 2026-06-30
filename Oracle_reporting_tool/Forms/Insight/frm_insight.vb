Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports LiveCharts
Imports LiveCharts.Wpf
Imports Guna.UI2.WinForms

Public Class frm_insight

#Region "Enum"

    Private Enum DateFilter
        Daily
        Weekly
        Monthly
        Quarterly
        Yearly
    End Enum

    Private _activeFilter As DateFilter = DateFilter.Daily
    Private _suppressReload As Boolean = False   ' prevents double-fire when populating combos

#End Region

#Region "Colors"

    Private ReadOnly clrBg As Color = Color.FromArgb(255, 245, 235)
    Private ReadOnly clrSurface2 As Color = Color.FromArgb(255, 235, 210)
    Private ReadOnly clrAccent As Color = Color.FromArgb(255, 224, 192)
    Private ReadOnly clrMuted As Color = Color.FromArgb(160, 120, 80)
    Private ReadOnly clrText As Color = Color.FromArgb(60, 35, 10)
    Private ReadOnly clrDeep As Color = Color.FromArgb(210, 140, 80)

    Private ReadOnly _sliceColors As Color() = {
        Color.FromArgb(255, 224, 192),
        Color.FromArgb(220, 160, 90),
        Color.FromArgb(200, 110, 60),
        Color.FromArgb(180, 80, 40),
        Color.FromArgb(240, 190, 130)
    }

#End Region

#Region "Form Load"

    Private Async Sub frm_insight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy")

        InitPickerData()          ' populate month / quarter / year combos
        ShowPickersForMode()      ' show correct pickers for Daily (default)

        AddHandler Me.Resize, Sub(s2, e2)
                                  lblDate.Location = New Point(pnlHeader.Width - lblDate.Width - 24, 26)
                                  RepositionKpiCards()
                                  FitChartControls()
                                  CenterOverlay()
                              End Sub

        Await LoadDataAsync()
    End Sub

    ''' <summary>
    ''' Populate cmbMonth (Jan–Dec), cmbQuarter (Q1–Q4), and cmbYear (5 years back to 1 ahead).
    ''' Uses _suppressReload to prevent ValueChanged from firing a query while filling.
    ''' </summary>
    Private Sub InitPickerData()
        _suppressReload = True

        ' Month names
        cmbMonth.Items.Clear()
        For m As Integer = 1 To 12
            cmbMonth.Items.Add(New MonthItem(m, New Date(2000, m, 1).ToString("MMMM")))
        Next
        cmbMonth.SelectedIndex = DateTime.Today.Month - 1   ' default = current month

        ' Quarters
        cmbQuarter.Items.Clear()
        cmbQuarter.Items.Add(New QuarterItem(1, "Q1  (Jan – Mar)"))
        cmbQuarter.Items.Add(New QuarterItem(2, "Q2  (Apr – Jun)"))
        cmbQuarter.Items.Add(New QuarterItem(3, "Q3  (Jul – Sep)"))
        cmbQuarter.Items.Add(New QuarterItem(4, "Q4  (Oct – Dec)"))
        cmbQuarter.SelectedIndex = CInt(Math.Ceiling(DateTime.Today.Month / 3.0)) - 1

        ' Years  (5 years back up to next year)
        cmbYear.Items.Clear()
        Dim thisYear = DateTime.Today.Year
        For y As Integer = thisYear - 3 To thisYear + 1
            cmbYear.Items.Add(y)
        Next
        cmbYear.SelectedItem = thisYear    ' default = current year

        ' Date picker default = today
        dtpDate.Value = DateTime.Today

        _suppressReload = False
    End Sub

#End Region

#Region "Picker helper types"

    ''' <summary>Item type for cmbMonth so we store month number alongside display name.</summary>
    Private Class MonthItem
        Public ReadOnly Number As Integer
        Private ReadOnly _name As String
        Public Sub New(num As Integer, name As String)
            Number = num : _name = name
        End Sub
        Public Overrides Function ToString() As String
            Return _name
        End Function
    End Class

    ''' <summary>Item type for cmbQuarter.</summary>
    Private Class QuarterItem
        Public ReadOnly Number As Integer
        Private ReadOnly _label As String
        Public Sub New(num As Integer, label As String)
            Number = num : _label = label
        End Sub
        Public Overrides Function ToString() As String
            Return _label
        End Function
    End Class

#End Region

#Region "Filter Button Click Handlers"

    Private Async Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        _activeFilter = DateFilter.Daily
        RefreshFilterStyles()
        ShowPickersForMode()
        Await LoadDataAsync()
    End Sub

    Private Async Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        _activeFilter = DateFilter.Weekly
        RefreshFilterStyles()
        ShowPickersForMode()
        Await LoadDataAsync()
    End Sub

    Private Async Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click
        _activeFilter = DateFilter.Monthly
        RefreshFilterStyles()
        ShowPickersForMode()
        Await LoadDataAsync()
    End Sub

    Private Async Sub btnQuarterly_Click(sender As Object, e As EventArgs) Handles btnQuarterly.Click
        _activeFilter = DateFilter.Quarterly
        RefreshFilterStyles()
        ShowPickersForMode()
        Await LoadDataAsync()
    End Sub

    Private Async Sub btnYearly_Click(sender As Object, e As EventArgs) Handles btnYearly.Click
        _activeFilter = DateFilter.Yearly
        RefreshFilterStyles()
        ShowPickersForMode()
        Await LoadDataAsync()
    End Sub

    ' ── Picker change handlers ────────────────────────────────────────

    Private Async Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If _suppressReload Then Return
        If _activeFilter = DateFilter.Daily OrElse _activeFilter = DateFilter.Weekly Then
            Await LoadDataAsync()
        End If
    End Sub

    Private Async Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        If _suppressReload Then Return
        Await LoadDataAsync()
    End Sub

    Private Async Sub cmbQuarter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbQuarter.SelectedIndexChanged
        If _suppressReload Then Return
        Await LoadDataAsync()
    End Sub

    Private Async Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        If _suppressReload Then Return
        Await LoadDataAsync()
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await LoadDataAsync()
    End Sub

    ' ── Style helpers ─────────────────────────────────────────────────

    Private Sub RefreshFilterStyles()
        Dim active = _activeFilter
        SetFilterStyle(btnDaily, active = DateFilter.Daily)
        SetFilterStyle(btnWeekly, active = DateFilter.Weekly)
        SetFilterStyle(btnMonthly, active = DateFilter.Monthly)
        SetFilterStyle(btnQuarterly, active = DateFilter.Quarterly)
        SetFilterStyle(btnYearly, active = DateFilter.Yearly)
    End Sub

    Private Sub SetFilterStyle(btn As Guna2Button, isActive As Boolean)
        btn.FillColor = If(isActive, clrAccent, clrSurface2)
        btn.ForeColor = If(isActive, clrText, clrMuted)
    End Sub

    ''' <summary>
    ''' Shows only the pickers relevant to the current filter mode.
    ''' Also updates the hint label text so users know what they're selecting.
    ''' 
    '''  Daily     → dtpDate only           "Pick a day:"
    '''  Weekly    → dtpDate only           "Pick any date in the week:"
    '''  Monthly   → cmbMonth + cmbYear     "Month / Year:"
    '''  Quarterly → cmbQuarter + cmbYear   "Quarter / Year:"
    '''  Yearly    → cmbYear only           "Year:"
    ''' </summary>
    Private Sub ShowPickersForMode()
        ' Hide all first
        dtpDate.Visible = False
        cmbMonth.Visible = False
        cmbQuarter.Visible = False
        cmbYear.Visible = False

        Select Case _activeFilter
            Case DateFilter.Daily
                lblPickerHint.Text = "Pick a day:"
                dtpDate.Visible = True
                cmbYear.Visible = False

            Case DateFilter.Weekly
                lblPickerHint.Text = "Any date in week:"
                dtpDate.Visible = True
                cmbYear.Visible = False

            Case DateFilter.Monthly
                lblPickerHint.Text = "Month / Year:"
                cmbMonth.Visible = True
                cmbYear.Visible = True
                ' Position year right after month
                cmbYear.Location = New Point(cmbMonth.Right + 8, cmbMonth.Top)

            Case DateFilter.Quarterly
                lblPickerHint.Text = "Quarter / Year:"
                cmbQuarter.Visible = True
                cmbYear.Visible = True
                cmbYear.Location = New Point(cmbQuarter.Right + 8, cmbQuarter.Top)

            Case DateFilter.Yearly
                lblPickerHint.Text = "Year:"
                cmbYear.Visible = True
                cmbYear.Location = New Point(578, cmbYear.Top)  ' leftmost position

        End Select
    End Sub

#End Region

#Region "Layout"

    Private Sub RepositionKpiCards()
        Dim usable = pnlKpiRow.Width - 40
        Dim gap = 14
        Dim w = (usable - gap * 3) \ 4
        cardRevenue.Width = w : cardRevenue.Location = New Point(20, 14)
        cardNetsales.Width = w : cardNetsales.Location = New Point(20 + (w + gap), 14)
        cardAvgOrder.Width = w : cardAvgOrder.Location = New Point(20 + (w + gap) * 2, 14)
        cardTxnCount.Width = w : cardTxnCount.Location = New Point(20 + (w + gap) * 3, 14)
    End Sub

    Private Sub FitChartControls()
        TrendChart.Size = New Size(pnlTrend.Width - 16, pnlTrend.Height - 50)
        PieChartDonuts.Size = New Size(pnlDonuts.Width - 8, pnlDonuts.Height - 50)
        PieChartBeverages.Size = New Size(pnlBeverages.Width - 8, pnlBeverages.Height - 50)
    End Sub

    Private Sub CenterOverlay()
        loader.Location = New Point((pnlOverlay.Width - loader.Width) \ 2,
                                        (pnlOverlay.Height - loader.Height) \ 2 - 20)
        lblLoading.Location = New Point((pnlOverlay.Width - lblLoading.Width) \ 2,
                                         loader.Bottom + 10)
    End Sub

#End Region

#Region "Overlay"

    Private Sub ShowLoader(show As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ShowLoader(show))
            Return
        End If
        pnlOverlay.Visible = show
        If show Then
            pnlOverlay.BringToFront()
            CenterOverlay()
        End If
    End Sub

#End Region

#Region "Date Range Logic"

    ''' <summary>
    ''' Returns the correct (startDate, endDate) pair for every filter mode.
    ''' 
    ''' Daily      → the single day chosen in dtpDate
    ''' Weekly     → Mon–Sun of the week that contains dtpDate
    ''' Monthly    → 1st to last day of cmbMonth + cmbYear
    ''' Quarterly  → first to last day of cmbQuarter + cmbYear
    ''' Yearly     → Jan 1 to Dec 31 of cmbYear
    ''' </summary>
    Private Function GetDateRange() As Tuple(Of Date, Date)

        Select Case _activeFilter

            Case DateFilter.Daily
                Dim d = dtpDate.Value.Date
                Return Tuple.Create(d, d)

            Case DateFilter.Weekly
                ' Any date inside the desired week — resolve to Mon..Sun
                Dim anchor = dtpDate.Value.Date
                Dim dow = If(anchor.DayOfWeek = DayOfWeek.Sunday, 7, CInt(anchor.DayOfWeek))
                Dim monday = anchor.AddDays(-(dow - 1))
                Return Tuple.Create(monday, monday.AddDays(6))

            Case DateFilter.Monthly
                Dim year = SelectedYear()
                Dim month = SelectedMonth()
                Dim first = New Date(year, month, 1)
                Return Tuple.Create(first, first.AddMonths(1).AddDays(-1))

            Case DateFilter.Quarterly
                Dim year = SelectedYear()
                Dim quarter = SelectedQuarter()
                Dim qFirst = New Date(year, (quarter - 1) * 3 + 1, 1)
                Return Tuple.Create(qFirst, qFirst.AddMonths(3).AddDays(-1))

            Case DateFilter.Yearly
                Dim year = SelectedYear()
                Return Tuple.Create(New Date(year, 1, 1), New Date(year, 12, 31))

            Case Else
                Dim d = DateTime.Today
                Return Tuple.Create(d, d)

        End Select
    End Function

    ' ── Combo value helpers ───────────────────────────────────────────

    Private Function SelectedYear() As Integer
        If cmbYear.SelectedItem IsNot Nothing Then
            Return CInt(cmbYear.SelectedItem)
        End If
        Return DateTime.Today.Year
    End Function

    Private Function SelectedMonth() As Integer
        If cmbMonth.SelectedItem IsNot Nothing Then
            Return DirectCast(cmbMonth.SelectedItem, MonthItem).Number
        End If
        Return DateTime.Today.Month
    End Function

    Private Function SelectedQuarter() As Integer
        If cmbQuarter.SelectedItem IsNot Nothing Then
            Return DirectCast(cmbQuarter.SelectedItem, QuarterItem).Number
        End If
        Return CInt(Math.Ceiling(DateTime.Today.Month / 3.0))
    End Function

#End Region

#Region "Data Loading"

    Private Async Function LoadDataAsync() As Task
        ShowLoader(True)
        Try
            Dim range = GetDateRange()
            Dim startDate As Date = range.Item1
            Dim endDate As Date = range.Item2

            ' Update trend card title to show the selected range
            lblTrendTitle.Text = $"<b>Net Sales Trend</b>  " &
                                 $"<span style='font-size:8pt;color:rgb(160,120,80)'>" &
                                 $"{startDate:MMM dd, yyyy}  –  {endDate:MMM dd, yyyy}</span>"

            Dim tDonuts As Task(Of DataTable) = Task.Run(Function() GetTopItemsData(startDate, endDate, "Ring", "Shell"))
            Dim tBev As Task(Of DataTable) = Task.Run(Function() GetTopItemsData(startDate, endDate, "Beverage"))
            Dim tTrend As Task(Of DataTable) = Task.Run(Function() GetTrendData(startDate, endDate))
            Dim tRev As Task(Of Decimal) = GetRevenueAsync(startDate, endDate)
            Dim tNet As Task(Of Decimal) = GetNetsalesAsync(startDate, endDate)
            Dim tAvg As Task(Of Decimal) = GetAvgOrderAsync(startDate, endDate)
            Dim tTxn As Task(Of Integer) = GetTransactionCountAsync(startDate, endDate)

            Await Task.WhenAll(tDonuts, tBev, tTrend, tRev, tNet, tAvg, tTxn)

            BindPieChart(tDonuts.Result, PieChartDonuts)
            BindPieChart(tBev.Result, PieChartBeverages)
            BindTrendChart(tTrend.Result)

            Await AnimateKpiLabel(lblRevenue, FormatPeso(tRev.Result))
            Await AnimateKpiLabel(lblNetsales, FormatPeso(tNet.Result))
            Await AnimateKpiLabel(lblAvgOrder, FormatPeso(tAvg.Result))
            Await AnimateKpiLabel(lblTxnCount, tTxn.Result.ToString("#,##0"))

            lblLastRefresh.Text = "Last refreshed: " & DateTime.Now.ToString("hh:mm:ss tt")
            FitChartControls()

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Dashboard Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ShowLoader(False)
        End Try
    End Function

    Private Function FormatPeso(value As Decimal) As String
        Return "P " & value.ToString("#,##0.00")
    End Function

#End Region

#Region "SQL"

    Private Function ConnStr() As String
        Return ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString
    End Function

    Private Function GetTopItemsData(startDate As Date, endDate As Date,
                                     ParamArray categories() As String) As DataTable
        Dim dt As New DataTable()
        If categories Is Nothing OrElse categories.Length = 0 Then Return dt

        Dim paramNames = Enumerable.Range(0, categories.Length).Select(Function(i) "@cat" & i).ToList()
        Dim query = "SELECT TOP 5 ItemName, SUM(qty) AS TotalSold " &
                    "FROM v_itemdetail " &
                    "WHERE Category IN (" & String.Join(",", paramNames) & ") " &
                    "  AND CAST(DetailPostingTime AS DATE) BETWEEN @start AND @end " &
                    "GROUP BY ItemName ORDER BY TotalSold DESC"

        Using con As New SqlConnection(ConnStr()), cmd As New SqlCommand(query, con)
            For i = 0 To categories.Length - 1
                cmd.Parameters.AddWithValue("@cat" & i, categories(i))
            Next
            cmd.Parameters.AddWithValue("@start", startDate)
            cmd.Parameters.AddWithValue("@end", endDate)
            Using da As New SqlDataAdapter(cmd) : da.Fill(dt) : End Using
        End Using
        Return dt
    End Function

    Private Function GetTrendData(startDate As Date, endDate As Date) As DataTable
        Dim dt As New DataTable()
        Dim query As String

        If _activeFilter = DateFilter.Quarterly OrElse _activeFilter = DateFilter.Yearly Then
            ' Group by month
            query = "SELECT FORMAT(BusinessDate,'MMM yyyy') AS DayLabel, " &
                    "YEAR(BusinessDate) AS yr, MONTH(BusinessDate) AS mo, " &
                    "SUM(qty * Netsales) AS Netsales " &
                    "FROM v_salesdetails " &
                    "WHERE BusinessDate BETWEEN @start AND @end AND Transtype='Item Sale' " &
                    "GROUP BY FORMAT(BusinessDate,'MMM yyyy'),YEAR(BusinessDate),MONTH(BusinessDate) " &
                    "ORDER BY yr, mo"
        Else
            ' Group by day
            query = "SELECT CONVERT(VARCHAR,CAST(BusinessDate AS DATE),107) AS DayLabel, " &
                    "CAST(BusinessDate AS DATE) AS SortKey, " &
                    "SUM(qty * Netsales) AS Netsales " &
                    "FROM v_salesdetails " &
                    "WHERE BusinessDate BETWEEN @start AND @end AND Transtype='Item Sale' " &
                    "GROUP BY CAST(BusinessDate AS DATE) ORDER BY SortKey"
        End If

        Using con As New SqlConnection(ConnStr()), cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@start", startDate)
            cmd.Parameters.AddWithValue("@end", endDate)
            con.Open()
            Using da As New SqlDataAdapter(cmd) : da.Fill(dt) : End Using
        End Using
        Return dt
    End Function

    Private Async Function GetRevenueAsync(s As Date, e As Date) As Task(Of Decimal)
        Dim q = "SELECT SUM(Netsales+taxcollected-lessNationalAth-lessSoloparent-other_disc) " &
                "FROM v_salesdetails WHERE CAST(businessdate AS DATE) BETWEEN @start AND @end"
        Using conn As New SqlConnection(ConnStr()), cmd As New SqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@start", s) : cmd.Parameters.AddWithValue("@end", e)
            Await conn.OpenAsync()
            Dim r = Await cmd.ExecuteScalarAsync()
            Return If(IsDBNull(r) OrElse r Is Nothing, 0D, Convert.ToDecimal(r))
        End Using
    End Function

    Private Async Function GetNetsalesAsync(s As Date, e As Date) As Task(Of Decimal)
        Dim q = "SELECT SUM(Netsales) FROM v_salesdetails " &
                "WHERE CAST(businessdate AS DATE) BETWEEN @start AND @end"
        Using conn As New SqlConnection(ConnStr()), cmd As New SqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@start", s) : cmd.Parameters.AddWithValue("@end", e)
            Await conn.OpenAsync()
            Dim r = Await cmd.ExecuteScalarAsync()
            Return If(IsDBNull(r) OrElse r Is Nothing, 0D, Convert.ToDecimal(r))
        End Using
    End Function

    Private Async Function GetAvgOrderAsync(s As Date, e As Date) As Task(Of Decimal)
        Dim q = "SELECT AVG(Netsales) FROM v_salesdetails " &
                "WHERE CAST(businessdate AS DATE) BETWEEN @start AND @end AND Transtype='Item Sale'"
        Using conn As New SqlConnection(ConnStr()), cmd As New SqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@start", s) : cmd.Parameters.AddWithValue("@end", e)
            Await conn.OpenAsync()
            Dim r = Await cmd.ExecuteScalarAsync()
            Return If(IsDBNull(r) OrElse r Is Nothing, 0D, Convert.ToDecimal(r))
        End Using
    End Function

    Private Async Function GetTransactionCountAsync(s As Date, e As Date) As Task(Of Integer)
        Dim q = "SELECT COUNT(DISTINCT CheckNumber) FROM v_salesdetails AS sd WHERE CAST(businessdate AS DATE) BETWEEN @start AND @end AND Transtype = 'Item Sale' AND NOT EXISTS ( SELECT 1 FROM v_salesdetails AS sd_ex WHERE sd_ex.CheckNumber = sd.CheckNumber AND sd_ex.ObjectNumber = 1101)"
        Using conn As New SqlConnection(ConnStr()), cmd As New SqlCommand(q, conn)
            cmd.Parameters.AddWithValue("@start", s)
            cmd.Parameters.AddWithValue("@end", e)
            Await conn.OpenAsync()
            Dim r = Await cmd.ExecuteScalarAsync()
            Return If(IsDBNull(r) OrElse r Is Nothing, 0, Convert.ToInt32(r))
        End Using
    End Function

#End Region

#Region "Chart Binding"

    Private Sub BindPieChart(dt As DataTable, chart As LiveCharts.WinForms.PieChart)
        Dim col As New SeriesCollection()
        Dim idx As Integer = 0
        For Each row As DataRow In dt.Rows
            Dim c = _sliceColors(idx Mod _sliceColors.Length)
            col.Add(New PieSeries With {
                .Title = row("ItemName").ToString(),
                .Values = New ChartValues(Of Double)({Convert.ToDouble(row("TotalSold"))}),
                .DataLabels = True,
                .LabelPoint = Function(p) p.Y.ToString("N0"),
                .Fill = New System.Windows.Media.SolidColorBrush(
                                  System.Windows.Media.Color.FromArgb(c.A, c.R, c.G, c.B))
            })
            idx += 1
        Next
        chart.Series = col
        chart.InnerRadius = 55
        chart.LegendLocation = LegendLocation.Bottom
        chart.AnimationsSpeed = TimeSpan.FromMilliseconds(500)
        chart.BackColor = Color.Transparent
    End Sub

    Private Sub BindTrendChart(dt As DataTable)
        Dim values As New ChartValues(Of Double)()
        Dim labels As New List(Of String)()
        Dim colName As String = If(dt.Columns.Contains("DayLabel"), "DayLabel", "MonthLabel")

        For Each row As DataRow In dt.Rows
            values.Add(Convert.ToDouble(row("Netsales")))
            labels.Add(row(colName).ToString())
        Next

        Dim grad As New System.Windows.Media.LinearGradientBrush()
        grad.StartPoint = New System.Windows.Point(0, 0)
        grad.EndPoint = New System.Windows.Point(0, 1)
        grad.GradientStops.Add(New System.Windows.Media.GradientStop(
            System.Windows.Media.Color.FromArgb(140, 255, 224, 192), 0))
        grad.GradientStops.Add(New System.Windows.Media.GradientStop(
            System.Windows.Media.Color.FromArgb(0, 255, 224, 192), 1))

        Dim lineBrush = New System.Windows.Media.SolidColorBrush(
                            System.Windows.Media.Color.FromRgb(210, 140, 80))
        Dim axFore = New System.Windows.Media.SolidColorBrush(
                            System.Windows.Media.Color.FromRgb(160, 120, 80))
        Dim sepBrush = New System.Windows.Media.SolidColorBrush(
                            System.Windows.Media.Color.FromArgb(40, 180, 120, 60))

        TrendChart.Series = New SeriesCollection From {
            New LineSeries With {
                .Title = "Net Sales",
                .Values = values,
                .PointGeometry = DefaultGeometries.Circle,
                .PointGeometrySize = 8,
                .LineSmoothness = 0.4,
                .Stroke = lineBrush,
                .Fill = grad,
                .LabelPoint = Function(p) "P" & p.Y.ToString("N0")
            }
        }

        TrendChart.AxisX.Clear()
        TrendChart.AxisX.Add(New Axis With {
            .Labels = labels,
            .LabelsRotation = -30,
            .FontSize = 9,
            .Foreground = axFore,
            .Separator = New Separator With {.StrokeThickness = 0.5, .Stroke = sepBrush}
        })
        TrendChart.AxisY.Clear()
        TrendChart.AxisY.Add(New Axis With {
            .LabelFormatter = Function(v) "P" & v.ToString("N0"),
            .FontSize = 9,
            .Foreground = axFore,
            .Separator = New Separator With {.StrokeThickness = 0.5, .Stroke = sepBrush}
        })
        TrendChart.BackColor = Color.Transparent
    End Sub

#End Region

#Region "Helpers"

    Private Async Function AnimateKpiLabel(lbl As Guna2HtmlLabel, finalValue As String) As Task
        For i = 1 To 10
            Await Task.Delay(16)
            lbl.Text = If(i < 10, New String(CChar("*"), Math.Min(i + 2, 8)), finalValue)
        Next
    End Function

#End Region

End Class
