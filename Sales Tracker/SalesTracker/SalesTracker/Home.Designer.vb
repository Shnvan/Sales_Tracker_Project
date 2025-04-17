<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Purchase = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Purchase
        ' 
        Purchase.BackColor = SystemColors.ScrollBar
        Purchase.BackgroundImage = CType(resources.GetObject("Purchase.BackgroundImage"), Image)
        Purchase.BackgroundImageLayout = ImageLayout.Zoom
        Purchase.FlatAppearance.BorderSize = 0
        Purchase.FlatAppearance.MouseDownBackColor = SystemColors.Info
        Purchase.FlatAppearance.MouseOverBackColor = SystemColors.ScrollBar
        Purchase.FlatStyle = FlatStyle.Flat
        Purchase.Location = New Point(149, 98)
        Purchase.Name = "Purchase"
        Purchase.Size = New Size(200, 100)
        Purchase.TabIndex = 1
        Purchase.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ScrollBar
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(539, 95)
        Button2.Name = "Button2"
        Button2.Size = New Size(200, 100)
        Button2.TabIndex = 2
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ScrollBar
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(149, 335)
        Button1.Name = "Button1"
        Button1.Size = New Size(200, 100)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ScrollBar
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(539, 335)
        Button3.Name = "Button3"
        Button3.Size = New Size(200, 100)
        Button3.TabIndex = 6
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(438, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 23)
        Label1.TabIndex = 3
        Label1.Text = "ADD"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.WindowFrame
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-15, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(960, 32)
        Panel1.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.WindowFrame
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(-15, 227)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(926, 32)
        Panel2.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(436, 6)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 23)
        Label3.TabIndex = 3
        Label3.Text = "VIEW"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(206, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 19)
        Label2.TabIndex = 9
        Label2.Text = "Purchase "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(598, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 19)
        Label4.TabIndex = 10
        Label4.Text = "Products"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(177, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 19)
        Label5.TabIndex = 11
        Label5.Text = "Purchase History"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(586, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 19)
        Label6.TabIndex = 12
        Label6.Text = "All Products"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(911, 500)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Purchase)
        FormBorderStyle = FormBorderStyle.None
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Purchase As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
