<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_check_details
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

        Me.pnlToolbar     = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblFromLabel   = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtFrom         = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblToLabel     = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.dtto           = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btngenerate    = New Guna.UI2.WinForms.Guna2Button()
        Me.lblSearchLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtsearch      = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblRecCount    = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlGrid        = New System.Windows.Forms.Panel()
        Me.dgvvariance    = New Guna.UI2.WinForms.Guna2DataGridView()

        Me.pnlOverlay     = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader         = New Guna.UI2.WinForms.Guna2CircleProgressbar()
        Me.lblLoading     = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlStatus      = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus      = New Guna.UI2.WinForms.Guna2HtmlLabel()

        ' ── SuspendLayout ────────────────────────────────────────────
        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvvariance, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Name                = "frm_check_details"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "Tender Listing"
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)

        ' ════════════════════════════════════════════════════════════
        '  HEADER  (Dock=Top, H=62, peach)
        ' ════════════════════════════════════════════════════════════
        Me.pnlHeader.Name      = "pnlHeader"
        Me.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height    = 62
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.pnlHeader.TabIndex  = 0
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)

        Me.lblTitle.Name      = "lblTitle"
        Me.lblTitle.Text      = "<b>Tender Listing</b>"
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblTitle.Font      = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.AutoSize  = True
        Me.lblTitle.Location  = New System.Drawing.Point(18, 7)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent

        Me.lblSubtitle.Name      = "lblSubtitle"
        Me.lblSubtitle.Text      = "Non-cash tender details by date range"
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblSubtitle.Font      = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.AutoSize  = True
        Me.lblSubtitle.Location  = New System.Drawing.Point(20, 36)
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  TOOLBAR  (Dock=Top, H=62, warm cream)
        '  [From] [dtFrom] [To] [dtto] [Generate] | [Search:] [txt] [record count →]
        ' ════════════════════════════════════════════════════════════
        Me.pnlToolbar.Name      = "pnlToolbar"
        Me.pnlToolbar.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Height    = 62
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(255, 240, 225)
        Me.pnlToolbar.TabIndex  = 1
        Me.pnlToolbar.Controls.Add(Me.lblFromLabel)
        Me.pnlToolbar.Controls.Add(Me.dtFrom)
        Me.pnlToolbar.Controls.Add(Me.lblToLabel)
        Me.pnlToolbar.Controls.Add(Me.dtto)
        Me.pnlToolbar.Controls.Add(Me.btngenerate)
        Me.pnlToolbar.Controls.Add(Me.lblSearchLabel)
        Me.pnlToolbar.Controls.Add(Me.txtsearch)
        Me.pnlToolbar.Controls.Add(Me.lblRecCount)

        Me.lblFromLabel.Name      = "lblFromLabel"
        Me.lblFromLabel.Text      = "From:"
        Me.lblFromLabel.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblFromLabel.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFromLabel.AutoSize  = True
        Me.lblFromLabel.Location  = New System.Drawing.Point(14, 20)
        Me.lblFromLabel.BackColor = System.Drawing.Color.Transparent

        Me.dtFrom.Name              = "dtFrom"
        Me.dtFrom.Size              = New System.Drawing.Size(168, 30)
        Me.dtFrom.Location          = New System.Drawing.Point(60, 16)
        Me.dtFrom.Font              = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtFrom.ForeColor         = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dtFrom.BackColor         = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.dtFrom.BorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.dtFrom.Format            = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFrom.Value             = New DateTime(2025, 1, 1)
        Me.dtFrom.TabIndex          = 0

        Me.lblToLabel.Name      = "lblToLabel"
        Me.lblToLabel.Text      = "To:"
        Me.lblToLabel.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblToLabel.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblToLabel.AutoSize  = True
        Me.lblToLabel.Location  = New System.Drawing.Point(240, 20)
        Me.lblToLabel.BackColor = System.Drawing.Color.Transparent

        Me.dtto.Name              = "dtto"
        Me.dtto.Size              = New System.Drawing.Size(168, 30)
        Me.dtto.Location          = New System.Drawing.Point(266, 16)
        Me.dtto.Font              = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtto.ForeColor         = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dtto.BackColor         = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.dtto.BorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.dtto.Format            = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtto.Value             = New DateTime(2025, 1, 1)
        Me.dtto.TabIndex          = 1

        Me.btngenerate.Name             = "btngenerate"
        Me.btngenerate.Text             = "Generate"
        Me.btngenerate.Size             = New System.Drawing.Size(120, 34)
        Me.btngenerate.Location         = New System.Drawing.Point(448, 14)
        Me.btngenerate.Font             = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btngenerate.BorderRadius     = 17
        Me.btngenerate.FillColor        = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.btngenerate.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.btngenerate.CustomBorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.btngenerate.Animated         = True
        Me.btngenerate.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.btngenerate.TabIndex         = 2

        Me.lblSearchLabel.Name      = "lblSearchLabel"
        Me.lblSearchLabel.Text      = "Search:"
        Me.lblSearchLabel.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblSearchLabel.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchLabel.AutoSize  = True
        Me.lblSearchLabel.Location  = New System.Drawing.Point(586, 20)
        Me.lblSearchLabel.BackColor = System.Drawing.Color.Transparent

        Me.txtsearch.Name             = "txtsearch"
        Me.txtsearch.Size             = New System.Drawing.Size(220, 30)
        Me.txtsearch.Location         = New System.Drawing.Point(638, 16)
        Me.txtsearch.Font             = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsearch.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.txtsearch.FillColor        = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.txtsearch.BorderRadius     = 8
        Me.txtsearch.BorderThickness  = 1
        Me.txtsearch.Cursor           = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultText      = ""
        Me.txtsearch.PlaceholderText  = "Check #, reference, tender..."
        Me.txtsearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(190, 160, 120)
        Me.txtsearch.PasswordChar     = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.SelectedText     = ""
        Me.txtsearch.TabIndex         = 3

        Me.lblRecCount.Name      = "lblRecCount"
        Me.lblRecCount.Text      = ""
        Me.lblRecCount.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblRecCount.Font      = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblRecCount.AutoSize  = True
        Me.lblRecCount.Location  = New System.Drawing.Point(872, 20)
        Me.lblRecCount.Anchor    = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.lblRecCount.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  GRID PANEL  (Dock=Fill)
        ' ════════════════════════════════════════════════════════════
        Me.pnlGrid.Name      = "pnlGrid"
        Me.pnlGrid.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.BackColor = System.Drawing.Color.FromArgb(255, 245, 235)
        Me.pnlGrid.TabIndex  = 2
        Me.pnlGrid.Controls.Add(Me.dgvvariance)

        ' ── Guna2DataGridView ─────────────────────────────────────────
        Me.dgvvariance.Name                         = "dgvvariance"
        Me.dgvvariance.Dock                         = System.Windows.Forms.DockStyle.Fill
        Me.dgvvariance.AutoSizeColumnsMode          = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvvariance.CellBorderStyle              = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvvariance.ColumnHeadersBorderStyle     = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single
        Me.dgvvariance.ColumnHeadersHeightSizeMode  = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvariance.RowHeadersVisible            = False
        Me.dgvvariance.RowHeadersWidth              = 51
        Me.dgvvariance.RowTemplate.Height           = 30
        Me.dgvvariance.AllowUserToAddRows           = False
        Me.dgvvariance.SelectionMode                = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvvariance.TabIndex                     = 0
        ' Theme & palette applied in code-behind to avoid Designer sub-property issues
        Me.dgvvariance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember

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
        '  OVERLAY  (Dock=Fill, hidden by default)
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
        Me.lblLoading.Text      = "Loading tender data, please wait..."
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblLoading.Font      = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoading.AutoSize  = True
        Me.lblLoading.Location  = New System.Drawing.Point(520, 344)
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.TabIndex  = 1

        ' ── ResumeLayout ─────────────────────────────────────────────
        CType(Me.dgvvariance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlOverlay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' ── Field declarations ───────────────────────────────────────────
    Friend WithEvents pnlHeader      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle       As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle    As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlToolbar     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblFromLabel   As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtFrom         As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblToLabel     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dtto           As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btngenerate    As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblSearchLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtsearch      As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblRecCount    As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlGrid        As System.Windows.Forms.Panel
    Friend WithEvents dgvvariance    As Guna.UI2.WinForms.Guna2DataGridView

    Friend WithEvents pnlStatus      As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus      As Guna.UI2.WinForms.Guna2HtmlLabel

    Friend WithEvents pnlOverlay     As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader         As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading     As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
