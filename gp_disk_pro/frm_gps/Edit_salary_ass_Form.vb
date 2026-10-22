Imports System.Data.OleDb

Public Class Edit_salary_ass_Form

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
    Public dt As New DataTable
    Public dt_add_new_data As New DataTable
    Private Function Getcount(ByVal n As String) As Integer
        Dim co As Integer = 0
        Dim i As Integer
        For i = 0 To d1.Rows.Count - IIf(d1.AllowUserToAddRows, 2, 1)
            Dim t As String = d1.Rows(i).Cells(0).Value
            If t = n Then
                co += 1
            End If
        Next
        Return co
    End Function
    '===========================
    'اخذ البيانات من دات جرد واضافة فى جدول خارجى
    Public dtlocal As New DataTable
    Private Function GetDatatable()
        'انشاء اعمدة جدول خارجى 
        dtlocal.Columns.Add("d1", GetType(String))
        dtlocal.Columns.Add("d2", GetType(String))
        dtlocal.Columns.Add("d3", GetType(Double))

        Dim drlocal As DataRow
        drlocal = Nothing
        For Each dr As DataGridViewRow In d1.Rows
            drlocal = dtlocal.NewRow
            drlocal("d1") = dr.Cells(0).Value
            drlocal("d2") = dr.Cells(1).Value
            drlocal("d3") = dr.Cells(2).Value
            dtlocal.Rows.Add(drlocal)
        Next
        Return dtlocal

    End Function
    'التاكد من عدم تكرار الرقم القومى
    '=======================================
    ' select id_emp
    Public dt_select_id_emp_salary_ass As New DataTable
    Public Sub select_id_emp_salary_ass(ByVal id_emp As String)
        dt_select_id_emp_salary_ass.Clear()
        Dim Cmd As New OleDbCommand("select * from salary_ass where id_no = @id_no", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_no", OleDbType.VarChar).Value = id_emp
            dt_select_id_emp_salary_ass.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '=================
    Private Sub open_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles open_file.Click
        'SByte = vbNullm.Windows.Forms.Application.DoEvents()


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

                    Dim num_idd As Double
                    num_Row = i
                    Dim num_id As String
                    num_id = dt_excel.Rows(i).Item(0).ToString()
                    If num_id Is Nothing Or num_id = "" Then
                        Dim message_erro As String
                        message_erro = ("بالرجاء التاكد من الرقم القومى  فى السطر رقم " + Convert.ToString(i + 1))
                        'MessageBox.Show("بالرجاء التاكد من الرقم القومى  فى السطر رقم " + Convert.ToString(i + 1))

                        num_idd = "0"
                        ListBox1.Visible = True
                        ListBox1.Items.Add(message_erro)
                    Else

                        num_idd = Convert.ToDouble(num_id)
                        num_idd = Convert.ToDouble(dt_excel.Rows(i).Item(0))

                    End If


                    Dim salary_ass_str As String

                    salary_ass_str = dt_excel.Rows(i).Item(2).ToString()
                    If salary_ass_str Is Nothing Or salary_ass_str = "" Then
                        Dim message_erro As String

                        message_erro = "بالرجاء التاكد من المرتب  فى السطر رقم " + Convert.ToString(i + 1)

                        'MessageBox.Show("بالرجاء التاكد من المرتب  فى السطر رقم " + Convert.ToString(i + 1))

                        salary_ass_str = "0"
                        ListBox1.Visible = True
                        ListBox1.Items.Add(message_erro)


                    Else
                        Dim salary_ass As Double
                        salary_ass = Convert.ToDouble(salary_ass_str)
                        salary_ass = Convert.ToDouble(dt_excel.Rows(i).Item(2))

                    End If




                    d1.Rows.Add(num_idd, dt_excel.Rows(i).Item(1).ToString, salary_ass_str)
                Next

                'd1.DataSource = dt_excel
                Label4.Text = dt_excel.Rows.Count.ToString()
                'format_datagridview(d1)
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

    Private Sub Edit_salary_ass_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub d1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles d1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num_id As String

        For i = 0 To dt_excel.Rows.Count - 1
            num_id = dt_excel.Rows(i).Item(0).ToString()

            Dim c As Integer = Getcount(num_id)

            If c > 1 Then
                d1.Rows(i).DefaultCellStyle.BackColor = Color.Red
                Button3.Enabled = False
            Else

                d1.Rows(i).DefaultCellStyle.BackColor = Color.SkyBlue
                Button3.Enabled = True

            End If
        Next

        '========================
        'd2.Visible = True
        'd2.Rows.Clear()
        'lst.Clear()
        '    'lst2.Clear()
        '    lst3.Clear()
        '    Dim i As Integer

        '    'For i = 0 To d1.Rows.Count - IIf(d1.AllowUserToAddRows, 2, 1)
        '    '    Dim t As String = d1.Rows(i).Cells("op_id_no").Value.ToString

        '    'Dim c As Integer = Getcount(t)


        '    '    If c > 1 Then
        '    '        If lst.Contains(t) = False Then
        '    '            lst.Add(t)
        '    '            lst2.Add(c)

        '    '            lst3.Add(t + "  " + "الرقم القومى مكرر")
        '    '        End If

        '    '    End If


        '    'Next


        '    Dim x As Integer

        '    For x = 0 To d1.Rows.Count - IIf(d1.AllowUserToAddRows, 2, 1)

        '        Dim num As String = d1.Rows(x).Cells("No_55").Value.ToString

        '        'n = Getcount_num(num)

        '        If n > 1 Then
        '            If lst.Contains(num) = False Then

        '                lst.Add(num)
        '                lst2.Add(n)

        '                lst3.Add(num + "  " + "رقم 55 ع ح مكرر")
        '                Dim messg_erro As String
        '                messg_erro = "رقم 55 ع ح مكرر " + num
        '                ListBox1.Items.Add(messg_erro)

        '                num_erro += num

        '            Else

        '            End If


        '        End If





        '    Next



        '    '====================================

        '    Dim m As Integer
        '    For m = 0 To lst.Count - 1
        '        Dim v As String = lst(m).ToString
        '        Dim mc As String = lst2(m).ToString
        '        Dim dc As String = lst3(m).ToString

        '        'd2.Rows.Add(v, mc, dc)
        '    Next
        '    '===============================================================
        '    'التحقق من عدم تكرار رقم 55 ع ح
        '    MessageBox.Show(Convert.ToString(num_erro))
        '    If num_erro >= 1 Then
        '        Button2.Visible = False
        '        num_erro = 0
        '    Else
        '        Button2.Visible = True
        '        num_erro = 0
        '    End If
        'End Sub

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try


            If d1.Rows.Count > 0 Then
                For i = 0 To d1.Rows.Count - 1

                    ''ProgressBar1=====================

                    Dim total_s As Double = 0
                    'total_s = (x * 1) / d1.RowCount
                    total_s = i / d1.RowCount
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0) + 1

                    Label3.Invoke(Sub() Label3.Text = "%".ToString() + total_s.ToString())



                    Update_salary_ass_old(d1.Rows(i).Cells(0).Value.ToString(), d1.Rows(i).Cells(2).Value.ToString(), DateTimePicker1.Value.Date.ToString())


                Next
                MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
                d1.DataSource = Nothing
                d1.Rows.Clear()
                ListBox1.Items.Clear()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim source_path, destpasth As String
            'source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\page_tfrgh.xls"
            source_path = ((Application.StartupPath) & "\DATABASE\الاساسى الجديد.xlsx ")

            destpasth = (Application.StartupPath) & "\الاساسى الجديد.xlsx"

            If My.Computer.FileSystem.FileExists(destpasth) = True Then
                My.Computer.FileSystem.DeleteFile(destpasth)
                My.Computer.FileSystem.CopyFile(source_path, destpasth)
                'MessageBox.Show("تم نسخ قاعدة بيانات")
            Else
                My.Computer.FileSystem.CopyFile(source_path, destpasth)

            End If
            Process.Start((Application.StartupPath) & "\الاساسى الجديد.xlsx")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Button3.Enabled = False
        'اخذ البيانات من دات الجرد وضعه فى جدول موقت
        GetDatatable()
        'انشاء جدول لتخزين البيانات الغير مسجله فى قاعدة البيانات
        dt.Columns.Add("d11", GetType(String))
        dt.Columns.Add("d22", GetType(String))
        dt.Columns.Add("d33", GetType(Double))
        'انشاء جدول لتخزين البيانات  المسجله فى قاعدة البيانات من قبل لتعديلها
        dt_add_new_data.Columns.Add("d1", GetType(String))
        dt_add_new_data.Columns.Add("d2", GetType(String))
        dt_add_new_data.Columns.Add("d3", GetType(Double))

        For Each row As DataRow In dtlocal.Rows
            ''ProgressBar1=====================

            Dim total_s As Double = 0
            'total_s = (x * 1) / d1.RowCount
            Dim n As Integer
            n += 1
            total_s = n / dtlocal.Rows.Count
            total_s = total_s * 100
            total_s = Math.Round(total_s, 0) + 1

            Label3.Invoke(Sub() Label3.Text = "%".ToString() + total_s.ToString() + " فحص البيانات ")
            '=====================
            Dim id_no As String
            Dim nameEmp As String
            Dim salary_ass As Double
            id_no = row.Item("d1").ToString()
            nameEmp = row.Item("d2").ToString()
            salary_ass = row.Item("d3").ToString()

            'البحث عن البيانات المسجله من قبل 
            select_id_emp_salary_ass(id_no)

            If dt_select_id_emp_salary_ass.Rows.Count > 0 Then
                ' القديمه لتعديل البيانات جدول
                Dim row2 As DataRow
                row2 = dt_add_new_data.NewRow

                row2(0) = id_no
                row2(1) = nameEmp
                row2(2) = salary_ass

                dt_add_new_data.Rows.Add(row2)

            Else
                'لاضافة البيانات الجديده جدول
                Dim row1 As DataRow
                row1 = dt.NewRow
                Dim count As Integer
                count += 1
                row1(0) = id_no
                row1(1) = nameEmp
                row1(2) = salary_ass

                dt.Rows.Add(row1)


            End If
        Next
        '==========================================
        'اضافة البيانات ال اول مرة تسجل فى قاعدة البيانات
        For i = 0 To dt.Rows.Count - 1

            ''ProgressBar1=====================

            Dim total_s As Double = 0
            'total_s = (x * 1) / d1.RowCount
            total_s = i / dt.Rows.Count
            total_s = total_s * 100
            total_s = Math.Round(total_s, 0) + 1

            Label3.Invoke(Sub() Label3.Text = "%".ToString() + total_s.ToString() + " اضافة")
            Dim salary_new, saffy, drab As New Double
            salary_new = 0
            saffy = 0
            drab = 10
            ''Insert_salary_ass(ByVal id_no As String, ByVal salary_old As Double, ByVal salary_new As Double, ByVal salary_safy As Double, ByVal Drab As Double)

            '===================================id_no==============================salary_old=============================salary_new==============saffy==================================================drab
            Insert_salary_ass(dt.Rows(i).Item(0).ToString(), dt.Rows(i).Item(2).ToString(), salary_new, saffy, drab)



        Next


        '==========================================
        'تعديل البيانات ال اول مرة تسجل فى قاعدة البيانات

        For i = 0 To dt_add_new_data.Rows.Count - 1

            ''ProgressBar1=====================

            Dim total_s As Double = 0
            'total_s = (x * 1) / d1.RowCount
            total_s = i / dt_add_new_data.Rows.Count
            total_s = total_s * 100
            total_s = Math.Round(total_s, 0) + 1

            Label3.Invoke(Sub() Label3.Text = "%".ToString() + total_s.ToString() + " تعديل ")


            Update_salary_ass_old(dt_add_new_data.Rows(i).Item(0).ToString(), dt_add_new_data.Rows(i).Item(2), DateTimePicker1.Value.Date.ToString())


        Next

        dt.Clear()
        'ListBox1.Items.Clear()
        MsgBox("تم الاضافة السجل بنجاح", MsgBoxStyle.Information, "اضافة")
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        dt_add_new_data.Clear()
        'ListBox1.Items.Clear()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If BackgroundWorker1.IsBusy Then


        Else
            BackgroundWorker1.RunWorkerAsync()

        End If



    End Sub
End Class