Imports System.Data.OleDb

Module export_data_base_Module
    Public dt_select_data_base As New DataTable
    Public Sub select_data_base(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_select_data_base.Clear()
        da = New OleDbDataAdapter("select *  from Table_mkf_add ORDER BY no_kshf,Name_Emp", con2)
        da.Fill(dt_select_data_base)
        dgv.DataSource = dt_select_data_base
    End Sub

End Module
