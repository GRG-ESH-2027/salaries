Public Class add_emp_frm

    Public check_lenth_string As Boolean
    Public Sub ClearControls()
        Me.id_no_txt.Text = vbNullString
        Me.school.Text = vbNullString
        Me.no_emb.Text = vbNullString
        Me.name_emp.Text = vbNullString
        id_no_txt.Focus()
    End Sub
    '#====================
    Public Sub check_txt()
        If Me.id_no_txt.Text.Length > 14 Then
            MessageBox.Show("يجب التاكد من الرقم القومى")
            check_lenth_string = True
            id_no_txt.Focus()
        ElseIf dt_Select_emp.Rows.Count > 0 Then
            MessageBox.Show("الرقم القومى مسجل من قبل")
        ElseIf Me.id_no_txt.Text.Length < 14 Then
            MessageBox.Show("يجب التاكد من الرقم القومى")
        Else
            check_lenth_string = False

        End If


    End Sub
    '===============





    Private Sub id_no_txt_Leave(sender As Object, e As EventArgs) Handles id_no_txt.Leave
        Select_emp(id_no_txt.Text)
        check_txt()
    End Sub

  

    Private Sub hh_Click(sender As Object, e As EventArgs) Handles hh.Click

    End Sub


    Private Sub BtnNewAdd_Click_1(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        check_txt()
        If check_lenth_string = True Then
            MessageBox.Show("يجب التاكد من الرقم القومى")
        ElseIf Me.id_no_txt.Text = vbNullString Then
            MessageBox.Show("يجب التاكد من الرقم القومى")
        ElseIf Me.name_emp.Text = vbNullString Then
            MessageBox.Show("يجب ادخال اسم الموظف ")
        Else
            Insert_emp(id_no_txt.Text, name_paylbl.Text, al_ktalbl.Text, school.Text, no_emb.Text, name_emp.Text, hh.Text)
            MessageBox.Show("تم الاضافة بنجاح ")
            ClearControls()
            SelectAll_emp(dgv_emp)


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'TODO: This line of code loads data into the 'Gp_tafrgh_dbDataSet3.emp' table. You can move, or remove it, as needed.
        Me.EmpTableAdapter1.Fill(Me.Gp_tafrgh_dbDataSet3.emp)
     
        SelectAll_emp(dgv_emp)
  

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
   
        Try
            Dim dv As DataView = dt_all_emp.DefaultView
            If txt_name.TextLength > 0 Then
                dv.RowFilter = " Name_Emp LIKE '%" & txt_name.Text & "%' "
            ElseIf txt_id.TextLength > 0 Then
                dv.RowFilter = " id_no LIKE '%" & txt_id.Text & "%' "
            ElseIf txt_id.TextLength > 0 And txt_name.TextLength > 0 Then
                MessageBox.Show("يجيب اختيار طريقة واحده للبحث")

            End If



        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgv_emp_Click(sender As Object, e As EventArgs) Handles dgv_emp.Click
        Try
            With dgv_emp
                Me.id_no_txt.Text = .CurrentRow.Cells("IdnoDataGridViewTextBoxColumn").Value.ToString()
                Me.school.Text = .CurrentRow.Cells("SchoolDataGridViewTextBoxColumn").Value.ToString()
                Me.no_emb.Text = .CurrentRow.Cells("NoembDataGridViewTextBoxColumn").Value.ToString()
                Me.name_emp.Text = .CurrentRow.Cells("NameempDataGridViewTextBoxColumn").Value.ToString()

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub add_emp_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class