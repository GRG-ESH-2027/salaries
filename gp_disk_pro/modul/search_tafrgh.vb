Imports System.Data.OleDb

Module searghch_tafrgh

    'search_by_name
    'Public dt_select_by_name As New DataTable
    'Public Sub select__by_name(ByVal by_name As String)
    '    dt_select_by_name.Clear()
    '    Dim Cmd As New OleDbCommand("select * from Table_mkf_add where Name_Emp = @Name_Emp", con)
    '    With Cmd
    '        .Connection = con
    '        con.Open()
    '        .Parameters.Clear()
    '        .Parameters.AddWithValue("@Name_Emp", OleDbType.VarChar).Value = by_name
    '        dt_select_by_name.Load(Cmd.ExecuteReader)

    '    End With
    '    con.Close()
    '    Cmd = Nothing
    'End Sub
    'delete mkf
    'delete _mkf_tfrgh
    '============================================
    '======load_some_importer
    Public dt_select_by_name As New DataTable
    Public Sub select__by_name(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_select_by_name.Clear()
        'da = New OleDbDataAdapter("select * from Table_mkf_add ORDER BY no_kshf,Name_Emp", con)

        da = New OleDbDataAdapter("SELECT *  FROM Table_mkf_add ORDER BY no_kshf", con)


        da.Fill(dt_select_by_name)
        dgv.DataSource = dt_select_by_name
    End Sub





End Module
