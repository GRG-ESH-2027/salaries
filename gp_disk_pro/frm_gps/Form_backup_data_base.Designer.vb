<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_backup_data_base
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
        Me.copy = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.restorr = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'copy
        '
        Me.copy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.copy.BackColor = System.Drawing.Color.Blue
        Me.copy.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.copy.Image = Global.gp_disk_pro.My.Resources.Resources.accept
        Me.copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.copy.Location = New System.Drawing.Point(222, 133)
        Me.copy.Name = "copy"
        Me.copy.Size = New System.Drawing.Size(262, 49)
        Me.copy.TabIndex = 60
        Me.copy.Text = "نسخ قاعدة بيانات"
        Me.copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.copy.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(222, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(646, 36)
        Me.TextBox1.TabIndex = 63
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'restorr
        '
        Me.restorr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.restorr.BackColor = System.Drawing.Color.LimeGreen
        'Me.restorr.BackgroundImage = Global.gp_disk_pro.My.Resources.Resources.حفظ
        Me.restorr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.restorr.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restorr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.restorr.Location = New System.Drawing.Point(490, 134)
        Me.restorr.Name = "restorr"
        Me.restorr.Size = New System.Drawing.Size(378, 49)
        Me.restorr.TabIndex = 64
        Me.restorr.Text = "استرجاع قاعدة بيانات"
        Me.restorr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.restorr.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 29)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "صفحة نسخ احتياطى لقاعدة بيانات"
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(241, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(331, 40)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "نسخ قاعدة بيانات فى d:\"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(599, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 43)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "نسخ ملف اكسيل الى برنامج"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.ForeColor = System.Drawing.Color.Red
        'Me.BtnClose.Image = Global.gp_disk_pro.My.Resources.Resources.cancel
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.Location = New System.Drawing.Point(928, 147)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(68, 36)
        Me.BtnClose.TabIndex = 68
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Form_backup_data_base
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1123, 266)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.restorr)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.copy)
        Me.Name = "Form_backup_data_base"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "Form_backup_data_base"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents copy As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Public WithEvents restorr As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
