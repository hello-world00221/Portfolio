Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin123" Then
            MsgBox("Login Successfully.")
            txtUsername.Text = ""
            txtPassword.Text = ""
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username or Password.")
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class