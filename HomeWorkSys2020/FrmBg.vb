Public Class FrmBg
    Private ReadOnly Log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
    Public Declare Function FlashWindow Lib "user32" (ByVal hwnd As Long, ByVal bInvert As Long) As Long
    Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long, ByVal dwNewLong As Long) As Long
    Private Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Long, ByVal nIndex As Long) As Long
    'Private Const WS_EX_NOACTIVATE = &H8000000
    Private Const GWL_EXSTYLE = -20
    Private Sub FrmBg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Handle = Me.Handle
        Dim exstyle As Int32 = GetWindowLong(Handle, GWL_EXSTYLE)
        'SetWindowLong(Handle, GWL_EXSTYLE, exstyle Or WS_EX_NOACTIVATE)
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

    Private Sub FrmBg_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        FrmMain.Hide()
        FrmMain.Show()
        If FrmMusic.Visible = True Then
            FrmMusic.Hide()
            FrmMusic.Show()
        End If
    End Sub

    Private Sub FrmBg_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        'FrmMain.TopMost = My.Settings.TopMost
        'FrmMusic.TopMost = My.Settings.TopMost
    End Sub
End Class