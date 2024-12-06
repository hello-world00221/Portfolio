Imports System.Drawing.Text

Public Class Form1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtDisplay.Text &= "1"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtDisplay.Text &= "3"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtDisplay.Text &= "7"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtDisplay.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtDisplay.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtDisplay.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtDisplay.Text &= "6"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtDisplay.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtDisplay.Text &= "9"
    End Sub

    Dim firstNum As Double
    Dim operation As String
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "+"
        txtDisplay.Text = ""

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "*"
        txtDisplay.Text = ""
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "/"
        txtDisplay.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        firstNum = CDbl(txtDisplay.Text)
        operation = "-"
        txtDisplay.Text = ""
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtDisplay.Text &= "0"
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        Dim secondNum As Double = CDbl(txtDisplay.Text)
        Dim result As Double

        Select Case operation
            Case "+"
                result = firstNum + secondNum
            Case "-"
                result = firstNum - secondNum
            Case "*"
                result = firstNum * secondNum
            Case "/"
                result = firstNum / secondNum

        End Select

        txtDisplay.Text = result.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear the text box or other display element'
        txtDisplay.Text = ""

    End Sub
End Class
