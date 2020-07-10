Imports System.Web.Script.Serialization

Public Class Tsklist
    Private Shared ReadOnly Log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    ''' <summary>
    ''' 作者 不做评论
    ''' </summary>
    Public Structure Task '设置任务结构
        Dim tskName As String
        Dim tskDetail As String
        Dim isInfo As Boolean '是否为通知类信息（则无需计算进度）
        Dim tskProgress As Long '当前进度
        Dim tskTotal As Long '总进度
        Dim Files As String '附件
    End Structure
    Public Structure Subject '设置学科结构
        Dim subName As String
        Dim subTasks() As Task
        Public tskCount As Long
        ''' <summary>
        ''' 获取任务数量
        ''' </summary>
        ''' <returns></returns>
        Public Function Count() As Long
            Try
                Return subTasks.Count
            Catch ex As Exception
                Log.Error(ex.Message)
                Return 0
            End Try
        End Function
        ''' <summary>
        ''' 新增一个任务
        ''' </summary>
        ''' <param name="TaskName"></param>
        ''' <param name="isInfo"></param>
        ''' <param name="Total"></param>
        ''' <param name="Progress"></param>
        ''' <param name="TaskDetail"></param>
        ''' <param name="FileURL"></param>
        Public Sub AddTask(TaskName As String, isInfo As Boolean, Total As Long, Progress As Long, Optional TaskDetail As String = "", Optional FileURL As String = "")
            ReDim Preserve subTasks(Count()) 'Redim确定新数组长度，preserve保存原始数据
            With subTasks(Count() - 1)
                .tskName = TaskName
                .isInfo = isInfo
                .tskTotal = Total
                .tskProgress = Progress
                .tskDetail = TaskDetail
                .Files = FileURL
            End With
            tskCount = Count()
        End Sub
    End Structure
    Public Author As String
    Public Subjects() As Subject
    Public SubCount As Long
    ''' <summary>
    ''' 初始化
    ''' </summary>
    Public Sub New()
        Author = ""
        SubCount = Count()
    End Sub
    ''' <summary>
    ''' 获得学科数量
    ''' </summary>
    ''' <returns></returns>
    Public Function Count() As Long
        Try
            Return Subjects.Count
        Catch ex As Exception
            Log.Error(ex.Message)
            Return 0
        End Try
    End Function
    ''' <summary>
    ''' 新增一门学科
    ''' </summary>
    ''' <param name="SubName"></param>
    Public Sub AddSubject(SubName As String)
        If SubIndex(SubName) = -1 Then
            ReDim Preserve Subjects(Count()) 'Redim确定新数组长度，preserve保存原始数据
            Subjects(Count() - 1).subName = SubName
            SubCount = Count()
        End If
    End Sub
    ''' <summary>
    ''' 返回第一个找到的与学科名称相匹配的数组下标，若未找到，则返回-1
    ''' </summary>
    ''' <param name="SubName"></param>
    ''' <returns></returns>
    Public Function SubIndex(SubName As String) As Long
        Dim i As Long
        For i = 0 To Count() - 1
            If Subjects(i).subName = SubName Then Return i
        Next
        Return -1
    End Function

    Public Function Convert2Json() As String
        Dim serializer As New JavaScriptSerializer()
        Dim result As String = serializer.Serialize(Me)
        Return result
    End Function
End Class
