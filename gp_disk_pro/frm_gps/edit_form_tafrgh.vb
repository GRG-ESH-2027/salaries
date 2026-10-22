Imports System.Data.OleDb

Public Class edit_form_tafrgh
    Public stat_frm As String
    Public no_k As Integer
    Public no_kshfff As Integer
    Public mkf_count As Integer
    Public cel As Integer = 2
    Public cel_r As Integer = 30
    Public drab As Double = 0.003
    '==================================
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



    '===============
    Public Sub format_datagridview()
      
        If DataGridView2.Rows.Count >= 8 Then
            For i As Integer = 0 To DataGridView2.Rows.Count - 6


                'i += 1

                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                i += 1
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                i += 1
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                i += 1
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Orange

            Next


        End If

        DataGridView2.Columns("no_kshf").DefaultCellStyle.Format = "N0"
        DataGridView2.Columns("Salary_ass").DefaultCellStyle.Format = "N2"
        DataGridView2.Columns("Mkf").DefaultCellStyle.Format = "N2"
        DataGridView2.Columns("mkf_2").DefaultCellStyle.Format = "N2"
        DataGridView2.Columns("total").DefaultCellStyle.Format = "N2"
        DataGridView2.Columns("Badl_safer").DefaultCellStyle.Format = "N2"
        DataGridView2.Columns("Entklat").DefaultCellStyle.Format = "N2"

        DataGridView2.Columns("no_kshf").Width = 50
        DataGridView2.Columns("No_55").Width = 50
        DataGridView2.Columns("Name_Emp").Width = 250
        DataGridView2.Columns("id_no").Width = 130
        DataGridView2.Columns("Dayes").Width = 50
        DataGridView2.Columns("Salary_ass").Width = 80
        DataGridView2.Columns("Badl_safer").Width = 50
        DataGridView2.Columns("Entklat").Width = 60
    End Sub


    '================
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
            Me.Name_emp_txt.Text = Name_emp


        End If

    End Sub
    '==========================================
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
        Name_emp_txt.AutoCompleteCustomSource = data_souce
        Name_emp_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        Name_emp_txt.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    '=========================
    'الاستكمال التلقائى لرقم القومى textbox====================================
    Public dt_auto_id_no As New DataTable
    Public Sub auto_id_no(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_id_no.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_emp_txt.Text + "'", con)

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

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_emp_txt.Text + "'", con)

        da.Fill(dt_auto_name_pay)

        cmbx_name_pay.DataSource = dt_auto_name_pay
        cmbx_name_pay.DisplayMember = "name_pay"

    End Sub

    'الاستكمال التلقائى  القطاع textbox====================================
    Public dt_auto_alkta As New DataTable
    Public Sub auto_alkta(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_alkta.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_emp_txt.Text + "'", con)

        da.Fill(dt_auto_alkta)

        cmbx_alkta.DataSource = dt_auto_alkta
        cmbx_alkta.DisplayMember = "al_kta"

    End Sub

    'الاستكمال التلقائى  رقم الموظف textbox====================================
    Public dt_auto_no_emp As New DataTable
    Public Sub auto_no_emp(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_no_emp.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_emp_txt.Text + "'", con)

        da.Fill(dt_auto_no_emp)

        cmbx_no_emp.DataSource = dt_auto_no_emp
        cmbx_no_emp.DisplayMember = "no_emb"

    End Sub



    '================================
    Public Sub open_text_box()
        No_55_val.Enabled = True
        ComboBox_Salary_ass.Enabled = True
        Name_emp_txt.Enabled = True
        Name_school_txt.Enabled = True
        id_noo_combx.Enabled = True
        Dayes_vale.Enabled = True
        Mkf_val.Enabled = True
        Badl_safer_vale.Enabled = True
        Entklat_val.Enabled = True
        Mashat_val.Enabled = True
        mash1_val.Enabled = True
        Darabb_val.Enabled = True
        nkba_val.Enabled = True
        tamen_1_val.Enabled = True
        Mastshfa_vale.Enabled = True
        Earaadta_val.Enabled = True
        mkf_2_val.Enabled = True
        Mzay_t17.Enabled = True
    End Sub
    '======================================
    Public Sub ClearControls()
        Me.Id_lbl.Text = vbNullString
        Me.No_55_val.Text = vbNullString

        Me.Name_emp_txt.Text = vbNullString
        Name_school_txt.Text = vbNullString
        Me.id_noo_combx.Text = vbNullString
        Me.ComboBox_Salary_ass.Text = vbNullString
        'Me.Salary_ass.Value = 0
        Me.Dayes_vale.Text = vbNullString
        Me.Mkf_val.Value = 0
        Me.mkf_2_val.Text = 0

        Me.Badl_safer_vale.Text = vbNullString
        Me.Entklat_val.Text = vbNullString
        Me.total_mkff.Value = vbNullString
        Me.Mashat_val.Text = vbNullString
        Me.mash1_val.Text = vbNullString
        Me.Darabb_val.Text = vbNullString
        Me.nkba_val.Text = vbNullString
        Me.tamen_1_val.Text = vbNullString
        Me.Mastshfa_vale.Text = vbNullString
        Me.Damghh_val.Text = vbNullString
        Me.Earaadta_val.Text = vbNullString
        Me.box_val.Text = vbNullString
        Me.Total_Mostkta_val.Text = vbNullString
        Me.Saffy_val.Text = vbNullString
        'Me.Id_Mkf.Text = vbNullString
        Me.date1.Value = Today
        Me.mash1_val.Text = vbNullString
        Me.nkba_val.Text = vbNullString
        Me.box_val.Text = vbNullString
        Me.saffa_after_val.Text = vbNullString
        cmbx_name_pay.Text = ""
        cmbx_alkta.Text = ""
        cmbx_no_emp.Text = ""
        id_noo_combx.Text = ""

        No_55_val.Enabled = True
        ComboBox_Salary_ass.Enabled = True
        Dayes_vale.Enabled = True
        Name_emp_txt.Enabled = True
        id_noo_combx.Enabled = True
        Mkf_val.Enabled = True
        Badl_safer_vale.Enabled = True
        Entklat_val.Enabled = True
        Mashat_val.Enabled = True
        Darabb_val.Enabled = True
        tamen_1_val.Enabled = True
        Mastshfa_vale.Enabled = True
        Damghh_val.Enabled = True
        Earaadta_val.Enabled = True
        id_noo_combx.Text = ""

    End Sub
    '==================================

    Public Sub total_mostakt()
        Dim tot_mos, Msht, Darab, Mhan, Mastshf, Damgh, Earaadt, mas8, nkb, box20, Mashat_17 As Double
        tot_mos = 0
        If Me.Mashat_val.Text = vbNullString Then
            Me.Mashat_val.Text = "0"

        End If

        If Me.Darabb_val.Text = vbNullString Then
            Me.Darabb_val.Text = "0"
        End If

        If Me.tamen_1_val.Text = vbNullString Then
            Me.tamen_1_val.Text = "0"
        End If

        If Me.Mastshfa_vale.Text = vbNullString Then
            Me.Mastshfa_vale.Text = "0"
        End If

        If Me.Damghh_val.Text = vbNullString Then
            Me.Damghh_val.Text = " 0"
        End If

        If Me.Earaadta_val.Text = vbNullString Then
            Me.Earaadta_val.Text = "0"
        End If

        If Me.mash1_val.Text = vbNullString Then
            Me.mash1_val.Text = "0"
        End If

        If Me.nkba_val.Text = vbNullString Then
            Me.nkba_val.Text = "0"
        End If

        If Me.box_val.Text = vbNullString Then
            Me.box_val.Text = "0"
        End If
        If Me.Mzay_t17.Text = vbNullString Then
            Me.Mzay_t17.Text = "0"
        End If
        Try
            Msht = Convert.ToDouble(Mashat_val.Value)
            Darab = Convert.ToDouble(Darabb_val.Value)
            Mhan = Convert.ToDouble(tamen_1_val.Value)
            Mastshf = Convert.ToDouble(Mastshfa_vale.Value)
            Damgh = Convert.ToDouble(Damghh_val.Value)
            Earaadt = Convert.ToDouble(Earaadta_val.Value)
            mas8 = Convert.ToDouble(mash1_val.Value)
            nkb = Convert.ToDouble(nkba_val.Value)
            box20 = Convert.ToDouble(box_val.Value)
            box20 = Convert.ToDouble(box_val.Value)
            Mashat_17 = Convert.ToDouble(Mzay_t17.Value)
            tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20 + Mashat_17
            Total_Mostkta_val.Text = tot_mos.ToString()
        Catch ex As Exception
            MessageBox.Show("يجب ادخال رقم صحيح")
            Msht = 0
            Msht = Mashat_val.Value

        End Try

    End Sub
    Public Sub total_sffy()
        Dim tota_sff As Double = 0
        tota_sff = total_mkff.Value - Convert.ToDouble(Total_Mostkta_val.Text)
        Saffy_val.Text = tota_sff.ToString()
    End Sub
    '============================الصافى بعد الانتقالات =============
    Public Sub total_sffy_after_Entkal()
        Dim tota_sff_after As Double = 0
        tota_sff_after = (total_mkff.Value - Convert.ToDouble(Total_Mostkta_val.Text)) + Entklat_val.Value + Badl_safer_vale.Value
        saffa_after_val.Text = tota_sff_after.ToString()
    End Sub


    '===================================================
    Public Sub total_mkf()
        Dim tot_mkf As Double = 0
        If Me.Mkf_val.Text = vbNullString Then
            Me.Mkf_val.Text = "0"
        End If
        If Me.mkf_2_val.Text = vbNullString Then
            Me.mkf_2_val.Text = "0"
        End If
        If Me.Dayes_vale.Text = vbNullString Then
            Me.Dayes_vale.Text = "0"

        End If

        If Me.Badl_safer_vale.Text = vbNullString Then
            Me.Badl_safer_vale.Text = "0"
        End If
        If Me.Entklat_val.Text = vbNullString Then
            Me.Entklat_val.Text = "0"
        End If
        tot_mkf = tot_mkf + Mkf_val.Value + Convert.ToDouble(mkf_2_val.Text)
        total_mkff.Value = tot_mkf
    End Sub
    '=========================================
    'حساب عدد الايام
    'ط================
    Public Sub total_day_cal()
        Dim tot_mos, Msht, Darab, Mhan, Mastshf, Damgh, Earaadt, mas8, nkb, box20, Mash_17 As Double
        tot_mos = 0



        Try
            Msht = Convert.ToDouble(Mashat_val.Value)
            Darab = Convert.ToDouble(Darabb_val.Value)
            Mhan = Convert.ToDouble(tamen_1_val.Value)
            Mastshf = Convert.ToDouble(Mastshfa_vale.Value)
            Damgh = Convert.ToDouble(Damghh_val.Value)
            Earaadt = Convert.ToDouble(Earaadta_val.Value)
            mas8 = Convert.ToDouble(mash1_val.Value)

            nkb = Convert.ToDouble(nkba_val.Value)

            Mash_17 = Convert.ToDouble(Mzay_t17.Value)
            box20 = Convert.ToDouble(box_val.Value)
            '=================================
            Mashat_val.Value = 0
            Darabb_val.Value = 0
            tamen_1_val.Value = 0
            Mastshfa_vale.Value = 0
            Damghh_val.Value = 0
            Earaadta_val.Value = 0
            mash1_val.Value = 0

            nkba_val.Value = 0


            box_val.Value = 0
            Mzay_t17.Value = 0
            '====================================
            'حساب الملاحظه
            If (rb_mlahza.Checked = True) Then
                'Mkf_val.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_vale.Value)
                Mkf_val.Value = Math.Floor(130 * Dayes_vale.Value)

                Darabb_val.Value = Math.Round(total_mkff.Value * drab)

                'If drab = 10 Then
                '    Darabb_val.Value = Math.Round((total_mkff.Value * 10) / 100, 1, MidpointRounding.AwayFromZero)
                'ElseIf drab = 5 Then
                '    Darabb_val.Value = Math.Round((total_mkff.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
                'ElseIf drab = 15 Then
                '    Darabb_val.Value = Math.Round((total_mkff.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)

                'End If

                Mashat_val.Value = Math.Round((total_mkff.Value * 9) / 100, 1, MidpointRounding.AwayFromZero)



                If (radb_nkaba.Checked = True) Then
                    nkba_val.Value = Math.Round((total_mkff.Value * 2) / 100, 1)
                    Mastshfa_vale.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                ElseIf (radb_nkaba.Checked = False) Then
                    nkba_val.Value = 0
                    Mastshfa_vale.Value = 0

                End If

                mash1_val.Value = Math.Round((total_mkff.Value * 1) / 100, 1)
                tamen_1_val.Value = Math.Round((total_mkff.Value * 1) / 100, 1)
                Mzay_t17.Value = Math.Round((total_mkff.Value * 17.25) / 100, 1, MidpointRounding.AwayFromZero)

                If total_mkff.Value >= 50 Then
                    Damghh_val.Value = Math.Round((total_mkff.Value * 0.7) / 100, 1)
                Else
                    Damghh_val.Value = 0
                End If
                box_val.Value = 0
                box20 = 0
                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20 + Mash_17
                Total_Mostkta_val.Text = tot_mos.ToString()
            End If
            '=====================================================


            '=================   ========    حساب تصحيح         

            If (rb_tsh.Checked = True) Then
                'Mkf.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes.Value)


                If drab = 10 Then
                    Darabb_val.Value = Math.Round((total_mkff.Value * 10) / 100, 1, MidpointRounding.AwayFromZero)
                ElseIf drab = 5 Then
                    Darabb_val.Value = Math.Round((total_mkff.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
                ElseIf drab = 15 Then
                    Darabb_val.Value = Math.Round((total_mkff.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)

                End If

                Mashat_val.Value = Math.Round((total_mkff.Value * 9) / 100, 1, MidpointRounding.AwayFromZero)



                If (radb_nkaba.Checked = True) Then
                    nkba_val.Value = Math.Round((total_mkff.Value * 2) / 100, 1)
                    Mastshfa_vale.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                ElseIf (radb_nkaba.Checked = False) Then
                    nkba_val.Value = 0
                    Mastshfa_vale.Value = 0

                End If

                mash1_val.Value = Math.Round((total_mkff.Value * 1) / 100, 1)
                tamen_1_val.Value = Math.Round((total_mkff.Value * 1) / 100, 1)

                If total_mkff.Value >= 50 Then
                    Damghh_val.Value = Math.Round((total_mkff.Value * 0.7) / 100, 1)
                Else
                    Damghh_val.Value = 0
                End If
                box_val.Value = 0
                box20 = 0
                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20
                Total_Mostkta_val.Text = tot_mos.ToString()
            End If
            '=====================================================
            'حساب زائر الصحى
            If (rb_sha.Checked = True) Then
                Mkf_val.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_vale.Value)




                If drab = 10 Then
                    Darabb_val.Value = Math.Round((total_mkff.Value * 10) / 100, 1, MidpointRounding.AwayFromZero)
                ElseIf drab = 5 Then
                    Darabb_val.Value = Math.Round((total_mkff.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
                ElseIf drab = 15 Then
                    Darabb_val.Value = Math.Round((total_mkff.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)

                End If
                'Mashat.Value = Math.Round((Mkf.Value * 9) / 100, 1, MidpointRounding.AwayFromZero)

0:


                'If (radb_nkaba.Checked = True) Then
                '    nkba.Value = Math.Round((Mkf.Value * 2) / 100, 1)
                '    Mastshfa.Value = Math.Round((Mkf.Value * 1) / 100, 1)

                'ElseIf (radb_nkaba.Checked = False) Then
                Mashat_val.Value = 0
                nkba_val.Value = 0
                Mastshfa_vale.Value = 0
                mash1_val.Value = 0
                tamen_1_val.Value = 0
                box_val.Value = 0
                'End If

                'mash1.Value = Math.Round((Mkf.Value * 1) / 100, 1)
                'tamen_1.Value = Math.Round((Mkf.Value * 1) / 100, 1)

                If total_mkff.Value >= 50 Then
                    Damghh_val.Value = Math.Round((total_mkff.Value * 0.7) / 100, 1)
                Else
                    Damghh_val.Value = 0
                End If
                tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20
                Total_Mostkta_val.Text = tot_mos.ToString()
            End If

            '==================================================
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Msht = 0
            Msht = Mashat_val.Value

        End Try

    End Sub

    '==============================================================
    ' الشرطه : حساب عدد الايام
    'ط================

    Public Sub total_day_cal_sharta()
        Dim tot_mos, Msht, Darab, Mhan, Mastshf, Damgh, Earaadt, mas8, nkb, box20 As Double
        tot_mos = 0



        Try
            Msht = Convert.ToDouble(Mashat_val.Value)
            Darab = Convert.ToDouble(Darabb_val.Value)
            Mhan = Convert.ToDouble(tamen_1_val.Value)
            Mastshf = Convert.ToDouble(Mastshfa_vale.Value)
            Damgh = Convert.ToDouble(Damghh_val.Value)
            Earaadt = Convert.ToDouble(Earaadta_val.Value)
            mas8 = Convert.ToDouble(mash1_val.Value)

            nkb = Convert.ToDouble(nkba_val.Value)


            box20 = Convert.ToDouble(box_val.Value)



            If (cbx_sharta.Checked = True) Then
                Mkf_val.Value = Math.Floor((Convert.ToDouble(ComboBox_Salary_ass.Text) * mkf_count) / 100 * Dayes_vale.Value)


            End If

            If drab = 10 Then
                Darabb_val.Value = Math.Round((total_mkff.Value * 10) / 100, 1, MidpointRounding.AwayFromZero)
            ElseIf drab = 5 Then
                Darabb_val.Value = Math.Round((total_mkff.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
            ElseIf drab = 15 Then
                Darabb_val.Value = Math.Round((total_mkff.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)

            End If
            box_val.Value = Math.Round((total_mkff.Value * 20) / 100, 1)
            Mashat_val.Value = 0
            nkba_val.Value = 0
            Mastshfa_vale.Value = 0
            mash1_val.Value = 0
            tamen_1_val.Value = 0

            If Mkf_val.Value >= 50 Then
                Damghh_val.Value = Math.Round((total_mkff.Value * 0.7) / 100, 1)
            Else
                Damghh_val.Value = 0
            End If
            tot_mos = 0 + tot_mos + Msht + Darab + Mhan + Mastshf + Damgh + Earaadt + mas8 + nkb + box20
            Total_Mostkta_val.Text = tot_mos.ToString()

        Catch ex As Exception
            MessageBox.Show("يجب ادخال رقم صحيح")
            Msht = 0
            Msht = Mashat_val.Value

        End Try



    End Sub
    '==========================

    Public Sub if_total_larg_than_4000()



        If Convert.ToDouble(saffa_after_val.Text) >= 4000 Then
            drab = 15
            select_drab.Text = "15%ضرائب "
            total_day_cal()
            total_mkf()
            total_mostakt()

            total_sffy()
            total_sffy_after_Entkal()
            total_day_cal()
            'Button4_Click(sender, e)
        Else
            select_drab.Text = "10%ضرائب "
            drab = 10
        End If
    End Sub
    '=============================================


    '===============================

    Private Sub edit_form_tafrgh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        date1.Value = Date.Now.Date
        'dgv_Table_add_tfrgh.Columns("no_kshf").DefaultCellStyle.Format = "N0"
        'dgv_Table_add_tfrgh.Columns("No_55").DefaultCellStyle.Format = "N0"
        'dgv_Table_add_tfrgh.Columns(0).DefaultCellStyle.BackColor = Color.Yellow


        'dgv_Table_add_tfrgh.Columns("no_kshf").ValueType = GetType(Integer)
        'dgv_Table_add_tfrgh.Columns("No_55").ValueType = GetType(Integer)

        'For Each row As DataGridViewRow In dgv_Table_add_tfrgh.Rows
        '    row.Cells("no_kshf").Value = Convert.ToInt32(row.Cells("no_kshf").Value)
        'Next
    



    End Sub

    Private Sub Btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_new.Click
        Try
            'auto_txt_Name_school()


            auto_txt_name_emp(Name_emp_txt)
            '======================
            'DataGridView1.AutoGenerateColumns = False
            DataGridView2.AutoGenerateColumns = False
            'select__by_name(DataGridView2)
            SelectAll_Table_mkf_add(DataGridView2)
            format_datagridview()


        Catch ex As Exception
            MessageBox.Show("")

        End Try
   


    End Sub




    Private Sub btn_cal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cal.Click
        '=================================================

        Try
            If Dayes_vale.Value = 0 Then
                rb_tsh.Checked = True
                radb_nkaba.Checked = True
            End If

            '===============================================

            ''فى حالة ان التفريغ غير الشرطه
            'If cbx_sharta.Checked = False Then



            '    select_id_emp(id_noo_combx.Text)
            '    If dt_select_by_name.Rows.Count > 0 Then

            '        MessageBox.Show("رقم قومى مسجل من قبل  ...!")
            '        ErrorProvider1.SetError(No_55_val, " مكرر تاكد من رقم القومى  !...")

            '        msg_lbl.Text += "  تاكد من رقم  القومى مكرر  !..  ..؟"
            '        lbl_erro.Text = "1"
            '        id_noo_combx.Focus()

            '    Else

            '        msg_lbl.Text = ""
            '        lbl_erro.Text = ""


            '    End If
            '=========================
            'معرفة نقابى اوغير نقابى 
            auto_techer_or_no(dt_auto_techer_or_no, Cmbx_nokapa, ComboBox_work, id_noo_combx.Text)
            If (ComboBox_work.Text = "عامل خدمات" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة ثالث" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة خامس" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة رابع" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة سادس") Then
                Radio_b_work.Checked = True
                msg_lbl.Text = "عامل خدمات"
            Else
                Radio_b_work.Checked = False
                msg_lbl.Text = ""

            End If
            If radb_nkaba.Checked = False And rad_b_no_nokapy.Checked = False Then


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
            'If total_larg_than_4000() Then
            '=============================================
            ''عندما يكون تحديد تصحيح المرتب الاساى فارغ =0
            'If Me.ComboBox_Salary_ass.Text = vbNullString And chb_tsh_mlahza.Checked = True Then
            '    Me.ComboBox_Salary_ass.Text = "0"


            'End If

            'End If
            '=====================================================
            'فى حالة ان التفريغ  الشرطه
            '=================================================

            '==================================

            If cbx_sharta.Checked = True Then



                total_day_cal_sharta()

                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()

                Button4_Click(sender, e)
                '=============================================
                '
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click

        Try
            btn_cal_Click(sender, e)
            If (rb_mlahza.Checked = True And auto_total_chk.Checked = False) Then




                total_day_cal()
                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()
                total_day_cal()
            End If
            '===============
            'فى حالة ان التفريغ  الشرطه
            '=================================================

            If (cbx_sharta.Checked = True And auto_total_chk.Checked = False) Then



                total_day_cal_sharta()

                total_mkf()
                total_mostakt()

                total_sffy()
                total_sffy_after_Entkal()

                Button4_Click(sender, e)

            End If
            '===================================
            Txt_seach.Text = ""

            If Id_Mkf_val.Text = "" Or No_55_val.Text = "" Or Name_emp_txt.Text = "" Or Convert.ToDouble(Me.Saffy_val.Text) <= 0 Then

                MessageBox.Show("!يجب التاكد من الجمله اادخال اسم الموظف , وادخال المكافاة وادخال رقم 55 ع ح و اختيار مكافاة!")
                Exit Sub
            ElseIf ComboBox_Salary_ass.Text = 0 And rb_mlahza.Checked = True Then

                MessageBox.Show("يجب التاكد من المرتب الاساسى ...")
                Exit Sub

            End If
            '==================================================================================
            If auto_total_chk.Text = "Auto_cal" Then
                '=================
                ''اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                'if_total_larg_than_4000()
                ''=============================================

                Button4_Click(sender, e)


                Update_Table_mkf_add(Convert.ToInt32(Id_lbl.Text), id_and_user2.Text, No_55_val.Value, no_kshf_vale.Value, Name_emp_txt.Text, Name_school_txt.Text, Convert.ToDouble(ComboBox_Salary_ass.Text), Dayes_vale.Value, Mkf_val.Value, Convert.ToDouble(mkf_2_val.Text), Badl_safer_vale.Value, Entklat_val.Value, total_mkff.Value, Mashat_val.Value, mash1_val.Value, Darabb_val.Value, nkba_val.Value, tamen_1_val.Value, Mastshfa_vale.Value, Convert.ToDouble(Damghh_val.Value), Earaadta_val.Value, box_val.Value, Mzay_t17.Value, Convert.ToDouble(Total_Mostkta_val.Text), Convert.ToDouble(Saffy_val.Text), Convert.ToInt32(Id_Mkf_val.Text), date1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, Convert.ToDouble(saffa_after_val.Text), radb_nkaba.Checked, rb_tsh.Checked, chk_auto.Checked, auto_total_chk.Checked, rb_mlahza.Checked, cbx_sharta.Checked, rb_sha.Checked)

                'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")



                ClearControls()

                'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
                'Id_lbl.Text = Max_Table_mkf_add() + 1
                'id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                'no_kshfff = no_kshf_vale.Value
                'no_k = no_kshf_vale.Value

                'select_no_kash(no_kshfff)
                'DataGridView2.DataSource = dt_select_by_name
                'select__by_name(DataGridView2)
                SelectAll_Table_mkf_add(DataGridView2)
                radb_nkaba.Checked = False
                ClearControls()
                Label9.Text = DataGridView2.RowCount().ToString()
                BtnEdit.Enabled = False
                'close_text_box()
                '================================
                'BtnSave_Click(sender, e)
                drab = 10
                select_drab.Text = "%10 ضرائب"
                Me.Darabb_val.Text = vbNullString



            Else

                '=================
                ''اعادة حساب فى حالة الصافى اكبر من 4000 جنيه
                'If auto_total_chk.Checked = False Then
                '    if_total_larg_than_4000()
                'End If


                Button4_Click(sender, e)
                '=============================================

                Update_Table_mkf_add(Convert.ToInt32(Id_lbl.Text), id_and_user2.Text, No_55_val.Value, no_kshf_vale.Value, Name_emp_txt.Text, Name_school_txt.Text, Convert.ToDouble(ComboBox_Salary_ass.Text), Dayes_vale.Value, Mkf_val.Value, Convert.ToDouble(mkf_2_val.Text), Badl_safer_vale.Value, Entklat_val.Value, total_mkff.Value, Mashat_val.Value, mash1_val.Value, Darabb_val.Value, nkba_val.Value, tamen_1_val.Value, Mastshfa_vale.Value, Convert.ToDouble(Damghh_val.Value), Earaadta_val.Value, box_val.Value, Mzay_t17.Value, Convert.ToDouble(Total_Mostkta_val.Text), Convert.ToDouble(Saffy_val.Text), Convert.ToInt32(Id_Mkf_val.Text), date1.Value, id_noo_combx.Text, cmbx_name_pay.Text, cmbx_alkta.Text, cmbx_no_emp.Text, Convert.ToDouble(saffa_after_val.Text), radb_nkaba.Checked, rb_tsh.Checked, chk_auto.Checked, auto_total_chk.Checked, rb_mlahza.Checked, cbx_sharta.Checked, rb_sha.Checked)



                MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")

                'total_mkf()
                'total_mostakt()
                'total_sffy()
                'total_sffy_after_Entkal()





                ClearControls()

                'DataGridViewHeaderTxxt(dgv_Table_add_tfrgh)
                'Id_lbl.Text = Max_Table_mkf_add() + 1
                'id_and_user.Text = (Max_Table_mkf_add() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
                'no_kshfff = no_kshf_vale.Value
                'no_k = no_kshf_vale.Value

                'select_no_kash(no_kshfff)
                DataGridView2.DataSource = dt_select_by_name

                ClearControls()
                Label9.Text = DataGridView2.RowCount().ToString()
                BtnEdit.Enabled = False
                'close_text_box()
                '================================
                'BtnSave_Click(sender, e)
                'ايجاد السطر الحالى دات



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        format_datagridview()
    End Sub


    Private Sub mkf_2_lbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mkf_2_lbl.Click
        If mkf_2_lbl.Text = "مكافات اخرى" Then
            mkf_2_val.Visible = True
            mkf_2_lbl.Text = "مكافات اخري"
        Else
            mkf_2_val.Visible = False
            mkf_2_lbl.Text = "مكافات اخرى"

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'select__by_name(Name_Emp.Text)
        Try
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MessageBox.Show("يجب اختيار طريق البحث!")
            End If
            If RadioButton1.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " No_55=" & Txt_seach.Text & " "
            End If
            If RadioButton2.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " Name_Emp LIKE '%" & Txt_seach.Text & "%' "
            End If
            If RadioButton3.Checked = True Then
                Dim dv As DataView = dt_select_by_name.DefaultView
                dv.RowFilter = " id_no LIKE '%" & Txt_seach.Text & "%' "
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub Txt_seach_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_seach.TextChanged
        Try
            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
                MessageBox.Show("يجب اختيار طريق البحث!")
            End If
            If RadioButton1.Checked = True Then
                Dim dv As DataView = dt_Table_mkf_add.DefaultView
                dv.RowFilter = " No_55=" & Txt_seach.Text & " "
            End If
            If RadioButton2.Checked = True Then
                Dim dv As DataView = dt_Table_mkf_add.DefaultView
                dv.RowFilter = " Name_Emp LIKE '%" & Txt_seach.Text & "%' "
            End If
            If RadioButton3.Checked = True Then
                Dim dv As DataView = dt_Table_mkf_add.DefaultView
                dv.RowFilter = " id_no LIKE '%" & Txt_seach.Text & "%' "
            End If

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub radb_nkaba_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radb_nkaba.CheckedChanged
        If (radb_nkaba.Checked = True) Then


            Me.radb_nkaba.Text = "نقابى"
            Cmbx_nokapa.Text = "معلم"
            msg_lbl.Text = ""
            nkba_val.Value = Math.Round((Mkf_val.Value * 2) / 100, 1)
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

    Private Sub rad_b_no_nokapy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rad_b_no_nokapy.CheckedChanged
        If (rad_b_no_nokapy.Checked = True) Then


            Me.rad_b_no_nokapy.Text = "غير نقابى"
            Cmbx_nokapa.Text = "ادارى"
            msg_lbl.Text = ""
            nkba_val.Value = Math.Round((Mkf_val.Value * 2) / 100, 1)
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
        Form_add_mkf.ShowDialog()
    End Sub

    Private Sub mkf_2_val_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mkf_2_val.Leave
        textbox_to_deciemal(mkf_2_val)
    End Sub

    Private Sub mkf_2_val_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles mkf_2_val.KeyPress
        noused_char(e)
    End Sub

    Private Sub mkf_2_val_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mkf_2_val.MouseClick
        mkf_2_val.BackColor = Color.Gold
    End Sub

    Private Sub ComboBox_Salary_ass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox_Salary_ass.KeyDown
        If e.KeyCode = Keys.Down Then
            Dayes_vale.Focus()
            Dayes_vale.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            id_noo_combx.Focus()
            id_noo_combx.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Left Then
            Badl_safer_vale.Focus()
            Badl_safer_vale.BackColor = Color.Gold
        End If
    End Sub

    Private Sub ComboBox_Salary_ass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox_Salary_ass.KeyPress
        no_used_char2(e)
    End Sub

    Private Sub Dayes_vale_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dayes_vale.Validated
        If Dayes_vale.Value > 400 Then
            MessageBox.Show(" !  برجاء التاكد من عدد الايام ")
            Me.Dayes_vale.Text = "1"
            'Me.Dayes.Value = 1
            Me.Dayes_vale.Focus()
        End If
        If Dayes_vale.Value >= 200 Then
            'MessageBox.Show(" !........................................................................................  بـــرجــاء التاكــد مـــن عـــدد الايــام ")
            MessageBox.Show("!...................  بـــرجــاء التاكــد مـــن عـــدد الايــام ", "تنبيه", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
            msg_lbl.Text = "! يرجى التاكد من عدد الايام "
            'Me.Dayes.Focus()
        Else
            msg_lbl.Text = ""
        End If
    End Sub

    Private Sub Dayes_vale_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Dayes_vale.MouseClick
        Dayes_vale.BackColor = Color.Gold
    End Sub

    Private Sub Dayes_vale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dayes_vale.KeyDown
        If e.KeyCode = Keys.Down Then
            No_55_val.Focus()
            No_55_val.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            ComboBox_Salary_ass.Focus()
            ComboBox_Salary_ass.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Left Then
            Entklat_val.Focus()
            Entklat_val.BackColor = Color.Gold
        End If
    End Sub

    Private Sub No_55_val_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No_55_val.Validated
        ''select_no_55(No_55_val.Value)
        'If dt_select_no_55.Rows.Count > 0 Then

        'MessageBox.Show("رقم 55 ع ح مسجل من قبل  ...!")
        'ErrorProvider1.SetError(No_55_val, " مكرر تاكد من رقم 55  !...")
        'isvalaied = False
        'msg_lbl.Text += "  تاكد من رقم 55 مكرر  !..  ..؟"
        'No_55_val.Focus()

        'End If
    End Sub

    Private Sub No_55_val_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles No_55_val.MouseClick
        No_55_val.BackColor = Color.Gold
    End Sub

    Private Sub No_55_val_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles No_55_val.KeyDown
        If e.KeyCode = Keys.Down Then
            Badl_safer_vale.Focus()
            Badl_safer_vale.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            '    no_gp.Focus()
            Dayes_vale.Focus()
            Dayes_vale.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Left Then
            Mkf_val.Focus()
            Mkf_val.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Badl_saferlbl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badl_saferlbl.CheckedChanged
        If Badl_saferlbl.CheckState = CheckState.Checked Then
            Badl_safer_vale.Maximum = 3000
        Else
            Badl_safer_vale.Maximum = 401
        End If
    End Sub

    Private Sub Entklatlbl_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entklatlbl.CheckedChanged
        If Entklatlbl.CheckState = CheckState.Checked Then
            Entklat_val.Maximum = 3000
        Else
            Entklat_val.Maximum = 401
        End If
    End Sub

    Private Sub Badl_safer_vale_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badl_safer_vale.Validated
        If Badl_safer_vale.Value >= 401 Then
            MessageBox.Show(" !  برجاء التاكد من بدل السفر")
            'Badl_safer.Focus()

        End If
    End Sub

    Private Sub Badl_safer_vale_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Badl_safer_vale.MouseClick
        Badl_safer_vale.BackColor = Color.Gold
    End Sub

    Private Sub Badl_safer_vale_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Badl_safer_vale.KeyDown
        If e.KeyCode = Keys.Down Then
            Entklat_val.Focus()
            Entklat_val.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            No_55_val.Focus()
            No_55_val.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Right Then
            ComboBox_Salary_ass.Focus()
            ComboBox_Salary_ass.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Entklat_val_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entklat_val.Validated
        If Entklat_val.Value >= 401 Then
            MessageBox.Show(" !  برجاء التاكد من انتقالات ")
            'Entklat.Focus()

        End If
    End Sub

    Private Sub Entklat_val_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Entklat_val.MouseClick
        Entklat_val.BackColor = Color.Gold
    End Sub

    Private Sub Entklat_val_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Entklat_val.KeyDown
        If e.KeyCode = Keys.Down Then
            Mkf_val.Focus()
            Mkf_val.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Badl_safer_vale.Focus()
            Badl_safer_vale.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Right Then
            Dayes_vale.Focus()
            Dayes_vale.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Mkf_val_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mkf_val.MouseClick
        Mkf_val.BackColor = Color.Gold
    End Sub

    Private Sub Mkf_val_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mkf_val.KeyDown
        If e.KeyCode = Keys.Down Then
            Darabb_val.Focus()
            Darabb_val.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Entklat_val.Focus()
            Entklat_val.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Right Then
            No_55_val.Focus()
            No_55_val.BackColor = Color.Gold
        End If
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

    Private Sub auto_total_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles auto_total_chk.CheckedChanged
        If auto_total_chk.CheckState = CheckState.Checked Then
            btn_cal.Visible = False
            auto_total_chk.Text = "تجميع يدوى"
        Else
            btn_cal.Visible = True
            auto_total_chk.Text = "Auto_cal"
        End If
    End Sub

    Private Sub Name_emp_txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Name_emp_txt.KeyDown
        If chk_auto.CheckState = CheckState.Unchecked Then
            Try
                auto_Name_school(dt_auto_Name_school, Name_school_txt, Name_emp_txt.Text)
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
            Name_emp_txt.Focus()
            Name_emp_txt.BackColor = Color.Gold
        End If

    End Sub

    Private Sub id_noo_combx_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_noo_combx.Leave

        Try
            Dim id As String
            id = id_noo_combx.Text


            If chk_auto.CheckState = CheckState.Unchecked Then


                auto_name_emp(dt_auto_name_emp, id_noo_combx.Text)



                auto_Name_school(dt_auto_Name_school, Name_school_txt, Name_emp_txt.Text)
                auto_id_no(dt_auto_Name_school)
                auto_name_pay(dt_auto_Name_school)
                auto_alkta(dt_auto_Name_school)
                auto_no_emp(dt_auto_Name_school)
                auto_salary_ass(dt_auto_salary_ass, ComboBox_Salary_ass, id_noo_combx.Text)
                If id.Length = 14 Then
                Else
                    msg_lbl.Text += "  التاكد من الرقم القومى" + id.Length.ToString()
                    MessageBox.Show("  التاكد من الرقم القومى")
                    dt_auto_salary_ass.Clear()
                    Me.ComboBox_Salary_ass.Text = vbNullString
                End If
                'معرفة نقابى اوغير نقابى 
                auto_techer_or_no(dt_auto_techer_or_no, Cmbx_nokapa, ComboBox_work, id_noo_combx.Text)
                id_noo_combx.Text = id
            Else
                dt_auto_name_emp.Clear()
                dt_auto_name_emp.Clear()
                dt_auto_Name_school.Clear()
                dt_auto_salary_ass.Clear()
                id_noo_combx.Text = id
                If id.Length = 14 Then
                Else
                    msg_lbl.Text += "  التاكد من الرقم القومى" + id.Length.ToString()
                    MessageBox.Show("  التاكد من الرقم القومى")
                    dt_auto_salary_ass.Clear()
                    Me.ComboBox_Salary_ass.Text = vbNullString
                End If
            End If
        Catch

            'dt_auto_Name_school.Clear()

        End Try

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        stat_frm = "تعديل"
        search_emp_q.ShowDialog()
        search_emp_q.Name_emp_seach.Focus()
    End Sub




    Private Sub DataGridView2_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If (dt_Table_mkf_add.Rows.Count > 0) Then
            BtnDelete.Enabled = True
            open_text_box()
            'BtnNewAdd.Enabled = False
            'btn_save_sharta.Enabled = False
            Try


                'CheckBox1.Checked = True
                'CheckBox2.Checked = True
                'CheckBox3.Checked = True
                'CheckBox4.Checked = True
                BtnEdit.Enabled = True
                BtnDelete.Enabled = True
                With DataGridView2

                    id_and_user2.Text = .CurrentRow.Cells("id_and_user_tfg").Value.ToString()
                    Me.No_55_val.Text = .CurrentRow.Cells("No_55").Value
                    Me.no_kshf_vale.Text = .CurrentRow.Cells("no_kshf").Value.ToString()
                    Me.Name_emp_txt.Text = .CurrentRow.Cells("Name_Emp").Value.ToString()
                    Me.Name_school_txt.Text = .CurrentRow.Cells("Name_school").Value.ToString()
                    Me.ComboBox_Salary_ass.Text = .CurrentRow.Cells("Salary_ass").Value
                    Me.Dayes_vale.Text = .CurrentRow.Cells("Dayes").Value.ToString()
                    Me.Mkf_val.Text = .CurrentRow.Cells("Mkf").Value
                    Me.mkf_2_val.Text = .CurrentRow.Cells("mkf_2").Value

                    Me.Badl_safer_vale.Text = .CurrentRow.Cells("Badl_safer").Value
                    Me.Entklat_val.Text = .CurrentRow.Cells("Entklat").Value
                    Me.total_mkff.Text = .CurrentRow.Cells("total").Value
                    Me.Mashat_val.Text = .CurrentRow.Cells("Mashat").Value
                    Me.mash1_val.Text = .CurrentRow.Cells("Mashat8").Value
                    Me.Darabb_val.Text = .CurrentRow.Cells("Darabb").Value
                    Me.nkba_val.Text = .CurrentRow.Cells("nkaba").Value
                    Me.tamen_1_val.Text = .CurrentRow.Cells("Mhann").Value
                    Me.Mastshfa_vale.Text = .CurrentRow.Cells("Mastshfa").Value
                    Me.Damghh_val.Text = .CurrentRow.Cells("Damghh").Value
                    Me.Earaadta_val.Text = .CurrentRow.Cells("Earaadta").Value
                    Me.box_val.Text = .CurrentRow.Cells("box20").Value
                    Me.Mzay_t17.Text = .CurrentRow.Cells("Mzay_t_17_25").Value

                    Me.Total_Mostkta_val.Text = .CurrentRow.Cells("Total_Mostkta").Value
                    Me.Saffy_val.Text = .CurrentRow.Cells("Saffy").Value

                    Me.Id_Mkf_val.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                    'Me.date1.Value = .CurrentRow.Cells("date1").Value.ToString()
                    Me.id_noo_combx.Text = .CurrentRow.Cells("id_no").Value.ToString()
                    Me.cmbx_name_pay.Text = .CurrentRow.Cells("op_name_pay").Value.ToString()
                    Me.cmbx_alkta.Text = .CurrentRow.Cells("op_al_kta").Value.ToString()
                    Me.cmbx_no_emp.Text = .CurrentRow.Cells("op_no_emb").Value.ToString()
                    Me.saffa_after_val.Text = .CurrentRow.Cells("Saffy_after_antkal").Value
                    Me.radb_nkaba.Checked = .CurrentRow.Cells("nakab_yes_no").Value
                    Me.rb_tsh.Checked = .CurrentRow.Cells("chb_tsh_mlahza").Value
                    Me.chk_auto.Checked = .CurrentRow.Cells("Auto_emp").Value
                    Me.auto_total_chk.Checked = .CurrentRow.Cells("Auto_total").Value
                    Me.Id_lbl.Text = .CurrentRow.Cells("Id").Value.ToString()
                    Me.id_and_user.Text = .CurrentRow.Cells("id_user").Value.ToString()

                    No_55_val.Enabled = True
                    ComboBox_Salary_ass.Enabled = True
                    Dayes_vale.Enabled = True
                    Name_emp_txt.Enabled = True
                    Name_school_txt.Enabled = True
                    Mkf_val.Enabled = True
                    Badl_safer_vale.Enabled = True
                    Entklat_val.Enabled = True
                    Mashat_val.Enabled = True
                    Darabb_val.Enabled = True
                    tamen_1_val.Enabled = True
                    Mastshfa_vale.Enabled = True
                    Damghh_val.Enabled = True
                    Earaadta_val.Enabled = True
                    'BtnNewAdd.Enabled = False
                    Btn_new.Enabled = True
                End With
                '============================
                '======تحميل جدول المكافاة

                Dim Id_Mkff As Integer = 0

                Id_Mkff = DataGridView2.CurrentRow.Cells("Id_Mkf").Value

                Id_Mkff = Id_Mkff
                Id_Mkf_val.Text = Id_Mkff.ToString()
                select_id_mkf(Convert.ToInt32(Id_Mkff))
                DataGridView1.DataSource = dt_select_id_mkf
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()

                Item_Mkf_val.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'عرض العمود رقم 21
        'cel = 20
        Try
            If DataGridView2.Rows.Count > 0 And cel_r < 32 And cel_r > 0 Then

                DataGridView2.Rows(DataGridView2.RowCount - 2).Cells(cel_r).Selected = True


            End If


            cel_r += 5
            If cel_r > 32 Then
                cel_r = 1

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Txt_seach.Text = ""
            'Delete_mkf_tfrgh(dgv_Table_add_tfrgh)
            Delete_id_tfrgh(id_and_user2.Text)

            select__by_name(DataGridView2)
            format_datagridview()


            rad_b_no_nokapy.Checked = False
            radb_nkaba.Checked = False
            ClearControls()

            BtnDelete.Enabled = False
            Label9.Text = DataGridView2.RowCount().ToString()
            'close_text_box()
            '================================

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub


    Private Sub select_drab_Click(sender As Object, e As EventArgs) Handles select_drab.Click
        'select_drab_Form.ShowDialog()
    End Sub

    Private Sub saffa_after_val_TextChanged(sender As Object, e As EventArgs) Handles saffa_after_val.TextChanged
        textbox_to_deciemal(saffa_after_val)
    End Sub

    Private Sub Saffy_val_TextChanged(sender As Object, e As EventArgs) Handles Saffy_val.TextChanged
        textbox_to_deciemal(Saffy_val)
    End Sub

    Private Sub Total_Mostkta_val_TextChanged(sender As Object, e As EventArgs) Handles Total_Mostkta_val.TextChanged
        textbox_to_deciemal(Total_Mostkta_val)
    End Sub


    Private Sub Radio_b_work_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_b_work.CheckedChanged
        If (ComboBox_work.Text = "عامل خدمات" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة ثالث" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة خامس" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة رابع" Or ComboBox_work.Text = "خدمات معاونة.معاون خدمة سادس") Then
            Radio_b_work.Checked = True
            msg_lbl.Text = "عامل خدمات"
        Else

            Radio_b_work.Checked = False
            msg_lbl.Text = ""
        End If
    End Sub

    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click

    End Sub

    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        If (dt_Table_mkf_add.Rows.Count > 0) Then
            BtnDelete.Enabled = True
            open_text_box()
            'BtnNewAdd.Enabled = False
            'btn_save_sharta.Enabled = False
            Try


                'CheckBox1.Checked = True
                'CheckBox2.Checked = True
                'CheckBox3.Checked = True
                'CheckBox4.Checked = True
                BtnEdit.Enabled = True
                BtnDelete.Enabled = True
                With DataGridView2

                    id_and_user2.Text = .CurrentRow.Cells("id_and_user_tfg").Value.ToString()
                    Me.No_55_val.Text = .CurrentRow.Cells("No_55").Value
                    Me.no_kshf_vale.Text = .CurrentRow.Cells("no_kshf").Value.ToString()
                    Me.Name_emp_txt.Text = .CurrentRow.Cells("Name_Emp").Value.ToString()
                    Me.Name_school_txt.Text = .CurrentRow.Cells("Name_school").Value.ToString()
                    Me.ComboBox_Salary_ass.Text = .CurrentRow.Cells("Salary_ass").Value
                    Me.Dayes_vale.Text = .CurrentRow.Cells("Dayes").Value.ToString()
                    Me.Mkf_val.Text = .CurrentRow.Cells("Mkf").Value
                    Me.mkf_2_val.Text = .CurrentRow.Cells("mkf_2").Value

                    Me.Badl_safer_vale.Text = .CurrentRow.Cells("Badl_safer").Value
                    Me.Entklat_val.Text = .CurrentRow.Cells("Entklat").Value
                    Me.total_mkff.Text = .CurrentRow.Cells("total").Value
                    Me.Mashat_val.Text = .CurrentRow.Cells("Mashat").Value
                    Me.mash1_val.Text = .CurrentRow.Cells("Mashat8").Value
                    Me.Darabb_val.Text = .CurrentRow.Cells("Darabb").Value
                    Me.nkba_val.Text = .CurrentRow.Cells("nkaba").Value
                    Me.tamen_1_val.Text = .CurrentRow.Cells("Mhann").Value
                    Me.Mastshfa_vale.Text = .CurrentRow.Cells("Mastshfa").Value
                    Me.Damghh_val.Text = .CurrentRow.Cells("Damghh").Value
                    Me.Earaadta_val.Text = .CurrentRow.Cells("Earaadta").Value
                    Me.box_val.Text = .CurrentRow.Cells("box20").Value
                    Me.Mzay_t17.Text = .CurrentRow.Cells("Mzay_t_17_25").Value

                    Me.Total_Mostkta_val.Text = .CurrentRow.Cells("Total_Mostkta").Value
                    Me.Saffy_val.Text = .CurrentRow.Cells("Saffy").Value

                    Me.Id_Mkf_val.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                    'Me.date1.Value = .CurrentRow.Cells("date1").Value.ToString()
                    Me.id_noo_combx.Text = .CurrentRow.Cells("id_no").Value.ToString()
                    Me.cmbx_name_pay.Text = .CurrentRow.Cells("op_name_pay").Value.ToString()
                    Me.cmbx_alkta.Text = .CurrentRow.Cells("op_al_kta").Value.ToString()
                    Me.cmbx_no_emp.Text = .CurrentRow.Cells("op_no_emb").Value.ToString()
                    Me.saffa_after_val.Text = .CurrentRow.Cells("Saffy_after_antkal").Value
                    Me.radb_nkaba.Checked = .CurrentRow.Cells("nakab_yes_no").Value
                    Me.rb_tsh.Checked = .CurrentRow.Cells("chb_tsh_mlahza").Value
                    Me.chk_auto.Checked = .CurrentRow.Cells("Auto_emp").Value
                    Me.auto_total_chk.Checked = .CurrentRow.Cells("Auto_total").Value
                    Me.Id_lbl.Text = .CurrentRow.Cells("Id").Value.ToString()
                    Me.id_and_user.Text = .CurrentRow.Cells("id_user").Value.ToString()

                    No_55_val.Enabled = True
                    ComboBox_Salary_ass.Enabled = True
                    Dayes_vale.Enabled = True
                    Name_emp_txt.Enabled = True
                    Name_school_txt.Enabled = True
                    Mkf_val.Enabled = True
                    Badl_safer_vale.Enabled = True
                    Entklat_val.Enabled = True
                    Mashat_val.Enabled = True
                    Darabb_val.Enabled = True
                    tamen_1_val.Enabled = True
                    Mastshfa_vale.Enabled = True
                    Damghh_val.Enabled = True
                    Earaadta_val.Enabled = True
                    'BtnNewAdd.Enabled = False
                    Btn_new.Enabled = True
                End With
                '============================
                '======تحميل جدول المكافاة

                Dim Id_Mkff As Integer = 0

                Id_Mkff = DataGridView2.CurrentRow.Cells("Id_Mkf").Value

                Id_Mkff = Id_Mkff
                Id_Mkf_val.Text = Id_Mkff.ToString()
                select_id_mkf(Convert.ToInt32(Id_Mkff))
                DataGridView1.DataSource = dt_select_id_mkf
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()

                Item_Mkf_val.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class