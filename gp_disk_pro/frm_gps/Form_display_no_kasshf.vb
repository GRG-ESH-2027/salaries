Public Class Form_display_no_kasshf

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Close()
    End Sub

  
    Private Sub dgv_Table_add_tfrgh_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv_Table_add_tfrgh.RowPostPaint
        Me.dgv_Table_add_tfrgh.Rows(e.RowIndex).Cells("Column0").Value = (e.RowIndex + 1).ToString()
    End Sub
End Class