Imports FontAwesome.Sharp
Imports System.Data.OleDb
Imports System.Text

Public Class vote
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kim Alfred\source\repos\VotingSystem2\VotingSystem2\bin\Debug\votingSystem.accdb")



    Private Sub RadioButton_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton4.Click
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        pres.Text = radioButton.Text
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton6.Click, RadioButton7.Click, RadioButton8.Click
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        vp.Text = radioButton.Text
    End Sub
    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton9.Click, RadioButton10.Click, RadioButton11.Click, RadioButton12.Click
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        Sec.Text = radioButton.Text
    End Sub
    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton14.Click, RadioButton15.Click, RadioButton16.Click
        Dim radiobutton As RadioButton = DirectCast(sender, RadioButton)
        Audi.Text = radiobutton.Text
    End Sub
    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton18.Click, RadioButton19.Click, RadioButton20.Click
        Dim radioButton As RadioButton = DirectCast(sender, RadioButton)
        PIO.Text = radioButton.Text
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Try
            Dim allRadioButtonsSelected As Boolean = True

            allRadioButtonsSelected = allRadioButtonsSelected And CountVotesForPosition("President", Panel3)
            allRadioButtonsSelected = allRadioButtonsSelected And CountVotesForPosition("Vice President", Panel5)
            allRadioButtonsSelected = allRadioButtonsSelected And CountVotesForPosition("Secretary", Panel7)
            allRadioButtonsSelected = allRadioButtonsSelected And CountVotesForPosition("Auditor", Panel9)
            allRadioButtonsSelected = allRadioButtonsSelected And CountVotesForPosition("P.I.O", Panel11)

            UpdateDoneVote()

            Dim receipt As New ReciptForm()
            Dim email As String = studentpanel.Label8.Text()

            If allRadioButtonsSelected Then
                MessageBox.Show("Thankyou For Voting.")
                Dim selectedCandidates As String = GetSelectedCandidates()
                receipt.SelectedCandidates = selectedCandidates
                receipt.Label3.Text = email
                receipt.Show()
                studentpanel.Hide()
            Else
                MessageBox.Show("Please select a candidate for each position before submitting.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Function GetSelectedCandidates() As String
        Dim selectedCandidates As New StringBuilder()

        selectedCandidates.AppendLine("President: " & GetSelectedCandidate(Panel3))
        selectedCandidates.AppendLine("Vice-President: " & GetSelectedCandidate(Panel5))
        selectedCandidates.AppendLine("Secretary: " & GetSelectedCandidate(Panel7))
        selectedCandidates.AppendLine("Auditor: " & GetSelectedCandidate(Panel9))
        selectedCandidates.AppendLine("PIO: " & GetSelectedCandidate(Panel11))

        Return selectedCandidates.ToString()
    End Function

    Private Function CountVotesForPosition(position As String, panel As Panel) As Boolean
        Dim selectedCandidate As String = GetSelectedCandidate(panel)

        If Not String.IsNullOrEmpty(selectedCandidate) Then
            ' Update the vote count in the database.
            UpdateVoteCount(position, selectedCandidate)
            Return True ' A candidate was selected for this position.
        Else
            Return False ' No candidate was selected for this position.
        End If
    End Function

    Private Function GetSelectedCandidate(panel As Panel) As String

        For Each control As Control In panel.Controls
            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)
                If radioButton.Checked Then
                    Return radioButton.Text
                End If
            End If
        Next


        Return ""
    End Function
    Private Sub UpdateVoteCount(position As String, candidateName As String)

        con.Open()
        Dim query As String = "update [Candidates] set [VoteCount] = VoteCount + 1 WHERE Position =@Position AND Fullname = @FullName"
        Using cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("@Position", position)
            cmd.Parameters.AddWithValue("@FullName", candidateName)
            cmd.ExecuteNonQuery()

            con.Close()
        End Using
    End Sub
    Private Sub UpdateDoneVote()
        con.Open()
        Dim query As String = "update [Student] set [DoneVote] = @donevote WHERE Student_id = @StudentID"

        Using cmd As New OleDbCommand(query, con)
            cmd.Parameters.AddWithValue("@donevote", True)
            cmd.Parameters.AddWithValue("@StudentID", Label15.Text)

            cmd.ExecuteNonQuery()
        End Using

        con.Close()
    End Sub


    Private Sub PIO_Click(sender As Object, e As EventArgs) Handles PIO.Click

    End Sub

    Private Sub Audi_Click(sender As Object, e As EventArgs) Handles Audi.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub vote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblclocks2.Text = DateTime.Now.ToString("hh:mm:ss tt") 'Time with AM/PM
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
End Class