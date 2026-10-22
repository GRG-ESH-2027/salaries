<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_ndb_frm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.msg_lbl = New System.Windows.Forms.Label()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.date_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lgna_txt = New System.Windows.Forms.TextBox()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jop_txt = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lbl_erro = New System.Windows.Forms.Label()
        Me.chk_auto = New System.Windows.Forms.CheckBox()
        Me.Name_school = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_noo_combx = New System.Windows.Forms.ComboBox()
        Me.Idlbl = New System.Windows.Forms.Label()
        Me.Name_Emplbl = New System.Windows.Forms.Label()
        Me.Name_emp = New System.Windows.Forms.TextBox()
        Me.Name_schoollbl = New System.Windows.Forms.Label()
        Me.dgv_Table_add_tfrgh = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Btn_new = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Txt_seach = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_ex_to_excell = New System.Windows.Forms.Button()
        Me.count_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Table_add_tfrgh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Green
        Me.Panel2.Controls.Add(Me.msg_lbl)
        Me.Panel2.Controls.Add(Me.date1)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.date_lbl)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lgna_txt)
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.jop_txt)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.lbl_erro)
        Me.Panel2.Controls.Add(Me.chk_auto)
        Me.Panel2.Controls.Add(Me.Name_school)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.id_noo_combx)
        Me.Panel2.Controls.Add(Me.Idlbl)
        Me.Panel2.Controls.Add(Me.Name_Emplbl)
        Me.Panel2.Controls.Add(Me.Name_emp)
        Me.Panel2.Controls.Add(Me.Name_schoollbl)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(630, 290)
        Me.Panel2.TabIndex = 52
        '
        'msg_lbl
        '
        Me.msg_lbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg_lbl.ForeColor = System.Drawing.Color.Maroon
        Me.msg_lbl.Location = New System.Drawing.Point(63, 267)
        Me.msg_lbl.Name = "msg_lbl"
        Me.msg_lbl.Size = New System.Drawing.Size(435, 23)
        Me.msg_lbl.TabIndex = 101
        Me.msg_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'date1
        '
        Me.date1.CustomFormat = "yyyy/MM/dd"
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date1.Location = New System.Drawing.Point(110, 187)
        Me.date1.Name = "date1"
        Me.date1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.date1.Size = New System.Drawing.Size(284, 29)
        Me.date1.TabIndex = 100
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Black
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnEdit.Location = New System.Drawing.Point(14, 152)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(91, 36)
        Me.BtnEdit.TabIndex = 88
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'date_lbl
        '
        Me.date_lbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_lbl.ForeColor = System.Drawing.Color.White
        Me.date_lbl.Location = New System.Drawing.Point(404, 181)
        Me.date_lbl.Name = "date_lbl"
        Me.date_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.date_lbl.Size = New System.Drawing.Size(98, 30)
        Me.date_lbl.TabIndex = 99
        Me.date_lbl.Text = "التاريخ"
        Me.date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(400, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(98, 30)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "اللجنة"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lgna_txt
        '
        Me.lgna_txt.BackColor = System.Drawing.Color.DarkOrange
        Me.lgna_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lgna_txt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lgna_txt.ForeColor = System.Drawing.Color.Black
        Me.lgna_txt.Location = New System.Drawing.Point(110, 147)
        Me.lgna_txt.Name = "lgna_txt"
        Me.lgna_txt.Size = New System.Drawing.Size(284, 35)
        Me.lgna_txt.TabIndex = 97
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.Orange
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.White
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(14, 63)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(91, 36)
        Me.BtnNewAdd.TabIndex = 86
        Me.BtnNewAdd.Text = "حفظ-f4"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(400, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(98, 30)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "الوظيفة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'jop_txt
        '
        Me.jop_txt.BackColor = System.Drawing.Color.DarkOrange
        Me.jop_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jop_txt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jop_txt.ForeColor = System.Drawing.Color.Black
        Me.jop_txt.Location = New System.Drawing.Point(110, 107)
        Me.jop_txt.Name = "jop_txt"
        Me.jop_txt.Size = New System.Drawing.Size(284, 35)
        Me.jop_txt.TabIndex = 95
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.ForeColor = System.Drawing.Color.DarkRed
        Me.Button8.Location = New System.Drawing.Point(509, 9)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(122, 35)
        Me.Button8.TabIndex = 94
        Me.Button8.Text = "بحث سريع"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'lbl_erro
        '
        Me.lbl_erro.ForeColor = System.Drawing.Color.White
        Me.lbl_erro.Location = New System.Drawing.Point(575, 230)
        Me.lbl_erro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_erro.Name = "lbl_erro"
        Me.lbl_erro.Size = New System.Drawing.Size(32, 21)
        Me.lbl_erro.TabIndex = 92
        Me.lbl_erro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chk_auto
        '
        Me.chk_auto.AutoSize = True
        Me.chk_auto.ForeColor = System.Drawing.Color.Gold
        Me.chk_auto.Location = New System.Drawing.Point(515, 71)
        Me.chk_auto.Name = "chk_auto"
        Me.chk_auto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_auto.Size = New System.Drawing.Size(72, 28)
        Me.chk_auto.TabIndex = 91
        Me.chk_auto.Text = "Auto"
        Me.chk_auto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_auto.UseVisualStyleBackColor = True
        '
        'Name_school
        '
        Me.Name_school.FormattingEnabled = True
        Me.Name_school.Location = New System.Drawing.Point(110, 35)
        Me.Name_school.Name = "Name_school"
        Me.Name_school.Size = New System.Drawing.Size(284, 32)
        Me.Name_school.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(400, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(98, 30)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "رقم قومى"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'id_noo_combx
        '
        Me.id_noo_combx.FormattingEnabled = True
        Me.id_noo_combx.Location = New System.Drawing.Point(110, 69)
        Me.id_noo_combx.MaxLength = 14
        Me.id_noo_combx.Name = "id_noo_combx"
        Me.id_noo_combx.Size = New System.Drawing.Size(284, 32)
        Me.id_noo_combx.TabIndex = 89
        '
        'Idlbl
        '
        Me.Idlbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Idlbl.ForeColor = System.Drawing.Color.DarkRed
        Me.Idlbl.Location = New System.Drawing.Point(537, 111)
        Me.Idlbl.Name = "Idlbl"
        Me.Idlbl.Size = New System.Drawing.Size(67, 23)
        Me.Idlbl.TabIndex = 84
        Me.Idlbl.Text = "Id"
        Me.Idlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name_Emplbl
        '
        Me.Name_Emplbl.ForeColor = System.Drawing.Color.White
        Me.Name_Emplbl.Location = New System.Drawing.Point(400, 8)
        Me.Name_Emplbl.Name = "Name_Emplbl"
        Me.Name_Emplbl.Size = New System.Drawing.Size(103, 23)
        Me.Name_Emplbl.TabIndex = 86
        Me.Name_Emplbl.Text = "اسم الموظف"
        Me.Name_Emplbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Name_emp
        '
        Me.Name_emp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Name_emp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Name_emp.BackColor = System.Drawing.Color.DarkOrange
        Me.Name_emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Name_emp.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_emp.ForeColor = System.Drawing.Color.Black
        Me.Name_emp.Location = New System.Drawing.Point(110, 3)
        Me.Name_emp.Name = "Name_emp"
        Me.Name_emp.Size = New System.Drawing.Size(284, 35)
        Me.Name_emp.TabIndex = 85
        '
        'Name_schoollbl
        '
        Me.Name_schoollbl.ForeColor = System.Drawing.Color.White
        Me.Name_schoollbl.Location = New System.Drawing.Point(404, 40)
        Me.Name_schoollbl.Name = "Name_schoollbl"
        Me.Name_schoollbl.Size = New System.Drawing.Size(122, 23)
        Me.Name_schoollbl.TabIndex = 87
        Me.Name_schoollbl.Text = "المدرسة"
        Me.Name_schoollbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgv_Table_add_tfrgh
        '
        Me.dgv_Table_add_tfrgh.AllowUserToAddRows = False
        Me.dgv_Table_add_tfrgh.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.NullValue = "0"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Table_add_tfrgh.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Table_add_tfrgh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Table_add_tfrgh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Table_add_tfrgh.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_Table_add_tfrgh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_Table_add_tfrgh.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Table_add_tfrgh.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Table_add_tfrgh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Table_add_tfrgh.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_Table_add_tfrgh.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Table_add_tfrgh.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Table_add_tfrgh.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_Table_add_tfrgh.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv_Table_add_tfrgh.Location = New System.Drawing.Point(11, 342)
        Me.dgv_Table_add_tfrgh.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Table_add_tfrgh.MultiSelect = False
        Me.dgv_Table_add_tfrgh.Name = "dgv_Table_add_tfrgh"
        Me.dgv_Table_add_tfrgh.ReadOnly = True
        Me.dgv_Table_add_tfrgh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Table_add_tfrgh.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Table_add_tfrgh.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Table_add_tfrgh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Table_add_tfrgh.Size = New System.Drawing.Size(1035, 246)
        Me.dgv_Table_add_tfrgh.TabIndex = 62
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "مسلسل"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 81
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "name_emp"
        Me.Column2.HeaderText = "الاســـــــــــــــــــــــــــم"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 204
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "job"
        Me.Column3.HeaderText = "الوظيفة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 86
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "school"
        Me.Column4.HeaderText = "المدرسة الاصليه"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 147
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "date_ndb"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "تاريخ ندب العمل"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "al_gna"
        Me.Column6.HeaderText = "اللجنه"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 75
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "id_emp"
        Me.Column7.HeaderText = "الرقم القومى"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 119
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.count_lbl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.Btn_new)
        Me.Panel1.Location = New System.Drawing.Point(648, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 291)
        Me.Panel1.TabIndex = 63
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(172, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 36)
        Me.Button2.TabIndex = 92
        Me.Button2.Text = "طباعة "
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseCompatibleTextRendering = True
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(172, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 36)
        Me.Button1.TabIndex = 91
        Me.Button1.Text = "حذف الكل"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDelete.Location = New System.Drawing.Point(172, 72)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(91, 36)
        Me.BtnDelete.TabIndex = 90
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = False
        Me.BtnDelete.Visible = False
        '
        'Btn_new
        '
        Me.Btn_new.BackColor = System.Drawing.Color.Lime
        Me.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_new.Location = New System.Drawing.Point(172, 22)
        Me.Btn_new.Name = "Btn_new"
        Me.Btn_new.Size = New System.Drawing.Size(91, 36)
        Me.Btn_new.TabIndex = 87
        Me.Btn_new.Text = "جديد"
        Me.Btn_new.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button6.Location = New System.Drawing.Point(555, 308)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(169, 30)
        Me.Button6.TabIndex = 88
        Me.Button6.Text = "بحث باسم موظف"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Txt_seach
        '
        Me.Txt_seach.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Txt_seach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_seach.ForeColor = System.Drawing.Color.Black
        Me.Txt_seach.Location = New System.Drawing.Point(12, 308)
        Me.Txt_seach.Name = "Txt_seach"
        Me.Txt_seach.Size = New System.Drawing.Size(537, 29)
        Me.Txt_seach.TabIndex = 87
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btn_ex_to_excell
        '
        Me.btn_ex_to_excell.BackColor = System.Drawing.Color.Yellow
        Me.btn_ex_to_excell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ex_to_excell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ex_to_excell.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ex_to_excell.ForeColor = System.Drawing.Color.Red
        Me.btn_ex_to_excell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ex_to_excell.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_ex_to_excell.Location = New System.Drawing.Point(730, 308)
        Me.btn_ex_to_excell.Name = "btn_ex_to_excell"
        Me.btn_ex_to_excell.Size = New System.Drawing.Size(269, 29)
        Me.btn_ex_to_excell.TabIndex = 90
        Me.btn_ex_to_excell.Text = "تصدير كل البيانات الى اكسيل"
        Me.btn_ex_to_excell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ex_to_excell.UseCompatibleTextRendering = True
        Me.btn_ex_to_excell.UseVisualStyleBackColor = False
        '
        'count_lbl
        '
        Me.count_lbl.AutoSize = True
        Me.count_lbl.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count_lbl.ForeColor = System.Drawing.Color.Red
        Me.count_lbl.Location = New System.Drawing.Point(111, 245)
        Me.count_lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.count_lbl.Name = "count_lbl"
        Me.count_lbl.Size = New System.Drawing.Size(47, 32)
        Me.count_lbl.TabIndex = 138
        Me.count_lbl.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(190, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 32)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "عدد"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(48, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 36)
        Me.Button3.TabIndex = 93
        Me.Button3.Text = "طباعة2 "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = False
        '
        'add_ndb_frm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1167, 644)
        Me.Controls.Add(Me.btn_ex_to_excell)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Txt_seach)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgv_Table_add_tfrgh)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "add_ndb_frm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة ندب جديد"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_Table_add_tfrgh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents date_lbl As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lgna_txt As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents jop_txt As System.Windows.Forms.TextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Public WithEvents lbl_erro As System.Windows.Forms.Label
    Public WithEvents chk_auto As System.Windows.Forms.CheckBox
    Public WithEvents Name_school As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents id_noo_combx As System.Windows.Forms.ComboBox
    Public WithEvents Idlbl As System.Windows.Forms.Label
    Public WithEvents Name_Emplbl As System.Windows.Forms.Label
    Public WithEvents Name_emp As System.Windows.Forms.TextBox
    Public WithEvents Name_schoollbl As System.Windows.Forms.Label
    Public WithEvents date1 As System.Windows.Forms.DateTimePicker
    Public WithEvents dgv_Table_add_tfrgh As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Public WithEvents Btn_new As System.Windows.Forms.Button
    Public WithEvents BtnNewAdd As System.Windows.Forms.Button
    Public WithEvents msg_lbl As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Public WithEvents Txt_seach As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_ex_to_excell As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents count_lbl As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
