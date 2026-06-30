<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_insight
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubtitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlFilterBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnDaily = New Guna.UI2.WinForms.Guna2Button()
        Me.btnWeekly = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMonthly = New Guna.UI2.WinForms.Guna2Button()
        Me.btnQuarterly = New Guna.UI2.WinForms.Guna2Button()
        Me.btnYearly = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPickerHint = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cmbMonth = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbQuarter = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pnlKpiRow = New Guna.UI2.WinForms.Guna2Panel()
        Me.cardRevenue = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeRevenue = New System.Windows.Forms.Panel()
        Me.lblRevenueLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRevenue = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardNetsales = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeNetsales = New System.Windows.Forms.Panel()
        Me.lblNetsalesLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblNetsales = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardAvgOrder = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeAvg = New System.Windows.Forms.Panel()
        Me.lblAvgLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblAvgOrder = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardTxnCount = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeTxn = New System.Windows.Forms.Panel()
        Me.lblTxnLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTxnCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlChartsOuter = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTrend = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTrendTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TrendChart = New LiveCharts.WinForms.CartesianChart()
        Me.pnlDonuts = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDonutTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PieChartDonuts = New LiveCharts.WinForms.PieChart()
        Me.pnlBeverages = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBevTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PieChartBeverages = New LiveCharts.WinForms.PieChart()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLastRefresh = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFilterBar.SuspendLayout()
        Me.pnlKpiRow.SuspendLayout()
        Me.cardRevenue.SuspendLayout()
        Me.cardNetsales.SuspendLayout()
        Me.cardAvgOrder.SuspendLayout()
        Me.cardTxnCount.SuspendLayout()
        Me.pnlChartsOuter.SuspendLayout()
        Me.pnlTrend.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlDonuts.SuspendLayout()
        Me.pnlBeverages.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblDate)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(24, 0, 24, 0)
        Me.pnlHeader.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlHeader.ShadowDecoration.Depth = 8
        Me.pnlHeader.ShadowDecoration.Enabled = True
        Me.pnlHeader.Size = New System.Drawing.Size(1280, 68)
        Me.pnlHeader.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(24, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(213, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>Insight Dashboard</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(29, 40)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(197, 21)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Business Performance Overview"
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(2160, 26)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(163, 21)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Monday, January 01 2025"
        '
        'pnlFilterBar
        '
        Me.pnlFilterBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlFilterBar.Controls.Add(Me.btnDaily)
        Me.pnlFilterBar.Controls.Add(Me.btnWeekly)
        Me.pnlFilterBar.Controls.Add(Me.btnMonthly)
        Me.pnlFilterBar.Controls.Add(Me.btnQuarterly)
        Me.pnlFilterBar.Controls.Add(Me.btnYearly)
        Me.pnlFilterBar.Controls.Add(Me.lblPickerHint)
        Me.pnlFilterBar.Controls.Add(Me.dtpDate)
        Me.pnlFilterBar.Controls.Add(Me.cmbMonth)
        Me.pnlFilterBar.Controls.Add(Me.cmbQuarter)
        Me.pnlFilterBar.Controls.Add(Me.cmbYear)
        Me.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilterBar.Location = New System.Drawing.Point(0, 68)
        Me.pnlFilterBar.Name = "pnlFilterBar"
        Me.pnlFilterBar.Size = New System.Drawing.Size(1280, 58)
        Me.pnlFilterBar.TabIndex = 2
        '
        'btnDaily
        '
        Me.btnDaily.BorderRadius = 16
        Me.btnDaily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDaily.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnDaily.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDaily.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.btnDaily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnDaily.Location = New System.Drawing.Point(20, 13)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(92, 32)
        Me.btnDaily.TabIndex = 0
        Me.btnDaily.Text = "Daily"
        '
        'btnWeekly
        '
        Me.btnWeekly.BorderRadius = 16
        Me.btnWeekly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWeekly.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnWeekly.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnWeekly.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.btnWeekly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnWeekly.Location = New System.Drawing.Point(120, 13)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.Size = New System.Drawing.Size(92, 32)
        Me.btnWeekly.TabIndex = 1
        Me.btnWeekly.Text = "Weekly"
        '
        'btnMonthly
        '
        Me.btnMonthly.BorderRadius = 16
        Me.btnMonthly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonthly.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnMonthly.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMonthly.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.btnMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMonthly.Location = New System.Drawing.Point(220, 13)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(92, 32)
        Me.btnMonthly.TabIndex = 2
        Me.btnMonthly.Text = "Monthly"
        '
        'btnQuarterly
        '
        Me.btnQuarterly.BorderRadius = 16
        Me.btnQuarterly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuarterly.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnQuarterly.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnQuarterly.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.btnQuarterly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnQuarterly.Location = New System.Drawing.Point(318, 13)
        Me.btnQuarterly.Name = "btnQuarterly"
        Me.btnQuarterly.Size = New System.Drawing.Size(101, 32)
        Me.btnQuarterly.TabIndex = 3
        Me.btnQuarterly.Text = "Quarterly"
        '
        'btnYearly
        '
        Me.btnYearly.BorderRadius = 16
        Me.btnYearly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYearly.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.btnYearly.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnYearly.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.btnYearly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnYearly.Location = New System.Drawing.Point(424, 13)
        Me.btnYearly.Name = "btnYearly"
        Me.btnYearly.Size = New System.Drawing.Size(92, 32)
        Me.btnYearly.TabIndex = 4
        Me.btnYearly.Text = "Yearly"
        '
        'lblPickerHint
        '
        Me.lblPickerHint.BackColor = System.Drawing.Color.Transparent
        Me.lblPickerHint.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblPickerHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblPickerHint.Location = New System.Drawing.Point(536, 19)
        Me.lblPickerHint.Name = "lblPickerHint"
        Me.lblPickerHint.Size = New System.Drawing.Size(35, 21)
        Me.lblPickerHint.TabIndex = 5
        Me.lblPickerHint.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtpDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.dtpDate.Checked = True
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.dtpDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(653, 13)
        Me.dtpDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(148, 32)
        Me.dtpDate.TabIndex = 6
        Me.dtpDate.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'cmbMonth
        '
        Me.cmbMonth.BackColor = System.Drawing.Color.Transparent
        Me.cmbMonth.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.cmbMonth.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMonth.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbMonth.ItemHeight = 26
        Me.cmbMonth.Location = New System.Drawing.Point(632, 13)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(120, 32)
        Me.cmbMonth.TabIndex = 7
        Me.cmbMonth.Visible = False
        '
        'cmbQuarter
        '
        Me.cmbQuarter.BackColor = System.Drawing.Color.Transparent
        Me.cmbQuarter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.cmbQuarter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuarter.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.cmbQuarter.FocusedColor = System.Drawing.Color.Empty
        Me.cmbQuarter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cmbQuarter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbQuarter.ItemHeight = 26
        Me.cmbQuarter.Location = New System.Drawing.Point(632, 13)
        Me.cmbQuarter.Name = "cmbQuarter"
        Me.cmbQuarter.Size = New System.Drawing.Size(148, 32)
        Me.cmbQuarter.TabIndex = 8
        Me.cmbQuarter.Visible = False
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbYear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.cmbYear.FocusedColor = System.Drawing.Color.Empty
        Me.cmbYear.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cmbYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbYear.ItemHeight = 26
        Me.cmbYear.Location = New System.Drawing.Point(782, 13)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(90, 32)
        Me.cmbYear.TabIndex = 9
        Me.cmbYear.Visible = False
        '
        'pnlKpiRow
        '
        Me.pnlKpiRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlKpiRow.Controls.Add(Me.cardRevenue)
        Me.pnlKpiRow.Controls.Add(Me.cardNetsales)
        Me.pnlKpiRow.Controls.Add(Me.cardAvgOrder)
        Me.pnlKpiRow.Controls.Add(Me.cardTxnCount)
        Me.pnlKpiRow.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlKpiRow.Location = New System.Drawing.Point(0, 126)
        Me.pnlKpiRow.Name = "pnlKpiRow"
        Me.pnlKpiRow.Size = New System.Drawing.Size(1280, 118)
        Me.pnlKpiRow.TabIndex = 1
        '
        'cardRevenue
        '
        Me.cardRevenue.BackColor = System.Drawing.Color.Transparent
        Me.cardRevenue.BorderRadius = 14
        Me.cardRevenue.Controls.Add(Me.stripeRevenue)
        Me.cardRevenue.Controls.Add(Me.lblRevenueLbl)
        Me.cardRevenue.Controls.Add(Me.lblRevenue)
        Me.cardRevenue.Location = New System.Drawing.Point(20, 14)
        Me.cardRevenue.Name = "cardRevenue"
        Me.cardRevenue.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.cardRevenue.ShadowDecoration.Depth = 6
        Me.cardRevenue.ShadowDecoration.Enabled = True
        Me.cardRevenue.Size = New System.Drawing.Size(280, 90)
        Me.cardRevenue.TabIndex = 0
        '
        'stripeRevenue
        '
        Me.stripeRevenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.stripeRevenue.Location = New System.Drawing.Point(14, 19)
        Me.stripeRevenue.Name = "stripeRevenue"
        Me.stripeRevenue.Size = New System.Drawing.Size(4, 52)
        Me.stripeRevenue.TabIndex = 0
        '
        'lblRevenueLbl
        '
        Me.lblRevenueLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblRevenueLbl.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblRevenueLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblRevenueLbl.Location = New System.Drawing.Point(26, 16)
        Me.lblRevenueLbl.Name = "lblRevenueLbl"
        Me.lblRevenueLbl.Size = New System.Drawing.Size(85, 19)
        Me.lblRevenueLbl.TabIndex = 1
        Me.lblRevenueLbl.Text = "Total Revenue"
        '
        'lblRevenue
        '
        Me.lblRevenue.BackColor = System.Drawing.Color.Transparent
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblRevenue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblRevenue.Location = New System.Drawing.Point(26, 36)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(73, 37)
        Me.lblRevenue.TabIndex = 2
        Me.lblRevenue.Text = "P 0.00"
        '
        'cardNetsales
        '
        Me.cardNetsales.BackColor = System.Drawing.Color.Transparent
        Me.cardNetsales.BorderRadius = 14
        Me.cardNetsales.Controls.Add(Me.stripeNetsales)
        Me.cardNetsales.Controls.Add(Me.lblNetsalesLbl)
        Me.cardNetsales.Controls.Add(Me.lblNetsales)
        Me.cardNetsales.Location = New System.Drawing.Point(314, 14)
        Me.cardNetsales.Name = "cardNetsales"
        Me.cardNetsales.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cardNetsales.ShadowDecoration.Depth = 6
        Me.cardNetsales.ShadowDecoration.Enabled = True
        Me.cardNetsales.Size = New System.Drawing.Size(280, 90)
        Me.cardNetsales.TabIndex = 1
        '
        'stripeNetsales
        '
        Me.stripeNetsales.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.stripeNetsales.Location = New System.Drawing.Point(14, 19)
        Me.stripeNetsales.Name = "stripeNetsales"
        Me.stripeNetsales.Size = New System.Drawing.Size(4, 52)
        Me.stripeNetsales.TabIndex = 0
        '
        'lblNetsalesLbl
        '
        Me.lblNetsalesLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblNetsalesLbl.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNetsalesLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblNetsalesLbl.Location = New System.Drawing.Point(26, 16)
        Me.lblNetsalesLbl.Name = "lblNetsalesLbl"
        Me.lblNetsalesLbl.Size = New System.Drawing.Size(58, 19)
        Me.lblNetsalesLbl.TabIndex = 1
        Me.lblNetsalesLbl.Text = "Net Sales"
        '
        'lblNetsales
        '
        Me.lblNetsales.BackColor = System.Drawing.Color.Transparent
        Me.lblNetsales.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblNetsales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblNetsales.Location = New System.Drawing.Point(26, 36)
        Me.lblNetsales.Name = "lblNetsales"
        Me.lblNetsales.Size = New System.Drawing.Size(73, 37)
        Me.lblNetsales.TabIndex = 2
        Me.lblNetsales.Text = "P 0.00"
        '
        'cardAvgOrder
        '
        Me.cardAvgOrder.BackColor = System.Drawing.Color.Transparent
        Me.cardAvgOrder.BorderRadius = 14
        Me.cardAvgOrder.Controls.Add(Me.stripeAvg)
        Me.cardAvgOrder.Controls.Add(Me.lblAvgLbl)
        Me.cardAvgOrder.Controls.Add(Me.lblAvgOrder)
        Me.cardAvgOrder.Location = New System.Drawing.Point(608, 14)
        Me.cardAvgOrder.Name = "cardAvgOrder"
        Me.cardAvgOrder.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.cardAvgOrder.ShadowDecoration.Depth = 6
        Me.cardAvgOrder.ShadowDecoration.Enabled = True
        Me.cardAvgOrder.Size = New System.Drawing.Size(280, 90)
        Me.cardAvgOrder.TabIndex = 2
        '
        'stripeAvg
        '
        Me.stripeAvg.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.stripeAvg.Location = New System.Drawing.Point(14, 19)
        Me.stripeAvg.Name = "stripeAvg"
        Me.stripeAvg.Size = New System.Drawing.Size(4, 52)
        Me.stripeAvg.TabIndex = 0
        '
        'lblAvgLbl
        '
        Me.lblAvgLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgLbl.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblAvgLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblAvgLbl.Location = New System.Drawing.Point(26, 16)
        Me.lblAvgLbl.Name = "lblAvgLbl"
        Me.lblAvgLbl.Size = New System.Drawing.Size(103, 19)
        Me.lblAvgLbl.TabIndex = 1
        Me.lblAvgLbl.Text = "Avg. Order Value"
        '
        'lblAvgOrder
        '
        Me.lblAvgOrder.BackColor = System.Drawing.Color.Transparent
        Me.lblAvgOrder.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblAvgOrder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblAvgOrder.Location = New System.Drawing.Point(26, 36)
        Me.lblAvgOrder.Name = "lblAvgOrder"
        Me.lblAvgOrder.Size = New System.Drawing.Size(73, 37)
        Me.lblAvgOrder.TabIndex = 2
        Me.lblAvgOrder.Text = "P 0.00"
        '
        'cardTxnCount
        '
        Me.cardTxnCount.BackColor = System.Drawing.Color.Transparent
        Me.cardTxnCount.BorderRadius = 14
        Me.cardTxnCount.Controls.Add(Me.stripeTxn)
        Me.cardTxnCount.Controls.Add(Me.lblTxnLbl)
        Me.cardTxnCount.Controls.Add(Me.lblTxnCount)
        Me.cardTxnCount.Location = New System.Drawing.Point(902, 14)
        Me.cardTxnCount.Name = "cardTxnCount"
        Me.cardTxnCount.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cardTxnCount.ShadowDecoration.Depth = 6
        Me.cardTxnCount.ShadowDecoration.Enabled = True
        Me.cardTxnCount.Size = New System.Drawing.Size(280, 90)
        Me.cardTxnCount.TabIndex = 3
        '
        'stripeTxn
        '
        Me.stripeTxn.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.stripeTxn.Location = New System.Drawing.Point(14, 19)
        Me.stripeTxn.Name = "stripeTxn"
        Me.stripeTxn.Size = New System.Drawing.Size(4, 52)
        Me.stripeTxn.TabIndex = 0
        '
        'lblTxnLbl
        '
        Me.lblTxnLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblTxnLbl.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTxnLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTxnLbl.Location = New System.Drawing.Point(26, 16)
        Me.lblTxnLbl.Name = "lblTxnLbl"
        Me.lblTxnLbl.Size = New System.Drawing.Size(97, 19)
        Me.lblTxnLbl.TabIndex = 1
        Me.lblTxnLbl.Text = "Customer Count"
        '
        'lblTxnCount
        '
        Me.lblTxnCount.BackColor = System.Drawing.Color.Transparent
        Me.lblTxnCount.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!)
        Me.lblTxnCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblTxnCount.Location = New System.Drawing.Point(26, 36)
        Me.lblTxnCount.Name = "lblTxnCount"
        Me.lblTxnCount.Size = New System.Drawing.Size(17, 37)
        Me.lblTxnCount.TabIndex = 2
        Me.lblTxnCount.Text = "0"
        '
        'pnlChartsOuter
        '
        Me.pnlChartsOuter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlChartsOuter.ColumnCount = 2
        Me.pnlChartsOuter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlChartsOuter.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlChartsOuter.Controls.Add(Me.pnlTrend, 0, 0)
        Me.pnlChartsOuter.Controls.Add(Me.pnlDonuts, 0, 1)
        Me.pnlChartsOuter.Controls.Add(Me.pnlBeverages, 1, 1)
        Me.pnlChartsOuter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChartsOuter.Location = New System.Drawing.Point(0, 244)
        Me.pnlChartsOuter.Name = "pnlChartsOuter"
        Me.pnlChartsOuter.Padding = New System.Windows.Forms.Padding(14, 10, 14, 10)
        Me.pnlChartsOuter.RowCount = 2
        Me.pnlChartsOuter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.pnlChartsOuter.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.pnlChartsOuter.Size = New System.Drawing.Size(1280, 532)
        Me.pnlChartsOuter.TabIndex = 0
        '
        'pnlTrend
        '
        Me.pnlTrend.BackColor = System.Drawing.Color.Transparent
        Me.pnlTrend.BorderRadius = 14
        Me.pnlChartsOuter.SetColumnSpan(Me.pnlTrend, 2)
        Me.pnlTrend.Controls.Add(Me.Guna2Panel1)
        Me.pnlTrend.Controls.Add(Me.TrendChart)
        Me.pnlTrend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTrend.Location = New System.Drawing.Point(14, 10)
        Me.pnlTrend.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.pnlTrend.Name = "pnlTrend"
        Me.pnlTrend.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTrend.ShadowDecoration.Depth = 6
        Me.pnlTrend.ShadowDecoration.Enabled = True
        Me.pnlTrend.Size = New System.Drawing.Size(1252, 275)
        Me.pnlTrend.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 14
        Me.Guna2Panel1.Controls.Add(Me.lblTrendTitle)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel1.ShadowDecoration.Depth = 6
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.Size = New System.Drawing.Size(1252, 30)
        Me.Guna2Panel1.TabIndex = 2
        '
        'lblTrendTitle
        '
        Me.lblTrendTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTrendTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblTrendTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblTrendTitle.Location = New System.Drawing.Point(13, 3)
        Me.lblTrendTitle.Name = "lblTrendTitle"
        Me.lblTrendTitle.Size = New System.Drawing.Size(123, 25)
        Me.lblTrendTitle.TabIndex = 0
        Me.lblTrendTitle.Text = "<b>Net Sales Trend</b>"
        '
        'TrendChart
        '
        Me.TrendChart.BackColor = System.Drawing.Color.Transparent
        Me.TrendChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrendChart.Location = New System.Drawing.Point(0, 0)
        Me.TrendChart.Name = "TrendChart"
        Me.TrendChart.Size = New System.Drawing.Size(1252, 275)
        Me.TrendChart.TabIndex = 1
        '
        'pnlDonuts
        '
        Me.pnlDonuts.BackColor = System.Drawing.Color.Transparent
        Me.pnlDonuts.BorderRadius = 14
        Me.pnlDonuts.Controls.Add(Me.lblDonutTitle)
        Me.pnlDonuts.Controls.Add(Me.PieChartDonuts)
        Me.pnlDonuts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDonuts.Location = New System.Drawing.Point(14, 297)
        Me.pnlDonuts.Margin = New System.Windows.Forms.Padding(0, 6, 6, 0)
        Me.pnlDonuts.Name = "pnlDonuts"
        Me.pnlDonuts.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlDonuts.ShadowDecoration.Depth = 6
        Me.pnlDonuts.ShadowDecoration.Enabled = True
        Me.pnlDonuts.Size = New System.Drawing.Size(620, 225)
        Me.pnlDonuts.TabIndex = 1
        '
        'lblDonutTitle
        '
        Me.lblDonutTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDonutTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblDonutTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblDonutTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblDonutTitle.Name = "lblDonutTitle"
        Me.lblDonutTitle.Size = New System.Drawing.Size(182, 25)
        Me.lblDonutTitle.TabIndex = 0
        Me.lblDonutTitle.Text = "<b>Top Rings &amp; Shells Sold</b>"
        '
        'PieChartDonuts
        '
        Me.PieChartDonuts.BackColor = System.Drawing.Color.Transparent
        Me.PieChartDonuts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PieChartDonuts.Location = New System.Drawing.Point(0, 0)
        Me.PieChartDonuts.Name = "PieChartDonuts"
        Me.PieChartDonuts.Size = New System.Drawing.Size(620, 225)
        Me.PieChartDonuts.TabIndex = 1
        '
        'pnlBeverages
        '
        Me.pnlBeverages.BackColor = System.Drawing.Color.Transparent
        Me.pnlBeverages.BorderRadius = 14
        Me.pnlBeverages.Controls.Add(Me.lblBevTitle)
        Me.pnlBeverages.Controls.Add(Me.PieChartBeverages)
        Me.pnlBeverages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBeverages.Location = New System.Drawing.Point(646, 297)
        Me.pnlBeverages.Margin = New System.Windows.Forms.Padding(6, 6, 0, 0)
        Me.pnlBeverages.Name = "pnlBeverages"
        Me.pnlBeverages.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlBeverages.ShadowDecoration.Depth = 6
        Me.pnlBeverages.ShadowDecoration.Enabled = True
        Me.pnlBeverages.Size = New System.Drawing.Size(620, 225)
        Me.pnlBeverages.TabIndex = 2
        '
        'lblBevTitle
        '
        Me.lblBevTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblBevTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.lblBevTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBevTitle.Location = New System.Drawing.Point(16, 12)
        Me.lblBevTitle.Name = "lblBevTitle"
        Me.lblBevTitle.Size = New System.Drawing.Size(153, 25)
        Me.lblBevTitle.TabIndex = 0
        Me.lblBevTitle.Text = "<b>Top Beverages Sold</b>"
        '
        'PieChartBeverages
        '
        Me.PieChartBeverages.BackColor = System.Drawing.Color.Transparent
        Me.PieChartBeverages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PieChartBeverages.Location = New System.Drawing.Point(0, 0)
        Me.PieChartBeverages.Name = "PieChartBeverages"
        Me.PieChartBeverages.Size = New System.Drawing.Size(620, 225)
        Me.PieChartBeverages.TabIndex = 1
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.lblLastRefresh)
        Me.pnlStatus.Controls.Add(Me.btnRefresh)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 776)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1280, 44)
        Me.pnlStatus.TabIndex = 4
        '
        'lblLastRefresh
        '
        Me.lblLastRefresh.BackColor = System.Drawing.Color.Transparent
        Me.lblLastRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblLastRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblLastRefresh.Location = New System.Drawing.Point(20, 14)
        Me.lblLastRefresh.Name = "lblLastRefresh"
        Me.lblLastRefresh.Size = New System.Drawing.Size(110, 21)
        Me.lblLastRefresh.TabIndex = 0
        Me.lblLastRefresh.Text = "Last refreshed: —"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BorderRadius = 15
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(2232, 7)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(108, 30)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        '
        'pnlOverlay
        '
        Me.pnlOverlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.pnlOverlay.Controls.Add(Me.loader)
        Me.pnlOverlay.Controls.Add(Me.lblLoading)
        Me.pnlOverlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverlay.Location = New System.Drawing.Point(0, 0)
        Me.pnlOverlay.Name = "pnlOverlay"
        Me.pnlOverlay.Size = New System.Drawing.Size(1280, 820)
        Me.pnlOverlay.TabIndex = 5
        Me.pnlOverlay.Visible = False
        '
        'loader
        '
        Me.loader.Animated = True
        Me.loader.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loader.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loader.ForeColor = System.Drawing.Color.White
        Me.loader.Location = New System.Drawing.Point(611, 360)
        Me.loader.Minimum = 0
        Me.loader.Name = "loader"
        Me.loader.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.loader.ProgressColor2 = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.loader.Size = New System.Drawing.Size(58, 58)
        Me.loader.TabIndex = 0
        Me.loader.Value = 75
        '
        'lblLoading
        '
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblLoading.Location = New System.Drawing.Point(598, 428)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(115, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Loading data..."
        '
        'frm_insight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 820)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlChartsOuter)
        Me.Controls.Add(Me.pnlKpiRow)
        Me.Controls.Add(Me.pnlFilterBar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.MinimumSize = New System.Drawing.Size(1100, 720)
        Me.Name = "frm_insight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insight Dashboard"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFilterBar.ResumeLayout(False)
        Me.pnlFilterBar.PerformLayout()
        Me.pnlKpiRow.ResumeLayout(False)
        Me.cardRevenue.ResumeLayout(False)
        Me.cardRevenue.PerformLayout()
        Me.cardNetsales.ResumeLayout(False)
        Me.cardNetsales.PerformLayout()
        Me.cardAvgOrder.ResumeLayout(False)
        Me.cardAvgOrder.PerformLayout()
        Me.cardTxnCount.ResumeLayout(False)
        Me.cardTxnCount.PerformLayout()
        Me.pnlChartsOuter.ResumeLayout(False)
        Me.pnlTrend.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.pnlDonuts.ResumeLayout(False)
        Me.pnlDonuts.PerformLayout()
        Me.pnlBeverages.ResumeLayout(False)
        Me.pnlBeverages.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlOverlay.ResumeLayout(False)
        Me.pnlOverlay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    ' ── Field declarations ───────────────────────────────────────────
    Friend WithEvents pnlHeader          As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlFilterBar       As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlKpiRow          As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlChartsOuter     As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlStatus          As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlOverlay         As Guna.UI2.WinForms.Guna2Panel

    Friend WithEvents lblTitle           As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle        As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDate            As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents btnDaily           As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnWeekly          As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMonthly         As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnQuarterly       As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnYearly          As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents lblPickerHint      As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtpDate            As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cmbMonth           As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbQuarter         As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbYear            As Guna.UI2.WinForms.Guna2ComboBox

    Friend WithEvents cardRevenue        As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cardNetsales       As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cardAvgOrder       As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cardTxnCount       As Guna.UI2.WinForms.Guna2Panel

    Friend WithEvents stripeRevenue      As System.Windows.Forms.Panel
    Friend WithEvents stripeNetsales     As System.Windows.Forms.Panel
    Friend WithEvents stripeAvg          As System.Windows.Forms.Panel
    Friend WithEvents stripeTxn          As System.Windows.Forms.Panel

    Friend WithEvents lblRevenueLbl      As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRevenue         As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNetsalesLbl     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNetsales        As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAvgLbl          As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblAvgOrder        As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTxnLbl          As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTxnCount        As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlTrend           As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlDonuts          As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlBeverages       As Guna.UI2.WinForms.Guna2Panel

    Friend WithEvents lblTrendTitle      As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDonutTitle      As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBevTitle        As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents TrendChart         As LiveCharts.WinForms.CartesianChart
    Friend WithEvents PieChartDonuts     As LiveCharts.WinForms.PieChart
    Friend WithEvents PieChartBeverages  As LiveCharts.WinForms.PieChart

    Friend WithEvents lblLastRefresh     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnRefresh         As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents loader             As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents lblLoading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
