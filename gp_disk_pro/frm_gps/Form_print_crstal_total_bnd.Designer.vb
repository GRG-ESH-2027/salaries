<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_print_crstal_total_bnd
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Btn_tot_report = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btn_print2 = New System.Windows.Forms.Button()
        Me.btn_print3 = New System.Windows.Forms.Button()
        Me.btn_print4 = New System.Windows.Forms.Button()
        Me.btn_print5 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.Maroon
        Me.btn_print.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_print.Location = New System.Drawing.Point(513, 41)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(228, 38)
        Me.btn_print.TabIndex = 75
        Me.btn_print.Text = "طباعة الكشف الاول "
        Me.btn_print.UseVisualStyleBackColor = False
        Me.btn_print.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(391, 42)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(118, 30)
        Me.NumericUpDown1.TabIndex = 77
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(261, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "رقم الكشف"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1129, 9)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(237, 74)
        Me.DataGridView2.TabIndex = 82
        Me.DataGridView2.Visible = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Location = New System.Drawing.Point(1246, 89)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(120, 30)
        Me.NumericUpDown2.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(66, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 41)
        Me.Button1.TabIndex = 84
        Me.Button1.Text = "تحميل"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(310, 23)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "صفحة طباعة كشف اجمالى البنود"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(2)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Coral
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.MenuText
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.NullValue = Nothing
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(11, 252)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.CornflowerBlue
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1355, 369)
        Me.DataGridView1.TabIndex = 86
        Me.DataGridView1.VirtualMode = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(941, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 23)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "طباعة الميزان- اجماليات"
        '
        'Btn_tot_report
        '
        Me.Btn_tot_report.BackColor = System.Drawing.Color.Blue
        Me.Btn_tot_report.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        'Me.Btn_tot_report.Image = Global.gp_disk_pro.My.Resources.Resources.accept
        Me.Btn_tot_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_tot_report.Location = New System.Drawing.Point(1170, 205)
        Me.Btn_tot_report.Name = "Btn_tot_report"
        Me.Btn_tot_report.Size = New System.Drawing.Size(158, 38)
        Me.Btn_tot_report.TabIndex = 99
        Me.Btn_tot_report.Text = "عرض التقرير"
        Me.Btn_tot_report.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(353, 214)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(22, 23)
        Me.Label21.TabIndex = 101
        Me.Label21.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Green
        Me.Label20.Location = New System.Drawing.Point(296, 213)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label20.Size = New System.Drawing.Size(47, 24)
        Me.Label20.TabIndex = 100
        Me.Label20.Text = "عدد :"
        '
        'btn_print2
        '
        Me.btn_print2.BackColor = System.Drawing.Color.Maroon
        Me.btn_print2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_print2.Location = New System.Drawing.Point(513, 82)
        Me.btn_print2.Name = "btn_print2"
        Me.btn_print2.Size = New System.Drawing.Size(228, 38)
        Me.btn_print2.TabIndex = 102
        Me.btn_print2.Text = "طباعة الكشف الثانى "
        Me.btn_print2.UseVisualStyleBackColor = False
        Me.btn_print2.Visible = False
        '
        'btn_print3
        '
        Me.btn_print3.BackColor = System.Drawing.Color.Maroon
        Me.btn_print3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_print3.Location = New System.Drawing.Point(513, 117)
        Me.btn_print3.Name = "btn_print3"
        Me.btn_print3.Size = New System.Drawing.Size(228, 38)
        Me.btn_print3.TabIndex = 103
        Me.btn_print3.Text = "طباعة الكشف الثالث "
        Me.btn_print3.UseVisualStyleBackColor = False
        Me.btn_print3.Visible = False
        '
        'btn_print4
        '
        Me.btn_print4.BackColor = System.Drawing.Color.Maroon
        Me.btn_print4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_print4.Location = New System.Drawing.Point(513, 161)
        Me.btn_print4.Name = "btn_print4"
        Me.btn_print4.Size = New System.Drawing.Size(228, 38)
        Me.btn_print4.TabIndex = 104
        Me.btn_print4.Text = "طباعة الكشف الرابع "
        Me.btn_print4.UseVisualStyleBackColor = False
        Me.btn_print4.Visible = False
        '
        'btn_print5
        '
        Me.btn_print5.BackColor = System.Drawing.Color.Maroon
        Me.btn_print5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_print5.Location = New System.Drawing.Point(513, 206)
        Me.btn_print5.Name = "btn_print5"
        Me.btn_print5.Size = New System.Drawing.Size(228, 38)
        Me.btn_print5.TabIndex = 105
        Me.btn_print5.Text = "طباعة الكشف الخامس "
        Me.btn_print5.UseVisualStyleBackColor = False
        Me.btn_print5.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormatString = "0"
        Me.ListBox1.ItemHeight = 23
        Me.ListBox1.Items.AddRange(New Object() {"4"})
        Me.ListBox1.Location = New System.Drawing.Point(171, 41)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(83, 188)
        Me.ListBox1.TabIndex = 106
        '
        'Form_print_crstal_total_bnd
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 644)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_print5)
        Me.Controls.Add(Me.btn_print4)
        Me.Controls.Add(Me.btn_print3)
        Me.Controls.Add(Me.btn_print2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Btn_tot_report)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btn_print)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_print_crstal_total_bnd"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "Form_print_crystal"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Btn_tot_report As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btn_print2 As System.Windows.Forms.Button
    Friend WithEvents btn_print3 As System.Windows.Forms.Button
    Friend WithEvents btn_print4 As System.Windows.Forms.Button
    Friend WithEvents btn_print5 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
