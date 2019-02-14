Public Class FormAns

    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean

        If keyData = Keys.Left Or keyData = Keys.Right Or keyData = Keys.Up Or keyData = Keys.Down Or Keys.Enter Then
            Return False '如果是方向键返回FALSE,意思是继续执行form的keydown事件.
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If

    End Function

    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Height = Height + Height * 0.2
                Location = New Point((Screen.PrimaryScreen.Bounds.Width - Width) / 2, (Screen.PrimaryScreen.Bounds.Height - Height) / 2)
            Case Keys.Down
                Height = Height - Height * 0.2
                Location = New Point((Screen.PrimaryScreen.Bounds.Width - Width) / 2, (Screen.PrimaryScreen.Bounds.Height - Height) / 2)
            Case Keys.Enter
                Close()
        End Select
    End Sub

    Private Sub LabelAns_Click(sender As Object, e As EventArgs) Handles LabelAns.Click
        LabelAns.Visible = False
    End Sub

End Class