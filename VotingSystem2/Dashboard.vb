Imports System.Data.OleDb
Public Class Dashboard
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kim Alfred\source\repos\VotingSystem2\VotingSystem2\bin\Debug\votingSystem.accdb")
    Private Sub Add2_Click(sender As Object, e As EventArgs) Handles add2.Click
        addStudent.Show()
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            con.Open()

            Dim tableNames As List(Of String) = New List(Of String) From {"Student", "Candidates"}

            For i As Integer = 0 To tableNames.Count - 1
                Dim query As String = "SELECT COUNT(*) FROM " & tableNames(i)
                Using cmd As New OleDbCommand(query, con)
                    Dim rowCount As Integer = CInt(cmd.ExecuteScalar())

                    If i = 0 Then
                        Label2.Text = rowCount.ToString()
                    ElseIf i = 1 Then
                        Label4.Text = rowCount.ToString()
                    End If
                End Using
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblclock.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub lblclock_Click(sender As Object, e As EventArgs) Handles lblclock.Click

    End Sub

    Private Sub Panel12_Paint(sender As Object, e As PaintEventArgs) Handles Panel12.Paint

    End Sub
End Class