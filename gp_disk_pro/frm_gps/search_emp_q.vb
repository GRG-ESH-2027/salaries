Imports System.Data.OleDb

Public Class search_emp_q
    'الاستكمال التلقائى لاسم الموظف
    '==============================
    Public dt_auto_name_emp_q As New DataTable
    'Public dt_auto_id_no_q As New DataTable
    Public Sub auto_name_emp_q(ByVal dt As DataTable, ByVal list_box As ListBox, ByVal txtbox As String)
        Dim da As New OleDbDataAdapter
        dt_auto_name_emp_q.Clear()

        'da = New OleDbDataAdapter("select * from emp where id_no='" + id_noo_combx.Text + "'", con)

        da = New OleDbDataAdapter("select * from emp where name_emp LIKE '%" & txtbox & "%'  ORDER BY name_emp ", con)

        da.Fill(dt_auto_name_emp_q)
        list_box.DataSource = dt_auto_name_emp_q
        ListBox2.DataSource = dt_auto_name_emp_q
        'ListBox3.DataSource = dt_auto_name_emp_q

        list_box.DisplayMember = "name_emp"
        ListBox2.DisplayMember = "id_no"
        'ListBox3.DisplayMember = "school"
        If dt_auto_name_emp_q.Rows.Count > 0 Then
            'Dim Name_emp As String


        End If

    End Sub
    '===========================================================
    'الاستكمال التلقائى لاسم الموظف
    '==============================
    'Public dt_auto_name_emp_q As New DataTable
    'Public dt_auto_id_no_q As New DataTable
    Public Sub auto_name_emp_q_by_id(ByVal dt As DataTable, ByVal list_box As ListBox, ByVal txtbox As String)
        Dim da As New OleDbDataAdapter
        dt_auto_name_emp_q.Clear()

        'da = New OleDbDataAdapter("select * from emp where id_no='" + id_noo_combx.Text + "'", con)

        da = New OleDbDataAdapter("select * from emp where id_no LIKE '%" & txtbox & "%'  ORDER BY name_emp ", con)

        da.Fill(dt_auto_name_emp_q)
        list_box.DataSource = dt_auto_name_emp_q
        ListBox2.DataSource = dt_auto_name_emp_q
        'ListBox3.DataSource = dt_auto_name_emp_q

        list_box.DisplayMember = "name_emp"
        ListBox2.DisplayMember = "id_no"
        'ListBox3.DisplayMember = "school"
        If dt_auto_name_emp_q.Rows.Count > 0 Then
            ' Dim Name_emp As String


        End If

    End Sub
    '=====================

    'الاستكمال التلقائى _listboxلاسم الموظف
    '==============================
    Public dt_auto_name_emp_q_listbox As New DataTable
    Public Sub auto_name_emp_q_listbox()
        Dim da As New OleDbDataAdapter
        'Dim Query As String

        'Dim myreader As OleDbDataReader

        dt_auto_name_emp_q_listbox.Clear()

        'da = New OleDbDataAdapter("select * from emp where id_no='" + id_noo_combx.Text + "'", con)

        'da = New OleDbDataAdapter("select * from emp where name_emp LIKE '%" & ListBox1.Text & "%' ", con)
        da = New OleDbDataAdapter("SELECT emp.id_no, emp.name_pay, emp.al_kta, emp.school, emp.no_emb, emp.name_emp, salary_ass.salary_old, Emp_inf.techer_or_no FROM Emp_inf RIGHT JOIN (salary_ass RIGHT JOIN emp ON salary_ass.id_no = emp.id_no) ON Emp_inf.id_no = emp.id_no  where name_emp  LIKE '%" & ListBox1.Text & "%' ", con)
        'Query = "select * from emp where name_emp LIKE '%" & ListBox1.Text & "%' "
        da.Fill(dt_auto_name_emp_q_listbox)



        'Dim cmd As New OleDbCommand(Query, con)
        'myreader = cmd.ExecuteReader()
        If dt_auto_name_emp_q_listbox.Rows.Count > 0 Then
            For i = 0 To dt_auto_name_emp_q_listbox.Rows.Count - 1
                Name_emp.Text = (dt_auto_name_emp_q_listbox.Rows(0)("name_emp")).ToString()
                Name_school.Text = (dt_auto_name_emp_q_listbox.Rows(0)("school")).ToString()
                id_noo_combx.Text = (dt_auto_name_emp_q_listbox.Rows(0)("id_no")).ToString()

                cmbx_no_emp.Text = (dt_auto_name_emp_q_listbox.Rows(0)("no_emb")).ToString()
                cmbx_alkta.Text = (dt_auto_name_emp_q_listbox.Rows(0)("al_kta")).ToString()
                cmbx_name_pay.Text = (dt_auto_name_emp_q_listbox.Rows(0)("name_pay")).ToString()
                ComboBox_Salary_ass.Text = (dt_auto_name_emp_q_listbox.Rows(0)("salary_old")).ToString()
                Cmbx_nokapa.Text = (dt_auto_name_emp_q_listbox.Rows(0)("techer_or_no")).ToString()
            Next
        End If
 




    End Sub
    '===================================
    'الاستكمال التلقائى _listboxلاسم الموظف
    '==============================
    Public dt_auto_id_no_q_listbox As New DataTable
    Public Sub auto_id_no_q_listbox()
        Dim da1 As New OleDbDataAdapter
        'Dim Query As String

        'Dim myreader As OleDbDataReader

        dt_auto_id_no_q_listbox.Clear()

        'da1 = New OleDbDataAdapter("SELECT emp.id_no, emp.name_pay, emp.al_kta, emp.school, emp.no_emb, emp.name_emp, salary_ass.salary_old, Emp_inf.techer_or_no FROM Emp_inf RIGHT JOIN (salary_ass RIGHT JOIN emp ON salary_ass.id_no = emp.id_no) ON Emp_inf.id_no = emp.id_no  where id_no=  LIKE '" & ListBox1.Text & "%' ", con)
       
        If ListBox2.Text = "" Then
        Else
            Dim id_no As String

            id_no = ListBox2.Text




            'id_no = (dt_auto_name_emp_q_listbox.Rows(0)("id_no")).ToString()
            'MessageBox.Show(id_no)

            da1 = New OleDbDataAdapter("SELECT emp.id_no, emp.name_pay, emp.al_kta, emp.school, emp.no_emb, emp.name_emp, salary_ass.salary_old, Emp_inf.techer_or_no, Emp_inf.[id_no] FROM Emp_inf RIGHT JOIN (salary_ass RIGHT JOIN emp ON salary_ass.id_no = emp.id_no) ON Emp_inf.id_no = emp.id_no WHERE emp.id_no LIKE '%" & id_no & "%' ", con)

            'Query = "select * from emp where name_emp LIKE '%" & ListBox1.Text & "%' "
            da1.Fill(dt_auto_id_no_q_listbox)


            'Dim cmd As New OleDbCommand(Query, con)
            'myreader = cmd.ExecuteReader()
            If dt_auto_id_no_q_listbox.Rows.Count > 0 Then
                For i = 0 To dt_auto_id_no_q_listbox.Rows.Count - 1
                    Name_emp.Text = ""
                    Name_school.Text = ""
                    id_noo_combx.Text = ""
                    Name_emp.Text = (dt_auto_id_no_q_listbox.Rows(0)("name_emp")).ToString()
                    Name_school.Text = (dt_auto_id_no_q_listbox.Rows(0)("school")).ToString()

                    id_noo_combx.Text = id_no

                    cmbx_no_emp.Text = (dt_auto_id_no_q_listbox.Rows(0)("no_emb")).ToString()
                    cmbx_alkta.Text = (dt_auto_id_no_q_listbox.Rows(0)("al_kta")).ToString()
                    cmbx_name_pay.Text = (dt_auto_id_no_q_listbox.Rows(0)("name_pay")).ToString()
                    ComboBox_Salary_ass.Text = (dt_auto_id_no_q_listbox.Rows(0)("salary_old")).ToString()
                    Cmbx_nokapa.Text = (dt_auto_id_no_q_listbox.Rows(0)("techer_or_no")).ToString()
                Next
            End If
        End If

    End Sub



    '==============
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        Try
            If Name_emp_seach.Text = "" Then
                MessageBox.Show("يجب ادخال اسم الموظف")
                lbl_msg.Text = "يجب ادخال اسم الموظف"
            Else
                dgv_search_emp_q.AutoGenerateColumns = False
                auto_name_emp_q(dt_auto_name_emp_q, ListBox1, Name_emp_seach.Text)
                dgv_search_emp_q.DataSource = dt_auto_name_emp_q
                lbl_msg.Text = ""
            End If
        

            If dgv_search_emp_q.Rows.Count > 0 Then
                Dim co_num As Integer = 0
                For x As Integer = 0 To dgv_search_emp_q.RowCount - 1
                    co_num = co_num + 1
                    dgv_search_emp_q.Rows(x).Cells("Column1").Value = co_num

                Next





            End If


            If dt_auto_name_emp_q.Rows.Count > 0 Then

                lbl_msg.Text = ""
            Else
                lbl_msg.Text = "لا يوجد نتائج "
            End If



            auto_salary_ass(dt_auto_salary_ass, ComboBox_Salary_ass, id_noo_combx.Text)

            '==================================
            Name_emp_seach.Items.Add(Name_emp_seach.Text)
        Catch
            'dt_auto_Name_school.Clear()


        End Try
    End Sub




    

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        'If dt_auto_name_emp_q.Rows.Count > 0 Then


        '    auto_name_emp_q_listbox()

        'End If
        If dt_auto_name_emp_q.Rows.Count > 0 Then


            auto_id_no_q_listbox()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Name_emp.Text = "" Then
            MessageBox.Show(" يجب اختيار اسم موظف  ..")
        Else
            Form_add_tfrgh.Name_emp.Text = Name_emp.Text
            Form_add_tfrgh.Name_school.Text = Name_school.Text
            Form_add_tfrgh.id_noo_combx.Text = id_noo_combx.Text
            Form_add_tfrgh.ComboBox_Salary_ass.Text = ComboBox_Salary_ass.Text

            Form_add_tfrgh.cmbx_no_emp.Text = cmbx_no_emp.Text
            Form_add_tfrgh.cmbx_alkta.Text = cmbx_alkta.Text
            Form_add_tfrgh.cmbx_name_pay.Text = cmbx_name_pay.Text

            '========================
            'التحقق من النقابى والغير نقابى
            Dim nokpa As String
            nokpa = Cmbx_nokapa.Text


            If nokpa = "ادارى" Then
                Form_add_tfrgh.rad_b_no_nokapy.Checked = True
                Form_add_tfrgh.radb_nkaba.Checked = False
            ElseIf nokpa = "معلم" Then
                Form_add_tfrgh.radb_nkaba.Checked = True
                Form_add_tfrgh.rad_b_no_nokapy.Checked = False
            Else
                Cmbx_nokapa.Text = "0"
                Form_add_tfrgh.radb_nkaba.Checked = False

                Form_add_tfrgh.rad_b_no_nokapy.Checked = False
            End If

            If Form_add_tfrgh.radb_nkaba.Checked = False And Form_add_tfrgh.rad_b_no_nokapy.Checked = False Then

                Cmbx_nokapa.Text = "0"
                MessageBox.Show("يجب تحديد نقابى او غير نقابى ! ..")
                Form_add_tfrgh.msg_lbl.Text = "اختر نقابى اوغير نقابى"
            Else
                msg_lbl.Text = ""
                Form_add_tfrgh.lbl_erro.Text = ""


            End If

        End If
        Form_add_tfrgh.Cmbx_nokapa.Text = Cmbx_nokapa.Text
        Form_add_tfrgh.Dayes_1.Focus()
        Me.Hide()
    End Sub

    Private Sub ListBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick

        If dgv_search_emp_q.Rows.Count > 0 Then


            auto_name_emp_q_listbox()
        End If
    End Sub

    Private Sub search_emp_q_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Name_emp_seach.Text = ""
        Name_emp_seach.Focus()
        Name_emp_seach.BackColor = Color.Yellow
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dt_auto_name_emp_q.Rows.Count > 0 Then


            auto_id_no_q_listbox()
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        If Name_emp.Text = "" Then
            MessageBox.Show(" يجب اختيار اسم موظف  ..")
        ElseIf edit_form_tafrgh.stat_frm = "تعديل" Then


            edit_form_tafrgh.Name_emp_txt.Text = Name_emp.Text
            edit_form_tafrgh.Name_school_txt.Text = Name_school.Text
            edit_form_tafrgh.id_noo_combx.Text = id_noo_combx.Text
            edit_form_tafrgh.ComboBox_Salary_ass.Text = ComboBox_Salary_ass.Text

            edit_form_tafrgh.cmbx_no_emp.Text = cmbx_no_emp.Text
            edit_form_tafrgh.cmbx_alkta.Text = cmbx_alkta.Text
            edit_form_tafrgh.cmbx_name_pay.Text = cmbx_name_pay.Text


            '========================
            'التحقق من النقابى والغير نقابى
            Dim nokpa As String
            nokpa = Cmbx_nokapa.Text


            If nokpa = "ادارى" Then
                edit_form_tafrgh.rad_b_no_nokapy.Checked = True
                edit_form_tafrgh.radb_nkaba.Checked = False
            ElseIf nokpa = "معلم" Then
                edit_form_tafrgh.radb_nkaba.Checked = True
                edit_form_tafrgh.rad_b_no_nokapy.Checked = False
            Else
                Cmbx_nokapa.Text = "0"
                edit_form_tafrgh.radb_nkaba.Checked = False

                edit_form_tafrgh.rad_b_no_nokapy.Checked = False
            End If

            If edit_form_tafrgh.radb_nkaba.Checked = False And edit_form_tafrgh.rad_b_no_nokapy.Checked = False Then

                Cmbx_nokapa.Text = "0"
                MessageBox.Show("يجب تحديد نقابى او غير نقابى ! ..")
                edit_form_tafrgh.msg_lbl.Text = "اختر نقابى اوغير نقابى"
            Else
                msg_lbl.Text = ""
                edit_form_tafrgh.lbl_erro.Text = ""


            End If
        Else
            Form_add_tfrgh.Name_emp.Text = Name_emp.Text
            Form_add_tfrgh.Name_school.Text = Name_school.Text
            Form_add_tfrgh.id_noo_combx.Text = id_noo_combx.Text
            Form_add_tfrgh.ComboBox_Salary_ass.Text = ComboBox_Salary_ass.Text

            Form_add_tfrgh.cmbx_no_emp.Text = cmbx_no_emp.Text
            Form_add_tfrgh.cmbx_alkta.Text = cmbx_alkta.Text
            Form_add_tfrgh.cmbx_name_pay.Text = cmbx_name_pay.Text
            auto_salary_ass(dt_auto_salary_ass, ComboBox_Salary_ass, id_noo_combx.Text)
            Form_add_tfrgh.drab = dt_auto_salary_ass.Rows(0)("Drab")

            '========================
            'التحقق من النقابى والغير نقابى
            Dim nokpa As String
            nokpa = Cmbx_nokapa.Text


            If nokpa = "ادارى" Then
                Form_add_tfrgh.rad_b_no_nokapy.Checked = True
                Form_add_tfrgh.radb_nkaba.Checked = False
            ElseIf nokpa = "معلم" Then
                Form_add_tfrgh.radb_nkaba.Checked = True
                Form_add_tfrgh.rad_b_no_nokapy.Checked = False
            Else
                Cmbx_nokapa.Text = "0"
                Form_add_tfrgh.radb_nkaba.Checked = False

                Form_add_tfrgh.rad_b_no_nokapy.Checked = False
            End If

            If Form_add_tfrgh.radb_nkaba.Checked = False And Form_add_tfrgh.rad_b_no_nokapy.Checked = False Then

                Cmbx_nokapa.Text = "0"
                MessageBox.Show("يجب تحديد نقابى او غير نقابى ! ..")
                Form_add_tfrgh.msg_lbl.Text = "اختر نقابى اوغير نقابى"
            Else
                msg_lbl.Text = ""
                Form_add_tfrgh.lbl_erro.Text = ""


            End If





        End If
        Form_add_tfrgh.Cmbx_nokapa.Text = Cmbx_nokapa.Text
        Form_add_tfrgh.Dayes_1.Focus()
        Me.Hide()


    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dt_auto_name_emp_q.Rows.Count > 0 Then


            auto_id_no_q_listbox()
        End If


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub dgv_search_emp_q_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_search_emp_q.MouseClick
        If dgv_search_emp_q.Rows.Count > 0 Then


            Dim id As String
            id = dgv_search_emp_q.CurrentRow.Cells("Column2").Value.ToString()





            '=========================================
            Dim da1 As New OleDbDataAdapter
            'Dim Query As String



            dt_auto_id_no_q_listbox.Clear()

            'da1 = New OleDbDataAdapter("SELECT emp.id_no, emp.name_pay, emp.al_kta, emp.school, emp.no_emb, emp.name_emp, salary_ass.salary_old, Emp_inf.techer_or_no FROM Emp_inf RIGHT JOIN (salary_ass RIGHT JOIN emp ON salary_ass.id_no = emp.id_no) ON Emp_inf.id_no = emp.id_no  where id_no=  LIKE '" & ListBox1.Text & "%' ", con)







            da1 = New OleDbDataAdapter("SELECT emp.id_no, emp.name_pay, emp.al_kta, emp.school, emp.no_emb, emp.name_emp, salary_ass.salary_old, Emp_inf.techer_or_no, Emp_inf.[id_no] FROM Emp_inf RIGHT JOIN (salary_ass RIGHT JOIN emp ON salary_ass.id_no = emp.id_no) ON Emp_inf.id_no = emp.id_no WHERE emp.id_no LIKE '%" & id & "%' ", con)

            'Query = "select * from emp where name_emp LIKE '%" & ListBox1.Text & "%' "
            da1.Fill(dt_auto_id_no_q_listbox)


            'Dim cmd As New OleDbCommand(Query, con)
            'myreader = cmd.ExecuteReader()
            If dt_auto_id_no_q_listbox.Rows.Count > 0 Then
                For i = 0 To dt_auto_id_no_q_listbox.Rows.Count - 1
                    Name_emp.Text = ""
                    Name_school.Text = ""
                    id_noo_combx.Text = ""
                    Name_emp.Text = (dt_auto_id_no_q_listbox.Rows(0)("name_emp")).ToString()
                    Name_school.Text = (dt_auto_id_no_q_listbox.Rows(0)("school")).ToString()

                    id_noo_combx.Text = id

                    cmbx_no_emp.Text = (dt_auto_id_no_q_listbox.Rows(0)("no_emb")).ToString()
                    cmbx_alkta.Text = (dt_auto_id_no_q_listbox.Rows(0)("al_kta")).ToString()
                    cmbx_name_pay.Text = (dt_auto_id_no_q_listbox.Rows(0)("name_pay")).ToString()
                    ComboBox_Salary_ass.Text = (dt_auto_id_no_q_listbox.Rows(0)("salary_old")).ToString()
                    Cmbx_nokapa.Text = (dt_auto_id_no_q_listbox.Rows(0)("techer_or_no")).ToString()
                Next
            End If
        End If




    End Sub


 
  
    Private Sub Name_emp_seach_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Name_emp_seach.MouseClick
        'If e.Clicks = True Then
        Name_emp_seach.BackColor = Color.Yellow
        'Else
        'Name_emp_seach.BackColor = Color.White
        'End If
    End Sub

    Private Sub Name_emp_seach_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Name_emp_seach.KeyPress
        no_used_char3(e)
    End Sub

    Private Sub Name_emp_seach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Name_emp_seach.SelectedIndexChanged

    End Sub
End Class