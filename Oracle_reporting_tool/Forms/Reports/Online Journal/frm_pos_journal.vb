Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Configuration
Imports System.Data.SqlClient
Imports Guna.UI2.WinForms
Imports System.Drawing

' Aliases to avoid type name conflicts
Imports WinFont = System.Drawing.Font
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Pdf

Public Class frm_pos_journal

    Dim cls_POS_journal       As New cls_menuitem
    Private currentSearchIndex As Integer = -1
    Private receiptLines       As List(Of String)
    Private isReprintMode      As Boolean = False

#Region "Form Load"

    Private Sub frm_pos_journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtdate.Value = DateTime.Today

        ' Runtime-only Guna2 property
        loader.ProgressColor2 = Color.FromArgb(255, 224, 192)

        ' ListView setup
        ListView1.OwnerDraw = True
        AddHandler ListView1.DrawColumnHeader, AddressOf ListView1_DrawColumnHeader
        AddHandler ListView1.DrawSubItem,      AddressOf ListView1_DrawSubItem
        ListView1.View         = View.Details
        ListView1.FullRowSelect = False
        ListView1.GridLines    = False
        ListView1.Columns.Add("Receipt", ListView1.Width - 4)
        ListView1.Font         = New WinFont("Courier New", 9, FontStyle.Regular)

        ' Keep column width in sync when the form resizes
        AddHandler Me.Resize, Sub(s, ev)
            If ListView1.Columns.Count > 0 Then
                ListView1.Columns(0).Width = ListView1.Width - 4
            End If
            CenterOverlay()
        End Sub

        ShowOverlay(False)
        UpdateStatus("Ready — pick a date and click Load Receipt.")
    End Sub

#End Region

