Public Class Form_all_gps

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim dv As DataView = DT_SEARCH.DefaultView
            dv.RowFilter = " descr LIKE '%" & TextBox1.Text & "%' "
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form_all_gps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SelectAll_gp_table(dgv_gp_table)
    
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SEARCH2DATE(DateTimePicker1.Value, DateTimePicker2.Value)
        'dgv_gp_table.DataSource = DT_SEARCH
        'DataGridViewHeaderwith(dgv_gp_table)
        'DataGridViewHeaderText(dgv_gp_table)

        Try
            DT_SEARCH.Clear()
            SEARCH2DATE(DateTimePicker1.Value, DateTimePicker2.Value)
            dgv_gp_table.DataSource = DT_SEARCH
            'DataGridViewHeaderwith(dgv_gp_table)
            DataGridViewHeaderText(dgv_gp_table)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        'Try
        '    SEARCH2DATE(DateTimePicker1.Value, DateTimePicker2.Value)
        '    dgv_gp_table.DataSource = DT_SEARCH

        '    DataGridViewHeaderText(dgv_gp_table)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            SEARCH2DATE(DateTimePicker1.Value, DateTimePicker2.Value)
            dgv_gp_table.DataSource = DT_SEARCH
            'DataGridViewHeaderwith(dgv_gp_table)
            DataGridViewHeaderText(dgv_gp_table)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DateTimePicker2_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
End Class