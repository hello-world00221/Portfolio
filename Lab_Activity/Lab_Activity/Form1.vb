Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim sum As Integer

        If Integer.TryParse(txtFirstNumber.Text, firstNumber) AndAlso Integer.TryParse(txtSecondNumber.Text, secondNumber) Then
            sum = firstNumber + secondNumber
            lblResult.Text = sum.ToString()
        Else
            lblResult.Text = "Please Enter a valid integer."
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ClickMe_Click(sender As Object, e As EventArgs) Handles btnActivity.Click

        Form2.Show()
    End Sub
End Class
