<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesTrackerIn
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
        Panel1 = New Panel()
        IconButton4 = New FontAwesome.Sharp.IconButton()
        Panel5 = New Panel()
        Panel4 = New Panel()
        Panel7 = New Panel()
        IconButton3 = New FontAwesome.Sharp.IconButton()
        IconButton2 = New FontAwesome.Sharp.IconButton()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel1.Controls.Add(IconButton4)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(IconButton3)
        Panel1.Controls.Add(IconButton2)
        Panel1.Controls.Add(IconButton1)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(278, 572)
        Panel1.TabIndex = 0
        ' 
        ' IconButton4
        ' 
        IconButton4.BackColor = Color.Black
        IconButton4.FlatAppearance.BorderSize = 0
        IconButton4.FlatAppearance.MouseDownBackColor = Color.White
        IconButton4.FlatAppearance.MouseOverBackColor = Color.Black
        IconButton4.FlatStyle = FlatStyle.Flat
        IconButton4.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton4.ForeColor = SystemColors.Info
        IconButton4.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        IconButton4.IconColor = SystemColors.Info
        IconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton4.IconSize = 45
        IconButton4.Location = New Point(-7, 514)
        IconButton4.Name = "IconButton4"
        IconButton4.Size = New Size(288, 55)
        IconButton4.TabIndex = 16
        IconButton4.Text = "Log Out"
        IconButton4.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton4.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.Location = New Point(1, 219)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(17, 45)
        Panel5.TabIndex = 15
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.Location = New Point(1, 152)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(17, 45)
        Panel4.TabIndex = 14
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.Black
        Panel7.Location = New Point(2, 87)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(17, 45)
        Panel7.TabIndex = 10
        ' 
        ' IconButton3
        ' 
        IconButton3.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        IconButton3.FlatAppearance.BorderSize = 0
        IconButton3.FlatAppearance.MouseDownBackColor = Color.White
        IconButton3.FlatAppearance.MouseOverBackColor = Color.Black
        IconButton3.FlatStyle = FlatStyle.Flat
        IconButton3.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton3.ForeColor = SystemColors.Info
        IconButton3.IconChar = FontAwesome.Sharp.IconChar.Info
        IconButton3.IconColor = Color.Black
        IconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton3.Location = New Point(-7, 212)
        IconButton3.Name = "IconButton3"
        IconButton3.Size = New Size(288, 60)
        IconButton3.TabIndex = 13
        IconButton3.Text = "About"
        IconButton3.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton3.UseVisualStyleBackColor = False
        ' 
        ' IconButton2
        ' 
        IconButton2.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        IconButton2.FlatAppearance.BorderSize = 0
        IconButton2.FlatAppearance.MouseDownBackColor = Color.White
        IconButton2.FlatAppearance.MouseOverBackColor = Color.Black
        IconButton2.FlatStyle = FlatStyle.Flat
        IconButton2.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton2.ForeColor = SystemColors.Info
        IconButton2.IconChar = FontAwesome.Sharp.IconChar.Database
        IconButton2.IconColor = Color.Black
        IconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton2.Location = New Point(-2, 146)
        IconButton2.Name = "IconButton2"
        IconButton2.Size = New Size(285, 60)
        IconButton2.TabIndex = 12
        IconButton2.Text = "Dashboard"
        IconButton2.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton2.UseVisualStyleBackColor = False
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatAppearance.MouseDownBackColor = Color.White
        IconButton1.FlatAppearance.MouseOverBackColor = Color.Black
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        IconButton1.ForeColor = SystemColors.Info
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(-8, 80)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(291, 60)
        IconButton1.TabIndex = 11
        IconButton1.Text = "Home"
        IconButton1.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Modern No. 20", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(40, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 38)
        Label1.TabIndex = 2
        Label1.Text = "JoeBanana"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(271, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(918, 64)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(275, 60)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(911, 500)
        Panel3.TabIndex = 2
        ' 
        ' SalesTrackerIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1184, 561)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "SalesTrackerIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SalesTrackerIn"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
End Class
