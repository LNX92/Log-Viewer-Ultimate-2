Public Class TableSelectionForm
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Form1.GridView1.OptionsSelection.MultiSelect = True
        Me.Hide()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        On Error Resume Next
        AnalysisModule.TableSelection()
    End Sub
End Class