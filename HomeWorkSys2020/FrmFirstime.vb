Public Class FrmFirstime
    Private ReadOnly Log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)

    ''' <summary>
    ''' 创建桌面快捷方式
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CreateDesktopShortcut()
        Try
            Dim WshShell As Object, MyShortcut As Object
            WshShell = CreateObject("Wscript.shell")
            Dim strDesktop As String
            strDesktop = WshShell.SpecialFolders("Desktop")
            MyShortcut = WshShell.CreateShortcut(strDesktop + "\" + My.Settings.Title + ".lnk") '此处为快捷名称
            MyShortcut.TargetPath = Application.ExecutablePath  '此处为源文件
            'MyShortcut.IconLocation '此处为快捷图标,默认为应用程序的图标
            MyShortcut.WorkingDirectory = Application.StartupPath  '工作目录
            MyShortcut.Description = "点击以启动" + My.Settings.Title '备注
            'MyShortcut.Hotkey = "ALT+CTRL+A" '此处为快捷热键
            MyShortcut.Save
        Catch ex As Exception
            Log.Error(ex.Message)
        End Try
    End Sub

    Private Sub FrmFirstime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        My.Application.DoEvents()
        '1
        Dim offline As Boolean
        lbl_Progress.Text = "正在检测网络配置"
        Log.Info("正在检测网络配置")
        If My.Computer.Network.IsAvailable Then '网络连接正常
            lbl_Progress.Text = "网络连接正常"
            Log.Info("网络连接正常")
            Try
                Kill(Application.StartupPath + "\Download\nettest")
            Catch ex As Exception
                Log.Error(ex.Message)
            End Try
            Try
                My.Computer.Network.DownloadFile("http://" + My.Settings.ServerURL + "/Homewksys/nettest.txt", Application.StartupPath + "\Download\nettest")
                If IO.File.ReadAllText(Application.StartupPath + "\Download\nettest") = "OK" Then
                    offline = False
                    Log.Info("成功从服务器返回数据")
                Else
                    offline = True
                    Log.Error("从服务器返回数据失败")
                End If
                Try
                    Kill(Application.StartupPath + "\Download\nettest")
                Catch ex As Exception
                    Log.Error(ex.Message)
                End Try
            Catch ex As Exception
                offline = True
                Log.Error("服务器连接错误，进入离线模式" + vbCrLf + ex.Message)
            End Try
        Else
            lbl_Progress.Text = "网络连接错误，进入离线模式"
            Log.Error("服务器连接错误，进入离线模式")
            offline = True
        End If
        ProgressBar1.Value += 25
        Label3.Text = Format(ProgressBar1.Value / 100, "0.00%")
        '2
        Dim subs(), choice, ans As String
        lbl_Progress.Text = "检查任务文件是否存在..."
        Log.Info("检查任务文件是否存在...")
        If System.IO.File.Exists(Application.StartupPath + "\Data\Works.json") = False Then
            If offline = False Then
                lbl_Progress.Text = "创建桌面快捷方式..."
                CreateDesktopShortcut()
                lbl_Progress.Text = "任务文件不存在，正在从互联网中获取..."
                Log.Info("任务文件不存在，正在从互联网中获取...")
                Try
                    Kill(Application.StartupPath + "\Download\SubjectList.txt")
                Catch exc As Exception
                    Log.Error(exc.Message)
                End Try
                Try
                    Log.Info("http://" + My.Settings.ServerURL + "/Homewksys/SubjectList.txt->" + Application.StartupPath + "\Download\SubjectList.txt")
                    My.Computer.Network.DownloadFile("http://" + My.Settings.ServerURL + "/Homewksys/SubjectList.txt", Application.StartupPath + "\Download\SubjectList.txt")
                Catch exc As Exception
                    Log.Fatal(exc.Message)
                    MsgBox("程序遇到致命错误，请联系开发者1398456099" + vbCrLf + exc.Message, vbCritical)
                    End
                End Try
                Log.Info("选科列表获取成功,请选择您的选科。")
                lbl_Progress.Text = "选科列表获取成功,请选择您的选科。"
                subs = IO.File.ReadAllLines(Application.StartupPath + "\Download\SubjectList.txt")
                Dim i
                For i = 1 To subs.Count
                    FrmChooseSubject.ComboBox1.Items.Add(subs(i - 1))
                Next
CS:             FrmChooseSubject.ShowDialog()
                choice = FrmChooseSubject.choice
                Try
                    ans = choice
                    If ans = "" Then
                        Log.Error("请选择选科！")
                        MsgBox("请选择选科！", vbCritical, "错误")
                        GoTo CS
                    End If
                    If MsgBox(String.Format("您选择的加三科目为{0}，确认无误？", ans), vbYesNo + vbInformation, "确认") = vbNo Then GoTo CS
                Catch ex As Exception
                    Log.Error("请选择选科！")
                    MsgBox("请选择选科！", vbCritical, "错误")
                    GoTo CS
                End Try

                ProgressBar1.Value += 25
                Label3.Text = Format(ProgressBar1.Value / 100, "0.00%")
                '3
                Log.Info("下载对应选科文件...")
                lbl_Progress.Text = "下载对应选科文件..."
                Try
                    Kill(Application.StartupPath + "\Data\Works.json") '\" & ans & ".json")
                Catch exc1 As Exception
                    DbP(exc1.Message)
                    Log.Error(exc1.Message)
                End Try
                Try
                    My.Computer.Network.DownloadFile("http://" + My.Settings.ServerURL + "/Homewksys/" & ans & ".json", Application.StartupPath + "\Data\Works.json")
                Catch exc2 As Exception
                    Log.Fatal(exc2.Message)
                    MsgBox("程序遇到致命错误，请联系开发者1398456099" + vbCrLf + exc2.Message, vbCritical)
                    End
                End Try
                My.Settings.Subjects = ans
                ProgressBar1.Value += 25
                Label3.Text = Format(ProgressBar1.Value / 100, "0.00%")
            Else
                Log.Fatal("无法从服务器下载文件")
                MsgBox("网络连接失败，无法更新作业信息！" + vbCrLf + "请联系作者1398456099。", vbCritical, "错误")
                End
            End If
        Else
            Log.Info("任务文件检查通过.")
            lbl_Progress.Text = "任务文件检查通过."
            ProgressBar1.Value += 50
            Label3.Text = Format(ProgressBar1.Value / 100, "0.00%")
        End If
        '4
        Log.Info("检查设置...")
        lbl_Progress.Text = "检查设置..."
        Dim a
        Try
            a = CInt(My.Settings.Opacity)
        Catch ex As Exception
            Log.Error(ex.Message)
            My.Settings.Opacity = 80
            DbP("Err:My.Settings.Opacity")
        End Try
        Try
            a = CInt(My.Settings.TimerFrequency)
        Catch ex As Exception
            Log.Error(ex.Message)
            My.Settings.TimerFrequency = 100
            DbP("Err:My.Settings.TimerFrequency")
        End Try
        Log.Info("检查完毕.")
        lbl_Progress.Text = "检查完毕."
        ProgressBar1.Value += 25
        Label3.Text = Format(ProgressBar1.Value / 100, "0.00%")
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        FrmMain.loaded = True
        Finalize()
        Timer1.Enabled = False
    End Sub
End Class