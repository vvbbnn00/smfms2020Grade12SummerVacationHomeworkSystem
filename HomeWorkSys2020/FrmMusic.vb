Imports System.ComponentModel

Public Class FrmMusic
    Dim x As Single = 0
    Dim y As Single = 0 '窗体缩放
    Function GenerateURL(Optional Songlist As String = "113455148") As String
        Return ("http://music.163.com/outchain/player?type=0&id=" & Songlist & "&auto=0&height=430")
        'Return ("https://music.163.com/style/swf/widget.swf?sid=" & Songlist & "&type=0&auto=0&width=310&height=430")
    End Function
    Private Sub FrmMusic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://s.cpman.cn/")
        Me.Opacity = My.Settings.Opacity / 100
        Me.TopMost = My.Settings.TopMost
        Me.Top = 10
        Me.Left = 10
        timer_RunOnce.Enabled = True

    End Sub
    Private Sub FrmMusic_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
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
        Me.Height = 480 / 1080 * Screen.PrimaryScreen.Bounds.Height
        Me.Width = 420 / 1920 * Screen.PrimaryScreen.Bounds.Width
        FrmMain.Hide()
        FrmMain.Show()
        timer_RunOnce.Enabled = False
    End Sub

    Private Sub FrmMusic_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        'Me.TopMost = My.Settings.TopMost
        'FrmMain.TopMost = My.Settings.TopMost
    End Sub
End Class