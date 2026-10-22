Public Class select_drab_Form

    Private Sub btn_select_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_select.Click
        If rd_drab_10.Checked = True Then
            Form_add_tfrgh.drab = 0.01
            edit_form_tafrgh.drab = 0.01
            Form_add_tfrgh.select_drab.Text = "ضرائب" + "%" + Convert.ToString(Form_add_tfrgh.drab)
            edit_form_tafrgh.select_drab.Text = "ضرائب" + "%" + Convert.ToString(edit_form_tafrgh.drab)
        ElseIf rd_drab_5.Checked = True Then
            Form_add_tfrgh.drab = 0.005
            edit_form_tafrgh.drab = 0.005
            Form_add_tfrgh.select_drab.Text = "ضرائب" + "%" + Convert.ToString(Form_add_tfrgh.drab)
            edit_form_tafrgh.select_drab.Text = "ضرائب" + "%" + Convert.ToString(edit_form_tafrgh.drab)
            Form_add_tfrgh.Darabb_1.Value = Math.Round((Form_add_tfrgh.Mkf_1.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
            edit_form_tafrgh.Darabb_val.Value = Math.Round((edit_form_tafrgh.Mkf_val.Value * 5) / 100, 1, MidpointRounding.AwayFromZero)
        ElseIf rd_drab_15.Checked = True Then
            Form_add_tfrgh.drab = 0.015
            edit_form_tafrgh.drab = 0.015
            Form_add_tfrgh.select_drab.Text = "ضرائب" + "%" + Convert.ToString(Form_add_tfrgh.drab)
            edit_form_tafrgh.select_drab.Text = "ضرائب" + "%" + Convert.ToString(edit_form_tafrgh.drab)
            Form_add_tfrgh.Darabb_1.Value = Math.Round((Form_add_tfrgh.Mkf_1.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)
            edit_form_tafrgh.Darabb_val.Value = Math.Round((edit_form_tafrgh.Mkf_val.Value * 15) / 100, 1, MidpointRounding.AwayFromZero)
        End If
        Form_add_tfrgh.total_day_cal()
        Form_add_tfrgh.total_mkf()
        Form_add_tfrgh.total_mostakt()

        Form_add_tfrgh.total_sffy()
        Form_add_tfrgh.total_sffy_after_Entkal()
        Form_add_tfrgh.total_day_cal()
        '====
        edit_form_tafrgh.total_day_cal()
        edit_form_tafrgh.total_mkf()
        edit_form_tafrgh.total_mostakt()

        edit_form_tafrgh.total_sffy()
        edit_form_tafrgh.total_sffy_after_Entkal()
        edit_form_tafrgh.total_day_cal()
        'Form_add_tfrgh.Button4_Click(sender, e)
        Me.Close()
    End Sub

End Class