<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_variance
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubtitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFromLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtFrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.lblHint = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblRecCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.dgvvariance = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtTo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvvariance, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Size = New System.Drawing.Size(194, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>Variance Checking</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(25, 45)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(270, 21)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Double-click any row to view the full receipt"
        '
        'pnlToolbar
        '
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlToolbar.Controls.Add(Me.Guna2HtmlLabel1)
        Me.pnlToolbar.Controls.Add(Me.dtTo)
        Me.pnlToolbar.Controls.Add(Me.lblFromLabel)
        Me.pnlToolbar.Controls.Add(Me.dtFrom)
        Me.pnlToolbar.Controls.Add(Me.btnRefresh)
        Me.pnlToolbar.Controls.Add(Me.lblHint)
        Me.pnlToolbar.Controls.Add(Me.lblRecCount)
        Me.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Location = New System.Drawing.Point(0, 78)
        Me.pnlToolbar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlToolbar.Name = "pnlToolbar"
        Me.pnlToolbar.Size = New System.Drawing.Size(1500, 113)
        Me.pnlToolbar.TabIndex = 1
        '
        'lblFromLabel
        '
        Me.lblFromLabel.BackColor = System.Drawing.Color.Transparent
        Me.lblFromLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblFromLabel.Location = New System.Drawing.Point(24, 22)
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
        Me.dtFrom.Location = New System.Drawing.Point(75, 15)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(210, 38)
        Me.dtFrom.TabIndex = 0
        Me.dtFrom.Value = New Date(2026, 3, 1, 0, 0, 0, 0)
        '
        'btnRefresh
        '
        Me.btnRefresh.Animated = True
        Me.btnRefresh.BorderRadius = 16
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnRefresh.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(293, 34)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(138, 36)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Filter"
        '
        'lblHint
        '
        Me.lblHint.BackColor = System.Drawing.Color.Transparent
        Me.lblHint.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Italic)
        Me.lblHint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblHint.Location = New System.Drawing.Point(450, 43)
        Me.lblHint.Margin = New System.Windows.Forms.Padding(4)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(194, 19)
        Me.lblHint.TabIndex = 3
        Me.lblHint.Text = "Double-click a row to open receipt"
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
        Me.lblRecCount.TabIndex = 4
        Me.lblRecCount.Text = Nothing
        '
        'pnlGrid
        '
        Me.pnlGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlGrid.Controls.Add(Me.dgvvariance)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 191)
        Me.pnlGrid.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Size = New System.Drawing.Size(1500, 644)
        Me.pnlGrid.TabIndex = 2
        '
        'dgvvariance
        '
        Me.dgvvariance.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvvariance.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvvariance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvvariance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvvariance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvvariance.ColumnHeadersHeight = 4
        Me.dgvvariance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvvariance.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvvariance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvvariance.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvvariance.Location = New System.Drawing.Point(0, 0)
        Me.dgvvariance.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvvariance.Name = "dgvvariance"
        Me.dgvvariance.RowHeadersVisible = False
        Me.dgvvariance.RowHeadersWidth = 51
        Me.dgvvariance.RowTemplate.Height = 32
        Me.dgvvariance.Size = New System.Drawing.Size(1500, 644)
        Me.dgvvariance.TabIndex = 0
        Me.dgvvariance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember
        Me.dgvvariance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.dgvvariance.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvvariance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvvariance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvvariance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvvariance.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvvariance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.dgvvariance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.dgvvariance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvvariance.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvvariance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvvariance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvvariance.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvvariance.ThemeStyle.ReadOnly = False
        Me.dgvvariance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.dgvvariance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvvariance.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvvariance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvvariance.ThemeStyle.RowsStyle.Height = 32
        Me.dgvvariance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.dgvvariance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
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
        Me.lblLoading.Location = New System.Drawing.Point(644, 430)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(276, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Loading variance data, please wait..."
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
        Me.lblStatus.Size = New System.Drawing.Size(61, 21)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Loading..."
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(43, 59)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(24, 22)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "To:"
        '
        'dtTo
        '
        Me.dtTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtTo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtTo.Checked = True
        Me.dtTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTo.Location = New System.Drawing.Point(75, 57)
        Me.dtTo.Margin = New System.Windows.Forms.Padding(4)
        Me.dtTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(210, 38)
        Me.dtTo.TabIndex = 6
        Me.dtTo.Value = New Date(2026, 3, 1, 0, 0, 0, 0)
        '
        'frm_variance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1500, 875)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_variance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlToolbar.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvvariance, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents pnlToolbar     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFromLabel   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtFrom         As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblHint        As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRecCount    As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlGrid        As System.Windows.Forms.Panel
    Friend WithEvents dgvvariance    As Guna.UI2.WinForms.Guna2DataGridView

    Friend WithEvents pnlStatus      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus      As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlOverlay     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader         As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents lblLoading As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtTo As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
