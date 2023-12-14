<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startelec
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
        Label1 = New Label()
        Label2 = New Label()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Panel1 = New Panel()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        startnow = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(12, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(364, 30)
        Label1.TabIndex = 0
        Label1.Text = "BSCS SUPREME STUDENT ELECTION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(29, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 17)
        Label2.TabIndex = 1
        Label2.Text = "End Date"
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.AutoRoundedCorners = True
        Guna2DateTimePicker1.BackColor = Color.White
        Guna2DateTimePicker1.BorderRadius = 17
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges1
        Guna2DateTimePicker1.FillColor = Color.White
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Long
        Guna2DateTimePicker1.Location = New Point(29, 43)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2DateTimePicker1.Size = New Size(334, 36)
        Guna2DateTimePicker1.TabIndex = 2
        Guna2DateTimePicker1.Value = New Date(2023, 11, 1, 20, 24, 42, 0)
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Guna2GradientButton2)
        Panel1.Controls.Add(startnow)
        Panel1.Controls.Add(Guna2TextBox1)
        Panel1.Controls.Add(Guna2ComboBox1)
        Panel1.Controls.Add(Guna2DateTimePicker1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(0, 94)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(389, 315)
        Panel1.TabIndex = 3
        ' 
        ' Guna2GradientButton2
        ' 
        Guna2GradientButton2.BorderRadius = 10
        Guna2GradientButton2.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton2.FillColor = Color.White
        Guna2GradientButton2.FillColor2 = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Guna2GradientButton2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton2.ForeColor = Color.Black
        Guna2GradientButton2.Location = New Point(29, 253)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton2.Size = New Size(138, 45)
        Guna2GradientButton2.TabIndex = 5
        Guna2GradientButton2.Text = "Cancel"
        ' 
        ' startnow
        ' 
        startnow.BorderRadius = 10
        startnow.CustomizableEdges = CustomizableEdges5
        startnow.DisabledState.BorderColor = Color.DarkGray
        startnow.DisabledState.CustomBorderColor = Color.DarkGray
        startnow.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        startnow.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        startnow.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        startnow.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        startnow.FillColor2 = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        startnow.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        startnow.ForeColor = Color.White
        startnow.Location = New Point(225, 253)
        startnow.Name = "startnow"
        startnow.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        startnow.Size = New Size(138, 45)
        startnow.TabIndex = 5
        startnow.Text = "Start Now!"
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderRadius = 5
        Guna2TextBox1.CustomizableEdges = CustomizableEdges7
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(29, 209)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = ""
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2TextBox1.Size = New Size(334, 36)
        Guna2TextBox1.TabIndex = 4
        ' 
        ' Guna2ComboBox1
        ' 
        Guna2ComboBox1.BackColor = Color.Transparent
        Guna2ComboBox1.CustomizableEdges = CustomizableEdges9
        Guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        Guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        Guna2ComboBox1.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2ComboBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2ComboBox1.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        Guna2ComboBox1.ItemHeight = 30
        Guna2ComboBox1.Items.AddRange(New Object() {"Within The Day"})
        Guna2ComboBox1.Location = New Point(29, 137)
        Guna2ComboBox1.Name = "Guna2ComboBox1"
        Guna2ComboBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2ComboBox1.Size = New Size(334, 36)
        Guna2ComboBox1.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(28, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 17)
        Label4.TabIndex = 1
        Label4.Text = "Confirm Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(29, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 1
        Label3.Text = "End Time"
        ' 
        ' startelec
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Blue
        ClientSize = New Size(388, 405)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        ForeColor = SystemColors.ControlText
        Name = "startelec"
        StartPosition = FormStartPosition.CenterScreen
        Text = "StartElection"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents startnow As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
End Class
