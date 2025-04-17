Imports System.Runtime.InteropServices

Public Class SalesTrackerIn

    Sub switchPanel(panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub SalesTrackerIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        switchPanel(Home)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        switchPanel(Dashboard)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        switchPanel(About)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        LogLogoutActivity() ' Call the function to log the activity
        Application.Exit() ' Exit the application
    End Sub

    Private Sub LogLogoutActivity()
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim xlWorkbook As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Dim lastRow As Integer
        Dim filePath As String = "C:\Users\Ivan\OneDrive\Desktop\wetransfer_sales-tracker_2025-01-27_0656\Sales Tracker\SalesData.xlsx"

        Try
            ' Open Excel application
            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkbook = xlApp.Workbooks.Open(filePath)
            xlSheet = CType(xlWorkbook.Sheets("Sheet3"), Microsoft.Office.Interop.Excel.Worksheet)

            ' Find the next available row in Column A
            lastRow = xlSheet.Cells(xlSheet.Rows.Count, 1).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row + 1

            ' Write "LOGGED OUT" in Column A and the current date & time in Column B
            xlSheet.Cells(lastRow, 1).Value = "LOGGED OUT"
            xlSheet.Cells(lastRow, 2).Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            ' Save and close
            xlWorkbook.Save()
        Catch ex As Exception
            MessageBox.Show("Error updating log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close and release Excel objects
            If xlWorkbook IsNot Nothing Then xlWorkbook.Close(False)
            If xlApp IsNot Nothing Then xlApp.Quit()

            ' Release COM objects
            ReleaseObject(xlSheet)
            ReleaseObject(xlWorkbook)
            ReleaseObject(xlApp)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

End Class