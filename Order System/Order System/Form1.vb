Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin123" Then
            MsgBox("You Login Successfully.")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class
