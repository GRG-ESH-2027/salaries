Imports System.Data.OleDb

Public Class search_tafrgh

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'select__by_name(Name_Emp.Text)
        Try
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MessageBox.Show("يجب اختيار طريق البحث!")
            End If
            If RadioButton1.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " No_55=" & Name_Emp.Text & " "
            End If
            If RadioButton2.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " Name_Emp LIKE '%" & Name_Emp.Text & "%' "
            End If
            If RadioButton3.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " id_no LIKE '%" & Name_Emp.Text & "%' "
            End If

        Catch ex As Exception
        End Try

    End Sub

    Private Sub Btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_new.Click
        dgv_Table_add_tfrgh.AutoGenerateColumns = False
        select__by_name(dgv_Table_add_tfrgh)
    End Sub

    Private Sub Name_Emp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_Emp.TextChanged
        'select__by_name(Name_Emp.Text)
        Try
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MessageBox.Show("يجب اختيار طريق البحث!")
            End If
            If RadioButton1.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " No_55=" & Name_Emp.Text & " "
            End If
            If RadioButton2.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " Name_Emp LIKE '%" & Name_Emp.Text & "%' "
            End If
            If RadioButton3.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " id_no LIKE '%" & Name_Emp.Text & "%' "
            End If

        Catch ex As Exception
        End Try
    End Sub






    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        '======================================================================================
        'Dim no_kkk As Integer = 0




        'If no_kkk > 0 Then

        'SelectAll_Table_mkf_all_data()
        'dgv_Table_mkf_no_kshf.DataSource = dt_Table_mkf_no_kshff_pr
        'txt_name_user.Text = dgv_Table_mkf_no_kshf.Rows(0).Cells("user_name").Value.ToString()

        'Dim Id_Mkff As Integer
        'Id_Mkff = dgv_Table_mkf_no_kshf.CurrentRow.Cells("Id_Mkf").Value

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

        add_file()
        'Label3.Visible = True
        'Label2.Visible = True
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
        'xlWorkSheet.Cells(3, 9) = Name_Mkf.Text
        'xlWorkSheet.Cells(2, 3) = "رقم الشطب"
        'xlWorkSheet.Cells(3, 12) = term.Text
        'xlWorkSheet.Cells(3, 18) = Years.Text

        'xlWorkSheet.Cells(2, 18) = iteem
        'xlWorkSheet.Cells(2, 17) = txt_name_user.Text



        'Dim no_kkk As Integer = 0



        'no_kkk = iteem

        Dim Cmd As New OleDbDataAdapter("select No_55,Salary_ass,Dayes,Mkf,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy,Entklat,Badl_safer,id,Id_Mkf,no_kshf,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb,user_table.user_name from Table_mkf_add,user_table where Table_mkf_add.id_user=user_table.id_user", con)



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
        Dim gg As Integer = 0
        'gg = iteem
        'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")
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
        Label2.Visible = False
        Label3.Visible = False
        ProgressBar1.Value = 0


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export_all.Click
        btn_export_all.Enabled = False
        btn_export_all.Text = "Wait"
        SaveGridToExcel_all_tfrgh(dgv_Table_add_tfrgh)
        btn_export_all.Text = "تصدير البيانات الى اكسيل"
    End Sub

    Private Sub search_tafrgh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class