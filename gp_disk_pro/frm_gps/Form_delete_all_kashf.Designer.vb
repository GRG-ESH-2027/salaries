<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_delete_all_kashf
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.no_kshf = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_load_kshf = New System.Windows.Forms.Button()
        Me.btn_deleted_one_kashf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(729, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "حذف"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "صفحة حذف جميع الكشوف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(711, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "هل تريد حذف جميع الكشوف التى تم انشائه مع العلم لا يمكن استرجاعه"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(52, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 52)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "خروج"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'no_kshf
        '
        Me.no_kshf.FormattingEnabled = True
        Me.no_kshf.ItemHeight = 25
        Me.no_kshf.Location = New System.Drawing.Point(877, 54)
        Me.no_kshf.Name = "no_kshf"
        Me.no_kshf.Size = New System.Drawing.Size(84, 404)
        Me.no_kshf.TabIndex = 137
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(873, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 23)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "الكشوف المتاحة"
        '
        'btn_load_kshf
        '
        Me.btn_load_kshf.BackColor = System.Drawing.Color.Yellow
        Me.btn_load_kshf.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_load_kshf.Location = New System.Drawing.Point(623, 8)
        Me.btn_load_kshf.Name = "btn_load_kshf"
        Me.btn_load_kshf.Size = New System.Drawing.Size(244, 39)
        Me.btn_load_kshf.TabIndex = 139
        Me.btn_load_kshf.Text = "تحميل كشوف"
        Me.btn_load_kshf.UseVisualStyleBackColor = False
        '
        'btn_deleted_one_kashf
        '
        Me.btn_deleted_one_kashf.BackColor = System.Drawing.Color.Goldenrod
        Me.btn_deleted_one_kashf.Enabled = False
        Me.btn_deleted_one_kashf.Location = New System.Drawing.Point(623, 53)
        Me.btn_deleted_one_kashf.Name = "btn_deleted_one_kashf"
        Me.btn_deleted_one_kashf.Size = New System.Drawing.Size(244, 39)
        Me.btn_deleted_one_kashf.TabIndex = 140
        Me.btn_deleted_one_kashf.Text = "حذف كشف المحدد"
        Me.btn_deleted_one_kashf.UseVisualStyleBackColor = False
        '
        'Form_delete_all_kashf
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1041, 470)
        Me.Controls.Add(Me.btn_deleted_one_kashf)
        Me.Controls.Add(Me.btn_load_kshf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.no_kshf)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Red
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_delete_all_kashf"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "صفحة حذف جميع الكشوف"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents no_kshf As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_load_kshf As System.Windows.Forms.Button
    Friend WithEvents btn_deleted_one_kashf As System.Windows.Forms.Button
End Class
