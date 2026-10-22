Imports System.Data.OleDb

Public Class Form_report_gps


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try


            Dim daa As New OleDbDataAdapter
            'Dim reprt As New CrystalReport2
            Dim dv As New DataView
            Dim ds As New DataSet1



            If CheckBox1.Checked = False Then

                daa = New OleDbDataAdapter(" SELECT gp_table.date1, gp_table.no_shatb, gp_table.descr, gp_table.el_mablgh, gp_table.no_gp, gp_table.no_file, gp_table.date_assthkk, dec_shatb_table.descr_shatb FROM (gp_table INNER JOIN dec_shatb_table ON gp_table.id_desc = dec_shatb_table.id_desc) WHERE date1 between #" & date1.Value.ToString("yyyy/MM/dd") & "# and #" & DateTimePicker1.Value.ToString("yyyy/MM/dd") & "#", con)
                daa.Fill(ds, "table_gps")
                dv = New DataView(ds.Tables("table_gps"))
                'reprt.SetDataSource(dv)



                'frm_viewer.CrystalReportViewer1.ReportSource = reprt
                frm_viewer.Show()
            Else
                daa = New OleDbDataAdapter(" SELECT gp_table.date1, gp_table.no_shatb, gp_table.descr, gp_table.el_mablgh, gp_table.no_gp, gp_table.no_file, gp_table.date_assthkk, dec_shatb_table.descr_shatb FROM (gp_table INNER JOIN dec_shatb_table ON gp_table.id_desc = dec_shatb_table.id_desc) WHERE date1 between #" & date1.Value.ToString("yyyy/MM/dd") & "# and #" & DateTimePicker1.Value.ToString("yyyy/MM/dd") & "# and  gp_table.id_desc = " & id_desc.SelectedValue & " ", con)
                daa.Fill(ds, "table_gps")
                dv = New DataView(ds.Tables("table_gps"))
                'reprt.SetDataSource(dv)



                'frm_viewer.CrystalReportViewer1.ReportSource = reprt
                frm_viewer.Show()

            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Panel1.Visible = True
        Else
            Panel1.Visible = False
        End If
    End Sub

    Private Sub Form_report_gps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcmb_dec_shatb_table(id_desc)

    End Sub

    Public Sub fillcmb_dec_shatb_table(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New OleDbDataAdapter
        DT.Clear()
        DA = New OleDbDataAdapter("Select * FROM dec_shatb_table ", con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT

            cmb.DisplayMember = "descr_shatb"
            cmb.ValueMember = "id_desc"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub


End Class