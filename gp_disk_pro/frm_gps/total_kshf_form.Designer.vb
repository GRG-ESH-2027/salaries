<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class total_kshf_form
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
        Me.txt_num_rows = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lbl_load_percen = New System.Windows.Forms.Label()
        Me.lbl_load = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_print_to_excell_total = New System.Windows.Forms.Button()
        Me.num_tot_end = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.num_tot_frist = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmb_exam = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_years = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_part = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_mkf_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.no_kshf = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_load_kshf = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtArabicWord = New System.Windows.Forms.TextBox()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.txtEnglishWord = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.cboCurrency = New System.Windows.Forms.ComboBox()
        CType(Me.num_tot_end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_tot_frist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_num_rows
        '
        Me.txt_num_rows.AutoSize = True
        Me.txt_num_rows.ForeColor = System.Drawing.Color.White
        Me.txt_num_rows.Location = New System.Drawing.Point(133, 183)
        Me.txt_num_rows.Name = "txt_num_rows"
        Me.txt_num_rows.Size = New System.Drawing.Size(22, 23)
        Me.txt_num_rows.TabIndex = 86
        Me.txt_num_rows.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(542, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 23)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "طباعة اجمالى كشوف"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'lbl_load_percen
        '
        Me.lbl_load_percen.AutoSize = True
        Me.lbl_load_percen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_load_percen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_load_percen.Location = New System.Drawing.Point(212, 198)
        Me.lbl_load_percen.Name = "lbl_load_percen"
        Me.lbl_load_percen.Size = New System.Drawing.Size(22, 23)
        Me.lbl_load_percen.TabIndex = 132
        Me.lbl_load_percen.Text = "0"
        '
        'lbl_load
        '
        Me.lbl_load.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_load.AutoSize = True
        Me.lbl_load.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_load.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_load.Location = New System.Drawing.Point(511, 183)
        Me.lbl_load.Name = "lbl_load"
        Me.lbl_load.Size = New System.Drawing.Size(22, 23)
        Me.lbl_load.TabIndex = 131
        Me.lbl_load.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Yellow
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar1.Location = New System.Drawing.Point(335, 229)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar1.RightToLeftLayout = True
        Me.ProgressBar1.Size = New System.Drawing.Size(207, 23)
        Me.ProgressBar1.TabIndex = 130
        '
        'btn_print_to_excell_total
        '
        Me.btn_print_to_excell_total.BackColor = System.Drawing.Color.Blue
        Me.btn_print_to_excell_total.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_print_to_excell_total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print_to_excell_total.Location = New System.Drawing.Point(37, 135)
        Me.btn_print_to_excell_total.Name = "btn_print_to_excell_total"
        Me.btn_print_to_excell_total.Size = New System.Drawing.Size(154, 38)
        Me.btn_print_to_excell_total.TabIndex = 129
        Me.btn_print_to_excell_total.Text = "تجميع اكسيل"
        Me.btn_print_to_excell_total.UseVisualStyleBackColor = False
        '
        'num_tot_end
        '
        Me.num_tot_end.Location = New System.Drawing.Point(222, 141)
        Me.num_tot_end.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.num_tot_end.Name = "num_tot_end"
        Me.num_tot_end.Size = New System.Drawing.Size(145, 30)
        Me.num_tot_end.TabIndex = 128
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(385, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 23)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "الــــى"
        '
        'num_tot_frist
        '
        Me.num_tot_frist.Location = New System.Drawing.Point(489, 143)
        Me.num_tot_frist.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.num_tot_frist.Name = "num_tot_frist"
        Me.num_tot_frist.Size = New System.Drawing.Size(145, 30)
        Me.num_tot_frist.TabIndex = 126
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(640, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 23)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "مــــــــــــن"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.num_tot_frist)
        Me.Panel1.Controls.Add(Me.lbl_load_percen)
        Me.Panel1.Controls.Add(Me.num_tot_end)
        Me.Panel1.Controls.Add(Me.lbl_load)
        Me.Panel1.Controls.Add(Me.btn_print_to_excell_total)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.txt_num_rows)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(206, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(740, 311)
        Me.Panel1.TabIndex = 135
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Indigo
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.33766!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.66234!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_exam, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_years, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmb_part, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_mkf_name, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(27, 13)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.7907!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.2093!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(690, 93)
        Me.TableLayoutPanel1.TabIndex = 139
        '
        'cmb_exam
        '
        Me.cmb_exam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_exam.FormattingEnabled = True
        Me.cmb_exam.Items.AddRange(New Object() {"ملاحظه", "تصحيح"})
        Me.cmb_exam.Location = New System.Drawing.Point(292, 61)
        Me.cmb_exam.Name = "cmb_exam"
        Me.cmb_exam.Size = New System.Drawing.Size(216, 31)
        Me.cmb_exam.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(545, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "مكافاة امتحان :"
        '
        'txt_years
        '
        Me.txt_years.Location = New System.Drawing.Point(16, 3)
        Me.txt_years.Name = "txt_years"
        Me.txt_years.Size = New System.Drawing.Size(176, 30)
        Me.txt_years.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(202, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 23)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "ســنة"
        '
        'cmb_part
        '
        Me.cmb_part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_part.FormattingEnabled = True
        Me.cmb_part.Items.AddRange(New Object() {"الاول", "الثانى"})
        Me.cmb_part.Location = New System.Drawing.Point(34, 61)
        Me.cmb_part.Name = "cmb_part"
        Me.cmb_part.Size = New System.Drawing.Size(158, 31)
        Me.cmb_part.TabIndex = 138
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(211, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 23)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "دور :"
        '
        'txt_mkf_name
        '
        Me.txt_mkf_name.Location = New System.Drawing.Point(292, 3)
        Me.txt_mkf_name.Name = "txt_mkf_name"
        Me.txt_mkf_name.Size = New System.Drawing.Size(216, 30)
        Me.txt_mkf_name.TabIndex = 116
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(556, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "نوع الامتحان :"
        '
        'no_kshf
        '
        Me.no_kshf.FormattingEnabled = True
        Me.no_kshf.ItemHeight = 23
        Me.no_kshf.Location = New System.Drawing.Point(32, 39)
        Me.no_kshf.Name = "no_kshf"
        Me.no_kshf.Size = New System.Drawing.Size(99, 165)
        Me.no_kshf.TabIndex = 136
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 23)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "الكشوف المتاحة"
        '
        'btn_load_kshf
        '
        Me.btn_load_kshf.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_load_kshf.Location = New System.Drawing.Point(174, 9)
        Me.btn_load_kshf.Name = "btn_load_kshf"
        Me.btn_load_kshf.Size = New System.Drawing.Size(169, 39)
        Me.btn_load_kshf.TabIndex = 138
        Me.btn_load_kshf.Text = "تحميل كشوف"
        Me.btn_load_kshf.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(Me.txtArabicWord)
        Me.Panel2.Controls.Add(Me.NumericUpDown3)
        Me.Panel2.Controls.Add(Me.txtEnglishWord)
        Me.Panel2.Controls.Add(Me.txtNumber)
        Me.Panel2.Controls.Add(Me.cboCurrency)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(91, 400)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(867, 119)
        Me.Panel2.TabIndex = 140
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(219, 9)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 103
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtArabicWord
        '
        Me.txtArabicWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtArabicWord.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArabicWord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtArabicWord.Location = New System.Drawing.Point(15, 37)
        Me.txtArabicWord.Multiline = True
        Me.txtArabicWord.Name = "txtArabicWord"
        Me.txtArabicWord.ReadOnly = True
        Me.txtArabicWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtArabicWord.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtArabicWord.Size = New System.Drawing.Size(849, 29)
        Me.txtArabicWord.TabIndex = 10
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumericUpDown3.Location = New System.Drawing.Point(15, 1)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.ReadOnly = True
        Me.NumericUpDown3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumericUpDown3.Size = New System.Drawing.Size(169, 30)
        Me.NumericUpDown3.TabIndex = 102
        Me.NumericUpDown3.ThousandsSeparator = True
        '
        'txtEnglishWord
        '
        Me.txtEnglishWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnglishWord.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnglishWord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtEnglishWord.Location = New System.Drawing.Point(15, 72)
        Me.txtEnglishWord.Multiline = True
        Me.txtEnglishWord.Name = "txtEnglishWord"
        Me.txtEnglishWord.ReadOnly = True
        Me.txtEnglishWord.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEnglishWord.Size = New System.Drawing.Size(849, 23)
        Me.txtEnglishWord.TabIndex = 9
        '
        'txtNumber
        '
        Me.txtNumber.ForeColor = System.Drawing.Color.Blue
        Me.txtNumber.Location = New System.Drawing.Point(266, 1)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(432, 30)
        Me.txtNumber.TabIndex = 8
        '
        'cboCurrency
        '
        Me.cboCurrency.DisplayMember = "EnglishCurrencyName"
        Me.cboCurrency.Enabled = False
        Me.cboCurrency.FormattingEnabled = True
        Me.cboCurrency.Items.AddRange(New Object() {"Saudi Riyal"})
        Me.cboCurrency.Location = New System.Drawing.Point(726, 3)
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Size = New System.Drawing.Size(138, 31)
        Me.cboCurrency.TabIndex = 7
        Me.cboCurrency.Text = "Saudi Riyal"
        Me.cboCurrency.ValueMember = "CurrencyID"
        '
        'total_kshf_form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 706)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_load_kshf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.no_kshf)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.Name = "total_kshf_form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "total_kshf_form"
        CType(Me.num_tot_end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_tot_frist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_num_rows As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_load_percen As System.Windows.Forms.Label
    Friend WithEvents lbl_load As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents btn_print_to_excell_total As System.Windows.Forms.Button
    Public WithEvents num_tot_end As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents num_tot_frist As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents no_kshf As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_load_kshf As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmb_exam As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_years As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_part As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_mkf_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Private WithEvents txtArabicWord As System.Windows.Forms.TextBox
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Private WithEvents txtEnglishWord As System.Windows.Forms.TextBox
    Private WithEvents txtNumber As System.Windows.Forms.TextBox
    Private WithEvents cboCurrency As System.Windows.Forms.ComboBox
End Class
