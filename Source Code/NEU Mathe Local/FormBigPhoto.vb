Public Class FormBigPhoto

    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        If keyData = Keys.Left Or keyData = Keys.Right Or keyData = Keys.Up Or keyData = Keys.Down Or Keys.Enter Then
            Return False '如果是方向键返回FALSE,意思是继续执行form的keydown事件.
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function

    Private Sub FormBigPhoto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Space
                Close()
            Case Keys.Up
                Width = Width + Width * 0.2
                Height = Height + Height * 0.2
                Location = New Point(FormMain.Location.X + (FormMain.Width - Width) / 2, FormMain.Location.Y + (FormMain.Height - Height) / 2)
            Case Keys.Down
                Width = Width - Width * 0.2
                Height = Height - Height * 0.2
                Location = New Point(FormMain.Location.X + (FormMain.Width - Width) / 2, FormMain.Location.Y + (FormMain.Height - Height) / 2)
        End Select
    End Sub

End Class