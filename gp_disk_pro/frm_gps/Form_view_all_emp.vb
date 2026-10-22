Imports System.IO
Imports System.Data.OleDb
'Imports System.Net.Mime.MediaTypeNames
Imports Microsoft.Office.Interop

Public Class Form_view_all_emp

    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & Application.StartupPath & "\gp_tafrgh_db.accdb")

    Public dt_gp_table As New DataTable

    Public Sub SelectAll_gp_table(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_gp_table.Clear()
        da = New OleDbDataAdapter("select * from gp_table", con)
        da.Fill(dt_gp_table)
        dgv.DataSource = dt_gp_table
    End Sub
    '===========================


    Public Shared Sub SaveGridToExcel(ByVal DGV As DataGridView) ' صب نسخ من الجريد لإكسل
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
                        XSHEET = XWORKBOOK.ActiveSheet
                        XSHEET.DisplayRightToLeft = True
                        XSHEET.Columns(1).ToString()

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
                        XSHEET.PasteSpecial(RightToLeft.Yes)

                        XSHEET.Cells(1, 1) = "الشرط الاول"
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

    '==========================================

    Public Sub SelectAll_user_table(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_user_table.Clear()
        da = New OleDbDataAdapter("select * from emp ", con)
        da.Fill(dt_user_table)
        dgv.DataSource = dt_user_table
    End Sub


    '=========================

    Private Sub Form_pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With DataGridView1
            .Columns.Clear()
            .Columns.Add("id_no", "رقم القومى")
            .Columns.Add("name_pay", "نوع المدفوعة")
            .Columns.Add("al_kta", "القطاع")
            .Columns.Add("school", "المدرسة")
            .Columns.Add("no_emb", "رقم الموظف")
            .Columns.Add("name_emp", "اسم الموظف")
            .Columns.Add("Saffy", "المرتب")
            .Columns.Add("Entklat", "انتقالات")
            .Columns.Add("Badl_safer", "بدل سفر")
            .Columns.Add("no_kshf", "رقم الكشف")
            .Columns.Add("user_ful_name", "اسم المستخدم")

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .ScrollBars = ScrollBars.Both
            .ReadOnly = True
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub


    Private Sub BtnLoadData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoadData.Click

        BtnLoadData.Text = "Please Wait..."
        BtnLoadData.ForeColor = Color.Red
        BtnLoadData.Enabled = False
        System.Windows.Forms.Application.DoEvents()

        Dim da As New OleDbDataAdapter
        dt_emp_table.Clear()
        da = New OleDbDataAdapter("select * from emp ", con)
        da.Fill(dt_emp_table)
        'DGV.DataSource = dt_user_table
        'LOAD 10000 ROWS INTO DATAGRIDVIEW
        For i As Integer = 1 To dt_emp_table.Rows.Count - 1
            With DataGridView1.Rows
                '.Add(i, "3112" & i, "Student " & i, "Indonesia " & i, "021-" & i)
                .Add(dt_emp_table.Rows(i).Item(0).ToString(), dt_emp_table.Rows(i).Item(1).ToString(), dt_emp_table.Rows(i).Item(2).ToString(), dt_emp_table.Rows(i).Item(3).ToString(), dt_emp_table.Rows(i).Item(4).ToString(), dt_emp_table.Rows(i).Item(5).ToString(), dt_emp_table.Rows(i).Item(6).ToString())
            End With
            System.Windows.Forms.Application.DoEvents()
        Next

        BtnLoadData.Text = "Load Data"
        BtnLoadData.Enabled = True
        btn_export.Enabled = True
        lbl_count.Text = (dt_emp_table.Rows.Count - 1).ToString()
    End Sub







    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_export.Click
        btn_export.Enabled = False
        btn_export.Text = "Wait"
        SaveGridToExcel(DataGridView1)
        btn_export.Text = "تصدير البيانات الى اكسيل"
    End Sub

  
End Class


