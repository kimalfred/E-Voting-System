Imports System.Net
Imports System.Net.Mail

Public Class ReciptForm

    Public WriteOnly Property SelectedCandidates As String
        Set(value As String)
            Label1.Text = value
        End Set
    End Property

    Private Sub ReciptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Dim toEmail As String = Label3.Text
        Dim messageBody As String = Label5.Text
        Dim receipt As String = Label1.Text
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress("kvillaruel245@gmail.com")
            mail.To.Add(toEmail)
            mail.Subject = "BSCS-A2022 Homeroom E-Voting"
            mail.Body = messageBody
            mail.Body = receipt

            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            smtpServer.Port = 587
            smtpServer.Credentials = New NetworkCredential("kvillaruel245@gmail.com", "ydbu xmve bzkb zucn")
            smtpServer.EnableSsl = True

            smtpServer.Send(mail)

            MsgBox("Email sent successfully!")

        Catch ex As Exception
            MsgBox("Error sending email: " & ex.Message)
        End Try

        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

End Class

