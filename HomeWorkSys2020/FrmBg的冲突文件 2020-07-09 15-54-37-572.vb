Public Class FrmBg
    Private ReadOnly Log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    Private Sub FrmBg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Application.DoEvents()
        Me.WindowState = FormWindowState.Maximized
        If My.Settings.BackType = "Img" Then
            Try
                Me.BackgroundImage = Image.FromFile(My.Settings.BackImgPath)
            Catch ex As Exception
                MsgBox("背景配置错误！已自动还原。", vbExclamation, "错误")
                Log.Error(ex.Message)
                My.Settings.BackType = "Default"
                My.Settings.Save()
            End Try
        End If
        If My.Settings.BackType = "Pure" Then
            Try
                Me.BackColor = My.Settings.BackColor
                Me.BackgroundImage = Nothing
            Catch ex As Exception
                MsgBox("背景配置错误！已自动还原。", vbExclamation, "错误")
                Log.Error(ex.Message)
                My.Settings.BackType = "Default"
                My.Settings.Save()
                FrmDialogSettingChanged.chkbox_notmentioned.Visible = False
                FrmDialogSettingChanged.ShowDialog()
                FrmDialogSettingChanged.chkbox_notmentioned.Visible = True
            End Try
        End If
    End Sub
End Class