<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voteResults
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(voteResults))
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        DataGridView1 = New DataGridView()
        search = New Guna.UI2.WinForms.Guna2TextBox()
        Label1 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = SystemColors.ActiveBorder
        DataGridView1.Location = New Point(92, 95)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.ScrollBars = ScrollBars.None
        DataGridView1.Size = New Size(805, 497)
        DataGridView1.TabIndex = 0
        ' 
        ' search
        ' 
        search.BorderRadius = 20
        search.CustomizableEdges = CustomizableEdges1
        search.DefaultText = ""
        search.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        search.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        search.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        search.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        search.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        search.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        search.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        search.Location = New Point(307, 48)
        search.Name = "search"
        search.PasswordChar = ChrW(0)
        search.PlaceholderText = "Search Candidates Name:"
        search.SelectedText = ""
        search.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        search.Size = New Size(363, 41)
        search.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(383, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(212, 36)
        Label1.TabIndex = 3
        Label1.Text = "Voting Results"
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
        Guna2GradientButton2.Location = New Point(676, 48)
        Guna2GradientButton2.Name = "Guna2GradientButton2"
        Guna2GradientButton2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2GradientButton2.Size = New Size(138, 41)
        Guna2GradientButton2.TabIndex = 9
        Guna2GradientButton2.Text = "Print"
        ' 
        ' voteResults
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(976, 608)
        Controls.Add(Guna2GradientButton2)
        Controls.Add(Label1)
        Controls.Add(search)
        Controls.Add(DataGridView1)
        Name = "voteResults"
        Text = "voteResults"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
End Class
