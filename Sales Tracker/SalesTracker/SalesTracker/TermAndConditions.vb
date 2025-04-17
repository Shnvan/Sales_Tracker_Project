Public Class TermAndConditions
    ' Event handler to handle the closing of the form
    Private originalPositions As New Dictionary(Of Control, Integer)


    Private Sub TermAndConditions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure VScrollBar properties
        VScrollBar1.Minimum = 0
        VScrollBar1.Maximum = 200 ' Adjust the range if needed
        VScrollBar1.LargeChange = 10
        VScrollBar1.SmallChange = 1

        ' Store the initial positions of all controls
        For Each ctrl As Control In Me.Controls
            If ctrl IsNot VScrollBar1 Then ' Skip the scrollbar itself
                originalPositions(ctrl) = ctrl.Top
            End If
        Next
    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll
        ' Update the position of all controls based on the scroll value
        For Each ctrl As Control In originalPositions.Keys
            ctrl.Top = originalPositions(ctrl) - VScrollBar1.Value
        Next
    End Sub





    Private Sub TermAndConditions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if the user is trying to close the form
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True ' This cancels the closing operation
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PublicVariables.userAgree = True
        Me.Hide()
        My.Settings.UserAgree = True
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PublicVariables.userAgree = False
        LoginForm.Hide()
        My.Settings.UserAgree = False
        My.Settings.Save()
        Application.Exit()
    End Sub


End Class