Imports System.Text.RegularExpressions
Public Class SettingsForm
    Private Sub ToggleSwitch1_Click(sender As Object, e As EventArgs) Handles ToggleSwitch1.Click
        On Error Resume Next
        SettingsModule.AnalysisMethodChange()
    End Sub

    Private Sub ToggleSwitch2_Click(sender As Object, e As EventArgs) Handles ToggleSwitch2.Click
        On Error Resume Next

        If (ToggleSwitch2.IsOn = True) Then
            System.IO.File.WriteAllText("C:\SWQA Log Viewer Ultimate 2\Settings\FastScanMode.txt", "0")
            SettingsModule.FastScanMode = "0"
        ElseIf (ToggleSwitch2.IsOn = False) Then
            System.IO.File.WriteAllText("C:\SWQA Log Viewer Ultimate 2\Settings\FastScanMode.txt", "1")
            SettingsModule.FastScanMode = "1"
        End If
    End Sub
End Class