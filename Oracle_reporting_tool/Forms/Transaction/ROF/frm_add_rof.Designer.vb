<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_add_rof
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubtitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDateBadge = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.lblToolbarNote = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlCashSection = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlCashGrid = New System.Windows.Forms.Panel()
        Me.dgvrof_cash = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblCashTitle = New System.Windows.Forms.Label()
        Me.pnlNonCashSection = New Guna.UI2.WinForms.Guna2Panel()
        Me.pnlNonCashGrid = New System.Windows.Forms.Panel()
        Me.dgvrof_noncash = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblNonCashTitle = New System.Windows.Forms.Label()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlCashSection.SuspendLayout()
        Me.pnlCashGrid.SuspendLayout()
        CType(Me.dgvrof_cash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNonCashSection.SuspendLayout()
        Me.pnlNonCashGrid.SuspendLayout()
        CType(Me.dgvrof_noncash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatus.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Controls.Add(Me.lblDateBadge)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1550, 85)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(246, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>Add Remittance of Fund</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 45)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(443, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Enter actual cash and non-cash amounts collected per cashier / tender type"
        '
        'lblDateBadge
        '
        Me.lblDateBadge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateBadge.BackColor = System.Drawing.Color.Transparent
        Me.lblDateBadge.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblDateBadge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblDateBadge.Location = New System.Drawing.Point(2500, 28)
        Me.lblDateBadge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDateBadge.Name = "lblDateBadge"
        Me.lblDateBadge.Size = New System.Drawing.Size(3, 2)
        Me.lblDateBadge.TabIndex = 2
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlToolbar.Controls.Add(Me.btnSave)
        Me.pnlToolbar.Controls.Add(Me.lblToolbarNote)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 85)
        Me.pnlToolbar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(1550, 68)
        Me.pnlToolbar.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BorderRadius = 17
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(18, 12)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(175, 42)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save ROF"
        '
        'lblToolbarNote
        '
        Me.lblToolbarNote.BackColor = System.Drawing.Color.Transparent
        Me.lblToolbarNote.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblToolbarNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblToolbarNote.Location = New System.Drawing.Point(210, 22)
        Me.lblToolbarNote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblToolbarNote.Name = "lblToolbarNote"
        Me.lblToolbarNote.Size = New System.Drawing.Size(306, 21)
        Me.lblToolbarNote.TabIndex = 1
        Me.lblToolbarNote.Text = "White cells are editable  ·  Variance = Actual − POS"
        '
        'pnlCashSection
        '
        Me.pnlCashSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlCashSection.Controls.Add(Me.pnlCashGrid)
        Me.pnlCashSection.Controls.Add(Me.lblCashTitle)
        Me.pnlCashSection.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCashSection.Location = New System.Drawing.Point(0, 153)
        Me.pnlCashSection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlCashSection.Name = "pnlCashSection"
        Me.pnlCashSection.Size = New System.Drawing.Size(1550, 300)
        Me.pnlCashSection.TabIndex = 2
        '
        'pnlCashGrid
        '
        Me.pnlCashGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlCashGrid.Controls.Add(Me.dgvrof_cash)
        Me.pnlCashGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCashGrid.Location = New System.Drawing.Point(0, 32)
        Me.pnlCashGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlCashGrid.Name = "pnlCashGrid"
        Me.pnlCashGrid.Size = New System.Drawing.Size(1550, 268)
        Me.pnlCashGrid.TabIndex = 1
        '
        'dgvrof_cash
        '
        Me.dgvrof_cash.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvrof_cash.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvrof_cash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvrof_cash.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.dgvrof_cash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrof_cash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvrof_cash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvrof_cash.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvrof_cash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvrof_cash.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvrof_cash.Location = New System.Drawing.Point(0, 0)
        Me.dgvrof_cash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvrof_cash.Name = "dgvrof_cash"
        Me.dgvrof_cash.RowHeadersVisible = False
        Me.dgvrof_cash.RowHeadersWidth = 51
        Me.dgvrof_cash.RowTemplate.Height = 32
        Me.dgvrof_cash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvrof_cash.Size = New System.Drawing.Size(1550, 268)
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
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrof_cash.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvrof_cash.ThemeStyle.ReadOnly = False
        Me.dgvrof_cash.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgvrof_cash.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvrof_cash.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvrof_cash.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvrof_cash.ThemeStyle.RowsStyle.Height = 32
        Me.dgvrof_cash.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgvrof_cash.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'lblCashTitle
        '
        Me.lblCashTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCashTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCashTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCashTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblCashTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblCashTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCashTitle.Name = "lblCashTitle"
        Me.lblCashTitle.Size = New System.Drawing.Size(1550, 32)
        Me.lblCashTitle.TabIndex = 0
        Me.lblCashTitle.Text = "  Cash Remittance"
        Me.lblCashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlNonCashSection
        '
        Me.pnlNonCashSection.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlNonCashSection.Controls.Add(Me.pnlNonCashGrid)
        Me.pnlNonCashSection.Controls.Add(Me.lblNonCashTitle)
        Me.pnlNonCashSection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNonCashSection.Location = New System.Drawing.Point(0, 453)
        Me.pnlNonCashSection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlNonCashSection.Name = "pnlNonCashSection"
        Me.pnlNonCashSection.Size = New System.Drawing.Size(1550, 445)
        Me.pnlNonCashSection.TabIndex = 3
        '
        'pnlNonCashGrid
        '
        Me.pnlNonCashGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlNonCashGrid.Controls.Add(Me.dgvrof_noncash)
        Me.pnlNonCashGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNonCashGrid.Location = New System.Drawing.Point(0, 32)
        Me.pnlNonCashGrid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlNonCashGrid.Name = "pnlNonCashGrid"
        Me.pnlNonCashGrid.Size = New System.Drawing.Size(1550, 413)
        Me.pnlNonCashGrid.TabIndex = 1
        '
        'dgvrof_noncash
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvrof_noncash.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvrof_noncash.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvrof_noncash.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.dgvrof_noncash.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvrof_noncash.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvrof_noncash.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvrof_noncash.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvrof_noncash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvrof_noncash.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvrof_noncash.Location = New System.Drawing.Point(0, 0)
        Me.dgvrof_noncash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvrof_noncash.Name = "dgvrof_noncash"
        Me.dgvrof_noncash.RowHeadersVisible = False
        Me.dgvrof_noncash.RowHeadersWidth = 51
        Me.dgvrof_noncash.RowTemplate.Height = 32
        Me.dgvrof_noncash.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvrof_noncash.Size = New System.Drawing.Size(1550, 413)
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
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrof_noncash.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvrof_noncash.ThemeStyle.ReadOnly = False
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.Height = 32
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgvrof_noncash.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'lblNonCashTitle
        '
        Me.lblNonCashTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNonCashTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNonCashTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblNonCashTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblNonCashTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblNonCashTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNonCashTitle.Name = "lblNonCashTitle"
        Me.lblNonCashTitle.Size = New System.Drawing.Size(1550, 32)
        Me.lblNonCashTitle.TabIndex = 0
        Me.lblNonCashTitle.Text = "  Non-Cash Remittance  (you may add rows for additional tender types)"
        Me.lblNonCashTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 898)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1550, 40)
        Me.pnlStatus.TabIndex = 4
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(18, 10)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 21)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Ready"
        '
        'pnlOverlay
        '
        Me.pnlOverlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.pnlOverlay.Controls.Add(Me.loader)
        Me.pnlOverlay.Controls.Add(Me.lblLoading)
        Me.pnlOverlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverlay.Location = New System.Drawing.Point(0, 0)
        Me.pnlOverlay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlOverlay.Name = "pnlOverlay"
        Me.pnlOverlay.Size = New System.Drawing.Size(1550, 938)
        Me.pnlOverlay.TabIndex = 99
        Me.pnlOverlay.Visible = False
        '
        'loader
        '
        Me.loader.Animated = True
        Me.loader.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loader.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loader.ForeColor = System.Drawing.Color.White
        Me.loader.Location = New System.Drawing.Point(738, 375)
        Me.loader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.loader.Minimum = 0
        Me.loader.Name = "loader"
        Me.loader.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.loader.Size = New System.Drawing.Size(68, 68)
        Me.loader.TabIndex = 0
        Me.loader.Value = 75
        '
        'lblLoading
        '
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblLoading.Location = New System.Drawing.Point(669, 455)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(245, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Loading POS data, please wait..."
        '
        'frm_add_rof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1550, 938)
        Me.Controls.Add(Me.pnlNonCashSection)
        Me.Controls.Add(Me.pnlCashSection)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_add_rof"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Remittance of Fund"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlCashSection.ResumeLayout(False)
        Me.pnlCashGrid.ResumeLayout(False)
        CType(Me.dgvrof_cash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNonCashSection.ResumeLayout(False)
        Me.pnlNonCashGrid.ResumeLayout(False)
        CType(Me.dgvrof_noncash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlOverlay.ResumeLayout(False)
        Me.pnlOverlay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader         As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle          As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle       As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDateBadge      As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlToolbar        As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSave           As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblToolbarNote    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlCashSection    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblCashTitle      As System.Windows.Forms.Label
    Friend WithEvents pnlCashGrid       As System.Windows.Forms.Panel
    Friend WithEvents dgvrof_cash       As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlNonCashSection As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblNonCashTitle   As System.Windows.Forms.Label
    Friend WithEvents pnlNonCashGrid    As System.Windows.Forms.Panel
    Friend WithEvents dgvrof_noncash    As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlStatus         As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus         As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlOverlay        As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader            As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading        As Guna.UI2.WinForms.Guna2HtmlLabel

    ' Legacy alias referenced by original code-behind
    Friend WithEvents GunaProgressIndicator1 As Guna.UI2.WinForms.Guna2CircleProgressbar =
        New Guna.UI2.WinForms.Guna2CircleProgressbar()

End Class
