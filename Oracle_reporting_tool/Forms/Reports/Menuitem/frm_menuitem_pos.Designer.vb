<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_menuitem_pos
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

        ' ── Instantiate ALL controls first (flat, no nested calls) ───
        Me.BackgroundWorker1                = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1                       = New System.Windows.Forms.MenuStrip()
        Me.MenuitemSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()

        Me.pnlHeader        = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFormTitle      = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFormSub        = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlToolbar        = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFrom           = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtFrom            = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblTo             = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtto              = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btngenerate       = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExportToExcel  = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRecordCount    = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlSummary        = New Guna.UI2.WinForms.Guna2Panel()
        Me.cardTotalQty      = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeQty         = New System.Windows.Forms.Panel()
        Me.lblTotalQtyLbl    = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblTotalQtyVal    = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardGross         = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeGross       = New System.Windows.Forms.Panel()
        Me.lblGrossLbl       = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblGrossVal       = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardDiscount      = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeDiscount    = New System.Windows.Forms.Panel()
        Me.lblDiscountLbl    = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDiscountVal    = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.cardNetSales      = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeNet         = New System.Windows.Forms.Panel()
        Me.lblNetSalesLbl    = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblNetSalesVal    = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.dgvmenuitem       = New Guna.UI2.WinForms.Guna2DataGridView()

        Me.pnlStatus         = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblLastRefresh    = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblStatusRight    = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlOverlay        = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader            = New Guna.UI2.WinForms.Guna2CircleProgressbar()
        Me.lblLoading        = New Guna.UI2.WinForms.Guna2HtmlLabel()

        ' ── SuspendLayout ────────────────────────────────────────────
        CType(Me.dgvmenuitem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlSummary.SuspendLayout()
        Me.cardTotalQty.SuspendLayout()
        Me.cardGross.SuspendLayout()
        Me.cardDiscount.SuspendLayout()
        Me.cardNetSales.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
        Me.SuspendLayout()

        ' ════════════════════════════════════════════════════════════
        '  FORM
        '  AutoScaleMode.Dpi + 96,96 = proper DPI-aware scaling
        ' ════════════════════════════════════════════════════════════
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor           = System.Drawing.Color.FromArgb(255, 245, 235)
        Me.ClientSize          = New System.Drawing.Size(1200, 700)
        Me.ControlBox          = False
        Me.Font                = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor           = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize         = New System.Drawing.Size(1000, 580)
        Me.Name                = "frm_menuitem_pos"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "MenuItem by Sales"
        ' Add controls in Z-order (overlay last = topmost)
        Me.Controls.Add(Me.dgvmenuitem)
        Me.Controls.Add(Me.pnlSummary)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlOverlay)
        Me.MainMenuStrip = Me.MenuStrip1

        ' ════════════════════════════════════════════════════════════
        '  MENU STRIP
        ' ════════════════════════════════════════════════════════════
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.MenuStrip1.Font      = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Dock      = System.Windows.Forms.DockStyle.Top
        Me.MenuStrip1.Location  = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name      = "MenuStrip1"
        Me.MenuStrip1.Size      = New System.Drawing.Size(1200, 26)
        Me.MenuStrip1.TabIndex  = 0
        Me.MenuStrip1.Text      = "MenuStrip1"
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuitemSummaryToolStripMenuItem})

        Me.MenuitemSummaryToolStripMenuItem.Name = "MenuitemSummaryToolStripMenuItem"
        Me.MenuitemSummaryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.MenuitemSummaryToolStripMenuItem.Text = "Menuitem Summary"

        ' ════════════════════════════════════════════════════════════
        '  HEADER  (Dock=Top, 62 px)
        ' ════════════════════════════════════════════════════════════
        Me.pnlHeader.Name      = "pnlHeader"
        Me.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height    = 62
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.pnlHeader.TabIndex  = 1
        Me.pnlHeader.Controls.Add(Me.lblFormTitle)
        Me.pnlHeader.Controls.Add(Me.lblFormSub)

        Me.lblFormTitle.Name      = "lblFormTitle"
        Me.lblFormTitle.Text      = "<b>MenuItem Sales Report</b>"
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblFormTitle.Font      = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblFormTitle.AutoSize  = True
        Me.lblFormTitle.Location  = New System.Drawing.Point(18, 7)
        Me.lblFormTitle.BackColor = System.Drawing.Color.Transparent

        Me.lblFormSub.Name      = "lblFormSub"
        Me.lblFormSub.Text      = "Sales count, gross amount, discounts and net sales per menu item"
        Me.lblFormSub.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblFormSub.Font      = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblFormSub.AutoSize  = True
        Me.lblFormSub.Location  = New System.Drawing.Point(20, 36)
        Me.lblFormSub.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  TOOLBAR  (Dock=Top, 62 px)
        ' ════════════════════════════════════════════════════════════
        Me.pnlToolbar.Name      = "pnlToolbar"
        Me.pnlToolbar.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Height    = 62
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(255, 245, 235)
        Me.pnlToolbar.TabIndex  = 2
        Me.pnlToolbar.Controls.Add(Me.lblFrom)
        Me.pnlToolbar.Controls.Add(Me.dtFrom)
        Me.pnlToolbar.Controls.Add(Me.lblTo)
        Me.pnlToolbar.Controls.Add(Me.dtto)
        Me.pnlToolbar.Controls.Add(Me.btngenerate)
        Me.pnlToolbar.Controls.Add(Me.btnExportToExcel)
        Me.pnlToolbar.Controls.Add(Me.lblRecordCount)

        ' lblFrom
        Me.lblFrom.Name      = "lblFrom"
        Me.lblFrom.Text      = "From:"
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblFrom.Font      = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblFrom.AutoSize  = True
        Me.lblFrom.Location  = New System.Drawing.Point(18, 22)
        Me.lblFrom.BackColor = System.Drawing.Color.Transparent

        ' dtFrom  — NOTE: use CustomBorderColor, NOT BorderColor (Guna2DateTimePicker)
        Me.dtFrom.Name             = "dtFrom"
        Me.dtFrom.Size             = New System.Drawing.Size(148, 30)
        Me.dtFrom.Location         = New System.Drawing.Point(66, 16)
        Me.dtFrom.Font             = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.dtFrom.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dtFrom.BackColor        = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.dtFrom.BorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.dtFrom.Format           = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFrom.Value            = New DateTime(2025, 1, 1)

        ' lblTo
        Me.lblTo.Name      = "lblTo"
        Me.lblTo.Text      = "To:"
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblTo.Font      = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblTo.AutoSize  = True
        Me.lblTo.Location  = New System.Drawing.Point(228, 22)
        Me.lblTo.BackColor = System.Drawing.Color.Transparent

        ' dtto
        Me.dtto.Name             = "dtto"
        Me.dtto.Size             = New System.Drawing.Size(148, 30)
        Me.dtto.Location         = New System.Drawing.Point(256, 16)
        Me.dtto.Font             = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.dtto.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dtto.BackColor        = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.dtto.BorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.dtto.Format           = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtto.Value            = New DateTime(2025, 1, 1)

        ' btngenerate  — NO special unicode chars (causes E_INVALIDARG in Designer)
        Me.btngenerate.Name             = "btngenerate"
        Me.btngenerate.Text             = "Generate"
        Me.btngenerate.Size             = New System.Drawing.Size(120, 34)
        Me.btngenerate.Location         = New System.Drawing.Point(418, 14)
        Me.btngenerate.Font             = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btngenerate.BorderRadius     = 17
        Me.btngenerate.FillColor        = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.btngenerate.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.btngenerate.CustomBorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.btngenerate.Animated         = True
        Me.btngenerate.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.btngenerate.TabIndex         = 0

        ' btnExportToExcel
        Me.btnExportToExcel.Name             = "btnExportToExcel"
        Me.btnExportToExcel.Text             = "Export to Excel"
        Me.btnExportToExcel.Size             = New System.Drawing.Size(140, 34)
        Me.btnExportToExcel.Location         = New System.Drawing.Point(550, 14)
        Me.btnExportToExcel.Font             = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnExportToExcel.BorderRadius     = 17
        Me.btnExportToExcel.FillColor        = System.Drawing.Color.FromArgb(76, 153, 85)
        Me.btnExportToExcel.ForeColor        = System.Drawing.Color.White
        Me.btnExportToExcel.CustomBorderColor = System.Drawing.Color.FromArgb(55, 120, 65)
        Me.btnExportToExcel.Animated         = True
        Me.btnExportToExcel.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.btnExportToExcel.TabIndex         = 1

        ' lblRecordCount  (right-anchored, position adjusted at runtime)
        Me.lblRecordCount.Name      = "lblRecordCount"
        Me.lblRecordCount.Text      = "0 records"
        Me.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblRecordCount.Font      = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblRecordCount.AutoSize  = True
        Me.lblRecordCount.Anchor    = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.lblRecordCount.Location  = New System.Drawing.Point(1060, 22)
        Me.lblRecordCount.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  KPI SUMMARY STRIP  (Dock=Top, 96 px)
        ' ════════════════════════════════════════════════════════════
        Me.pnlSummary.Name      = "pnlSummary"
        Me.pnlSummary.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlSummary.Height    = 96
        Me.pnlSummary.BackColor = System.Drawing.Color.FromArgb(255, 245, 235)
        Me.pnlSummary.TabIndex  = 3
        Me.pnlSummary.Controls.Add(Me.cardTotalQty)
        Me.pnlSummary.Controls.Add(Me.cardGross)
        Me.pnlSummary.Controls.Add(Me.cardDiscount)
        Me.pnlSummary.Controls.Add(Me.cardNetSales)

        ' ── cardTotalQty ─────────────────────────────────────────────
        Me.cardTotalQty.Name         = "cardTotalQty"
        Me.cardTotalQty.BackColor    = System.Drawing.Color.FromArgb(255, 255, 250)
        Me.cardTotalQty.BorderRadius = 12
        Me.cardTotalQty.Size         = New System.Drawing.Size(255, 72)
        Me.cardTotalQty.Location     = New System.Drawing.Point(18, 12)
        Me.cardTotalQty.TabIndex     = 0
        Me.cardTotalQty.Controls.Add(Me.stripeQty)
        Me.cardTotalQty.Controls.Add(Me.lblTotalQtyLbl)
        Me.cardTotalQty.Controls.Add(Me.lblTotalQtyVal)

        Me.stripeQty.Name      = "stripeQty"
        Me.stripeQty.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.stripeQty.Size      = New System.Drawing.Size(4, 46)
        Me.stripeQty.Location  = New System.Drawing.Point(10, 13)

        Me.lblTotalQtyLbl.Name      = "lblTotalQtyLbl"
        Me.lblTotalQtyLbl.Text      = "Total Qty Sold"
        Me.lblTotalQtyLbl.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblTotalQtyLbl.Font      = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblTotalQtyLbl.AutoSize  = True
        Me.lblTotalQtyLbl.Location  = New System.Drawing.Point(22, 12)
        Me.lblTotalQtyLbl.BackColor = System.Drawing.Color.Transparent

        Me.lblTotalQtyVal.Name      = "lblTotalQtyVal"
        Me.lblTotalQtyVal.Text      = "0"
        Me.lblTotalQtyVal.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblTotalQtyVal.Font      = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalQtyVal.AutoSize  = True
        Me.lblTotalQtyVal.Location  = New System.Drawing.Point(22, 30)
        Me.lblTotalQtyVal.BackColor = System.Drawing.Color.Transparent

        ' ── cardGross ────────────────────────────────────────────────
        Me.cardGross.Name         = "cardGross"
        Me.cardGross.BackColor    = System.Drawing.Color.FromArgb(255, 255, 250)
        Me.cardGross.BorderRadius = 12
        Me.cardGross.Size         = New System.Drawing.Size(255, 72)
        Me.cardGross.Location     = New System.Drawing.Point(289, 12)
        Me.cardGross.TabIndex     = 1
        Me.cardGross.Controls.Add(Me.stripeGross)
        Me.cardGross.Controls.Add(Me.lblGrossLbl)
        Me.cardGross.Controls.Add(Me.lblGrossVal)

        Me.stripeGross.Name      = "stripeGross"
        Me.stripeGross.BackColor = System.Drawing.Color.FromArgb(220, 160, 90)
        Me.stripeGross.Size      = New System.Drawing.Size(4, 46)
        Me.stripeGross.Location  = New System.Drawing.Point(10, 13)

        Me.lblGrossLbl.Name      = "lblGrossLbl"
        Me.lblGrossLbl.Text      = "Gross Amount"
        Me.lblGrossLbl.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblGrossLbl.Font      = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblGrossLbl.AutoSize  = True
        Me.lblGrossLbl.Location  = New System.Drawing.Point(22, 12)
        Me.lblGrossLbl.BackColor = System.Drawing.Color.Transparent

        Me.lblGrossVal.Name      = "lblGrossVal"
        Me.lblGrossVal.Text      = "P 0.00"
        Me.lblGrossVal.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblGrossVal.Font      = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrossVal.AutoSize  = True
        Me.lblGrossVal.Location  = New System.Drawing.Point(22, 30)
        Me.lblGrossVal.BackColor = System.Drawing.Color.Transparent

        ' ── cardDiscount ─────────────────────────────────────────────
        Me.cardDiscount.Name         = "cardDiscount"
        Me.cardDiscount.BackColor    = System.Drawing.Color.FromArgb(255, 255, 250)
        Me.cardDiscount.BorderRadius = 12
        Me.cardDiscount.Size         = New System.Drawing.Size(255, 72)
        Me.cardDiscount.Location     = New System.Drawing.Point(560, 12)
        Me.cardDiscount.TabIndex     = 2
        Me.cardDiscount.Controls.Add(Me.stripeDiscount)
        Me.cardDiscount.Controls.Add(Me.lblDiscountLbl)
        Me.cardDiscount.Controls.Add(Me.lblDiscountVal)

        Me.stripeDiscount.Name      = "stripeDiscount"
        Me.stripeDiscount.BackColor = System.Drawing.Color.FromArgb(200, 110, 60)
        Me.stripeDiscount.Size      = New System.Drawing.Size(4, 46)
        Me.stripeDiscount.Location  = New System.Drawing.Point(10, 13)

        Me.lblDiscountLbl.Name      = "lblDiscountLbl"
        Me.lblDiscountLbl.Text      = "Total Discount"
        Me.lblDiscountLbl.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblDiscountLbl.Font      = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblDiscountLbl.AutoSize  = True
        Me.lblDiscountLbl.Location  = New System.Drawing.Point(22, 12)
        Me.lblDiscountLbl.BackColor = System.Drawing.Color.Transparent

        Me.lblDiscountVal.Name      = "lblDiscountVal"
        Me.lblDiscountVal.Text      = "P 0.00"
        Me.lblDiscountVal.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblDiscountVal.Font      = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblDiscountVal.AutoSize  = True
        Me.lblDiscountVal.Location  = New System.Drawing.Point(22, 30)
        Me.lblDiscountVal.BackColor = System.Drawing.Color.Transparent

        ' ── cardNetSales ─────────────────────────────────────────────
        Me.cardNetSales.Name         = "cardNetSales"
        Me.cardNetSales.BackColor    = System.Drawing.Color.FromArgb(255, 255, 250)
        Me.cardNetSales.BorderRadius = 12
        Me.cardNetSales.Size         = New System.Drawing.Size(255, 72)
        Me.cardNetSales.Location     = New System.Drawing.Point(831, 12)
        Me.cardNetSales.TabIndex     = 3
        Me.cardNetSales.Controls.Add(Me.stripeNet)
        Me.cardNetSales.Controls.Add(Me.lblNetSalesLbl)
        Me.cardNetSales.Controls.Add(Me.lblNetSalesVal)

        Me.stripeNet.Name      = "stripeNet"
        Me.stripeNet.BackColor = System.Drawing.Color.FromArgb(180, 80, 40)
        Me.stripeNet.Size      = New System.Drawing.Size(4, 46)
        Me.stripeNet.Location  = New System.Drawing.Point(10, 13)

        Me.lblNetSalesLbl.Name      = "lblNetSalesLbl"
        Me.lblNetSalesLbl.Text      = "Net Sales"
        Me.lblNetSalesLbl.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblNetSalesLbl.Font      = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNetSalesLbl.AutoSize  = True
        Me.lblNetSalesLbl.Location  = New System.Drawing.Point(22, 12)
        Me.lblNetSalesLbl.BackColor = System.Drawing.Color.Transparent

        Me.lblNetSalesVal.Name      = "lblNetSalesVal"
        Me.lblNetSalesVal.Text      = "P 0.00"
        Me.lblNetSalesVal.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblNetSalesVal.Font      = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblNetSalesVal.AutoSize  = True
        Me.lblNetSalesVal.Location  = New System.Drawing.Point(22, 30)
        Me.lblNetSalesVal.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  DATA GRID  (Dock=Fill)
        ' ════════════════════════════════════════════════════════════
        Me.dgvmenuitem.Name                    = "dgvmenuitem"
        Me.dgvmenuitem.Dock                    = System.Windows.Forms.DockStyle.Fill
        Me.dgvmenuitem.TabIndex                = 4
        Me.dgvmenuitem.RowHeadersVisible        = False
        Me.dgvmenuitem.AllowUserToAddRows       = False
        Me.dgvmenuitem.AllowUserToDeleteRows    = False
        Me.dgvmenuitem.ReadOnly                 = True
        Me.dgvmenuitem.CellBorderStyle          = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvmenuitem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single
        Me.dgvmenuitem.AutoSizeColumnsMode      = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvmenuitem.RowTemplate.Height       = 30
        Me.dgvmenuitem.SelectionMode            = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmenuitem.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.dgvmenuitem.ThemeStyle.BackColor                               = System.Drawing.Color.FromArgb(255, 255, 250)
        Me.dgvmenuitem.ThemeStyle.GridColor                               = System.Drawing.Color.FromArgb(230, 195, 155)
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.BackColor                   = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.ForeColor                   = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.Font                        = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.BorderStyle                 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single
        Me.dgvmenuitem.ThemeStyle.HeaderStyle.HeaightSizeMode             = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmenuitem.ThemeStyle.RowsStyle.BackColor                     = System.Drawing.Color.FromArgb(255, 255, 250)
        Me.dgvmenuitem.ThemeStyle.RowsStyle.ForeColor                     = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dgvmenuitem.ThemeStyle.RowsStyle.Font                          = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgvmenuitem.ThemeStyle.RowsStyle.Height                        = 30
        Me.dgvmenuitem.ThemeStyle.RowsStyle.SelectionBackColor            = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.dgvmenuitem.ThemeStyle.RowsStyle.SelectionForeColor            = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dgvmenuitem.ThemeStyle.RowsStyle.BorderStyle                   = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.BackColor          = System.Drawing.Color.FromArgb(255, 245, 228)
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.Font               = Nothing
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.ForeColor          = System.Drawing.Color.Empty
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvmenuitem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty

        ' ════════════════════════════════════════════════════════════
        '  STATUS BAR  (Dock=Bottom, 34 px)
        ' ════════════════════════════════════════════════════════════
        Me.pnlStatus.Name      = "pnlStatus"
        Me.pnlStatus.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Height    = 34
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.pnlStatus.TabIndex  = 5
        Me.pnlStatus.Controls.Add(Me.lblLastRefresh)
        Me.pnlStatus.Controls.Add(Me.lblStatusRight)

        Me.lblLastRefresh.Name      = "lblLastRefresh"
        Me.lblLastRefresh.Text      = "Ready"
        Me.lblLastRefresh.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblLastRefresh.Font      = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblLastRefresh.AutoSize  = True
        Me.lblLastRefresh.Location  = New System.Drawing.Point(14, 9)
        Me.lblLastRefresh.BackColor = System.Drawing.Color.Transparent

        Me.lblStatusRight.Name      = "lblStatusRight"
        Me.lblStatusRight.Text      = "MenuItem by Sales"
        Me.lblStatusRight.ForeColor = System.Drawing.Color.FromArgb(180, 130, 80)
        Me.lblStatusRight.Font      = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblStatusRight.AutoSize  = True
        Me.lblStatusRight.Anchor    = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.lblStatusRight.Location  = New System.Drawing.Point(1060, 9)
        Me.lblStatusRight.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  LOADING OVERLAY  (Dock=Fill, hidden)
        '  NOTE: Guna2CircleProgressbar — only ProgressColor is safe
        '  in the Designer; ProgressColor2 must be set in code-behind
        ' ════════════════════════════════════════════════════════════
        Me.pnlOverlay.Name      = "pnlOverlay"
        Me.pnlOverlay.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverlay.BackColor = System.Drawing.Color.FromArgb(210, 255, 240, 220)
        Me.pnlOverlay.Visible   = False
        Me.pnlOverlay.TabIndex  = 99
        Me.pnlOverlay.Controls.Add(Me.loader)
        Me.pnlOverlay.Controls.Add(Me.lblLoading)

        Me.loader.Name          = "loader"
        Me.loader.Size          = New System.Drawing.Size(54, 54)
        Me.loader.ProgressColor = System.Drawing.Color.FromArgb(210, 140, 80)
        Me.loader.Value         = 75
        Me.loader.Animated      = True
        Me.loader.Location      = New System.Drawing.Point(573, 300)
        Me.loader.TabIndex      = 0

        Me.lblLoading.Name      = "lblLoading"
        Me.lblLoading.Text      = "Loading data, please wait..."
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblLoading.Font      = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoading.AutoSize  = True
        Me.lblLoading.Location  = New System.Drawing.Point(538, 364)
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.TabIndex  = 1

        ' ── BackgroundWorker ─────────────────────────────────────────
        Me.BackgroundWorker1.WorkerReportsProgress = True

        ' ── ResumeLayout ─────────────────────────────────────────────
        CType(Me.dgvmenuitem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlSummary.ResumeLayout(False)
        Me.cardTotalQty.ResumeLayout(False)
        Me.cardGross.ResumeLayout(False)
        Me.cardDiscount.ResumeLayout(False)
        Me.cardNetSales.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlOverlay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ── Field declarations ───────────────────────────────────────────
    Friend WithEvents BackgroundWorker1                As System.ComponentModel.BackgroundWorker
    Friend WithEvents MenuStrip1                       As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuitemSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents pnlHeader     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFormTitle  As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFormSub    As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlToolbar       As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFrom          As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtFrom           As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblTo            As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtto             As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btngenerate      As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExportToExcel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRecordCount   As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlSummary    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cardTotalQty  As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeQty     As System.Windows.Forms.Panel
    Friend WithEvents lblTotalQtyLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblTotalQtyVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardGross     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeGross   As System.Windows.Forms.Panel
    Friend WithEvents lblGrossLbl   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblGrossVal   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardDiscount  As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeDiscount As System.Windows.Forms.Panel
    Friend WithEvents lblDiscountLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDiscountVal As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cardNetSales  As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeNet     As System.Windows.Forms.Panel
    Friend WithEvents lblNetSalesLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNetSalesVal As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents dgvmenuitem   As Guna.UI2.WinForms.Guna2DataGridView

    Friend WithEvents pnlStatus      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblLastRefresh As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStatusRight As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlOverlay  As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader      As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading  As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
