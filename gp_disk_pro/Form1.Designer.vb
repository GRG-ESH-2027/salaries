<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ادخاليوميهجديدهToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تقريريوميهToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تقريريوميةصناديقToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ادخاليوميهجديدهToolStripMenuItem, Me.تقريريوميهToolStripMenuItem, Me.تقريريوميةصناديقToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1351, 33)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ادخاليوميهجديدهToolStripMenuItem
        '
        Me.ادخاليوميهجديدهToolStripMenuItem.Name = "ادخاليوميهجديدهToolStripMenuItem"
        Me.ادخاليوميهجديدهToolStripMenuItem.Size = New System.Drawing.Size(157, 29)
        Me.ادخاليوميهجديدهToolStripMenuItem.Text = "ادخال يوميه جديده"
        '
        'تقريريوميهToolStripMenuItem
        '
        Me.تقريريوميهToolStripMenuItem.Name = "تقريريوميهToolStripMenuItem"
        Me.تقريريوميهToolStripMenuItem.Size = New System.Drawing.Size(110, 29)
        Me.تقريريوميهToolStripMenuItem.Text = "تقرير يوميه"
        '
        'تقريريوميةصناديقToolStripMenuItem
        '
        Me.تقريريوميةصناديقToolStripMenuItem.Name = "تقريريوميةصناديقToolStripMenuItem"
        Me.تقريريوميةصناديقToolStripMenuItem.Size = New System.Drawing.Size(172, 29)
        Me.تقريريوميةصناديقToolStripMenuItem.Text = "تقرير يومية صناديق"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1351, 722)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ادخاليوميهجديدهToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تقريريوميهToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تقريريوميةصناديقToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
