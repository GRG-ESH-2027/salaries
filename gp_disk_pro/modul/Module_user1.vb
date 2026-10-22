Imports System.Data.OleDb

Module Module_user1

    'ملا المستخدمين combox
    Public dt_user As New DataTable
    Public Sub auto_user()
        Dim da As New OleDbDataAdapter
        dt_user.Clear()
        'Dim Cmd As New OleDbCommand
        'Cmd.Connection = con
        'Cmd.CommandType = CommandType.Text
        'dv.RowFilter = " descr LIKE '%" & TextBox1.Text & "%' "

        da = New OleDbDataAdapter("select * from user_table", con)
        'da = New OleDbDataAdapter("select school from emp where name_emp=@name_emp ", con)
        'da.Fill(dt_auto_txt)
        'Dim data_souce As New AutoCompleteStringCollection
        da.Fill(dt_user)

     
        'Name_school.DataBindings = ""

    End Sub

    '=====================================================================================
    'تسجيل الدخول
    Public dt_logon_user As New DataTable
    Public Sub logon_user(ByVal user_name As String, ByVal user_pass As String)

        Dim da As New OleDbDataAdapter
        dt_logon_user.Clear()
        Dim Cmd As New OleDbCommand(" select * from user_table  where  user_name = @user_name and user_pass= @user_pass", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@user_name", OleDbType.VarChar).Value = user_name
            .Parameters.AddWithValue("@user_pass", OleDbType.VarChar).Value = user_pass
            'da.Fill(dt_load_oper)
            dt_logon_user.Load(Cmd.ExecuteReader)

        End With

        con.Close()
        Cmd = Nothing
    End Sub



End Module
