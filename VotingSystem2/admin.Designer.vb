<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(admin))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Panel1 = New Panel()
        Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Label1 = New Label()
        Button1 = New Button()
        Login = New Guna.UI2.WinForms.Guna2GradientButton()
        passad = New Guna.UI2.WinForms.Guna2TextBox()
        Userad = New Guna.UI2.WinForms.Guna2TextBox()
        Checkbox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(Guna2CirclePictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2CirclePictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Guna2CirclePictureBox1)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(1, 67)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(392, 450)
        Panel1.TabIndex = 1
        ' 
        ' Guna2CirclePictureBox1
        ' 
        Guna2CirclePictureBox1.Image = My.Resources.Resources.logo
        Guna2CirclePictureBox1.ImageRotate = 0F
        Guna2CirclePictureBox1.Location = New Point(110, 38)
        Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox1.Size = New Size(171, 148)
        Guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox1.TabIndex = 0
        Guna2CirclePictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(93, 323)
        Label6.Name = "Label6"
        Label6.Size = New Size(183, 33)
        Label6.TabIndex = 0
        Label6.Text = "Voting System"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(93, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(215, 33)
        Label5.TabIndex = 0
        Label5.Text = "Welcome To The"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(32, 272)
        Label4.Name = "Label4"
        Label4.Size = New Size(337, 33)
        Label4.TabIndex = 0
        Label4.Text = "BSCS Home Room Officer"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Panel2.Controls.Add(Guna2CirclePictureBox3)
        Panel2.Controls.Add(Guna2CirclePictureBox2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(1, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(789, 71)
        Panel2.TabIndex = 2
        ' 
        ' Guna2CirclePictureBox3
        ' 
        Guna2CirclePictureBox3.Image = CType(resources.GetObject("Guna2CirclePictureBox3.Image"), Image)
        Guna2CirclePictureBox3.ImageRotate = 0F
        Guna2CirclePictureBox3.Location = New Point(213, 10)
        Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Guna2CirclePictureBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox3.Size = New Size(64, 58)
        Guna2CirclePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox3.TabIndex = 14
        Guna2CirclePictureBox3.TabStop = False
        ' 
        ' Guna2CirclePictureBox2
        ' 
        Guna2CirclePictureBox2.Image = My.Resources.Resources.taguig_city_university_logo
        Guna2CirclePictureBox2.ImageRotate = 0F
        Guna2CirclePictureBox2.Location = New Point(532, 10)
        Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges3
        Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox2.Size = New Size(59, 58)
        Guna2CirclePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox2.TabIndex = 0
        Guna2CirclePictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(360, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 33)
        Label1.TabIndex = 0
        Label1.Text = "Admin "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(548, 435)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 23)
        Button1.TabIndex = 12
        Button1.Text = "Log in as Student"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        Login.BorderRadius = 10
        Login.CustomBorderColor = Color.White
        Login.CustomizableEdges = CustomizableEdges4
        Login.DisabledState.BorderColor = Color.DarkGray
        Login.DisabledState.CustomBorderColor = Color.DarkGray
        Login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Login.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Login.FillColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Login.FillColor2 = Color.Navy
        Login.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Login.ForeColor = Color.White
        Login.Location = New Point(516, 384)
        Login.Name = "Login"
        Login.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Login.Size = New Size(180, 45)
        Login.TabIndex = 11
        Login.Text = "Login"
        ' 
        ' passad
        ' 
        passad.CustomizableEdges = CustomizableEdges6
        passad.DefaultText = ""
        passad.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        passad.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        passad.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passad.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        passad.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passad.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        passad.ForeColor = Color.Black
        passad.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        passad.Location = New Point(467, 301)
        passad.Name = "passad"
        passad.PasswordChar = ChrW(0)
        passad.PlaceholderText = "Password"
        passad.SelectedText = ""
        passad.ShadowDecoration.CustomizableEdges = CustomizableEdges7
        passad.Size = New Size(270, 36)
        passad.TabIndex = 7
        ' 
        ' Userad
        ' 
        Userad.CustomizableEdges = CustomizableEdges8
        Userad.DefaultText = ""
        Userad.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Userad.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Userad.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Userad.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Userad.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Userad.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Userad.ForeColor = Color.Black
        Userad.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Userad.Location = New Point(467, 196)
        Userad.Name = "Userad"
        Userad.PasswordChar = ChrW(0)
        Userad.PlaceholderText = "Username"
        Userad.SelectedText = ""
        Userad.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        Userad.Size = New Size(270, 36)
        Userad.TabIndex = 8
        ' 
        ' Checkbox1
        ' 
        Checkbox1.AutoSize = True
        Checkbox1.CheckedState.BorderColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        Checkbox1.CheckedState.BorderRadius = 0
        Checkbox1.CheckedState.BorderThickness = 0
        Checkbox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Checkbox1.Location = New Point(548, 343)
        Checkbox1.Name = "Checkbox1"
        Checkbox1.Size = New Size(112, 19)
        Checkbox1.TabIndex = 13
        Checkbox1.Text = "Check Password"
        Checkbox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Checkbox1.UncheckedState.BorderRadius = 0
        Checkbox1.UncheckedState.BorderThickness = 0
        Checkbox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(567, 279)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 19)
        Label3.TabIndex = 9
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(562, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 19)
        Label2.TabIndex = 10
        Label2.Text = "Username"
        ' 
        ' admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(791, 512)
        Controls.Add(Checkbox1)
        Controls.Add(Button1)
        Controls.Add(Login)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(passad)
        Controls.Add(Userad)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "admin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Guna2CirclePictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(Guna2CirclePictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2CirclePictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Login As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents passad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Userad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Checkbox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
