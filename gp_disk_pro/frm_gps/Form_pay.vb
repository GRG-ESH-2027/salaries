Imports System.IO
Imports System.Data.OleDb
'Imports System.Net.Mime.MediaTypeNames
Imports Microsoft.Office.Interop


Public Class Form_pay

    Public ds As New DataSet
    Public no_k As Integer

    Private Sub BtnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadData.Click
        BtnLoadData.Text = "Please Wait..."
        BtnLoadData.ForeColor = Color.Red
        BtnLoadData.Enabled = False
        System.Windows.Forms.Application.DoEvents()
        Label3.Text = "كشوف اعدادى"

        Dim da As New OleDbDataAdapter
        Dim dt_pay As New DataTable
        dt_pay.Clear()
        '===0==========================1==========================2====================3=============================4=========================5==================6=====================7===== ===============  ===8===================9==================10=
        da = New OleDbDataAdapter("SELECT Table_mkf_add.id_no, Table_mkf_add.op_name_pay, Table_mkf_add.op_al_kta, Table_mkf_add.Name_school, Table_mkf_add.op_no_emb, Table_mkf_add.Name_Emp, Table_mkf_add.Saffy, Table_mkf_add.Entklat, Table_mkf_add.Badl_safer, Table_mkf_add.no_kshf ,user_table.user_ful_name FROM user_table INNER JOIN Table_mkf_add ON user_table.id_user = Table_mkf_add.id_user ORDER BY no_kshf", con)
        da.Fill(dt_pay)
        'Dim Cmd As New OleDbDataAdapter("select op_id_no,op_name_pay,op_al_kta,Name_school,op_no_emb , Name_Emp,Saffy,Entklat,Badl_safer,no_kshf from Table_mkf_add ", con)
    

        DataGridView1.Rows.Clear()

        For i As Integer = 0 To dt_pay.Rows.Count - 1

            With DataGridView1.Rows
                '========================0===================================1=================================2==================================3================================4====================================5====================================6================================7==================================8=================================9=============
                .Add(dt_pay.Rows(i).Item(0).ToString(), dt_pay.Rows(i).Item(1).ToString(), dt_pay.Rows(i).Item(2).ToString(), dt_pay.Rows(i).Item(3).ToString(), dt_pay.Rows(i).Item(4).ToString(), dt_pay.Rows(i).Item(5).ToString(), dt_pay.Rows(i).Item(6).ToString(), dt_pay.Rows(i).Item(7).ToString(), dt_pay.Rows(i).Item(8).ToString(), dt_pay.Rows(i).Item(9).ToString(), dt_pay.Rows(i).Item(10).ToString())
            End With
            System.Windows.Forms.Application.DoEvents()
        Next

        BtnLoadData.Text = "تحميل كل الكشوف اعدادى"
        BtnLoadData.Enabled = True
        btn_export.Enabled = True
        lbl_count.Text = (dt_pay.Rows.Count - 1).ToString()



    End Sub



    Private Sub Form_pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With DataGridView1
            .Columns.Clear()
            .Columns.Add("id_no", "رقم القومى")
            .Columns.Add("name_pay", "نوع المدفوعة")
            .Columns.Add("al_kta", "القطاع")
            .Columns.Add("school", "المدرسة")
            .Columns.Add("no_emb", "رقم الموظف")
            .Columns.Add("name_emp", "اسم الموظف")
            .Columns.Add("Saffy", "المرتب")
            .Columns.Add("Entklat", "انتقالات")
            .Columns.Add("Badl_safer", "بدل سفر")
            .Columns.Add("no_kshf", "رقم الكشف")
            .Columns.Add("user_ful_name", "اسم المستخدم")

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .ScrollBars = ScrollBars.Both
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub btn_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        btn_export.Enabled = False
        btn_export.Text = "Wait"
        SaveGridToExcel_all_pay(DataGridView1)
        btn_export.Text = "تصدير البيانات الى اكسيل"

    End Sub

    Private Sub btn_load_thnoy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_thnoy.Click
        btn_load_thnoy.Text = "Please Wait..."
        btn_load_thnoy.ForeColor = Color.Red
        btn_load_thnoy.Enabled = False
        System.Windows.Forms.Application.DoEvents()
        Label3.Text = "كشـوف ثـانـوى"
        Dim da As New OleDbDataAdapter
        Dim dt_pay As New DataTable
        DataGridView1.Rows.Clear()

        dt_pay.Clear()
        '===0==========================1==========================2====================3=============================4=========================5==================6=====================7===== ===============  ===8===================9==================10=
        'da = New OleDbDataAdapter("SELECT Table_mkf_add.op_id_no, Table_mkf_add.op_name_pay, Table_mkf_add.op_al_kta, Table_mkf_add.Name_school, Table_mkf_add.op_no_emb, Table_mkf_add.Name_Emp, Table_mkf_add.Saffy, Table_mkf_add.Entklat, Table_mkf_add.Badl_safer, Table_mkf_add.no_kshf ,user_table.user_ful_name FROM user_table INNER JOIN Table_mkf_add ON user_table.id_user = Table_mkf_add.id_user ORDER BY no_kshf,Name_Emp", con)
        da = New OleDbDataAdapter("SELECT Table_mkf_add.id_no, Table_mkf_add.op_name_pay, Table_mkf_add.op_al_kta, Table_mkf_add.Name_school, Table_mkf_add.op_no_emb, Table_mkf_add.Name_Emp, Table_mkf_add.Saffy, Table_mkf_add.Entklat, Table_mkf_add.Badl_safer, Table_mkf_add.no_kshf ,user_table.user_ful_name FROM user_table INNER JOIN Table_mkf_add ON user_table.id_user = Table_mkf_add.id_user", con)

        da.Fill(dt_pay)
        'Dim Cmd As New OleDbDataAdapter("select op_id_no,op_name_pay,op_al_kta,Name_school,op_no_emb , Name_Emp,Saffy,Entklat,Badl_safer,no_kshf from Table_mkf_add ", con)




        For i As Integer = 0 To dt_pay.Rows.Count - 1
            With DataGridView1.Rows
                '========================0===================================1=================================2==================================3================================4====================================5====================================6================================7==================================8=================================9=============
                .Add(dt_pay.Rows(i).Item(0).ToString(), dt_pay.Rows(i).Item(1).ToString(), dt_pay.Rows(i).Item(2).ToString(), dt_pay.Rows(i).Item(3).ToString(), dt_pay.Rows(i).Item(4).ToString(), dt_pay.Rows(i).Item(5).ToString(), dt_pay.Rows(i).Item(6).ToString(), dt_pay.Rows(i).Item(7).ToString(), dt_pay.Rows(i).Item(8).ToString(), dt_pay.Rows(i).Item(9).ToString(), dt_pay.Rows(i).Item(10).ToString())
            End With
            System.Windows.Forms.Application.DoEvents()
        Next

        btn_load_thnoy.Text = "تحميل كل الكشوف ثانوى"
        btn_load_thnoy.Enabled = True
        btn_export.Enabled = True
        lbl_count.Text = (dt_pay.Rows.Count - 1).ToString()




    End Sub
End Class