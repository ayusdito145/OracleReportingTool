<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_rof
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
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubtitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlSumGrid = New System.Windows.Forms.Panel()
        Me.dgvsum_rof = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlTab1Toolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btngenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlOverlay1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.pnlNonCashSection = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlNonCashGrid = New System.Windows.Forms.Panel()
        Me.dgvrof_noncash = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblNonCashTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlCashSection = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlCashGrid = New System.Windows.Forms.Panel()
        Me.dgvrof_cash = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblCashTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlTab2Toolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_busidate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnGenerateROF = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdd_Rof = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlOverlay2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader2 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.progress_ROF = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlSumGrid.SuspendLayout()
        CType(Me.dgvsum_rof, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTab1Toolbar.SuspendLayout()
        Me.pnlOverlay1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.pnlNonCashSection.SuspendLayout()
        Me.pnlNonCashGrid.SuspendLayout()
        CType(Me.dgvrof_noncash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCashSection.SuspendLayout()
        Me.pnlCashGrid.SuspendLayout()
        CType(Me.dgvrof_cash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTab2Toolbar.SuspendLayout()
        Me.pnlOverlay2.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1500, 78)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(22, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(205, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>Remittance of Fund</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(25, 45)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(373, 21)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Cash and non-cash remittance monitoring per business date"
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(160, 38)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 78)
        Me.Guna2TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1500, 820)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(160, 38)
        Me.Guna2TabControl1.TabIndex = 1
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.pnlSumGrid)
        Me.TabPage1.Controls.Add(Me.pnlTab1Toolbar)
        Me.TabPage1.Controls.Add(Me.pnlOverlay1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 42)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1492, 774)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Summary ROF"
        '
        'pnlSumGrid
        '
        Me.pnlSumGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlSumGrid.Controls.Add(Me.dgvsum_rof)
        Me.pnlSumGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSumGrid.Location = New System.Drawing.Point(0, 68)
        Me.pnlSumGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSumGrid.Name = "pnlSumGrid"
        Me.pnlSumGrid.Size = New System.Drawing.Size(1492, 706)
        Me.pnlSumGrid.TabIndex = 1
        '
        'dgvsum_rof
        '
        Me.dgvsum_rof.AllowUserToAddRows = False
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvsum_rof.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.dgvsum_rof.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvsum_rof.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsum_rof.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.dgvsum_rof.ColumnHeadersHeight = 4
        Me.dgvsum_rof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvsum_rof.DefaultCellStyle = DataGridViewCellStyle39
        Me.dgvsum_rof.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvsum_rof.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvsum_rof.Location = New System.Drawing.Point(0, 0)
        Me.dgvsum_rof.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvsum_rof.Name = "dgvsum_rof"
        Me.dgvsum_rof.RowHeadersVisible = False
        Me.dgvsum_rof.RowHeadersWidth = 51
        Me.dgvsum_rof.RowTemplate.Height = 32
        Me.dgvsum_rof.Size = New System.Drawing.Size(1492, 706)
        Me.dgvsum_rof.TabIndex = 0
        Me.dgvsum_rof.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.dgvsum_rof.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvsum_rof.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvsum_rof.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvsum_rof.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvsum_rof.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvsum_rof.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvsum_rof.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvsum_rof.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.dgvsum_rof.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvsum_rof.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.dgvsum_rof.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvsum_rof.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvsum_rof.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvsum_rof.ThemeStyle.ReadOnly = False
        Me.dgvsum_rof.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgvsum_rof.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvsum_rof.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.dgvsum_rof.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvsum_rof.ThemeStyle.RowsStyle.Height = 32
        Me.dgvsum_rof.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgvsum_rof.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'pnlTab1Toolbar
        '
        Me.pnlTab1Toolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTab1Toolbar.Controls.Add(Me.Label2)
        Me.pnlTab1Toolbar.Controls.Add(Me.dtFrom)
        Me.pnlTab1Toolbar.Controls.Add(Me.Label3)
        Me.pnlTab1Toolbar.Controls.Add(Me.dtTo)
        Me.pnlTab1Toolbar.Controls.Add(Me.btngenerate)
        Me.pnlTab1Toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTab1Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTab1Toolbar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTab1Toolbar.Name = "pnlTab1Toolbar"
        Me.pnlTab1Toolbar.Size = New System.Drawing.Size(1492, 68)
        Me.pnlTab1Toolbar.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From:"
        '
        'dtFrom
        '
        Me.dtFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtFrom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtFrom.Checked = True
        Me.dtFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(78, 15)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(210, 38)
        Me.dtFrom.TabIndex = 0
        Me.dtFrom.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(308, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "To:"
        '
        'dtTo
        '
        Me.dtTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtTo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtTo.Checked = True
        Me.dtTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(340, 15)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(210, 38)
        Me.dtTo.TabIndex = 1
        Me.dtTo.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'btngenerate
        '
        Me.btngenerate.Animated = True
        Me.btngenerate.BorderRadius = 17
        Me.btngenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngenerate.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btngenerate.FillColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btngenerate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btngenerate.ForeColor = System.Drawing.Color.White
        Me.btngenerate.Location = New System.Drawing.Point(572, 12)
        Me.btngenerate.Margin = New System.Windows.Forms.Padding(4)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(200, 42)
        Me.btngenerate.TabIndex = 2
        Me.btngenerate.Text = "Generate Summary"
        '
        'pnlOverlay1
        '
        Me.pnlOverlay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.pnlOverlay1.Controls.Add(Me.loader1)
        Me.pnlOverlay1.Controls.Add(Me.lblLoading1)
        Me.pnlOverlay1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverlay1.Location = New System.Drawing.Point(0, 0)
        Me.pnlOverlay1.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOverlay1.Name = "pnlOverlay1"
        Me.pnlOverlay1.Size = New System.Drawing.Size(1492, 774)
        Me.pnlOverlay1.TabIndex = 98
        Me.pnlOverlay1.Visible = False
        '
        'loader1
        '
        Me.loader1.Animated = True
        Me.loader1.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loader1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loader1.ForeColor = System.Drawing.Color.White
        Me.loader1.Location = New System.Drawing.Point(716, 312)
        Me.loader1.Margin = New System.Windows.Forms.Padding(4)
        Me.loader1.Minimum = 0
        Me.loader1.Name = "loader1"
        Me.loader1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.loader1.Size = New System.Drawing.Size(68, 68)
        Me.loader1.TabIndex = 0
        Me.loader1.Value = 75
        '
        'lblLoading1
        '
        Me.lblLoading1.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoading1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblLoading1.Location = New System.Drawing.Point(656, 392)
        Me.lblLoading1.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLoading1.Name = "lblLoading1"
        Me.lblLoading1.Size = New System.Drawing.Size(175, 25)
        Me.lblLoading1.TabIndex = 1
        Me.lblLoading1.Text = "Generating summary..."
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.pnlNonCashSection)
        Me.TabPage2.Controls.Add(Me.pnlCashSection)
        Me.TabPage2.Controls.Add(Me.pnlTab2Toolbar)
        Me.TabPage2.Controls.Add(Me.pnlOverlay2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 42)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1492, 774)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Details ROF"
        '
        'pnlNonCashSection
        '
        Me.pnlNonCashSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlNonCashSection.Controls.Add(Me.Label5)
        Me.pnlNonCashSection.Controls.Add(Me.pnlNonCashGrid)
        Me.pnlNonCashSection.Controls.Add(Me.lblNonCashTitle)
        Me.pnlNonCashSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNonCashSection.Location = New System.Drawing.Point(0, 347)
        Me.pnlNonCashSection.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlNonCashSection.Name = "pnlNonCashSection"
        Me.pnlNonCashSection.Size = New System.Drawing.Size(1492, 427)
        Me.pnlNonCashSection.TabIndex = 2
        '
        'pnlNonCashGrid
        '
        Me.pnlNonCashGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlNonCashGrid.Controls.Add(Me.dgvrof_noncash)
        Me.pnlNonCashGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNonCashGrid.Location = New System.Drawing.Point(0, 37)
        Me.pnlNonCashGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlNonCashGrid.Name = "pnlNonCashGrid"
        Me.pnlNonCashGrid.Size = New System.Drawing.Size(1492, 390)
        Me.pnlNonCashGrid.TabIndex = 1
        '
        'dgvrof_noncash
        '
        Me.dgvrof_noncash.AllowUserToAddRows = False
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvrof_noncash.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle40
        Me.dgvrof_noncash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvrof_noncash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle41.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrof_noncash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle41
        Me.dgvrof_noncash.ColumnHeadersHeight = 4
        Me.dgvrof_noncash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvrof_noncash.DefaultCellStyle = DataGridViewCellStyle42
        Me.dgvrof_noncash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvrof_noncash.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvrof_noncash.Location = New System.Drawing.Point(0, 0)
        Me.dgvrof_noncash.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvrof_noncash.Name = "dgvrof_noncash"
        Me.dgvrof_noncash.RowHeadersVisible = False
        Me.dgvrof_noncash.RowHeadersWidth = 51
        Me.dgvrof_noncash.RowTemplate.Height = 32
        Me.dgvrof_noncash.Size = New System.Drawing.Size(1492, 390)
        Me.dgvrof_noncash.TabIndex = 0
        Me.dgvrof_noncash.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.dgvrof_noncash.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvrof_noncash.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvrof_noncash.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvrof_noncash.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvrof_noncash.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvrof_noncash.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvrof_noncash.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvrof_noncash.ThemeStyle.ReadOnly = False
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.Height = 32
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'lblNonCashTitle
        '
        Me.lblNonCashTitle.AutoSize = False
        Me.lblNonCashTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNonCashTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNonCashTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNonCashTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblNonCashTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblNonCashTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNonCashTitle.Name = "lblNonCashTitle"
        Me.lblNonCashTitle.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblNonCashTitle.Size = New System.Drawing.Size(1492, 37)
        Me.lblNonCashTitle.TabIndex = 0
        Me.lblNonCashTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlCashSection
        '
        Me.pnlCashSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlCashSection.Controls.Add(Me.pnlCashGrid)
        Me.pnlCashSection.Controls.Add(Me.Label1)
        Me.pnlCashSection.Controls.Add(Me.lblCashTitle)
        Me.pnlCashSection.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCashSection.Location = New System.Drawing.Point(0, 72)
        Me.pnlCashSection.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCashSection.Name = "pnlCashSection"
        Me.pnlCashSection.Size = New System.Drawing.Size(1492, 275)
        Me.pnlCashSection.TabIndex = 1
        '
        'pnlCashGrid
        '
        Me.pnlCashGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlCashGrid.Controls.Add(Me.dgvrof_cash)
        Me.pnlCashGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCashGrid.Location = New System.Drawing.Point(0, 36)
        Me.pnlCashGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCashGrid.Name = "pnlCashGrid"
        Me.pnlCashGrid.Size = New System.Drawing.Size(1492, 239)
        Me.pnlCashGrid.TabIndex = 1
        '
        'dgvrof_cash
        '
        Me.dgvrof_cash.AllowUserToAddRows = False
        DataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvrof_cash.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle43
        Me.dgvrof_cash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvrof_cash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle44.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrof_cash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle44
        Me.dgvrof_cash.ColumnHeadersHeight = 4
        Me.dgvrof_cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        DataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvrof_cash.DefaultCellStyle = DataGridViewCellStyle45
        Me.dgvrof_cash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvrof_cash.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvrof_cash.Location = New System.Drawing.Point(0, 0)
        Me.dgvrof_cash.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvrof_cash.Name = "dgvrof_cash"
        Me.dgvrof_cash.RowHeadersVisible = False
        Me.dgvrof_cash.RowHeadersWidth = 51
        Me.dgvrof_cash.RowTemplate.Height = 32
        Me.dgvrof_cash.Size = New System.Drawing.Size(1492, 239)
        Me.dgvrof_cash.TabIndex = 0
        Me.dgvrof_cash.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.dgvrof_cash.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvrof_cash.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvrof_cash.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvrof_cash.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvrof_cash.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvrof_cash.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvrof_cash.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvrof_cash.ThemeStyle.ReadOnly = False
        Me.dgvrof_cash.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgvrof_cash.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvrof_cash.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.dgvrof_cash.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvrof_cash.ThemeStyle.RowsStyle.Height = 32
        Me.dgvrof_cash.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgvrof_cash.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'lblCashTitle
        '
        Me.lblCashTitle.AutoSize = False
        Me.lblCashTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCashTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCashTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCashTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblCashTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblCashTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCashTitle.Name = "lblCashTitle"
        Me.lblCashTitle.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lblCashTitle.Size = New System.Drawing.Size(1492, 36)
        Me.lblCashTitle.TabIndex = 0
        Me.lblCashTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlTab2Toolbar
        '
        Me.pnlTab2Toolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlTab2Toolbar.Controls.Add(Me.Label4)
        Me.pnlTab2Toolbar.Controls.Add(Me.dtp_busidate)
        Me.pnlTab2Toolbar.Controls.Add(Me.btnGenerateROF)
        Me.pnlTab2Toolbar.Controls.Add(Me.btnAdd_Rof)
        Me.pnlTab2Toolbar.Controls.Add(Me.btnDelete)
        Me.pnlTab2Toolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTab2Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTab2Toolbar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTab2Toolbar.Name = "pnlTab2Toolbar"
        Me.pnlTab2Toolbar.Size = New System.Drawing.Size(1492, 72)
        Me.pnlTab2Toolbar.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Business Date:"
        '
        'dtp_busidate
        '
        Me.dtp_busidate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtp_busidate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtp_busidate.Checked = True
        Me.dtp_busidate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtp_busidate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtp_busidate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_busidate.Location = New System.Drawing.Point(148, 18)
        Me.dtp_busidate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_busidate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtp_busidate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtp_busidate.Name = "dtp_busidate"
        Me.dtp_busidate.Size = New System.Drawing.Size(210, 38)
        Me.dtp_busidate.TabIndex = 0
        Me.dtp_busidate.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'btnGenerateROF
        '
        Me.btnGenerateROF.Animated = True
        Me.btnGenerateROF.BorderRadius = 17
        Me.btnGenerateROF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateROF.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnGenerateROF.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerateROF.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnGenerateROF.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnGenerateROF.Location = New System.Drawing.Point(378, 15)
        Me.btnGenerateROF.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerateROF.Name = "btnGenerateROF"
        Me.btnGenerateROF.Size = New System.Drawing.Size(162, 42)
        Me.btnGenerateROF.TabIndex = 1
        Me.btnGenerateROF.Text = "Load ROF"
        '
        'btnAdd_Rof
        '
        Me.btnAdd_Rof.Animated = True
        Me.btnAdd_Rof.BorderRadius = 17
        Me.btnAdd_Rof.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd_Rof.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAdd_Rof.FillColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAdd_Rof.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnAdd_Rof.ForeColor = System.Drawing.Color.White
        Me.btnAdd_Rof.Location = New System.Drawing.Point(558, 15)
        Me.btnAdd_Rof.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd_Rof.Name = "btnAdd_Rof"
        Me.btnAdd_Rof.Size = New System.Drawing.Size(162, 42)
        Me.btnAdd_Rof.TabIndex = 2
        Me.btnAdd_Rof.Text = "+ Add ROF"
        '
        'btnDelete
        '
        Me.btnDelete.Animated = True
        Me.btnDelete.BorderRadius = 17
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(738, 15)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(162, 42)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete ROF"
        '
        'pnlOverlay2
        '
        Me.pnlOverlay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.pnlOverlay2.Controls.Add(Me.loader2)
        Me.pnlOverlay2.Controls.Add(Me.lblLoading2)
        Me.pnlOverlay2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverlay2.Location = New System.Drawing.Point(0, 0)
        Me.pnlOverlay2.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOverlay2.Name = "pnlOverlay2"
        Me.pnlOverlay2.Size = New System.Drawing.Size(1492, 774)
        Me.pnlOverlay2.TabIndex = 98
        Me.pnlOverlay2.Visible = False
        '
        'loader2
        '
        Me.loader2.Animated = True
        Me.loader2.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loader2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loader2.ForeColor = System.Drawing.Color.White
        Me.loader2.Location = New System.Drawing.Point(716, 312)
        Me.loader2.Margin = New System.Windows.Forms.Padding(4)
        Me.loader2.Minimum = 0
        Me.loader2.Name = "loader2"
        Me.loader2.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.loader2.Size = New System.Drawing.Size(68, 68)
        Me.loader2.TabIndex = 0
        Me.loader2.Value = 75
        '
        'lblLoading2
        '
        Me.lblLoading2.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoading2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblLoading2.Location = New System.Drawing.Point(656, 392)
        Me.lblLoading2.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLoading2.Name = "lblLoading2"
        Me.lblLoading2.Size = New System.Drawing.Size(166, 25)
        Me.lblLoading2.TabIndex = 1
        Me.lblLoading2.Text = "Loading ROF details..."
        '
        'progress_ROF
        '
        Me.progress_ROF.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.progress_ROF.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.progress_ROF.ForeColor = System.Drawing.Color.White
        Me.progress_ROF.Location = New System.Drawing.Point(0, 0)
        Me.progress_ROF.Minimum = 0
        Me.progress_ROF.Name = "progress_ROF"
        Me.progress_ROF.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.progress_ROF.Size = New System.Drawing.Size(1, 1)
        Me.progress_ROF.TabIndex = 0
        Me.progress_ROF.Visible = False
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 898)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1500, 40)
        Me.pnlStatus.TabIndex = 99
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(18, 10)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 21)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Ready"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cash Remittance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Non- Cash Remittance"
        '
        'frm_rof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 938)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_rof"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remittance of Fund"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlSumGrid.ResumeLayout(False)
        CType(Me.dgvsum_rof, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTab1Toolbar.ResumeLayout(False)
        Me.pnlTab1Toolbar.PerformLayout()
        Me.pnlOverlay1.ResumeLayout(False)
        Me.pnlOverlay1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.pnlNonCashSection.ResumeLayout(False)
        Me.pnlNonCashSection.PerformLayout()
        Me.pnlNonCashGrid.ResumeLayout(False)
        CType(Me.dgvrof_noncash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCashSection.ResumeLayout(False)
        Me.pnlCashSection.PerformLayout()
        Me.pnlCashGrid.ResumeLayout(False)
        CType(Me.dgvrof_cash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTab2Toolbar.ResumeLayout(False)
        Me.pnlTab2Toolbar.PerformLayout()
        Me.pnlOverlay2.ResumeLayout(False)
        Me.pnlOverlay2.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents pnlTab1Toolbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtTo As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btngenerate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlSumGrid As System.Windows.Forms.Panel
    Friend WithEvents dgvsum_rof As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlOverlay1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader1 As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents pnlTab2Toolbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_busidate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnGenerateROF As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdd_Rof As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlCashSection As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCashTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlCashGrid As System.Windows.Forms.Panel
    Friend WithEvents dgvrof_cash As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlNonCashSection As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblNonCashTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlNonCashGrid As System.Windows.Forms.Panel
    Friend WithEvents dgvrof_noncash As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlOverlay2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader2 As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents progress_ROF As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents pnlStatus As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus As Guna.UI2.WinForms.Guna2HtmlLabel

    ' Legacy alias — code-behind references GunaProgressIndicator1
    Friend WithEvents GunaProgressIndicator1 As Guna.UI2.WinForms.Guna2CircleProgressBar =
        New Guna.UI2.WinForms.Guna2CircleProgressBar()
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
