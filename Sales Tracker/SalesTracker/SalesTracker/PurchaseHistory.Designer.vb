<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseHistory
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
        dgvSalesData = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        CType(dgvSalesData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvSalesData
        ' 
        DataGridViewCellStyle1.BackColor = Color.White
        dgvSalesData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        DataGridViewCellStyle2.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvSalesData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvSalesData.ColumnHeadersHeight = 40
        dgvSalesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvSalesData.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvSalesData.DefaultCellStyle = DataGridViewCellStyle3
        dgvSalesData.GridColor = Color.MidnightBlue
        dgvSalesData.Location = New Point(-2, 49)
        dgvSalesData.Name = "dgvSalesData"
        dgvSalesData.RowHeadersVisible = False
        dgvSalesData.Size = New Size(911, 449)
        dgvSalesData.TabIndex = 2
        dgvSalesData.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvSalesData.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvSalesData.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvSalesData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvSalesData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvSalesData.ThemeStyle.BackColor = Color.White
        dgvSalesData.ThemeStyle.GridColor = Color.MidnightBlue
        dgvSalesData.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvSalesData.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvSalesData.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dgvSalesData.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvSalesData.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvSalesData.ThemeStyle.HeaderStyle.Height = 40
        dgvSalesData.ThemeStyle.ReadOnly = False
        dgvSalesData.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvSalesData.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvSalesData.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgvSalesData.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvSalesData.ThemeStyle.RowsStyle.Height = 25
        dgvSalesData.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvSalesData.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Column2"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Column3"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Column4"
        Column4.Name = "Column4"
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.Transparent
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.HomeLg
        IconButton1.IconColor = SystemColors.Info
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(853, 6)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(46, 37)
        IconButton1.TabIndex = 3
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' PurchaseHistory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.WindowFrame
        ClientSize = New Size(911, 500)
        Controls.Add(IconButton1)
        Controls.Add(dgvSalesData)
        FormBorderStyle = FormBorderStyle.None
        Name = "PurchaseHistory"
        Text = "PurchaseHistory"
        CType(dgvSalesData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvSalesData As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
