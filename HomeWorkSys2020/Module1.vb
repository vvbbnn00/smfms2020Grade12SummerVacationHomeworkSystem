Module Module1
    'Private ReadOnly Log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    Public Function TransTime(seconds As Long) As String '用于转换秒为规范日期格式
        Dim dd, hh, nn, ss As Long
        dd = seconds \ 86400
        seconds -= dd * 86400
        hh = seconds \ 3600
        seconds -= hh * 3600
        nn = seconds \ 60
        seconds -= nn * 60
        ss = seconds
        Return (dd & “天” & Format(hh, "00") & "时" & Format(nn, "00") & "分" & Format(ss, "00") & "秒")
    End Function
    ''' <summary>
    ''' 更简洁的DebugPrint，且加入全局调试变量
    ''' </summary>
    ''' <param name="Message"></param>
    Public Sub DbP(Message As String)
        If My.Settings.DebugMode Then
            Debug.Print(Message)
        End If
    End Sub
End Module

Public Class ClsListviewSorter ' listview排序
    Implements IComparer
    Private ReadOnly m_ColumnNumber As Integer
    Private ReadOnly m_SortOrder As SortOrder

    Public Sub New(ByVal column_number As Integer, ByVal sort_order As SortOrder)
        m_ColumnNumber = column_number
        m_SortOrder = sort_order
    End Sub

    ' Compare the items in the appropriate column
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
        Dim item_y As ListViewItem = DirectCast(y, ListViewItem)
        ' Get the sub-item values.
        Dim string_x As String
        If item_x.SubItems.Count <= m_ColumnNumber Then
            string_x = ""
        Else
            string_x = item_x.SubItems(m_ColumnNumber).Text
        End If
        Dim string_y As String
        If item_y.SubItems.Count <= m_ColumnNumber Then
            string_y = ""
        Else
            string_y = item_y.SubItems(m_ColumnNumber).Text
        End If
        ' Compare them.
        If m_SortOrder = SortOrder.Ascending Then
            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return Val(string_x).CompareTo(Val(string_y))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
            Else
                Return String.Compare(string_x, string_y)
            End If
        Else
            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return Val(string_y).CompareTo(Val(string_x))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
            Else
                Return String.Compare(string_y, string_x)
            End If
        End If
    End Function

End Class
