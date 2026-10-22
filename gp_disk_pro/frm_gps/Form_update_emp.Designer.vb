<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_update_emp
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.name_emplbl = New System.Windows.Forms.Label()
        Me.name_adderss = New System.Windows.Forms.TextBox()
        Me.dgv_emp = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.open_file = New System.Windows.Forms.Button()
        Me.btn_delete_data = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_selcet_data = New System.Windows.Forms.Button()
        Me.Btn_add = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1 = New gp_disk_pro.DataSet1()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gp_tafrgh_dbDataSet = New gp_disk_pro.gp_tafrgh_dbDataSet()
        Me.EmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpTableAdapter = New gp_disk_pro.gp_tafrgh_dbDataSetTableAdapters.empTableAdapter()
        Me.IdnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamepayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlktaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchoolDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoembDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameempDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gp_tafrgh_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'name_emplbl
        '
        Me.name_emplbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.name_emplbl.Font = New System.Drawing.Font("Times New Roman", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_emplbl.ForeColor = System.Drawing.Color.Blue
        Me.name_emplbl.Location = New System.Drawing.Point(355, 9)
        Me.name_emplbl.Name = "name_emplbl"
        Me.name_emplbl.Size = New System.Drawing.Size(633, 39)
        Me.name_emplbl.TabIndex = 0
        Me.name_emplbl.Text = "صفحة تحديث بيانات "
        Me.name_emplbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'name_emp
        '
        Me.name_adderss.Location = New System.Drawing.Point(116, 7)
        Me.name_adderss.Name = "name_adderss"
        Me.name_adderss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.name_adderss.Size = New System.Drawing.Size(881, 29)
        Me.name_adderss.TabIndex = 1
        '
        'dgv_emp
        '
        Me.dgv_emp.AllowUserToAddRows = False
        Me.dgv_emp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_emp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_emp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_emp.ColumnHeadersHeight = 44
        Me.dgv_emp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgv_emp.Location = New System.Drawing.Point(27, 239)
        Me.dgv_emp.Name = "dgv_emp"
        Me.dgv_emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_emp.Size = New System.Drawing.Size(1195, 136)
        Me.dgv_emp.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "اختيار"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 52
        '
        'open_file
        '
        Me.open_file.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.open_file.ForeColor = System.Drawing.Color.Red
        Me.open_file.Location = New System.Drawing.Point(18, 3)
        Me.open_file.Name = "open_file"
        Me.open_file.Size = New System.Drawing.Size(92, 36)
        Me.open_file.TabIndex = 3
        Me.open_file.Text = "......open"
        Me.open_file.UseVisualStyleBackColor = False
        '
        'btn_delete_data
        '
        Me.btn_delete_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_delete_data.ForeColor = System.Drawing.Color.Red
        Me.btn_delete_data.Location = New System.Drawing.Point(202, 0)
        Me.btn_delete_data.Name = "btn_delete_data"
        Me.btn_delete_data.Size = New System.Drawing.Size(179, 36)
        Me.btn_delete_data.TabIndex = 4
        Me.btn_delete_data.Text = "حذف بيانات مكرر"
        Me.btn_delete_data.UseVisualStyleBackColor = False
        Me.btn_delete_data.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Gold
        Me.BtnClose.ForeColor = System.Drawing.Color.Red
        Me.BtnClose.Location = New System.Drawing.Point(997, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(111, 36)
        Me.BtnClose.TabIndex = 5
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_selcet_data
        '
        Me.btn_selcet_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_selcet_data.ForeColor = System.Drawing.Color.Blue
        Me.btn_selcet_data.Location = New System.Drawing.Point(3, -2)
        Me.btn_selcet_data.Name = "btn_selcet_data"
        Me.btn_selcet_data.Size = New System.Drawing.Size(182, 35)
        Me.btn_selcet_data.TabIndex = 6
        Me.btn_selcet_data.Text = "تحديد بيانات مكرر"
        Me.btn_selcet_data.UseVisualStyleBackColor = False
        Me.btn_selcet_data.Visible = False
        '
        'Btn_add
        '
        Me.Btn_add.BackColor = System.Drawing.Color.LightSalmon
        Me.Btn_add.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_add.ForeColor = System.Drawing.Color.Blue
        Me.Btn_add.Location = New System.Drawing.Point(420, -2)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(202, 39)
        Me.Btn_add.TabIndex = 7
        Me.Btn_add.Text = "اضافة وتحديث بيانات"
        Me.Btn_add.UseVisualStyleBackColor = False
        Me.Btn_add.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(116, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 32)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(336, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 32)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "0"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProgressBar1.Location = New System.Drawing.Point(440, 15)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(568, 23)
        Me.ProgressBar1.TabIndex = 45
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.name_adderss)
        Me.Panel1.Controls.Add(Me.open_file)
        Me.Panel1.Location = New System.Drawing.Point(183, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 41)
        Me.Panel1.TabIndex = 48
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(301, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 31)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "اضافة بيانات"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(183, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1022, 35)
        Me.Panel2.TabIndex = 50
        Me.Panel2.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(29, -2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 36)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "حذف كل بيانات الموظف"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(183, 192)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1022, 41)
        Me.Panel3.TabIndex = 51
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Btn_add)
        Me.Panel4.Controls.Add(Me.btn_delete_data)
        Me.Panel4.Controls.Add(Me.btn_selcet_data)
        Me.Panel4.Location = New System.Drawing.Point(197, 51)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(822, 36)
        Me.Panel4.TabIndex = 51
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(638, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 31)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "حفظ فى ملف اكسيل"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'CheckBox1
       



        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Location = New System.Drawing.Point(1022, 51)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(146, 32)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdnoDataGridViewTextBoxColumn, Me.NamepayDataGridViewTextBoxColumn, Me.AlktaDataGridViewTextBoxColumn, Me.SchoolDataGridViewTextBoxColumn, Me.NoembDataGridViewTextBoxColumn, Me.NameempDataGridViewTextBoxColumn, Me.HhDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(347, 465)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(742, 150)
        Me.DataGridView1.TabIndex = 54
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'Gp_tafrgh_dbDataSet
        '
        Me.Gp_tafrgh_dbDataSet.DataSetName = "gp_tafrgh_dbDataSet"
        Me.Gp_tafrgh_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpBindingSource
        '
        Me.EmpBindingSource.DataMember = "emp"
        Me.EmpBindingSource.DataSource = Me.Gp_tafrgh_dbDataSet
        '
        'EmpTableAdapter
        '
        Me.EmpTableAdapter.ClearBeforeFill = True
        '
        'IdnoDataGridViewTextBoxColumn
        '
        Me.IdnoDataGridViewTextBoxColumn.DataPropertyName = "id_no"
        Me.IdnoDataGridViewTextBoxColumn.HeaderText = "id_no"
        Me.IdnoDataGridViewTextBoxColumn.Name = "IdnoDataGridViewTextBoxColumn"
        '
        'NamepayDataGridViewTextBoxColumn
        '
        Me.NamepayDataGridViewTextBoxColumn.DataPropertyName = "name_pay"
        Me.NamepayDataGridViewTextBoxColumn.HeaderText = "name_pay"
        Me.NamepayDataGridViewTextBoxColumn.Name = "NamepayDataGridViewTextBoxColumn"
        '
        'AlktaDataGridViewTextBoxColumn
        '
        Me.AlktaDataGridViewTextBoxColumn.DataPropertyName = "al_kta"
        Me.AlktaDataGridViewTextBoxColumn.HeaderText = "al_kta"
        Me.AlktaDataGridViewTextBoxColumn.Name = "AlktaDataGridViewTextBoxColumn"
        '
        'SchoolDataGridViewTextBoxColumn
        '
        Me.SchoolDataGridViewTextBoxColumn.DataPropertyName = "school"
        Me.SchoolDataGridViewTextBoxColumn.HeaderText = "school"
        Me.SchoolDataGridViewTextBoxColumn.Name = "SchoolDataGridViewTextBoxColumn"
        '
        'NoembDataGridViewTextBoxColumn
        '
        Me.NoembDataGridViewTextBoxColumn.DataPropertyName = "no_emb"
        Me.NoembDataGridViewTextBoxColumn.HeaderText = "no_emb"
        Me.NoembDataGridViewTextBoxColumn.Name = "NoembDataGridViewTextBoxColumn"
        '
        'NameempDataGridViewTextBoxColumn
        '
        Me.NameempDataGridViewTextBoxColumn.DataPropertyName = "name_emp"
        Me.NameempDataGridViewTextBoxColumn.HeaderText = "name_emp"
        Me.NameempDataGridViewTextBoxColumn.Name = "NameempDataGridViewTextBoxColumn"
        '
        'HhDataGridViewTextBoxColumn
        '
        Me.HhDataGridViewTextBoxColumn.DataPropertyName = "hh"
        Me.HhDataGridViewTextBoxColumn.HeaderText = "hh"
        Me.HhDataGridViewTextBoxColumn.Name = "HhDataGridViewTextBoxColumn"
        '
        'Form_update_emp
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 616)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.name_emplbl)
        Me.Controls.Add(Me.dgv_emp)
        Me.Controls.Add(Me.BtnClose)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_update_emp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "صفحة تحديث بيانات"
        Me.TopMost = True
        CType(Me.dgv_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gp_tafrgh_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents name_adderss As System.Windows.Forms.TextBox
    Friend WithEvents name_emplbl As System.Windows.Forms.Label
    Friend WithEvents dgv_emp As System.Windows.Forms.DataGridView
    Friend WithEvents open_file As System.Windows.Forms.Button
    Friend WithEvents btn_delete_data As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_selcet_data As System.Windows.Forms.Button
    Friend WithEvents Btn_add As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

    Private Sub Form_update_emp_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form_update_emp_AutoSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.AutoSizeChanged

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As gp_disk_pro.DataSet1
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gp_tafrgh_dbDataSet As gp_disk_pro.gp_tafrgh_dbDataSet
    Friend WithEvents EmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpTableAdapter As gp_disk_pro.gp_tafrgh_dbDataSetTableAdapters.empTableAdapter
    Friend WithEvents IdnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamepayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlktaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SchoolDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoembDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameempDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
