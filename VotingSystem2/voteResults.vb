Imports System.Data.OleDb
Imports Guna.UI2.WinForms

Public Class voteResults
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kim Alfred\source\repos\VotingSystem2\VotingSystem2\bin\Debug\votingSystem.accdb")
    Private Sub voteResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridShow1()
    End Sub

    Private Sub datagridShow1()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim Da As New OleDbDataAdapter


        Da = New OleDbDataAdapter("select * from Candidates", con)
        Da.Fill(dt)


        DataGridView1.DataSource = dt.DefaultView
        con.Close()

    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        con.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim Da As New OleDbDataAdapter

        Da = New OleDbDataAdapter("Select * from Candidates where Fullname Like '%" & search.Text & "%'", con)
        Da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

        'StudentData.DataSource = dt.DefaultView
        con.Close()

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        PrintDocument1.Print()
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(70, 70, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class