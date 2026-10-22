Imports System.IO
Imports excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb


Public Class Form_report_day
    Public stat_form As String
    '   total datagrid
    Public Sub total_years()
        Dim sum As Double = 0
        For s As Integer = 0 To DataGridView1.RowCount - 1
            sum = sum + DataGridView1.Item(2, s).Value
            DataGridView1.Item(2, s).Value = Math.Round(DataGridView1.Item(2, s).Value, 3)

        Next
        NumericUpDown1.Value = sum


    End Sub
    '   total datagrid2
    Public Sub total_day()
        Dim sum As Double = 0
        For s As Integer = 0 To dgv_gp_table.RowCount - 1
            sum = sum + dgv_gp_table.Item(1, s).Value
            dgv_gp_table.Item(1, s).Value = Math.Round(dgv_gp_table.Item(1, s).Value, 3)


        Next
        NumericUpDown2.Value = sum


    End Sub
    'نسخ ملف اكسيل
    Public Sub add_file()
        'نسخ ملف اكسيل
        Dim source_path, destpasth As String
        source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\page_tfrgh.xlsx"
        '
        destpasth = "d:\page_tfrgh.xlsx"

        If My.Computer.FileSystem.FileExists(destpasth) = True Then
            My.Computer.FileSystem.DeleteFile(destpasth)
            My.Computer.FileSystem.CopyFile(source_path, destpasth)
            'MessageBox.Show("تم نسخ قاعدة بيانات")
        Else
            My.Computer.FileSystem.CopyFile(source_path, destpasth)

        End If
        'نسخ ملف اكسيل
        Dim srce_path, dest_pasth As String
        srce_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\ProductsList.xlsx"

        dest_pasth = "d:\ProductsList.xlsx"

        If My.Computer.FileSystem.FileExists(dest_pasth) = True Then
            My.Computer.FileSystem.DeleteFile(dest_pasth)
            My.Computer.FileSystem.CopyFile(srce_path, dest_pasth)

        Else
            My.Computer.FileSystem.CopyFile(source_path, dest_pasth)
            'MessageBox.Show("تم نسخ قاعدة بيانات")
        End If
    End Sub


    'total manth
    Public dt_total_manth As New DataTable
    Public Sub SelectAll_total_manth(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_total_manth.Clear()
        da = New OleDbDataAdapter("select * from total_manth", con)
        da.Fill(dt_total_manth)
        dgv.DataSource = dt_total_manth
    End Sub
    Private Sub Form_report_day_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SEARCH2DATE(DateTimePicker1.Value, DateTimePicker2.Value)
        dgv_gp_table.DataSource = DT_SEARCH
        'DataGridViewHeaderwith(dgv_gp_table)
        total_years()
        total_day()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        add_file()

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        Dim inputFile As String = ("d:\ProductsList.xlsx")
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkBook = xlApp.Workbooks.Open(inputFile)

        xlWorkSheet = xlWorkBook.ActiveSheet
        For i = 0 To dgv_gp_table.RowCount - 2
            For j = 0 To dgv_gp_table.ColumnCount - 1
                For k As Integer = 1 To dgv_gp_table.Columns.Count
                    xlWorkSheet.Cells(2, k) = dgv_gp_table.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgv_gp_table(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\ProductsList.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file D:\")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If stat_form = "add" Then
            SelectAll_total_day_addy(dgv_gp_table)
            SelectAll_total_manth(DataGridView1)
            total_years()
            total_day()


        Else : stat_form = "box"
            SelectAll_total_day_box(dgv_gp_table)
            SelectAll_total_manth(DataGridView1)
            total_years()
            total_day()
        End If
    End Sub
End Class