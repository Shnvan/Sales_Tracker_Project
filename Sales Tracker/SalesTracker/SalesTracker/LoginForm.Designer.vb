<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        lblForgotPassword = New LinkLabel()
        btnLogin = New Button()
        Label2 = New Label()
        txtPassword = New TextBox()
        Label1 = New Label()
        txtEmail = New TextBox()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        btnSignup = New Button()
        IconButton1 = New FontAwesome.Sharp.IconButton()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblForgotPassword
        ' 
        lblForgotPassword.AutoSize = True
        lblForgotPassword.Location = New Point(62, 276)
        lblForgotPassword.Name = "lblForgotPassword"
        lblForgotPassword.Size = New Size(100, 15)
        lblForgotPassword.TabIndex = 7
        lblForgotPassword.TabStop = True
        lblForgotPassword.Text = "Forgot Password?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnLogin.FlatAppearance.MouseOverBackColor = Color.Black
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.ButtonHighlight
        btnLogin.Location = New Point(39, 319)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(339, 41)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOG IN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(62, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 16)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(62, 239)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(292, 23)
        txtPassword.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(62, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 16)
        Label1.TabIndex = 0
        Label1.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(62, 150)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(292, 23)
        txtEmail.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Modern No. 20", 26.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(144, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(133, 37)
        Label4.TabIndex = 9
        Label4.Text = "Sign In"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Location = New Point(-15, -5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(520, 275)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Info
        Panel2.Controls.Add(IconButton1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(btnSignup)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(txtEmail)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lblForgotPassword)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(31, 194)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(426, 440)
        Panel2.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.WindowFrame
        Label5.Location = New Point(101, 384)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 16)
        Label5.TabIndex = 12
        Label5.Text = "Don't have an account?"
        ' 
        ' btnSignup
        ' 
        btnSignup.FlatAppearance.BorderSize = 0
        btnSignup.FlatStyle = FlatStyle.Flat
        btnSignup.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignup.ForeColor = Color.Blue
        btnSignup.Location = New Point(259, 372)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(150, 41)
        btnSignup.TabIndex = 14
        btnSignup.Text = "Sign Up"
        btnSignup.TextAlign = ContentAlignment.MiddleLeft
        btnSignup.UseVisualStyleBackColor = True
        ' 
        ' IconButton1
        ' 
        IconButton1.BackColor = Color.Transparent
        IconButton1.FlatAppearance.BorderSize = 0
        IconButton1.FlatStyle = FlatStyle.Flat
        IconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye
        IconButton1.IconColor = Color.Black
        IconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButton1.Location = New Point(360, 222)
        IconButton1.Name = "IconButton1"
        IconButton1.Size = New Size(56, 54)
        IconButton1.TabIndex = 15
        IconButton1.UseVisualStyleBackColor = False
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Menu
        ClientSize = New Size(491, 656)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblForgotPassword As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSignup As Button
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
End Class
