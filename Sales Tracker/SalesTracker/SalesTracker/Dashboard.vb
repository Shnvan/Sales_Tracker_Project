Imports Excel = Microsoft.Office.Interop.Excel

Public Class Dashboard
    Dim bestSellingProduct As String = ""
    Dim leastSellingProduct As String = ""
    Dim totalRevenue As Double = 0
    Dim targetRevenue As Double = 1 ' Default value to prevent division by zero
    Dim storedMonths As New Dictionary(Of String, (String, String)) ' Stores Best/Least Selling per month

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load sales data from Excel
        LoadDataFromExcel()

        ' Update UI
        UpdateSellingCategories()
        UpdateRevenueDisplay()
        UpdateProgressBar()
        LoadStoredMonths()
    End Sub

    Private Sub LoadDataFromExcel()
        Try
            Dim xlApp As New Excel.Application
            Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Open("C:\Users\Ivan\Downloads\wetransfer_sales-tracker_2025-01-29_1012\Sales Tracker\SalesData.xlsx")
            Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets(1), Excel.Worksheet)
            Dim xlRange As Excel.Range = xlWorksheet.UsedRange

            Dim highestSales As Integer = Integer.MinValue
            Dim lowestSales As Integer = Integer.MaxValue

            For i As Integer = 2 To xlRange.Rows.Count
                Dim productName As String = xlRange.Cells(i, 1).Value
                Dim sales As Integer = xlRange.Cells(i, 4).Value
                Dim revenue As Double = xlRange.Cells(i, 5).Value

                ' Calculate total revenue
                totalRevenue += revenue

                ' Find Best Selling (Highest Sales)
                If sales > highestSales Then
                    highestSales = sales
                    bestSellingProduct = productName
                End If

                ' Find Least Selling (Lowest Sales)
                If sales < lowestSales Then
                    lowestSales = sales
                    leastSellingProduct = productName
                End If
            Next

            xlWorkbook.Close()
            xlApp.Quit()
        Catch ex As Exception
            MessageBox.Show("Error loading Excel data: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateSellingCategories()
        lblBestSelling.Text = bestSellingProduct
        lblLeastSelling.Text = leastSellingProduct
    End Sub

    Private Sub UpdateRevenueDisplay()
        lblRevenue.Text = "₱" & totalRevenue.ToString("N2")
    End Sub

    Private Sub UpdateProgressBar()
        If targetRevenue > 0 Then
            Dim progressValue As Integer = CInt((totalRevenue / targetRevenue) * 100)

            ' Ensure progress is within 0-100 range
            If progressValue > 100 Then progressValue = 100
            If progressValue < 0 Then progressValue = 0

            Guna2CircleProgressBar1.Value = progressValue
            Label6.Text = "Achieve:" & progressValue.ToString() & "% of the Target Revenue"
        End If
    End Sub


    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ' Create and configure the TextBox
        Dim inputTextBox As New TextBox With {
            .Location = New Point(IconButton1.Left, IconButton1.Top + 40),
            .Width = 100
        }

        ' Add the TextBox to the form
        Me.Controls.Add(inputTextBox)
        inputTextBox.BringToFront()

        ' Handle the TextBox's key press event for integer validation
        AddHandler inputTextBox.KeyPress, AddressOf InputTextBox_KeyPress

        ' Handle when user leaves the TextBox or presses Enter
        AddHandler inputTextBox.LostFocus, Sub()
                                               UpdateLabel(inputTextBox)
                                           End Sub
        AddHandler inputTextBox.KeyDown, Sub(senderObj, eArgs)
                                             If eArgs.KeyCode = Keys.Enter Then
                                                 UpdateLabel(inputTextBox)
                                                 inputTextBox.Dispose()
                                             End If
                                         End Sub

        ' Focus on the new TextBox
        inputTextBox.Focus()
    End Sub

    ' Allow only integers in the TextBox
    Private Sub InputTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Update Label2 with the integer value from the TextBox and update progress bar
    Private Sub UpdateLabel(textBox As TextBox)
        Dim newTargetRevenue As Double
        If Double.TryParse(textBox.Text, newTargetRevenue) AndAlso newTargetRevenue > 0 Then
            targetRevenue = newTargetRevenue
            Label2.Text = "₱" & newTargetRevenue.ToString("N2")

            ' Update Progress Bar
            UpdateProgressBar()
        Else
            MessageBox.Show("Please enter a valid number greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Load stored months from Sheet4 and populate ListBox1
    Private Sub LoadStoredMonths()
        Try
            Dim xlApp As New Excel.Application
            Dim xlWorkbook As Excel.Workbook = xlApp.Workbooks.Open("C:\Users\Ivan\Downloads\wetransfer_sales-tracker_2025-01-29_1012\Sales Tracker\SalesData.xlsx")
            Dim xlWorksheet As Excel.Worksheet = CType(xlWorkbook.Sheets(4), Excel.Worksheet)
            Dim xlRange As Excel.Range = xlWorksheet.UsedRange

            ' Add "Current" option
            ListBox1.Items.Add("Current")

            For col As Integer = 2 To xlRange.Columns.Count
                Dim monthName As String = xlRange.Cells(1, col).Value
                If Not String.IsNullOrEmpty(monthName) Then
                    Dim best As String = xlRange.Cells(2, col).Value
                    Dim least As String = xlRange.Cells(3, col).Value
                    storedMonths(monthName) = (best, least)
                    ListBox1.Items.Add(monthName)
                End If
            Next

            xlWorkbook.Close()
            xlApp.Quit()
        Catch ex As Exception
            MessageBox.Show("Error loading stored months: " & ex.Message)
        End Try
    End Sub

    ' Handle month selection from ListBox1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selectedMonth As String = ListBox1.SelectedItem.ToString()

        If selectedMonth = "Current" Then
            ' Show current best/least selling
            lblBestSelling.Text = bestSellingProduct
            lblLeastSelling.Text = leastSellingProduct
        ElseIf storedMonths.ContainsKey(selectedMonth) Then
            ' Show stored best/least selling for that month
            lblBestSelling.Text = storedMonths(selectedMonth).Item1
            lblLeastSelling.Text = storedMonths(selectedMonth).Item2
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class