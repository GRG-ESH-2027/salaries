<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_print_crystal
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.no_kshf = New System.Windows.Forms.ListBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_tot_report = New System.Windows.Forms.Button()
        Me.num_tot_end = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.num_tot_frist = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Item_Mkf = New System.Windows.Forms.ComboBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btn_print_to_excell_total = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_tot_end, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_tot_frist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Maroon
        Me.Button7.Enabled = False
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(524, 130)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(148, 38)
        Me.Button7.TabIndex = 75
        Me.Button7.Text = "طباعة الكشف "
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(391, 136)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(118, 30)
        Me.NumericUpDown1.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(271, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "رقم الكشف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(1166, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "مكافاة"
        Me.Label2.Visible = False
        '
        'no_kshf
        '
        Me.no_kshf.AllowDrop = True
        Me.no_kshf.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.no_kshf.FormattingEnabled = True
        Me.no_kshf.ItemHeight = 23
        Me.no_kshf.Location = New System.Drawing.Point(170, 42)
        Me.no_kshf.Name = "no_kshf"
        Me.no_kshf.ScrollAlwaysVisible = True
        Me.no_kshf.Size = New System.Drawing.Size(85, 188)
        Me.no_kshf.TabIndex = 81
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1129, 9)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(237, 74)
        Me.DataGridView2.TabIndex = 82
        Me.DataGridView2.Visible = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Location = New System.Drawing.Point(1246, 89)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 30)
        Me.NumericUpDown2.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Enabled = False
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(66, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 41)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "تحميل"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 23)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "صفحة طباعة اعداديه تقارير"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(11, 248)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1355, 369)
        Me.DataGridView1.TabIndex = 86
        Me.DataGridView1.VirtualMode = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(558, 213)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 30)
        Me.TextBox1.TabIndex = 87
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(780, 213)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(133, 30)
        Me.TextBox2.TabIndex = 88
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(1192, 213)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(133, 30)
        Me.TextBox3.TabIndex = 89
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(986, 213)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(133, 30)
        Me.TextBox4.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(919, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 23)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "الدور"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(1125, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 23)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "العام"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1053, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(305, 41)
        Me.Button2.TabIndex = 93
        Me.Button2.Text = "طباعة كشف الدفع الالكترونى رقم"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(261, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 23)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "طباعة اجمالى كشوف"
        '
        'Btn_tot_report
        '
        Me.Btn_tot_report.BackColor = System.Drawing.Color.Blue
        Me.Btn_tot_report.Enabled = False
        Me.Btn_tot_report.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        'Me.Btn_tot_report.Image = Global.gp_disk_pro.My.Resources.Resources.accept
        Me.Btn_tot_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_tot_report.Location = New System.Drawing.Point(878, 69)
        Me.Btn_tot_report.Name = "Btn_tot_report"
        Me.Btn_tot_report.Size = New System.Drawing.Size(158, 38)
        Me.Btn_tot_report.TabIndex = 99
        Me.Btn_tot_report.Text = "عرض التقرير"
        Me.Btn_tot_report.UseVisualStyleBackColor = False
        '
        'num_tot_end
        '
        Me.num_tot_end.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.num_tot_end.Location = New System.Drawing.Point(727, 74)
        Me.num_tot_end.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.num_tot_end.Name = "num_tot_end"
        Me.num_tot_end.Size = New System.Drawing.Size(145, 30)
        Me.num_tot_end.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(678, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 23)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "الى"
        '
        'num_tot_frist
        '
        Me.num_tot_frist.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.num_tot_frist.Location = New System.Drawing.Point(527, 77)
        Me.num_tot_frist.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.num_tot_frist.Name = "num_tot_frist"
        Me.num_tot_frist.Size = New System.Drawing.Size(145, 30)
        Me.num_tot_frist.TabIndex = 96
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(472, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 23)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "من"
        '
        'Item_Mkf
        '
        Me.Item_Mkf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Item_Mkf.FormattingEnabled = True
        Me.Item_Mkf.Items.AddRange(New Object() {"ملاحظه", "تصحيح"})
        Me.Item_Mkf.Location = New System.Drawing.Point(878, 9)
        Me.Item_Mkf.Name = "Item_Mkf"
        Me.Item_Mkf.Size = New System.Drawing.Size(158, 31)
        Me.Item_Mkf.TabIndex = 100
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(77, 91)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 33)
        Me.Button9.TabIndex = 101
        Me.Button9.Text = "خروج"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btn_print_to_excell_total
        '
        Me.btn_print_to_excell_total.BackColor = System.Drawing.Color.Blue
        Me.btn_print_to_excell_total.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        'Me.btn_print_to_excell_total.Image = Global.gp_disk_pro.My.Resources.Resources.accept
        Me.btn_print_to_excell_total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_print_to_excell_total.Location = New System.Drawing.Point(882, 113)
        Me.btn_print_to_excell_total.Name = "btn_print_to_excell_total"
        Me.btn_print_to_excell_total.Size = New System.Drawing.Size(154, 38)
        Me.btn_print_to_excell_total.TabIndex = 102
        Me.btn_print_to_excell_total.Text = "تجميع اكسيل"
        Me.btn_print_to_excell_total.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(336, 220)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar1.RightToLeftLayout = True
        Me.ProgressBar1.Size = New System.Drawing.Size(207, 23)
        Me.ProgressBar1.TabIndex = 103
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.BackColor = System.Drawing.Color.Yellow
        Me.NumericUpDown3.ForeColor = System.Drawing.Color.Red
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumericUpDown3.Location = New System.Drawing.Point(780, 119)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.ReadOnly = True
        Me.NumericUpDown3.Size = New System.Drawing.Size(93, 30)
        Me.NumericUpDown3.TabIndex = 104
        '
        'Form_print_crystal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1156, 644)
        Me.Controls.Add(Me.NumericUpDown3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btn_print_to_excell_total)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Item_Mkf)
        Me.Controls.Add(Me.Btn_tot_report)
        Me.Controls.Add(Me.num_tot_end)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.num_tot_frist)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.no_kshf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button7)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_print_crystal"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "Form_print_crystal"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_tot_end, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_tot_frist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents no_kshf As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Btn_tot_report As System.Windows.Forms.Button
    Public WithEvents num_tot_end As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents num_tot_frist As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Item_Mkf As System.Windows.Forms.ComboBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Public WithEvents btn_print_to_excell_total As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
End Class
