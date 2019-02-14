Public Class FormSelect_Main

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click
        Dim subject As String
        If CheckBox1.Checked Then
            subject = "HM"
        ElseIf CheckBox2.Checked Then
            subject = "LA"
        ElseIf CheckBox3.Checked Then
            subject = "PT"
        Else
            Exit Sub
        End If

        Dim Writter As New IO.StreamWriter(FormMain.MainConfigPath, False)
        Writter.WriteLine(subject)
        Writter.WriteLine(FormMain.ViewMode)
        Writter.Dispose()
        Application.Restart()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
        CheckBox3.Checked = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

End Class