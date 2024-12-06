Imports MySql.Data.MySqlClient

Public Class Form1

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlDt As New DataTable
    Dim sqlRD As MySqlDataReader
    Dim sqlDtA As New MySqlDataAdapter


    Dim ID As String

    Private Sub uploadData()
        sqlConn.ConnectionString = "server=localhost;userid=root;password=;database=employee_db;port=3306"
        sqlConn.Open()

        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * FROM employee_db"

        sqlRD = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRD)
        sqlRD.Close()
        sqlConn.Close()

        DataGridView1.DataSource = sqlDt

    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Try
            e.Graphics.DrawString(rtPaySlip.Text, New Font("Arial", 12, FontStyle.Bold), Brushes.Black, 100, 100)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim iExit As DialogResult


        Try
            iExit = MessageBox.Show("Confimed if you want to exit", "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If iExit = DialogResult.Yes Then
                Application.Exit()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End Try




    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Try
            txtRef.Text = ""
            txtFirstname.Text = ""
            txtsurname.Text = ""
            txtAddress.Text = ""
            txtMobile.Text = ""
            txtGender.Text = ""

            txtTaxCode.Text = ""
            txtTaxPeriod.Text = ""
            dateTimePicker1.ResetText()
            txtSearch.Text = ""
            rtPaySlip.Text = ""
            txtOverTime.Text = ""
            txtBasicSalary.Text = ""
            txtCityWeighting.Text = ""

            lblDeductions.Text = ""
            lblGrossPay.Text = ""
            lblNetPay.Text = ""
            lblStudentLoan.Text = ""
            lblTax.Text = ""
            lblTaxablePay.Text = ""
            lblPension.Text = ""
            lblPensionablePay.Text = ""
            lblNIPayment.Text = ""
            lblNINUmber.Text = ""
            lblNICode.Text = ""

            Dim iRef As Integer = CInt(Int((31773 * Rnd()) + 12))
            txtRef.Text = Convert.ToString(iRef)




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End Try



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iRef As Integer = CInt(Int((31773 * Rnd()) + 12))
        txtRef.Text = Convert.ToString(iRef)
        uploadData()

        Timer1.Enabled = True



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim iSave As New SaveFileDialog


        iSave.Filter = "txt files (*.txt) |*.txt| doc files (*.doc) |*.doc"
        iSave.FilterIndex = 2
        iSave.RestoreDirectory = False


        If iSave.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(iSave.FileName, rtPaySlip.Text)
        End If
    End Sub


    Private Sub dateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dateTimePicker1.ValueChanged

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            If e.RowIndex >= 0 Then
                'Access the  selectedRow
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                'Map data to the input
                txtRef.Text = selectedRow.Cells("ID").Value.ToString()
                txtFirstname.Text = selectedRow.Cells("Firstname").Value.ToString
                txtsurname.Text = selectedRow.Cells("Surname").Value.ToString
                txtAddress.Text = selectedRow.Cells("Address").Value.ToString()
                txtGender.Text = selectedRow.Cells("Gender").Value.ToString
                txtMobile.Text = selectedRow.Cells("Mobile").Value.ToString
                txtCityWeighting.Text = selectedRow.Cells("Weight").Value.ToString()
                txtBasicSalary.Text = selectedRow.Cells("Salary").Value.ToString
                txtOverTime.Text = selectedRow.Cells("OverTime").Value.ToString
                txtOtherPayment.Text = selectedRow.Cells("OtherPayment").Value.ToString()
                lblTax.Text = selectedRow.Cells("Tax").Value.ToString
                lblPension.Text = selectedRow.Cells("Pension").Value.ToString
                lblStudentLoan.Text = selectedRow.Cells("StudentLoan").Value.ToString()
                lblNIPayment.Text = selectedRow.Cells("NIPayment").Value.ToString
                dateTimePicker1.Text = selectedRow.Cells("PayDate").Value.ToString
                txtTaxPeriod.Text = selectedRow.Cells("TaxPeriod").Value.ToString()
                txtTaxCode.Text = selectedRow.Cells("TaxCode").Value.ToString
                lblNINUmber.Text = selectedRow.Cells("NINumber").Value.ToString
                lblNICode.Text = selectedRow.Cells("NICode").Value.ToString()
                lblTaxablePay.Text = selectedRow.Cells("TaxablePay").Value.ToString
                lblPensionablePay.Text = selectedRow.Cells("PensionablePay").Value.ToString
                lblNetPay.Text = selectedRow.Cells("NetPay").Value.ToString()
                lblGrossPay.Text = selectedRow.Cells("GrossPay").Value.ToString
                lblDeductions.Text = selectedRow.Cells("Deduction").Value.ToString
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End Try


    End Sub

    Private Sub btnTotal_Click(ByVal sender As Object, e As EventArgs) Handles btnTotal.Click

        Dim GrossPay, Deductions, NetPay, Period As Double
        Dim InnerCity, BasicPay, OverTime, OtherPayment, Tax, Pension, StudentLoan, NIPayment As Double

        InnerCity = Double.Parse(txtCityWeighting.Text)
        BasicPay = Double.Parse(txtBasicSalary.Text)
        OverTime = Double.Parse(txtOverTime.Text)
        OtherPayment = Double.Parse(txtOtherPayment.Text)

        'Calculate the GrossPay
        GrossPay = InnerCity + BasicPay + OverTime + OtherPayment
        lblGrossPay.Text = FormatCurrency(GrossPay)

        'Calculate the Deduction
        Tax = (GrossPay * 9) / 100
        Pension = (GrossPay * 12) / 100
        StudentLoan = (GrossPay * 5) / 100
        NIPayment = (GrossPay * 3) / 100

        Deductions = Tax + Pension + StudentLoan + NIPayment
        lblDeductions.Text = FormatCurrency(Deductions)

        'Set labels for deductioons
        lblTax.Text = FormatCurrency(Tax)
        lblPension.Text = FormatCurrency(Pension)
        lblStudentLoan.Text = FormatCurrency(StudentLoan)
        lblNIPayment.Text = FormatCurrency(NIPayment)

        NetPay = GrossPay - Deductions
        lblNetPay.Text = FormatCurrency(NetPay)

        Period = Double.Parse(txtTaxPeriod.Text)
        lblTaxablePay.Text = FormatCurrency(Period * Tax)
        lblPensionablePay.Text = FormatCurrency(Period * Pension)

        '==========================Insert=================================

        Dim connStr As String = "server=localhost;user id=root;password=;database=employee_db;port=3306"
        Dim sqlConn As New MySqlConnection(connStr)
        Dim sqlCmd As New MySqlCommand

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        Try


            Dim OtherPay As Decimal
            If Not Decimal.TryParse(txtOtherPayment.Text, OtherPay) Then
                MessageBox.Show("Please Enter a valid number for Other Payment", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            sqlCmd.CommandText = "INSERT INTO employee_db (EmployeeID,Firstname,Surname,Address,Gender,Mobile,Weight,Salary,Overtime,OtherPayment,Tax,Pension,StudentLoan,NIPayment,PayDate,TaxPeriod,TaxCode,NINumber,NICode,TaxablePay,PensionablePay,NetPay,GrossPay,Deduction)" &
                "VALUES(@ID,@Firstname,@Surname,@Address,@Gender,@Mobile,@Weight,@Salary,@Overtime,@OtherPay,@Tax,@Pension,@StudentLoan,@NIPay,@Paydate,@TaxPeriod,@TaxCode,@NINumber,@NICode,@Taxable,@PensionablePay,@NetPay,@GrossPay,@Deduction)"

            'Format the date in yyyy-MM-dd format
            Dim formattedDate As String = dateTimePicker1.Value.ToString("yyyy-MM-dd")

            sqlCmd.Parameters.AddWithValue("@ID", txtRef.Text)
            sqlCmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
            sqlCmd.Parameters.AddWithValue("@Surname", txtsurname.Text)
            sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            sqlCmd.Parameters.AddWithValue("@Gender", txtGender.Text)
            sqlCmd.Parameters.AddWithValue("@Mobile", txtMobile.Text)
            sqlCmd.Parameters.AddWithValue("@Weight", InnerCity)

            sqlCmd.Parameters.AddWithValue("@Salary", BasicPay)
            sqlCmd.Parameters.AddWithValue("@OverTime", OverTime)
            sqlCmd.Parameters.AddWithValue("@OtherPay", OtherPayment)

            sqlCmd.Parameters.AddWithValue("@Tax", Tax)
            sqlCmd.Parameters.AddWithValue("@Pension", Pension)
            sqlCmd.Parameters.AddWithValue("@StudentLoan", StudentLoan)
            sqlCmd.Parameters.AddWithValue("@NIPay", NIPayment)

            sqlCmd.Parameters.AddWithValue("@Paydate", formattedDate)
            sqlCmd.Parameters.AddWithValue("@TaxPeriod", Period)
            sqlCmd.Parameters.AddWithValue("@TaxCode", txtTaxCode.Text)
            sqlCmd.Parameters.AddWithValue("@NINumber", lblNINUmber.Text)
            sqlCmd.Parameters.AddWithValue("@NICode", lblNICode.Text)

            sqlCmd.Parameters.AddWithValue("@Taxable", Period * Tax)
            sqlCmd.Parameters.AddWithValue("@PensionablePay", Period * Pension)
            sqlCmd.Parameters.AddWithValue("@NetPay", NetPay)
            sqlCmd.Parameters.AddWithValue("@GrossPay", GrossPay)
            sqlCmd.Parameters.AddWithValue("@Deduction", Deductions)

            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Data successfully inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            sqlConn.Close()
            uploadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employe System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        Try

            sqlCmd.CommandText = "UPDATE employee_db SET Firstname = @Firstname, Surname = @Surname, Address = @Address, Gender = @Gender, Mobile = @Mobile, Weight = @Weight, Salary = @Salary, Overtime = @Overtime, OtherPayment = @OtherPay, Tax = @Tax, Pension = @Pension, StudentLoan = @StudentLoan, NIPayment = @NIPay, PayDate = @PayDate, TaxPeriod = @TaxPeriod, TaxCode = @TaxCode, NINumber = @NINumber, NICode = @NICode, TaxablePay = @Taxable, PensionablePay = @PensionablePay, NetPay = @NetPay, GrossPay = @GrossPay, Deduction = @Deduction WHERE ID = @ID"

            Dim formattedDate As String = dateTimePicker1.Value.ToString("yyyy-MM-dd")


                sqlCmd.Parameters.AddWithValue("@ID", txtRef.Text)
                sqlCmd.Parameters.AddWithValue("@Firstname", txtFirstname.Text)
            sqlCmd.Parameters.AddWithValue("@Surname", txtsurname.Text)
            sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text)
            sqlCmd.Parameters.AddWithValue("@Gender", txtGender.Text)
            sqlCmd.Parameters.AddWithValue("@Mobile", txtMobile.Text)
            sqlCmd.Parameters.AddWithValue("@Weight", txtCityWeighting.Text)

            sqlCmd.Parameters.AddWithValue("@Salary", txtBasicSalary.Text)
            sqlCmd.Parameters.AddWithValue("@Overtime", txtOverTime.Text)
            sqlCmd.Parameters.AddWithValue("@OtherPay", txtOtherPayment.Text)
            sqlCmd.Parameters.AddWithValue("@Tax", lblTax.Text)
            sqlCmd.Parameters.AddWithValue("@Pension", lblPension.Text)
            sqlCmd.Parameters.AddWithValue("@StudentLoan", lblStudentLoan.Text)
            sqlCmd.Parameters.AddWithValue("@NIPay", lblNIPayment.Text)

            sqlCmd.Parameters.AddWithValue("@PayDate", formattedDate)
            sqlCmd.Parameters.AddWithValue("@TaxPeriod", txtTaxPeriod.Text)
            sqlCmd.Parameters.AddWithValue("@TaxCode", txtTaxCode.Text)
            sqlCmd.Parameters.AddWithValue("@NINumber", lblNINUmber.Text)
            sqlCmd.Parameters.AddWithValue("@NICode", lblNICode.Text)

            sqlCmd.Parameters.AddWithValue("@Taxable", lblTaxablePay.Text)
            sqlCmd.Parameters.AddWithValue("@PensionablePay", lblPensionablePay.Text)
            sqlCmd.Parameters.AddWithValue("@NetPay", lblNetPay.Text)
            sqlCmd.Parameters.AddWithValue("@GrossPay", lblGrossPay.Text)
            sqlCmd.Parameters.AddWithValue("@Deduction", lblDeductions.Text)

            sqlCmd.ExecuteNonQuery()
            MessageBox.Show("Employee Payroll System Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        sqlCmd.Connection = sqlConn

        Try

            Dim ID As String = txtRef.Text

            sqlCmd.CommandText = "DELETE FROM employee_db WHERE ID = @ID "
            sqlCmd.Parameters.Clear()
            sqlCmd.Parameters.AddWithValue("@ID", ID)

            sqlConn.Open()

            Dim result As Integer = sqlCmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Record Deleted Successfully", "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No record found with the given ID", "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error)

        Finally
            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()

            End If

        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Me.Hide()
        Dim main As New Form1
        main.Show()

    End Sub

    Private Sub btnPaySlip_Click(sender As Object, e As EventArgs) Handles btnPaySlip.Click

        Try
            rtPaySlip.Clear()
            rtPaySlip.AppendText(vbTab + vbTab + "Pay Slip" + vbTab + vbTab + vbNewLine)
            rtPaySlip.AppendText(vbTab + vbTab + "--------------" + vbTab + vbTab + vbNewLine)
            rtPaySlip.AppendText("Employee ID" + vbTab + vbTab + txtRef.Text + vbNewLine)
            rtPaySlip.AppendText("FirstName" + vbTab + vbTab + vbTab + txtFirstname.Text + vbNewLine)
            rtPaySlip.AppendText("Surname" + vbTab + vbTab + vbTab + txtsurname.Text + vbNewLine)
            rtPaySlip.AppendText("Address" + vbTab + vbTab + vbTab + txtAddress.Text + vbNewLine)
            rtPaySlip.AppendText("Gender" + vbTab + vbTab + vbTab + txtGender.Text + vbNewLine)
            rtPaySlip.AppendText("Mobile Number" + vbTab + vbTab + txtMobile.Text + vbNewLine)
            rtPaySlip.AppendText("Weight" + vbTab + vbTab + vbTab + txtCityWeighting.Text + vbNewLine)


            rtPaySlip.AppendText("Salary" + vbTab + vbTab + vbTab + txtBasicSalary.Text + vbNewLine)
            rtPaySlip.AppendText("Over Time" + vbTab + vbTab + txtOverTime.Text + vbNewLine)
            rtPaySlip.AppendText("Other Payment" + vbTab + vbTab + txtOtherPayment.Text + vbNewLine)
            rtPaySlip.AppendText("Tax" + vbTab + vbTab + vbTab + lblTax.Text + vbNewLine)
            rtPaySlip.AppendText("Pension" + vbTab + vbTab + vbTab + lblPension.Text + vbNewLine)

            rtPaySlip.AppendText("Student Loan" + vbTab + vbTab + lblStudentLoan.Text + vbNewLine)
            rtPaySlip.AppendText("NI Payment" + vbTab + vbTab + lblNIPayment.Text + vbNewLine)
            rtPaySlip.AppendText("PayDate" + vbTab + vbTab + dateTimePicker1.Text + vbNewLine)
            rtPaySlip.AppendText("TaxPeriod" + vbTab + vbTab + txtTaxPeriod.Text + vbNewLine)

            rtPaySlip.AppendText("TaxCode" + vbTab + vbTab + vbTab + txtTaxCode.Text + vbNewLine)
            rtPaySlip.AppendText("NINumber" + vbTab + vbTab + lblNINUmber.Text + vbNewLine)
            rtPaySlip.AppendText("NICode" + vbTab + vbTab + vbTab + lblNICode.Text + vbNewLine)
            rtPaySlip.AppendText("Taxable" + vbTab + vbTab + vbTab + lblTaxablePay.Text + vbNewLine)
            rtPaySlip.AppendText("Pensionable" + vbTab + vbTab + lblPensionablePay.Text + vbNewLine)
            rtPaySlip.AppendText("NetPay" + vbTab + vbTab + vbTab + lblNetPay.Text + vbNewLine)
            rtPaySlip.AppendText("GrossPay" + vbTab + vbTab + vbTab + lblGrossPay.Text + vbNewLine)
            rtPaySlip.AppendText("Deductions" + vbTab + vbTab + lblDeductions.Text + vbNewLine)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView

                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("Firstname like '%{0}%'", txtSearch.Text)
                DataGridView1.DataSource = dv.ToTable
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            If sqlDt Is Nothing Then
                MessageBox.Show("Data Table is not loaded", "Emloyee System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If String.IsNullOrWhiteSpace(txtSearch.Text) Then
                MessageBox.Show("Please enter a name to search", "Employee System", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If



            Dim dv As DataView = sqlDt.DefaultView

            dv.RowFilter = String.Format("Firstname Like '%{0}%'", txtSearch.Text.Replace("'", "''"))
            DataGridView1.DataSource = dv.ToTable()

        Catch ex As Exception
            MessageBox.Show($"An Error Occured: (ex.Message)", "Employee System", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtOtherPayment_MouseEnter(sender As Object, e As EventArgs) Handles txtOtherPayment.MouseEnter
        txtOtherPayment.Text = ""
        txtOtherPayment.Focus()

    End Sub

    Private Sub txtOtherPayment_MouseLeave(sender As Object, e As EventArgs) Handles txtOtherPayment.MouseLeave

        If txtOtherPayment.Text = "" Then
            txtOtherPayment.Text = 0.0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label25.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub
End Class
