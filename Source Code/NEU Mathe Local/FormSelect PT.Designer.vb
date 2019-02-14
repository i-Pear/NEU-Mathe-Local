<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectPT
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点0")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1.1 分布律及其性质(34题)")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1.2.1.1 二项分布（0-1分布）(28题)")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1.2.1.2 泊松分布、超几何分布和几何分布(13题)")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1.2.1 常见的离散型随机变量的概率计算(41题)", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1.2.2 一般离散型随机变量的概率计算(8题)")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1.2 离散型随机变量的概率计算(49题)", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1 离散型随机变量及其分布(83题)", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.1 概率密度及其性质(23题)")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.4.1.1 均匀分布与指数分布(18题)")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.4.1.2 正态分布(14题)")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.4.1 常见连续型随机变量的概率计算(32题)", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11})
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.4.2 一般连续型随机变量事件的概率计算(27题)")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.4 连续型随机变量的概率计算(59题)", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.2 正态分布及其性质(10题)")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.3 正态分布标准化与应用(19题)")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2 连续型随机变量及其分布(111题)", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode14, TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.3.1 分布函数及其性质(0题)")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.3.2 分布函数与分布律(22题)")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.3.3 分布函数与概率密度(12题)")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.3.4 分布函数与概率计算(13题)")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.3 随机变量的分布函数(47题)", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.4.1 离散型随机变量的函数的分布(7题)")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.4.2.1 连续函数情形(37题)")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.4.2.2 非连续函数情形(0题)")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.4.2 连续型随机变量的函数的分布(37题)", New System.Windows.Forms.TreeNode() {TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.4 随机变量的函数的分布(44题)", New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("第2章 随机变量及其分布(285题)", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode17, TreeNode22, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点2")
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点3")
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点4")
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点5")
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点6")
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("节点7")
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "节点0"
        TreeNode1.Text = "节点0"
        TreeNode2.Name = "39"
        TreeNode2.Text = "2.1.1 分布律及其性质(34题)"
        TreeNode3.Name = "43"
        TreeNode3.Text = "2.1.2.1.1 二项分布（0-1分布）(28题)"
        TreeNode4.Name = "44"
        TreeNode4.Text = "2.1.2.1.2 泊松分布、超几何分布和几何分布(13题)"
        TreeNode5.Name = "节点24"
        TreeNode5.Text = "2.1.2.1 常见的离散型随机变量的概率计算(41题)"
        TreeNode6.Name = "45"
        TreeNode6.Text = "2.1.2.2 一般离散型随机变量的概率计算(8题)"
        TreeNode7.Name = "节点13"
        TreeNode7.Text = "2.1.2 离散型随机变量的概率计算(49题)"
        TreeNode8.Name = "38"
        TreeNode8.Text = "2.1 离散型随机变量及其分布(83题)"
        TreeNode9.Name = "47"
        TreeNode9.Text = "2.2.1 概率密度及其性质(23题)"
        TreeNode10.Name = "52"
        TreeNode10.Text = "2.2.4.1.1 均匀分布与指数分布(18题)"
        TreeNode11.Name = "54"
        TreeNode11.Text = "2.2.4.1.2 正态分布(14题)"
        TreeNode12.Name = "51"
        TreeNode12.Text = "2.2.4.1 常见连续型随机变量的概率计算(32题)"
        TreeNode13.Name = "55"
        TreeNode13.Text = "2.2.4.2 一般连续型随机变量事件的概率计算(27题)"
        TreeNode14.Name = "节点15"
        TreeNode14.Text = "2.2.4 连续型随机变量的概率计算(59题)"
        TreeNode15.Name = "68"
        TreeNode15.Text = "2.2.2 正态分布及其性质(10题)"
        TreeNode16.Name = "110"
        TreeNode16.Text = "2.2.3 正态分布标准化与应用(19题)"
        TreeNode17.Name = "46"
        TreeNode17.Text = "2.2 连续型随机变量及其分布(111题)"
        TreeNode18.Name = "58"
        TreeNode18.Text = "2.3.1 分布函数及其性质(0题)"
        TreeNode19.Name = "59"
        TreeNode19.Text = "2.3.2 分布函数与分布律(22题)"
        TreeNode20.Name = "60"
        TreeNode20.Text = "2.3.3 分布函数与概率密度(12题)"
        TreeNode21.Name = "62"
        TreeNode21.Text = "2.3.4 分布函数与概率计算(13题)"
        TreeNode22.Name = "57"
        TreeNode22.Text = "2.3 随机变量的分布函数(47题)"
        TreeNode23.Name = "64"
        TreeNode23.Text = "2.4.1 离散型随机变量的函数的分布(7题)"
        TreeNode24.Name = "66"
        TreeNode24.Text = "2.4.2.1 连续函数情形(37题)"
        TreeNode25.Name = "67"
        TreeNode25.Text = "2.4.2.2 非连续函数情形(0题)"
        TreeNode26.Name = "节点23"
        TreeNode26.Text = "2.4.2 连续型随机变量的函数的分布(37题)"
        TreeNode27.Name = "63"
        TreeNode27.Text = "2.4 随机变量的函数的分布(44题)"
        TreeNode28.Name = "6"
        TreeNode28.Text = "第2章 随机变量及其分布(285题)"
        TreeNode29.Name = "节点2"
        TreeNode29.Text = "节点2"
        TreeNode30.Name = "节点3"
        TreeNode30.Text = "节点3"
        TreeNode31.Name = "节点4"
        TreeNode31.Text = "节点4"
        TreeNode32.Name = "节点5"
        TreeNode32.Text = "节点5"
        TreeNode33.Name = "节点6"
        TreeNode33.Text = "节点6"
        TreeNode34.Name = "节点7"
        TreeNode34.Text = "节点7"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32, TreeNode33, TreeNode34})
        Me.TreeView1.Size = New System.Drawing.Size(776, 426)
        Me.TreeView1.TabIndex = 1
        '
        'FormSelectPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.TreeView1)
        Me.KeyPreview = True
        Me.Name = "FormSelectPT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Double Click To Choose A Chapter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
End Class
