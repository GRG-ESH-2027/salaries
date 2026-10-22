Public Class Form_Add_user

    Private Sub Btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearControls()
        id_user.Text = Max_user_table() + 1
        BtnNewAdd.Enabled = True

    End Sub

    Private Sub Form_Add_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectAll_user_table(dgv_user_table)
        ClearControls()
        id_user.Text = Max_user_table() + 1
        fillcmb_user_table(user_mange)
        user_mange.SelectedIndex = 0
        dgv_user_table.Columns(2).Visible = False
    End Sub

    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.Click
        Try
            If user_name.Text.Trim() = "" Or user_pass.Text.Trim() = "" Or user_ful_name.Text.Trim() = "" Or user_mange.Text.Trim() = "" Then
                MessageBox.Show("برجاء التاكد من ملا البيانات بطريقه صحيحه")
            ElseIf user_pass.Text <> TextBox1.Text Then
                MessageBox.Show("برجاء التاكد من مطابقة الرقم السرى")
            Else
                Insert_user_table(id_user.Text, user_name.Text, user_pass.Text, user_ful_name.Text, user_mange.Text)

                SelectAll_user_table(dgv_user_table)
                ClearControls()
                id_user.Text = Max_user_table() + 1
                'fillcmb_user_table(user_mange)
                user_mange.SelectedIndex = 0

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
  

        'dgv_user_table.Rows.Cells(0).Value. = "*"

    End Sub

    Private Sub dgv_user_table_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_user_table.Click
        Try
            With dgv_user_table
                Me.id_user.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.user_name.Text = .CurrentRow.Cells(1).Value.ToString()
                Me.user_pass.Text = .CurrentRow.Cells(2).Value.ToString()
                Me.user_ful_name.Text = .CurrentRow.Cells(3).Value.ToString()
                Me.user_mange.Text = .CurrentRow.Cells(4).Value.ToString()

            End With
            user_pass.PasswordChar = "*"
            BtnDelete.Enabled = True
            BtnNewAdd.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_user_table(dgv_user_table)
            SelectAll_user_table(dgv_user_table)
            ClearControls()
            id_user.Text = Max_user_table() + 1
        End If

    End Sub


    
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form_password.Label1.Text = "عرض كلمة السر"
        Form_password.txt_pass.Text = ""
        Form_password.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox3.Text = DateAndTime.Now.ToString("hh:mm.ss  tt    ")
    End Sub
End Class