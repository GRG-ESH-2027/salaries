<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_report_gps
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
        Me.date1lbl = New System.Windows.Forms.Label()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id_desc = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'date1lbl
        '
        Me.date1lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.date1lbl.ForeColor = System.Drawing.Color.White
        Me.date1lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.date1lbl.Location = New System.Drawing.Point(1183, 26)
        Me.date1lbl.Name = "date1lbl"
        Me.date1lbl.Size = New System.Drawing.Size(89, 23)
        Me.date1lbl.TabIndex = 11
        Me.date1lbl.Text = "تاريخ اليوم"
        Me.date1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'date1
        '
        Me.date1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.date1.CustomFormat = "yyyy/MM/dd"
        Me.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.date1.Location = New System.Drawing.Point(21, 12)
        Me.date1.Name = "date1"
        Me.date1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.date1.Size = New System.Drawing.Size(232, 30)
        Me.date1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Traditional Arabic", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(536, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 56)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "صفحة عرض تقرير يومى وسنوى"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(21, 47)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(232, 30)
        Me.DateTimePicker1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(259, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 27)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "من"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(259, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 27)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "الى"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'id_desc
        '
        Me.id_desc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.id_desc.Items.AddRange(New Object() {"عادى", "انشطه"})
        Me.id_desc.Location = New System.Drawing.Point(28, 5)
        Me.id_desc.Name = "id_desc"
        Me.id_desc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.id_desc.Size = New System.Drawing.Size(270, 31)
        Me.id_desc.TabIndex = 44
        Me.id_desc.Text = "عادى"
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(1082, 165)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(190, 27)
        Me.CheckBox1.TabIndex = 46
        Me.CheckBox1.Text = "اختيار نوع الشطب"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.id_desc)
        Me.Panel1.Location = New System.Drawing.Point(914, 199)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(358, 50)
        Me.Panel1.TabIndex = 47
        Me.Panel1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.date1)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(914, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(358, 91)
        Me.Panel2.TabIndex = 48
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(716, 68)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(159, 42)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "تقرير يومى"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Form_report_gps
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1284, 622)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.date1lbl)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form_report_gps"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "صفحة تقرير يوميه"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents date1lbl As System.Windows.Forms.Label
    Public WithEvents date1 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents id_desc As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Public WithEvents Button5 As System.Windows.Forms.Button
End Class
