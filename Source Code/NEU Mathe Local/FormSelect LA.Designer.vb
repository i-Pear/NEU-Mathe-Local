<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectLA
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("行列式概念、性质及其计算(80题)")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cramer法则(15题)")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("第一章 行列式(95题)", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("矩阵及其运算、分块矩阵(95题)")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("逆矩阵、矩阵方程(60题)")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("初等变换和初等矩阵(60题)")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("第二章 矩阵(215题)", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("向量概念及其性质、内积、正交(34题)")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("向量的线性表示、向量组的线性相关性(35题)")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("极大无关组、向量和矩阵的秩(33题)")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("第三章 向量组的线性相关性(102题)", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("线性方程组解判定及其求解(35题)")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("基础解系和解的结构(60题)")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("向量空间(68题)")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("第四章 线性方程组(163题)", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("矩阵特征值和特征向量(35题)")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("矩阵相似及相似对角化(35题)")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("第五章 矩阵相似对角化(70题)", New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("二次型概念、惯性定理、正定二次型(59题)")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("矩阵合同，化二次型为标准形(60题)")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("第六章 二次型(119题)", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("线性空间(41题)")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("线性变换、欧几里得空间(65题)")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("第七章 线性空间与线性变换(106题)", New System.Windows.Forms.TreeNode() {TreeNode22, TreeNode23})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "a5b2ae18c3114b4595d4f6a8816e32b2"
        TreeNode1.Text = "行列式概念、性质及其计算(80题)"
        TreeNode2.Name = "ba19594dbbc04ae99df34522731e8027"
        TreeNode2.Text = "Cramer法则(15题)"
        TreeNode3.Name = "1"
        TreeNode3.Text = "第一章 行列式(95题)"
        TreeNode4.Name = "aee2bf4e14994f55a09daa3e5cfaa780"
        TreeNode4.Text = "矩阵及其运算、分块矩阵(95题)"
        TreeNode5.Name = "4b0c147b458f48b2bcea51b87112e4d4"
        TreeNode5.Text = "逆矩阵、矩阵方程(60题)"
        TreeNode6.Name = "ae44f93dc4214dbda2a5a4935e8e7e89"
        TreeNode6.Text = "初等变换和初等矩阵(60题)"
        TreeNode7.Name = "5370c7c1b5d94b33a48c27da5d231d45"
        TreeNode7.Text = "第二章 矩阵(215题)"
        TreeNode8.Name = "1ce8bf32ad9f47eebbb125169c1c64e6"
        TreeNode8.Text = "向量概念及其性质、内积、正交(34题)"
        TreeNode9.Name = "c804a3e0710243f78ebc660e3787725c"
        TreeNode9.Text = "向量的线性表示、向量组的线性相关性(35题)"
        TreeNode10.Name = "899f83cd55a34b3483c29a629e3356fb"
        TreeNode10.Text = "极大无关组、向量和矩阵的秩(33题)"
        TreeNode11.Name = "4804a297639949bdbc941970bfdf1b6c"
        TreeNode11.Text = "第三章 向量组的线性相关性(102题)"
        TreeNode12.Name = "a26f93ecd1a44086a033729aa58e5f7d"
        TreeNode12.Text = "线性方程组解判定及其求解(35题)"
        TreeNode13.Name = "34e2968370ff4807a7fdc46505841c53"
        TreeNode13.Text = "基础解系和解的结构(60题)"
        TreeNode14.Name = "f0c6b02da04844c58442103e0b2da3f8"
        TreeNode14.Text = "向量空间(68题)"
        TreeNode15.Name = "81c0494ad5f848e289a6777b28778750"
        TreeNode15.Text = "第四章 线性方程组(163题)"
        TreeNode16.Name = "40f6a4397722426b8e0c62fb311389a4"
        TreeNode16.Text = "矩阵特征值和特征向量(35题)"
        TreeNode17.Name = "a0d674e70e0c429ea1a6e73218a12dd7"
        TreeNode17.Text = "矩阵相似及相似对角化(35题)"
        TreeNode18.Name = "dd926ab0652a451584621e92b3959ec4"
        TreeNode18.Text = "第五章 矩阵相似对角化(70题)"
        TreeNode19.Name = "27b1b42b003645c7b1f1d0ee7377857d"
        TreeNode19.Text = "二次型概念、惯性定理、正定二次型(59题)"
        TreeNode20.Name = "2ec65336c69e4812ae11621076d6caf7"
        TreeNode20.Text = "矩阵合同，化二次型为标准形(60题)"
        TreeNode21.Name = "6cf42fdcbb164b6c8a03ddf76b4b9c5b"
        TreeNode21.Text = "第六章 二次型(119题)"
        TreeNode22.Name = "cc32d25976814e6b99a9b80643d86a21"
        TreeNode22.Text = "线性空间(41题)"
        TreeNode23.Name = "003ca76edf354f128ee0f0e27ad74153"
        TreeNode23.Text = "线性变换、欧几里得空间(65题)"
        TreeNode24.Name = "5dddbaf110414eb5b4cf5255152d6743"
        TreeNode24.Text = "第七章 线性空间与线性变换(106题)"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode7, TreeNode11, TreeNode15, TreeNode18, TreeNode21, TreeNode24})
        Me.TreeView1.Size = New System.Drawing.Size(776, 426)
        Me.TreeView1.TabIndex = 0
        '
        'FormSelectLA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.TreeView1)
        Me.KeyPreview = True
        Me.Name = "FormSelectLA"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Double Click To Choose a Chapater"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
End Class
