Imports System.Data.OleDb


Public Class total_kshf_form


    Public TOAL As Double = 0

    '=============
    Private Sub btn_load_kshf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_kshf.Click
        Dim no_k As Integer
        no_k = Max_no_kshf()

        SelectSome_Table_mkf_add_indirect(no_kshf)
        SelectAll_Table_mkf_no_kshf(no_k)
        no_kshf.SelectedValue = no_k
    End Sub

    Private Sub btn_print_to_excell_total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print_to_excell_total.Click
        btn_print_to_excell_total.Enabled = False
        If BackgroundWorker1.IsBusy Then


            'lbl_load.Text = "جارى التحميل 00000"

        Else
            'lbl_load.Invoke(Sub() lbl_load.Text = "جارى التحميل 00000")
            BackgroundWorker1.RunWorkerAsync()

        End If

        btn_print_to_excell_total.Enabled = True
    End Sub
    Public total_safy As String
    Private currencies As New List(Of NumberToWord.CurrencyInfo)()

    Private Sub number_to_word_UserControl1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        currencies.Add(New NumberToWord.CurrencyInfo(NumberToWord.CurrencyInfo.Currencies.SaudiArabia))
        currencies.Add(New NumberToWord.CurrencyInfo(NumberToWord.CurrencyInfo.Currencies.UAE))
        currencies.Add(New NumberToWord.CurrencyInfo(NumberToWord.CurrencyInfo.Currencies.SaudiArabia))
        currencies.Add(New NumberToWord.CurrencyInfo(NumberToWord.CurrencyInfo.Currencies.Tunisia))
        currencies.Add(New NumberToWord.CurrencyInfo(NumberToWord.CurrencyInfo.Currencies.Gold))

        cboCurrency.DataSource = currencies


        'NumberToWord.cboCurrency_DropDownClosed(Nothing, Nothing)
        txtNumber.Text = NumericUpDown3.Value.ToString()
        txtNumber.Text = Convert.ToString(total_safy)
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim toWord As New NumberToWord.ToWord(Convert.ToDecimal(txtNumber.Text), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
            txtEnglishWord.Text = toWord.ConvertToEnglish()
            txtArabicWord.Text = toWord.ConvertToArabic()
        Catch ex As Exception

            txtEnglishWord.Text = String.Empty
            txtArabicWord.Text = String.Empty
        End Try
        '===========
        Dim xlApp As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Try
            ' تحقق من وجود الملف المصدر
            add_file_tfrgh_total()
            Dim inputFile As String = Application.StartupPath & "\tfrgh_total.xlsx"
            If Not System.IO.File.Exists(inputFile) Then
                MsgBox("ملف التصدير غير موجود: " & inputFile, MsgBoxStyle.Critical)
                Exit Sub
            End If

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(inputFile, [ReadOnly]:=False)
            xlWorkSheet = CType(xlWorkBook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            ' تنشيط الورقة
            xlWorkSheet.Activate()
            xlApp.Visible = False  ' اجعلها True إذا أردت عرض الإكسل للمستخدم

            ' .... بقية الكود كما هو من تعبئة البيانات ....
            '===============


            Dim num_rows As Integer = Convert.ToInt32(txt_num_rows.Text)
            num_rows = (num_tot_end.Value - num_tot_frist.Value)
            If num_rows > 19 Then
                num_tot_end.Invoke(Sub() num_tot_end.Value = num_tot_frist.Value + 19)

            End If
            '===================================================
            If num_tot_frist.Value < 0 Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub

            End If
            If num_tot_end.Value <= 0 Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub
            End If
            If num_tot_end.Value < num_tot_frist.Value Then
                MessageBox.Show("رقم غير صحيح برجاء التاكد من الرقم")

                Exit Sub
            End If


            '===================================================================================

            lbl_load.Invoke(Sub() lbl_load.Text = "جارى التحميل 00000")

            Dim daa As New OleDbDataAdapter
            Dim Cmd As New OleDbDataAdapter("SELECT Table_mkf_add.no_kshf, Sum(Table_mkf_add.Mkf), Sum(Table_mkf_add.Mkf_2), Sum(Table_mkf_add.total), Sum(Table_mkf_add.Dayes), Sum(Table_mkf_add.Darabb), Sum(Table_mkf_add.Mashat), Sum(Table_mkf_add.nkaba), Sum(Table_mkf_add.Mashat8), Sum(Table_mkf_add.Mhann), Sum(Table_mkf_add.Mastshfa), Sum(Table_mkf_add.Damghh), Sum(Table_mkf_add.Earaadta), Sum(Table_mkf_add.box20), Sum(Table_mkf_add.Mzay_t_17_25), Sum(Table_mkf_add.Total_Mostkta), Sum(Table_mkf_add.Saffy), Sum(Table_mkf_add.Badl_safer), Sum(Table_mkf_add.Entklat) FROM Table_mkf_add WHERE no_kshf >= " & num_tot_frist.Value & " AND no_kshf <= " & num_tot_end.Value & " GROUP BY Table_mkf_add.no_kshf", con)


            'Dim inputFile As String = Application.StartupPath & "\tfrgh_total.xls"
            xlWorkBook = xlApp.Workbooks.Open(inputFile)
            xlWorkSheet = CType(xlWorkBook.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)

            xlWorkSheet.DisplayRightToLeft = True
            xlWorkSheet.Cells(3, 9) = txt_mkf_name.Text
            cmb_part.Invoke(Sub() xlWorkSheet.Cells(2, 8) = cmb_part.SelectedItem)
            cmb_exam.Invoke(Sub() xlWorkSheet.Cells(2, 17) = cmb_exam.SelectedItem)
            xlWorkSheet.Cells(3, 17) = txt_years.Text

            Dim dst As New DataSet
            Cmd.Fill(dst)

            ' ضبط قيمة الـ Maximum مرة واحدة
            ProgressBar1.Invoke(Sub() ProgressBar1.Maximum = dst.Tables(0).Rows.Count)

            For i As Integer = 0 To dst.Tables(0).Rows.Count - 1
                Dim rowIndex As Integer = i   ' نسخة محلية من i

                ' تحديث الـ ProgressBar
                ProgressBar1.Invoke(Sub() ProgressBar1.Value = rowIndex + 1)

                ' حساب النسبة المئوية
                Dim total_s As Double = Math.Round(((rowIndex + 1) * 100.0) / dst.Tables(0).Rows.Count, 0)

                lbl_load_percen.Invoke(Sub() lbl_load_percen.Text = "%" & total_s.ToString())
                lbl_load.Invoke(Sub() lbl_load.Text = "جارى التحميل...")

                ' كتابة البيانات في ملف Excel
                For j As Integer = 0 To dst.Tables(0).Columns.Count - 1
                    xlWorkSheet.Cells(rowIndex + 5, j + 2) = dst.Tables(0).Rows(rowIndex).Item(j)

                Next


            ' معادلة تجميع المستقطع
            Dim drab_t As String = "G" & (5 + i)
                Dim mas_t_9 As String = "H" & (5 + i)
                Dim mahn_t_2 As String = "I" & (5 + i)
                Dim m_1_t As String = "J" & (5 + i)
                Dim m1_t As String = "K" & (5 + i)
                Dim m_t_1 As String = "L" & (5 + i)
                Dim damgh_t As String = "M" & (5 + i)
                Dim eradat_t As String = "N" & (5 + i)
                Dim box_t As String = "O" & (5 + i)
                Dim mashat_17 As String = "P" & (5 + i)

                xlWorkSheet.Cells(i + 5, 17) = "=(" & drab_t & "+" & mas_t_9 & "+" & mahn_t_2 & "+" & m_1_t & "+" & m1_t & "+" & m_t_1 & "+" & damgh_t & "+" & eradat_t & "+" & box_t & "+" & mashat_17 & ")"

                ' معادلة تجميع الصافى
                Dim num_row As String = "E" & (5 + i)
                Dim num_col As String = "Q" & (5 + i)

                xlWorkSheet.Cells(i + 5, 18) = "=(" & num_row & "-" & num_col & ")"


                'تجميع عمود الصافى 
                TOAL = TOAL + dst.Tables(0).Rows(i).Item(16)
                '==========
            Next
            'اظهار جملة عمود الصافى 
            txtNumber.Invoke(Sub() txtNumber.Text = TOAL.ToString())




            ' ================================================
            Dim da1 As New OleDbDataAdapter("SELECT * FROM table_name_col_total_tfrgh", con)
            Dim ds1 As New DataSet

            ds1.Tables.Add("st")
            da1.Fill(ds1, "st")

            For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
                xlWorkSheet.Cells(4, i + 1) = ds1.Tables(0).Rows(i).Item(1)
            Next
            xlWorkSheet.Cells(26, 3) = txtArabicWord.Text
            ' ================================================





            '====

            ' حفظ باسم جديد
            Dim gg As Integer = num_tot_frist.Value
            Dim savePath As String = Application.StartupPath & "\كشف اجمالى " & gg.ToString() & ".xlsx"

            xlWorkBook.SaveAs(savePath)
            MsgBox("تم الحفظ بنجاح في " & savePath)

            lbl_load.Invoke(Sub() lbl_load.Text = "تم التحميل كشف اجمالى " & gg.ToString())
            lbl_load_percen.Invoke(Sub() lbl_load_percen.Text = "%100")
            'xlWorkBook.Save()
            xlWorkBook.Close()
            xlApp.Quit()

        Catch ex As Exception
            MsgBox("حدث خطأ أثناء التنفيذ: " & ex.Message, MsgBoxStyle.Critical, "خطأ")

        Finally
            ' تأكد من إغلاق الموارد لمنع Excel من البقاء في الخلفية
            If xlWorkBook IsNot Nothing Then
                'xlWorkBook.Close(SaveChanges:=False)
                Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook)
            End If

            If xlApp IsNot Nothing Then
                xlApp.Quit()
                Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)
            End If

            xlWorkSheet = Nothing
            xlWorkBook = Nothing
            xlApp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try

    End Sub


    Private Sub txtArabicWord_TextChanged(sender As Object, e As EventArgs) Handles txtArabicWord.TextChanged
        Try
            Dim toWord As New NumberToWord.ToWord(Convert.ToDecimal(txtNumber.Text), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
            txtEnglishWord.Text = toWord.ConvertToEnglish()
            txtArabicWord.Text = toWord.ConvertToArabic()
        Catch ex As Exception

            txtEnglishWord.Text = String.Empty
            txtArabicWord.Text = String.Empty
        End Try
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        Try
            'If stat = "اعدادى" Then

            'total_saffy_adayed()

   
            'Else
            'stat = "ثانوى"

            'total_saffy_sanwy()

            Dim toWord As New NumberToWord.ToWord(Convert.ToDecimal(NumericUpDown3.Value), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
            txtEnglishWord.Text = toWord.ConvertToEnglish()
            txtArabicWord.Text = toWord.ConvertToArabic()
            'End If
        Catch ex As Exception
            txtEnglishWord.Text = String.Empty
            txtArabicWord.Text = String.Empty

        End Try
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        Try
            Dim toWord As New NumberToWord.ToWord(Convert.ToDecimal(txtNumber.Text), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
            txtEnglishWord.Text = toWord.ConvertToEnglish()
            txtArabicWord.Text = toWord.ConvertToArabic()
        Catch ex As Exception

            txtEnglishWord.Text = String.Empty
            txtArabicWord.Text = String.Empty
        End Try
    End Sub
End Class