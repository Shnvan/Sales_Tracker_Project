Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Purchase_Click(sender As Object, e As EventArgs) Handles Purchase.Click
        Me.Hide()
        ' Create an instance of the Home form
        ' Set the Home form to be a child of Panel3 in Form3
        addPurchase.TopLevel = False
        addPurchase.FormBorderStyle = FormBorderStyle.None
        addPurchase.Dock = DockStyle.Fill

        ' Add the Home form to Panel3 of Form3
        SalesTrackerIn.Panel3.Controls.Add(addPurchase)

        ' Show the Home form inside Panel3
        addPurchase.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ' Create an instance of the Home form
        ' Set the Home form to be a child of Panel3 in Form3
        addProducts.TopLevel = False
        addProducts.FormBorderStyle = FormBorderStyle.None
        addProducts.Dock = DockStyle.Fill

        ' Add the Home form to Panel3 of Form3
        SalesTrackerIn.Panel3.Controls.Add(addProducts)

        ' Show the Home form inside Panel3
        addProducts.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ' Create an instance of the Home form
        ' Set the Home form to be a child of Panel3 in Form3
        PurchaseHistory.TopLevel = False
        PurchaseHistory.FormBorderStyle = FormBorderStyle.None
        PurchaseHistory.Dock = DockStyle.Fill

        ' Add the Home form to Panel3 of Form3
        SalesTrackerIn.Panel3.Controls.Add(PurchaseHistory)

        ' Show the Home form inside Panel3
        PurchaseHistory.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        ' Create an instance of the Home form
        ' Set the Home form to be a child of Panel3 in Form3
        allProducts.TopLevel = False
        allProducts.FormBorderStyle = FormBorderStyle.None
        allProducts.Dock = DockStyle.Fill

        ' Add the Home form to Panel3 of Form3
        SalesTrackerIn.Panel3.Controls.Add(allProducts)

        ' Show the Home form inside Panel3
        allProducts.Show()
    End Sub


End Class