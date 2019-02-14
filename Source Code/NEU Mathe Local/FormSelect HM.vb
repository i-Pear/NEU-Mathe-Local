Public Class FormSelectHM

    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean

        If keyData = Keys.Left Or keyData = Keys.Right Or keyData = Keys.Up Or keyData = Keys.Down Or Keys.Enter Then
            Return False '如果是方向键返回FALSE,意思是继续执行form的keydown事件.
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If

    End Function

    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Close()
        End If
    End Sub

    Private Sub TreeView1_DoubleClick(sender As Object, e As EventArgs) Handles TreeView1.DoubleClick
        If TreeView1.SelectedNode.GetNodeCount(True) > 0 Then
            Exit Sub
        End If
        Dim Writter As New IO.StreamWriter(FormMain.ConfigPath, False)
        Writter.WriteLine(TreeView1.SelectedNode.Name)
        Writter.Dispose()
        Application.Restart()
    End Sub

    Private Sub FormSelect_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Dim tnRet As TreeNode = Nothing
            For Each tn As TreeNode In TreeView1.Nodes
                tnRet = FindNode(tn, FormMain.Chapterid)
                If Not (tnRet Is Nothing) Then
                    Exit For
                End If
            Next
            tnRet.Parent.ExpandAll()
        Catch ex As Exception
        End Try
    End Sub

    Private Function FindNode(ByVal tnParent As TreeNode, ByRef strValue As String) As TreeNode
        If (tnParent Is Nothing) Then
            Return Nothing
        End If
        If (tnParent.Name = strValue) Then
            Return tnParent
        End If

        Dim tnRet As TreeNode = Nothing
        For Each tn As TreeNode In tnParent.Nodes
            tnRet = FindNode(tn, strValue)
            If Not (tnRet Is Nothing) Then
                Exit For
            End If
        Next
        Return tnRet
    End Function

End Class