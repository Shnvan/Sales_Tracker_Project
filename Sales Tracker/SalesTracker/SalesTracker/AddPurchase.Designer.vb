<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addPurchase
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
        txtQuantity = New TextBox()
        btnUpdateInventory = New Button()
        Label1 = New Label()
        listBoxProductName = New ListBox()
        Label3 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label6 = New Label()
        txtReturnQuantity = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(31, 50)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(199, 23)
        txtQuantity.TabIndex = 1
        ' 
        ' btnUpdateInventory
        ' 
        btnUpdateInventory.BackColor = Color.LimeGreen
        btnUpdateInventory.FlatAppearance.BorderSize = 0
        btnUpdateInventory.FlatAppearance.MouseDownBackColor = Color.Silver
        btnUpdateInventory.FlatAppearance.MouseOverBackColor = Color.Gray
        btnUpdateInventory.FlatStyle = FlatStyle.Flat
        btnUpdateInventory.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdateInventory.ForeColor = SystemColors.ActiveCaptionText
        btnUpdateInventory.Location = New Point(412, 461)
        btnUpdateInventory.Name = "btnUpdateInventory"
        btnUpdateInventory.Size = New Size(131, 27)
        btnUpdateInventory.TabIndex = 2
        btnUpdateInventory.Text = "Update"
        btnUpdateInventory.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(277, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 29)
        Label1.TabIndex = 3
        Label1.Text = "Product Name"
        ' 
        ' listBoxProductName
        ' 
        listBoxProductName.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        listBoxProductName.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        listBoxProductName.FormattingEnabled = True
        listBoxProductName.Location = New Point(50, 97)
        listBoxProductName.Name = "listBoxProductName"
        listBoxProductName.Size = New Size(660, 164)
        listBoxProductName.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Window
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(47, 53)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 15)
        Label3.TabIndex = 7
        Label3.Text = "Available Stocks: "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel1.Controls.Add(listBoxProductName)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(109, 170)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(756, 280)
        Panel1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txtQuantity)
        Panel2.Location = New Point(190, 36)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(251, 100)
        Panel2.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(107, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 14)
        Label6.TabIndex = 16
        Label6.Text = "Sales"
        ' 
        ' txtReturnQuantity
        ' 
        txtReturnQuantity.Location = New Point(43, 55)
        txtReturnQuantity.Name = "txtReturnQuantity"
        txtReturnQuantity.Size = New Size(172, 23)
        txtReturnQuantity.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(865, 286)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(55, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 15)
        Label4.TabIndex = 12
        Label4.Text = "Available Sales:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(845, 289)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(92, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 14)
        Label5.TabIndex = 14
        Label5.Text = "Return"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtReturnQuantity)
        Panel3.Location = New Point(534, 36)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(237, 100)
        Panel3.TabIndex = 15
        ' 
        ' addPurchase
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(911, 500)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(btnUpdateInventory)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.None
        Name = "addPurchase"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addPurchase"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnUpdateInventory As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents listBoxProductName As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtReturnQuantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
End Class
