Imports System.Data.OleDb

Public Class Form_print_crstal_total_bnd

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim no_kkk As Integer = 0



            no_kkk = ListBox1.SelectedValue
            If no_kkk > 0 Then
                'Dim no_k As Integer = 0

                'no_k = Max_table_detailes_data_total()
                'SelectSome_Table_all_bnd(no_kshff)

                SelectSome_selcet_all_bnd(no_kkk)



                DataGridView1.DataSource = dt_select_all_bnd_no_kash
                DataGridViewHeaderText_all_bnd(DataGridView1)
                'no_kshff.SelectedValue = no_k

                NumericUpDown1.Value = ListBox1.SelectedValue
                '=============================
                'عدد سطور
                Label21.Text = DataGridView1.Rows.Count.ToString()
                btn_print.Visible = True
                btn_print2.Visible = True
                btn_print3.Visible = True
                btn_print4.Visible = True
                btn_print5.Visible = True
            Else
                MessageBox.Show("لا يوجد ........")

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim no_k As Integer = 0

        no_k = Max_table_detailes_data_total()
        SelectSome_Table_all_bnd(ListBox1)
        SelectSome_selcet_all_bnd(no_k)



        DataGridView1.DataSource = dt_select_all_bnd_no_kash
        DataGridViewHeaderText_all_bnd(DataGridView1)
        ListBox1.SelectedValue = no_k
        '=============================
        'عدد سطور
        Label21.Text = DataGridView1.Rows.Count.ToString()
        btn_print.Visible = True
        btn_print2.Visible = True
        btn_print3.Visible = True
        btn_print4.Visible = True
        btn_print5.Visible = True
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        Try

            Dim daa As New OleDbDataAdapter
            ''Dim reprt As New CrystalReport_all_bnd
            'Dim reprt4 As New CrystalReport_all_bnd
            Dim dv As New DataView
            Dim ds As New DataSet2


            Dim no_kshf As Integer
            no_kshf = NumericUpDown1.Value



            daa = New OleDbDataAdapter("select * from select_all_bnd3 where no_of_kashf = " & no_kshf & "  ", con)
            daa.Fill(ds, "select_all_bnd333")
            dv = New DataView(ds.Tables("select_all_bnd333"))
            'reprt.SetDataSource(dv)


            'frm_viewer.CrystalReportViewer1.ReportSource = reprt
            frm_viewer.Show()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_print2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print2.Click
        Try

            Dim daa As New OleDbDataAdapter
            'Dim reprt As New CrystalReport_all_bnd_2
            'Dim reprt4 As New CrystalReport_all_bnd_2
            Dim dv As New DataView
            Dim ds As New DataSet2


            Dim no_kshf As Integer
            no_kshf = NumericUpDown1.Value
            'Dim id_mkf As Integer
            'id_mkf = NumericUpDown2.Value

            'If Label3.Text = "صفحة طباعة اعداديه تقارير" Then
            daa = New OleDbDataAdapter("select * from select_all_bnd3 where no_of_kashf = " & no_kshf & "  ", con)
            daa.Fill(ds, "select_all_bnd333")
            dv = New DataView(ds.Tables("select_all_bnd333"))
            'reprt.SetDataSource(dv)


            'reprt.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
            'reprt.SetParameterValue(1, TextBox2.Text)
            'frm_viewer.CrystalReportViewer1.ReportSource = reprt
            frm_viewer.Show()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_print3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print3.Click
        Try

            Dim daa As New OleDbDataAdapter
            'Dim reprt As New CrystalReport_all_bnd_3
            'Dim reprt4 As New CrystalReport_all_bnd_3
            Dim dv As New DataView
            Dim ds As New DataSet2


            Dim no_kshf As Integer
            no_kshf = NumericUpDown1.Value
            

            daa = New OleDbDataAdapter("select * from select_all_bnd3 where no_of_kashf = " & no_kshf & "  ", con)
            daa.Fill(ds, "select_all_bnd333")
            dv = New DataView(ds.Tables("select_all_bnd333"))
            'reprt.SetDataSource(dv)


            'reprt.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
            'reprt.SetParameterValue(1, TextBox2.Text)
            'frm_viewer.CrystalReportViewer1.ReportSource = reprt
            frm_viewer.Show()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print4.Click
        Try

            Dim daa As New OleDbDataAdapter
            'Dim reprt As New CrystalReport_all_bnd_4
            'Dim reprt4 As New CrystalReport_all_bnd_4
            Dim dv As New DataView
            Dim ds As New DataSet2


            Dim no_kshf As Integer
            no_kshf = NumericUpDown1.Value

            daa = New OleDbDataAdapter("select * from select_all_bnd3 where no_of_kashf = " & no_kshf & "  ", con)
            daa.Fill(ds, "select_all_bnd333")
            dv = New DataView(ds.Tables("select_all_bnd333"))
            'reprt.SetDataSource(dv)


            'reprt.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
            'reprt.SetParameterValue(1, TextBox2.Text)
            'frm_viewer.CrystalReportViewer1.ReportSource = reprt
            frm_viewer.Show()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print5.Click
        Try

            Dim daa As New OleDbDataAdapter
            'Dim reprt As New CrystalReport_all_bnd_5
            'Dim reprt4 As New CrystalReport_all_bnd_5
            Dim dv As New DataView
            Dim ds As New DataSet2


            Dim no_kshf As Integer
            no_kshf = NumericUpDown1.Value




            daa = New OleDbDataAdapter("select * from select_all_bnd3 where no_of_kashf = " & no_kshf & "  ", con)
            daa.Fill(ds, "select_all_bnd333")
            dv = New DataView(ds.Tables("select_all_bnd333"))
            'reprt.SetDataSource(dv)


          
            ''frm_viewer.CrystalReportViewer1.ReportSource = reprt
            frm_viewer.Show()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Btn_tot_report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_tot_report.Click
        Try

            Dim daa As New OleDbDataAdapter
            'Dim reprt As New CrystalReport_total_all_bnd
            'Dim reprt4 As New CrystalReport_total_all_bnd
            Dim dv As New DataView
            Dim ds As New DataSet2


            Dim no_kshf As Integer
            no_kshf = NumericUpDown1.Value
            'Dim id_mkf As Integer
            'id_mkf = NumericUpDown2.Value

            'If Label3.Text = "صفحة طباعة اعداديه تقارير" Then
            daa = New OleDbDataAdapter("select * from select_all_bnd3 where no_of_kashf = " & no_kshf & "  ", con)
            daa.Fill(ds, "select_all_bnd333")
            dv = New DataView(ds.Tables("select_all_bnd333"))
            'reprt.SetDataSource(dv)


            'reprt.SetParameterValue(0, "كشف مكافاة امتحانات  " & TextBox1.Text & " " & "الدور " & "  " & TextBox4.Text & "  " & TextBox3.Text)
            'reprt.SetParameterValue(1, TextBox2.Text)
            'frm_viewer.CrystalReportViewer1.ReportSource = reprt
            frm_viewer.Show()

        Catch ex As Exception

        End Try



    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        Try
            Dim no_kkk As Integer = 0



            no_kkk = ListBox1.SelectedValue
            If no_kkk > 0 Then
                'Dim no_k As Integer = 0

                'no_k = Max_table_detailes_data_total()
                'SelectSome_Table_all_bnd(no_kshff)

                SelectSome_selcet_all_bnd(no_kkk)



                DataGridView1.DataSource = dt_select_all_bnd_no_kash
                DataGridViewHeaderText_all_bnd(DataGridView1)
                'no_kshff.SelectedValue = no_k

                NumericUpDown1.Value = ListBox1.SelectedValue
                '=============================
                'عدد سطور
                Label21.Text = DataGridView1.Rows.Count.ToString()
            Else
                MessageBox.Show("لا يوجد ........")

            End If
        Catch ex As Exception

        End Try



      



       

    End Sub
End Class