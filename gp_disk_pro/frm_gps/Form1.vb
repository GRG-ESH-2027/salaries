Imports System.IO

Public Class Form1
    Public log, log_2, sum_log As Integer

    Private Sub ادخاليوميهجديدهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادخاليوميهجديدهToolStripMenuItem.Click
        close_all()
        Form_add_gp.Icon = Me.Icon
        Form_add_gp.MdiParent = Me
        Form_add_gp.Show()
    End Sub











    Private Sub Form1_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        Try
            'Dim sfd As New SaveFileDialog
            Dim source_path, destpasth As String
            source_path = (Application.StartupPath) & "\gp_tafrgh_db.accdb"
            'Dim dat As String


            'dat = Format(Now(), "dd-mm-yyyy")

            destpasth = "d:\gp_tafrgh_db.accdb"

            If My.Computer.FileSystem.FileExists(destpasth) = True Then
                My.Computer.FileSystem.DeleteFile(destpasth)
                My.Computer.FileSystem.CopyFile(source_path, destpasth)
                MessageBox.Show("تم نسخ قاعدة بيانات")
            Else
                My.Computer.FileSystem.CopyFile(source_path, destpasth)
                MessageBox.Show("تم نسخ قاعدة بيانات")
            End If
        Catch
            MessageBox.Show("يوجد قاعدة بيانات بنفس الاسم")
        End Try

    End Sub

    Private Sub بحثفىيوميهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بحثفىيوميهToolStripMenuItem.Click
        close_all()
        Form_all_gps.Icon = Me.Icon
        Form_all_gps.MdiParent = Me
        Form_all_gps.Show()
    End Sub

    Private Sub تقريريوموشهرToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تقريريوموشهرToolStripMenuItem.Click
        close_all()
        Form_report_day.stat_form = "add"
        Form_report_day.MdiParent = Me
        Form_report_day.Show()
        Form_report_day.Label1.Text = "جملة اليوم"
    End Sub

    Private Sub تقريريوميةصناديقToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تقريريوميةصناديقToolStripMenuItem1.Click
        close_all()
        Form_report_day.stat_form = "box"
        Form_report_day.MdiParent = Me
        Form_report_day.Show()
        Form_report_day.Label1.Text = "جملة الصناديق"
    End Sub

    Private Sub جولالبرنامجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles جولالبرنامجToolStripMenuItem.Click
        close_all()
        frm_hlep.MdiParent = Me
        frm_hlep.Show()
    End Sub

    Private Sub اضافةمكافاةجديدهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةمكافاةجديدهToolStripMenuItem.Click
        'close_all()
        'Form_add_mkf.MdiParent = Me
        Form_add_mkf.ShowDialog()
    End Sub

    Private Sub تحديثبياناتموظفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تحديثبياناتموظفToolStripMenuItem.Click
        'close_all()
        'Form_update_emp.MdiParent = Me
        'Form_update_emp.Show()
    End Sub

    Private Sub انشاءكشفجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles انشاءكشفجديدToolStripMenuItem.Click
        close_all()
        Form_add_tfrgh.Icon = Me.Icon
        Form_add_tfrgh.MdiParent = Me
        Form_add_tfrgh.btn_mkf.Text = "مكافاة 5%"
        Form_add_tfrgh.mkf_count = 5
        Form_add_tfrgh.Label14.Text = "تفريغ اعدادى"
        Form_add_tfrgh.Show()
        Form_add_tfrgh.stat_frm = "add"
    End Sub







    Private Sub طباعةكشفExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةكشفExcelToolStripMenuItem.Click
        close_all()
        Form_print_tfrgh.Icon = Me.Icon
        Form_print_tfrgh.MdiParent = Me
        Form_print_tfrgh.stat = "اعدادى"
        Form_print_tfrgh.name_page.Text = "صفحة طباعة مكافاة اعدادي"
        Form_print_tfrgh.Show()
    End Sub

    Private Sub طباعةتقريركشفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةتقريركشفToolStripMenuItem.Click
        'close_all()
        'Form_print_crystal.MdiParent = Me
        'Form_print_crystal.Show()
        close_all()
        total_kshf_form.MdiParent = Me
        total_kshf_form.Show()

    End Sub

    Private Sub طباعةكشفثانوىExcellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةكشفثانوىExcellToolStripMenuItem.Click
        'close_all()
        'Form_print_tfrgh.MdiParent = Me

        'Form_print_tfrgh.stat = "ثانوى"
        'Form_print_tfrgh.name_page.Text = "صفحة طباعة مكافاة ثانوي"
        'Form_print_tfrgh.name_page.ForeColor = Color.DarkOrange
        'Form_print_tfrgh.Show()
    End Sub

    Private Sub طباعةتقريريوميهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةتقريريوميهToolStripMenuItem.Click
        close_all()
        Form_report_gps.MdiParent = Me
        Form_report_gps.Show()
    End Sub

    Private Sub طباعةتقريركشفتفريغثانوىToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةتقريركشفتفريغثانوىToolStripMenuItem.Click
        'close_all()
        'Form_print_crystal.MdiParent = Me
        'Form_print_crystal.Label3.Text = "صفحة طباعة كشف ثانوى"
        'Form_print_crystal.Show()
        close_all()
        total_kshf_form.MdiParent = Me
        total_kshf_form.Show()

    End Sub

    Private Sub حذفجميعالكشوفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفجميعالكشوفToolStripMenuItem.Click
        close_all()
        'Form_delete_all_kashf.MdiParent = Me
        Form_delete_all_kashf.ShowDialog()


    End Sub


    Private Sub انشاءكشفاجمالىبنودToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles انشاءكشفاجمالىبنودToolStripMenuItem.Click
        'close_all()
        'Form_enter_data_bnd.MdiParent = Me

        'Form_enter_data_bnd.Show()
    End Sub

    Private Sub طباعةكشفاجمالىبنودExcellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةكشفاجمالىبنودExcellToolStripMenuItem.Click
        close_all()
        Form_print_excell_all_total_bnd.MdiParent = Me

        Form_print_excell_all_total_bnd.Show()
    End Sub

    Private Sub طباعةتقريراجمالىبنودToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةتقريراجمالىبنودToolStripMenuItem.Click
        close_all()
        Form_print_crstal_total_bnd.MdiParent = Me

        Form_print_crstal_total_bnd.Show()
    End Sub

    Private Sub تعديلاسماءالاعمدةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلاسماءالاعمدةToolStripMenuItem.Click
        close_all()
        Form_edite_bnd_name.MdiParent = Me

        Form_edite_bnd_name.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon("gp_disk_pro.exe")
        PictureBox1.Image = Icon.ExtractAssociatedIcon("gp_disk_pro.exe").ToBitmap()
        '================================
        'BackgroundImage = Image.FromFile("C:\2024.jpg")
        BackgroundImage = Image.FromFile((Application.StartupPath) & "\Resources\2025.jpeg")

        'Dim ofd As New OpenFileDialog
        'ofd.ShowDialog()
        'Dim bgimage As String = ofd.FileName.ToString()
        'Me.BackgroundImage = New System.Drawing.Bitmap(bgimage)
        'My.Settings.setBGImage = bgimage
        'My.Settings.Save()

        'If My.Settings.setBGImage = "" Then
        '    '
        'Else
        '    'Me.BackgroundImage = New System.Drawing.Bitmap(My.Settings.setBGImage)
        'End If
        '===================================

        MenuStrip1.Enabled = False
        auto_user()
        combox_user_name.DataSource = dt_user
        combox_user_name.DisplayMember = "user_name"
        num_pass.Focus()
        '=====================================
        'حفظ كلمة السر
        num_pass.Text = My.Settings.pass
        combox_user_name.Text = My.Settings.user_name

    End Sub

    Private Sub انشاءكشفثانوىToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles انشاءكشفثانوىToolStripMenuItem1.Click
        close_all()
        Form_add_tfrgh.Icon = Me.Icon
        Form_add_tfrgh.MdiParent = Me
        Form_add_tfrgh.btn_mkf.Text = "مكافاة 7%"
        Form_add_tfrgh.mkf_count = 7
        Form_add_tfrgh.Label14.Text = "تفريغ ثانوى"
        Form_add_tfrgh.Show()
        Form_add_tfrgh.stat_frm = "add"

    End Sub

    Private Sub تعديلكشفثانوىToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلكشفثانوىToolStripMenuItem.Click
        close_all()
        Form_add_tfrgh.Icon = Me.Icon
        Form_add_tfrgh.MdiParent = Me
        Form_add_tfrgh.btn_mkf.Text = "مكافاة 7%"
        Form_add_tfrgh.mkf_count = 7


        Form_add_tfrgh.Label14.Text = "تفريغ ثانوى"
        Form_add_tfrgh.stat_frm = "edit"
        'Form_add_tfrgh.ListBox1.Visible = True
        'Form_add_tfrgh.Button3.Visible = True
        'Form_add_tfrgh.no_kashfff.Visible = True

        Form_add_tfrgh.Label15.Visible = True
        Form_add_tfrgh.WindowState = FormWindowState.Maximized
        Form_add_tfrgh.Show()

    End Sub

    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.Click


        If My.Settings.logon_user1 > 20 Then
            MessageBox.Show(" لقد تجاوزت عدد مرات ادخال الرقم السرى خطا اكثرة من مرة !")
            Exit Sub
        End If
        '=============================================================================
        logon_user(combox_user_name.Text, num_pass.Text)

        If dt_logon_user.Rows.Count > 0 Then
            'MessageBox.Show("تم تسجيل الدخول")
            Label4.Text = "تم تسجيل الدخول"
            'MdiParent.Show()
            '=================================================
            'حفظ كلمة المرور
            If CheckBox2.CheckState = CheckState.Checked Then
                My.Settings.pass = num_pass.Text
                My.Settings.user_name = combox_user_name.Text



            End If
            '==========================
            MenuStrip1.Enabled = True
            Panel1.Visible = False

            'Form1.ToolStripStatusLabel2.Text = dt_logon_user.Rows(0)(1)
            'Form1.ToolStripStatusLabel3.Text = dt_logon_user.Rows(0)(0)
            Me.ToolStripStatusLabel2.Text = dt_logon_user.Rows(0)(1)
            Me.ToolStripStatusLabel3.Text = dt_logon_user.Rows(0)(0)



        Else
            MessageBox.Show(" برجاء التاكد من اسم المستخدم و كلمة المرور !")
            Label4.Text = "  برجاء التاكد من اسم المستخدم و كلمة المرور ! "
            log = Convert.ToInt32(Label3.Text)
            log_2 = My.Settings.logon_user1
            sum_log = (log + log_2)
            Label3.Text = sum_log.ToString()


        End If
        If Convert.ToInt32(Label3.Text) > 5 Then
            MessageBox.Show(" لقد ادخلت الرقم السرى خطا اكثرة من مرة !")
            My.Settings.logon_user1 = sum_log
            'Application.Exit()

        End If


    End Sub



    '==========================





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub

    Private Sub combox_user_name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combox_user_name.SelectedIndexChanged
        num_pass.Focus()

    End Sub

    Private Sub تعديلكشفاعدادىToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلكشفاعدادىToolStripMenuItem.Click
        close_all()

        Form_add_tfrgh.MdiParent = Me
        Form_add_tfrgh.btn_mkf.Text = "مكافاة 5%"
        Form_add_tfrgh.mkf_count = 5
        Form_add_tfrgh.Label14.Text = "تفريغ اعدادى"

        Form_add_tfrgh.stat_frm = "edit"
        'Form_add_tfrgh.ListBox1.Visible = True
        'Form_add_tfrgh.Button3.Visible = True
        'Form_add_tfrgh.no_kashfff.Visible = True

        Form_add_tfrgh.Label15.Visible = True
        Form_add_tfrgh.Show()

    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        My.Settings.pass = num_pass.Text
        My.Settings.user_name = combox_user_name.Text
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            CheckBox2.Text = "اخفاء"
            num_pass.PasswordChar = Nothing
        Else
            CheckBox2.Text = "اظهار"
            num_pass.PasswordChar = "*"
        End If

    End Sub

    Private Sub اخرىToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اخرىToolStripMenuItem.Click
        close_all()
        try_form.MdiParent = Me
        try_form.Show()
    End Sub

    Private Sub خروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles خروجToolStripMenuItem.Click
        Try
            'Dim sfd As New SaveFileDialog
            Dim source_path, destpasth As String
            source_path = (Application.StartupPath) & "\gp_tafrgh_db.accdb"
            'Dim dat As String


            'dat = Format(Now(), "dd-mm-yyyy")

            destpasth = "d:\gp_tafrgh_db.accdb"

            If My.Computer.FileSystem.FileExists(destpasth) = True Then
                My.Computer.FileSystem.DeleteFile(destpasth)
                My.Computer.FileSystem.CopyFile(source_path, destpasth)
                MessageBox.Show("تم نسخ قاعدة بيانات")
            Else
                My.Computer.FileSystem.CopyFile(source_path, destpasth)
                MessageBox.Show("تم نسخ قاعدة بيانات")
            End If
        Catch
            MessageBox.Show("يوجد قاعدة بيانات بنفس الاسم")
        End Try


    End Sub

    Private Sub نسخالاحتياطىToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles نسخالاحتياطىToolStripMenuItem.Click
        close_all()

        Form_backup_data_base.MdiParent = Me
        Form_backup_data_base.Show()
    End Sub

    Private Sub اضافةمستخدمجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةمستخدمجديدToolStripMenuItem.Click
        close_all()

        'Form_Add_user.MdiParent = Me
        'Form_Add_user.ShowDialog()
        Form_password.ShowDialog()
    End Sub

    Private Sub عرضبياناتموظفينبالقاعدةالحاليةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضبياناتموظفينبالقاعدةالحاليةToolStripMenuItem.Click
        close_all()

        Form_view_all_emp.MdiParent = Me
        'Form_Add_user.ShowDialog()
        Form_view_all_emp.Show()
    End Sub

    Private Sub تحديثبياناتالموظفينبالقاعدةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تحديثبياناتالموظفينبالقاعدةToolStripMenuItem.Click
        close_all()

        Form_update_emp2.MdiParent = Me
        'Form_Add_user.ShowDialog()
        Form_update_emp2.Show()


    End Sub

    Private Sub عرضكلكشوفالتفريغToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضكلكشوفالتفريغToolStripMenuItem.Click
        close_all()

        search_tafrgh.MdiParent = Me
        search_tafrgh.Show()
    End Sub

    Private Sub تصديركشوفامردفعToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تصديركشوفامردفعToolStripMenuItem.Click

        close_all()

        Form_pay.MdiParent = Me
        Form_pay.Show()


    End Sub

    Private Sub اضافةمرتباساسىToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةمرتباساسىToolStripMenuItem.Click


        'salary_add_Form.MdiParent = Me
        salary_add_Form.Show()
    End Sub

    Private Sub بحثعنموظفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles بحثعنموظفToolStripMenuItem.Click

        search_emp_q.MdiParent = Me
        search_emp_q.btn_select.Visible = False
        search_emp_q.Show()
    End Sub

    Private Sub الهحاسبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الهحاسبToolStripMenuItem.Click

        cal_form.MdiParent = Me
        cal_form.Show()
    End Sub

    Private Sub استيرادقاعدةبياناتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles استيرادقاعدةبياناتToolStripMenuItem.Click
        close_all()
        export_from_database_Form.Icon = Me.Icon

        export_from_database_Form.MdiParent = Me
        export_from_database_Form.MaximizeBox = True
        export_from_database_Form.Show()
    End Sub



    Private Sub تعديلكشفثانوىToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلكشفثانوىToolStripMenuItem1.Click
        close_all()


        edit_form_tafrgh.MdiParent = Me
        edit_form_tafrgh.Icon = Me.Icon
        edit_form_tafrgh.btn_mkf.Text = "مكافاة 7%"
        edit_form_tafrgh.mkf_count = 7
        edit_form_tafrgh.Label14.Text = "تفريغ ثانوى"
        'close_all_forms(edit_form_tafrgh)
        edit_form_tafrgh.Show()
        edit_form_tafrgh.stat_frm = "add"
    End Sub

    Private Sub تعديلكشفاعداى2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلكشفاعداى2ToolStripMenuItem.Click
        close_all()
        edit_form_tafrgh.Icon = Me.Icon
        edit_form_tafrgh.MdiParent = Me
        edit_form_tafrgh.btn_mkf.Text = "مكافاة 5%"
        edit_form_tafrgh.mkf_count = 5
        edit_form_tafrgh.Label14.Text = "تفريغ اعدادى"
        edit_form_tafrgh.Show()
        edit_form_tafrgh.stat_frm = "add"
    End Sub

    Private Sub تعديلكشفاعدادىToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تعديلكشفاعدادىToolStripMenuItem1.Click
        close_all()
        Form_add_tfrgh.Icon = Me.Icon
        Form_add_tfrgh.MdiParent = Me
        Form_add_tfrgh.btn_mkf.Text = "مكافاة 5%"
        Form_add_tfrgh.mkf_count = 5
        Form_add_tfrgh.Label14.Text = "تفريغ اعدادى"
        Form_add_tfrgh.Show()
        Form_add_tfrgh.stat_frm = "edite"
    End Sub

    Private Sub اضافةملفاكسيلشرطهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةملفاكسيلشرطهToolStripMenuItem.Click

        close_all()
        excel_add_form.Icon = Me.Icon
        excel_add_form.mkf_count = 7
        excel_add_form.id_Mkff = 2

        excel_add_form.MdiParent = Me
        excel_add_form.MaximizeBox = True
        excel_add_form.Show()
    End Sub

    Private Sub اضافةملفاكسيلشرطةاعداديهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةملفاكسيلشرطةاعداديهToolStripMenuItem.Click
        close_all()
        excel_add_form.Icon = Me.Icon
        excel_add_form.mkf_count = 5
        excel_add_form.id_Mkff = 1
        excel_add_form.Label1.Text = "صفحة ادخال ملف اكسيل اعداديه شرطه"
        excel_add_form.MdiParent = Me
        excel_add_form.MaximizeBox = True
        excel_add_form.Show()

    End Sub

    Private Sub نسخنصToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles نسخنصToolStripMenuItem.Click
        Form_select_text.Icon = Me.Icon


        Form_select_text.Show()

    End Sub

    Private Sub تحميلملفاكسيللتعديلالاساسىالجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تحميلملفاكسيللتعديلالاساسىالجديدToolStripMenuItem.Click
        close_all()

        Edit_salary_ass_Form.MdiParent = Me


        Edit_salary_ass_Form.Show()

    End Sub

    Private Sub اضافةموظفجديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةموظفجديدToolStripMenuItem.Click

        add_emp_frm.MdiParent = Me

        add_emp_frm.Show()
    End Sub


    Private Sub اضافةتسويهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةتسويهToolStripMenuItem.Click
        close_all()
        add_taswy_frm.Icon = Me.Icon

        add_taswy_frm.MdiParent = Me

        add_taswy_frm.Show()
        add_taswy_frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub طباعةتسويهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طباعةتسويهToolStripMenuItem.Click
        close_all()
        print_taswy_frm.Icon = Me.Icon

        print_taswy_frm.MdiParent = Me

        print_taswy_frm.Show()
        print_taswy_frm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub اضافةنـــدبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةنـــدبToolStripMenuItem.Click


        close_all()
        add_ndb_frm.Icon = Me.Icon

        add_ndb_frm.MdiParent = Me

        add_ndb_frm.Show()

    End Sub

    Private Sub اضافةملفاكسيلندبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةملفاكسيلندبToolStripMenuItem.Click
        close_all()
        ndb_frm_all_excel_upload.Icon = Me.Icon

        ndb_frm_all_excel_upload.MdiParent = Me

        ndb_frm_all_excel_upload.Show()
    End Sub

    Private Sub اضافةضرائبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةضرائبToolStripMenuItem.Click
        close_all()
        add_darab_frm.Icon = Me.Icon

        add_darab_frm.MdiParent = Me

        add_darab_frm.Show()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        offece = 12
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        offece = 16
    End Sub

    Private Sub حذفجميعجداولالضرائبToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفجميعجداولالضرائبToolStripMenuItem.Click
        close_all()

        Deled_all_drab_shatb.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            offece = 12
            My.Settings.DbProviderVersion = 12

        ElseIf RadioButton2.Checked = True Then

            offece = 16
            My.Settings.DbProviderVersion = 16


        End If
        My.Settings.Save()
        MsgBox("تم حفظ إعداد الاتصال بنجاح ✅")

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label5.Text = DateTime.Now.ToString()

    End Sub

End Class
