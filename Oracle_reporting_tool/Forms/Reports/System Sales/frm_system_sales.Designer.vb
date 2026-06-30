<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_system_sales
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VarianceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeSalesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.POSSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VATExemptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NonCashToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFromLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblToLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtto = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnGenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.lblStore = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlReport = New System.Windows.Forms.Panel()
        Me.rv_salesreport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ZreadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHeader.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlReport.SuspendLayout()
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
        Me.lblTitle.Size = New System.Drawing.Size(214, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>System Sales Report</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(25, 45)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(323, 21)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Consolidated sales summary with tender breakdown"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.MenuStrip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VarianceToolStripMenuItem, Me.EmployeeSalesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 78)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1500, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VarianceToolStripMenuItem
        '
        Me.VarianceToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.VarianceToolStripMenuItem.Name = "VarianceToolStripMenuItem"
        Me.VarianceToolStripMenuItem.Size = New System.Drawing.Size(151, 25)
        Me.VarianceToolStripMenuItem.Text = "Variance Checking"
        '
        'EmployeeSalesToolStripMenuItem
        '
        Me.EmployeeSalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeSalesToolStripMenuItem1, Me.POSSalesToolStripMenuItem, Me.VATExemptToolStripMenuItem, Me.NonCashToolStripMenuItem, Me.ZreadingToolStripMenuItem})
        Me.EmployeeSalesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.EmployeeSalesToolStripMenuItem.Name = "EmployeeSalesToolStripMenuItem"
        Me.EmployeeSalesToolStripMenuItem.Size = New System.Drawing.Size(104, 25)
        Me.EmployeeSalesToolStripMenuItem.Text = "Other Sales"
        '
        'EmployeeSalesToolStripMenuItem1
        '
        Me.EmployeeSalesToolStripMenuItem1.Name = "EmployeeSalesToolStripMenuItem1"
        Me.EmployeeSalesToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.EmployeeSalesToolStripMenuItem1.Text = "Employee Sales"
        '
        'POSSalesToolStripMenuItem
        '
        Me.POSSalesToolStripMenuItem.Name = "POSSalesToolStripMenuItem"
        Me.POSSalesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.POSSalesToolStripMenuItem.Text = "POS Sales"
        '
        'VATExemptToolStripMenuItem
        '
        Me.VATExemptToolStripMenuItem.Name = "VATExemptToolStripMenuItem"
        Me.VATExemptToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.VATExemptToolStripMenuItem.Text = "SC/PWD Listing"
        '
        'NonCashToolStripMenuItem
        '
        Me.NonCashToolStripMenuItem.Name = "NonCashToolStripMenuItem"
        Me.NonCashToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NonCashToolStripMenuItem.Text = "Tender Listing"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlToolbar.Controls.Add(Me.lblFromLabel)
        Me.pnlToolbar.Controls.Add(Me.dtFrom)
        Me.pnlToolbar.Controls.Add(Me.lblToLabel)
        Me.pnlToolbar.Controls.Add(Me.dtto)
        Me.pnlToolbar.Controls.Add(Me.btnGenerate)
        Me.pnlToolbar.Controls.Add(Me.lblStore)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 107)
        Me.pnlToolbar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(1500, 72)
        Me.pnlToolbar.TabIndex = 2
        '
        'lblFromLabel
        '
        Me.lblFromLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblFromLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblFromLabel.Location = New System.Drawing.Point(18, 25)
        Me.lblFromLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblFromLabel.Name = "lblFromLabel"
        Me.lblFromLabel.Size = New System.Drawing.Size(43, 22)
        Me.lblFromLabel.TabIndex = 0
        Me.lblFromLabel.Text = "From:"
        '
        'dtFrom
        '
        Me.dtFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtFrom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtFrom.Checked = True
        Me.dtFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFrom.Location = New System.Drawing.Point(75, 18)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(222, 38)
        Me.dtFrom.TabIndex = 0
        Me.dtFrom.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'lblToLabel
        '
        Me.lblToLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblToLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblToLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblToLabel.Location = New System.Drawing.Point(315, 25)
        Me.lblToLabel.Margin = New System.Windows.Forms.Padding(4)
        Me.lblToLabel.Name = "lblToLabel"
        Me.lblToLabel.Size = New System.Drawing.Size(24, 22)
        Me.lblToLabel.TabIndex = 1
        Me.lblToLabel.Text = "To:"
        '
        'dtto
        '
        Me.dtto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtto.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtto.Checked = True
        Me.dtto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtto.Location = New System.Drawing.Point(348, 18)
        Me.dtto.Margin = New System.Windows.Forms.Padding(4)
        Me.dtto.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtto.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtto.Name = "dtto"
        Me.dtto.Size = New System.Drawing.Size(222, 38)
        Me.dtto.TabIndex = 1
        Me.dtto.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
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
        Me.btnGenerate.Location = New System.Drawing.Point(588, 15)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(190, 42)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "Generate Report"
        '
        'lblStore
        '
        Me.lblStore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStore.BackColor = System.Drawing.Color.Transparent
        Me.lblStore.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblStore.Location = New System.Drawing.Point(2045, 25)
        Me.lblStore.Margin = New System.Windows.Forms.Padding(4)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(3, 2)
        Me.lblStore.TabIndex = 3
        Me.lblStore.Text = Nothing
        '
        'pnlReport
        '
        Me.pnlReport.BackColor = System.Drawing.Color.White
        Me.pnlReport.Controls.Add(Me.rv_salesreport)
        Me.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReport.Location = New System.Drawing.Point(0, 179)
        Me.pnlReport.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlReport.Name = "pnlReport"
        Me.pnlReport.Size = New System.Drawing.Size(1500, 656)
        Me.pnlReport.TabIndex = 3
        '
        'rv_salesreport
        '
        Me.rv_salesreport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_salesreport.Location = New System.Drawing.Point(0, 0)
        Me.rv_salesreport.Margin = New System.Windows.Forms.Padding(4)
        Me.rv_salesreport.Name = "rv_salesreport"
        Me.rv_salesreport.ServerReport.BearerToken = Nothing
        Me.rv_salesreport.Size = New System.Drawing.Size(1500, 656)
        Me.rv_salesreport.TabIndex = 0
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
        Me.lblLoading.Location = New System.Drawing.Point(662, 430)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(245, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Generating report, please wait..."
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
        'ZreadingToolStripMenuItem
        '
        Me.ZreadingToolStripMenuItem.Name = "ZreadingToolStripMenuItem"
        Me.ZreadingToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ZreadingToolStripMenuItem.Text = "Zreading"
        '
        'frm_system_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 875)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlReport)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_system_sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Sales Report"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlReport.ResumeLayout(False)
        Me.pnlOverlay.ResumeLayout(False)
        Me.pnlOverlay.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ── Field declarations ───────────────────────────────────────────
    Friend WithEvents pnlHeader    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle  As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents MenuStrip1                     As System.Windows.Forms.MenuStrip
    Friend WithEvents VarianceToolStripMenuItem      As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeSalesToolStripMenuItem  As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeSalesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents POSSalesToolStripMenuItem       As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VATExemptToolStripMenuItem      As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NonCashToolStripMenuItem        As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents pnlToolbar   As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFromLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtFrom       As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblToLabel   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtto         As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnGenerate  As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStore     As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlReport      As System.Windows.Forms.Panel
    Friend WithEvents rv_salesreport As Microsoft.Reporting.WinForms.ReportViewer

    Friend WithEvents pnlStatus    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus    As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlOverlay   As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader       As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents lblLoading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ZreadingToolStripMenuItem As ToolStripMenuItem
End Class
