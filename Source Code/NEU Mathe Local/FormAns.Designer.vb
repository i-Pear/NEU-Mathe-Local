<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAns
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
        Me.PictureBoxAns = New System.Windows.Forms.PictureBox()
        Me.LabelAns = New System.Windows.Forms.Label()
        CType(Me.PictureBoxAns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxAns
        '
        Me.PictureBoxAns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxAns.Location = New System.Drawing.Point(13, 13)
        Me.PictureBoxAns.Name = "PictureBoxAns"
        Me.PictureBoxAns.Size = New System.Drawing.Size(1196, 425)
        Me.PictureBoxAns.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxAns.TabIndex = 0
        Me.PictureBoxAns.TabStop = False
        '
        'LabelAns
        '
        Me.LabelAns.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelAns.AutoSize = True
        Me.LabelAns.Font = New System.Drawing.Font("微软雅黑", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelAns.ForeColor = System.Drawing.Color.Red
        Me.LabelAns.Location = New System.Drawing.Point(1169, 389)
        Me.LabelAns.Name = "LabelAns"
        Me.LabelAns.Size = New System.Drawing.Size(49, 57)
        Me.LabelAns.TabIndex = 1
        Me.LabelAns.Text = "L"
        '
        'FormAns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelAns)
        Me.Controls.Add(Me.PictureBoxAns)
        Me.Name = "FormAns"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormAns"
        CType(Me.PictureBoxAns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxAns As PictureBox
    Friend WithEvents LabelAns As Label
End Class
