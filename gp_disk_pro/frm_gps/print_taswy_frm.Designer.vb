<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_taswy_frm
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_tabel_bnd = New System.Windows.Forms.DataGridView()
        Me.btn_export = New System.Windows.Forms.Button()
        Me.num_total = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.num_taswy = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.msg_lbl = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_tabel_bnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_total, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_taswy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.ForestGreen
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button7.Location = New System.Drawing.Point(12, 38)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(121, 47)
        Me.Button7.TabIndex = 106
        Me.Button7.Text = "تحميل التسويات"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(34, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 19)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "اختيار تسويه"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(142, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(121, 144)
        Me.ListBox1.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(505, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "صفحة طباعة تسوية"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.dgv_tabel_bnd)
        Me.Panel1.Location = New System.Drawing.Point(12, 189)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1900, 860)
        Me.Panel1.TabIndex = 107
        '
        'dgv_tabel_bnd
        '
        Me.dgv_tabel_bnd.AllowUserToAddRows = False
        Me.dgv_tabel_bnd.AllowUserToDeleteRows = False
        Me.dgv_tabel_bnd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabel_bnd.Location = New System.Drawing.Point(22, 10)
        Me.dgv_tabel_bnd.Name = "dgv_tabel_bnd"
        Me.dgv_tabel_bnd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tabel_bnd.Size = New System.Drawing.Size(1835, 847)
        Me.dgv_tabel_bnd.TabIndex = 0
        '
        'btn_export
        '
        Me.btn_export.BackColor = System.Drawing.Color.Green
        Me.btn_export.Enabled = False
        Me.btn_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_export.Location = New System.Drawing.Point(283, 10)
        Me.btn_export.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(184, 34)
        Me.btn_export.TabIndex = 108
        Me.btn_export.Text = "تصدير الى اكسيل"
        Me.btn_export.UseVisualStyleBackColor = False
        '
        'num_total
        '
        Me.num_total.BackColor = System.Drawing.SystemColors.InfoText
        Me.num_total.DecimalPlaces = 2
        Me.num_total.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_total.ForeColor = System.Drawing.Color.Blue
        Me.num_total.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.num_total.Location = New System.Drawing.Point(554, 147)
        Me.num_total.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.num_total.Name = "num_total"
        Me.num_total.ReadOnly = True
        Me.num_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.num_total.Size = New System.Drawing.Size(202, 35)
        Me.num_total.TabIndex = 110
        Me.num_total.ThousandsSeparator = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(762, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 19)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "اجمالى مبلغ التسوية"
        '
        'num_taswy
        '
        Me.num_taswy.Enabled = False
        Me.num_taswy.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.num_taswy.Location = New System.Drawing.Point(142, 10)
        Me.num_taswy.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.num_taswy.Name = "num_taswy"
        Me.num_taswy.Size = New System.Drawing.Size(124, 26)
        Me.num_taswy.TabIndex = 111
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "0"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "0"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView2.Location = New System.Drawing.Point(-4, -12)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(307, 160)
        Me.DataGridView2.TabIndex = 112
        Me.DataGridView2.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_col"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.FillWeight = 45.68528!
        Me.DataGridViewTextBoxColumn1.HeaderText = "رقم بند"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name_col_total"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.FillWeight = 127.1574!
        Me.DataGridViewTextBoxColumn2.HeaderText = "اسم البند"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "el_mblgh"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.FillWeight = 127.1574!
        Me.DataGridViewTextBoxColumn3.HeaderText = "المبلغ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1248, 149)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(110, 30)
        Me.Button4.TabIndex = 113
        Me.Button4.Text = "تحميل"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.ListBox2)
        Me.Panel2.Location = New System.Drawing.Point(1528, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(381, 172)
        Me.Panel2.TabIndex = 114
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(789, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 115
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(760, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 32)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(942, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 27)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(766, 62)
        Me.ProgressBar1.Maximum = 101
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar1.RightToLeftLayout = True
        Me.ProgressBar1.Size = New System.Drawing.Size(213, 23)
        Me.ProgressBar1.TabIndex = 116
        '
        'msg_lbl
        '
        Me.msg_lbl.BackColor = System.Drawing.SystemColors.InfoText
        Me.msg_lbl.ForeColor = System.Drawing.Color.Red
        Me.msg_lbl.FormattingEnabled = True
        Me.msg_lbl.ItemHeight = 20
        Me.msg_lbl.Location = New System.Drawing.Point(1326, 10)
        Me.msg_lbl.Name = "msg_lbl"
        Me.msg_lbl.ScrollAlwaysVisible = True
        Me.msg_lbl.Size = New System.Drawing.Size(196, 104)
        Me.msg_lbl.TabIndex = 121
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.Location = New System.Drawing.Point(283, 57)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 31)
        Me.Button2.TabIndex = 122
        Me.Button2.Text = "اخفاء الاعمده التى تساوى صفر"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(1393, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Label6"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.SystemColors.InfoText
        Me.ListBox2.ForeColor = System.Drawing.Color.Red
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(308, 2)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.ScrollAlwaysVisible = True
        Me.ListBox2.Size = New System.Drawing.Size(88, 104)
        Me.ListBox2.TabIndex = 124
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Location = New System.Drawing.Point(283, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 31)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "اظهار كل الاعمده"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'print_taswy_frm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1924, 1061)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.msg_lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.num_taswy)
        Me.Controls.Add(Me.num_total)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "print_taswy_frm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "print_taswy_frm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_tabel_bnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_total, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_taswy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgv_tabel_bnd As System.Windows.Forms.DataGridView
    Friend WithEvents btn_export As System.Windows.Forms.Button
    Friend WithEvents num_total As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents num_taswy As System.Windows.Forms.NumericUpDown
    Public WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents msg_lbl As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
