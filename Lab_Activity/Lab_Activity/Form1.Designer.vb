<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtFirstNumber = New TextBox()
        txtSecondNumber = New TextBox()
        Label4 = New Label()
        lblResult = New TextBox()
        btnCalculate = New Button()
        btnActivity = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Brown
        Label1.Location = New Point(125, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(245, 37)
        Label1.TabIndex = 0
        Label1.Text = "UNIT CONVERTER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.RosyBrown
        Label2.Location = New Point(92, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(292, 37)
        Label2.TabIndex = 1
        Label2.Text = "Enter the First Number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.IndianRed
        Label3.Location = New Point(77, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(326, 37)
        Label3.TabIndex = 2
        Label3.Text = "Enter the Second Number"
        ' 
        ' txtFirstNumber
        ' 
        txtFirstNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFirstNumber.Location = New Point(102, 172)
        txtFirstNumber.Name = "txtFirstNumber"
        txtFirstNumber.Size = New Size(268, 33)
        txtFirstNumber.TabIndex = 3
        ' 
        ' txtSecondNumber
        ' 
        txtSecondNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSecondNumber.Location = New Point(102, 265)
        txtSecondNumber.Name = "txtSecondNumber"
        txtSecondNumber.Size = New Size(273, 33)
        txtSecondNumber.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.IndianRed
        Label4.Location = New Point(70, 333)
        Label4.Name = "Label4"
        Label4.Size = New Size(333, 37)
        Label4.TabIndex = 5
        Label4.Text = "The sum of two numers is:"
        ' 
        ' lblResult
        ' 
        lblResult.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(102, 373)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(273, 33)
        lblResult.TabIndex = 6
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.Location = New Point(190, 431)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(88, 32)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Result"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnActivity
        ' 
        btnActivity.Location = New Point(296, 489)
        btnActivity.Name = "btnActivity"
        btnActivity.Size = New Size(88, 23)
        btnActivity.TabIndex = 8
        btnActivity.Text = "Click Me"
        btnActivity.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.IndianRed
        Label5.Location = New Point(77, 493)
        Label5.Name = "Label5"
        Label5.Size = New Size(135, 15)
        Label5.TabIndex = 9
        Label5.Text = "30% Sum of the number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(479, 538)
        Controls.Add(Label5)
        Controls.Add(btnActivity)
        Controls.Add(btnCalculate)
        Controls.Add(lblResult)
        Controls.Add(Label4)
        Controls.Add(txtSecondNumber)
        Controls.Add(txtFirstNumber)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
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
    Friend WithEvents btnActivity As Button
    Friend WithEvents Label5 As Label

End Class
