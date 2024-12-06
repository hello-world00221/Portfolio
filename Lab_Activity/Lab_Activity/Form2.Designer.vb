<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtFirstNumber = New TextBox()
        txtSecondNumber = New TextBox()
        Label4 = New Label()
        lblResult = New TextBox()
        btnCalculate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(126, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 37)
        Label1.TabIndex = 0
        Label1.Text = "UNIT CONVERTER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Maroon
        Label2.Location = New Point(91, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(292, 37)
        Label2.TabIndex = 2
        Label2.Text = "Enter the First Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Maroon
        Label3.Location = New Point(81, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(326, 37)
        Label3.TabIndex = 3
        Label3.Text = "Enter the Second Number"
        ' 
        ' txtFirstNumber
        ' 
        txtFirstNumber.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstNumber.Location = New Point(142, 181)
        txtFirstNumber.Name = "txtFirstNumber"
        txtFirstNumber.Size = New Size(173, 34)
        txtFirstNumber.TabIndex = 4
        ' 
        ' txtSecondNumber
        ' 
        txtSecondNumber.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSecondNumber.Location = New Point(142, 271)
        txtSecondNumber.Name = "txtSecondNumber"
        txtSecondNumber.Size = New Size(173, 34)
        txtSecondNumber.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Maroon
        Label4.Location = New Point(12, 318)
        Label4.Name = "Label4"
        Label4.Size = New Size(476, 37)
        Label4.TabIndex = 6
        Label4.Text = "The 30% of the sum of two numbers is"
        ' 
        ' lblResult
        ' 
        lblResult.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(24, 372)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(457, 34)
        lblResult.TabIndex = 7
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.Location = New Point(179, 430)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(102, 35)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Result"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(493, 496)
        Controls.Add(btnCalculate)
        Controls.Add(lblResult)
        Controls.Add(Label4)
        Controls.Add(txtSecondNumber)
        Controls.Add(txtFirstNumber)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblResult As TextBox
    Friend WithEvents btnCalculate As Button
End Class
