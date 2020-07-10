
Public Class FrmTaskEdit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "任务文件|*.json"
        Dim a = SaveFileDialog1.ShowDialog()
        If a = DialogResult.Cancel Then Exit Sub
        TextBox1.Text = SaveFileDialog1.FileName
        IO.File.WriteAllText(TextBox1.Text, txtContent.Text)
        MsgBox(txtContent.Text)
    End Sub
    Function Wuli()
        Dim Sampletask As New Tsklist
        Sampletask.AddSubject("语文")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("作业名称", False, 0, 0, "作业详情")
        Sampletask.Author = "不做评论"
        Return (Sampletask.Convert2Json)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            txtContent.Text = Wuli()
        Catch ex As Exception
            txtDebug.Text += vbCrLf + ex.Message
        End Try
    End Sub
End Class