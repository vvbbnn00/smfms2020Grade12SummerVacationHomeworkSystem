
Imports System.ComponentModel

Public Class FrmMusic
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

    End Sub

    Private Sub FrmMusic_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs)

    End Sub
End Class