#Region "Load — Async (replaces BackgroundWorker)"

    Public Async Sub LoadReceiptFromPOS(targetDate As DateTime)
        ClearWatermark()
        isReprintMode = False
        ShowOverlay(True)
        DisableButtons(True)
        UpdateStatus("Loading receipts for " & targetDate.ToString("MMM dd, yyyy") & "...")

        Try
            receiptLines = Await Task.Run(Function() cls_menuitem.GetReceipts(targetDate))
            BindListView(receiptLines)
            UpdateStatus("Loaded " & receiptLines.Count & " line(s)  ·  Date: " & targetDate.ToString("MMM dd, yyyy"))
        Catch ex As Exception
            MessageBox.Show("Error loading receipts:" & Environment.NewLine & ex.Message,
                            "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay(False)
            DisableButtons(False)
        End Try
    End Sub

    Public Async Sub LoadReceiptReprint()
        If String.IsNullOrWhiteSpace(txtChknum.Text) Then
            MessageBox.Show("Please enter a check number.", "Reprint",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        SetWatermark("RE-PRINT")
        isReprintMode = True
        ShowOverlay(True)
        DisableButtons(True)
        UpdateStatus("Loading reprint for check # " & txtChknum.Text & "...")

        Try
            Dim chk = txtChknum.Text.Trim()
            receiptLines = Await Task.Run(Function() cls_menuitem.GetReceipts_Reprint(chk))
            BindListView(receiptLines)
            UpdateStatus("Reprint loaded — Check #: " & chk & "  ·  " & receiptLines.Count & " line(s)")
        Catch ex As Exception
            MessageBox.Show("Error loading reprint:" & Environment.NewLine & ex.Message,
                            "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UpdateStatus("Error — " & ex.Message)
        Finally
            ShowOverlay(False)
            DisableButtons(False)
        End Try
    End Sub

    Private Sub BindListView(lines As List(Of String))
        ListView1.BeginUpdate()
        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        ListView1.Columns.Add("Receipt", ListView1.Width - 4)
        ListView1.Font = New WinFont("Courier New", 9, FontStyle.Regular)

        If lines IsNot Nothing Then
            For Each line As String In lines
                ListView1.Items.Add(line)
            Next
        Else
            ListView1.Items.Add("No results found.")
        End If

        ListView1.EndUpdate()
        currentSearchIndex = -1   ' reset search position
    End Sub

#End Region

#Region "Button handlers"

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        LoadReceiptFromPOS(dtdate.Value.Date)
    End Sub

    Private Sub btnGenerate_reprint_Click(sender As Object, e As EventArgs) Handles btnGenerate_reprint.Click
        LoadReceiptReprint()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtsearch.Text.Trim()
        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Please enter a search term.", "Search",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim startIndex As Integer = currentSearchIndex + 1
        Dim found As Boolean = False

        For i As Integer = startIndex To ListView1.Items.Count - 1
            If ListView1.Items(i).Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 Then
                ListView1.Items(i).Selected = True
                ListView1.EnsureVisible(i)
                currentSearchIndex = i
                found = True
                Exit For
            End If
        Next

        If Not found Then
            ' Wrap around
            If currentSearchIndex > 0 Then
                currentSearchIndex = -1
                MessageBox.Show("End of results — wrapping to top.", "Search",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No matches found.", "Search",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        ListView1.Invalidate()
    End Sub

    Private Sub btnExportPdf_Click(sender As Object, e As EventArgs) Handles btnExportPdf.Click
        Try
            If receiptLines Is Nothing OrElse receiptLines.Count = 0 Then
                MessageBox.Show("No receipt data to export.", "Export to PDF",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Using sfd As New SaveFileDialog()
                sfd.Filter   = "PDF Files|*.pdf"
                sfd.Title    = "Save Receipt as PDF"
                sfd.FileName = "Receipt_" & txtChknum.Text.Trim() & ".pdf"

                If sfd.ShowDialog() = DialogResult.OK Then
                    ExportReceiptToPdf(receiptLines, sfd.FileName)
                    MessageBox.Show("PDF exported successfully.", "Export to PDF",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    UpdateStatus("PDF exported: " & Path.GetFileName(sfd.FileName))
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error exporting PDF: " & ex.ToString(), "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "ListView owner-draw (search highlight + watermark pass-through)"

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs)
        ' Draw header with peach tint to match palette
        Using bgBrush As New SolidBrush(Color.FromArgb(255, 224, 192))
            e.Graphics.FillRectangle(bgBrush, e.Bounds)
        End Using
        TextRenderer.DrawText(e.Graphics, e.Header.Text, New WinFont("Segoe UI Semibold", 9.0!),
                              e.Bounds, Color.FromArgb(60, 35, 10),
                              TextFormatFlags.Left Or TextFormatFlags.VerticalCenter)
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs)
        Dim searchText As String = txtsearch.Text.Trim()

        ' Background
        If Not isReprintMode Then
            Using bg As New SolidBrush(If(e.ItemIndex Mod 2 = 0,
                                          Color.FromArgb(255, 255, 250),
                                          Color.FromArgb(255, 248, 238)))
                e.Graphics.FillRectangle(bg, e.Bounds)
            End Using
        End If

        ' Highlight current search match row
        If e.Item.Selected Then
            Using selBrush As New SolidBrush(Color.FromArgb(80, 255, 224, 192))
                e.Graphics.FillRectangle(selBrush, e.Bounds)
            End Using
        End If

        Dim fullText As String = e.SubItem.Text
        Dim font     As WinFont = e.SubItem.Font

        If String.IsNullOrEmpty(searchText) Then
            TextRenderer.DrawText(e.Graphics, fullText, font, e.Bounds,
                                  Color.FromArgb(40, 25, 8),
                                  TextFormatFlags.Left Or TextFormatFlags.VerticalCenter)
            Return
        End If

        Dim index As Integer = fullText.IndexOf(searchText, StringComparison.OrdinalIgnoreCase)
        If index < 0 Then
            e.Graphics.DrawString(fullText, font, Brushes.Black, e.Bounds.Left + 2, e.Bounds.Top + 2)
            Return
        End If

        ' Draw in three segments: before / match / after
        Dim beforeText As String = fullText.Substring(0, index)
        Dim matchText  As String = fullText.Substring(index, searchText.Length)
        Dim afterText  As String = fullText.Substring(index + searchText.Length)

        Dim x As Single = e.Bounds.Left + 2
        Dim y As Single = e.Bounds.Top + 2

        If beforeText <> "" Then
            e.Graphics.DrawString(beforeText, font, Brushes.Black, x, y)
            x += e.Graphics.MeasureString(beforeText, font).Width
        End If

        Dim matchSize As SizeF = e.Graphics.MeasureString(matchText, font)
        ' Amber highlight instead of yellow — fits the palette
        Using highlightBrush As New SolidBrush(Color.FromArgb(255, 200, 80))
            e.Graphics.FillRectangle(highlightBrush, x, y, matchSize.Width, matchSize.Height)
        End Using
        e.Graphics.DrawString(matchText, font, Brushes.Black, x, y)
        x += matchSize.Width

        If afterText <> "" Then
            e.Graphics.DrawString(afterText, font, Brushes.Black, x, y)
        End If
    End Sub

#End Region

#Region "Watermark"

    Private Sub SetWatermark(text As String)
        Dim bmp As New Bitmap(ListView1.Width, ListView1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.FromArgb(255, 255, 250))
            g.SmoothingMode         = Drawing2D.SmoothingMode.AntiAlias
            g.TextRenderingHint     = System.Drawing.Text.TextRenderingHint.AntiAlias

            Dim wFont  As New WinFont("Courier New", 50, FontStyle.Bold)
            Dim wBrush As New SolidBrush(Color.FromArgb(40, 210, 140, 80))

            Dim textSize As SizeF = g.MeasureString(text, wFont)
            g.TranslateTransform(ListView1.Width / 4, ListView1.Height / 2)
            g.RotateTransform(-45)
            g.DrawString(text, wFont, wBrush, -textSize.Width / 2, -textSize.Height / 2)
            g.ResetTransform()
        End Using

        ListView1.BackgroundImage       = bmp
        ListView1.BackgroundImageLayout = ImageLayout.Center
        isReprintMode = True
    End Sub

    Private Sub ClearWatermark()
        If ListView1.BackgroundImage IsNot Nothing Then
            ListView1.BackgroundImage.Dispose()
            ListView1.BackgroundImage = Nothing
        End If
        isReprintMode = False
    End Sub

#End Region

#Region "PDF Export (unchanged logic)"

    Private Sub ExportReceiptToPdf(lines As List(Of String), outputPath As String)
        If lines Is Nothing OrElse lines.Count = 0 Then
            Throw New InvalidOperationException("No lines to export.")
        End If
        If String.IsNullOrWhiteSpace(outputPath) Then
            Throw New ArgumentException("Output path is empty.")
        End If

        Dim document As New PdfDocument()
        document.Info.Title = "POS Receipt"

        Dim page As PdfPage = document.AddPage()
        page.Size = PageSize.A4

        Dim gfx  As XGraphics = XGraphics.FromPdfPage(page)
        Dim font As New XFont("Courier New", 9, XFontStyle.Regular)

        If isReprintMode Then
            Dim watermarkFont As New XFont("Courier New", 60, XFontStyle.Bold)
            Dim state         As XGraphicsState = gfx.Save()
            gfx.TranslateTransform(page.Width.Point / 4, page.Height.Point / 2)
            gfx.RotateTransform(-45)
            gfx.DrawString("RE-PRINT", watermarkFont, XBrushes.LightGray,
                           New XPoint(0, 0), XStringFormats.Center)
            gfx.Restore(state)
        End If

        Dim marginLeft  As Double = 40
        Dim marginTop   As Double = 40
        Dim lineHeight  As Double = font.GetHeight()
        Dim y           As Double = marginTop
        Dim maxHeight   As Double = page.Height.Point - marginTop

        For Each line As String In lines
            If y + lineHeight > maxHeight Then
                page     = document.AddPage()
                page.Size = PageSize.A4
                gfx      = XGraphics.FromPdfPage(page)
                y        = marginTop
            End If
            gfx.DrawString(If(line, ""), font, XBrushes.Black,
                           New XPoint(marginLeft, y), XStringFormats.TopLeft)
            y += lineHeight
        Next

        document.Save(outputPath)
        document.Close()
    End Sub

#End Region

#Region "Overlay, Status, Helpers"

    Private Sub ShowOverlay(show As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ShowOverlay(show))
            Return
        End If
        pnlOverlay.Visible = show
        If show Then
            pnlOverlay.BringToFront()
            CenterOverlay()
        End If
    End Sub

    Private Sub CenterOverlay()
        loader.Location   = New Point((pnlOverlay.Width  - loader.Width)   \ 2,
                                      (pnlOverlay.Height - loader.Height)  \ 2 - 20)
        lblLoading.Location = New Point((pnlOverlay.Width - lblLoading.Width) \ 2,
                                         loader.Bottom + 10)
    End Sub

    Private Sub DisableButtons(disable As Boolean)
        btnGenerate.Enabled        = Not disable
        btnSearch.Enabled          = Not disable
        btnGenerate_reprint.Enabled = Not disable
        btnExportPdf.Enabled       = Not disable
    End Sub

    Private Sub UpdateStatus(msg As String)
        lblStatus.Text = msg
    End Sub

#End Region

End Class
