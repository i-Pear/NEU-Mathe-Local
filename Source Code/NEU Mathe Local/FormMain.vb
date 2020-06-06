Imports System.Data.SqlServerCe

Public Class FormMain

    Private DatabaseString As String
    Private MyDatabaseConnection As New SqlCeConnection
    Private MyDataAdaper As SqlCeDataAdapter
    Private MyCommandBuilder As SqlCeCommandBuilder
    Private MyDataSet As New DataSet

    Private ShowingID As Integer
    Friend FriendAnsImage As Image
    Friend FriendAns As Char
    Private CurrentCount As Integer

    Friend Chapterid As String
    Private ChapterSumCount As Integer
    Private ChapterErrorCount As Integer
    Private ChapterNotDoneCount As Integer

    Friend ViewMode As String
    Friend Subject As String
    Friend ConfigPath As String
    Friend MainConfigPath As String = Environment.CurrentDirectory & "\Config Main.ini"

    Private ifChapterShuffle As Boolean
    Private nodes As New ArrayList

    'Private Sub CreateShortcut(lnkFileName As String, Arguments As String)
    '    Dim CreateDir As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    '    Dim wShell As New IWshShell_Class
    '    Dim shortCut As IWshShortcut
    '    shortCut = CType(wShell.CreateShortcut(CreateDir & "/" & lnkFileName & ".lnk"), IWshShortcut)
    '    shortCut.TargetPath = Environment.CurrentDirectory & "\NEU Mathe Local.exe"
    '    shortCut.WindowStyle = 1
    '    shortCut.Arguments = Arguments
    '    shortCut.Description = lnkFileName
    '    shortCut.WorkingDirectory = Environment.CurrentDirectory
    '    shortCut.IconLocation = Environment.CurrentDirectory & "\NEU Mathe Local.exe" & ", " & "0"
    '    shortCut.Save()
    '    wShell = Nothing
    'End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean

        If keyData = Keys.Left Or keyData = Keys.Right Or keyData = Keys.Up Or keyData = Keys.Down Or Keys.Enter Then
            Return False '如果是方向键返回FALSE,意思是继续执行form的keydown事件.
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If

    End Function

    'FormSelectHM.TreeView1.Nodes(chapterCountdown)
    Private Sub getLeaves(ByRef node As TreeNode)
        If node.Nodes.Count = 0 Then
            nodes.Add(node.Name)
            Return
        End If
        For i = 0 To node.Nodes.Count - 1
            getLeaves(node.Nodes(i))
        Next
    End Sub

    Private Sub DisplayDetails()

        ProgressBar1.Maximum = ChapterSumCount
        ProgressBar1.Value = ChapterSumCount - ChapterNotDoneCount

        PictureBox1.Cursor = Cursors.Default
        PictureBox2.Cursor = Cursors.Default
        PictureBox3.Cursor = Cursors.Default
        PictureBox4.Cursor = Cursors.Default

        LabelSum.Text = " Inside this chapater :   Total=" & ChapterSumCount & "  "
        LabelMark.Text = " Marked=" & ChapterErrorCount & "   "
        LabelNotDone.Text = " NotDone=" & ChapterNotDoneCount & "  "

        Try
            CurrentCount = MyDataSet.Tables(0).Rows.Count
        Catch ex As Exception
            MessageBox.Show("Display::CurrentCount Load ERROR:" & ex.Message)
        End Try

        Try
            Dim Bytes0() As Byte = MyDataSet.Tables(0).Rows(ShowingID).Item("img0")
            Dim Bytes1() As Byte = MyDataSet.Tables(0).Rows(ShowingID).Item("img1")
            Dim Bytes2() As Byte = MyDataSet.Tables(0).Rows(ShowingID).Item("img2")
            Dim Bytes3() As Byte = MyDataSet.Tables(0).Rows(ShowingID).Item("img3")
            Dim Bytes4() As Byte = MyDataSet.Tables(0).Rows(ShowingID).Item("img4")
            Dim BytesAns() As Byte = MyDataSet.Tables(0).Rows(ShowingID).Item("imgAns")

            Dim imageStream0 As IO.MemoryStream = New IO.MemoryStream(Bytes0)
            Dim imageStream1 As IO.MemoryStream = New IO.MemoryStream(Bytes1)
            Dim imageStream2 As IO.MemoryStream = New IO.MemoryStream(Bytes2)
            Dim imageStream3 As IO.MemoryStream = New IO.MemoryStream(Bytes3)
            Dim imageStream4 As IO.MemoryStream = New IO.MemoryStream(Bytes4)
            Dim imageStreamAns As IO.MemoryStream = New IO.MemoryStream(BytesAns)

            PictureBox0.Image = New Bitmap(imageStream0)
            PictureBox1.Image = New Bitmap(imageStream1)
            PictureBox2.Image = New Bitmap(imageStream2)
            PictureBox3.Image = New Bitmap(imageStream3)
            PictureBox4.Image = New Bitmap(imageStream4)
            FriendAnsImage = New Bitmap(imageStreamAns)
        Catch ex As Exception
            MessageBox.Show("Display::Images Load ERROR:" & ex.Message)
        End Try

        Try
            LabelID.Text = "Current ID=" & MyDataSet.Tables(0).Rows(ShowingID).Item("id")
        Catch ex As Exception
            MessageBox.Show("Display::CurrentID Load ERROR:" & ex.Message)
        End Try

        Try
            FriendAns = MyDataSet.Tables(0).Rows(ShowingID).Item("ans")
        Catch ex As Exception
            MessageBox.Show("Display::FriendAns Load ERROR:" & ex.Message)
        End Try

        Select Case FriendAns
            Case "1"
                FriendAns = "A"
            Case "2"
                FriendAns = "B"
            Case "3"
                FriendAns = "C"
            Case "4"
                FriendAns = "D"
        End Select
        FormAns.LabelAns.Visible = True
        FormAns.LabelAns.Text = FriendAns

        Try
            If MyDataSet.Tables(0).Rows(ShowingID).Item("mark") = 1 Then
                PictureBoxMark.Visible = True
            Else
                PictureBoxMark.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Display::PictureBoxMark.Visible Load ERROR:" & ex.Message)
        End Try

        Try
            If MyDataSet.Tables(0).Rows(ShowingID).Item("done") = 1 Then
                PictureBoxDone.Visible = True
            Else
                PictureBoxDone.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Display::PictureBoxDone.Visible Load ERROR:" & ex.Message)
        End Try

    End Sub

    Private Sub Display()
        Try
            DisplayDetails()
        Catch ex As Exception
            MessageBox.Show("ERROR Found in Displaying:" & ex.Message)
        End Try
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\shuffle.ini") Then
            ifChapterShuffle = True
            Dim reader As New IO.StreamReader(Environment.CurrentDirectory & "\shuffle.ini")
            Dim chapterCountdown As Integer = reader.ReadLine
            chapterCountdown -= 1
            getLeaves(FormSelectHM.TreeView1.Nodes(chapterCountdown))
            reader.Close()
        Else
            ifChapterShuffle = False
        End If

        '检测文件完整性
        If Not My.Computer.FileSystem.FileExists(Environment.CurrentDirectory & "\System.Data.SqlServerCe.dll") Then
            MessageBox.Show("文件完整性效验失败：缺少System.Data.SqlServerCe.dll")
            Application.Exit()
        End If
        '读取主配置文件
        Try
            Dim MainConfigReader As New IO.StreamReader(MainConfigPath)
            Subject = MainConfigReader.ReadLine
            ViewMode = MainConfigReader.ReadLine
            MainConfigReader.Dispose()
        Catch ex As Exception
            Subject = "HM"
            ViewMode = "All"
        End Try
        '检测初始化参数
        If Subject = "HM" Then
            Text = "NEU Mathe Local - Higher Mathematics"
            DatabaseString = "Data Source=" & Environment.CurrentDirectory & "\HM.sdf;password=20000211"
            ConfigPath = Environment.CurrentDirectory & "\Config HM.ini"
        ElseIf Subject = "LA" Then
            Text = "NEU Mathe Local - Linear Algebra"
            DatabaseString = "Data Source=" & Environment.CurrentDirectory & "\LA.sdf;password=20000211"
            ConfigPath = Environment.CurrentDirectory & "\Config LA.ini"
        ElseIf Subject = "PT" Then
            Text = "NEU Mathe Local - Probability Theory"
            DatabaseString = "Data Source=" & Environment.CurrentDirectory & "\PT.sdf;password=20000211"
            ConfigPath = Environment.CurrentDirectory & "\Config PT.ini"
        Else
            Text = "NEU Mathe Local - Higher Mathematics"
            DatabaseString = "Data Source=" & Environment.CurrentDirectory & "\HM.sdf;password=20000211"
            ConfigPath = Environment.CurrentDirectory & "\Config HM.ini"
        End If
        '开始加载数据
        LoadDatabase()
    End Sub

    Private Sub LoadDatabase()
        '加载Config.ini
        Try
            Dim Reader As New IO.StreamReader(ConfigPath)
            Chapterid = Reader.ReadLine
            Reader.Dispose()
        Catch ex As Exception
            Select Case Subject
                Case "HM"
                    Chapterid = "e624c53dff2d48e6bb1932c1b5e640e0"
                Case "LA"
                    Chapterid = "a5b2ae18c3114b4595d4f6a8816e32b2"
                Case "PT"
                    Chapterid = "39"
            End Select
        End Try
        '初始化数据库连接
        Try
            MyDatabaseConnection.ConnectionString = DatabaseString
            MyDatabaseConnection.Open()
            Try
                '加载计数器
                LoadCounts()
            Catch ex As Exception
                MessageBox.Show("Load Counts ERROR:" & ex.Message)
            End Try
            '加载数据
            Dim cmd As SqlCeCommand = MyDatabaseConnection.CreateCommand

            If ifChapterShuffle Then
                Dim s = "SELECT id,img0,img1,img2,img3,img4,imgans,ans,done,mark FROM main WHERE "
                Dim ifFirst As Boolean = True
                For Each node In nodes
                    If ifFirst Then
                        s = s & " parent = '" & node & "' "
                        ifFirst = False
                    Else
                        s = s & " or parent = '" & node & "' "
                    End If
                Next
                cmd.CommandText = s & " ORDER BY RAND();"
            Else
                Select Case ViewMode
                    Case "All"
                        cmd.CommandText = "SELECT id,img0,img1,img2,img3,img4,imgans,ans,done,mark FROM main WHERE parent = '" & Chapterid & "' ORDER BY id;"
                    Case "Error"
                        cmd.CommandText = "SELECT id,img0,img1,img2,img3,img4,imgans,ans,done,mark FROM main WHERE parent = '" & Chapterid & "' AND mark = 1 ORDER BY id;"
                    Case "NotDone"
                        cmd.CommandText = "SELECT id,img0,img1,img2,img3,img4,imgans,ans,done,mark FROM main WHERE parent = '" & Chapterid & "' AND done = 0 ORDER BY id;"
                End Select
            End If

            MyDataAdaper = New SqlCeDataAdapter(cmd)
            MyCommandBuilder = New SqlCeCommandBuilder With {
                .DataAdapter = MyDataAdaper
            }
            MyDataSet = New DataSet
            MyDataAdaper.Fill(MyDataSet)
        Catch ex As Exception
            MessageBox.Show("SQL Connection Failed：" & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub LoadCounts()
        Dim cmd As SqlCeCommand = MyDatabaseConnection.CreateCommand
        'Part Sum
        If ifChapterShuffle Then
            Dim s = "SELECT COUNT(*) as count FROM main WHERE "
            Dim ifFirst As Boolean = True
            For Each node In nodes
                If ifFirst Then
                    s = s & " parent = '" & node & "' "
                    ifFirst = False
                Else
                    s = s & " or parent = '" & node & "' "
                End If
            Next
            cmd.CommandText = s & " ;"
        Else
            cmd.CommandText = "SELECT COUNT(*) as count FROM main WHERE parent = '" & Chapterid & "';"
        End If
        MyDataAdaper = New SqlCeDataAdapter(cmd)
        MyCommandBuilder = New SqlCeCommandBuilder With {
        .DataAdapter = MyDataAdaper
            }
        MyDataSet = New DataSet
        MyDataAdaper.Fill(MyDataSet)
        ChapterSumCount = MyDataSet.Tables(0).Rows(0).Item(0)
        'Part Error
        If ifChapterShuffle Then
            Dim s = "SELECT COUNT(*) as count FROM main WHERE "
            Dim ifFirst As Boolean = True
            For Each node In nodes
                If ifFirst Then
                    s = s & " parent = '" & node & "' "
                    ifFirst = False
                Else
                    s = s & " or parent = '" & node & "' "
                End If
            Next
            cmd.CommandText = s & " AND mark = 1;"
        Else
            cmd.CommandText = "SELECT COUNT(*) as count FROM main WHERE parent = '" & Chapterid & "' AND mark = 1;"
        End If
        MyDataAdaper = New SqlCeDataAdapter(cmd)
        MyCommandBuilder = New SqlCeCommandBuilder With {
            .DataAdapter = MyDataAdaper
            }
        MyDataSet = New DataSet
        MyDataAdaper.Fill(MyDataSet)
        ChapterErrorCount = MyDataSet.Tables(0).Rows(0).Item(0)
        If ChapterErrorCount = 0 And ViewMode = "Error" Then
            Dim Writter As New IO.StreamWriter(MainConfigPath, False)
            Writter.WriteLine(Subject)
            Writter.WriteLine("All")
            Writter.Dispose()
            MessageBox.Show("ERROR: Can't find any marked problem in this character. Failed in initializing. Restarting program in common mode...", "NEU Mathe Local Project")
            Application.Restart()
        End If
        'Part NotDone
        If ifChapterShuffle Then
            Dim s = "SELECT COUNT(*) as count FROM main WHERE "
            Dim ifFirst As Boolean = True
            For Each node In nodes
                If ifFirst Then
                    s = s & " parent = '" & node & "' "
                    ifFirst = False
                Else
                    s = s & " or parent = '" & node & "' "
                End If
            Next
            cmd.CommandText = s & " AND done = 0;"
        Else
            cmd.CommandText = "SELECT COUNT(*) as count FROM main WHERE parent = '" & Chapterid & "' AND done = 0;"
        End If
        MyDataAdaper = New SqlCeDataAdapter(cmd)
        MyCommandBuilder = New SqlCeCommandBuilder With {
            .DataAdapter = MyDataAdaper
        }
        MyDataSet = New DataSet
        MyDataAdaper.Fill(MyDataSet)
        ChapterNotDoneCount = MyDataSet.Tables(0).Rows(0).Item(0)

        If ChapterNotDoneCount = 0 And ViewMode = "NotDone" Then
            Dim Writter As New IO.StreamWriter(MainConfigPath, False)
            Writter.WriteLine(Subject)
            Writter.WriteLine("All")
            Writter.Dispose()
            MessageBox.Show("ERROR: Can't find any problem which have not been done in this character. Failed in initializing. Restarting program in common mode...", "NEU Mathe Local Project")
            Application.Restart()
        End If
    End Sub

    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode
            Case Keys.Right
                If ShowingID = CurrentCount - 1 Then
                    Exit Sub
                End If
                ShowingID = ShowingID + 1
                Display()
            Case Keys.Left
                If ShowingID = 0 Then
                    Exit Sub
                End If
                ShowingID = ShowingID - 1
                Display()
            Case Keys.Enter
                FormAns.PictureBoxAns.Image = FriendAnsImage
                FormAns.Width = FriendAnsImage.Width * 2
                FormAns.Height = FriendAnsImage.Height * 2
                FormAns.ShowDialog()
            Case Keys.ControlKey
                If PictureBoxDone.Visible = True Then
                    MyDataSet.Tables(0).Rows(ShowingID).Item("done") = 0
                    MyDataAdaper.Update(MyDataSet)
                    ChapterNotDoneCount = ChapterNotDoneCount + 1
                    Display()
                Else
                    MyDataSet.Tables(0).Rows(ShowingID).Item("done") = 1
                    MyDataAdaper.Update(MyDataSet)
                    ChapterNotDoneCount = ChapterNotDoneCount - 1
                    Display()
                End If
            Case Keys.Space
                FormBigPhoto.PictureBox1.Image = PictureBox0.Image
                FormBigPhoto.Width = PictureBox0.Image.Width
                FormBigPhoto.Height = PictureBox0.Image.Height
                FormBigPhoto.ShowDialog()
            Case Keys.T
                If TopMost = True Then
                    TopMost = False
                Else
                    TopMost = True
                End If
        End Select

    End Sub

    Private Sub FormMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ShowingID = 0
        ChangeSize()
        Display()
    End Sub

    Private Sub PictureBox0_Click(sender As Object, e As EventArgs) Handles PictureBox0.Click
        '此处为Mark标签操作
        If PictureBoxMark.Visible = True Then
            MyDataSet.Tables(0).Rows(ShowingID).Item("mark") = 0
            MyDataAdaper.Update(MyDataSet)
            ChapterErrorCount = ChapterErrorCount - 1
            Display()
        Else
            MyDataSet.Tables(0).Rows(ShowingID).Item("mark") = 1
            MyDataAdaper.Update(MyDataSet)
            ChapterErrorCount = ChapterErrorCount + 1
            Display()
        End If
    End Sub

    Private Sub UnloadDatabase()
        MyDatabaseConnection.Close()
    End Sub

    Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UnloadDatabase()
    End Sub

    Private Sub ToolStripDropDownButton2_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton2.Click
        FormAbout.ShowDialog()
    End Sub

    Private Sub LabelSum_DoubleClick(sender As Object, e As EventArgs) Handles LabelSum.DoubleClick
        Dim Writter As New IO.StreamWriter(MainConfigPath, False)
        Writter.WriteLine(Subject)
        Writter.WriteLine("All")
        Writter.Dispose()
        Application.Restart()
    End Sub

    Private Sub LabelMark_DoubleClick(sender As Object, e As EventArgs) Handles LabelMark.DoubleClick
        Dim Writter As New IO.StreamWriter(MainConfigPath, False)
        Writter.WriteLine(Subject)
        Writter.WriteLine("Error")
        Writter.Dispose()
        Application.Restart()
    End Sub

    Private Sub LabelNotDone_DoubleClick(sender As Object, e As EventArgs) Handles LabelNotDone.DoubleClick
        Dim Writter As New IO.StreamWriter(MainConfigPath, False)
        Writter.WriteLine(Subject)
        Writter.WriteLine("NotDone")
        Writter.Dispose()
        Application.Restart()
    End Sub

    Private Sub A_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If FriendAns = "A" Then
            PictureBox1.Cursor = Cursors.WaitCursor
        Else
            PictureBox1.Cursor = Cursors.No
        End If
    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If FriendAns = "B" Then
            PictureBox2.Cursor = Cursors.WaitCursor
        Else
            PictureBox2.Cursor = Cursors.No
        End If
    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If FriendAns = "C" Then
            PictureBox3.Cursor = Cursors.WaitCursor
        Else
            PictureBox3.Cursor = Cursors.No
        End If
    End Sub

    Private Sub D_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If FriendAns = "D" Then
            PictureBox4.Cursor = Cursors.WaitCursor
        Else
            PictureBox4.Cursor = Cursors.No
        End If
    End Sub

    Private Sub FormMain_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ChangeSize()
    End Sub

    Private Sub ChangeSize()
        ProgressBar1.Size = New Size(Width - ToolStripDropDownButton1.Width - ToolStripDropDownButton2.Width - LabelID.Width - LabelSum.Width _
                             - LabelNotDone.Width - LabelMark.Width - 50, ProgressBar1.Size.Height)
        Dim InsideWidth As Integer = Width - 20
        Dim InsideHeight As Integer = Height - StatusStrip1.Height - 50

        PictureBox0.Size = New Size(InsideWidth, InsideHeight * 4 / 10)
        PictureBox0.Location = New Point(0, 0)

        PictureBox1.Size = New Size(InsideWidth / 2, InsideHeight * 3 / 10)
        PictureBox1.Location = New Point(0, InsideHeight * 4 / 10)

        PictureBox2.Size = New Size(InsideWidth / 2, InsideHeight * 3 / 10)
        PictureBox2.Location = New Point(InsideWidth / 2, InsideHeight * 4 / 10)

        PictureBox3.Size = New Size(InsideWidth / 2, InsideHeight * 3 / 10)
        PictureBox3.Location = New Point(0, InsideHeight * 7 / 10)

        PictureBox4.Size = New Size(InsideWidth / 2, InsideHeight * 3 / 10)
        PictureBox4.Location = New Point(InsideWidth / 2, InsideHeight * 7 / 10)
    End Sub

    Private Sub ChooseSubject_Click(sender As Object, e As EventArgs) Handles ChooseSubjectToolStripMenuItem.Click
        FormSelect_Main.ShowDialog()
    End Sub

    Private Sub ChooseChapter_Click(sender As Object, e As EventArgs) Handles ChooseChapterToolStripMenuItem.Click
        Select Case Subject
            Case "HM"
                FormSelectHM.ShowDialog()
            Case "LA"
                FormSelectLA.ShowDialog()
            Case "PT"
                FormSelectPT.ShowDialog()
        End Select
    End Sub

End Class