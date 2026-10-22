Imports System.Data.OleDb
Module Module_emp
    Public dt_emp_table As New DataTable
    '=============================
    Public Sub delete_all_emp()
        Dim Cmd_Delete_all_emp As New OleDbCommand
        With Cmd_Delete_all_emp
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete * From emp  "
            .Parameters.Clear()

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd_Delete_all_emp.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف .", MsgBoxStyle.Information, "حذف")
        Cmd_Delete_all_emp = Nothing
    End Sub
    '=======================================
    '0=====================1=======================2=======================3========================4========================5======================6
    Public Sub Insert_emp(ByVal id_no As String, ByVal name_pay As String, ByVal al_kta As String, ByVal school As String, ByVal no_emb As String, ByVal name_emp As String, ByVal hh As String)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            '0======1=========2=====3=====4=======5======6
            .CommandText = "Insert Into emp ( id_no,name_pay,al_kta,school,no_emb,name_emp,hh)values(@id_no,@name_pay,@al_kta,@school,@no_emb,@name_emp,@hh)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            .Parameters.AddWithValue("@name_pay", OleDbType.VarChar).Value = name_pay
            .Parameters.AddWithValue("@al_kta", OleDbType.VarChar).Value = al_kta
            .Parameters.AddWithValue("@school", OleDbType.VarChar).Value = school
            .Parameters.AddWithValue("@no_emb", OleDbType.VarChar).Value = no_emb
            .Parameters.AddWithValue("@name_emp", OleDbType.VarChar).Value = name_emp
            .Parameters.AddWithValue("@hh", OleDbType.VarChar).Value = hh
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '===========================================
    Public dt_Select_emp As New DataTable
    Public Sub Select_emp(ByVal id_no As String)

        Dim da As New OleDbDataAdapter
        dt_Select_emp.Clear()
        Dim Cmd As New OleDbCommand("select id_no from emp where id_no=@id_no ", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_no
            dt_Select_emp.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
        'dgv.DataSource = dt_Select_emp
    End Sub
    '=================================
    Public dt_all_emp As New DataTable
    Public Sub SelectAll_emp(dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_all_emp.Clear()
        da = New OleDbDataAdapter("select * from emp", con)
        da.Fill(dt_all_emp)
        dgv.DataSource = dt_all_emp
    End Sub






End Module
