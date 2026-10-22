<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search_taswy_frm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.msg_lbl = New System.Windows.Forms.Label()
        Me.el_mablgh = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.id_col = New System.Windows.Forms.TextBox()
        Me.name_col_total = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgv_tabel_names_col_total = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_tabel_names_col_total, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.DarkMagenta
        Me.Panel1.Controls.Add(Me.msg_lbl)
        Me.Panel1.Controls.Add(Me.el_mablgh)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.id_col)
        Me.Panel1.Controls.Add(Me.name_col_total)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dgv_tabel_names_col_total)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(9, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 1037)
        Me.Panel1.TabIndex = 66
        '
        'msg_lbl
        '
        Me.msg_lbl.AutoSize = True
        Me.msg_lbl.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg_lbl.ForeColor = System.Drawing.Color.Red
        Me.msg_lbl.Location = New System.Drawing.Point(258, 6)
        Me.msg_lbl.Name = "msg_lbl"
        Me.msg_lbl.Size = New System.Drawing.Size(22, 24)
        Me.msg_lbl.TabIndex = 103
        Me.msg_lbl.Text = "0"
        '
        'el_mablgh
        '
        Me.el_mablgh.Location = New System.Drawing.Point(201, 73)
        Me.el_mablgh.Name = "el_mablgh"
        Me.el_mablgh.Size = New System.Drawing.Size(306, 29)
        Me.el_mablgh.TabIndex = 102
        Me.el_mablgh.Text = "0"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(17, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 32)
        Me.Button2.TabIndex = 101
        Me.Button2.Text = "بحث"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(521, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 26)
        Me.Label10.TabIndex = 100
        Me.Label10.Text = "المبلغ :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(513, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 22)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "رقم البند :"
        '
        'id_col
        '
        Me.id_col.Location = New System.Drawing.Point(389, 6)
        Me.id_col.Name = "id_col"
        Me.id_col.ReadOnly = True
        Me.id_col.Size = New System.Drawing.Size(118, 29)
        Me.id_col.TabIndex = 97
        '
        'name_col_total
        '
        Me.name_col_total.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_col_total.ForeColor = System.Drawing.Color.Green
        Me.name_col_total.Location = New System.Drawing.Point(141, 41)
        Me.name_col_total.Name = "name_col_total"
        Me.name_col_total.ReadOnly = True
        Me.name_col_total.Size = New System.Drawing.Size(366, 26)
        Me.name_col_total.TabIndex = 99
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(513, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 26)
        Me.Label9.TabIndex = 98
        Me.Label9.Text = "اسم البند :"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Green
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(17, 35)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 32)
        Me.Button8.TabIndex = 63
        Me.Button8.Text = "f2 اضافة"
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(487, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 24)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "بحث عن بند :"
        '
        'dgv_tabel_names_col_total
        '
        Me.dgv_tabel_names_col_total.AllowUserToAddRows = False
        Me.dgv_tabel_names_col_total.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_tabel_names_col_total.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_tabel_names_col_total.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_tabel_names_col_total.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_tabel_names_col_total.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_tabel_names_col_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tabel_names_col_total.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_tabel_names_col_total.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabel_names_col_total.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv_tabel_names_col_total.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_tabel_names_col_total.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_tabel_names_col_total.GridColor = System.Drawing.SystemColors.ControlText
        Me.dgv_tabel_names_col_total.Location = New System.Drawing.Point(17, 154)
        Me.dgv_tabel_names_col_total.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_tabel_names_col_total.MultiSelect = False
        Me.dgv_tabel_names_col_total.Name = "dgv_tabel_names_col_total"
        Me.dgv_tabel_names_col_total.ReadOnly = True
        Me.dgv_tabel_names_col_total.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_tabel_names_col_total.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgv_tabel_names_col_total.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_tabel_names_col_total.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_tabel_names_col_total.Size = New System.Drawing.Size(585, 853)
        Me.dgv_tabel_names_col_total.TabIndex = 61
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_col"
        Me.Column1.FillWeight = 50.76143!
        Me.Column1.HeaderText = "رقم بند"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "name_col_total"
        Me.Column2.FillWeight = 149.2386!
        Me.Column2.HeaderText = "اسم البند"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "el_mblgh"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "المبلغ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(106, 117)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(375, 29)
        Me.TextBox2.TabIndex = 11
        '
        'search_taswy_frm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(642, 1061)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "search_taswy_frm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "search_taswy_frm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_tabel_names_col_total, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents dgv_tabel_names_col_total As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents el_mablgh As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents id_col As System.Windows.Forms.TextBox
    Friend WithEvents name_col_total As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents msg_lbl As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
