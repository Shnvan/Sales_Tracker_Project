<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TermAndConditions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TermAndConditions))
        Button1 = New Button()
        Button2 = New Button()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveBorder
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(235, 715)
        Button1.Name = "Button1"
        Button1.Size = New Size(126, 40)
        Button1.TabIndex = 0
        Button1.Text = "Agree"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveBorder
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(407, 715)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 40)
        Button2.TabIndex = 1
        Button2.Text = "Disagree"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.ForeColor = Color.Black
        Guna2HtmlLabel1.Location = New Point(43, 13)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(387, 44)
        Guna2HtmlLabel1.TabIndex = 3
        Guna2HtmlLabel1.Text = "Terms And Conditions" & vbCrLf
        ' 
        ' VScrollBar1
        ' 
        VScrollBar1.InUpdate = False
        VScrollBar1.LargeChange = 10
        VScrollBar1.Location = New Point(770, 82)
        VScrollBar1.Name = "VScrollBar1"
        VScrollBar1.ScrollbarSize = 18
        VScrollBar1.Size = New Size(18, 545)
        VScrollBar1.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(Guna2HtmlLabel1)
        Panel1.Location = New Point(-3, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(805, 77)
        Panel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 6.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(761, 583)
        Label1.TabIndex = 6
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' TermAndConditions
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 599)
        Controls.Add(VScrollBar1)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Name = "TermAndConditions"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TermAndConditions"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
