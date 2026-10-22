Imports System.Data.OleDb

Module Module_repot_add

    Public dt_total_day_addy As New DataTable

    Public Sub SelectAll_total_day_addy(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_total_day_addy.Clear()
        da = New OleDbDataAdapter("select * from total_day_addy", con)
        da.Fill(dt_total_day_addy)
        Form_report_day.dgv_gp_table.DataSource = dt_total_day_addy
    End Sub
    Public DT_SEARCH As New DataTable()
    Public Sub SEARCH2DATE(ByVal date1 As DateTime, ByVal date12 As DateTime)
        DT_SEARCH.clear()
        Dim CMDSEARCH As New OleDbCommand(" select * from gp_table WHERE date1 >= @date1 AND date1 <= @date12", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date1", OleDbType.Date).Value = "#" & date1 & "#"
        CMDSEARCH.Parameters.Add("@date12", OleDbType.Date).Value = "#" & date12 & "#"
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            DT_SEARCH.Load(CMDSEARCH.ExecuteReader)
            Con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub
    'with dgv
    Public Sub DataGridViewHeaderwithh(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("id").Width = 60
                .Columns("date1").Width = 80
                .Columns("descr").Width = 120
                .Columns("no_file").Width = 120
                .Columns("el_mablgh").Width = 100
                .Columns("no_gp").Width = 100
                .Columns("date_assthkk").Width = 40
                .Columns("no_shatb").Width = 60
                .Columns("id_desc").Width = 20
            End With
        End If
    End Sub
    'total manth
    Public dt_total_manth As New DataTable
    Public Sub SelectAll_total_manth(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_total_manth.Clear()
        da = New OleDbDataAdapter("select * from total_manth", con)
        da.Fill(dt_total_manth)
        dgv.DataSource = dt_total_manth
    End Sub

End Module
