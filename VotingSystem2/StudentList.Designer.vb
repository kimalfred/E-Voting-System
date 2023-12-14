<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentList
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(StudentList))
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        TabPage1 = New TabPage()
        StudentData = New DataGridView()
        TabPage2 = New TabPage()
        Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Guna2TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(StudentData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2TabControl1
        ' 
        Guna2TabControl1.Controls.Add(TabPage1)
        Guna2TabControl1.Controls.Add(TabPage2)
        Guna2TabControl1.ItemSize = New Size(180, 40)
        Guna2TabControl1.Location = New Point(53, 94)
        Guna2TabControl1.Name = "Guna2TabControl1"
        Guna2TabControl1.SelectedIndex = 0
        Guna2TabControl1.Size = New Size(877, 502)
        Guna2TabControl1.TabButtonHoverState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonHoverState.FillColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        Guna2TabControl1.TabButtonHoverState.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TabControl1.TabButtonHoverState.ForeColor = Color.White
        Guna2TabControl1.TabButtonHoverState.InnerColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        Guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonIdleState.FillColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2TabControl1.TabButtonIdleState.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(CByte(156), CByte(160), CByte(167))
        Guna2TabControl1.TabButtonIdleState.InnerColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2TabControl1.TabButtonSelectedState.BorderColor = Color.Empty
        Guna2TabControl1.TabButtonSelectedState.FillColor = Color.FromArgb(CByte(29), CByte(37), CByte(49))
        Guna2TabControl1.TabButtonSelectedState.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TabControl1.TabButtonSelectedState.ForeColor = Color.White
        Guna2TabControl1.TabButtonSelectedState.InnerColor = Color.FromArgb(CByte(76), CByte(132), CByte(255))
        Guna2TabControl1.TabButtonSize = New Size(180, 40)
        Guna2TabControl1.TabIndex = 0
        Guna2TabControl1.TabMenuBackColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Gray
        TabPage1.Controls.Add(StudentData)
        TabPage1.Location = New Point(4, 44)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(869, 454)
        TabPage1.TabIndex = 0
        TabPage1.Text = "BSCS A2022"
        ' 
        ' StudentData
        ' 
        StudentData.BackgroundColor = SystemColors.ControlLightLight
        StudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentData.Location = New Point(89, 3)
        StudentData.Name = "StudentData"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        StudentData.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        StudentData.RowTemplate.Height = 25
        StudentData.Size = New Size(702, 451)
        StudentData.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 44)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(869, 454)
        TabPage2.TabIndex = 1
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Guna2TextBox1
        ' 
        Guna2TextBox1.BorderRadius = 20
        Guna2TextBox1.CustomizableEdges = CustomizableEdges1
        Guna2TextBox1.DefaultText = ""
        Guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Guna2TextBox1.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2TextBox1.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2TextBox1.Location = New Point(486, 47)
        Guna2TextBox1.Name = "Guna2TextBox1"
        Guna2TextBox1.PasswordChar = ChrW(0)
        Guna2TextBox1.PlaceholderText = "Search Student Name:"
        Guna2TextBox1.SelectedText = ""
        Guna2TextBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2TextBox1.Size = New Size(438, 41)
        Guna2TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(375, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 32)
        Label1.TabIndex = 3
        Label1.Text = "Student Voter List "
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
        Guna2GradientButton2.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Guna2GradientButton2.FillColor2 = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Guna2GradientButton2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton2.ForeColor = Color.White
        Guna2GradientButton2.Location = New Point(342, 47)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton2.Size = New Size(138, 41)
        Guna2GradientButton2.TabIndex = 8
        Guna2GradientButton2.Text = "Print"
        ' 
        ' Guna2GradientButton1
        ' 
        Guna2GradientButton1.BorderRadius = 10
        Guna2GradientButton1.CustomizableEdges = CustomizableEdges5
        Guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton1.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Guna2GradientButton1.FillColor2 = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Guna2GradientButton1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton1.ForeColor = Color.White
        Guna2GradientButton1.Location = New Point(197, 47)
        Guna2GradientButton1.Name = "Guna2GradientButton1"
        Guna2GradientButton1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2GradientButton1.Size = New Size(138, 41)
        Guna2GradientButton1.TabIndex = 7
        Guna2GradientButton1.Text = "Delete"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Guna2GradientButton3
        ' 
        Guna2GradientButton3.BorderRadius = 10
        Guna2GradientButton3.CustomizableEdges = CustomizableEdges7
        Guna2GradientButton3.DisabledState.BorderColor = Color.DarkGray
        Guna2GradientButton3.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2GradientButton3.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton3.DisabledState.FillColor2 = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2GradientButton3.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2GradientButton3.FillColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        Guna2GradientButton3.FillColor2 = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        Guna2GradientButton3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2GradientButton3.ForeColor = Color.White
        Guna2GradientButton3.Location = New Point(53, 47)
        Guna2GradientButton3.Name = "Guna2GradientButton3"
        Guna2GradientButton3.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2GradientButton3.Size = New Size(138, 41)
        Guna2GradientButton3.TabIndex = 9
        Guna2GradientButton3.Text = "Add"
        ' 
        ' StudentList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(976, 594)
        Controls.Add(Guna2GradientButton3)
        Controls.Add(Guna2GradientButton2)
        Controls.Add(Guna2GradientButton1)
        Controls.Add(Label1)
        Controls.Add(Guna2TextBox1)
        Controls.Add(Guna2TabControl1)
        Name = "StudentList"
        Text = "StudentList"
        Guna2TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(StudentData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StudentData As DataGridView
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2vScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
End Class
