Imports System.IO
Imports excel = Microsoft.Office.Interop.Excel
Public Class Form_add_gp
    'clear contan
    Dim add_edit As String = False
    Public Sub ClearControls()
        'Me.id.Text = vbNullString
        'Me.date1.Value = Today
        'Me.descr.Text = vbNullString
        Me.no_file.Text = vbNullString
        Me.el_mablgh.Text = vbNullString
        Me.no_gp.Text = vbNullString
        'Me.date_assthkk.Value = Today
        Me.no_shatb.Text = vbNullString
        'Me.id_desc.Text = vbNullString
    End Sub


    Private Sub Form_add_gp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SelectAll_gp_table(dgv_gp_table)
        DataGridViewHeaderText(dgv_gp_table)
        id.Text = Max_gp_table() + 1
        'ايجاد اخر سطرفى دات
        dgv_gp_table.Focus()
        dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
        'fill compbox
        fillcmb_dec_shatb_table(id_desc)
        'DataGridViewHeaderwith(dgv_gp_table)
        Me.date1.Value = Today
        Me.date_assthkk.Value = Today

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_gp_table(dgv_gp_table)
            SelectAll_gp_table(dgv_gp_table)
            'ايجاد اخر سطرفى دات
            dgv_gp_table.Focus()
            dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
        End If


    End Sub

    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.Click
        Dim id_des As Integer
        id_des = id_desc.SelectedValue()

        'MessageBox.Show(id_des)
        If el_mablgh.Text = vbNullString Then

            MessageBox.Show("عفواً ، قم بادخال المبلغ", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Else
            Insert_gp_table(date1.Value, descr.Text, no_file.Text, Convert.ToDouble(el_mablgh.Text), no_gp.Text, date_assthkk.Value, no_shatb.Text, id_des)
        End If


        SelectAll_gp_table(dgv_gp_table)
        'ايجاد اخر سطرفى دات
        dgv_gp_table.Focus()
        dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
        id.Text = Max_gp_table() + 1
        ClearControls()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.descr.Text = vbNullString
    End Sub



    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If add_edit = False Then
            BtnNewAdd.Enabled = False
            Dim id_dess As Integer
            id_dess = id_desc.SelectedValue()
            Update_gp_table(Convert.ToInt32(id.Text), date1.Value, descr.Text, no_file.Text, Convert.ToDouble(el_mablgh.Text), no_gp.Text, date_assthkk.Value, no_shatb.Text, id_dess)
            SelectAll_gp_table(dgv_gp_table)
            'ايجاد اخر سطرفى دات
            dgv_gp_table.Focus()
            dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
            id.Text = Max_gp_table() + 1
            ClearControls()
        End If

    End Sub



    Private Sub dgv_gp_table_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv_gp_table.CellMouseClick
        Try
            With dgv_gp_table
                Me.id.Text = .CurrentRow.Cells("id").Value.ToString()
                Me.date1.Value = .CurrentRow.Cells("date1").Value.ToString()
                Me.descr.Text = .CurrentRow.Cells("descr").Value.ToString()
                Me.no_file.Text = .CurrentRow.Cells("no_file").Value.ToString()
                Me.el_mablgh.Text = .CurrentRow.Cells("el_mablgh").Value.ToString()
                Me.no_gp.Text = .CurrentRow.Cells("no_gp").Value.ToString()
                Me.date_assthkk.Value = .CurrentRow.Cells("date_assthkk").Value.ToString()
                Me.no_shatb.Text = .CurrentRow.Cells("no_shatb").Value.ToString()
                Me.id_desc.Text = .CurrentRow.Cells("id_desc").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnNewAdd.Enabled = False
        BtnEdit.Enabled = True
    End Sub

    Private Sub el_mablgh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles el_mablgh.KeyDown
        If MakeTextBoxNumeric(e.KeyCode, e.Shift) = False Then e.SuppressKeyPress = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClearControls()
        BtnNewAdd.Enabled = True
        id.Text = Max_gp_table() + 1
        BtnEdit.Enabled = False
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim dv As DataView = dt_gp_table.DefaultView
            dv.RowFilter = " descr LIKE '%" & TextBox1.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

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

                xlworksheet = xlworkbook.ActiveSheet
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

    Private Sub dgv_gp_table_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_gp_table.CellContentClick

    End Sub

    Private Sub id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id.Click

    End Sub
End Class