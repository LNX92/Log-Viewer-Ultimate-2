Imports DevExpress.XtraSplashScreen
Public Class AddTableErrorForm
    Public Handle As IOverlaySplashScreenHandle = Nothing

    Private Function ShowProgressPanel() As IOverlaySplashScreenHandle
        Dim handle As IOverlaySplashScreenHandle = SplashScreenManager.ShowOverlayForm(Me)
        Return handle
    End Function

    Public Sub CloseProgressPanel(ByVal handle As IOverlaySplashScreenHandle)
        If handle IsNot Nothing Then SplashScreenManager.CloseOverlayForm(handle)
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error Resume Next

        If (ComboBoxEdit1.Text = "Favori Listesi 1") Then
            Handle = ShowProgressPanel()
            AnalysisModule.AddFavouriteError_1()
        ElseIf (ComboBoxEdit1.Text = "Favori Listesi 2") Then
            Handle = ShowProgressPanel()
            AnalysisModule.AddFavouriteError_2()
        ElseIf (ComboBoxEdit1.Text = "Favori Listesi 3") Then
            Handle = ShowProgressPanel()
            AnalysisModule.AddFavouriteError_3()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Me.Hide()
    End Sub
End Class