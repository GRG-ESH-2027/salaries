Imports System.Data.OleDb


Module Module_add_tfrghh
    'الاستكمال التلقائى لمدرسه textbox====================================
    Public dt_auto_Name_school As New DataTable
    Public Sub auto_Name_school(ByVal dt As DataTable, ByVal combox As ComboBox, ByVal name_emp As String)
        Try


            Dim da As New OleDbDataAdapter
            dt_auto_Name_school.Clear()
            'Dim Cmd As New OleDbCommand
            'Cmd.Connection = con
            'Cmd.CommandType = CommandType.Text
            'dv.RowFilter = " descr LIKE '%" & TextBox1.Text & "%' "

            'da = New OleDbDataAdapter("select * from emp where name_emp LIKE  '%" & Name_Emp.Text & "%'", con)

            da = New OleDbDataAdapter("select * from emp where name_emp LIKE  '%" & name_emp & "%'", con)
            da.Fill(dt_auto_Name_school)

            combox.DataSource = dt_auto_Name_school
            combox.DisplayMember = "school"

            'Name_school.DataSource = dt_auto_Name_school
            'Name_school.DisplayMember = "school"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    '============================
    'اسماءعمود فى دات
    Public Sub DataGridViewHeaderText_salary_ass(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("id_no").HeaderText = "رقم القومى"
                .Columns("name_emp").HeaderText = "اسم الموظف"
                .Columns("salary_old").HeaderText = "اساسى القديم"
                .Columns("salary_new").HeaderText = "اساسى الجديد"
                .Columns("salary_safy").HeaderText = "صافى المرتب"
                .Columns("school").DefaultCellStyle.BackColor = Color.Yellow

                .Columns("school").HeaderText = "المدرسة"
              
            End With
        End If
    End Sub
    '    =================================
    '===============================================================

    '=======================================================
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
    '==========================================================

    '===========================================
    'الاستكمال التلقائى للنقابى او غير نقابى textbox====================================
    Public dt_auto_techer_or_no As New DataTable

    Public Sub auto_techer_or_no(ByVal dt As DataTable, ByVal combox As ComboBox, ByVal combox_2 As ComboBox, ByVal id_no As String)
        dt_auto_techer_or_no.Clear()

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim cmd As New OleDbCommand("SELECT * FROM Emp_inf WHERE id_no = ?", con)
            cmd.Parameters.AddWithValue("?", id_no)

            Dim da As New OleDbDataAdapter(cmd)
            da.Fill(dt_auto_techer_or_no)

            If dt_auto_techer_or_no.Rows.Count > 0 Then
                combox.DataSource = dt_auto_techer_or_no
                combox.DisplayMember = "techer_or_no"

                combox_2.DataSource = dt_auto_techer_or_no
                combox_2.DisplayMember = "work_ass"
            Else
                'MsgBox("لا توجد بيانات لهذا الرقم.", MsgBoxStyle.Information, "تنبيه")
            End If

        Catch ex As Exception
            MsgBox("حدث خطأ أثناء جلب البيانات:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "خطأ")
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    '===============================================================
    Public Sub Insert_salary_ass(ByVal id_no As String, ByVal salary_old As Double, ByVal salary_new As Double, ByVal salary_safy As Double, ByVal Drab As Double)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into salary_ass ( id_no,salary_old,salary_new,salary_safy,Drab)values(@id_no,@salary_old,@salary_new,@salary_safy,@Drab)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            .Parameters.AddWithValue("@salary_old", OleDbType.Double).Value = salary_old
            .Parameters.AddWithValue("@salary_new", OleDbType.Double).Value = salary_new
            .Parameters.AddWithValue("@salary_safy", OleDbType.Double).Value = salary_safy
            .Parameters.AddWithValue("@Drab", OleDbType.Double).Value = Drab

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        'MsgBox("تم إضافة مرتب اساسى بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    '=================================================
    Public Sub Insert_emp_inf(ByVal id_no As String, ByVal techer_or_no As String, ByVal work_ass As String)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Emp_inf ( id_no,techer_or_no,work_ass)values(@id_no,@techer_or_no,@work_ass)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            .Parameters.AddWithValue("@techer_or_no", OleDbType.VarChar).Value = techer_or_no
            .Parameters.AddWithValue("@work_ass", OleDbType.VarChar).Value = work_ass
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم إضافة وظيفه بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    '========================================================
    Public Sub Update_emp_inf(ByVal original_id As String, ByVal new_id As String, ByVal techer_or_no As String, ByVal work_ass As String)
        Dim Cmd As New OleDbCommand

        Try
            With Cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = "UPDATE Emp_inf SET id_no = @new_id, techer_or_no = @techer_or_no, work_ass = @work_ass WHERE id_no = @original_id"
                .Parameters.Clear()
                .Parameters.AddWithValue("@new_id", new_id)
                .Parameters.AddWithValue("@techer_or_no", techer_or_no)
                .Parameters.AddWithValue("@work_ass", work_ass)
                .Parameters.AddWithValue("@original_id", original_id)
            End With

            If con.State = ConnectionState.Open Then con.Close()
            con.Open()
            Dim rowsAffected As Integer = Cmd.ExecuteNonQuery()
            con.Close()

            If rowsAffected > 0 Then
                MsgBox("تم تعديل البيانات بنجاح", MsgBoxStyle.Information, "تعديل")
            Else
                MsgBox("لم يتم العثور على السجل المطلوب تعديله", MsgBoxStyle.Exclamation, "تنبيه")
            End If

        Catch ex As Exception
            MsgBox("حدث خطأ أثناء تعديل البيانات:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "خطأ")

        Finally
            If con.State = ConnectionState.Open Then con.Close()
            Cmd = Nothing
        End Try
    End Sub

    '======================================================

    Public Sub Update_salary_ass(ByVal id_no As String, ByVal salary_old As Double, ByVal salary_new As Double, ByVal salary_safy As Double, ByVal date1 As DateTime, ByVal Drab As Double)
        Try


            Dim Cmd As New OleDbCommand
            With Cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = "Update salary_ass Set id_no = @id_no,salary_old = @salary_old,salary_new = @salary_new,salary_safy = @salary_safy ,date1 = @date1,Drab=@Drab  Where id_no = @id_no "
                .Parameters.Clear()
                .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
                .Parameters.AddWithValue("@salary_old", OleDbType.Double).Value = salary_old
                .Parameters.AddWithValue("@salary_new", OleDbType.Double).Value = salary_new
                .Parameters.AddWithValue("@salary_safy", OleDbType.Double).Value = salary_safy
                .Parameters.AddWithValue("@date1", OleDbType.Date).Value = date1
                .Parameters.AddWithValue("@Drab", OleDbType.Double).Value = Drab

            End With
            If con.State = 1 Then con.Close()
            con.Open()
            Cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
    '=============================================================================
    Public Sub Update_Drab_all(ByVal id_no As String, ByVal Drab As Double)
        Try


            Dim Cmd As New OleDbCommand
            With Cmd
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = "Update Table_mkf_add Set id_no = @id_no,Darabb=@Darabb  Where id_no = @id_no "
                .Parameters.Clear()
                .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
                .Parameters.AddWithValue("@Darabb", OleDbType.Double).Value = Drab

            End With
            If con.State = 1 Then con.Close()
            con.Open()
            Cmd.ExecuteNonQuery()
            con.Close()
            'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            con.Close()
        End Try
    End Sub
    '==============================================================================
    Public Sub Update_salary_ass_old(ByVal id_no As String, ByVal salary_old As Double, ByVal date1 As DateTime)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update salary_ass Set id_no = @id_no,salary_old = @salary_old,date1=@date1 Where id_no = @id_no"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            .Parameters.AddWithValue("@salary_old", OleDbType.Double).Value = salary_old
            .Parameters.AddWithValue("@date1", OleDbType.DBDate).Value = date1


        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub

    '==========================================================
    Public Sub SelectAll_Table_no_kshf(ByVal no_kshf As Integer)
        dt_Table_mkf_no_kshff.Clear()
        Dim Cmd As New OleDbCommand("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Mzay_t_17_25,Total_Mostkta,Name_school,Name_Emp,Saffy,Entklat,Badl_safer,Id_Mkf,Id,no_kshf,date1,id_no,op_name_pay,op_al_kta,op_no_emb,Saffy_after_antkal,nakab_yes_no,chb_tsh_mlahza,Auto_emp,Auto_total,id_and_user_tfg,chb_mlahza,chb_ٍsharta,chb_zar_shee from Table_mkf_add where no_kshf = @no_kshf", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf
            dt_Table_mkf_no_kshff.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub


    Public dt_Table_mkf_add As New DataTable
    Public Sub SelectAll_Table_mkf_add(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_Table_mkf_add.Clear()
        da = New OleDbDataAdapter("select * from Table_mkf_add", con)
        da.Fill(dt_Table_mkf_add)
        dgv.DataSource = dt_Table_mkf_add
    End Sub
    'Public Sub DataGridViewHeaderTxxt(ByVal DGV As DataGridView)
    '    If DGV.RowCount > 0 Then
    '        With DGV
    '            .Columns("Id").HeaderText = "Id"
    '            .Columns("No_55").HeaderText = "55 ع . ح"
    '            .Columns("no_kshf").HeaderText = "رقم الكشف"
    '            .Columns("Name_Emp").HeaderText = "الاسم"
    '            .Columns("Name_school").HeaderText = "المدرسة"
    '            .Columns("Salary_ass").HeaderText = "المرتب الاساسى"
    '            .Columns("Dayes").HeaderText = "عدد الايام"
    '            .Columns("Mkf").HeaderText = "المكافاة"
    '            .Columns("Badl_safer").HeaderText = "بدل سفر"
    '            .Columns("Entklat").HeaderText = "انتقالات"
    '            .Columns("total").HeaderText = "جملة"
    '            .Columns("Mashat").HeaderText = "معاشات"
    '            .Columns("Mashat8").HeaderText = "مهن 2%"
    '            .Columns("Darabb").HeaderText = "ضرائب"
    '            .Columns("nkaba").HeaderText = "معاشات 1%"
    '            .Columns("Mhann").HeaderText = "م 1% "

    '            .Columns("Mastshfa").HeaderText = "مستشفى"
    '            .Columns("Damghh").HeaderText = "دمغه"
    '            .Columns("Earaadta").HeaderText = "ايرادات"
    '            .Columns("box20").HeaderText = "صندوق %20"
    '            .Columns("Total_Mostkta").HeaderText = "جملة المستقطع"
    '            .Columns("Saffy").HeaderText = "الصافى"
    '            .Columns("Id_Mkf").HeaderText = "Id_Mkf"
    '            .Columns("date1").HeaderText = "التاريخ"
    '            .Columns("id_no").HeaderText = "رقم القومى"
    ''.Columns("name_pay").Visible = False
    ''.Columns("al_kta").Visible = False
    ''.Columns("no_emb").Visible = False
    '            .Columns("nakab_yes_no").Visible = False
    '            .Columns("No_55").DefaultCellStyle.BackColor = Color.Yellow
    '            .Columns("Total_Mostkta").DefaultCellStyle.BackColor = Color.Yellow

    '        End With
    '    End If
    'End Sub
    Public Sub Insert_Table_mkf_add(ByVal Id As Integer, ByVal id_and_user_tfg As String, ByVal No_55 As Integer,
                                    ByVal no_kshf As Integer, ByVal Name_Emp As String,
                                    ByVal Name_school As String, ByVal Salary_ass As Double,
                                    ByVal Dayes As Integer, ByVal Mkf As Double, ByVal Mkf_2 As Double,
                                    ByVal Badl_safer As Double, ByVal Entklat As Double,
                                    ByVal total As Double, ByVal Mashat As Double,
                                    ByVal Mashat8 As Double, ByVal Darabb As Double,
                                    ByVal nkaba As Double, ByVal Mhann As Double,
                                    ByVal Mastshfa As Double, ByVal Damghh As Double,
                                    ByVal Earaadta As Double, ByVal box20 As Double, ByVal Mzay_t_17_25 As Double,
                                    ByVal Total_Mostkta As Double, ByVal Saffy As Double,
                                    ByVal Id_Mkf As Integer, ByVal date1 As DateTime,
                                    ByVal id_no As String, ByVal name_pay As String,
                                    ByVal al_kta As String, ByVal no_emb As String, ByVal Saffy_after_antkal As Double, ByVal nakab_yes_no As Boolean, ByVal chb_tsh_mlahza As Boolean, ByVal id_user As Integer, ByVal Auto_emp As Boolean, ByVal Auto_total As Boolean, ByVal chb_mlahza As Boolean, ByVal chb_ٍsharta As Boolean, ByVal chb_zar_shee As Boolean)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Table_mkf_add (Id,id_and_user_tfg,No_55,no_kshf,Name_Emp,Name_school,Salary_ass,Dayes,Mkf,Mkf_2,Badl_safer,Entklat,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Mzay_t_17_25,Total_Mostkta,Saffy,Id_Mkf,date1,id_no,op_name_pay,op_al_kta,op_no_emb,Saffy_after_antkal,nakab_yes_no,chb_tsh_mlahza,id_user,Auto_emp,Auto_total,chb_mlahza,chb_ٍsharta,chb_zar_shee)values(@Id,@id_and_user_tfg,@No_55,@no_kshf,@Name_Emp,@Name_school,@Salary_ass,@Dayes,@Mkf,@Mkf_2,@Badl_safer,@Entklat,@total,@Mashat,@Mashat8,@Darabb,@nkaba,@Mhann,@Mastshfa,@Damghh,@Earaadta,@box20,@Mzay_t_17_25,@Total_Mostkta,@Saffy,@Id_Mkf,@date1,@id_no,@op_name_pay,@op_al_kta,@op_no_emb,@Saffy_after_antkal,@nakab_yes_no,@chb_tsh_mlahza,@id_user,@Auto_emp,@Auto_total,@chb_mlahza,@chb_ٍsharta,@chb_zar_shee)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Id", OleDbType.Integer).Value = Id
            .Parameters.AddWithValue("@id_and_user_tfg", OleDbType.VarChar).Value = id_and_user_tfg
            .Parameters.AddWithValue("@No_55", OleDbType.Integer).Value = No_55
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf
            .Parameters.AddWithValue("@Name_Emp", OleDbType.VarChar).Value = Name_Emp
            .Parameters.AddWithValue("@Name_school", OleDbType.VarChar).Value = Name_school
            .Parameters.AddWithValue("@Salary_ass", OleDbType.Double).Value = Salary_ass
            .Parameters.AddWithValue("@Dayes", OleDbType.Integer).Value = Dayes
            .Parameters.AddWithValue("@Mkf", OleDbType.Double).Value = Mkf
            .Parameters.AddWithValue("@Mkf_2", OleDbType.Double).Value = Mkf_2

            .Parameters.AddWithValue("@Badl_safer", OleDbType.Double).Value = Badl_safer
            .Parameters.AddWithValue("@Entklat", OleDbType.Double).Value = Entklat
            .Parameters.AddWithValue("@total", OleDbType.Double).Value = total
            .Parameters.AddWithValue("@Mashat", OleDbType.Double).Value = Mashat
            .Parameters.AddWithValue("@Mashat8", OleDbType.Double).Value = Mashat8
            .Parameters.AddWithValue("@Darabb", OleDbType.Double).Value = Darabb
            .Parameters.AddWithValue("@nkaba", OleDbType.Double).Value = nkaba
            .Parameters.AddWithValue("@Mhann", OleDbType.Double).Value = Mhann
            .Parameters.AddWithValue("@Mastshfa", OleDbType.Double).Value = Mastshfa
            .Parameters.AddWithValue("@Damghh", OleDbType.Double).Value = Damghh
            .Parameters.AddWithValue("@Earaadta", OleDbType.Double).Value = Earaadta
            .Parameters.AddWithValue("@box20", OleDbType.Double).Value = box20
            .Parameters.AddWithValue("@Mzay_t_17_25", OleDbType.Double).Value = Mzay_t_17_25
            .Parameters.AddWithValue("@Total_Mostkta", OleDbType.Double).Value = Total_Mostkta
            .Parameters.AddWithValue("@Saffy", OleDbType.Double).Value = Saffy
            .Parameters.AddWithValue("@Id_Mkf", OleDbType.Integer).Value = Id_Mkf
            .Parameters.AddWithValue("@date1", OleDbType.Date).Value = date1

            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            .Parameters.AddWithValue("@op_name_pay", OleDbType.VarChar).Value = name_pay
            .Parameters.AddWithValue("@op_al_kta", OleDbType.VarChar).Value = al_kta
            .Parameters.AddWithValue("@op_no_emb", OleDbType.VarChar).Value = no_emb
            .Parameters.AddWithValue("@Saffy_after_antkal", OleDbType.Double).Value = Saffy_after_antkal
            .Parameters.AddWithValue("@nakab_yes_no", OleDbType.Boolean).Value = nakab_yes_no
            .Parameters.AddWithValue("@chb_tsh_mlahza", OleDbType.Boolean).Value = chb_tsh_mlahza
            .Parameters.AddWithValue("@id_user", OleDbType.Integer).Value = id_user
            .Parameters.AddWithValue("@Auto_emp", OleDbType.Boolean).Value = Auto_emp
            .Parameters.AddWithValue("@Auto_total", OleDbType.Boolean).Value = Auto_total
            .Parameters.AddWithValue("@chb_mlahza", OleDbType.Boolean).Value = chb_mlahza
            .Parameters.AddWithValue("@chb_ٍsharta", OleDbType.Boolean).Value = chb_ٍsharta
            .Parameters.AddWithValue("@chb_zar_shee", OleDbType.Boolean).Value = chb_zar_shee

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '==================================================
    Public Sub Insert_Table_mkf_add_speed_shorta(ByVal id_and_user_tfg As String, ByVal No_55 As Integer,
                                ByVal no_kshf As Integer, ByVal Name_Emp As String,
                                 ByVal Salary_ass As Double,
                                ByVal Dayes As Integer, ByVal Mkf As Double, ByVal total As Double, ByVal Darabb As Double, ByVal Damghh As Double, ByVal box20 As Double,
                                ByVal Total_Mostkta As Double, ByVal Saffy As Double, ByVal Saffy_after_antkal As Double,
                                ByVal Id_Mkf As Integer,
                                ByVal id_no As String,
                              ByVal id_user As Integer, ByVal id As Integer, ByVal Name_school As String)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Table_mkf_add (id_and_user_tfg,No_55,no_kshf,Name_Emp,Salary_ass,Dayes,Mkf,total,Darabb,Damghh,box20,Total_Mostkta,Saffy,Saffy_after_antkal,Id_Mkf,id_no,id_user,id,Name_school)values(@id_and_user_tfg,@No_55,@no_kshf,@Name_Emp,@Salary_ass,@Dayes,@Mkf,@total,@Darabb,@Damghh,@box20,@Total_Mostkta,@Saffy,@Saffy_after_antkal,@Id_Mkf,@id_no,@id_user,@id,@Name_school)"
            .Parameters.Clear()

            .Parameters.AddWithValue("@id_and_user_tfg", OleDbType.VarChar).Value = id_and_user_tfg
            .Parameters.AddWithValue("@No_55", OleDbType.Integer).Value = No_55
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf
            .Parameters.AddWithValue("@Name_Emp", OleDbType.VarChar).Value = Name_Emp

            .Parameters.AddWithValue("@Salary_ass", OleDbType.Double).Value = Salary_ass
            .Parameters.AddWithValue("@Dayes", OleDbType.Integer).Value = Dayes
            .Parameters.AddWithValue("@Mkf", OleDbType.Double).Value = Mkf

            .Parameters.AddWithValue("@total", OleDbType.Double).Value = total

            .Parameters.AddWithValue("@Darabb", OleDbType.Double).Value = Darabb

            .Parameters.AddWithValue("@Damghh", OleDbType.Double).Value = Damghh

            .Parameters.AddWithValue("@box20", OleDbType.Double).Value = box20
            .Parameters.AddWithValue("@Total_Mostkta", OleDbType.Double).Value = Total_Mostkta
            .Parameters.AddWithValue("@Saffy", OleDbType.Double).Value = Saffy
            .Parameters.AddWithValue("@Saffy_after_antkal", OleDbType.Double).Value = Saffy_after_antkal
            .Parameters.AddWithValue("@Id_Mkf", OleDbType.Integer).Value = Id_Mkf


            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no


            .Parameters.AddWithValue("@id_user", OleDbType.Integer).Value = id_user
            .Parameters.AddWithValue("@id", OleDbType.Integer).Value = id
            .Parameters.AddWithValue("@Name_school", OleDbType.VarChar).Value = Name_school

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub


    '==============
    'update
    Public Sub Update_TMzay(ByVal Mzay_t_17_25 As Double)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update Table_mkf_add Set Mzay_t_17_25=@Mzay_t_17_25"
            .Parameters.Clear()
      
            .Parameters.AddWithValue("@Mzay_t_17_25", OleDbType.Double).Value = Mzay_t_17_25



        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub


    '=========================================================
    'update
    Public Sub Update_Table_mkf_add(ByVal Id As Integer, ByVal id_and_user_tfg As String, ByVal No_55 As Integer, ByVal no_kshf As Integer, ByVal Name_Emp As String, ByVal Name_school As String, ByVal Salary_ass As Double, ByVal Dayes As Integer, ByVal Mkf As Double, ByVal Mkf_2 As Double, ByVal Badl_safer As Double, ByVal Entklat As Double, ByVal total As Double, ByVal Mashat As Double, ByVal Mashat8 As Double, ByVal Darabb As Double, ByVal nkaba As Double, ByVal Mhann As Double, ByVal Mastshfa As Double, ByVal Damghh As Double, ByVal Earaadta As Double, ByVal box20 As Double, ByVal Mzay_t_17_25 As Double, ByVal Total_Mostkta As Double, ByVal Saffy As Double, ByVal Id_Mkf As Integer, ByVal date1 As Date, ByVal id_no As String, ByVal op_name_pay As String, ByVal op_al_kta As String, ByVal op_no_emb As String, ByVal Saffy_after_antkal As Double, ByVal nakab_yes_no As Boolean, ByVal chb_tsh_mlahza As Boolean, ByVal Auto_emp As Boolean, ByVal Auto_total As Boolean, ByVal chb_mlahza As Boolean, ByVal chb_ٍsharta As Boolean, ByVal chb_zar_shee As Boolean)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update Table_mkf_add Set Id =@Id,id_and_user_tfg=@id_and_user_tfg,No_55 = @No_55 ,no_kshf = @no_kshf,Name_Emp = @Name_Emp,Name_school = @Name_school,Salary_ass = @Salary_ass,Dayes = @Dayes,Mkf = @Mkf,Mkf_2= @Mkf_2,Badl_safer = @Badl_safer,Entklat = @Entklat,total = @total,Mashat = @Mashat,Mashat8=@Mashat8,Darabb = @Darabb,nkaba=@nkaba,Mhann = @Mhann,Mastshfa = @Mastshfa,Damghh = @Damghh,Earaadta = @Earaadta,box20=@box20,Mzay_t_17_25=@Mzay_t_17_25,Total_Mostkta = @Total_Mostkta,Saffy = @Saffy,Id_Mkf=@Id_Mkf,date1= @date1,id_no=@id_no,op_name_pay=@op_name_pay,op_al_kta=@op_al_kta,op_no_emb=@op_no_emb,Saffy_after_antkal=@Saffy_after_antkal,nakab_yes_no=@nakab_yes_no,chb_tsh_mlahza=@chb_tsh_mlahza,Auto_emp=@Auto_emp,Auto_total=@Auto_total,chb_mlahza=@chb_mlahza,chb_ٍsharta=@chb_ٍsharta,chb_zar_shee=@chb_zar_shee Where id_and_user_tfg=@id_and_user_tfg "
            .Parameters.Clear()
            .Parameters.AddWithValue("@Id", OleDbType.Integer).Value = Id
            .Parameters.AddWithValue("@id_and_user_tfg", OleDbType.VarChar).Value = id_and_user_tfg

            .Parameters.AddWithValue("@No_55", OleDbType.Integer).Value = No_55
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf
            .Parameters.AddWithValue("@Name_Emp", OleDbType.VarChar).Value = Name_Emp
            .Parameters.AddWithValue("@Name_school", OleDbType.VarChar).Value = Name_school
            .Parameters.AddWithValue("@Salary_ass", OleDbType.Double).Value = Salary_ass
            .Parameters.AddWithValue("@Dayes", OleDbType.Integer).Value = Dayes
            .Parameters.AddWithValue("@Mkf", OleDbType.Double).Value = Mkf
            .Parameters.AddWithValue("@Mkf_2", OleDbType.Double).Value = Mkf_2

            .Parameters.AddWithValue("@Badl_safer", OleDbType.Double).Value = Badl_safer
            .Parameters.AddWithValue("@Entklat", OleDbType.Double).Value = Entklat
            .Parameters.AddWithValue("@total", OleDbType.Double).Value = total
            .Parameters.AddWithValue("@Mashat", OleDbType.Double).Value = Mashat
            .Parameters.AddWithValue("@Mashat8", OleDbType.Double).Value = Mashat8

            .Parameters.AddWithValue("@Darabb", OleDbType.Double).Value = Darabb
            .Parameters.AddWithValue("@nkaba", OleDbType.Double).Value = nkaba
            .Parameters.AddWithValue("@Mhann", OleDbType.Double).Value = Mhann
            .Parameters.AddWithValue("@Mastshfa", OleDbType.Double).Value = Mastshfa
            .Parameters.AddWithValue("@Damghh", OleDbType.Double).Value = Damghh
            .Parameters.AddWithValue("@Earaadta", OleDbType.Double).Value = Earaadta
            .Parameters.AddWithValue("@box20", OleDbType.Double).Value = box20
            .Parameters.AddWithValue("@Mzay_t_17_25", OleDbType.Double).Value = Mzay_t_17_25
            .Parameters.AddWithValue("@Total_Mostkta", OleDbType.Double).Value = Total_Mostkta
            .Parameters.AddWithValue("@Saffy", OleDbType.Double).Value = Saffy
            .Parameters.AddWithValue("@Id_Mkf", OleDbType.Integer).Value = Id_Mkf
            .Parameters.AddWithValue("@date1", OleDbType.Date).Value = date1

            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            .Parameters.AddWithValue("@op_name_pay", OleDbType.VarChar).Value = op_name_pay
            .Parameters.AddWithValue("@op_al_kta", OleDbType.VarChar).Value = op_al_kta

            .Parameters.AddWithValue("@op_no_emb", OleDbType.VarChar).Value = op_no_emb
            .Parameters.AddWithValue("@Saffy_after_antkal", OleDbType.Double).Value = Saffy_after_antkal
            .Parameters.AddWithValue("@nakab_yes_no", OleDbType.Boolean).Value = nakab_yes_no
            .Parameters.AddWithValue("@chb_tsh_mlahza", OleDbType.Boolean).Value = chb_tsh_mlahza
            .Parameters.AddWithValue("@Auto_emp", OleDbType.Boolean).Value = Auto_emp
            .Parameters.AddWithValue("@Auto_total", OleDbType.Boolean).Value = Auto_total
            .Parameters.AddWithValue("@chb_mlahza", OleDbType.Boolean).Value = chb_mlahza
            .Parameters.AddWithValue("@chb_ٍsharta", OleDbType.Boolean).Value = chb_ٍsharta
            .Parameters.AddWithValue("@chb_zar_shee", OleDbType.Boolean).Value = chb_zar_shee


        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Function Max_Table_mkf_add()
        Dim Number As Integer = 1
        Try
            Dim cmd As New OleDbCommand("Select Max(Id) From Table_mkf_add ", con)
            If con.State = 1 Then con.Close()
            con.Open()
            Number = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Number = 1
            con.Close()
        End Try
        Return Number
    End Function

    Public Function Max_no_kshf()
        Dim Number As Integer = 1
        Try
            Dim cmd As New OleDbCommand("Select Max(no_kshf) From Table_mkf_add ", con)
            If con.State = 1 Then con.Close()
            con.Open()
            Number = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Number = 1
            con.Close()
        End Try
        Return Number
    End Function

    ' select no_kshf_list_box

    Public Sub SelectSome_Table_mkf_add_indirect(ByVal list_box As ListBox)
        Dim dt_no_kshf As New DataTable
        Dim da As New OleDbDataAdapter
        dt_no_kshf.Clear()
        da = New OleDbDataAdapter("select DISTINCT no_kshf from Table_mkf_add", con)
        da.Fill(dt_no_kshf)
        If dt_no_kshf.Rows.Count > 0 Then
            list_box.DataSource = dt_no_kshf
            list_box.DisplayMember = "no_kshf"


            list_box.ValueMember = "no_kshf"
        Else
            list_box.DataSource = Nothing
        End If
    End Sub
    '==============================================
    'select salary_ass
    Public dt_salary_ass As New DataTable
    ' select id_mkf

    Public Sub select_salary_ass()
        dt_salary_ass.Clear()
        Dim Cmd As New OleDbCommand("SELECT emp.id_no, emp.name_emp, salary_ass.salary_old, salary_ass.salary_new, salary_ass.salary_safy, emp.school FROM salary_ass RIGHT JOIN emp ON salary_ass.id_no = emp.id_no WHERE (((salary_ass.salary_old)>1))", con)
        With Cmd
            .Connection = con
            con.Open()


            dt_salary_ass.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '===========================
    'select salary_ass
    Public dt_salary_ass_all As New DataTable
    ' select id_mkf

    Public Sub select_salary_ass_all()
        dt_salary_ass_all.Clear()
        Dim Cmd As New OleDbCommand("SELECT emp.id_no, emp.name_emp, salary_ass.salary_old, salary_ass.salary_new, salary_ass.salary_safy, emp.school FROM salary_ass RIGHT JOIN emp ON salary_ass.id_no = emp.id_no ", con)
        With Cmd
            .Connection = con
            con.Open()


            dt_salary_ass_all.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '    ==================================================
    'select no_kshf
    Public dt_Table_mkf_no_kshff As New DataTable
    ' select id_mkf
    Public dt_select_id_mkf As New DataTable
    Public Sub select_id_mkf(ByVal Id_Mkf As Integer)
        dt_select_id_mkf.Clear()
        Dim Cmd As New OleDbCommand("select * from Table_Mkf where Id_Mkf = @Id_Mkf", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@Id_Mkf", OleDbType.Integer).Value = Id_Mkf
            dt_select_id_mkf.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub

    ' select no_kasf
    Public dt_select_no_kash As New DataTable
    Public Sub select_no_kash(ByVal no_kash As Integer)
        dt_select_no_kash.Clear()
        Dim Cmd As New OleDbCommand("select * from Table_mkf_add where no_kshf = @no_kshf", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kash
            dt_select_no_kash.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '===================================================================
    ' select no_kasf_view
    Public dt_select_no_kash_view As New DataTable
    Public Sub select_no_kash_view(ByVal no_kash As Integer)
        dt_select_no_kash_view.Clear()
        Dim Cmd As New OleDbCommand("SELECT Table_mkf_add.Id,Table_mkf_add.id_and_user_tfg,Table_mkf_add.no_kshf, Table_mkf_add.Name_Emp, Table_mkf_add.id_no, Table_mkf_add.Name_school, Table_mkf_add.No_55, Table_mkf_add.Salary_ass, Table_mkf_add.Dayes, Table_mkf_add.Badl_safer, Table_mkf_add.Entklat, Table_mkf_add.Mkf, Table_mkf_add.total, Table_mkf_add.Darabb, Table_mkf_add.Mashat, Table_mkf_add.nkaba, Table_mkf_add.Mashat8, Table_mkf_add.Mhann, Table_mkf_add.Mastshfa, Table_mkf_add.Damghh, Table_mkf_add.Earaadta, Table_mkf_add.box20,Table_mkf_add.Mzay_t_17_25, Table_mkf_add.Total_Mostkta, Table_mkf_add.Saffy, Table_mkf_add.nakab_yes_no, Table_mkf_add.Auto_emp, Table_mkf_add.Auto_total, Table_mkf_add.id_user, Table_mkf_add.hh, Table_mkf_add.op_al_kta, Table_mkf_add.op_no_emb, Table_mkf_add.op_name_pay, Table_mkf_add.date1, Table_mkf_add.Id_Mkf, Table_mkf_add.Saffy_after_antkal, Table_mkf_add.chb_tsh_mlahza FROM Table_mkf_add where no_kshf = @no_kshf", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kash
            dt_select_no_kash_view.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub



    '==================================================================
    'delete mkf
    'delete _mkf_tfrgh
    Public Sub Delete_mkf_tfrgh(ByVal dgv__mkf_tfrgh As DataGridView)
        Dim Position As Integer = dgv__mkf_tfrgh.CurrentRow.Index
        Dim ID_Position As Integer = dgv__mkf_tfrgh.Rows(Position).Cells("id").Value
        Dim CmdDelete As New OleDbCommand
        With CmdDelete
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Table_mkf_add Where id = @id"
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
    '========================================================
    'delete id
    Public Sub Delete_id_tfrgh(ByVal id_and_user_tfg As String)
        'Dim Position As Integer = dgv__mkf_tfrgh.CurrentRow.Index
        'Dim ID_Position As Integer = dgv__mkf_tfrgh.Rows(Position).Cells("id").Value
        Dim CmdDelete As New OleDbCommand
        With CmdDelete
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Table_mkf_add Where id_and_user_tfg = @id_and_user_tfg"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_and_user_tfg", OleDbType.VarChar).Value = id_and_user_tfg
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        CmdDelete.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        CmdDelete = Nothing
    End Sub


    '=======================================================

    ' select no_55
    Public dt_select_no_55 As New DataTable
    Public Sub select_no_55(ByVal no_55 As Integer)
        dt_select_no_55.Clear()
        Dim Cmd As New OleDbCommand("select * from Table_mkf_add where No_55 = @No_55", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@No_55", OleDbType.Integer).Value = no_55
            dt_select_no_55.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '=========================================================================
    'التاكد من عدم تكرار الرقم القومى
    '=======================================
    ' select id_emp
    Public dt_select_id_emp As New DataTable
    Public Sub select_id_emp(ByVal id_emp As String)
        dt_select_id_emp.Clear()
        Dim Cmd As New OleDbCommand("select * from Table_mkf_add where id_no = @id_no", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_emp
            dt_select_id_emp.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '=========================================================================
    '=========================================================================
    'التاكد من عدم تكرار الرقم القومى
    '=======================================
    ' select id_emp
    Public dt_select_id_no_salary_ass As New DataTable
    Public Sub select_id_salary_ass(ByVal id_no As String)
        dt_select_id_no_salary_ass.Clear()
        Dim Cmd As New OleDbCommand("select * from salary_ass where id_no = @id_no", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            dt_select_id_no_salary_ass.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '=====================================
    ' فى جدول emp_infالتاكد من عدم تكرار الرقم القومى
    '=======================================
    ' select id_emp
    Public dt_select_id_no_emp_inf As New DataTable
    Public Sub select_id_emp_inf(ByVal id_no As String)
        dt_select_id_no_emp_inf.Clear()
        Dim Cmd As New OleDbCommand("select * from Emp_inf where id_no = @id_no", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            dt_select_id_no_emp_inf.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub

    '=========================================================================
    'delete _all_tfrgh
    Public Sub delete_all_tfrgh()


        Dim Cmd_Delete_all As New OleDbCommand
        With Cmd_Delete_all
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete * From Table_mkf_add where id>1 "
            .Parameters.Clear()

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd_Delete_all.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف .", MsgBoxStyle.Information, "حذف")
        Cmd_Delete_all = Nothing
    End Sub
    '==============================================
    'delete _one_tfrgh
    Public Sub Delete_one_kashf(ByVal listbox As ListBox)
        'Dim Position As Integer = dgv_Table_mkf_add.CurrentRow.Index

        Dim Position As Integer = listbox.SelectedValue
        'Dim ID_Position As Integer = dgv_Table_mkf_add.Rows(Position).Cells("Id").Value.Rows(Position).Cells("no_kshf").Value()
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Table_mkf_add Where  no_kshf = @no_kshf"
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = Position
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Sub noused_char(ByVal e As KeyPressEventArgs)
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "." Or e.KeyChar = "+" Or e.KeyChar = "-" Or e.KeyChar = "*" Or e.KeyChar = "/" Or e.KeyChar = ControlChars.Back Or e.KeyChar = "v" Or e.KeyChar = ControlChars.CrLf Then
            Exit Sub
        Else
            e.KeyChar = ""
            'MessageBox.Show((e.KeyChar).ToString())
            'cal_form.RichTextBox1.Text = (e.KeyChar).ToString()
        End If
    End Sub

    Sub no_used_char2(ByVal e As KeyPressEventArgs)
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "." Or e.KeyChar = ControlChars.Back Then
            Exit Sub
        Else
            e.KeyChar = ""
            'MessageBox.Show((e.KeyChar).ToString())
            'cal_form.RichTextBox1.Text = (e.KeyChar).ToString()
        End If
    End Sub
    '================================
    Sub no_used_char3(ByVal e As KeyPressEventArgs)
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "." Then

            e.KeyChar = ""
            Exit Sub
        Else

            'MessageBox.Show((e.KeyChar).ToString())
            'cal_form.RichTextBox1.Text = (e.KeyChar).ToString()
        End If
    End Sub


    '=====================================
    Public Sub textbox_to_deciemal(ByVal textbox As TextBox)
        If textbox.Text = "" Then
            textbox.Text = 0
        Else
            textbox.Text = Format(Double.Parse(textbox.Text), "########0.00")
        End If
    End Sub

End Module
