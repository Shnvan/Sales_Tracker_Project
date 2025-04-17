<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allProducts
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgvProducts = New DataGridView()
        btnSaveChanges = New Button()
        btnDeleteRow = New Button()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Label2 = New Label()
        Label1 = New Label()
        lstSort = New ListBox()
        Panel1 = New Panel()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        Guna2Panel1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvProducts
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        dgvProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvProducts.BackgroundColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridViewCellStyle2.Font = New Font("Tahoma", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvProducts.DefaultCellStyle = DataGridViewCellStyle2
        dgvProducts.Location = New Point(41, 51)
        dgvProducts.Name = "dgvProducts"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridViewCellStyle3.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvProducts.Size = New Size(590, 258)
        dgvProducts.TabIndex = 0
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.LimeGreen
        btnSaveChanges.FlatAppearance.BorderSize = 0
        btnSaveChanges.FlatAppearance.MouseDownBackColor = Color.Silver
        btnSaveChanges.FlatAppearance.MouseOverBackColor = Color.Black
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSaveChanges.ForeColor = SystemColors.Info
        btnSaveChanges.Location = New Point(369, 389)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(113, 50)
        btnSaveChanges.TabIndex = 1
        btnSaveChanges.Text = "SAVE CHANGES"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteRow
        ' 
        btnDeleteRow.BackColor = Color.Red
        btnDeleteRow.FlatAppearance.BorderSize = 0
        btnDeleteRow.FlatAppearance.MouseDownBackColor = Color.Silver
        btnDeleteRow.FlatAppearance.MouseOverBackColor = Color.Black
        btnDeleteRow.FlatStyle = FlatStyle.Flat
        btnDeleteRow.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteRow.ForeColor = SystemColors.Info
        btnDeleteRow.Location = New Point(544, 389)
        btnDeleteRow.Name = "btnDeleteRow"
        btnDeleteRow.Size = New Size(113, 50)
        btnDeleteRow.TabIndex = 3
        btnDeleteRow.Text = "REMOVE PRODUCT"
        btnDeleteRow.UseVisualStyleBackColor = False
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Guna2Panel1.Controls.Add(Label2)
        Guna2Panel1.Controls.Add(dgvProducts)
        Guna2Panel1.CustomizableEdges = CustomizableEdges1
        Guna2Panel1.ForeColor = SystemColors.Info
        Guna2Panel1.Location = New Point(193, 23)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Panel1.Size = New Size(674, 345)
        Guna2Panel1.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(280, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 23)
        Label2.TabIndex = 2
        Label2.Text = "Products"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(30, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 19)
        Label1.TabIndex = 1
        Label1.Text = "Sort By"
        ' 
        ' lstSort
        ' 
        lstSort.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        lstSort.BorderStyle = BorderStyle.FixedSingle
        lstSort.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lstSort.FormattingEnabled = True
        lstSort.ItemHeight = 17
        lstSort.Location = New Point(18, 52)
        lstSort.Name = "lstSort"
        lstSort.Size = New Size(94, 138)
        lstSort.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lstSort)
        Panel1.Location = New Point(45, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(130, 202)
        Panel1.TabIndex = 6
        ' 
        ' allProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(895, 461)
        Controls.Add(Panel1)
        Controls.Add(Guna2Panel1)
        Controls.Add(btnDeleteRow)
        Controls.Add(btnSaveChanges)
        Name = "allProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "allProducts"
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnDeleteRow As Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstSort As ListBox
    Friend WithEvents Panel1 As Panel
End Class
