<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_all_gps
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
        Me.dgv_gp_table = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        'Me.CachedCrystalReport41 = New gp_disk_pro.CachedCrystalReport4()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgv_gp_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgv_gp_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_gp_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_gp_table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_gp_table.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgv_gp_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_gp_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_gp_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gp_table.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_gp_table.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_gp_table.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgv_gp_table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgv_gp_table.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv_gp_table.Location = New System.Drawing.Point(0, 163)
        Me.dgv_gp_table.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_gp_table.Name = "dgv_gp_table"
        Me.dgv_gp_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.dgv_gp_table.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_gp_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_gp_table.Size = New System.Drawing.Size(1244, 559)
        Me.dgv_gp_table.TabIndex = 19
        Me.dgv_gp_table.VirtualMode = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(1141, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "بحث"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(15, 66)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(1114, 30)
        Me.TextBox1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 35)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "بحث"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.AllowDrop = True
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(874, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeftLayout = True
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 30)
        Me.DateTimePicker1.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(810, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "الى"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.AllowDrop = True
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(535, 31)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(255, 30)
        Me.DateTimePicker2.TabIndex = 33
        '
        'Form_all_gps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1244, 722)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dgv_gp_table)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "Form_all_gps"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_all_gps"
        CType(Me.dgv_gp_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgv_gp_table As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Friend WithEvents CachedCrystalReport41 As gp_disk_pro.CachedCrystalReport4
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
