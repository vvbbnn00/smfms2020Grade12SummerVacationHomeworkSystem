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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTaskEdit))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtDebug = New System.Windows.Forms.TextBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_ysy = New System.Windows.Forms.Button()
        Me.btn_wl = New System.Windows.Forms.Button()
        Me.btn_hx = New System.Windows.Forms.Button()
        Me.btn_zz = New System.Windows.Forms.Button()
        Me.btn_ls = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
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
        Me.txtContent.Location = New System.Drawing.Point(12, 76)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtContent.Size = New System.Drawing.Size(412, 362)
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
        'btn_ysy
        '
        Me.btn_ysy.Location = New System.Drawing.Point(12, 46)
        Me.btn_ysy.Name = "btn_ysy"
        Me.btn_ysy.Size = New System.Drawing.Size(76, 24)
        Me.btn_ysy.TabIndex = 5
        Me.btn_ysy.Text = "语数英"
        Me.btn_ysy.UseVisualStyleBackColor = True
        '
        'btn_wl
        '
        Me.btn_wl.Location = New System.Drawing.Point(94, 46)
        Me.btn_wl.Name = "btn_wl"
        Me.btn_wl.Size = New System.Drawing.Size(61, 24)
        Me.btn_wl.TabIndex = 6
        Me.btn_wl.Text = "物理"
        Me.btn_wl.UseVisualStyleBackColor = True
        '
        'btn_hx
        '
        Me.btn_hx.Location = New System.Drawing.Point(161, 46)
        Me.btn_hx.Name = "btn_hx"
        Me.btn_hx.Size = New System.Drawing.Size(61, 24)
        Me.btn_hx.TabIndex = 7
        Me.btn_hx.Text = "化学"
        Me.btn_hx.UseVisualStyleBackColor = True
        '
        'btn_zz
        '
        Me.btn_zz.Location = New System.Drawing.Point(228, 46)
        Me.btn_zz.Name = "btn_zz"
        Me.btn_zz.Size = New System.Drawing.Size(61, 24)
        Me.btn_zz.TabIndex = 8
        Me.btn_zz.Text = "政治"
        Me.btn_zz.UseVisualStyleBackColor = True
        '
        'btn_ls
        '
        Me.btn_ls.Location = New System.Drawing.Point(295, 46)
        Me.btn_ls.Name = "btn_ls"
        Me.btn_ls.Size = New System.Drawing.Size(61, 24)
        Me.btn_ls.TabIndex = 9
        Me.btn_ls.Text = "历史"
        Me.btn_ls.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(362, 46)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(62, 24)
        Me.btn_Clear.TabIndex = 10
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'FrmTaskEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_ls)
        Me.Controls.Add(Me.btn_zz)
        Me.Controls.Add(Me.btn_hx)
        Me.Controls.Add(Me.btn_wl)
        Me.Controls.Add(Me.btn_ysy)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtContent)
        Me.Controls.Add(Me.txtDebug)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents btn_ysy As Button
    Friend WithEvents btn_wl As Button
    Friend WithEvents btn_hx As Button
    Friend WithEvents btn_zz As Button
    Friend WithEvents btn_ls As Button
    Friend WithEvents btn_Clear As Button
End Class
