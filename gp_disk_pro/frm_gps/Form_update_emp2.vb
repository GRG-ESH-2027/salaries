Imports System.Data.OleDb

Public Class Form_update_emp2
    Public dt_excel As New System.Data.DataTable
    Public ds As New DataSet()


    Private Sub open_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_file.Click
        System.Windows.Forms.Application.DoEvents()
        Try

            Dim source_path, destpasth As String
            Dim ofd As New OpenFileDialog



            destpasth = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))

            ofd.Filter = "Excel xls |*.xls ;*.xlsx"
            If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                source_path = ofd.FileName
                name_emp.Text = source_path
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
                con.Close()
                DataGridView1.DataSource = dt_excel
                Label4.Text = dt_excel.Rows.Count.ToString()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            MessageBox.Show("ملف خطا ...!")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            delete_all_emp()
            btn_update.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        If BackgroundWorker1.IsBusy Then


            lbl_load.Text = "جارى التحميل 00000"

        Else
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub




    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            btn_update.Enabled = False

            If ds.Tables(0).Rows.Count > 0 Then
                'For i = 0 To dt_excel.Rows.Count - 1
                For i = 0 To ds.Tables(0).Rows.Count - 1

                    Insert_emp(ds.Tables(0).Rows(i).Item(0).ToString(), ds.Tables(0).Rows(i).Item(1).ToString(),
                              ds.Tables(0).Rows(i).Item(2).ToString(), ds.Tables(0).Rows(i).Item(3).ToString(),
                              ds.Tables(0).Rows(i).Item(4).ToString(), ds.Tables(0).Rows(i).Item(5).ToString(),
                              ds.Tables(0).Rows(i).Item(6).ToString())
                    'ProgressBar1=====================
                    ProgressBar1.Maximum = ds.Tables(0).Rows.Count
                    ProgressBar1.Value = i
                    Dim total_s As Double = 0
                    total_s = (i * 1) / ds.Tables(0).Rows.Count
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()


                    '============================
                Next

                MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
                Label3.Text = "100%"
                lbl_load.Text = "تم التحميل 00000"
                'dt_auto_no_emp.Clear()
                'DataGridView1.Refresh()
                'Btn_add.Visible = False
            Else
                MsgBox("لا يوجد بيانات كى تضاف", MsgBoxStyle.Information, "تنبيه")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

   




    Private Sub Form_update_emp2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class