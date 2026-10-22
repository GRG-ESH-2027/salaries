Imports System.Data.OleDb

Module Module_salary_ass
    'الاستكمال التلقائى لاسم الموظف
    '==============================
    Public dt_auto_name_emp_q_salary_ass As New DataTable
    Public Sub auto_name_emp_q_salary_ass(ByVal dt As DataTable, ByVal list_box As ListBox, ByVal txtbox As String)
        Dim da As New OleDbDataAdapter
        dt_auto_name_emp_q_salary_ass.Clear()

        'da = New OleDbDataAdapter("select * from emp where id_no='" + id_noo_combx.Text + "'", con)

        da = New OleDbDataAdapter("select * from salary_ass where name_emp LIKE '%" & txtbox & "%' ", con)

        da.Fill(dt_auto_name_emp_q_salary_ass)
        list_box.DataSource = dt_auto_name_emp_q_salary_ass
        list_box.DisplayMember = "name_emp"
        If dt_auto_name_emp_q_salary_ass.Rows.Count > 0 Then
            ' Dim Name_emp As String
            'Name_Emp.Text = (dt_auto_name_emp.Rows(0)("name_emp")).ToString()
            'Name_emp = (dt_auto_name_emp_q.Rows(0)("name_emp")).ToString()
            'Me.Name_emp_seach.Text = Name_emp


        End If

    End Sub
    '==================
    'الاستكمال التلقائى للمرتب الاساسى textbox====================================
    Public dt_auto_salary_ass As New DataTable
    Public Sub auto_salary_ass(ByVal dt As DataTable, ByVal combox As ComboBox, ByVal id_no As String)
        Dim da As New OleDbDataAdapter
        dt_auto_salary_ass.Clear()
        'Dim Cmd As New OleDbCommand
        'Cmd.Connection = con
        'Cmd.CommandType = CommandType.Text
        'dv.RowFilter = " descr LIKE '%" & TextBox1.Text & "%' "

        da = New OleDbDataAdapter("select * from salary_ass where id_no   = '" & id_no & "'", con)


        da.Fill(dt_auto_salary_ass)

        combox.DataSource = dt_auto_salary_ass
        combox.DisplayMember = "salary_old"
        'Drab = dt_auto_salary_ass.Rows(0)("Drab")

        'Name_school.DataSource = dt_auto_Name_school
        'Name_school.DisplayMember = "school"


    End Sub
    '================================================
Public dt_auto_salary_ass_drab As New DataTable

    Public Sub auto_salary_ass_drab(ByVal id_no As String, ByRef Drab As Double)
        dt_auto_salary_ass_drab.Clear()

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim cmd As New OleDbCommand("SELECT * FROM salary_ass WHERE id_no = ?", con)
            cmd.Parameters.AddWithValue("?", id_no)

            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(dt_auto_salary_ass_drab)

            If dt_auto_salary_ass_drab.Rows.Count > 0 Then
                Drab = Convert.ToDouble(dt_auto_salary_ass_drab.Rows(0)("Drab"))
                Form_add_tfrgh.select_drab.Text = Drab.ToString() & " ضرائب"
                edit_form_tafrgh.select_drab.Text = Drab.ToString() & " ضرائب"
                Form_add_tfrgh.drab = Drab
                edit_form_tafrgh.drab = Drab
            Else
                'MsgBox("لم يتم العثور على بيانات لهذا الرقم.", MsgBoxStyle.Information, "تنبيه")
                Drab = 10 / 100

            End If

        Catch ex As Exception
            MsgBox("حدث خطأ :" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "خطأ")
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    '=================================
    'الاستكمال التلقائى للمرتب الاساسى textbox====================================
    Public dt_auto_emp_inf_job As New DataTable
    Public Sub auto_emp_inf_job(ByVal dt As DataTable, ByVal combox As ComboBox, ByVal id_no As String)
        Dim da As New OleDbDataAdapter
        dt_auto_emp_inf_job.Clear()
        'Dim Cmd As New OleDbCommand
        'Cmd.Connection = con
        'Cmd.CommandType = CommandType.Text
        'dv.RowFilter = " descr LIKE '%" & TextBox1.Text & "%' "

        'da = New OleDbDataAdapter("select * from emp where name_emp LIKE  '%" & Name_Emp.Text & "%'", con)

        da = New OleDbDataAdapter("select * from Emp_inf where id_no   LIKE '%" & id_no & "%'", con)
        da.Fill(dt_auto_salary_ass)

        combox.DataSource = dt_auto_emp_inf_job
        combox.DisplayMember = "techer_or_no"

        'Name_school.DataSource = dt_auto_Name_school
        'Name_school.DisplayMember = "school"


    End Sub



End Module
