Imports System.IO
Imports System.Data.OleDb
'Imports System.Net.Mime.MediaTypeNames
Imports Microsoft.Office.Interop

Public Class print_taswy_frm

    '====================
    'rename datagrid
    Public Sub DataGridViewHeaderText_taswy(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("id_bnd").HeaderText = "م"
                .Columns("num_taswy").HeaderText = "رقم التسويه"
                .Columns("col_1").HeaderText = DataGridView2.Rows(0).Cells(1).Value.ToString()
                .Columns("col_2").HeaderText = DataGridView2.Rows(1).Cells(1).Value.ToString()
                .Columns("col_3").HeaderText = DataGridView2.Rows(2).Cells(1).Value.ToString()
                .Columns("col_4").HeaderText = DataGridView2.Rows(3).Cells(1).Value.ToString()
                .Columns("col_5").HeaderText = DataGridView2.Rows(4).Cells(1).Value.ToString()
                .Columns("col_6").HeaderText = DataGridView2.Rows(5).Cells(1).Value.ToString()
                .Columns("col_7").HeaderText = DataGridView2.Rows(6).Cells(1).Value.ToString()
                .Columns("col_8").HeaderText = DataGridView2.Rows(7).Cells(1).Value.ToString()
                .Columns("col_9").HeaderText = DataGridView2.Rows(8).Cells(1).Value.ToString()
                .Columns("col_10").HeaderText = DataGridView2.Rows(9).Cells(1).Value.ToString()
                .Columns("col_11").HeaderText = DataGridView2.Rows(10).Cells(1).Value.ToString()
                .Columns("col_12").HeaderText = DataGridView2.Rows(11).Cells(1).Value.ToString()
                .Columns("col_13").HeaderText = DataGridView2.Rows(12).Cells(1).Value.ToString()
                .Columns("col_14").HeaderText = DataGridView2.Rows(13).Cells(1).Value.ToString()
                .Columns("col_15").HeaderText = DataGridView2.Rows(14).Cells(1).Value.ToString()
                .Columns("col_16").HeaderText = DataGridView2.Rows(15).Cells(1).Value.ToString()
                .Columns("col_17").HeaderText = DataGridView2.Rows(16).Cells(1).Value.ToString()
                .Columns("col_18").HeaderText = DataGridView2.Rows(17).Cells(1).Value.ToString()
                .Columns("col_19").HeaderText = DataGridView2.Rows(18).Cells(1).Value.ToString()
                .Columns("col_20").HeaderText = DataGridView2.Rows(19).Cells(1).Value.ToString()
                .Columns("col_21").HeaderText = DataGridView2.Rows(20).Cells(1).Value.ToString()
                .Columns("col_22").HeaderText = DataGridView2.Rows(21).Cells(1).Value.ToString()
                .Columns("col_23").HeaderText = DataGridView2.Rows(22).Cells(1).Value.ToString()
                .Columns("col_24").HeaderText = DataGridView2.Rows(23).Cells(1).Value.ToString()
                .Columns("col_25").HeaderText = DataGridView2.Rows(24).Cells(1).Value.ToString()
                .Columns("col_26").HeaderText = DataGridView2.Rows(25).Cells(1).Value.ToString()
                .Columns("bnd_adafy_3").HeaderText = DataGridView2.Rows(26).Cells(1).Value.ToString()
                .Columns("bnd_adafy_4").HeaderText = DataGridView2.Rows(27).Cells(1).Value.ToString()
                .Columns("bnd_adafy_5").HeaderText = DataGridView2.Rows(28).Cells(1).Value.ToString()
                .Columns("bnd_adafy_6").HeaderText = DataGridView2.Rows(29).Cells(1).Value.ToString()
                .Columns("bnd_adafy_7").HeaderText = DataGridView2.Rows(30).Cells(1).Value.ToString()
                .Columns("bnd_adafy_8").HeaderText = DataGridView2.Rows(31).Cells(1).Value.ToString()
                .Columns("bnd_adafy_9").HeaderText = DataGridView2.Rows(32).Cells(1).Value.ToString()
                .Columns("bnd_adafy_10").HeaderText = DataGridView2.Rows(33).Cells(1).Value.ToString()
                .Columns("total_all").HeaderText = "الاجمالى"
            End With
        End If
    End Sub
    '===========================================

    '==================
    ' تجميع datagridview
    Public Sub total_dgv_tabel_bnd()
        Dim sum As Double = 0
        For s As Integer = 0 To dgv_tabel_bnd.RowCount - 1
            sum = sum + dgv_tabel_bnd.Item("total_all", s).Value

        Next
        num_total.Value = sum


    End Sub
    '================



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        SelectAll_tabel_bnd_all_taswy(ListBox1)
        btn_export.Enabled = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try

    

            num_taswy.Value = ListBox1.SelectedValue
            If num_taswy.Value >= 0 Then

                SelectAll_tabel_bnd_one_taswy(dgv_tabel_bnd, num_taswy.Value)

                SelectAll_tabel_names_col_total(DataGridView2)


                DataGridViewHeaderText_taswy(dgv_tabel_bnd)
                total_dgv_tabel_bnd()
                '===========اظهار كل الاعمده=============

                For n = 0 To dgv_tabel_bnd.ColumnCount - 1
                    'Dim num_column As Integer

                    dgv_tabel_bnd.Columns(n).Visible = True
                Next

            Else

            End If


            '==============

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub print_taswy_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button4_Click(sender, e)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_export.Click

        Dim Cmd As New OleDbDataAdapter("select * from tabel_bnd where num_taswy  = " & num_taswy.Value & " ", con)

        '=====================
        Dim ds As New DataSet
        Cmd.Fill(ds)
        '=========================
        '================معرفة جملة الاعمدة التى اكبر من صفر =====

        'For m As Integer = 0 To ds1.Tables(0).Columns.Count - 1
        Dim sum As Double = 0
        msg_lbl.Items.Clear()
        ListBox2.Items.Clear()

        For j = 0 To ds.Tables(0).Columns.Count - 1
            For i = 0 To ds.Tables(0).Rows.Count - 1

                'sum = sum + dgv_tabel_bnd.Item("total_all", s).Value
                sum = sum + ds.Tables(0).Rows(i).Item(j)


            Next
            If sum > 0 Then

                'Dim num_col() As Integer
                'num_col(j) = j
                msg_lbl.Items.Add(j)
                sum = 0
            Else
                ListBox2.Items.Add(j)
                sum = 0

            End If
            'num_total.Value = sum
        Next
        '========================
        For k = 0 To ListBox2.Items.Count - 1
            For n = 0 To dgv_tabel_bnd.ColumnCount - 1
                Dim num_column As Integer
                num_column = ListBox2.Items(k)
                dgv_tabel_bnd.Columns(num_column).Visible = False
            Next
        Next
        '=======


        '=============================
        btn_export.Enabled = False
        btn_export.Text = "Wait"
        'SaveGridToExcel_all_tfrgh(dgv_tabel_bnd)
        '----------------------------
        Dim XCELAPP As Microsoft.Office.Interop.Excel.Application = Nothing
        Dim XWORKBOOK As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim XSHEET As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Dim misValue As Object = System.Reflection.Missing.Value
        If dgv_tabel_bnd.Rows.Count > 0 Then


            'Dim filename As String = ""
            'Dim SV As New SaveFileDialog()
            'SV.Filter = "Excel Files|*.xlsx|Excel 2003|*.xls"

            'If SV.ShowDialog = DialogResult.OK Then
            If dgv_tabel_bnd.RightToLeft = RightToLeft.Yes Then
                dgv_tabel_bnd.RightToLeft = False 'تغيير اتجاه الجريد من اليمين لليسار لكي لا ينسخ بالمقلوب
                'filename = SV.FileName
                Dim multiselect As Boolean = dgv_tabel_bnd.MultiSelect
                dgv_tabel_bnd.MultiSelect = True
                dgv_tabel_bnd.SelectAll()
                dgv_tabel_bnd.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
                Clipboard.SetDataObject(dgv_tabel_bnd.GetClipboardContent())
                Dim results = System.Convert.ToString(Clipboard.GetData(DataFormats.Text))
                dgv_tabel_bnd.ClearSelection()
                dgv_tabel_bnd.MultiSelect = multiselect
                dgv_tabel_bnd.RightToLeft = RightToLeft.Yes ' ارجاع اتجاه الجريد لليمين
                'XCELAPP = New Application()

                XCELAPP = New Excel.Application()
                XWORKBOOK = XCELAPP.Workbooks.Add(misValue)
                XCELAPP.DisplayAlerts = False
                XCELAPP.Visible = False
                'XCELAPP.Visible = True

                'XCELAPP.Workbooks.Add()
                CType(XCELAPP.Workbooks(1).Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Name = "Sheet1"

                XSHEET = XWORKBOOK.ActiveSheet
                XSHEET.DisplayRightToLeft = True
                XSHEET.Columns(1).ToString()

                Dim formatRange As Excel.Range
                formatRange = XSHEET.Range("a1", "c20000")
                formatRange.NumberFormat = "@"
                'formatRange.NumberFormat = "#,###,###"
                formatRange.EntireRow.Font.Bold = True
                formatRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                formatRange.Font.Size = 20

                'formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                '==================

                '==========================
                Dim formatRange2 As Excel.Range
                formatRange2 = XSHEET.Range("d1", "AF20000")
                formatRange2.NumberFormat = "0.00"
                formatRange2.EntireRow.Font.Bold = True
                formatRange2.Font.Size = 20
                XSHEET.PasteSpecial(RightToLeft.Yes)

                XSHEET.Cells(1, 1) = "الشرط الاول"
                '==============================
                'Dim usedrange As Excel.Range = XSHEET.UsedRange
                formatRange.Columns.AutoFit()
                formatRange.Columns.ShrinkToFit = True
                formatRange2.Columns.AutoFit()
                formatRange2.Columns.ShrinkToFit = True
                'usedrange.Rows.AutoFit()
                '===============
                'Dim formatRange3 As Excel.Range = XSHEET.UsedRange

                Dim colum As Excel.Range = formatRange
                'Dim cell As Excel.Range = formatRange.Cells("a1", "k20000")
                Dim border As Excel.Borders = colum.Borders
                border.LineStyle = Excel.XlLineStyle.xlContinuous
                border.Weight = 2.0
                '===================================
                Dim colum2 As Excel.Range = formatRange2
                'Dim cell As Excel.Range = formatRange.Cells("a1", "k20000")
                Dim border2 As Excel.Borders = colum2.Borders
                border2.LineStyle = Excel.XlLineStyle.xlContinuous
                border2.Weight = 2.0
                '===============================
                '====كل اوراق عمل احتواء مناسب  
                'For Each wrkst As Excel.Worksheet In XWORKBOOK.Worksheets
                '    Dim usedrange As Excel.Range = wrkst.UsedRange
                '    usedrange.Columns.AutoFit()
                '    formatRange.Columns.ShrinkToFit = True
                'Next wrkst
                '================================
                ProgressBar1.Maximum = dgv_tabel_bnd.RowCount


                '=====================

                For i = 0 To ds.Tables(0).Rows.Count - 1

                    'ProgressBar1=====================
                    ProgressBar1.Value = i
                    Dim total_s As Double = 0
                    total_s = (i * 1) / dgv_tabel_bnd.RowCount
                    total_s = total_s * 100
                    total_s = Math.Round(total_s, 0)

                    Label3.Text = "%".ToString() + total_s.ToString()
                    Label2.Text = "جارى التحميل 00000"
                    Label2.Visible = False
                    Label2.Visible = True
                    '==============


                    '=============تجميع اعمده
                    Dim num_first_row As String
                    Dim num_last_row As Integer
                    '---------------
                    Dim num_col() As Integer = {5, 6, 7}




                    '----------
                    Dim name_col() As String = {"D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL"}

                    For y As Integer = 0 To name_col.Count - 1
                        'For x = 5 To ds.Tables(0).Columns.Count - 1
                        '---
                        'num_first_row = "E2"
                        num_first_row = name_col(y) + "2"
                        num_last_row = ds.Tables(0).Rows.Count + 2
                        '----------------
                        Dim last_row As String
                        'last_row = "E" + (num_last_row - 1).ToString()
                        last_row = name_col(y) + (num_last_row - 1).ToString()
                        XSHEET.Cells(num_last_row, y + 4) = "=sum(" + num_first_row + ":" + last_row + ")"



                    Next
                    '=================================
                Next
                Dim gg As Integer = 0
                Dim yers, day, month, date1 As String
                yers = Date.Now().Year().ToString()
                day = Date.Now().Day().ToString()
                month = Date.Now().Month().ToString()

                gg = ListBox1.SelectedValue
                date1 = "(" + gg.ToString() + ")" + "    " + day + "-" + month + "-" + yers
                'xlWorkSheet.SaveAs("D:\كشف رقم " + gg.ToString() + ".xls ")
                XWORKBOOK.SaveAs((Application.StartupPath) & "\كشف رقم " + date1 + ".xlsx ")

                '===============
                '========================

                'XWORKBOOK.SaveAs(filename, Excel.XlFileFormat.xlOpenXMLWorkbook)
                XWORKBOOK.Close(False)
                XCELAPP.Quit()

                '----
                Dim msg As String
                msg = " تم تصدير البيانات الى اكسيل"
                Label2.Text = msg
                msg_lbl.Items.Add("كشف رقم" + date1)

                '=====================
            End If
        End If
        btn_export.Enabled = True
        btn_export.Text = "تصدير الى اكسيل"

        Label3.Text = "%100"
        Label2.Text = " تم التحميل"
        ProgressBar1.Value = 0

        'End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '====اخفاء الاعمدة التى تساوى صفر
        Dim Cmd As New OleDbDataAdapter("select * from tabel_bnd where num_taswy  = " & num_taswy.Value & " ", con)

        '================معرفة جملة الاعمدة التى اكبر من صفر =====
        Dim ds As New DataSet
        Cmd.Fill(ds)
        'For m As Integer = 0 To ds1.Tables(0).Columns.Count - 1
        Dim sum As Double = 0
        msg_lbl.Items.Clear()
        ListBox2.Items.Clear()
        For j = 0 To ds.Tables(0).Columns.Count - 1
            For i = 0 To ds.Tables(0).Rows.Count - 1

                'sum = sum + dgv_tabel_bnd.Item("total_all", s).Value
                sum = sum + ds.Tables(0).Rows(i).Item(j)


            Next
            If sum > 0 Then

                'Dim num_col() As Integer
                'num_col(j) = j
                msg_lbl.Items.Add(j)
                sum = 0
            Else
                ListBox2.Items.Add(j)
                sum = 0

            End If
            'num_total.Value = sum
        Next
        '========================
        For k = 0 To ListBox2.Items.Count - 1
            For n = 0 To dgv_tabel_bnd.ColumnCount - 1
                Dim num_column As Integer
                num_column = ListBox2.Items(k)
                dgv_tabel_bnd.Columns(num_column).Visible = False
            Next
        Next
        'ط===============
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '====اخفاء الاعمدة التى تساوى صفر
        'Dim Cmd As New OleDbDataAdapter("select * from tabel_bnd where num_taswy  = " & num_taswy.Value & " ", con)

        ''================معرفة جملة الاعمدة التى اكبر من صفر =====
        'Dim ds As New DataSet
        'Cmd.Fill(ds)

        '===========اظهار كل الاعمده=============

        For n = 0 To dgv_tabel_bnd.ColumnCount - 1
            'Dim num_column As Integer

            dgv_tabel_bnd.Columns(n).Visible = True
        Next

        '==============
    End Sub
End Class