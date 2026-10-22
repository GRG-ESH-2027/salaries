<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class view_frm_2
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet_ndb = New gp_disk_pro.DataSet_ndb()
        Me.nadbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.nadbTableAdapter = New gp_disk_pro.DataSet_ndbTableAdapters.nadbTableAdapter()
        CType(Me.DataSet_ndb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nadbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet_ndb"
        ReportDataSource1.Value = Me.nadbBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "gp_disk_pro.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 611)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet_ndb
        '
        Me.DataSet_ndb.DataSetName = "DataSet_ndb"
        Me.DataSet_ndb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nadbBindingSource
        '
        Me.nadbBindingSource.DataMember = "nadb"
        Me.nadbBindingSource.DataSource = Me.DataSet_ndb
        '
        'nadbTableAdapter
        '
        Me.nadbTableAdapter.ClearBeforeFill = True
        '
        'view_frm_2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(784, 611)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "view_frm_2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view_frm_2"
        CType(Me.DataSet_ndb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nadbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents nadbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_ndb As gp_disk_pro.DataSet_ndb
    Friend WithEvents nadbTableAdapter As gp_disk_pro.DataSet_ndbTableAdapters.nadbTableAdapter
End Class
