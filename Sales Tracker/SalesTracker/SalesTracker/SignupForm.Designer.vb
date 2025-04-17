<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupForm
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtEmail = New TextBox()
        txtVerificationCode = New TextBox()
        txtPassword = New TextBox()
        btnSendVerification = New Button()
        btnVerify = New Button()
        Label4 = New Label()
        btnSignup = New Button()
        Label5 = New Label()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(82, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 16)
        Label1.TabIndex = 0
        Label1.Text = "Enter your Email:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(84, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 16)
        Label2.TabIndex = 1
        Label2.Text = "Enter Verification Code:" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(82, 395)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 16)
        Label3.TabIndex = 2
        Label3.Text = "Enter Strong Password:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(82, 133)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(307, 23)
        txtEmail.TabIndex = 3
        ' 
        ' txtVerificationCode
        ' 
        txtVerificationCode.Location = New Point(82, 215)
        txtVerificationCode.Name = "txtVerificationCode"
        txtVerificationCode.Size = New Size(307, 23)
        txtVerificationCode.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(86, 429)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(307, 23)
        txtPassword.TabIndex = 5
        ' 
        ' btnSendVerification
        ' 
        btnSendVerification.BackColor = Color.Transparent
        btnSendVerification.FlatStyle = FlatStyle.Popup
        btnSendVerification.Font = New Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSendVerification.Location = New Point(135, 263)
        btnSendVerification.Name = "btnSendVerification"
        btnSendVerification.Size = New Size(210, 40)
        btnSendVerification.TabIndex = 6
        btnSendVerification.Text = "SEND VERIFICATION CODE"
        btnSendVerification.UseVisualStyleBackColor = False
        ' 
        ' btnVerify
        ' 
        btnVerify.BackColor = Color.Transparent
        btnVerify.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnVerify.FlatAppearance.MouseOverBackColor = Color.Black
        btnVerify.FlatStyle = FlatStyle.Popup
        btnVerify.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerify.ForeColor = SystemColors.ControlText
        btnVerify.Location = New Point(135, 328)
        btnVerify.Name = "btnVerify"
        btnVerify.Size = New Size(210, 40)
        btnVerify.TabIndex = 7
        btnVerify.Text = "VERIFY"
        btnVerify.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 27F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label4.Location = New Point(163, 19)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 43)
        Label4.TabIndex = 10
        Label4.Text = "Sign Up"
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnSignup.FlatAppearance.BorderSize = 0
        btnSignup.FlatStyle = FlatStyle.Flat
        btnSignup.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignup.ForeColor = SystemColors.Info
        btnSignup.Location = New Point(82, 487)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(311, 34)
        btnSignup.TabIndex = 8
        btnSignup.Text = "Sign Up"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.WindowFrame
        Label5.Location = New Point(124, 536)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 16)
        Label5.TabIndex = 11
        Label5.Text = "Already have an account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(300, 535)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(47, 16)
        LinkLabel1.TabIndex = 12
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Log In"
        ' 
        ' SignupForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(491, 593)
        Controls.Add(LinkLabel1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnSignup)
        Controls.Add(btnVerify)
        Controls.Add(btnSendVerification)
        Controls.Add(txtPassword)
        Controls.Add(txtVerificationCode)
        Controls.Add(txtEmail)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "SignupForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "SignupForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtVerificationCode As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSendVerification As Button
    Friend WithEvents btnVerify As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSignup As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
