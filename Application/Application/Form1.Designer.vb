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
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        link_SignUp = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 24F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(266, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 45)
        Label1.TabIndex = 0
        Label1.Text = "Welcome"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(155, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(289, 135)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(148, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(155, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 28)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(289, 181)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(148, 23)
        TextBox2.TabIndex = 4
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(304, 252)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' link_SignUp
        ' 
        link_SignUp.AutoSize = True
        link_SignUp.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        link_SignUp.LinkColor = Color.Red
        link_SignUp.Location = New Point(167, 303)
        link_SignUp.Name = "link_SignUp"
        link_SignUp.Size = New Size(321, 25)
        link_SignUp.TabIndex = 7
        link_SignUp.TabStop = True
        link_SignUp.Text = "Don't have an account, Sign Up now!"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(695, 476)
        Controls.Add(link_SignUp)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents link_SignUp As LinkLabel

End Class
