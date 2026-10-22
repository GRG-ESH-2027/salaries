<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_salary_ass_Form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.name_empp = New System.Windows.Forms.TextBox()
        Me.open_file = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.d1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.d1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(778, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 29)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "صفحة تعديل المرتب الاساسى"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Sienna
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(964, 113)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 39)
        Me.Button1.TabIndex = 142
        Me.Button1.Text = "معرفة المكرر"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.ForeColor = System.Drawing.Color.Red
        Me.Button6.Location = New System.Drawing.Point(1189, 63)
        Me.Button6.Margin = New System.Windows.Forms.Padding(12, 9, 12, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 35)
        Me.Button6.TabIndex = 146
        Me.Button6.Text = "جديد"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(571, 113)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 32)
        Me.Button2.TabIndex = 143
        Me.Button2.Text = " تعديل البيانات"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(256, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 32)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "00"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Sienna
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(30, 24)
        Me.Button4.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 38)
        Me.Button4.TabIndex = 144
        Me.Button4.Text = "فتح ملف اكسيل "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Sienna
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(225, 24)
        Me.Button5.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 47)
        Me.Button5.TabIndex = 145
        Me.Button5.Text = "خروج"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'name_empp
        '
        Me.name_empp.Location = New System.Drawing.Point(372, 68)
        Me.name_empp.Margin = New System.Windows.Forms.Padding(12, 9, 12, 9)
        Me.name_empp.Name = "name_empp"
        Me.name_empp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.name_empp.Size = New System.Drawing.Size(652, 26)
        Me.name_empp.TabIndex = 139
        '
        'open_file
        '
        Me.open_file.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.open_file.ForeColor = System.Drawing.Color.Red
        Me.open_file.Location = New System.Drawing.Point(1030, 63)
        Me.open_file.Margin = New System.Windows.Forms.Padding(12, 9, 12, 9)
        Me.open_file.Name = "open_file"
        Me.open_file.Size = New System.Drawing.Size(146, 34)
        Me.open_file.TabIndex = 138
        Me.open_file.Text = "......اختيار "
        Me.open_file.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(220, 87)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 18)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "0"
        '
        'd1
        '
        Me.d1.AllowUserToAddRows = False
        Me.d1.AllowUserToDeleteRows = False
        Me.d1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.d1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.d1.Location = New System.Drawing.Point(372, 169)
        Me.d1.Name = "d1"
        Me.d1.ReadOnly = True
        Me.d1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.d1.Size = New System.Drawing.Size(785, 440)
        Me.d1.TabIndex = 148
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_no"
        Me.Column1.FillWeight = 200.0!
        Me.Column1.HeaderText = "الرقم القومى"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.FillWeight = 300.0!
        Me.Column2.HeaderText = "الاســـــــم"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "salary_old"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.FillWeight = 200.0!
        Me.Column3.HeaderText = "المرتب الاساسى الجديد"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 165)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(354, 576)
        Me.ListBox1.TabIndex = 150
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(586, 14)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 27)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "تاريخ التعديل"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.AllowDrop = True
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(390, 14)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(178, 26)
        Me.DateTimePicker1.TabIndex = 151
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.Enabled = False
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(784, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(159, 38)
        Me.Button3.TabIndex = 153
        Me.Button3.Text = "اضافة وتعديل"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Edit_salary_ass_Form
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1284, 836)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.name_empp)
        Me.Controls.Add(Me.open_file)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Edit_salary_ass_Form"
        Me.Text = "Edit_salary_ass_Form"
        CType(Me.d1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents name_empp As System.Windows.Forms.TextBox
    Friend WithEvents open_file As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents d1 As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Public WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
