<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insights
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
        lstInsights = New ListBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lstInsights
        ' 
        lstInsights.FormattingEnabled = True
        lstInsights.ItemHeight = 15
        lstInsights.Location = New Point(201, 32)
        lstInsights.Name = "lstInsights"
        lstInsights.Size = New Size(402, 244)
        lstInsights.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(302, 302)
        Button1.Name = "Button1"
        Button1.Size = New Size(186, 23)
        Button1.TabIndex = 1
        Button1.Text = "GO BACK TO DASHBOARD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' insights
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(911, 475)
        Controls.Add(Button1)
        Controls.Add(lstInsights)
        FormBorderStyle = FormBorderStyle.None
        Name = "insights"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstInsights As ListBox
    Friend WithEvents Button1 As Button
End Class
