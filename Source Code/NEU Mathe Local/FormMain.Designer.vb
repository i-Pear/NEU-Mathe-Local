<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.PictureBox0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ChooseSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChooseChapterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelID = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelSum = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelNotDone = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LabelMark = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.PictureBoxMark = New System.Windows.Forms.PictureBox()
        Me.PictureBoxDone = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBoxMark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxDone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox0
        '
        Me.PictureBox0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox0.Image = CType(resources.GetObject("PictureBox0.Image"), System.Drawing.Image)
        Me.PictureBox0.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox0.Name = "PictureBox0"
        Me.PictureBox0.Size = New System.Drawing.Size(1135, 200)
        Me.PictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox0.TabIndex = 0
        Me.PictureBox0.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 218)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(561, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(579, 218)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(568, 150)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 374)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(561, 146)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(579, 374)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(568, 146)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton1, Me.LabelID, Me.LabelSum, Me.LabelNotDone, Me.LabelMark, Me.ProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 520)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1159, 28)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.ShowDropDownArrow = False
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(24, 26)
        Me.ToolStripDropDownButton2.Text = "ToolStripDropDownButton1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChooseSubjectToolStripMenuItem, Me.ChooseChapterToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.ShowDropDownArrow = False
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(24, 26)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'ChooseSubjectToolStripMenuItem
        '
        Me.ChooseSubjectToolStripMenuItem.Name = "ChooseSubjectToolStripMenuItem"
        Me.ChooseSubjectToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.ChooseSubjectToolStripMenuItem.Text = "Choose Subject"
        '
        'ChooseChapterToolStripMenuItem
        '
        Me.ChooseChapterToolStripMenuItem.Name = "ChooseChapterToolStripMenuItem"
        Me.ChooseChapterToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.ChooseChapterToolStripMenuItem.Text = "Choose Chapter"
        '
        'LabelID
        '
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(121, 23)
        Me.LabelID.Text = "Current ID=100"
        '
        'LabelSum
        '
        Me.LabelSum.DoubleClickEnabled = True
        Me.LabelSum.Name = "LabelSum"
        Me.LabelSum.Size = New System.Drawing.Size(257, 23)
        Me.LabelSum.Text = " Inside this chapater :   Total=100  "
        '
        'LabelNotDone
        '
        Me.LabelNotDone.DoubleClickEnabled = True
        Me.LabelNotDone.Name = "LabelNotDone"
        Me.LabelNotDone.Size = New System.Drawing.Size(117, 23)
        Me.LabelNotDone.Text = " NotDone=10  "
        '
        'LabelMark
        '
        Me.LabelMark.DoubleClickEnabled = True
        Me.LabelMark.Name = "LabelMark"
        Me.LabelMark.Size = New System.Drawing.Size(106, 23)
        Me.LabelMark.Text = " Marked=10  "
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(500, 22)
        '
        'PictureBoxMark
        '
        Me.PictureBoxMark.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMark.Image = CType(resources.GetObject("PictureBoxMark.Image"), System.Drawing.Image)
        Me.PictureBoxMark.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxMark.Name = "PictureBoxMark"
        Me.PictureBoxMark.Size = New System.Drawing.Size(54, 71)
        Me.PictureBoxMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxMark.TabIndex = 7
        Me.PictureBoxMark.TabStop = False
        Me.PictureBoxMark.Visible = False
        '
        'PictureBoxDone
        '
        Me.PictureBoxDone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxDone.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxDone.Image = CType(resources.GetObject("PictureBoxDone.Image"), System.Drawing.Image)
        Me.PictureBoxDone.Location = New System.Drawing.Point(1067, 12)
        Me.PictureBoxDone.Name = "PictureBoxDone"
        Me.PictureBoxDone.Size = New System.Drawing.Size(80, 71)
        Me.PictureBoxDone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxDone.TabIndex = 8
        Me.PictureBoxDone.TabStop = False
        Me.PictureBoxDone.Visible = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1159, 548)
        Me.Controls.Add(Me.PictureBoxDone)
        Me.Controls.Add(Me.PictureBoxMark)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEU Mathe Local"
        CType(Me.PictureBox0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBoxMark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxDone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox0 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LabelID As ToolStripStatusLabel
    Friend WithEvents PictureBoxMark As PictureBox
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents PictureBoxDone As PictureBox
    Friend WithEvents LabelSum As ToolStripStatusLabel
    Friend WithEvents LabelMark As ToolStripStatusLabel
    Friend WithEvents LabelNotDone As ToolStripStatusLabel
    Friend WithEvents ProgressBar1 As ToolStripProgressBar
    Friend WithEvents ChooseSubjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChooseChapterToolStripMenuItem As ToolStripMenuItem
End Class
