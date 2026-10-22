Imports System.Data.OleDb


Module Module_add_mkf

    '======================================
    Public xlApp As Microsoft.Office.Interop.Excel.Application
    'Public xlApp As Microsoft.Office.Interop.Excel.Application
    Public xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
    Public xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
    Public misValue As Object = System.Reflection.Missing.Value
    '======================================
    Public dt_Table_Mkf As New DataTable
    Public Sub SelectAll_Table_Mkf(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_Table_Mkf.Clear()
        da = New OleDbDataAdapter("select * from Table_Mkf", con)
        da.Fill(dt_Table_Mkf)
        dgv.DataSource = dt_Table_Mkf
    End Sub

    Public Sub DataGridViewHeaderTxt(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Id_Mkf").HeaderText = "Id_Mkf"
                .Columns("Name_Mkf").HeaderText = "اسم المكافاة"
                .Columns("Item_Mkf").HeaderText = "نوع المكافاة"
                .Columns("Years").HeaderText = "العام"
                .Columns("term").HeaderText = "الدور"
            End With
        End If
    End Sub
    Public Function Max_Table_Mkf()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(Id_Mkf) From Table_Mkf ", con)
            If con.State = 1 Then con.Close()
            con.Open()
            Number = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Number = 0
            con.Close()
        End Try
        Return Number
    End Function

    Public Sub Insert_Table_Mkf(ByVal Name_Mkf As String, ByVal Item_Mkf As String, ByVal Years As String, ByVal term As String)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Table_Mkf ( Id_Mkf,Name_Mkf,Item_Mkf,Years,term)values(@Id_Mkf,@Name_Mkf,@Item_Mkf,@Years,@term)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Id_Mkf", OleDbType.Integer).Value = Max_Table_Mkf() + 1
            .Parameters.AddWithValue("@Name_Mkf", OleDbType.VarChar).Value = Name_Mkf
            .Parameters.AddWithValue("@Item_Mkf", OleDbType.VarChar).Value = Item_Mkf
            .Parameters.AddWithValue("@Years", OleDbType.VarChar).Value = Years
            .Parameters.AddWithValue("@term", OleDbType.VarChar).Value = term
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    'ط===========================================================
    'update
    '==========
    Public Sub Update_Table_Mkf(ByVal Id_Mkf As Integer, ByVal Name_Mkf As String, ByVal Item_Mkf As String, ByVal Years As String, ByVal term As String)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Table_Mkf Set Id_Mkf = @Id_Mkf,Name_Mkf = @Name_Mkf,Item_Mkf = @Item_Mkf,Years = @Years,term = @term Where Id_Mkf=@Id_Mkf"
            .Parameters.AddWithValue("@Id_Mkf", OleDbType.Integer).Value = Id_Mkf
            .Parameters.AddWithValue("@Name_Mkf", OleDbType.varchar).Value = Name_Mkf
            .Parameters.AddWithValue("@Item_Mkf", OleDbType.varchar).Value = Item_Mkf
            .Parameters.AddWithValue("@Years", OleDbType.varchar).Value = Years
            .Parameters.AddWithValue("@term", OleDbType.varchar).Value = term
        End With
        If Con.State = 1 Then Con.Close()
        COn.Open()
        Cmd.ExecuteNonQuery()
        COn.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    '==================
    Public Sub add_file_tfrgh_total()
        Dim source_pathh_total, destpasthhh_total As String
        'source_pathh = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\page_print_all_bnd.xls"
        source_pathh_total = (Application.StartupPath) & "\DATABASE\tfrgh_total.xlsx"


        destpasthhh_total = (Application.StartupPath) & "\tfrgh_total.xlsx"

        If My.Computer.FileSystem.FileExists(destpasthhh_total) = True Then
            My.Computer.FileSystem.DeleteFile(destpasthhh_total)
            My.Computer.FileSystem.CopyFile(source_pathh_total, destpasthhh_total)
        Else
            My.Computer.FileSystem.CopyFile(source_pathh_total, destpasthhh_total)

        End If

    End Sub


    '============================================
    Public Sub add_file()
        '================ 'نسخ ملف اكسيل
        Dim source_path, destpasth As String
        'source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\page_tfrgh.xls"
        source_path = (Application.StartupPath) & "\DATABASE\page_tfrgh.xlsx"

        destpasth = (Application.StartupPath) & "\page_tfrgh.xlsx"

        If My.Computer.FileSystem.FileExists(destpasth) = True Then
            My.Computer.FileSystem.DeleteFile(destpasth)
            My.Computer.FileSystem.CopyFile(source_path, destpasth)
            'MessageBox.Show("تم نسخ قاعدة بيانات")
        Else
            My.Computer.FileSystem.CopyFile(source_path, destpasth)

        End If
        '=============================================
        '================ 'نسخ ملف اكسيل
        Dim sourrce_path, destpasthh As String
        'sourrce_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\tfrgh_sanwy.xls"
        sourrce_path = (Application.StartupPath) & "\DATABASE\tfrgh_sanwy.xlsx"



        destpasthh = (Application.StartupPath) & "\tfrgh_sanwy.xlsx"

        If My.Computer.FileSystem.FileExists(destpasthh) = True Then
            My.Computer.FileSystem.DeleteFile(destpasthh)
            My.Computer.FileSystem.CopyFile(sourrce_path, destpasthh)
        Else
            My.Computer.FileSystem.CopyFile(sourrce_path, destpasthh)

        End If



        '===================================================

        'MessageBox.Show("تم نسخ قاعدة بيانات")
        '================ 'نسخ ملف اكسيل
        Dim source_pathh, destpasthhh As String
        'source_pathh = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\page_print_all_bnd.xls"
        source_pathh = (Application.StartupPath) & "\DATABASE\page_print_all_bnd.xls"


        destpasthhh = (Application.StartupPath) & "\page_print_all_bnd.xls"

        If My.Computer.FileSystem.FileExists(destpasthhh) = True Then
            My.Computer.FileSystem.DeleteFile(destpasthhh)
            My.Computer.FileSystem.CopyFile(source_pathh, destpasthhh)
        Else
            My.Computer.FileSystem.CopyFile(source_pathh, destpasthhh)

        End If



        'MessageBox.Show("تم نسخ قاعدة بيانات")
        '==============================================================
        '============================================================

        '================ 'نسخ ملف اكسيل
        Dim sourrce_path_pay, destpasthh_pay As String
        'sourrce_path_pay = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\Pay-krke_george-20190618-100047.xlsx"
        sourrce_path_pay = (Application.StartupPath) & "\DATABASE\Pay-krke_george-20190618-100047.xlsx"


        destpasthh_pay = (Application.StartupPath) & "\Pay-krke_george-20190618-100047.xlsx"

        If My.Computer.FileSystem.FileExists(destpasthh_pay) = True Then
            My.Computer.FileSystem.DeleteFile(destpasthh_pay)
            My.Computer.FileSystem.CopyFile(sourrce_path_pay, destpasthh_pay)
        Else
            My.Computer.FileSystem.CopyFile(sourrce_path_pay, destpasthh_pay)

        End If
        'MessageBox.Show("تم نسخ قاعدة بيانات")
        '================ 'نسخ ملف اكسيل
        '===========================================================================

        '==========================================================================

      
        '=============================================
        '================================================================
        'نسخ ملف اكسيل
        Dim srce_path, dest_pasth As String
        'srce_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\ProductsList.xlsx"
        srce_path = (Application.StartupPath) & "\DATABASE\ProductsList.xlsx"


        dest_pasth = (Application.StartupPath) & "\ProductsList.xlsx"

        If My.Computer.FileSystem.FileExists(dest_pasth) = True Then
            My.Computer.FileSystem.DeleteFile(dest_pasth)
            My.Computer.FileSystem.CopyFile(srce_path, dest_pasth)

        Else
            My.Computer.FileSystem.CopyFile(source_path, dest_pasth)
            'MessageBox.Show("تم نسخ قاعدة بيانات")
        End If
        '======================================================
        ' data_all'=
        '===============
        Dim source_data_all, destpas_data_all As String
        'source_pathh = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\page_print_all_bnd.xls"
        source_data_all = (Application.StartupPath) & "\DATABASE\data_all.xlsx"


        destpas_data_all = (Application.StartupPath) & "\data_all.xlsx"

        If My.Computer.FileSystem.FileExists(destpas_data_all) = True Then
            My.Computer.FileSystem.DeleteFile(destpas_data_all)
            My.Computer.FileSystem.CopyFile(source_data_all, destpas_data_all)
        Else
            My.Computer.FileSystem.CopyFile(source_data_all, destpas_data_all)

        End If

        '====================================================
    End Sub
    '=========================================================

End Module
