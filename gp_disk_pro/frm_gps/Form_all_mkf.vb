Imports System.Data.OleDb

Public Class Form_all_mkf
    Public frm_stat As String


    Public dt_Table_Mkf As New DataTable
    Public Sub SelectAll_Table_Mkf(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_Table_Mkf.Clear()
        da = New OleDbDataAdapter("select * from Table_Mkf", con)
        da.Fill(dt_Table_Mkf)
        dgv.DataSource = dt_Table_Mkf
    End Sub



    Private Sub Form_all_mkf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectAll_Table_Mkf(dgv_Table_Mkf)

    End Sub



    Private Sub dgv_Table_Mkf_CellMouseClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

        Try

            If frm_stat = "add" Then

                With dgv_Table_Mkf
                    Form_add_tfrgh.Id_Mkf_1.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                    Form_add_tfrgh.Name_Mkf.Text = .CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Form_add_tfrgh.Item_Mkf.Text = .CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Form_add_tfrgh.Years.Text = .CurrentRow.Cells("Years").Value.ToString()
                    Form_add_tfrgh.term.Text = .CurrentRow.Cells("term").Value.ToString()
                End With
            Else : frm_stat = "edit"


            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Close()
    End Sub


    Private Sub dgv_Table_Mkf_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_Table_Mkf.MouseClick

        Try

            If frm_stat = "add" Then

                With dgv_Table_Mkf
                    Form_add_tfrgh.Id_Mkf_1.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                    Form_add_tfrgh.Name_Mkf.Text = .CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Form_add_tfrgh.Item_Mkf.Text = .CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Form_add_tfrgh.Years.Text = .CurrentRow.Cells("Years").Value.ToString()
                    Form_add_tfrgh.term.Text = .CurrentRow.Cells("term").Value.ToString()
                End With
            Else : frm_stat = "edit"


            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Close()

    End Sub
End Class