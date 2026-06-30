<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_POS_sales
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
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFromLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblToLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPOS = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnGenerate = New Guna.UI2.WinForms.Guna2Button()
        Me.lblStore = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlReport = New System.Windows.Forms.Panel()
        Me.rv_POS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlHeader.SuspendLayout()
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
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(182, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>POS Sales Report</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(25, 45)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(365, 21)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Sales metrics and tender breakdown filtered by workstation"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlToolbar.Controls.Add(Me.lblFromLabel)
        Me.pnlToolbar.Controls.Add(Me.dtFrom)
        Me.pnlToolbar.Controls.Add(Me.lblToLabel)
        Me.pnlToolbar.Controls.Add(Me.dtTo)
        Me.pnlToolbar.Controls.Add(Me.Label1)
        Me.pnlToolbar.Controls.Add(Me.cbPOS)
        Me.pnlToolbar.Controls.Add(Me.btnGenerate)
        Me.pnlToolbar.Controls.Add(Me.lblStore)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 78)
        Me.pnlToolbar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(1500, 72)
        Me.pnlToolbar.TabIndex = 1
        '
        'lblFromLabel
        '
        Me.lblFromLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblFromLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblFromLabel.Location = New System.Drawing.Point(18, 25)
        Me.lblFromLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.dtFrom.Location = New System.Drawing.Point(65, 18)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(210, 38)
        Me.dtFrom.TabIndex = 0
        Me.dtFrom.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'lblToLabel
        '
        Me.lblToLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblToLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblToLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblToLabel.Location = New System.Drawing.Point(300, 25)
        Me.lblToLabel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblToLabel.Name = "lblToLabel"
        Me.lblToLabel.Size = New System.Drawing.Size(24, 22)
        Me.lblToLabel.TabIndex = 1
        Me.lblToLabel.Text = "To:"
        '
        'dtTo
        '
        Me.dtTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtTo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtTo.Checked = True
        Me.dtTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(331, 18)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(210, 38)
        Me.dtTo.TabIndex = 1
        Me.dtTo.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(565, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Workstation:"
        '
        'cbPOS
        '
        Me.cbPOS.BackColor = System.Drawing.Color.Transparent
        Me.cbPOS.BorderRadius = 8
        Me.cbPOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbPOS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbPOS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPOS.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.cbPOS.FocusedColor = System.Drawing.Color.Empty
        Me.cbPOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbPOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cbPOS.ItemHeight = 26
        Me.cbPOS.Location = New System.Drawing.Point(664, 21)
        Me.cbPOS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbPOS.Name = "cbPOS"
        Me.cbPOS.Size = New System.Drawing.Size(249, 32)
        Me.cbPOS.TabIndex = 2
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
        Me.btnGenerate.Location = New System.Drawing.Point(926, 15)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(190, 42)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate Report"
        '
        'lblStore
        '
        Me.lblStore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStore.BackColor = System.Drawing.Color.Transparent
        Me.lblStore.Font = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblStore.Location = New System.Drawing.Point(2405, 25)
        Me.lblStore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(3, 2)
        Me.lblStore.TabIndex = 4
        '
        'pnlReport
        '
        Me.pnlReport.BackColor = System.Drawing.Color.White
        Me.pnlReport.Controls.Add(Me.rv_POS)
        Me.pnlReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReport.Location = New System.Drawing.Point(0, 150)
        Me.pnlReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlReport.Name = "pnlReport"
        Me.pnlReport.Size = New System.Drawing.Size(1500, 685)
        Me.pnlReport.TabIndex = 2
        '
        'rv_POS
        '
        Me.rv_POS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rv_POS.Location = New System.Drawing.Point(0, 0)
        Me.rv_POS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rv_POS.Name = "rv_POS"
        Me.rv_POS.ServerReport.BearerToken = Nothing
        Me.rv_POS.Size = New System.Drawing.Size(1500, 685)
        Me.rv_POS.TabIndex = 0
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
        Me.lblLoading.Location = New System.Drawing.Point(650, 430)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        'frm_POS_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 875)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlReport)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_POS_sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS Sales Report"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlReport.ResumeLayout(False)
        Me.pnlOverlay.ResumeLayout(False)
        Me.pnlOverlay.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlStatus.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle  As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlToolbar   As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFromLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtFrom       As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblToLabel   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtTo         As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1       As System.Windows.Forms.Label
    Friend WithEvents cbPOS        As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnGenerate  As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblStore     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlReport    As System.Windows.Forms.Panel
    Friend WithEvents rv_POS       As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents pnlStatus    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlOverlay   As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader       As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading   As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
