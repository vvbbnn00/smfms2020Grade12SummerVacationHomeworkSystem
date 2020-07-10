Imports System.Windows.Forms

Public Class FrmDonate

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FrmDonate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Opacity = My.Settings.Opacity / 100
    End Sub
End Class
