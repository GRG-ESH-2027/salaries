Module Module_frm1
    Public Sub close_all()
        Form_add_gp.Close()
        Form_add_mkf.Close()
        Form_add_tfrgh.Close()
        Form_all_mkf.Close()

        Form_print_tfrgh.Close()
        Form_report_day.Close()
        Form_backup_data_base.Close()
        Form_all_gps.Close()
        frm_hlep.Close()
        Form_update_emp.Close()
        Form_print_crystal.Close()
        frm_viewer.Close()
        Form_report_gps.Close()
        Form_delete_all_kashf.Close()
        Form_enter_data_bnd.Close()
        Form_print_excell_all_total_bnd.Close()
        Form_print_crstal_total_bnd.Close()
        Form_edite_bnd_name.Close()
        Form_view_all_emp.Close()
        Form_update_emp2.Close()
        Form_pay.Close()
        'edit_form_tafrgh.Close()
        excel_add_form.Close()
        add_darab_frm.Close()
        drab_print_frm.Close()

    End Sub

    Public Sub close_all_forms(ByVal frm_name As Form)
        Dim isopen As Boolean
        For Each frm As Form In Application.OpenForms
       
            If frm.Text = frm_name.Text Then
                frm_name.Close()
                frm_name.Visible = False
                frm_name.Dispose()

                isopen = True

            End If

        Next
        'If isopen = True Then

        frm_name.Show()
        'End If

    End Sub




End Module
