
Public Class Form_add_mkf
    Public nam_form As String = ""
    Private Sub Form_add_mkf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SelectAll_Table_Mkf(dgv_Table_Mkf)
        DataGridViewHeaderTxt(dgv_Table_Mkf)
        Id_Mkf.Text = Max_Table_Mkf() + 1

        'جعل كومبوبكس على اول اختيار
        Item_Mkf.SelectedIndex = 0
        term.SelectedIndex = 0


    End Sub

    Public Sub ClearControls()
        'Me.Id_Mkf.Text = vbNullString
        Me.Name_Mkf.Text = vbNullString

        Me.Years.Text = vbNullString

        Name_Mkf.Enabled = True
        Item_Mkf.Enabled = True
        Years.Enabled = True
        term.Enabled = True
    End Sub

    Private Sub BtnNewAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewAdd.Click
        'Try
        '    'Insert_Table_Mkf(Name_Mkf.Text, Item_Mkf.Text, Years.Text, term.Text)
        '    Update_Table_Mkf(Id_Mkf.Text, Name_Mkf.Text, Me.Item_Mkf.Text, Years.Text, Me.term.Text)

        '    SelectAll_Table_Mkf(dgv_Table_Mkf)
        '    Id_Mkf.Text = Max_Table_Mkf() + 1
        '    ClearControls()
        'Catch ex As Exception
        '    MessageBox.Show("ex As Exception")
        'End Try
        Try
            Insert_Table_Mkf(Name_Mkf.Text, Item_Mkf.Text, Years.Text, term.Text)
            SelectAll_Table_Mkf(dgv_Table_Mkf)
            Id_Mkf.Text = Max_Table_Mkf() + 1
            ClearControls()
        Catch ex As Exception
            MessageBox.Show("ex As Exception")
        End Try

    End Sub



    Private Sub BtnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click



        Close()
    End Sub

    Private Sub Name_Mkf_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Name_Mkf.MouseClick
        Name_Mkf.BackColor = Color.Gold
    End Sub

    Private Sub Years_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Years.MouseClick
        Years.BackColor = Color.Gold
    End Sub

    Private Sub Item_Mkf_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Item_Mkf.MouseClick
        Item_Mkf.BackColor = Color.Gold
    End Sub


    Private Sub Name_Mkf_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_Mkf.Leave
        Name_Mkf.BackColor = Color.White
    End Sub


    Private Sub Item_Mkf_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Item_Mkf.Leave
        Item_Mkf.BackColor = Color.White
    End Sub

    Private Sub Years_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Years.Leave
        Years.BackColor = Color.White
    End Sub

    Private Sub dgv_Table_Mkf_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgv_Table_Mkf.MouseClick

        Try
            ' تعريف المتغير مع قيمة أولية فارغة
            Dim nam_form As String = String.Empty

            ' البحث عن الفورم المفتوح
            For Each frm As Form In Application.OpenForms.OfType(Of Form)()
                If frm.IsMdiChild Then
                    nam_form = frm.GetType().Name
                    Exit For   ' الخروج من الحلقة بعد العثور على الفورم
                End If
            Next

            '===========================

            With dgv_Table_Mkf
                If String.IsNullOrEmpty(nam_form) Then
                    MessageBox.Show("لم يتم تحديد قيمة لـ nam_form")
                ElseIf nam_form = "Form_add_tfrgh" Then
                    Form_add_tfrgh.Id_Mkf_1.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                    Form_add_tfrgh.Name_Mkf.Text = .CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Form_add_tfrgh.Item_Mkf.Text = .CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Form_add_tfrgh.Years.Text = .CurrentRow.Cells("Years").Value.ToString()
                    Form_add_tfrgh.term.Text = .CurrentRow.Cells("term").Value.ToString()

                ElseIf nam_form = "edit_form_tafrgh" Then
                    edit_form_tafrgh.Name_Mkf.Text = .CurrentRow.Cells("Name_Mkf").Value.ToString()
                    edit_form_tafrgh.Item_Mkf_val.Text = .CurrentRow.Cells("Item_Mkf").Value.ToString()
                    edit_form_tafrgh.Years.Text = .CurrentRow.Cells("Years").Value.ToString()
                    edit_form_tafrgh.term.Text = .CurrentRow.Cells("term").Value.ToString()
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        ClearControls()
        BtnNewAdd.Enabled = True
        Id_Mkf.Text = Max_Table_Mkf() + 1
    End Sub

    Private Sub dgv_Table_Mkf_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Table_Mkf.CellContentClick

        Try
            ' تعريف المتغير مع قيمة أولية فارغة
            Dim nam_form As String = String.Empty

            ' البحث عن الفورم المفتوح
            For Each frm As Form In Application.OpenForms.OfType(Of Form)()
                If frm.IsMdiChild Then
                    nam_form = frm.GetType().Name
                    Exit For   ' الخروج من الحلقة بعد العثور على الفورم
                End If
            Next

            '===========================

            With dgv_Table_Mkf
                If String.IsNullOrEmpty(nam_form) Then
                    MessageBox.Show("لم يتم تحديد قيمة لـ nam_form")
                ElseIf nam_form = "Form_add_tfrgh" Then
                    Form_add_tfrgh.Id_Mkf_1.Text = .CurrentRow.Cells("Id_Mkf").Value.ToString()
                    Form_add_tfrgh.Name_Mkf.Text = .CurrentRow.Cells("Name_Mkf").Value.ToString()
                    Form_add_tfrgh.Item_Mkf.Text = .CurrentRow.Cells("Item_Mkf").Value.ToString()
                    Form_add_tfrgh.Years.Text = .CurrentRow.Cells("Years").Value.ToString()
                    Form_add_tfrgh.term.Text = .CurrentRow.Cells("term").Value.ToString()

                ElseIf nam_form = "edit_form_tafrgh" Then
                    edit_form_tafrgh.Name_Mkf.Text = .CurrentRow.Cells("Name_Mkf").Value.ToString()
                    edit_form_tafrgh.Item_Mkf_val.Text = .CurrentRow.Cells("Item_Mkf").Value.ToString()
                    edit_form_tafrgh.Years.Text = .CurrentRow.Cells("Years").Value.ToString()
                    edit_form_tafrgh.term.Text = .CurrentRow.Cells("term").Value.ToString()
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Close()

    End Sub


End Class