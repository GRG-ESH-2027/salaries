<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_add_mkf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_add_mkf))
        Me.Id_Mkflbl = New System.Windows.Forms.Label()
        Me.Id_Mkf = New System.Windows.Forms.Label()
        Me.Name_Mkflbl = New System.Windows.Forms.Label()
        Me.Name_Mkf = New System.Windows.Forms.TextBox()
        Me.Item_Mkflbl = New System.Windows.Forms.Label()
        Me.Yearslbl = New System.Windows.Forms.Label()
        Me.Years = New System.Windows.Forms.TextBox()
        Me.termlbl = New System.Windows.Forms.Label()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.dgv_Table_Mkf = New System.Windows.Forms.DataGridView()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Item_Mkf = New System.Windows.Forms.ComboBox()
        Me.term = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.dgv_Table_Mkf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_Mkflbl
        '
        Me.Id_Mkflbl.ForeColor = System.Drawing.Color.White
        Me.Id_Mkflbl.Location = New System.Drawing.Point(17, 9)
        Me.Id_Mkflbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Id_Mkflbl.Name = "Id_Mkflbl"
        Me.Id_Mkflbl.Size = New System.Drawing.Size(116, 29)
        Me.Id_Mkflbl.TabIndex = 0
        Me.Id_Mkflbl.Text = "Id_Mkf"
        Me.Id_Mkflbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Id_Mkf
        '
        Me.Id_Mkf.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_Mkf.ForeColor = System.Drawing.Color.Red
        Me.Id_Mkf.Location = New System.Drawing.Point(155, 9)
        Me.Id_Mkf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Id_Mkf.Name = "Id_Mkf"
        Me.Id_Mkf.Size = New System.Drawing.Size(246, 29)
        Me.Id_Mkf.TabIndex = 1
        '
        'Name_Mkflbl
        '
        Me.Name_Mkflbl.ForeColor = System.Drawing.Color.White
        Me.Name_Mkflbl.Location = New System.Drawing.Point(31, 63)
        Me.Name_Mkflbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Name_Mkflbl.Name = "Name_Mkflbl"
        Me.Name_Mkflbl.Size = New System.Drawing.Size(116, 29)
        Me.Name_Mkflbl.TabIndex = 2
        Me.Name_Mkflbl.Text = "اسم المكافاة"
        Me.Name_Mkflbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name_Mkf
        '
        Me.Name_Mkf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Name_Mkf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.Name_Mkf.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Name_Mkf.Enabled = False
        Me.Name_Mkf.Location = New System.Drawing.Point(155, 62)
        Me.Name_Mkf.Margin = New System.Windows.Forms.Padding(4)
        Me.Name_Mkf.Name = "Name_Mkf"
        Me.Name_Mkf.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Name_Mkf.Size = New System.Drawing.Size(246, 32)
        Me.Name_Mkf.TabIndex = 3
        '
        'Item_Mkflbl
        '
        Me.Item_Mkflbl.ForeColor = System.Drawing.Color.White
        Me.Item_Mkflbl.Location = New System.Drawing.Point(31, 106)
        Me.Item_Mkflbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Item_Mkflbl.Name = "Item_Mkflbl"
        Me.Item_Mkflbl.Size = New System.Drawing.Size(116, 29)
        Me.Item_Mkflbl.TabIndex = 4
        Me.Item_Mkflbl.Text = "نوع المكافاة"
        Me.Item_Mkflbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Yearslbl
        '
        Me.Yearslbl.ForeColor = System.Drawing.Color.White
        Me.Yearslbl.Location = New System.Drawing.Point(31, 161)
        Me.Yearslbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Yearslbl.Name = "Yearslbl"
        Me.Yearslbl.Size = New System.Drawing.Size(116, 29)
        Me.Yearslbl.TabIndex = 6
        Me.Yearslbl.Text = "العام"
        Me.Yearslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Years
        '
        Me.Years.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Years.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.Years.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Years.Enabled = False
        Me.Years.Location = New System.Drawing.Point(156, 158)
        Me.Years.Margin = New System.Windows.Forms.Padding(4)
        Me.Years.Name = "Years"
        Me.Years.Size = New System.Drawing.Size(113, 32)
        Me.Years.TabIndex = 7
        '
        'termlbl
        '
        Me.termlbl.ForeColor = System.Drawing.Color.White
        Me.termlbl.Location = New System.Drawing.Point(31, 217)
        Me.termlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.termlbl.Name = "termlbl"
        Me.termlbl.Size = New System.Drawing.Size(116, 29)
        Me.termlbl.TabIndex = 8
        Me.termlbl.Text = "الدور"
        Me.termlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.Green
        Me.BtnNewAdd.Enabled = False
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.White
        Me.BtnNewAdd.Location = New System.Drawing.Point(155, 263)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(89, 45)
        Me.BtnNewAdd.TabIndex = 11
        Me.BtnNewAdd.Text = "اضافه"
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'dgv_Table_Mkf
        '
        Me.dgv_Table_Mkf.AllowUserToAddRows = False
        Me.dgv_Table_Mkf.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        Me.dgv_Table_Mkf.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Table_Mkf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_Table_Mkf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Table_Mkf.BackgroundColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Table_Mkf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Table_Mkf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Table_Mkf.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Table_Mkf.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Table_Mkf.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv_Table_Mkf.Location = New System.Drawing.Point(446, 9)
        Me.dgv_Table_Mkf.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_Table_Mkf.MultiSelect = False
        Me.dgv_Table_Mkf.Name = "dgv_Table_Mkf"
        Me.dgv_Table_Mkf.ReadOnly = True
        Me.dgv_Table_Mkf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Table_Mkf.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Table_Mkf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Table_Mkf.Size = New System.Drawing.Size(544, 327)
        Me.dgv_Table_Mkf.TabIndex = 25
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnClose.ForeColor = System.Drawing.Color.Red
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.Location = New System.Drawing.Point(279, 263)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(97, 45)
        Me.BtnClose.TabIndex = 60
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Item_Mkf
        '
        Me.Item_Mkf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.Item_Mkf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Item_Mkf.Enabled = False
        Me.Item_Mkf.FormattingEnabled = True
        Me.Item_Mkf.Items.AddRange(New Object() {"ملاحظه", "تصحيح"})
        Me.Item_Mkf.Location = New System.Drawing.Point(156, 103)
        Me.Item_Mkf.Name = "Item_Mkf"
        Me.Item_Mkf.Size = New System.Drawing.Size(246, 32)
        Me.Item_Mkf.TabIndex = 61
        Me.Item_Mkf.Tag = ""
        '
        'term
        '
        Me.term.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.term.Enabled = False
        Me.term.FormattingEnabled = True
        Me.term.Items.AddRange(New Object() {"الاول", "الثانى"})
        Me.term.Location = New System.Drawing.Point(155, 217)
        Me.term.Name = "term"
        Me.term.Size = New System.Drawing.Size(114, 32)
        Me.term.TabIndex = 62
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1001, 366)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnSave.ForeColor = System.Drawing.Color.Red
        Me.BtnSave.Location = New System.Drawing.Point(13, 263)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(102, 45)
        Me.BtnSave.TabIndex = 65
        Me.BtnSave.Text = "جديد"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Form_add_mkf
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1001, 366)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.term)
        Me.Controls.Add(Me.Item_Mkf)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.dgv_Table_Mkf)
        Me.Controls.Add(Me.Id_Mkflbl)
        Me.Controls.Add(Me.Id_Mkf)
        Me.Controls.Add(Me.Name_Mkflbl)
        Me.Controls.Add(Me.Name_Mkf)
        Me.Controls.Add(Me.Item_Mkflbl)
        Me.Controls.Add(Me.Yearslbl)
        Me.Controls.Add(Me.Years)
        Me.Controls.Add(Me.termlbl)
        Me.Controls.Add(Me.BtnNewAdd)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form_add_mkf"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة مكافاة"
        CType(Me.dgv_Table_Mkf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgv_Table_Mkf As System.Windows.Forms.DataGridView
    Public WithEvents Id_Mkf As System.Windows.Forms.Label
    Public WithEvents Id_Mkflbl As System.Windows.Forms.Label
    Public WithEvents Name_Mkf As System.Windows.Forms.TextBox
    Public WithEvents Name_Mkflbl As System.Windows.Forms.Label
    Public WithEvents Item_Mkflbl As System.Windows.Forms.Label
    Public WithEvents Years As System.Windows.Forms.TextBox
    Public WithEvents Yearslbl As System.Windows.Forms.Label
    Public WithEvents termlbl As System.Windows.Forms.Label
    Public WithEvents BtnNewAdd As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Item_Mkf As System.Windows.Forms.ComboBox
    Friend WithEvents term As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Public WithEvents BtnSave As System.Windows.Forms.Button


End Class
