Imports System.IO
Imports System.Data.OleDb
'Imports System.Net.Mime.MediaTypeNames
Imports Microsoft.Office.Interop

Module Module_export_to_excell
    Public filename As String

    Public Sub SaveGridToExcel_all_tfrgh(ByVal DGV As DataGridView) ' صب نسخ من الجريد لإكسل
        Try
            Dim XCELAPP As Microsoft.Office.Interop.Excel.Application = Nothing
            Dim XWORKBOOK As Microsoft.Office.Interop.Excel.Workbook = Nothing
            Dim XSHEET As Microsoft.Office.Interop.Excel.Worksheet = Nothing
            Dim misValue As Object = System.Reflection.Missing.Value
            If DGV.Rows.Count > 0 Then
                'Dim filename As String = ""
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
                        '=================================



                        '===============
                        '========================
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
                        filename = SV.FileName
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

End Module
