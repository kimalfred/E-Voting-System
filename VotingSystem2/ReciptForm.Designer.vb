<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReciptForm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ReciptForm))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Panel1 = New Panel()
        Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Label2 = New Label()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Label5 = New Label()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(Guna2CirclePictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2CirclePictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.GradientInactiveCaption
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(48, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(307, 274)
        Label1.TabIndex = 0
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.Controls.Add(Guna2CirclePictureBox2)
        Panel1.Controls.Add(Guna2CirclePictureBox3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(1, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(395, 80)
        Panel1.TabIndex = 1
        ' 
        ' Guna2CirclePictureBox2
        ' 
        Guna2CirclePictureBox2.Image = My.Resources.Resources.taguig_city_university_logo
        Guna2CirclePictureBox2.ImageRotate = 0F
        Guna2CirclePictureBox2.Location = New Point(304, 10)
        Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Guna2CirclePictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges1
        Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox2.Size = New Size(62, 56)
        Guna2CirclePictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox2.TabIndex = 3
        Guna2CirclePictureBox2.TabStop = False
        ' 
        ' Guna2CirclePictureBox3
        ' 
        Guna2CirclePictureBox3.Image = CType(resources.GetObject("Guna2CirclePictureBox3.Image"), Image)
        Guna2CirclePictureBox3.ImageRotate = 0F
        Guna2CirclePictureBox3.Location = New Point(32, 10)
        Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Guna2CirclePictureBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CirclePictureBox3.Size = New Size(64, 56)
        Guna2CirclePictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        Guna2CirclePictureBox3.TabIndex = 2
        Guna2CirclePictureBox3.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(119, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 31)
        Label2.TabIndex = 0
        Label2.Text = "Vote Receipt"
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.BorderRadius = 10
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges3
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.Navy
        Guna2GradientButton1.FillColor2 = Color.Blue
        Guna2GradientButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.Location = New Point(106, 548)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton1.Size = New Size(186, 45)
        Guna2GradientButton1.TabIndex = 2
        Guna2GradientButton1.Text = "Close"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2HtmlLabel1.Location = New Point(73, 129)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(3, 2)
        Guna2HtmlLabel1.TabIndex = 3
        Guna2HtmlLabel1.Text = Nothing
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(60, 462)
        Label5.Name = "Label5"
        Label5.Size = New Size(282, 61)
        Label5.TabIndex = 8
        Label5.Text = "Your Vote Has Been Recorded, Thanks For Voting!!!"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(48, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(334, 54)
        Label3.TabIndex = 9
        ' 
        ' ReciptForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 616)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "ReciptForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ReciptForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Guna2CirclePictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2CirclePictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
