<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPasswordForm
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
        Label2 = New Label()
        btnSave = New Button()
        txtReEnterPass = New TextBox()
        Label1 = New Label()
        txtNewPass = New TextBox()
        Label3 = New Label()
        btnSendCode = New Button()
        txtVerification = New TextBox()
        Label4 = New Label()
        txtEmail = New TextBox()
        Label5 = New Label()
        btnVerify = New Button()
        Label6 = New Label()
        btnGoBackToLogin = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Modern No. 20", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label2.Location = New Point(89, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(246, 34)
        Label2.TabIndex = 3
        Label2.Text = "Forgot Password"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatAppearance.MouseDownBackColor = Color.Silver
        btnSave.FlatAppearance.MouseOverBackColor = Color.Black
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = SystemColors.Info
        btnSave.Location = New Point(174, 428)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(83, 29)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtReEnterPass
        ' 
        txtReEnterPass.Location = New Point(91, 382)
        txtReEnterPass.Name = "txtReEnterPass"
        txtReEnterPass.Size = New Size(256, 23)
        txtReEnterPass.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Location = New Point(89, 355)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 14)
        Label1.TabIndex = 7
        Label1.Text = "Re-Enter Password"
        ' 
        ' txtNewPass
        ' 
        txtNewPass.Location = New Point(91, 310)
        txtNewPass.Name = "txtNewPass"
        txtNewPass.Size = New Size(256, 23)
        txtNewPass.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label3.Location = New Point(89, 286)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 14)
        Label3.TabIndex = 9
        Label3.Text = "Enter New Password"
        ' 
        ' btnSendCode
        ' 
        btnSendCode.Location = New Point(90, 245)
        btnSendCode.Name = "btnSendCode"
        btnSendCode.Size = New Size(138, 23)
        btnSendCode.TabIndex = 10
        btnSendCode.Text = "Send Verification Code"
        btnSendCode.UseVisualStyleBackColor = True
        ' 
        ' txtVerification
        ' 
        txtVerification.Location = New Point(89, 203)
        txtVerification.Name = "txtVerification"
        txtVerification.Size = New Size(258, 23)
        txtVerification.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(90, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 14)
        Label4.TabIndex = 12
        Label4.Text = "Enter Sent OTP"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(89, 141)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(258, 23)
        txtEmail.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label5.Location = New Point(89, 119)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 16)
        Label5.TabIndex = 14
        Label5.Text = "Enter Email"
        ' 
        ' btnVerify
        ' 
        btnVerify.Location = New Point(244, 245)
        btnVerify.Name = "btnVerify"
        btnVerify.Size = New Size(103, 23)
        btnVerify.TabIndex = 15
        btnVerify.Text = "Verify"
        btnVerify.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlDark
        Label6.Location = New Point(100, 496)
        Label6.Name = "Label6"
        Label6.Size = New Size(165, 14)
        Label6.TabIndex = 16
        Label6.Text = "Already have an account?"
        ' 
        ' btnGoBackToLogin
        ' 
        btnGoBackToLogin.BackColor = SystemColors.Info
        btnGoBackToLogin.FlatAppearance.BorderSize = 0
        btnGoBackToLogin.FlatStyle = FlatStyle.Flat
        btnGoBackToLogin.ForeColor = Color.Blue
        btnGoBackToLogin.Location = New Point(250, 492)
        btnGoBackToLogin.Name = "btnGoBackToLogin"
        btnGoBackToLogin.Size = New Size(75, 23)
        btnGoBackToLogin.TabIndex = 17
        btnGoBackToLogin.Text = "Sign In"
        btnGoBackToLogin.UseVisualStyleBackColor = False
        ' 
        ' ForgotPasswordForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(426, 561)
        Controls.Add(Label6)
        Controls.Add(btnVerify)
        Controls.Add(Label5)
        Controls.Add(txtEmail)
        Controls.Add(Label4)
        Controls.Add(txtVerification)
        Controls.Add(btnSendCode)
        Controls.Add(Label3)
        Controls.Add(txtNewPass)
        Controls.Add(Label1)
        Controls.Add(txtReEnterPass)
        Controls.Add(btnSave)
        Controls.Add(Label2)
        Controls.Add(btnGoBackToLogin)
        Name = "ForgotPasswordForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ForgotPasswordForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents txtReEnterPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSendCode As Button
    Friend WithEvents txtVerification As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnVerify As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGoBackToLogin As Button
End Class
