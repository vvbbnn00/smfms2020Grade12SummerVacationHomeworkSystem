<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lbl_CountDown = New System.Windows.Forms.Label()
        Me.lbl_Title = New System.Windows.Forms.Label()
        Me.Progress_All = New System.Windows.Forms.ProgressBar()
        Me.lbl_Tip1 = New System.Windows.Forms.Label()
        Me.lbl_Tip2 = New System.Windows.Forms.Label()
        Me.list_Remains = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.group_Detail = New System.Windows.Forms.GroupBox()
        Me.lbl_Detail_Progress1 = New System.Windows.Forms.Label()
        Me.btn_Detail_ChangeProgress1 = New System.Windows.Forms.Button()
        Me.btn_Detail_Minus1 = New System.Windows.Forms.Button()
        Me.btn_Detail_add1 = New System.Windows.Forms.Button()
        Me.txt_Detail_progress = New System.Windows.Forms.TextBox()
        Me.Progress_Detail_Progress1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_Tip4 = New System.Windows.Forms.Label()
        Me.txt_Detail1 = New System.Windows.Forms.TextBox()
        Me.txt_Detail_subject1 = New System.Windows.Forms.TextBox()
        Me.lbl_Tip3 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SettingPanel = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_Version = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_ResetAll = New System.Windows.Forms.Button()
        Me.btn_ResetFiles = New System.Windows.Forms.Button()
        Me.btn_resetSettings = New System.Windows.Forms.Button()
        Me.btn_testmusic = New System.Windows.Forms.Button()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_Test1 = New System.Windows.Forms.Button()
        Me.btn_Test2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Tip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timer_Fun1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer_Fun2 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.btn_showCreateTask = New System.Windows.Forms.Button()
        Me.lnk_Donate = New System.Windows.Forms.LinkLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.group_Detail.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SettingPanel.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_CountDown
        '
        Me.lbl_CountDown.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_CountDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_CountDown.Location = New System.Drawing.Point(7, 64)
        Me.lbl_CountDown.Name = "lbl_CountDown"
        Me.lbl_CountDown.Size = New System.Drawing.Size(703, 24)
        Me.lbl_CountDown.TabIndex = 0
        Me.lbl_CountDown.Text = "你的假期还剩下0天0时0分0秒"
        Me.lbl_CountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Title
        '
        Me.lbl_Title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Title.Font = New System.Drawing.Font("微软雅黑", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Title.Location = New System.Drawing.Point(4, 15)
        Me.lbl_Title.Name = "lbl_Title"
        Me.lbl_Title.Size = New System.Drawing.Size(706, 39)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "这里是标题测试文字"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Progress_All
        '
        Me.Progress_All.Location = New System.Drawing.Point(107, 100)
        Me.Progress_All.Name = "Progress_All"
        Me.Progress_All.Size = New System.Drawing.Size(508, 27)
        Me.Progress_All.TabIndex = 2
        '
        'lbl_Tip1
        '
        Me.lbl_Tip1.AutoSize = True
        Me.lbl_Tip1.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Tip1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Tip1.Location = New System.Drawing.Point(15, 103)
        Me.lbl_Tip1.Name = "lbl_Tip1"
        Me.lbl_Tip1.Size = New System.Drawing.Size(89, 19)
        Me.lbl_Tip1.TabIndex = 3
        Me.lbl_Tip1.Text = "当前进度"
        '
        'lbl_Tip2
        '
        Me.lbl_Tip2.AutoSize = True
        Me.lbl_Tip2.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Tip2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Tip2.Location = New System.Drawing.Point(624, 103)
        Me.lbl_Tip2.Name = "lbl_Tip2"
        Me.lbl_Tip2.Size = New System.Drawing.Size(86, 19)
        Me.lbl_Tip2.TabIndex = 4
        Me.lbl_Tip2.Text = "999.99%"
        Me.lbl_Tip2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'list_Remains
        '
        Me.list_Remains.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.list_Remains.BackColor = System.Drawing.Color.Black
        Me.list_Remains.BackgroundImageTiled = True
        Me.list_Remains.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_Remains.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.list_Remains.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.list_Remains.FullRowSelect = True
        Me.list_Remains.HideSelection = False
        Me.list_Remains.LargeImageList = Me.ImageList1
        Me.list_Remains.Location = New System.Drawing.Point(3, 3)
        Me.list_Remains.MultiSelect = False
        Me.list_Remains.Name = "list_Remains"
        Me.list_Remains.ShowGroups = False
        Me.list_Remains.Size = New System.Drawing.Size(361, 270)
        Me.list_Remains.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.list_Remains.StateImageList = Me.ImageList1
        Me.list_Remains.TabIndex = 5
        Me.list_Remains.UseCompatibleStateImageBehavior = False
        Me.list_Remains.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "科目"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "作业"
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "详情"
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "进度"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "unfinished")
        Me.ImageList1.Images.SetKeyName(1, "finished")
        Me.ImageList1.Images.SetKeyName(2, "notification")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(19, 133)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(680, 305)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.WindowText
        Me.TabPage1.Controls.Add(Me.group_Detail)
        Me.TabPage1.Controls.Add(Me.list_Remains)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Red
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(672, 279)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "任务列表"
        '
        'group_Detail
        '
        Me.group_Detail.BackColor = System.Drawing.Color.Black
        Me.group_Detail.Controls.Add(Me.lbl_Detail_Progress1)
        Me.group_Detail.Controls.Add(Me.btn_Detail_ChangeProgress1)
        Me.group_Detail.Controls.Add(Me.btn_Detail_Minus1)
        Me.group_Detail.Controls.Add(Me.btn_Detail_add1)
        Me.group_Detail.Controls.Add(Me.txt_Detail_progress)
        Me.group_Detail.Controls.Add(Me.Progress_Detail_Progress1)
        Me.group_Detail.Controls.Add(Me.lbl_Tip4)
        Me.group_Detail.Controls.Add(Me.txt_Detail1)
        Me.group_Detail.Controls.Add(Me.txt_Detail_subject1)
        Me.group_Detail.Controls.Add(Me.lbl_Tip3)
        Me.group_Detail.ForeColor = System.Drawing.Color.White
        Me.group_Detail.Location = New System.Drawing.Point(372, 3)
        Me.group_Detail.Name = "group_Detail"
        Me.group_Detail.Size = New System.Drawing.Size(294, 273)
        Me.group_Detail.TabIndex = 6
        Me.group_Detail.TabStop = False
        Me.group_Detail.Text = "任务详情"
        '
        'lbl_Detail_Progress1
        '
        Me.lbl_Detail_Progress1.AutoSize = True
        Me.lbl_Detail_Progress1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Detail_Progress1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Detail_Progress1.Location = New System.Drawing.Point(254, 198)
        Me.lbl_Detail_Progress1.Name = "lbl_Detail_Progress1"
        Me.lbl_Detail_Progress1.Size = New System.Drawing.Size(39, 20)
        Me.lbl_Detail_Progress1.TabIndex = 10
        Me.lbl_Detail_Progress1.Text = "/999"
        '
        'btn_Detail_ChangeProgress1
        '
        Me.btn_Detail_ChangeProgress1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_Detail_ChangeProgress1.ForeColor = System.Drawing.Color.Black
        Me.btn_Detail_ChangeProgress1.Location = New System.Drawing.Point(123, 231)
        Me.btn_Detail_ChangeProgress1.Name = "btn_Detail_ChangeProgress1"
        Me.btn_Detail_ChangeProgress1.Size = New System.Drawing.Size(64, 28)
        Me.btn_Detail_ChangeProgress1.TabIndex = 9
        Me.btn_Detail_ChangeProgress1.Text = "修改"
        Me.Tip1.SetToolTip(Me.btn_Detail_ChangeProgress1, "点按后将会将你的进度应用为文本框中的数值")
        Me.btn_Detail_ChangeProgress1.UseVisualStyleBackColor = True
        '
        'btn_Detail_Minus1
        '
        Me.btn_Detail_Minus1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_Detail_Minus1.ForeColor = System.Drawing.Color.Black
        Me.btn_Detail_Minus1.Location = New System.Drawing.Point(35, 224)
        Me.btn_Detail_Minus1.Name = "btn_Detail_Minus1"
        Me.btn_Detail_Minus1.Size = New System.Drawing.Size(64, 38)
        Me.btn_Detail_Minus1.TabIndex = 8
        Me.btn_Detail_Minus1.Text = "-1"
        Me.Tip1.SetToolTip(Me.btn_Detail_Minus1, "点按后你的进度将会减少1")
        Me.btn_Detail_Minus1.UseVisualStyleBackColor = True
        '
        'btn_Detail_add1
        '
        Me.btn_Detail_add1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_Detail_add1.ForeColor = System.Drawing.Color.Black
        Me.btn_Detail_add1.Location = New System.Drawing.Point(215, 224)
        Me.btn_Detail_add1.Name = "btn_Detail_add1"
        Me.btn_Detail_add1.Size = New System.Drawing.Size(64, 38)
        Me.btn_Detail_add1.TabIndex = 7
        Me.btn_Detail_add1.Text = "+1"
        Me.Tip1.SetToolTip(Me.btn_Detail_add1, "点按后你的进度将会增加1")
        Me.btn_Detail_add1.UseVisualStyleBackColor = True
        '
        'txt_Detail_progress
        '
        Me.txt_Detail_progress.BackColor = System.Drawing.Color.Black
        Me.txt_Detail_progress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Detail_progress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Detail_progress.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_Detail_progress.ForeColor = System.Drawing.Color.Lime
        Me.txt_Detail_progress.Location = New System.Drawing.Point(226, 198)
        Me.txt_Detail_progress.MaxLength = 3
        Me.txt_Detail_progress.Name = "txt_Detail_progress"
        Me.txt_Detail_progress.ReadOnly = True
        Me.txt_Detail_progress.Size = New System.Drawing.Size(29, 19)
        Me.txt_Detail_progress.TabIndex = 6
        Me.txt_Detail_progress.Text = "0"
        Me.txt_Detail_progress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Tip1.SetToolTip(Me.txt_Detail_progress, "修改后点击""修改""以确认修改")
        '
        'Progress_Detail_Progress1
        '
        Me.Progress_Detail_Progress1.Location = New System.Drawing.Point(92, 199)
        Me.Progress_Detail_Progress1.Name = "Progress_Detail_Progress1"
        Me.Progress_Detail_Progress1.Size = New System.Drawing.Size(132, 19)
        Me.Progress_Detail_Progress1.TabIndex = 5
        '
        'lbl_Tip4
        '
        Me.lbl_Tip4.AutoSize = True
        Me.lbl_Tip4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Tip4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Tip4.Location = New System.Drawing.Point(6, 199)
        Me.lbl_Tip4.Name = "lbl_Tip4"
        Me.lbl_Tip4.Size = New System.Drawing.Size(93, 16)
        Me.lbl_Tip4.TabIndex = 3
        Me.lbl_Tip4.Text = "目前进度："
        '
        'txt_Detail1
        '
        Me.txt_Detail1.BackColor = System.Drawing.Color.Black
        Me.txt_Detail1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_Detail1.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_Detail1.Location = New System.Drawing.Point(9, 56)
        Me.txt_Detail1.Multiline = True
        Me.txt_Detail1.Name = "txt_Detail1"
        Me.txt_Detail1.ReadOnly = True
        Me.txt_Detail1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_Detail1.Size = New System.Drawing.Size(279, 128)
        Me.txt_Detail1.TabIndex = 2
        Me.txt_Detail1.Text = "请先选择一项任务"
        '
        'txt_Detail_subject1
        '
        Me.txt_Detail_subject1.BackColor = System.Drawing.Color.Black
        Me.txt_Detail_subject1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Detail_subject1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_Detail_subject1.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_Detail_subject1.Location = New System.Drawing.Point(71, 31)
        Me.txt_Detail_subject1.Name = "txt_Detail_subject1"
        Me.txt_Detail_subject1.ReadOnly = True
        Me.txt_Detail_subject1.Size = New System.Drawing.Size(196, 19)
        Me.txt_Detail_subject1.TabIndex = 1
        Me.txt_Detail_subject1.Text = "未知"
        '
        'lbl_Tip3
        '
        Me.lbl_Tip3.AutoSize = True
        Me.lbl_Tip3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Tip3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Tip3.Location = New System.Drawing.Point(6, 31)
        Me.lbl_Tip3.Name = "lbl_Tip3"
        Me.lbl_Tip3.Size = New System.Drawing.Size(59, 16)
        Me.lbl_Tip3.TabIndex = 0
        Me.lbl_Tip3.Text = "科目："
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.WindowText
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage2.Controls.Add(Me.SettingPanel)
        Me.TabPage2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(672, 279)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "设置"
        '
        'SettingPanel
        '
        Me.SettingPanel.AutoScroll = True
        Me.SettingPanel.Controls.Add(Me.GroupBox5)
        Me.SettingPanel.Controls.Add(Me.GroupBox1)
        Me.SettingPanel.Controls.Add(Me.GroupBox2)
        Me.SettingPanel.Controls.Add(Me.GroupBox4)
        Me.SettingPanel.Controls.Add(Me.GroupBox3)
        Me.SettingPanel.ForeColor = System.Drawing.Color.White
        Me.SettingPanel.Location = New System.Drawing.Point(3, 3)
        Me.SettingPanel.Name = "SettingPanel"
        Me.SettingPanel.Size = New System.Drawing.Size(666, 267)
        Me.SettingPanel.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lnk_Donate)
        Me.GroupBox5.Controls.Add(Me.lbl_Version)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(385, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(256, 188)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "关于程序"
        '
        'lbl_Version
        '
        Me.lbl_Version.AutoSize = True
        Me.lbl_Version.Location = New System.Drawing.Point(99, 127)
        Me.lbl_Version.Name = "lbl_Version"
        Me.lbl_Version.Size = New System.Drawing.Size(56, 14)
        Me.lbl_Version.TabIndex = 9
        Me.lbl_Version.Text = "0.0.0.0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(217, 14)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "联系邮箱：vvbbnn00@foxmail.com"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 79)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(133, 14)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "联系QQ：1398456099"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 127)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 14)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "程序版本号："
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 14)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "作者：不做评论"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 14)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "程序名称：作业任务系统"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 205)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "系统设置"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(194, 174)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(14, 14)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "%"
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "Opacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox7.Location = New System.Drawing.Point(131, 168)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(55, 23)
        Me.TextBox7.TabIndex = 14
        Me.TextBox7.Text = Global.HomeWorkSys2020.My.MySettings.Default.Opacity
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 14)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "不透明度："
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(304, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 26)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "BackImgPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(132, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(166, 23)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = Global.HomeWorkSys2020.My.MySettings.Default.BackImgPath
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "背景图片："
        '
        'Button1
        '
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.HomeWorkSys2020.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.ForeColor = Global.HomeWorkSys2020.My.MySettings.Default.BackColor
        Me.Button1.Location = New System.Drawing.Point(131, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 26)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "点击更改"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "背景颜色："
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "BackType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Default", "Pure", "Img"})
        Me.ComboBox1.Location = New System.Drawing.Point(132, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 22)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = Global.HomeWorkSys2020.My.MySettings.Default.BackType
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "背景类型："
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = Global.HomeWorkSys2020.My.MySettings.Default.BackGround
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.HomeWorkSys2020.My.MySettings.Default, "BackGround", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(132, 53)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(54, 18)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "开启"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "启用背景窗体："
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.HomeWorkSys2020.My.MySettings.Default.TopMost
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.HomeWorkSys2020.My.MySettings.Default, "TopMost", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(132, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(54, 18)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "开启"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "始终最前："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(3, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 230)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "任务设置"
        '
        'Button8
        '
        Me.Button8.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.HomeWorkSys2020.My.MySettings.Default, "NotificationFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button8.Font = Global.HomeWorkSys2020.My.MySettings.Default.NotificationFont
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(222, 154)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(77, 26)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "字体"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.HomeWorkSys2020.My.MySettings.Default, "UnfinishedFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button7.Font = Global.HomeWorkSys2020.My.MySettings.Default.UnfinishedFont
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(222, 123)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(77, 26)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "字体"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.HomeWorkSys2020.My.MySettings.Default, "FinishedFont", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button6.Font = Global.HomeWorkSys2020.My.MySettings.Default.FinishedFont
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(222, 91)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(77, 26)
        Me.Button6.TabIndex = 16
        Me.Button6.Text = "字体"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.HomeWorkSys2020.My.MySettings.Default, "ExpireDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 189)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 23)
        Me.DateTimePicker1.TabIndex = 15
        Me.DateTimePicker1.Value = Global.HomeWorkSys2020.My.MySettings.Default.ExpireDate
        '
        'Button5
        '
        Me.Button5.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.HomeWorkSys2020.My.MySettings.Default, "NotificationColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button5.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button5.ForeColor = Global.HomeWorkSys2020.My.MySettings.Default.NotificationColor
        Me.Button5.Location = New System.Drawing.Point(128, 154)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 26)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "颜色"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.HomeWorkSys2020.My.MySettings.Default, "UnfinishedColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button4.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button4.ForeColor = Global.HomeWorkSys2020.My.MySettings.Default.UnfinishedColor
        Me.Button4.Location = New System.Drawing.Point(128, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(77, 26)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "颜色"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.HomeWorkSys2020.My.MySettings.Default, "FinishedColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button3.ForeColor = Global.HomeWorkSys2020.My.MySettings.Default.FinishedColor
        Me.Button3.Location = New System.Drawing.Point(128, 91)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 26)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "颜色"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 14)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "截止日期："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "通知样式："
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 14)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "未完成样式："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 14)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "已完成样式："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 14)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "加三选课："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "任务标题："
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "Subjects", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(128, 59)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(216, 23)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = Global.HomeWorkSys2020.My.MySettings.Default.Subjects
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "Title", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(128, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(216, 23)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = Global.HomeWorkSys2020.My.MySettings.Default.Title
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_showCreateTask)
        Me.GroupBox4.Controls.Add(Me.btn_ResetAll)
        Me.GroupBox4.Controls.Add(Me.btn_ResetFiles)
        Me.GroupBox4.Controls.Add(Me.btn_resetSettings)
        Me.GroupBox4.Controls.Add(Me.btn_testmusic)
        Me.GroupBox4.Controls.Add(Me.CheckBox4)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.btn_Test1)
        Me.GroupBox4.Controls.Add(Me.btn_Test2)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox4.Location = New System.Drawing.Point(3, 618)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(376, 181)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "高级"
        '
        'btn_ResetAll
        '
        Me.btn_ResetAll.ForeColor = System.Drawing.Color.Black
        Me.btn_ResetAll.Location = New System.Drawing.Point(222, 56)
        Me.btn_ResetAll.Name = "btn_ResetAll"
        Me.btn_ResetAll.Size = New System.Drawing.Size(131, 34)
        Me.btn_ResetAll.TabIndex = 20
        Me.btn_ResetAll.Text = "重置设置和文件"
        Me.btn_ResetAll.UseVisualStyleBackColor = True
        '
        'btn_ResetFiles
        '
        Me.btn_ResetFiles.ForeColor = System.Drawing.Color.Black
        Me.btn_ResetFiles.Location = New System.Drawing.Point(128, 56)
        Me.btn_ResetFiles.Name = "btn_ResetFiles"
        Me.btn_ResetFiles.Size = New System.Drawing.Size(85, 34)
        Me.btn_ResetFiles.TabIndex = 20
        Me.btn_ResetFiles.Text = "重置文件"
        Me.btn_ResetFiles.UseVisualStyleBackColor = True
        '
        'btn_resetSettings
        '
        Me.btn_resetSettings.ForeColor = System.Drawing.Color.Black
        Me.btn_resetSettings.Location = New System.Drawing.Point(27, 56)
        Me.btn_resetSettings.Name = "btn_resetSettings"
        Me.btn_resetSettings.Size = New System.Drawing.Size(85, 34)
        Me.btn_resetSettings.TabIndex = 20
        Me.btn_resetSettings.Text = "重置设置"
        Me.btn_resetSettings.UseVisualStyleBackColor = True
        '
        'btn_testmusic
        '
        Me.btn_testmusic.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_testmusic.ForeColor = System.Drawing.Color.Blue
        Me.btn_testmusic.Location = New System.Drawing.Point(222, 96)
        Me.btn_testmusic.Name = "btn_testmusic"
        Me.btn_testmusic.Size = New System.Drawing.Size(131, 34)
        Me.btn_testmusic.TabIndex = 10
        Me.btn_testmusic.Text = "测试音乐播放器"
        Me.btn_testmusic.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = Global.HomeWorkSys2020.My.MySettings.Default.DebugMode
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.HomeWorkSys2020.My.MySettings.Default, "DebugMode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Location = New System.Drawing.Point(132, 30)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(54, 18)
        Me.CheckBox4.TabIndex = 19
        Me.CheckBox4.Text = "开启"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 14)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "调试模式："
        '
        'btn_Test1
        '
        Me.btn_Test1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_Test1.ForeColor = System.Drawing.Color.Blue
        Me.btn_Test1.Location = New System.Drawing.Point(128, 96)
        Me.btn_Test1.Name = "btn_Test1"
        Me.btn_Test1.Size = New System.Drawing.Size(85, 34)
        Me.btn_Test1.TabIndex = 7
        Me.btn_Test1.Text = "测试生成"
        Me.btn_Test1.UseVisualStyleBackColor = True
        '
        'btn_Test2
        '
        Me.btn_Test2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_Test2.ForeColor = System.Drawing.Color.Blue
        Me.btn_Test2.Location = New System.Drawing.Point(27, 96)
        Me.btn_Test2.Name = "btn_Test2"
        Me.btn_Test2.Size = New System.Drawing.Size(85, 34)
        Me.btn_Test2.TabIndex = 8
        Me.btn_Test2.Text = "测试保存"
        Me.btn_Test2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Location = New System.Drawing.Point(3, 445)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 167)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "杂项"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = Global.HomeWorkSys2020.My.MySettings.Default.ShowMusicForm
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.HomeWorkSys2020.My.MySettings.Default, "ShowMusicForm", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(132, 132)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(54, 18)
        Me.CheckBox3.TabIndex = 19
        Me.CheckBox3.Text = "开启"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 14)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "音乐悬浮窗："
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(300, 93)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(40, 26)
        Me.Button9.TabIndex = 17
        Me.Button9.Text = "..."
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(128, 94)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(166, 23)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.Text = "默认"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 14)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "任务文件："
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(21, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 14)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "刷新频率："
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(21, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 14)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "服务器地址："
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "TimerFrequency", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Location = New System.Drawing.Point(128, 59)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 23)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = Global.HomeWorkSys2020.My.MySettings.Default.TimerFrequency
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "ServerURL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox5.Location = New System.Drawing.Point(128, 25)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(216, 23)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.Text = Global.HomeWorkSys2020.My.MySettings.Default.ServerURL
        '
        'timer_Fun1
        '
        Me.timer_Fun1.Enabled = True
        Me.timer_Fun1.Interval = 1000
        '
        'timer_Fun2
        '
        Me.timer_Fun2.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_showCreateTask
        '
        Me.btn_showCreateTask.ForeColor = System.Drawing.Color.Blue
        Me.btn_showCreateTask.Location = New System.Drawing.Point(27, 136)
        Me.btn_showCreateTask.Name = "btn_showCreateTask"
        Me.btn_showCreateTask.Size = New System.Drawing.Size(184, 30)
        Me.btn_showCreateTask.TabIndex = 21
        Me.btn_showCreateTask.Text = "显示任务编辑窗体"
        Me.btn_showCreateTask.UseVisualStyleBackColor = True
        '
        'lnk_Donate
        '
        Me.lnk_Donate.AutoSize = True
        Me.lnk_Donate.LinkColor = System.Drawing.Color.Cyan
        Me.lnk_Donate.Location = New System.Drawing.Point(15, 159)
        Me.lnk_Donate.Name = "lnk_Donate"
        Me.lnk_Donate.Size = New System.Drawing.Size(77, 14)
        Me.lnk_Donate.TabIndex = 10
        Me.lnk_Donate.TabStop = True
        Me.lnk_Donate.Text = "赞助开发者"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(716, 455)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbl_Tip2)
        Me.Controls.Add(Me.lbl_Tip1)
        Me.Controls.Add(Me.Progress_All)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.lbl_CountDown)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.group_Detail.ResumeLayout(False)
        Me.group_Detail.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SettingPanel.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_CountDown As Label
    Friend WithEvents lbl_Title As Label
    Friend WithEvents Progress_All As ProgressBar
    Friend WithEvents lbl_Tip1 As Label
    Friend WithEvents lbl_Tip2 As Label
    Friend WithEvents list_Remains As ListView
    Friend WithEvents TabControl1 As TabControl
    Protected Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents group_Detail As GroupBox
    Friend WithEvents txt_Detail_subject1 As TextBox
    Friend WithEvents lbl_Tip3 As Label
    Friend WithEvents txt_Detail1 As TextBox
    Friend WithEvents lbl_Tip4 As Label
    Friend WithEvents txt_Detail_progress As TextBox
    Friend WithEvents Progress_Detail_Progress1 As ProgressBar
    Friend WithEvents btn_Detail_ChangeProgress1 As Button
    Friend WithEvents btn_Detail_Minus1 As Button
    Friend WithEvents btn_Detail_add1 As Button
    Friend WithEvents Tip1 As ToolTip
    Friend WithEvents lbl_Detail_Progress1 As Label
    Friend WithEvents timer_Fun1 As Timer
    Friend WithEvents btn_Test1 As Button
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents timer_Fun2 As Timer
    Friend WithEvents btn_Test2 As Button
    Friend WithEvents SettingPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn_testmusic As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl_Version As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_resetSettings As Button
    Friend WithEvents btn_ResetAll As Button
    Friend WithEvents btn_ResetFiles As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btn_showCreateTask As Button
    Friend WithEvents lnk_Donate As LinkLabel
End Class
