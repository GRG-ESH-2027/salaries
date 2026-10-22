Imports System.Data.OleDb
Imports System.IO


Public Class Form_backup_data_base
    Dim source_path, destpasth As String

    Private Sub copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copy.Click
        Try
            Dim sfd As New SaveFileDialog
            sfd.Filter = "Access db |*.accdb"
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = sfd.FileName
                'Dim source_path, destpasth As String
                source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb"
                destpasth = sfd.FileName
                'My.Computer.FileSystem.CopyFile(source_path, destpasth)

                'MessageBox.Show("تم نسخ قاعدة بيانات")
            End If
            source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb"
            destpasth = TextBox1.Text
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




    End Sub

  


    Private Sub restorr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restorr.Click
        Dim source_path, destpasth, comp_despath As String
        Dim ofd As New OpenFileDialog

        'destpasth = Application.StartupPath & "\data\"
        destpasth = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData))
        comp_despath = Path.Combine(destpasth, "gp_tafrgh_db.accdb")
        ofd.Filter = "Access db |*.accdb"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            source_path = ofd.FileName

        End If
        If My.Computer.FileSystem.FileExists(comp_despath) = True Then
            My.Computer.FileSystem.DeleteFile(comp_despath)
            My.Computer.FileSystem.CopyFile(ofd.FileName, comp_despath)
            MsgBox("تم استعادة قاعدة بيانات")
        Else
            MsgBox("لا يوجد قاعده بيانات")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim sfd As New SaveFileDialog
            Dim source_path, destpasth As String
            source_path = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb"
            Dim dat As String


            dat = Format(Now(), "dd-mmm-yyyy")
            TextBox1.Text = dat
            destpasth = "t:\" + dat + ".accdb"

            My.Computer.FileSystem.CopyFile(source_path, destpasth)
            MessageBox.Show("تم نسخ قاعدة بيانات")
        Catch
            MessageBox.Show("يوجد قاعدة بيانات بنفس الاسم")
        End Try

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        add_file()

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

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Close()
    End Sub
End Class