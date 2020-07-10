<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTaskEdit
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtDebug = New System.Windows.Forms.TextBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(323, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 24)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "保存文件"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(186, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "选择文件。"
        '
        'txtDebug
        '
        Me.txtDebug.Location = New System.Drawing.Point(430, 9)
        Me.txtDebug.Multiline = True
        Me.txtDebug.Name = "txtDebug"
        Me.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDebug.Size = New System.Drawing.Size(358, 429)
        Me.txtDebug.TabIndex = 2
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(12, 39)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContent.Size = New System.Drawing.Size(412, 399)
        Me.txtContent.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(242, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmTaskEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.txtDebug)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmTaskEdit"
        Me.Text = "FrmTaskEdit"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtDebug As TextBox
    Friend WithEvents txtContent As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button2 As Button
End Class
