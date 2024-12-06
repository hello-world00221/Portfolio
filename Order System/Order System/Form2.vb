Public Class Form2

    Dim ItemAmount As Double
    Dim AmountToPay As Double
    Dim Total As Double
    Const Monitor_PRICE = 1700
    Const Keyboard_PRICE = 250
    Const Mousepad_PRICE = 165
    Const SystemUnit_PRICE = 7599
    Const Scissors_PRICE = 65
    Const BondPaper_PRICE = 300
    Const Ballpen_PRICE = 10
    Const Chairs_PRICE = 460
    Const Desk_PRICE = 1250
    Const Printer_PRICE = 15780
    Const Aircon_PRICE = 22700
    Const Fan_PRICE = 2400
    Const Tape_PRICE = 45
    Const Marker_PRCE = 55

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("MM-dd-yyyy      hh:mm:ss")
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtQtyMonitor_TextChanged(sender As Object, e As EventArgs) Handles txtQtyMonitor.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyMonitor.Text, qty) AndAlso txtQtyMonitor.Text <> "" Then
            MsgBox("Please Enter a Valid quantity for monitor")
            txtQtyMonitor.Text = String.Empty
        End If
    End Sub

    Private Sub chckboxMonitor_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxMonitor.CheckedChanged

        txtQtyMonitor.Enabled = True
        If Not chckboxMonitor.Checked Then
            txtQtyMonitor.Text = String.Empty
        End If

    End Sub

    Private Sub txtQtyKeyboard_TextChanged(sender As Object, e As EventArgs) Handles txtQtyKeyboard.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyKeyboard.Text, qty) AndAlso txtQtyKeyboard.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Keyboard.")
            txtQtyKeyboard.Text = String.Empty

        End If
    End Sub

    Private Sub chckboxKeyBoard_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxKeyBoard.CheckedChanged
        txtQtyKeyboard.Enabled = True
        If Not chckboxKeyBoard.Checked Then
            txtQtyKeyboard.Text = String.Empty
        End If
    End Sub

    Private Sub txtQtyMousepad_TextChanged(sender As Object, e As EventArgs) Handles txtQtyMousepad.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyMousepad.Text, qty) AndAlso txtQtyMousepad.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Mousepad.")
            txtQtyMousepad.Text = String.Empty
        End If

    End Sub

    Private Sub chckboxMousepad_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxMousepad.CheckedChanged
        txtQtyMousepad.Enabled = True
        If Not chckboxMousepad.Checked Then
            txtQtyMousepad.Text = String.Empty
        End If

    End Sub

    Private Sub btnClearCart_Click(sender As Object, e As EventArgs) Handles btnClearCart.Click
        txtQtyMonitor.Text = ""
        txtQtyKeyboard.Text = ""
        txtQtyMousepad.Text = ""
        txtQtySystemUnit.Text = ""
        txtQtyScissors.Text = ""
        txtQtyBondPaper.Text = ""
        txtQtyBallpen.Text = ""
        txtQtyChairs.Text = ""
        txtQtyDesk.Text = ""
        txtQtyPrinter.Text = ""
        txtQtyAircon.Text = ""
        txtQtyFan.Text = ""
        txtQtyTape.Text = ""
        txtQtyMarker.Text = ""



    End Sub

    Private Sub txtQtySystemUnit_TextChanged(sender As Object, e As EventArgs) Handles txtQtySystemUnit.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtySystemUnit.Text, qty) AndAlso txtQtySystemUnit.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for System Unit.")
            txtQtySystemUnit.Text = String.Empty
        End If
    End Sub

    Private Sub chckboxSystemUnit_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxSystemUnit.CheckedChanged
        txtQtySystemUnit.Enabled = True
        If Not chckboxSystemUnit.Checked Then
            txtQtySystemUnit.Text = String.Empty
        End If
    End Sub

    Private Sub txtQtyBondPaper_TextChanged(sender As Object, e As EventArgs) Handles txtQtyBondPaper.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyBondPaper.Text, qty) AndAlso txtQtyBondPaper.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Bond Paper.")
            txtQtyBondPaper.Text = String.Empty

        End If
    End Sub
    Private Sub chckBoxBondPaper_CheckedChanged(sender As Object, e As EventArgs) Handles chckBoxBondPaper.CheckedChanged
        txtQtyBondPaper.Enabled = True
        If Not chckBoxBondPaper.Checked Then
            txtQtyBondPaper.Text = String.Empty
        End If
    End Sub

    Private Sub txtQtyBallpen_TextChanged(sender As Object, e As EventArgs) Handles txtQtyBallpen.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyBallpen.Text, qty) AndAlso txtQtyBallpen.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Ballpen.")
            txtQtyBallpen.Text = String.Empty
        End If
    End Sub

    Private Sub chckBoxBallpen_CheckedChanged(sender As Object, e As EventArgs) Handles chckBoxBallpen.CheckedChanged
        txtQtyBallpen.Enabled = True
        If Not chckBoxBallpen.Checked Then
            txtQtyBallpen.Text = String.Empty
        End If
    End Sub

    Private Sub txtQtyChairs_TextChanged(sender As Object, e As EventArgs) Handles txtQtyChairs.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyChairs.Text, qty) AndAlso txtQtyChairs.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Chairs.")
        End If
    End Sub

    Private Sub chckboxChairs_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxChairs.CheckedChanged
        txtQtyChairs.Enabled = True
        If Not chckboxChairs.Checked Then
            txtQtyBallpen.Text = String.Empty
        End If
    End Sub

    Private Sub txtQtyDesk_TextChanged(sender As Object, e As EventArgs) Handles txtQtyDesk.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyDesk.Text, qty) AndAlso txtQtyDesk.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Desk.")
        End If
    End Sub

    Private Sub txtQtyPrinter_TextChanged(sender As Object, e As EventArgs) Handles txtQtyPrinter.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyPrinter.Text, qty) AndAlso txtQtyPrinter.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Printer.")
        End If
    End Sub

    Private Sub txtQtyAircon_TextChanged(sender As Object, e As EventArgs) Handles txtQtyAircon.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyAircon.Text, qty) AndAlso txtQtyAircon.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Aircon.")
        End If
    End Sub

    Private Sub txtQtyFan_TextChanged(sender As Object, e As EventArgs) Handles txtQtyFan.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyFan.Text, qty) AndAlso txtQtyFan.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Fan.")
        End If
    End Sub

    Private Sub txtQtyTape_TextChanged(sender As Object, e As EventArgs) Handles txtQtyTape.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyTape.Text, qty) AndAlso txtQtyTape.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Tape.")
        End If
    End Sub

    Private Sub txtQtyMarker_TextChanged(sender As Object, e As EventArgs) Handles txtQtyMarker.TextChanged
        Dim qty As Integer
        If Not Integer.TryParse(txtQtyMarker.Text, qty) AndAlso txtQtyMarker.Text <> "" Then
            MsgBox("Please Enter a valid Quantity for Marker.")
        End If
    End Sub

    Private Sub chckboxDesk_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxDesk.CheckedChanged
        txtQtyDesk.Enabled = True
        If Not chckboxDesk.Checked Then
            txtQtyDesk.Text = String.Empty
        End If
    End Sub

    Private Sub chckboxPrinter_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxPrinter.CheckedChanged
        txtQtyPrinter.Enabled = True
        If Not chckboxPrinter.Checked Then
            txtQtyPrinter.Text = String.Empty
        End If
    End Sub

    Private Sub chckboxAircon_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxAircon.CheckedChanged
        txtQtyAircon.Enabled = True
        If Not chckboxAircon.Checked Then
            txtQtyAircon.Text = String.Empty
        End If
    End Sub

    Private Sub chckboxFan_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxFan.CheckedChanged
        txtQtyFan.Enabled = True
        If Not chckboxFan.Checked Then
            txtQtyFan.Text = String.Empty
        End If
    End Sub

    Private Sub chckboxTape_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxTape.CheckedChanged
        txtQtyTape.Enabled = True
        If Not chckboxTape.Checked Then
            txtQtyTape.Text = String.Empty
        End If
    End Sub

    Private Sub chckboxMarker_CheckedChanged(sender As Object, e As EventArgs) Handles chckboxMarker.CheckedChanged
        txtQtyMarker.Enabled = True
        If Not chckboxMarker.Checked Then
            txtQtyMarker.Text = String.Empty
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim TotalAmount As Double = 0.1
        Dim Price As Double = 0
        Dim Quantity As Double
        Dim TaxRate As Double = 0.1
        Dim ItemAmount As Double
        Dim Change As Double
        Dim Payment As Double

        If chckboxMonitor.Checked = True AndAlso IsNumeric(txtQtyMonitor.Text) Then
            Price = Monitor_PRICE
            Quantity = Convert.ToDouble(txtQtyMonitor.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxKeyBoard.Checked = True AndAlso IsNumeric(txtQtyKeyboard.Text) Then
            Price = Keyboard_PRICE
            Quantity = Convert.ToDouble(txtQtyKeyboard.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxMousepad.Checked = True AndAlso IsNumeric(txtQtyMousepad.Text) Then
            Price = Mousepad_PRICE
            Quantity = Convert.ToDouble(txtQtyMousepad.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxSystemUnit.Checked = True AndAlso IsNumeric(txtQtySystemUnit.Text) Then
            Price = SystemUnit_PRICE
            Quantity = Convert.ToDouble(txtQtySystemUnit.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckBoxScissors.Checked = True AndAlso IsNumeric(txtQtyScissors.Text) Then
            Price = Scissors_PRICE
            Quantity = Convert.ToDouble(txtQtyScissors.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckBoxBondPaper.Checked = True AndAlso IsNumeric(txtQtyBondPaper.Text) Then
            Price = BondPaper_PRICE
            Quantity = Convert.ToDouble(txtQtyBondPaper.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckBoxBallpen.Checked = True AndAlso IsNumeric(txtQtyBallpen.Text) Then
            Price = Ballpen_PRICE
            Quantity = Convert.ToDouble(txtQtyBallpen.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxChairs.Checked = True AndAlso IsNumeric(txtQtyChairs.Text) Then
            Price = Chairs_PRICE
            Quantity = Convert.ToDouble(txtQtyChairs.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxDesk.Checked = True AndAlso IsNumeric(txtQtyDesk.Text) Then
            Price = Desk_PRICE
            Quantity = Convert.ToDouble(txtQtyDesk.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxPrinter.Checked = True AndAlso IsNumeric(txtQtyPrinter.Text) Then
            Price = Printer_PRICE
            Quantity = Convert.ToDouble(txtQtyPrinter.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxAircon.Checked = True AndAlso IsNumeric(txtQtyAircon.Text) Then
            Price = Aircon_PRICE
            Quantity = Convert.ToDouble(txtQtyAircon.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxFan.Checked = True AndAlso IsNumeric(txtQtyFan.Text) Then
            Price = Fan_PRICE
            Quantity = Convert.ToDouble(txtQtyFan.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxTape.Checked = True AndAlso IsNumeric(txtQtyTape.Text) Then
            Price = Tape_PRICE
            Quantity = Convert.ToDouble(txtQtyTape.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount
        ElseIf chckboxMarker.Text = True AndAlso IsNumeric(txtQtyMarker.Text) Then
            Price = Marker_PRCE
            Quantity = Convert.ToDouble(txtQtyMarker.Text)
            ItemAmount = Price * Quantity
            TotalAmount += ItemAmount

        End If

        If TotalAmount = 0 Then
            MsgBox("Please Enter an item and enter a valid quantities", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops")

        Else
            TotalAmount += TotalAmount * TaxRate

            Payment = Convert.ToDouble(InputBox("Enter Your Payment"))

            Change = Payment - TotalAmount


            MsgBox("Change (Including Tax): " & Change.ToString("C2"), MsgBoxStyle.Information, "Change")
        End If


    End Sub

End Class