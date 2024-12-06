Public Class Dashboard

    Private Sub Panel5_paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Sub switchpanel(ByVal panel As Form)
        Panel5.Controls.Clear() 'Clear existing controls in Panel 3
        panel.TopLevel = False 'Treat the form as a control
        panel.FormBorderStyle = FormBorderStyle.None 'Remove border and title bar
        panel.Dock = DockStyle.Fill 'Fill the entire panel3 Area
        Panel5.Controls.Add(panel) 'Add the form to panel3
        panel.Show() 'Display the embedded form
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Automatically load DashboardAccess form
        Dim dashboardAccess As New DashboardAccess()
        switchpanel(dashboardAccess)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        switchpanel(DashboardAccess)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchpanel(Achievelist)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchpanel(List)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchpanel(Stats)
    End Sub
End Class