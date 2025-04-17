Imports System.Net
Imports System.Net.Mail
Imports System.Text.RegularExpressions
Imports Excel = Microsoft.Office.Interop.Excel

Public Class SignupForm
    Private verificationCode As String ' Stores the generated verification code
    Private isOtpVerified As Boolean = False ' Tracks if OTP is verified

    ' ✅ SEND VERIFICATION CODE FUNCTION
    Private Sub btnSendVerification_Click(sender As Object, e As EventArgs) Handles btnSendVerification.Click
        Dim email As String = txtEmail.Text

        ' 🔹 Validate Email
        If Not email.Contains("@") OrElse Not email.Contains(".") Then
            MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 🔹 Generate a Random 6-digit Code
        Dim rand As New Random()
        verificationCode = rand.Next(100000, 999999).ToString()

        ' 🔹 Send Email
        If SendEmail(email, "Your Verification Code", "Your OTP is: " & verificationCode & vbCrLf & vbCrLf & " DO NOT SHARE THIS CODE!") Then
            MessageBox.Show("OTP code sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to send verification code. Check your internet connection and email settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ✅ EMAIL SENDING FUNCTION
    Private Function SendEmail(toEmail As String, subject As String, body As String) As Boolean
        Try
            ' 🔹 SMTP Configuration (Example: Gmail)
            Dim smtpClient As New SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New NetworkCredential("joebananaservices@gmail.com", "zfrz cyem ojzw ifmy")
            smtpClient.EnableSsl = True

            ' 🔹 Email Message
            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress("your-email@gmail.com")
            mailMessage.To.Add(toEmail)
            mailMessage.Subject = subject
            mailMessage.Body = body
            mailMessage.IsBodyHtml = False

            ' 🔹 Send Email
            smtpClient.Send(mailMessage)
            Return True

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' ✅ OTP VERIFICATION FUNCTION (Only checks OTP, does not save to Excel)
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If txtVerificationCode.Text = verificationCode Then
            MessageBox.Show("OTP Verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            isOtpVerified = True ' Mark OTP as verified
        Else
            MessageBox.Show("Invalid/Incorrect OTP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ✅ SIGNUP FUNCTION (Checks OTP & Password before saving to Excel)
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text

        ' 🔹 Check if OTP is verified
        If Not isOtpVerified Then
            MessageBox.Show("Please verify OTP first.", "Verification Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 🔹 Validate Password (At least 8 characters, must contain letters, numbers, special characters)
        If Not IsValidPassword(password) Then
            MessageBox.Show("Password must be at least 8 characters long and contain letters, numbers, and special characters.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 🔹 Save to Excel
        SaveToExcel(email, password)
    End Sub

    ' ✅ PASSWORD VALIDATION FUNCTION
    Private Function IsValidPassword(password As String) As Boolean
        Dim passwordPattern As String = "^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"
        Return Regex.IsMatch(password, passwordPattern)
    End Function

    ' ✅ SAVE USERNAME (EMAIL) AND PASSWORD TO EXCEL
    Private Sub SaveToExcel(username As String, password As String)
        Dim excelPath As String = "C:\Users\Ivan\OneDrive\Desktop\wetransfer_sales-tracker_2025-01-27_0656\Sales Tracker\User.xlsx"
        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            ' 🔹 Open the Excel File
            workbook = excelApp.Workbooks.Open(excelPath)
            worksheet = workbook.Sheets("Sheet1")

            ' 🔹 Find the Next Empty Row (Start from Row 2)
            Dim lastRow As Integer = worksheet.Cells(worksheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row + 1

            ' 🔹 Write Data (Column 1 = Username, Column 2 = Password)
            worksheet.Cells(lastRow, 1).Value = username
            worksheet.Cells(lastRow, 2).Value = password

            ' 🔹 Save and Close
            workbook.Save()
            MessageBox.Show("Signup successful! Data saved to Excel.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            LoginForm.Show()

        Catch ex As Exception
            MessageBox.Show("Error saving to Excel: " & ex.Message, "Excel Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            ' 🔹 Close Excel properly
            If Not workbook Is Nothing Then workbook.Close()
            If Not excelApp Is Nothing Then excelApp.Quit()
            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)
        End Try
    End Sub

    ' ✅ RELEASE EXCEL OBJECTS TO AVOID MEMORY LEAKS
    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class