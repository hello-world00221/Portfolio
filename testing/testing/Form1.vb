Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "admin123" Then
            MessageBox.Show("Welcome to QCU Clinic", "QCU Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dashboard.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged

        'Toggle the Password char
        If CheckBoxShowPassword.Checked Then
            txtPassword.PasswordChar = "" 'Show password
        Else
            txtPassword.PasswordChar = "*" 'Hide Password
        End If
    End Sub
End Class
