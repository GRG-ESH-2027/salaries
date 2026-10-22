
Imports System.Data.OleDb
Module Module_add_gp
    'Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb")
    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\gp_tafrgh_db.accdb")
    Public con2 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;" & "Data Source=" & Application.StartupPath & "\datadata\gp_tafrgh_db.accdb")
    'cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=" & Application.StartupPath & "\UsersData.mdb;Jet OLEDB:Database Password=,"
    Public offece As Integer = 12

    Public dt_gp_table As New DataTable

    Public Sub SelectAll_gp_table(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_gp_table.Clear()
        da = New OleDbDataAdapter("select * from gp_table", con)
        da.Fill(dt_gp_table)
        dgv.DataSource = dt_gp_table
    End Sub

    'اسماءعمود فى دات
    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("id").HeaderText = "id"
                .Columns("date1").HeaderText = "تاريخ اليوم"
                .Columns("descr").HeaderText = "البيان"
                .Columns("no_file").HeaderText = "رقم الملف"
                .Columns("el_mablgh").HeaderText = "المبلغ"
                .Columns("el_mablgh").DefaultCellStyle.BackColor = Color.Yellow


                .Columns("no_gp").HeaderText = "رقم امر الدفع"
                .Columns("date_assthkk").HeaderText = "تاريخ الصرف"
                .Columns("no_shatb").HeaderText = "رقم الشطب"
                .Columns("id_desc").HeaderText = "نوع المدفوعه"
            End With
        End If
    End Sub
    'with dgv
    Public Sub DataGridViewHeaderwith(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("id").Width = 80
                .Columns("date1").Width = 150
                .Columns("descr").Width = 300
                .Columns("no_file").Width = 100
                .Columns("el_mablgh").Width = 150
                .Columns("no_gp").Width = 250
                .Columns("date_assthkk").Width = 150
                .Columns("no_shatb").Width = 150
                .Columns("id_desc").Width = 60
            End With
        End If
    End Sub

  

    'max id
    Public Function Max_gp_table()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(id) From gp_table ", Con)
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
    'fill compbox
    
    Public Sub fillcmb_dec_shatb_table(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New OleDbDataAdapter
        DT.Clear()
        DA = New OleDbDataAdapter("Select * FROM dec_shatb_table ", con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "id_desc"
            cmb.DisplayMember = "descr_shatb"
            cmb.ValueMember = "id_desc"
        Else
            cmb.DataSource = Nothing
        End If

    End Sub
    ' insert 
    Public Sub Insert_gp_table(ByVal id_and_user As String, ByVal date11 As DateTime, ByVal descr_gp As String, ByVal no_filee As String, ByVal el_mablghh As Double, ByVal no_gpp As String, ByVal date_assthkkk As DateTime, ByVal no_shatb As String, ByVal id_descc As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into gp_table ( id,id_and_user,date1,descr,no_file,el_mablgh,no_gp,date_assthkk,no_shatb,id_desc)values(@id,@id_and_user,@date1,@descr,@no_file,@el_mablgh,@no_gp,@date_assthkk,@no_shatb,@id_desc)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id", OleDbType.Integer).Value = Max_gp_table() + 1
            .Parameters.AddWithValue("@id_and_user", OleDbType.VarChar).Value = id_and_user
            .Parameters.AddWithValue("@date1", OleDbType.Date).Value = date11
            .Parameters.AddWithValue("@descr", OleDbType.VarChar).Value = descr_gp
            .Parameters.AddWithValue("@no_file", OleDbType.VarChar).Value = no_filee
            .Parameters.AddWithValue("@el_mablgh", OleDbType.Double).Value = el_mablghh
            .Parameters.AddWithValue("@no_gp", OleDbType.VarChar).Value = no_gpp
            .Parameters.AddWithValue("@date_assthkk", OleDbType.Date).Value = date_assthkkk
            .Parameters.AddWithValue("@no_shatb", OleDbType.VarChar).Value = no_shatb
            .Parameters.AddWithValue("@id_desc", OleDbType.Integer).Value = id_descc
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub


    ' only numb
    Public Function MakeTextBoxNumeric(ByVal kcode As Integer, ByVal shift As Boolean) As Boolean
        If kcode >= 96 And kcode <= 105 Then
        ElseIf kcode >= 48 And kcode <= 57 Then
            If shift = True Then Return False
        ElseIf kcode = 8 Or kcode = 107 Then
        ElseIf kcode = 187 Then
            If shift = False Then Return False
        Else
            Return False
        End If
        Return True
    End Function
    'update
    Public Sub Update_gp_table(ByVal id_and_user As String, ByVal date1 As DateTime, ByVal descr As String, ByVal no_file As String, ByVal el_mablghh As Double, ByVal no_gp As String, ByVal date_assthkk As DateTime, ByVal no_shatb As String, ByVal id_desc As Integer, ByVal idw As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update gp_table Set id_and_user=@id_and_user,date1 = @date1,descr = @descr,no_file = @no_file,el_mablgh = @el_mablgh,no_gp = @no_gp,date_assthkk = @date_assthkk,no_shatb = @no_shatb,id_desc = @id_desc Where id = @idw"
            .Parameters.Clear()
            '.Parameters.AddWithValue("@id", OleDbType.Integer).Value = id
            .Parameters.AddWithValue("@id_and_user", OleDbType.VarChar).Value = id_and_user
            .Parameters.AddWithValue("@date1", OleDbType.Date).Value = date1
            .Parameters.AddWithValue("@descr", OleDbType.VarChar).Value = descr
            .Parameters.AddWithValue("@no_file", OleDbType.VarChar).Value = no_file
            .Parameters.AddWithValue("@el_mablghh", OleDbType.Double).Value = el_mablghh
            .Parameters.AddWithValue("@no_gp", OleDbType.VarChar).Value = no_gp
            .Parameters.AddWithValue("@date_assthkk", OleDbType.Date).Value = date_assthkk
            .Parameters.AddWithValue("@no_shatb", OleDbType.VarChar).Value = no_shatb
            .Parameters.AddWithValue("@id_desc", OleDbType.Integer).Value = id_desc
            .Parameters.AddWithValue("@id", OleDbType.Integer).Value = idw

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    'delete row
    Public Sub Delete_gp_table(ByVal dgv_gp_table As DataGridView)
        Dim Position As Integer = dgv_gp_table.CurrentRow.Index
        Dim ID_Position As String = dgv_gp_table.Rows(Position).Cells("id_and_user").Value
        Dim CmdDelete As New OleDbCommand
        With CmdDelete
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From gp_table Where id_and_user = @id_and_user"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_and_user", OleDbType.VarChar).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        COn.Open()
        CmdDelete.ExecuteNonQuery()
        COn.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        CmdDelete = Nothing
    End Sub
    'search by date
    Public DT_SEARCH_by_date As New DataTable()
    Public Sub SEARCH_by_DATE(ByVal date1 As DateTime)
        DT_SEARCH_by_date.Clear()
        Dim CMDSEARCH As New OleDbCommand(" select * from gp_table WHERE date1 = @date1", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date1", OleDbType.Date).Value = "#" & date1 & "#"

        Try
            If con.State = 1 Then con.Close()
            con.Open()
            DT_SEARCH_by_date.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub
    ' تجميع select
    Public Function Sum_gp_table_el_mablgh()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand(" Select Sum(el_mablgh) From gp_table  ", con)
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
  




End Module

