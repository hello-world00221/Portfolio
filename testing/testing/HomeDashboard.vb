Imports MySql.Data.MySqlClient

Public Class HomeDashboard

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand

    Private Sub uploadData()
        sqlConn.ConnectionString = "server=localhost; userid=root; password=; database=clinicdb; port=3306"
        sqlConn.Open()

    End Sub

    Private Sub HomeDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Populate Combobox with roles


        txtGender.Items.Add("Male")
        txtGender.Items.Add("Female")
        txtGender.Items.Add("Others")

        txtRelationship.Items.Add("Parent")
        txtRelationship.Items.Add("Guardian")
        txtRelationship.Items.Add("Wife")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs)
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnPatientAdd_Click(sender As Object, e As EventArgs)

        'Connection to Database
        Dim connStr As String = "server=localhost; userid=root; password=; database=clinicdb; port=3306"
        Dim sqlConn As New MySqlConnection(connStr)
        Dim sqlCmd As New MySqlCommand

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        Try
            sqlCmd.CommandText = "INSERT INTO patientsinfo(StudentID, Course, LastName, MiddleName, FirstName, Age, Height, Weight, Gender, PhoneNumber, BloodType, BloodPressure, Category, Address,Date)" &
            "VALUES(@StudentID,@Course,@LastName,@MiddleName,@FirstName,@Age,@Height,@Weight,@Gender,@PhoneNumber,@BloodType,@BloodPressure,@Category,@Address,@Date)"

            'Format the Date
            Dim formattedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

            sqlCmd.Parameters.AddWithValue("@Date", formattedDate)

            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Patients info inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "QCU Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)

        'Connection to Database
        Dim connStr As String = "server=localhost; userid=root; password=; database=clinicdb; port=3306"
        Dim sqlConn As New MySqlConnection(connStr)
        Dim sqlCmd As New MySqlCommand

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        Try
            sqlCmd.CommandText = "INSERT INTO visitorsinfo(PatientsName, VisitorName, Relatives, ContactNumber, PhoneNumber, Relationship,PurposeofVisit,Date)" &
                "VALUES(@PatientsName, @Visitor1,@Relatives, @ContactNumber, @PhoneNumber, @Relationship, @PurposeofVisit, @Date)"

            'Format the Date
            Dim formattedDate As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")

            sqlCmd.Parameters.AddWithValue("@Date", formattedDate)

            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Visitors inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "QCU Clinic", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub
End Class