Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Controls

Public Class StudentList
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kim Alfred\source\repos\VotingSystem2\VotingSystem2\bin\Debug\votingSystem.accdb")

    Private Sub StudentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridShow()

    End Sub

    Private Sub datagridShow()
        ' Dim ds As New DataSet
        'Dim dt As New DataTable
        'ds.Tables.Add(dt)
        ' Dim Da As New OleDbDataAdapter

        ' Da = New OleDbDataAdapter("select * from Student", con)
        ' Da.Fill(dt)

        ' StudentData.DataSource = dt.DefaultView
        'con.Close()

    End Sub

    Private Sub StudentData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentData.CellContentClick

    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged
        con.Open()

        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim Da As New OleDbDataAdapter

        Da = New OleDbDataAdapter("select * from Student where Full_Name like '%" & Guna2TextBox1.Text & "%'", con)
        Da.Fill(dt)

        StudentData.DataSource = dt.DefaultView

        'StudentData.DataSource = dt.DefaultView
        con.Close()

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        If StudentData.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = StudentData.SelectedRows(0).Index
            Dim studentId As String = StudentData.Rows(selectedRowIndex).Cells("Student_id").Value.ToString()

            con.Open()
            Dim command As String
            command = "DELETE FROM Student WHERE Student_id = ?"
            Dim cmd As OleDbCommand = New OleDbCommand(command, con)
            cmd.Parameters.Add(New OleDbParameter("Student_id", CType(studentId, String)))

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            cmd.Dispose()
            con.Close()

            If rowsAffected > 0 Then
                MsgBox("Student Deleted", vbInformation)
                StudentData.Rows.RemoveAt(selectedRowIndex)
            Else
                MsgBox("Failed to delete the student.", vbExclamation)
            End If
        Else
            MsgBox("Please select a row before clicking the delete button.", vbExclamation)
        End If



    End Sub



    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        PrintDocument1.Print()
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.StudentData.Width, Me.StudentData.Height)
        StudentData.DrawToBitmap(bm, New Rectangle(70, 70, Me.StudentData.Width, Me.StudentData.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        addStudent.Show()
    End Sub
End Class