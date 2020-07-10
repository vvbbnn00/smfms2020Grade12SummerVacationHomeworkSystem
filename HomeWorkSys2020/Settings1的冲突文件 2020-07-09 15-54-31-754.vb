
Imports System.ComponentModel
Imports System.Configuration

Namespace My

    '通过此类可以处理设置类的特定事件: 
    ' 在更改某个设置的值之前将引发 SettingChanging 事件。
    ' 在更改某个设置的值之后将引发 PropertyChanged 事件。
    ' 在加载设置值之后将引发 SettingsLoaded 事件。
    ' 在保存设置值之前将引发 SettingsSaving 事件。
    Partial Friend NotInheritable Class MySettings
        Private ReadOnly Log As log4net.ILog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType)
        Private Sub MySettings_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles Me.PropertyChanged
            If FrmDialogSettingChanged.NotShow Then Exit Sub
            FrmDialogSettingChanged.chkbox_notmentioned.Checked = True
            FrmDialogSettingChanged.ShowDialog()
            My.Settings.Save()
        End Sub

        Private Sub MySettings_SettingChanging(sender As Object, e As SettingChangingEventArgs) Handles Me.SettingChanging
            If e.SettingKey.ToString = e.NewValue.ToString Then e.Cancel = True
            DbP("设置修改:" + e.SettingName.ToString + "->" + e.NewValue.ToString)
            Log.Info("设置修改:" + e.SettingName.ToString + "->" + e.NewValue.ToString)
        End Sub

        Private Sub MySettings_SettingsSaving(sender As Object, e As CancelEventArgs) Handles Me.SettingsSaving
        End Sub
    End Class
End Namespace
