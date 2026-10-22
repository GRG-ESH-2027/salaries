<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class excel_add_form
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.name_empp = New System.Windows.Forms.TextBox()
        Me.open_file = New System.Windows.Forms.Button()
        Me.d1 = New System.Windows.Forms.DataGridView()
        Me.Name_Emp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.op_id_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salary_ass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dayes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.No_55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mkf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Darabb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Damghh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.box20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Mostkta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saffy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saffy_after_antkal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_kshf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_and_user_tfg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id_Mkf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_school = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.d2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.d1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.d2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(192, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 18)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(495, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 32)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "00"
        '
        'name_empp
        '
        Me.name_empp.Location = New System.Drawing.Point(455, 37)
        Me.name_empp.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.name_empp.Name = "name_empp"
        Me.name_empp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.name_empp.Size = New System.Drawing.Size(436, 26)
        Me.name_empp.TabIndex = 120
        '
        'open_file
        '
        Me.open_file.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.open_file.ForeColor = System.Drawing.Color.Red
        Me.open_file.Location = New System.Drawing.Point(898, 37)
        Me.open_file.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.open_file.Name = "open_file"
        Me.open_file.Size = New System.Drawing.Size(97, 31)
        Me.open_file.TabIndex = 119
        Me.open_file.Text = "......اختيار "
        Me.open_file.UseVisualStyleBackColor = False
        '
        'd1
        '
        Me.d1.AllowUserToAddRows = False
        Me.d1.AllowUserToDeleteRows = False
        Me.d1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.d1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name_Emp, Me.op_id_no, Me.Salary_ass, Me.Dayes, Me.No_55, Me.Mkf, Me.total, Me.Darabb, Me.Damghh, Me.box20, Me.Total_Mostkta, Me.Saffy, Me.Saffy_after_antkal, Me.no_kshf, Me.id_and_user_tfg, Me.id_user, Me.Id_Mkf, Me.id, Me.Name_school})
        Me.d1.Location = New System.Drawing.Point(0, 0)
        Me.d1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.d1.Name = "d1"
        Me.d1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.d1.Size = New System.Drawing.Size(1240, 219)
        Me.d1.TabIndex = 125
        '
        'Name_Emp
        '
        Me.Name_Emp.DataPropertyName = "Name_Emp"
        Me.Name_Emp.HeaderText = "الاسم"
        Me.Name_Emp.Name = "Name_Emp"
        Me.Name_Emp.ReadOnly = True
        Me.Name_Emp.Width = 200
        '
        'op_id_no
        '
        Me.op_id_no.DataPropertyName = "op_id_no"
        Me.op_id_no.HeaderText = "الرقم القومى"
        Me.op_id_no.Name = "op_id_no"
        Me.op_id_no.ReadOnly = True
        '
        'Salary_ass
        '
        Me.Salary_ass.DataPropertyName = "Salary_ass"
        Me.Salary_ass.HeaderText = "المرتب الاساسى"
        Me.Salary_ass.Name = "Salary_ass"
        Me.Salary_ass.ReadOnly = True
        '
        'Dayes
        '
        Me.Dayes.DataPropertyName = "Dayes"
        Me.Dayes.HeaderText = "عدد الايام"
        Me.Dayes.Name = "Dayes"
        Me.Dayes.ReadOnly = True
        '
        'No_55
        '
        Me.No_55.DataPropertyName = "No_55"
        Me.No_55.HeaderText = "رقم 55 ع ح"
        Me.No_55.Name = "No_55"
        Me.No_55.ReadOnly = True
        '
        'Mkf
        '
        Me.Mkf.DataPropertyName = "Mkf"
        Me.Mkf.HeaderText = "المكافاة"
        Me.Mkf.Name = "Mkf"
        Me.Mkf.ReadOnly = True
        '
        'total
        '
        Me.total.DataPropertyName = "total"
        Me.total.HeaderText = "الاجمالى"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'Darabb
        '
        Me.Darabb.DataPropertyName = "Darabb"
        Me.Darabb.HeaderText = "ضرائب"
        Me.Darabb.Name = "Darabb"
        Me.Darabb.ReadOnly = True
        '
        'Damghh
        '
        Me.Damghh.DataPropertyName = "Damghh"
        Me.Damghh.HeaderText = "دمغة"
        Me.Damghh.Name = "Damghh"
        Me.Damghh.ReadOnly = True
        '
        'box20
        '
        Me.box20.DataPropertyName = "box20"
        Me.box20.HeaderText = "صندوق"
        Me.box20.Name = "box20"
        Me.box20.ReadOnly = True
        '
        'Total_Mostkta
        '
        Me.Total_Mostkta.DataPropertyName = "Total_Mostkta"
        Me.Total_Mostkta.HeaderText = "جملة المستقطع"
        Me.Total_Mostkta.Name = "Total_Mostkta"
        Me.Total_Mostkta.ReadOnly = True
        '
        'Saffy
        '
        Me.Saffy.DataPropertyName = "Saffy"
        Me.Saffy.HeaderText = "الصافى"
        Me.Saffy.Name = "Saffy"
        Me.Saffy.ReadOnly = True
        '
        'Saffy_after_antkal
        '
        Me.Saffy_after_antkal.DataPropertyName = "Saffy_after_antkal"
        Me.Saffy_after_antkal.HeaderText = "الصافى بعد انتقالات"
        Me.Saffy_after_antkal.Name = "Saffy_after_antkal"
        '
        'no_kshf
        '
        Me.no_kshf.DataPropertyName = "no_kshf"
        Me.no_kshf.HeaderText = "رقم الكشف"
        Me.no_kshf.Name = "no_kshf"
        Me.no_kshf.ReadOnly = True
        '
        'id_and_user_tfg
        '
        Me.id_and_user_tfg.DataPropertyName = "id_and_user_tfg"
        Me.id_and_user_tfg.HeaderText = "م"
        Me.id_and_user_tfg.Name = "id_and_user_tfg"
        Me.id_and_user_tfg.ReadOnly = True
        '
        'id_user
        '
        Me.id_user.DataPropertyName = "id_user"
        Me.id_user.HeaderText = "id_user"
        Me.id_user.Name = "id_user"
        Me.id_user.ReadOnly = True
        '
        'Id_Mkf
        '
        Me.Id_Mkf.DataPropertyName = "Id_Mkf"
        Me.Id_Mkf.HeaderText = "Id_Mkf"
        Me.Id_Mkf.Name = "Id_Mkf"
        Me.Id_Mkf.ReadOnly = True
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'Name_school
        '
        Me.Name_school.DataPropertyName = "Name_school"
        Me.Name_school.HeaderText = "مدرسه"
        Me.Name_school.Name = "Name_school"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Sienna
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(807, 74)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 29)
        Me.Button1.TabIndex = 126
        Me.Button1.Text = "معرفة المكرر"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(650, 74)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 34)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "اضافة البيانات"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'd2
        '
        Me.d2.AllowUserToAddRows = False
        Me.d2.AllowUserToDeleteRows = False
        Me.d2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.d2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.tc, Me.Column2})
        Me.d2.Location = New System.Drawing.Point(512, 231)
        Me.d2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.d2.Name = "d2"
        Me.d2.ReadOnly = True
        Me.d2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.d2.Size = New System.Drawing.Size(764, 177)
        Me.d2.TabIndex = 128
        Me.d2.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "الخطأ"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'tc
        '
        Me.tc.HeaderText = "عدد التكرار"
        Me.tc.Name = "tc"
        Me.tc.ReadOnly = True
        Me.tc.Width = 95
        '
        'Column2
        '
        Me.Column2.FillWeight = 400.0!
        Me.Column2.HeaderText = "وصــــــــــف"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 400
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.ForeColor = System.Drawing.Color.Red
        Me.Button3.Location = New System.Drawing.Point(828, 681)
        Me.Button3.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 38)
        Me.Button3.TabIndex = 129
        Me.Button3.Text = "......"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Sienna
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(904, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(204, 34)
        Me.Button4.TabIndex = 130
        Me.Button4.Text = "فتح ملف اكسيل شرطه"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Sienna
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(195, 4)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 34)
        Me.Button5.TabIndex = 132
        Me.Button5.Text = "خروج"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.d2)
        Me.Panel1.Controls.Add(Me.d1)
        Me.Panel1.Location = New System.Drawing.Point(1, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1291, 448)
        Me.Panel1.TabIndex = 135
        '
        'ListBox1
        '
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(63, 239)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(441, 166)
        Me.ListBox1.TabIndex = 129
        Me.ListBox1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.name_empp)
        Me.Panel2.Controls.Add(Me.open_file)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(37, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1255, 104)
        Me.Panel2.TabIndex = 129
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(839, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(498, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(373, 18)
        Me.Label1.TabIndex = 137
        Me.Label1.Text = "صفحة ادخال بيانات من ملف اكسيل شرطة ثانوى عام"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.ForeColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(1115, 0)
        Me.Button6.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 31)
        Me.Button6.TabIndex = 136
        Me.Button6.Text = "جديد"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'excel_add_form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1331, 579)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "excel_add_form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "excel_add_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.d1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.d2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents name_empp As System.Windows.Forms.TextBox
    Friend WithEvents open_file As System.Windows.Forms.Button
    Friend WithEvents d1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents d2 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Name_Emp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents op_id_no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salary_ass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dayes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents No_55 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mkf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Darabb As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Damghh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents box20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Mostkta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saffy As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saffy_after_antkal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_kshf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_and_user_tfg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Mkf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Name_school As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
