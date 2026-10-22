<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class export_from_database_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.name_emplbl = New System.Windows.Forms.Label()
        Me.name_adderss = New System.Windows.Forms.TextBox()
        Me.dgv_data_base = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.id_and_user_tfg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_kshf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_Em = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_school = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salary_ass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dayes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mkf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Badl_safer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entklat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mashat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mashat8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Darabb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nkaba = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mhann = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mastshfa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Damghh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Earaadta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.box20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Mostkta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saffy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Mkf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.op_id_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.op_name_pay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.op_al_kta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.op_no_emb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saffy_after_antkal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nakab_yes_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chb_tsh_mlahza = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Auto_emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Auto_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chb_mlahza = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chb_ٍsharta = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chb_zar_shee = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.open_file = New System.Windows.Forms.Button()
        Me.btn_delete_data = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_selcet_data = New System.Windows.Forms.Button()
        Me.Btn_add = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox_search = New System.Windows.Forms.TextBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Entklatlbl = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgv_data_base, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'name_emplbl
        '
        Me.name_emplbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.name_emplbl.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_emplbl.ForeColor = System.Drawing.Color.DarkOrange
        Me.name_emplbl.Location = New System.Drawing.Point(45, 9)
        Me.name_emplbl.Name = "name_emplbl"
        Me.name_emplbl.Size = New System.Drawing.Size(1268, 39)
        Me.name_emplbl.TabIndex = 0
        Me.name_emplbl.Text = "استرداد قاعدة بيانات  اخرى( كشوف تفريغ )"
        Me.name_emplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'name_adderss
        '
        Me.name_adderss.Location = New System.Drawing.Point(7, 7)
        Me.name_adderss.Name = "name_adderss"
        Me.name_adderss.ReadOnly = True
        Me.name_adderss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.name_adderss.Size = New System.Drawing.Size(604, 29)
        Me.name_adderss.TabIndex = 1
        '
        'dgv_data_base
        '
        Me.dgv_data_base.AllowUserToAddRows = False
        Me.dgv_data_base.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_data_base.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_data_base.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_data_base.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_data_base.ColumnHeadersHeight = 44
        Me.dgv_data_base.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.id_and_user_tfg, Me.id, Me.No_55, Me.no_kshf, Me.Name_Em, Me.Name_school, Me.Salary_ass, Me.Dayes, Me.Mkf, Me.Badl_safer, Me.Entklat, Me.total, Me.Mashat, Me.Mashat8, Me.Darabb, Me.nkaba, Me.Mhann, Me.Mastshfa, Me.Damghh, Me.Earaadta, Me.box20, Me.Total_Mostkta, Me.Saffy, Me.Id_Mkf, Me.date1, Me.op_id_no, Me.op_name_pay, Me.op_al_kta, Me.op_no_emb, Me.Saffy_after_antkal, Me.nakab_yes_no, Me.chb_tsh_mlahza, Me.id_user, Me.Auto_emp, Me.Auto_total, Me.chb_mlahza, Me.chb_ٍsharta, Me.chb_zar_shee})
        Me.dgv_data_base.Location = New System.Drawing.Point(42, 254)
        Me.dgv_data_base.Name = "dgv_data_base"
        Me.dgv_data_base.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_data_base.Size = New System.Drawing.Size(1815, 484)
        Me.dgv_data_base.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "اختيار"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 52
        '
        'id_and_user_tfg
        '
        Me.id_and_user_tfg.DataPropertyName = "id_and_user_tfg"
        Me.id_and_user_tfg.HeaderText = "id_and_user_tfr"
        Me.id_and_user_tfg.Name = "id_and_user_tfg"
        Me.id_and_user_tfg.Width = 165
        '
        'id
        '
        Me.id.DataPropertyName = "Id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Width = 50
        '
        'No_55
        '
        Me.No_55.DataPropertyName = "No_55"
        Me.No_55.HeaderText = "55 ع ح"
        Me.No_55.Name = "No_55"
        Me.No_55.Width = 88
        '
        'no_kshf
        '
        Me.no_kshf.DataPropertyName = "no_kshf"
        Me.no_kshf.HeaderText = "رقم الكشف"
        Me.no_kshf.Name = "no_kshf"
        Me.no_kshf.Width = 102
        '
        'Name_Em
        '
        Me.Name_Em.DataPropertyName = "Name_Emp"
        Me.Name_Em.HeaderText = "اسم الموظف"
        Me.Name_Em.Name = "Name_Em"
        Me.Name_Em.Width = 112
        '
        'Name_school
        '
        Me.Name_school.DataPropertyName = "Name_school"
        Me.Name_school.HeaderText = "المدرسة"
        Me.Name_school.Name = "Name_school"
        Me.Name_school.Width = 86
        '
        'Salary_ass
        '
        Me.Salary_ass.DataPropertyName = "Salary_ass"
        Me.Salary_ass.HeaderText = "اساسى المرتب"
        Me.Salary_ass.Name = "Salary_ass"
        Me.Salary_ass.Width = 124
        '
        'Dayes
        '
        Me.Dayes.DataPropertyName = "Dayes"
        Me.Dayes.HeaderText = "الايام"
        Me.Dayes.Name = "Dayes"
        Me.Dayes.Width = 64
        '
        'Mkf
        '
        Me.Mkf.DataPropertyName = "Mkf"
        Me.Mkf.HeaderText = "مكافاة"
        Me.Mkf.Name = "Mkf"
        Me.Mkf.Width = 71
        '
        'Badl_safer
        '
        Me.Badl_safer.DataPropertyName = "Badl_safer"
        Me.Badl_safer.HeaderText = "بدل سفر"
        Me.Badl_safer.Name = "Badl_safer"
        Me.Badl_safer.Width = 87
        '
        'Entklat
        '
        Me.Entklat.DataPropertyName = "Entklat"
        Me.Entklat.HeaderText = "انتقالات"
        Me.Entklat.Name = "Entklat"
        Me.Entklat.Width = 80
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "اجمالى"
        Me.total.Name = "total"
        Me.total.Width = 76
        '
        'Mashat
        '
        Me.Mashat.DataPropertyName = "Mashat"
        Me.Mashat.HeaderText = "معاشات"
        Me.Mashat.Name = "Mashat"
        Me.Mashat.Width = 82
        '
        'Mashat8
        '
        Me.Mashat8.DataPropertyName = "Mashat8"
        Me.Mashat8.HeaderText = "1 %"
        Me.Mashat8.Name = "Mashat8"
        Me.Mashat8.Width = 69
        '
        'Darabb
        '
        Me.Darabb.DataPropertyName = "Darabb"
        Me.Darabb.HeaderText = "ضرائب"
        Me.Darabb.Name = "Darabb"
        Me.Darabb.Width = 79
        '
        'nkaba
        '
        Me.nkaba.DataPropertyName = "nkaba"
        Me.nkaba.HeaderText = "nkaba"
        Me.nkaba.Name = "nkaba"
        Me.nkaba.Width = 86
        '
        'Mhann
        '
        Me.Mhann.DataPropertyName = "Mhann"
        Me.Mhann.HeaderText = "مهن"
        Me.Mhann.Name = "Mhann"
        Me.Mhann.Width = 62
        '
        'Mastshfa
        '
        Me.Mastshfa.DataPropertyName = "Mastshfa"
        Me.Mastshfa.HeaderText = "مستشفى"
        Me.Mastshfa.Name = "Mastshfa"
        Me.Mastshfa.Width = 89
        '
        'Damghh
        '
        Me.Damghh.DataPropertyName = "Damghh"
        Me.Damghh.HeaderText = "دمغة"
        Me.Damghh.Name = "Damghh"
        Me.Damghh.Width = 65
        '
        'Earaadta
        '
        Me.Earaadta.DataPropertyName = "Earaadta"
        Me.Earaadta.HeaderText = "ايرادات"
        Me.Earaadta.Name = "Earaadta"
        Me.Earaadta.Width = 79
        '
        'box20
        '
        Me.box20.DataPropertyName = "box20"
        Me.box20.HeaderText = "صندوق"
        Me.box20.Name = "box20"
        Me.box20.Width = 83
        '
        'Total_Mostkta
        '
        Me.Total_Mostkta.DataPropertyName = "Total_Mostkta"
        Me.Total_Mostkta.HeaderText = "جملة المستقطع"
        Me.Total_Mostkta.Name = "Total_Mostkta"
        Me.Total_Mostkta.Width = 128
        '
        'Saffy
        '
        Me.Saffy.DataPropertyName = "Saffy"
        Me.Saffy.HeaderText = "صافى"
        Me.Saffy.Name = "Saffy"
        Me.Saffy.Width = 71
        '
        'Id_Mkf
        '
        Me.Id_Mkf.DataPropertyName = "Id_Mkf"
        Me.Id_Mkf.HeaderText = "Id_Mkf"
        Me.Id_Mkf.Name = "Id_Mkf"
        Me.Id_Mkf.Width = 97
        '
        'date1
        '
        Me.date1.DataPropertyName = "date1"
        Me.date1.HeaderText = "التاريخ"
        Me.date1.Name = "date1"
        Me.date1.Width = 76
        '
        'op_id_no
        '
        Me.op_id_no.DataPropertyName = "op_id_no"
        Me.op_id_no.HeaderText = "رقم القومى"
        Me.op_id_no.Name = "op_id_no"
        Me.op_id_no.Width = 103
        '
        'op_name_pay
        '
        Me.op_name_pay.DataPropertyName = "op_name_pay"
        Me.op_name_pay.HeaderText = "نوع العملية"
        Me.op_name_pay.Name = "op_name_pay"
        Me.op_name_pay.Width = 104
        '
        'op_al_kta
        '
        Me.op_al_kta.DataPropertyName = "op_al_kta"
        Me.op_al_kta.HeaderText = "القطاع"
        Me.op_al_kta.Name = "op_al_kta"
        Me.op_al_kta.Width = 73
        '
        'op_no_emb
        '
        Me.op_no_emb.DataPropertyName = "op_no_emb"
        Me.op_no_emb.HeaderText = "رقم الموظف"
        Me.op_no_emb.Name = "op_no_emb"
        Me.op_no_emb.Width = 110
        '
        'Saffy_after_antkal
        '
        Me.Saffy_after_antkal.DataPropertyName = "Saffy_after_antkal"
        Me.Saffy_after_antkal.HeaderText = "الصافى بعدالانتقالات"
        Me.Saffy_after_antkal.Name = "Saffy_after_antkal"
        Me.Saffy_after_antkal.Width = 157
        '
        'nakab_yes_no
        '
        Me.nakab_yes_no.DataPropertyName = "nakab_yes_no"
        Me.nakab_yes_no.HeaderText = "نقابى او غير نقابى"
        Me.nakab_yes_no.Name = "nakab_yes_no"
        Me.nakab_yes_no.Width = 148
        '
        'chb_tsh_mlahza
        '
        Me.chb_tsh_mlahza.DataPropertyName = "chb_tsh_mlahza"
        Me.chb_tsh_mlahza.HeaderText = "ملاحظه ام تصحيح"
        Me.chb_tsh_mlahza.Name = "chb_tsh_mlahza"
        Me.chb_tsh_mlahza.Width = 148
        '
        'id_user
        '
        Me.id_user.DataPropertyName = "id_user"
        Me.id_user.HeaderText = "المستخدم"
        Me.id_user.Name = "id_user"
        Me.id_user.Width = 92
        '
        'Auto_emp
        '
        Me.Auto_emp.DataPropertyName = "Auto_emp"
        Me.Auto_emp.HeaderText = "اسم يدوى"
        Me.Auto_emp.Name = "Auto_emp"
        Me.Auto_emp.Width = 96
        '
        'Auto_total
        '
        Me.Auto_total.DataPropertyName = "Auto_total"
        Me.Auto_total.HeaderText = "جملة يدوى"
        Me.Auto_total.Name = "Auto_total"
        Me.Auto_total.Width = 103
        '
        'chb_mlahza
        '
        Me.chb_mlahza.DataPropertyName = "chb_mlahza"
        Me.chb_mlahza.HeaderText = "ملاحظه"
        Me.chb_mlahza.Name = "chb_mlahza"
        Me.chb_mlahza.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chb_mlahza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chb_mlahza.Width = 81
        '
        'chb_ٍsharta
        '
        Me.chb_ٍsharta.DataPropertyName = "chb_ٍsharta"
        Me.chb_ٍsharta.HeaderText = "شرطه"
        Me.chb_ٍsharta.Name = "chb_ٍsharta"
        Me.chb_ٍsharta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chb_ٍsharta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chb_ٍsharta.Width = 73
        '
        'chb_zar_shee
        '
        Me.chb_zar_shee.DataPropertyName = "chb_zar_shee"
        Me.chb_zar_shee.HeaderText = "زائر صحى"
        Me.chb_zar_shee.Name = "chb_zar_shee"
        Me.chb_zar_shee.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chb_zar_shee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chb_zar_shee.Width = 101
        '
        'open_file
        '
        Me.open_file.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.open_file.ForeColor = System.Drawing.Color.Red
        Me.open_file.Location = New System.Drawing.Point(617, 7)
        Me.open_file.Name = "open_file"
        Me.open_file.Size = New System.Drawing.Size(92, 36)
        Me.open_file.TabIndex = 3
        Me.open_file.Text = "......open"
        Me.open_file.UseVisualStyleBackColor = False
        '
        'btn_delete_data
        '
        Me.btn_delete_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete_data.ForeColor = System.Drawing.Color.Red
        Me.btn_delete_data.Location = New System.Drawing.Point(623, 15)
        Me.btn_delete_data.Name = "btn_delete_data"
        Me.btn_delete_data.Size = New System.Drawing.Size(179, 36)
        Me.btn_delete_data.TabIndex = 4
        Me.btn_delete_data.Text = "حذف بيانات مكرر"
        Me.btn_delete_data.UseVisualStyleBackColor = False
        Me.btn_delete_data.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Gold
        Me.BtnClose.ForeColor = System.Drawing.Color.Red
        Me.BtnClose.Location = New System.Drawing.Point(1110, 9)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(111, 36)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_selcet_data
        '
        Me.btn_selcet_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_selcet_data.ForeColor = System.Drawing.Color.Blue
        Me.btn_selcet_data.Location = New System.Drawing.Point(824, 15)
        Me.btn_selcet_data.Name = "btn_selcet_data"
        Me.btn_selcet_data.Size = New System.Drawing.Size(182, 35)
        Me.btn_selcet_data.TabIndex = 6
        Me.btn_selcet_data.Text = "تحديد بيانات مكرر"
        Me.btn_selcet_data.UseVisualStyleBackColor = False
        Me.btn_selcet_data.Visible = False
        '
        'Btn_add
        '
        Me.Btn_add.BackColor = System.Drawing.Color.LightSalmon
        Me.Btn_add.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_add.ForeColor = System.Drawing.Color.Blue
        Me.Btn_add.Location = New System.Drawing.Point(382, 15)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(202, 39)
        Me.Btn_add.TabIndex = 7
        Me.Btn_add.Text = "اضافة وتحديث بيانات"
        Me.Btn_add.UseVisualStyleBackColor = False
        Me.Btn_add.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(1206, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 32)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(341, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 32)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProgressBar1.Location = New System.Drawing.Point(44, 9)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(166, 23)
        Me.ProgressBar1.TabIndex = 45
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_add)
        Me.Panel2.Controls.Add(Me.btn_delete_data)
        Me.Panel2.Controls.Add(Me.btn_selcet_data)
        Me.Panel2.Location = New System.Drawing.Point(42, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1022, 64)
        Me.Panel2.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(940, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 41)
        Me.Panel3.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.open_file)
        Me.Panel4.Controls.Add(Me.name_adderss)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Location = New System.Drawing.Point(42, 51)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(892, 45)
        Me.Panel4.TabIndex = 51
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.YellowGreen
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(721, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 36)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "تحميل قاعدة بيانات"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.TextBox_search)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Entklatlbl)
        Me.Panel1.Location = New System.Drawing.Point(42, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1365, 57)
        Me.Panel1.TabIndex = 54
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(308, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 30)
        Me.Button5.TabIndex = 87
        Me.Button5.Text = "بحث"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseCompatibleTextRendering = True
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox_search
        '
        Me.TextBox_search.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_search.ForeColor = System.Drawing.Color.Blue
        Me.TextBox_search.Location = New System.Drawing.Point(401, 16)
        Me.TextBox_search.Name = "TextBox_search"
        Me.TextBox_search.Size = New System.Drawing.Size(344, 29)
        Me.TextBox_search.TabIndex = 86
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(898, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton3.Size = New System.Drawing.Size(104, 26)
        Me.RadioButton3.TabIndex = 49
        Me.RadioButton3.Text = "الرقم القومى"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(1008, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton2.Size = New System.Drawing.Size(105, 26)
        Me.RadioButton2.TabIndex = 48
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "اسم الموظف"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(1140, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton1.Size = New System.Drawing.Size(107, 26)
        Me.RadioButton1.TabIndex = 47
        Me.RadioButton1.Text = "رقم 55 ع ح"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Entklatlbl
        '
        Me.Entklatlbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Entklatlbl.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Entklatlbl.ForeColor = System.Drawing.Color.DarkRed
        Me.Entklatlbl.Location = New System.Drawing.Point(1253, 0)
        Me.Entklatlbl.Name = "Entklatlbl"
        Me.Entklatlbl.Size = New System.Drawing.Size(112, 57)
        Me.Entklatlbl.TabIndex = 23
        Me.Entklatlbl.Text = "بحث"
        Me.Entklatlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'export_from_database_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = true
        Me.AutoSize = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.name_emplbl)
        Me.Controls.Add(Me.dgv_data_base)
        Me.Controls.Add(Me.BtnClose)
        Me.Font = New System.Drawing.Font("Times New Roman", 14!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "export_from_database_Form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = true
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "صفحة تحديث بيانات"
        Me.TopMost = true
        CType(Me.dgv_data_base,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents name_adderss As System.Windows.Forms.TextBox
    Friend WithEvents name_emplbl As System.Windows.Forms.Label
    Friend WithEvents dgv_data_base As System.Windows.Forms.DataGridView
    Friend WithEvents open_file As System.Windows.Forms.Button
    Friend WithEvents btn_delete_data As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_selcet_data As System.Windows.Forms.Button
    Friend WithEvents Btn_add As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

    Private Sub Form_update_emp_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form_update_emp_AutoSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AutoSizeChanged

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Public WithEvents Entklatlbl As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Public WithEvents TextBox_search As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents id_and_user_tfg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_kshf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Name_Em As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Name_school As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salary_ass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dayes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mkf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Badl_safer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entklat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mashat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mashat8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Darabb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nkaba As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mhann As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mastshfa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Damghh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Earaadta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents box20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Mostkta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saffy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Mkf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents date1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents op_id_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents op_name_pay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents op_al_kta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents op_no_emb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saffy_after_antkal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nakab_yes_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chb_tsh_mlahza As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Auto_emp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Auto_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chb_mlahza As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chb_ٍsharta As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chb_zar_shee As System.Windows.Forms.DataGridViewCheckBoxColumn


End Class
