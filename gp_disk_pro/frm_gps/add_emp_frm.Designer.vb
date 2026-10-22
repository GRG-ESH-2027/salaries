<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_emp_frm
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
        Me.name_paylbl = New System.Windows.Forms.Label()
        Me.al_ktalbl = New System.Windows.Forms.Label()
        Me.schoollbl = New System.Windows.Forms.Label()
        Me.school = New System.Windows.Forms.TextBox()
        Me.no_emblbl = New System.Windows.Forms.Label()
        Me.no_emb = New System.Windows.Forms.TextBox()
        Me.name_emplbl = New System.Windows.Forms.Label()
        Me.name_emp = New System.Windows.Forms.TextBox()
        Me.hh = New System.Windows.Forms.Label()
        Me.dgv_emp = New System.Windows.Forms.DataGridView()
        Me.IdnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameempDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoembDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamepayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlktaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gp_tafrgh_dbDataSet3 = New gp_disk_pro.gp_tafrgh_dbDataSet3()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_no_txt = New System.Windows.Forms.TextBox()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lbl_load = New System.Windows.Forms.Label()
        Me.EmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gp_tafrgh_dbDataSet2 = New gp_disk_pro.gp_tafrgh_dbDataSet2()
        Me.EmpTableAdapter = New gp_disk_pro.gp_tafrgh_dbDataSet2TableAdapters.empTableAdapter()
        Me.EmpTableAdapter1 = New gp_disk_pro.gp_tafrgh_dbDataSet3TableAdapters.empTableAdapter()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgv_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gp_tafrgh_dbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gp_tafrgh_dbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'name_paylbl
        '
        Me.name_paylbl.ForeColor = System.Drawing.Color.White
        Me.name_paylbl.Location = New System.Drawing.Point(21, 440)
        Me.name_paylbl.Name = "name_paylbl"
        Me.name_paylbl.Size = New System.Drawing.Size(191, 23)
        Me.name_paylbl.TabIndex = 2
        Me.name_paylbl.Text = "2-اخرى بطاقات حكومية"
        Me.name_paylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'al_ktalbl
        '
        Me.al_ktalbl.ForeColor = System.Drawing.Color.White
        Me.al_ktalbl.Location = New System.Drawing.Point(-4, 410)
        Me.al_ktalbl.Name = "al_ktalbl"
        Me.al_ktalbl.Size = New System.Drawing.Size(225, 23)
        Me.al_ktalbl.TabIndex = 4
        Me.al_ktalbl.Text = "الأدارة التعليميه بأبو قرقاص"
        Me.al_ktalbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'schoollbl
        '
        Me.schoollbl.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.schoollbl.Location = New System.Drawing.Point(10, 152)
        Me.schoollbl.Name = "schoollbl"
        Me.schoollbl.Size = New System.Drawing.Size(120, 23)
        Me.schoollbl.TabIndex = 6
        Me.schoollbl.Text = "المدرسة"
        Me.schoollbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'school
        '
        Me.school.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.school.Location = New System.Drawing.Point(130, 152)
        Me.school.Name = "school"
        Me.school.Size = New System.Drawing.Size(300, 30)
        Me.school.TabIndex = 37
        '
        'no_emblbl
        '
        Me.no_emblbl.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.no_emblbl.Location = New System.Drawing.Point(10, 182)
        Me.no_emblbl.Name = "no_emblbl"
        Me.no_emblbl.Size = New System.Drawing.Size(120, 23)
        Me.no_emblbl.TabIndex = 8
        Me.no_emblbl.Text = "رقم الموظف"
        Me.no_emblbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'no_emb
        '
        Me.no_emb.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.no_emb.Location = New System.Drawing.Point(130, 182)
        Me.no_emb.Name = "no_emb"
        Me.no_emb.Size = New System.Drawing.Size(300, 30)
        Me.no_emb.TabIndex = 9
        '
        'name_emplbl
        '
        Me.name_emplbl.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.name_emplbl.Location = New System.Drawing.Point(10, 120)
        Me.name_emplbl.Name = "name_emplbl"
        Me.name_emplbl.Size = New System.Drawing.Size(120, 23)
        Me.name_emplbl.TabIndex = 10
        Me.name_emplbl.Text = "اسم الموظف"
        Me.name_emplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'name_emp
        '
        Me.name_emp.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.name_emp.Location = New System.Drawing.Point(130, 120)
        Me.name_emp.Name = "name_emp"
        Me.name_emp.Size = New System.Drawing.Size(300, 30)
        Me.name_emp.TabIndex = 11
        '
        'hh
        '
        Me.hh.Location = New System.Drawing.Point(21, 288)
        Me.hh.Name = "hh"
        Me.hh.Size = New System.Drawing.Size(391, 111)
        Me.hh.TabIndex = 13
        Me.hh.Text = "0"
        '
        'dgv_emp
        '
        Me.dgv_emp.AllowUserToAddRows = False
        Me.dgv_emp.AllowUserToDeleteRows = False
        Me.dgv_emp.AutoGenerateColumns = False
        Me.dgv_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_emp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_emp.ColumnHeadersHeight = 40
        Me.dgv_emp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdnoDataGridViewTextBoxColumn, Me.NameempDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.NoembDataGridViewTextBoxColumn, Me.NamepayDataGridViewTextBoxColumn, Me.AlktaDataGridViewTextBoxColumn})
        Me.dgv_emp.DataSource = Me.EmpBindingSource1
        Me.dgv_emp.Location = New System.Drawing.Point(436, 88)
        Me.dgv_emp.Name = "dgv_emp"
        Me.dgv_emp.ReadOnly = True
        Me.dgv_emp.RowHeadersWidth = 51
        Me.dgv_emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_emp.Size = New System.Drawing.Size(982, 400)
        Me.dgv_emp.TabIndex = 14
        '
        'IdnoDataGridViewTextBoxColumn
        '
        Me.IdnoDataGridViewTextBoxColumn.DataPropertyName = "id_no"
        Me.IdnoDataGridViewTextBoxColumn.HeaderText = "الرقم القومى"
        Me.IdnoDataGridViewTextBoxColumn.Name = "IdnoDataGridViewTextBoxColumn"
        Me.IdnoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdnoDataGridViewTextBoxColumn.Width = 114
        '
        'NameempDataGridViewTextBoxColumn
        '
        Me.NameempDataGridViewTextBoxColumn.DataPropertyName = "name_emp"
        Me.NameempDataGridViewTextBoxColumn.HeaderText = "اسم الموظف"
        Me.NameempDataGridViewTextBoxColumn.Name = "NameempDataGridViewTextBoxColumn"
        Me.NameempDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameempDataGridViewTextBoxColumn.Width = 114
        '
        'SchoolDataGridViewTextBoxColumn
        '
        Me.SchoolDataGridViewTextBoxColumn.DataPropertyName = "school"
        Me.SchoolDataGridViewTextBoxColumn.HeaderText = "المدرسة"
        Me.SchoolDataGridViewTextBoxColumn.Name = "SchoolDataGridViewTextBoxColumn"
        Me.SchoolDataGridViewTextBoxColumn.ReadOnly = True
        Me.SchoolDataGridViewTextBoxColumn.Width = 88
        '
        'NoembDataGridViewTextBoxColumn
        '
        Me.NoembDataGridViewTextBoxColumn.DataPropertyName = "no_emb"
        Me.NoembDataGridViewTextBoxColumn.HeaderText = "رقم الموظف"
        Me.NoembDataGridViewTextBoxColumn.Name = "NoembDataGridViewTextBoxColumn"
        Me.NoembDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoembDataGridViewTextBoxColumn.Width = 113
        '
        'NamepayDataGridViewTextBoxColumn
        '
        Me.NamepayDataGridViewTextBoxColumn.DataPropertyName = "name_pay"
        Me.NamepayDataGridViewTextBoxColumn.HeaderText = "نوع المدفوعة"
        Me.NamepayDataGridViewTextBoxColumn.Name = "NamepayDataGridViewTextBoxColumn"
        Me.NamepayDataGridViewTextBoxColumn.ReadOnly = True
        Me.NamepayDataGridViewTextBoxColumn.Width = 123
        '
        'AlktaDataGridViewTextBoxColumn
        '
        Me.AlktaDataGridViewTextBoxColumn.DataPropertyName = "al_kta"
        Me.AlktaDataGridViewTextBoxColumn.HeaderText = "القطاع"
        Me.AlktaDataGridViewTextBoxColumn.Name = "AlktaDataGridViewTextBoxColumn"
        Me.AlktaDataGridViewTextBoxColumn.ReadOnly = True
        Me.AlktaDataGridViewTextBoxColumn.Width = 76
        '
        'EmpBindingSource1
        '
        Me.EmpBindingSource1.DataMember = "emp"
        Me.EmpBindingSource1.DataSource = Me.Gp_tafrgh_dbDataSet3
        '
        'Gp_tafrgh_dbDataSet3
        '
        Me.Gp_tafrgh_dbDataSet3.DataSetName = "gp_tafrgh_dbDataSet3"
        Me.Gp_tafrgh_dbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label1.Location = New System.Drawing.Point(78, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "صفحة ادخال موظف جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label2.Location = New System.Drawing.Point(10, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "الرقم القومى"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'id_no_txt
        '
        Me.id_no_txt.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.id_no_txt.Location = New System.Drawing.Point(130, 88)
        Me.id_no_txt.MaxLength = 14
        Me.id_no_txt.Name = "id_no_txt"
        Me.id_no_txt.Size = New System.Drawing.Size(300, 30)
        Me.id_no_txt.TabIndex = 7
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.Orange
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.White
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(130, 229)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(91, 36)
        Me.BtnNewAdd.TabIndex = 38
        Me.BtnNewAdd.Text = "حفظ-f4"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(245, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 36)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "خروج"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.txt_name.Location = New System.Drawing.Point(690, 12)
        Me.txt_name.MaxLength = 14
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(276, 30)
        Me.txt_name.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label3.Location = New System.Drawing.Point(519, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "البحث : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Orange
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(436, 54)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 30)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "تحميل البيانات"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(690, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 30)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "البحث"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Location = New System.Drawing.Point(818, 494)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar1.RightToLeftLayout = True
        Me.ProgressBar1.Size = New System.Drawing.Size(284, 23)
        Me.ProgressBar1.TabIndex = 102
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'lbl_load
        '
        Me.lbl_load.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_load.ForeColor = System.Drawing.Color.Red
        Me.lbl_load.Location = New System.Drawing.Point(436, 495)
        Me.lbl_load.Name = "lbl_load"
        Me.lbl_load.Size = New System.Drawing.Size(308, 24)
        Me.lbl_load.TabIndex = 103
        Me.lbl_load.Text = "0"
        Me.lbl_load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpBindingSource
        '
        Me.EmpBindingSource.DataMember = "emp"
        Me.EmpBindingSource.DataSource = Me.Gp_tafrgh_dbDataSet2
        '
        'Gp_tafrgh_dbDataSet2
        '
        Me.Gp_tafrgh_dbDataSet2.DataSetName = "gp_tafrgh_dbDataSet2"
        Me.Gp_tafrgh_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpTableAdapter
        '
        Me.EmpTableAdapter.ClearBeforeFill = True
        '
        'EmpTableAdapter1
        '
        Me.EmpTableAdapter1.ClearBeforeFill = True
        '
        'txt_id
        '
        Me.txt_id.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.txt_id.Location = New System.Drawing.Point(1130, 7)
        Me.txt_id.MaxLength = 14
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(276, 30)
        Me.txt_id.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label4.Location = New System.Drawing.Point(597, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "الاسم"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label5.Location = New System.Drawing.Point(972, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 24)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "الرقم القومى"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'add_emp_frm
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1439, 531)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_load)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnNewAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_no_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.name_paylbl)
        Me.Controls.Add(Me.al_ktalbl)
        Me.Controls.Add(Me.schoollbl)
        Me.Controls.Add(Me.school)
        Me.Controls.Add(Me.no_emblbl)
        Me.Controls.Add(Me.no_emb)
        Me.Controls.Add(Me.name_emplbl)
        Me.Controls.Add(Me.name_emp)
        Me.Controls.Add(Me.hh)
        Me.Controls.Add(Me.dgv_emp)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "add_emp_frm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmemp"
        CType(Me.dgv_emp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gp_tafrgh_dbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gp_tafrgh_dbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name_paylbl As System.Windows.Forms.Label
    Friend WithEvents al_ktalbl As System.Windows.Forms.Label
    Friend WithEvents school As System.Windows.Forms.TextBox
    Friend WithEvents schoollbl As System.Windows.Forms.Label
    Friend WithEvents no_emb As System.Windows.Forms.TextBox
    Friend WithEvents no_emblbl As System.Windows.Forms.Label
    Friend WithEvents name_emp As System.Windows.Forms.TextBox
    Friend WithEvents name_emplbl As System.Windows.Forms.Label
    Friend WithEvents hh As System.Windows.Forms.Label
    Friend WithEvents dgv_emp As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id_no_txt As System.Windows.Forms.TextBox
    Public WithEvents BtnNewAdd As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Gp_tafrgh_dbDataSet2 As gp_disk_pro.gp_tafrgh_dbDataSet2
    Friend WithEvents EmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpTableAdapter As gp_disk_pro.gp_tafrgh_dbDataSet2TableAdapters.empTableAdapter
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Gp_tafrgh_dbDataSet3 As gp_disk_pro.gp_tafrgh_dbDataSet3
    Friend WithEvents EmpBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EmpTableAdapter1 As gp_disk_pro.gp_tafrgh_dbDataSet3TableAdapters.empTableAdapter
    Public WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IdnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameempDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoembDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamepayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlktaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_load As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
