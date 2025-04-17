Imports System.IO
Imports Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices ' Required for releasing Excel objects

Public Class LoginForm

    Private isPasswordVisible As Boolean = False
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable controls until userAgreement is handled
        DisableControls()

        Dim userAgreed As Boolean = PublicVariables.userAgree

        ' If user has not agreed, show User Agreement form
        If userAgreed = False Then
            TermAndConditions.ShowDialog() ' Using ShowDialog to block until UserAgreement is closed
        End If

        ' Enable controls once the User Agreement form is closed
        EnableControls()

        ' Disable Signup if an account exists
        If AccountExists() Then
            btnSignup.Enabled = False
            btnSignup.Text = "Signup Disabled"
        End If
    End Sub

    ' Function to disable all controls on the form
    Private Sub DisableControls()
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = False
        Next
    End Sub

    ' Function to enable all controls on the form
    Private Sub EnableControls()
        For Each ctrl As Control In Me.Controls
            ctrl.Enabled = True
        Next
    End Sub

    ' ✅ LOGIN BUTTON CLICK EVENT
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        If ValidateLogin(email, password) Then
            LogActivity("LOGGED IN")
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            SalesTrackerIn.Show()

            ' Create an instance of the Home form
            ' Set the Home form to be a child of Panel3 in Form3
            Home.TopLevel = False
            Home.FormBorderStyle = FormBorderStyle.None
            Home.Dock = DockStyle.Fill

            ' Add the Home form to Panel3 of Form3
            SalesTrackerIn.Panel3.Controls.Add(Home)

            ' Show the Home form inside Panel3
            Home.Show()
        Else
            MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ✅ FUNCTION TO VALIDATE LOGIN CREDENTIALS
    Private Function ValidateLogin(email As String, password As String) As Boolean
        Dim xlApp As New Application()
        xlApp.Visible = False
        Dim xlWorkbook As Workbook = Nothing
        Dim xlSheet As Worksheet = Nothing

        Try
            xlWorkbook = xlApp.Workbooks.Open("C:\Users\Ivan\OneDrive\Desktop\wetransfer_sales-tracker_2025-01-27_0656\Sales Tracker\User.xlsx")
            xlSheet = xlWorkbook.Sheets(1)

            If xlSheet.Cells(2, 1).Value = email AndAlso xlSheet.Cells(2, 2).Value = password Then
                Return True
            End If
            Return False
        Catch ex As Exception
            MessageBox.Show("Error accessing user data. Make sure the file exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            ' Close and release Excel objects properly
            If xlWorkbook IsNot Nothing Then
                xlWorkbook.Close(False)
                Marshal.ReleaseComObject(xlWorkbook)
            End If

            If xlApp IsNot Nothing Then
                xlApp.Quit()  ' Ensure Excel application is closed
                Marshal.ReleaseComObject(xlApp)
            End If

            If xlSheet IsNot Nothing Then
                Marshal.ReleaseComObject(xlSheet)
            End If
        End Try
    End Function

    ' ✅ FUNCTION TO CHECK IF AN ACCOUNT ALREADY EXISTS
    Private Function AccountExists() As Boolean
        Dim xlApp As New Application()
        xlApp.Visible = False
        Dim xlWorkbook As Workbook = Nothing
        Dim xlSheet As Worksheet = Nothing

        Try
            xlWorkbook = xlApp.Workbooks.Open("C:\Users\Ivan\OneDrive\Desktop\wetransfer_sales-tracker_2025-01-27_0656\Sales Tracker\SalesData.xlsx")
            xlSheet = xlWorkbook.Sheets(1)

            Dim exists As Boolean = xlSheet.Cells(2, 1).Value <> ""
            Return exists
        Catch ex As Exception
            Return False
        Finally
            ' Close and release Excel objects properly
            If xlWorkbook IsNot Nothing Then
                xlWorkbook.Close(False)
                Marshal.ReleaseComObject(xlWorkbook)
            End If

            If xlApp IsNot Nothing Then
                xlApp.Quit()  ' Ensure Excel application is closed
                Marshal.ReleaseComObject(xlApp)
            End If

            If xlSheet IsNot Nothing Then
                Marshal.ReleaseComObject(xlSheet)
            End If
        End Try
    End Function

    ' ✅ FUNCTION TO LOG USER ACTIVITY
    Private Sub LogActivity(activity As String)
        Dim xlApp As New Application()
        xlApp.Visible = False
        Dim xlWorkbook As Workbook = Nothing
        Dim xlSheet As Worksheet = Nothing

        Try
            xlWorkbook = xlApp.Workbooks.Open("C:\Users\Ivan\OneDrive\Desktop\wetransfer_sales-tracker_2025-01-27_0656\Sales Tracker\SalesData.xlsx")
            xlSheet = xlWorkbook.Sheets(3)

            ' 🔹 FIND LAST ROW SAFELY
            Dim lastRow As Integer
            If xlSheet.Cells(2, 1).Value = "" Then
                lastRow = 2 ' Start from row 2 if empty
            Else
                lastRow = xlSheet.Cells(xlSheet.Rows.Count, 1).End(XlDirection.xlUp).Row + 1
            End If

            xlSheet.Cells(lastRow, 1).Value = activity
            xlSheet.Cells(lastRow, 2).Value = Now.ToString("yyyy-MM-dd HH:mm:ss")

            xlWorkbook.Save()
        Catch ex As Exception
            MessageBox.Show("Error logging activity.", "Logging Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close and release Excel objects properly
            If xlWorkbook IsNot Nothing Then
                xlWorkbook.Close(False)
                Marshal.ReleaseComObject(xlWorkbook)
            End If

            If xlApp IsNot Nothing Then
                xlApp.Quit()  ' Ensure Excel application is closed
                Marshal.ReleaseComObject(xlApp)
            End If

            If xlSheet IsNot Nothing Then
                Marshal.ReleaseComObject(xlSheet)
            End If
        End Try
    End Sub

    ' ✅ OPEN FORGOT PASSWORD FORM
    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        ForgotPasswordForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SignupForm.Show()
    End Sub

    Private Sub btnSignup_Click_1(sender As Object, e As EventArgs) Handles btnSignup.Click
        Me.Hide()
        SignupForm.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim currentProcessName As String = Process.GetCurrentProcess().ProcessName
        For Each proc As Process In Process.GetProcessesByName(currentProcessName)
            If proc.Id <> Process.GetCurrentProcess().Id Then
                proc.Kill()
            End If
        Next
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ' Toggle the password visibility state
        isPasswordVisible = Not isPasswordVisible

        ' If visible, show plain text, otherwise, show '*'
        txtPassword.UseSystemPasswordChar = Not isPasswordVisible
    End Sub
End Class
