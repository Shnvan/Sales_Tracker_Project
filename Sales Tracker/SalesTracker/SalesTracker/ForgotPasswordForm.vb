Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Runtime.InteropServices

Public Class ForgotPasswordForm
    Private VerificationCode As String
    Private userExcelPath As String = "C:\Users\Ivan\OneDrive\Desktop\wetransfer_sales-tracker_2025-01-27_0656\Sales Tracker\User.xlsx"
    Private salesDataExcelPath As String = "C:\Users\Ivan\OneDrive\Desktop\wetransfer_sales-tracker_2025-01-27_0656\Sales Tracker\SalesData.xlsx"

    Private Sub btnSendCode_Click(sender As Object, e As EventArgs) Handles btnSendCode.Click
        If txtEmail.Text = "" Then
            MsgBox("Please enter your email address.", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        Dim rand As New Random()
        VerificationCode = rand.Next(100000, 999999).ToString()

        Try
            Dim smtpClient As New SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New NetworkCredential("jamesangelobolano@gmail.com", "cdwa sfku mvzt kvxt")
            smtpClient.EnableSsl = True

            Dim mail As New MailMessage()
            mail.From = New MailAddress("jamesangelobolano@gmail.com")
            mail.To.Add(txtEmail.Text)
            mail.Subject = "Your Verification Code"
            mail.Body = "Your OTP code is: " & VerificationCode & vbCrLf & vbCrLf & "DO NOT SHARE THIS CODE WITH ANYONE!"

            smtpClient.Send(mail)
            MsgBox("Verification code sent to " & txtEmail.Text, MsgBoxStyle.Information, "Email Sent")
        Catch ex As Exception
            MsgBox("Failed to send email. Please check your email and internet connection." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If txtVerification.Text = "" Then
            MsgBox("Please enter the verification code.", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        If txtVerification.Text = VerificationCode Then
            MsgBox("Verification successful. You may now set your new password.", MsgBoxStyle.Information, "Verified")
            txtNewPass.Enabled = True
            txtReEnterPass.Enabled = True
            btnSave.Enabled = True
        Else
            MsgBox("Invalid verification code. Please try again.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not txtNewPass.Enabled OrElse Not txtReEnterPass.Enabled Then
            MsgBox("Please verify your email first.", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        Dim newPassword As String = txtNewPass.Text
        Dim reEnterPassword As String = txtReEnterPass.Text

        If newPassword = "" OrElse reEnterPassword = "" Then
            MsgBox("Please enter and re-enter your new password.", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        If Not IsStrongPassword(newPassword) Then
            MsgBox("Password must be at least 8 characters long and include letters, numbers, and special characters.", MsgBoxStyle.Critical, "Weak Password")
            Return
        End If

        If newPassword <> reEnterPassword Then
            MsgBox("Passwords do not match. Please try again.", MsgBoxStyle.Critical, "Error")
            Return
        End If

        If UpdatePasswordInExcel(newPassword) Then
            MsgBox("Password successfully changed and updated in system.", MsgBoxStyle.Information, "Success")
            Me.Hide()
            LoginForm.Show()
            txtNewPass.Enabled = False
            txtReEnterPass.Enabled = False
            btnSave.Enabled = False
            LogPasswordChange()
        Else
            MsgBox("Failed to update password in Excel.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Function IsStrongPassword(password As String) As Boolean
        Dim pattern As String = "^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
        Return Regex.IsMatch(password, pattern)
    End Function

    Private Function UpdatePasswordInExcel(newPassword As String) As Boolean
        Dim excelApp As Application = Nothing
        Dim workbook As Workbook = Nothing
        Dim sheet As Worksheet = Nothing

        Try
            excelApp = New Application
            excelApp.DisplayAlerts = False
            workbook = excelApp.Workbooks.Open(userExcelPath, [ReadOnly]:=False, Editable:=True)
            sheet = workbook.Sheets(1)
            sheet.Cells(2, 2).Value = newPassword
            workbook.Save()
            Return True
        Catch ex As Exception
            MsgBox("Error updating password: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        Finally
            ReleaseExcelObjects(sheet, workbook, excelApp)
        End Try
    End Function

    Private Sub LogPasswordChange()
        Dim excelApp As Application = Nothing
        Dim workbook As Workbook = Nothing
        Dim sheet As Worksheet = Nothing

        Try
            excelApp = New Application
            excelApp.DisplayAlerts = False
            workbook = excelApp.Workbooks.Open(salesDataExcelPath, [ReadOnly]:=False, Editable:=True)
            sheet = workbook.Sheets(3)
            Dim lastRow As Integer = sheet.Cells(sheet.Rows.Count, 1).End(XlDirection.xlUp).Row + 1
            sheet.Cells(lastRow, 1).Value = "CHANGED PASSWORD"
            sheet.Cells(lastRow, 2).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            workbook.Save()
        Catch ex As Exception
            MsgBox("Error logging password change: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            ReleaseExcelObjects(sheet, workbook, excelApp)
        End Try
    End Sub

    Private Sub ReleaseExcelObjects(sheet As Worksheet, workbook As Workbook, excelApp As Application)
        Try
            If sheet IsNot Nothing Then Marshal.FinalReleaseComObject(sheet)
            If workbook IsNot Nothing Then workbook.Close(False) : Marshal.FinalReleaseComObject(workbook)
            If excelApp IsNot Nothing Then excelApp.Quit() : Marshal.FinalReleaseComObject(excelApp)
        Catch ex As Exception
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Private Sub btnGoBackToLogin_Click(sender As Object, e As EventArgs) Handles btnGoBackToLogin.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class
