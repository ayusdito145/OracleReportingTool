Public Class frm_dashboard_new

    ' ── Scale helpers ────────────────────────────────────────────────
    Private _baseSidebarWidth As Integer
    Private _baseFormWidth As Integer
    Private _baseFormHeight As Integer
    Private _scaleFactor As Single = 1.0F

    Private Sub ComputeScaleFactor()
        Dim scr As Screen = Screen.FromControl(Me)
        Const dW As Integer = 1920, dH As Integer = 1080
        _scaleFactor = Math.Max(0.6F, Math.Min(1.25F,
                       Math.Min(scr.Bounds.Width / CSng(dW),
                                scr.Bounds.Height / CSng(dH))))
    End Sub

    Private Sub ApplyFormScale()
        Dim scr As Screen = Screen.FromControl(Me)
        Me.Size = New Size(
            Math.Min(CInt(_baseFormWidth * _scaleFactor), scr.WorkingArea.Width),
            Math.Min(CInt(_baseFormHeight * _scaleFactor), scr.WorkingArea.Height))
        Me.CenterToScreen()
    End Sub

    Private Sub ScaleFonts(container As Control, factor As Single)
        For Each ctrl As Control In container.Controls
            Try
                ctrl.Font = New Font(ctrl.Font.FontFamily,
                                     Math.Max(6.0F, ctrl.Font.Size * factor),
                                     ctrl.Font.Style, GraphicsUnit.Point)
            Catch : End Try
            If ctrl.Controls.Count > 0 Then ScaleFonts(ctrl, factor)
        Next
    End Sub

    ' ── Title-bar drag support ────────────────────────────────────────
    Private _dragging As Boolean
    Private _dragOrigin As Point

    ' ── Active-state tracking ─────────────────────────────────────────
    Private _activeBtn As Guna.UI2.WinForms.Guna2Button = Nothing

    ' Map each nav button to its icon label — kept in sync during SetActive
    Private _iconMap As Dictionary(Of Guna.UI2.WinForms.Guna2Button, Label)

    Private ReadOnly Property NavButtons As IEnumerable(Of Guna.UI2.WinForms.Guna2Button)
        Get
            Return {btnInsight, btnhourly, btnsystemSales, BtnMenuItem,
                    BtnJournal, btnROF, BtnDepo, btnMaintenance}
        End Get
    End Property

    ' ── Safe BMP icon characters (Segoe UI Symbol, all <= 65535) ──────
    '   Chr() values are all in the Basic Multilingual Plane — no
    '   surrogate pair issues.
    Private Sub SetIconChars()
        lblIconInsight.Text = ChrW(9685)   ' ◕
        lblIconHourly.Text = ChrW(9200)   ' ⏰
        lblIconSystem.Text = ChrW(9096)   ' ⌨
        lblIconMenuItem.Text = ChrW(9749)   ' ☕
        lblIconJournal.Text = ChrW(9999)   ' ✏
        lblIconROF.Text = ChrW(9732)   ' ☴
        lblIconDepo.Text = ChrW(9962)   ' ⛲
        lblIconMaint.Text = ChrW(9881)   ' ⚙
        lblIconLogout.Text = ChrW(9099)   ' ⌛
    End Sub

#Region "Form Load"

    Private Sub frm_dashboard_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScaleMode = AutoScaleMode.None

        _baseFormWidth = Me.Width
        _baseFormHeight = Me.Height
        _baseSidebarWidth = sidebar.Width

        ComputeScaleFactor()
        ApplyFormScale()
        ScaleFonts(Me, _scaleFactor)
        sidebar.Width = CInt(_baseSidebarWidth * _scaleFactor)

        ' Username from login session
        lblname.Text = login_username
        lblRole.Text = login_name

        ' Assign safe icon chars
        SetIconChars()

        ' Build button→iconLabel map for SetActive
        _iconMap = New Dictionary(Of Guna.UI2.WinForms.Guna2Button, Label) From {
            {btnInsight, lblIconInsight},
            {btnhourly, lblIconHourly},
            {btnsystemSales, lblIconSystem},
            {BtnMenuItem, lblIconMenuItem},
            {BtnJournal, lblIconJournal},
            {btnROF, lblIconROF},
            {BtnDepo, lblIconDepo},
            {btnMaintenance, lblIconMaint}
        }


        ' Title-bar button hover colours (set at runtime — Designer-safe)

        ' Reposition bottom controls on resize
        RepositionBottomControls()
        AddHandler Me.Resize, Sub(s, ev)
                                  RepositionBottomControls()

                              End Sub
    End Sub

    Private Sub RepositionBottomControls()
        Dim h = sidebar.Height
        lblVersion.Location = New Point(18, h - 16)
        pnlRowLogout.Location = New Point(0, h - 60)
        sep4.Location = New Point(17, h - 64)
    End Sub


