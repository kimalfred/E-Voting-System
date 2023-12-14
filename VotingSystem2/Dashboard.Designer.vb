<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Panel3 = New Panel()
        Label3 = New Label()
        Label7 = New Label()
        Panel11 = New Panel()
        IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Panel2 = New Panel()
        Label4 = New Label()
        Label9 = New Label()
        Panel12 = New Panel()
        IconPictureBox7 = New FontAwesome.Sharp.IconPictureBox()
        Panel13 = New Panel()
        add2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Label10 = New Label()
        IconPictureBox8 = New FontAwesome.Sharp.IconPictureBox()
        Panel14 = New Panel()
        Label2 = New Label()
        Label11 = New Label()
        Panel15 = New Panel()
        IconPictureBox9 = New FontAwesome.Sharp.IconPictureBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        lblclock = New Label()
        Timer1 = New Timer(components)
        Panel3.SuspendLayout()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(IconPictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel13.SuspendLayout()
        CType(IconPictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel14.SuspendLayout()
        CType(IconPictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(149, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 55)
        Label1.TabIndex = 1
        Label1.Text = "Dashboard"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Blue
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Panel11)
        Panel3.Controls.Add(IconPictureBox5)
        Panel3.Location = New Point(150, 305)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(285, 137)
        Panel3.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(36, 4)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 56)
        Label3.TabIndex = 3
        Label3.Text = "2"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(3, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 20)
        Label7.TabIndex = 2
        Label7.Text = "Total no. of Parties"
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel11.Location = New Point(0, 116)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(284, 20)
        Panel11.TabIndex = 1
        ' 
        ' IconPictureBox5
        ' 
        IconPictureBox5.BackColor = Color.Blue
        IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup
        IconPictureBox5.IconColor = Color.White
        IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox5.IconSize = 91
        IconPictureBox5.Location = New Point(187, -1)
        IconPictureBox5.Name = "IconPictureBox5"
        IconPictureBox5.Size = New Size(96, 91)
        IconPictureBox5.TabIndex = 0
        IconPictureBox5.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Blue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Panel12)
        Panel2.Controls.Add(IconPictureBox7)
        Panel2.Location = New Point(504, 145)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(286, 137)
        Panel2.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(53, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 58)
        Label4.TabIndex = 3
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(-1, 93)
        Label9.Name = "Label9"
        Label9.Size = New Size(165, 20)
        Label9.TabIndex = 2
        Label9.Text = "Total no. of Candidates"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel12.Location = New Point(0, 116)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(285, 20)
        Panel12.TabIndex = 1
        ' 
        ' IconPictureBox7
        ' 
        IconPictureBox7.BackColor = Color.Blue
        IconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.UserCheck
        IconPictureBox7.IconColor = Color.White
        IconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox7.IconSize = 91
        IconPictureBox7.Location = New Point(191, -1)
        IconPictureBox7.Name = "IconPictureBox7"
        IconPictureBox7.Size = New Size(94, 91)
        IconPictureBox7.TabIndex = 0
        IconPictureBox7.TabStop = False
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.Blue
        Panel13.BorderStyle = BorderStyle.FixedSingle
        Panel13.Controls.Add(add2)
        Panel13.Controls.Add(Label10)
        Panel13.Controls.Add(IconPictureBox8)
        Panel13.Location = New Point(505, 305)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(285, 137)
        Panel13.TabIndex = 10
        ' 
        ' add2
        ' 
        add2.CustomizableEdges = CustomizableEdges1
        add2.DisabledState.BorderColor = Color.DarkGray
        add2.DisabledState.CustomBorderColor = Color.DarkGray
        add2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        add2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        add2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        add2.FillColor = Color.Navy
        add2.FillColor2 = Color.Blue
        add2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        add2.ForeColor = Color.White
        add2.Location = New Point(-1, 107)
        add2.Name = "add2"
        add2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        add2.Size = New Size(285, 29)
        add2.TabIndex = 3
        add2.Text = "Upload Student"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(26, 33)
        Label10.Name = "Label10"
        Label10.Size = New Size(126, 48)
        Label10.TabIndex = 2
        Label10.Text = "Add Student " & vbCrLf & "     Data"
        ' 
        ' IconPictureBox8
        ' 
        IconPictureBox8.BackColor = Color.Blue
        IconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.Add
        IconPictureBox8.IconColor = Color.White
        IconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox8.IconSize = 90
        IconPictureBox8.Location = New Point(192, -1)
        IconPictureBox8.Name = "IconPictureBox8"
        IconPictureBox8.Size = New Size(92, 90)
        IconPictureBox8.TabIndex = 0
        IconPictureBox8.TabStop = False
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.Blue
        Panel14.BorderStyle = BorderStyle.FixedSingle
        Panel14.Controls.Add(Label2)
        Panel14.Controls.Add(Label11)
        Panel14.Controls.Add(Panel15)
        Panel14.Controls.Add(IconPictureBox9)
        Panel14.Location = New Point(149, 145)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(285, 137)
        Panel14.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(37, 25)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 58)
        Label2.TabIndex = 3
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.White
        Label11.Location = New Point(-1, 93)
        Label11.Name = "Label11"
        Label11.Size = New Size(149, 20)
        Label11.TabIndex = 2
        Label11.Text = "Total no. of Students"
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Panel15.Location = New Point(0, 116)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(285, 20)
        Panel15.TabIndex = 1
        ' 
        ' IconPictureBox9
        ' 
        IconPictureBox9.BackColor = Color.Blue
        IconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.User
        IconPictureBox9.IconColor = Color.White
        IconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox9.IconSize = 91
        IconPictureBox9.Location = New Point(190, -1)
        IconPictureBox9.Name = "IconPictureBox9"
        IconPictureBox9.Size = New Size(94, 91)
        IconPictureBox9.TabIndex = 0
        IconPictureBox9.TabStop = False
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 10
        Guna2Button1.CustomizableEdges = CustomizableEdges3
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Red
        Guna2Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button1.ForeColor = Color.Black
        Guna2Button1.Location = New Point(373, 476)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button1.Size = New Size(164, 44)
        Guna2Button1.TabIndex = 12
        Guna2Button1.Text = "Refresh"
        ' 
        ' lblclock
        ' 
        lblclock.AutoSize = True
        lblclock.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point)
        lblclock.Location = New Point(492, 77)
        lblclock.Name = "lblclock"
        lblclock.Size = New Size(315, 65)
        lblclock.TabIndex = 13
        lblclock.Text = "12:00:00 AM"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(915, 612)
        Controls.Add(lblclock)
        Controls.Add(Guna2Button1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel13)
        Controls.Add(Panel14)
        Controls.Add(Label1)
        Name = "Dashboard"
        Text = "Dashboard"
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(IconPictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IconPictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        CType(IconPictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel14.ResumeLayout(False)
        Panel14.PerformLayout()
        CType(IconPictureBox9, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents IconPictureBox7 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents add2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label10 As Label
    Friend WithEvents IconPictureBox8 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel15 As Panel
    Friend WithEvents IconPictureBox9 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblclock As Label
    Friend WithEvents Timer1 As Timer
End Class
