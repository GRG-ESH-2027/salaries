Imports System.Data.OleDb
Public Class Form_add_tfrgh

    Public stat_frm As String
    Public no_k As Integer
    Public no_kshfff As Integer
    Public mkf_count As Integer
    Public cel As Integer = 2
    Public cel_r As Integer = 30
    Public drab As Double = 0.08
    'Public id As String

    '=================================================================

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

    'الاستكمال التلقائى نوع المدفوعه textbox====================================
    Public dt_auto_name_pay As New DataTable
    Public Sub auto_name_pay(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_name_pay.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_emp.Text + "'", con)

        da.Fill(dt_auto_name_pay)

        cmbx_name_pay.DataSource = dt_auto_name_pay
        cmbx_name_pay.DisplayMember = "name_pay"

    End Sub

    'الاستكمال التلقائى  القطاع textbox====================================
    Public dt_auto_alkta As New DataTable
    Public Sub auto_alkta(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_alkta.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_emp.Text + "'", con)

        da.Fill(dt_auto_alkta)

        cmbx_alkta.DataSource = dt_auto_alkta
        cmbx_alkta.DisplayMember = "al_kta"

    End Sub

    'الاستكمال التلقائى  رقم الموظف textbox====================================
    Public dt_auto_no_emp As New DataTable
    Public Sub auto_no_emp(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_no_emp.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_emp.Text + "'", con)

        da.Fill(dt_auto_no_emp)

        cmbx_no_emp.DataSource = dt_auto_no_emp
        cmbx_no_emp.DisplayMember = "no_emb"

    End Sub

    '================================
    Public Sub select_drab_a()


        Try
            If id_noo_combx.Text <> "" Then
                auto_salary_ass_drab(id_noo_combx.Text, drab)
                If dt_auto_salary_ass_drab.Rows.Count > 0 Then
                    drab = dt_auto_salary_ass_drab.Rows(0)("Drab")



                    select_drab.Text = Convert.ToString(drab) + "ضرائب"


                End If


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '==================================


    Public Sub ClearControls()
        Me.Id.Text = vbNullString
        Me.No_55.Text = vbNullString

        Me.Name_emp.Text = vbNullString
        Name_school.Text = vbNullString
        Me.id_noo_combx.Text = vbNullString
        Me.ComboBox_Salary_ass.Text = vbNullString
        'Me.Salary_ass.Value = 0
        Me.Dayes_1.Text = vbNullString
        Me.Mkf_1.Value = 0
        Me.mkf_22.Text = 0

        Me.Badl_safer.Text = vbNullString
        Me.Entklat_1.Text = vbNullString
        Me.total_mkff.Value = vbNullString
        Me.Mashat_9.Text = vbNullString
        Me.mash1_1.Text = vbNullString
        Me.Darabb_1.Text = vbNullString
        Me.nkba_1.Text = vbNullString
        Me.tamen_11.Text = vbNullString
        Me.Mastshfa_1.Text = vbNullString
        Me.Damghh_1.Text = vbNullString
        Me.Earaadta_1.Text = vbNullString
        Me.box_1.Text = vbNullString
        Me.Total_Mostkta_1.Text = vbNullString
        Me.Saffy_1.Text = vbNullString
        'Me.Id_Mkf.Text = vbNullString
        Me.date_1.Value = Today
        Me.mash1_1.Text = vbNullString
        Me.nkba_1.Text = vbNullString
        Me.box_1.Text = vbNullString
        Me.saffa_after_1.Text = vbNullString
        Me.Mzay_t17.Text = vbNullString
        cmbx_name_pay.Text = ""
        cmbx_alkta.Text = ""
        cmbx_no_emp.Text = ""
        id_noo_combx.Text = ""

        No_55.Enabled = True
        ComboBox_Salary_ass.Enabled = True
        Dayes_1.Enabled = True
        Name_emp.Enabled = True
        id_noo_combx.Enabled = True
        Mkf_1.Enabled = True
        Badl_safer.Enabled = True
        Entklat_1.Enabled = True
        Mashat_9.Enabled = True
        Darabb_1.Enabled = True
        tamen_11.Enabled = True
        Mastshfa_1.Enabled = True
        Damghh_1.Enabled = True
        Earaadta_1.Enabled = True
        Mzay_t17.Enabled = True
        id_noo_combx.Text = ""

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form_all_mkf.frm_stat = "add"
        'Form_add_mkf.MdiParent = Form1
        ''Dim frm As New Form_add_mkf
        ''frm.Size = New Size(900, 500)
        ' ''frm.dgv_Table_Mkf.Size = New Size(1200, 600)
        'Form_add_mkf.dgv_Table_Mkf.Size = New Size(900, 500)
        ''frm.Show()
        'Form_add_mkf.Show()
        'Form_all_mkf.MdiParent = Form1
        'Form_all_mkf.Show()
        Form_add_mkf.ShowDialog()

    End Sub

    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.Click
        Try
            btn_cal_Click(sender, e)
            '===
            If (rb_mlahza.Checked = True And auto_total_1.Checked = False) Then




                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()
                total_day_cal()
                '=================
                'اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                if_total_larg_than_4000()
            End If
            '===================================
            Txt_seach.Text = ""
            Dim isvalaied As Boolean
            ErrorProvider1.Clear()
            msg_lbl.Text = ""

            If Convert.ToDouble(Me.Saffy_1.Text) <= 0 Then
                'ErrorProvider1.SetError(Saffy, "يجب التاكد من الصافى  !...")
                'isvalaied = False
                MessageBox.Show(" يجب التاكد من الجملة ..؟")
                msg_lbl.Text += "يجب التاكد من الجملة ..؟"
                Exit Sub
            End If


            select_no_55(No_55.Value)
            If dt_select_no_55.Rows.Count > 0 Then

                MessageBox.Show("رقم 55 ع ح مسجل من قبل  ...!")
                ErrorProvider1.SetError(No_55, "تاكد من رقم 55  !...")
                isvalaied = False
                msg_lbl.Text += "  تاكد من رقم 55  !..  ..؟"

            ElseIf Id_Mkf_1.Text.Trim = "" Then
                ErrorProvider1.SetError(Button1, "يجب اختيار اسم مكافاة !...")
                isvalaied = False
                msg_lbl.Text += "  يجب اختيار اسم مكافاة.؟"

                '    'عندما يكون تحديد تصحيح المرتب الاساى فارغ =0
                'ElseIf Me.ComboBox_Salary_ass.Text = vbNullString Then
                '    Me.ComboBox_Salary_ass.Text = "0"

                'ElseIf rb_tsh.Checked = False Then

                '    Me.ComboBox_Salary_ass.Text = "0"

            ElseIf No_55.Text.Trim = "" Then
                ErrorProvider1.SetError(No_55, "يجب ادخال رقم 55 ع ح  !...")
                isvalaied = False
                msg_lbl.Text += "  يجب ادخال رقم 55 ع ح  "
            ElseIf Name_emp.Text.Trim = "" Then
                ErrorProvider1.SetError(Name_emp, "يجب ادخال اسم الموظف  !...")
                isvalaied = False
                msg_lbl.Text += "يجب ادخال اسم الموظف  !..."
            ElseIf lbl_erro.Text = "1" Then
                ErrorProvider1.SetError(Name_emp, "اسم الموظف تم ادخاله من قبل !...")
                isvalaied = False
                msg_lbl.Text += "اسم الموظف تم ادخاله من قبل !..."
                MessageBox.Show("رقم القومى مسجل من قبل  ...!")
            ElseIf Convert.ToDouble(Me.Saffy_1.Text) <= 0 Then
                ErrorProvider1.SetError(Saffy_1, "يجب التاكد من الصافى  !...")
                isvalaied = False

            ElseIf Id_Mkf_1.Text = "" Or No_55.Text = "" Or Name_emp.Text = "" Or dt_select_no_kash.Rows.Count > 18 Or Convert.ToDouble(Me.Saffy_1.Text) <= 0 Then
                MessageBox.Show("يجب التاكد من الجمله اادخال اسم الموظف ,وادخال المكافاة وادخال رقم 55 ع ح و اختيار مكافاة")




            Else
                'isvalaied = True
                total_mkf()
                total_mostakt()
                total_sffy()
                total_sffy_after_Entkal()
                '=================
                'اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                if_total_larg_than_4000()
                Insert_Table_mkf_add(Convert.ToInt32(Idlbl.Text), id_and_user.Text, Convert.ToInt32(No_55.Text), Convert.ToInt32(no_kshf.Text), Name_emp.Text, Name_school.Text, Convert.ToDouble(ComboBox_Salary_ass.Text), Convert.ToInt32(Dayes_1.Text), Mkf_1.Value, Convert.ToDouble(mkf_22.Text), Badl_safer.Value, Entklat_1.Value, total_mkff.Value, Mashat_9.Value, mash1_1.Value, Darabb_1.Value, nkba_1.Value, tamen_11.Value, Mastshfa_1.Value, Convert.ToDouble(Damghh_1.Value), Earaadta_1.Value, box_1.Value, Mzay_t17.Value, Convert.ToDouble(Total_Mostkta_1.Text), Convert.ToDouble(Saffy_1.Text), Convert.ToInt32(Id_Mkf_1.Text), date_1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, Convert.ToDouble(saffa_after_1.Text), radb_nkaba.Checked, rb_tsh.Checked, Convert.ToInt32(txt_user.Text), chk_auto.Checked, auto_total_1.Checked, rb_mlahza.Checked, cbx_sharta.Checked, rb_zar.Checked)
                MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
                'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
                Idlbl.Text = Max_Table_mkf_add() + 1
                id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                SelectAll_Table_no_kshf(no_k)
                no_kshfff = no_kshf.Value

                select_no_kash(no_kshfff)
                dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
                ClearControls()
                Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()

                'ايجاد اخر سطرفى دات
                'dgv_Table_add_tfrgh.Focus()
                dgv_Table_add_tfrgh.CurrentCell = dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(1)
                id_noo_combx.BackColor = Color.Gold
                id_noo_combx.Focus()
                'isvalaied = True
                ErrorProvider1.Clear()
                msg_lbl.Text = ""
                radb_nkaba.Checked = False
                drab = 10
                select_drab.Text = " ضرائب" + Convert.ToString(drab)
                Me.Darabb_1.Text = vbNullString

            End If
            If dt_select_no_kash.Rows.Count > 18 Then
                MessageBox.Show("لا يمكن اضافة يجب انشاء كشف تفريغ جديد")
                If MessageBox.Show("هل تريد انشاء كشف تفريغ جديد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    Form_all_mkf.frm_stat = "add"
                    isvalaied = True
                    Idlbl.Text = Max_Table_mkf_add() + 1
                    id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                    no_kshf.Text = Max_no_kshf() + 1
                    no_kshfff = no_kshf.Value

                    select_no_kash(no_kshfff)
                    dgv_Table_add_tfrgh.DataSource = dt_select_no_kash

                    auto_txt_name_emp(Name_emp)
                    auto_txt_Name_school()
                    'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

                    BtnNewAdd.Enabled = True
                    radb_nkaba.Checked = False
                    ClearControls()
                    Label9.Text = "0"
                    'drab = 10
                    select_drab.Text = " ضرائب" + Convert.ToString(drab)
                    Me.Darabb_1.Text = vbNullString

                End If
            End If
            '==================لعرض الاسم======
            If dgv_Table_add_tfrgh.Rows.Count > 0 Then

                dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(20).Selected = True


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            con.Close()

        End Try

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Update_Table_mkf_add(Id.Text, No_55.Text, no_kshf.Text, Name_Emp.Text, Name_school.Text, , Dayes.Text, , , , , , , , , , , , , Id_Mkf.Text, date1.Value)

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try


        Txt_seach.Text = ""
        Form_all_mkf.frm_stat = "add"
        dgv_Table_add_tfrgh.ClearSelection()
        no_k = Max_no_kshf()

        open_text_box()
        Idlbl.Text = Max_Table_mkf_add() + 1

        id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
        no_kshfff = Max_no_kshf()

        no_k = Max_no_kshf()

        select_no_kash(no_kshfff)
        dgv_Table_add_tfrgh.DataSource = dt_select_no_kash

        auto_txt_name_emp(Name_emp)


        BtnNewAdd.Enabled = True
        btn_save_sharta.Enabled = True
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        ClearControls()


        '======تحميل جدول المكافاة

        Dim Id_Mkff As Integer

        Id_Mkff = dgv_Table_add_tfrgh.CurrentRow.Cells("Id_Mkf").Value

        Id_Mkff = Id_Mkff
        Id_Mkf_1.Text = Id_Mkff.ToString()
        select_id_mkf(Convert.ToInt32(Id_Mkff))
        DataGridView1.DataSource = dt_select_id_mkf
        Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
        Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
        Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
        term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()



        SelectSome_Table_mkf_add_indirect(ListBox1)

        SelectAll_Table_no_kshf(no_k)
        dgv_Table_add_tfrgh.DataSource = dt_Table_mkf_no_kshff


        'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

        'try_form.DataGridViewHeaderTxxtedit(dgv_Table_add_tfrgh)

        no_k = Max_no_kshf()

        ListBox1.SelectedValue = no_k
        Me.no_kshf.Text = dgv_Table_add_tfrgh.CurrentRow.Cells("no_kashf").Value.ToString()
        Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
        'ايجاد اخر سطرفى دات
        'dgv_Table_add_tfrgh.Focus()
        dgv_Table_add_tfrgh.CurrentCell = dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(1)
        id_noo_combx.Focus()
        Name_emp.BackColor = Color.Gold

        'عرض العمود رقم 21
        If dgv_Table_add_tfrgh.Rows.Count > 0 Then

            dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(20).Selected = True

        End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)

        'End Try
        'auto_txt_
        'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_mkf_tfrgh(dgv_Table_add_tfrgh)

            SelectAll_Table_no_kshf(no_kshf.Value)
            dgv_Table_add_tfrgh.DataSource = dt_Table_mkf_no_kshff
            'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
            Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()

        End If

    End Sub






    Public Sub total_mkf()
        Dim tot_mkf As Double = 0
        If Me.Mkf_1.Text = vbNullString Then
            Me.Mkf_1.Text = "0"
        End If
        If Me.mkf_22.Text = vbNullString Then
            Me.mkf_22.Text = "0"
        End If
        If Me.Dayes_1.Text = vbNullString Then
            Me.Dayes_1.Text = "0"

        End If

        If Me.Badl_safer.Text = vbNullString Then
            Me.Badl_safer.Text = "0"
        End If
        If Me.Entklat_1.Text = vbNullString Then
            Me.Entklat_1.Text = "0"
        End If
        tot_mkf = tot_mkf + Mkf_1.Value + Convert.ToDouble(mkf_22.Text)
        total_mkff.Value = tot_mkf
    End Sub

    Private Sub Badl_safer_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        total_mkf()
        total_sffy()
        Badl_safer.BackColor = Color.White
    End Sub

    Private Sub Entklat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        total_mkf()
        total_sffy()
        Entklat_1.BackColor = Color.White
    End Sub

    Public Sub total_mostakt()
        Dim tot_mos, Msht, Darab, Mhan, Mastshf, Damgh, Earaadt, mas8, nkb, box20, Mash_17 As Double

        tot_mos = 0
        If Me.Mashat_9.Text = vbNullString Then
            Me.Mashat_9.Text = "0"

        End If

        If Me.Darabb_1.Text = vbNullString Then
            Me.Darabb_1.Text = "0"
        End If

        If Me.tamen_11.Text = vbNullString Then
            Me.tamen_11.Text = "0"
        End If

        If Me.Mastshfa_1.Text = vbNullString Then
            Me.Mastshfa_1.Text = "0"
        End If

        If Me.Damghh_1.Text = vbNullString Then
            Me.Damghh_1.Text = " 0"
        End If

        If Me.Earaadta_1.Text = vbNullString Then
            Me.Earaadta_1.Text = "0"
        End If

        If Me.mash1_1.Text = vbNullString Then
            Me.mash1_1.Text = "0"
        End If

        If Me.nkba_1.Text = vbNullString Then
            Me.nkba_1.Text = "0"
        End If

        If Me.box_1.Text = vbNullString Then
            Me.box_1.Text = "0"
        End If

        If Me.Mzay_t17.Text = vbNullString Then
            Me.Mzay_t17.Text = "0"
        End If
        Try
            Msht = Convert.ToDouble(Mashat_9.Value)
            Darab = Convert.ToDouble(Darabb_1.Value)
            Mhan = Convert.ToDouble(tamen_11.Value)
            Mastshf = Convert.ToDouble(Mastshfa_1.Value)
            Damgh = Convert.ToDouble(Damghh_1.Value)
            Earaadt = Convert.ToDouble(Earaadta_1.Value)
            mas8 = Convert.ToDouble(mash1_1.Value)
            nkb = Convert.ToDouble(nkba_1.Value)
            box20 = Convert.ToDouble(box_1.Value)
            Mash_17 = Convert.ToDouble(Mzay_t17.Value)
            tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20 + Mash_17
            Total_Mostkta_1.Text = tot_mos.ToString()
        Catch ex As Exception
            MessageBox.Show("يجب ادخال رقم صحيح")
            Msht = 0
            Msht = Mashat_9.Value

        End Try

    End Sub
    Public Sub total_sffy()
        Dim tota_sff As Double = 0
        tota_sff = total_mkff.Value - Convert.ToDouble(Total_Mostkta_1.Text)
        Saffy_1.Text = tota_sff.ToString()
    End Sub
    '============================الصافى بعد الانتقالات =============
    Public Sub total_sffy_after_Entkal()
        Dim tota_sff_after As Double = 0
        tota_sff_after = (total_mkff.Value - Convert.ToDouble(Total_Mostkta_1.Text)) + Entklat_1.Value + Badl_safer.Value
        saffa_after_1.Text = tota_sff_after.ToString()
    End Sub

    Private Sub Mashat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        total_mkf()
        total_mostakt()
        total_sffy()
        Mashat_9.BackColor = Color.White
    End Sub
    '=========================================
    'حساب عدد الايام
    'ط================
    Public Sub total_day_cal()
        Dim tot_mos, Msht, Darab, Mhan, Mastshf, Damgh, Earaadt, mas8, nkb, box20, Mash_17 As Double
        tot_mos = 0



        Try
            Msht = Convert.ToDouble(Mashat_9.Value)
            Darab = Convert.ToDouble(Darabb_1.Value)
            Mhan = Convert.ToDouble(tamen_11.Value)
            Mastshf = Convert.ToDouble(Mastshfa_1.Value)
            Damgh = Convert.ToDouble(Damghh_1.Value)
            Earaadt = Convert.ToDouble(Earaadta_1.Value)
            mas8 = Convert.ToDouble(mash1_1.Value)

            nkb = Convert.ToDouble(nkba_1.Value)


            box20 = Convert.ToDouble(box_1.Value)
            Mash_17 = Convert.ToDouble(Mzay_t17.Value)
            '=============
            Mashat_9.Value = 0
            Darabb_1.Value = 0
            tamen_11.Value = 0
            Mastshfa_1.Value = 0
            Damghh_1.Value = 0
            Earaadta_1.Value = 0
            mash1_1.Value = 0
            nkba_1.Value = 0
            box_1.Value = 0
            Mzay_t17.Value = 0
            '====================================
            'حساب الملاحظه الاعداديه
            If (rb_mlahza.Checked = True And Radio_b_work.Checked = False And mkf_count = 5) Then
                'Mkf_1.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_1.Value)
                Mkf_1.Value = Math.Floor(130 * Dayes_1.Value)




                auto_salary_ass_drab(id_noo_combx.Text, drab)

                If (Radio_drab.Checked = True) Then


                    Darabb_1.Value = Math.Round(total_mkff.Value * 0)
                Else
                    drab = Convert.ToDouble(Num_drab.Value)
                    Darabb_1.Value = Math.Round(total_mkff.Value * drab)
                End If




                Mashat_9.Value = Math.Round((total_mkff.Value * 9) / 100, 1, MidpointRounding.AwayFromZero)
                'Mzay_t17.Value = Math.Round((total_mkff.Value * 17.25) / 100, 1, MidpointRounding.AwayFromZero)


                If (radb_nkaba.Checked = True) Then
                    nkba_1.Value = Math.Round((total_mkff.Value * 2) / 100, 1)
                    Mastshfa_1.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                ElseIf (radb_nkaba.Checked = False) Then
                    nkba_1.Value = 0
                    Mastshfa_1.Value = 0

                End If

                mash1_1.Value = Math.Round((total_mkff.Value * 1) / 100, 1)
                tamen_11.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                If total_mkff.Value >= 50 Then
                    Damghh_1.Value = Math.Round((total_mkff.Value * 0.008))
                Else
                    Damghh_1.Value = 0
                End If
                box_1.Value = 0
                box20 = 0



                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20 + Mash_17
                Total_Mostkta_1.Text = tot_mos.ToString()


            End If
            '====================================
            'حساب الملاحظه الثانوية 
            If (rb_mlahza.Checked = True And mkf_count = 7) Then
                Mkf_1.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_1.Value)





                auto_salary_ass_drab(id_noo_combx.Text, drab)

                If (Radio_drab.Checked = True) Then


                    Darabb_1.Value = Math.Round(total_mkff.Value * 0)
                Else
                    drab = Convert.ToDouble(Num_drab.Value)
                    Darabb_1.Value = Math.Round(total_mkff.Value * drab)
                End If




                Mashat_9.Value = Math.Round((total_mkff.Value * 9) / 100, 1, MidpointRounding.AwayFromZero)
                'Mzay_t17.Value = Math.Round((total_mkff.Value * 17.25) / 100, 1, MidpointRounding.AwayFromZero)


                If (radb_nkaba.Checked = True) Then
                    nkba_1.Value = Math.Round((total_mkff.Value * 2) / 100, 1)
                    Mastshfa_1.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                ElseIf (radb_nkaba.Checked = False) Then
                    nkba_1.Value = 0
                    Mastshfa_1.Value = 0

                End If

                mash1_1.Value = Math.Round((total_mkff.Value * 1) / 100, 1)
                tamen_11.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                If total_mkff.Value >= 50 Then
                    Damghh_1.Value = Math.Round((total_mkff.Value * 0.008))
                Else
                    Damghh_1.Value = 0
                End If
                box_1.Value = 0
                box20 = 0



                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20 + Mash_17
                Total_Mostkta_1.Text = tot_mos.ToString()


            End If
            '=====================================================
            'حساب العمال 
            '===========
            If (rb_mlahza.Checked = True And Radio_b_work.Checked = True) Then
                Mkf_1.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_1.Value)
                'Mkf_1.Value = Math.Floor(130 * Dayes_1.Value)




                auto_salary_ass_drab(id_noo_combx.Text, drab)


                'Darabb_1.Value = Math.Round(total_mkff.Value * drab)
                If (Radio_drab.Checked = True) Then


                    Darabb_1.Value = Math.Round(total_mkff.Value * 0)
                Else
                    drab = Convert.ToDouble(Num_drab.Value)
                    Darabb_1.Value = Math.Round(total_mkff.Value * drab)
                End If


                Mashat_9.Value = Math.Round((total_mkff.Value * 9) / 100, 1, MidpointRounding.AwayFromZero)
                'Mzay_t17.Value = Math.Round((total_mkff.Value * 17.25) / 100, 1, MidpointRounding.AwayFromZero)


                If (radb_nkaba.Checked = True) Then
                    nkba_1.Value = Math.Round((total_mkff.Value * 2) / 100, 1)
                    Mastshfa_1.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                ElseIf (radb_nkaba.Checked = False) Then
                    nkba_1.Value = 0
                    Mastshfa_1.Value = 0

                End If

                mash1_1.Value = Math.Round((total_mkff.Value * 1) / 100, 1)
                tamen_11.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                If total_mkff.Value >= 50 Then
                    Damghh_1.Value = Math.Round((total_mkff.Value * 0.008))
                Else
                    Damghh_1.Value = 0
                End If
                box_1.Value = 0
                box20 = 0



                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20 + Mash_17
                Total_Mostkta_1.Text = tot_mos.ToString()


            End If

            '=================   ========    حساب تصحيح         

            If (rb_tsh.Checked = True) Then
                'Mkf.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes.Value)
                Mkf_1.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_1.Value)

                'If drab = 10 Then

                If (Radio_drab.Checked = True) Then


                    Darabb_1.Value = Math.Round(total_mkff.Value * 0)
                Else
                    drab = Convert.ToDouble(Num_drab.Value)
                    Darabb_1.Value = Math.Round(total_mkff.Value * drab)
                End If

                'ElseIf drab = 5 Then
                '    Darabb.Value = Math.Round((total_mkff.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
                'ElseIf drab = 15 Then
                '    Darabb.Value = Math.Round((total_mkff.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)

                'End If

                Mashat_9.Value = Math.Round((total_mkff.Value * 9) / 100, 1, MidpointRounding.AwayFromZero)



                If (radb_nkaba.Checked = True) Then
                    nkba_1.Value = Math.Round((total_mkff.Value * 2) / 100, 1)
                    Mastshfa_1.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                ElseIf (radb_nkaba.Checked = False) Then
                    nkba_1.Value = 0
                    Mastshfa_1.Value = 0

                End If

                mash1_1.Value = Math.Round((total_mkff.Value * 1) / 100, 1)
                tamen_11.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                If total_mkff.Value >= 50 Then
                    Damghh_1.Value = Math.Round((total_mkff.Value * 0.7) / 100, 1)
                Else
                    Damghh_1.Value = 0
                End If
                box_1.Value = 0
                box20 = 0
                'Mzay_t17.Value = Math.Round((total_mkff.Value * 17.25) / 100, 1, MidpointRounding.AwayFromZero)
                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20 + Mash_17
                Total_Mostkta_1.Text = tot_mos.ToString()
            End If
            '=====================================================
            'حساب زائر الصحى
            If (rb_zar.Checked = True) Then
                rad_b_no_nokapy.Checked = True
                Cmbx_nokapa.Text = "ادارى"
                Mkf_1.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_1.Value)
                If Me.ComboBox_Salary_ass.Text = vbNullString Then
                    Me.ComboBox_Salary_ass.Text = "1"
                End If
                'Mkf_1.Value = Math.Floor(130 * Dayes_1.Value)




                'drab = 10
                Darabb_1.Value = Math.Round((total_mkff.Value * 10) / 100, 1, MidpointRounding.AwayFromZero)
                'ElseIf drab = 5 Then
                '    Darabb_1.Value = Math.Round((total_mkff.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
                'ElseIf drab = 15 Then
                '    Darabb_1.Value = Math.Round((total_mkff.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)

                'End If
                'Mashat.Value = Math.Round((Mkf.Value * 9) / 100, 1, MidpointRounding.AwayFromZero)

