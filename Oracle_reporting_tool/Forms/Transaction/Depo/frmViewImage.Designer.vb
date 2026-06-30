<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewImage
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

        Me.pnlHeader      = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle       = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblFilename    = New Guna.UI2.WinForms.Guna2HtmlLabel()

        Me.pbImage        = New System.Windows.Forms.PictureBox()

        Me.Guna2Panel1    = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnReupload    = New Guna.UI2.WinForms.Guna2Button()
        Me.btndownload    = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose       = New Guna.UI2.WinForms.Guna2Button()

        Me.pnlOverlay     = New Guna.UI2.WinForms.Guna2Panel()
        Me.progressIndicator = New Guna.UI2.WinForms.Guna2CircleProgressbar()
        Me.lblLoadingImg  = New Guna.UI2.WinForms.Guna2HtmlLabel()

        ' BackgroundWorkers preserved exactly
        Me.bgWorker          = New System.ComponentModel.BackgroundWorker()
        Me.bgWorkerDownload  = New System.ComponentModel.BackgroundWorker()

        Me.pnlHeader.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
        Me.SuspendLayout()

        ' ════════════════════════════════════════════════════════════
        '  FORM
        ' ════════════════════════════════════════════════════════════
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor           = System.Drawing.Color.FromArgb(255, 245, 235)
        Me.ClientSize          = New System.Drawing.Size(920, 620)
        Me.Font                = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox         = False
        Me.Name                = "frmViewImage"
        Me.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text                = "View Attachment"
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlOverlay)

        ' ════════════════════════════════════════════════════════════
        '  HEADER  (Dock=Top, H=58, peach)
        ' ════════════════════════════════════════════════════════════
        Me.pnlHeader.Name      = "pnlHeader"
        Me.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height    = 58
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.pnlHeader.TabIndex  = 0
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblFilename)

        Me.lblTitle.Name      = "lblTitle"
        Me.lblTitle.Text      = "<b>Deposit Slip</b>"
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblTitle.Font      = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.AutoSize  = True
        Me.lblTitle.Location  = New System.Drawing.Point(16, 6)
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent

        Me.lblFilename.Name      = "lblFilename"
        Me.lblFilename.Text      = ""
        Me.lblFilename.ForeColor = System.Drawing.Color.FromArgb(160, 120, 80)
        Me.lblFilename.Font      = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblFilename.AutoSize  = True
        Me.lblFilename.Location  = New System.Drawing.Point(18, 34)
        Me.lblFilename.BackColor = System.Drawing.Color.Transparent

        ' ════════════════════════════════════════════════════════════
        '  PICTURE BOX  (Dock=Fill)
        ' ════════════════════════════════════════════════════════════
        Me.pbImage.Name      = "pbImage"
        Me.pbImage.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.pbImage.BackColor = System.Drawing.Color.FromArgb(255, 250, 245)
        Me.pbImage.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex  = 1
        Me.pbImage.TabStop   = False

        ' ════════════════════════════════════════════════════════════
        '  ACTION BAR  (Dock=Bottom, H=68, peach)
        ' ════════════════════════════════════════════════════════════
        Me.Guna2Panel1.Name      = "Guna2Panel1"
        Me.Guna2Panel1.Dock      = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Height    = 68
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(255, 240, 225)
        Me.Guna2Panel1.TabIndex  = 2
        Me.Guna2Panel1.Controls.Add(Me.btnClose)
        Me.Guna2Panel1.Controls.Add(Me.btnReupload)
        Me.Guna2Panel1.Controls.Add(Me.btndownload)

        Me.btnClose.Name             = "btnClose"
        Me.btnClose.Text             = "Close"
        Me.btnClose.Size             = New System.Drawing.Size(110, 40)
        Me.btnClose.Location         = New System.Drawing.Point(14, 14)
        Me.btnClose.Font             = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnClose.BorderRadius     = 20
        Me.btnClose.FillColor        = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.btnClose.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.btnClose.CustomBorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.btnClose.Animated         = True
        Me.btnClose.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.btnClose.TabIndex         = 0

        Me.btnReupload.Name             = "btnReupload"
        Me.btnReupload.Text             = "&Re-upload"
        Me.btnReupload.Size             = New System.Drawing.Size(140, 40)
        Me.btnReupload.Location         = New System.Drawing.Point(626, 14)
        Me.btnReupload.Font             = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btnReupload.BorderRadius     = 20
        Me.btnReupload.FillColor        = System.Drawing.Color.FromArgb(255, 224, 192)
        Me.btnReupload.ForeColor        = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.btnReupload.CustomBorderColor = System.Drawing.Color.FromArgb(210, 170, 120)
        Me.btnReupload.Animated         = True
        Me.btnReupload.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.btnReupload.TabIndex         = 1

        Me.btndownload.Name             = "btndownload"
        Me.btndownload.Text             = "&Download"
        Me.btndownload.Size             = New System.Drawing.Size(140, 40)
        Me.btndownload.Location         = New System.Drawing.Point(772, 14)
        Me.btndownload.Font             = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.btndownload.BorderRadius     = 20
        Me.btndownload.FillColor        = System.Drawing.Color.FromArgb(210, 140, 80)
        Me.btndownload.ForeColor        = System.Drawing.Color.White
        Me.btndownload.CustomBorderColor = System.Drawing.Color.FromArgb(180, 110, 50)
        Me.btndownload.Animated         = True
        Me.btndownload.Cursor           = System.Windows.Forms.Cursors.Hand
        Me.btndownload.TabIndex         = 2

        ' ════════════════════════════════════════════════════════════
        '  OVERLAY
        ' ════════════════════════════════════════════════════════════
        Me.pnlOverlay.Name      = "pnlOverlay"
        Me.pnlOverlay.Dock      = System.Windows.Forms.DockStyle.Fill
        Me.pnlOverlay.BackColor = System.Drawing.Color.FromArgb(210, 255, 240, 220)
        Me.pnlOverlay.Visible   = False
        Me.pnlOverlay.TabIndex  = 99
        Me.pnlOverlay.Controls.Add(Me.progressIndicator)
        Me.pnlOverlay.Controls.Add(Me.lblLoadingImg)

        Me.progressIndicator.Name          = "progressIndicator"
        Me.progressIndicator.Size          = New System.Drawing.Size(54, 54)
        Me.progressIndicator.ProgressColor = System.Drawing.Color.FromArgb(210, 140, 80)
        Me.progressIndicator.Value         = 75
        Me.progressIndicator.Animated      = True
        Me.progressIndicator.Location      = New System.Drawing.Point(433, 220)
        Me.progressIndicator.TabIndex      = 0

        Me.lblLoadingImg.Name      = "lblLoadingImg"
        Me.lblLoadingImg.Text      = "Loading image..."
        Me.lblLoadingImg.ForeColor = System.Drawing.Color.FromArgb(60, 35, 10)
        Me.lblLoadingImg.Font      = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblLoadingImg.AutoSize  = True
        Me.lblLoadingImg.Location  = New System.Drawing.Point(378, 284)
        Me.lblLoadingImg.BackColor = System.Drawing.Color.Transparent
        Me.lblLoadingImg.TabIndex  = 1

        ' BackgroundWorkers
        Me.bgWorker.WorkerReportsProgress         = True
        Me.bgWorkerDownload.WorkerReportsProgress = True

        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.pnlOverlay.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlHeader          As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle           As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblFilename        As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pbImage            As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2Panel1        As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose           As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReupload        As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btndownload        As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlOverlay         As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents progressIndicator  As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoadingImg      As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents bgWorker           As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgWorkerDownload   As System.ComponentModel.BackgroundWorker

End Class
