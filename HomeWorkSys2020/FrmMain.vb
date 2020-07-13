Imports System.IO
Imports log4net '日志文件的引用
Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class FrmMain
    Structure Task
        Public GlobalID As Long
        Public subject As String
        Public name As String
        Public detail As String
        Public progress As String
        Public url As String
        Public show As Boolean
    End Structure
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As IntPtr, ByVal lParam As Byte()) As Integer
    Public Const EM_SETCUEBANNER As Integer = &H1501
    Dim x As Single = 0
    Dim y As Single = 0 '窗体缩放
    ReadOnly ExpireDate As Date = My.Settings.ExpireDate
    Public Global_Progress, Global_Total As Long
    Dim List_Selected As Integer = -1
    Public Author As String
    Public loaded As Boolean
    Private m_SortingColumn As ColumnHeader  '排序的列
    Private Shared ReadOnly Log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    Dim RemainList() As Task, RemainList_count = 0
    ''' <summary>
    ''' 添加列表项
    ''' </summary>
    ''' <param name="SubjectName"></param>
    ''' <param name="TaskName"></param>
    ''' <param name="TaskDetail"></param>
    ''' <param name="isInfo"></param>
    ''' <param name="TaskProgress"></param>
    ''' <param name="TaskTotal"></param>
    ''' <returns></returns>
    Public Function AddIntoList(SubjectName As String, TaskName As String, TaskDetail As String, isInfo As Boolean, TaskProgress As Long, TaskTotal As Long, FileURL As String) As Long
        Dim item0 As String = (SubjectName)
        Dim item1 As String = (TaskName)
        Dim item2 As String = (TaskDetail)
        Dim item3 As String
        If isInfo Then
            item3 = ("通知")
        Else
            item3 = (TaskProgress & "/" & TaskTotal)
            Global_Progress += TaskProgress
            Global_Total += TaskTotal
        End If
        Dim a = list_Remains.Items.Add(item0)
        a.SubItems.AddRange({item1, item2, item3, FileURL, RemainList_count})
        If isInfo Then
            a.ForeColor = My.Settings.NotificationColor
            a.Font = My.Settings.NotificationFont
            a.StateImageIndex = 2
        Else
            If TaskProgress = TaskTotal Then
                a.ForeColor = My.Settings.FinishedColor
                a.Font = My.Settings.FinishedFont
                a.StateImageIndex = 1
            Else
                a.ForeColor = My.Settings.UnfinishedColor
                a.Font = My.Settings.UnfinishedFont
                a.StateImageIndex = 0
            End If
        End If
        ReDim Preserve RemainList(RemainList_count)
        With RemainList(RemainList_count)
            .GlobalID = RemainList_count
            .subject = item0
            .name = item1
            .detail = item2
            .progress = item3
            .url = FileURL
            .show = True
        End With
        RemainList_count += 1
        Return 0
    End Function

    Public Sub RefreshList()
        list_Remains.Items.Clear()
        For i = 0 To RemainList.Count - 1
            With RemainList(i)
                If .show = True Then
                    Dim a = list_Remains.Items.Add(.subject)
                    a.SubItems.AddRange({ .name, .detail, .progress, .url, .GlobalID})
                    If .progress = "通知" Then
                        a.ForeColor = My.Settings.NotificationColor
                        a.Font = My.Settings.NotificationFont
                        a.StateImageIndex = 2
                    Else
                        Dim progress() As String
                        progress = Split(.progress, "/")
                        If progress(0) = progress(1) Then
                            a.ForeColor = My.Settings.FinishedColor
                            a.Font = My.Settings.FinishedFont
                            a.StateImageIndex = 1
                        Else
                            a.ForeColor = My.Settings.UnfinishedColor
                            a.Font = My.Settings.UnfinishedFont
                            a.StateImageIndex = 0
                        End If
                    End If
                End If
            End With
        Next
    End Sub
    ''' <summary>
    ''' 清除所有任务
    ''' </summary>
    Public Sub Cls()
        list_Remains.Items.Clear()
    End Sub
    ''' <summary>
    ''' 修改进度
    ''' </summary>
    ''' <param name="Add"></param>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    Public Function ProgressChange(Index As Integer, Add As Boolean, Value As Long) As Long
        Try
            Dim progress() As String
            With RemainList(Index)
                progress = Split(.progress, "/")
                If Add Then
                    progress(0) = IIf(progress(0) + Value >= 0 And progress(0) + Value <= progress(1), progress(0) + Value, progress(0))
                Else
                    progress(0) = IIf(Value >= 0 And Value <= progress(1), Value, progress(0))
                End If
                .progress = progress(0) + "/" + progress(1)
                Dim saveData As String
                saveData = SaveList()
                IO.File.WriteAllText(Application.UserAppDataPath + "\Data\Works.json", saveData) '自动保存
                RefreshList()
                Return progress(0)
            End With
        Catch ex As Exception
            Log.Error(ex.Message)
            DbP(ex.Message)
            Return (0)
        End Try
    End Function
    ''' <summary>
    ''' 字符串转拼音
    ''' </summary>
    ''' <param name="chars"></param>
    ''' <returns></returns>
    Public Function ToPinyin(ByVal chars As String) As String
        Dim pinyin As String = ""
        Dim charArray() As Char = chars.ToCharArray
        Dim frmt As hyjiacan.py4n.PinyinFormat = hyjiacan.py4n.PinyinFormat.WITHOUT_TONE Or hyjiacan.py4n.PinyinFormat.LOWERCASE Or hyjiacan.py4n.PinyinFormat.WITH_V
        For Each c As Char In charArray
            If hyjiacan.py4n.PinyinUtil.IsHanzi(c) Then
                pinyin += hyjiacan.py4n.Pinyin4Net.GetPinyin(c, frmt)(0)
            Else
                pinyin += c
            End If
        Next
        Return pinyin
    End Function

    ''' <summary>
    ''' 更新进度
    ''' </summary>
    ''' <returns></returns>
    Public Function UpdateProgress() As Long
        'On Error Resume Next
        Dim i As Integer
        Global_Total = 0
        Global_Progress = 0
        For i = 0 To RemainList.Count - 1
            If RemainList(i).progress <> "通知" Then
                Global_Total += Split(RemainList(i).progress, "/")(1)
                Global_Progress += Split(RemainList(i).progress, "/")(0)
            End If
        Next
        If Global_Total = 0 Then
            lbl_Tip2.Text = "100.00%"
            Progress_All.Value = 100
        Else
            lbl_Tip2.Text = Format(Global_Progress / Global_Total, "0.00%")
            Progress_All.Value = Global_Progress / Global_Total * 100
        End If
        Return Progress_All.Value
    End Function
    ''' <summary>
    ''' 保存进度
    ''' </summary>
    Public Function SaveList() As String
        Dim json As New Tsklist
        Dim i
        json.Author = Author
        For i = 0 To RemainList.Count - 1
            json.AddSubject(RemainList(i).subject)
            Dim taskname, taskdetail As String
            Dim isinfo As Boolean
            Dim total, progress As Long
            Dim fileurl As String
            fileurl = RemainList(i).url
            taskname = RemainList(i).name
            taskdetail = RemainList(i).detail
            isinfo = IIf(RemainList(i).progress = "通知", True, False)
            If RemainList(i).progress <> "通知" Then
                total = Split(RemainList(i).progress, "/")(1)
                progress = Split(RemainList(i).progress, "/")(0)
            Else
                total = 0
                progress = 0
            End If
            json.Subjects(json.SubIndex(RemainList(i).subject)).AddTask(taskname, isinfo, total, progress, taskdetail, fileurl)
        Next
        Return (json.Convert2Json)
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Log.Info("HomeWkSys " + My.Application.Info.Version.ToString + " By BZPL")
        CheckBox5.Checked = True
        CheckBox6.Checked = True
        loaded = False
        FrmFirstime.Show()
        Me.Hide()
        While Not loaded
            My.Application.DoEvents()
        End While
        My.Application.DoEvents()
        Me.Show()
        Me.Opacity = My.Settings.Opacity / 100
        lbl_Version.Text = My.Application.Info.Version.ToString
        If My.Settings.BackGround Then FrmBg.Show()
        Me.Text = My.Settings.Title
        lbl_Title.Text = My.Settings.Title
        Me.TopMost = My.Settings.TopMost
        timer_Fun1.Interval = My.Settings.TimerFrequency
        If My.Settings.ShowMusicForm Then FrmMusic.Show()
        Try
            If Dir(Application.UserAppDataPath + "\Data\") = Nothing Then
                MkDir(Application.UserAppDataPath + "\Data\")
            End If
        Catch ex As Exception
            Log.Error(ex.Message)
        End Try
        timer_Fun1.Enabled = True
        timer_Fun2.Enabled = True
        timer_RunOnce.Enabled = True
        SendMessage(TextBox8.Handle, EM_SETCUEBANNER, IntPtr.Zero, System.Text.Encoding.Unicode.GetBytes("键入以搜索（支持拼音）"))
    End Sub

    Private Sub TxtDetail_progress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Detail_progress.KeyPress
        Dim t = e.KeyChar
        If (Asc(t) >= Asc("0")) = True And (Asc(t) <= Asc("9")) = True Then
            If txt_Detail_progress.TextLength >= txt_Detail_progress.MaxLength Then Exit Sub
            txt_Detail_progress.Text += CStr(t)
        End If
    End Sub

    Private Sub TxtDetail_progress_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Detail_progress.KeyDown
        If e.KeyCode = 8 Then
            If txt_Detail_progress.TextLength <= 0 Then
                Exit Sub
            End If
            txt_Detail_progress.Text = Microsoft.VisualBasic.Left(txt_Detail_progress.Text, txt_Detail_progress.Text.Length - 1)
        End If
    End Sub
    Private Sub Timer_Fun1_Tick(sender As Object, e As EventArgs) Handles timer_Fun1.Tick
        My.Application.DoEvents()
        lbl_CountDown.Text = "你的假期还剩下" & TransTime(DateDiff("s", Now, ExpireDate))
        GC.Collect()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Test1.Click
        If MsgBox("警告！！" & vbCrLf & "如果你不知道这是做什么的，请勿继续", vbExclamation + vbYesNo, "警告！！") = vbNo Then Exit Sub
        Dim json As String
        json = (CreateSimpleHomework())
        DbP(json)
        If Dir(Application.UserAppDataPath + "\Data\") = Nothing Then
            MkDir(Application.UserAppDataPath + "\Data\")
        End If
        FileOpen(1, Application.UserAppDataPath + "\Data\Works.json", OpenMode.Output)
        Print(1, json)
        FileClose(1)
        MsgBox(Application.UserAppDataPath + "\Data\Works.json")
    End Sub

    Private Sub Timer_Fun2_Tick(sender As Object, e As EventArgs) Handles timer_Fun2.Tick
        My.Application.DoEvents()

        UpdateProgress()
        If List_Selected = -1 Then Exit Sub
        Try
            With RemainList(List_Selected)
                txt_Detail_subject1.Text = .name
                txt_Detail1.Text = .detail
                If .url <> "" Then
                    If LinkLabel1.Visible = False Then
                        LinkLabel1.Visible = True
                        LinkLabel1.Links.Clear()
                        LinkLabel1.Links.Add(LinkLabel1.Text.Length - 4, 4, .url)
                    End If
                Else
                    LinkLabel1.Visible = False
                End If
                If .progress = "通知" Then
                    Progress_Detail_Progress1.Value = 100
                    txt_Detail_progress.Text = "0"
                    lbl_Detail_Progress1.Text = "/0"
                Else
                    Dim progress() As String
                    progress = Split(.progress, "/")
                    'txt_Detail_progress.Text = progress(0)
                    lbl_Detail_Progress1.Text = "/" & progress(1)
                    Progress_Detail_Progress1.Value = (progress(0) / progress(1)) * 100
                End If
                btn_Detail_add1.Enabled = True
                btn_Detail_Minus1.Enabled = True
                btn_Detail_ChangeProgress1.Enabled = True
            End With
        Catch ex As Exception
            Log.Error(ex.Message)
            btn_Detail_add1.Enabled = False
            btn_Detail_Minus1.Enabled = False
            btn_Detail_ChangeProgress1.Enabled = False
            lbl_Detail_Progress1.Text = "/999"
            txt_Detail_progress.Text = 999
            Progress_Detail_Progress1.Value = 0
            txt_Detail_subject1.Text = "未知"
            txt_Detail1.Text = "请先选择一项任务"
            'DbP(ex.Message)
        End Try
    End Sub
    ''' <summary>
    ''' 寻找列表对应ID
    ''' </summary>
    ''' <param name="list_Selected"></param>
    ''' <returns></returns>
    Private Function Finditem(list_Selected As Integer) As Integer
        For i = 0 To RemainList.Count - 1
            If list_Remains.Items.Item(i).SubItems(5).Text = list_Selected Then
                Return i
            End If
        Next
        Return 0
    End Function
    Private Sub Btn_Detail_Minus1_Click(sender As Object, e As EventArgs) Handles btn_Detail_Minus1.Click
        txt_Detail_progress.Text = ProgressChange(List_Selected, True, -1)
        list_Remains.Items.Item(Finditem(List_Selected)).Selected = True
        list_Remains.SelectedItems.Item(0).EnsureVisible()
    End Sub


    Private Sub Btn_Detail_ChangeProgress1_Click(sender As Object, e As EventArgs) Handles btn_Detail_ChangeProgress1.Click
        txt_Detail_progress.Text = ProgressChange(List_Selected, False, CInt(txt_Detail_progress.Text))
        list_Remains.Items.Item(Finditem(List_Selected)).Selected = True
        list_Remains.SelectedItems.Item(0).EnsureVisible()
    End Sub

    Private Sub Btn_Detail_add1_Click(sender As Object, e As EventArgs) Handles btn_Detail_add1.Click
        txt_Detail_progress.Text = ProgressChange(List_Selected, True, 1)
        list_Remains.Items.Item(Finditem(List_Selected)).Selected = True
        list_Remains.SelectedItems.Item(0).EnsureVisible()
    End Sub

    Private Sub Btn_Test2_Click(sender As Object, e As EventArgs) Handles btn_Test2.Click
        Dim json1, json2 As String
        json1 = SaveList()
        json2 = IO.File.ReadAllText(Application.UserAppDataPath + "\Data\Works.json")
        MsgBox(IIf(String.Compare(json1, json2) = 0, "保存核验通过", "保存核验不通过" & vbCrLf & json1 & vbCrLf & vbCrLf & json2))
        IO.File.WriteAllText(Application.UserAppDataPath + "\Data\Works1.json", json1)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Btn_testmusic_Click(sender As Object, e As EventArgs) Handles btn_testmusic.Click
        FrmMusic.Show()
    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ColorDialog1.AllowFullOpen = True
        ColorDialog1.Color = Button1.ForeColor
        Dim result = ColorDialog1.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub
        Button1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.Title = "选择一张背景图片"
        OpenFileDialog1.Multiselect = False
        Dim result = OpenFileDialog1.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub
        Try
            OpenFileDialog1.OpenFile().Close()
            TextBox2.Text = OpenFileDialog1.FileName
        Catch exc As Exception
            Log.Error(exc.Message)
            DbP(exc.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ColorDialog1.AllowFullOpen = True
        ColorDialog1.Color = Button3.ForeColor
        Dim result = ColorDialog1.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub
        Button3.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ColorDialog1.AllowFullOpen = True
        ColorDialog1.Color = Button4.ForeColor
        Dim result = ColorDialog1.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub
        Button4.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ColorDialog1.AllowFullOpen = True
        ColorDialog1.Color = Button5.ForeColor
        Dim result = ColorDialog1.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub
        Button5.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        OpenFileDialog1.Title = "选择一个任务文件（请不要随意更改）"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.ShowDialog()
        Try
            OpenFileDialog1.OpenFile().Close()
            TextBox6.Text = OpenFileDialog1.FileName
        Catch exc As Exception
            Log.Error(exc.Message)
            DbP(exc.Message)
        End Try
    End Sub

    Private Sub List_Remains_SelectedIndexChanged(sender As Object, e As EventArgs) Handles list_Remains.SelectedIndexChanged
        Dim status As Boolean = True
        Try
            DbP(list_Remains.SelectedItems.Item(0).SubItems(5).Text)
        Catch ex As Exception
            Log.Error(ex.Message)
            status = False
        End Try
        If status Then
            List_Selected = list_Remains.SelectedItems.Item(0).SubItems(5).Text
            txt_Detail_progress.Text = IIf(Split(list_Remains.SelectedItems.Item(0).SubItems(3).Text, "/")(0) <> "通知", Split(list_Remains.SelectedItems.Item(0).SubItems(3).Text, "/")(0), 0)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FontDialog1.Reset()
        FontDialog1.ShowEffects = True
        FontDialog1.Font = Button6.Font
        Dim result = FontDialog1.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub
        Button6.Font = FontDialog1.Font
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FontDialog1.Reset()
        FontDialog1.ShowEffects = True
        FontDialog1.Font = Button7.Font
        Dim result = FontDialog1.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub
        Button7.Font = FontDialog1.Font
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        FontDialog1.Reset()
        FontDialog1.ShowEffects = True
        FontDialog1.Font = Button8.Font
        Dim result = FontDialog1.ShowDialog()
        If result = DialogResult.Cancel Then Exit Sub
        Button8.Font = FontDialog1.Font
    End Sub

    Private Sub EventLog1_EntryWritten(sender As Object, e As EntryWrittenEventArgs)

    End Sub

    Private Sub FrmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Btn_resetSettings_Click(sender As Object, e As EventArgs) Handles btn_resetSettings.Click
        Dim a, b
        a = My.Settings.Title
        b = My.Settings.Subjects
        If MsgBox("这个操作将会还原一切设置，确定要继续吗？", vbExclamation + vbYesNo, "警告") = vbYes Then
            My.Settings.Reset()
            My.Settings.Title = a
            My.Settings.Subjects = b
            My.Settings.Save()
            MsgBox("重置完成，即将重启程序", vbInformation, "提示")
            Application.Restart()
        End If
    End Sub

    Private Sub Btn_ResetFiles_Click(sender As Object, e As EventArgs) Handles btn_ResetFiles.Click
        If MsgBox("这个操作将会删除所有配置文件，确定要继续吗？", vbExclamation + vbYesNo, "警告") = vbYes Then
            Try
                Kill(Application.UserAppDataPath + "\Data\*.*")
                Kill(Application.UserAppDataPath + "\Download\*.*")
            Catch ex As Exception
                Log.Error(ex.Message)
            End Try
            MsgBox("重置完成，即将重启程序", vbInformation, "提示")
            Application.Restart()
        End If
    End Sub

    Private Sub Btn_ResetAll_Click(sender As Object, e As EventArgs) Handles btn_ResetAll.Click
        Dim a, b
        a = My.Settings.Title
        b = My.Settings.Subjects
        If MsgBox("这个操作将会删除所有配置文件和设置，确定要继续吗？", vbExclamation + vbYesNo, "警告") = vbYes Then
            Try
                My.Settings.Reset()
                My.Settings.Title = a
                My.Settings.Save()
                Kill(Application.UserAppDataPath + "\Data\*.*")
                Kill(Application.UserAppDataPath + "\Download\*.*")
            Catch ex As Exception
                Log.Error(ex.Message)
            End Try
            MsgBox("重置完成，即将重启程序", vbInformation, "提示")
            Application.Restart()
        End If
    End Sub

    Private Sub FrmMain_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_showCreateTask.Click
        If MsgBox("警告！！" & vbCrLf & "如果你不知道这是做什么的，请勿继续", vbExclamation + vbYesNo, "警告！！") = vbNo Then Exit Sub
        FrmTaskEdit.Show()
    End Sub

    Private Sub Lnk_Donate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Donate.LinkClicked
        FrmDonate.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim url = LinkLabel1.Links.Item(0).LinkData.ToString
        System.Diagnostics.Process.Start(url)
    End Sub

    ''' <summary>
    ''' 列表排序
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub List_Remains_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles list_Remains.ColumnClick
        ' Get the new sorting column.
        Dim new_sorting_column As ColumnHeader = sender.Columns(e.Column)
        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.EndsWith("▲") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If
            ' Remove the old sort indicator.
            m_SortingColumn.Text = m_SortingColumn.Text.Substring(0, m_SortingColumn.Text.Length - 1)
        End If
        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text &= "▲"
        Else
            m_SortingColumn.Text &= "▼"
        End If
        ' Create a comparer.
        sender.ListViewItemSorter = New ClsListviewSorter(e.Column, sort_order)
        ' Sort.
        sender.Sort()
    End Sub

    Private Sub List_Remains_Click(sender As Object, e As EventArgs) Handles list_Remains.Click
        Try
            With list_Remains.Items.Item(List_Selected)
                If .SubItems(4).Text <> "" Then
                    LinkLabel1.Visible = True
                    LinkLabel1.Links.Clear()
                    LinkLabel1.Links.Add(LinkLabel1.Text.Length - 4, 4, .SubItems(4).Text)
                Else
                    LinkLabel1.Visible = False
                End If
            End With
        Catch ex As Exception
            Log.Error(ex.Message)
            'DbP(ex.Message)
        End Try
    End Sub
    Private Sub FrmLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        x = Me.Width
        y = Me.Height
        SetTag(Me)
    End Sub
    '递归取控件的原始大小和位置，用tag来纪录
    Private Sub SetTag(ByVal obj As Object)
        For Each con As Control In obj.Controls
            'Application.DoEvents()
            con.Tag = con.Width & ":" & con.Height & ":" & con.Left & ":" & con.Top & ":" & con.Font.Size
            '如果是容器控件，则递归继续纪录
            If con.Controls.Count > 0 Then
                SetTag(con)
            End If
        Next
    End Sub
    '递归重新设定控件的大小和位置
    Private Sub SetControls(ByVal newx As Single, ByVal newy As Single, ByVal obj As Object)
        For Each con As Control In obj.Controls
            'Application.DoEvents()
            'Try
            con.AutoSize = False
            Dim mytag() As String = con.Tag.ToString.Split(":")
            con.Width = mytag(0) * newx
            con.Height = mytag(1) * newy
            con.Left = mytag(2) * newx
            con.Top = mytag(3) * newy
            con.AutoSize = con.AutoSize
            '计算字体缩放比例，缩放字体
            Dim currentSize As Single = (mytag(1) * newy * mytag(4)) / mytag(1)
            con.Font = New Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit)
            '如果是容器控件，则递归继续缩放
            If con.Controls.Count > 0 Then
                SetControls(newx, newy, con)
            End If
            'Catch ex As Exception
            ' Log.Warn(ex.Message)
            'End Try
        Next
    End Sub

    Private Sub FrmResize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        '得到现在窗体的大小，然后根据原始大小计算缩放比例
        'Application.DoEvents()
        Dim newx As Single = Me.Width / x
        Dim newy As Single = Me.Height / y
        SetControls(newx, newy, Me)
    End Sub

    Private Sub Timer_RunOnce_Tick(sender As Object, e As EventArgs) Handles timer_RunOnce.Tick
        Me.Height = 600 / 1080 * Screen.PrimaryScreen.Bounds.Height
        Me.Width = 950 / 1920 * Screen.PrimaryScreen.Bounds.Width
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Height) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Width) / 2
        Try
            Dim json As String
            json = IO.File.ReadAllText(Application.UserAppDataPath + "\Data\Works.json")
            AnalyzeJson(json)
        Catch ex As Exception
            Log.Error(ex.Message)
        End Try
        timer_RunOnce.Enabled = False
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        ListSearch(TextBox8.Text)
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        ListSearch(TextBox8.Text)
    End Sub

    ''' <summary>
    ''' 搜索列表中的项目
    ''' </summary>
    ''' <param name="text"></param>
    Private Sub ListSearch(Text As String)
        Try
            For i As Integer = 0 To RemainList.Count - 1
                Dim oristr As String = RemainList(i).subject + RemainList(i).name + RemainList(i).detail + RemainList(i).progress + RemainList(i).url
                Dim nowstr As String = ToPinyin(oristr)
                If InStr(nowstr, Text) = 0 Then
                    RemainList(i).show = False
                Else
                    RemainList(i).show = True
                End If
                If CheckBox5.Checked = False And RemainList(i).progress = "通知" Then
                    RemainList(i).show = False
                Else
                    If CheckBox6.Checked = False And RemainList(i).progress <> "通知" Then
                        If Split(RemainList(i).progress, "/")(0) = Split(RemainList(i).progress, "/")(1) Then
                            RemainList(i).show = False
                        End If
                    End If
                End If
                RefreshList()
            Next
        Catch ex As Exception
            Log.Error(ex.Message)
        End Try
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        ListSearch(ToPinyin(TextBox8.Text))
    End Sub

End Class
