Imports System.Data.OleDb

Module Module_Add_user
    Public Sub ClearControls()
        Form_Add_user.id_user.Text = vbNullString
        Form_Add_user.user_name.Text = vbNullString
        Form_Add_user.user_pass.Text = vbNullString
        Form_Add_user.TextBox1.Text = vbNullString
        Form_Add_user.user_ful_name.Text = vbNullString
        Form_Add_user.user_mange.Text = vbNullString
    End Sub
    '======================================================
    Public Function Max_user_table()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(id_user) From user_table ", con)
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
    '=====================================
    Public dt_user_table As New DataTable
    Public Sub SelectAll_user_table(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_user_table.Clear()
        da = New OleDbDataAdapter("select * from user_table", con)
        da.Fill(dt_user_table)
        dgv.DataSource = dt_user_table
    End Sub
    '======================================
    Public Sub Insert_user_table(ByVal id_user As Integer, ByVal user_name As String, ByVal user_pass As String, ByVal user_ful_name As String, ByVal user_mange As String)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into user_table ( id_user,user_name,user_pass,user_ful_name,user_mange)values(@id_user,@user_name,@user_pass,@user_ful_name,@user_mange)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_user", OleDbType.Integer).Value = id_user
            .Parameters.AddWithValue("@user_name", OleDbType.VarChar).Value = user_name
            .Parameters.AddWithValue("@user_pass", OleDbType.VarChar).Value = user_pass
            .Parameters.AddWithValue("@user_ful_name", OleDbType.VarChar).Value = user_ful_name
            .Parameters.AddWithValue("@user_mange", OleDbType.VarChar).Value = user_mange
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    '========================

    '========================
    Public Function DGVCurrentImageView(ByVal byt As Byte()) As Image
        Dim MS As New System.IO.MemoryStream()
        Dim drwing As Image = Nothing
        MS.Write(byt, 0, byt.Length)
        drwing = New Bitmap(MS)
        MS.Close()
        Return drwing
    End Function

    '========================================
    Public Sub fillcmb_user_table(ByVal cmb As ComboBox)
        'Dim DT As New DataTable
        'Dim DA As New OleDbDataAdapter
        'DT.Clear()
        'DA = New OleDbDataAdapter("Select * FROM user_table ", con)
        'DA.Fill(DT)
        'If DT.Rows.Count > 0 Then
        '    cmb.DataSource = DT
        '    cmb.DisplayMember = "user_mange"
        cmb.Items.Add("admin")
        cmb.Items.Add("mange")
        cmb.DisplayMember = "admin"
        'Else
        'cmb.DataSource = Nothing
        'End If
    End Sub
    '=============================================
    Public Sub Delete_user_table(ByVal dgv_user_table As DataGridView)
        Dim Position As Integer = dgv_user_table.CurrentRow.Index
        Dim ID_Position As Integer = dgv_user_table.Rows(Position).Cells(0).Value
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From user_table Where id_user = @id_user"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_user", OleDbType.Integer).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    '===================





End Module
