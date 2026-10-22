Imports System.Data.OleDb
'Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports excel = Microsoft.Office.Interop.Excel


Public Class Form_print_crystal
    Public no_k As Integer
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try

        


        Dim daa As New OleDbDataAdapter
            'Dim reprt As New Report2
            'Dim reprt4 As New CrystalReport4
        Dim dv As New DataView
        Dim ds As New DataSet1
       
        Dim no_kshf As Integer
        no_kshf = NumericUpDown1.Value
        Dim id_mkf As Integer
        id_mkf = NumericUpDown2.Value

        If Label3.Text = "صفحة طباعة اعداديه تقارير" Then
            daa = New OleDbDataAdapter("SELECT No_55, Salary_ass, Dayes, Mkf, total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta, Name_school, Name_Emp , Saffy, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, op_id_no, op_name_pay, op_al_kta, op_no_emb,Name_Mkf,Item_Mkf,Years,term FROM Table_mkf_add  INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf WHERE no_kshf = " & no_kshf & " and Table_Mkf.Id_Mkf = " & id_mkf & " ", con)
            daa.Fill(ds, "table_add_mkf")
            dv = New DataView(ds.Tables("table_add_mkf"))
                'reprt.SetDataSource(dv)


                'reprt.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
                'reprt.SetParameterValue(1, TextBox2.Text)
                'frm_viewer.CrystalReportViewer1.ReportSource = reprt
            frm_viewer.Show()
        Else
            daa = New OleDbDataAdapter("SELECT No_55, Salary_ass, Dayes, Mkf, total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta, Name_school, Name_Emp , Saffy_after_antkal, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, op_id_no, op_name_pay, op_al_kta, op_no_emb,Name_Mkf,Item_Mkf,Years,term FROM Table_mkf_add  INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf WHERE no_kshf = " & no_kshf & " and Table_Mkf.Id_Mkf = " & id_mkf & " ", con)
            daa.Fill(ds, "table_add_mkf")
            dv = New DataView(ds.Tables("table_add_mkf"))
                'reprt4.SetDataSource(dv)


                'reprt4.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
                'reprt4.SetParameterValue(1, TextBox2.Text)
                'frm_viewer.CrystalReportViewer1.ReportSource = reprt4
            frm_viewer.Show()
        End If
        Catch ex As Exception

        End Try
    End Sub



    Public dt_Table_no_kshf_id_mkf As New DataTable
    Public Sub SelectAll_Table_mkf_ad(ByVal no_kshf As Integer, ByVal Id_Mkf As Integer)
        dt_Table_no_kshf_id_mkf.Clear()
        Dim cmd As New OleDbCommand("SELECT No_55, Salary_ass, Dayes, Mkf, total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta, Name_school, Name_Emp , Saffy, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, op_id_no, op_name_pay, op_al_kta, op_no_emb,Name_Mkf,Item_Mkf,Years,term FROM Table_mkf_add INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf WHERE no_kshf = @no_kshf and Table_Mkf.Id_Mkf = @Id_Mkf", con)

        With cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf
            .Parameters.AddWithValue("@Id_Mkf", OleDbType.Integer).Value = Id_Mkf
            dt_Table_no_kshf_id_mkf.Load(cmd.ExecuteReader)

        End With
        con.Close()
        cmd = Nothing



    End Sub

    Public dt_Table_id_mkf As New DataTable
    Public Sub SelectAll_Table_id_mkk(ByVal no_kshf As Integer)
        dt_Table_id_mkf.Clear()
        Dim cmd As New OleDbCommand("SELECT  no_kshf,Table_Mkf.Id_Mkf FROM Table_mkf_add INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf WHERE no_kshf = @no_kshf ", con)

        With cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf

            dt_Table_id_mkf.Load(cmd.ExecuteReader)

        End With
        con.Close()
        cmd = Nothing



    End Sub


    Private Sub Form_print_crystal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'no_k = Max_no_kshf()

        'SelectSome_Table_mkf_add_indirect(no_kshf)



        'no_kshf.SelectedValue = no_k

        'NumericUpDown1.Value = no_k

        'SelectAll_Table_id_mkk(no_k)
        'DataGridView2.DataSource = dt_Table_id_mkf
        'no_k = NumericUpDown1.Value

        'NumericUpDown2.Value = DataGridView2.Rows(0).Cells("Id_Mkf").Value
        ''جعل كومبوبكس على اول اختيار
        'Item_Mkf.SelectedIndex = 0

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SelectAll_Table_mkf_ad(NumericUpDown1.Value, NumericUpDown2.Value)
        DataGridView1.DataSource = dt_Table_no_kshf_id_mkf

        DataGridViewHeaderText_no_kshf(DataGridView1)
        TextBox1.Text = DataGridView1.Rows(0).Cells("Name_Mkf").Value.ToString()
        TextBox2.Text = DataGridView1.Rows(0).Cells("Item_Mkf").Value.ToString()
        TextBox3.Text = DataGridView1.Rows(0).Cells("Years").Value.ToString()
        TextBox4.Text = DataGridView1.Rows(0).Cells("term").Value.ToString()
        Button7.Visible = True
        Button2.Visible = True
        Btn_tot_report.Enabled = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_kshf.SelectedIndexChanged
        Try
            no_k = no_kshf.SelectedValue
            NumericUpDown1.Value = no_k



            SelectAll_Table_id_mkk(no_k)
            DataGridView2.DataSource = dt_Table_id_mkf

            no_k = NumericUpDown1.Value

            NumericUpDown2.Value = DataGridView2.Rows(0).Cells("Id_Mkf").Value

            Button7.Visible = False

        Catch ex As Exception

        End Try

    End Sub

    Public Sub DataGridViewHeaderText_no_kshf(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Id").HeaderText = "Id"
                .Columns("No_55").HeaderText = "55 ع . ح"
                .Columns("no_kshf").HeaderText = "رقم الكشف"

                .Columns("Salary_ass").HeaderText = "المرتب الاساسى"
                .Columns("Dayes").HeaderText = "عدد الايام"
                .Columns("Mkf").HeaderText = "المكافاة"
                .Columns("Badl_safer").HeaderText = "بدل سفر"
                .Columns("Entklat").HeaderText = "انتقالات"
                .Columns("total").HeaderText = "جملة"
                .Columns("Mashat").HeaderText = "معاشات"
                .Columns("Mashat8").HeaderText = "مهن 2%"
                .Columns("Darabb").HeaderText = "ضرائب"
                .Columns("nkaba").HeaderText = "نقابه"
                .Columns("Mhann").HeaderText = "تامين صحى 1%"

                .Columns("Mastshfa").HeaderText = "مستشفى"
                .Columns("Damghh").HeaderText = "دمغه"
                .Columns("Earaadta").HeaderText = "ايرادات"
                .Columns("box20").HeaderText = "صندوق %20"
                .Columns("Total_Mostkta").HeaderText = "جملة المستقطع"
                .Columns("Name_school").HeaderText = "المدرسة"
                .Columns("Name_Emp").HeaderText = "الاسم"
                .Columns("Saffy").HeaderText = "الصافى"
                '.Columns("Id_Mkf").HeaderText = "Id_Mkf"
                '.Columns("date1").HeaderText = "التاريخ"
                .Columns("op_id_no").HeaderText = "الرقم القومى"
                .Columns("op_name_pay").HeaderText = "نوع المدفوعه"
                .Columns("op_al_kta").HeaderText = "القطاع"
                '.Columns("Name_school").HeaderText = "المدرسة"
                .Columns("op_no_emb").HeaderText = "رقم الموظف بجهته الأصلية"
                '.Columns("Name_Emp").HeaderText = "الاسم"
                '.Columns("name_pay").Visible = False
                '.Columns("al_kta").Visible = False
                '.Columns("no_emb").Visible = False
                '.Columns("hh").Visible = False

            End With
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim daa As New OleDbDataAdapter
        'Dim reprt As New CrystalReport1
        Dim dv As New DataView
        Dim ds As New DataSet1
        Dim no_kshf As Integer
        no_kshf = NumericUpDown1.Value
        Dim id_mkf As Integer
        id_mkf = NumericUpDown2.Value

        daa = New OleDbDataAdapter("SELECT No_55, Salary_ass, Dayes, Mkf, total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta, Name_school, Name_Emp , Saffy, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, op_id_no, op_name_pay, op_al_kta, op_no_emb,Name_Mkf,Item_Mkf,Years,term FROM Table_mkf_add  INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf WHERE no_kshf = " & no_kshf & " and Table_Mkf.Id_Mkf = " & id_mkf & " ", con)
        daa.Fill(ds, "table_add_mkf")
        dv = New DataView(ds.Tables("table_add_mkf"))
        'reprt.SetDataSource(dv)

        'frm_viewer.CrystalReportViewer1.ReportSource = reprt
        frm_viewer.Show()
    End Sub

    
    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_tot_report.Click
        Try

            If num_tot_frist.Value <= 0 Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub

            End If
            If num_tot_end.Value <= 0 Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub
            End If
            If num_tot_end.Value < num_tot_frist.Value Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub
            End If

            Dim daa As New OleDbDataAdapter
            'Dim reprt As New Report2
            'Dim reprt4 As New CrystalReport_total_sanwy
            Dim dv As New DataView
            Dim ds As New DataSet1

            
            Dim no_kshf As Integer
            no_kshf = NumericUpDown1.Value
            Dim id_mkf As Integer
            id_mkf = NumericUpDown2.Value

            If Label3.Text = "صفحة طباعة اعداديه تقارير" Then
                daa = New OleDbDataAdapter("SELECT Mkf,total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta , Saffy_after_antkal, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, op_id_no, op_name_pay, op_al_kta, op_no_emb,Name_Mkf,Item_Mkf,Years,term FROM Table_mkf_add  INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf  WHERE no_kshf >=" & num_tot_frist.Value & " And no_kshf <=" & num_tot_end.Value & "", con)
                daa.Fill(ds, "table_add_mkf")
                dv = New DataView(ds.Tables("table_add_mkf"))
                'reprt.SetDataSource(dv)


                'reprt.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
                'reprt.SetParameterValue(1, TextBox2.Text)
                'frm_viewer.CrystalReportViewer1.ReportSource = reprt
                frm_viewer.Show()
            Else
                daa = New OleDbDataAdapter("SELECT Mkf,total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta , Saffy_after_antkal, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, op_id_no, op_name_pay, op_al_kta, op_no_emb,Name_Mkf,Item_Mkf,Years,term FROM Table_mkf_add  INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf  WHERE no_kshf >=" & num_tot_frist.Value & " And no_kshf <=" & num_tot_end.Value & "", con)

                daa.Fill(ds, "table_add_mkf")
                dv = New DataView(ds.Tables("table_add_mkf"))
                'reprt4.SetDataSource(dv)


                'reprt4.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
                'reprt4.SetParameterValue(1, TextBox2.Text)
                'frm_viewer.CrystalReportViewer1.ReportSource = reprt4
                frm_viewer.Show()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        close_all()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_to_excell_total.Click
        'Dim fr As New frm_viewer()
        'fr.Show()
        Try
            NumericUpDown3.Value = (num_tot_end.Value - num_tot_frist.Value)
            If NumericUpDown3.Value > 19 Then
                num_tot_end.Value = num_tot_frist.Value + 19

            End If
            '===================================================
            If num_tot_frist.Value <= 0 Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub

            End If
            If num_tot_end.Value <= 0 Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub
            End If
            If num_tot_end.Value < num_tot_frist.Value Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub
            End If

            Dim daa As New OleDbDataAdapter
            'Dim reprt As New Report2
            'Dim reprt4 As New CrystalReport_total_sanwy
            Dim dv As New DataView
            Dim ds As New DataSet1




            Dim id_mkf As Integer
            id_mkf = NumericUpDown2.Value

            'If Label3.Text = "صفحة طباعة اعداديه تقارير" Then
            'reprt.SetDataSource(dv)


            'reprt.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
            'reprt.SetParameterValue(1, TextBox2.Text)
            'frm_viewer.CrystalReportViewer1.ReportSource = reprt
            'frm_viewer.Show()
            '==================================================================================



            'no_kkk = no_kshf.SelectedValue
            Dim Cmd As New OleDbDataAdapter("SELECT Table_mkf_add.no_kshf , Sum(Table_mkf_add.Mkf), Sum(Table_mkf_add.Dayes) , Sum(Table_mkf_add.Darabb), Sum(Table_mkf_add.Mashat) , Sum(Table_mkf_add.nkaba), Sum(Table_mkf_add.Mashat8) , Sum(Table_mkf_add.Mhann) , Sum(Table_mkf_add.Mastshfa), Sum(Table_mkf_add.Damghh) , Sum(Table_mkf_add.Earaadta) , Sum(Table_mkf_add.box20) , Sum(Table_mkf_add.Total_Mostkta) , Sum(Table_mkf_add.Saffy) , Sum(Table_mkf_add.Badl_safer) , Sum(Table_mkf_add.Entklat) FROM Table_mkf_add WHERE no_kshf >= " & num_tot_frist.Value & "  And no_kshf <=" & num_tot_end.Value & " GROUP BY Table_mkf_add.no_kshf", con)
            'Dim Cmd As New OleDbDataAdapter("SELECT Sum(Table_mkf_add.Dayes),Sum(Table_mkf_add.Mkf) , Sum(Table_mkf_add.Badl_safer) , Sum(Table_mkf_add.Entklat) , Sum(Table_mkf_add.Mashat) AS SumمنMashat, Sum(Table_mkf_add.Mashat8) , Sum(Table_mkf_add.Darabb) , Sum(Table_mkf_add.nkaba) , Sum(Table_mkf_add.Mhann) , Sum(Table_mkf_add.Damghh) , Sum(Table_mkf_add.Earaadta) , Sum(Table_mkf_add.box20) , Sum(Table_mkf_add.Total_Mostkta) , Sum(Table_mkf_add.Saffy)  FROM Table_mkf_add WHERE no_kshf >=" & num_tot_frist.Value & " And no_kshf <=" & num_tot_end.Value & " GROUP BY Table_mkf_add.no_ksh", con)

            add_file()
            Label3.Visible = True
            Label2.Visible = True
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            'Dim inputFile As String = ("d:\page_tfrgh.xls")
            Dim inputFile As String = ((Application.StartupPath) & "\tfrgh_total.xls")

            'xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkBook = xlApp.Workbooks.Open(inputFile)

            xlWorkSheet = xlWorkBook.ActiveSheet

            xlWorkSheet.DisplayRightToLeft = True
            xlWorkSheet.Cells(3, 9) = TextBox1.Text
            'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
            xlWorkSheet.Cells(3, 12) = TextBox4.Text
            xlWorkSheet.Cells(3, 18) = TextBox3.Text
            xlWorkSheet.Cells(2, 17) = Item_Mkf.Text
            'xlWorkSheet.Cells(2, 18) = no_kashf2.Value

            ProgressBar1.Maximum = DataGridView1.RowCount

            Dim no_kkk As Integer = 0

            '=====================
            Dim dst As New DataSet
            Cmd.Fill(dst)

            For i = 0 To dst.Tables(0).Rows.Count - 1


                'ProgressBar1=====================
                'ProgressBar1.Value = i
                'Dim total_s As Double = 0
                'total_s = (i * 1) / DataGridView1.RowCount
                'total_s = total_s * 100
                'total_s = Math.Round(total_s, 0)

                'Label3.Text = "%".ToString() + total_s.ToString()
                'Label2.Text = "جارى التحميل 00000"
                'Label2.Visible = False
                'Label2.Visible = True

                '=====================================
                For j = 0 To dst.Tables(0).Columns.Count - 1
                    'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                    'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 5, j + 2) = dst.Tables(0).Rows(i).Item(j)
                    'Next
                Next
            Next

            '========================================================
            Dim da1 As New OleDbDataAdapter("select * from table_name_col_total_tfrgh ", con)



            Dim ds1 As New DataSet

            ds1.Tables.Add("st")
            da1.Fill(ds1, "st")

            DataGridView2.DataSource = ds1.Tables(0)

            'da2.Fill(ds2)
            'DataGridView1.DataSource = ds2.Tables(0)

            For i = 0 To ds1.Tables(0).Rows.Count - 1



                For m As Integer = 0 To ds1.Tables(0).Columns.Count - 1


                    xlWorkSheet.Cells(4, i + 1) = ds1.Tables(0).Rows(i).Item(1)




                Next

            Next




            '===========================================================
            Dim gg As Integer = 0
            gg = num_tot_frist.Value
            'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")
            xlWorkSheet.SaveAs((Application.StartupPath) & "\كشف اجمالى  " + gg.ToString() + ".xls ")

            xlWorkBook.Save()
            'xlWorkSheet.PrintPreview()
            xlWorkBook.Close()
            'xlApp.Quit()
            'releaseObject(xlApp)
            'releaseObject(xlWorkBook)
            'releaseObject(xlWorkSheet)

            'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())

            MsgBox("تم الحفظ بنجاح فى \كشف رقم " + gg.ToString())
            'Label2.Visible = False
            'Label3.Visible = False
            'ProgressBar1.Value = 0

            '===================================================================================

        Catch ex As Exception

        End Try

    End Sub

    
    Private Sub num_tot_end_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles num_tot_end.Leave
        NumericUpDown3.Value = (num_tot_end.Value - num_tot_frist.Value)
        If NumericUpDown3.Value > 19 Then
            num_tot_end.Value = num_tot_frist.Value + 19

        End If
    End Sub

End Class