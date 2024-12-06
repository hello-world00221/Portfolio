Imports MySql.Data.MySqlClient

Public Class PatientsaDashboard

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
        Radius.AddLine(btnAdd.Width, 20, btn.Width, btn.Height - 10)

        Radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Radius.CloseFigure()

        btnAdd.Region = New Region(Radius)

    End Sub

    Private Sub RoundButton1(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.Orange
        btn.ForeColor = Color.LightYellow
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Radius As New Drawing2D.GraphicsPath

        Radius.StartFigure()

        Radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Radius.AddLine(10, 0, btn.Width - 20, 0)

        Radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Radius.AddLine(btnPrint.Width, 20, btn.Width, btn.Height - 10)

        Radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Radius.CloseFigure()
        btnPrint.Region = New Region(Radius)

    End Sub

    Private Sub RoundButton2(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.BackColor = Color.DarkBlue
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        btn.Font = New Font("Century Gothic", 14)

        Dim Radius As New Drawing2D.GraphicsPath

        Radius.StartFigure()

        Radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        Radius.AddLine(10, 0, btn.Width - 20, 0)

        Radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        Radius.AddLine(btnSave.Width, 20, btn.Width, btn.Height - 10)

        Radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Radius.CloseFigure()
        btnSave.Region = New Region(Radius)

    End Sub
    Private Sub RoundButton3(btn As Button)

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
        Radius.AddLine(btnExit.Width, 20, btn.Width, btn.Height - 10)

        Radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        Radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Radius.CloseFigure()
        btnExit.Region = New Region(Radius)

    End Sub

    Private UserRole As String

    Public Sub New(role As String)

        ' This call is required by the designer.
        InitializeComponent()
        UserRole = role
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PatientsaDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        RoundButton(btnAdd)
        RoundButton1(btnPrint)
        RoundButton2(btnSave)
        RoundButton(btnExit)

        DoctorDashBoard.Visible = False
        NurseDashBoard.Visible = False


        Dim iRef As Integer = CInt(Int(23992 * Rnd()) + 12)
        txtRef.Text = Convert.ToString(iRef)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles doctorsTab.Click
        LoginAsDoctor()
        DoctorDashBoard.Show()
    End Sub

    Private Sub patientTab_Click(sender As Object, e As EventArgs) Handles patientTab.Click
        LoginAsNurse()
    End Sub

    Private Sub LoginAsDoctor()

        ' Show the Doctor panel and hide Nurse Panel
        DoctorDashBoard.Visible = True
        NurseDashBoard.Visible = False

        ' Disable access to Nurse label
        patientTab.Enabled = False
        patientTab.ForeColor = Color.Gray
    End Sub

    Private Sub LoginAsNurse()

        'Show the Nurse panel and hide doctor panel
        NurseDashBoard.Visible = True
        DoctorDashBoard.Visible = False

        'Disable access to Doctor label
        doctorsTab.Enabled = False
        doctorsTab.ForeColor = Color.Gray

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintPreviewDialog1.Load
        Try
            e.Graphics.DrawString(rtDocs.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 100, 100)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs)

        Try
            txtRef.Text = ""
            txtFirstName.Text = ""
            txtLastName.Text = ""
            StudentID.Text = ""
            txtCourse.Text = ""
            txtAge.Text = ""
            txtMobile.Text = ""
            txtSex.Text = ""
            DateTimePicker1.ResetText()
            txtStatus.Text = ""
            txtCase.Text = ""

            Dim iRef As Integer = CInt(Int(23992 * Rnd()) + 12)
            txtRef.Text = Convert.ToString(iRef)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "QCU Clinic", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Dim iSave As New SaveFileDialog

        iSave.Filter = "txt files (*.txt) |*.txt| doc files (*.doc) |*.doc"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False

        If iSave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, rtDocs.Text)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Dim connStr As String = ""
    End Sub
End Class