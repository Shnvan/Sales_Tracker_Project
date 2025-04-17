<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addProducts
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtProductName = New TextBox()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        btnSaveToExcel = New Button()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtProductName
        ' 
        txtProductName.Location = New Point(307, 159)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(323, 23)
        txtProductName.TabIndex = 0
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(307, 221)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(323, 23)
        txtPrice.TabIndex = 1
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(307, 291)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(323, 23)
        txtQuantity.TabIndex = 2
        ' 
        ' btnSaveToExcel
        ' 
        btnSaveToExcel.BackColor = Color.LimeGreen
        btnSaveToExcel.FlatAppearance.BorderSize = 0
        btnSaveToExcel.FlatAppearance.MouseDownBackColor = Color.Silver
        btnSaveToExcel.FlatAppearance.MouseOverBackColor = Color.Gray
        btnSaveToExcel.FlatStyle = FlatStyle.Flat
        btnSaveToExcel.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveToExcel.ForeColor = SystemColors.InactiveCaptionText
        btnSaveToExcel.Location = New Point(414, 340)
        btnSaveToExcel.Name = "btnSaveToExcel"
        btnSaveToExcel.Size = New Size(105, 25)
        btnSaveToExcel.TabIndex = 6
        btnSaveToExcel.Text = "SAVE"
        btnSaveToExcel.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(273, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(394, 405)
        Panel1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(307, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 19)
        Label3.TabIndex = 5
        Label3.Text = "Quantity"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Info
        Label2.Location = New Point(307, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 19)
        Label2.TabIndex = 4
        Label2.Text = "Price"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(35, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 19)
        Label1.TabIndex = 3
        Label1.Text = "Product Name"
        ' 
        ' addProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(911, 500)
        Controls.Add(btnSaveToExcel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(txtProductName)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "addProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "addProducts"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnSaveToExcel As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label

End Class
