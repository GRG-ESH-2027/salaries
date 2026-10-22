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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_gp_table = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        CType(Me.dgv_gp_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_gp_table
        '
        Me.dgv_gp_table.AllowUserToAddRows = False
        Me.dgv_gp_table.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_gp_table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_gp_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_gp_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_gp_table.BackgroundColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_gp_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_gp_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gp_table.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgv_gp_table.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dgv_gp_table.Location = New System.Drawing.Point(28, 71)
        Me.dgv_gp_table.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_gp_table.MultiSelect = False
        Me.dgv_gp_table.Name = "dgv_gp_table"
        Me.dgv_gp_table.ReadOnly = True
        Me.dgv_gp_table.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv_gp_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_gp_table.Size = New System.Drawing.Size(1325, 668)
        Me.dgv_gp_table.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(304, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePicker1.TabIndex = 26
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(563, 22)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePicker2.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(817, 19)
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
        Me.BtnSave.Location = New System.Drawing.Point(56, 22)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(159, 36)
        Me.BtnSave.TabIndex = 29
        Me.BtnSave.Text = "تصدير الى اكسل"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Form_report_day
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1364, 750)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.dgv_gp_table)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_report_day"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_report_day"
        CType(Me.dgv_gp_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents dgv_gp_table As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents BtnSave As System.Windows.Forms.Button
End Class
