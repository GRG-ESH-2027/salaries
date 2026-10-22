<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_password
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
        Me.Btn_close = New System.Windows.Forms.Button()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Button1.Location = New System.Drawing.Point(9, 106)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 41)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "تسجيل الدخول"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_close
        '
        Me.Btn_close.BackColor = System.Drawing.Color.White
        Me.Btn_close.ForeColor = System.Drawing.Color.DarkOrange
        Me.Btn_close.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Btn_close.Location = New System.Drawing.Point(289, 106)
        Me.Btn_close.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(180, 41)
        Me.Btn_close.TabIndex = 104
        Me.Btn_close.Text = "خروج"
        Me.Btn_close.UseVisualStyleBackColor = False
        '
        'txt_pass
        '
        Me.txt_pass.AcceptsReturn = True
        Me.txt_pass.Location = New System.Drawing.Point(195, 43)
        Me.txt_pass.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txt_pass.Size = New System.Drawing.Size(228, 33)
        Me.txt_pass.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Olive
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 27)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "الدخول الى صفحة صلاحيات المستخدم"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Olive
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 27)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "ادخال الرقم السرى"
        '
        'Form_password
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(568, 175)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form_password"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
