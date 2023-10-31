Public Class AddErrorForm
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        DatabaseModule.AddError()
    End Sub

    Private Sub AddErrorForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        On Error Resume Next
        e.Cancel = False

        If (DatabaseModule.CurrentDatabase = "Main") Then
            AnalysisModule.LoadErrorTable()
        ElseIf (DatabaseModule.CurrentDatabase = "Favourites_1") Then
            AnalysisModule.LoadFavouritesList_1()
        ElseIf (DatabaseModule.CurrentDatabase = "Favourites_2") Then
            AnalysisModule.LoadFavouritesList_2()
        ElseIf (DatabaseModule.CurrentDatabase = "Favourites_3") Then
            AnalysisModule.LoadFavouritesList_3()
        End If

        Me.Hide()
    End Sub

    Private Sub TextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextEdit1.KeyDown
        On Error Resume Next

        If (e.KeyCode = Keys.Enter) Then
            DatabaseModule.AddError()
        End If
    End Sub
End Class