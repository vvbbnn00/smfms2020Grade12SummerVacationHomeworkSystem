Public Class FrmTaskEdit
    Private Sampletask As New Tsklist
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.Filter = "任务文件|*.json"
        Dim a = SaveFileDialog1.ShowDialog()
        If a = DialogResult.Cancel Then Exit Sub
        TextBox1.Text = SaveFileDialog1.FileName
        IO.File.WriteAllText(TextBox1.Text, txtContent.Text)
        MsgBox("Success." + vbCrLf + txtContent.Text)
    End Sub
    Sub Wuli() Handles btn_wl.Click
        '物理
        txtDebug.Text += vbCrLf + "加入了物理"
        Sampletask.AddSubject("物理")
        Sampletask.Subjects(Sampletask.SubIndex("物理")).AddTask("2019零距离突破课时作业", False, 45, 0, "2019零距离突破知识点梳理+课时作业，共45课", "")
    End Sub
    Sub Huaxue() Handles btn_hx.Click
        '化学
        txtDebug.Text += vbCrLf + "加入了化学"
        Sampletask.AddSubject("化学")
        Sampletask.Subjects(Sampletask.SubIndex("化学")).AddTask("2019零距离突破课时作业", False, 35, 0, "完成高中化学基础篇整套卷子及配套大卷子。", "")
        Sampletask.Subjects(Sampletask.SubIndex("化学")).AddTask("参考考纲考点整理知识点", False, 1, 0, "参考考纲考点整理知识点。", "")
        Sampletask.Subjects(Sampletask.SubIndex("化学")).AddTask("有机推断一周3题", False, 18, 0, "有机推断一周3题（以6周计）。", "")
    End Sub
    Sub Zhengzhi() Handles btn_zz.Click
        '政治
        txtDebug.Text += vbCrLf + "加入了政治"
        Sampletask.AddSubject("政治")
        Sampletask.Subjects(Sampletask.SubIndex("政治")).AddTask("《等级考零距离突破》", False, 1, 0, "购买《等级考零距离突破》政治知识梳理篇，作业进度见群公告。", "")
        Sampletask.Subjects(Sampletask.SubIndex("政治")).AddTask("对应考点举例", False, 1, 0, "关注教材，关注时政，对应考点举例。准备一本《思维导图本》大小的本子，用于此项作业，进度见群公告。", "")
        Sampletask.Subjects(Sampletask.SubIndex("政治")).AddTask("写政治学科观后感", False, 6, 0, "每周观看一期《这就是中国》指定节目，写政治学科观后感。（以6周计）", "")
    End Sub
    Sub Lishi() Handles btn_ls.Click
        '历史
        txtDebug.Text += vbCrLf + "加入了历史"
        Sampletask.AddSubject("历史")
        Sampletask.Subjects(Sampletask.SubIndex("历史")).AddTask("整理2~6分册的知识点", False, 5, 0, "①按照学科基本要求整理2~6分册的相关知识点或绘制思维导图;
②老师定期检查作业完成情况，并进行相应练习反馈.作业检查时间暂时安排如下:
7月24日第2~3分册; 7月31日第4分册; 8月14日第5分册; 8月28日第6分册。", "")
    End Sub
    Sub Yushuying() Handles btn_ysy.Click
        txtDebug.Text += vbCrLf + "加入了语数英"
        Sampletask.AddSubject("语文")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("背诵规定篇目", True, 0, 0, "背诵、默写1-4册 规定篇目。
要求每天一首，反复循坏。", "")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("2019一模卷", False, 15, 0, "下发的2019一模卷（绿色的那本）。每天二篇现代文阅读，50分钟", "")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("古诗文专刊", False, 60, 0, "结合古诗文阅读大赛资料，基础30+提高30", "")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("《步步高》", False, 30, 0, "完成《步步高》【下篇1-30】", "")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("熟读经典课内课文", True, 0, 0, "熟读经典课内课文", "")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("2019一模卷文言文二", False, 15, 0, "2019一模卷文言文二（绿色的那本）", "")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("作文-1", False, 4, 0, "完成规定作文，共四篇，详见附件", "http://vvbbnn00.cn/Homewksys/Download/%E8%AF%AD%E6%96%87_%E6%9A%91%E6%9C%9F%E4%BD%9C%E6%96%87%E9%A2%98.docx")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("作文-2", True, 4, 0, "认真阅读下发的2019各区模拟卷样文", "")
        Sampletask.Subjects(Sampletask.SubIndex("语文")).AddTask("作文-3", False, 6, 0, "读课外读物。推荐相关书目。做好点评。每周一次。", "")
        Sampletask.AddSubject("数学")
        Sampletask.Subjects(Sampletask.SubIndex("数学")).AddTask("上海新高考数学", False, 59, 0, "上海新高考数学第1讲至第59讲。
要求: 
(1) 先看知识梳理，再完成巩固训练，并按答案核对和订正;
(2)老师每周定期作业和答疑。", "")
        Sampletask.AddSubject("英语")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("反思与总结", True, 0, 0, "反思与总结
1.汇总高二阶段的各次重要考卷(月考、期中、期末考),做好错题整理与好词、好句的摘抄。
2. 汇总高一、高二两年共四学期的笔记，主要是重要语法专题和作文讲义。学有余力的同学可以绘制重要语法点的思维导图，帮助理解与记忆。", "")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("《步步高》", False, 30, 0, "完成2019年二模试卷上的听力练习，并自行核对答案。音频自行从网上下载。要求至少听两遍，随听随记，提高记笔记的效率和正确率
听力下载地址见附件。", "https://link.gimhoy.com/sharepoint/aHR0cHM6Ly9kcXJ6cy1teS5zaGFyZXBvaW50LmNvbS86dTovZy9wZXJzb25hbC92dmJibm4wMF8zNjVwcF9tZS9FUkpfMkRFUERmdEZ2M3B0am9SeUdSY0JvTWdYQ1JvWU4wR2VKdkM0cXhCRkF3P2U9ZjNkVHk5.zip")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("朗读", False, 3, 0, "1)正确朗读高考词汇 手册中的所有单词;
2) SSP 报纸暑期刊篇目朗读;
3) 2019 年二模试卷阅读文章朗读。", "")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("SSP暑期合刊阅读部分+试卷", False, 56, 0, "SSP暑期合刊[可用补课材料代替] :
阅读题做在报纸上，要求划出解题线索，summay不做.完成后登陆网站自行核对答案(www.cheeseABC.com)", "")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("SSP暑期合刊翻译部分", False, 70, 0, "中译英专项做在本子上(配中文)，共70句", "")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("SSP暑期合刊生词整理部分", False, 1, 0, "准备大开面笔记本，摘抄生词、好词", "")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("2019年二模试卷", False, 15, 0, "2019年二模试卷
要求:综合卷在不借助任何词汇工具的前提下，限时2个小时完成（作文时间至少需要15-20分钟）
划出解题线索，所有题目完成后摘抄生词、好词。并自行核对答案。每周2-3套。", "")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("(自选)阅读外刊", True, 0, 0, " (自选)学有余力的同学，建议每天精读一篇外刊文章，并完成摘抄。
推荐网站: https://www.rd.com/ (易)[!可能需要翻墙] https://www.ehow.com/ (易)
https://www.wikihow.com/Main-Page (易) https://www.ft.com/ (难)
https://www.psychologicalscience.org/ (难)
https://www.thetimes.co.uk/ (难)", "")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("2019年二模试卷上指定作文", False, 15, 0, "准备一本作文本，完成2019年二模试卷上的指定作文:可以练习先列提纲,后写第一稿，再润色。", "")
        Sampletask.Subjects(Sampletask.SubIndex("英语")).AddTask("完成剩余默写", False, 40, 0, "完成词汇默写本后半部分余下的默写，并自行批改。", "")
        Sampletask.Author = "不做评论"
    End Sub
    Function Generate()
        Return (Sampletask.Convert2Json)
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            txtContent.Text = Generate()
        Catch ex As Exception
            txtDebug.Text += vbCrLf + ex.Message
        End Try
    End Sub

    Private Sub Lishi(sender As Object, e As EventArgs) Handles btn_ls.Click

    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        txtDebug.Text += vbCrLf + "清空了"
        txtContent.Text = ""
        Sampletask = New Tsklist
    End Sub
End Class