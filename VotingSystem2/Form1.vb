Imports System.Data.OleDb
Public Class Form1
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kim Alfred\source\repos\VotingSystem2\VotingSystem2\bin\Debug\votingSystem.accdb")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admin.Show()
        Me.Hide()

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Try
            con.Open()
            Dim query As String = "SELECT * FROM Student WHERE Email = @userParam AND Student_id = @passParam"
            Dim myacc As New OleDbCommand(query, con)
            myacc.Parameters.AddWithValue("@userParam", studid.Text)
            myacc.Parameters.AddWithValue("@passParam", pass.Text)

            Dim reader As OleDbDataReader = myacc.ExecuteReader()
            Dim studentID As String = ""
            Dim email As String = ""

            If reader.Read() Then
                If Not IsDBNull(reader("donevote")) AndAlso CBool(reader("donevote")) = False Then
                    studentID = reader("Student_id").ToString()
                    email = reader("Email").ToString()
                    MsgBox("Login Successful!")
                    vote.Label15.Text = studentID
                    vote.Label17.Text = email
                    studentpanel.Label4.Text = studentID
                    studentpanel.Label8.Text = email
                    ReciptForm.Label3.Text = email
                    studentpanel.Show()
                    Me.Hide()
                Else
                    MsgBox("You have already voted and cannot log in again.")
                End If
            Else
                MsgBox("Account not found")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pass.UseSystemPasswordChar = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Checkbox1_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox1.CheckedChanged
        If Checkbox1.CheckState = CheckState.Checked Then
            pass.UseSystemPasswordChar = False
        Else
            pass.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
