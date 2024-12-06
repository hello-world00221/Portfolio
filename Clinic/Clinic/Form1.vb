
Imports System.Runtime.Remoting.Messaging

Public Class Form1

    Private Sub roundCorners(obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None
        obj.BackColor = Color.White

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()

        'top left Corner

        DGP.AddArc(New Rectangle(0, 0, 40, 40), 180, 90)
        DGP.AddLine(40, 0, obj.Width - 40, 0)

        'top right Corner

        DGP.AddArc(New Rectangle(obj.Width - 40, 0, 40, 40), -90, 90)
        DGP.AddLine(obj.Width, 40, obj.Width, obj.Width - 40)

        'buttom  right corner

        DGP.AddArc(New Rectangle(obj.Width - 40, obj.Height - 40, 40, 40), 0, 90)
        DGP.AddLine(obj.Width - 40, obj.Height, 40, obj.Height)

        'buttom left corner

        DGP.AddArc(New Rectangle(0, obj.Height - 40, 40, 40), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)

    End Sub

    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.Cyan
        btn.ForeColor = Color.Blue
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Radius As New Drawing2D.GraphicsPath

        Radius.StartFigure()

        Radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Radius.AddLine(10, 0, btn.Width - 20, 0)

        Radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Radius.AddLine(btnLogin.Width, 20, btn.Width, btn.Height - 10)

        Radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Radius.CloseFigure()

        btnLogin.Region = New Region(Radius)

    End Sub

    Private Sub RoundButton1(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.Red
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Radius As New Drawing2D.GraphicsPath

        Radius.StartFigure()

        Radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Radius.AddLine(10, 0, btn.Width - 20, 0)

        Radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Radius.AddLine(btnReset.Width, 20, btn.Width, btn.Height - 10)

        Radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Radius.CloseFigure()

        btnReset.Region = New Region(Radius)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        RoundButton(btnLogin)
        RoundButton1(btnReset)

        cmbRole.Items.Add("Doctor")
        cmbRole.Items.Add("Nurse")
        cmbRole.SelectedIndex = 0

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim role As String = cmbRole.SelectedItem.ToString()
        Dim username As String = txtUserName.Text
        Dim password As String = txtPassword.Text

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please fill in all fields.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Select Case role
            Case "Doctor"
                If username = "doctor" AndAlso password = "doctor123" Then
                    MessageBox.Show("Welcome, Doctor!", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Invalid Doctor credentials.", "Login Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Case "Nurse"
                If username = "nurse" AndAlso password = "nurse123" Then
                    MessageBox.Show("Welcome, Nurse!", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Invalid Nurse credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Case Else
                MessageBox.Show("Invalid role selected.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

        Dim dashboard As New PatientsaDashboard(role)
        dashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUserName.Text = ""
        txtPassword.Text = ""
    End Sub
End Class
