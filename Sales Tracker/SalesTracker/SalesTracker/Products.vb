Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class allProducts
    Dim xlApp As Excel.Application
    Dim xlWorkbook As Excel.Workbook
    Dim xlWorksheet As Excel.Worksheet
    Dim dt As New System.Data.DataTable()

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSort.Items.Add("by name")
        lstSort.Items.Add("by stocks")
        lstSort.Items.Add("by sales")
        lstSort.Items.Add("by revenue")

        Try
            xlApp = New Excel.Application
            xlWorkbook = xlApp.Workbooks.Open("C:\Users\Ivan\Downloads\wetransfer_sales-tracker_2025-01-29_1012\Sales Tracker\SalesData.xlsx")
            xlWorksheet = CType(xlWorkbook.Sheets(1), Excel.Worksheet)

            dt.Columns.Add("Product Name", GetType(String))
            dt.Columns.Add("Price", GetType(Double))
            dt.Columns.Add("Quantity", GetType(Integer))
            dt.Columns.Add("Total Sold", GetType(Integer))
            dt.Columns.Add("Total Revenue", GetType(Double))

            Dim lastRow As Integer = xlWorksheet.Cells(xlWorksheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row

            For i As Integer = 2 To lastRow
                Dim row As System.Data.DataRow = dt.NewRow()
                row("Product Name") = xlWorksheet.Cells(i, 1).Value
                row("Price") = xlWorksheet.Cells(i, 2).Value
                row("Quantity") = xlWorksheet.Cells(i, 3).Value
                row("Total Sold") = xlWorksheet.Cells(i, 4).Value
                row("Total Revenue") = xlWorksheet.Cells(i, 5).Value
                dt.Rows.Add(row)
            Next

            dgvProducts.DataSource = dt

            For Each row As DataGridViewRow In dgvProducts.Rows
                If Not row.IsNewRow Then
                    Dim quantity As Integer = Convert.ToInt32(row.Cells("Quantity").Value)
                    If quantity <= 10 Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        row.DefaultCellStyle.ForeColor = Color.White
                    Else
                        row.DefaultCellStyle.BackColor = Color.Green
                        row.DefaultCellStyle.ForeColor = Color.White
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        Finally
            CleanupExcelObjects()
        End Try
    End Sub

    Private Sub lstSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSort.SelectedIndexChanged
        Try
            Dim sortColumn As String = ""
            Dim sortOrder As String = "ASC"

            Select Case lstSort.SelectedItem.ToString()
                Case "by name"
                    sortColumn = "Product Name"
                    sortOrder = "ASC" ' Alphabetical order (A-Z)
                Case "by stocks"
                    sortColumn = "Quantity"
                    sortOrder = "DESC" ' High to low
                Case "by sales"
                    sortColumn = "Total Sold"
                    sortOrder = "DESC" ' High to low
                Case "by revenue"
                    sortColumn = "Total Revenue"
                    sortOrder = "DESC" ' High to low
            End Select

            If Not String.IsNullOrEmpty(sortColumn) Then
                dt.DefaultView.Sort = $"{sortColumn} {sortOrder}"
                dgvProducts.DataSource = dt.DefaultView.ToTable()
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred during sorting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Try
            xlApp = New Excel.Application
            xlWorkbook = xlApp.Workbooks.Open("C:\Users\Ivan\Downloads\wetransfer_sales-tracker_2025-01-29_1012\Sales Tracker\SalesData.xlsx")
            xlWorksheet = CType(xlWorkbook.Sheets(1), Excel.Worksheet)

            Dim lastRow As Integer = xlWorksheet.Cells(xlWorksheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row
            xlWorksheet.Range("A2:C" & lastRow).ClearContents()

            For i As Integer = 0 To dgvProducts.Rows.Count - 1
                xlWorksheet.Cells(i + 2, 1).Value = dgvProducts.Rows(i).Cells("Product Name").Value
                xlWorksheet.Cells(i + 2, 2).Value = dgvProducts.Rows(i).Cells("Price").Value
                xlWorksheet.Cells(i + 2, 3).Value = dgvProducts.Rows(i).Cells("Quantity").Value
            Next

            xlWorkbook.Save()
            MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        Finally
            CleanupExcelObjects()
        End Try
    End Sub

    Private Sub CleanupExcelObjects()
        ' Ensure proper cleanup of Excel objects
        If xlWorksheet IsNot Nothing Then Marshal.ReleaseComObject(xlWorksheet)
        If xlWorkbook IsNot Nothing Then xlWorkbook.Close(False) : Marshal.ReleaseComObject(xlWorkbook)
        If xlApp IsNot Nothing Then xlApp.Quit() : Marshal.ReleaseComObject(xlApp)

        ' Explicit garbage collection and cleanup
        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        Try
            If dgvProducts.SelectedRows.Count > 0 Then
                Dim rowIndex As Integer = dgvProducts.SelectedRows(0).Index
                dt.Rows(rowIndex).Delete()
                dgvProducts.DataSource = dt
                MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred while deleting the row: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Hide()
        SalesTrackerIn.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dgvProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellContentClick

    End Sub
End Class
