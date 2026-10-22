<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_emp_Form
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
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmbx_name_pay = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.cmbx_alkta = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbx_no_emp = New System.Windows.Forms.ComboBox()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label27)
        Me.Panel8.Controls.Add(Me.cmbx_name_pay)
        Me.Panel8.Controls.Add(Me.Label28)
        Me.Panel8.Controls.Add(Me.cmbx_alkta)
        Me.Panel8.Controls.Add(Me.Label29)
        Me.Panel8.Controls.Add(Me.cmbx_no_emp)
        Me.Panel8.Location = New System.Drawing.Point(443, 735)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(204, 171)
        Me.Panel8.TabIndex = 115
        '
        'Label27
        '
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(794, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(133, 23)
        Me.Label27.TabIndex = 63
        Me.Label27.Text = "نوع المدفوعه"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbx_name_pay
        '
        Me.cmbx_name_pay.Enabled = False
        Me.cmbx_name_pay.FormattingEnabled = True
        Me.cmbx_name_pay.Location = New System.Drawing.Point(9, 118)
        Me.cmbx_name_pay.Name = "cmbx_name_pay"
        Me.cmbx_name_pay.Size = New System.Drawing.Size(86, 21)
        Me.cmbx_name_pay.TabIndex = 66
        '
        'Label28
        '
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(105, 79)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(98, 31)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "القطاع"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbx_alkta
        '
        Me.cmbx_alkta.Enabled = False
        Me.cmbx_alkta.FormattingEnabled = True
        Me.cmbx_alkta.Location = New System.Drawing.Point(3, 79)
        Me.cmbx_alkta.Name = "cmbx_alkta"
        Me.cmbx_alkta.Size = New System.Drawing.Size(98, 21)
        Me.cmbx_alkta.TabIndex = 67
        '
        'Label29
        '
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(101, 26)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(98, 23)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "رقم الموظف"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbx_no_emp
        '
        Me.cmbx_no_emp.Enabled = False
        Me.cmbx_no_emp.FormattingEnabled = True
        Me.cmbx_no_emp.Location = New System.Drawing.Point(6, 19)
        Me.cmbx_no_emp.Name = "cmbx_no_emp"
        Me.cmbx_no_emp.Size = New System.Drawing.Size(89, 21)
        Me.cmbx_no_emp.TabIndex = 68
        '
        'Add_emp_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1503, 908)
        Me.Controls.Add(Me.Panel8)
        Me.Name = "Add_emp_Form"
        Me.Text = "Add_emp_Form"
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents cmbx_name_pay As System.Windows.Forms.ComboBox
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents cmbx_alkta As System.Windows.Forms.ComboBox
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents cmbx_no_emp As System.Windows.Forms.ComboBox
End Class
