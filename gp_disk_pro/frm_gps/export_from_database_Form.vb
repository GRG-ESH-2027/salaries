Imports System.Data.OleDb

Public Class export_from_database_Form

    Public dt_auto_data_base As New System.Data.DataTable

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        select_data_base(dgv_data_base)
        btn_selcet_data.Visible = True
        Button3.Enabled = True
    End Sub

    Private Sub btn_selcet_data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_selcet_data.Click
        If BackgroundWorker1.IsBusy Then
            Label7.Text = "جارى التحميل 000"


        Else
            BackgroundWorker1.RunWorkerAsync()

            Label7.Text = "تم التحميل"

        End If
    End Sub

    Private Sub btn_delete_data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete_data.Click
        'If BackgroundWorker2.IsBusy Then
        '    Label7.Text = "جارى التحميل 000"

        'Else
        '    BackgroundWorker2.RunWorkerAsync()
        '    Label7.Text = "تم الحذف"
        '    Btn_add.Visible = True
        '    btn_delete_data.Enabled = True

        'End If
        '===حذف البيانات  المكرر=====================================
        'btn_delete_data.Enabled = False
        For z As Integer = dgv_data_base.RowCount - 1 To 0 Step -1
            Dim delete As Boolean
            delete = dgv_data_base.Rows(z).Cells("Column1").Value

            If delete = True Then
                Dim row As DataGridViewRow
                row = dgv_data_base.Rows(z)


                dgv_data_base.Rows.RemoveAt(z)



            End If
        Next
        Label7.Text = "تم الحذف"
        Btn_add.Visible = True
        btn_delete_data.Enabled = True
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Try
            Btn_add.Enabled = False
            If dgv_data_base.Rows.Count < 0 Then

                MsgBox("لا يوجد بيانات كى تضاف", MsgBoxStyle.Information, "تنبيه")
                Exit Sub
            End If
            Btn_add.Enabled = False
            '=======================================
            If dgv_data_base.Rows.Count > 0 Then
                For i = 0 To dgv_data_base.RowCount - 1
                    'Insert_emp(id_no.Text,name_pay.Text,al_kta.Text,school.Text,no_emb.Text,name_emp.Text,hh.Text)

                    'Insert_emp(dgv_data_base.Rows(i).Cells(1).Value.ToString(), dgv_emp.Rows(i).Cells(2).Value.ToString(), dgv_emp.Rows(i).Cells(3).Value.ToString(), dgv_emp.Rows(i).Cells(4).Value.ToString(), dgv_emp.Rows(i).Cells(5).Value.ToString(), dgv_emp.Rows(i).Cells(6).Value.ToString(), dgv_emp.Rows(i).Cells(7).Value.ToString())
                    Insert_Table_mkf_add(dgv_data_base.Rows(i).Cells("id").Value.ToString(), dgv_data_base.Rows(i).Cells("id_and_user_tfg").Value.ToString(),
                                         dgv_data_base.Rows(i).Cells("No_55").Value.ToString(), dgv_data_base.Rows(i).Cells("no_kshf").Value.ToString(),
                                         dgv_data_base.Rows(i).Cells("Name_Em").Value.ToString(), dgv_data_base.Rows(i).Cells("Name_school").Value.ToString(),
                                         dgv_data_base.Rows(i).Cells("Salary_ass").Value.ToString(), dgv_data_base.Rows(i).Cells("Dayes").Value.ToString(),
                                         dgv_data_base.Rows(i).Cells("Mkf").Value.ToString(), dgv_data_base.Rows(i).Cells("Mkf_2").Value.ToString(), dgv_data_base.Rows(i).Cells("Badl_safer").Value.ToString(),
                                         dgv_data_base.Rows(i).Cells("Entklat").Value.ToString(), dgv_data_base.Rows(i).Cells("total").Value.ToString(),
                                         dgv_data_base.Rows(i).Cells("Mashat").Value.ToString(), dgv_data_base.Rows(i).Cells("Mashat8").Value.ToString(),
                                         dgv_data_base.Rows(i).Cells("Darabb").Value.ToString(), dgv_data_base.Rows(i).Cells("nkaba").Value.ToString(),
                                         dgv_data_base.Rows(i).Cells("Mhann").Value.ToString(), dgv_data_base.Rows(i).Cells("Mastshfa").Value.ToString(),
                                        dgv_data_base.Rows(i).Cells("Damghh").Value.ToString(), dgv_data_base.Rows(i).Cells("Earaadta").Value.ToString(),
                                        dgv_data_base.Rows(i).Cells("box20").Value.ToString(), dgv_data_base.Rows(i).Cells("Mzay_t_17_25").Value.ToString(), dgv_data_base.Rows(i).Cells("Total_Mostkta").Value.ToString(),
                                        dgv_data_base.Rows(i).Cells("Saffy").Value.ToString(), dgv_data_base.Rows(i).Cells("Id_Mkf").Value.ToString(),
                                        dgv_data_base.Rows(i).Cells("date1").Value.ToString(), dgv_data_base.Rows(i).Cells("op_id_no").Value.ToString(),
                                        dgv_data_base.Rows(i).Cells("op_name_pay").Value.ToString(), dgv_data_base.Rows(i).Cells("op_al_kta").Value.ToString(),
                                        dgv_data_base.Rows(i).Cells("op_no_emb").Value.ToString(), dgv_data_base.Rows(i).Cells("Saffy_after_antkal").Value.ToString(),
                                        dgv_data_base.Rows(i).Cells("nakab_yes_no").Value.ToString(), dgv_data_base.Rows(i).Cells("chb_tsh_mlahza").Value.ToString(),
                                       dgv_data_base.Rows(i).Cells("id_user").Value.ToString(), dgv_data_base.Rows(i).Cells("Auto_emp").Value.ToString(),
                                       dgv_data_base.Rows(i).Cells("Auto_total").Value.ToString(), dgv_data_base.Rows(i).Cells("chb_mlahza").Value.ToString(), dgv_data_base.Rows(i).Cells("chb_ٍsharta").Value.ToString(), dgv_data_base.Rows(i).Cells("chb_zar_shee").Value.ToString())

                Next


                'dt_auto_no_emp.Clear()
                'dgv_emp.Refresh()

            End If
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Label7.Text = "تم الاضافة"
            dt_select_data_base.Clear()
            dgv_data_base.Refresh()
            btn_delete_data.Visible = False
            btn_selcet_data.Visible = False
            Btn_add.Visible = False
            Btn_add.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()

    End Sub

 
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim total_row As Integer = dgv_data_base.Rows.Count

        If total_row > 0 Then
            ProgressBar1.Invoke(Sub() ProgressBar1.Maximum = total_row)

            For i = 0 To total_row - 1
                Dim rowIndex As Integer = i   ' متغير محلي يحمل قيمة i

                ' تحديث الـ ProgressBar
                ProgressBar1.Invoke(Sub() ProgressBar1.Value = rowIndex + 1)

                ' حساب النسبة المئوية
                Dim total_s As Double = ((rowIndex + 1) / total_row) * 100
                total_s = Math.Round(total_s, 0)

                Label6.Invoke(Sub() Label6.Text = "%" & total_s.ToString())
                Label7.Invoke(Sub() Label7.Text = "جارى التحميل...")
                Label6.Invoke(Sub() Label6.Visible = True)
                Label7.Invoke(Sub() Label7.Visible = True)

                ' جلب البيانات من قاعدة البيانات
                Dim id_anduser As String = dgv_data_base.Rows(rowIndex).Cells("id_and_user_tfg").Value.ToString()
                Using da As New OleDbDataAdapter("SELECT * FROM Table_mkf_add WHERE id_and_user_tfg = '" & id_anduser & "'", con)
                    dt_auto_data_base.Clear()
                    da.Fill(dt_auto_data_base)
                End Using

                ' تحديث الخلية حسب وجود بيانات
                If dt_auto_data_base.Rows.Count > 0 Then
                    dgv_data_base.Invoke(Sub() dgv_data_base.Rows(rowIndex).Cells("Column1").Value = True)
                Else
                    dgv_data_base.Invoke(Sub() dgv_data_base.Rows(rowIndex).Cells("Column1").Value = False)
                End If
            Next

        End If


    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox_search.TextChanged
        'select__by_name(Name_Emp.Text)
        Try
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MessageBox.Show("يجب اختيار طريق البحث!")
            End If
            If RadioButton1.Checked = True Then
                Dim dv As DataView = dt_select_data_base.DefaultView
                dv.RowFilter = " No_55=" & TextBox_search.Text & " "
            End If
            If RadioButton2.Checked = True Then
                Dim dv As DataView = dt_select_data_base.DefaultView
                dv.RowFilter = " Name_Emp LIKE '%" & TextBox_search.Text & "%' "
            End If
            If RadioButton3.Checked = True Then
                Dim dv As DataView = dt_select_data_base.DefaultView
                dv.RowFilter = " op_id_no LIKE '%" & TextBox_search.Text & "%' "
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'select__by_name(Name_Emp.Text)
        Try
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MessageBox.Show("يجب اختيار طريق البحث!")
            End If
            If RadioButton1.Checked = True Then
                Dim dv As DataView = dt_select_data_base.DefaultView
                dv.RowFilter = " No_55=" & TextBox_search.Text & " "
            End If
            If RadioButton2.Checked = True Then
                Dim dv As DataView = dt_select_data_base.DefaultView
                dv.RowFilter = " Name_Emp LIKE '%" & TextBox_search.Text & "%' "
            End If
            If RadioButton3.Checked = True Then
                Dim dv As DataView = dt_select_data_base.DefaultView
                dv.RowFilter = " op_id_no LIKE '%" & TextBox_search.Text & "%' "
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class