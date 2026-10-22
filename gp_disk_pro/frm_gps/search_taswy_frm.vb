Public Class search_taswy_frm

    Private Sub dgv_tabel_names_col_total_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_tabel_names_col_total.MouseClick
        add_taswy_frm.el_mablgh.Text = vbNullString
        add_taswy_frm.id_col.Text = dgv_tabel_names_col_total.CurrentRow.Cells(0).Value.ToString()
        add_taswy_frm.name_col_total.Text = dgv_tabel_names_col_total.CurrentRow.Cells(1).Value.ToString()
        '\\\\\\\\\\\
        el_mablgh.Text = vbNullString
        id_col.Text = dgv_tabel_names_col_total.CurrentRow.Cells(0).Value.ToString()
        name_col_total.Text = dgv_tabel_names_col_total.CurrentRow.Cells(1).Value.ToString()

        '====

        If dgv_tabel_names_col_total.CurrentRow.Cells(2).Value = 0 Then
            add_taswy_frm.el_mablgh.Text = vbNullString
        Else
            add_taswy_frm.el_mablgh.Text = dgv_tabel_names_col_total.CurrentRow.Cells(2).Value.ToString()
        End If
        '===============================================
        Dim no_row As Integer
        no_row = dgv_tabel_names_col_total.CurrentRow.Index
        If add_taswy_frm.DataGridView2.Rows(no_row).Cells(2).Value = 0 Then
            add_taswy_frm.el_mablgh.Text = vbNullString
        Else
            add_taswy_frm.el_mablgh.Text = add_taswy_frm.DataGridView2.Rows(no_row).Cells(2).Value
        End If

        add_taswy_frm.el_mablgh.Enabled = True
        'add_taswy_frm.el_mablgh.Focus()
        add_taswy_frm.el_mablgh.BackColor = Color.Gold
        '======
        el_mablgh.Enabled = True
        el_mablgh.Focus()
        el_mablgh.BackColor = Color.Gold

    End Sub

    Private Sub search_taswy_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SelectAll_tabel_names_col_search(dgv_tabel_names_col_total)
        SelectAll_tabel_names_col_total(dgv_tabel_names_col_total)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Try
            Dim dv As DataView = dt_tabel_names_col_total.DefaultView
            dv.RowFilter = " name_col_total LIKE '%" & TextBox2.Text & "%' "
            dv.RowFilter = " id_col =  " & Convert.ToInt32(TextBox2.Text) & " "

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Me.el_mablgh.Text = vbNullString Then
            Me.el_mablgh.Text = 0
        End If
        If add_taswy_frm.add_edite = "addd" And id_col.Text = vbNullString Then
            Dim elmblgh1 As Double
            elmblgh1 = Convert.ToDouble(el_mablgh.Text)
            Update_tabel_names_col_total(elmblgh1, id_col.Text)

            'SelectAll_tabel_names_col_total(DataGridView2)
            'run total
            '==========



            Me.el_mablgh.Text = 0

            SelectAll_tabel_names_col_total(add_taswy_frm.DataGridView2)
            add_taswy_frm.total_bndd()
        Else


            Dim no_row As Integer
            no_row = Convert.ToInt32(id_col.Text)

            add_taswy_frm.DataGridView2.Rows(no_row - 1).Cells(2).Value = Convert.ToDouble(el_mablgh.Text)

            'run total
            '==========
            add_taswy_frm.total_bndd()

            Me.el_mablgh.Text = vbNullString

            add_taswy_frm.DataGridView2.Rows(no_row - 1).Cells(2).Selected = True

        End If
    End Sub

    Private Sub el_mablgh_Leave(sender As Object, e As EventArgs) Handles el_mablgh.Leave
        Try

       
        If Me.el_mablgh.Text = vbNullString Then
            Me.el_mablgh.Text = 0
        End If
        If add_taswy_frm.add_edite = "addd" And id_col.Text <> "" Then
            Dim elmblgh1 As Double
            elmblgh1 = Convert.ToDouble(el_mablgh.Text)
                Update_tabel_names_col_total(elmblgh1, id_col.Text)

                SelectAll_tabel_names_col_total(add_taswy_frm.DataGridView2)
            'run total
            '==========



            Me.el_mablgh.Text = 0

                'SelectAll_tabel_names_col_total(add_taswy_frm.DataGridView2)
            add_taswy_frm.total_bndd()
        Else


            'Dim no_row As Integer
            'no_row = Convert.ToInt32(id_col.Text)

            'add_taswy_frm.DataGridView2.Rows(no_row - 1).Cells(2).Value = Convert.ToDouble(el_mablgh.Text)

            ''run total
            ''==========
            'add_taswy_frm.total_bndd()

            'Me.el_mablgh.Text = vbNullString

            'add_taswy_frm.DataGridView2.Rows(no_row - 1).Cells(2).Selected = True

        End If
            textbox_to_deciemal(el_mablgh)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            msg_lbl.Text = ex.Message.ToString()
        End Try
    End Sub


    Private Sub el_mablgh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles el_mablgh.KeyPress
        noused_char(e)
    End Sub


End Class