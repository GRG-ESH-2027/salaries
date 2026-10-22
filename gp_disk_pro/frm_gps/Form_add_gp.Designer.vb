<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_add_gp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_add_gp))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.idlbl = New System.Windows.Forms.Label()
        Me.date1lbl = New System.Windows.Forms.Label()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.descrlbl = New System.Windows.Forms.Label()
        Me.no_filelbl = New System.Windows.Forms.Label()
        Me.no_file = New System.Windows.Forms.TextBox()
        Me.el_mablghlbl = New System.Windows.Forms.Label()
        Me.no_gplbl = New System.Windows.Forms.Label()
        Me.no_gp = New System.Windows.Forms.TextBox()
        Me.date_assthkklbl = New System.Windows.Forms.Label()
        Me.date_assthkk = New System.Windows.Forms.DateTimePicker()
        Me.no_shatblbl = New System.Windows.Forms.Label()
        Me.no_shatb = New System.Windows.Forms.TextBox()
        Me.id_desclbl = New System.Windows.Forms.Label()
        Me.id_desc = New System.Windows.Forms.ComboBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.dgv_gp_table = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.el_mablgh = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.descr = New System.Windows.Forms.TextBox()
        Me.Table_gpsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New gp_disk_pro.DataSet1()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.id = New System.Windows.Forms.NumericUpDown()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.id_user = New System.Windows.Forms.Label()
        CType(Me.dgv_gp_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.el_mablgh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table_gpsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'idlbl
        '
        resources.ApplyResources(Me.idlbl, "idlbl")
        Me.idlbl.ForeColor = System.Drawing.Color.White
        Me.idlbl.Name = "idlbl"
        '
        'date1lbl
        '
        resources.ApplyResources(Me.date1lbl, "date1lbl")
        Me.date1lbl.ForeColor = System.Drawing.Color.White
        Me.date1lbl.Name = "date1lbl"
        '
        'date1
        '
        resources.ApplyResources(Me.date1, "date1")
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date1.Name = "date1"
        '
        'descrlbl
        '
        resources.ApplyResources(Me.descrlbl, "descrlbl")
        Me.descrlbl.ForeColor = System.Drawing.Color.White
        Me.descrlbl.Name = "descrlbl"
        '
        'no_filelbl
        '
        resources.ApplyResources(Me.no_filelbl, "no_filelbl")
        Me.no_filelbl.ForeColor = System.Drawing.Color.White
        Me.no_filelbl.Name = "no_filelbl"
        '
        'no_file
        '
        resources.ApplyResources(Me.no_file, "no_file")
        Me.no_file.Name = "no_file"
        '
        'el_mablghlbl
        '
        resources.ApplyResources(Me.el_mablghlbl, "el_mablghlbl")
        Me.el_mablghlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.el_mablghlbl.ForeColor = System.Drawing.Color.White
        Me.el_mablghlbl.Name = "el_mablghlbl"
        '
        'no_gplbl
        '
        resources.ApplyResources(Me.no_gplbl, "no_gplbl")
        Me.no_gplbl.ForeColor = System.Drawing.Color.White
        Me.no_gplbl.Name = "no_gplbl"
        '
        'no_gp
        '
        resources.ApplyResources(Me.no_gp, "no_gp")
        Me.no_gp.Name = "no_gp"
        '
        'date_assthkklbl
        '
        resources.ApplyResources(Me.date_assthkklbl, "date_assthkklbl")
        Me.date_assthkklbl.ForeColor = System.Drawing.Color.White
        Me.date_assthkklbl.Name = "date_assthkklbl"
        '
        'date_assthkk
        '
        resources.ApplyResources(Me.date_assthkk, "date_assthkk")
        Me.date_assthkk.Name = "date_assthkk"
        '
        'no_shatblbl
        '
        resources.ApplyResources(Me.no_shatblbl, "no_shatblbl")
        Me.no_shatblbl.ForeColor = System.Drawing.Color.White
        Me.no_shatblbl.Name = "no_shatblbl"
        '
        'no_shatb
        '
        resources.ApplyResources(Me.no_shatb, "no_shatb")
        Me.no_shatb.Name = "no_shatb"
        '
        'id_desclbl
        '
        resources.ApplyResources(Me.id_desclbl, "id_desclbl")
        Me.id_desclbl.ForeColor = System.Drawing.Color.White
        Me.id_desclbl.Name = "id_desclbl"
        '
        'id_desc
        '
        Me.id_desc.AllowDrop = True
        resources.ApplyResources(Me.id_desc, "id_desc")
        Me.id_desc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.id_desc.Name = "id_desc"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Orange
        resources.ApplyResources(Me.BtnEdit, "BtnEdit")
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'dgv_gp_table
        '
        Me.dgv_gp_table.AllowDrop = True
        Me.dgv_gp_table.AllowUserToAddRows = False
        Me.dgv_gp_table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_gp_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.dgv_gp_table, "dgv_gp_table")
        Me.dgv_gp_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_gp_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_gp_table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_gp_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_gp_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gp_table.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_gp_table.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_gp_table.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv_gp_table.MultiSelect = False
        Me.dgv_gp_table.Name = "dgv_gp_table"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_gp_table.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_gp_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_gp_table.VirtualMode = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Name = "Label1"
        '
        'el_mablgh
        '
        resources.ApplyResources(Me.el_mablgh, "el_mablgh")
        Me.el_mablgh.DecimalPlaces = 2
        Me.el_mablgh.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.el_mablgh.Maximum = New Decimal(New Integer() {-1530494977, 232830, 0, 0})
        Me.el_mablgh.Name = "el_mablgh"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Name = "Label2"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        resources.ApplyResources(Me.NumericUpDown1, "NumericUpDown1")
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        '
        'descr
        '
        Me.descr.AcceptsReturn = True
        Me.descr.AllowDrop = True
        resources.ApplyResources(Me.descr, "descr")
        Me.descr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.descr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.descr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table_gpsBindingSource, "descr", True))
        Me.descr.Name = "descr"
        Me.descr.TabStop = False
        '
        'Table_gpsBindingSource
        '
        Me.Table_gpsBindingSource.DataMember = "table_gps"
        Me.Table_gpsBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.DarkOrange
        resources.ApplyResources(Me.BtnNewAdd, "BtnNewAdd")
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.Green
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Name = "Button3"
        Me.Button3.UseCompatibleTextRendering = True
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Gold
        resources.ApplyResources(Me.BtnDelete, "BtnDelete")
        Me.BtnDelete.ForeColor = System.Drawing.Color.Red
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        resources.ApplyResources(Me.BtnClose, "BtnClose")
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnClose.ForeColor = System.Drawing.Color.Red
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        resources.ApplyResources(Me.NumericUpDown2, "NumericUpDown2")
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.ReadOnly = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Name = "Label4"
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.DecimalPlaces = 2
        Me.NumericUpDown3.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        resources.ApplyResources(Me.NumericUpDown3, "NumericUpDown3")
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.ReadOnly = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Name = "Label5"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        resources.ApplyResources(Me.DateTimePicker1, "DateTimePicker1")
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Name = "DateTimePicker1"
        '
        'PictureBox1
        '
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Lime
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Name = "Label6"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Name = "Label7"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'id
        '
        resources.ApplyResources(Me.id, "id")
        Me.id.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.id.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        Me.id.Name = "id"
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnNewAdd)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.Button2)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.NumericUpDown3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.NumericUpDown2)
        Me.Panel2.Controls.Add(Me.Label5)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.no_file)
        Me.Panel3.Controls.Add(Me.id_desc)
        Me.Panel3.Controls.Add(Me.id_desclbl)
        Me.Panel3.Controls.Add(Me.no_shatb)
        Me.Panel3.Controls.Add(Me.no_shatblbl)
        Me.Panel3.Controls.Add(Me.no_filelbl)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.date1lbl)
        Me.Panel4.Controls.Add(Me.date1)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.el_mablgh)
        Me.Panel4.Controls.Add(Me.no_gp)
        Me.Panel4.Controls.Add(Me.no_gplbl)
        Me.Panel4.Controls.Add(Me.el_mablghlbl)
        Me.Panel4.Controls.Add(Me.descrlbl)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.descr)
        Me.Panel4.Controls.Add(Me.date_assthkk)
        Me.Panel4.Controls.Add(Me.date_assthkklbl)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'id_user
        '
        Me.id_user.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.id_user, "id_user")
        Me.id_user.Name = "id_user"
        '
        'Form_add_gp
        '
        Me.AcceptButton = Me.BtnNewAdd
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.id_user)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgv_gp_table)
        Me.Controls.Add(Me.idlbl)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Form_add_gp"
        CType(Me.dgv_gp_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.el_mablgh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table_gpsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgv_gp_table As System.Windows.Forms.DataGridView
    Public WithEvents idlbl As System.Windows.Forms.Label
    Public WithEvents date1 As System.Windows.Forms.DateTimePicker
    Public WithEvents date1lbl As System.Windows.Forms.Label
    Public WithEvents descrlbl As System.Windows.Forms.Label
    Public WithEvents no_file As System.Windows.Forms.TextBox
    Public WithEvents no_filelbl As System.Windows.Forms.Label
    Public WithEvents el_mablghlbl As System.Windows.Forms.Label
    Public WithEvents no_gp As System.Windows.Forms.TextBox
    Public WithEvents no_gplbl As System.Windows.Forms.Label
    Public WithEvents date_assthkk As System.Windows.Forms.DateTimePicker
    Public WithEvents date_assthkklbl As System.Windows.Forms.Label
    Public WithEvents no_shatb As System.Windows.Forms.TextBox
    Public WithEvents no_shatblbl As System.Windows.Forms.Label
    Public WithEvents id_desc As System.Windows.Forms.ComboBox
    Public WithEvents id_desclbl As System.Windows.Forms.Label
    Public WithEvents BtnNewAdd As System.Windows.Forms.Button
    Public WithEvents BtnSave As System.Windows.Forms.Button
    Public WithEvents BtnEdit As System.Windows.Forms.Button
    Public WithEvents BtnDelete As System.Windows.Forms.Button
    Public WithEvents BtnClose As System.Windows.Forms.Button
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents el_mablgh As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents descr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Button5 As System.Windows.Forms.Button
    Public WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Table_gpsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As gp_disk_pro.DataSet1
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents id As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Public WithEvents id_user As System.Windows.Forms.Label


End Class
