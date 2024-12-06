Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim firstNumber As Double
        Dim SecondNumber As Double
        Dim sum As Double
        Dim thirtyPercent As Double

        If Double.TryParse(txtFirstNumber.Text, firstNumber) AndAlso Double.TryParse(txtSecondNumber.Text, SecondNumber) Then

            sum = firstNumber + SecondNumber
            thirtyPercent = sum * 0.3
            lblResult.Text = "30% of the sum of" & firstNumber.ToString() & "and" & SecondNumber.ToString() & " is" & thirtyPercent.ToString()
        Else
            lblResult.Text = "Please Enter valid Numbers."
        End If

    End Sub
End Class