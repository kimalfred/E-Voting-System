Imports System.Data.OleDb
Public Class admin
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kim Alfred\source\repos\VotingSystem2\VotingSystem2\bin\Debug\votingSystem.accdb")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Try
            con.Open()
            Dim query As String = "SELECT * FROM Admin WHERE Username = ? AND Password = ?"
            Dim myacc As New OleDbCommand(query, con)
            myacc.Parameters.AddWithValue("userParam", Userad.Text)
            myacc.Parameters.AddWithValue("passParam", passad.Text)

            Dim reader As OleDbDataReader = myacc.ExecuteReader()



            If reader.Read() Then
                MsgBox("Login Successful!")
                AdminPanel.Show()
                Me.Hide()
            Else
                MsgBox("Account not found")
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passad.UseSystemPasswordChar = True
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox1.CheckedChanged
        If Checkbox1.CheckState = CheckState.Checked Then
            passad.UseSystemPasswordChar = False
        Else
            passad.UseSystemPasswordChar = True

        End If
    End Sub

End Class