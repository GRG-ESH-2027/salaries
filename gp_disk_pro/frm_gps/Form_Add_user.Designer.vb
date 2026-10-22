<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Add_user
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Add_user))
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dgv_user_table = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_new = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.id_user = New System.Windows.Forms.Label()
        Me.user_mange = New System.Windows.Forms.ComboBox()
        Me.id_userlbl = New System.Windows.Forms.Label()
        Me.user_namelbl = New System.Windows.Forms.Label()
        Me.user_passlbl = New System.Windows.Forms.Label()
        Me.user_ful_namelbl = New System.Windows.Forms.Label()
        Me.user_mangelbl = New System.Windows.Forms.Label()
        Me.user_name = New System.Windows.Forms.TextBox()
        Me.user_pass = New System.Windows.Forms.TextBox()
        Me.user_ful_name = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.user_datelbl = New System.Windows.Forms.Label()
        Me.user_date = New System.Windows.Forms.DateTimePicker()
        Me.user_timelbl = New System.Windows.Forms.Label()
        Me.user_time = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6.SuspendLayout()
        CType(Me.dgv_user_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.Orange
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.White
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(4, 44)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(158, 35)
        Me.BtnNewAdd.TabIndex = 17
        Me.BtnNewAdd.Text = "حفظ-f4"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnDelete.Location = New System.Drawing.Point(3, 182)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(158, 35)
        Me.BtnDelete.TabIndex = 71
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BackColor = System.Drawing.Color.DarkRed
        Me.Panel6.Controls.Add(Me.dgv_user_table)
        Me.Panel6.Location = New System.Drawing.Point(12, 291)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1105, 327)
        Me.Panel6.TabIndex = 97
        '
        'dgv_user_table
        '
        Me.dgv_user_table.AllowUserToAddRows = False
        Me.dgv_user_table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_user_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_user_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_user_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_user_table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_user_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_user_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_user_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_user_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv_user_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_user_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_user_table.Location = New System.Drawing.Point(15, 7)
        Me.dgv_user_table.MultiSelect = False
        Me.dgv_user_table.Name = "dgv_user_table"
        Me.dgv_user_table.ReadOnly = True
        Me.dgv_user_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv_user_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_user_table.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Blue
        Me.dgv_user_table.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_user_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_user_table.Size = New System.Drawing.Size(1072, 317)
        Me.dgv_user_table.TabIndex = 105
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_user"
        Me.Column1.HeaderText = "رقم المستخدم"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "user_name"
        Me.Column2.HeaderText = "اسم المستخدم"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "user_pass"
        Me.Column3.HeaderText = "باسورد"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "user_ful_name"
        Me.Column4.HeaderText = "الاسم بالكامل"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "user_mange"
        Me.Column5.HeaderText = "صلاحيات المستخدم"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Btn_new
        '
        Me.Btn_new.BackColor = System.Drawing.Color.DarkGreen
        Me.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_new.Location = New System.Drawing.Point(3, 3)
        Me.Btn_new.Name = "Btn_new"
        Me.Btn_new.Size = New System.Drawing.Size(158, 35)
        Me.Btn_new.TabIndex = 98
        Me.Btn_new.Text = "جديد"
        Me.Btn_new.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.id_user)
        Me.Panel1.Controls.Add(Me.user_mange)
        Me.Panel1.Controls.Add(Me.id_userlbl)
        Me.Panel1.Controls.Add(Me.user_namelbl)
        Me.Panel1.Controls.Add(Me.user_passlbl)
        Me.Panel1.Controls.Add(Me.user_ful_namelbl)
        Me.Panel1.Controls.Add(Me.user_mangelbl)
        Me.Panel1.Controls.Add(Me.user_name)
        Me.Panel1.Controls.Add(Me.user_pass)
        Me.Panel1.Controls.Add(Me.user_ful_name)
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(499, 240)
        Me.Panel1.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(310, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 31)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "تاكيد الباسورد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(5, 116)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(299, 35)
        Me.TextBox1.TabIndex = 103
        '
        'id_user
        '
        Me.id_user.AutoSize = True
        Me.id_user.Location = New System.Drawing.Point(222, 0)
        Me.id_user.Name = "id_user"
        Me.id_user.Size = New System.Drawing.Size(84, 26)
        Me.id_user.TabIndex = 102
        Me.id_user.Text = "Label1"
        '
        'user_mange
        '
        Me.user_mange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.user_mange.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.user_mange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.user_mange.ForeColor = System.Drawing.Color.White
        Me.user_mange.FormattingEnabled = True
        Me.user_mange.Location = New System.Drawing.Point(5, 203)
        Me.user_mange.Name = "user_mange"
        Me.user_mange.Size = New System.Drawing.Size(301, 34)
        Me.user_mange.TabIndex = 102
        Me.user_mange.Tag = ""
        '
        'id_userlbl
        '
        Me.id_userlbl.Location = New System.Drawing.Point(314, -2)
        Me.id_userlbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.id_userlbl.Name = "id_userlbl"
        Me.id_userlbl.Size = New System.Drawing.Size(187, 31)
        Me.id_userlbl.TabIndex = 20
        Me.id_userlbl.Text = "رقم المستخدم"
        Me.id_userlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_namelbl
        '
        Me.user_namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.user_namelbl.Location = New System.Drawing.Point(307, 30)
        Me.user_namelbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.user_namelbl.Name = "user_namelbl"
        Me.user_namelbl.Size = New System.Drawing.Size(174, 31)
        Me.user_namelbl.TabIndex = 21
        Me.user_namelbl.Text = "اسم المستخدم"
        Me.user_namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_passlbl
        '
        Me.user_passlbl.BackColor = System.Drawing.Color.Navy
        Me.user_passlbl.Location = New System.Drawing.Point(310, 73)
        Me.user_passlbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.user_passlbl.Name = "user_passlbl"
        Me.user_passlbl.Size = New System.Drawing.Size(171, 31)
        Me.user_passlbl.TabIndex = 22
        Me.user_passlbl.Text = "باسورد"
        Me.user_passlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_ful_namelbl
        '
        Me.user_ful_namelbl.BackColor = System.Drawing.Color.Navy
        Me.user_ful_namelbl.Location = New System.Drawing.Point(310, 158)
        Me.user_ful_namelbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.user_ful_namelbl.Name = "user_ful_namelbl"
        Me.user_ful_namelbl.Size = New System.Drawing.Size(171, 31)
        Me.user_ful_namelbl.TabIndex = 23
        Me.user_ful_namelbl.Text = "الاسم بالكامل"
        Me.user_ful_namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_mangelbl
        '
        Me.user_mangelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.user_mangelbl.Location = New System.Drawing.Point(307, 203)
        Me.user_mangelbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.user_mangelbl.Name = "user_mangelbl"
        Me.user_mangelbl.Size = New System.Drawing.Size(174, 31)
        Me.user_mangelbl.TabIndex = 24
        Me.user_mangelbl.Text = "صلاحيات المستخدم"
        Me.user_mangelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_name
        '
        Me.user_name.Location = New System.Drawing.Point(5, 30)
        Me.user_name.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(299, 35)
        Me.user_name.TabIndex = 13
        '
        'user_pass
        '
        Me.user_pass.Location = New System.Drawing.Point(5, 73)
        Me.user_pass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.user_pass.Name = "user_pass"
        Me.user_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.user_pass.Size = New System.Drawing.Size(299, 35)
        Me.user_pass.TabIndex = 15
        '
        'user_ful_name
        '
        Me.user_ful_name.Location = New System.Drawing.Point(5, 158)
        Me.user_ful_name.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.user_ful_name.Name = "user_ful_name"
        Me.user_ful_name.Size = New System.Drawing.Size(299, 35)
        Me.user_ful_name.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Btn_new)
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Location = New System.Drawing.Point(575, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 220)
        Me.Panel2.TabIndex = 100
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(3, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 35)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "عرض الباسورد"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(391, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 26)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "صفحة ادخال وتعديل مستخدم"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(905, 160)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(212, 35)
        Me.TextBox3.TabIndex = 108
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'user_datelbl
        '
        Me.user_datelbl.ForeColor = System.Drawing.Color.White
        Me.user_datelbl.Location = New System.Drawing.Point(824, 122)
        Me.user_datelbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.user_datelbl.Name = "user_datelbl"
        Me.user_datelbl.Size = New System.Drawing.Size(69, 31)
        Me.user_datelbl.TabIndex = 104
        Me.user_datelbl.Text = "تاريخ"
        Me.user_datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_date
        '
        Me.user_date.CustomFormat = "yyyy/MM/dd"
        Me.user_date.Enabled = False
        Me.user_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.user_date.Location = New System.Drawing.Point(903, 118)
        Me.user_date.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.user_date.Name = "user_date"
        Me.user_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.user_date.RightToLeftLayout = True
        Me.user_date.Size = New System.Drawing.Size(212, 35)
        Me.user_date.TabIndex = 105
        '
        'user_timelbl
        '
        Me.user_timelbl.ForeColor = System.Drawing.Color.White
        Me.user_timelbl.Location = New System.Drawing.Point(826, 160)
        Me.user_timelbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.user_timelbl.Name = "user_timelbl"
        Me.user_timelbl.Size = New System.Drawing.Size(69, 31)
        Me.user_timelbl.TabIndex = 106
        Me.user_timelbl.Text = "وقت"
        Me.user_timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_time
        '
        Me.user_time.CustomFormat = "ss:mm:hh"
        Me.user_time.Enabled = False
        Me.user_time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.user_time.Location = New System.Drawing.Point(903, 203)
        Me.user_time.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.user_time.Name = "user_time"
        Me.user_time.RightToLeftLayout = True
        Me.user_time.Size = New System.Drawing.Size(214, 35)
        Me.user_time.TabIndex = 107
        Me.user_time.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(973, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 101
        Me.PictureBox1.TabStop = False
        '
        'Form_Add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1129, 630)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.user_datelbl)
        Me.Controls.Add(Me.user_date)
        Me.Controls.Add(Me.user_timelbl)
        Me.Controls.Add(Me.user_time)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "Form_Add_user"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة مستخدم جديد"
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgv_user_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents BtnNewAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Public WithEvents Btn_new As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents id_userlbl As System.Windows.Forms.Label
    Friend WithEvents user_namelbl As System.Windows.Forms.Label
    Friend WithEvents user_passlbl As System.Windows.Forms.Label
    Friend WithEvents user_ful_namelbl As System.Windows.Forms.Label
    Friend WithEvents user_mangelbl As System.Windows.Forms.Label
    Friend WithEvents user_name As System.Windows.Forms.TextBox
    Friend WithEvents user_pass As System.Windows.Forms.TextBox
    Friend WithEvents user_ful_name As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents user_mange As System.Windows.Forms.ComboBox
    Public WithEvents dgv_user_table As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents user_datelbl As System.Windows.Forms.Label
    Friend WithEvents user_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents user_timelbl As System.Windows.Forms.Label
    Friend WithEvents user_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer


End Class
