<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class select_drab_Form
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
        Me.btn_select = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rd_drab_15 = New System.Windows.Forms.RadioButton()
        Me.rd_drab_5 = New System.Windows.Forms.RadioButton()
        Me.rd_drab_10 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_select
        '
        Me.btn_select.BackColor = System.Drawing.Color.Orange
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.Location = New System.Drawing.Point(3, 32)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(86, 32)
        Me.btn_select.TabIndex = 100
        Me.btn_select.Text = "اختيار"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 29)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "اختيار نسبة الضريبه ؟"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.Label2.Location = New System.Drawing.Point(59, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(473, 29)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "======================="
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.rd_drab_15)
        Me.Panel1.Controls.Add(Me.rd_drab_5)
        Me.Panel1.Controls.Add(Me.rd_drab_10)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_select)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 82)
        Me.Panel1.TabIndex = 103
        '
        'rd_drab_15
        '
        Me.rd_drab_15.AutoSize = True
        Me.rd_drab_15.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_drab_15.ForeColor = System.Drawing.Color.White
        Me.rd_drab_15.Location = New System.Drawing.Point(120, 34)
        Me.rd_drab_15.Name = "rd_drab_15"
        Me.rd_drab_15.Size = New System.Drawing.Size(132, 27)
        Me.rd_drab_15.TabIndex = 104
        Me.rd_drab_15.TabStop = True
        Me.rd_drab_15.Text = "%15 ضرائب"
        Me.rd_drab_15.UseVisualStyleBackColor = True
        '
        'rd_drab_5
        '
        Me.rd_drab_5.AutoSize = True
        Me.rd_drab_5.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_drab_5.ForeColor = System.Drawing.Color.White
        Me.rd_drab_5.Location = New System.Drawing.Point(282, 37)
        Me.rd_drab_5.Name = "rd_drab_5"
        Me.rd_drab_5.Size = New System.Drawing.Size(120, 27)
        Me.rd_drab_5.TabIndex = 103
        Me.rd_drab_5.TabStop = True
        Me.rd_drab_5.Text = "%5 ضرائب"
        Me.rd_drab_5.UseVisualStyleBackColor = True
        '
        'rd_drab_10
        '
        Me.rd_drab_10.AutoSize = True
        Me.rd_drab_10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_drab_10.ForeColor = System.Drawing.Color.White
        Me.rd_drab_10.Location = New System.Drawing.Point(411, 37)
        Me.rd_drab_10.Name = "rd_drab_10"
        Me.rd_drab_10.Size = New System.Drawing.Size(132, 27)
        Me.rd_drab_10.TabIndex = 102
        Me.rd_drab_10.TabStop = True
        Me.rd_drab_10.Text = "%10 ضرائب"
        Me.rd_drab_10.UseVisualStyleBackColor = True
        '
        'select_drab_Form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(574, 132)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.MaximizeBox = False
        Me.Name = "select_drab_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "select_drab_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rd_drab_15 As System.Windows.Forms.RadioButton
    Friend WithEvents rd_drab_5 As System.Windows.Forms.RadioButton
    Friend WithEvents rd_drab_10 As System.Windows.Forms.RadioButton
End Class
