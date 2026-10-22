Imports System.Data.OleDb

Module Module_edite_bnd_name
    Public num_taswy As Integer
    '============
    'max id
    Public Function Max_id_bnd()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(id_bnd) From tabel_bnd ", con)
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

    '==================
    Public Function Max_taswy_bnd()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(num_taswy) From tabel_bnd ", con)
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
    '=============
    Public Function Max_no_of_kashf_bnd()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(no_of_kashf) From tabel_bnd ", con)
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
    '====================
    'select_all max_taswy
    Public dt_tabel_bnd As New DataTable
    Public Sub SelectAll_tabel_bnd(dgv As DataGridView, ByVal num_taswy As Integer)
        Dim da As New OleDbDataAdapter
        dt_tabel_bnd.Clear()

        num_taswy = Max_taswy_bnd()
        da = New OleDbDataAdapter("select * from tabel_bnd where num_taswy=" & num_taswy & "", con)
        da.Fill(dt_tabel_bnd)
        dgv.DataSource = dt_tabel_bnd
    End Sub
    '==================
    'select_one taswy
    Public dt_tabel_bnd_one As New DataTable
    Public Sub SelectAll_tabel_bnd_one_taswy(dgv As DataGridView, ByVal num_taswy As Integer)
        Dim da As New OleDbDataAdapter
        dt_tabel_bnd_one.Clear()

        da = New OleDbDataAdapter("select * from tabel_bnd where num_taswy=" & num_taswy & "", con)
        da.Fill(dt_tabel_bnd_one)
        dgv.DataSource = dt_tabel_bnd_one
    End Sub
    '================
    'select_all taswy
    Public dt_tabel_all_taswy As New DataTable
    Public Sub SelectAll_tabel_bnd_all_taswy(ByVal list_box As ListBox)
        Dim da As New OleDbDataAdapter
        dt_tabel_all_taswy.Clear()

        da = New OleDbDataAdapter("select DISTINCT num_taswy from tabel_bnd ", con)
        da.Fill(dt_tabel_all_taswy)
        If dt_tabel_all_taswy.Rows.Count > 0 Then
            list_box.DataSource = dt_tabel_all_taswy
            list_box.DisplayMember = "num_taswy"


            list_box.ValueMember = "num_taswy"
        Else
            list_box.DataSource = Nothing
        End If
    End Sub

    '\\\\\\\\\\\\\\\
    Public Sub Delete_tabel_bnd_rec(ByVal id_bnd As Integer)
        'Dim Position As Integer = dgv_tabel_bnd.CurrentRow.Index
        'Dim ID_Position As Integer = dgv_tabel_bnd.Rows(Position).Cells("id_bnd").Value
        Dim CmdDelete As New OleDbCommand
        With CmdDelete
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From tabel_bnd Where id_bnd = @id_bnd"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = id_bnd
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        CmdDelete.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        CmdDelete = Nothing
    End Sub

    '=============
    'انشاء تسويه جديده

    '==============================================================
    'insert_tsw


    Public Sub Insert_taswy_bnd(ByVal id_bnd As Integer, ByVal num_taswy As Integer, ByVal col_1 As Double,
                                ByVal col_2 As Double, ByVal col_3 As Double, ByVal col_4 As Double, ByVal col_5 As Double,
                                ByVal col_6 As Double, ByVal col_7 As Double, ByVal col_8 As Double, ByVal col_9 As Double,
                                ByVal col_10 As Double, ByVal col_11 As Double, ByVal col_12 As Double, ByVal col_13 As Double,
                                ByVal col_14 As Double, ByVal col_15 As Double, ByVal col_16 As Double, ByVal col_17 As Double,
                                ByVal col_18 As Double, ByVal col_19 As Double, ByVal col_20 As Double, ByVal col_21 As Double,
                                ByVal col_22 As Double, ByVal col_23 As Double, ByVal col_24 As Double, ByVal col_25 As Double,
                                ByVal col_26 As Double, ByVal bnd_adafy_1 As Double, ByVal bnd_adafy_2 As Double, ByVal bnd_adafy_3 As Double, ByVal bnd_adafy_4 As Double, ByVal bnd_adafy_5 As Double,
                                ByVal bnd_adafy_6 As Double, ByVal bnd_adafy_7 As Double, ByVal bnd_adafy_8 As Double, ByVal bnd_adafy_9 As Double,
                                ByVal bnd_adafy_10 As Double, ByVal total_all As Double)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into tabel_bnd (id_bnd,num_taswy,col_1,col_2,col_3,col_4,col_5,col_6,col_7,col_8,col_9,col_10,col_11,col_12,col_13,col_14,col_15,col_16,col_17,col_18,col_19,col_20,col_21,col_22,col_23,col_24,col_25,col_26,bnd_adafy_1,bnd_adafy_2,bnd_adafy_3,bnd_adafy_4,bnd_adafy_5,bnd_adafy_6,bnd_adafy_7,bnd_adafy_8,bnd_adafy_9,bnd_adafy_10,total_all)values(@id_bnd,@num_taswy,@col_1,@col_2,@col_3,@col_4,@col_5,@col_6,@col_7,@col_8,@col_9,@col_10,@col_11,@col_12,@col_13,@col_14,@col_15,@col_16,@col_17,@col_18,@col_19,@col_20,@col_21,@col_22,@col_23,@col_24,@col_25,@col_26,@bnd_adafy_1,@bnd_adafy_2,@bnd_adafy_3,@bnd_adafy_4,@bnd_adafy_5,@bnd_adafy_6,@bnd_adafy_7,@bnd_adafy_8,@bnd_adafy_9,@bnd_adafy_10,@total_all)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = id_bnd

            .Parameters.AddWithValue("@num_taswy", OleDbType.Integer).Value = num_taswy
            .Parameters.AddWithValue("@col_1", OleDbType.Double).Value = col_1
            .Parameters.AddWithValue("@col_2", OleDbType.Double).Value = col_2
            .Parameters.AddWithValue("@col_3", OleDbType.Double).Value = col_3
            .Parameters.AddWithValue("@col_4", OleDbType.Double).Value = col_4
            .Parameters.AddWithValue("@col_5", OleDbType.Double).Value = col_5
            .Parameters.AddWithValue("@col_6", OleDbType.Double).Value = col_6
            .Parameters.AddWithValue("@col_7", OleDbType.Double).Value = col_7
            .Parameters.AddWithValue("@col_8", OleDbType.Double).Value = col_8
            .Parameters.AddWithValue("@col_9", OleDbType.Double).Value = col_9
            .Parameters.AddWithValue("@col_10", OleDbType.Double).Value = col_10
            .Parameters.AddWithValue("@col_11", OleDbType.Double).Value = col_11
            .Parameters.AddWithValue("@col_12", OleDbType.Double).Value = col_12
            .Parameters.AddWithValue("@col_13", OleDbType.Double).Value = col_13
            .Parameters.AddWithValue("@col_14", OleDbType.Double).Value = col_14
            .Parameters.AddWithValue("@col_15", OleDbType.Double).Value = col_15
            .Parameters.AddWithValue("@col_16", OleDbType.Double).Value = col_16
            .Parameters.AddWithValue("@col_17", OleDbType.Double).Value = col_17
            .Parameters.AddWithValue("@col_18", OleDbType.Double).Value = col_18
            .Parameters.AddWithValue("@col_19", OleDbType.Double).Value = col_19
            .Parameters.AddWithValue("@col_20", OleDbType.Double).Value = col_20
            .Parameters.AddWithValue("@col_21", OleDbType.Double).Value = col_21
            .Parameters.AddWithValue("@col_22", OleDbType.Double).Value = col_22
            .Parameters.AddWithValue("@col_23", OleDbType.Double).Value = col_23
            .Parameters.AddWithValue("@col_24", OleDbType.Double).Value = col_24
            .Parameters.AddWithValue("@col_25", OleDbType.Double).Value = col_25
            .Parameters.AddWithValue("@col_26", OleDbType.Double).Value = col_26
            .Parameters.AddWithValue("@bnd_adafy_1", OleDbType.Double).Value = bnd_adafy_1
            .Parameters.AddWithValue("@bnd_adafy_2", OleDbType.Double).Value = bnd_adafy_2
            .Parameters.AddWithValue("@bnd_adafy_3", OleDbType.Double).Value = bnd_adafy_3
            .Parameters.AddWithValue("@bnd_adafy_4", OleDbType.Double).Value = bnd_adafy_4
            .Parameters.AddWithValue("@bnd_adafy_5", OleDbType.Double).Value = bnd_adafy_5
            .Parameters.AddWithValue("@bnd_adafy_6", OleDbType.Double).Value = bnd_adafy_6
            .Parameters.AddWithValue("@bnd_adafy_7", OleDbType.Double).Value = bnd_adafy_7
            .Parameters.AddWithValue("@bnd_adafy_8", OleDbType.Double).Value = bnd_adafy_8
            .Parameters.AddWithValue("@bnd_adafy_9", OleDbType.Double).Value = bnd_adafy_9
            .Parameters.AddWithValue("@bnd_adafy_10", OleDbType.Double).Value = bnd_adafy_10
            .Parameters.AddWithValue("@total_all", OleDbType.Double).Value = total_all

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    '=================
    'update
    Public Sub Update_tabel_bnd_taswy(ByVal id_bnd As Integer, ByVal num_taswy As Integer, ByVal col_1 As Double,
                                ByVal col_2 As Double, ByVal col_3 As Double, ByVal col_4 As Double, ByVal col_5 As Double,
                                ByVal col_6 As Double, ByVal col_7 As Double, ByVal col_8 As Double, ByVal col_9 As Double,
                                ByVal col_10 As Double, ByVal col_11 As Double, ByVal col_12 As Double, ByVal col_13 As Double,
                                ByVal col_14 As Double, ByVal col_15 As Double, ByVal col_16 As Double, ByVal col_17 As Double,
                                ByVal col_18 As Double, ByVal col_19 As Double, ByVal col_20 As Double, ByVal col_21 As Double,
                                ByVal col_22 As Double, ByVal col_23 As Double, ByVal col_24 As Double, ByVal col_25 As Double,
                                ByVal col_26 As Double, ByVal bnd_adafy_1 As Double, ByVal bnd_adafy_2 As Double, ByVal bnd_adafy_3 As Double, ByVal bnd_adafy_4 As Double, ByVal bnd_adafy_5 As Double,
                                ByVal bnd_adafy_6 As Double, ByVal bnd_adafy_7 As Double, ByVal bnd_adafy_8 As Double, ByVal bnd_adafy_9 As Double,
                                ByVal bnd_adafy_10 As Double, ByVal total_all As Double)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tabel_bnd Set id_bnd = @id_bnd,num_taswy = @num_taswy,col_1 = @col_1,col_2 = @col_2,col_3 = @col_3,col_4 = @col_4,col_5 = @col_5,col_6 = @col_6,col_7 = @col_7,col_8 = @col_8,col_9 = @col_9,col_10 = @col_10,col_11 = @col_11,col_12 = @col_12,col_13 = @col_13,col_14 = @col_14,col_15 = @col_15,col_16 = @col_16,col_17 = @col_17,col_18 = @col_18,col_19 = @col_19,col_20 = @col_20,col_21 = @col_21,col_22 = @col_22,col_23 = @col_23,col_24 = @col_24,col_25 = @col_25,col_26 = @col_26,bnd_adafy_1 = @bnd_adafy_1,bnd_adafy_2 = @bnd_adafy_2,bnd_adafy_3 = @bnd_adafy_3,bnd_adafy_4 = @bnd_adafy_4,bnd_adafy_5 = @bnd_adafy_5,bnd_adafy_6 = @bnd_adafy_6,bnd_adafy_7 = @bnd_adafy_7,bnd_adafy_8 = @bnd_adafy_8,bnd_adafy_9 = @bnd_adafy_9,bnd_adafy_10 = @bnd_adafy_10,total_all = @total_all Where id_bnd = @id_bnd"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = id_bnd

            .Parameters.AddWithValue("@num_taswy", OleDbType.Integer).Value = num_taswy
            .Parameters.AddWithValue("@col_1", OleDbType.Double).Value = col_1
            .Parameters.AddWithValue("@col_2", OleDbType.Double).Value = col_2
            .Parameters.AddWithValue("@col_3", OleDbType.Double).Value = col_3
            .Parameters.AddWithValue("@col_4", OleDbType.Double).Value = col_4
            .Parameters.AddWithValue("@col_5", OleDbType.Double).Value = col_5
            .Parameters.AddWithValue("@col_6", OleDbType.Double).Value = col_6
            .Parameters.AddWithValue("@col_7", OleDbType.Double).Value = col_7
            .Parameters.AddWithValue("@col_8", OleDbType.Double).Value = col_8
            .Parameters.AddWithValue("@col_9", OleDbType.Double).Value = col_9
            .Parameters.AddWithValue("@col_10", OleDbType.Double).Value = col_10
            .Parameters.AddWithValue("@col_11", OleDbType.Double).Value = col_11
            .Parameters.AddWithValue("@col_12", OleDbType.Double).Value = col_12
            .Parameters.AddWithValue("@col_13", OleDbType.Double).Value = col_13
            .Parameters.AddWithValue("@col_14", OleDbType.Double).Value = col_14
            .Parameters.AddWithValue("@col_15", OleDbType.Double).Value = col_15
            .Parameters.AddWithValue("@col_16", OleDbType.Double).Value = col_16
            .Parameters.AddWithValue("@col_17", OleDbType.Double).Value = col_17
            .Parameters.AddWithValue("@col_18", OleDbType.Double).Value = col_18
            .Parameters.AddWithValue("@col_19", OleDbType.Double).Value = col_19
            .Parameters.AddWithValue("@col_20", OleDbType.Double).Value = col_20
            .Parameters.AddWithValue("@col_21", OleDbType.Double).Value = col_21
            .Parameters.AddWithValue("@col_22", OleDbType.Double).Value = col_22
            .Parameters.AddWithValue("@col_23", OleDbType.Double).Value = col_23
            .Parameters.AddWithValue("@col_24", OleDbType.Double).Value = col_24
            .Parameters.AddWithValue("@col_25", OleDbType.Double).Value = col_25
            .Parameters.AddWithValue("@col_26", OleDbType.Double).Value = col_26
            .Parameters.AddWithValue("@bnd_adafy_1", OleDbType.Double).Value = bnd_adafy_1
            .Parameters.AddWithValue("@bnd_adafy_2", OleDbType.Double).Value = bnd_adafy_2
            .Parameters.AddWithValue("@bnd_adafy_3", OleDbType.Double).Value = bnd_adafy_3
            .Parameters.AddWithValue("@bnd_adafy_4", OleDbType.Double).Value = bnd_adafy_4
            .Parameters.AddWithValue("@bnd_adafy_5", OleDbType.Double).Value = bnd_adafy_5
            .Parameters.AddWithValue("@bnd_adafy_6", OleDbType.Double).Value = bnd_adafy_6
            .Parameters.AddWithValue("@bnd_adafy_7", OleDbType.Double).Value = bnd_adafy_7
            .Parameters.AddWithValue("@bnd_adafy_8", OleDbType.Double).Value = bnd_adafy_8
            .Parameters.AddWithValue("@bnd_adafy_9", OleDbType.Double).Value = bnd_adafy_9
            .Parameters.AddWithValue("@bnd_adafy_10", OleDbType.Double).Value = bnd_adafy_10
            .Parameters.AddWithValue("@total_all", OleDbType.Double).Value = total_all

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    '================
    Public Function Count_num_taswy_bnd()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand(" Select Count(num_taswy) From tabel_bnd  ", con)
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

    '===================
    '  تعديل اسم عمود المستحقات 
    Public Sub Update_tabel_names_col(ByVal id_col As Integer, ByVal name_col_total As String, ByVal id_colW As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tabel_names_col_total Set  name_col_total = @name_col_total  Where id_col = @id_col"
            .Parameters.Clear()

            .Parameters.AddWithValue("@name_col_total", OleDbType.VarChar).Value = name_col_total
            .Parameters.AddWithValue("@id_col", OleDbType.Integer).Value = id_colW
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub


    '=========================================================
    'تعديل اسم عمود المستقطع 
    Public Sub Update_tabel_mostkta_names_col(ByVal id_name_mostkta As Integer, ByVal names_col_mostkta As String, ByVal id_name_mostktaW As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tabel_names_mostkta Set id_name_mostkta = @id_name_mostkta,names_col_mostkta = @names_col_mostkta  Where id_name_mostkta = @id_name_mostkta"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_name_mostkta", OleDbType.Integer).Value = id_name_mostkta
            .Parameters.AddWithValue("@names_col_mostkta", OleDbType.VarChar).Value = names_col_mostkta
            .Parameters.AddWithValue("@id_name_mostkta", OleDbType.Integer).Value = id_name_mostktaW
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    ''ط==================================
    Public Sub format_datagridview(dgv As DataGridView)
        Try


            If dgv.Rows.Count >= 8 Then
                For i As Integer = 0 To dgv.Rows.Count - 6


                    'i += 1

                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                    i += 1
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                    i += 1
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                    i += 1
                    dgv.Rows(i).DefaultCellStyle.BackColor = Color.Orange

                Next


            End If

            'DataGridView2.Columns("no_kshf").DefaultCellStyle.Format = "N0"
            'DataGridView2.Columns("Salary_ass").DefaultCellStyle.Format = "N2"
            'DataGridView2.Columns("Mkf").DefaultCellStyle.Format = "N2"
            'DataGridView2.Columns("mkf_2").DefaultCellStyle.Format = "N2"
            'DataGridView2.Columns("total").DefaultCellStyle.Format = "N2"
            'DataGridView2.Columns("Badl_safer").DefaultCellStyle.Format = "N2"
            'DataGridView2.Columns("Entklat").DefaultCellStyle.Format = "N2"

            'DataGridView2.Columns("no_kshf").Width = 50
            'DataGridView2.Columns("No_55").Width = 50
            'DataGridView2.Columns("Name_Emp").Width = 250
            'DataGridView2.Columns("id_no").Width = 130
            'DataGridView2.Columns("Dayes").Width = 50
            'DataGridView2.Columns("Salary_ass").Width = 80
            'DataGridView2.Columns("Badl_safer").Width = 50
            'DataGridView2.Columns("Entklat").Width = 60
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'msg_lbl.Text = ex.Message.ToString()
        End Try
    End Sub


End Module
