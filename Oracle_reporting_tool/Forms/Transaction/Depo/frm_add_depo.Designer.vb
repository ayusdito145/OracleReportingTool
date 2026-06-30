<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_add_depo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtfrom = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DTdepo = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdepoRef = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpos = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdepo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpetty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbir = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtopensales = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtotherdept = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfilename = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlFooter = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.pnlOverlay = New Guna.UI2.WinForms.Guna2Panel()
        Me.loader = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Me.lblLoading = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.pnlOverlay.SuspendLayout()
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
        Me.pnlHeader.Size = New System.Drawing.Size(650, 72)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(127, 32)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<b>Add Deposit</b>"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.BackColor = System.Drawing.Color.Transparent
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 42)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(221, 19)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Fill in all fields and attach deposit slip"
        '
        'pnlBody
        '
        Me.pnlBody.AutoScroll = True
        Me.pnlBody.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.pnlBody.Controls.Add(Me.Label1)
        Me.pnlBody.Controls.Add(Me.dtfrom)
        Me.pnlBody.Controls.Add(Me.Label9)
        Me.pnlBody.Controls.Add(Me.DTdepo)
        Me.pnlBody.Controls.Add(Me.Label10)
        Me.pnlBody.Controls.Add(Me.txtdepoRef)
        Me.pnlBody.Controls.Add(Me.Label2)
        Me.pnlBody.Controls.Add(Me.txtpos)
        Me.pnlBody.Controls.Add(Me.Label3)
        Me.pnlBody.Controls.Add(Me.txtdepo)
        Me.pnlBody.Controls.Add(Me.Label5)
        Me.pnlBody.Controls.Add(Me.txtpetty)
        Me.pnlBody.Controls.Add(Me.Label6)
        Me.pnlBody.Controls.Add(Me.txtbir)
        Me.pnlBody.Controls.Add(Me.Label7)
        Me.pnlBody.Controls.Add(Me.txtopensales)
        Me.pnlBody.Controls.Add(Me.Label8)
        Me.pnlBody.Controls.Add(Me.txtotherdept)
        Me.pnlBody.Controls.Add(Me.Label4)
        Me.pnlBody.Controls.Add(Me.txtfilename)
        Me.pnlBody.Controls.Add(Me.btnBrowse)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 72)
        Me.pnlBody.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(650, 549)
        Me.pnlBody.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Business Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtfrom
        '
        Me.dtfrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.dtfrom.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.dtfrom.BorderRadius = 8
        Me.dtfrom.Checked = True
        Me.dtfrom.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtfrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfrom.Location = New System.Drawing.Point(215, 22)
        Me.dtfrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtfrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtfrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtfrom.Name = "dtfrom"
        Me.dtfrom.Size = New System.Drawing.Size(313, 42)
        Me.dtfrom.TabIndex = 1
        Me.dtfrom.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(18, 72)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 42)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Date of Deposit"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DTdepo
        '
        Me.DTdepo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.DTdepo.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.DTdepo.BorderRadius = 8
        Me.DTdepo.Checked = True
        Me.DTdepo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.DTdepo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.DTdepo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTdepo.Location = New System.Drawing.Point(215, 73)
        Me.DTdepo.Margin = New System.Windows.Forms.Padding(4)
        Me.DTdepo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DTdepo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DTdepo.Name = "DTdepo"
        Me.DTdepo.Size = New System.Drawing.Size(313, 42)
        Me.DTdepo.TabIndex = 3
        Me.DTdepo.Value = New Date(2025, 1, 1, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(18, 125)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 42)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Depo. Ref #"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdepoRef
        '
        Me.txtdepoRef.BorderRadius = 8
        Me.txtdepoRef.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdepoRef.DefaultText = ""
        Me.txtdepoRef.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtdepoRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtdepoRef.Location = New System.Drawing.Point(226, 134)
        Me.txtdepoRef.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdepoRef.Name = "txtdepoRef"
        Me.txtdepoRef.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdepoRef.PlaceholderText = ""
        Me.txtdepoRef.SelectedText = ""
        Me.txtdepoRef.Size = New System.Drawing.Size(302, 36)
        Me.txtdepoRef.TabIndex = 5
        Me.txtdepoRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "POS Amount"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtpos
        '
        Me.txtpos.BorderRadius = 8
        Me.txtpos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpos.DefaultText = ""
        Me.txtpos.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtpos.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtpos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtpos.Location = New System.Drawing.Point(226, 181)
        Me.txtpos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpos.PlaceholderText = ""
        Me.txtpos.ReadOnly = True
        Me.txtpos.SelectedText = ""
        Me.txtpos.Size = New System.Drawing.Size(302, 36)
        Me.txtpos.TabIndex = 7
        Me.txtpos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(18, 225)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 42)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cash Deposit"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtdepo
        '
        Me.txtdepo.BorderRadius = 8
        Me.txtdepo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdepo.DefaultText = ""
        Me.txtdepo.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtdepo.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtdepo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtdepo.Location = New System.Drawing.Point(226, 228)
        Me.txtdepo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdepo.Name = "txtdepo"
        Me.txtdepo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdepo.PlaceholderText = ""
        Me.txtdepo.ReadOnly = True
        Me.txtdepo.SelectedText = ""
        Me.txtdepo.Size = New System.Drawing.Size(302, 36)
        Me.txtdepo.TabIndex = 9
        Me.txtdepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(18, 271)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 42)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Petty Cash"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtpetty
        '
        Me.txtpetty.BorderRadius = 8
        Me.txtpetty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpetty.DefaultText = ""
        Me.txtpetty.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtpetty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtpetty.Location = New System.Drawing.Point(226, 277)
        Me.txtpetty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpetty.Name = "txtpetty"
        Me.txtpetty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpetty.PlaceholderText = ""
        Me.txtpetty.SelectedText = ""
        Me.txtpetty.Size = New System.Drawing.Size(302, 36)
        Me.txtpetty.TabIndex = 11
        Me.txtpetty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(18, 322)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 42)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "BIR 2307"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtbir
        '
        Me.txtbir.BorderRadius = 8
        Me.txtbir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbir.DefaultText = ""
        Me.txtbir.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtbir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtbir.Location = New System.Drawing.Point(226, 323)
        Me.txtbir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbir.Name = "txtbir"
        Me.txtbir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbir.PlaceholderText = ""
        Me.txtbir.SelectedText = ""
        Me.txtbir.Size = New System.Drawing.Size(302, 36)
        Me.txtbir.TabIndex = 13
        Me.txtbir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 366)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 42)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Open Sales"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtopensales
        '
        Me.txtopensales.BorderRadius = 8
        Me.txtopensales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtopensales.DefaultText = ""
        Me.txtopensales.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtopensales.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtopensales.Location = New System.Drawing.Point(226, 367)
        Me.txtopensales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtopensales.Name = "txtopensales"
        Me.txtopensales.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtopensales.PlaceholderText = ""
        Me.txtopensales.SelectedText = ""
        Me.txtopensales.Size = New System.Drawing.Size(302, 36)
        Me.txtopensales.TabIndex = 15
        Me.txtopensales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(18, 408)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 42)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Other Dept. Exp."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtotherdept
        '
        Me.txtotherdept.BorderRadius = 8
        Me.txtotherdept.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtotherdept.DefaultText = ""
        Me.txtotherdept.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtotherdept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtotherdept.Location = New System.Drawing.Point(226, 411)
        Me.txtotherdept.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtotherdept.Name = "txtotherdept"
        Me.txtotherdept.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtotherdept.PlaceholderText = ""
        Me.txtotherdept.SelectedText = ""
        Me.txtotherdept.Size = New System.Drawing.Size(302, 36)
        Me.txtotherdept.TabIndex = 17
        Me.txtotherdept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 457)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 42)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Filename"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtfilename
        '
        Me.txtfilename.BorderRadius = 8
        Me.txtfilename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfilename.DefaultText = ""
        Me.txtfilename.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.txtfilename.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtfilename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.txtfilename.Location = New System.Drawing.Point(226, 459)
        Me.txtfilename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtfilename.Name = "txtfilename"
        Me.txtfilename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfilename.PlaceholderText = ""
        Me.txtfilename.ReadOnly = True
        Me.txtfilename.SelectedText = ""
        Me.txtfilename.Size = New System.Drawing.Size(237, 36)
        Me.txtfilename.TabIndex = 19
        '
        'btnBrowse
        '
        Me.btnBrowse.Animated = True
        Me.btnBrowse.BorderRadius = 8
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnBrowse.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBrowse.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!)
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnBrowse.Location = New System.Drawing.Point(470, 455)
        Me.btnBrowse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(58, 42)
        Me.btnBrowse.TabIndex = 20
        Me.btnBrowse.Text = "..."
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.lblstatus)
        Me.pnlFooter.Controls.Add(Me.btnSave)
        Me.pnlFooter.Controls.Add(Me.btnCancel)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 621)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(650, 132)
        Me.pnlFooter.TabIndex = 2
        '
        'lblstatus
        '
        Me.lblstatus.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblstatus.Location = New System.Drawing.Point(153, 4)
        Me.lblstatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(397, 47)
        Me.lblstatus.TabIndex = 0
        Me.lblstatus.Text = "-----------"
        Me.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblstatus.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.BorderRadius = 21
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(142, 67)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(200, 52)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Animated = True
        Me.btnCancel.BorderRadius = 21
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(350, 67)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 52)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "&Cancel"
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
        Me.pnlOverlay.Size = New System.Drawing.Size(650, 753)
        Me.pnlOverlay.TabIndex = 99
        Me.pnlOverlay.Visible = False
        '
        'loader
        '
        Me.loader.Animated = True
        Me.loader.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.loader.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.loader.ForeColor = System.Drawing.Color.White
        Me.loader.Location = New System.Drawing.Point(291, 275)
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
        Me.lblLoading.Location = New System.Drawing.Point(212, 355)
        Me.lblLoading.Margin = New System.Windows.Forms.Padding(4)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(187, 25)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Uploading, please wait..."
        '
        'frm_add_depo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 753)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlOverlay)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_add_depo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Deposit"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlOverlay.ResumeLayout(False)
        Me.pnlOverlay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTitle     As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblSubtitle  As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pnlBody      As System.Windows.Forms.Panel
    Friend WithEvents Label1       As System.Windows.Forms.Label
    Friend WithEvents dtfrom       As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9       As System.Windows.Forms.Label
    Friend WithEvents DTdepo       As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10      As System.Windows.Forms.Label
    Friend WithEvents txtdepoRef   As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2       As System.Windows.Forms.Label
    Friend WithEvents txtpos       As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3       As System.Windows.Forms.Label
    Friend WithEvents txtdepo      As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5       As System.Windows.Forms.Label
    Friend WithEvents txtpetty     As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6       As System.Windows.Forms.Label
    Friend WithEvents txtbir       As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7       As System.Windows.Forms.Label
    Friend WithEvents txtopensales As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8       As System.Windows.Forms.Label
    Friend WithEvents txtotherdept As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4       As System.Windows.Forms.Label
    Friend WithEvents txtfilename  As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBrowse    As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlFooter    As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblstatus    As System.Windows.Forms.Label
    Friend WithEvents btnSave      As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel    As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlOverlay   As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents loader       As Guna.UI2.WinForms.Guna2CircleProgressbar
    Friend WithEvents lblLoading   As Guna.UI2.WinForms.Guna2HtmlLabel

    ' Legacy alias referenced by code-behind
    Friend WithEvents Guna2ProgressIndicator1 As Guna.UI2.WinForms.Guna2CircleProgressbar =
        New Guna.UI2.WinForms.Guna2CircleProgressbar()

End Class
