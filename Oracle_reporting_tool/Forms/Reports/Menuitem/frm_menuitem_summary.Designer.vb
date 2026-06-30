<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menuitem_summary
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuitemPosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFormTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFormSub = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFrom = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblTo = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtto = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblFilter = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cmbMajorgroup = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btngenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExportToExcel = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRecordCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlSummary = New Guna.UI2.WinForms.Guna2Panel()
        Me.cardTotalQty = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeQty = New System.Windows.Forms.Panel()
        Me.lblTotalQtyLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTotalQtyVal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardGross = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeGross = New System.Windows.Forms.Panel()
        Me.lblGrossLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGrossVal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardDiscount = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeDiscount = New System.Windows.Forms.Panel()
        Me.lblDiscountLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDiscountVal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardNetSales = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeNet = New System.Windows.Forms.Panel()
        Me.lblNetSalesLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblNetSalesVal = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dgvmenuitem = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLastRefresh = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblStatusRight = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        Me.cardTotalQty.SuspendLayout()
        Me.cardGross.SuspendLayout()
        Me.cardDiscount.SuspendLayout()
        Me.cardNetSales.SuspendLayout()
        CType(Me.dgvmenuitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStatus.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemPosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1500, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuitemPosToolStripMenuItem
        '
        Me.MenuitemPosToolStripMenuItem.Name = "MenuitemPosToolStripMenuItem"
        Me.MenuitemPosToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.MenuitemPosToolStripMenuItem.Text = "MenuItem by Sales"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblFormTitle)
        Me.pnlHeader.Controls.Add(Me.lblFormSub)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 28)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1500, 78)
        Me.pnlHeader.TabIndex = 1
        '
        'lblFormTitle
        '
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(22, 9)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(291, 33)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "<b>MenuItem Summary Report</b>"
        '
        'lblFormSub
        '
        Me.lblFormSub.BackColor = System.Drawing.Color.Transparent
        Me.lblFormSub.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblFormSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblFormSub.Location = New System.Drawing.Point(25, 45)
        Me.lblFormSub.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFormSub.Name = "lblFormSub"
        Me.lblFormSub.Size = New System.Drawing.Size(357, 21)
        Me.lblFormSub.TabIndex = 1
        Me.lblFormSub.Text = "Sales summary grouped by major group and family group"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlToolbar.Controls.Add(Me.lblFrom)
        Me.pnlToolbar.Controls.Add(Me.dtFrom)
        Me.pnlToolbar.Controls.Add(Me.lblTo)
        Me.pnlToolbar.Controls.Add(Me.dtto)
        Me.pnlToolbar.Controls.Add(Me.lblFilter)
        Me.pnlToolbar.Controls.Add(Me.cmbMajorgroup)
        Me.pnlToolbar.Controls.Add(Me.btngenerate)
        Me.pnlToolbar.Controls.Add(Me.btnExportToExcel)
        Me.pnlToolbar.Controls.Add(Me.lblRecordCount)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 106)
        Me.pnlToolbar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(1500, 85)
        Me.pnlToolbar.TabIndex = 2
        '
        'lblFrom
        '
        Me.lblFrom.BackColor = System.Drawing.Color.Transparent
        Me.lblFrom.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblFrom.Location = New System.Drawing.Point(22, 28)
        Me.lblFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(38, 21)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Text = "From:"
        '
        'dtFrom
        '
        Me.dtFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtFrom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtFrom.Checked = True
        Me.dtFrom.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.dtFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(82, 20)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(185, 38)
        Me.dtFrom.TabIndex = 1
        Me.dtFrom.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'lblTo
        '
        Me.lblTo.BackColor = System.Drawing.Color.Transparent
        Me.lblTo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTo.Location = New System.Drawing.Point(285, 28)
        Me.lblTo.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(22, 21)
        Me.lblTo.TabIndex = 2
        Me.lblTo.Text = "To:"
        '
        'dtto
        '
        Me.dtto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtto.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtto.Checked = True
        Me.dtto.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.dtto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(320, 20)
        Me.dtto.Margin = New System.Windows.Forms.Padding(4)
        Me.dtto.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtto.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(185, 38)
        Me.dtto.TabIndex = 3
        Me.dtto.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'lblFilter
        '
        Me.lblFilter.BackColor = System.Drawing.Color.Transparent
        Me.lblFilter.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblFilter.Location = New System.Drawing.Point(522, 28)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(45, 21)
        Me.lblFilter.TabIndex = 4
        Me.lblFilter.Text = "Group:"
        '
        'cmbMajorgroup
        '
        Me.cmbMajorgroup.BackColor = System.Drawing.Color.Transparent
        Me.cmbMajorgroup.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cmbMajorgroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMajorgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMajorgroup.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.cmbMajorgroup.FocusedColor = System.Drawing.Color.Empty
        Me.cmbMajorgroup.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.cmbMajorgroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmbMajorgroup.ItemHeight = 26
        Me.cmbMajorgroup.Location = New System.Drawing.Point(578, 20)
        Me.cmbMajorgroup.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMajorgroup.Name = "cmbMajorgroup"
        Me.cmbMajorgroup.Size = New System.Drawing.Size(199, 32)
        Me.cmbMajorgroup.TabIndex = 0
        '
        'btngenerate
        '
        Me.btngenerate.Animated = True
        Me.btngenerate.BorderRadius = 17
        Me.btngenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btngenerate.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btngenerate.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btngenerate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btngenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btngenerate.Location = New System.Drawing.Point(795, 16)
        Me.btngenerate.Margin = New System.Windows.Forms.Padding(4)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(150, 42)
        Me.btngenerate.TabIndex = 1
        Me.btngenerate.Text = "Generate"
        '
        'btnExportToExcel
        '
        Me.btnExportToExcel.Animated = True
        Me.btnExportToExcel.BorderRadius = 17
        Me.btnExportToExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportToExcel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnExportToExcel.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnExportToExcel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnExportToExcel.ForeColor = System.Drawing.Color.White
        Me.btnExportToExcel.Location = New System.Drawing.Point(960, 16)
        Me.btnExportToExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExportToExcel.Name = "btnExportToExcel"
        Me.btnExportToExcel.Size = New System.Drawing.Size(175, 42)
        Me.btnExportToExcel.TabIndex = 2
        Me.btnExportToExcel.Text = "Export to Excel"
        '
        'lblRecordCount
        '
        Me.lblRecordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecordCount.BackColor = System.Drawing.Color.Transparent
        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblRecordCount.Location = New System.Drawing.Point(2575, 28)
        Me.lblRecordCount.Margin = New System.Windows.Forms.Padding(4)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(60, 21)
        Me.lblRecordCount.TabIndex = 5
        Me.lblRecordCount.Text = "0 records"
        '
        'pnlSummary
        '
        Me.pnlSummary.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlSummary.Controls.Add(Me.cardTotalQty)
        Me.pnlSummary.Controls.Add(Me.cardGross)
        Me.pnlSummary.Controls.Add(Me.cardDiscount)
        Me.pnlSummary.Controls.Add(Me.cardNetSales)
        Me.pnlSummary.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSummary.Location = New System.Drawing.Point(0, 191)
        Me.pnlSummary.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSummary.Name = "pnlSummary"
        Me.pnlSummary.Size = New System.Drawing.Size(1500, 120)
        Me.pnlSummary.TabIndex = 3
        '
        'cardTotalQty
        '
        Me.cardTotalQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cardTotalQty.BorderRadius = 12
        Me.cardTotalQty.Controls.Add(Me.stripeQty)
        Me.cardTotalQty.Controls.Add(Me.lblTotalQtyLbl)
        Me.cardTotalQty.Controls.Add(Me.lblTotalQtyVal)
        Me.cardTotalQty.Location = New System.Drawing.Point(22, 15)
        Me.cardTotalQty.Margin = New System.Windows.Forms.Padding(4)
        Me.cardTotalQty.Name = "cardTotalQty"
        Me.cardTotalQty.Size = New System.Drawing.Size(319, 90)
        Me.cardTotalQty.TabIndex = 0
        '
        'stripeQty
        '
        Me.stripeQty.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.stripeQty.Location = New System.Drawing.Point(12, 16)
        Me.stripeQty.Margin = New System.Windows.Forms.Padding(4)
        Me.stripeQty.Name = "stripeQty"
        Me.stripeQty.Size = New System.Drawing.Size(5, 58)
        Me.stripeQty.TabIndex = 0
        '
        'lblTotalQtyLbl
        '
        Me.lblTotalQtyLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalQtyLbl.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTotalQtyLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblTotalQtyLbl.Location = New System.Drawing.Point(28, 15)
        Me.lblTotalQtyLbl.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTotalQtyLbl.Name = "lblTotalQtyLbl"
        Me.lblTotalQtyLbl.Size = New System.Drawing.Size(86, 19)
        Me.lblTotalQtyLbl.TabIndex = 1
        Me.lblTotalQtyLbl.Text = "Total Qty Sold"
        '
        'lblTotalQtyVal
        '
        Me.lblTotalQtyVal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalQtyVal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalQtyVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblTotalQtyVal.Location = New System.Drawing.Point(28, 38)
        Me.lblTotalQtyVal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTotalQtyVal.Name = "lblTotalQtyVal"
        Me.lblTotalQtyVal.Size = New System.Drawing.Size(16, 33)
        Me.lblTotalQtyVal.TabIndex = 2
        Me.lblTotalQtyVal.Text = "0"
        '
        'cardGross
        '
        Me.cardGross.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cardGross.BorderRadius = 12
        Me.cardGross.Controls.Add(Me.stripeGross)
        Me.cardGross.Controls.Add(Me.lblGrossLbl)
        Me.cardGross.Controls.Add(Me.lblGrossVal)
        Me.cardGross.Location = New System.Drawing.Point(361, 15)
        Me.cardGross.Margin = New System.Windows.Forms.Padding(4)
        Me.cardGross.Name = "cardGross"
        Me.cardGross.Size = New System.Drawing.Size(319, 90)
        Me.cardGross.TabIndex = 1
        '
        'stripeGross
        '
        Me.stripeGross.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.stripeGross.Location = New System.Drawing.Point(12, 16)
        Me.stripeGross.Margin = New System.Windows.Forms.Padding(4)
        Me.stripeGross.Name = "stripeGross"
        Me.stripeGross.Size = New System.Drawing.Size(5, 58)
        Me.stripeGross.TabIndex = 0
        '
        'lblGrossLbl
        '
        Me.lblGrossLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblGrossLbl.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblGrossLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblGrossLbl.Location = New System.Drawing.Point(28, 15)
        Me.lblGrossLbl.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGrossLbl.Name = "lblGrossLbl"
        Me.lblGrossLbl.Size = New System.Drawing.Size(86, 19)
        Me.lblGrossLbl.TabIndex = 1
        Me.lblGrossLbl.Text = "Gross Amount"
        '
        'lblGrossVal
        '
        Me.lblGrossVal.BackColor = System.Drawing.Color.Transparent
        Me.lblGrossVal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrossVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblGrossVal.Location = New System.Drawing.Point(28, 38)
        Me.lblGrossVal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGrossVal.Name = "lblGrossVal"
        Me.lblGrossVal.Size = New System.Drawing.Size(67, 33)
        Me.lblGrossVal.TabIndex = 2
        Me.lblGrossVal.Text = "P 0.00"
        '
        'cardDiscount
        '
        Me.cardDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cardDiscount.BorderRadius = 12
        Me.cardDiscount.Controls.Add(Me.stripeDiscount)
        Me.cardDiscount.Controls.Add(Me.lblDiscountLbl)
        Me.cardDiscount.Controls.Add(Me.lblDiscountVal)
        Me.cardDiscount.Location = New System.Drawing.Point(700, 15)
        Me.cardDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.cardDiscount.Name = "cardDiscount"
        Me.cardDiscount.Size = New System.Drawing.Size(319, 90)
        Me.cardDiscount.TabIndex = 2
        '
        'stripeDiscount
        '
        Me.stripeDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.stripeDiscount.Location = New System.Drawing.Point(12, 16)
        Me.stripeDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.stripeDiscount.Name = "stripeDiscount"
        Me.stripeDiscount.Size = New System.Drawing.Size(5, 58)
        Me.stripeDiscount.TabIndex = 0
        '
        'lblDiscountLbl
        '
        Me.lblDiscountLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscountLbl.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDiscountLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblDiscountLbl.Location = New System.Drawing.Point(28, 15)
        Me.lblDiscountLbl.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDiscountLbl.Name = "lblDiscountLbl"
        Me.lblDiscountLbl.Size = New System.Drawing.Size(86, 19)
        Me.lblDiscountLbl.TabIndex = 1
        Me.lblDiscountLbl.Text = "Total Discount"
        '
        'lblDiscountVal
        '
        Me.lblDiscountVal.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscountVal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiscountVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblDiscountVal.Location = New System.Drawing.Point(28, 38)
        Me.lblDiscountVal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDiscountVal.Name = "lblDiscountVal"
        Me.lblDiscountVal.Size = New System.Drawing.Size(67, 33)
        Me.lblDiscountVal.TabIndex = 2
        Me.lblDiscountVal.Text = "P 0.00"
        '
        'cardNetSales
        '
        Me.cardNetSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cardNetSales.BorderRadius = 12
        Me.cardNetSales.Controls.Add(Me.stripeNet)
        Me.cardNetSales.Controls.Add(Me.lblNetSalesLbl)
        Me.cardNetSales.Controls.Add(Me.lblNetSalesVal)
        Me.cardNetSales.Location = New System.Drawing.Point(1039, 15)
        Me.cardNetSales.Margin = New System.Windows.Forms.Padding(4)
        Me.cardNetSales.Name = "cardNetSales"
        Me.cardNetSales.Size = New System.Drawing.Size(319, 90)
        Me.cardNetSales.TabIndex = 3
        '
        'stripeNet
        '
        Me.stripeNet.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.stripeNet.Location = New System.Drawing.Point(12, 16)
        Me.stripeNet.Margin = New System.Windows.Forms.Padding(4)
        Me.stripeNet.Name = "stripeNet"
        Me.stripeNet.Size = New System.Drawing.Size(5, 58)
        Me.stripeNet.TabIndex = 0
        '
        'lblNetSalesLbl
        '
        Me.lblNetSalesLbl.BackColor = System.Drawing.Color.Transparent
        Me.lblNetSalesLbl.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNetSalesLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblNetSalesLbl.Location = New System.Drawing.Point(28, 15)
        Me.lblNetSalesLbl.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNetSalesLbl.Name = "lblNetSalesLbl"
        Me.lblNetSalesLbl.Size = New System.Drawing.Size(58, 19)
        Me.lblNetSalesLbl.TabIndex = 1
        Me.lblNetSalesLbl.Text = "Net Sales"
        '
        'lblNetSalesVal
        '
        Me.lblNetSalesVal.BackColor = System.Drawing.Color.Transparent
        Me.lblNetSalesVal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblNetSalesVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblNetSalesVal.Location = New System.Drawing.Point(28, 38)
        Me.lblNetSalesVal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblNetSalesVal.Name = "lblNetSalesVal"
        Me.lblNetSalesVal.Size = New System.Drawing.Size(67, 33)
        Me.lblNetSalesVal.TabIndex = 2
        Me.lblNetSalesVal.Text = "P 0.00"
        '
        'dgvmenuitem
        '
        Me.dgvmenuitem.AllowUserToAddRows = False
        Me.dgvmenuitem.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.dgvmenuitem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmenuitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvmenuitem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dgvmenuitem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.dgvmenuitem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmenuitem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvmenuitem.ColumnHeadersHeight = 4
        Me.dgvmenuitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmenuitem.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvmenuitem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvmenuitem.GridColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.dgvmenuitem.Location = New System.Drawing.Point(0, 311)
        Me.dgvmenuitem.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvmenuitem.Name = "dgvmenuitem"
        Me.dgvmenuitem.ReadOnly = True
        Me.dgvmenuitem.RowHeadersVisible = False
        Me.dgvmenuitem.RowHeadersWidth = 51
        Me.dgvmenuitem.RowTemplate.Height = 30
        Me.dgvmenuitem.Size = New System.Drawing.Size(1500, 522)
        Me.dgvmenuitem.TabIndex = 4
        Me.dgvmenuitem.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvmenuitem.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dgvmenuitem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvmenuitem.ThemeStyle.ReadOnly = True
        Me.dgvmenuitem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.dgvmenuitem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.dgvmenuitem.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvmenuitem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dgvmenuitem.ThemeStyle.RowsStyle.Height = 30
        Me.dgvmenuitem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvmenuitem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.lblLastRefresh)
        Me.pnlStatus.Controls.Add(Me.lblStatusRight)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 833)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1500, 42)
        Me.pnlStatus.TabIndex = 5
        '
        'lblLastRefresh
        '
        Me.lblLastRefresh.BackColor = System.Drawing.Color.Transparent
        Me.lblLastRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblLastRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblLastRefresh.Location = New System.Drawing.Point(18, 11)
        Me.lblLastRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLastRefresh.Name = "lblLastRefresh"
        Me.lblLastRefresh.Size = New System.Drawing.Size(40, 21)
        Me.lblLastRefresh.TabIndex = 0
        Me.lblLastRefresh.Text = "Ready"
        '
        'lblStatusRight
        '
        Me.lblStatusRight.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatusRight.BackColor = System.Drawing.Color.Transparent
        Me.lblStatusRight.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblStatusRight.Location = New System.Drawing.Point(2575, 11)
        Me.lblStatusRight.Margin = New System.Windows.Forms.Padding(4)
        Me.lblStatusRight.Name = "lblStatusRight"
        Me.lblStatusRight.Size = New System.Drawing.Size(119, 19)
        Me.lblStatusRight.TabIndex = 1
        Me.lblStatusRight.Text = "MenuItem Summary"
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
        Me.loader.Location = New System.Drawing.Point(716, 375)
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
        Me.lblLoading.Location = New System.Drawing.Point(672, 455)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(208, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Loading data, please wait..."
        '
        'frm_menuitem_summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 875)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvmenuitem)
        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1250, 725)
        Me.Name = "frm_menuitem_summary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuItem Summary"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlSummary.ResumeLayout(False)
        Me.cardTotalQty.ResumeLayout(False)
        Me.cardTotalQty.PerformLayout()
        Me.cardGross.ResumeLayout(False)
        Me.cardGross.PerformLayout()
        Me.cardDiscount.ResumeLayout(False)
        Me.cardDiscount.PerformLayout()
        Me.cardNetSales.ResumeLayout(False)
        Me.cardNetSales.PerformLayout()
        CType(Me.dgvmenuitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.pnlOverlay.ResumeLayout(False)
        Me.pnlOverlay.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ── Field declarations ───────────────────────────────────────────
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuitemPosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFormTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFormSub As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlToolbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFrom As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtFrom As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblTo As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtto As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblFilter As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbMajorgroup As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btngenerate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExportToExcel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRecordCount As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlSummary As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cardTotalQty As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeQty As System.Windows.Forms.Panel
    Friend WithEvents lblTotalQtyLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTotalQtyVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardGross As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeGross As System.Windows.Forms.Panel
    Friend WithEvents lblGrossLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGrossVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardDiscount As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeDiscount As System.Windows.Forms.Panel
    Friend WithEvents lblDiscountLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDiscountVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardNetSales As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeNet As System.Windows.Forms.Panel
    Friend WithEvents lblNetSalesLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNetSalesVal As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents dgvmenuitem As Guna.UI2.WinForms.Guna2DataGridView

    Friend WithEvents pnlStatus As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLastRefresh As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStatusRight As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlOverlay As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents lblLoading As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
