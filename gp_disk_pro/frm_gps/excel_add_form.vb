Imports System.Data.OleDb

Public Class excel_add_form
    Dim lst As New List(Of String)
    Dim lst2 As New List(Of String)
    Dim lst3 As New List(Of String)

    Public dt_excel As New System.Data.DataTable
    Public ds As New DataSet()
    Public mkf_count As Double = 0
    Public n As Integer
    Public num_erro As Integer = 0
    Public message_erro As String
    Public num_Row As Integer = 0
    Public id_Mkff As Integer = 1
    '========================
    Public Sub new_and_clear_data()
        If d1.Rows.Count > 1 Then


            d1.Rows.Clear()
            ds.Tables.Remove("tbl")
            d2.Rows.Clear()
            ListBox1.Items.Clear()
            Button1.Visible = False
            Button2.Visible = False
            d2.Visible = False
            ListBox1.Visible = False
        End If
    End Sub
    '===========================
    Private Function Getcount(n As String) As Integer
        Dim co As Integer = 0
        Dim i As Integer
        For i = 0 To d1.Rows.Count - IIf(d1.AllowUserToAddRows, 2, 1)
            Dim t As String = d1.Rows(i).Cells("op_id_no").Value
            If t = n Then
                co += 1
            End If
        Next
        Return co
    End Function
    '=================================
    Private Function Getcount_num(n As String) As Integer
        Dim co As Integer = 0
        Dim i As Integer
        For i = 0 To d1.Rows.Count - IIf(d1.AllowUserToAddRows, 2, 1)
            Dim t As String = d1.Rows(i).Cells("No_55").Value
            If t = n Then
                co += 1
              

            End If
        Next
    
        Return co
 
    End Function

    '================================


    '====================================


    Public Sub format_datagridview(datgridv As DataGridView)

        If datgridv.Rows.Count >= 8 Then
            For i As Integer = 0 To datgridv.Rows.Count - 6


                'i += 1

                datgridv.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                i += 1
                datgridv.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                i += 1
                datgridv.Rows(i).DefaultCellStyle.BackColor = Color.Orange
                i += 1
                datgridv.Rows(i).DefaultCellStyle.BackColor = Color.Orange

            Next


        End If

        datgridv.Columns("no_kshf").DefaultCellStyle.Format = "N0"
        datgridv.Columns("Salary_ass").DefaultCellStyle.Format = "N2"
        datgridv.Columns("Mkf").DefaultCellStyle.Format = "N2"
        'datgridv.Columns("mkf_2").DefaultCellStyle.Format = "N2"
        datgridv.Columns("total").DefaultCellStyle.Format = "N2"
        datgridv.Columns("Total_Mostkta").DefaultCellStyle.Format = "N2"
        datgridv.Columns("Saffy").DefaultCellStyle.Format = "N2"
        datgridv.Columns("Darabb").DefaultCellStyle.Format = "N2"
        datgridv.Columns("Damghh").DefaultCellStyle.Format = "N2"
        datgridv.Columns("box20").DefaultCellStyle.Format = "N2"
        datgridv.Columns("Total_Mostkta").DefaultCellStyle.Format = "N2"

        datgridv.Columns("no_kshf").Width = 50
        datgridv.Columns("No_55").Width = 50
        datgridv.Columns("Name_Emp").Width = 250
        datgridv.Columns("op_id_no").Width = 150
        datgridv.Columns("Dayes").Width = 50
        datgridv.Columns("Salary_ass").Width = 80

        datgridv.Columns("Mkf").Width = 70
        datgridv.Columns("total").Width = 80
        datgridv.Columns("Darabb").Width = 70
        datgridv.Columns("Damghh").Width = 80
        datgridv.Columns("box20").Width = 80
        datgridv.Columns("Total_Mostkta").Width = 80
        datgridv.Columns("Saffy").Width = 90
    End Sub

    Private Sub excel_add_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        format_datagridview(d1)
    End Sub

    Private Sub open_file_Click(sender As Object, e As EventArgs) Handles open_file.Click
        System.Windows.Forms.Application.DoEvents()
        ListBox1.Visible = True

        Try

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
                    Dim mkf As Double = 0

                    num_Row = i
                    Dim mkf_str As String
                    mkf_str = dt_excel.Rows(i).Item(2).ToString()
                    If mkf_str Is Nothing Or mkf_str = "" Then

                        'message_erro = "بالرجاء التاكد من المرتب وعدد الايام فى السطر رقم " + Convert.ToString(i + 2)
                        'ListBox1.Items.Add(message_erro)
                        MessageBox.Show("بالرجاء التاكد من المرتب وعدد الايام فى السطر رقم " + Convert.ToString(i + 2))
                        num_erro += 1
                        mkf_str = "0"
                        'Exit Sub
                    Else
                        mkf = Convert.ToDouble(mkf_str)
                        mkf = Convert.ToDouble(dt_excel.Rows(i).Item(2))
                        If mkf_count = 5 Then

                            mkf = Math.Floor(Convert.ToInt32(dt_excel.Rows(i).Item(3)))


                            mkf = Convert.ToDouble(dt_excel.Rows(i).Item(2))

                            mkf = Math.Floor(mkf * 0.05 * Convert.ToInt32(dt_excel.Rows(i).Item(3)))
                        Else
                            mkf = mkf * mkf_count / 100
                            mkf = Math.Floor(mkf * Convert.ToInt32(dt_excel.Rows(i).Item(3)))
                        End If
                     
                    End If


                    Dim total As Double = 0
                    total = mkf
                    Dim drab As Double = 0
                    drab = Math.Round((total * 3) / 100, 1, MidpointRounding.AwayFromZero)
                    Dim damgh As Double = 0

                    If total >= 50 Then
                        damgh = Math.Round((total * 0.7) / 100, 1)
                    Else
                        damgh = 0
                    End If
                    Dim box_20 As Double = 0
                    box_20 = Math.Round((total * 20) / 100, 1)
                    Dim total_mostkta = 0
                    total_mostkta = total - (drab + damgh + box_20)
                    ''dt_excel.Rows(i).Item(10) = total_mostkta.ToString()

                    Dim saffy As Double = 0
                    Dim Saffy_after_antkal As Double = 0
                    saffy = total - total_mostkta
                    Saffy_after_antkal = mkf - (drab + damgh + box_20)



                    If saffy <= 0 Then
                        Dim message_erro_saffy As String
                        message_erro_saffy = "بالرجاء التاكد من الصافى فى السطر رقم " + Convert.ToString(i + 2)
                        ListBox1.Items.Add(message_erro_saffy)
                        num_erro += 1
                        ''dt_excel.Rows(i).Item(11) = saffy.ToString()

                        'dt_excel.Rows(i).Item(12) = Saffy_after_antkal.ToString()
                    End If


                    Dim no_kashff As Integer
                    Dim num_pag As Integer
                    Dim start_pag As Integer = 19
                    'num_pag = start_pag

                    If i >= num_pag + start_pag Then
                        no_kashff += 1
                        num_pag = num_pag + 19
                        start_pag = 0

                    End If
                    '===

                    Dim id_num As Integer = 0

                    id_num = Max_Table_mkf_add() + i

                    Dim id As String
                    id = Convert.ToString(id_num) + (Form1.ToolStripStatusLabel2).ToString()
                    '==========
                    Dim id_user As String
                    id_user = Form1.ToolStripStatusLabel3.Text
                    '=========



                    d1.Rows.Add(dt_excel.Rows(i).Item(0).ToString, dt_excel.Rows(i).Item(1).ToString, dt_excel.Rows(i).Item(2).ToString, dt_excel.Rows(i).Item(3).ToString, dt_excel.Rows(i).Item(4).ToString, mkf, total, drab, damgh, box_20, saffy, total_mostkta, Saffy_after_antkal, no_kashff, id, id_user, id_Mkff, id_num, dt_excel.Rows(i).Item(5).ToString)
                Next

                'd1.DataSource = dt_excel
                Label4.Text = dt_excel.Rows.Count.ToString()
                format_datagridview(d1)
                Button1.Visible = True
                Button6.Visible = True

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
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If BackgroundWorker1.IsBusy Then




        Else
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        d2.Visible = True
        d2.Rows.Clear()
        lst.Clear()
        lst2.Clear()
        lst3.Clear()
        Dim i As Integer

        For i = 0 To d1.Rows.Count - IIf(d1.AllowUserToAddRows, 2, 1)
            Dim t As String = d1.Rows(i).Cells("op_id_no").Value.ToString

            Dim c As Integer = Getcount(t)


            If c > 1 Then
                If lst.Contains(t) = False Then
                    lst.Add(t)
                    lst2.Add(c)

                    lst3.Add(t + "  " + "الرقم القومى مكرر")
                End If

            End If


        Next


        Dim x As Integer

        For x = 0 To d1.Rows.Count - IIf(d1.AllowUserToAddRows, 2, 1)

            Dim num As String = d1.Rows(x).Cells("No_55").Value.ToString

            n = Getcount_num(num)

            If n > 1 Then
                If lst.Contains(num) = False Then

                    lst.Add(num)
                    lst2.Add(n)

                    lst3.Add(num + "  " + "رقم 55 ع ح مكرر")
                    Dim messg_erro As String
                    messg_erro = "رقم 55 ع ح مكرر " + num
                    ListBox1.Items.Add(messg_erro)

                    num_erro += num
                   
                Else

                End If

          
            End If





        Next



        '====================================

        Dim m As Integer
        For m = 0 To lst.Count - 1
            Dim v As String = lst(m).ToString
            Dim mc As String = lst2(m).ToString
            Dim dc As String = lst3(m).ToString

            d2.Rows.Add(v, mc, dc)
        Next
        '===============================================================
        'التحقق من عدم تكرار رقم 55 ع ح
        MessageBox.Show(Convert.ToString(num_erro))
        If num_erro >= 1 Then
            Button2.Visible = False
            num_erro = 0
        Else
            Button2.Visible = True
            num_erro = 0
        End If

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
         


            'Button2.Enabled = False
            If d1.Rows.Count > 0 Then


                'For i = 0 To dt_excel.Rows.Count - 1
                For i = 0 To d1.Rows.Count - 1
                    'Public Sub Insert_Table_mkf_add_speed_shorta(ByVal id_and_user_tfg As String, ByVal No_55 As Integer,
                    '        ByVal no_kshf As Integer, ByVal Name_Emp As String,
                    '         ByVal Salary_ass As Double,
                    '        ByVal Dayes As Integer, ByVal Mkf As Double, ByVal total As Double, ByVal Darabb As Double, ByVal Damghh As Double, ByVal box20 As Double,
                    '        ByVal Total_Mostkta As Double, ByVal Saffy As Double,
                    '        ByVal Id_Mkf As Integer,
                    '        ByVal id_no As String,
                    '      ByVal id_user As Integer)


                    'MessageBox.Show(ds.Tables(0).Rows(i).Item(0).ToString() + "")
                    select_no_55(Convert.ToInt32(d1.Rows(i).Cells("No_55").Value.ToString()))
                    If dt_select_no_55.Rows.Count > 0 Then

                        MessageBox.Show("رقم 55 ع ح مسجل من قبل يوجد  ...")
                        Dim no_55_erro As String
                        no_55_erro = "رقم 55 ع ح مسجل من قبل يوجد  ..." + (Convert.ToString(d1.Rows(i).Cells("No_55").Value.ToString()))
                        ListBox1.Items.Add(no_55_erro)
                        Exit Sub
                    End If
                    ''ProgressBar1=====================

                    Dim total_s As Double = 0
                    'total_s = (x * 1) / d1.RowCount
                    total_s = i / d1.RowCount
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0) + 1

                    Label3.Invoke(Sub() Label3.Text = "%".ToString() + total_s.ToString())


                    Insert_Table_mkf_add_speed_shorta(d1.Rows(i).Cells("id_and_user_tfg").Value.ToString(), Convert.ToInt32(d1.Rows(i).Cells("No_55").Value.ToString()), Convert.ToInt32(d1.Rows(i).Cells("no_kshf").Value.ToString()),
                                                      d1.Rows(i).Cells("Name_Emp").Value.ToString(), Convert.ToDouble(d1.Rows(i).Cells("Salary_ass").Value.ToString()), Convert.ToInt32(d1.Rows(i).Cells("Dayes").Value.ToString()), Convert.ToDouble(d1.Rows(i).Cells("Mkf").Value.ToString()),
                  Convert.ToDouble(d1.Rows(i).Cells("total").Value.ToString()), Convert.ToDouble(d1.Rows(i).Cells("Darabb").Value.ToString()), Convert.ToDouble(d1.Rows(i).Cells("Damghh").Value.ToString()), Convert.ToDouble(d1.Rows(i).Cells("box20").Value.ToString()), Convert.ToDouble(d1.Rows(i).Cells("Total_Mostkta").Value.ToString()), Convert.ToDouble(d1.Rows(i).Cells("Saffy").Value.ToString()), Convert.ToDouble(d1.Rows(i).Cells("Saffy").Value.ToString()),
                                                     Convert.ToInt32(d1.Rows(i).Cells("Id_Mkf").Value.ToString()), d1.Rows(i).Cells("op_id_no").Value.ToString(), Convert.ToInt32(d1.Rows(i).Cells("id_user").Value.ToString()), Convert.ToInt32(d1.Rows(i).Cells("id").Value.ToString()), d1.Rows(i).Cells("Name_school").Value.ToString())




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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    
 
        Dim source_path, destpasth As String
        'source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\page_tfrgh.xls"
        source_path = ((Application.StartupPath) & "\DATABASE\شرطه.xlsx ")

        destpasth = (Application.StartupPath) & "\شرطه.xlsx"

        If My.Computer.FileSystem.FileExists(destpasth) = True Then
            My.Computer.FileSystem.DeleteFile(destpasth)
            My.Computer.FileSystem.CopyFile(source_path, destpasth)
            'MessageBox.Show("تم نسخ قاعدة بيانات")
        Else
            My.Computer.FileSystem.CopyFile(source_path, destpasth)

        End If
        Process.Start((Application.StartupPath) & "\شرطه.xlsx")


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        new_and_clear_data()

    End Sub

   
   
   
End Class