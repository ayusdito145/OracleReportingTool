<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_employee_sales
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

        ' ── Instantiate ──────────────────────────────────────────────
        Me.pnlHeader      = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle       = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubtitle    = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.MenuStrip1                        = New System.Windows.Forms.MenuStrip()
        Me.VarianceCheckingToolStripMenuItem  = New System.Windows.Forms.ToolStripMenuItem()

        Me.pnlToolbar     = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFromLabel   = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtFrom         = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblToLabel     = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtTo           = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1         = New System.Windows.Forms.Label()
        Me.cbemployee     = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnGenerate    = New Guna.UI2.WinForms.Guna2Button()
        Me.lblStore       = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlReport      = New System.Windows.Forms.Panel()
        Me.rv_employee    = New Microsoft.Reporting.WinForms.ReportViewer()

        Me.pnlOverlay     = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader         = New Guna.UI2.WinForms.Guna2CircleProgressbar()
        Me.lblLoading     = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlStatus      = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus      = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlHeader.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlReport.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()

        ' ════════════════════════════════════════════════════════════
        '  FORM
        ' ════════════════════════════════════════════════════════════
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor           = System.Drawing.Color.FromArgb(255, 245, 235)
        Me.ClientSize          = New System.Drawing.Size(1200, 700)
        Me.ControlBox          = False
        Me.Font                = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.None
        Me.Name                = "frm_employee_sales"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "Employee Sales Report"
        Me.Controls.Add(Me.pnlReport)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)
        Me.MainMenuStrip = Me.MenuStrip1

        ' ════════════════════════════════════════════════════════════
        '  HEADER  (Dock=Top, H=62)
        ' ════════════════════════════════════════════════════════════
        Me.pnlHeader.Name      = "pnlHeader"
        Me.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height    = 62
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.pnlHeader.TabIndex  = 0
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)

        Me.lblTitle.Name      = "lblTitle"
        Me.lblTitle.Text      = "<b>Employee Sales Report</b>"
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblTitle.Font      = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.AutoSize  = True
        Me.lblTitle.Location  = New System.Drawing.Point(18, 7)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent

        Me.lblSubtitle.Name      = "lblSubtitle"
        Me.lblSubtitle.Text      = "Sales metrics and tender breakdown filtered by employee"
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblSubtitle.Font      = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.AutoSize  = True
        Me.lblSubtitle.Location  = New System.Drawing.Point(20, 36)
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  MENU STRIP  (Dock=Top, styled warm cream)
        ' ════════════════════════════════════════════════════════════
        Me.MenuStrip1.Name             = "MenuStrip1"
        Me.MenuStrip1.Dock             = System.Windows.Forms.DockStyle.Top
        Me.MenuStrip1.BackColor        = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.MenuStrip1.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.MenuStrip1.Font             = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Height           = 28
        Me.MenuStrip1.TabIndex         = 1
        Me.MenuStrip1.Text             = "MenuStrip1"
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {
            Me.VarianceCheckingToolStripMenuItem})

        Me.VarianceCheckingToolStripMenuItem.Name = "VarianceCheckingToolStripMenuItem"
        Me.VarianceCheckingToolStripMenuItem.Text = "Variance Checking"
        Me.VarianceCheckingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.5!)

        ' ════════════════════════════════════════════════════════════
        '  TOOLBAR  (Dock=Top, H=58)
        '  [From][dtFrom] [To][dtTo] [Employee:][cbemployee] [Generate]  [store →]
        ' ════════════════════════════════════════════════════════════
        Me.pnlToolbar.Name      = "pnlToolbar"
        Me.pnlToolbar.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Height    = 58
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(255, 240, 225)
        Me.pnlToolbar.TabIndex  = 2
        Me.pnlToolbar.Controls.Add(Me.lblFromLabel)
        Me.pnlToolbar.Controls.Add(Me.dtFrom)
        Me.pnlToolbar.Controls.Add(Me.lblToLabel)
        Me.pnlToolbar.Controls.Add(Me.dtTo)
        Me.pnlToolbar.Controls.Add(Me.Label1)
        Me.pnlToolbar.Controls.Add(Me.cbemployee)
        Me.pnlToolbar.Controls.Add(Me.btnGenerate)
        Me.pnlToolbar.Controls.Add(Me.lblStore)

        Me.lblFromLabel.Name      = "lblFromLabel"
        Me.lblFromLabel.Text      = "From:"
        Me.lblFromLabel.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblFromLabel.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromLabel.AutoSize  = True
        Me.lblFromLabel.Location  = New System.Drawing.Point(14, 20)
        Me.lblFromLabel.BackColor = System.Drawing.Color.Transparent

        Me.dtFrom.Name              = "dtFrom"
        Me.dtFrom.Size              = New System.Drawing.Size(168, 30)
        Me.dtFrom.Location          = New System.Drawing.Point(60, 14)
        Me.dtFrom.Font              = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtFrom.ForeColor         = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dtFrom.BackColor         = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.dtFrom.BorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.dtFrom.Format            = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFrom.Value             = New DateTime(2025, 1, 1, 0, 0, 0, 0)
        Me.dtFrom.TabIndex          = 0

        Me.lblToLabel.Name      = "lblToLabel"
        Me.lblToLabel.Text      = "To:"
        Me.lblToLabel.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblToLabel.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblToLabel.AutoSize  = True
        Me.lblToLabel.Location  = New System.Drawing.Point(240, 20)
        Me.lblToLabel.BackColor = System.Drawing.Color.Transparent

        Me.dtTo.Name              = "dtTo"
        Me.dtTo.Size              = New System.Drawing.Size(168, 30)
        Me.dtTo.Location          = New System.Drawing.Point(266, 14)
        Me.dtTo.Font              = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtTo.ForeColor         = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dtTo.BackColor         = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.dtTo.BorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.dtTo.Format            = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtTo.Value             = New DateTime(2025, 1, 1, 0, 0, 0, 0)
        Me.dtTo.TabIndex          = 1

        Me.Label1.Name      = "Label1"
        Me.Label1.Text      = "Employee:"
        Me.Label1.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.Label1.AutoSize  = True
        Me.Label1.Location  = New System.Drawing.Point(448, 20)
        Me.Label1.BackColor = System.Drawing.Color.Transparent

        Me.cbemployee.Name             = "cbemployee"
        Me.cbemployee.Size             = New System.Drawing.Size(220, 32)
        Me.cbemployee.Location         = New System.Drawing.Point(524, 13)
        Me.cbemployee.Font             = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbemployee.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.cbemployee.FillColor        = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.cbemployee.BorderRadius     = 8
        Me.cbemployee.ItemHeight       = 26
        Me.cbemployee.DropDownStyle    = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbemployee.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.cbemployee.TabIndex         = 2

        Me.btnGenerate.Name             = "btnGenerate"
        Me.btnGenerate.Text             = "Generate Report"
        Me.btnGenerate.Size             = New System.Drawing.Size(152, 34)
        Me.btnGenerate.Location         = New System.Drawing.Point(758, 12)
        Me.btnGenerate.Font             = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnGenerate.BorderRadius     = 17
        Me.btnGenerate.FillColor        = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.btnGenerate.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.btnGenerate.CustomBorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.btnGenerate.Animated         = True
        Me.btnGenerate.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.btnGenerate.TabIndex         = 3

        Me.lblStore.Name      = "lblStore"
        Me.lblStore.Text      = ""
        Me.lblStore.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblStore.Font      = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStore.AutoSize  = True
        Me.lblStore.Location  = New System.Drawing.Point(924, 20)
        Me.lblStore.Anchor    = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.lblStore.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  REPORT PANEL  (Dock=Fill)
        ' ════════════════════════════════════════════════════════════
        Me.pnlReport.Name      = "pnlReport"
        Me.pnlReport.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.pnlReport.BackColor = System.Drawing.Color.White
        Me.pnlReport.TabIndex  = 3
        Me.pnlReport.Controls.Add(Me.rv_employee)

        Me.rv_employee.Name      = "rv_employee"
        Me.rv_employee.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.rv_employee.Location  = New System.Drawing.Point(0, 0)
        Me.rv_employee.TabIndex  = 0
        Me.rv_employee.ServerReport.BearerToken = Nothing

        ' ════════════════════════════════════════════════════════════
        '  STATUS BAR  (Dock=Bottom, H=32)
        ' ════════════════════════════════════════════════════════════
        Me.pnlStatus.Name      = "pnlStatus"
        Me.pnlStatus.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Height    = 32
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.pnlStatus.TabIndex  = 4
        Me.pnlStatus.Controls.Add(Me.lblStatus)

        Me.lblStatus.Name      = "lblStatus"
        Me.lblStatus.Text      = "Ready"
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblStatus.Font      = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblStatus.AutoSize  = True
        Me.lblStatus.Location  = New System.Drawing.Point(14, 8)
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  OVERLAY  (Dock=Fill, hidden)
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
        Me.loader.Location      = New System.Drawing.Point(573, 280)
        Me.loader.TabIndex      = 0

        Me.lblLoading.Name      = "lblLoading"
        Me.lblLoading.Text      = "Generating report, please wait..."
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblLoading.Font      = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoading.AutoSize  = True
        Me.lblLoading.Location  = New System.Drawing.Point(520, 344)
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.TabIndex  = 1

        Me.pnlHeader.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlReport.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlOverlay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle       As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MenuStrip1     As System.Windows.Forms.MenuStrip
    Friend WithEvents VarianceCheckingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlToolbar     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFromLabel   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtFrom         As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblToLabel     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtTo           As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1         As System.Windows.Forms.Label
    Friend WithEvents cbemployee     As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnGenerate    As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStore       As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlReport      As System.Windows.Forms.Panel
    Friend WithEvents rv_employee    As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnlStatus      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus      As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlOverlay     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader         As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading     As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
