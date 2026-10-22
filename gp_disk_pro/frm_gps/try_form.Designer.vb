<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class try_form
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
        Me.components = New System.ComponentModel.Container()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.ListBox44 = New System.Windows.Forms.ListBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.ListBox33 = New System.Windows.Forms.ListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New gp_disk_pro.DataSet1()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 25
        Me.ListBox1.Location = New System.Drawing.Point(148, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(101, 179)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.HorizontalScrollbar = True
        Me.ListBox2.ItemHeight = 25
        Me.ListBox2.Location = New System.Drawing.Point(79, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.ScrollAlwaysVisible = True
        Me.ListBox2.Size = New System.Drawing.Size(63, 179)
        Me.ListBox2.TabIndex = 1
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(771, 12)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 53)
        Me.button2.TabIndex = 7
        Me.button2.Text = "all"
        Me.button2.UseVisualStyleBackColor = True
        '
        'ListBox44
        '
        Me.ListBox44.FormattingEnabled = True
        Me.ListBox44.ItemHeight = 25
        Me.ListBox44.Location = New System.Drawing.Point(712, 67)
        Me.ListBox44.Name = "ListBox44"
        Me.ListBox44.Size = New System.Drawing.Size(53, 204)
        Me.ListBox44.TabIndex = 6
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(771, 81)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 34)
        Me.button1.TabIndex = 5
        Me.button1.Text = "<<"
        Me.button1.UseVisualStyleBackColor = True
        '
        'ListBox33
        '
        Me.ListBox33.FormattingEnabled = True
        Me.ListBox33.ItemHeight = 25
        Me.ListBox33.Items.AddRange(New Object() {"6", "5", "7", "2", "4"})
        Me.ListBox33.Location = New System.Drawing.Point(888, 81)
        Me.ListBox33.Name = "ListBox33"
        Me.ListBox33.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox33.Size = New System.Drawing.Size(64, 204)
        Me.ListBox33.TabIndex = 4
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(515, 60)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(99, 228)
        Me.CheckedListBox1.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 334)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(978, 156)
        Me.DataGridView1.TabIndex = 9
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(371, 290)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 38)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "عرض"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(573, 290)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(174, 34)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "تعديل"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'try_form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1035, 865)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.ListBox44)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.ListBox33)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "try_form"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "try_form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents ListBox44 As System.Windows.Forms.ListBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Public WithEvents ListBox33 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As gp_disk_pro.DataSet1
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
