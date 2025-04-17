Imports Microsoft.Office.Interop.Excel

Public Class AddPurchase
    Private Const ExcelFilePath As String = "C:\Users\Ivan\Downloads\wetransfer_sales-tracker_2025-01-29_1012\Sales Tracker\SalesData.xlsx"

    ' 📌 Load Form & Populate Product List
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateProductList()
    End Sub

    ' 🔄 Cleanup Excel Objects
    Private Sub CleanupExcelObjects(ByRef xlApp As Application, ByRef xlWorkbook As Workbook, ByRef xlWorksheet As Worksheet)
        Try
            xlWorkbook?.Close(False)
            xlApp?.Quit()
            ReleaseObject(xlWorksheet)
            ReleaseObject(xlWorkbook)
            ReleaseObject(xlApp)
        Catch
            ' Suppress cleanup errors
        End Try
    End Sub

    ' 🔄 Release COM Object
    Private Sub ReleaseObject(ByRef obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    ' 📌 Populate ListBox with Product Names
    Private Sub PopulateProductList()
        Dim xlApp As Application = Nothing
        Dim xlWorkbook As Workbook = Nothing
        Dim xlWorksheet As Worksheet = Nothing

        Try
            xlApp = New Application()
            xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath, ReadOnly:=True)
            xlWorksheet = CType(xlWorkbook.Sheets(1), Worksheet)

            listBoxProductName.Items.Clear()
            Dim lastRow As Integer = xlWorksheet.Cells(xlWorksheet.Rows.Count, 1).End(XlDirection.xlUp).Row

            For i As Integer = 2 To lastRow
                Dim productName As String = xlWorksheet.Cells(i, 1).Value?.ToString()
                If Not String.IsNullOrEmpty(productName) Then
                    listBoxProductName.Items.Add(productName)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error loading product list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CleanupExcelObjects(xlApp, xlWorkbook, xlWorksheet)
        End Try
    End Sub

    ' 📌 Display Stock & Sales Info when Product is Selected
    Private Sub listBoxProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxProductName.SelectedIndexChanged
        If listBoxProductName.SelectedItem IsNot Nothing Then
            ShowProductDetails(listBoxProductName.SelectedItem.ToString())
        Else
            Label3.Text = "Select a product to view details."
            Label7.Text = ""
        End If
    End Sub

    ' 📌 Show Product Details
    Private Sub ShowProductDetails(selectedProduct As String)
        Dim xlApp As Application = Nothing
        Dim xlWorkbook As Workbook = Nothing
        Dim xlWorksheet As Worksheet = Nothing

        Try
            xlApp = New Application()
            xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath, ReadOnly:=True)
            xlWorksheet = CType(xlWorkbook.Sheets(1), Worksheet)

            Dim lastRow As Integer = xlWorksheet.Cells(xlWorksheet.Rows.Count, 1).End(XlDirection.xlUp).Row

            For i As Integer = 2 To lastRow
                If String.Equals(xlWorksheet.Cells(i, 1).Value?.ToString(), selectedProduct, StringComparison.OrdinalIgnoreCase) Then
                    Label3.Text = $"Available Stocks: {xlWorksheet.Cells(i, 3).Value?.ToString()}"
                    Label7.Text = $"Total Sales: {xlWorksheet.Cells(i, 4).Value}"
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error displaying product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CleanupExcelObjects(xlApp, xlWorkbook, xlWorksheet)
        End Try
    End Sub

    ' 📌 Update Inventory on Button Click
    Private Sub btnUpdateInventory_Click(sender As Object, e As EventArgs) Handles btnUpdateInventory.Click
        If listBoxProductName.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a product.", "No Product Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim soldQuantity, returnQuantity As Integer
        If Not Integer.TryParse(txtQuantity.Text, soldQuantity) Then soldQuantity = 0
        If Not Integer.TryParse(txtReturnQuantity.Text, returnQuantity) Then returnQuantity = 0

        If soldQuantity = 0 AndAlso returnQuantity = 0 Then
            MessageBox.Show("Please enter a valid quantity or return quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure of these changes?", "Confirm Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            UpdateInventory(listBoxProductName.SelectedItem.ToString(), soldQuantity, returnQuantity)
        End If
    End Sub

    ' 📌 Update Inventory & Revenue Calculation
    Private Sub UpdateInventory(selectedProduct As String, soldQuantity As Integer, returnQuantity As Integer)
        Dim xlApp As Application = Nothing
        Dim xlWorkbook As Workbook = Nothing
        Dim xlWorksheet As Worksheet = Nothing

        Try
            xlApp = New Application()
            xlWorkbook = xlApp.Workbooks.Open(ExcelFilePath)
            xlWorksheet = CType(xlWorkbook.Sheets(1), Worksheet)

            Dim lastRow As Integer = xlWorksheet.Cells(xlWorksheet.Rows.Count, 1).End(XlDirection.xlUp).Row

            For i As Integer = 2 To lastRow
                If String.Equals(xlWorksheet.Cells(i, 1).Value?.ToString(), selectedProduct, StringComparison.OrdinalIgnoreCase) Then
                    Dim currentStock As Integer = Convert.ToInt32(xlWorksheet.Cells(i, 3).Value)
                    Dim totalSales As Integer = Convert.ToInt32(xlWorksheet.Cells(i, 4).Value)
                    Dim revenue As Double = Convert.ToDouble(xlWorksheet.Cells(i, 5).Value)
                    Dim pricePerUnit As Double = Convert.ToDouble(xlWorksheet.Cells(i, 2).Value)

                    Dim salesRevenue As Double = soldQuantity * pricePerUnit
                    Dim returnRevenue As Double = returnQuantity * pricePerUnit
                    Dim updatedRevenue As Double = revenue + salesRevenue - returnRevenue

                    xlWorksheet.Cells(i, 3).Value = currentStock - soldQuantity + returnQuantity
                    xlWorksheet.Cells(i, 4).Value = totalSales + soldQuantity - returnQuantity
                    xlWorksheet.Cells(i, 5).Value = updatedRevenue

                    xlWorkbook.Save()
                    MessageBox.Show("Inventory updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show($"Error updating inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CleanupExcelObjects(xlApp, xlWorkbook, xlWorksheet)
        End Try
    End Sub


End Class