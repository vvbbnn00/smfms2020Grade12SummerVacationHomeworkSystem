Imports System.Windows.Forms

Public Class FrmChooseSubject
    Public choice As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.choice = ComboBox1.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        End
    End Sub

End Class
