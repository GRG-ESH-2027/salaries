<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search_emp_q
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_msg = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Name_emp_seach = New System.Windows.Forms.ComboBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.msg_lbl = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.Label()
        Me.dgv_search_emp_q = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.co2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_emp = New System.Windows.Forms.TextBox()
        Me.ComboBox_Salary_ass = New System.Windows.Forms.ComboBox()
        Me.Name_school = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_noo_combx = New System.Windows.Forms.ComboBox()
        Me.Name_Emplbl = New System.Windows.Forms.Label()
        Me.Name_schoollbl = New System.Windows.Forms.Label()
        Me.Salary_asslbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.Cmbx_nokapa = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbx_name_pay = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbx_alkta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbx_no_emp = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_search_emp_q, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ListBox2)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.lbl_msg)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.Name_emp_seach)
        Me.Panel2.Controls.Add(Me.btn_search)
        Me.Panel2.Controls.Add(Me.msg_lbl)
        Me.Panel2.Controls.Add(Me.Id)
        Me.Panel2.Location = New System.Drawing.Point(444, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(756, 252)
        Me.Panel2.TabIndex = 52
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Black
        Me.ListBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 23
        Me.ListBox2.Location = New System.Drawing.Point(211, 114)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(233, 96)
        Me.ListBox2.TabIndex = 105
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(211, 85)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(531, 30)
        Me.Panel4.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "الرقم القومى"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(404, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "الاســـــــــم"
        '
        'lbl_msg
        '
        Me.lbl_msg.AutoSize = True
        Me.lbl_msg.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.Location = New System.Drawing.Point(328, 6)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(19, 19)
        Me.lbl_msg.TabIndex = 102
        Me.lbl_msg.Text = "0"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 23
        Me.ListBox1.Location = New System.Drawing.Point(441, 114)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(301, 96)
        Me.ListBox1.TabIndex = 101
        '
        'Name_emp_seach
        '
        Me.Name_emp_seach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Name_emp_seach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.Name_emp_seach.FormattingEnabled = True
        Me.Name_emp_seach.Location = New System.Drawing.Point(420, 48)
        Me.Name_emp_seach.Name = "Name_emp_seach"
        Me.Name_emp_seach.Size = New System.Drawing.Size(322, 31)
        Me.Name_emp_seach.TabIndex = 1
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.White
        Me.btn_search.ForeColor = System.Drawing.Color.Red
        Me.btn_search.Location = New System.Drawing.Point(350, 48)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(64, 32)
        Me.btn_search.TabIndex = 94
        Me.btn_search.Text = "بحث"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'msg_lbl
        '
        Me.msg_lbl.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg_lbl.ForeColor = System.Drawing.Color.White
        Me.msg_lbl.Location = New System.Drawing.Point(480, 6)
        Me.msg_lbl.Name = "msg_lbl"
        Me.msg_lbl.Size = New System.Drawing.Size(266, 36)
        Me.msg_lbl.TabIndex = 83
        Me.msg_lbl.Text = "بحث عن موظف"
        Me.msg_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Id
        '
        Me.Id.Location = New System.Drawing.Point(726, 120)
        Me.Id.Name = "Id"
        Me.Id.Size = New System.Drawing.Size(20, 23)
        Me.Id.TabIndex = 1
        '
        'dgv_search_emp_q
        '
        Me.dgv_search_emp_q.AllowUserToAddRows = False
        Me.dgv_search_emp_q.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red
        Me.dgv_search_emp_q.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_search_emp_q.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_search_emp_q.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_search_emp_q.BackgroundColor = System.Drawing.Color.Black
        Me.dgv_search_emp_q.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgv_search_emp_q.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_search_emp_q.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_search_emp_q.ColumnHeadersHeight = 40
        Me.dgv_search_emp_q.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.co2, Me.Column2, Me.Column3})
        Me.dgv_search_emp_q.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "0"
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_search_emp_q.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_search_emp_q.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_search_emp_q.GridColor = System.Drawing.Color.Black
        Me.dgv_search_emp_q.Location = New System.Drawing.Point(232, 277)
        Me.dgv_search_emp_q.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_search_emp_q.MultiSelect = False
        Me.dgv_search_emp_q.Name = "dgv_search_emp_q"
        Me.dgv_search_emp_q.ReadOnly = True
        Me.dgv_search_emp_q.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_search_emp_q.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_search_emp_q.RowHeadersWidth = 40
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.dgv_search_emp_q.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_search_emp_q.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_search_emp_q.Size = New System.Drawing.Size(954, 244)
        Me.dgv_search_emp_q.TabIndex = 106
        '
        'Column1
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "م"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 48
        '
        'co2
        '
        Me.co2.DataPropertyName = "name_emp"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkOrange
        Me.co2.DefaultCellStyle = DataGridViewCellStyle4
        Me.co2.FillWeight = 130.0!
        Me.co2.HeaderText = "الاســــم"
        Me.co2.Name = "co2"
        Me.co2.ReadOnly = True
        Me.co2.Width = 109
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "id_no"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column2.HeaderText = "الرقم القومى"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 153
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "school"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column3.HeaderText = "الـــمـدرســة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 144
        '
        'Name_emp
        '
        Me.Name_emp.BackColor = System.Drawing.Color.Black
        Me.Name_emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Name_emp.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_emp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name_emp.Location = New System.Drawing.Point(28, 8)
        Me.Name_emp.Name = "Name_emp"
        Me.Name_emp.Size = New System.Drawing.Size(254, 35)
        Me.Name_emp.TabIndex = 97
        '
        'ComboBox_Salary_ass
        '
        Me.ComboBox_Salary_ass.BackColor = System.Drawing.Color.Black
        Me.ComboBox_Salary_ass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox_Salary_ass.FormatString = "N2"
        Me.ComboBox_Salary_ass.FormattingEnabled = True
        Me.ComboBox_Salary_ass.Location = New System.Drawing.Point(28, 123)
        Me.ComboBox_Salary_ass.Name = "ComboBox_Salary_ass"
        Me.ComboBox_Salary_ass.Size = New System.Drawing.Size(254, 31)
        Me.ComboBox_Salary_ass.TabIndex = 93
        Me.ComboBox_Salary_ass.Text = "0"
        '
        'Name_school
        '
        Me.Name_school.BackColor = System.Drawing.Color.Black
        Me.Name_school.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Name_school.FormattingEnabled = True
        Me.Name_school.Location = New System.Drawing.Point(28, 49)
        Me.Name_school.Name = "Name_school"
        Me.Name_school.Size = New System.Drawing.Size(254, 31)
        Me.Name_school.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(311, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(104, 30)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "رقم قومى"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'id_noo_combx
        '
        Me.id_noo_combx.BackColor = System.Drawing.Color.Black
        Me.id_noo_combx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.id_noo_combx.FormattingEnabled = True
        Me.id_noo_combx.Location = New System.Drawing.Point(28, 86)
        Me.id_noo_combx.Name = "id_noo_combx"
        Me.id_noo_combx.Size = New System.Drawing.Size(254, 31)
        Me.id_noo_combx.TabIndex = 89
        '
        'Name_Emplbl
        '
        Me.Name_Emplbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Emplbl.ForeColor = System.Drawing.Color.White
        Me.Name_Emplbl.Location = New System.Drawing.Point(311, 8)
        Me.Name_Emplbl.Name = "Name_Emplbl"
        Me.Name_Emplbl.Size = New System.Drawing.Size(115, 31)
        Me.Name_Emplbl.TabIndex = 86
        Me.Name_Emplbl.Text = "اسم الموظف"
        Me.Name_Emplbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Name_schoollbl
        '
        Me.Name_schoollbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_schoollbl.ForeColor = System.Drawing.Color.White
        Me.Name_schoollbl.Location = New System.Drawing.Point(311, 39)
        Me.Name_schoollbl.Name = "Name_schoollbl"
        Me.Name_schoollbl.Size = New System.Drawing.Size(104, 23)
        Me.Name_schoollbl.TabIndex = 87
        Me.Name_schoollbl.Text = "المدرسة"
        Me.Name_schoollbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Salary_asslbl
        '
        Me.Salary_asslbl.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salary_asslbl.ForeColor = System.Drawing.Color.White
        Me.Salary_asslbl.Location = New System.Drawing.Point(288, 111)
        Me.Salary_asslbl.Name = "Salary_asslbl"
        Me.Salary_asslbl.Size = New System.Drawing.Size(138, 39)
        Me.Salary_asslbl.TabIndex = 18
        Me.Salary_asslbl.Text = "المرتب الاساسى"
        Me.Salary_asslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.btn_select)
        Me.Panel1.Controls.Add(Me.Cmbx_nokapa)
        Me.Panel1.Controls.Add(Me.Name_emp)
        Me.Panel1.Controls.Add(Me.Name_school)
        Me.Panel1.Controls.Add(Me.Name_Emplbl)
        Me.Panel1.Controls.Add(Me.Name_schoollbl)
        Me.Panel1.Controls.Add(Me.ComboBox_Salary_ass)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.id_noo_combx)
        Me.Panel1.Controls.Add(Me.Salary_asslbl)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 252)
        Me.Panel1.TabIndex = 53
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.Orange
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.Location = New System.Drawing.Point(161, 205)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(121, 32)
        Me.btn_select.TabIndex = 100
        Me.btn_select.Text = "اختيار"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'Cmbx_nokapa
        '
        Me.Cmbx_nokapa.BackColor = System.Drawing.Color.Black
        Me.Cmbx_nokapa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Cmbx_nokapa.FormattingEnabled = True
        Me.Cmbx_nokapa.Location = New System.Drawing.Point(170, 160)
        Me.Cmbx_nokapa.Name = "Cmbx_nokapa"
        Me.Cmbx_nokapa.Size = New System.Drawing.Size(112, 31)
        Me.Cmbx_nokapa.TabIndex = 98
        Me.Cmbx_nokapa.Text = "0"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.cmbx_name_pay)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cmbx_alkta)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cmbx_no_emp)
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(12, 389)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(215, 132)
        Me.Panel3.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(794, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "نوع المدفوعه"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbx_name_pay
        '
        Me.cmbx_name_pay.Enabled = False
        Me.cmbx_name_pay.FormattingEnabled = True
        Me.cmbx_name_pay.Location = New System.Drawing.Point(9, 93)
        Me.cmbx_name_pay.Name = "cmbx_name_pay"
        Me.cmbx_name_pay.Size = New System.Drawing.Size(112, 24)
        Me.cmbx_name_pay.TabIndex = 66
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(129, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 31)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "القطاع"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbx_alkta
        '
        Me.cmbx_alkta.Enabled = False
        Me.cmbx_alkta.FormattingEnabled = True
        Me.cmbx_alkta.Location = New System.Drawing.Point(9, 56)
        Me.cmbx_alkta.Name = "cmbx_alkta"
        Me.cmbx_alkta.Size = New System.Drawing.Size(114, 24)
        Me.cmbx_alkta.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(129, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 23)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "رقم الموظف"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbx_no_emp
        '
        Me.cmbx_no_emp.Enabled = False
        Me.cmbx_no_emp.FormattingEnabled = True
        Me.cmbx_no_emp.Location = New System.Drawing.Point(6, 19)
        Me.cmbx_no_emp.Name = "cmbx_no_emp"
        Me.cmbx_no_emp.Size = New System.Drawing.Size(117, 24)
        Me.cmbx_no_emp.TabIndex = 68
        '
        'search_emp_q
        '
        Me.AcceptButton = Me.btn_search
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1212, 539)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgv_search_emp_q)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "search_emp_q"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بحث سريع عن موظف"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv_search_emp_q, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Public WithEvents ComboBox_Salary_ass As System.Windows.Forms.ComboBox
    Public WithEvents Name_school As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents id_noo_combx As System.Windows.Forms.ComboBox
    Public WithEvents Name_Emplbl As System.Windows.Forms.Label
    Public WithEvents Name_schoollbl As System.Windows.Forms.Label
    Public WithEvents msg_lbl As System.Windows.Forms.Label
    Public WithEvents Id As System.Windows.Forms.Label
    Public WithEvents Salary_asslbl As System.Windows.Forms.Label
    Public WithEvents Name_emp As System.Windows.Forms.TextBox
    Public WithEvents Name_emp_seach As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents cmbx_name_pay As System.Windows.Forms.ComboBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmbx_alkta As System.Windows.Forms.ComboBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents cmbx_no_emp As System.Windows.Forms.ComboBox
    Public WithEvents Cmbx_nokapa As System.Windows.Forms.ComboBox
    Private WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lbl_msg As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Public WithEvents dgv_search_emp_q As System.Windows.Forms.DataGridView
    Private WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents co2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
