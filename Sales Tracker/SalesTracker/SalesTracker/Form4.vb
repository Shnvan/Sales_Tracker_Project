Imports Microsoft.Office.Interop.Excel

Public Class insights
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xlApp As New Application
        Dim xlWorkbook As Workbook = Nothing
        Dim xlWorksheet As Worksheet = Nothing

        Try
            xlWorkbook = xlApp.Workbooks.Open("C:\Users\Ivan\OneDrive\Desktop\wetransfer_sales-tracker_2025-01-27_0656\Sales Tracker\SalesData.xlsx")
            xlWorksheet = xlWorkbook.Sheets(1)

            Dim lastRow As Integer = xlWorksheet.Cells(xlWorksheet.Rows.Count, 1).End(XlDirection.xlUp).Row
            Dim insights As New List(Of String) From {
                "📊 Sales Insights:",
                "---------------------------"
            }

            Dim productSales As New Dictionary(Of String, Integer)
            For i As Integer = 2 To lastRow
                Dim productName As String = xlWorksheet.Cells(i, 1).Value
                Dim totalSold As Integer = If(IsNumeric(xlWorksheet.Cells(i, 4).Value), xlWorksheet.Cells(i, 4).Value, 0)
                productSales(productName) = totalSold
            Next

            Dim bestSellingProduct = productSales.Aggregate(Function(a, b) If(a.Value > b.Value, a, b))
            Dim leastSellingProduct = productSales.Where(Function(p) p.Value > 0).Aggregate(Function(a, b) If(a.Value < b.Value, a, b))

            For Each kvp In productSales
                Dim productName As String = kvp.Key
                Dim totalSold As Integer = kvp.Value

                If totalSold = 0 Then
                    insights.Add($"❌ Not Selling: {productName}")
                ElseIf productName = bestSellingProduct.Key Then
                    insights.Add($"🔥 Best-Selling: {productName} ({totalSold} units)")
                ElseIf productName = leastSellingProduct.Key Then
                    insights.Add($"⚠️ Least-Selling: {productName} ({totalSold} units)")
                Else
                    insights.Add($"✔ Normal Sales: {productName} ({totalSold} units)")
                End If
            Next

            lstInsights.DataSource = insights

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If xlWorksheet IsNot Nothing Then ReleaseObject(xlWorksheet)
            If xlWorkbook IsNot Nothing Then xlWorkbook.Close(False) : ReleaseObject(xlWorkbook)
            xlApp.Quit()
            ReleaseObject(xlApp)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        SalesTrackerIn.Show()
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