#End Region

#Region "Active-state highlight"

    ''' <summary>
    ''' Highlights the active nav row: peach fill on button + bright icon.
    ''' All other rows reset to transparent + dimmed icon.
    ''' </summary>
    Private Sub SetActive(btn As Guna.UI2.WinForms.Guna2Button)
        For Each b In NavButtons
            b.FillColor = Color.Transparent
            b.ForeColor = Color.FromArgb(210, 185, 155)
            b.CustomBorderColor = Color.Transparent
            b.Font = New Font("Segoe UI", 9.5!)
            If _iconMap IsNot Nothing AndAlso _iconMap.ContainsKey(b) Then
                _iconMap(b).ForeColor = Color.FromArgb(160, 120, 80)
            End If
            ' Reset parent panel background
            b.Parent.BackColor = Color.Transparent
        Next

        ' Highlight active row
        btn.FillColor = Color.FromArgb(255, 224, 192)
        btn.ForeColor = Color.FromArgb(60, 35, 10)
        btn.CustomBorderColor = Color.FromArgb(210, 160, 90)
        btn.Font = New Font("Segoe UI Semibold", 9.5!, FontStyle.Bold)
        If _iconMap IsNot Nothing AndAlso _iconMap.ContainsKey(btn) Then
            _iconMap(btn).ForeColor = Color.FromArgb(60, 35, 10)
        End If
        ' Give the whole row a subtle peach tint
        btn.Parent.BackColor = Color.FromArgb(255, 224, 192)

        _activeBtn = btn
    End Sub

#End Region

#Region "Form Loader"

    Public Sub LoadForm(childForm As Form)
        If mainpanel.Controls.Count > 0 Then
            Dim old As Control = mainpanel.Controls(0)
            mainpanel.Controls.Remove(old)
            old.Dispose()
        End If
        ApplyScaleToChildForm(childForm)
        With childForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .AutoScaleMode = AutoScaleMode.None
            .AutoSize = False
        End With
        mainpanel.Controls.Add(childForm)
        mainpanel.Tag = childForm
        childForm.Show()
        childForm.BringToFront()
    End Sub

    Private Sub ApplyScaleToChildForm(childForm As Form)
        ScaleFonts(childForm, _scaleFactor)
        If TypeOf childForm Is IScalable Then
            DirectCast(childForm, IScalable).ApplyScale(_scaleFactor)
        End If
    End Sub

#End Region

#Region "Navigation"

    Private Sub btnInsight_Click(sender As Object, e As EventArgs) Handles btnInsight.Click
        SetActive(btnInsight)
        LoadForm(New frm_insight())
    End Sub

    Private Sub btnhourly_Click(sender As Object, e As EventArgs) Handles btnhourly.Click
        SetActive(btnhourly)
        LoadForm(New frm_hourly())
    End Sub

    Private Sub btnsystemSales_Click(sender As Object, e As EventArgs) Handles btnsystemSales.Click
        SetActive(btnsystemSales)
        LoadForm(New frm_system_sales())
    End Sub

    Private Sub btnmenuitem_Click(sender As Object, e As EventArgs) Handles BtnMenuItem.Click
        SetActive(BtnMenuItem)
        LoadForm(New frm_menuitem_pos())
    End Sub

    Private Sub BtnJournal_Click(sender As Object, e As EventArgs) Handles BtnJournal.Click
        SetActive(BtnJournal)
        LoadForm(New frm_pos_journal())
    End Sub

    Private Sub btnROF_Click(sender As Object, e As EventArgs) Handles btnROF.Click
        SetActive(btnROF)
        LoadForm(New frm_rof())
    End Sub

    Private Sub BtnDepo_Click(sender As Object, e As EventArgs) Handles BtnDepo.Click
        SetActive(BtnDepo)
        LoadForm(New frm_depo())
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        SetActive(btnMaintenance)
        LoadForm(New frm_sync_data())
    End Sub

#End Region

#Region "Logout / Close"

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MsgBox("Are you sure you want to sign out?",
                  vbQuestion + vbYesNo, "Sign Out") = vbYes Then
            Me.Hide()
            frm_login.Show()
            frm_login.txtusername.Focus()
        End If
    End Sub

    Private Sub frm_dashboard_new_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub mainpanel_Paint(sender As Object, e As PaintEventArgs) Handles mainpanel.Paint

    End Sub

#End Region

End Class
