Imports System.Data.OleDb

Public Class ndb_frm_all_excel_upload
    Public dt_excel As New System.Data.DataTable
    Public ds As New DataSet()
    Public num_Row As Integer = 0
    Public num_erro As Integer = 0
    Public mkf_count As Double = 0
    '========================
    Public Sub new_and_clear_data_ndb()
        If dgv_Table_add_tfrgh.Rows.Count > 1 Then


            dgv_Table_add_tfrgh.Rows.Clear()
            ds.Tables.Remove("tbl")

            'ListBox1.Items.Clear()
            'Button1.Visible = False
            btn_add.Visible = False
            'd2.Visible = False
            'ListBox1.Visible = False
        End If

    End Sub
    '===============
    Private Sub open_file_Click(sender As Object, e As EventArgs) Handles open_file.Click
  


        Try
            System.Windows.Forms.Application.DoEvents()
            new_and_clear_data_ndb()

            Dim source_path, destpasth As String
            Dim ofd As New OpenFileDialog



            destpasth = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

            ofd.Filter = "Excel xls |*.xls ;*.xlsx"
            If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                source_path = ofd.FileName
                name_empp.Text = source_path
                'dt_gp_table.Clear(


                Dim con As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;  Data Source=" + ofd.FileName + "; Extended properties=Excel 12.0;")

                dt_excel.Clear()
                Dim cmd As New OleDbCommand("select * from [Sheet1$]", con)
                'Dim cmd As New OleDbDataAdapter("select * from [Sheet1$]", con)

                cmd.Connection = con

                con.Open()
                dt_excel.Load(cmd.ExecuteReader)
                '=====================
                'ملا dataset من جدول البيانات 
                Using sdr As OleDbDataReader = cmd.ExecuteReader()
                    ds.Tables.Add("tbl")

                    ds.Tables(0).Load(sdr)
                End Using
                '"=================================


                '=================================
                con.Close()
                For i = 0 To dt_excel.Rows.Count - 1
                    num_Row = i
                    Dim id_num As Integer = 0

                    id_num = add_ndb_frm.Max_nadb() + 1 + i

                    Dim id As String
                    id = Convert.ToString(id_num) + (Form1.ToolStripStatusLabel2).ToString()
                    '==========
                    'Dim id_user As String
                    'id_user = Form1.ToolStripStatusLabel3.Text
                    ''=========
                    Dim date_1 As DateTime
                    date_1 = Today()

                    date_1 = dt_excel.Rows(i).Item(3)
                    Dim day, m, y, ful_date As String
                    day = date_1.Day().ToString()
                    m = date_1.Month().ToString()
                    y = date_1.Year().ToString()
                    ful_date = day + "/" + m + "/" + y

                    dgv_Table_add_tfrgh.Rows.Add(id_num, dt_excel.Rows(i).Item(0).ToString(), dt_excel.Rows(i).Item(1).ToString(), dt_excel.Rows(i).Item(2).ToString(), date_1, dt_excel.Rows(i).Item(4).ToString(), dt_excel.Rows(i).Item(5).ToString())
                Next

                'd1.DataSource = dt_excel
                count_lbl.Text = dt_excel.Rows.Count.ToString()
                btn_add.Visible = True
                'format_datagridview(d1)
                'Button1.Visible = True
                'Button6.Visible = True

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'If MessageBox.Show(ex.Message) = Windows.Forms.DialogResult.OK Then

            '    message_erro = "بالرجاء التاكد من السطر رقم " + num_Row.ToString()
            '    'ListBox1.Items.Add(message_erro)
            '    MessageBox.Show("بالرجاء التاكد من السطر رقم " + num_Row.ToString())
            '    num_erro += 1

            'End If
            'MessageBox.Show("ملف خطا ...!")
            MessageBox.Show(ex.Message)
        End Try
        If BackgroundWorker2.IsBusy Then

        Else


            BackgroundWorker2.RunWorkerAsync()

        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If BackgroundWorker1.IsBusy Then




        Else
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try




            If dgv_Table_add_tfrgh.Rows.Count > 0 Then



                For i = 0 To dgv_Table_add_tfrgh.Rows.Count - 1



                    'select_no_55(Convert.ToInt32(dgv_Table_add_tfrgh.Rows(i).Cells("No_55").Value.ToString()))
                    'If dt_select_no_55.Rows.Count > 0 Then

                    '    MessageBox.Show("رقم 55 ع ح مسجل من قبل يوجد  ...")
                    '    Dim no_55_erro As String
                    '    no_55_erro = "رقم 55 ع ح مسجل من قبل يوجد  ..." + (Convert.ToString(d1.Rows(i).Cells("No_55").Value.ToString()))
                    '    ListBox1.Items.Add(no_55_erro)
                    '    Exit Sub
                    'End If
                    ''ProgressBar1=====================

                    Dim total_s As Double = 0
                    'total_s = (x * 1) / d1.RowCount
                    total_s = i / dgv_Table_add_tfrgh.RowCount
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0) + 1

                    Label4.Invoke(Sub() Label4.Text = "%".ToString() + total_s.ToString())


                    add_ndb_frm.Insert_nadb(Convert.ToInt32(dgv_Table_add_tfrgh.Rows(i).Cells("Column1").Value).ToString(), dgv_Table_add_tfrgh.Rows(i).Cells("Column2").Value.ToString(),
                                                      dgv_Table_add_tfrgh.Rows(i).Cells("Column3").Value.ToString(), dgv_Table_add_tfrgh.Rows(i).Cells("Column4").Value.ToString(),
                                                        dgv_Table_add_tfrgh.Rows(i).Cells("Column5").Value.ToString(), dgv_Table_add_tfrgh.Rows(i).Cells("Column6").Value.ToString(),
                                                        dgv_Table_add_tfrgh.Rows(i).Cells("Column7").Value.ToString())




                Next


                MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
                'new_and_clear_data()

                ''Label3.Text = "100%"
                'lbl_load.Text = "تم التحميل 00000"

            Else
                MsgBox("لا يوجد بيانات كى تضاف", MsgBoxStyle.Information, "تنبيه")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        ''ProgressBar1=====================
        For i = 0 To dt_excel.Rows.Count - 1
            Dim total_s As Double = 0
            'total_s = (x * 1) / d1.RowCount
            total_s = i / dt_excel.Rows.Count
            total_s = total_s * 100
            total_s = Math.Round(total_s, 0) + 1

            Label4.Invoke(Sub() Label4.Text = "%".ToString() + total_s.ToString())

        Next
    End Sub


   
End Class