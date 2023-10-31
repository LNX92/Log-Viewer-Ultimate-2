Imports System.Text.RegularExpressions
Public Module SettingsModule
    Public AnalysisCheckState As String = ""
    Public FastScanMode As String = ""

    Public Sub FastScanModeCheckModule()
        On Error Resume Next

        If (FastScanMode = "0") Then
            SettingsForm.ToggleSwitch2.IsOn = False
        ElseIf (FastScanMode = "1") Then
            SettingsForm.ToggleSwitch2.IsOn = True
        End If
    End Sub
    Public Sub AnalysisMethodChange()
        On Error Resume Next

        If (SettingsForm.ToggleSwitch1.IsOn = True) Then
            System.IO.File.WriteAllText("C:\SWQA Log Viewer Ultimate 2\Settings\AnalysisType.txt", "Normal")
        ElseIf (SettingsForm.ToggleSwitch1.IsOn = False) Then
            System.IO.File.WriteAllText("C:\SWQA Log Viewer Ultimate 2\Settings\AnalysisType.txt", "Advanced")
        End If
    End Sub
    Public Sub LoadAnalysisCheckState()
        On Error Resume Next
        AnalysisCheckState = System.IO.File.ReadAllText("C:\SWQA Log Viewer Ultimate 2\Settings\AnalysisType.txt")

        If (AnalysisCheckState = "Normal") Then
            SettingsForm.ToggleSwitch1.IsOn = False
        ElseIf (AnalysisCheckState = "Advanced") Then
            SettingsForm.ToggleSwitch1.IsOn = True
        End If
    End Sub
End Module
