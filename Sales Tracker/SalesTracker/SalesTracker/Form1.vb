Imports Microsoft.Office.Interop.Excel

Public Class addProducts
    Private Sub btnSaveToExcel_Click(sender As Object, e As EventArgs) Handles btnSaveToExcel.Click
        ' Declare objects inside the method to ensure proper management
        Dim xlApp As Application = Nothing
        Dim xlWorkbook As Workbook = Nothing
        Dim xlWorksheet As Worksheet = Nothing

        Try
            ' Validate price input
            Dim enteredPrice As Double
            If Not Double.TryParse(txtPrice.Text, enteredPrice) OrElse enteredPrice < 0 OrElse enteredPrice > 1000000000000 Then
                MessageBox.Show("Please enter a valid price between 0 and 1,000,000,000,000.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Initialize Excel application and open the workbook
            xlApp = New Application()
            xlWorkbook = xlApp.Workbooks.Open("C:\Users\Ivan\Downloads\wetransfer_sales-tracker_2025-01-29_1012\Sales Tracker\SalesData.xlsx")
            xlWorksheet = xlWorkbook.Sheets(1)

            Dim lastRow As Integer = xlWorksheet.Cells(xlWorksheet.Rows.Count, 1).End(XlDirection.xlUp).Row
            Dim productFound As Boolean = False
            Dim rowIndex As Integer = -1

            ' Check if the product exists in Column 1
            For i As Integer = 2 To lastRow
                If String.Equals(xlWorksheet.Cells(i, 1).Value?.ToString(), txtProductName.Text, StringComparison.OrdinalIgnoreCase) Then
                    productFound = True
                    rowIndex = i
                    Exit For
                End If
            Next

            If productFound Then
                ' Check if the price is the same
                Dim existingPrice As Double = Convert.ToDouble(xlWorksheet.Cells(rowIndex, 2).Value)

                If enteredPrice <> existingPrice Then
                    ' Prompt user to rename the product if price differs
                    MessageBox.Show($"The product name '{txtProductName.Text}' already exists but the price differs. " &
                                    "Please make the product name more specific.", "Product Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                Else
                    ' Confirm with the user to update the existing product
                    Dim result As DialogResult = MessageBox.Show($"The product '{txtProductName.Text}' already exists. " &
                                                                 "Do you want to update the quantity for this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        ' Update the quantity for the existing product
                        xlWorksheet.Cells(rowIndex, 3).Value += Convert.ToInt32(txtQuantity.Text)
                    Else
                        MessageBox.Show("Operation canceled. Please rename the product if it is different.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    ' Save and exit the method
                    xlWorkbook.Save()
                    CleanupExcelObjects(xlWorksheet, xlWorkbook, xlApp)
                    Return
                End If
            Else
                ' Add the product as a new row if not found
                xlWorksheet.Cells(lastRow + 1, 1).Value = txtProductName.Text
                xlWorksheet.Cells(lastRow + 1, 2).Value = enteredPrice
                xlWorksheet.Cells(lastRow + 1, 3).Value = Convert.ToInt32(txtQuantity.Text)
                xlWorksheet.Cells(lastRow + 1, 4).Value = 0 ' Total Sold
                xlWorksheet.Cells(lastRow + 1, 5).Value = 0 ' Total Revenue
            End If

            ' Save the workbook
            xlWorkbook.Save()
            MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Release and cleanup COM objects
            CleanupExcelObjects(xlWorksheet, xlWorkbook, xlApp)
        End Try
    End Sub

    ' Method to release COM objects
    Private Sub CleanupExcelObjects(ByVal xlWorksheet As Object, ByVal xlWorkbook As Object, ByVal xlApp As Object)
        Try
            If xlWorksheet IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorksheet)
            If xlWorkbook IsNot Nothing Then
                xlWorkbook.Close(False)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook)
            End If
            If xlApp IsNot Nothing Then
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            End If
        Catch ex As Exception
            ' Log or ignore errors during cleanup
        Finally
            xlWorksheet = Nothing
            xlWorkbook = Nothing
            xlApp = Nothing
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub
End Class