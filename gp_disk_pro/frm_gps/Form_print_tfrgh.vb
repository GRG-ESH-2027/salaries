Imports System.IO
Imports excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports gp_disk_pro.NumberToWord

Public Class Form_print_tfrgh
    'Public ds As New DataSet
    Public stat = "اعدادى"
    Public ds As New DataSet
    Public no_k As Integer
    '=========================================
    '  ثانوى تجميع صافى datagridview
    Public Sub total_saffy_sanwy()
        Dim sum As Double = 0
        For s As Integer = 0 To dgv_Table_mkf_no_kshf.RowCount - 1
            sum = sum + dgv_Table_mkf_no_kshf.Item("Saffy_after_antkal", s).Value

        Next
        NumericUpDown3.Value = sum


    End Sub

    '========================================
    '  اعدادى تجميع صافى datagridview
    Public Sub total_saffy_adayed()
        Dim sum As Double = 0
        For s As Integer = 0 To dgv_Table_mkf_no_kshf.RowCount - 1
            sum = sum + dgv_Table_mkf_no_kshf.Item("Saffy", s).Value

        Next
        NumericUpDown3.Value = sum
        'MessageBox.Show(sum.ToString())

    End Sub

    '========================================

    Public Sub DataGridViewHeaderText_no_kshf(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Id").HeaderText = "Id"
                .Columns("No_55").HeaderText = "55 ع . ح"
                '.Columns("no_kshf").HeaderText = "رقم الكشف"

                .Columns("Salary_ass").HeaderText = "المرتب الاساسى"
                .Columns("Dayes").HeaderText = "عدد الايام"
                .Columns("Mkf").HeaderText = "المكافاة"
                .Columns("Badl_safer").HeaderText = "بدل سفر"
                .Columns("Entklat").HeaderText = "انتقالات"
                .Columns("total").HeaderText = "جملة"
                .Columns("Mashat").HeaderText = "معاشات"
                .Columns("Mashat8").HeaderText = "معاشات 1% "
                .Columns("Darabb").HeaderText = "ضرائب"
                .Columns("nkaba").HeaderText = "مهن 2% "
                .Columns("Mhann").HeaderText = " م 1%"

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
                .Columns("id_no").HeaderText = "الرقم القومى"
                .Columns("op_name_pay").HeaderText = "نوع المدفوعه"
                .Columns("op_al_kta").HeaderText = "القطاع"
                '.Columns("Name_school").HeaderText = "المدرسة"
                .Columns("op_no_emb").HeaderText = "رقم الموظف بجهته الأصلية"
                '.Columns("Name_Emp").HeaderText = "الاسم"
                '.Columns("name_pay").Visible = False
                '.Columns("al_kta").Visible = False
                '.Columns("no_emb").Visible = False
                '.Columns("hh").Visible = False
                .Columns("Mzay_t_17_25").HeaderText = "مزايا تأمينية"
                .Columns(20).DefaultCellStyle.BackColor = Color.Yellow
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .ScrollBars = ScrollBars.Both
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .SelectionMode = DataGridView.DefaultFont.Bold

                .RowsDefaultCellStyle.BackColor = Color.Black
                .RowsDefaultCellStyle.ForeColor = Color.Green
                .RowsDefaultCellStyle.SelectionBackColor = Color.Red
                '====
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
                '====
                .RowHeadersDefaultCellStyle.ForeColor = Color.White
                .RowHeadersDefaultCellStyle.BackColor = Color.Navy
            End With
        End If
    End Sub

    'ط================================================
    Public Sub DataGridViewHeaderText_no_kshf_sanwy(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Id").HeaderText = "Id"
                .Columns("No_55").HeaderText = "55 ع . ح"
                '.Columns("no_kshf").HeaderText = "رقم الكشف"

                .Columns("Salary_ass").HeaderText = "المرتب الاساسى"
                .Columns("Dayes").HeaderText = "عدد الايام"
                .Columns("Mkf").HeaderText = "المكافاة"
                .Columns("Badl_safer").HeaderText = "بدل سفر"
                .Columns("Entklat").HeaderText = "انتقالات"
                .Columns("total").HeaderText = "جملة"
                .Columns("Mashat").HeaderText = "معاشات"
                .Columns("Mashat8").HeaderText = "معاشات 1% "
                .Columns("Darabb").HeaderText = "ضرائب"
                .Columns("nkaba").HeaderText = "مهن 2% "
                .Columns("Mhann").HeaderText = " م 1%"

                .Columns("Mastshfa").HeaderText = "مستشفى"
                .Columns("Damghh").HeaderText = "دمغه"
                .Columns("Earaadta").HeaderText = "ايرادات"
                .Columns("box20").HeaderText = "صندوق %20"
                .Columns("Mzay_t_17_25").HeaderText = "مزايا تأمينيه17_25"
                .Columns("Total_Mostkta").HeaderText = "جملة المستقطع"
                .Columns("Name_school").HeaderText = "المدرسة"
                .Columns("Name_Emp").HeaderText = "الاسم"
                .Columns("Saffy_after_antkal").HeaderText = "الصافى"
                '.Columns("Id_Mkf").HeaderText = "Id_Mkf"
                '.Columns("date1").HeaderText = "التاريخ"
                .Columns("id_no").HeaderText = "الرقم القومى"
                .Columns("op_name_pay").HeaderText = "نوع المدفوعه"
                .Columns("op_al_kta").HeaderText = "القطاع"
                '.Columns("Name_school").HeaderText = "المدرسة"
                .Columns("op_no_emb").HeaderText = "رقم الموظف بجهته الأصلية"
                '.Columns("Name_Emp").HeaderText = "الاسم"
                '.Columns("name_pay").Visible = False
                '.Columns("al_kta").Visible = False
                '.Columns("no_emb").Visible = False
                '.Columns("hh").Visible = False
                .Columns(20).DefaultCellStyle.BackColor = Color.Yellow
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .ScrollBars = ScrollBars.Both
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowsDefaultCellStyle.BackColor = Color.Black
                .RowsDefaultCellStyle.ForeColor = Color.Green
                .RowsDefaultCellStyle.SelectionBackColor = Color.Red
                '====
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
                '====
                .RowHeadersDefaultCellStyle.ForeColor = Color.White
                .RowHeadersDefaultCellStyle.BackColor = Color.Navy

            End With
        End If
    End Sub




    '=================================================

    Private Sub Form_print_tfrgh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PictureBox2.ImageLocation = (" & Application.StartupPath &" " \nav_left_red.ico ")
        'PictureBox2.Image = Icon.ExtractAssociatedIcon("nav_left_red.ico").ToBitmap()
        'PictureBox2.Image = Image.FromFile("nav_left_red.ico")
        ComboBox1.Text = "غير مرتب"
        If stat = "اعدادى" Then
            no_k = Max_no_kshf()

            'SelectSome_Table_mkf_add_indirect(ch_list_box)

            SelectSome_Table_mkf_add_indirect(no_kshf_list_box)
            SelectAll_Table_mkf_no_kshf(no_k)
            dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_no_kshff_pr
            DataGridViewHeaderText_no_kshf(dgv_Table_mkf_no_kshf)

            no_kshf_list_box.SelectedValue = no_k
            Label8.Text = dgv_Table_mkf_no_kshf.Rows.Count.ToString()
            '=======================================

            '==================

        Else
            no_k = Max_no_kshf()

            SelectSome_Table_mkf_add_indirect(no_kshf_list_box)


            SelectAll_Table_mkf_sanwy_no_kshf(no_k)
            dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_sanwy_no_kshff
            DataGridViewHeaderText_no_kshf_sanwy(dgv_Table_mkf_no_kshf)

            no_kshf_list_box.SelectedValue = no_k

            '================
            total_saffy_sanwy()
            Label8.Text = dgv_Table_mkf_no_kshf.Rows.Count.ToString()
            '====================

            '================================================

        End If




    End Sub

    Private Sub no_kshf_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If stat = "اعدادى" Then
                Dim no_kkk As Integer = 0



                no_kkk = no_kshf_list_box.SelectedValue
                If no_kkk > 0 Then

                    SelectAll_Table_mkf_no_kshf(no_kkk)
                    dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_no_kshff_pr
                    txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

                    Dim Id_Mkff As Integer
                    Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value

                    Id_Mkf.Value = Id_Mkff
                    select_id_mkf(Id_Mkf.Value)
                    DataGridView1.DataSource = dt_select_id_mkf
                    Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                    term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
                    no_kashf2.Value = dgv_Table_mkf_no_kshf.Rows(0).Cells("no_kshf").Value.ToString()
                    Label8.Text = dgv_Table_mkf_no_kshf.RowCount().ToString()

                Else
                    no_kkk = 1

                End If
            Else
                stat = "ثانوى"
                Dim no_kk As Integer = 0
                no_kk = no_kshf_list_box.SelectedValue
                If no_kk > 0 Then

                    SelectAll_Table_mkf_sanwy_no_kshf(no_kk)
                    dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_sanwy_no_kshff
                    txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

                    Dim Id_Mkff As Integer
                    Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value

                    Id_Mkf.Value = Id_Mkff
                    select_id_mkf(Id_Mkf.Value)
                    DataGridView1.DataSource = dt_select_id_mkf
                    Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                    term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
                    no_kashf2.Value = dgv_Table_mkf_no_kshf.Rows(0).Cells("no_kshf").Value.ToString()
                    Label8.Text = dgv_Table_mkf_no_kshf.Rows.Count.ToString()

                Else
                    no_kk = 1

                End If
            End If




        Catch
            Dim no_kk As Integer = 1
        End Try
    End Sub





    Private Sub no_kshf_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)
        Id_Mkf.Value = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value.ToString()
    End Sub

    Private Sub no_kshf_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Id_Mkf.Value = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value.ToString()
    End Sub





    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Label9.Text = ""
        ds.Clear()
        Try

            If stat = "اعدادى" Then
                For Each iteem As Integer In ch_list_box.CheckedItems


                    Dim no_kkk As Integer = 0

                    no_kkk = iteem

                    Dim Cmd As New OleDbDataAdapter("select id_no,op_name_pay,op_al_kta,Name_school,op_no_emb , Name_Emp,Saffy,Entklat,Badl_safer,no_kshf from Table_mkf_add where no_kshf  = " & no_kkk & "", con)

                    Cmd.Fill(ds)

                Next
                '======================================================================================



                add_file()
                Label3.Visible = True
                Label2.Visible = True
                'Dim i As Integer
                'Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                Dim inputFile As String = ((Application.StartupPath) & "\Pay-krke_george-20190618-100047.xlsx")
                'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                xlWorkBook = xlApp.Workbooks.Open(inputFile)

                xlWorkSheet = xlWorkBook.ActiveSheet

                xlWorkSheet.DisplayRightToLeft = True
                'xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                ''
                'xlWorkSheet.Cells(3, 12) = term.Text
                'xlWorkSheet.Cells(3, 18) = Years.Text
                'xlWorkSheet.Cells(2, 17) = Item_Mkf.Text
                'xlWorkSheet.Cells(2, 18) = iteem



                '========================================================


                For x = 0 To ds.Tables(0).Rows.Count - 1

                    ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
                    'ProgressBar1=====================
                    ProgressBar1.Value = x
                    Dim total_s As Double = 0
                    total_s = (x * 1) / ds.Tables(0).Rows.Count - 1
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()
                    Label2.Text = "جارى التحميل 00000"
                    Label2.Visible = False
                    Label2.Visible = True

                    '=====================================
                    For j = 0 To ds.Tables(0).Columns.Count - 1
                        'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                        'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(x + 2, j + 1) = ds.Tables(0).Rows(x).Item(j)
                        'Next
                    Next

                Next


                '===========================================================
                Dim gg As String
                gg = "Pay-krke_george-20190618-100047" + no_kashf2.Value.ToString()
                'xlWorkSheet.SaveAs("D:\" + gg + ".xlsx ")
                xlWorkSheet.SaveAs((Application.StartupPath) & "\" + gg + ".xlsx ")

                xlWorkBook.Save()
                'xlWorkSheet.PrintPreview()
                xlWorkBook.Close()

                '=========================
                Dim st As String
                st = (ds.Tables(0).Rows.Count).ToString()
                Label9.Text += st + "عدد"
                '======================
                'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
                Label9.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
                Label2.Visible = False
                Label3.Visible = False
                ProgressBar1.Value = 0
                ds.Clear()
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                xlApp = Nothing
                xlWorkBook = Nothing
                xlWorkSheet = Nothing

                If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Process.Start((Application.StartupPath) & "\" + gg + ".xlsx ")
                End If

            Else
                For Each iteem As Integer In ch_list_box.CheckedItems


                    Dim no_kkk As Integer = 0

                    no_kkk = iteem

                    Dim Cmd As New OleDbDataAdapter("select  id_no,op_name_pay,op_al_kta,Name_school,op_no_emb , Name_Emp,Saffy,Entklat,Badl_safer,no_kshf from Table_mkf_add where no_kshf  = " & no_kkk & " ORDER BY Name_Emp", con)

                    Cmd.Fill(ds)

                Next
                '======================================================================================



                add_file()
                Label3.Visible = True
                Label2.Visible = True
                'Dim i As Integer
                'Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                Dim inputFile As String = ((Application.StartupPath) & "\Pay-krke_george-20190618-100047.xlsx")
                'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                xlWorkBook = xlApp.Workbooks.Open(inputFile)

                xlWorkSheet = xlWorkBook.ActiveSheet

                xlWorkSheet.DisplayRightToLeft = True
                'xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                ''
                'xlWorkSheet.Cells(3, 12) = term.Text
                'xlWorkSheet.Cells(3, 18) = Years.Text
                'xlWorkSheet.Cells(2, 17) = Item_Mkf.Text
                'xlWorkSheet.Cells(2, 18) = iteem



                '========================================================


                For x = 0 To ds.Tables(0).Rows.Count - 1

                    ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
                    'ProgressBar1=====================
                    ProgressBar1.Value = x
                    Dim total_s As Double = 0
                    total_s = (x * 1) / ds.Tables(0).Rows.Count - 1
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()
                    Label2.Text = "جارى التحميل 00000"
                    Label2.Visible = False
                    Label2.Visible = True

                    '=====================================
                    For j = 0 To ds.Tables(0).Columns.Count - 1
                        'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                        'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(x + 2, j + 1) = ds.Tables(0).Rows(x).Item(j)
                        'Next
                    Next

                Next


                '===========================================================
                Dim gg As String
                gg = "Pay-krke_george-20190618-100047" + no_kashf2.Value.ToString()
                'xlWorkSheet.SaveAs("D:\" + gg + ".xlsx ")
                xlWorkSheet.SaveAs((Application.StartupPath) & "\" + gg + ".xlsx ")
                xlWorkBook.Save()
                'xlWorkSheet.PrintPreview()
                xlWorkBook.Close()

                '=========================
                Dim st As String
                st = (ds.Tables(0).Rows.Count).ToString()
                Label9.Text += st + "عدد"
                '======================
                'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
                Label9.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
                Label2.Visible = False
                Label3.Visible = False
                ProgressBar1.Value = 0
                ds.Clear()
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                xlApp = Nothing
                xlWorkBook = Nothing
                xlWorkSheet = Nothing

                If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Process.Start((Application.StartupPath) & "\" + gg + ".xlsx ")
                End If
            End If
        Catch ex As Exception
        Finally
            'MessageBox.Show("erro")
        End Try

    End Sub








    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try




            Dim daa As New OleDbDataAdapter
            'Dim reprt As New CrystalReport3
            'Dim reprt4 As New CrystalReport4
            Dim dv As New DataView
            Dim ds As New DataSet1

            Dim no_kshf As Integer
            no_kshf = no_kashf2.Value
            Dim id_mkff As Integer
            id_mkff = Id_Mkf.Value

            If Label3.Text = "صفحة طباعة اعداديه تقارير" Then
                daa = New OleDbDataAdapter("SELECT No_55, Salary_ass, Dayes, Mkf, total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta, Name_school, Name_Emp , Saffy, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, id_no, op_name_pay, op_al_kta, op_no_emb,Name_Mkf,Item_Mkf,Years,term FROM Table_mkf_add  INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf WHERE no_kshf = " & no_kshf & " and Table_Mkf.Id_Mkf = " & id_mkff & " ", con)
                daa.Fill(ds, "table_add_mkf")
                dv = New DataView(ds.Tables("table_add_mkf"))
                'reprt.SetDataSource(dv)


                'reprt.SetParameterValue(0, "كشف مكافاة امتحانات  " & term.Text & " " & "الدور " & "  " & Name_Mkf.Text & "  " & Years.Text)
                'reprt.SetParameterValue(1, term.Text)
                'frm_viewer.CrystalReportViewer1.ReportSource = reprt
                frm_viewer.Show()
            Else
                daa = New OleDbDataAdapter("SELECT No_55, Salary_ass, Dayes, Mkf, total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta, Name_school, Name_Emp , Saffy_after_antkal, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, id_no, op_name_pay, op_al_kta, op_no_emb,Name_Mkf,Item_Mkf,Years,term FROM Table_mkf_add  INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf WHERE no_kshf = " & no_kshf & " and Table_Mkf.Id_Mkf = " & id_mkff & " ", con)
                daa.Fill(ds, "table_add_mkf")
                dv = New DataView(ds.Tables("table_add_mkf"))
                'reprt4.SetDataSource(dv)


                'reprt4.SetParameterValue(0, "كشف مكافاة امتحانات  " & term.Text & " " & "الدور " & "  " & Name_Mkf.Text & "  " & Years.Text)
                'reprt4.SetParameterValue(1, term.Text)
                'frm_viewer.CrystalReportViewer1.ReportSource = reprt4
                frm_viewer.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub




    Public dt_Table_mkf_ad As New DataTable
    Public Sub SelectAll_Table_mkf_ad(ByVal no_kshf As Integer, ByVal Id_Mkf As Integer)
        dt_Table_mkf_ad.Clear()
        Dim cmd As New OleDbCommand("SELECT No_55, Salary_ass, Dayes, Mkf, total, Mashat, Mashat8, Darabb, nkaba, Mhann, Mastshfa, Damghh, Earaadta, box20, Total_Mostkta, Name_school AS المدرسة, Name_Emp AS الاسم, Saffy, Entklat, Badl_safer, id, Table_Mkf.Id_Mkf, no_kshf, id_no, op_name_pay, op_al_kta, op_no_emb FROM Table_mkf_add INNER JOIN Table_Mkf ON Table_mkf_add.Id_Mkf = Table_Mkf.Id_Mkf WHERE no_kshf = @no_kshf and Table_Mkf.Id_Mkf = @Id_Mkf", con)

        With cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf
            .Parameters.AddWithValue("@Id_Mkf", OleDbType.Integer).Value = Id_Mkf
            dt_Table_mkf_no_kshff.Load(cmd.ExecuteReader)

        End With
        con.Close()
        cmd = Nothing



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        no_kashf2.Value = ch_list_box.SelectedItem
    End Sub






    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Label4.Text = DateTime.Now.ToString("hh:mm:ss." + DateTime.Now.Ticks.ToString())
        Label4.Text = DateTime.Now.ToString("mm")
        Label5.Text = "0"
        Label6.Text = (Convert.ToInt32(Label5.Text) - Convert.ToInt32(Label4.Text)).ToString() + " د "
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        close_all()
    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Label4.Text = DateTime.Now.ToString("mm")
        Try


            If ComboBox1.Text = "غير مرتب" Then



                If stat = "اعدادى" Then

                    Dim no_kkk As Integer = 0



                    no_kkk = no_kshf_list_box.SelectedValue
                    'تفقيط الارقام
                    '=======================
                    total_saffy_adayed()
                    txtNumber.Text = NumericUpDown3.Value.ToString()
                    '======================================================================================
                    add_file()
                    Label3.Visible = True
                    Label2.Visible = True
                    Dim i As Integer
                    Dim j As Integer

                    xlApp = New Microsoft.Office.Interop.Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    'Dim inputFile As String = ("d:\page_tfrgh.xls")
                    Dim inputFile As String = ((Application.StartupPath) & "\page_tfrgh.xlsx")

                    'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                    xlWorkBook = xlApp.Workbooks.Open(inputFile)

                    xlWorkSheet = xlWorkBook.ActiveSheet

                    xlWorkSheet.DisplayRightToLeft = True
                    xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                    'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
                    xlWorkSheet.Cells(3, 12) = term.Text
                    xlWorkSheet.Cells(2, 8) = Years.Text

                    xlWorkSheet.Cells(2, 17) = Item_Mkf.Text

                    xlWorkSheet.Cells(3, 18) = no_kashf2.Value
                    xlWorkSheet.Cells(3, 17) = txt_name_user.Text
                    xlWorkSheet.Cells(25, 4) = txtArabicWord.Text
                    ProgressBar1.Maximum = dgv_Table_mkf_no_kshf.RowCount


                    Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Mzay_t_17_25,Total_Mostkta,Name_school ,Name_Emp ,Saffy,Entklat,Badl_safer,id,Id_Mkf,no_kshf,user_table.user_ful_name,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb from Table_mkf_add,user_table where no_kshf  = " & no_kkk & " and Table_mkf_add.id_user=user_table.id_user", con)


                    '=====================
                    Dim ds As New DataSet
                    Cmd.Fill(ds)

                    For i = 0 To ds.Tables(0).Rows.Count - 1



                        'ProgressBar1=====================
                        ProgressBar1.Value = i
                        Dim total_s As Double = 0
                        total_s = (i * 1) / dgv_Table_mkf_no_kshf.RowCount
                        total_s = total_s * 100
                        total_s = Math.Round(total_s, 0)

                        Label3.Text = "%".ToString() + total_s.ToString()
                        Label2.Text = "جارى التحميل 00000"
                        Label2.Visible = False
                        Label2.Visible = True

                        '=====================================
                        For j = 0 To ds.Tables(0).Columns.Count - 1

                            xlWorkSheet.Cells(i + 5, j + 1) = ds.Tables(0).Rows(i).Item(j)

                            '=============تجميع المستقطع ============
                            Dim drab_t, mas_t_9, mahn_t_2, m_1_t, m1_t, m_t_1, damgh_t, eradat_t, box_t, masht17 As String
                            drab_t = "i" + (5 + i).ToString()
                            mas_t_9 = "g" + (5 + i).ToString()
                            mahn_t_2 = "j" + (5 + i).ToString()
                            m_1_t = "h" + (5 + i).ToString()
                            m1_t = "k" + (5 + i).ToString()
                            m_t_1 = "l" + (5 + i).ToString()
                            damgh_t = "m" + (5 + i).ToString()
                            eradat_t = "n" + (5 + i).ToString()
                            box_t = "o" + (5 + i).ToString()
                            masht17 = "p" + (5 + i).ToString()

                            xlWorkSheet.Cells(i + 5, 17) = "=(" + drab_t + "+" + mas_t_9 + "+" + mahn_t_2 + "+" + m_1_t + "+" + m1_t + "+" + m_t_1 + "+" + damgh_t + "+" + eradat_t + "+" + box_t + "+" + masht17 + ")"
                            'xlWorkSheet.Cells(i + 5, 16) = ds.Tables(0).Rows(i).Item(6) + ds.Tables(0).Rows(i).Item(7) +
                            '    ds.Tables(0).Rows(i).Item(8) + ds.Tables(0).Rows(i).Item(9) +
                            '    ds.Tables(0).Rows(i).Item(10) + ds.Tables(0).Rows(i).Item(11) +
                            '    ds.Tables(0).Rows(i).Item(12) + ds.Tables(0).Rows(i).Item(13) +
                            '     ds.Tables(0).Rows(i).Item(14)
                            '=======================تجميع الصافى ======================
                            Dim num_row As String
                            Dim num_col As String
                            '(f-p)
                            num_row = "f" + (5 + i).ToString()
                            num_col = "q" + (5 + i).ToString()


                            xlWorkSheet.Cells(i + 5, 20) = "=(" + num_row + "-" + num_col + ")"


                        Next

                    Next


                    '========================================================
                    Dim da1 As New OleDbDataAdapter("select * from tabel_name_col_tfrgh ", con)



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
                    '===============================




                    '===========================================================
                    Dim gg As Integer = 0
                    gg = no_kshf_list_box.SelectedValue
                    'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")
                    xlWorkSheet.SaveAs((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")

                    xlWorkBook.Save()
                    'xlWorkSheet.PrintPreview()
                    xlWorkBook.Close()

                    MsgBox("تم الحفظ بنجاح فى \كشف رقم " + gg.ToString())
                    ListBox1.Items.Add("كشف رقم : " + gg.ToString())
                    Label2.Visible = False
                    Label3.Visible = False
                    ProgressBar1.Value = 0
                    ds.Clear()
                    xlApp.Quit()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                    xlApp = Nothing
                    xlWorkBook = Nothing
                    xlWorkSheet = Nothing

                    If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Process.Start((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
                    End If
                    'ط===================================================================================================
                    '=================================================ثانوى==========================================================================
                    '=========================================================================================

                Else
                    add_file()
                    Label3.Visible = True
                    Label2.Visible = True
                    Dim i As Integer
                    Dim j As Integer

                    xlApp = New Microsoft.Office.Interop.Excel.Application
                    xlWorkBook = xlApp.Workbooks.Add(misValue)
                    'Dim inputFile As String = ("d:\tfrgh_sanwy.xls")
                    Dim inputFile As String = ((Application.StartupPath) & "\tfrgh_sanwy.xlsx")

                    'source_path = (Application.StartupPath) & "\page_tfrgh.xls"

                    'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                    xlWorkBook = xlApp.Workbooks.Open(inputFile)

                    xlWorkSheet = xlWorkBook.ActiveSheet

                    xlWorkSheet.DisplayRightToLeft = True
                    xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                    'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
                    xlWorkSheet.Cells(3, 12) = term.Text
                    xlWorkSheet.Cells(3, 16) = Years.Text

                    xlWorkSheet.Cells(2, 17) = no_kashf2.Value
                    xlWorkSheet.Cells(2, 19) = txt_name_user.Text

                    xlWorkSheet.Cells(26, 3) = txtArabicWord.Text
                    ProgressBar1.Maximum = dgv_Table_mkf_no_kshf.RowCount
                    Dim no_kkk As Integer = 0



                    no_kkk = no_kshf_list_box.SelectedValue

                    'Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,Entklat,Badl_safer,total,Darabb, Mashat,nkaba,Mashat8,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy_after_antkal,id,Id_Mkf,no_kshf,user_table.user_ful_name,op_id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb  from Table_mkf_add,user_table where no_kshf  = " & no_kkk & " and Table_mkf_add.id_user=user_table.id_user ORDER BY Name_Emp", con)
                    '=======================================0=========1======2=====3====4=====5=======6==========7===8========9
                    Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,Entklat,Badl_safer,total,Darabb, Mashat,nkaba,Mashat8,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy_after_antkal,id,Id_Mkf,no_kshf,user_table.user_ful_name,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb  from Table_mkf_add,user_table where no_kshf  = " & no_kkk & " and Table_mkf_add.id_user=user_table.id_user", con)


                    '=====================
                    Dim ds As New DataSet
                    Cmd.Fill(ds)

                    For i = 0 To ds.Tables(0).Rows.Count - 1


                        'ProgressBar1=====================
                        ProgressBar1.Value = i
                        Dim total_s As Double = 0
                        total_s = (i * 1) / dgv_Table_mkf_no_kshf.RowCount
                        total_s = total_s * 100
                        total_s = Math.Round(total_s, 0)

                        Label3.Text = "%".ToString() + total_s.ToString()
                        Label2.Text = "جارى التحميل 00000"
                        Label2.Visible = False
                        Label2.Visible = True

                        '========================ثانوى=============
                        For j = 0 To ds.Tables(0).Columns.Count - 1
                            'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                            'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 5, j + 1) = ds.Tables(0).Rows(i).Item(j)
                            'N==================================================
                            '===========ثانوى ==تجميع المستقطع ============
                            xlWorkSheet.Cells(i + 5, 18) = ds.Tables(0).Rows(i).Item(8) + ds.Tables(0).Rows(i).Item(9) +
                                ds.Tables(0).Rows(i).Item(10) + ds.Tables(0).Rows(i).Item(11) +
                                ds.Tables(0).Rows(i).Item(12) + ds.Tables(0).Rows(i).Item(13) +
                                 ds.Tables(0).Rows(i).Item(14) + ds.Tables(0).Rows(i).Item(15) + ds.Tables(0).Rows(i).Item(16)
                            '=======================تجميع الصافى ======================
                            xlWorkSheet.Cells(i + 5, 21) = (ds.Tables(0).Rows(i).Item(3) + ds.Tables(0).Rows(i).Item(4) + ds.Tables(0).Rows(i).Item(5) + ds.Tables(0).Rows(i).Item(6)) - ds.Tables(0).Rows(i).Item(17)
                        Next
                    Next

                    '========================================================
                    Dim da1 As New OleDbDataAdapter("select * from table_name_co_tfrghh_sanwy ", con)



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
                    gg = no_kshf_list_box.SelectedValue
                    'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")


                    xlWorkSheet.SaveAs((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
                    xlWorkBook.Save()
                    'xlWorkSheet.PrintPreview()
                    xlWorkBook.Close()


                    MsgBox("تم الحفظ بنجاح فى \كشف رقم " + gg.ToString())
                    Label2.Visible = False
                    Label3.Visible = False
                    ProgressBar1.Value = 0
                    ds.Clear()
                    xlApp.Quit()
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                    xlApp = Nothing
                    xlWorkBook = Nothing
                    xlWorkSheet = Nothing

                    If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                        Process.Start((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
                    End If
                End If
            Else


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            '====كود غلق برنامج اكسيل 
            Dim Pro() As Process = System.Diagnostics.Process.GetProcessesByName("excel")
            For Each Y As Process In Pro
                Y.Kill()
            Next
            ''=============================
        End Try
        Label5.Text = DateTime.Now.ToString("mm")
        Label6.Text = (Convert.ToInt32(Label5.Text) - Convert.ToInt32(Label4.Text)).ToString() + " د "

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label9.Text = ""
        Try

       

        For Each iteem As Integer In ch_list_box.CheckedItems



            If stat = "اعدادى" Then
                '======================================================================================
                Dim no_kkk As Integer = 0



                no_kkk = iteem
                If no_kkk > 0 Then

                    SelectAll_Table_mkf_no_kshf(no_kkk)
                    dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_no_kshff_pr
                    txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

                    Dim Id_Mkff As Integer
                    Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value

                    Id_Mkf.Value = Id_Mkff
                    select_id_mkf(Id_Mkf.Value)
                    DataGridView1.DataSource = dt_select_id_mkf
                    Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                    term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
                    no_kashf2.Value = dgv_Table_mkf_no_kshf.Rows(0).Cells("no_kshf").Value.ToString()
                    Label8.Text = dgv_Table_mkf_no_kshf.RowCount().ToString()

                Else
                    no_kkk = 1

                End If

                '======================================================================================
                'تفقيط الارقام
                '=======================
                total_saffy_adayed()
                txtNumber.Text = NumericUpDown3.Value.ToString()
                '======================================================================================

                add_file()
                Label3.Visible = True
                Label2.Visible = True
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                ''Dim inputFile As String = ("d:\page_tfrgh.xls")
                Dim inputFile As String = ((Application.StartupPath) & "\page_tfrgh.xlsx")
                'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                xlWorkBook = xlApp.Workbooks.Open(inputFile)

                xlWorkSheet = xlWorkBook.ActiveSheet

                xlWorkSheet.DisplayRightToLeft = True
                xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
                xlWorkSheet.Cells(3, 12) = term.Text
                xlWorkSheet.Cells(2, 8) = Years.Text
                xlWorkSheet.Cells(2, 17) = Item_Mkf.Text

                xlWorkSheet.Cells(3, 18) = iteem
                xlWorkSheet.Cells(3, 17) = txt_name_user.Text
                xlWorkSheet.Cells(25, 4) = txtArabicWord.Text


                'Dim no_kkk As Integer = 0



                no_kkk = iteem
                '==========================================================1=====2=========3====4===5======6====7========8=====9=====10====11=====12=====13======14
                Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Mzay_t_17_25,Total_Mostkta,Name_school ,Name_Emp ,Saffy,Entklat,Badl_safer,id,Id_Mkf,no_kshf,user_table.user_ful_name,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb from Table_mkf_add,user_table where no_kshf  = " & no_kkk & " and Table_mkf_add.id_user=user_table.id_user", con)



                '=====================
                Dim ds As New DataSet
                Cmd.Fill(ds)

                For i = 0 To ds.Tables(0).Rows.Count - 1

                    ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
                    'ProgressBar1=====================
                    ProgressBar1.Value = i
                    Dim total_s As Double = 0
                    total_s = (i * 1) / ds.Tables(0).Rows.Count - 1
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()
                    Label2.Text = "جارى التحميل 00000"
                    Label2.Visible = False
                    Label2.Visible = True

                    '=====================================
                    For j = 0 To ds.Tables(0).Columns.Count - 1
                        'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                        'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 5, j + 1) = ds.Tables(0).Rows(i).Item(j)

                        '=============تجميع المستقطع ============
                        xlWorkSheet.Cells(i + 5, 17) = ds.Tables(0).Rows(i).Item(6) + ds.Tables(0).Rows(i).Item(7) +
                            ds.Tables(0).Rows(i).Item(8) + ds.Tables(0).Rows(i).Item(9) +
                            ds.Tables(0).Rows(i).Item(10) + ds.Tables(0).Rows(i).Item(11) +
                            ds.Tables(0).Rows(i).Item(12) + ds.Tables(0).Rows(i).Item(13) +
                             ds.Tables(0).Rows(i).Item(14) + ds.Tables(0).Rows(i).Item(15)
                        '=======================تجميع الصافى ======================
                        Dim num_row As String
                        Dim num_col As String
                        '(f-p)
                        num_row = "f" + (5 + i).ToString()
                        num_col = "q" + (5 + i).ToString()


                        xlWorkSheet.Cells(i + 5, 20) = "=(" + num_row + "-" + num_col + ")"
                    Next
                Next

                '========================================================
                Dim da1 As New OleDbDataAdapter("select * from tabel_name_col_tfrgh   ", con)



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
                gg = iteem
                'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")
                xlWorkSheet.SaveAs((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
                xlWorkBook.Save()
                'xlWorkSheet.PrintPreview()
                xlWorkBook.Close()


                'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
                Label9.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
                'RichTextBox1.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"

                ListBox1.Items.Add("كشف رقم : " + gg.ToString())
                Label2.Visible = False
                Label3.Visible = False
                ProgressBar1.Value = 0
                ds.Clear()
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                xlApp = Nothing
                xlWorkBook = Nothing
                xlWorkSheet = Nothing

                'If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                '    Process.Start((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
                'End If
                '=================================================================================
                '===================================ثانوى==========================================
                '========================================================================

            Else
                '======================================================================================
                Dim no_kkk As Integer = 0



                no_kkk = iteem

                If no_kkk > 0 Then

                    SelectAll_Table_mkf_sanwy_no_kshf(no_kkk)
                    dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_sanwy_no_kshff
                    txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

                    Dim Id_Mkff As Integer
                    Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value
                    txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

                    Id_Mkf.Value = Id_Mkff
                    select_id_mkf(Id_Mkf.Value)
                    DataGridView1.DataSource = dt_select_id_mkf
                    Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                    term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
                    no_kashf2.Value = dgv_Table_mkf_no_kshf.Rows(0).Cells("no_kshf").Value.ToString()
                    Label8.Text = dgv_Table_mkf_no_kshf.RowCount().ToString()

                Else
                    no_kkk = 1

                End If


                '======================================================================================
                'تفقيط الارقام
                '=======================
                total_saffy_sanwy()
                txtNumber.Text = NumericUpDown3.Value.ToString()
                '================================
                add_file()
                Label3.Visible = True
                Label2.Visible = True
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                Dim inputFile As String = ((Application.StartupPath) & "\tfrgh_sanwy.xlsx")
                'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                xlWorkBook = xlApp.Workbooks.Open(inputFile)

                xlWorkSheet = xlWorkBook.ActiveSheet

                xlWorkSheet.DisplayRightToLeft = True
                xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
                xlWorkSheet.Cells(3, 12) = term.Text
                xlWorkSheet.Cells(3, 16) = Years.Text

                xlWorkSheet.Cells(2, 17) = iteem
                xlWorkSheet.Cells(2, 19) = txt_name_user.Text
                xlWorkSheet.Cells(26, 3) = txtArabicWord.Text
                ProgressBar1.Maximum = dgv_Table_mkf_no_kshf.RowCount
                'Dim no_kkk As Integer = 0



                no_kkk = iteem

                'Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,Entklat,Badl_safer,total,Darabb, Mashat,nkaba,Mashat8,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy_after_antkal,id,Id_Mkf,no_kshf,user_table.user_ful_name,op_id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb  from Table_mkf_add,user_table where no_kshf  = " & no_kkk & " and Table_mkf_add.id_user=user_table.id_user ORDER BY Name_Emp", con)
                Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,Entklat,Badl_safer,total,Darabb, Mashat,nkaba,Mashat8,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy_after_antkal,id,Id_Mkf,no_kshf,user_table.user_ful_name,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb  from Table_mkf_add,user_table where no_kshf  = " & no_kkk & " and Table_mkf_add.id_user=user_table.id_user", con)



                '=====================
                Dim ds As New DataSet
                Cmd.Fill(ds)

                For i = 0 To ds.Tables(0).Rows.Count - 1

                    ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
                    'ProgressBar1=====================
                    ProgressBar1.Value = i
                    Dim total_s As Double = 0
                    total_s = (i * 1) / ds.Tables(0).Rows.Count - 1
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()
                    Label2.Text = "جارى التحميل 00000"
                    Label2.Visible = False
                    Label2.Visible = True

                    '=====================================
                    For j = 0 To ds.Tables(0).Columns.Count - 1
                        'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                        'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 5, j + 1) = ds.Tables(0).Rows(i).Item(j)
                        '================================================================
                        '===========ثانوى ==تجميع المستقطع ============
                        xlWorkSheet.Cells(i + 5, 18) = ds.Tables(0).Rows(i).Item(8) + ds.Tables(0).Rows(i).Item(9) +
                            ds.Tables(0).Rows(i).Item(10) + ds.Tables(0).Rows(i).Item(11) +
                            ds.Tables(0).Rows(i).Item(12) + ds.Tables(0).Rows(i).Item(13) +
                             ds.Tables(0).Rows(i).Item(14) + ds.Tables(0).Rows(i).Item(15) + ds.Tables(0).Rows(i).Item(16)
                        '=======================تجميع الصافى ======================
                        xlWorkSheet.Cells(i + 5, 21) = (ds.Tables(0).Rows(i).Item(3) + ds.Tables(0).Rows(i).Item(4) + ds.Tables(0).Rows(i).Item(5) + ds.Tables(0).Rows(i).Item(6)) - ds.Tables(0).Rows(i).Item(17)

                    Next
                Next

                '========================================================
                Dim da1 As New OleDbDataAdapter("select * from table_name_co_tfrghh_sanwy ", con)



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
                gg = iteem


                xlWorkSheet.SaveAs((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
                xlWorkBook.Save()
                'xlWorkSheet.PrintPreview()
                xlWorkBook.Close()
                'xlApp.Quit()
                'releaseObject(xlApp)
                'releaseObject(xlWorkBook)
                'releaseObject(xlWorkSheet)

                'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
                Label9.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
                'RichTextBox1.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"

                ListBox1.Items.Add("كشف رقم : " + gg.ToString())
                Label2.Visible = False
                Label3.Visible = False
                ProgressBar1.Value = 0
                ds.Clear()
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                xlApp = Nothing
                xlWorkBook = Nothing
                xlWorkSheet = Nothing

                'If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                '    Process.Start((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
                'End If

            End If

        Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim selectedIndex As Integer
        '= ch_list_box.SelectedIndex


        If (selectedIndex <> -1) Then
6:
            For i As Integer = 0 To ch_list_box.Items.Count - 1
7:
                ' Get the selected item's check state.
8:
                Dim chkstate As CheckState
9:
                chkstate = ch_list_box.GetItemCheckState(i)
10:
                ' Toggle the item state.
11:
                If (chkstate = CheckState.Checked) Then
12:
                    chkstate = CheckState.Unchecked
13:
                Else
14:
                    chkstate = CheckState.Checked

                End If
16:
                ' Set the new state.
17:
                ch_list_box.SetItemCheckState(i, chkstate)
18:
            Next
19:
        End If


        'Next

    End Sub










    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label9.Text = ""
        If stat = "اعدادى" Then
            add_file()
            'For Each iteem As Integer In ch_list_box.CheckedItems




            '======================================================================================
            'Dim no_kkk As Integer = 0



            'no_kkk = iteem
            'If no_kkk > 0 Then

            'SelectAll_Table_mkf_no_kshf(no_kkk)
            'dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_no_kshff_pr
            'txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

            'Dim Id_Mkff As Integer
            'Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value

            'Id_Mkf.Value = Id_Mkff
            '    select_id_mkf(Id_Mkf.Value)
            '    DataGridView1.DataSource = dt_select_id_mkf
            '    Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
            '    Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
            '    Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
            '    term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
            '    no_kashf2.Value = dgv_Table_mkf_no_kshf.Rows(0).Cells("no_kshf").Value.ToString()
            '    Label8.Text = dgv_Table_mkf_no_kshf.RowCount().ToString()

            'Else
            '    no_kkk = 1

            'End If

            Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy,Entklat,Badl_safer,id,Id_Mkf,no_kshf,user_table.user_ful_name,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb from Table_mkf_add,user_table where Table_mkf_add.id_user=user_table.id_user", con)



            '=====================

            Cmd.Fill(ds)
            'Next

            '======================================================================================

            'add_file()
            Label3.Visible = True
            Label2.Visible = True
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            ''Dim inputFile As String = ("d:\page_tfrgh.xls")
            Dim inputFile As String = ((Application.StartupPath) & "\data_all.xlsx")
            'xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkBook = xlApp.Workbooks.Open(inputFile)

            xlWorkSheet = xlWorkBook.ActiveSheet

            xlWorkSheet.DisplayRightToLeft = True
            xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
            'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
            xlWorkSheet.Cells(3, 12) = term.Text
            xlWorkSheet.Cells(3, 18) = Years.Text

            'xlWorkSheet.Cells(2, 18) = iteem
            'xlWorkSheet.Cells(2, 17) = txt_name_user.Text



            'Dim no_kkk As Integer = 0



            'no_kkk = iteem

            For i = 0 To ds.Tables(0).Rows.Count - 1

                ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
                'ProgressBar1=====================
                ProgressBar1.Value = i
                Dim total_s As Double = 0
                total_s = (i * 1) / ds.Tables(0).Rows.Count - 1
                total_s = total_s * 100
                total_s = Math.Round(total_s, 0)

                Label3.Text = "%".ToString() + total_s.ToString()
                Label2.Text = "جارى التحميل 00000"
                Label2.Visible = False
                Label2.Visible = True

                '=====================================
                For j = 0 To ds.Tables(0).Columns.Count - 1
                    'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                    'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 5, j + 1) = ds.Tables(0).Rows(i).Item(j)
                    'Next
                Next
            Next

            '========================================================
            Dim da1 As New OleDbDataAdapter("select * from tabel_name_col_tfrgh   ", con)



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
            Dim gg_num As Integer = 0
            'gg = iteem
            'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")
            xlWorkSheet.SaveAs((Application.StartupPath) & "\كشف رقم " + gg_num.ToString() + ".xlsx ")
            xlWorkBook.Save()
            'xlWorkSheet.PrintPreview()
            xlWorkBook.Close()
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            ds.Clear()
            xlApp = Nothing
            xlWorkBook = Nothing
            xlWorkSheet = Nothing



            'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
            Label9.Text += " تم تصدير كشف رقم" + gg_num.ToString() + "-<>-"
            'RichTextBox1.Text += " تم تصدير كشف رقم" + gg_num.ToString() + "-<>-"

            ListBox1.Items.Add("كشف رقم : " + gg_num.ToString())
            Label2.Visible = False
            Label3.Visible = False
            ProgressBar1.Value = 0

            If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Process.Start((Application.StartupPath) & "\كشف رقم " + gg_num.ToString() + ".xlsx ")
            End If

        End If
        '======================================================================================
        '======================================================================================
        '
        If stat = "ثانوى" Then
            add_file()

            'For Each iteem As Integer In ch_list_box.CheckedItems

            'Dim no_kkk As Integer = 0



            'no_kkk = iteem
            'If no_kkk > 0 Then

            'SelectAll_Table_mkf_sanwy_no_kshf(no_kkk)
            'dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_sanwy_no_kshff
            'txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

            'Dim Id_Mkff As Integer
            'Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value
            'txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

            'Id_Mkf.Value = Id_Mkff
            'select_id_mkf(Id_Mkf.Value)
            'DataGridView1.DataSource = dt_select_id_mkf
            'Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
            'Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
            'Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
            'term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
            'no_kashf2.Value = dgv_Table_mkf_no_kshf.Rows(0).Cells("no_kshf").Value.ToString()
            'Label8.Text = dgv_Table_mkf_no_kshf.RowCount().ToString()

            'Else
            'no_kkk = 1

            'End If


            '======================================================================================



            Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,Entklat,Badl_safer,total,Darabb, Mashat,nkaba,Mashat8,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy_after_antkal,id,Id_Mkf,no_kshf,user_table.user_ful_name,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb  from Table_mkf_add,user_table where  Table_mkf_add.id_user=user_table.id_user ORDER BY Name_Emp", con)



            '=====================

            Cmd.Fill(ds)

            'Next
            '==============
            Label3.Visible = True
            Label2.Visible = True
            'Dim i As Integer
            'Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            Dim inputFile As String = ((Application.StartupPath) & "\data_all.xlsx")
            'xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkBook = xlApp.Workbooks.Open(inputFile)

            xlWorkSheet = xlWorkBook.ActiveSheet

            xlWorkSheet.DisplayRightToLeft = True
            '==================
            For h = 0 To ds.Tables(0).Rows.Count - 1

                ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
                'ProgressBar1=====================
                ProgressBar1.Value = h
                Dim total_s As Double = 0
                total_s = (h * 1) / ds.Tables(0).Rows.Count - 1
                total_s = total_s * 100
                total_s = Math.Round(total_s, 0)

                Label3.Text = "%".ToString() + total_s.ToString()
                Label2.Text = "جارى التحميل 00000"
                Label2.Visible = False
                Label2.Visible = True

                '=====================================
                For s = 0 To ds.Tables(0).Columns.Count - 1
                    'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                    'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(h + 5, s + 1) = ds.Tables(0).Rows(h).Item(s)
                    'Next
                Next
            Next


            '========================================================
            Dim da1 As New OleDbDataAdapter("select * from table_name_co_tfrghh_sanwy ", con)



            Dim ds1 As New DataSet

            ds1.Tables.Add("st")
            da1.Fill(ds1, "st")

            DataGridView2.DataSource = ds1.Tables(0)

            'da2.Fill(ds2)
            'DataGridView1.DataSource = ds2.Tables(0)

            For m = 0 To ds1.Tables(0).Rows.Count - 1



                For k As Integer = 0 To ds1.Tables(0).Columns.Count - 1


                    xlWorkSheet.Cells(4, m + 1) = ds1.Tables(0).Rows(m).Item(1)




                Next

            Next




            'add_file()

            'xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
            'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
            'xlWorkSheet.Cells(3, 12) = term.Text
            'xlWorkSheet.Cells(3, 14) = Years.Text

            'xlWorkSheet.Cells(2, 17) = iteem
            'xlWorkSheet.Cells(2, 19) = txt_name_user.Text
            'ProgressBar1.Maximum = dgv_Table_mkf_no_kshf.RowCount
            'Dim no_kkk As Integer = 0



            'no_kkk = iteem

            '===========================================================
            Dim gg As Integer = 0
            'gg = iteem
            xlWorkSheet.SaveAs((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
            xlWorkBook.Save()
            'xlWorkSheet.PrintPreview()
            xlWorkBook.Close()
            'xlApp.Quit()
            'releaseObject(xlApp)
            'releaseObject(xlWorkBook)
            'releaseObject(xlWorkSheet)

            'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
            Label9.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
            'RichTextBox1.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"

            ListBox1.Items.Add("كشف رقم : " + gg.ToString())
            Label2.Visible = False
            Label3.Visible = False
            ProgressBar1.Value = 0
            ds.Clear()
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
            xlApp = Nothing
            xlWorkBook = Nothing
            xlWorkSheet = Nothing

            If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Process.Start((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
            End If


        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim dt_no_kshf As New DataTable
        Dim da As New OleDbDataAdapter
        dt_no_kshf.Clear()
        da = New OleDbDataAdapter("select DISTINCT no_kshf from Table_mkf_add", con)
        da.Fill(dt_no_kshf)
        If dt_no_kshf.Rows.Count > 0 Then
            ch_list_box.DataSource = dt_no_kshf
            ch_list_box.DisplayMember = "no_kshf"


            ch_list_box.ValueMember = "no_kshf"
        Else
            ch_list_box.DataSource = Nothing
        End If
        ''ch_list_box.Items.Add(no_kshf.SelectedValue)
        ''MessageBox.Show("لم يتم برمجه بعد")
        'For i As Integer = 0 To no_kshf.Items.Count - 1

        '    MessageBox.Show(no_kshf.Items(i).ToString())
        '    'ch_list_box.Items.AddRange(no_kshf.Items(i))

        'Next i
        '========================================================================
        ''Try
        'Dim MyArray(no_kshf.Items.Count - 1) As String

        'no_kshf.Items.CopyTo(MyArray, 0)

        ''Array.Sort(MyArray)
        'MessageBox.Show(MyArray.ToString())
        'For i As Integer = 0 To no_kshf.Items.Count - 1

        '    ch_list_box.Items.Add(MyArray(i))
        'Next i
        '============================
        Dim selectedIndex As Integer
        '= ch_list_box.SelectedIndex


        If (selectedIndex <> -1) Then
6:
            For i As Integer = 0 To ch_list_box.Items.Count - 1
7:
                ' Get the selected item's check state.
8:
                Dim chkstate As CheckState
9:
                chkstate = ch_list_box.GetItemCheckState(i)
10:
                ' Toggle the item state.
11:
                If (chkstate = CheckState.Checked) Then
12:
                    chkstate = CheckState.Unchecked
13:
                Else
14:
                    chkstate = CheckState.Checked

                End If
16:
                ' Set the new state.
17:
                ch_list_box.SetItemCheckState(i, chkstate)
18:
            Next
19:
        End If


        '==============================
        'Dim MyArray2(ch_list_box.Items.Count - 1) As String

        'listBox1.Items.CopyTo(MyArray, 0)

        'Array.Sort(MyArray2)

        'Catch ex As Exception

        'End Try


    End Sub

    Private Sub no_kshf_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_kshf_list_box.SelectedIndexChanged
        Try
            If stat = "اعدادى" Then
                Dim no_kkk As Integer = 0



                no_kkk = no_kshf_list_box.SelectedValue
                If no_kkk >= 0 Then

                    SelectAll_Table_mkf_no_kshf(no_kkk)
                    dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_no_kshff_pr
                    txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

                    Dim Id_Mkff As Integer
                    Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value

                    Id_Mkf.Value = Id_Mkff
                    select_id_mkf(Id_Mkf.Value)
                    DataGridView1.DataSource = dt_select_id_mkf
                    Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                    term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
                    no_kashf2.Value = dgv_Table_mkf_no_kshf.Rows(0).Cells("no_kshf").Value.ToString()
                    Label8.Text = dgv_Table_mkf_no_kshf.RowCount().ToString()

                Else
                    no_kkk = 1

                End If
                'تفقيط الارقام
                '=======================
                total_saffy_adayed()
                txtNumber.Text = NumericUpDown3.Value.ToString()
            Else
                stat = "ثانوى"
                Dim no_kk As Integer = 0
                no_kk = no_kshf_list_box.SelectedValue
                If no_kk >= 0 Then

                    SelectAll_Table_mkf_sanwy_no_kshf(no_kk)
                    dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_sanwy_no_kshff
                    txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

                    Dim Id_Mkff As Integer
                    Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value

                    Id_Mkf.Value = Id_Mkff
                    select_id_mkf(Id_Mkf.Value)
                    DataGridView1.DataSource = dt_select_id_mkf
                    Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                    term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
                    no_kashf2.Value = dgv_Table_mkf_no_kshf.Rows(0).Cells("no_kshf").Value.ToString()
                    Label8.Text = dgv_Table_mkf_no_kshf.RowCount().ToString()

                Else
                    no_kk = 1

                End If
            End If
            'تفقيط الارقام
            '=======================
            total_saffy_sanwy()
            txtNumber.Text = NumericUpDown3.Value.ToString()

        Catch
            Dim no_kk As Integer = 1
        End Try

    End Sub





    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown3.ValueChanged
        Try
            If stat = "اعدادى" Then

                total_saffy_adayed()

                Dim toWord As New NumberToWord.ToWord(Convert.ToDecimal(NumericUpDown3.Value), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
                txtEnglishWord.Text = toWord.ConvertToEnglish()
                txtArabicWord.Text = toWord.ConvertToArabic()
            Else
                stat = "ثانوى"

                total_saffy_sanwy()

                Dim toWord As New NumberToWord.ToWord(Convert.ToDecimal(NumericUpDown3.Value), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
                txtEnglishWord.Text = toWord.ConvertToEnglish()
                txtArabicWord.Text = toWord.ConvertToArabic()
            End If
        Catch ex As Exception
            txtEnglishWord.Text = String.Empty
            txtArabicWord.Text = String.Empty

        End Try

    End Sub

    '=====================================================================
    Private currencies As New List(Of CurrencyInfo)()
    'Public Sub New()
    '    InitializeComponent()
    'End Sub

    Private Sub number_to_word_UserControl1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia))
        currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.UAE))
        currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia))
        currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.Tunisia))
        currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.Gold))

        cboCurrency.DataSource = currencies


        cboCurrency_DropDownClosed(Nothing, Nothing)
        txtNumber.Text = NumericUpDown3.Value.ToString()
    End Sub
    Private Sub cboCurrency_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
        txtNumber_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub txtNumber_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim toWord As New NumberToWord.ToWord(Convert.ToDecimal(txtNumber.Text), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
            txtEnglishWord.Text = toWord.ConvertToEnglish()
            txtArabicWord.Text = toWord.ConvertToArabic()
        Catch ex As Exception
            txtEnglishWord.Text = String.Empty
            txtArabicWord.Text = String.Empty
        End Try
    End Sub



    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            txtNumber.Visible = True
        Else
            txtNumber.Visible = False
        End If
    End Sub



    Private Sub txtNumber_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumber.TextChanged
        Try
            Dim toWord As New NumberToWord.ToWord(Convert.ToDecimal(txtNumber.Text), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
            txtEnglishWord.Text = toWord.ConvertToEnglish()
            txtArabicWord.Text = toWord.ConvertToArabic()
        Catch ex As Exception

            txtEnglishWord.Text = String.Empty
            txtArabicWord.Text = String.Empty
        End Try

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'عرض العمود رقم 21
        If dgv_Table_mkf_no_kshf.Rows.Count > 0 Then

            dgv_Table_mkf_no_kshf.Rows(dgv_Table_mkf_no_kshf.RowCount - 1).Cells(20).Selected = True

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ch_list_box.DataSource = Nothing
        ch_list_box.Items.Remove(ch_list_box.SelectedItem)
        CheckBox1.Checked = False
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ch_list_box.DataSource = Nothing
        ch_list_box.Items.Add(no_kshf_list_box.SelectedValue)

        CheckBox1.Checked = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Label9.Text = ""
        ds.Clear()
        Try

            If stat = "اعدادى" Then
                'For Each iteem As Integer In ch_list_box.CheckedItems


                'Dim no_kkk As Integer = 0

                'no_kkk = iteem

                Dim Cmd As New OleDbDataAdapter("select id_no,op_name_pay,op_al_kta,Name_school,op_no_emb , Name_Emp,Saffy,Entklat,Badl_safer,no_kshf from Table_mkf_add ", con)

                Cmd.Fill(ds)

                'Next
                '======================================================================================



                add_file()
                Label3.Visible = True
                Label2.Visible = True
                'Dim i As Integer
                'Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                Dim inputFile As String = ((Application.StartupPath) & "\Pay-krke_george-20190618-100047.xlsx")
                'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                xlWorkBook = xlApp.Workbooks.Open(inputFile)

                xlWorkSheet = xlWorkBook.ActiveSheet

                xlWorkSheet.DisplayRightToLeft = True
                'xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                ''
                'xlWorkSheet.Cells(3, 12) = term.Text
                'xlWorkSheet.Cells(3, 18) = Years.Text
                'xlWorkSheet.Cells(2, 17) = Item_Mkf.Text
                'xlWorkSheet.Cells(2, 18) = iteem



                '========================================================


                For x = 0 To ds.Tables(0).Rows.Count - 1

                    ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
                    'ProgressBar1=====================
                    ProgressBar1.Value = x
                    Dim total_s As Double = 0
                    total_s = (x * 1) / ds.Tables(0).Rows.Count - 1
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()
                    Label2.Text = "جارى التحميل 00000"
                    Label2.Visible = False
                    Label2.Visible = True

                    '=====================================
                    For j = 0 To ds.Tables(0).Columns.Count - 1
                        'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                        'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(x + 2, j + 1) = ds.Tables(0).Rows(x).Item(j)
                        'Next
                    Next

                Next


                '===========================================================
                Dim gg As String
                gg = "Pay-krke_george-20190618-100047" + no_kashf2.Value.ToString()
                'xlWorkSheet.SaveAs("D:\" + gg + ".xlsx ")
                xlWorkSheet.SaveAs((Application.StartupPath) & "\" + gg + ".xlsx ")

                xlWorkBook.Save()
                'xlWorkSheet.PrintPreview()
                xlWorkBook.Close()

                '=========================
                Dim st As String
                st = (ds.Tables(0).Rows.Count).ToString()
                Label9.Text += st + "عدد"
                '======================
                'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
                Label9.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
                Label2.Visible = False
                Label3.Visible = False
                ProgressBar1.Value = 0
                ds.Clear()
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                xlApp = Nothing
                xlWorkBook = Nothing
                xlWorkSheet = Nothing

                If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Process.Start((Application.StartupPath) & "\" + gg + ".xlsx ")
                End If

            Else
                'For Each iteem As Integer In ch_list_box.CheckedItems


                'Dim no_kkk As Integer = 0

                'no_kkk = iteem

                Dim Cmd As New OleDbDataAdapter("select  id_no,op_name_pay,op_al_kta,Name_school,op_no_emb , Name_Emp,Saffy,Entklat,Badl_safer,no_kshf from Table_mkf_add  ORDER BY no_kshf,Name_Emp", con)

                Cmd.Fill(ds)

                'Next
                '======================================================================================



                add_file()
                Label3.Visible = True
                Label2.Visible = True
                'Dim i As Integer
                'Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                Dim inputFile As String = ((Application.StartupPath) & "\Pay-krke_george-20190618-100047.xlsx")
                'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                xlWorkBook = xlApp.Workbooks.Open(inputFile)

                xlWorkSheet = xlWorkBook.ActiveSheet

                xlWorkSheet.DisplayRightToLeft = True
                'xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                ''
                'xlWorkSheet.Cells(3, 12) = term.Text
                'xlWorkSheet.Cells(3, 18) = Years.Text
                'xlWorkSheet.Cells(2, 17) = Item_Mkf.Text
                'xlWorkSheet.Cells(2, 18) = iteem



                '========================================================


                For x = 0 To ds.Tables(0).Rows.Count - 1

                    ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
                    'ProgressBar1=====================
                    ProgressBar1.Value = x
                    Dim total_s As Double = 0
                    total_s = (x * 1) / ds.Tables(0).Rows.Count - 1
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()
                    Label2.Text = "جارى التحميل 00000"
                    Label2.Visible = False
                    Label2.Visible = True

                    '=====================================
                    For j = 0 To ds.Tables(0).Columns.Count - 1
                        'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                        'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(x + 2, j + 1) = ds.Tables(0).Rows(x).Item(j)
                        'Next
                    Next

                Next


                '===========================================================
                Dim gg As String
                gg = "Pay-krke_george-20190618-100047" + no_kashf2.Value.ToString()
                'xlWorkSheet.SaveAs("D:\" + gg + ".xlsx ")
                xlWorkSheet.SaveAs((Application.StartupPath) & "\" + gg + ".xlsx ")
                xlWorkBook.Save()
                'xlWorkSheet.PrintPreview()
                xlWorkBook.Close()

                '=========================
                Dim st As String
                st = (ds.Tables(0).Rows.Count).ToString()
                Label9.Text += st + "عدد"
                '======================
                'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
                Label9.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
                Label2.Visible = False
                Label3.Visible = False
                ProgressBar1.Value = 0
                ds.Clear()
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                xlApp = Nothing
                xlWorkBook = Nothing
                xlWorkSheet = Nothing

                If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Process.Start((Application.StartupPath) & "\" + gg + ".xlsx ")
                End If
            End If
        Catch ex As Exception
        Finally
            'MessageBox.Show("erro")
        End Try

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        search_tafrgh.Show()
    End Sub




    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If BackgroundWorker1.IsBusy Then
            'Label3.Text = "جارى التعديل 000"

        Else
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub


    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Label3.Invoke(Sub() Label3.Text = "..... جارى التعديل")
            SelectAll_Table_mkf_all_data()
            auto_all_salary_ass()

            'dt_Table_mkf_all_data
            'dt_all_salary_ass
            Dim id_no As String
            'Dim date_1 As Date
            'Dim drab As Integer
            Dim mkf As Double
            Dim dt_all_salary_ass As New DataTable
            If dt_Table_mkf_all_data.Rows.Count() > 0 Then

                For i = 0 To dt_Table_mkf_all_data.Rows.Count - 1
                    id_no = (dt_Table_mkf_all_data.Rows(i)("id_no")).ToString()

                    dt_all_salary_ass.Clear()
                    Dim da1 As New OleDbDataAdapter("SELECT Table_mkf_add.Mkf, Table_mkf_add.Name_Emp, Table_mkf_add.id_no, salary_ass.Drab FROM Table_mkf_add INNER JOIN salary_ass ON Table_mkf_add.id_no = salary_ass.id_no WHERE Table_mkf_add.id_no='" & id_no & "' and salary_ass.Drab =5", con)
                    'Dim ds As New DataSet
                    'Cmd1.Fill(ds)
                    da1.Fill(dt_all_salary_ass)
                    If (dt_all_salary_ass.Rows().Count()) > 0 Then

                        mkf = (dt_all_salary_ass.Rows(0)("Mkf"))
                        'MessageBox.Show(mkf)
                        Dim drab_N As Double = 0
                        drab_N = (mkf * 5) / 100
                        'MessageBox.Show(drab_N)
                        id_no = (dt_all_salary_ass.Rows(0)("id_no")).ToString()

                        Update_Drab_all(id_no, drab_N)

                        Dim name_Emp As String

                        name_Emp = (dt_all_salary_ass.Rows(0)("Name_Emp")).ToString()
                        ListBox1.Invoke(Sub() ListBox1.Items.Add(name_Emp))

                    End If

                Next

                MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
                con.Close()
                Label3.Invoke(Sub() Label3.Text = "تم التعديل")
                'Cmd = Nothing

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Try





            If stat = "اعدادى" Then



                Dim no_kkk As Integer = 0



                'no_kkk = no_kshf.SelectedValue
                'تفقيط الارقام
                '=======================
                total_saffy_adayed()
                txtNumber.Text = NumericUpDown3.Value.ToString()
                '======================================================================================
                add_file()
                Label3.Visible = True
                Label2.Visible = True
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                'Dim inputFile As String = ("d:\page_tfrgh.xls")
                Dim inputFile As String = ((Application.StartupPath) & "\all_tafrgh.xlsx")

                'xlWorkSheet = xlWorkBook.Sheets("sheet1")
                xlWorkBook = xlApp.Workbooks.Open(inputFile)

                xlWorkSheet = xlWorkBook.ActiveSheet

                xlWorkSheet.DisplayRightToLeft = True
                xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
                'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
                xlWorkSheet.Cells(3, 12) = term.Text
                xlWorkSheet.Cells(3, 16) = Years.Text

                xlWorkSheet.Cells(2, 17) = Item_Mkf.Text

                xlWorkSheet.Cells(3, 18) = no_kashf2.Value
                xlWorkSheet.Cells(3, 17) = txt_name_user.Text
                xlWorkSheet.Cells(25, 4) = txtArabicWord.Text
                ProgressBar1.Maximum = dgv_Table_mkf_no_kshf.RowCount


                Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy,Entklat,Badl_safer,id,Id_Mkf,no_kshf,user_table.user_ful_name,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb from Table_mkf_add,user_table where Table_mkf_add.id_user=user_table.id_user", con)


                '=====================
                Dim ds As New DataSet
                Cmd.Fill(ds)

                For i = 0 To ds.Tables(0).Rows.Count - 1



                    'ProgressBar1=====================
                    'ProgressBar1.Value = i
                    'lbl_num.Text = i.ToString()
                    Dim total_s As Double = 0
                    total_s = (i * 1) / ds.Tables(0).Rows.Count - 1
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()
                    Label2.Text = "جارى التحميل 00000"
                    Label2.Visible = False
                    Label2.Visible = True

                    '=====================================
                    For j = 0 To ds.Tables(0).Columns.Count - 1

                        xlWorkSheet.Cells(i + 5, j + 1) = ds.Tables(0).Rows(i).Item(j)

                        '=============تجميع المستقطع ============
                        Dim drab_t, mas_t_9, mahn_t_2, m_1_t, m1_t, m_t_1, damgh_t, eradat_t, box_t As String
                        drab_t = "i" + (5 + i).ToString()
                        mas_t_9 = "g" + (5 + i).ToString()
                        mahn_t_2 = "j" + (5 + i).ToString()
                        m_1_t = "h" + (5 + i).ToString()
                        m1_t = "k" + (5 + i).ToString()
                        m_t_1 = "l" + (5 + i).ToString()
                        damgh_t = "m" + (5 + i).ToString()
                        eradat_t = "n" + (5 + i).ToString()
                        box_t = "o" + (5 + i).ToString()
                        xlWorkSheet.Cells(i + 5, 16) = "=(" + drab_t + "+" + mas_t_9 + "+" + mahn_t_2 + "+" + m_1_t + "+" + m1_t + "+" + m_t_1 + "+" + damgh_t + "+" + eradat_t + "+" + box_t + ")"
                        'xlWorkSheet.Cells(i + 5, 16) = ds.Tables(0).Rows(i).Item(6) + ds.Tables(0).Rows(i).Item(7) +
                        '    ds.Tables(0).Rows(i).Item(8) + ds.Tables(0).Rows(i).Item(9) +
                        '    ds.Tables(0).Rows(i).Item(10) + ds.Tables(0).Rows(i).Item(11) +
                        '    ds.Tables(0).Rows(i).Item(12) + ds.Tables(0).Rows(i).Item(13) +
                        '     ds.Tables(0).Rows(i).Item(14)
                        '=======================تجميع الصافى ======================
                        Dim num_row As String
                        Dim num_col As String
                        '(f-p)
                        num_row = "f" + (5 + i).ToString()
                        num_col = "p" + (5 + i).ToString()


                        xlWorkSheet.Cells(i + 5, 19) = "=(" + num_row + "-" + num_col + ")"


                    Next

                Next


                '========================================================
                Dim da1 As New OleDbDataAdapter("select * from tabel_name_col_tfrgh ", con)



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
                '===============================




                '===========================================================
                Dim gg As Integer = 0
                gg = no_kshf_list_box.SelectedValue
                'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")
                xlWorkSheet.SaveAs((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")

                xlWorkBook.Save()
                'xlWorkSheet.PrintPreview()
                xlWorkBook.Close()

                MsgBox("تم الحفظ بنجاح فى \كشف رقم " + gg.ToString())
                ListBox1.Items.Add("كشف رقم : " + gg.ToString())
                Label2.Visible = False
                Label3.Visible = False
                ProgressBar1.Value = 0
                ds.Clear()
                xlApp.Quit()
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet)
                xlApp = Nothing
                xlWorkBook = Nothing
                xlWorkSheet = Nothing

                If MessageBox.Show("هل تريد فتح الملف ", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Process.Start((Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
                End If
                'ط===================================================================================================
                '=================================================ثانوى==========================================================================
                '=========================================================================================

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            '====كود غلق برنامج اكسيل 
            Dim Pro() As Process = System.Diagnostics.Process.GetProcessesByName("excel")
            For Each Y As Process In Pro
                Y.Kill()
            Next
            ''=============================
        End Try
    End Sub

   

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Try

       
        For Each iteem As Integer In no_kshf_list_box.Items
            ch_list_box.DataSource = Nothing
            ch_list_box.Items.Add(iteem)

            CheckBox1.Checked = True

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Update_TMzay(0)
        If stat = "اعدادى" Then
            no_k = Max_no_kshf()

            'SelectSome_Table_mkf_add_indirect(ch_list_box)

            SelectSome_Table_mkf_add_indirect(no_kshf_list_box)
            SelectAll_Table_mkf_no_kshf(no_k)
            dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_no_kshff_pr
            DataGridViewHeaderText_no_kshf(dgv_Table_mkf_no_kshf)

            no_kshf_list_box.SelectedValue = no_k
            Label8.Text = dgv_Table_mkf_no_kshf.Rows.Count.ToString()
            '=======================================

            '==================

        Else
            no_k = Max_no_kshf()

            SelectSome_Table_mkf_add_indirect(no_kshf_list_box)


            SelectAll_Table_mkf_sanwy_no_kshf(no_k)
            dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_sanwy_no_kshff
            DataGridViewHeaderText_no_kshf_sanwy(dgv_Table_mkf_no_kshf)

            no_kshf_list_box.SelectedValue = no_k

            '================
            total_saffy_sanwy()
            Label8.Text = dgv_Table_mkf_no_kshf.Rows.Count.ToString()
            '====================

            '================================================

        End If
    End Sub
End Class