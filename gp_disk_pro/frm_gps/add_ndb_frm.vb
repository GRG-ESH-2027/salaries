Imports System.Data.OleDb

Public Class add_ndb_frm
    Public id As String
    Public isvalaied As Boolean



    'الاستكمال التلقائى لاسم textbox====================================

    Public dt_auto_txt As New DataTable
    Public Sub auto_txt_name_emp(ByVal Name_Emp As TextBox)
        Dim da As New OleDbDataAdapter
        dt_auto_txt.Clear()
        da = New OleDbDataAdapter("select * from emp ", con)
        da.Fill(dt_auto_txt)
        Dim data_souce As New AutoCompleteStringCollection

        For i As Integer = 0 To dt_auto_txt.Rows.Count - 1
            data_souce.Add(dt_auto_txt.Rows(i)("name_emp")).ToString()

        Next
        Name_Emp.AutoCompleteCustomSource = data_souce
        Name_Emp.AutoCompleteSource = AutoCompleteSource.CustomSource
        Name_Emp.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    'الاستكمال التلقائى لاسم الموظف
    '==============================
    Public dt_auto_name_emp As New DataTable
    Public Sub auto_name_emp(ByVal dt As DataTable, ByVal id_no_combx As String)
        Dim da As New OleDbDataAdapter
        dt_auto_name_emp.Clear()

        'da = New OleDbDataAdapter("select * from emp where id_no='" + id_noo_combx.Text + "'", con)
        da = New OleDbDataAdapter("select * from emp where id_no='" + id_no_combx + "'", con)
        da.Fill(dt_auto_name_emp)
        If dt_auto_name_emp.Rows.Count > 0 Then
            Dim Name_emp As String
            'Name_Emp.Text = (dt_auto_name_emp.Rows(0)("name_emp")).ToString()
            Name_emp = (dt_auto_name_emp.Rows(0)("name_emp")).ToString()
            Me.Name_emp.Text = Name_emp
        Else
            Dim id As String = id_noo_combx.Text


        End If

    End Sub

    'الاستكمال التلقائى ل textbox====================================
    Public dt_auto_txt_Name_school As New DataTable
    Public Sub auto_txt_Name_school()
        Dim da As New OleDbDataAdapter
        dt_auto_txt.Clear()
        da = New OleDbDataAdapter("select school from emp", con)
        da.Fill(dt_auto_txt)
        Dim data_souce As New AutoCompleteStringCollection

        For i As Integer = 0 To dt_auto_txt.Rows.Count - 1
            data_souce.Add(dt_auto_txt.Rows(i)("school")).ToString()

        Next
        id_noo_combx.AutoCompleteCustomSource = data_souce
        id_noo_combx.AutoCompleteSource = AutoCompleteSource.CustomSource
        id_noo_combx.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    '====================================================
    'الاستكمال التلقائى لرقم القومى textbox====================================
    Public dt_auto_id_no As New DataTable
    Public Sub auto_id_no(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_id_no.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_emp.Text + "'", con)

        da.Fill(dt_auto_id_no)

        id_noo_combx.DataSource = dt_auto_id_no
        id_noo_combx.DisplayMember = "id_no"
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
    'insert ndb
    Public Sub Insert_nadb(ByVal id As Integer, ByVal name_emp As String, ByVal job As String, ByVal school As String, ByVal date_ndb As DateTime, ByVal al_gna As String, ByVal id_emp As String)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into nadb ( id,name_emp,job,school,date_ndb,al_gna,id_emp)values(@id,@name_emp,@job,@school,@date_ndb,@al_gna,@id_emp)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id", OleDbType.Integer).Value = id
            .Parameters.AddWithValue("@name_emp", OleDbType.VarChar).Value = name_emp
            .Parameters.AddWithValue("@job", OleDbType.VarChar).Value = job
            .Parameters.AddWithValue("@school", OleDbType.VarChar).Value = school
            .Parameters.AddWithValue("@date_ndb", OleDbType.Date).Value = date_ndb
            .Parameters.AddWithValue("@al_gna", OleDbType.VarChar).Value = al_gna
            .Parameters.AddWithValue("@id_emp", OleDbType.VarChar).Value = id_emp
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub

    '==========================
    Public dt_nadb_selcte_all As New DataTable
    Public Sub SelectAll_nadb(dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_nadb_selcte_all.Clear()
        da = New OleDbDataAdapter("select * from nadb", con)
        da.Fill(dt_nadb_selcte_all)
        dgv.DataSource = dt_nadb_selcte_all
        count_lbl.Text = (dt_nadb_selcte_all.Rows.Count()).ToString()
    End Sub

    '=========================================
    Public Sub Update_nadb(ByVal id As Integer, ByVal name_emp As String, ByVal job As String, ByVal school As String, ByVal date_ndb As DateTime, ByVal al_gna As String, ByVal id_emp As String)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update nadb Set id = @id,name_emp = @name_emp,job = @job,school = @school,date_ndb = @date_ndb,al_gna = @al_gna,id_emp = @id_emp Where id = @id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id", OleDbType.Integer).Value = id
            .Parameters.AddWithValue("@name_emp", OleDbType.VarChar).Value = name_emp
            .Parameters.AddWithValue("@job", OleDbType.VarChar).Value = job
            .Parameters.AddWithValue("@school", OleDbType.VarChar).Value = school
            .Parameters.AddWithValue("@date_ndb", OleDbType.Date).Value = date_ndb
            .Parameters.AddWithValue("@al_gna", OleDbType.VarChar).Value = al_gna
            .Parameters.AddWithValue("@id_emp", OleDbType.VarChar).Value = id_emp

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    'ط=======
    Public Function Max_nadb()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(id) From nadb ", con)
            If con.State = 1 Then con.Close()
            con.Open()
            Number = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Number = 0
            con.Close()
        End Try
        Return Number
    End Function
    '=======================
    Public Sub Delete_nadb(ByVal dgv_nadb As DataGridView)
        Dim Position As Integer = dgv_nadb.CurrentRow.Index
        Dim ID_Position As Integer = dgv_nadb.Rows(Position).Cells("Column1").Value
        Dim CmdDelete As New OleDbCommand
        With CmdDelete
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From nadb Where id = @id"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id", OleDbType.Integer).Value = ID_Position
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        CmdDelete.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        CmdDelete = Nothing
    End Sub


    '==========================
    Public Sub ClearControls()

        Me.Name_emp.Text = vbNullString
        Me.jop_txt.Text = vbNullString
        Me.Name_school.Text = vbNullString

        Me.lgna_txt.Text = vbNullString
        Me.id_noo_combx.Text = vbNullString
    End Sub
    '===========
    'delete _all_ndb
    Public Sub delete_all_ndb()


        Dim Cmd_Delete_all As New OleDbCommand
        With Cmd_Delete_all
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete * From nadb where id >1 "
            .Parameters.Clear()

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd_Delete_all.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف .", MsgBoxStyle.Information, "حذف")
        Cmd_Delete_all = Nothing
    End Sub

    'ط=====
    Private Sub Name_emp_KeyDown(sender As Object, e As KeyEventArgs) Handles Name_emp.KeyDown

        If chk_auto.CheckState = CheckState.Unchecked Then

            Try

                auto_Name_school(dt_auto_Name_school, Name_school, Name_emp.Text)
                auto_id_no(dt_auto_Name_school)




            Catch
                dt_auto_Name_school.Clear()

            End Try
        End If

        If e.KeyCode = Keys.Down Then
            jop_txt.Focus()
            jop_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_emp.Focus()
            Name_emp.BackColor = Color.Gold
        End If
    End Sub

    Private Sub id_noo_combx_Leave(sender As Object, e As EventArgs) Handles id_noo_combx.Leave
        Try
            Dim id As String = id_noo_combx.Text

            If chk_auto.CheckState = CheckState.Unchecked Then
                id_noo_combx.Text = id

                auto_name_emp(dt_auto_name_emp, id_noo_combx.Text)
                auto_Name_school(dt_auto_Name_school, Name_school, Name_emp.Text)
                auto_id_no(dt_auto_Name_school)

                id_noo_combx.Text = id
                If id.Length = 14 Then
                Else
                    msg_lbl.Text += "  التاكد من الرقم القومى" + id.Length.ToString()
                    'MessageBox.Show("  التاكد من الرقم القومى")
                    dt_auto_salary_ass.Clear()

                    id_noo_combx.Text = id
                End If


            Else
                dt_auto_name_emp.Clear()
                dt_auto_name_emp.Clear()
                dt_auto_Name_school.Clear()
                dt_auto_salary_ass.Clear()
                id_noo_combx.Text = id
                If id.Length = 14 Then
                Else
                    msg_lbl.Text += "  التاكد من الرقم القومى" + id.Length.ToString()
                    'MessageBox.Show("  التاكد من الرقم القومى")
                    dt_auto_salary_ass.Clear()


                End If
            End If
        Catch

            'dt_auto_Name_school.Clear()

        End Try

    End Sub



    Private Sub Name_emp_TextChanged(sender As Object, e As EventArgs) Handles Name_emp.TextChanged
        Try
            auto_txt_name_emp(Name_emp)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub jop_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles jop_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            jop_txt.Focus()
            jop_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            jop_txt.Focus()
            jop_txt.BackColor = Color.Gold
        End If
    End Sub

    Private Sub lgna_txt_KeyDown(sender As Object, e As KeyEventArgs) Handles lgna_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            lgna_txt.Focus()
            lgna_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            lgna_txt.Focus()
            lgna_txt.BackColor = Color.Gold
        End If
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        If Name_emp.Text.Trim() = "" Then
            ErrorProvider1.SetError(Name_emp, "يجب ادخال اسم الموظف  !...")
            isvalaied = False
            msg_lbl.Text += "يجب ادخال اسم الموظف "
        ElseIf Name_school.Text.Trim() = "" Then
            ErrorProvider1.SetError(Name_school, "يجب ادخال اسم المرسة  !...")
            isvalaied = False
            msg_lbl.Text += "يجب ادخال اسم الدرسة "
        ElseIf jop_txt.Text.Trim() = "" Then
            ErrorProvider1.SetError(jop_txt, "يجب ادخال اسم الوظيفه  !...")
            isvalaied = False
            msg_lbl.Text += "يجب ادخال اسم الوظيفة "
        ElseIf lgna_txt.Text.Trim() = "" Then
            ErrorProvider1.SetError(lgna_txt, "يجب ادخال اسم اللجنه  !...")
            isvalaied = False
            msg_lbl.Text += "يجب ادخال اسم اللجنه "
        Else
            Insert_nadb(Convert.ToInt32(Idlbl.Text), Name_emp.Text, jop_txt.Text, Name_school.Text, date1.Value, lgna_txt.Text, id_noo_combx.Text)
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            SelectAll_nadb(dgv_Table_add_tfrgh)
            ClearControls()
            Idlbl.Text = Max_nadb() +
                Name_emp.Focus()
        End If
    End Sub

    Private Sub add_ndb_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.date1.Value = Today
        Idlbl.Text = Max_nadb() + 1
        BtnEdit.Enabled = False
        BtnEdit.Visible = False
        BtnNewAdd.Enabled = True
        BtnNewAdd.Visible = True
        Name_emp.Focus()

    End Sub

    Private Sub chk_auto_CheckedChanged(sender As Object, e As EventArgs) Handles chk_auto.CheckedChanged
        If chk_auto.CheckState = CheckState.Checked Then
            chk_auto.Text = " ادخال يدوى"

        Else
            chk_auto.Text = "Auto"
        End If
    End Sub


    Private Sub Txt_seach_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_seach.KeyDown


        Txt_seach.BackColor = Color.Gold



    End Sub

    Private Sub Txt_seach_MouseEnter(sender As Object, e As EventArgs) Handles Txt_seach.MouseEnter
        Txt_seach.BackColor = Color.Gold
    End Sub

    Private Sub Txt_seach_Click(sender As Object, e As EventArgs) Handles Txt_seach.Click
        Txt_seach.BackColor = Color.Gold
    End Sub

    Private Sub dgv_Table_add_tfrgh_MouseClick(sender As Object, e As MouseEventArgs) Handles dgv_Table_add_tfrgh.MouseClick
        Try
            With dgv_Table_add_tfrgh
                Me.Idlbl.Text = .CurrentRow.Cells("Column1").Value.ToString()
                Me.Name_emp.Text = .CurrentRow.Cells("Column2").Value.ToString()
                Me.jop_txt.Text = .CurrentRow.Cells("Column3").Value.ToString()
                Me.Name_school.Text = .CurrentRow.Cells("Column4").Value.ToString()
                Me.date1.Value = .CurrentRow.Cells("Column5").Value.ToString()
                Me.lgna_txt.Text = .CurrentRow.Cells("Column6").Value.ToString()
                Me.id_noo_combx.Text = .CurrentRow.Cells("Column7").Value.ToString()
            End With
            BtnEdit.Enabled = True
            BtnEdit.Visible = True
            BtnNewAdd.Enabled = False
            BtnNewAdd.Visible = False
            BtnDelete.Visible = True


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        If Name_emp.Text.Trim() = "" Then
            ErrorProvider1.SetError(Name_emp, "يجب ادخال اسم الموظف  !...")
            isvalaied = False
            msg_lbl.Text += "يجب ادخال اسم الموظف "
        ElseIf Name_school.Text.Trim() = "" Then
            ErrorProvider1.SetError(Name_school, "يجب ادخال اسم المرسة  !...")
            isvalaied = False
            msg_lbl.Text += "يجب ادخال اسم الدرسة "
        ElseIf jop_txt.Text.Trim() = "" Then
            ErrorProvider1.SetError(jop_txt, "يجب ادخال اسم الوظيفه  !...")
            isvalaied = False
            msg_lbl.Text += "يجب ادخال اسم الوظيفة "
        ElseIf lgna_txt.Text.Trim() = "" Then
            ErrorProvider1.SetError(lgna_txt, "يجب ادخال اسم اللجنه  !...")
            isvalaied = False
            msg_lbl.Text += "يجب ادخال اسم اللجنه "
        Else
            Update_nadb(Convert.ToInt32(Idlbl.Text), Name_emp.Text, jop_txt.Text, Name_school.Text, date1.Value, lgna_txt.Text, id_noo_combx.Text)
            SelectAll_nadb(dgv_Table_add_tfrgh)
            Idlbl.Text = Max_nadb() + 1
            BtnEdit.Enabled = False
            BtnEdit.Visible = False
            BtnNewAdd.Enabled = True
            BtnNewAdd.Visible = True
            ClearControls()
            Name_emp.Focus()
        End If
    End Sub

    Private Sub Btn_new_Click(sender As Object, e As EventArgs) Handles Btn_new.Click
        BtnEdit.Enabled = False
        BtnEdit.Visible = False
        BtnNewAdd.Enabled = True

        Idlbl.Text = Max_nadb() + 1
        SelectAll_nadb(dgv_Table_add_tfrgh)
        ClearControls()
        Name_emp.Focus()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_nadb(dgv_Table_add_tfrgh)
            BtnEdit.Enabled = False
            BtnEdit.Visible = False
            BtnNewAdd.Enabled = True

            Idlbl.Text = Max_nadb() + 1
            SelectAll_nadb(dgv_Table_add_tfrgh)
            ClearControls()
            Name_emp.Focus()
            BtnDelete.Visible = False
        End If


        ClearControls()
    End Sub

    Private Sub Txt_seach_TextChanged(sender As Object, e As EventArgs) Handles Txt_seach.TextChanged
        Try
            Dim dv As DataView = dt_nadb_selcte_all.DefaultView
            dv.RowFilter = " name_emp LIKE '%" & Txt_seach.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

    End Sub

    Private Sub Name_emp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Name_emp.KeyPress
        Name_emp.BackColor = Color.Gold
    End Sub

    Private Sub Name_school_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Name_school.KeyPress
        Name_school.BackColor = Color.Gold
    End Sub

    Private Sub Name_emp_Leave(sender As Object, e As EventArgs) Handles Name_emp.Leave
        Name_emp.BackColor = Color.Orange
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            delete_all_ndb()
            BtnEdit.Enabled = False
            BtnEdit.Visible = False
            BtnNewAdd.Enabled = True

            Idlbl.Text = Max_nadb() + 1
            SelectAll_nadb(dgv_Table_add_tfrgh)
            ClearControls()
            Name_emp.Focus()


        End If
    End Sub

 

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_ex_to_excell.Click
        Try
            If dt_nadb_selcte_all.Rows.Count > 0 Then
                btn_ex_to_excell.Enabled = False
                btn_ex_to_excell.Text = "Wait"
                SaveGridToExcel_all_tfrgh(dgv_Table_add_tfrgh)
                btn_ex_to_excell.Text = "تصدير البيانات الى اكسيل"
                btn_ex_to_excell.Enabled = True
            Else
                MessageBox.Show("يجب تحميل البيانات اولا ...")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

   


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New view_frm_2()
        Dim da As New OleDbDataAdapter


        da = New OleDbDataAdapter("SELECT * FROM nadb", con)

        da.Fill(frm.DataSet_ndb.nadb)
        'frm.nadbTableAdapter.Fill(frm.DataSet_ndb.nadb)
        frm.ReportViewer1.RefreshReport()
        frm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New view_frm_3()
        Dim da As New OleDbDataAdapter


        da = New OleDbDataAdapter("SELECT * FROM nadb", con)

        da.Fill(frm.DataSet_ndb.nadb)
        'frm.nadbTableAdapter.Fill(frm.DataSet_ndb.nadb)
        frm.ReportViewer1.RefreshReport()
        frm.Show()
    End Sub
End Class