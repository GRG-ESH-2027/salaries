Imports System.Data.OleDb

Public Class salary_add_Form
    'الاستكمال التلقائى لرقم القومى textbox====================================
    Public dt_auto_id_no As New DataTable
    Public Sub auto_id_no(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_id_no.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_Emp_2.Text + "'", con)

        da.Fill(dt_auto_id_no)

        id_noo_combx_2.DataSource = dt_auto_id_no
        id_noo_combx_2.DisplayMember = "id_no"
        If dt_auto_id_no.Rows.Count > 1 Then
            Label1.Text = "اسم مكرر اختر رقم"
            Label1.ForeColor = Color.Red
            MessageBox.Show("اسم مكرر اختر رقم قومى ؟ ...")
            'chk_auto.Checked = True
            msg_lbl.Text = "اختر auto ثم اختيار الرقم القومى"
        Else
            Label1.Text = "رقم القومى "
            Label1.ForeColor = Color.White
            'chk_auto.Checked = False
            msg_lbl.Text = ""

        End If
    End Sub
    '====================================================
    Private Sub Name_Emp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Name_Emp_2.KeyDown




        'If chk_auto.CheckState = CheckState.Unchecked Then

        '    Try
        '        '        auto_name_emp(dt_auto_name_emp, id_noo_combx_2.Text, Name_Emp_2.Text)
        '        auto_Name_school(dt_auto_Name_school, Name_school_2, Name_Emp_2.Text)
        '        auto_id_no(dt_auto_Name_school)
        '        auto_salary_ass(dt_auto_salary_ass, ComboBox_ass_old, id_noo_combx_2.Text)
        '        'auto_emp_inf_job(dt_auto_emp_inf_job, Cmbx_job, id_noo_combx_2.Text)

        '        '        'auto_name_pay(dt_auto_Name_school)
        '        '        'auto_alkta(dt_auto_Name_school)
        '        '        'auto_no_emp(dt_auto_Name_school)
        '    Catch
        '        dt_auto_Name_school.Clear()

        '    End Try
        'Else


        'End If
        ''================================
        'select_id_salary_ass(id_noo_combx_2.Text)
        'Dim no_erro As String
        'If dt_select_id_no_salary_ass.Rows.Count > 0 Then
        '    no_erro = "id_you_enter_befor"
        'Else
        '    no_erro = ""

        'End If
        'If no_erro = "id_you_enter_befor" Then
        '    Idlbl.Text = "رقم قومى تم ادخاله من قبل ! !"
        '    'isvalaied = False
        '    ErrorProvider1.SetError(id_noo_combx_2, "تاكد من الرقم القومى  ..")
        '    BtnNewAdd.Visible = False
        '    BtnEdit.Visible = True
        'Else
        '    Idlbl.Text = ""
        '    BtnNewAdd.Visible = True
        '    BtnEdit.Visible = False
        'End If

    End Sub
    '=====================================
    Public Sub ClearControls()
        Me.Name_Emp_2.Text = vbNullString
        Me.Name_school_2.Text = vbNullString

        Me.id_noo_combx_2.Text = vbNullString
        Me.ComboBox_ass_old.Text = 0
        Me.ComboBox_ass_new.Text = 0
        Me.ComboBox_salary_safy.Text = 0
        Me.Cmbx_job.Text = 0
        Me.ComboBox_Drab.Text = 10

    End Sub
    '=========================================
    'الاستكمال التلقائى _listboxلاسم الموظف
    '==============================

    Public dt_auto_name_emp_q_listbox As New DataTable
    Public Sub auto_name_emp_q_listbox()
        Try
            Dim da As New OleDbDataAdapter
            'Dim Query As String

            'Dim myreader As OleDbDataReader

            dt_auto_name_emp_q_listbox.Clear()

            'da = New OleDbDataAdapter("select * from emp where id_no='" + id_noo_combx.Text + "'", con)

            'da = New OleDbDataAdapter("select * from emp where name_emp LIKE '%" & ListBox1.Text & "%' ", con)
            da = New OleDbDataAdapter("SELECT emp.id_no, emp.name_pay, emp.al_kta, emp.school, emp.no_emb, emp.name_emp, salary_ass.salary_old,salary_ass.salary_new,salary_ass.salary_safy,salary_ass.date1,salary_ass.Drab, Emp_inf.techer_or_no,Emp_inf.work_ass FROM Emp_inf RIGHT JOIN (salary_ass RIGHT JOIN emp ON salary_ass.id_no = emp.id_no) ON Emp_inf.id_no = emp.id_no  where name_emp LIKE '%" & ListBox1.Text & "%' ", con)
            'Query = "select * from emp where name_emp LIKE '%" & ListBox1.Text & "%' "
            da.Fill(dt_auto_name_emp_q_listbox)

            'Dim cmd As New OleDbCommand(Query, con)
            'myreader = cmd.ExecuteReader()
            If dt_auto_name_emp_q_listbox.Rows.Count > 0 Then
                For i = 0 To dt_auto_name_emp_q_listbox.Rows.Count - 1
                    Name_Emp_2.Text = (dt_auto_name_emp_q_listbox.Rows(0)("name_emp")).ToString()
                    Name_school_2.Text = (dt_auto_name_emp_q_listbox.Rows(0)("school")).ToString()
                    id_noo_combx_2.Text = (dt_auto_name_emp_q_listbox.Rows(0)("id_no")).ToString()
                    ComboBox_ass_old.Text = (dt_auto_name_emp_q_listbox.Rows(0)("salary_old")).ToString()
                    ComboBox_ass_new.Text = (dt_auto_name_emp_q_listbox.Rows(0)("salary_new")).ToString()
                    ComboBox_salary_safy.Text = (dt_auto_name_emp_q_listbox.Rows(0)("salary_safy")).ToString()
                    Cmbx_job.Text = (dt_auto_name_emp_q_listbox.Rows(0)("techer_or_no")).ToString()
                    DateTimePicker1.Value = (dt_auto_name_emp_q_listbox.Rows(0)("date1"))
                    ComboBox_Drab.Text = (dt_auto_name_emp_q_listbox.Rows(0)("Drab")).ToString()
                    ComboBox_work.Text = (dt_auto_name_emp_q_listbox.Rows(0)("work_ass")).ToString()
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()

            ' MsgBox(Err.Description, MsgBoxStyle.Information)
        End Try
    End Sub
    'While (myreader.Read())
    '    Dim name As String
    '    'name = myreader.GetString("name_emp")
    '    name = myreader.GetValue("name_emp").ToString()
    '    MessageBox.Show(name)
    '    Name_emp.Text = name
    'End While
    'da.Fill(dt_auto_name_emp_q_listbox)
    'ListBox1.DataSource = dt_auto_name_emp_q_listbox
    'ListBox1.DisplayMember = "name_emp"
    'If dt_auto_name_emp_q_listbox.Rows.Count > 0 Then
    '    Dim Name_emp As String
    '    'Name_Emp.Text = (dt_auto_name_emp.Rows(0)("name_emp")).ToString()
    '    Name_emp = (dt_auto_name_emp_q_listbox.Rows(0)("name_emp")).ToString()
    '    Me.Name_emp_seach.Text = Name_emp


    'End If





    '=====================



    '================================

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        'Dim ass_old, ass_new, safy As Double
        'ass_old = Convert.ToDouble(ComboBox_ass_old.Text)
        'ass_new = Convert.ToDouble(ComboBox_ass_new.Text)
        'safy = Convert.ToDouble(ComboBox_salary_safy.Text)
        Dim isvalaied As Boolean
        ErrorProvider1.Clear()
        Idlbl.Text = ""

        select_id_salary_ass(id_noo_combx_2.Text)
        select_id_emp_inf(id_noo_combx_2.Text)
        Dim no_erro As String
        If dt_select_id_no_salary_ass.Rows.Count > 0 Then
            no_erro = "id_you_enter_befor"
        Else
            no_erro = ""
        End If

        If Name_Emp_2.Text = "" Then
            ErrorProvider1.SetError(Name_Emp_2, "تاكد من اسم الموظف..")
            isvalaied = False
            msg_lbl.Text += "  تاكد من اسم الموظف"
            Idlbl.Text += "يجب كتابة اسم الموظف !"

        ElseIf id_noo_combx_2.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(id_noo_combx_2, "تاكد من الرقم القومى ..")
            msg_lbl.Text += "  تاكد من الرقم القومى"
            Idlbl.Text += "يجب ادخال الرقم القومى !"
        ElseIf ComboBox_ass_new.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(ComboBox_ass_new, "تاكد من اساسى المرتب الجديد ..")
            msg_lbl.Text += "  تاكد من اساسى المرتب الجديد"
            Idlbl.Text += "يجب ادخال اساسى المرتب الجديد !"
            ComboBox_ass_new.Text = 0
        ElseIf ComboBox_salary_safy.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(ComboBox_salary_safy, "تاكد من صافى المرتب  ..")
            msg_lbl.Text += "  تاكد من صافى المرتب "
            Idlbl.Text += "يجب ادخال صافى المرتب  !"
            ComboBox_salary_safy.Text = 0
        ElseIf ComboBox_Drab.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(ComboBox_Drab, "تاكد من تعيين 5%  ..")
            msg_lbl.Text += "  تاكد من ضرائب "
            Idlbl.Text += "يجب ادخال تعيين 5%  !"
            ComboBox_Drab.Text = 0

        ElseIf Cmbx_job.Text = "" Then
            Idlbl.Text += "يجب اختيار وظيفه !"
            Cmbx_job.Text = 0

        ElseIf ComboBox_ass_old.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(ComboBox_ass_old, "ساسى المرتب القديم ..")
            msg_lbl.Text += "  تاكد من ساسى المرتب القديم"

            Idlbl.Text += "يجب ادخال اساسى المرتب القديم !"

            ErrorProvider1.SetError(id_noo_combx_2, "تاكد من الرقم القومى  ..")
        Else
            Update_salary_ass(id_noo_combx_2.Text, Convert.ToDouble(ComboBox_ass_old.Text), Convert.ToDouble(ComboBox_ass_new.Text), Convert.ToDouble(ComboBox_salary_safy.Text), DateTimePicker1.Value, Convert.ToDouble(ComboBox_Drab.Text))
            If dt_select_id_no_emp_inf.Rows.Count > 0 Then
                Update_emp_inf(id_noo_combx_2.Text, id_noo_combx_2.Text, Cmbx_job.Text, ComboBox_work.Text)

            Else
                Insert_emp_inf(id_noo_combx_2.Text, Cmbx_job.Text, ComboBox_work.Text)

            End If
            ClearControls()

        End If
        '===================================================================


    End Sub

    Private Sub salary_add_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If chk_auto.CheckState = CheckState.Unchecked Then

            Try
                auto_txt_name_emp(Name_Emp_2)

            Catch ex As Exception
                dt_auto_Name_school.Clear()
            End Try

        Else

        End If
        '==============


    End Sub


    Private Sub chk_auto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_auto.CheckedChanged

        If chk_auto.CheckState = CheckState.Unchecked Then
            chk_auto.Text = "Auto"
            auto_txt_name_emp(Name_Emp_2)
        Else
            chk_auto.Text = "يدوى"
            Name_Emp_2.AutoCompleteCustomSource = Nothing
        End If
    End Sub

    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.Click
        'Dim ass_old, ass_new, safy As Double
        'ass_old = Convert.ToDouble(ComboBox_ass_old.Text)
        'ass_new = Convert.ToDouble(ComboBox_ass_new.Text)
        'safy = Convert.ToDouble(ComboBox_salary_safy.Text)
        Dim isvalaied As Boolean
        ErrorProvider1.Clear()
        Idlbl.Text = ""

        select_id_salary_ass(id_noo_combx_2.Text)
        select_id_emp_inf(id_noo_combx_2.Text)

        Dim no_erro As String
        If dt_select_id_no_salary_ass.Rows.Count > 0 Then
            no_erro = "id_you_enter_befor"
        Else
            no_erro = ""
        End If

        If Name_Emp_2.Text = "" Then
            ErrorProvider1.SetError(Name_Emp_2, "تاكد من اسم الموظف..")
            isvalaied = False
            msg_lbl.Text += "  تاكد من اسم الموظف"
            Idlbl.Text += "يجب كتابة اسم الموظف !"

        ElseIf id_noo_combx_2.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(id_noo_combx_2, "تاكد من الرقم القومى ..")
            msg_lbl.Text += "  تاكد من الرقم القومى"
            Idlbl.Text += "يجب ادخال الرقم القومى !"
        ElseIf ComboBox_ass_new.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(ComboBox_ass_new, "تاكد من اساسى المرتب الجديد ..")
            msg_lbl.Text += "  تاكد من اساسى المرتب الجديد"
            Idlbl.Text += "يجب ادخال اساسى المرتب الجديد !"
            ComboBox_ass_new.Text = 0
        ElseIf ComboBox_salary_safy.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(ComboBox_salary_safy, "تاكد من صافى المرتب  ..")
            msg_lbl.Text += "  تاكد من صافى المرتب "
            Idlbl.Text += "يجب ادخال صافى المرتب  !"
            ComboBox_salary_safy.Text = 0

        ElseIf ComboBox_ass_old.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(ComboBox_ass_old, "ساسى المرتب القديم ..")
            msg_lbl.Text += "  تاكد من ساسى المرتب القديم"

            Idlbl.Text += "يجب ادخال اساسى المرتب القديم !"
        ElseIf Cmbx_job.Text = "" Then
            Idlbl.Text += "يجب اختيار وظيفه !"
            Cmbx_job.Text = 0

        ElseIf ComboBox_Drab.Text = "" Then
            isvalaied = False
            ErrorProvider1.SetError(ComboBox_Drab, "تاكد من تعيين 5%  ..")
            msg_lbl.Text += "  تاكد من ضرائب "
            Idlbl.Text += "يجب ادخال تعيين 5%  !"
            ComboBox_Drab.Text = 0

        ElseIf no_erro = "id_you_enter_befor" Then
            Idlbl.Text += "رقم قومى تم ادخاله من قبل ! !"
            isvalaied = False
            ErrorProvider1.SetError(id_noo_combx_2, "تاكد من الرقم القومى  ..")
        ElseIf ComboBox_ass_new.Text = "" Then
            ComboBox_ass_new.Text = "0"
        ElseIf ComboBox_salary_safy.Text = "" Then
            ComboBox_salary_safy.Text = "0"
        ElseIf Name_school_2.Text = "" Then
            Name_school_2.Text = "0"
            'ElseIf dt_select_id_no_emp_inf.Rows.Count > 0 Then

            '    Update_emp_inf(id_noo_combx_2.Text, Cmbx_job.Text)

        Else

            Insert_salary_ass(id_noo_combx_2.Text, Convert.ToDouble(ComboBox_ass_old.Text), Convert.ToDouble(ComboBox_ass_new.Text), Convert.ToDouble(ComboBox_salary_safy.Text), Convert.ToDouble(ComboBox_Drab.Text))
            'Insert_emp_inf(id_noo_combx_2.Text, Cmbx_job.Text)
            'ClearControls()
            If dt_select_id_no_emp_inf.Rows.Count > 0 Then
                Update_emp_inf(id_noo_combx_2.Text, id_noo_combx_2.Text, Cmbx_job.Text, ComboBox_work.Text)

            Else
                Insert_emp_inf(id_noo_combx_2.Text, Cmbx_job.Text, ComboBox_work.Text)

            End If
            ClearControls()
        End If
        '===================================================================



    End Sub

    Private Sub Btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_new.Click
        System.Windows.Forms.Application.DoEvents()

        Btn_new.Enabled = False
        select_salary_ass()
        dgv_salary_ass.DataSource = dt_salary_ass
        DataGridViewHeaderText_salary_ass(dgv_salary_ass)
        lbl_count_emp.Text = dt_salary_ass.Rows.Count.ToString()
        lbl_msg_load.Text = "الاساسى تم تسجيل من قبل"
        'If BackgroundWorker3.IsBusy Then
        '    Idlbl.Text = "جارى التحميل 000"

        'Else
        '    BackgroundWorker3.RunWorkerAsync()

        'End If
        'ProgressBar1.Maximum = dt_salary_ass.Rows.Count
        'ProgressBar1.Value = i
        System.Windows.Forms.Application.DoEvents()
        Btn_new.Enabled = True
    End Sub

    Private Sub Txt_seach_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_seach.TextChanged
        'Try
        '    Dim dv As DataView = dt_salary_ass.DefaultView
        '    dv.RowFilter = " Name_Emp LIKE '%" & Txt_seach.Text & "%' "
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub dgv_salary_ass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_salary_ass.Click
        Try
            With dgv_salary_ass
                Me.Name_Emp_2.Text = .CurrentRow.Cells("name_emp").Value.ToString()
                Me.Name_school_2.Text = .CurrentRow.Cells("school").Value.ToString()
                Me.id_noo_combx_2.Text = .CurrentRow.Cells("id_no").Value.ToString()
                Me.ComboBox_ass_old.Text = .CurrentRow.Cells("salary_old").Value.ToString()
                Me.ComboBox_ass_new.Text = .CurrentRow.Cells("salary_new").Value.ToString()
                Me.ComboBox_salary_safy.Text = .CurrentRow.Cells("salary_safy").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If lbl_msg_load.Text = "الاساسى تم تسجيل من قبل" Then
            Try
                Dim dv As DataView = dt_salary_ass.DefaultView
                dv.RowFilter = " Name_Emp LIKE '%" & Txt_seach.Text & "%' "
            Catch ex As Exception
            End Try
        Else
            Try
                Dim dv As DataView = dt_salary_ass_all.DefaultView
                dv.RowFilter = " Name_Emp LIKE '%" & Txt_seach.Text & "%' "
            Catch ex As Exception
            End Try
        End If

    End Sub


    Private Sub btn_load_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_all.Click
        System.Windows.Forms.Application.DoEvents()

        btn_load_all.Enabled = False
        select_salary_ass_all()
        dgv_salary_ass.DataSource = Nothing
        dgv_salary_ass.DataSource = dt_salary_ass_all
        DataGridViewHeaderText_salary_ass(dgv_salary_ass)
        lbl_count_emp.Text = dt_salary_ass_all.Rows.Count.ToString()
        lbl_msg_load.Text = "كل الاسماء الموجودة بالقاعدة"
        'If BackgroundWorker3.IsBusy Then
        '    Idlbl.Text = "جارى التحميل 000"

        'Else
        '    BackgroundWorker3.RunWorkerAsync()

        'End If
        System.Windows.Forms.Application.DoEvents()
        btn_load_all.Enabled = True
    End Sub


    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        Try

            Cmbx_job.Text = "0"
            If Radio_name.Checked = True Then


                search_emp_q.auto_name_emp_q(search_emp_q.dt_auto_name_emp_q, ListBox1, Name_emp_seach.Text)
            Else
                search_emp_q.auto_name_emp_q_by_id(search_emp_q.dt_auto_name_emp_q, ListBox1, Combox.Text)
            End If

            If search_emp_q.dt_auto_name_emp_q.Rows.Count > 0 Then

                lbl_msg.Text = ""
                Name_emp_seach.Items.Add(Name_emp_seach.Text)
            Else
                lbl_msg.Text = "لا يوجد نتائج "
            End If

            'auto_id_no(dt_auto_Name_school)
            'auto_name_pay(dt_auto_Name_school)
            'auto_alkta(dt_auto_Name_school)
            'auto_no_emp(dt_auto_Name_school)
            '=================اضافة المرتب الاساسى 


            auto_salary_ass(dt_auto_salary_ass, ComboBox_ass_old, id_noo_combx_2.Text)
            'معرفة نقابى اوغير نقابى 
            'auto_techer_or_no(dt_auto_techer_or_no, Cmbx_nokapa, id_noo_combx.Text)


            'Salary_ass.Value = auto_salary_ass(dt_auto_salary_ass, combox, id_noo_combx.Text)

            '==================================

        Catch
            'dt_auto_Name_school.Clear()

            con.Close()
        End Try

    End Sub

    Private Sub ListBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseClick
        'If dt_auto_name_emp_q_listbox.Rows.Count > 0 Then


        auto_name_emp_q_listbox()

        '==================================
        select_id_salary_ass(id_noo_combx_2.Text)
        Dim no_erro As String
        If dt_select_id_no_salary_ass.Rows.Count > 0 Then
            no_erro = "id_you_enter_befor"
        Else
            no_erro = ""

        End If
        If no_erro = "id_you_enter_befor" Then
            Idlbl.Text = "رقم قومى تم ادخاله من قبل ! !"
            'isvalaied = False
            ErrorProvider1.SetError(id_noo_combx_2, "تاكد من الرقم القومى  ..")
            BtnNewAdd.Visible = False
            BtnEdit.Visible = True
        Else
            Idlbl.Text = ""
            BtnNewAdd.Visible = True
            BtnEdit.Visible = False
        End If
        'End If

    End Sub


    Private Sub Name_emp_seach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_emp_seach.Click
        Radio_name.Checked = True
    End Sub

    Private Sub Combox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combox.Click
        RadioButton2.Checked = True
    End Sub

End Class