Imports System.Web.Script.Serialization

Module JsonAnalyze
    Private ReadOnly Log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    ''' <summary>
    ''' 随机生成作业文件用以测试
    ''' </summary>
    ''' <returns></returns>
    Public Function CreateSimpleHomework()
        '总数统计体现
        '换行符使用\n表示
        '默认路径为APP目录下\Data\Works.json
        'Dim path As String = Application.StartupPath + "\Data\Works.json"
        Dim Sampletask As New tsklist
        Dim Subject, Task As Long
        Dim rand = New System.Random()
        For Subject = 1 To rand.Next(1, 10)
            Sampletask.AddSubject("Subject" & Subject.ToString)
            For Task = 1 To rand.Next(1, 10)
                Dim CBoolean = IIf(rand.Next(0, 100) >= 51, True, False)
                Sampletask.Subjects(Sampletask.SubIndex("Subject" & Subject.ToString)).AddTask("This is" + vbCrLf + " Task" & Task.ToString, CBoolean, IIf(CBoolean = False, rand.Next(1, 10), 0), 0, "This is the detail of the task" & Task.ToString & ".")
            Next
        Next
        Sampletask.Author = "SampleTask"
        Return (Sampletask.Convert2Json)
    End Function
    ''' <summary>
    ''' 将Json解析后加入到任务列表中
    ''' </summary>
    ''' <param name="Json"></param>
    Public Sub AnalyzeJson(Json As String)
        Try
            FrmMain.cls()
            FrmMain.Global_Progress = 0
            FrmMain.Global_Total = 0
            Dim jsonResult As Dictionary(Of String, Object)
            Dim jss As New JavaScriptSerializer()
            jsonResult = jss.DeserializeObject(Json) '用Newtonsoft.Json反序列json字符串
            DbP("Author:" & jsonResult("Author"))
            FrmMain.Author = jsonResult("Author")
            Dim i, j As Long
            Dim Subjects As Object = jsonResult("Subjects")
            Dim Tasks As Object
            Dim Subject, Task As Dictionary(Of String, Object)
            For i = 0 To jsonResult("SubCount") - 1
                DbP("------------------")
                Subject = Subjects(i)
                DbP("Subject:" & Subject("subName"))
                Tasks = Subject("subTasks")
                For j = 0 To Subject("tskCount") - 1
                    Task = Tasks(j)
                    DbP("")
                    DbP("TaskName:" & Task("tskName"))
                    DbP("TaskDetail:" & Task("tskDetail"))
                    DbP("isInfo:" & Task("isInfo"))
                    DbP("TaskProgress:" & Task("tskProgress"))
                    DbP("TaskTotal:" & Task("tskTotal"))
                    FrmMain.AddIntoList(Subject("subName"), Task("tskName"), Task("tskDetail"), Task("isInfo"), Task("tskProgress"), Task("tskTotal"))
                Next
            Next
            DbP("------------------")
        Catch e As Exception
            Log.fatal(e.Message)
            MsgBox("解析作业文件时出现错误" + vbCrLf + e.Message, vbObjectError, "错误")
        End Try
    End Sub
End Module
