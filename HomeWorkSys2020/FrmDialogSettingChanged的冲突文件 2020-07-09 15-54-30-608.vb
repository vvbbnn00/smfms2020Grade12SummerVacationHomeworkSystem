Imports System.Windows.Forms

Public Class FrmDialogSettingChanged
    Public NotShow As Boolean
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        NotShow = chkbox_notmentioned.Checked
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        NotShow = chkbox_notmentioned.Checked
        Me.Close()
    End Sub

End Class
