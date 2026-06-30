Public Module ScaleHelper
    ''' <summary>
    ''' Call this in any form's Load event as a one-liner.
    ''' Example: ScaleHelper.AutoScale(Me)
    ''' </summary>
    Public Sub AutoScale(frm As Form, Optional designWidth As Integer = 1920,
                                      Optional designHeight As Integer = 1080)
        frm.AutoScaleMode = AutoScaleMode.None

        Dim screen As Screen = Screen.FromControl(frm)
        Dim factor As Single = ComputeFactor(screen, designWidth, designHeight)

        ' Resize form
        Dim newW As Integer = Math.Min(CInt(frm.Width * factor), screen.WorkingArea.Width)
        Dim newH As Integer = Math.Min(CInt(frm.Height * factor), screen.WorkingArea.Height)
        frm.Size = New Size(newW, newH)
        frm.Location = New Point(
            screen.WorkingArea.Left + (screen.WorkingArea.Width - frm.Width) \ 2,
            screen.WorkingArea.Top + (screen.WorkingArea.Height - frm.Height) \ 2)
        ' Scale all fonts
        ScaleFontsRecursive(frm, factor)
    End Sub

    Public Function ComputeFactor(screen As Screen,
                                  Optional designW As Integer = 1920,
                                  Optional designH As Integer = 1080) As Single
        Dim rW As Single = screen.Bounds.Width / CSng(designW)
        Dim rH As Single = screen.Bounds.Height / CSng(designH)
        Dim f As Single = Math.Min(rW, rH)
        Return Math.Max(0.6F, Math.Min(1.25F, f)) ' Clamp 60%–125%
    End Function

    Public Sub ScaleFontsRecursive(container As Control, factor As Single)
        For Each ctrl As Control In container.Controls
            Try
                Dim sz As Single = Math.Max(6.0F, ctrl.Font.Size * factor)
                ctrl.Font = New Font(ctrl.Font.FontFamily, sz,
                                     ctrl.Font.Style, GraphicsUnit.Point)
            Catch
            End Try
            If ctrl.Controls.Count > 0 Then ScaleFontsRecursive(ctrl, factor)
        Next
    End Sub
    Public Interface IScalable
        Sub ApplyScale(factor As Single)
    End Interface

End Module
