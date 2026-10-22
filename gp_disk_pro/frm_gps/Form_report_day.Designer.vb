<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_report_day
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_gp_table = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv_gp_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_gp_table
        '
        Me.dgv_gp_table.AllowUserToAddRows = False
        Me.dgv_gp_table.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_gp_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_gp_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_gp_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_gp_table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_gp_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_gp_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gp_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_gp_table.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv_gp_table.Location = New System.Drawing.Point(22, 155)
        Me.dgv_gp_table.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_gp_table.MultiSelect = False
        Me.dgv_gp_table.Name = "dgv_gp_table"
        Me.dgv_gp_table.ReadOnly = True
        Me.dgv_gp_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv_gp_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_gp_table.Size = New System.Drawing.Size(465, 472)
        Me.dgv_gp_table.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(444, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 30)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(724, 70)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(277, 30)
        Me.DateTimePicker2.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1007, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 35)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "بحث"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSave.Location = New System.Drawing.Point(1160, 65)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(159, 36)
        Me.BtnSave.TabIndex = 29
        Me.BtnSave.Text = "تصدير الى اكسل"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(557, 155)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(564, 472)
        Me.DataGridView1.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(702, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Label1"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(724, 120)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumericUpDown1.Size = New System.Drawing.Size(247, 30)
        Me.NumericUpDown1.TabIndex = 33
        Me.NumericUpDown1.ThousandsSeparator = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(574, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 32)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "جمله شهور"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.NumericUpDown2.DecimalPlaces = 2
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NumericUpDown2.Location = New System.Drawing.Point(240, 115)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {-159383553, 46653770, 5421, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NumericUpDown2.Size = New System.Drawing.Size(247, 30)
        Me.NumericUpDown2.TabIndex = 34
        Me.NumericUpDown2.ThousandsSeparator = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 35)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "عرض التقرير"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(31, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 32)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "جملة يوم (عادي)"
        '
        'Form_report_day
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1344, 728)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dgv_gp_table)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_report_day"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "جملة اليوم"
        CType(Me.dgv_gp_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgv_gp_table As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents BtnSave As System.Windows.Forms.Button
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
