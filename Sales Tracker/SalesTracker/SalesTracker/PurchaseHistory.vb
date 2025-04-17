Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Excel

Public Class PurchaseHistory
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure the DataGridView
        dgvSalesData.AllowUserToAddRows = False
        dgvSalesData.AllowUserToDeleteRows = False
        dgvSalesData.ReadOnly = True
        dgvSalesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSalesData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Load data from Excel
        LoadDataFromExcel()
    End Sub

    Private Sub LoadDataFromExcel()
        Dim excelApp As Application = Nothing
        Dim workbook As Workbook = Nothing
        Dim worksheet As Worksheet = Nothing
        Dim range As Range = Nothing

        Try
            ' Open Excel file
            excelApp = New Application()
            workbook = excelApp.Workbooks.Open("C:\Users\Ivan\Downloads\wetransfer_sales-tracker_2025-01-29_1012\Sales Tracker\SalesData.xlsx")
            worksheet = workbook.Sheets("Sheet2")
            range = worksheet.Range("A1:C" & worksheet.UsedRange.Rows.Count)

            ' Clear existing rows and columns
            dgvSalesData.Rows.Clear()
            dgvSalesData.Columns.Clear()

            ' Add columns dynamically from Excel headers
            For colIndex As Integer = 1 To range.Columns.Count
                dgvSalesData.Columns.Add("Column" & colIndex, range.Cells(1, colIndex).Value?.ToString())
            Next

            ' Populate DataGridView with Excel data, starting from row 2 to skip headers
            For rowIndex As Integer = 2 To range.Rows.Count
                Dim rowData(range.Columns.Count - 1) As String
                For colIndex As Integer = 1 To range.Columns.Count
                    Dim cellValue = range.Cells(rowIndex, colIndex).Value
                    rowData(colIndex - 1) = If(cellValue IsNot Nothing, cellValue.ToString(), "")
                Next
                dgvSalesData.Rows.Add(rowData)
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Clean up Excel objects
            If range IsNot Nothing Then Marshal.ReleaseComObject(range)
            If worksheet IsNot Nothing Then Marshal.ReleaseComObject(worksheet)
            If workbook IsNot Nothing Then workbook.Close(False)
            If excelApp IsNot Nothing Then excelApp.Quit()

            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub
End Class
