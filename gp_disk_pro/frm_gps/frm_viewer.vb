'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Imports System.Data.OleDb

Public Class frm_viewer



    Private Sub view_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_ndb.nadb' table. You can move, or remove it, as needed.
        Me.nadbTableAdapter.Fill(Me.DataSet_ndb.nadb)
        'TODO: This line of code loads data into the 'DataSet_ndb.nadb' table. You can move, or remove it, as needed.

        'Try


        '    'Me.OleDbConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Swiss.mdb;Jet OLEDB:Database Password=261177;"

        '    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=" & (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb")

        '    Dim crtableLogoninfos As New TableLogOnInfos()

        '    Dim crtableLogoninfo As New TableLogOnInfo()
        '    Dim crConnectionInfo As New ConnectionInfo()
        '    Dim CrTables As Tables
        '    Dim CrTable As Table
        '    Dim reprt As New CrystalReport3
        '    With crConnectionInfo
        '        .DatabaseName = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) & "\gp_tafrgh_db.accdb"
        '        .Password = ""
        '    End With
        '    CrTables = reprt.Database.Tables
        '    For Each CrTable In CrTables
        '        crtableLogoninfo = CrTable.LogOnInfo
        '        crtableLogoninfo.ConnectionInfo = crConnectionInfo
        '        CrTable.ApplyLogOnInfo(crtableLogoninfo)
        '    Next
        '    CrystalReportViewer1.ReportSource = reprt
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'Me.nadbTableAdapter.Fill(Me.DataSet_ndb.nadb)
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class