0:



                Mashat_9.Value = 0
                nkba_1.Value = 0
                Mastshfa_1.Value = 0
                mash1_1.Value = 0
                tamen_11.Value = 0
                box_1.Value = 0
                'End If

                'mash1.Value = Math.Round((Mkf.Value * 1) / 100, 1)
                'tamen_1.Value = Math.Round((Mkf.Value * 1) / 100, 1)

                If total_mkff.Value >= 50 Then
                    Damghh_1.Value = Math.Round((total_mkff.Value * 0.7) / 100, 1)
                Else
                    Damghh_1.Value = 0
                End If
                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20
                Total_Mostkta_1.Text = tot_mos.ToString()
            End If

            '==================================================
            '==============================================================
            ' الشرطه : حساب عدد الايام
            'ط================

            'Public Sub total_day_cal_sharta()
            'Dim tot_mos, Msht, Darab, Mhan, Mastshf, Damgh, Earaadt, mas8, nkb, box20 As Double
            tot_mos = 0

            If (cbx_sharta.Checked = True) Then

                'Try
                'Msht = Convert.ToDouble(Mashat_1.Value)
                'Darab = Convert.ToDouble(Darabb_1.Value)
                'Mhan = Convert.ToDouble(tamen_11.Value)
                'Mastshf = Convert.ToDouble(Mastshfa_1.Value)
                'Damgh = Convert.ToDouble(Damghh_1.Value)
                'Earaadt = Convert.ToDouble(Earaadta_1.Value)
                'mas8 = Convert.ToDouble(mash1_1.Value)

                'nkb = Convert.ToDouble(nkba_1.Value)


                'box20 = Convert.ToDouble(box_1.Value)

                If Me.ComboBox_Salary_ass.Text = vbNullString Then
                    Me.ComboBox_Salary_ass.Text = "1"
                End If


                Mkf_1.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_1.Value)
                'Mkf_1.Value = Math.Floor(130 * Dayes_1.Value)
                Darabb_1.Value = Math.Round((total_mkff.Value * 10) / 100, 1, MidpointRounding.AwayFromZero)
                'ElseIf drab = 5 Then
                '    Darabb_1.Value = Math.Round((total_mkff.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
                'ElseIf drab = 15 Then
                '    Darabb_1.Value = Math.Round((total_mkff.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)

                'End If
                box_1.Value = Math.Round((total_mkff.Value * 20) / 100, 1)
                Mashat_9.Value = 0
                nkba_1.Value = 0
                Mastshfa_1.Value = 0
                mash1_1.Value = 0
                tamen_11.Value = 0

                If total_mkff.Value >= 50 Then
                    Damghh_1.Value = Math.Round((total_mkff.Value * 0.7) / 100, 1)
                Else
                    Damghh_1.Value = 0
                End If
                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20
                Total_Mostkta_1.Text = tot_mos.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Msht = 0
            Msht = Mashat_9.Value

        End Try

    End Sub


    '==========================

    Public Sub if_total_larg_than_4000()



        If Convert.ToDouble(saffa_after_1.Text) >= 4000 And drab > 5 Then
            drab = 0.09
            select_drab.Text = " ضرائب" + Convert.ToString(drab)
            total_day_cal()
            total_mkf()
            total_mostakt()

            total_sffy()
            total_sffy_after_Entkal()
            total_day_cal()
            'Button4_Click(sender, e)
        Else
            select_drab.Text = " ضرائب" + Convert.ToString(drab)
            drab = drab
        End If
    End Sub
    '=============================================
    Private Sub Salary_ass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            Dayes_1.Focus()
            Dayes_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_emp.Focus()
            Name_emp.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Left Then
            Badl_safer.Focus()
            Badl_safer.BackColor = Color.Gold
        End If
    End Sub

    Private Sub No_55_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles No_55.KeyDown
        If e.KeyCode = Keys.Down Then
            Badl_safer.Focus()
            Badl_safer.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            '    no_gp.Focus()
            Dayes_1.Focus()
            Dayes_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Left Then
            Mkf_1.Focus()
            Mkf_1.BackColor = Color.Gold
        End If


    End Sub

    Private Sub Dayes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dayes_1.KeyDown
        If e.KeyCode = Keys.Down Then
            No_55.Focus()
            No_55.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            ComboBox_Salary_ass.Focus()
            ComboBox_Salary_ass.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Left Then
            Entklat_1.Focus()
            Entklat_1.BackColor = Color.Gold
        End If


    End Sub

    Private Sub Mkf_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mkf_1.KeyDown
        If e.KeyCode = Keys.Down Then
            Darabb_1.Focus()
            Darabb_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Entklat_1.Focus()
            Entklat_1.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Right Then
            No_55.Focus()
            No_55.BackColor = Color.Gold
        End If

    End Sub

    Private Sub Badl_safer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Badl_safer.KeyDown
        If e.KeyCode = Keys.Down Then
            Entklat_1.Focus()
            Entklat_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            No_55.Focus()
            No_55.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Right Then
            ComboBox_Salary_ass.Focus()
            ComboBox_Salary_ass.BackColor = Color.Gold
        End If

    End Sub

    Private Sub Entklat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Entklat_1.KeyDown
        If e.KeyCode = Keys.Down Then
            Mkf_1.Focus()
            Mkf_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Badl_safer.Focus()
            Badl_safer.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Right Then
            Dayes_1.Focus()
            Dayes_1.BackColor = Color.Gold
        End If

    End Sub


    Private Sub Name_Emp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)


        'If e.KeyCode = Keys.Up Then
        '    Entklat.Focus()
        '    Entklat.BackColor = Color.Gold
        'End If

        Try
            auto_Name_school(dt_auto_Name_school, Name_school, Name_emp.Text)
            auto_id_no(dt_auto_Name_school)
            auto_name_pay(dt_auto_Name_school)
            auto_alkta(dt_auto_Name_school)
            auto_no_emp(dt_auto_Name_school)
        Catch
            dt_auto_Name_school.Clear()

        End Try
        If e.KeyCode = Keys.Down Then
            ComboBox_Salary_ass.Focus()
            ComboBox_Salary_ass.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Name_school_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            Mashat_9.Focus()
            Mashat_9.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_emp.Focus()
            Name_emp.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Mashat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mashat_9.KeyDown
        If nkba_1.Visible = False Then

            If e.KeyCode = Keys.Down Then
                mash1_1.Focus()
                mash1_1.BackColor = Color.Gold




            End If

            If e.KeyCode = Keys.Up Then
                Darabb_1.Focus()
                Darabb_1.BackColor = Color.Gold
                Darabb_1.Select()
            End If
        End If


        If mash1_1.Visible = True Then
            If e.KeyCode = Keys.Down Then
                nkba_1.Focus()
                nkba_1.BackColor = Color.Gold

            End If

            If e.KeyCode = Keys.Up Then
                Darabb_1.Focus()
                Darabb_1.BackColor = Color.Gold
                Darabb_1.Select()
            End If
        End If



    End Sub

    Private Sub Darabb_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Darabb_1.KeyDown
        If nkba_1.Visible = True Then

            If e.KeyCode = Keys.Down Then
                Mashat_9.Focus()
                Mashat_9.BackColor = Color.Gold

            End If

            If e.KeyCode = Keys.Up Then
                Mkf_1.Focus()
                Mkf_1.BackColor = Color.Gold
            End If
        End If
        If nkba_1.Visible = False Then

            If e.KeyCode = Keys.Down Then
                tamen_11.Focus()
                tamen_11.BackColor = Color.Gold
            End If

            If e.KeyCode = Keys.Up Then
                Darabb_1.Focus()
                Darabb_1.BackColor = Color.Gold
            End If
        End If
    End Sub

    Private Sub Mhann_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tamen_11.KeyDown
        If e.KeyCode = Keys.Down Then
            Mastshfa_1.Focus()
            Mastshfa_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            mash1_1.Focus()
            mash1_1.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Mastshfa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mastshfa_1.KeyDown
        If e.KeyCode = Keys.Down Then
            Damghh_1.Focus()
            Damghh_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            tamen_11.Focus()
            tamen_11.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Damghh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Earaadta_1.Visible = True Then
            If e.KeyCode = Keys.Down Then
                Earaadta_1.Focus()
                Earaadta_1.BackColor = Color.Gold
            End If

            If e.KeyCode = Keys.Up Then
                Mastshfa_1.Focus()
                Mastshfa_1.BackColor = Color.Gold
            End If
        End If
        If Earaadta_1.Visible = False Then
            If e.KeyCode = Keys.Down Then
                box_1.Focus()
                box_1.BackColor = Color.Gold
            End If

            If e.KeyCode = Keys.Up Then
                Damghh_1.Focus()
                Damghh_1.BackColor = Color.Gold
            End If
        End If

    End Sub

    Private Sub Earaadta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Earaadta_1.KeyDown


        If e.KeyCode = Keys.Down Then
            box_1.Focus()
            box_1.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Up Then
            Damghh_1.Focus()
            Damghh_1.BackColor = Color.Gold
        End If

    End Sub


    Private Sub total_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles total_mkff.KeyDown
        If e.KeyCode = Keys.Down Then
            Mashat_9.Focus()
            Mashat_9.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Entklat_1.Focus()
            Entklat_1.BackColor = Color.Gold
        End If
    End Sub

    Private Sub No_55_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        No_55.BackColor = Color.White
    End Sub

    Private Sub Salary_ass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ComboBox_Salary_ass.BackColor = Color.White
    End Sub



    Private Sub Name_school_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        id_noo_combx.BackColor = Color.White
    End Sub

    Private Sub Name_Emp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Name_emp.BackColor = Color.White


    End Sub

    Private Sub Dayes_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dayes_1.BackColor = Color.White
    End Sub



    Private Sub No_55_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles No_55.MouseClick
        No_55.BackColor = Color.Gold
    End Sub

    Private Sub Salary_ass_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ComboBox_Salary_ass.BackColor = Color.Gold
    End Sub

    Private Sub Dayes_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Dayes_1.MouseClick
        Dayes_1.BackColor = Color.Gold
    End Sub

    Private Sub Name_Emp_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Name_emp.BackColor = Color.Gold
    End Sub


    Private Sub Name_school_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        id_noo_combx.BackColor = Color.Gold
    End Sub

    Private Sub Mkf_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mkf_1.MouseClick
        Mkf_1.BackColor = Color.Gold
    End Sub

    Private Sub Badl_safer_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Badl_safer.MouseClick
        Badl_safer.BackColor = Color.Gold
    End Sub

    Private Sub Entklat_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Entklat_1.MouseClick
        Entklat_1.BackColor = Color.Gold
    End Sub

    Private Sub total_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles total_mkff.MouseClick
        total_mkff.BackColor = Color.Gold
    End Sub

    Private Sub Mashat_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mashat_9.MouseClick
        Mashat_9.BackColor = Color.Gold
    End Sub

    Private Sub Darabb_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Darabb_1.MouseClick
        Darabb_1.BackColor = Color.Gold
    End Sub

    Private Sub Mhann_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tamen_11.MouseClick
        tamen_11.BackColor = Color.Gold
    End Sub

    Private Sub Mastshfa_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mastshfa_1.MouseClick
        Mastshfa_1.BackColor = Color.Gold
    End Sub

    Private Sub Damghh_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Damghh_1.BackColor = Color.Gold
    End Sub

    Private Sub Earaadta_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Earaadta_1.MouseClick
        Earaadta_1.BackColor = Color.Gold
    End Sub

    Private Sub Name_school_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        id_noo_combx.BackColor = Color.White
    End Sub




    Private Sub CheckBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CheckBox1.MouseClick
        If (CheckBox1.Checked = True) Then
            mash1_1.Visible = True
            Label5.Visible = True
        Else
            mash1_1.Visible = False
            Label5.Visible = False
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            mash1_1.Visible = True
            Label5.Visible = True
            Me.mash1_1.Text = vbNullString


            'Darabb.Location = New System.Drawing.Point(287, 97)
            'Darabblbl.Location = New System.Drawing.Point(411, 100)
        Else
            mash1_1.Visible = False
            Label5.Visible = False
            'Darabb.Location = New System.Drawing.Point(287, 55)
            'Darabblbl.Location = New System.Drawing.Point(416, 55)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked = True) Then
            nkba_1.Visible = True
            Me.nkba_1.Text = vbNullString
            Label6.Visible = True
        Else
            nkba_1.Visible = False
            Label6.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked = True) Then
            box_1.Visible = True
            Label7.Visible = True
            Me.box_1.Text = vbNullString
        Else
            box_1.Visible = False
            Label7.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If MessageBox.Show("هل تريد انشاء كشف تفريغ جديد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else

            Form_all_mkf.frm_stat = "add"

            Idlbl.Text = Max_Table_mkf_add() + 1
            id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
            no_kshf.Text = Max_no_kshf() + 1
            no_kshfff = no_kshf.Value

            select_no_kash(no_kshfff)
            dgv_Table_add_tfrgh.DataSource = dt_select_no_kash




            auto_txt_name_emp(Name_emp)
            'auto_txt_Name_school()

            'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

            BtnNewAdd.Enabled = True

            ClearControls()
            Label9.Text = "0"
            open_text_box()
            SelectAll_Table_no_kshf(no_kshf.Value)
            dgv_Table_add_tfrgh.DataSource = dt_Table_mkf_no_kshff
            'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

        End If




    End Sub

    Private Sub BtnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Txt_seach.Text = ""
            'Delete_mkf_tfrgh(dgv_Table_add_tfrgh)
            Delete_id_tfrgh(id_and_user.Text)

            'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
            Idlbl.Text = Max_Table_mkf_add() + 1
            id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
            no_kshfff = Max_no_kshf()
            no_k = Max_no_kshf()
            select_no_kash(no_kshfff)
            dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
            radb_nkaba.Checked = False
            ClearControls()

            BtnDelete.Enabled = False
            Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
            'close_text_box()
            '================================
            BtnSave_Click(sender, e)
        End If
    End Sub



    Private Sub dgv_Table_mkf_add_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If (dt_select_no_kash.Rows.Count > 0) Then
            BtnDelete.Enabled = True
            open_text_box()
            BtnNewAdd.Enabled = False
            Try


                CheckBox1.Checked = True
                CheckBox2.Checked = True
                CheckBox3.Checked = True
                CheckBox4.Checked = True
                BtnEdit.Enabled = True
                BtnDelete.Enabled = True
                With dgv_Table_add_tfrgh
                    Me.Idlbl.Text = .CurrentRow.Cells("Id").Value.ToString()
                    Me.id_and_user.Text = .CurrentRow.Cells("id_and_user_tfg").Value.ToString()
                    Me.No_55.Text = .CurrentRow.Cells("No_55").Value
                    Me.no_kshf.Text = .CurrentRow.Cells("no_kshf").Value.ToString()
                    Me.Name_emp.Text = .CurrentRow.Cells("Name_Emp").Value.ToString()
                    Me.Name_school.Text = .CurrentRow.Cells("Name_school").Value.ToString()
                    Me.ComboBox_Salary_ass.Text = .CurrentRow.Cells("Salary_ass").Value
                    Me.Dayes_1.Text = .CurrentRow.Cells("Dayes").Value.ToString()
                    Me.Mkf_1.Text = .CurrentRow.Cells("Mkf").Value
                    Me.Badl_safer.Text = .CurrentRow.Cells("Badl_safer").Value
                    Me.Entklat_1.Text = .CurrentRow.Cells("Entklat").Value
                    Me.total_mkff.Text = .CurrentRow.Cells("total").Value
                    Me.Mashat_9.Text = .CurrentRow.Cells("Mashat").Value
                    Me.mash1_1.Text = .CurrentRow.Cells("Mashat8").Value
                    Me.Darabb_1.Text = .CurrentRow.Cells("Darabb").Value
                    Me.nkba_1.Text = .CurrentRow.Cells("nkaba").Value
                    Me.tamen_11.Text = .CurrentRow.Cells("Mhann").Value
                    Me.Mastshfa_1.Text = .CurrentRow.Cells("Mastshfa").Value
                    Me.Damghh_1.Text = .CurrentRow.Cells("Damghh").Value
                    Me.Earaadta_1.Text = .CurrentRow.Cells("Earaadta").Value
                    Me.box_1.Text = .CurrentRow.Cells("box20").Value
                    Me.Total_Mostkta_1.Text = .CurrentRow.Cells("Total_Mostkta").Value
                    Me.Saffy_1.Text = .CurrentRow.Cells("Saffy").Value

                    Me.Id_Mkf_1.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                    Me.date_1.Value = .CurrentRow.Cells("date1").Value.ToString()
                    Me.id_noo_combx.Text = .CurrentRow.Cells("op_id_no").Value.ToString()
                    Me.cmbx_name_pay.Text = .CurrentRow.Cells("op_name_pay").Value.ToString()
                    Me.cmbx_alkta.Text = .CurrentRow.Cells("op_al_kta").Value.ToString()
                    Me.cmbx_no_emp.Text = .CurrentRow.Cells("op_no_emb").Value.ToString()
                    Me.saffa_after_1.Text = .CurrentRow.Cells("Saffy_after_antkal").Value
                    Me.radb_nkaba.Checked = .CurrentRow.Cells("nakab_yes_no").Value
                    Me.rb_tsh.Checked = .CurrentRow.Cells("chb_tsh_mlahza").Value
                    Me.chk_auto.Checked = .CurrentRow.Cells("Auto_emp").Value
                    Me.auto_total_1.Checked = .CurrentRow.Cells("Auto_total").Value

                    No_55.Enabled = True
                    ComboBox_Salary_ass.Enabled = True
                    Dayes_1.Enabled = True
                    Name_emp.Enabled = True
                    Name_school.Enabled = True
                    Mkf_1.Enabled = True
                    Badl_safer.Enabled = True
                    Entklat_1.Enabled = True
                    Mashat_9.Enabled = True
                    Darabb_1.Enabled = True
                    tamen_11.Enabled = True
                    Mastshfa_1.Enabled = True
                    Damghh_1.Enabled = True
                    Earaadta_1.Enabled = True
                    BtnNewAdd.Enabled = False
                    Btn_new.Enabled = True
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked = True) Then
            Earaadta_1.Visible = True
            Earaadtalbl.Visible = True

        Else
            Earaadta_1.Visible = False
            Earaadtalbl.Visible = False
        End If
    End Sub



    Private Sub NumericUpDown1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mash1_1.MouseClick
        mash1_1.BackColor = Color.Gold
    End Sub

    Private Sub NumericUpDown2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nkba_1.MouseClick
        nkba_1.BackColor = Color.Gold
    End Sub

    Private Sub NumericUpDown3_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles box_1.MouseClick
        box_1.BackColor = Color.Gold
    End Sub

    Private Sub NumericUpDown1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mash1_1.KeyDown
        If e.KeyCode = Keys.Down Then
            tamen_11.Focus()
            tamen_11.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            nkba_1.Focus()
            nkba_1.BackColor = Color.Gold
        End If
    End Sub

    Private Sub NumericUpDown2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles nkba_1.KeyDown
        If e.KeyCode = Keys.Down Then
            mash1_1.Focus()
            mash1_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Mashat_9.Focus()
            Mashat_9.BackColor = Color.Gold
        End If
    End Sub

    Private Sub NumericUpDown3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles box_1.KeyDown


        If e.KeyCode = Keys.Up Then
            Earaadta_1.Focus()
            Earaadta_1.BackColor = Color.Gold
        End If
    End Sub

    Private Sub BtnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '===
        Try
            btn_cal_Click(sender, e)

            If (rb_mlahza.Checked = True And auto_total_1.Checked = False) Then




                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()
                total_day_cal()
                '=================
                'اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                if_total_larg_than_4000()
            End If
            '===============
            'فى حالة ان التفريغ  الشرطه
            '=================================================

            If (cbx_sharta.Checked = True And auto_total_1.Checked = False) Then



                'total_day_cal_sharta()
                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()

                Button4_Click(sender, e)

            End If
            '===================================
            Txt_seach.Text = ""

            If Id_Mkf_1.Text = "" Or No_55.Text = "" Or Name_emp.Text = "" Or Convert.ToDouble(Me.Saffy_1.Text) <= 0 Then

                MessageBox.Show("!يجب التاكد من الجمله اادخال اسم الموظف , وادخال المكافاة وادخال رقم 55 ع ح و اختيار مكافاة!")
                Exit Sub
            ElseIf ComboBox_Salary_ass.Text = 0 And rb_mlahza.Checked = True Then

                MessageBox.Show("يجب التاكد من المرتب الاساسى ...")
                Exit Sub

            End If
            '==================================================================================
            If auto_total_1.Text = "Auto_cal" Then
                '=================
                ''اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                'if_total_larg_than_4000()
                ''=============================================

                Button4_Click(sender, e)


                Update_Table_mkf_add(Convert.ToInt32(Idlbl.Text), id_and_user.Text, No_55.Value, no_kshf.Value, Name_emp.Text, Name_school.Text, Convert.ToDouble(ComboBox_Salary_ass.Text), Dayes_1.Value, Mkf_1.Value, Convert.ToDouble(mkf_22.Text), Badl_safer.Value, Entklat_1.Value, total_mkff.Value, Mashat_9.Value, mash1_1.Value, Darabb_1.Value, nkba_1.Value, tamen_11.Value, Mastshfa_1.Value, Convert.ToDouble(Damghh_1.Value), Earaadta_1.Value, box_1.Value, Mzay_t17.Value, Convert.ToDouble(Total_Mostkta_1.Text), Convert.ToDouble(Saffy_1.Text), Convert.ToInt32(Id_Mkf_1.Text), date_1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, Convert.ToDouble(saffa_after_1.Text), radb_nkaba.Checked, rb_tsh.Checked, chk_auto.Checked, auto_total_1.Checked, rb_mlahza.Checked, cbx_sharta.Checked, rb_zar.Checked)





                ClearControls()

                'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
                Idlbl.Text = Max_Table_mkf_add() + 1
                id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                no_kshfff = no_kshf.Value
                no_k = no_kshf.Value

                select_no_kash(no_kshfff)
                dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
                radb_nkaba.Checked = False
                ClearControls()
                Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
                BtnEdit.Enabled = False
                'close_text_box()
                '================================
                BtnSave_Click(sender, e)
                drab = 10
                select_drab.Text = " ضرائب" + Convert.ToString(drab)
                Me.Darabb_1.Text = vbNullString



            Else

                '=================
                'اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                If auto_total_1.Checked = False Then
                    if_total_larg_than_4000()
                End If


                Button4_Click(sender, e)
                '=============================================

                Update_Table_mkf_add(Convert.ToInt32(Idlbl.Text), id_and_user.Text, No_55.Value, no_kshf.Value, Name_emp.Text, Name_school.Text, Convert.ToDouble(ComboBox_Salary_ass.Text), Dayes_1.Value, Mkf_1.Value, Convert.ToDouble(mkf_22.Text), Badl_safer.Value, Entklat_1.Value, total_mkff.Value, Mashat_9.Value, mash1_1.Value, Darabb_1.Value, nkba_1.Value, tamen_11.Value, Mastshfa_1.Value, Convert.ToDouble(Damghh_1.Value), Earaadta_1.Value, box_1.Value, Mzay_t17.Value, Convert.ToDouble(Total_Mostkta_1.Text), Convert.ToDouble(Saffy_1.Text), Convert.ToInt32(Id_Mkf_1.Text), date_1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, Convert.ToDouble(saffa_after_1.Text), radb_nkaba.Checked, rb_tsh.Checked, chk_auto.Checked, auto_total_1.Checked, rb_mlahza.Checked, cbx_sharta.Checked, rb_zar.Checked)





                'total_mkf()
                'total_mostakt()
                'total_sffy()
                'total_sffy_after_Entkal()





                ClearControls()

                'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
                Idlbl.Text = Max_Table_mkf_add() + 1
                id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                no_kshfff = no_kshf.Value
                no_k = no_kshf.Value

                select_no_kash(no_kshfff)
                dgv_Table_add_tfrgh.DataSource = dt_select_no_kash

                ClearControls()
                Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
                BtnEdit.Enabled = False
                'close_text_box()
                '================================
                BtnSave_Click(sender, e)



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try

            no_k = ListBox1.SelectedValue

            If no_k >= 0 Then
                ClearControls()
                SelectAll_Table_no_kshf(no_k)
                dgv_Table_add_tfrgh.DataSource = dt_Table_mkf_no_kshff
                no_kshf.Value = no_k
                'dgv_Table_mkf_add.DataSource = dt_Table_mkf_no_kshff
                'DataGridViewHeaderTxxt(dgv_Table_mkf_add)
                'ListBox1.SelectedValue = no_k
                'Me.no_kshf.Text = dgv_Table_mkf_add.CurrentRow.Cells("no_kshf").Value.ToString()
                Dim Id_Mkff As Integer
                Id_Mkff = dgv_Table_add_tfrgh.CurrentRow.Cells("Id_Mkf").Value

                Id_Mkff = Id_Mkff
                Id_Mkf_1.Text = Id_Mkff.ToString()
                select_id_mkf(Convert.ToInt32(Id_Mkff))
                DataGridView1.DataSource = dt_select_id_mkf
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()

                Me.no_kshf.Text = dgv_Table_add_tfrgh.CurrentRow.Cells("no_kshf").Value.ToString()

                no_kashfff.Value = ListBox1.SelectedValue

            Else
                no_k = ListBox1.SelectedValue

            End If


        Catch
            Dim no_k As Integer = ListBox1.SelectedIndex
        End Try


        Label9.Text = dt_Table_mkf_no_kshff.Rows.Count.ToString()



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            no_k = no_kashfff.Value

            If no_k > 0 Then
                ClearControls()
                SelectAll_Table_no_kshf(no_k)
                dgv_Table_add_tfrgh.DataSource = dt_Table_mkf_no_kshff
                no_kshf.Value = no_k

                'dgv_Table_mkf_add.DataSource = dt_Table_mkf_no_kshff
                'DataGridViewHeaderTxxt(dgv_Table_mkf_add)
                'ListBox1.SelectedValue = no_k
                'Me.no_kshf.Text = dgv_Table_mkf_add.CurrentRow.Cells("no_kshf").Value.ToString()
                Dim Id_Mkff As Integer
                Id_Mkff = dgv_Table_add_tfrgh.CurrentRow.Cells("Id_Mkf").Value

                Id_Mkff = Id_Mkff
                Id_Mkf_1.Text = Id_Mkff.ToString()
                select_id_mkf(Convert.ToInt32(Id_Mkff))
                DataGridView1.DataSource = dt_select_id_mkf
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()

                Me.no_kshf.Text = dgv_Table_add_tfrgh.CurrentRow.Cells("no_kshf").Value.ToString()
            Else
                no_k = ListBox1.SelectedValue

            End If


        Catch
            Dim no_k As Integer = ListBox1.SelectedIndex
        End Try
        Label9.Text = dt_Table_mkf_no_kshff.Rows.Count.ToString()
    End Sub




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            'total_day_cal()
            total_mostakt()
            total_mkf()

            total_sffy()
            total_sffy_after_Entkal()
            'BtnNewAdd.Enabled = True
        Catch ex As Exception

        End Try

    End Sub
    Public Sub close_text_box()
        No_55.Enabled = False
        Name_emp.Enabled = False
        Name_school.Enabled = False
        id_noo_combx.Enabled = False
        ComboBox_Salary_ass.Enabled = False
        Dayes_1.Enabled = False
        Mkf_1.Enabled = False
        Badl_safer.Enabled = False
        Entklat_1.Enabled = False
        Mashat_9.Enabled = False
        mash1_1.Enabled = False
        Darabb_1.Enabled = False
        nkba_1.Enabled = False
        tamen_11.Enabled = False
        Mastshfa_1.Enabled = False
        Earaadta_1.Enabled = False
    End Sub
    Public Sub open_text_box()
        No_55.Enabled = True
        ComboBox_Salary_ass.Enabled = True
        Name_emp.Enabled = True
        Name_school.Enabled = True
        id_noo_combx.Enabled = True
        Dayes_1.Enabled = True
        Mkf_1.Enabled = True
        Badl_safer.Enabled = True
        Entklat_1.Enabled = True
        Mashat_9.Enabled = True
        mash1_1.Enabled = True
        Darabb_1.Enabled = True
        nkba_1.Enabled = True
        tamen_11.Enabled = True
        Mastshfa_1.Enabled = True
        Earaadta_1.Enabled = True
        mkf_22.Enabled = True
    End Sub

    Private Sub Dayes_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No_55.Leave, nkba_1.Leave, Mkf_1.Leave, tamen_11.Leave, Mastshfa_1.Leave, Mashat_9.Leave, mash1_1.Leave, Entklat_1.Leave, Earaadta_1.Leave, Dayes_1.Leave, Darabb_1.Leave, box_1.Leave, Badl_safer.Leave
        No_55.BackColor = Color.White
        ComboBox_Salary_ass.BackColor = Color.White
        Dayes_1.BackColor = Color.White
        Mkf_1.BackColor = Color.White
        Badl_safer.BackColor = Color.White
        Entklat_1.BackColor = Color.White
        Mashat_9.BackColor = Color.White
        mash1_1.BackColor = Color.White
        Darabb_1.BackColor = Color.White
        nkba_1.BackColor = Color.White
        tamen_11.BackColor = Color.White
        Mastshfa_1.BackColor = Color.White
        Damghh_1.BackColor = Color.White
        Earaadta_1.BackColor = Color.White
        box_1.BackColor = Color.White
        Try
            If id_noo_combx.Text <> "" Then
                auto_salary_ass_drab(id_noo_combx.Text, drab)
                If dt_auto_salary_ass_drab.Rows.Count > 0 Then
                    drab = dt_auto_salary_ass_drab.Rows(0)("Drab")
                    select_drab.Text = Convert.ToString(drab) + "ضرائب"

                End If


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub




    Private Sub Form_add_tfrgh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '=====تشغيل زر جمله اوتوماتك 
        If e.KeyCode = Keys.F2 Then

            btn_cal_Click(sender, e)
            btn_cal.Focus()
            Try
                total_mostakt()
                total_mkf()

                total_sffy()
                total_sffy_after_Entkal()
                'BtnNewAdd.Enabled = True
            Catch ex As Exception

            End Try
        End If
        '=====تشغيل زر حفظ اوتوماتك 
        If e.KeyCode = Keys.F4 Then

            BtnNewAdd.Focus()
            BtnNewAdd_Click(sender, e)
            '    Try



            '        If Id_Mkf.Text = "" Or No_55.Text = "" Or Name_Emp.Text = "" Or dt_select_no_kash.Rows.Count > 18 Or Me.Saffy.Value <= 0 Or Me.Mkf.Value <= 0 Then
            '            MessageBox.Show("يجب التاكد من الجمله اادخال اسم الموظف ,وادخال المكافاة وادخال رقم 55 ع ح و اختيار مكافاة")




            '        Else
            '            total_mkf()
            '            total_mostakt()
            '            total_sffy()
            '            total_sffy_after_Entkal()
            '            Insert_Table_mkf_add(Convert.ToInt32(Idlbl.Text), Convert.ToInt32(No_55.Text), Convert.ToInt32(no_kshf.Text), Name_Emp.Text, Name_school.Text, Salary_ass.Value, Convert.ToInt32(Dayes.Text), Mkf.Value, Badl_safer.Value, Entklat.Value, total.Value, Mashat.Value, mash1.Value, Darabb.Value, nkba.Value, tamen_1.Value, Mastshfa.Value, Convert.ToDouble(Damghh.Value), Earaadta.Value, box.Value, Total_Mostkta.Value, Saffy.Value, Convert.ToInt32(Id_Mkf.Text), date1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, NumericUpDown1.Value, Chb_nkaba.Checked, chb_tsh_mlahza.Checked, Convert.ToInt32(txt_user.Text), chk_auto.Checked, auto_total.Checked)

            '            DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
            '            Idlbl.Text = Max_Table_mkf_add() + 1
            '            SelectAll_Table_no_kshf(no_k)
            '            no_kshfff = no_kshf.Value
            '            select_no_kash(no_kshfff)
            '            dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
            '            ClearControls()
            '            Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()

            '            'ايجاد اخر سطرفى دات
            '            'dgv_Table_add_tfrgh.Focus()
            '            dgv_Table_add_tfrgh.CurrentCell = dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(1)
            '            No_55.BackColor = Color.Gold
            '            No_55.Focus()
            '        End If
            '        If dt_select_no_kash.Rows.Count > 18 Then
            '            MessageBox.Show("لا يمكن اضافة يجب انشاء كشف تفريغ جديد")
            '            If MessageBox.Show("هل تريد انشاء كشف تفريغ جديد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            '                Exit Sub
            '            Else
            '                Form_all_mkf.frm_stat = "add"

            '                Idlbl.Text = Max_Table_mkf_add() + 1
            '                no_kshf.Text = Max_no_kshf() + 1
            '                no_kshfff = no_kshf.Value

            '                select_no_kash(no_kshfff)
            '                dgv_Table_add_tfrgh.DataSource = dt_select_no_kash

            '                auto_txt_name_emp()
            '                auto_txt_Name_school()
            '                DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

            '                BtnNewAdd.Enabled = True

            '                ClearControls()
            '                Label9.Text = "0"

            '            End If
            '        End If

            '    Catch
            '        con.Close()
            '    End Try

        End If




    End Sub






    Private Sub Form_add_tfrgh_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.date_1.Value = Today
        close_text_box()
        txt_user.Text = Form1.ToolStripStatusLabel3.Text
        auto_txt_name_emp(Name_emp)
    End Sub










    Private Sub Damghh_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Damghh_1.KeyDown
        If e.KeyCode = Keys.Down Then
            Earaadta_1.Focus()
            Earaadta_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Mastshfa_1.Focus()
            Mastshfa_1.BackColor = Color.Gold
        End If
    End Sub

    Private Sub id_noo_combx_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            Darabb_1.Focus()
            Darabb_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_emp.Focus()
            Name_emp.BackColor = Color.Gold
        End If
    End Sub


    Private Sub btn_cal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cal.Click
        '=================================================

        Try
            'If Dayes.Value = 0 Then
            '    rb_tsh.Checked = True
            '    radb_nkaba.Checked = True
            'End If

            '===============================================

            'فى حالة ان التفريغ غير الشرطه
            If cbx_sharta.Checked = False Then



                select_id_emp(id_noo_combx.Text)
                If dt_select_id_emp.Rows.Count > 0 And BtnNewAdd.Enabled = True Then

                    MessageBox.Show("رقم قومى مسجل من قبل  ...!")
                    ErrorProvider1.SetError(No_55, " مكرر تاكد من رقم القومى  !...")
                    'isvalaied = False
                    msg_lbl.Text += "  تاكد من رقم  القومى مكرر  !..  ..؟"
                    lbl_erro.Text = "1"
                    id_noo_combx.Focus()

                Else

                    msg_lbl.Text = ""
                    lbl_erro.Text = ""


                End If
                '=========================
                'معرفة نقابى اوغير نقابى 
                If radb_nkaba.Checked = False And rad_b_no_nokapy.Checked = False Then
                    auto_techer_or_no(dt_auto_techer_or_no, Cmbx_nokapa, ComboBox_work, id_noo_combx.Text)
                    If (ComboBox_work.Text = "عامل خدمات" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة ثالث" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة خامس" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة رابع" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة سادس") Then
                        Radio_b_work.Checked = True
                    Else

                        Radio_b_work.Checked = False
                    End If

                End If


                'التحقق من النقابى والغير نقابى
                Dim nokpa As String
                nokpa = Cmbx_nokapa.Text

                If nokpa = "ادارى" Then
                    rad_b_no_nokapy.Checked = True
                    radb_nkaba.Checked = False
                ElseIf nokpa = "معلم" Then
                    radb_nkaba.Checked = True
                    rad_b_no_nokapy.Checked = False
                Else
                    Cmbx_nokapa.Text = "0"
                    radb_nkaba.Checked = False

                    rad_b_no_nokapy.Checked = False
                End If

                If radb_nkaba.Checked = False And rad_b_no_nokapy.Checked = False Then

                    Cmbx_nokapa.Text = "0"
                    MessageBox.Show("يجب تحديد نقابى او غير نقابى ! ..")
                    msg_lbl.Text = "اختر نقابى اوغير نقابى"


                End If
                '===================
                select_drab_a()
                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()
                total_day_cal()
                Button4_Click(sender, e)
                '=================
                'اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                if_total_larg_than_4000()
                '=============================================
                ''عندما يكون تحديد تصحيح المرتب الاساى فارغ =0
                'If Me.ComboBox_Salary_ass.Text = vbNullString And chb_tsh_mlahza.Checked = True Then
                '    Me.ComboBox_Salary_ass.Text = "0"


                'End If

            End If
            '=====================================================
            'فى حالة ان التفريغ  الشرطه
            '=================================================

            '==================================

            If cbx_sharta.Checked = True Then


                total_mkf()
                'total_day_cal_sharta()
                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()

                'Button4_Click(sender, e)
                '=============================================
                '
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'btn_cal_Click(sender, e)
    End Sub





    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (rb_tsh.Checked = True) Then


            Me.rb_tsh.Text = "تصحيح"
            radb_nkaba.Checked = True
            'nkba.Value = Math.Round((Mkf.Value * 2) / 100, 1)
            'total_day_cal()
            'total_mkf()

            'total_mostakt()
            'total_sffy()
            'total_sffy_after_Entkal()
            'total_day_cal()


        ElseIf (rb_tsh.Checked = False) Then
            'Me.chb_tsh_mlahza.Text = "ملاحظه"

            'nkba.Value = 0
            'total_day_cal()
            'total_mkf()


            'total_mostakt()


            'total_sffy()
            'total_sffy_after_Entkal()
            'total_day_cal()


        End If
    End Sub


    Private Sub BtnNewAdd_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.EnabledChanged
        If sender.Enabled = False Then
            sender.BackColor = Color.Gray
        Else
            sender.BackColor = Color.Blue
            sender.ForeColor = Color.White
        End If
    End Sub



    Private Sub dgv_Table_add_tfrgh_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If (dgv_Table_add_tfrgh.CurrentRow.Selected() = False And dgv_Table_add_tfrgh.Rows.Count > 0) Then
        '    BtnDelete.Enabled = True
        '    open_text_box()
        '    BtnNewAdd.Enabled = False
        '    Try


        '        CheckBox1.Checked = True
        '        CheckBox2.Checked = True
        '        CheckBox3.Checked = True
        '        CheckBox4.Checked = True
        '        BtnEdit.Enabled = True
        '        BtnDelete.Enabled = True
        '        With dgv_Table_add_tfrgh
        '            Me.Idlbl.Text = .CurrentRow.Cells("Id").Value.ToString()
        '            Me.No_55.Text = .CurrentRow.Cells("No_55").Value
        '            Me.no_kshf.Text = .CurrentRow.Cells("no_kshf").Value.ToString()
        '            Me.Name_Emp.Text = .CurrentRow.Cells("Name_Emp").Value.ToString()
        '            Me.Name_school.Text = .CurrentRow.Cells("Name_school").Value.ToString()
        '            Me.Salary_ass.Text = .CurrentRow.Cells("Salary_ass").Value
        '            Me.Dayes.Text = .CurrentRow.Cells("Dayes").Value.ToString()
        '            Me.Mkf.Text = .CurrentRow.Cells("Mkf").Value
        '            Me.Badl_safer.Text = .CurrentRow.Cells("Badl_safer").Value
        '            Me.Entklat.Text = .CurrentRow.Cells("Entklat").Value
        '            Me.total.Text = .CurrentRow.Cells("total").Value
        '            Me.Mashat.Text = .CurrentRow.Cells("Mashat").Value
        '            Me.mash1.Text = .CurrentRow.Cells("Mashat8").Value
        '            Me.Darabb.Text = .CurrentRow.Cells("Darabb").Value
        '            Me.nkba.Text = .CurrentRow.Cells("nkaba").Value
        '            Me.tamen_1.Text = .CurrentRow.Cells("Mhann").Value
        '            Me.Mastshfa.Text = .CurrentRow.Cells("Mastshfa").Value
        '            Me.Damghh.Text = .CurrentRow.Cells("Damghh").Value
        '            Me.Earaadta.Text = .CurrentRow.Cells("Earaadta").Value
        '            Me.box.Text = .CurrentRow.Cells("box20").Value
        '            Me.Total_Mostkta.Text = .CurrentRow.Cells("Total_Mostkta").Value
        '            Me.Saffy.Text = .CurrentRow.Cells("Saffy").Value

        '            Me.Id_Mkf.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
        '            Me.date1.Value = .CurrentRow.Cells("date1").Value.ToString()
        '            Me.id_noo_combx.Text = .CurrentRow.Cells("op_id_no").Value.ToString()
        '            Me.cmbx_name_pay.Text = .CurrentRow.Cells("op_name_pay").Value.ToString()
        '            Me.cmbx_alkta.Text = .CurrentRow.Cells("op_al_kta").Value.ToString()
        '            Me.cmbx_no_emp.Text = .CurrentRow.Cells("op_no_emb").Value.ToString()
        '            Me.NumericUpDown1.Text = .CurrentRow.Cells("Saffy_after_antkal").Value
        '            Me.Chb_nkaba.Checked = .CurrentRow.Cells("nakab_yes_no").Value
        '            Me.chb_tsh_mlahza.Checked = .CurrentRow.Cells("chb_tsh_mlahza").Value


        '            No_55.Enabled = True
        '            Salary_ass.Enabled = True
        '            Dayes.Enabled = True
        '            Name_Emp.Enabled = True
        '            Name_school.Enabled = True
        '            Mkf.Enabled = True
        '            Badl_safer.Enabled = True
        '            Entklat.Enabled = True
        '            Mashat.Enabled = True
        '            Darabb.Enabled = True
        '            tamen_1.Enabled = True
        '            Mastshfa.Enabled = True
        '            Damghh.Enabled = True
        '            Earaadta.Enabled = True
        '            BtnNewAdd.Enabled = False
        '            Btn_new.Enabled = True
        '        End With
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message)
        '    End Try
        'End If


    End Sub

    Private Sub BtnEdit_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.Enabled = False Then
            sender.BackColor = Color.Gray
        Else
            sender.BackColor = Color.Blue
            sender.ForeColor = Color.White
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'close_all()
        search_tafrgh.Show()
    End Sub

    Private Sub Salary_ass_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rb_tsh.Checked = True Then


        Else
            If Convert.ToDouble(ComboBox_Salary_ass.Text) > 1500 Then
                MessageBox.Show(" !  برجاء التاكد من المرتب الاساسى")
                ComboBox_Salary_ass.Focus()

            ElseIf Convert.ToDouble(ComboBox_Salary_ass.Text) = 0 Then
                MessageBox.Show(" !  برجاء التاكد من المرتب الاساسى")
                ComboBox_Salary_ass.Focus()

            End If
        End If


    End Sub

    Private Sub Dayes_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dayes_1.Validated
        If Dayes_1.Value > 400 Then
            MessageBox.Show(" !  برجاء التاكد من عدد الايام ")
            Me.Dayes_1.Text = "1"
            'Me.Dayes.Value = 1
            Me.Dayes_1.Focus()
        End If
        If Dayes_1.Value >= 200 Then
            'MessageBox.Show(" !........................................................................................  بـــرجــاء التاكــد مـــن عـــدد الايــام ")
            MessageBox.Show("!...................  بـــرجــاء التاكــد مـــن عـــدد الايــام ", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            msg_lbl.Text = "! يرجى التاكد من عدد الايام "
            'Me.Dayes.Focus()
        Else
            msg_lbl.Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_seach.TextChanged
        Try
            Dim dv As DataView = dt_Table_mkf_no_kshff.DefaultView

            dv.RowFilter = Nothing
            dv.RowFilter = " Name_Emp LIKE '%" & Txt_seach.Text & "%' "
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Try
            Dim dv As DataView = dt_Table_mkf_no_kshff.DefaultView
            dv.RowFilter = " Name_Emp LIKE '%" & Txt_seach.Text & "%' "
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Name_Emp_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Name_emp.KeyDown
    
        If chk_auto.CheckState = CheckState.Unchecked Then
            Try

                auto_Name_school(dt_auto_Name_school, Name_school, Name_emp.Text)
                auto_id_no(dt_auto_Name_school)
                auto_name_pay(dt_auto_Name_school)
                auto_alkta(dt_auto_Name_school)
                auto_no_emp(dt_auto_Name_school)
                '=================اضافة المرتب الاساسى 


                auto_salary_ass(dt_auto_salary_ass, ComboBox_Salary_ass, id_noo_combx.Text)
                'معرفة نقابى اوغير نقابى 
                auto_techer_or_no(dt_auto_techer_or_no, Cmbx_nokapa, ComboBox_work, id_noo_combx.Text)



                'Salary_ass.Value = auto_salary_ass(dt_auto_salary_ass, combox, id_noo_combx.Text)

                '==================================
            Catch
                dt_auto_Name_school.Clear()

            End Try
        End If

        If e.KeyCode = Keys.Down Then
            ComboBox_Salary_ass.Focus()
            ComboBox_Salary_ass.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_emp.Focus()
            Name_emp.BackColor = Color.Gold
        End If

    End Sub

    Private Sub Badl_safer_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badl_safer.Validated
        If Badl_safer.Value >= 401 Then
            MessageBox.Show(" !  برجاء التاكد من بدل السفر")
            'Badl_safer.Focus()

        End If
    End Sub

    Private Sub Entklat_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entklat_1.Validated
        If Entklat_1.Value >= 401 Then
            MessageBox.Show(" !  برجاء التاكد من انتقالات ")
            'Entklat.Focus()

        End If
    End Sub


    Private Sub id_noo_combx_Leave_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_noo_combx.Leave
        Try
            Dim id As String
            id = id_noo_combx.Text

            If chk_auto.CheckState = CheckState.Unchecked Then
                id_noo_combx.Text = Id

                auto_name_emp(dt_auto_name_emp, id_noo_combx.Text)
                auto_Name_school(dt_auto_Name_school, Name_school, Name_emp.Text)
                auto_id_no(dt_auto_Name_school)
                auto_name_pay(dt_auto_Name_school)
                auto_alkta(dt_auto_Name_school)
                auto_no_emp(dt_auto_Name_school)
                auto_salary_ass(dt_auto_salary_ass, ComboBox_Salary_ass, id_noo_combx.Text)
                'drab = dt_auto_salary_ass.Rows(0)("Drab")
                id_noo_combx.Text = Id
                If Id.Length = 14 Then
                Else
                    msg_lbl.Text += "  التاكد من الرقم القومى" + Id.Length.ToString()
                    'MessageBox.Show("  التاكد من الرقم القومى")
                    dt_auto_salary_ass.Clear()
                    Me.ComboBox_Salary_ass.Text = 1
                    id_noo_combx.Text = Id
                End If
                'معرفة نقابى اوغير نقابى 
                auto_techer_or_no(dt_auto_techer_or_no, Cmbx_nokapa, ComboBox_work, id_noo_combx.Text)
                If (ComboBox_work.Text = "عامل خدمات" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة ثالث" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة خامس" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة رابع" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة سادس") Then
                    Radio_b_work.Checked = True
                    msg_lbl.Text = "عامل خدمات"
                Else

                    Radio_b_work.Checked = False
                    msg_lbl.Text = ""
                End If
                id_noo_combx.Text = Id

            Else
                dt_auto_name_emp.Clear()
                dt_auto_name_emp.Clear()
                dt_auto_Name_school.Clear()
                dt_auto_salary_ass.Clear()
                id_noo_combx.Text = Id
                If Id.Length = 14 Then
                Else
                    msg_lbl.Text += "  التاكد من الرقم القومى" + Id.Length.ToString()
                    'MessageBox.Show("  التاكد من الرقم القومى")
                    dt_auto_salary_ass.Clear()
                    Me.ComboBox_Salary_ass.Text = 1

                End If
            End If
        Catch

            'dt_auto_Name_school.Clear()

        End Try

    End Sub

    Private Sub chk_auto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_auto.CheckedChanged
        If chk_auto.CheckState = CheckState.Checked Then
            chk_auto.Text = "يدوى"
            dt_auto_salary_ass.Clear()
            ComboBox_Salary_ass.DataSource = Nothing

        Else
            chk_auto.Text = "Auto"
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles auto_total_1.CheckedChanged
        If auto_total_1.CheckState = CheckState.Checked Then
            btn_cal.Visible = False
            auto_total_1.Text = "تجميع يدوى"
        Else
            btn_cal.Visible = True
            auto_total_1.Text = "Auto_cal"
        End If

    End Sub


    Private Sub Name_school_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Name_school.KeyDown
        If e.KeyCode = Keys.Down Then
            ComboBox_Salary_ass.Focus()
            ComboBox_Salary_ass.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_emp.Focus()
            Name_emp.BackColor = Color.Gold
        End If
    End Sub



    Private Sub id_noo_combx_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles id_noo_combx.KeyDown
        If e.KeyCode = Keys.Down Then
            ComboBox_Salary_ass.Focus()
            ComboBox_Salary_ass.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_emp.Focus()
            Name_emp.BackColor = Color.Gold
        End If
    End Sub







    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Txt_seach.Text = ""
        Form_all_mkf.frm_stat = "add"
        dgv_Table_add_tfrgh.ClearSelection()
        'no_k = Max_no_kshf()



        'no_kshf.Text = Max_no_kshf()
        'no_kshfff = no_kshf.Value
        no_kshfff = no_kshf.Value
        'ListBox1.SelectedValue = no_kshfff
        'no_k = Max_no_kshf()

        select_no_kash_view(no_kshfff)
        'dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
        Form_display_no_kasshf.dgv_Table_add_tfrgh.DataSource = dt_select_no_kash_view

        'auto_txt_Name_school()
        'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
        ''DataGridViewHeaderTxxt(Form_display_no_kasshf.dgv_Table_add_tfrgh)


        'Btn_new.Enabled = False

        '======تحميل جدول المكافاة

        'Dim Id_Mkff As Integer

        'Id_Mkff = dgv_Table_add_tfrgh.CurrentRow.Cells("Id_Mkf").Value

        'Id_Mkff = Id_Mkff
        'Id_Mkf.Text = Id_Mkff.ToString()
        'select_id_mkf(Convert.ToInt32(Id_Mkff))
        'DataGridView1.DataSource = dt_select_id_mkf
        'Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
        'Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
        'Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
        'term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
        ''Label9.Text = dgv_Table_mkf_add.RowCount().ToString()
        ''تحميل listbox
        ''no_k = 20
        ''no_k = Max_no_kshf()


        'SelectSome_Table_mkf_add_indirect(ListBox1)

        'SelectAll_Table_no_kshf(no_k)
        'dgv_Table_add_tfrgh.DataSource = dt_Table_mkf_no_kshff
        'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
        'no_k = Max_no_kshf()
        'ListBox1.SelectedValue = no_k
        'Me.no_kshf.Text = dgv_Table_add_tfrgh.CurrentRow.Cells("no_kshf").Value.ToString()
        'Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
        ''ايجاد اخر سطرفى دات
        ''dgv_Table_add_tfrgh.Focus()
        'dgv_Table_add_tfrgh.CurrentCell = dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(1)
        'Name_Emp.Focus()
        'Name_Emp.BackColor = Color.Gold

        '=============
        Form_display_no_kasshf.Show()
    End Sub


    Private Sub No_55_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No_55.Validated
        select_no_55(No_55.Value)
        If dt_select_no_55.Rows.Count > 0 Then

            MessageBox.Show("رقم 55 ع ح مسجل من قبل  ...!")
            ErrorProvider1.SetError(No_55, " مكرر تاكد من رقم 55  !...")
            'isvalaied = False
            msg_lbl.Text += "  تاكد من رقم 55 مكرر  !..  ..؟"
            No_55.Focus()

        End If

    End Sub


    Private Sub dgv_Table_add_tfrgh_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If (dt_select_no_kash.Rows.Count > 0) Then
            BtnDelete.Enabled = True
            open_text_box()
            BtnNewAdd.Enabled = False
            btn_save_sharta.Enabled = False
            Try


                CheckBox1.Checked = True
                CheckBox2.Checked = True
                CheckBox3.Checked = True
                CheckBox4.Checked = True
                BtnEdit.Enabled = True
                BtnDelete.Enabled = True
                With dgv_Table_add_tfrgh
                    Me.Idlbl.Text = .CurrentRow.Cells("iid").Value.ToString()
                    Me.id_and_user.Text = .CurrentRow.Cells("id_and_user_tfg").Value.ToString()
                    Me.No_55.Text = .CurrentRow.Cells("No_55").Value
                    Me.no_kshf.Text = .CurrentRow.Cells("no_kshf").Value.ToString()
                    Me.Name_emp.Text = .CurrentRow.Cells("Name_Emp").Value.ToString()
                    Me.Name_school.Text = .CurrentRow.Cells("Name_school").Value.ToString()
                    Me.ComboBox_Salary_ass.Text = .CurrentRow.Cells("Salary_ass").Value
                    Me.Dayes_1.Text = .CurrentRow.Cells("Dayes").Value.ToString()
                    Me.Mkf_1.Text = .CurrentRow.Cells("Mkf").Value
                    Me.mkf_22.Text = .CurrentRow.Cells("mkf_2").Value

                    Me.Badl_safer.Text = .CurrentRow.Cells("Badl_safer").Value
                    Me.Entklat_1.Text = .CurrentRow.Cells("Entklat").Value
                    Me.total_mkff.Text = .CurrentRow.Cells("total").Value
                    Me.Mashat_9.Text = .CurrentRow.Cells("Mashat").Value
                    Me.mash1_1.Text = .CurrentRow.Cells("Mashat8").Value
                    Me.Darabb_1.Text = .CurrentRow.Cells("Darabb").Value
                    Me.nkba_1.Text = .CurrentRow.Cells("nkaba").Value
                    Me.tamen_11.Text = .CurrentRow.Cells("Mhann").Value
                    Me.Mastshfa_1.Text = .CurrentRow.Cells("Mastshfa").Value
                    Me.Damghh_1.Text = .CurrentRow.Cells("Damghh").Value
                    Me.Earaadta_1.Text = .CurrentRow.Cells("Earaadta").Value
                    Me.box_1.Text = .CurrentRow.Cells("box20").Value
                    Me.Total_Mostkta_1.Text = .CurrentRow.Cells("Total_Mostkta").Value
                    Me.Saffy_1.Text = .CurrentRow.Cells("Saffy").Value

                    Me.Id_Mkf_1.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                    Me.date_1.Value = .CurrentRow.Cells("date1").Value.ToString()
                    Me.id_noo_combx.Text = .CurrentRow.Cells("id_no").Value.ToString()
                    Me.cmbx_name_pay.Text = .CurrentRow.Cells("op_name_pay").Value.ToString()
                    Me.cmbx_alkta.Text = .CurrentRow.Cells("op_al_kta").Value.ToString()
                    Me.cmbx_no_emp.Text = .CurrentRow.Cells("op_no_emb").Value.ToString()
                    Me.saffa_after_1.Text = .CurrentRow.Cells("Saffy_after_antkal").Value
                    Me.radb_nkaba.Checked = .CurrentRow.Cells("nakab_yes_no").Value
                    Me.rb_tsh.Checked = .CurrentRow.Cells("chb_tsh_mlahza").Value
                    Me.chk_auto.Checked = .CurrentRow.Cells("Auto_emp").Value
                    Me.auto_total_1.Checked = .CurrentRow.Cells("Auto_total").Value

                    No_55.Enabled = True
                    ComboBox_Salary_ass.Enabled = True
                    Dayes_1.Enabled = True
                    Name_emp.Enabled = True
                    Name_school.Enabled = True
                    Mkf_1.Enabled = True
                    Badl_safer.Enabled = True
                    Entklat_1.Enabled = True
                    Mashat_9.Enabled = True
                    Darabb_1.Enabled = True
                    tamen_11.Enabled = True
                    Mastshfa_1.Enabled = True
                    Damghh_1.Enabled = True
                    Earaadta_1.Enabled = True
                    BtnNewAdd.Enabled = False
                    Btn_new.Enabled = True
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub






    Private Sub Txt_seach_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_seach.Leave
        Txt_seach.BackColor = Color.White
    End Sub



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'عرض العمود رقم 21
        'cel = 1

        If dgv_Table_add_tfrgh.Rows.Count > 0 And cel < 33 And cel > 0 Then

            dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(cel).Selected = True


        End If


        cel -= 3
        If cel < 0 Then
            cel = 33

        End If


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'عرض العمود رقم 21
        'cel = 20
        Try
            If dgv_Table_add_tfrgh.Rows.Count > 0 And cel_r < 32 And cel_r > 0 Then

                dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 2).Cells(cel_r).Selected = True


            End If


            cel_r += 5
            If cel_r > 32 Then
                cel_r = 1

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub






    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        'عرض العمود رقم 21
        'If dgv_Table_add_tfrgh.Rows.Count > 0 Then

        '    dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(20).Selected = True

        'End If
    End Sub

    Private Sub cbx_sharta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (cbx_sharta.Checked = True) Then


            Me.cbx_sharta.Text = "شرطه"
            btn_save_sharta.Visible = True
            BtnNewAdd.Visible = False
            chk_auto.CheckState = CheckState.Checked
            box_1.Visible = True
            Label7.Visible = True
            Earaadta_1.Visible = True
            Earaadtalbl.Visible = True
            Label14.Text = "شرطه"
            'Chb_nkaba.Checked = True
            'nkba.Value = Math.Round((Mkf.Value * 2) / 100, 1)
            'total_day_cal()
            'total_mkf()

            'total_mostakt()
            'total_sffy()
            'total_sffy_after_Entkal()
            'total_day_cal()


        ElseIf (cbx_sharta.Checked = False) Then

            btn_save_sharta.Visible = False
            BtnNewAdd.Visible = True
            chk_auto.CheckState = CheckState.Unchecked
            box_1.Visible = False
            Label7.Visible = False
            Earaadta_1.Visible = False
            Earaadtalbl.Visible = False
            'nkba.Value = 0
            'total_day_cal()
            'total_mkf()


            'total_mostakt()


            'total_sffy()
            'total_sffy_after_Entkal()
            'total_day_cal()


        End If

    End Sub

    Private Sub btn_save_sharta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save_sharta.Click
        Try

            'فى حالة ان التفريغ  الشرطه
            '=================================================

            '==================================

            If cbx_sharta.Checked = True Then



                'total_day_cal_sharta()
                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()

                'Button4_Click(sender, e)
                '=============================================
                '
            End If

            Txt_seach.Text = ""
            Dim isvalaied As Boolean
            ErrorProvider1.Clear()
            msg_lbl.Text = ""

            If Convert.ToDouble(Me.Saffy_1.Text) <= 0 Then
                'ErrorProvider1.SetError(Saffy, "يجب التاكد من الصافى  !...")
                'isvalaied = False
                MessageBox.Show(" يجب التاكد من الجملة ..؟")
                msg_lbl.Text += "يجب التاكد من الجملة ..؟"
                Exit Sub
            End If


            select_no_55(No_55.Value)
            If dt_select_no_55.Rows.Count > 0 Then

                MessageBox.Show("رقم 55 ع ح مسجل من قبل  ...!")
                ErrorProvider1.SetError(No_55, "تاكد من رقم 55  !...")
                isvalaied = False
                msg_lbl.Text += "  تاكد من رقم 55  !..  ..؟"

            ElseIf Id_Mkf_1.Text.Trim = "" Then
                ErrorProvider1.SetError(Button1, "يجب اختيار اسم مكافاة !...")
                isvalaied = False
                msg_lbl.Text += "  يجب اختيار اسم مكافاة.؟"

                '    'عندما يكون تحديد تصحيح المرتب الاساى فارغ =0
                'ElseIf Me.ComboBox_Salary_ass.Text = vbNullString And chb_tsh_mlahza.CheckState = CheckState.Checked Then
                '    Me.ComboBox_Salary_ass.Text = "0"



            ElseIf No_55.Text.Trim = "" Then
                ErrorProvider1.SetError(No_55, "يجب ادخال رقم 55 ع ح  !...")
                isvalaied = False
                msg_lbl.Text += "  يجب ادخال رقم 55 ع ح  "
            ElseIf Name_emp.Text.Trim = "" Then
                ErrorProvider1.SetError(Name_emp, "يجب ادخال اسم الموظف  !...")
                isvalaied = False
                msg_lbl.Text += "يجب ادخال اسم الموظف  !..."
            ElseIf lbl_erro.Text = "1" Then
                ErrorProvider1.SetError(Name_emp, "اسم الموظف تم ادخاله من قبل !...")
                isvalaied = False
                msg_lbl.Text += "اسم الموظف تم ادخاله من قبل !..."
                MessageBox.Show("رقم القومى مسجل من قبل  ...!")
            ElseIf Convert.ToDouble(Me.Saffy_1.Text) <= 0 Then
                ErrorProvider1.SetError(Saffy_1, "يجب التاكد من الصافى  !...")
                isvalaied = False

            ElseIf Id_Mkf_1.Text = "" Or No_55.Text = "" Or Name_emp.Text = "" Or dt_select_no_kash.Rows.Count > 18 Or Convert.ToDouble(Me.Saffy_1.Text) <= 0 Or Me.Mkf_1.Value <= 0 Then
                MessageBox.Show("يجب التاكد من الجمله اادخال اسم الموظف ,وادخال المكافاة وادخال رقم 55 ع ح و اختيار مكافاة")


            ElseIf Convert.ToInt32(Label9.Text) >= 19 Then

                MessageBox.Show("يجيب انشاء كشف جديد")
                Exit Sub
            Else
                'isvalaied = True
                total_mkf()
                total_mostakt()
                total_sffy()
                total_sffy_after_Entkal()
                Insert_Table_mkf_add(Convert.ToInt32(Idlbl.Text), id_and_user.Text, Convert.ToInt32(No_55.Text), Convert.ToInt32(no_kshf.Text), Name_emp.Text, Name_school.Text, Convert.ToDouble(ComboBox_Salary_ass.Text), Convert.ToInt32(Dayes_1.Text), Mkf_1.Value, Convert.ToDouble(mkf_22.Text), Badl_safer.Value, Entklat_1.Value, total_mkff.Value, Mashat_9.Value, mash1_1.Value, Darabb_1.Value, nkba_1.Value, tamen_11.Value, Mastshfa_1.Value, Convert.ToDouble(Damghh_1.Value), Earaadta_1.Value, box_1.Value, Mzay_t17.Value, Convert.ToDouble(Total_Mostkta_1.Text), Convert.ToDouble(Saffy_1.Text), Convert.ToInt32(Id_Mkf_1.Text), date_1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, Convert.ToDouble(saffa_after_1.Text), radb_nkaba.Checked, rb_tsh.Checked, Convert.ToInt32(txt_user.Text), chk_auto.Checked, auto_total_1.Checked, rb_mlahza.Checked, cbx_sharta.Checked, rb_zar.Checked)

                MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
                'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
                Idlbl.Text = Max_Table_mkf_add() + 1
                id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                SelectAll_Table_no_kshf(no_k)
                no_kshfff = no_kshf.Value
                select_no_kash(no_kshfff)
                dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
                ClearControls()
                Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()

                'ايجاد اخر سطرفى دات
                'dgv_Table_add_tfrgh.Focus()
                dgv_Table_add_tfrgh.CurrentCell = dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(1)
                id_noo_combx.BackColor = Color.Gold
                id_noo_combx.Focus()
                'isvalaied = True
                ErrorProvider1.Clear()
                msg_lbl.Text = ""
            End If
            If dt_select_no_kash.Rows.Count > 18 Then
                MessageBox.Show("لا يمكن اضافة يجب انشاء كشف تفريغ جديد")
                If MessageBox.Show("هل تريد انشاء كشف تفريغ جديد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                Else
                    Form_all_mkf.frm_stat = "add"
                    isvalaied = True
                    Idlbl.Text = Max_Table_mkf_add() + 1
                    id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                    no_kshf.Text = Max_no_kshf() + 1
                    no_kshfff = no_kshf.Value

                    select_no_kash(no_kshfff)
                    dgv_Table_add_tfrgh.DataSource = dt_select_no_kash

                    auto_txt_name_emp(Name_emp)
                    auto_txt_Name_school()
                    'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

                    BtnNewAdd.Enabled = True

                    ClearControls()
                    Label9.Text = "0"

                End If
            End If
            '==================لعرض الاسم======
            If dgv_Table_add_tfrgh.Rows.Count > 0 Then

                dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(20).Selected = True


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try

    End Sub





    Private Sub radb_nkaba_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (radb_nkaba.Checked = True) Then


            Me.radb_nkaba.Text = "نقابى"
            Cmbx_nokapa.Text = "معلم"
            msg_lbl.Text = ""
            nkba_1.Value = Math.Round((Mkf_1.Value * 2) / 100, 1)
            total_day_cal()
            total_mkf()

            total_mostakt()
            total_sffy()
            total_sffy_after_Entkal()
            total_day_cal()


            'ElseIf (Chb_nkaba.Checked = False) Then
            '    Me.Chb_nkaba.Text = "غير نقابى"

            '    nkba.Value = 0
            '    total_day_cal()
            '    total_mkf()


            '    total_mostakt()


            '    total_sffy()
            '    total_sffy_after_Entkal()
            '    total_day_cal()


        End If
    End Sub

    Private Sub rad_b_no_nokapy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (rad_b_no_nokapy.Checked = True) Then


            Me.rad_b_no_nokapy.Text = "غير نقابى"
            Cmbx_nokapa.Text = "ادارى"
            msg_lbl.Text = ""
            nkba_1.Value = Math.Round((Mkf_1.Value * 2) / 100, 1)
            total_day_cal()
            total_mkf()

            total_mostakt()
            total_sffy()
            total_sffy_after_Entkal()
            total_day_cal()


            'ElseIf (Chb_nkaba.Checked = False) Then
            '    Me.Chb_nkaba.Text = "غير نقابى"

            '    nkba.Value = 0
            '    total_day_cal()
            '    total_mkf()


            '    total_mostakt()


            '    total_sffy()
            '    total_sffy_after_Entkal()
            '    total_day_cal()


        End If
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ''If chk_auto.CheckState = CheckState.Unchecked Then


        'auto_name_emp(dt_auto_name_emp, id_noo_combx.Text)
        ''Try
        'auto_Name_school(dt_auto_Name_school, Name_school, Name_emp.Text)
        'auto_id_no(dt_auto_Name_school)
        'auto_name_pay(dt_auto_Name_school)
        'auto_alkta(dt_auto_Name_school)
        'auto_no_emp(dt_auto_Name_school)
        'auto_salary_ass(dt_auto_salary_ass, ComboBox_Salary_ass, id_noo_combx.Text)
        ''معرفة نقابى اوغير نقابى 
        'auto_techer_or_no(dt_auto_techer_or_no, Cmbx_nokapa, id_noo_combx.Text)
        ''Catch
        ''    dt_auto_Name_school.Clear()

        ''End Try
        ''End If

        search_emp_q.ShowDialog()
        search_emp_q.Name_emp_seach.Focus()

    End Sub


    Private Sub ComboBox_Salary_ass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox_Salary_ass.KeyDown
        If e.KeyCode = Keys.Down Then
            Dayes_1.Focus()
            Dayes_1.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            id_noo_combx.Focus()
            id_noo_combx.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Left Then
            Badl_safer.Focus()
            Badl_safer.BackColor = Color.Gold
        End If

    End Sub

    Private Sub chb_sha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (rb_zar.Checked = True) Then


            'Me.chb_sha.Text = "صحه"
            'btn_save_sharta.Visible = True
            BtnNewAdd.Visible = False
            chk_auto.CheckState = CheckState.Checked
            box_1.Visible = True
            Label7.Visible = True
            Earaadta_1.Visible = True
            Earaadtalbl.Visible = True
            Label14.Text = "شرطه"
            'Chb_nkaba.Checked = True
            'nkba.Value = Math.Round((Mkf.Value * 2) / 100, 1)
            'total_day_cal()
            'total_mkf()

            'total_mostakt()
            'total_sffy()
            'total_sffy_after_Entkal()
            'total_day_cal()


        ElseIf (cbx_sharta.Checked = False) Then

            btn_save_sharta.Visible = False
            BtnNewAdd.Visible = True
            chk_auto.CheckState = CheckState.Unchecked
            box_1.Visible = False
            Label7.Visible = False
            Earaadta_1.Visible = False
            Earaadtalbl.Visible = False
            'nkba.Value = 0
            'total_day_cal()
            'total_mkf()


            'total_mostakt()


            'total_sffy()
            'total_sffy_after_Entkal()
            'total_day_cal()


        End If


    End Sub

    Private Sub cbx_sharta_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbx_sharta.CheckedChanged
        If cbx_sharta.Checked = True Then
            BtnNewAdd.Visible = False
            btn_save_sharta.Visible = True
            chk_auto.Checked = True
        Else
            BtnNewAdd.Visible = True
            btn_save_sharta.Visible = False
            chk_auto.Checked = False
        End If
    End Sub


    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        cal_form.Show()
    End Sub

    Private Sub ComboBox_Salary_ass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox_Salary_ass.KeyPress
        no_used_char2(e)
    End Sub


    Private Sub select_drab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_drab.Click
        'select_drab_Form.ShowDialog()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        noused_char(e)

    End Sub





    Private Sub saffa_after_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saffa_after_1.TextChanged
        textbox_to_deciemal(saffa_after_1)
    End Sub

    Private Sub Saffy_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Saffy_1.TextChanged
        textbox_to_deciemal(Saffy_1)
    End Sub

    Private Sub Total_Mostkta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Total_Mostkta_1.TextChanged
        textbox_to_deciemal(Total_Mostkta_1)
    End Sub



    Private Sub mkf_2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mkf_22.KeyPress
        noused_char(e)
    End Sub

    Private Sub mkf_2_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mkf_22.Leave
        textbox_to_deciemal(mkf_22)
    End Sub

    Private Sub mkf_2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mkf_22.MouseClick
        mkf_22.BackColor = Color.Gold
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mkf_2_lbl.Click
        If mkf_2_lbl.Text = "مكافات اخرى" Then
            mkf_22.Visible = True
            mkf_2_lbl.Text = "مكافات اخري"
        Else
            mkf_22.Visible = False
            mkf_2_lbl.Text = "مكافات اخرى"

        End If

    End Sub

    Private Sub Entklatlbl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entklatlbl.CheckedChanged, id_noo_combx.SelectedIndexChanged
        If Entklatlbl.CheckState = CheckState.Checked Then
            Entklat_1.Maximum = 3000
        Else
            Entklat_1.Maximum = 401
        End If
        auto_salary_ass(dt_auto_salary_ass, ComboBox_Salary_ass, id_noo_combx.Text)
    End Sub

    Private Sub Badl_saferlbl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badl_saferlbl.CheckedChanged
        If Badl_saferlbl.CheckState = CheckState.Checked Then
            Badl_safer.Maximum = 3000
        Else
            Badl_safer.Maximum = 401
        End If
    End Sub

    Private Sub BtnDelete_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Txt_seach.Text = ""
            'Delete_mkf_tfrgh(dgv_Table_add_tfrgh)
            Delete_id_tfrgh(id_and_user.Text)

            'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
            Idlbl.Text = Max_Table_mkf_add() + 1
            id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
            no_kshfff = Max_no_kshf()
            no_k = Max_no_kshf()
            select_no_kash(no_kshfff)
            dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
            radb_nkaba.Checked = False
            ClearControls()

            BtnDelete.Enabled = False
            Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
            'close_text_box()
            '================================
            BtnSave_Click(sender, e)
        End If

    End Sub









    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        salary_add_Form.ShowDialog()
    End Sub

    Private Sub id_noo_combx_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim id As String = id_noo_combx.Text
    End Sub






    Private Sub dgv_Table_add_tfrgh_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Table_add_tfrgh.CellClick
        If (dt_select_no_kash.Rows.Count > 0) Then
            BtnDelete.Enabled = True
            open_text_box()
            BtnNewAdd.Enabled = False
            btn_save_sharta.Enabled = False
            'Try


            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox4.Checked = True
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
            With dgv_Table_add_tfrgh
                Me.Idlbl.Text = .CurrentRow.Cells("iid").Value.ToString()
                Me.id_and_user.Text = .CurrentRow.Cells("id_and_user_tfg").Value.ToString()
                Me.No_55.Text = .CurrentRow.Cells("No_5").Value
                Me.no_kshf.Text = .CurrentRow.Cells("no_kashf").Value.ToString()
                Me.Name_emp.Text = .CurrentRow.Cells("Name_Emp1").Value.ToString()
                Me.Name_school.Text = .CurrentRow.Cells("Name_school_1").Value.ToString()
                Me.ComboBox_Salary_ass.Text = .CurrentRow.Cells("Salary_ass").Value
                Me.Dayes_1.Text = .CurrentRow.Cells("Dayes").Value.ToString()
                Me.Mkf_1.Text = .CurrentRow.Cells("Mkf").Value
                Me.mkf_22.Text = .CurrentRow.Cells("mkf_2").Value

                Me.Badl_safer.Text = .CurrentRow.Cells("Badl_safer_1").Value
                Me.Entklat_1.Text = .CurrentRow.Cells("Entklat").Value
                Me.total_mkff.Text = .CurrentRow.Cells("total").Value
                Me.Mashat_9.Text = .CurrentRow.Cells("Mashat").Value
                Me.mash1_1.Text = .CurrentRow.Cells("Mashat8").Value
                Me.Darabb_1.Text = .CurrentRow.Cells("Darabb").Value
                Me.nkba_1.Text = .CurrentRow.Cells("nkaba").Value
                Me.tamen_11.Text = .CurrentRow.Cells("Mhann").Value
                Me.Mastshfa_1.Text = .CurrentRow.Cells("Mastshfa").Value
                Me.Damghh_1.Text = .CurrentRow.Cells("Damghh").Value
                Me.Earaadta_1.Text = .CurrentRow.Cells("Earaadta").Value
                Me.box_1.Text = .CurrentRow.Cells("box20").Value
                Me.Mzay_t17.Text = .CurrentRow.Cells("Mzay_t_17_25").Value
                Me.Total_Mostkta_1.Text = .CurrentRow.Cells("Total_Mostkta").Value
                Me.Saffy_1.Text = .CurrentRow.Cells("Saffy").Value

                Me.Id_Mkf_1.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                'If .CurrentRow.Cells("date1").Value Is vbNullString Then
                '    Me.date_1.Value = Today

                'Else
                '    Me.date_1.Value = .CurrentRow.Cells("date1").Value
                'End If

                Me.id_noo_combx.Text = .CurrentRow.Cells("id_no").Value.ToString()
                Me.cmbx_name_pay.Text = .CurrentRow.Cells("op_name_pay").Value.ToString()
                Me.cmbx_alkta.Text = .CurrentRow.Cells("op_al_kta").Value.ToString()
                Me.cmbx_no_emp.Text = .CurrentRow.Cells("op_no_emb").Value.ToString()
                Me.saffa_after_1.Text = .CurrentRow.Cells("Saffy_after_antkal").Value
                Me.radb_nkaba.Checked = .CurrentRow.Cells("nakab_yes_no").Value
                Me.rb_tsh.Checked = .CurrentRow.Cells("chb_tsh_mlahza").Value
                Me.chk_auto.Checked = .CurrentRow.Cells("Auto_emp").Value
                Me.auto_total_1.Checked = .CurrentRow.Cells("Auto_total").Value
                Me.rb_mlahza.Checked = .CurrentRow.Cells("chb_mlahza").Value
                Me.cbx_sharta.Checked = .CurrentRow.Cells("chb_ٍsharta").Value
                Me.rb_zar.Checked = .CurrentRow.Cells("chb_zar_shee").Value
                No_55.Enabled = True
                ComboBox_Salary_ass.Enabled = True
                Dayes_1.Enabled = True
                Name_emp.Enabled = True
                Name_school.Enabled = True
                Mkf_1.Enabled = True
                Badl_safer.Enabled = True
                Entklat_1.Enabled = True
                Mashat_9.Enabled = True
                Darabb_1.Enabled = True
                tamen_11.Enabled = True
                Mastshfa_1.Enabled = True
                Damghh_1.Enabled = True
                Earaadta_1.Enabled = True
                Mzay_t17.Enabled = True
                BtnNewAdd.Enabled = False
                Btn_new.Enabled = True
            End With
            'Catch ex As Exception
            '    MessageBox.Show(ex.Message)
            'End Try
        End If

    End Sub



    Private Sub ComboBox_work_SelectedIndexChanged(sender As Object, e As EventArgs)
        If (ComboBox_work.Text = "عامل خدمات" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة ثالث" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة خامس" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة رابع" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة سادس") Then



            Radio_b_work.Checked = True
            msg_lbl.Text = ""
            nkba_1.Value = Math.Round((Mkf_1.Value * 2) / 100, 1)
            total_day_cal()
            total_mkf()

            total_mostakt()
            total_sffy()
            total_sffy_after_Entkal()
            total_day_cal()
        Else
            Radio_b_work.Checked = False




        End If
    End Sub

    Private Sub Radio_b_work_CheckedChanged(sender As Object, e As EventArgs)
        If (Radio_b_work.Checked = True) Then


            If (ComboBox_work.Text = "عامل خدمات" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة ثالث" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة خامس" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة رابع" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة سادس") Then
                Radio_b_work.Checked = True
            Else

                Radio_b_work.Checked = False
            End If
            msg_lbl.Text = ""
            nkba_1.Value = Math.Round((Mkf_1.Value * 2) / 100, 1)
            total_day_cal()
            total_mkf()

            total_mostakt()
            total_sffy()
            total_sffy_after_Entkal()
            total_day_cal()
        Else

            ComboBox_work.Text = ""



        End If
    End Sub


    Private Sub Btn_new_Click(sender As Object, e As EventArgs) Handles Btn_new.Click
        'Try


        Txt_seach.Text = ""
        Form_all_mkf.frm_stat = "add"
        dgv_Table_add_tfrgh.ClearSelection()
        no_k = Max_no_kshf()

        open_text_box()
        Idlbl.Text = Max_Table_mkf_add() + 1

        id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
        no_kshfff = Max_no_kshf()

        no_k = Max_no_kshf()

        select_no_kash(no_kshfff)
        dgv_Table_add_tfrgh.DataSource = dt_select_no_kash

        auto_txt_name_emp(Name_emp)


        BtnNewAdd.Enabled = True
        btn_save_sharta.Enabled = True
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        ClearControls()


        '======تحميل جدول المكافاة

        Dim Id_Mkff As Integer

        Id_Mkff = dgv_Table_add_tfrgh.CurrentRow.Cells("Id_Mkf").Value

        Id_Mkff = Id_Mkff
        Id_Mkf_1.Text = Id_Mkff.ToString()
        select_id_mkf(Convert.ToInt32(Id_Mkff))
        DataGridView1.DataSource = dt_select_id_mkf
        Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
        Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
        Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
        term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
        'Label9.Text = dgv_Table_mkf_add.RowCount().ToString()
        'تحميل listbox
        'no_k = 20
        'no_k = Max_no_kshf()


        SelectSome_Table_mkf_add_indirect(ListBox1)

        SelectAll_Table_no_kshf(no_k)
        dgv_Table_add_tfrgh.DataSource = dt_Table_mkf_no_kshff


        'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

        'try_form.DataGridViewHeaderTxxtedit(dgv_Table_add_tfrgh)
        no_k = Max_no_kshf()
        ListBox1.SelectedValue = no_k
        Me.no_kshf.Text = dgv_Table_add_tfrgh.CurrentRow.Cells("no_kashf").Value.ToString()
        Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
        'ايجاد اخر سطرفى دات
        'dgv_Table_add_tfrgh.Focus()
        dgv_Table_add_tfrgh.CurrentCell = dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(1)
        id_noo_combx.Focus()
        Name_emp.BackColor = Color.Gold

        'عرض العمود رقم 21
        If dgv_Table_add_tfrgh.Rows.Count > 0 Then

            dgv_Table_add_tfrgh.Rows(dgv_Table_add_tfrgh.RowCount - 1).Cells(20).Selected = True

        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        If MessageBox.Show("هل تريد انشاء كشف تفريغ جديد ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else

            Form_all_mkf.frm_stat = "add"

            Idlbl.Text = Max_Table_mkf_add() + 1
            id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
            no_kshf.Text = Max_no_kshf() + 1
            no_kshfff = no_kshf.Value

            select_no_kash(no_kshfff)
            dgv_Table_add_tfrgh.DataSource = dt_select_no_kash




            auto_txt_name_emp(Name_emp)
            'auto_txt_Name_school()

            'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

            BtnNewAdd.Enabled = True

            ClearControls()
            Label9.Text = "0"
            open_text_box()
            SelectAll_Table_no_kshf(no_kshf.Value)
            dgv_Table_add_tfrgh.DataSource = dt_Table_mkf_no_kshff
            'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)

        End If


    End Sub

    Private Sub BtnEdit_Click_2(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            btn_cal_Click(sender, e)

            If (rb_mlahza.Checked = True And auto_total_1.Checked = False) Then




                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()
                total_day_cal()
                '=================
                'اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                if_total_larg_than_4000()
            End If
            '===============
            'فى حالة ان التفريغ  الشرطه
            '=================================================

            If (cbx_sharta.Checked = True And auto_total_1.Checked = False) Then



                'total_day_cal_sharta()
                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()

                Button4_Click(sender, e)

            End If
            '===================================
            Txt_seach.Text = ""

            If Id_Mkf_1.Text = "" Or No_55.Text = "" Or Name_emp.Text = "" Or Convert.ToDouble(Me.Saffy_1.Text) <= 0 Then

                MessageBox.Show("!يجب التاكد من الجمله اادخال اسم الموظف , وادخال المكافاة وادخال رقم 55 ع ح و اختيار مكافاة!")
                Exit Sub
            ElseIf ComboBox_Salary_ass.Text = 0 And rb_mlahza.Checked = True Then

                MessageBox.Show("يجب التاكد من المرتب الاساسى ...")
                Exit Sub

            End If
            '==================================================================================
            If auto_total_1.Text = "Auto_cal" Then
                '=================
                ''اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                'if_total_larg_than_4000()
                ''=============================================

                Button4_Click(sender, e)


                Update_Table_mkf_add(Convert.ToInt32(Idlbl.Text), id_and_user.Text, No_55.Value, no_kshf.Value, Name_emp.Text, Name_school.Text, Convert.ToDouble(ComboBox_Salary_ass.Text), Dayes_1.Value, Mkf_1.Value, Convert.ToDouble(mkf_22.Text), Badl_safer.Value, Entklat_1.Value, total_mkff.Value, Mashat_9.Value, mash1_1.Value, Darabb_1.Value, nkba_1.Value, tamen_11.Value, Mastshfa_1.Value, Convert.ToDouble(Damghh_1.Value), Earaadta_1.Value, box_1.Value, Mzay_t17.Value, Convert.ToDouble(Total_Mostkta_1.Text), Convert.ToDouble(Saffy_1.Text), Convert.ToInt32(Id_Mkf_1.Text), date_1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, Convert.ToDouble(saffa_after_1.Text), radb_nkaba.Checked, rb_tsh.Checked, chk_auto.Checked, auto_total_1.Checked, rb_mlahza.Checked, cbx_sharta.Checked, rb_zar.Checked)





                ClearControls()

                'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
                Idlbl.Text = Max_Table_mkf_add() + 1
                id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                no_kshfff = no_kshf.Value
                no_k = no_kshf.Value

                select_no_kash(no_kshfff)
                dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
                radb_nkaba.Checked = False
                ClearControls()
                Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
                BtnEdit.Enabled = False
                'close_text_box()
                '================================
                BtnSave_Click(sender, e)
                drab = 10
                select_drab.Text = " ضرائب" + Convert.ToString(drab)
                Me.Darabb_1.Text = vbNullString



            Else

                '=================
                'اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                If auto_total_1.Checked = False Then
                    if_total_larg_than_4000()
                End If


                Button4_Click(sender, e)
                '=============================================

                Update_Table_mkf_add(Convert.ToInt32(Idlbl.Text), id_and_user.Text, No_55.Value, no_kshf.Value, Name_emp.Text, Name_school.Text, Convert.ToDouble(ComboBox_Salary_ass.Text), Dayes_1.Value, Mkf_1.Value, Convert.ToDouble(mkf_22.Text), Badl_safer.Value, Entklat_1.Value, total_mkff.Value, Mashat_9.Value, mash1_1.Value, Darabb_1.Value, nkba_1.Value, tamen_11.Value, Mastshfa_1.Value, Convert.ToDouble(Damghh_1.Value), Earaadta_1.Value, box_1.Value, Mzay_t17.Value, Convert.ToDouble(Total_Mostkta_1.Text), Convert.ToDouble(Saffy_1.Text), Convert.ToInt32(Id_Mkf_1.Text), date_1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, Convert.ToDouble(saffa_after_1.Text), radb_nkaba.Checked, rb_tsh.Checked, chk_auto.Checked, auto_total_1.Checked, rb_mlahza.Checked, cbx_sharta.Checked, rb_zar.Checked)





                'total_mkf()
                'total_mostakt()
                'total_sffy()
                'total_sffy_after_Entkal()





                ClearControls()

                'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
                Idlbl.Text = Max_Table_mkf_add() + 1
                id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                no_kshfff = no_kshf.Value
                no_k = no_kshf.Value

                select_no_kash(no_kshfff)
                dgv_Table_add_tfrgh.DataSource = dt_select_no_kash

                ClearControls()
                Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
                BtnEdit.Enabled = False
                'close_text_box()
                '================================
                BtnSave_Click(sender, e)



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnDelete_Click_3(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Txt_seach.Text = ""
            'Delete_mkf_tfrgh(dgv_Table_add_tfrgh)
            Delete_id_tfrgh(id_and_user.Text)

            'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
            Idlbl.Text = Max_Table_mkf_add() + 1
            id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
            no_kshfff = Max_no_kshf()
            no_k = Max_no_kshf()
            select_no_kash(no_kshfff)
            dgv_Table_add_tfrgh.DataSource = dt_select_no_kash
            radb_nkaba.Checked = False
            ClearControls()

            BtnDelete.Enabled = False
            Label9.Text = dgv_Table_add_tfrgh.RowCount().ToString()
            'close_text_box()
            '================================
            BtnSave_Click(sender, e)
        End If

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        search_tafrgh.Show()
    End Sub

    Private Sub Button10_Click_2(sender As Object, e As EventArgs) Handles Button10.Click
        salary_add_Form.ShowDialog()
    End Sub

    Private Sub Radio_b_work_CheckedChanged_1(sender As Object, e As EventArgs) Handles Radio_b_work.CheckedChanged
        If (ComboBox_work.Text = "عامل خدمات" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة ثالث" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة خامس" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة رابع" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة سادس") Then
            Radio_b_work.Checked = True
            msg_lbl.Text = "عامل خدمات"
            MsgBox("عــامـــل خدمــات", MsgBoxStyle.Exclamation, "تنبيه")
        Else

            Radio_b_work.Checked = False
            msg_lbl.Text = ""
        End If
    End Sub

    Private Sub ComboBox_work_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox_work.SelectedIndexChanged
        If (ComboBox_work.Text = "عامل خدمات" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة ثالث" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة خامس" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة رابع" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة سادس") Then
            Radio_b_work.Checked = True
            msg_lbl.Text = "عامل خدمات"
            MsgBox("عــامـــل خدمــات", MsgBoxStyle.Exclamation, "تنبيه")


        Else

            Radio_b_work.Checked = False
            msg_lbl.Text = ""
        End If
    End Sub

    Private Sub id_noo_combx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles id_noo_combx.KeyPress
        no_used_char2(e)
    End Sub

    Private Sub radb_nkaba_CheckedChanged_1(sender As Object, e As EventArgs) Handles radb_nkaba.CheckedChanged
        If (radb_nkaba.Checked = True) Then


            Me.radb_nkaba.Text = "نقابى"
            Cmbx_nokapa.Text = "معلم"
            msg_lbl.Text = ""
            nkba_1.Value = Math.Round((Mkf_1.Value * 2) / 100, 1)
            total_day_cal()
            total_mkf()

            total_mostakt()
            total_sffy()
            total_sffy_after_Entkal()
            total_day_cal()


            'ElseIf (Chb_nkaba.Checked = False) Then
            '    Me.Chb_nkaba.Text = "غير نقابى"

            '    nkba.Value = 0
            '    total_day_cal()
            '    total_mkf()


            '    total_mostakt()


            '    total_sffy()
            '    total_sffy_after_Entkal()
            '    total_day_cal()


        End If
    End Sub

    Private Sub rad_b_no_nokapy_CheckedChanged_1(sender As Object, e As EventArgs) Handles rad_b_no_nokapy.CheckedChanged
        If (rad_b_no_nokapy.Checked = True) Then


            Me.rad_b_no_nokapy.Text = "غير نقابى"
            Cmbx_nokapa.Text = "ادارى"
            msg_lbl.Text = ""
            nkba_1.Value = Math.Round((Mkf_1.Value * 2) / 100, 1)
            total_day_cal()
            total_mkf()

            total_mostakt()
            total_sffy()
            total_sffy_after_Entkal()
            total_day_cal()


            'ElseIf (Chb_nkaba.Checked = False) Then
            '    Me.Chb_nkaba.Text = "غير نقابى"

            '    nkba.Value = 0
            '    total_day_cal()
            '    total_mkf()


            '    total_mostakt()


            '    total_sffy()
            '    total_sffy_after_Entkal()
            '    total_day_cal()


        End If
    End Sub

    Private Sub rb_zar_CheckedChanged(sender As Object, e As EventArgs) Handles rb_zar.CheckedChanged
        Cmbx_nokapa.Text = "ادارى"
        total_day_cal()
        total_mkf()

        total_mostakt()
        total_sffy()
        total_sffy_after_Entkal()
        total_day_cal()
    End Sub

    Private Sub Radio_drab_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Radio_drab.CheckedChanged
        If (Radio_drab.Checked = True) Then
            Num_drab.Enabled = False
            Darabb_1.Value = 0
            drab = 0
        Else
            Num_drab.Enabled = True
            drab = Convert.ToDouble(Num_drab.Value)
            Darabb_1.Value = Math.Round(total_mkff.Value * Num_drab.Value)

        End If
    End Sub

    Private Sub Txt_seach_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Txt_seach.MouseClick
        Txt_seach.BackColor = Color.Gold
    End Sub

End Class