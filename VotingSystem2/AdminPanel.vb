Public Class AdminPanel

    Sub childform(ByVal panel As Form)
        Me.panel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Me.panel.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Form1.Show()
        Me.Close()

    End Sub


    Private Sub student_Click(sender As Object, e As EventArgs) Handles student.Click
        childform(StudentList)
    End Sub

    Private Sub candidates1_Click(sender As Object, e As EventArgs) Handles candidates1.Click
        childform(Candidate)
    End Sub

    Private Sub Partylist_Click(sender As Object, e As EventArgs) Handles Partylist.Click
        childform(Party)
    End Sub

    Private Sub results_Click(sender As Object, e As EventArgs) Handles results.Click
        childform(voteResults)

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        childform(Dashboard)
    End Sub




    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class