<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_pos_journal
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
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.pnlLeft = New Guna.UI2.WinForms.Guna2Panel()
        Me.cardView = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeView = New System.Windows.Forms.Panel()
        Me.lblCardView = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDateLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtdate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblSearchLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnGenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.cardReprint = New Guna.UI2.WinForms.Guna2Panel()
        Me.stripeReprint = New System.Windows.Forms.Panel()
        Me.lblCardReprint = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblChkLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtChknum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnGenerate_reprint = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExportPdf = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.cardView.SuspendLayout()
        Me.cardReprint.SuspendLayout()
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
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1500, 79)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(22, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(128, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>POS Journal</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(25, 45)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(342, 21)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "View and reprint POS receipts by date or check number"
        '
        'pnlBody
        '
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlBody.Controls.Add(Me.pnlRight)
        Me.pnlBody.Controls.Add(Me.pnlLeft)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 79)
        Me.pnlBody.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1500, 756)
        Me.pnlBody.TabIndex = 1
        '
        'pnlRight
        '
        Me.pnlRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlRight.Controls.Add(Me.ListView1)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(375, 0)
        Me.pnlRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(1125, 756)
        Me.pnlRight.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.OwnerDraw = True
        Me.ListView1.Size = New System.Drawing.Size(1125, 756)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.cardView)
        Me.pnlLeft.Controls.Add(Me.cardReprint)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.pnlLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(375, 756)
        Me.pnlLeft.TabIndex = 0
        '
        'cardView
        '
        Me.cardView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cardView.Controls.Add(Me.stripeView)
        Me.cardView.Controls.Add(Me.lblCardView)
        Me.cardView.Controls.Add(Me.lblDateLabel)
        Me.cardView.Controls.Add(Me.dtdate)
        Me.cardView.Controls.Add(Me.lblSearchLabel)
        Me.cardView.Controls.Add(Me.txtsearch)
        Me.cardView.Controls.Add(Me.btnGenerate)
        Me.cardView.Controls.Add(Me.btnSearch)
        Me.cardView.Dock = System.Windows.Forms.DockStyle.Top
        Me.cardView.Location = New System.Drawing.Point(0, 265)
        Me.cardView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cardView.Name = "cardView"
        Me.cardView.Size = New System.Drawing.Size(375, 310)
        Me.cardView.TabIndex = 0
        '
        'stripeView
        '
        Me.stripeView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.stripeView.Location = New System.Drawing.Point(0, 0)
        Me.stripeView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stripeView.Name = "stripeView"
        Me.stripeView.Size = New System.Drawing.Size(375, 5)
        Me.stripeView.TabIndex = 0
        '
        'lblCardView
        '
        Me.lblCardView.BackColor = System.Drawing.Color.Transparent
        Me.lblCardView.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblCardView.Location = New System.Drawing.Point(18, 18)
        Me.lblCardView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCardView.Name = "lblCardView"
        Me.lblCardView.Size = New System.Drawing.Size(102, 25)
        Me.lblCardView.TabIndex = 1
        Me.lblCardView.Text = "<b>View Receipt</b>"
        '
        'lblDateLabel
        '
        Me.lblDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblDateLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblDateLabel.Location = New System.Drawing.Point(18, 62)
        Me.lblDateLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDateLabel.Name = "lblDateLabel"
        Me.lblDateLabel.Size = New System.Drawing.Size(35, 21)
        Me.lblDateLabel.TabIndex = 2
        Me.lblDateLabel.Text = "Date:"
        '
        'dtdate
        '
        Me.dtdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtdate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtdate.Checked = True
        Me.dtdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtdate.Location = New System.Drawing.Point(18, 85)
        Me.dtdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtdate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtdate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtdate.Name = "dtdate"
        Me.dtdate.Size = New System.Drawing.Size(338, 38)
        Me.dtdate.TabIndex = 3
        Me.dtdate.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'lblSearchLabel
        '
        Me.lblSearchLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblSearchLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSearchLabel.Location = New System.Drawing.Point(18, 138)
        Me.lblSearchLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblSearchLabel.Name = "lblSearchLabel"
        Me.lblSearchLabel.Size = New System.Drawing.Size(111, 21)
        Me.lblSearchLabel.TabIndex = 4
        Me.lblSearchLabel.Text = "Search in receipt:"
        '
        'txtsearch
        '
        Me.txtsearch.BorderRadius = 8
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultText = ""
        Me.txtsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtsearch.Location = New System.Drawing.Point(18, 160)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtsearch.PlaceholderText = "Type to highlight matches..."
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.Size = New System.Drawing.Size(338, 42)
        Me.txtsearch.TabIndex = 0
        '
        'btnGenerate
        '
        Me.btnGenerate.Animated = True
        Me.btnGenerate.BorderRadius = 17
        Me.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerate.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnGenerate.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnGenerate.Location = New System.Drawing.Point(18, 250)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(162, 42)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Load Receipt"
        '
        'btnSearch
        '
        Me.btnSearch.Animated = True
        Me.btnSearch.BorderRadius = 17
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(192, 250)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(158, 42)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Find Next"
        '
        'cardReprint
        '
        Me.cardReprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.cardReprint.Controls.Add(Me.stripeReprint)
        Me.cardReprint.Controls.Add(Me.lblCardReprint)
        Me.cardReprint.Controls.Add(Me.lblChkLabel)
        Me.cardReprint.Controls.Add(Me.txtChknum)
        Me.cardReprint.Controls.Add(Me.btnGenerate_reprint)
        Me.cardReprint.Controls.Add(Me.btnExportPdf)
        Me.cardReprint.Dock = System.Windows.Forms.DockStyle.Top
        Me.cardReprint.Location = New System.Drawing.Point(0, 0)
        Me.cardReprint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cardReprint.Name = "cardReprint"
        Me.cardReprint.Size = New System.Drawing.Size(375, 265)
        Me.cardReprint.TabIndex = 1
        '
        'stripeReprint
        '
        Me.stripeReprint.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.stripeReprint.Location = New System.Drawing.Point(0, 0)
        Me.stripeReprint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.stripeReprint.Name = "stripeReprint"
        Me.stripeReprint.Size = New System.Drawing.Size(375, 5)
        Me.stripeReprint.TabIndex = 0
        '
        'lblCardReprint
        '
        Me.lblCardReprint.BackColor = System.Drawing.Color.Transparent
        Me.lblCardReprint.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblCardReprint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblCardReprint.Location = New System.Drawing.Point(18, 18)
        Me.lblCardReprint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblCardReprint.Name = "lblCardReprint"
        Me.lblCardReprint.Size = New System.Drawing.Size(203, 25)
        Me.lblCardReprint.TabIndex = 1
        Me.lblCardReprint.Text = "<b>Reprint by Check Number</b>"
        '
        'lblChkLabel
        '
        Me.lblChkLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblChkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!)
        Me.lblChkLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblChkLabel.Location = New System.Drawing.Point(18, 62)
        Me.lblChkLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblChkLabel.Name = "lblChkLabel"
        Me.lblChkLabel.Size = New System.Drawing.Size(99, 21)
        Me.lblChkLabel.TabIndex = 2
        Me.lblChkLabel.Text = "Check Number:"
        '
        'txtChknum
        '
        Me.txtChknum.BorderRadius = 8
        Me.txtChknum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChknum.DefaultText = ""
        Me.txtChknum.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtChknum.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtChknum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtChknum.Location = New System.Drawing.Point(18, 85)
        Me.txtChknum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChknum.Name = "txtChknum"
        Me.txtChknum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChknum.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtChknum.PlaceholderText = "Enter check number..."
        Me.txtChknum.SelectedText = ""
        Me.txtChknum.Size = New System.Drawing.Size(338, 42)
        Me.txtChknum.TabIndex = 0
        '
        'btnGenerate_reprint
        '
        Me.btnGenerate_reprint.Animated = True
        Me.btnGenerate_reprint.BorderRadius = 17
        Me.btnGenerate_reprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerate_reprint.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnGenerate_reprint.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerate_reprint.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnGenerate_reprint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnGenerate_reprint.Location = New System.Drawing.Point(18, 150)
        Me.btnGenerate_reprint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerate_reprint.Name = "btnGenerate_reprint"
        Me.btnGenerate_reprint.Size = New System.Drawing.Size(162, 42)
        Me.btnGenerate_reprint.TabIndex = 1
        Me.btnGenerate_reprint.Text = "Load Reprint"
        '
        'btnExportPdf
        '
        Me.btnExportPdf.Animated = True
        Me.btnExportPdf.BorderRadius = 17
        Me.btnExportPdf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportPdf.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnExportPdf.FillColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnExportPdf.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnExportPdf.ForeColor = System.Drawing.Color.White
        Me.btnExportPdf.Location = New System.Drawing.Point(192, 150)
        Me.btnExportPdf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExportPdf.Name = "btnExportPdf"
        Me.btnExportPdf.Size = New System.Drawing.Size(158, 42)
        Me.btnExportPdf.TabIndex = 2
        Me.btnExportPdf.Text = "Export PDF"
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
        Me.lblLoading.Location = New System.Drawing.Point(662, 430)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(233, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Loading receipts, please wait..."
        '
        'pnlStatus
        '
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlStatus.Controls.Add(Me.lblStatus)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 835)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1500, 40)
        Me.pnlStatus.TabIndex = 3
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
        'frm_pos_journal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 875)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1125, 675)
        Me.Name = "frm_pos_journal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS Journal"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.cardView.ResumeLayout(False)
        Me.cardView.PerformLayout()
        Me.cardReprint.ResumeLayout(False)
        Me.cardReprint.PerformLayout()
        Me.pnlOverlay.ResumeLayout(False)
        Me.pnlOverlay.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    ' ── Field declarations ───────────────────────────────────────────
    Friend WithEvents pnlHeader      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle       As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle    As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlBody        As System.Windows.Forms.Panel
    Friend WithEvents pnlLeft        As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlRight       As System.Windows.Forms.Panel

    Friend WithEvents cardView       As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeView     As System.Windows.Forms.Panel
    Friend WithEvents lblCardView    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblDateLabel   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtdate         As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblSearchLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtsearch      As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnGenerate    As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch      As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents cardReprint       As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents stripeReprint     As System.Windows.Forms.Panel
    Friend WithEvents lblCardReprint    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblChkLabel       As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtChknum         As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnGenerate_reprint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExportPdf      As Guna.UI2.WinForms.Guna2Button

    Friend WithEvents ListView1      As System.Windows.Forms.ListView

    Friend WithEvents pnlStatus      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus      As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlOverlay     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader         As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading     As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
