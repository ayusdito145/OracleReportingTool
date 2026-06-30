<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_scpwd
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

        Me.pnlHeader    = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle     = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblSubtitle  = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlToolbar   = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2       = New System.Windows.Forms.Label()
        Me.dtFrom       = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1       = New System.Windows.Forms.Label()
        Me.dtto         = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblTypeLabel = New System.Windows.Forms.Label()
        Me.cbtype       = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btngenerate  = New Guna.UI2.WinForms.Guna2Button()
        Me.lblRecCount  = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlGrid      = New System.Windows.Forms.Panel()
        Me.dgvvariance  = New Guna.UI2.WinForms.Guna2DataGridView()

        Me.pnlStatus    = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblStatus    = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlOverlay   = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader       = New Guna.UI2.WinForms.Guna2CircleProgressbar()
        Me.lblLoading   = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pnlHeader.SuspendLayout()
        Me.pnlToolbar.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
        CType(Me.dgvvariance, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Name                = "frm_scpwd"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text                = "SC/PWD Listing"
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlToolbar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlOverlay)

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
        Me.lblTitle.Text      = "<b>SC / PWD Listing</b>"
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblTitle.Font      = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.AutoSize  = True
        Me.lblTitle.Location  = New System.Drawing.Point(18, 7)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent

        Me.lblSubtitle.Name      = "lblSubtitle"
        Me.lblSubtitle.Text      = "Senior Citizen and PWD discount transaction details grouped by type"
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblSubtitle.Font      = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblSubtitle.AutoSize  = True
        Me.lblSubtitle.Location  = New System.Drawing.Point(20, 36)
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  TOOLBAR  (Dock=Top, H=58)
        '  [From][dtFrom] [To][dtto] [Type][cbtype] [Generate]  [count→]
        ' ════════════════════════════════════════════════════════════
        Me.pnlToolbar.Name      = "pnlToolbar"
        Me.pnlToolbar.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlToolbar.Height    = 58
        Me.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(255, 240, 225)
        Me.pnlToolbar.TabIndex  = 1
        Me.pnlToolbar.Controls.Add(Me.Label2)
        Me.pnlToolbar.Controls.Add(Me.dtFrom)
        Me.pnlToolbar.Controls.Add(Me.Label1)
        Me.pnlToolbar.Controls.Add(Me.dtto)
        Me.pnlToolbar.Controls.Add(Me.lblTypeLabel)
        Me.pnlToolbar.Controls.Add(Me.cbtype)
        Me.pnlToolbar.Controls.Add(Me.btngenerate)
        Me.pnlToolbar.Controls.Add(Me.lblRecCount)

        Me.Label2.Name      = "Label2"
        Me.Label2.Text      = "From:"
        Me.Label2.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.Label2.AutoSize  = True
        Me.Label2.Location  = New System.Drawing.Point(14, 20)
        Me.Label2.BackColor = System.Drawing.Color.Transparent

        Me.dtFrom.Name              = "dtFrom"
        Me.dtFrom.Size              = New System.Drawing.Size(168, 30)
        Me.dtFrom.Location          = New System.Drawing.Point(60, 13)
        Me.dtFrom.Font              = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtFrom.ForeColor         = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dtFrom.BackColor         = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.dtFrom.BorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.dtFrom.Format            = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFrom.Value             = New DateTime(2025, 1, 1, 0, 0, 0, 0)
        Me.dtFrom.TabIndex          = 0

        Me.Label1.Name      = "Label1"
        Me.Label1.Text      = "To:"
        Me.Label1.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.Label1.AutoSize  = True
        Me.Label1.Location  = New System.Drawing.Point(244, 20)
        Me.Label1.BackColor = System.Drawing.Color.Transparent

        Me.dtto.Name              = "dtto"
        Me.dtto.Size              = New System.Drawing.Size(168, 30)
        Me.dtto.Location          = New System.Drawing.Point(268, 13)
        Me.dtto.Font              = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtto.ForeColor         = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.dtto.BackColor         = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.dtto.BorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.dtto.Format            = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtto.Value             = New DateTime(2025, 1, 1, 0, 0, 0, 0)
        Me.dtto.TabIndex          = 1

        Me.lblTypeLabel.Name      = "lblTypeLabel"
        Me.lblTypeLabel.Text      = "Type:"
        Me.lblTypeLabel.Font      = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTypeLabel.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblTypeLabel.AutoSize  = True
        Me.lblTypeLabel.Location  = New System.Drawing.Point(452, 20)
        Me.lblTypeLabel.BackColor = System.Drawing.Color.Transparent

        Me.cbtype.Name          = "cbtype"
        Me.cbtype.Size          = New System.Drawing.Size(160, 32)
        Me.cbtype.Location      = New System.Drawing.Point(494, 13)
        Me.cbtype.Font          = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbtype.ForeColor     = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.cbtype.FillColor     = System.Drawing.Color.FromArgb(255, 235, 210)
        Me.cbtype.BorderRadius  = 8
        Me.cbtype.ItemHeight    = 26
        Me.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtype.Cursor        = System.Windows.Forms.Cursors.Hand
        Me.cbtype.TabIndex      = 2
        Me.cbtype.Items.AddRange(New Object() {"OSCA", "PWD"})

        Me.btngenerate.Name             = "btngenerate"
        Me.btngenerate.Text             = "Generate"
        Me.btngenerate.Size             = New System.Drawing.Size(140, 34)
        Me.btngenerate.Location         = New System.Drawing.Point(668, 12)
        Me.btngenerate.Font             = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btngenerate.BorderRadius     = 17
        Me.btngenerate.FillColor        = System.Drawing.Color.FromArgb(210, 140, 80)
        Me.btngenerate.ForeColor        = System.Drawing.Color.White
        Me.btngenerate.CustomBorderColor = System.Drawing.Color.FromArgb(180, 110, 50)
        Me.btngenerate.Animated         = True
        Me.btngenerate.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.btngenerate.TabIndex         = 3

        Me.lblRecCount.Name      = "lblRecCount"
        Me.lblRecCount.Text      = ""
        Me.lblRecCount.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblRecCount.Font      = New System.Drawing.Font("Segoe UI Semibold", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblRecCount.AutoSize  = True
        Me.lblRecCount.Location  = New System.Drawing.Point(826, 20)
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

        Me.dgvvariance.Name                        = "dgvvariance"
        Me.dgvvariance.Dock                        = System.Windows.Forms.DockStyle.Fill
        Me.dgvvariance.AutoSizeColumnsMode         = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        Me.dgvvariance.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.Single
        Me.dgvvariance.ColumnHeadersBorderStyle    = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single
        Me.dgvvariance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvvariance.RowHeadersVisible           = False
        Me.dgvvariance.RowTemplate.Height          = 30
        Me.dgvvariance.AllowUserToAddRows          = False
        Me.dgvvariance.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvvariance.TabIndex                    = 0
        Me.dgvvariance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Ember

        ' ════════════════════════════════════════════════════════════
        '  STATUS BAR  (Dock=Bottom, H=32)
        ' ════════════════════════════════════════════════════════════
        Me.pnlStatus.Name      = "pnlStatus"
        Me.pnlStatus.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Height    = 32
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.pnlStatus.TabIndex  = 3
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
        Me.lblLoading.Text      = "Loading SC/PWD data, please wait..."
        Me.lblLoading.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblLoading.Font      = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoading.AutoSize  = True
        Me.lblLoading.Location  = New System.Drawing.Point(505, 344)
        Me.lblLoading.BackColor = System.Drawing.Color.Transparent
        Me.lblLoading.TabIndex  = 1

        CType(Me.dgvvariance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlToolbar.ResumeLayout(False)
        Me.pnlGrid.ResumeLayout(False)
        Me.pnlStatus.ResumeLayout(False)
        Me.pnlOverlay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle  As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlToolbar   As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2       As System.Windows.Forms.Label
    Friend WithEvents dtFrom       As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1       As System.Windows.Forms.Label
    Friend WithEvents dtto         As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblTypeLabel As System.Windows.Forms.Label
    Friend WithEvents cbtype       As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btngenerate  As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblRecCount  As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlGrid      As System.Windows.Forms.Panel
    Friend WithEvents dgvvariance  As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents pnlStatus    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblStatus    As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlOverlay   As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader       As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading   As Guna.UI2.WinForms.Guna2HtmlLabel

End Class
