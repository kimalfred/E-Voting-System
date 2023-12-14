<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudent
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
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        id = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Fname = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        year = New Guna.UI2.WinForms.Guna2ComboBox()
        CS = New Guna.UI2.WinForms.Guna2ComboBox()
        Label4 = New Label()
        submit = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        email = New Guna.UI2.WinForms.Guna2TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' id
        ' 
        id.BorderRadius = 5
        CustomizableEdges1.TopLeft = False
        CustomizableEdges1.TopRight = False
        id.CustomizableEdges = CustomizableEdges1
        id.DefaultText = ""
        id.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        id.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        id.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        id.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        id.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        id.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        id.HoverState.BorderColor = Color.Navy
        id.HoverState.PlaceholderForeColor = Color.Navy
        id.Location = New Point(22, 76)
        id.Name = "id"
        id.PasswordChar = ChrW(0)
        id.PlaceholderText = "e.g 22-0057"
        id.SelectedText = ""
        id.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        id.Size = New Size(332, 36)
        id.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(22, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 1
        Label1.Text = "Student ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(20, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 3
        Label2.Text = "Full Name:"
        ' 
        ' Fname
        ' 
        Fname.BorderRadius = 5
        CustomizableEdges3.TopLeft = False
        CustomizableEdges3.TopRight = False
        Fname.CustomizableEdges = CustomizableEdges3
        Fname.DefaultText = ""
        Fname.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Fname.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Fname.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Fname.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Fname.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Fname.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Fname.HoverState.BorderColor = Color.Navy
        Fname.HoverState.PlaceholderForeColor = Color.Navy
        Fname.Location = New Point(20, 206)
        Fname.Name = "Fname"
        Fname.PasswordChar = ChrW(0)
        Fname.PlaceholderText = "Firstname, M.I, Lastname"
        Fname.SelectedText = ""
        Fname.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Fname.Size = New Size(332, 36)
        Fname.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(22, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 3
        Label3.Text = "Year Level:"
        ' 
        ' year
        ' 
        year.BackColor = Color.Transparent
        year.CustomizableEdges = CustomizableEdges5
        year.DrawMode = DrawMode.OwnerDrawFixed
        year.DropDownStyle = ComboBoxStyle.DropDownList
        year.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        year.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        year.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        year.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        year.ItemHeight = 30
        year.Items.AddRange(New Object() {"2nd Year", "3rd Year", "4th Year"})
        year.Location = New Point(20, 277)
        year.Name = "year"
        year.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        year.Size = New Size(332, 36)
        year.TabIndex = 4
        ' 
        ' CS
        ' 
        CS.BackColor = Color.Transparent
        CS.CustomizableEdges = CustomizableEdges7
        CS.DrawMode = DrawMode.OwnerDrawFixed
        CS.DropDownStyle = ComboBoxStyle.DropDownList
        CS.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        CS.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        CS.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        CS.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        CS.ItemHeight = 30
        CS.Items.AddRange(New Object() {"BSCS A2022"})
        CS.Location = New Point(20, 349)
        CS.Name = "CS"
        CS.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        CS.Size = New Size(332, 36)
        CS.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(22, 326)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 20)
        Label4.TabIndex = 5
        Label4.Text = "Course and Section"
        ' 
        ' submit
        ' 
        submit.BorderRadius = 10
        submit.CustomizableEdges = CustomizableEdges9
        submit.DisabledState.BorderColor = Color.DarkGray
        submit.DisabledState.CustomBorderColor = Color.DarkGray
        submit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        submit.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        submit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        submit.FillColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        submit.FillColor2 = Color.Navy
        submit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        submit.ForeColor = Color.White
        submit.Location = New Point(185, 400)
        submit.Name = "submit"
        submit.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        submit.Size = New Size(109, 44)
        submit.TabIndex = 0
        submit.Text = "Submit"
        ' 
        ' Guna2GradientButton2
        ' 
        Guna2GradientButton2.BorderRadius = 10
        Guna2GradientButton2.CustomizableEdges = CustomizableEdges11
        Guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton2.FillColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Guna2GradientButton2.FillColor2 = Color.Gray
        Guna2GradientButton2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton2.ForeColor = Color.Black
        Guna2GradientButton2.Location = New Point(70, 400)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2GradientButton2.Size = New Size(109, 44)
        Guna2GradientButton2.TabIndex = 0
        Guna2GradientButton2.Text = "Clear"
        ' 
        ' email
        ' 
        email.BorderRadius = 5
        CustomizableEdges13.TopLeft = False
        CustomizableEdges13.TopRight = False
        email.CustomizableEdges = CustomizableEdges13
        email.DefaultText = ""
        email.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        email.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        email.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        email.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        email.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        email.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        email.HoverState.BorderColor = Color.Navy
        email.HoverState.PlaceholderForeColor = Color.Navy
        email.Location = New Point(20, 144)
        email.Name = "email"
        email.PasswordChar = ChrW(0)
        email.PlaceholderText = "e.g yourname@gmail.com"
        email.SelectedText = ""
        email.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        email.Size = New Size(332, 36)
        email.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(22, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 20)
        Label5.TabIndex = 3
        Label5.Text = "Email:"
        ' 
        ' addStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(376, 478)
        Controls.Add(Guna2GradientButton2)
        Controls.Add(submit)
        Controls.Add(CS)
        Controls.Add(Label4)
        Controls.Add(year)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(email)
        Controls.Add(Fname)
        Controls.Add(Label1)
        Controls.Add(id)
        Name = "addStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addStudent"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents id As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents year As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CS As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents submit As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
