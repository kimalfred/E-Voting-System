Imports System.Data.OleDb
Imports FontAwesome.Sharp


Public Class addStudent
    Private con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Kim Alfred\source\repos\VotingSystem2\VotingSystem2\bin\Debug\votingSystem.accdb")




    'The color and the width of the border.
    Private borderColor As Color = Color.MidnightBlue
    Private borderWidth As Integer = 3
    'The color and region of the header.
    Private headerColor As Color = Color.MidnightBlue
    Private headerRect As Rectangle
    'The region of the client.
    Private clientRect As Rectangle
    'The region of the title text.
    Private titleRect As Rectangle
    'The region of the minimum button.
    Private miniBoxRect As Rectangle
    'The region of the maximum button.
    Private maxBoxRect As Rectangle
    'The region of the close button.
    Private closeBoxRect As Rectangle
    'The states of the three header buttons.
    Private miniState As ButtonState
    Private maxState As ButtonState
    Private closeState As ButtonState
    'Store the mouse down point to handle moving the form.
    Private x As Integer = 0
    Private y As Integer = 0
    'The height of the header.
    Const HEADER_HEIGHT As Integer = 25
    'The size of the header buttons.
    ReadOnly BUTTON_BOX_SIZE As Size = New Size(15, 15)


    Private Sub CustomBorderColorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Hide the border and the title bar.
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
    End Sub

    Private Sub CustomBorderColorForm_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Draw the header.
        Using b As Brush = New SolidBrush(borderColor)
            e.Graphics.FillRectangle(b, headerRect)
        End Using
        'Draw the title text
        Using b As Brush = New SolidBrush(Me.ForeColor)
            e.Graphics.DrawString(Me.Text, Me.Font, b, titleRect)
        End Using
        'Draw the header buttons.
        If Me.MinimizeBox Then
            ControlPaint.DrawCaptionButton(e.Graphics, miniBoxRect, CaptionButton.Minimize, miniState)
        End If
        If Me.MinimizeBox Then
            ControlPaint.DrawCaptionButton(e.Graphics, maxBoxRect, CaptionButton.Maximize, maxState)
        End If
        If Me.MinimizeBox Then
            ControlPaint.DrawCaptionButton(e.Graphics, closeBoxRect, CaptionButton.Close, closeState)
        End If
        'Draw the border.
        ControlPaint.DrawBorder(e.Graphics, clientRect, borderColor,
            borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub

    'Handle resize to adjust the region ot border, header and so on.
    Private Sub CustomBorderColorForm_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        headerRect = New Rectangle(Me.ClientRectangle.Location, New Size(Me.ClientRectangle.Width, HEADER_HEIGHT))
        clientRect = New Rectangle(New Point(Me.ClientRectangle.Location.X, Me.ClientRectangle.Y + HEADER_HEIGHT),
            New Point(Me.ClientRectangle.Width, Me.ClientRectangle.Height - HEADER_HEIGHT))
        Dim yOffset = (headerRect.Height + borderWidth - BUTTON_BOX_SIZE.Height) / 2
        titleRect = New Rectangle(yOffset, yOffset,
                                Me.ClientRectangle.Width - 3 * (BUTTON_BOX_SIZE.Width + 1) - yOffset,
                                BUTTON_BOX_SIZE.Height)
        miniBoxRect = New Rectangle(Me.ClientRectangle.Width - 3 * (BUTTON_BOX_SIZE.Width + 1),
                                    yOffset, BUTTON_BOX_SIZE.Width, BUTTON_BOX_SIZE.Height)
        maxBoxRect = New Rectangle(Me.ClientRectangle.Width - 2 * (BUTTON_BOX_SIZE.Width + 1),
                                    yOffset, BUTTON_BOX_SIZE.Width, BUTTON_BOX_SIZE.Height)
        closeBoxRect = New Rectangle(Me.ClientRectangle.Width - 1 * (BUTTON_BOX_SIZE.Width + 1),
                                    yOffset, BUTTON_BOX_SIZE.Width, BUTTON_BOX_SIZE.Height)
        Me.Invalidate()
    End Sub


    Private Sub CustomBorderColorForm_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        'Start to move the form.
        If (titleRect.Contains(e.Location)) Then
            x = e.X
            y = e.Y
        End If

        'Check and press the header buttons.
        Dim mousePos As Point = Me.PointToClient(Control.MousePosition)
        If (miniBoxRect.Contains(mousePos)) Then
            miniState = ButtonState.Pushed
        ElseIf (maxBoxRect.Contains(mousePos)) Then
            maxState = ButtonState.Pushed
        ElseIf (closeBoxRect.Contains(mousePos)) Then
            closeState = ButtonState.Pushed
        End If

    End Sub

    Private Sub CustomBorderColorForm_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Move and refresh.
        If (x <> 0 And y <> 0) Then
            Me.Location = New Point(Me.Left + e.X - x, Me.Top + e.Y - y)
            Me.Refresh()
        End If

    End Sub

    Private Sub CustomBorderColorForm_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        'Reset the mouse point.
        x = 0
        y = 0

        'Check the button states and modify the window state.
        If miniState = ButtonState.Pushed Then
            Me.WindowState = FormWindowState.Minimized
            miniState = ButtonState.Normal
        ElseIf maxState = ButtonState.Pushed Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
                maxState = ButtonState.Checked
            Else
                Me.WindowState = FormWindowState.Normal
                maxState = ButtonState.Normal
            End If
        ElseIf closeState = ButtonState.Pushed Then
            Me.Close()
        End If

    End Sub

    'Handle this event to maxmize/normalize the form via double clicking the title bar.
    Private Sub CustomBorderColorForm_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDoubleClick
        If (titleRect.Contains(e.Location)) Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
                maxState = ButtonState.Checked
            Else
                Me.WindowState = FormWindowState.Normal
                maxState = ButtonState.Normal
            End If
        End If
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        If String.IsNullOrEmpty(id.Text) OrElse String.IsNullOrEmpty(email.Text) OrElse String.IsNullOrEmpty(Fname.Text) OrElse String.IsNullOrEmpty(year.Text) OrElse String.IsNullOrEmpty(CS.Text) Then
            MsgBox("Please fill in all fields before adding a student.", vbExclamation)
        Else
            con.Open()
            Dim command As String
            command = "INSERT INTO Student VALUES (?, ?, ?, ?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(command, con)
            cmd.Parameters.Add(New OleDbParameter("Student_id", CType(id.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Email", CType(email.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Full_Name", CType(Fname.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Level", CType(year.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("CourseSection", CType(CS.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("DoneVote", CType(False, Boolean)))


            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            MsgBox("Student Added", vbInformation)
            id.Clear()
            email.Clear()
            Fname.Clear()
        End If


    End Sub

    Private Sub year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles year.SelectedIndexChanged

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        clear()
    End Sub
    Sub clear()
        id.Clear()
        email.Clear()
        Fname.Clear()

    End Sub
End Class