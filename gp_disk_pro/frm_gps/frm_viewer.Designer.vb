<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_viewer
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
        Me.nadbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet_ndb = New gp_disk_pro.DataSet_ndb()
        Me.nadbTableAdapter = New gp_disk_pro.DataSet_ndbTableAdapters.nadbTableAdapter()
        CType(Me.nadbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_ndb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet_ndb"
        ReportDataSource1.Value = Me.nadbBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "gp_disk_pro.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(950, 611)
        Me.ReportViewer1.TabIndex = 0
        '
        'nadbBindingSource
        '
        Me.nadbBindingSource.DataMember = "nadb"
        Me.nadbBindingSource.DataSource = Me.DataSet_ndb
        '
        'DataSet_ndb
        '
        Me.DataSet_ndb.DataSetName = "DataSet_ndb"
        Me.DataSet_ndb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nadbTableAdapter
        '
        Me.nadbTableAdapter.ClearBeforeFill = True
        '
        'frm_viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 611)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_viewer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "view"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nadbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_ndb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents nadbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet_ndb As gp_disk_pro.DataSet_ndb
    Friend WithEvents nadbTableAdapter As gp_disk_pro.DataSet_ndbTableAdapters.nadbTableAdapter
    'Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
