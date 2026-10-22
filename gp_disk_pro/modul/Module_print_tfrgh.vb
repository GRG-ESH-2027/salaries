Imports System.Data.OleDb
Imports System.IO
'Imports System.Net.Mime.MediaTypeNames
Imports Microsoft.Office.Interop

Module Module_print_tfrgh
    Public dt_Table_mkf_sanwy_no_kshff As New DataTable
    Public dt_Table_mkf_no_kshff_pr As New DataTable
    Public dt_Table_mkf_all_data As New DataTable
    '==========================
    Public Sub SaveGridToExcel_all_pay(ByVal DGV As DataGridView) ' صب نسخ من الجريد لإكسل
        Try
            Dim XCELAPP As Microsoft.Office.Interop.Excel.Application = Nothing
            Dim XWORKBOOK As Microsoft.Office.Interop.Excel.Workbook = Nothing
            Dim XSHEET As Microsoft.Office.Interop.Excel.Worksheet = Nothing
            Dim misValue As Object = System.Reflection.Missing.Value

            If DGV.Rows.Count > 0 Then
                Dim filename As String = ""
                Dim SV As New SaveFileDialog()
                SV.Filter = "Excel Files|*.xlsx|Excel 2003|*.xls"

                If SV.ShowDialog = DialogResult.OK Then
                    If DGV.RightToLeft = RightToLeft.Yes Then
                        DGV.RightToLeft = False 'تغيير اتجاه الجريد من اليمين لليسار لكي لا ينسخ بالمقلوب
                        filename = SV.FileName
                        Dim multiselect As Boolean = DGV.MultiSelect
                        DGV.MultiSelect = True
                        DGV.SelectAll()
                        DGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
                        Clipboard.SetDataObject(DGV.GetClipboardContent())
                        Dim results = System.Convert.ToString(Clipboard.GetData(DataFormats.Text))
                        DGV.ClearSelection()
                        DGV.MultiSelect = multiselect
                        DGV.RightToLeft = RightToLeft.Yes ' ارجاع اتجاه الجريد لليمين
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
                        formatRange = XSHEET.Range("a1", "f20000")
                        formatRange.NumberFormat = "@"
                        'formatRange.NumberFormat = "#,###,###"
                        formatRange.EntireRow.Font.Bold = True
                        formatRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                        formatRange.Font.Size = 20

                        'formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                        '==================

                        '==========================
                        Dim formatRange2 As Excel.Range
                        formatRange2 = XSHEET.Range("G1", "k20000")
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

                        XWORKBOOK.SaveAs(filename, Excel.XlFileFormat.xlOpenXMLWorkbook)
                        XWORKBOOK.Close(False)
                        XCELAPP.Quit()
                    Else
                        filename = SV.FileName
                        Dim multiselect As Boolean = DGV.MultiSelect
                        DGV.MultiSelect = True
                        DGV.SelectAll()
                        DGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
                        Clipboard.SetDataObject(DGV.GetClipboardContent())
                        Dim results = System.Convert.ToString(Clipboard.GetData(DataFormats.Text))
                        DGV.ClearSelection()
                        DGV.MultiSelect = multiselect
                        XCELAPP = New Excel.Application()
                        XWORKBOOK = XCELAPP.Workbooks.Add(misValue)
                        XCELAPP.DisplayAlerts = False
                        XCELAPP.Visible = False
                        'XCELAPP.Visible = True

                        'XCELAPP.Workbooks.Add()
                        CType(XCELAPP.Workbooks(1).Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet).Name = "Sheet1"

                        XSHEET = XWORKBOOK.ActiveSheet
                        Dim formatRange As Excel.Range
                        formatRange = XSHEET.Range("a1", "g20000")
                        formatRange.NumberFormat = "@"
                        'formatRange.NumberFormat = "#,###,###"
                        formatRange.EntireRow.Font.Bold = True
                        formatRange.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                        formatRange.Font.Size = 20

                        'formatRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black)
                        '==================

                        '==========================
                        Dim formatRange2 As Excel.Range
                        formatRange2 = XSHEET.Range("h1", "m20000")
                        formatRange2.NumberFormat = "0.00"
                        formatRange2.EntireRow.Font.Bold = True
                        formatRange2.Font.Size = 20
                        XSHEET.Paste()

                        XSHEET.Cells(1, 1) = "الشرط الثانى"
                        '==============================
                        'Dim usedrange As Excel.Range = XSHEET.UsedRange
                        formatRange.Columns.AutoFit()
                        formatRange.Columns.ShrinkToFit = True

                        'usedrange.Rows.AutoFit()
                        '===============
                        'Dim formatRange3 As Excel.Range = XSHEET.UsedRange

                        Dim colum As Excel.Range = formatRange
                        'Dim cell As Excel.Range = formatRange.Cells("a1", "k20000")
                        Dim border As Excel.Borders = colum.Borders
                        border.LineStyle = Excel.XlLineStyle.xlContinuous
                        border.Weight = 2.0
                        '===============================
                        '====كل اوراق عمل احتواء مناسب  
                        'For Each wrkst As Excel.Worksheet In XWORKBOOK.Worksheets
                        '    Dim usedrange As Excel.Range = wrkst.UsedRange
                        '    usedrange.Columns.AutoFit()
                        '    formatRange.Columns.ShrinkToFit = True
                        'Next wrkst
                        '================================


                        XWORKBOOK.SaveAs(filename, Excel.XlFileFormat.xlOpenXMLWorkbook)
                        XWORKBOOK.Close(False)
                        XCELAPP.Quit()
                    End If

                    If MessageBox.Show("هل تريد فتح الملف ؟", "فتح ملف الأكسل", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading) = MsgBoxResult.Yes Then
                        Process.Start(SV.FileName)

                    End If
                    Try
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(XSHEET)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(XWORKBOOK)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(XCELAPP)
                    Catch
                    End Try
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    '=======================
    'تحميل رقم الكشف
    Public Sub SelectAll_Table_mkf_no_kshf(ByVal no_kshf As Integer)

        dt_Table_mkf_no_kshff_pr.Clear()
        Dim Cmd As New OleDbCommand("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Mzay_t_17_25,Mzay_t_17_25,Total_Mostkta,Name_school ,Name_Emp ,Saffy,Entklat,Badl_safer,id,Id_Mkf,no_kshf,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb,user_table.user_name from Table_mkf_add,user_table where no_kshf = @no_kshf  and Table_mkf_add.id_user=user_table.id_user", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf
            dt_Table_mkf_no_kshff_pr.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '=======================
    Public Sub SelectAll_Table_mkf_sanwy_no_kshf(ByVal no_kshf As Integer)
        dt_Table_mkf_sanwy_no_kshff.Clear()
        Dim Cmd As New OleDbCommand("select No_55,Salary_ass,Dayes,Mkf,Mkf_2,Entklat,Badl_safer,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Mzay_t_17_25,Total_Mostkta,Name_school ,Name_Emp ,Saffy_after_antkal ,id,Id_Mkf,no_kshf,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb,user_table.user_name from Table_mkf_add,user_table where no_kshf = @no_kshf and Table_mkf_add.id_user=user_table.id_user", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kshf
            dt_Table_mkf_sanwy_no_kshff.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '=========================================
    'تحميل كل الكشوف
    'تحميل كل الكشف
    Public Sub SelectAll_Table_mkf_all_data()

        dt_Table_mkf_all_data.Clear()
        Dim Cmd As New OleDbCommand("select No_55,Salary_ass,Dayes,Mkf,total,Mashat,Mashat8,Darabb,nkaba,Mhann,Mastshfa,Damghh,Earaadta,box20,Total_Mostkta,Name_school ,Name_Emp ,Saffy,Entklat,Badl_safer,id,Id_Mkf,no_kshf,id_no,op_name_pay,op_al_kta,Name_school as الادارة,op_no_emb,user_table.user_name from Table_mkf_add,user_table where Table_mkf_add.id_user=user_table.id_user", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()

            dt_Table_mkf_all_data.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '================================================
    Public dt_all_salary_ass As New DataTable
    Public Sub auto_all_salary_ass()
        Dim da As New OleDbDataAdapter
        dt_all_salary_ass.Clear()
        da = New OleDbDataAdapter("select * from salary_ass", con)
        da.Fill(dt_all_salary_ass)

    End Sub
End Module
