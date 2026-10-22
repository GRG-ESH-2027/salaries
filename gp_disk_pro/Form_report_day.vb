Imports System.IO
Imports excel = Microsoft.Office.Interop.Excel


Public Class Form_report_day


    Private Sub Form_report_day_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectAll_total_day_addy(dgv_gp_table)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SEARCH2DATE(DateTimePicker1.Value, DateTimePicker2.Value)
        dgv_gp_table.DataSource = DT_SEARCH
        DataGridViewHeaderwith(dgv_gp_table)

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        Dim inputFile As String = ("D:\ProductsList.xlsx")
        'xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkBook = xlApp.Workbooks.Open(inputFile)

        xlWorkSheet = xlWorkBook.ActiveSheet
        For i = 0 To dgv_gp_table.RowCount - 2
            For j = 0 To dgv_gp_table.ColumnCount - 1
                For k As Integer = 1 To dgv_gp_table.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgv_gp_table.Columns(k - 1).HeaderText
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

        MsgBox("You can find the file D:\vbexcel.xlsx")
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
End Class