Imports System.Data.OleDb

Public Class Form_edit_tfrgh
    Public no_k As Integer
    Public no_kshfff As Integer


    'الاستكمال التلقائى لاسم textbox====================================
    Public dt_auto_txt As New DataTable
    Public Sub auto_txt_name_emp()
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
        Name_Emp.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub

    'الاستكمال التلقائى ل textbox====================================
    Public dt_auto_txt_Name_school As New DataTable
    Public Sub auto_txt_Name_school()
        Dim da As New OleDbDataAdapter
        dt_auto_txt.Clear()
        da = New OleDbDataAdapter("select school from emp  ", con)
        da.Fill(dt_auto_txt)
        Dim data_souce As New AutoCompleteStringCollection

        For i As Integer = 0 To dt_auto_txt.Rows.Count - 1
            data_souce.Add(dt_auto_txt.Rows(i)("school")).ToString()

        Next
        id_no_combx.AutoCompleteCustomSource = data_souce
        id_no_combx.AutoCompleteSource = AutoCompleteSource.CustomSource
        id_no_combx.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub
    'الاستكمال التلقائى لمدرسه textbox====================================
    Public dt_auto_Name_school As New DataTable
    Public Sub auto_Name_school(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_Name_school.Clear()
        'Dim Cmd As New OleDbCommand
        'Cmd.Connection = con
        'Cmd.CommandType = CommandType.Text
        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_Emp.Text + "'", con)
        'da = New OleDbDataAdapter("select school from emp where name_emp=@name_emp ", con)
        'da.Fill(dt_auto_txt)
        'Dim data_souce As New AutoCompleteStringCollection
        da.Fill(dt_auto_Name_school)

        Name_school.DataSource = dt_auto_Name_school
        Name_school.DisplayMember = "school"
        'Name_school.DataBindings = ""

    End Sub

    'الاستكمال التلقائى لرقم القومى textbox====================================
    Public dt_auto_id_no As New DataTable
    Public Sub auto_id_no(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_id_no.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_Emp.Text + "'", con)

        da.Fill(dt_auto_id_no)

        id_no_combx.DataSource = dt_auto_id_no
        id_no_combx.DisplayMember = "id_no"

    End Sub
    'الاستكمال التلقائى نوع المدفوعه textbox====================================
    Public dt_auto_name_pay As New DataTable
    Public Sub auto_name_pay(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_name_pay.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_Emp.Text + "'", con)

        da.Fill(dt_auto_name_pay)

        cmbx_name_pay.DataSource = dt_auto_name_pay
        cmbx_name_pay.DisplayMember = "name_pay"

    End Sub

    'الاستكمال التلقائى  القطاع textbox====================================
    Public dt_auto_alkta As New DataTable
    Public Sub auto_alkta(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_alkta.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_Emp.Text + "'", con)

        da.Fill(dt_auto_alkta)

        cmbx_alkta.DataSource = dt_auto_alkta
        cmbx_alkta.DisplayMember = "al_kta"

    End Sub

    'الاستكمال التلقائى  رقم الموظف textbox====================================
    Public dt_auto_no_emp As New DataTable
    Public Sub auto_no_emp(ByVal dt As DataTable)
        Dim da As New OleDbDataAdapter
        dt_auto_no_emp.Clear()

        da = New OleDbDataAdapter("select * from emp where name_emp='" + Name_Emp.Text + "'", con)

        da.Fill(dt_auto_no_emp)

        cmbx_no_emp.DataSource = dt_auto_no_emp
        cmbx_no_emp.DisplayMember = "no_emb"

    End Sub

    Public Sub ClearControls()
        Me.Id.Text = vbNullString
        Me.No_55.Text = vbNullString

        Me.Name_Emp.Text = vbNullString
        Me.Name_school.Text = vbNullString
        'Me.Salary_ass.Text = vbNullString
        Me.Salary_ass.Value = 0
        Me.Dayes.Text = vbNullString
        Me.Mkf.Text = vbNullString
        Me.Badl_safer.Text = vbNullString
        Me.Entklat.Text = vbNullString
        Me.total.Text = vbNullString
        Me.Mashat.Text = vbNullString
        Me.Darabb.Text = vbNullString
        Me.Mhann.Text = vbNullString
        Me.Mastshfa.Text = vbNullString
        Me.Damghh.Text = vbNullString
        Me.Earaadta.Text = vbNullString
        Me.Total_Mostkta.Text = vbNullString
        Me.Saffy.Text = vbNullString
        'Me.Id_Mkf.Text = vbNullString
        Me.DateTimePicker1.Value = Today
        No_55.Enabled = True
        Salary_ass.Enabled = True
        Dayes.Enabled = True
        Name_Emp.Enabled = True
        Name_school.Enabled = True
        Mkf.Enabled = True
        Badl_safer.Enabled = True
        Entklat.Enabled = True
        Mashat.Enabled = True
        Darabb.Enabled = True
        Mhann.Enabled = True
        Mastshfa.Enabled = True
        Damghh.Enabled = True
        Earaadta.Enabled = True
    End Sub


    Public Sub DataGridViewHeaderText_no_kshf(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("No_55").HeaderText = "رقم 55ع.ح"
                .Columns("Salary_ass").HeaderText = "اساسى المرتب"
                .Columns("Dayes").HeaderText = "عدد الايام"
                .Columns("Mkf").HeaderText = "المكافاة"
                .Columns("Badl_safer").HeaderText = "بدل سفر"
                .Columns("Entklat").HeaderText = "انتقالات"
                .Columns("total").HeaderText = "الجمله"
                .Columns("Mashat").HeaderText = "معاشات"
                .Columns("Darabb").HeaderText = "ضرائب"
                .Columns("Mhann").HeaderText = "مهن"
                .Columns("Mastshfa").HeaderText = "مستشفى"
                .Columns("Damghh").HeaderText = "دمغه"
                .Columns("Earaadta").HeaderText = "ايرادات"
                .Columns("Total_Mostkta").HeaderText = "جملة المستقطع"
                .Columns("Saffy").HeaderText = "الصافى"
                .Columns("Name_school").HeaderText = "المدرسة"
                .Columns("Name_Emp").HeaderText = "اسم الموظف"
            End With
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try

            no_k = ListBox1.SelectedValue
            If no_k > 0 Then
                ClearControls()
                SelectAll_Table_mkf_no_kshf(no_k)
                dgv_Table_mkf_add.DataSource = dt_Table_mkf_no_kshff

                Dim Id_Mkff As Integer
                Id_Mkff = dgv_Table_mkf_add.CurrentRow.Cells("Id_Mkf").Value

                Id_Mkff = Id_Mkff
                Id_Mkf.Text = Id_Mkff.ToString()
                select_id_mkf(Convert.ToInt32(Id_Mkff))
                DataGridView1.DataSource = dt_select_id_mkf
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
            Else
                no_k = ListBox1.SelectedValue

            End If


        Catch
            Dim no_k As Integer = ListBox1.SelectedIndex
        End Try
    End Sub

    Private Sub Form_edit_tfrgh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        no_k = Max_no_kshf()


        SelectSome_Table_mkf_add_indirect(ListBox1)

        SelectAll_Table_mkf_no_kshf(no_k)
        dgv_Table_mkf_add.DataSource = dt_Table_mkf_no_kshff
        DataGridViewHeaderText_no_kshf(dgv_Table_mkf_add)
        ListBox1.SelectedValue = no_k
        auto_txt_name_emp()
        auto_txt_Name_school()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form_all_mkf.frm_stat = "edit"
        Form_all_mkf.MdiParent = Form1
        Form_all_mkf.Show()
    End Sub

    Private Sub dgv_Table_mkf_add_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Table_mkf_add.CellContentClick
        Try
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
            With dgv_Table_mkf_add
                Me.Idlbl.Text = .CurrentRow.Cells("Id").Value.ToString()
                Me.No_55.Value = .CurrentRow.Cells("No_55").Value
                Me.no_kshf.Text = .CurrentRow.Cells("no_kshf").Value.ToString()
                Me.Name_Emp.Text = .CurrentRow.Cells("Name_Emp").Value.ToString()
                Me.Name_school.Text = .CurrentRow.Cells("Name_school").Value.ToString()
                Me.Salary_ass.Value = .CurrentRow.Cells("Salary_ass").Value
                Me.Dayes.Value = .CurrentRow.Cells("Dayes").Value.ToString()
                Me.Mkf.Value = .CurrentRow.Cells("Mkf").Value
                Me.Badl_safer.Value = .CurrentRow.Cells("Badl_safer").Value
                Me.Entklat.Value = .CurrentRow.Cells("Entklat").Value
                Me.total.Value = .CurrentRow.Cells("total").Value
                Me.Mashat.Value = .CurrentRow.Cells("Mashat").Value
                Me.Darabb.Value = .CurrentRow.Cells("Darabb").Value
                Me.Mhann.Value = .CurrentRow.Cells("Mhann").Value
                Me.Mastshfa.Value = .CurrentRow.Cells("Mastshfa").Value
                Me.Damghh.Value = .CurrentRow.Cells("Damghh").Value
                Me.Earaadta.Value = .CurrentRow.Cells("Earaadta").Value
                Me.Total_Mostkta.Value = .CurrentRow.Cells("Total_Mostkta").Value
                Me.Saffy.Value = .CurrentRow.Cells("Saffy").Value
                Me.Id_Mkf.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                Me.DateTimePicker1.Value = .CurrentRow.Cells("date1").Value.ToString()

                No_55.Enabled = True
                Salary_ass.Enabled = True
                Dayes.Enabled = True
                Name_Emp.Enabled = True
                Name_school.Enabled = True
                Mkf.Enabled = True
                Badl_safer.Enabled = True
                Entklat.Enabled = True
                Mashat.Enabled = True
                Darabb.Enabled = True
                Mhann.Enabled = True
                Mastshfa.Enabled = True
                Damghh.Enabled = True
                Earaadta.Enabled = True

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub







    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_mkf_tfrgh(dgv_Table_mkf_add)
            'SelectSome_Table_mkf_add_indirect(ListBox1)


            SelectAll_Table_mkf_no_kshf(no_k)
            dgv_Table_mkf_add.DataSource = dt_Table_mkf_no_kshff
            DataGridViewHeaderText_no_kshf(dgv_Table_mkf_add)

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try

            no_k = NumericUpDown1.Value
            If no_k > 0 Then
                ClearControls()
                SelectAll_Table_mkf_no_kshf(no_k)
                dgv_Table_mkf_add.DataSource = dt_Table_mkf_no_kshff

                Dim Id_Mkff As Integer
                Id_Mkff = dgv_Table_mkf_add.CurrentRow.Cells("Id_Mkf").Value

                Id_Mkff = Id_Mkff
                Id_Mkf.Text = Id_Mkff.ToString()
                select_id_mkf(Convert.ToInt32(Id_Mkff))
                DataGridView1.DataSource = dt_select_id_mkf
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
            Else
                no_k = ListBox1.SelectedValue

            End If


        Catch
            Dim no_k As Integer = ListBox1.SelectedIndex
        End Try

    End Sub

    Private Sub dgv_Table_mkf_add_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv_Table_mkf_add.CellMouseClick
        Try
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
            With dgv_Table_mkf_add
                Me.Idlbl.Text = .CurrentRow.Cells("Id").Value.ToString()
                Me.No_55.Value = .CurrentRow.Cells("No_55").Value
                Me.no_kshf.Text = .CurrentRow.Cells("no_kshf").Value.ToString()
                Me.Name_Emp.Text = .CurrentRow.Cells("Name_Emp").Value.ToString()
                Me.Name_school.Text = .CurrentRow.Cells("Name_school").Value.ToString()
                Me.Salary_ass.Value = .CurrentRow.Cells("Salary_ass").Value
                Me.Dayes.Value = .CurrentRow.Cells("Dayes").Value.ToString()
                Me.Mkf.Value = .CurrentRow.Cells("Mkf").Value
                Me.Badl_safer.Value = .CurrentRow.Cells("Badl_safer").Value
                Me.Entklat.Value = .CurrentRow.Cells("Entklat").Value
                Me.total.Value = .CurrentRow.Cells("total").Value
                Me.Mashat.Value = .CurrentRow.Cells("Mashat").Value
                Me.Darabb.Value = .CurrentRow.Cells("Darabb").Value
                Me.Mhann.Value = .CurrentRow.Cells("Mhann").Value
                Me.Mastshfa.Value = .CurrentRow.Cells("Mastshfa").Value
                Me.Damghh.Value = .CurrentRow.Cells("Damghh").Value
                Me.Earaadta.Value = .CurrentRow.Cells("Earaadta").Value
                Me.Total_Mostkta.Value = .CurrentRow.Cells("Total_Mostkta").Value
                Me.Saffy.Value = .CurrentRow.Cells("Saffy").Value
                Me.Id_Mkf.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                Me.DateTimePicker1.Value = .CurrentRow.Cells("date1").Value.ToString()

                No_55.Enabled = True
                Salary_ass.Enabled = True
                Dayes.Enabled = True
                Name_Emp.Enabled = True
                Name_school.Enabled = True
                Mkf.Enabled = True
                Badl_safer.Enabled = True
                Entklat.Enabled = True
                Mashat.Enabled = True
                Darabb.Enabled = True
                Mhann.Enabled = True
                Mastshfa.Enabled = True
                Damghh.Enabled = True
                Earaadta.Enabled = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        total_mkf()
        total_sffy()

        Update_Table_mkf_add(Convert.ToInt32(Idlbl.Text), No_55.Value, no_kshf.Value, Name_Emp.Text, Name_school.Text, Salary_ass.Value, Dayes.Value, Mkf.Value, Badl_safer.Value, Entklat.Value, total.Value, Mashat.Value, Darabb.Value, Mhann.Value, Mastshfa.Value, Damghh.Value, Earaadta.Value, Total_Mostkta.Value, Saffy.Value, Convert.ToInt32(Id_Mkf.Text), DateTimePicker1.Value)
        Try

            no_k = ListBox1.SelectedValue
            If no_k > 0 Then
                ClearControls()
                SelectAll_Table_mkf_no_kshf(no_k)
                dgv_Table_mkf_add.DataSource = dt_Table_mkf_no_kshff

                Dim Id_Mkff As Integer
                Id_Mkff = dgv_Table_mkf_add.CurrentRow.Cells("Id_Mkf").Value

                Id_Mkff = Id_Mkff
                Id_Mkf.Text = Id_Mkff.ToString()
                select_id_mkf(Convert.ToInt32(Id_Mkff))
                DataGridView1.DataSource = dt_select_id_mkf
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
            Else
                no_k = ListBox1.SelectedValue

            End If


        Catch
            Dim no_k As Integer = ListBox1.SelectedIndex
        End Try

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub Mkf_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mkf.Leave
        total_mkf()
        total_sffy()
        Mkf.BackColor = Color.White
    End Sub
    Public Sub total_mkf()
        Dim tot_mkf As Double = 0
        tot_mkf = tot_mkf + Mkf.Value + Badl_safer.Value + Entklat.Value
        total.Value = tot_mkf
    End Sub
    Public Sub total_mostakt()
        Dim tot_mos As Double = 0
        tot_mos = tot_mos + Mashat.Value + Darabb.Value + Mhann.Value + Mastshfa.Value + Damghh.Value + Earaadta.Value
        Total_Mostkta.Value = tot_mos
    End Sub
    Public Sub total_sffy()
        Dim tota_sff As Double = 0
        tota_sff = total.Value - Total_Mostkta.Value
        Saffy.Value = tota_sff
    End Sub
    Private Sub Badl_safer_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Badl_safer.Leave
        total_mkf()
        total_sffy()
        Badl_safer.BackColor = Color.White
    End Sub

    Private Sub Entklat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Entklat.Leave
        total_mkf()
        total_sffy()
        Entklat.BackColor = Color.White
    End Sub

    Private Sub Mashat_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mashat.Leave
        total_mostakt()
        total_sffy()
        Mashat.BackColor = Color.White
    End Sub

    Private Sub Darabb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Darabb.Leave
        total_mostakt()
        total_sffy()
        Darabb.BackColor = Color.White
    End Sub

    Private Sub Mhann_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mhann.Leave
        total_mostakt()
        total_sffy()
        Mhann.BackColor = Color.White
    End Sub

    Private Sub Mastshfa_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mastshfa.Leave
        total_mostakt()
        total_sffy()
        Mastshfa.BackColor = Color.White
    End Sub

    Private Sub Damghh_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Damghh.Leave
        total_mostakt()
        total_sffy()
        Damghh.BackColor = Color.White
    End Sub

    Private Sub Earaadta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Earaadta.Leave
        total_mostakt()
        total_sffy()
        Earaadta.BackColor = Color.White
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.Click
        Try
            total_mkf()
            total_sffy()

            If Id_Mkf.Text = "" Then
                MessageBox.Show("يجب اختيار مكافاة")
            End If

            If dt_select_no_kash.Rows.Count > 18 Then
                MessageBox.Show("لا يمكن اضافة يجب انشاء كشف تفريغ جديد")
            Else
                Insert_Table_mkf_add(Convert.ToInt32(Idlbl.Text), Convert.ToInt32(No_55.Text), Convert.ToInt32(no_kshf.Text), Name_Emp.Text, Name_school.Text, Salary_ass.Value, Convert.ToInt32(Dayes.Text), Mkf.Value, Badl_safer.Value, Entklat.Value, total.Value, Mashat.Value, Darabb.Value, Mhann.Value, Mastshfa.Value, Damghh.Value, Earaadta.Value, Total_Mostkta.Value, Saffy.Value, Convert.ToInt32(Id_Mkf.Text), DateTimePicker1.Value)
                'SelectAll_Table_mkf_add(dgv_Table_mkf_add)
                DataGridViewHeaderTxxt(dgv_Table_mkf_add)
                Idlbl.Text = Max_Table_mkf_add() + 1

                no_kshfff = no_kshf.Value
                select_no_kash(no_kshfff)
                dgv_Table_mkf_add.DataSource = dt_select_no_kash
                ClearControls()
            End If



        Catch
            con.Close()
        End Try
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        BtnNewAdd.Enabled = True
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        ClearControls()
        Idlbl.Text = Max_Table_mkf_add() + 1
    End Sub

    Private Sub No_55_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles No_55.KeyDown
        If e.KeyCode = Keys.Down Then
            Salary_ass.Focus()
            Salary_ass.BackColor = Color.Gold
        End If

        'If e.KeyCode = Keys.Right Then
        '    no_gp.Focus()
        'End If
    End Sub

    Private Sub Salary_ass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Salary_ass.KeyDown
        If e.KeyCode = Keys.Down Then
            Dayes.Focus()
            Dayes.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            No_55.Focus()
        End If
        'If e.KeyCode = Keys.Right Then
        '    no_gp.Focus()
        'End If
    End Sub

    Private Sub Dayes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dayes.KeyDown
        If e.KeyCode = Keys.Down Then
            Mkf.Focus()
        End If

        If e.KeyCode = Keys.Up Then
            Salary_ass.Focus()
            Salary_ass.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Name_Emp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Name_Emp.KeyDown
        If e.KeyCode = Keys.Down Then
            Name_school.Focus()
            Name_school.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Entklat.Focus()
            Entklat.BackColor = Color.Gold
        End If
        Try
            auto_Name_school(dt_auto_Name_school)
            auto_id_no(dt_auto_Name_school)
            auto_name_pay(dt_auto_Name_school)
            auto_alkta(dt_auto_Name_school)
            auto_no_emp(dt_auto_Name_school)
        Catch
            dt_auto_Name_school.Clear()

        End Try
    End Sub

    Private Sub Name_school_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            Mashat.Focus()
            Mashat.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_Emp.Focus()
            Name_Emp.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Mkf_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mkf.KeyDown
        If e.KeyCode = Keys.Down Then
            Badl_safer.Focus()
            Badl_safer.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Dayes.Focus()
            Dayes.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Badl_safer_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Badl_safer.KeyDown
        If e.KeyCode = Keys.Down Then
            Entklat.Focus()
            Entklat.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Mkf.Focus()
            Mkf.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Entklat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Entklat.KeyDown
        If e.KeyCode = Keys.Down Then
            Name_Emp.Focus()
            Name_Emp.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Badl_safer.Focus()
            Badl_safer.BackColor = Color.Gold
        End If
    End Sub

    Private Sub total_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles total.KeyDown
        If e.KeyCode = Keys.Down Then
            Mashat.Focus()
            Mashat.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Entklat.Focus()
            Entklat.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Mashat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mashat.KeyDown
        If e.KeyCode = Keys.Down Then
            Darabb.Focus()
            Darabb.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Name_school.Focus()
            Name_school.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Darabb_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Darabb.KeyDown
        If e.KeyCode = Keys.Down Then
            Mhann.Focus()
            Mhann.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Mashat.Focus()
            Mashat.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Mhann_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mhann.KeyDown
        If e.KeyCode = Keys.Down Then
            Mastshfa.Focus()
            Mastshfa.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Darabb.Focus()
            Darabb.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Mastshfa_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mastshfa.KeyDown
        If e.KeyCode = Keys.Down Then
            Damghh.Focus()
            Damghh.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Mhann.Focus()
            Mhann.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Damghh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Damghh.KeyDown
        If e.KeyCode = Keys.Down Then
            Earaadta.Focus()
            Earaadta.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            Mastshfa.Focus()
            Mastshfa.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Earaadta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Earaadta.KeyDown
        If e.KeyCode = Keys.Down Then
            BtnNewAdd.Focus()
        End If

        If e.KeyCode = Keys.Up Then
            Damghh.Focus()
            Damghh.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Salary_ass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salary_ass.Leave
        Salary_ass.BackColor = Color.White
    End Sub

    Private Sub Dayes_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dayes.Leave
        Dayes.BackColor = Color.White
    End Sub

    Private Sub Form_edit_tfrgh_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
       
    End Sub

    Private Sub Form_edit_tfrgh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
      

    End Sub

    Private Sub total_DragLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles total.DragLeave

    End Sub

    Private Sub Name_Emp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_Emp.Leave
        Name_Emp.BackColor = Color.White
    End Sub

    Private Sub Name_school_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Name_school.BackColor = Color.White
    End Sub
    Private Sub No_55_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles No_55.MouseClick
        No_55.BackColor = Color.Gold
    End Sub

    Private Sub Salary_ass_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Salary_ass.MouseClick
        Salary_ass.BackColor = Color.Gold
    End Sub

    Private Sub Dayes_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Dayes.MouseClick
        Dayes.BackColor = Color.Gold
    End Sub

    Private Sub Name_Emp_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Name_Emp.MouseClick
        Name_Emp.BackColor = Color.Gold
    End Sub


    Private Sub Name_school_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Name_school.BackColor = Color.Gold
    End Sub

    Private Sub Mkf_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mkf.MouseClick
        Mkf.BackColor = Color.Gold
    End Sub

    Private Sub Badl_safer_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Badl_safer.MouseClick
        Badl_safer.BackColor = Color.Gold
    End Sub

    Private Sub Entklat_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Entklat.MouseClick
        Entklat.BackColor = Color.Gold
    End Sub

    Private Sub total_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles total.MouseClick
        total.BackColor = Color.Gold
    End Sub

    Private Sub Mashat_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mashat.MouseClick
        Mashat.BackColor = Color.Gold
    End Sub

    Private Sub Darabb_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Darabb.MouseClick
        Darabb.BackColor = Color.Gold
    End Sub

    Private Sub Mhann_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mhann.MouseClick
        Mhann.BackColor = Color.Gold
    End Sub

    Private Sub Mastshfa_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Mastshfa.MouseClick
        Mastshfa.BackColor = Color.Gold
    End Sub

    Private Sub Damghh_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Damghh.MouseClick
        Damghh.BackColor = Color.Gold
    End Sub

    Private Sub Earaadta_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Earaadta.MouseClick
        Earaadta.BackColor = Color.Gold
    End Sub

    Private Sub No_55_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles No_55.Leave
        No_55.BackColor = Color.White
    End Sub

    Private Sub dgv_Table_mkf_add_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Table_mkf_add.CellEndEdit
        total_mkf()
        total_sffy()

        updat_tfrgh_datagrid()
        Try

            no_k = ListBox1.SelectedValue
            If no_k > 0 Then
                'ClearControls()
                'SelectAll_Table_mkf_no_kshf(no_k)
                'dgv_Table_mkf_add.DataSource = dt_Table_mkf_no_kshff

                Dim Id_Mkff As Integer
                Id_Mkff = dgv_Table_mkf_add.CurrentRow.Cells("Id_Mkf").Value


                Id_Mkf.Text = Id_Mkff.ToString()
                'select_id_mkf(Convert.ToInt32(Id_Mkff))
                'DataGridView1.DataSource = dt_select_id_mkf
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
                Update_Table_mkf_add(Convert.ToInt32(Idlbl.Text), No_55.Value, no_kshf.Value, Name_Emp.Text, Name_school.Text, Salary_ass.Value, Dayes.Value, Mkf.Value, Badl_safer.Value, Entklat.Value, total.Value, Mashat.Value, Darabb.Value, Mhann.Value, Mastshfa.Value, Damghh.Value, Earaadta.Value, Total_Mostkta.Value, Saffy.Value, Convert.ToInt32(Id_Mkf.Text), DateTimePicker1.Value)
            Else
                no_k = ListBox1.SelectedValue

            End If


        Catch
            Dim no_k As Integer = ListBox1.SelectedIndex
        End Try
    End Sub

    Public Sub updat_tfrgh_datagrid()
        Try
            With dgv_Table_mkf_add
                Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
                Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
                Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
                term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()

                Me.Id.Text = .CurrentRow.Cells("id").Value.ToString()
                Me.DateTimePicker1.Value = .CurrentRow.Cells("date1").Value.ToString()
                Me.No_55.Text = .CurrentRow.Cells("No_55").Value.ToString()
                Me.Salary_ass.Text = .CurrentRow.Cells("Salary_ass").Value.ToString()
                Me.Dayes.Text = .CurrentRow.Cells("Dayes").Value.ToString()
                Me.Name_Emp.Text = .CurrentRow.Cells("Name_Emp").Value.ToString()
                Me.Name_school.Text = .CurrentRow.Cells("Name_school").Value.ToString()
                Me.Mkf.Text = .CurrentRow.Cells("Mkf").Value.ToString()
                Me.Badl_safer.Text = .CurrentRow.Cells("Badl_safer").Value.ToString()
                Me.Entklat.Text = .CurrentRow.Cells("Entklat").Value.ToString()
                Me.Mashat.Text = .CurrentRow.Cells("Mashat").Value.ToString()
                Me.Darabb.Text = .CurrentRow.Cells("Darabb").Value.ToString()
                Me.Mhann.Text = .CurrentRow.Cells("Mhann").Value.ToString()
                Me.Mastshfa.Text = .CurrentRow.Cells("Mastshfa").Value.ToString()
                Me.Damghh.Text = .CurrentRow.Cells("Damghh").Value.ToString()
                Me.Earaadta.Text = .CurrentRow.Cells("Earaadta").Value.ToString()





            End With
            BtnDelete.Enabled = True


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnNewAdd.Enabled = False
        BtnEdit.Enabled = True
    End Sub

    Private Sub dgv_Table_mkf_add_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_Table_mkf_add.MouseClick
        Dim Id_Mkff As Integer
        Id_Mkff = dgv_Table_mkf_add.CurrentRow.Cells("Id_Mkf").Value


        Id_Mkf.Text = Id_Mkff.ToString()
        select_id_mkf(Convert.ToInt32(Id_Mkff))
        'DataGridView1.DataSource = dt_select_id_mkf
        Name_Mkf.Text = DataGridView1.CurrentRow.Cells("Name_Mkf").Value.ToString()
        Item_Mkf.Text = DataGridView1.CurrentRow.Cells("Item_Mkf").Value.ToString()
        Years.Text = DataGridView1.CurrentRow.Cells("Years").Value.ToString()
        term.Text = DataGridView1.CurrentRow.Cells("term").Value.ToString()
    End Sub
End Class