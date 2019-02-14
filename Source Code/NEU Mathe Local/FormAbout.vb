Public Class FormAbout

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FormAbout_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.Select(0, 0)
    End Sub

End Class