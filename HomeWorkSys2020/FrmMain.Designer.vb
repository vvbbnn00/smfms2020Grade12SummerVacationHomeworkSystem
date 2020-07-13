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
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.group_Detail = New System.Windows.Forms.GroupBox()
        Me.btn_Detail_ChangeProgress1 = New System.Windows.Forms.Button()
        Me.btn_Detail_Minus1 = New System.Windows.Forms.Button()
        Me.btn_Detail_add1 = New System.Windows.Forms.Button()
        Me.txt_Detail_progress = New System.Windows.Forms.TextBox()
        Me.Progress_Detail_Progress1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_Tip4 = New System.Windows.Forms.Label()
        Me.txt_Detail1 = New System.Windows.Forms.TextBox()
        Me.txt_Detail_subject1 = New System.Windows.Forms.TextBox()
        Me.lbl_Tip3 = New System.Windows.Forms.Label()
        Me.lbl_Detail_Progress1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SettingPanel = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lnk_Donate = New System.Windows.Forms.LinkLabel()
        Me.lbl_Version = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_showCreateTask = New System.Windows.Forms.Button()
        Me.btn_ResetAll = New System.Windows.Forms.Button()
        Me.btn_ResetFiles = New System.Windows.Forms.Button()
        Me.btn_resetSettings = New System.Windows.Forms.Button()
        Me.btn_testmusic = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_Test1 = New System.Windows.Forms.Button()
        Me.btn_Test2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Tip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timer_Fun1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer_Fun2 = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Tip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timer_RunOnce = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_CountDown.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CountDown.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_CountDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_CountDown.Location = New System.Drawing.Point(7, 63)
        Me.lbl_CountDown.Name = "lbl_CountDown"
        Me.lbl_CountDown.Size = New System.Drawing.Size(850, 24)
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
        Me.lbl_Title.Size = New System.Drawing.Size(853, 39)
        Me.lbl_Title.TabIndex = 1
        Me.lbl_Title.Text = "这里是标题测试文字"
        Me.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Progress_All
        '
        Me.Progress_All.Location = New System.Drawing.Point(122, 101)
        Me.Progress_All.Name = "Progress_All"
        Me.Progress_All.Size = New System.Drawing.Size(635, 27)
        Me.Progress_All.TabIndex = 2
        '
        'lbl_Tip1
        '
        Me.lbl_Tip1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tip1.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Tip1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Tip1.Location = New System.Drawing.Point(11, 104)
        Me.lbl_Tip1.Name = "lbl_Tip1"
        Me.lbl_Tip1.Size = New System.Drawing.Size(655, 27)
        Me.lbl_Tip1.TabIndex = 3
        Me.lbl_Tip1.Text = "当前进度"
        '
        'lbl_Tip2
        '
        Me.lbl_Tip2.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Tip2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Tip2.Location = New System.Drawing.Point(767, 93)
        Me.lbl_Tip2.Name = "lbl_Tip2"
        Me.lbl_Tip2.Size = New System.Drawing.Size(90, 40)
        Me.lbl_Tip2.TabIndex = 4
        Me.lbl_Tip2.Text = "999.99%"
        Me.lbl_Tip2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'list_Remains
        '
        Me.list_Remains.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.list_Remains.BackColor = System.Drawing.Color.Black
        Me.list_Remains.BackgroundImageTiled = True
        Me.list_Remains.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_Remains.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.list_Remains.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.list_Remains.FullRowSelect = True
        Me.list_Remains.HideSelection = False
        Me.list_Remains.LargeImageList = Me.ImageList1
        Me.list_Remains.Location = New System.Drawing.Point(6, 38)
        Me.list_Remains.Name = "list_Remains"
        Me.list_Remains.ShowGroups = False
        Me.list_Remains.Size = New System.Drawing.Size(505, 313)
        Me.list_Remains.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.list_Remains.StateImageList = Me.ImageList1
        Me.list_Remains.TabIndex = 5
        Me.list_Remains.UseCompatibleStateImageBehavior = False
        Me.list_Remains.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "科目"
        Me.ColumnHeader1.Width = 70
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "作业"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "详情"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "进度"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "附件地址"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "GlobalID"
        Me.ColumnHeader6.Width = 0
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
        Me.TabControl1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(15, 134)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(838, 387)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.WindowText
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.TextBox8)
        Me.TabPage1.Controls.Add(Me.group_Detail)
        Me.TabPage1.Controls.Add(Me.list_Remains)
        Me.TabPage1.Controls.Add(Me.CheckBox6)
        Me.TabPage1.Controls.Add(Me.CheckBox5)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.Red
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(830, 357)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "任务列表"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.HomeWorkSys2020.My.Resources.Resources.搜索__1_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Black
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextBox8.ForeColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(39, 10)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(333, 19)
        Me.TextBox8.TabIndex = 7
        '
        'group_Detail
        '
        Me.group_Detail.BackColor = System.Drawing.Color.Black
        Me.group_Detail.Controls.Add(Me.btn_Detail_ChangeProgress1)
        Me.group_Detail.Controls.Add(Me.btn_Detail_Minus1)
        Me.group_Detail.Controls.Add(Me.btn_Detail_add1)
        Me.group_Detail.Controls.Add(Me.txt_Detail_progress)
        Me.group_Detail.Controls.Add(Me.Progress_Detail_Progress1)
        Me.group_Detail.Controls.Add(Me.lbl_Tip4)
        Me.group_Detail.Controls.Add(Me.txt_Detail1)
        Me.group_Detail.Controls.Add(Me.txt_Detail_subject1)
        Me.group_Detail.Controls.Add(Me.lbl_Tip3)
        Me.group_Detail.Controls.Add(Me.lbl_Detail_Progress1)
        Me.group_Detail.Controls.Add(Me.LinkLabel1)
        Me.group_Detail.ForeColor = System.Drawing.Color.White
        Me.group_Detail.Location = New System.Drawing.Point(514, 2)
        Me.group_Detail.Name = "group_Detail"
        Me.group_Detail.Size = New System.Drawing.Size(310, 349)
        Me.group_Detail.TabIndex = 6
        Me.group_Detail.TabStop = False
        Me.group_Detail.Text = "任务详情"
        '
        'btn_Detail_ChangeProgress1
        '
        Me.btn_Detail_ChangeProgress1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_Detail_ChangeProgress1.ForeColor = System.Drawing.Color.Black
        Me.btn_Detail_ChangeProgress1.Location = New System.Drawing.Point(123, 304)
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
        Me.btn_Detail_Minus1.Location = New System.Drawing.Point(35, 297)
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
        Me.btn_Detail_add1.Location = New System.Drawing.Point(215, 297)
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
        Me.txt_Detail_progress.Location = New System.Drawing.Point(226, 271)
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
        Me.Progress_Detail_Progress1.Location = New System.Drawing.Point(92, 272)
        Me.Progress_Detail_Progress1.Name = "Progress_Detail_Progress1"
        Me.Progress_Detail_Progress1.Size = New System.Drawing.Size(132, 19)
        Me.Progress_Detail_Progress1.TabIndex = 5
        '
        'lbl_Tip4
        '
        Me.lbl_Tip4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tip4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Tip4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Tip4.Location = New System.Drawing.Point(6, 272)
        Me.lbl_Tip4.Name = "lbl_Tip4"
        Me.lbl_Tip4.Size = New System.Drawing.Size(181, 41)
        Me.lbl_Tip4.TabIndex = 3
        Me.lbl_Tip4.Text = "目前进度："
        '
        'txt_Detail1
        '
        Me.txt_Detail1.BackColor = System.Drawing.Color.Black
        Me.txt_Detail1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_Detail1.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_Detail1.Location = New System.Drawing.Point(9, 59)
        Me.txt_Detail1.Multiline = True
        Me.txt_Detail1.Name = "txt_Detail1"
        Me.txt_Detail1.ReadOnly = True
        Me.txt_Detail1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_Detail1.Size = New System.Drawing.Size(284, 184)
        Me.txt_Detail1.TabIndex = 2
        Me.txt_Detail1.Text = "请先选择一项任务"
        '
        'txt_Detail_subject1
        '
        Me.txt_Detail_subject1.BackColor = System.Drawing.Color.Black
        Me.txt_Detail_subject1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Detail_subject1.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_Detail_subject1.ForeColor = System.Drawing.SystemColors.Window
        Me.txt_Detail_subject1.Location = New System.Drawing.Point(71, 31)
        Me.txt_Detail_subject1.Name = "txt_Detail_subject1"
        Me.txt_Detail_subject1.ReadOnly = True
        Me.txt_Detail_subject1.Size = New System.Drawing.Size(222, 22)
        Me.txt_Detail_subject1.TabIndex = 1
        Me.txt_Detail_subject1.Text = "未知"
        '
        'lbl_Tip3
        '
        Me.lbl_Tip3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tip3.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Tip3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Tip3.Location = New System.Drawing.Point(6, 31)
        Me.lbl_Tip3.Name = "lbl_Tip3"
        Me.lbl_Tip3.Size = New System.Drawing.Size(298, 66)
        Me.lbl_Tip3.TabIndex = 0
        Me.lbl_Tip3.Text = "作业："
        '
        'lbl_Detail_Progress1
        '
        Me.lbl_Detail_Progress1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Detail_Progress1.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl_Detail_Progress1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_Detail_Progress1.Location = New System.Drawing.Point(254, 271)
        Me.lbl_Detail_Progress1.Name = "lbl_Detail_Progress1"
        Me.lbl_Detail_Progress1.Size = New System.Drawing.Size(59, 42)
        Me.lbl_Detail_Progress1.TabIndex = 10
        Me.lbl_Detail_Progress1.Text = "/999"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.LinkArea = New System.Windows.Forms.LinkArea(0, 12)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(103, 251)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(201, 43)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "该项作业有附件，点击下载"
        Me.LinkLabel1.Visible = False
        '
        'CheckBox6
        '
        Me.CheckBox6.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox6.ForeColor = System.Drawing.Color.White
        Me.CheckBox6.Location = New System.Drawing.Point(439, 11)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(130, 21)
        Me.CheckBox6.TabIndex = 9
        Me.CheckBox6.Text = "已完成"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.White
        Me.CheckBox5.Location = New System.Drawing.Point(378, 12)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(129, 20)
        Me.CheckBox5.TabIndex = 9
        Me.CheckBox5.Text = "通知"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.WindowText
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage2.Controls.Add(Me.SettingPanel)
        Me.TabPage2.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(830, 357)
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
        Me.SettingPanel.Size = New System.Drawing.Size(824, 348)
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
        Me.GroupBox5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(417, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(376, 205)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "关于程序"
        '
        'lnk_Donate
        '
        Me.lnk_Donate.BackColor = System.Drawing.Color.Transparent
        Me.lnk_Donate.LinkColor = System.Drawing.Color.Cyan
        Me.lnk_Donate.Location = New System.Drawing.Point(15, 159)
        Me.lnk_Donate.Name = "lnk_Donate"
        Me.lnk_Donate.Size = New System.Drawing.Size(345, 35)
        Me.lnk_Donate.TabIndex = 10
        Me.lnk_Donate.TabStop = True
        Me.lnk_Donate.Text = "赞助开发者"
        Me.Tip2.SetToolTip(Me.lnk_Donate, "家境贫寒，救救孩子。")
        '
        'lbl_Version
        '
        Me.lbl_Version.Location = New System.Drawing.Point(99, 127)
        Me.lbl_Version.Name = "lbl_Version"
        Me.lbl_Version.Size = New System.Drawing.Size(271, 29)
        Me.lbl_Version.TabIndex = 9
        Me.lbl_Version.Text = "0.0.0.0"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(15, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(361, 23)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "联系邮箱：vvbbnn00@foxmail.com"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Location = New System.Drawing.Point(15, 79)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(361, 25)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "联系QQ：1398456099"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(15, 127)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(361, 29)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "程序版本号："
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(15, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(361, 27)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "作者：不做评论"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(15, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(355, 26)
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
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 205)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "系统设置"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(189, 174)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(176, 15)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "%"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(21, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(370, 20)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "不透明度："
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(325, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 26)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(21, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(370, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "背景图片："
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(21, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(370, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "背景颜色："
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(21, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(370, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "背景类型："
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(21, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(402, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "启用背景窗体："
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(21, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 24)
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
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox2.Location = New System.Drawing.Point(3, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 230)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "任务设置"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(21, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(370, 22)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "截止日期："
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(21, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(370, 22)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "通知样式："
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(21, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(386, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "未完成样式："
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(21, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(386, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "已完成样式："
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(21, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(370, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "加三选课："
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(21, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(370, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "任务标题："
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
        Me.GroupBox4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox4.Location = New System.Drawing.Point(3, 450)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(396, 181)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "高级"
        '
        'btn_showCreateTask
        '
        Me.btn_showCreateTask.ForeColor = System.Drawing.Color.Blue
        Me.btn_showCreateTask.Location = New System.Drawing.Point(27, 136)
        Me.btn_showCreateTask.Name = "btn_showCreateTask"
        Me.btn_showCreateTask.Size = New System.Drawing.Size(184, 30)
        Me.btn_showCreateTask.TabIndex = 21
        Me.btn_showCreateTask.Text = "显示任务编辑窗体"
        Me.Tip2.SetToolTip(Me.btn_showCreateTask, "开发者生成任务文件的窗体，无需点按。")
        Me.btn_showCreateTask.UseVisualStyleBackColor = True
        '
        'btn_ResetAll
        '
        Me.btn_ResetAll.ForeColor = System.Drawing.Color.Black
        Me.btn_ResetAll.Location = New System.Drawing.Point(222, 56)
        Me.btn_ResetAll.Name = "btn_ResetAll"
        Me.btn_ResetAll.Size = New System.Drawing.Size(131, 34)
        Me.btn_ResetAll.TabIndex = 20
        Me.btn_ResetAll.Text = "重置设置和文件"
        Me.Tip2.SetToolTip(Me.btn_ResetAll, "点击后会重置一切设置和任务文件。")
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
        Me.Tip2.SetToolTip(Me.btn_ResetFiles, "点击后会重置任务文件。")
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
        Me.Tip2.SetToolTip(Me.btn_resetSettings, "点击后会重置一切设置。")
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
        Me.Tip2.SetToolTip(Me.btn_testmusic, "显示音乐播放器窗体。")
        Me.btn_testmusic.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(21, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(375, 23)
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
        Me.Tip2.SetToolTip(Me.btn_Test1, "（请勿点击）生成测试任务文件，会覆盖原先的文件。")
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
        Me.Tip2.SetToolTip(Me.btn_Test2, "测试保存是否正常。")
        Me.btn_Test2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox3)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox3.Location = New System.Drawing.Point(417, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(376, 230)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "杂项"
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
        Me.TextBox6.Size = New System.Drawing.Size(166, 26)
        Me.TextBox6.TabIndex = 16
        Me.TextBox6.Text = "默认"
        Me.Tip2.SetToolTip(Me.TextBox6, "任务文件（暂无法修改）")
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(21, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(386, 22)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "音乐悬浮窗："
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(21, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(370, 22)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "任务文件："
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(21, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(370, 22)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "刷新频率："
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(21, 28)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(386, 22)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "服务器地址："
        '
        'timer_Fun1
        '
        Me.timer_Fun1.Interval = 1000
        '
        'timer_Fun2
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Tip2
        '
        Me.Tip2.IsBalloon = True
        Me.Tip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Tip2.ToolTipTitle = "这是什么？"
        '
        'timer_RunOnce
        '
        Me.timer_RunOnce.Interval = 1
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "Opacity", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox7.Location = New System.Drawing.Point(128, 168)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(55, 26)
        Me.TextBox7.TabIndex = 14
        Me.TextBox7.Text = Global.HomeWorkSys2020.My.MySettings.Default.Opacity
        Me.Tip2.SetToolTip(Me.TextBox7, "设置窗体的不透明度，需要注意，请输入1-100的合法整数。（重启后生效）")
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "BackImgPath", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox2.Location = New System.Drawing.Point(128, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(192, 26)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = Global.HomeWorkSys2020.My.MySettings.Default.BackImgPath
        Me.Tip2.SetToolTip(Me.TextBox2, "修改纯色背景的图片，需要将背景类型选为Img才有效，点击""...""按钮来选择图片文件。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "需要注意：请确保图片文件有效，否则将会自动重置为默认背景。（重启后生效）" &
        "")
        '
        'Button1
        '
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("ForeColor", Global.HomeWorkSys2020.My.MySettings.Default, "BackColor", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.ForeColor = Global.HomeWorkSys2020.My.MySettings.Default.BackColor
        Me.Button1.Location = New System.Drawing.Point(127, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 26)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "点击更改"
        Me.Tip2.SetToolTip(Me.Button1, "修改纯色背景的颜色，需要将背景类型选为Pure才有效。（重启后生效）")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "BackType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Default", "Pure", "Img"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(105, 24)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = Global.HomeWorkSys2020.My.MySettings.Default.BackType
        Me.Tip2.SetToolTip(Me.ComboBox1, "选择背景的样式" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Default-默认" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pure-纯色背景" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Img-自定义图片背景" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "（重启后生效）")
        '
        'CheckBox2
        '
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Checked = Global.HomeWorkSys2020.My.MySettings.Default.BackGround
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.HomeWorkSys2020.My.MySettings.Default, "BackGround", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox2.Location = New System.Drawing.Point(132, 53)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(258, 20)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "开启"
        Me.Tip2.SetToolTip(Me.CheckBox2, "开启后，启动本程序时会自动开启背景窗体。（重启后生效）")
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = Global.HomeWorkSys2020.My.MySettings.Default.TopMost
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.HomeWorkSys2020.My.MySettings.Default, "TopMost", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(132, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(264, 20)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "开启"
        Me.Tip2.SetToolTip(Me.CheckBox1, "开启后，本程序的窗体将保持在最前端。（重启后生效）")
        Me.CheckBox1.UseVisualStyleBackColor = False
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
        Me.Tip2.SetToolTip(Me.Button8, "修改通知的显示字体。（重启后生效）")
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
        Me.Tip2.SetToolTip(Me.Button7, "修改未完成的任务显示字体。（重启后生效）")
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
        Me.Tip2.SetToolTip(Me.Button6, "修改已完成的任务显示字体。（重启后生效）")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.HomeWorkSys2020.My.MySettings.Default, "ExpireDate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 189)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(171, 26)
        Me.DateTimePicker1.TabIndex = 15
        Me.Tip2.SetToolTip(Me.DateTimePicker1, "修改任务的截止时间。（重启后生效）")
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
        Me.Tip2.SetToolTip(Me.Button5, "修改通知的显示颜色。（重启后生效）")
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
        Me.Tip2.SetToolTip(Me.Button4, "修改未完成的任务显示颜色。（重启后生效）")
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
        Me.Tip2.SetToolTip(Me.Button3, "修改已完成的任务显示颜色。（重启后生效）")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "Subjects", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(128, 59)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(216, 26)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = Global.HomeWorkSys2020.My.MySettings.Default.Subjects
        Me.Tip2.SetToolTip(Me.TextBox3, "你的加三选课。")
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "Title", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox1.Location = New System.Drawing.Point(128, 25)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(216, 26)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = Global.HomeWorkSys2020.My.MySettings.Default.Title
        Me.Tip2.SetToolTip(Me.TextBox1, "任务程序的标题。")
        '
        'CheckBox4
        '
        Me.CheckBox4.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox4.Checked = Global.HomeWorkSys2020.My.MySettings.Default.DebugMode
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.HomeWorkSys2020.My.MySettings.Default, "DebugMode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox4.Location = New System.Drawing.Point(132, 30)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(259, 20)
        Me.CheckBox4.TabIndex = 19
        Me.CheckBox4.Text = "开启"
        Me.Tip2.SetToolTip(Me.CheckBox4, "在控制台中输出debug信息。（仅供开发者使用）")
        Me.CheckBox4.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.Checked = Global.HomeWorkSys2020.My.MySettings.Default.ShowMusicForm
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.HomeWorkSys2020.My.MySettings.Default, "ShowMusicForm", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox3.Location = New System.Drawing.Point(132, 132)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(228, 21)
        Me.CheckBox3.TabIndex = 19
        Me.CheckBox3.Text = "开启"
        Me.Tip2.SetToolTip(Me.CheckBox3, "开启后，程序启动时会附加启动一个音乐播放器。（重启后生效）")
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "TimerFrequency", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Location = New System.Drawing.Point(128, 59)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(137, 26)
        Me.TextBox4.TabIndex = 1
        Me.TextBox4.Text = Global.HomeWorkSys2020.My.MySettings.Default.TimerFrequency
        Me.Tip2.SetToolTip(Me.TextBox4, "任务界面的刷新频率，可因电脑性能调整（单位ms）。（重启后生效）")
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.HomeWorkSys2020.My.MySettings.Default, "ServerURL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox5.Location = New System.Drawing.Point(128, 25)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(216, 26)
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.Text = Global.HomeWorkSys2020.My.MySettings.Default.ServerURL
        Me.Tip2.SetToolTip(Me.TextBox5, "修改服务器地址（一般无需修改，以防程序错误）。（重启后生效）")
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(864, 531)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lbl_Tip2)
        Me.Controls.Add(Me.Progress_All)
        Me.Controls.Add(Me.lbl_Title)
        Me.Controls.Add(Me.lbl_CountDown)
        Me.Controls.Add(Me.lbl_Tip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMain"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_Detail.ResumeLayout(False)
        Me.group_Detail.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SettingPanel.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Tip2 As ToolTip
    Friend WithEvents timer_RunOnce As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
End Class
