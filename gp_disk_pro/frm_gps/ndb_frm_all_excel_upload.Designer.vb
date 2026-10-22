<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ndb_frm_all_excel_upload
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.count_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.open_file = New System.Windows.Forms.Button()
        Me.name_empp = New System.Windows.Forms.TextBox()
        Me.dgv_Table_add_tfrgh = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_Table_add_tfrgh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'count_lbl
        '
        Me.count_lbl.AutoSize = True
        Me.count_lbl.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count_lbl.ForeColor = System.Drawing.Color.Red
        Me.count_lbl.Location = New System.Drawing.Point(830, 39)
        Me.count_lbl.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.count_lbl.Name = "count_lbl"
        Me.count_lbl.Size = New System.Drawing.Size(47, 32)
        Me.count_lbl.TabIndex = 137
        Me.count_lbl.Text = "00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(669, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 32)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "00"
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.SaddleBrown
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(492, 44)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(147, 34)
        Me.btn_add.TabIndex = 134
        Me.btn_add.Text = "اضافة البيانات"
        Me.btn_add.UseVisualStyleBackColor = False
        Me.btn_add.Visible = False
        '
        'open_file
        '
        Me.open_file.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.open_file.ForeColor = System.Drawing.Color.Red
        Me.open_file.Location = New System.Drawing.Point(382, 44)
        Me.open_file.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.open_file.Name = "open_file"
        Me.open_file.Size = New System.Drawing.Size(97, 31)
        Me.open_file.TabIndex = 133
        Me.open_file.Text = "......اختيار "
        Me.open_file.UseVisualStyleBackColor = False
        '
        'name_empp
        '
        Me.name_empp.Location = New System.Drawing.Point(11, 46)
        Me.name_empp.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.name_empp.Name = "name_empp"
        Me.name_empp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.name_empp.Size = New System.Drawing.Size(369, 26)
        Me.name_empp.TabIndex = 132
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Table_add_tfrgh.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Table_add_tfrgh.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_Table_add_tfrgh.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv_Table_add_tfrgh.Location = New System.Drawing.Point(11, 81)
        Me.dgv_Table_add_tfrgh.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Table_add_tfrgh.MultiSelect = False
        Me.dgv_Table_add_tfrgh.Name = "dgv_Table_add_tfrgh"
        Me.dgv_Table_add_tfrgh.ReadOnly = True
        Me.dgv_Table_add_tfrgh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Table_add_tfrgh.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Table_add_tfrgh.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Table_add_tfrgh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Table_add_tfrgh.Size = New System.Drawing.Size(999, 510)
        Me.dgv_Table_add_tfrgh.TabIndex = 138
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id"
        Me.Column1.HeaderText = "مسلسل"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 73
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "name_emp"
        Me.Column2.HeaderText = "الاســـــــــــــــــــــــــــم"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "job"
        Me.Column3.HeaderText = "الوظيفة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "school"
        Me.Column4.HeaderText = "المدرسة الاصليه"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 134
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
        Me.Column5.Width = 132
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "al_gna"
        Me.Column6.HeaderText = "اللجنه"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 69
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "id_emp"
        Me.Column7.HeaderText = "الرقم القومى"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(14, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 32)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "صفحة تحميل ملف اكسيل ندب"
        '
        'BackgroundWorker1
        '
        '
        'BackgroundWorker2
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(773, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 32)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "عدد"
        '
        'ndb_frm_all_excel_upload
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1013, 602)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_Table_add_tfrgh)
        Me.Controls.Add(Me.count_lbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.open_file)
        Me.Controls.Add(Me.name_empp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ndb_frm_all_excel_upload"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تحميل ملف اكسيل"
        CType(Me.dgv_Table_add_tfrgh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents count_lbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents open_file As System.Windows.Forms.Button
    Friend WithEvents name_empp As System.Windows.Forms.TextBox
    Public WithEvents dgv_Table_add_tfrgh As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
