Public Class Form_password

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        If Me.Label1.Text = "الدخول الى صفحة صلاحيات المستخدم" And txt_pass.Text = "123" Then
            close_all()

            Form_Add_user.MdiParent = Form1

            Form_Add_user.Show()
            Me.Close()
        ElseIf Me.Label1.Text = "عرض كلمة السر" And txt_pass.Text = "1" Then
            Form_Add_user.user_pass.PasswordChar = ""
            Me.Close()
        Else

            MessageBox.Show("الرقم السرى خطا !")
        End If
        '==============================
     
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()
    End Sub
End Class