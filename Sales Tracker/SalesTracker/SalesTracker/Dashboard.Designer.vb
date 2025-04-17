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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        lblBestSelling = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblLeastSelling = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblRevenue = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        Panel1 = New Panel()
        Label6 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel4 = New Panel()
        Label4 = New Label()
        Panel5 = New Panel()
        Label5 = New Label()
        ListBox1 = New ListBox()
        Timer1 = New Timer(components)
        Label8 = New Label()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        Label1 = New Label()
        Panel10 = New Panel()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblBestSelling
        ' 
        lblBestSelling.BackColor = Color.Transparent
        lblBestSelling.Font = New Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBestSelling.Location = New Point(13, 58)
        lblBestSelling.Name = "lblBestSelling"
        lblBestSelling.Size = New Size(104, 28)
        lblBestSelling.TabIndex = 1
        lblBestSelling.Text = "Best Selling"
        ' 
        ' lblLeastSelling
        ' 
        lblLeastSelling.BackColor = Color.Transparent
        lblLeastSelling.Font = New Font("Segoe UI Variable Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLeastSelling.Location = New Point(14, 56)
        lblLeastSelling.Name = "lblLeastSelling"
        lblLeastSelling.Size = New Size(112, 28)
        lblLeastSelling.TabIndex = 2
        lblLeastSelling.Text = "Least Selling"
        ' 
        ' lblRevenue
        ' 
        lblRevenue.BackColor = Color.Transparent
        lblRevenue.Font = New Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRevenue.ForeColor = Color.Black
        lblRevenue.Location = New Point(47, 31)
        lblRevenue.Name = "lblRevenue"
        lblRevenue.Size = New Size(183, 38)
        lblRevenue.TabIndex = 4
        lblRevenue.Text = "Total Revenue"
        ' 
        ' Guna2CircleProgressBar1
        ' 
        Guna2CircleProgressBar1.FillColor = Color.White
        Guna2CircleProgressBar1.Font = New Font("Segoe UI", 12F)
        Guna2CircleProgressBar1.ForeColor = Color.White
        Guna2CircleProgressBar1.Location = New Point(114, 41)
        Guna2CircleProgressBar1.Minimum = 0
        Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Guna2CircleProgressBar1.ShadowDecoration.CustomizableEdges = CustomizableEdges5
        Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Guna2CircleProgressBar1.Size = New Size(146, 146)
        Guna2CircleProgressBar1.TabIndex = 5
        Guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel1.Controls.Add(Panel10)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Guna2CircleProgressBar1)
        Panel1.Location = New Point(68, 204)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(380, 242)
        Panel1.TabIndex = 6
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(75, 213)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 16)
        Label6.TabIndex = 6
        Label6.Text = "Label6"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel2.Controls.Add(lblRevenue)
        Panel2.Location = New Point(68, 124)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(380, 74)
        Panel2.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(IconButton1)
        Panel3.Location = New Point(68, 45)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(380, 73)
        Panel3.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(8, 7)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 14)
        Label3.TabIndex = 11
        Label3.Text = "Target Revenue"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(15, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 36)
        Label2.TabIndex = 0
        Label2.Text = "Target Revenue" & vbCrLf
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.DarkGray
        IconButton1.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Add
        IconButton1.IconColor = Color.White
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(334, 33)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(33, 32)
        IconButton1.TabIndex = 10
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(lblBestSelling)
        Panel4.Location = New Point(497, 212)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(267, 108)
        Panel4.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Info
        Label4.Location = New Point(57, 1)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 28)
        Label4.TabIndex = 2
        Label4.Text = "BEST SELLING"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel5.Controls.Add(lblLeastSelling)
        Panel5.Location = New Point(497, 336)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(267, 110)
        Panel5.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.Info
        Label5.Location = New Point(52, 1)
        Label5.Name = "Label5"
        Label5.Size = New Size(162, 28)
        Label5.TabIndex = 3
        Label5.Text = "LEAST SELLING"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(497, 45)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(267, 154)
        ListBox1.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Variable Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(68, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(133, 26)
        Label8.TabIndex = 14
        Label8.Text = "DASH BOARD" & vbCrLf
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel6.Controls.Add(Label4)
        Panel6.Location = New Point(497, 212)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(267, 35)
        Panel6.TabIndex = 15
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel7.Controls.Add(Label5)
        Panel7.Location = New Point(497, 336)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(267, 35)
        Panel7.TabIndex = 16
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel8.Controls.Add(Label3)
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(380, 27)
        Panel8.TabIndex = 16
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel9.Controls.Add(Label1)
        Panel9.Location = New Point(68, 122)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(380, 27)
        Panel9.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(8, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 14)
        Label1.TabIndex = 11
        Label1.Text = "Total Revenue"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel10.Controls.Add(Label7)
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(380, 27)
        Panel10.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.Info
        Label7.Location = New Point(8, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(84, 14)
        Label7.TabIndex = 11
        Label7.Text = "Progress bar"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(895, 461)
        Controls.Add(Panel9)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Label8)
        Controls.Add(ListBox1)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblBestSelling As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblLeastSelling As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblRevenue As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label1 As Label
End Class
