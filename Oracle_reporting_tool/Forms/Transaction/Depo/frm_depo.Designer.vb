<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_depo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubtitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnAdddepo = New Guna.UI2.WinForms.Guna2Button()
        Me.lblSearchLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMonthLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbMonth = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblYearLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnClearFilter = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRecCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.dgvdepo = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlPager = New Guna.UI2.WinForms.Guna2Panel()
        Me.BtnPrevious = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPageInfo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnNext = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvdepo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPager.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
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
        Me.lblTitle.Size = New System.Drawing.Size(208, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>Deposit Monitoring</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(25, 45)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(276, 21)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Track and manage daily cash deposit records"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlToolbar.Controls.Add(Me.BtnAdddepo)
        Me.pnlToolbar.Controls.Add(Me.lblSearchLabel)
        Me.pnlToolbar.Controls.Add(Me.txtsearch)
        Me.pnlToolbar.Controls.Add(Me.lblMonthLabel)
        Me.pnlToolbar.Controls.Add(Me.cmbMonth)
        Me.pnlToolbar.Controls.Add(Me.lblYearLabel)
        Me.pnlToolbar.Controls.Add(Me.cmbYear)
        Me.pnlToolbar.Controls.Add(Me.btnClearFilter)
        Me.pnlToolbar.Controls.Add(Me.lblRecCount)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 78)
        Me.pnlToolbar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(1500, 68)
        Me.pnlToolbar.TabIndex = 1
        '
        'BtnAdddepo
        '
        Me.BtnAdddepo.Animated = True
        Me.BtnAdddepo.BorderRadius = 17
        Me.BtnAdddepo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdddepo.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnAdddepo.FillColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnAdddepo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.BtnAdddepo.ForeColor = System.Drawing.Color.White
        Me.BtnAdddepo.Location = New System.Drawing.Point(18, 12)
        Me.BtnAdddepo.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdddepo.Name = "BtnAdddepo"
        Me.BtnAdddepo.Size = New System.Drawing.Size(175, 42)
        Me.BtnAdddepo.TabIndex = 0
        Me.BtnAdddepo.Text = "+ Add Deposit"
        '
        'lblSearchLabel
        '
        Me.lblSearchLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSearchLabel.Location = New System.Drawing.Point(215, 21)
        Me.lblSearchLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSearchLabel.Name = "lblSearchLabel"
        Me.lblSearchLabel.Size = New System.Drawing.Size(53, 22)
        Me.lblSearchLabel.TabIndex = 1
        Me.lblSearchLabel.Text = "Search:"
        '
        'txtsearch
        '
        Me.txtsearch.BorderRadius = 8
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultText = ""
        Me.txtsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(285, 15)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtsearch.PlaceholderText = "Ref #, amount..."
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.Size = New System.Drawing.Size(250, 38)
        Me.txtsearch.TabIndex = 1
        '
        'lblMonthLabel
        '
        Me.lblMonthLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblMonthLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblMonthLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblMonthLabel.Location = New System.Drawing.Point(552, 25)
        Me.lblMonthLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblMonthLabel.Name = "lblMonthLabel"
        Me.lblMonthLabel.Size = New System.Drawing.Size(53, 22)
        Me.lblMonthLabel.TabIndex = 2
        Me.lblMonthLabel.Text = "Month:"
        '
        'cmbMonth
        '
        Me.cmbMonth.BackColor = System.Drawing.Color.Transparent
        Me.cmbMonth.BorderRadius = 8
        Me.cmbMonth.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.cmbMonth.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMonth.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbMonth.ItemHeight = 26
        Me.cmbMonth.Location = New System.Drawing.Point(620, 18)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(162, 32)
        Me.cmbMonth.TabIndex = 2
        '
        'lblYearLabel
        '
        Me.lblYearLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblYearLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblYearLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblYearLabel.Location = New System.Drawing.Point(798, 25)
        Me.lblYearLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblYearLabel.Name = "lblYearLabel"
        Me.lblYearLabel.Size = New System.Drawing.Size(38, 22)
        Me.lblYearLabel.TabIndex = 3
        Me.lblYearLabel.Text = "Year:"
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.Color.Transparent
        Me.cmbYear.BorderRadius = 8
        Me.cmbYear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.cmbYear.FocusedColor = System.Drawing.Color.Empty
        Me.cmbYear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbYear.ItemHeight = 26
        Me.cmbYear.Location = New System.Drawing.Point(850, 18)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(112, 32)
        Me.cmbYear.TabIndex = 3
        '
        'btnClearFilter
        '
        Me.btnClearFilter.Animated = True
        Me.btnClearFilter.BorderRadius = 16
        Me.btnClearFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearFilter.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnClearFilter.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClearFilter.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.btnClearFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnClearFilter.Location = New System.Drawing.Point(978, 14)
        Me.btnClearFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClearFilter.Name = "btnClearFilter"
        Me.btnClearFilter.Size = New System.Drawing.Size(125, 40)
        Me.btnClearFilter.TabIndex = 4
        Me.btnClearFilter.Text = "Clear Filter"
        '
        'lblRecCount
        '
        Me.lblRecCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecCount.BackColor = System.Drawing.Color.Transparent
        Me.lblRecCount.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblRecCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblRecCount.Location = New System.Drawing.Point(2575, 21)
        Me.lblRecCount.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRecCount.Name = "lblRecCount"
        Me.lblRecCount.Size = New System.Drawing.Size(3, 2)
        Me.lblRecCount.TabIndex = 5
        Me.lblRecCount.Text = Nothing
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlGrid.Controls.Add(Me.dgvdepo)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 146)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1500, 629)
        Me.pnlGrid.TabIndex = 2
        '
        'dgvdepo
        '
        Me.dgvdepo.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvdepo.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvdepo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvdepo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdepo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdepo.ColumnHeadersHeight = 4
        Me.dgvdepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdepo.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdepo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvdepo.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvdepo.Location = New System.Drawing.Point(0, 0)
        Me.dgvdepo.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvdepo.Name = "dgvdepo"
        Me.dgvdepo.RowHeadersVisible = False
        Me.dgvdepo.RowHeadersWidth = 51
        Me.dgvdepo.RowTemplate.Height = 32
        Me.dgvdepo.Size = New System.Drawing.Size(1500, 629)
        Me.dgvdepo.TabIndex = 0
        Me.dgvdepo.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.dgvdepo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvdepo.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvdepo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvdepo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvdepo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvdepo.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvdepo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvdepo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.dgvdepo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvdepo.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvdepo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvdepo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvdepo.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvdepo.ThemeStyle.ReadOnly = False
        Me.dgvdepo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgvdepo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvdepo.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvdepo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvdepo.ThemeStyle.RowsStyle.Height = 32
        Me.dgvdepo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgvdepo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'pnlPager
        '
        Me.pnlPager.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlPager.Controls.Add(Me.BtnPrevious)
        Me.pnlPager.Controls.Add(Me.lblPageInfo)
        Me.pnlPager.Controls.Add(Me.btnNext)
        Me.pnlPager.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPager.Location = New System.Drawing.Point(0, 775)
        Me.pnlPager.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlPager.Name = "pnlPager"
        Me.pnlPager.Size = New System.Drawing.Size(1500, 60)
        Me.pnlPager.TabIndex = 3
        '
        'BtnPrevious
        '
        Me.BtnPrevious.Animated = True
        Me.BtnPrevious.BorderRadius = 16
        Me.BtnPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrevious.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.BtnPrevious.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrevious.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.BtnPrevious.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.BtnPrevious.Location = New System.Drawing.Point(18, 10)
        Me.BtnPrevious.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(150, 40)
        Me.BtnPrevious.TabIndex = 0
        Me.BtnPrevious.Text = "◄ Previous"
        '
        'lblPageInfo
        '
        Me.lblPageInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblPageInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblPageInfo.Location = New System.Drawing.Point(185, 19)
        Me.lblPageInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPageInfo.Name = "lblPageInfo"
        Me.lblPageInfo.Size = New System.Drawing.Size(75, 22)
        Me.lblPageInfo.TabIndex = 1
        Me.lblPageInfo.Text = "Page 1 of 1"
        '
        'btnNext
        '
        Me.btnNext.Animated = True
        Me.btnNext.BorderRadius = 16
        Me.btnNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNext.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnNext.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnNext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnNext.Location = New System.Drawing.Point(285, 11)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(138, 40)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next ►"
        '
        'pnlOverlay
        '
        Me.pnlOverlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.pnlOverlay.Controls.Add(Me.loader)
        Me.pnlOverlay.Controls.Add(Me.lblLoading)
        Me.pnlOverlay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverlay.Location = New System.Drawing.Point(0, 0)
        Me.pnlOverlay.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlOverlay.Name = "pnlOverlay"
        Me.pnlOverlay.Size = New System.Drawing.Size(1500, 875)
        Me.pnlOverlay.TabIndex = 99
        Me.pnlOverlay.Visible = False
        '
        'loader
        '
        Me.loader.Animated = True
        Me.loader.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loader.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loader.ForeColor = System.Drawing.Color.White
        Me.loader.Location = New System.Drawing.Point(716, 350)
        Me.loader.Margin = New System.Windows.Forms.Padding(4)
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
        Me.lblLoading.Location = New System.Drawing.Point(650, 430)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(230, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Loading records, please wait..."
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 835)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1500, 40)
        Me.pnlStatus.TabIndex = 4
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
        'frm_depo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 875)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlPager)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_depo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deposit Monitoring"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvdepo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPager.ResumeLayout(False)
        Me.pnlPager.PerformLayout()
        Me.pnlOverlay.ResumeLayout(False)
        Me.pnlOverlay.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle       As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlToolbar     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnAdddepo     As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSearchLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtsearch      As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblMonthLabel  As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbMonth       As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblYearLabel   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbYear        As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnClearFilter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRecCount    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlGrid        As System.Windows.Forms.Panel
    Friend WithEvents dgvdepo        As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlPager       As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BtnPrevious    As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPageInfo    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnNext        As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlStatus      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus      As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlOverlay     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader         As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading     As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
