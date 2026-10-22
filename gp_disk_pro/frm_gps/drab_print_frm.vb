Public Class drab_print_frm

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DataGridView1.AutoGenerateColumns = False
        DataGridView2.AutoGenerateColumns = False
        DataGridView3.AutoGenerateColumns = False
        DataGridView4.AutoGenerateColumns = False
        DataGridView5.AutoGenerateColumns = False
        DataGridView6.AutoGenerateColumns = False
        Dim date_new As Date
        Dim monthh As Integer
        Dim yearss As Integer
        date_new = date_drab.Value
        monthh = date_new.Month
        yearss = date_new.Year
        Dim date_string As String
        date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
        date_new = FormatDateTime(date_string)
        Select_kasb(DataGridView1, date_new)
        Select_damgha_total(DataGridView2, date_new)
        Select_arbah_t_total(DataGridView3, date_new)
        Select_nwaya_total(DataGridView4, date_new)
        Select_tanmea_total(DataGridView5, date_new)
        Select_kema_mdfa_total(DataGridView6, date_new)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Button4.Text = "Wait"
        SaveGridToExcel_all_tfrgh(DataGridView1)
        Button4.Text = "تصدير البيانات الى اكسيل"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Wait"
        SaveGridToExcel_all_tfrgh(DataGridView2)
        Button1.Text = "تصدير البيانات الى اكسيل"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button2.Text = "Wait"
        SaveGridToExcel_all_tfrgh(DataGridView3)
        Button2.Text = "تصدير البيانات الى اكسيل"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Button3.Text = "Wait"
        SaveGridToExcel_all_tfrgh(DataGridView4)
        Button3.Text = "تصدير البيانات الى اكسيل"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False
        Button5.Text = "Wait"
        SaveGridToExcel_all_tfrgh(DataGridView5)
        Button5.Text = "تصدير البيانات الى اكسيل"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Enabled = False
        Button6.Text = "Wait"
        SaveGridToExcel_all_tfrgh(DataGridView6)
        Button6.Text = "تصدير البيانات الى اكسيل"
    End Sub

    Private Sub drab_print_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class