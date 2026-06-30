Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Drawing.Printing
Imports Guna.UI2.WinForms

Public Class frm_ZReading

    '=================================================================
    ' PALETTE
    '=================================================================
    Private Const PEACH_BG As String = "#FFF5EB"
    Private Const PEACH_PANEL As String = "#FFE0C0"
    Private Const DARK_TEXT As String = "#3C2310"
    Private Const MUTED_LABEL As String = "#A07850"
    Private Const AMBER_ACCENT As String = "#D2A05A"
    Private Const AMBER_DARK As String = "#B8833A"

    '=================================================================
    ' STATE
    '=================================================================
    Private ReadOnly _connStr As String =
        ConfigurationManager.ConnectionStrings("LocalDB").ConnectionString

    '=================================================================
    ' CONSTRUCTOR
    '=================================================================
    Public Sub New()
        InitializeComponent()           ' designer stub — sets Name/Size only
        AutoScaleMode = AutoScaleMode.None
        BuildUI()                       ' all real control creation lives here
        WireEvents()
    End Sub

    '=================================================================
    ' UI CONSTRUCTION  (called once from New — safe, no designer limits)
    '=================================================================
    Private Sub BuildUI()
        Me.Size = New Size(820, 820)
        Me.MinimumSize = New Size(820, 700)
        Me.BackColor = ColorTranslator.FromHtml(PEACH_BG)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)

        '── HEADER ──────────────────────────────────────────────────
        pnlHeader = New Guna2Panel With {
            .Dock = DockStyle.Top,
            .Height = 72,
            .FillColor = ColorTranslator.FromHtml(PEACH_PANEL)
        }
        lblTitle = New Label With {
            .Text = "Z-READING REPORT",
            .Font = New Font("Segoe UI", 14.0F, FontStyle.Bold),
            .ForeColor = ColorTranslator.FromHtml(DARK_TEXT),
            .AutoSize = True,
            .Location = New Point(20, 12)
        }
        lblSubTitle = New Label With {
            .Text = "End-of-Day Sales Summary",
            .Font = New Font("Segoe UI", 9.0F, FontStyle.Regular),
            .ForeColor = ColorTranslator.FromHtml(MUTED_LABEL),
            .AutoSize = True,
            .Location = New Point(22, 40)
        }
        pnlHeader.Controls.AddRange({lblTitle, lblSubTitle})

        '── TOOLBAR ─────────────────────────────────────────────────
        pnlToolbar = New Guna2Panel With {
            .Dock = DockStyle.Top,
            .Height = 56,
            .FillColor = ColorTranslator.FromHtml(PEACH_BG)
        }
        lblDateLbl = New Label With {
            .Text = "Business Date:",
            .ForeColor = ColorTranslator.FromHtml(DARK_TEXT),
            .AutoSize = True,
            .Location = New Point(18, 18)
        }
        dtpDate = New Guna2DateTimePicker With {
            .Format = DateTimePickerFormat.Short,
            .Value = Date.Today,
            .Width = 150,
            .Height = 34,
            .Location = New Point(118, 10),
            .FillColor = Color.White,
            .BorderColor = ColorTranslator.FromHtml(AMBER_ACCENT),
            .ForeColor = ColorTranslator.FromHtml(DARK_TEXT),
            .Font = New Font("Segoe UI", 9.5F)
        }
        btnLoad = New Guna2Button With {
            .Text = "Load",
            .Width = 90,
            .Height = 34,
            .Location = New Point(280, 10),
            .FillColor = ColorTranslator.FromHtml(AMBER_ACCENT),
            .ForeColor = Color.White,
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .BorderRadius = 6
        }
        btnPrint = New Guna2Button With {
            .Text = "Print",
            .Width = 90,
            .Height = 34,
            .Location = New Point(380, 10),
            .FillColor = ColorTranslator.FromHtml(PEACH_PANEL),
            .ForeColor = ColorTranslator.FromHtml(DARK_TEXT),
            .Font = New Font("Segoe UI", 9.5F, FontStyle.Bold),
            .BorderRadius = 6,
            .Enabled = False
        }
        lblStatus = New Label With {
            .Text = "Select a date and click Load.",
            .ForeColor = ColorTranslator.FromHtml(MUTED_LABEL),
            .AutoSize = True,
            .Location = New Point(484, 18)
        }
        pnlToolbar.Controls.AddRange({lblDateLbl, dtpDate, btnLoad, btnPrint, lblStatus})

        '── STATUS BAR ──────────────────────────────────────────────
        pnlStatus = New Guna2Panel With {
            .Dock = DockStyle.Bottom,
            .Height = 28,
            .FillColor = ColorTranslator.FromHtml(PEACH_PANEL)
        }
        Dim lblFooter As New Label With {
            .Text = "Contemporain Foods Inc.  |  CheckPostingDB",
            .ForeColor = ColorTranslator.FromHtml(MUTED_LABEL),
            .AutoSize = True,
            .Location = New Point(10, 6)
        }
        pnlStatus.Controls.Add(lblFooter)

        '── SCROLLABLE BODY ─────────────────────────────────────────
        pnlBody = New Panel With {
            .Dock = DockStyle.Fill,
            .AutoScroll = True,
            .BackColor = ColorTranslator.FromHtml(PEACH_BG),
            .Padding = New Padding(12, 12, 12, 12)
        }

        '── CARDS ───────────────────────────────────────────────────
        pnlAccum = BuildAccumulationCard()
        pnlSales = BuildSalesCard()
        pnlTender = BuildTenderCard()
        pnlDisc = BuildDiscountCard()

        LayoutCards()
        pnlBody.Controls.AddRange({pnlAccum, pnlSales, pnlTender, pnlDisc})

        '── OVERLAY ─────────────────────────────────────────────────
        pnlOverlay = New Guna2Panel With {
            .Dock = DockStyle.Fill,
            .FillColor = Color.FromArgb(160, 255, 240, 220),
            .Visible = False
        }
        lblLoading = New Label With {
            .Text = "Loading…",
            .Font = New Font("Segoe UI", 13.0F, FontStyle.Bold),
            .ForeColor = ColorTranslator.FromHtml(DARK_TEXT),
            .AutoSize = True,
            .Location = New Point(340, 300)
        }
        pnlOverlay.Controls.Add(lblLoading)

        '── ASSEMBLE (dock order: last added = outermost) ────────────
        Me.Controls.Add(pnlBody)
        Me.Controls.Add(pnlOverlay)
        Me.Controls.Add(pnlToolbar)
        Me.Controls.Add(pnlHeader)
        Me.Controls.Add(pnlStatus)

        ClearValues()
    End Sub

    '=================================================================
    ' CARD FACTORY HELPERS
    '=================================================================

    Private Function MakeCard(title As String, cardColor As String) As Guna2Panel
        Dim card As New Guna2Panel With {
            .FillColor = ColorTranslator.FromHtml(cardColor),
            .BorderRadius = 8
        }
        Dim lbl As New Label With {
            .Text = title.ToUpper(),
            .Font = New Font("Segoe UI", 8.5F, FontStyle.Bold),
            .ForeColor = ColorTranslator.FromHtml(AMBER_DARK),
            .AutoSize = True,
            .Location = New Point(14, 10)
        }
        card.Controls.Add(lbl)
        Dim sep As New Panel With {
            .BackColor = ColorTranslator.FromHtml(AMBER_ACCENT),
            .Height = 1,
            .Left = 14,
            .Top = 30,
            .Width = 760
        }
        card.Controls.Add(sep)
        Return card
    End Function

    Private Function MakeRow(card As Guna2Panel, y As Integer,
                             labelText As String,
                             isTotal As Boolean) As Label
        Dim captionColor As Color = If(isTotal,
            ColorTranslator.FromHtml(DARK_TEXT),
            ColorTranslator.FromHtml(MUTED_LABEL))
        Dim fSize As Single = If(isTotal, 9.5F, 9.0F)
        Dim fStyle As FontStyle = If(isTotal, FontStyle.Bold, FontStyle.Regular)

        Dim lblCaption As New Label With {
            .Text = labelText,
            .Font = New Font("Segoe UI", fSize, fStyle),
            .ForeColor = captionColor,
            .AutoSize = False,
            .Width = 280,
            .Height = 22,
            .Location = New Point(20, y),
            .TextAlign = ContentAlignment.MiddleLeft
        }
        Dim lblValue As New Label With {
            .Text = "—",
            .Font = New Font("Segoe UI", fSize, fStyle),
            .ForeColor = ColorTranslator.FromHtml(DARK_TEXT),
            .AutoSize = False,
            .Width = 180,
            .Height = 22,
            .Location = New Point(310, y),
            .TextAlign = ContentAlignment.MiddleRight
        }
        card.Controls.AddRange({lblCaption, lblValue})
        Return lblValue
    End Function

    Private Sub AddSeparator(card As Guna2Panel, y As Integer)
        card.Controls.Add(New Panel With {
            .BackColor = ColorTranslator.FromHtml(AMBER_ACCENT),
            .Height = 1,
            .Left = 14,
            .Top = y,
            .Width = 500
        })
    End Sub

    Private Sub AddColumnHeaders(card As Guna2Panel, y As Integer,
                                 leftText As String, rightText As String)
        card.Controls.AddRange({
            New Label With {
                .Text = leftText, .Font = New Font("Segoe UI", 8.5F, FontStyle.Bold),
                .ForeColor = ColorTranslator.FromHtml(DARK_TEXT),
                .AutoSize = False, .Width = 280, .Height = 20,
                .Location = New Point(20, y), .TextAlign = ContentAlignment.MiddleLeft
            },
            New Label With {
                .Text = rightText, .Font = New Font("Segoe UI", 8.5F, FontStyle.Bold),
                .ForeColor = ColorTranslator.FromHtml(DARK_TEXT),
                .AutoSize = False, .Width = 180, .Height = 20,
                .Location = New Point(310, y), .TextAlign = ContentAlignment.MiddleRight
            }
        })
    End Sub

    '── Accumulation ─────────────────────────────────────────────────
    Private Function BuildAccumulationCard() As Guna2Panel
        Dim card = MakeCard("Accumulation & Invoice Range", PEACH_PANEL)
        Dim y = 44

        lblStartBalVal = MakeRow(card, y, "Starting Balance  (Old Accumulated Total)", False) : y += 26
        lblEndBalVal = MakeRow(card, y, "Ending Balance    (New Accumulated Total)", False) : y += 32
        lblFromInvVal = MakeRow(card, y, "From Invoice #", False) : y += 26
        lblToInvVal = MakeRow(card, y, "To Invoice #", False) : y += 26
        lblCustCountVal = MakeRow(card, y, "Customer Count", False) : y += 18

        card.Height = y + 20
        Return card
    End Function

    '── Sales ────────────────────────────────────────────────────────
    Private Function BuildSalesCard() As Guna2Panel
        Dim card = MakeCard("Sales Breakdown", PEACH_PANEL)
        Dim y = 44

        lblTotalSalesVal = MakeRow(card, y, "Total Sales (Net VAT Incl.)", False) : y += 26
        lblVatSalesVal = MakeRow(card, y, "VAT Sales (Vatable Amount)", False) : y += 26
        lblVatAmtVal = MakeRow(card, y, "VAT Amount (12%)", False) : y += 26
        lblVatExemptVal = MakeRow(card, y, "VAT Exempt Sales", False) : y += 26
        lblZeroRatedVal = MakeRow(card, y, "Zero Rated Sales", False) : y += 26
        lblTaxExemptedVal = MakeRow(card, y, "Tax Exempted (Gov. Disc.)", False) : y += 32
        lblDiscountsVal = MakeRow(card, y, "Total Discounts", False) : y += 26
        lblVoidsVal = MakeRow(card, y, "Voids", False) : y += 26
        lblServiceChgVal = MakeRow(card, y, "Service Charges", False) : y += 32

        AddSeparator(card, y - 8)
        lblNetSalesVal = MakeRow(card, y, "Net Sales", True) : y += 26

        card.Height = y + 20
        Return card
    End Function

    '── Tender ───────────────────────────────────────────────────────
    Private Function BuildTenderCard() As Guna2Panel
        Dim card = MakeCard("Tender Media", PEACH_PANEL)
        Dim y = 44

        AddColumnHeaders(card, y, "Tender Type", "Amount") : y += 24

        lblCashAmt = MakeRow(card, y, "Cash", False) : y += 24
        lblCreditCardAmt = MakeRow(card, y, "Credit Card", False) : y += 24
        lblOtherPayAmt = MakeRow(card, y, "Other Payments (e-Wallet / Online)", False) : y += 30

        AddSeparator(card, y - 6)
        lblTotalTenderAmt = MakeRow(card, y, "Total Tender", True) : y += 26

        card.Height = y + 20
        Return card
    End Function

    '── Discounts ────────────────────────────────────────────────────
    Private Function BuildDiscountCard() As Guna2Panel
        Dim card = MakeCard("Discount Detail", PEACH_PANEL)
        Dim y = 44

        AddColumnHeaders(card, y, "Discount Type", "Amount") : y += 24

        lblGovDiscVal = MakeRow(card, y, "Government Discounts (SC / PWD / Natl. Athlete / Solo Parent)", False) : y += 24
        lblOtherDiscVal = MakeRow(card, y, "Other Discounts (Employee / Promo)", False) : y += 30

        AddSeparator(card, y - 6)
        lblTotalDiscVal = MakeRow(card, y, "Total Discounts", True) : y += 26

        card.Height = y + 20
        Return card
    End Function

    '=================================================================
    ' LAYOUT / OVERLAY / CLEAR
    '=================================================================

    Private Sub LayoutCards()
        Dim padding = 12
        Dim cardW = pnlBody.ClientSize.Width - (padding * 2) - 20
        If cardW < 500 Then cardW = 500

        Dim y = padding
        For Each c As Guna2Panel In {pnlAccum, pnlSales, pnlTender, pnlDisc}
            c.Left = padding
            c.Top = y
            c.Width = cardW
            For Each ctrl As Control In c.Controls
                If TypeOf ctrl Is Panel Then
                    Dim p = DirectCast(ctrl, Panel)
                    If p.Height = 1 Then p.Width = cardW - 28
                End If
            Next
            y += c.Height + padding
        Next
    End Sub

    Private Sub ShowOverlay(show As Boolean)
        pnlOverlay.Visible = show
        If show Then pnlOverlay.BringToFront()
    End Sub

    Private Sub ClearValues()
        For Each lbl In {lblStartBalVal, lblEndBalVal, lblFromInvVal,
                         lblToInvVal, lblCustCountVal,
                         lblTotalSalesVal, lblVatSalesVal, lblVatAmtVal,
                         lblVatExemptVal, lblZeroRatedVal, lblTaxExemptedVal,
                         lblDiscountsVal, lblVoidsVal, lblServiceChgVal, lblNetSalesVal,
                         lblCashAmt, lblCreditCardAmt, lblOtherPayAmt, lblTotalTenderAmt,
                         lblGovDiscVal, lblOtherDiscVal, lblTotalDiscVal}
            lbl.Text = "—"
        Next
    End Sub

    '=================================================================
    ' EVENT WIRING
    '=================================================================
    Private Sub WireEvents()
        AddHandler btnLoad.Click, AddressOf btnLoad_Click
        AddHandler btnPrint.Click, AddressOf btnPrint_Click
        AddHandler Me.Resize, AddressOf frm_Resize
    End Sub

    Private Sub frm_Resize(sender As Object, e As EventArgs)
        LayoutCards()
    End Sub

    '=================================================================
    ' LOAD DATA
    '=================================================================
    Private Async Sub btnLoad_Click(sender As Object, e As EventArgs)
        Dim bDate As Date = dtpDate.Value.Date

        ShowOverlay(True)
        lblStatus.Text = "Loading…"
        btnLoad.Enabled = False
        btnPrint.Enabled = False
        ClearValues()

        Try
            Dim dt As DataTable = Await Task.Run(Function() FetchZReading(bDate))

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                PopulateValues(dt.Rows(0), bDate)
                lblStatus.Text = $"Loaded: {bDate:MMMM dd, yyyy}"
                btnPrint.Enabled = True
            Else
                lblStatus.Text = "No data found for the selected date."
                ClearValues()
            End If

        Catch ex As Exception
            MessageBox.Show($"Error loading data:{Environment.NewLine}{ex.Message}",
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblStatus.Text = "Load failed."

        Finally
            ShowOverlay(False)
            btnLoad.Enabled = True
        End Try
    End Sub

    '=================================================================
    ' DATABASE CALLS
    '=================================================================
    Private Function FetchZReading(businessDate As Date) As DataTable
        Dim dt As New DataTable()
        Using conn As New SqlConnection(_connStr)
            conn.Open()
            Using cmd As New SqlCommand("usp_GetMallDailySummary", conn) With {
                    .CommandType = CommandType.StoredProcedure,
                    .CommandTimeout = 120}
                cmd.Parameters.Add(New SqlParameter("@StartDate", SqlDbType.Date) With {.Value = businessDate})
                cmd.Parameters.Add(New SqlParameter("@EndDate", SqlDbType.Date) With {.Value = businessDate})
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Private Sub FetchInvoiceRange(bDate As Date,
                                  ByRef fromInv As String,
                                  ByRef toInv As String)
        Try
            Using conn As New SqlConnection(_connStr)
                conn.Open()
                Const sql As String =
                    "SELECT MIN(FCRInvNumber) AS MinInv,
                            MAX(FCRInvNumber) AS MaxInv
                     FROM   dbo.FCR_INVOICE_DATA
                     WHERE  PurgeStatus = 0
                       AND  CAST(MicrosBsnzDate AS DATE) = @bDate"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.Add(New SqlParameter("@bDate", SqlDbType.Date) With {.Value = bDate})
                    Using rdr = cmd.ExecuteReader()
                        If rdr.Read() Then
                            fromInv = If(rdr.IsDBNull(0), "—", rdr.GetString(0))
                            toInv = If(rdr.IsDBNull(1), "—", rdr.GetString(1))
                        End If
                    End Using
                End Using
            End Using
        Catch
            ' Non-fatal — leave defaults
        End Try
    End Sub

    '=================================================================
    ' POPULATE UI FROM DATA ROW
    '=================================================================
    Private Sub PopulateValues(row As DataRow, bDate As Date)
        Dim netVatIncl As Decimal = GetDec(row, "NetVatIncl")
        Dim oldAccum As Decimal = GetDec(row, "OldAccumulatedTotal")
        Dim newAccum As Decimal = GetDec(row, "NewAccumulatedTotal")
        Dim govDisc As Decimal = GetDec(row, "GovDisc")
        Dim otherDisc As Decimal = GetDec(row, "OtherDisc")
        Dim cashSales As Decimal = GetDec(row, "cashsales")
        Dim creditCard As Decimal = GetDec(row, "CreditCardpayment")
        Dim otherPay As Decimal = GetDec(row, "Otherpayment")
        Dim voidAmt As Decimal = GetDec(row, "void")
        Dim taxVatAmt As Decimal = GetDec(row, "taxvatamt")
        Dim custCount As Integer = GetInt(row, "CustomerCount")

        Dim vatSales As Decimal = Math.Round(netVatIncl / 1.12D, 2)
        Dim totalDisc As Decimal = govDisc + otherDisc
        Dim netSales As Decimal = netVatIncl - totalDisc - voidAmt
        Dim totalTender As Decimal = cashSales + creditCard + otherPay

        Dim fromInv As String = "—"
        Dim toInv As String = "—"
        FetchInvoiceRange(bDate, fromInv, toInv)

        ' Accumulation card
        lblStartBalVal.Text = FormatAmt(oldAccum)
        lblEndBalVal.Text = FormatAmt(newAccum)
        lblFromInvVal.Text = fromInv
        lblToInvVal.Text = toInv
        lblCustCountVal.Text = custCount.ToString("N0")

        ' Sales card
        lblTotalSalesVal.Text = FormatAmt(netVatIncl)
        lblVatSalesVal.Text = FormatAmt(vatSales)
        lblVatAmtVal.Text = FormatAmt(taxVatAmt)
        lblVatExemptVal.Text = FormatAmt(govDisc)
        lblZeroRatedVal.Text = FormatAmt(0D)
        lblTaxExemptedVal.Text = FormatAmt(govDisc)
        lblDiscountsVal.Text = FormatAmt(totalDisc)
        lblVoidsVal.Text = FormatAmt(voidAmt)
        lblServiceChgVal.Text = "—"
        lblNetSalesVal.Text = FormatAmt(netSales)

        ' Tender card
        lblCashAmt.Text = FormatAmt(cashSales)
        lblCreditCardAmt.Text = FormatAmt(creditCard)
        lblOtherPayAmt.Text = FormatAmt(otherPay)
        lblTotalTenderAmt.Text = FormatAmt(totalTender)

        ' Discount card
        lblGovDiscVal.Text = FormatAmt(govDisc)
        lblOtherDiscVal.Text = FormatAmt(otherDisc)
        lblTotalDiscVal.Text = FormatAmt(totalDisc)
    End Sub

    '=================================================================
    ' PRINT
    '=================================================================
    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        Try
            Dim pd As New PrintDocument()
            AddHandler pd.PrintPage, AddressOf PrintZReading
            Dim dlg As New PrintPreviewDialog With {
                .Document = pd,
                .Width = 800,
                .Height = 900
            }
            dlg.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Print Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub PrintZReading(sender As Object, e As PrintPageEventArgs)
        Dim g = e.Graphics
        Dim x = 60
        Dim y = 50
        Dim lh = 22
        Dim W = 480

        Dim fTitle As New Font("Courier New", 12, FontStyle.Bold)
        Dim fHead As New Font("Courier New", 9, FontStyle.Bold)
        Dim fNormal As New Font("Courier New", 9, FontStyle.Regular)
        Dim br As New SolidBrush(Color.Black)

        Dim PrintLine As Action(Of String, String, Font) =
            Sub(caption, value, fnt)
                g.DrawString(caption, fnt, br, x, y)
                g.DrawString(value, fnt, br, x + W - 160, y)
                y += lh
            End Sub

        Dim PrintSep As Action =
            Sub()
                g.DrawLine(Pens.Black, x, y, x + W, y)
                y += 6
            End Sub

        g.DrawString("Z-READING REPORT", fTitle, br, x + 150, y) : y += lh + 6
        g.DrawString($"Business Date: {dtpDate.Value:MMMM dd, yyyy}", fNormal, br, x, y) : y += lh
        g.DrawString($"Printed: {DateTime.Now:yyyy-MM-dd HH:mm}", fNormal, br, x, y) : y += lh + 4
        PrintSep()

        g.DrawString("ACCUMULATION / INVOICE RANGE", fHead, br, x, y) : y += lh
        PrintSep()
        PrintLine("Starting Balance:", lblStartBalVal.Text, fNormal)
        PrintLine("Ending Balance:", lblEndBalVal.Text, fNormal)
        PrintLine("From Invoice #:", lblFromInvVal.Text, fNormal)
        PrintLine("To Invoice #:", lblToInvVal.Text, fNormal)
        PrintLine("Customer Count:", lblCustCountVal.Text, fNormal)
        y += 6

        g.DrawString("SALES BREAKDOWN", fHead, br, x, y) : y += lh
        PrintSep()
        PrintLine("Total Sales (Net VAT Incl.):", lblTotalSalesVal.Text, fNormal)
        PrintLine("VAT Sales:", lblVatSalesVal.Text, fNormal)
        PrintLine("VAT Amount (12%):", lblVatAmtVal.Text, fNormal)
        PrintLine("VAT Exempt Sales:", lblVatExemptVal.Text, fNormal)
        PrintLine("Zero Rated Sales:", lblZeroRatedVal.Text, fNormal)
        PrintLine("Tax Exempted:", lblTaxExemptedVal.Text, fNormal)
        PrintLine("Total Discounts:", lblDiscountsVal.Text, fNormal)
        PrintLine("Voids:", lblVoidsVal.Text, fNormal)
        PrintLine("Service Charges:", lblServiceChgVal.Text, fNormal)
        PrintSep()
        PrintLine("NET SALES:", lblNetSalesVal.Text, fHead)
        y += 6

        g.DrawString("TENDER MEDIA", fHead, br, x, y) : y += lh
        PrintSep()
        PrintLine("Cash:", lblCashAmt.Text, fNormal)
        PrintLine("Credit Card:", lblCreditCardAmt.Text, fNormal)
        PrintLine("Other Payments:", lblOtherPayAmt.Text, fNormal)
        PrintSep()
        PrintLine("TOTAL TENDER:", lblTotalTenderAmt.Text, fHead)
        y += 6

        g.DrawString("DISCOUNT DETAIL", fHead, br, x, y) : y += lh
        PrintSep()
        PrintLine("Government Discounts:", lblGovDiscVal.Text, fNormal)
        PrintLine("Other Discounts:", lblOtherDiscVal.Text, fNormal)
        PrintSep()
        PrintLine("TOTAL DISCOUNTS:", lblTotalDiscVal.Text, fHead)

        fTitle.Dispose() : fHead.Dispose() : fNormal.Dispose() : br.Dispose()
    End Sub

    '=================================================================
    ' HELPERS
    '=================================================================
    Private Shared Function FormatAmt(v As Decimal) As String
        Return v.ToString("N2")
    End Function

    Private Shared Function GetDec(row As DataRow, col As String) As Decimal
        If row.Table.Columns.Contains(col) AndAlso Not row.IsNull(col) Then
            Return Convert.ToDecimal(row(col))
        End If
        Return 0D
    End Function

    Private Shared Function GetInt(row As DataRow, col As String) As Integer
        If row.Table.Columns.Contains(col) AndAlso Not row.IsNull(col) Then
            Return Convert.ToInt32(row(col))
        End If
        Return 0
    End Function

    Private Sub frm_ZReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
