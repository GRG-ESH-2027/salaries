<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_select_text
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
        Me.no1 = New System.Windows.Forms.NumericUpDown()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.no1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(194, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "مسح"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'no1
        '
        Me.no1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.no1.DecimalPlaces = 2
        Me.no1.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.no1.Location = New System.Drawing.Point(3, 33)
        Me.no1.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.no1.Name = "no1"
        Me.no1.Size = New System.Drawing.Size(167, 27)
        Me.no1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(167, 27)
        Me.TextBox1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.Location = New System.Drawing.Point(194, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "تحديد"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.ForeColor = System.Drawing.Color.Lime
        Me.Button3.Location = New System.Drawing.Point(3, 69)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 29)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "نسخ"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Green
        Me.Button4.ForeColor = System.Drawing.Color.Lime
        Me.Button4.Location = New System.Drawing.Point(176, 31)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 29)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "لصق"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.no1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(12, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 100)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(12, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(297, 101)
        Me.Panel2.TabIndex = 8
        '
        'Form_select_text
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(311, 222)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Form_select_text"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_select_text"
        CType(Me.no1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents no1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
