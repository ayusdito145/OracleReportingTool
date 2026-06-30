Imports Guna.UI2.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_ZReading
    Inherits System.Windows.Forms.Form

    '=================================================================
    ' DISPOSE
    '=================================================================
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

    '=================================================================
    ' InitializeComponent — DESIGNER STUB ONLY
    ' No helper calls, no constants, no custom methods.
    ' All real UI construction happens in BuildUI() called from New().
    '=================================================================
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'frm_ZReading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 1009)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_ZReading"
        Me.Text = "Z-Reading Report"
        Me.ResumeLayout(False)

    End Sub

    '─────────────────────────────────────────────────────────────────
    ' CONTROL DECLARATIONS
    ' Declared here so both partial files can reference them.
    '─────────────────────────────────────────────────────────────────

    ' Structural panels
    Friend WithEvents pnlHeader As Guna2Panel
    Friend WithEvents pnlToolbar As Guna2Panel
    Friend WithEvents pnlBody As Panel
    Friend WithEvents pnlStatus As Guna2Panel
    Friend WithEvents pnlOverlay As Guna2Panel

    ' Header
    Friend lblTitle As Label
    Friend lblSubTitle As Label

    ' Toolbar
    Friend WithEvents dtpDate As Guna2DateTimePicker
    Friend WithEvents lblDateLbl As Label
    Friend WithEvents btnLoad As Guna2Button
    Friend WithEvents btnPrint As Guna2Button
    Friend WithEvents lblStatus As Label

    ' Card panels
    Friend pnlAccum As Guna2Panel
    Friend pnlSales As Guna2Panel
    Friend pnlTender As Guna2Panel
    Friend pnlDisc As Guna2Panel

    ' Accumulation card values
    Friend lblStartBalVal As Label
    Friend lblEndBalVal As Label
    Friend lblFromInvVal As Label
    Friend lblToInvVal As Label
    Friend lblCustCountVal As Label

    ' Sales card values
    Friend lblTotalSalesVal As Label
    Friend lblVatSalesVal As Label
    Friend lblVatAmtVal As Label
    Friend lblVatExemptVal As Label
    Friend lblZeroRatedVal As Label
    Friend lblTaxExemptedVal As Label
    Friend lblDiscountsVal As Label
    Friend lblVoidsVal As Label
    Friend lblServiceChgVal As Label
    Friend lblNetSalesVal As Label

    ' Tender card values
    Friend lblCashAmt As Label
    Friend lblCreditCardAmt As Label
    Friend lblOtherPayAmt As Label
    Friend lblTotalTenderAmt As Label

    ' Discount card values
    Friend lblGovDiscVal As Label
    Friend lblOtherDiscVal As Label
    Friend lblTotalDiscVal As Label

    ' Overlay
    Friend lblLoading As Label

End Class
