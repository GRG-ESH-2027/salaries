Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel

Public Class Form_update_emp
    Public dt_auto_no_emp As New System.Data.DataTable
    Public dt_excel As New System.Data.DataTable
    Private Sub open_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_file.Click
        Dim source_path, destpasth As String
        Dim ofd As New OpenFileDialog



        destpasth = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

        ofd.Filter = "Excel xls |*.xls ;*.xlsx"
        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            source_path = ofd.FileName
            name_adderss.Text = source_path
            dt_gp_table.Clear()


            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;  Data Source=" + ofd.FileName + "; Extended properties=Excel 12.0;")
            Dim dt_excel As New System.Data.DataTable
            dt_excel.Clear()
            Dim cmd As New OleDbCommand("select * from [Sheet1$]", con)
            'Dim cmd As New OleDbDataAdapter("select * from [Sheet1$]", con)

            con.Open()
            dt_excel.Load(cmd.ExecuteReader)
            '=====================


            '"=================================
            con.Close()
            dgv_emp.DataSource = dt_excel

            btn_selcet_data.Visible = True
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selcet_data.Click
        If BackgroundWorker1.IsBusy Then
            Label7.Text = "جارى التحميل 000"

        Else
            BackgroundWorker1.RunWorkerAsync()

        End If


    End Sub

    Private Sub update_data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_data.Click
        'MessageBox.Show(dgv_emp.Rows(2).Cells(1).Value.ToString())
        'dgv_emp.Rows(2).Cells("Column1").Value = True
        ProgressBar1.Maximum = dgv_emp.RowCount
        For i As Integer = dgv_emp.RowCount - 1 To 0 Step -1
            'ProgressBar1=====================
            ProgressBar1.Value = i
            Dim total_s As Double = 0
            total_s = (i * 1) / 200
            total_s = total_s * 100
            total_s = Math.Round(total_s, 0)

            Label6.Text = total_s.ToString() + "%".ToString()
            Label7.Text = "جارى التحميل 00000"
            Label6.Visible = True
            Label7.Visible = True

            '=====================================

            Dim delete As Boolean
            delete = dgv_emp.Rows(i).Cells("Column1").Value

            If delete = True Then
                Dim row As DataGridViewRow
                row = dgv_emp.Rows(i)
                'dgv_emp.Rows(i).Cells("Column2").Value = "Yes"

                'dgv_emp.Rows.RemoveAt(Convert.ToInt32(dgv_emp.Rows(i).Index))
                dgv_emp.Rows.RemoveAt(i)
                'MessageBox.Show(dgv_emp.Rows(i).Index)


            End If
            'dgv_emp.Rows.RemoveAt(dgv_emp.Rows(i).Index)
        Next
        'Btn_add.Visible = True
        btn_delete_data.Visible = False
        'dgv_emp.Rows.RemoveAt(Convert.ToInt32(dgv_emp.Rows(i).Index))

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Try
            If dgv_emp.Rows.Count > 0 Then
                For i = 0 To dgv_emp.RowCount - 1
                    'Insert_emp(id_no.Text,name_pay.Text,al_kta.Text,school.Text,no_emb.Text,name_emp.Text,hh.Text)

                    Insert_emp(dgv_emp.Rows(i).Cells(1).Value.ToString(), dgv_emp.Rows(i).Cells(2).Value.ToString(), dgv_emp.Rows(i).Cells(3).Value.ToString(), dgv_emp.Rows(i).Cells(4).Value.ToString(), dgv_emp.Rows(i).Cells(5).Value.ToString(), dgv_emp.Rows(i).Cells(6).Value.ToString(), dgv_emp.Rows(i).Cells(7).Value.ToString())

                Next
                MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")

                dt_auto_no_emp.Clear()
                dgv_emp.Refresh()
                Btn_add.Visible = False
            Else
                MsgBox("لا يوجد بيانات كى تضاف", MsgBoxStyle.Information, "تنبيه")
            End If
        Catch ex As Exception

        End Try
    End Sub


    'delete _all_tfrgh


    '===========================================

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim total_row As Integer = 0
        Dim start As Integer = 0
        Dim end_list As Integer = 1

        total_row = dgv_emp.Rows.Count
        start = total_row - total_row
        ProgressBar1.Invoke(Sub() ProgressBar1.Maximum = 200)

        If dgv_emp.Rows.Count < 200 Then

            ' ضبط قيمة الـ Maximum مرة واحدة
            ProgressBar1.Invoke(Sub() ProgressBar1.Maximum = dgv_emp.Rows.Count)

            For i = 0 To dgv_emp.Rows.Count - 1
                Dim rowIndex As Integer = i   ' نسخة محلية من i

                ' تحديث الـ ProgressBar
                ProgressBar1.Invoke(Sub() ProgressBar1.Value = rowIndex + 1)

                ' حساب النسبة المئوية بشكل صحيح
                Dim total_s As Double = Math.Round(((rowIndex + 1) * 100.0) / dgv_emp.Rows.Count, 0)

                Label6.Invoke(Sub() Label6.Text = "%" & total_s.ToString())
                Label7.Invoke(Sub() Label7.Text = "جارى التحميل...")
                Label6.Invoke(Sub() Label6.Visible = True)
                Label7.Invoke(Sub() Label7.Visible = True)

                ' جلب البيانات من قاعدة البيانات
                dt_auto_no_emp.Clear()
                Dim id_no As String = dgv_emp.Rows(rowIndex).Cells(1).Value.ToString()
                Using da As New OleDbDataAdapter("SELECT * FROM emp WHERE id_no = '" & id_no & "'", con)
                    da.Fill(dt_auto_no_emp)
                End Using

                ' تحديث الخلية حسب وجود بيانات
                If dt_auto_no_emp.Rows.Count > 0 Then
                    dgv_emp.Invoke(Sub() dgv_emp.Rows(rowIndex).Cells("Column1").Value = True)
                Else
                    btn_delete_data.Invoke(Sub() Btn_add.Visible = True)
                End If
            Next



            ''===حذف البيانات  المكرر=====================================
            'For z As Integer = dgv_emp.RowCount - 1 To 0 Step -1
            '    Dim delete As Boolean
            '    delete = dgv_emp.Rows(z).Cells("Column1").Value

            '    If delete = True Then
            '        Dim row As DataGridViewRow
            '        row = dgv_emp.Rows(z)


            '        dgv_emp.Rows.RemoveAt(z)



            '    End If

            'Next
            '==========================================================================
            btn_delete_data.Invoke(Sub() btn_delete_data.Visible = True)
        Else

            start = total_row - total_row

            Dim tot_row As Integer

            tot_row = dgv_emp.Rows.Count - 2

            end_list = tot_row - 200


            ' ضبط قيمة الـ Maximum مرة واحدة
            ProgressBar1.Invoke(Sub() ProgressBar1.Maximum = dgv_emp.Rows.Count)

            For i = 0 To dgv_emp.Rows.Count - end_list
                Dim rowIndex As Integer = i   ' نسخة محلية من i

                Dim da As New OleDbDataAdapter("SELECT * FROM emp WHERE id_no = '" & dgv_emp.Rows(rowIndex).Cells(1).Value.ToString() & "'", con)
                dt_auto_no_emp.Clear()
                da.Fill(dt_auto_no_emp)

                If dt_auto_no_emp.Rows.Count > 0 Then
                    dgv_emp.Invoke(Sub() dgv_emp.Rows(rowIndex).Cells("Column1").Value = True)
                End If

                'ProgressBar1=====================
                ProgressBar1.Invoke(Sub() ProgressBar1.Value = rowIndex + 1)

                Dim total_s As Double = Math.Round(((rowIndex + 1) * 100.0) / dgv_emp.Rows.Count, 0)

                Label6.Invoke(Sub() Label6.Text = total_s.ToString() & "%")
                Label7.Invoke(Sub() Label7.Text = "جارى التحميل...")
                Label6.Invoke(Sub() Label6.Visible = True)
                Label7.Invoke(Sub() Label7.Visible = True)
            Next




            MessageBox.Show(end_list)
            If end_list < 200 Then
                end_list = total_row - 200
                start = start + 200
            Else
                end_list = total_row
                start = start + 200
            End If




        End If

        btn_delete_data.Invoke(Sub() btn_delete_data.Visible = True)
        'Button1.Visible = False

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim source_path, destpasth As String
        Dim ofd As New OpenFileDialog



        destpasth = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

        ofd.Filter = "Excel xls |*.xls ;*.xlsx"
        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            source_path = ofd.FileName
            name_adderss.Text = source_path
            dt_gp_table.Clear()


            Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;  Data Source=" + ofd.FileName + "; Extended properties=Excel 12.0;")
            Dim dt_excel As New System.Data.DataTable
            dt_excel.Clear()
            Dim cmd1 As New OleDbCommand("select * from [Sheet1$]", con)
            Dim cmd As New OleDbDataAdapter("select * from [Sheet1$]", con)

            con.Open()
            dt_excel.Load(cmd1.ExecuteReader)
            dgv_emp.DataSource = dt_excel
            '=====================
            Dim ds As New DataSet

            cmd.Fill(ds)
            For i = 0 To ds.Tables(0).Rows.Count - 1


                'For j = 0 To ds.Tables(0).Columns.Count - 1

                'xlWorkSheet.Cells(i + 5, j + 1) = ds.Tables(0).Rows(i).Item(j)
                Insert_emp(ds.Tables(0).Rows(i).Item(0).ToString(), ds.Tables(0).Rows(i).Item(1).ToString(), ds.Tables(0).Rows(i).Item(2).ToString(), ds.Tables(0).Rows(i).Item(3).ToString(), ds.Tables(0).Rows(i).Item(4).ToString(), ds.Tables(0).Rows(i).Item(5).ToString(), ds.Tables(0).Rows(i).Item(6).ToString())

            Next
            'Next
            '"=================================
            con.Close()


            'btn_selcet_data.Visible = True
            MessageBox.Show("update sucess")
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            delete_all_emp()
        End If



        Button1.Visible = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        add_file()
        'Label3.Visible = True
        'Label2.Visible = True
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        ''Dim inputFile As String = ("d:\page_tfrgh.xls")
        Dim inputFile As String = ((System.Windows.Forms.Application.StartupPath) & "\data_all.xlsx")
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkBook = xlApp.Workbooks.Open(inputFile)

        xlWorkSheet = xlWorkBook.ActiveSheet

        xlWorkSheet.DisplayRightToLeft = True
        'xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
        'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
        'xlWorkSheet.Cells(3, 12) = term.Text
        'xlWorkSheet.Cells(3, 18) = Years.Text

        'xlWorkSheet.Cells(2, 18) = iteem
        'xlWorkSheet.Cells(2, 17) = txt_name_user.Text



        'Dim no_kkk As Integer = 0



        'no_kkk = iteem
        Dim cmd As New OleDbDataAdapter("select * from [Sheet1$]", con)
        'Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy,Entklat,Badl_safer,id,Id_Mkf,no_kshf,op_id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb,user_table.user_name from Table_mkf_add,user_table where Table_mkf_add.id_user=user_table.id_user", con)



        '=====================
        Dim ds As New DataSet
        cmd.Fill(ds)

        For i = 0 To ds.Tables(0).Rows.Count - 1

            ProgressBar1.Maximum = ds.Tables(0).Rows.Count - 1
            'ProgressBar1=====================
            ProgressBar1.Value = i
            Dim total_s As Double = 0
            total_s = (i * 1) / ds.Tables(0).Rows.Count - 1
            total_s = total_s * 100
            total_s = Math.Round(total_s, 0)

            Label6.Text = "%".ToString() + total_s.ToString()
            Label7.Text = "جارى التحميل 00000"
            'Label2.Visible = False
            'Label2.Visible = True

            '=====================================
            For j = 0 To ds.Tables(0).Columns.Count - 1
                'For k As Integer = 1 To dgv_Table_mkf_no_kshf.Columns.Count - 4
                'xlWorkSheet.Cells(3, k) = dgv_Table_mkf_no_kshf.Columns(k - 1).HeaderText
                xlWorkSheet.Cells(i + 5, j + 1) = ds.Tables(0).Rows(i).Item(j)
                'Next
            Next
        Next

        '========================================================
        'Dim da1 As New OleDbDataAdapter("select * from tabel_name_col_tfrgh   ", con)



        'Dim ds1 As New DataSet

        'ds1.Tables.Add("st")
        'da1.Fill(ds1, "st")

        'dgv_emp.DataSource = ds1.Tables(0)

        'da2.Fill(ds2)
        'DataGridView1.DataSource = ds2.Tables(0)

        'For i = 0 To ds1.Tables(0).Rows.Count - 1



        'For m As Integer = 0 To ds1.Tables(0).Columns.Count - 1


        'xlWorkSheet.Cells(4, i + 1) = ds1.Tables(0).Rows(i).Item(1)




        'Next

        'Next




        '===========================================================
        Dim gg As Integer = 0
        'gg = iteem
        'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")
        xlWorkSheet.SaveAs((System.Windows.Forms.Application.StartupPath) & "\كشف رقم " + gg.ToString() + ".xlsx ")
        xlWorkBook.Save()
        'xlWorkSheet.PrintPreview()
        xlWorkBook.Close()
        'xlApp.Quit()
        'releaseObject(xlApp)
        'releaseObject(xlWorkBook)
        'releaseObject(xlWorkSheet)

        'MsgBox("تم الحفظ بنجاح فى D:\كشف رقم " + gg.ToString())
        Label7.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
        'RichTextBox1.Text += " تم تصدير كشف رقم" + gg.ToString() + "-<>-"
        'Label2.Visible = False
        'Label3.Visible = False
        ProgressBar1.Value = 0
    End Sub
    Public Sub dgv_ExportDataToExcelFile(ByVal dgv As DataGridView)
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("ar-SA")
        Dim SFD As New SaveFileDialog
        Dim exlapp As New Application
        Dim exlworkbook As Workbook
        Dim exlworksheet As Worksheet
        Dim misvalue As Object = System.Reflection.Missing.Value
        exlworkbook = exlapp.Workbooks.Add(misvalue)
        exlworksheet = exlworkbook.Sheets(1)
        exlworksheet.DisplayRightToLeft = True
        For colhead As Integer = 0 To dgv.ColumnCount - 1
            exlworksheet.Cells(1, colhead + 1) = dgv.Columns(colhead).HeaderText
        Next
        For i As Integer = 0 To dgv.RowCount - 1
            For j As Integer = 0 To dgv.ColumnCount - 1
                exlworksheet.Cells(i + 2, j + 1) = dgv.Rows(i).Cells(j).Value.ToString
            Next
        Next
        SFD.Filter = "Excel Files|*.xlsx|Excel 2003|*.xls"
        If SFD.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            exlworksheet.SaveAs(SFD.FileName)
        End If
        exlworkbook.Close()
        exlapp.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(exlapp)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(exlworkbook)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(exlworksheet)
        exlapp = Nothing : exlworkbook = Nothing : exlworksheet = Nothing
        If MessageBox.Show("هل تريد فتح الملف ؟", "فتح ملف الأكسل", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) = MsgBoxResult.Yes Then
            Process.Start(SFD.FileName)
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        dgv_ExportDataToExcelFile(DataGridView1)

    End Sub

   
    Private Sub Form_update_emp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Gp_tafrgh_dbDataSet.emp' table. You can move, or remove it, as needed.
        Me.EmpTableAdapter.Fill(Me.Gp_tafrgh_dbDataSet.emp)

    End Sub
End Class