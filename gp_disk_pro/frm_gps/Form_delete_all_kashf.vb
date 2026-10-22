Public Class Form_delete_all_kashf

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            delete_all_tfrgh()
            Dim no_k As Integer
            no_k = Max_no_kshf()

            SelectSome_Table_mkf_add_indirect(no_kshf)
            SelectAll_Table_mkf_no_kshf(no_k)
            no_kshf.SelectedValue = no_k
            btn_deleted_one_kashf.Enabled = True
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        close_all()

    End Sub

    Private Sub btn_load_kshf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_load_kshf.Click
        Dim no_k As Integer
        no_k = Max_no_kshf()

        SelectSome_Table_mkf_add_indirect(no_kshf)
        SelectAll_Table_mkf_no_kshf(no_k)
        no_kshf.SelectedValue = no_k
        btn_deleted_one_kashf.Enabled = True
    End Sub

    Private Sub btn_deleted_one_kashf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deleted_one_kashf.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_one_kashf(no_kshf)
            Dim no_k As Integer
            no_k = Max_no_kshf()

            SelectSome_Table_mkf_add_indirect(no_kshf)
            SelectAll_Table_mkf_no_kshf(no_k)
            no_kshf.SelectedValue = no_k
        End If
    End Sub

  
End Class