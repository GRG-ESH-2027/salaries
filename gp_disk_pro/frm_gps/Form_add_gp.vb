Imports System.IO
Imports excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb

Public Class Form_add_gp
    '=======================================================
    ''الاستكمال التلقائى  الوصف textbox====================================
    'Public dt_auto_txt_descr As New DataTable
    'Public Sub auto_txt_descr()
    '    Dim da As New OleDbDataAdapter
    '    dt_auto_txt_descr.Clear()
    '    da = New OleDbDataAdapter("select NVL(descr,0) from gp_table ", con)
    '    da.Fill(dt_auto_txt_descr)
    '    Dim data_souce As New AutoCompleteStringCollection

    '    For i As Integer = 0 To dt_auto_txt_descr.Rows.Count - 1
    '        data_souce.Add(dt_auto_txt_descr.Rows(i)("descr")).ToString()

    '    Next
    '    descr.AutoCompleteCustomSource = data_souce
    '    descr.AutoCompleteSource = AutoCompleteSource.CustomSource
    '    descr.AutoCompleteMode = AutoCompleteMode.Suggest

    'End Sub


    '=======================================================

    'Public Sub add_file()
    'نسخ ملف اكسيل
    'Dim source_path, destpasth As String
    '    source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\page_tfrgh.xlsx"
    ''
    '    destpasth = "d:\page_tfrgh.xlsx"

    '    If My.Computer.FileSystem.FileExists(destpasth) = True Then
    '        My.Computer.FileSystem.DeleteFile(destpasth)
    '        My.Computer.FileSystem.CopyFile(source_path, destpasth)
    ''MessageBox.Show("تم نسخ قاعدة بيانات")
    '    Else
    '        My.Computer.FileSystem.CopyFile(source_path, destpasth)

    '    End If
    ''نسخ ملف اكسيل
    'Dim srce_path, dest_pasth As String
    '    srce_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\ProductsList.xlsx"

    '    dest_pasth = "d:\ProductsList.xlsx"

    '    If My.Computer.FileSystem.FileExists(dest_pasth) = True Then
    '        My.Computer.FileSystem.DeleteFile(dest_pasth)
    '        My.Computer.FileSystem.CopyFile(srce_path, dest_pasth)

    '    Else
    '        My.Computer.FileSystem.CopyFile(source_path, dest_pasth)
    ''MessageBox.Show("تم نسخ قاعدة بيانات")
    '    End If
    'End Sub


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
        el_mablgh.Enabled = True
        no_gp.Enabled = True
        descr.Enabled = True
        no_file.Enabled = True
        no_shatb.Enabled = True


    End Sub


    Private Sub Form_add_gp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'SelectAll_gp_table(dgv_gp_table)
        'SEARCH_by_DATE(Now)
        'dgv_gp_table.DataSource = DT_SEARCH_by_date

        id.Text = Max_gp_table() + 1
        'ايجاد اخر سطرفى دات
        'dgv_gp_table.Focus()
        'dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
        'fill compbox
        fillcmb_dec_shatb_table(id_desc)
        DataGridViewHeaderwith(dgv_gp_table)
        Me.date1.Value = Today
        Me.date_assthkk.Value = Today
        NumericUpDown1.Value = Sum_gp_table_el_mablgh()
        total_day()
        DataGridViewHeaderText(dgv_gp_table)
        'dgv_gp_table.Columns("el_mablgh").DefaultCellStyle.SelectionForeColor

        'جعل كومبوبكس على اول اختيار
        id_desc.SelectedIndex = 0
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Try
            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                Delete_gp_table(dgv_gp_table)
                'SelectAll_gp_table(dgv_gp_table)
                'ايجاد اخر سطرفى دات
                'dgv_gp_table.Focus()

                SEARCH_by_DATE(date1.Value)
                dgv_gp_table.DataSource = DT_SEARCH_by_date

                total_day()
                total_box()
                total_adyy()
                dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
                idlbl.Text = dgv_gp_table.RowCount().ToString()
                close_all_txtbox()
                BtnNewAdd.Visible = False
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.Click
        Dim id_des As Integer
        ErrorProvider1.Clear()
        id_des = id_desc.SelectedValue()

        'MessageBox.Show(id_des)
        If el_mablgh.Text.Trim() = "" Or el_mablgh.Value = 0 Then

            MessageBox.Show("عفواً ، قم بادخال المبلغ", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            ErrorProvider1.SetError(el_mablgh, "تاكد من المبلغ  !...")
        Else
            Insert_gp_table(id_user.Text, date1.Value, descr.Text, no_file.Text, el_mablgh.Value, no_gp.Text, date_assthkk.Value, no_shatb.Text, id_des)
        End If
        'SelectAll_gp_table(dgv_gp_table)

        SEARCH_by_DATE(date1.Value)
        dgv_gp_table.DataSource = DT_SEARCH_by_date
        'ايجاد اخر سطرفى دات
        dgv_gp_table.Focus()
        dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
        id.Text = Max_gp_table() + 1
        id_user.Text = (Max_gp_table() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
        ClearControls()
        total_day()
        total_box()
        total_adyy()
        DataGridViewHeaderText(dgv_gp_table)
        idlbl.Text = dgv_gp_table.RowCount().ToString()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.descr.Text = vbNullString
    End Sub



    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If add_edit = False Then
            BtnNewAdd.Enabled = False
            Dim id_dess As Integer
            id_dess = id_desc.SelectedValue()
            Update_gp_table(id_user.Text, date1.Value, descr.Text, no_file.Text, el_mablgh.Value, no_gp.Text, date_assthkk.Value, no_shatb.Text, id_dess, id.Value)
            'SelectAll_gp_table(dgv_gp_table)
            SEARCH_by_DATE(date1.Value)
            dgv_gp_table.DataSource = DT_SEARCH_by_date
            'ايجاد اخر سطرفى دات
            dgv_gp_table.Focus()
            dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
            id.Text = Max_gp_table() + 1
            id_user.Text = (Max_gp_table() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
            ClearControls()
            total_day()
            total_box()
            total_adyy()
            close_all_txtbox()
            BtnNewAdd.Visible = False
        End If

    End Sub





    Private Sub dgv_gp_table_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv_gp_table.CellMouseClick
        Try
            With dgv_gp_table
                Me.id.Text = .CurrentRow.Cells("id").Value.ToString()

                Me.id_user.Text = .CurrentRow.Cells("id_and_user").Value.ToString()
                Me.date1.Value = .CurrentRow.Cells("date1").Value.ToString()
                Me.descr.Text = .CurrentRow.Cells("descr").Value.ToString()
                Me.no_file.Text = .CurrentRow.Cells("no_file").Value.ToString()
                Me.el_mablgh.Text = .CurrentRow.Cells("el_mablgh").Value.ToString()
                Me.no_gp.Text = .CurrentRow.Cells("no_gp").Value.ToString()
                Me.date_assthkk.Value = .CurrentRow.Cells("date_assthkk").Value.ToString()
                Me.no_shatb.Text = .CurrentRow.Cells("no_shatb").Value.ToString()

                'Me.id_desc.Text = .CurrentRow.Cells("id_desc").Value.ToString()
                id_desc.SelectedValue = .CurrentRow.Cells("id_desc").Value.ToString()
                id_desc.DisplayMember = id_desc.SelectedValue
                BtnNewAdd.Visible = False

            End With
            BtnDelete.Enabled = True
            open_all_txtbox()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnNewAdd.Enabled = False
        BtnEdit.Enabled = True
    End Sub

    Private Sub el_mablgh_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If MakeTextBoxNumeric(e.KeyCode, e.Shift) = False Then e.SuppressKeyPress = True

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ClearControls()
        BtnNewAdd.Enabled = True
        id.Text = Max_gp_table() + 1
        id_user.Text = (Max_gp_table() + 1).ToString() + (Form1.ToolStripStatusLabel2).ToString()
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnNewAdd.Visible = True
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Try

            Dim source_path, destpasth As String
            source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb"
            destpasth = "k:\gp_tafrgh_db.accdb"
            'My.Computer.FileSystem.CopyFile(source_path, destpasth)

            'MessageBox.Show("تم نسخ قاعدة بيانات")

            source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb"
            If My.Computer.FileSystem.FileExists(destpasth) = True Then
                My.Computer.FileSystem.DeleteFile(destpasth)

                My.Computer.FileSystem.CopyFile(source_path, destpasth)

                MessageBox.Show("تم نسخ قاعدة بيانات")
            Else
                My.Computer.FileSystem.CopyFile(source_path, destpasth)
                MessageBox.Show("تم نسخ قاعدة بيانات")
            End If
        Catch
            'My.Computer.FileSystem.CopyFile(source_path, destpasth)

            'MessageBox.Show("تم نسخ قاعدة بيانات")
            MessageBox.Show("يوجد قاعدة بيانات بنفس الاسم")
        End Try
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            Dim dv As DataView = DT_SEARCH_by_date.DefaultView
            dv.RowFilter = " descr LIKE '%" & TextBox1.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If BackgroundWorker1.IsBusy Then
            Label7.Text = "جارى التحميل 000"

        Else
            BackgroundWorker1.RunWorkerAsync()

        End If
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



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            ClearControls()
            SEARCH_by_DATE(date1.Value)
            dgv_gp_table.DataSource = DT_SEARCH_by_date
            DataGridViewHeaderText(dgv_gp_table)
            total_day()
            total_box()
            total_adyy()
            DataGridViewHeaderwith(dgv_gp_table)
            'ايجاد اخر سطرفى دات
            dgv_gp_table.Focus()
            dgv_gp_table.CurrentCell = dgv_gp_table.Rows(dgv_gp_table.RowCount - 1).Cells(1)
            idlbl.Text = dgv_gp_table.RowCount().ToString()
            BtnNewAdd.Enabled = True

            close_all_txtbox()
            BtnNewAdd.Visible = False
        Catch
            close_all_txtbox()
        End Try
    End Sub
    ' تجميع datagridview
    Public Sub total_day()
        Dim sum As Double = 0
        For s As Integer = 0 To dgv_gp_table.RowCount - 1
            sum = sum + dgv_gp_table.Item("el_mablgh", s).Value

        Next
        NumericUpDown1.Value = sum


    End Sub

    '==============================================
    'صناديق تجميع datagridview
    Public Sub total_box()
        Dim sum As Double = 0
        For a As Integer = 0 To dgv_gp_table.RowCount - 1
            If dgv_gp_table.Item("id_desc", a).Value = 2 Then
                sum = sum + dgv_gp_table.Item("el_mablgh", a).Value
            End If


        Next
        NumericUpDown2.Value = sum


    End Sub

    '==============================================
    ' تجميع عادى datagridview
    Public Sub total_adyy()
        Dim sum As Double = 0
        For a As Integer = 0 To dgv_gp_table.RowCount - 1
            If dgv_gp_table.Item("id_desc", a).Value = 1 Then
                sum = sum + dgv_gp_table.Item("el_mablgh", a).Value
            End If


        Next
        NumericUpDown3.Value = sum


    End Sub
    Private Sub el_mablgh_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles el_mablgh.KeyDown
        If e.KeyCode = Keys.Down Then
            no_gp.Focus()
            no_gp.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            el_mablgh.Focus()
            el_mablgh.BackColor = Color.Gold
        End If


    End Sub



    Private Sub no_gp_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles no_gp.KeyDown
        If e.KeyCode = Keys.Down Then
            descr.Focus()
            descr.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            el_mablgh.Focus()
            el_mablgh.BackColor = Color.Gold
        End If
    End Sub

    Private Sub descr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles descr.KeyDown
        If e.KeyCode = Keys.Down Then
            no_file.Focus()
            no_file.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            no_gp.Focus()
            no_gp.BackColor = Color.Gold
        End If
        'Try

        'Catch ex As Exception
        'MessageBox.Show(ex)
        'End Try

    End Sub

    Private Sub no_file_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles no_file.KeyDown
        If e.KeyCode = Keys.Down Then
            no_shatb.Focus()
            no_shatb.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            descr.Focus()
            descr.BackColor = Color.Gold
        End If
    End Sub

    Private Sub no_shatb_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles no_shatb.KeyDown
        If e.KeyCode = Keys.Down Then
            BtnNewAdd.Focus()
        End If

        If e.KeyCode = Keys.Up Then
            no_file.Focus()
        End If
    End Sub

    Private Sub Form_add_gp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress


    End Sub

    Private Sub dgv_gp_table_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_gp_table.CellEndEdit

        open_all_txtbox()
        Dim id_dess As Integer
        id_dess = id_desc.SelectedValue()
        updat()
        Update_gp_table(id_user.Text, date1.Value, descr.Text, no_file.Text, el_mablgh.Value, no_gp.Text, date_assthkk.Value, no_shatb.Text, id_dess, id.Value)
        total_adyy()
        close_all_txtbox()
        BtnNewAdd.Visible = False

    End Sub

    Public Sub updat()
        Try
            With dgv_gp_table
                Me.id.Text = .CurrentRow.Cells("id").Value.ToString()
                Me.id_user.Text = .CurrentRow.Cells("id_and_user").Value.ToString()
                Me.date1.Value = .CurrentRow.Cells("date1").Value.ToString()
                Me.descr.Text = .CurrentRow.Cells("descr").Value.ToString()
                Me.no_file.Text = .CurrentRow.Cells("no_file").Value.ToString()
                Me.el_mablgh.Text = .CurrentRow.Cells("el_mablgh").Value.ToString()
                Me.no_gp.Text = .CurrentRow.Cells("no_gp").Value.ToString()
                Me.date_assthkk.Value = .CurrentRow.Cells("date_assthkk").Value.ToString()
                Me.no_shatb.Text = .CurrentRow.Cells("no_shatb").Value.ToString()
                Me.id_desc.Text = .CurrentRow.Cells("id_desc").Value.ToString()
            End With
            BtnDelete.Enabled = True
            el_mablgh.Enabled = True
            no_gp.Enabled = True
            descr.Enabled = True
            no_file.Enabled = True
            no_shatb.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnNewAdd.Enabled = False
        BtnEdit.Enabled = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try

            Dim source_path, destpasth As String
            source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb"
            destpasth = "i:\gp_tafrgh_db.accdb"
            'My.Computer.FileSystem.CopyFile(source_path, destpasth)

            'MessageBox.Show("تم نسخ قاعدة بيانات")

            source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb"
            If My.Computer.FileSystem.FileExists(destpasth) = True Then
                My.Computer.FileSystem.DeleteFile(destpasth)

                My.Computer.FileSystem.CopyFile(source_path, destpasth)

                MessageBox.Show("تم نسخ قاعدة بيانات")
            Else
                My.Computer.FileSystem.CopyFile(source_path, destpasth)
                MessageBox.Show("تم نسخ قاعدة بيانات")
            End If
        Catch
            'My.Computer.FileSystem.CopyFile(source_path, destpasth)

            'MessageBox.Show("تم نسخ قاعدة بيانات")
            MessageBox.Show("يوجد قاعدة بيانات بنفس الاسم")
        End Try
        Close()
    End Sub

    Private Sub el_mablgh_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles el_mablgh.Leave
        el_mablgh.BackColor = Color.White
    End Sub

    Private Sub no_gp_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_gp.Leave
        no_gp.BackColor = Color.White
    End Sub

    Private Sub descr_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles descr.Leave
        descr.BackColor = Color.White
    End Sub

    Private Sub no_file_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_file.Leave
        no_file.BackColor = Color.White
    End Sub

    Private Sub no_shatb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_shatb.Leave
        no_shatb.BackColor = Color.White
    End Sub

    Private Sub id_desc_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_desc.Leave
        id_desc.BackColor = Color.White
    End Sub

    Private Sub el_mablgh_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles el_mablgh.MouseClick
        el_mablgh.BackColor = Color.Gold
    End Sub

    Private Sub no_gp_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles no_gp.MouseClick
        no_gp.BackColor = Color.Gold
    End Sub

    Private Sub descr_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles descr.MouseClick
        descr.BackColor = Color.Gold
    End Sub

    Private Sub no_file_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles no_file.MouseClick
        no_file.BackColor = Color.Gold
    End Sub

    Private Sub no_shatb_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles no_shatb.MouseClick
        no_shatb.BackColor = Color.Gold
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim daa As New OleDbDataAdapter
        'Dim reprt As New CrystalReport2
        Dim dv As New DataView
        Dim ds As New DataSet1






        daa = New OleDbDataAdapter(" SELECT gp_table.date1, gp_table.no_shatb, gp_table.descr, gp_table.el_mablgh, gp_table.no_gp, gp_table.no_file, gp_table.date_assthkk, dec_shatb_table.descr_shatb FROM (gp_table INNER JOIN dec_shatb_table ON gp_table.id_desc = dec_shatb_table.id_desc) WHERE date1 between #" & date1.Value.ToString("yyyy/MM/dd") & "# and #" & DateTimePicker1.Value.ToString("yyyy/MM/dd") & "#", con)
        daa.Fill(ds, "table_gps")
        dv = New DataView(ds.Tables("table_gps"))
        'reprt.SetDataSource(dv)



        'frm_viewer.CrystalReportViewer1.ReportSource = reprt
        frm_viewer.Show()
    End Sub
    '=====================close_textbox
    Public Sub close_all_txtbox()
        el_mablgh.Enabled = False
        no_gp.Enabled = False
        descr.Enabled = False
        no_file.Enabled = False
        no_shatb.Enabled = False
    End Sub

    '=======================open_textbox
    Public Sub open_all_txtbox()
        el_mablgh.Enabled = True
        no_gp.Enabled = True
        descr.Enabled = True
        no_file.Enabled = True
        no_shatb.Enabled = True
    End Sub




    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If DT_SEARCH_by_date.Rows.Count > 0 Then
            add_file()
            Dim xlApp As Microsoft.Office.Interop.Excel.Application
            Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlApp = New Microsoft.Office.Interop.Excel.Application
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            Dim inputFile As String = ((Application.StartupPath) & "\ProductsList.xlsx")
            'xlWorkSheet = xlWorkBook.Sheets("sheet1")
            xlWorkBook = xlApp.Workbooks.Open(inputFile)

            xlWorkSheet = xlWorkBook.ActiveSheet
            'ProgressBar1.Maximum = dgv_gp_table.RowCount


            For i = 0 To dgv_gp_table.RowCount - 1

                'ProgressBar1=====================
                ProgressBar1.Invoke(Sub() ProgressBar1.Value = i)
                Dim total_s As Double = 0
                total_s = (i * 1) / dgv_gp_table.RowCount
                total_s = total_s * 100
                total_s = Math.Round(total_s, 0)

                Label6.Invoke(Sub() Label6.Text = total_s.ToString() + "%".ToString())
                Label7.Invoke(Sub() Label7.Text = "جارى التحميل 00000")
                Label6.Invoke(Sub() Label6.Visible = True)
                Label7.Invoke(Sub() Label7.Visible = True)
                BackgroundWorker1.ReportProgress(j)
                ''=====================================
                For j = 0 To dgv_gp_table.ColumnCount - 1
                    For k As Integer = 1 To dgv_gp_table.Columns.Count
                        xlWorkSheet.Cells(1, k) = dgv_gp_table.Columns(k - 1).HeaderText
                        xlWorkSheet.Cells(i + 2, j + 1) = dgv_gp_table(j, i).Value.ToString()
                    Next

                Next

            Next
            xlWorkSheet.SaveAs((Application.StartupPath) & "\  يوميه" + id.Text + ".xlsx ")

            'xlWorkSheet.SaveAs("d:\يوميه" + id.Text + ".xlsx")
            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

            MsgBox("يوميه تم الحفظ بنجاحd:\" + id.Text)
            Label6.Invoke(Sub() Label6.Visible = False)
            Label7.Invoke(Sub() Label7.Visible = False)
            ProgressBar1.Invoke(Sub() ProgressBar1.Value = 0)
        Else
            MessageBox.Show("لا يوجد بيانات")

        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub



    Private Sub BtnEdit_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.EnabledChanged
        'Dim sender1 As Button
        'sender1.ForeColor = Color.Gray
        'sender = sender1

        If sender.Enabled = False Then
            sender.BackColor = Color.Gray
        Else
            sender.BackColor = Color.Green
            sender.ForeColor = Color.White
        End If
    End Sub

    Private Sub BtnNewAdd_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.EnabledChanged
        'If sender.Enabled = False Or sender.Visible = False Then
        '    sender.BackColor = Color.Gray
        'Else
        '    sender.BackColor = Color.Green
        '    sender.ForeColor = Color.White
        'End If

    End Sub

    Private Sub BtnDelete_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.EnabledChanged
        If sender.Enabled = False Then
            sender.BackColor = Color.Gray
        Else
            sender.BackColor = Color.Green
            sender.ForeColor = Color.White
        End If
    End Sub

    Private Sub el_mablgh_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles no_shatb.EnabledChanged, no_gp.EnabledChanged, no_file.EnabledChanged, el_mablgh.EnabledChanged, descr.EnabledChanged
        If sender.Enabled = False Then
            sender.BackColor = Color.Gray
        Else
            sender.BackColor = Color.Green
            sender.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub


End Class