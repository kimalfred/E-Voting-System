Public Class studentpanel

    Sub childform(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel3.Controls.Add(panel)
        panel.Show()


    End Sub
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        childform(CandidateInfo)
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        childform(Partylist)
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        childform(vote)

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub studentpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class