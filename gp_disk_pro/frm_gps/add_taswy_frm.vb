Imports System.Data.OleDb

Public Class add_taswy_frm
    Public add_edite As String = "add"

    '====================
    'rename datagrid
    Public Sub DataGridViewHeaderText_taswy(ByVal DGV As DataGridView)
        Try

        
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("id_bnd").HeaderText = "م"
                .Columns("num_taswy").HeaderText = "رقم التسويه"
                .Columns("col_1").HeaderText = DataGridView2.Rows(0).Cells(1).Value.ToString()
                .Columns("col_2").HeaderText = DataGridView2.Rows(1).Cells(1).Value.ToString()
                .Columns("col_3").HeaderText = DataGridView2.Rows(2).Cells(1).Value.ToString()
                .Columns("col_4").HeaderText = DataGridView2.Rows(3).Cells(1).Value.ToString()
                .Columns("col_5").HeaderText = DataGridView2.Rows(4).Cells(1).Value.ToString()
                .Columns("col_6").HeaderText = DataGridView2.Rows(5).Cells(1).Value.ToString()
                .Columns("col_7").HeaderText = DataGridView2.Rows(6).Cells(1).Value.ToString()
                .Columns("col_8").HeaderText = DataGridView2.Rows(7).Cells(1).Value.ToString()
                .Columns("col_9").HeaderText = DataGridView2.Rows(8).Cells(1).Value.ToString()
                .Columns("col_10").HeaderText = DataGridView2.Rows(9).Cells(1).Value.ToString()
                .Columns("col_11").HeaderText = DataGridView2.Rows(10).Cells(1).Value.ToString()
                .Columns("col_12").HeaderText = DataGridView2.Rows(11).Cells(1).Value.ToString()
                .Columns("col_13").HeaderText = DataGridView2.Rows(12).Cells(1).Value.ToString()
                .Columns("col_14").HeaderText = DataGridView2.Rows(13).Cells(1).Value.ToString()
                .Columns("col_15").HeaderText = DataGridView2.Rows(14).Cells(1).Value.ToString()
                .Columns("col_16").HeaderText = DataGridView2.Rows(15).Cells(1).Value.ToString()
                .Columns("col_17").HeaderText = DataGridView2.Rows(16).Cells(1).Value.ToString()
                .Columns("col_18").HeaderText = DataGridView2.Rows(17).Cells(1).Value.ToString()
                .Columns("col_19").HeaderText = DataGridView2.Rows(18).Cells(1).Value.ToString()
                .Columns("col_20").HeaderText = DataGridView2.Rows(19).Cells(1).Value.ToString()
                .Columns("col_21").HeaderText = DataGridView2.Rows(20).Cells(1).Value.ToString()
                .Columns("col_22").HeaderText = DataGridView2.Rows(21).Cells(1).Value.ToString()
                .Columns("col_23").HeaderText = DataGridView2.Rows(22).Cells(1).Value.ToString()
                .Columns("col_24").HeaderText = DataGridView2.Rows(23).Cells(1).Value.ToString()
                .Columns("col_25").HeaderText = DataGridView2.Rows(24).Cells(1).Value.ToString()
                    .Columns("col_26").HeaderText = DataGridView2.Rows(25).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_1").HeaderText = DataGridView2.Rows(26).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_2").HeaderText = DataGridView2.Rows(27).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_3").HeaderText = DataGridView2.Rows(28).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_4").HeaderText = DataGridView2.Rows(29).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_5").HeaderText = DataGridView2.Rows(30).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_6").HeaderText = DataGridView2.Rows(31).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_7").HeaderText = DataGridView2.Rows(32).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_8").HeaderText = DataGridView2.Rows(33).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_9").HeaderText = DataGridView2.Rows(34).Cells(1).Value.ToString()
                    .Columns("bnd_adafy_10").HeaderText = DataGridView2.Rows(35).Cells(1).Value.ToString()
                .Columns("total_all").HeaderText = "الاجمالى"
            End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '==================
    ' تجميع datagridview
    Public Sub total_dgv_tabel_bnd()
        Dim sum As Double = 0
        For s As Integer = 0 To dgv_tabel_bnd.RowCount - 1
            sum = sum + dgv_tabel_bnd.Item("total_all", s).Value

        Next
        num_total.Value = sum


    End Sub
    '================
















    '=============================================================
    '' تجميع datagridview3
    '====================

    Public Sub total_bndd()
        Dim total_bnd As Double = 0

        For i As Integer = 0 To DataGridView2.Rows.Count - 1

            'حساب البند
            '=============

            total_bnd = total_bnd + DataGridView2.Item(2, i).Value


        Next

        total_bnod.Value = total_bnd
    End Sub
    '==============================================
    '' تجميع datagridview4
    '====================

    Public Sub total_bnd_mostkta()
        Dim total_bnd_mos As Double = 0

        For i As Integer = 0 To DataGridView2.Rows.Count - 1

            'حساب البند
            '=============




        Next


    End Sub
    '=================================

    '=======================================================
    ' تجميع datagridview3
    Public Sub total_bndd_all()
        Dim sum As Double = 0
        For s As Integer = 0 To DataGridView2.RowCount - 1
            sum = sum + DataGridView2.Item("total_bnd", s).Value

        Next
        num_total.Value = sum


    End Sub
    Private Sub add_taswy_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Button4_Click(sender, e)

    End Sub






    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        search_taswy_frm.ShowDialog()
        search_taswy_frm.TextBox2.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If add_edite = "addd" Then
            Update_tabel_names_col_total(el_mablgh.Text, id_col.Text)

            SelectAll_tabel_names_col_total(DataGridView2)
            'run total
            '==========
            total_bndd()


            Me.el_mablgh.Text = vbNullString
            Update_tabel_names_col_total_to_zero()
            SelectAll_tabel_names_col_total(DataGridView2)
        Else
            'Update_tabel_names_col_total(el_mablgh.Value, id_col.Text)
            'SelectAll_tabel_names_col_total(dgv_tabel_names_col_total)
            'SelectAll_tabel_names_col_total(DataGridView2)

            Dim no_row As Integer
            no_row = Convert.ToInt32(id_col.Text)

            DataGridView2.Rows(no_row - 1).Cells(2).Value = el_mablgh.Text

            'run total
            '==========
            total_bndd()

            Me.el_mablgh.Text = vbNullString

            DataGridView2.Rows(no_row - 1).Cells(2).Selected = True

        End If
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        'Try

        Insert_taswy_bnd(id_bnd.Value, num_taswy_txt.Text, DataGridView2.Rows(0).Cells(2).Value,
                         DataGridView2.Rows(1).Cells(2).Value, DataGridView2.Rows(2).Cells(2).Value,
                         DataGridView2.Rows(3).Cells(2).Value, DataGridView2.Rows(4).Cells(2).Value,
                         DataGridView2.Rows(5).Cells(2).Value, DataGridView2.Rows(6).Cells(2).Value,
                         DataGridView2.Rows(7).Cells(2).Value, DataGridView2.Rows(8).Cells(2).Value,
                         DataGridView2.Rows(9).Cells(2).Value, DataGridView2.Rows(10).Cells(2).Value,
                         DataGridView2.Rows(11).Cells(2).Value, DataGridView2.Rows(12).Cells(2).Value,
                        DataGridView2.Rows(13).Cells(2).Value, DataGridView2.Rows(14).Cells(2).Value,
                        DataGridView2.Rows(15).Cells(2).Value, DataGridView2.Rows(16).Cells(2).Value,
                        DataGridView2.Rows(17).Cells(2).Value, DataGridView2.Rows(18).Cells(2).Value,
                        DataGridView2.Rows(19).Cells(2).Value, DataGridView2.Rows(20).Cells(2).Value,
                        DataGridView2.Rows(21).Cells(2).Value, DataGridView2.Rows(22).Cells(2).Value,
                        DataGridView2.Rows(23).Cells(2).Value, DataGridView2.Rows(24).Cells(2).Value,
                        DataGridView2.Rows(25).Cells(2).Value, DataGridView2.Rows(26).Cells(2).Value,
                        DataGridView2.Rows(27).Cells(2).Value, DataGridView2.Rows(28).Cells(2).Value,
                        DataGridView2.Rows(29).Cells(2).Value, DataGridView2.Rows(30).Cells(2).Value,
                        DataGridView2.Rows(31).Cells(2).Value, DataGridView2.Rows(32).Cells(2).Value,
                        DataGridView2.Rows(33).Cells(2).Value, DataGridView2.Rows(34).Cells(2).Value, DataGridView2.Rows(35).Cells(2).Value, total_bnod.Value)
        SelectAll_tabel_bnd(dgv_tabel_bnd, num_taswy)
        id_bnd.Value = Max_id_bnd() + 1
        Label7.Text = Count_num_taswy_bnd().ToString()
        total_dgv_tabel_bnd()
        DataGridViewHeaderText_taswy(dgv_tabel_bnd)
        total_bnod.Value = 0

        Update_tabel_names_col_total_to_zero()
        SelectAll_tabel_names_col_total(DataGridView2)
        BtnDelete.Visible = False
        format_datagridview(dgv_tabel_bnd)
        format_datagridview(DataGridView2)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        '    msg_lbl.Text = ex.Message.ToString()


        'End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'يحمل datagridvew
        ''================
        add_edite = "addd"
        SelectAll_tabel_names_col_total(DataGridView2)

        id_bnd.Value = Max_id_bnd() + 1
        num_taswy_txt.Text = Max_taswy_bnd()
        num_taswy = Convert.ToInt32(num_taswy)


        total_dgv_tabel_bnd()

        SelectAll_tabel_bnd(dgv_tabel_bnd, num_taswy)
        DataGridViewHeaderText_taswy(dgv_tabel_bnd)
        BtnNewAdd.Visible = True
        BtnEdit.Visible = False
        format_datagridview(dgv_tabel_bnd)
        format_datagridview(DataGridView2)
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click




        total_bnod.Value = 0

        Update_tabel_names_col_total_to_zero()
        SelectAll_tabel_names_col_total(DataGridView2)
        SelectAll_tabel_bnd(dgv_tabel_bnd, num_taswy)


        Dim da As New OleDbDataAdapter

        dt_tabel_bnd.Clear()
        num_taswy = Max_taswy_bnd() + 1
        da = New OleDbDataAdapter("select * from tabel_bnd where num_taswy=" & num_taswy & "", con)
        da.Fill(dt_tabel_bnd)
        dgv_tabel_bnd.DataSource = dt_tabel_bnd
        num_taswy_txt.Text = num_taswy.ToString()
        num_total.Value = 0
        BtnNewAdd.Visible = True
        BtnEdit.Visible = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Update_tabel_names_col_total_to_zero()
    End Sub

    Private Sub el_mablgh_Leave_1(sender As Object, e As EventArgs) Handles el_mablgh.Leave
        textbox_to_deciemal(el_mablgh)
        If Me.el_mablgh.Text = vbNullString Then
            Me.el_mablgh.Text = 0
        End If

        If add_edite = "addd" And id_col.Text <> "" Then
            Dim elmblgh1 As Double
            elmblgh1 = Convert.ToDouble(el_mablgh.Text)
            Update_tabel_names_col_total(elmblgh1, id_col.Text)

            SelectAll_tabel_names_col_total(DataGridView2)
            'run total
            '==========



            Me.el_mablgh.Text = 0

            'SelectAll_tabel_names_col_total(DataGridView2)
            total_bndd()
            '=========
            '    Dim no_row As Integer
            '    no_row = Convert.ToInt32(id_col.Text)

            '    DataGridView2.Rows(no_row - 1).Cells(2).Value = Convert.ToDouble(el_mablgh.Text)

            '    'run total
            '    '==========
            '    total_bndd()

            '    Me.el_mablgh.Text = vbNullString

            '    DataGridView2.Rows(no_row - 1).Cells(2).Selected = True
            'Else




        End If
        '======


    End Sub

    Private Sub dgv_tabel_bnd_Click(sender As Object, e As EventArgs) Handles dgv_tabel_bnd.Click
        Try


            With dgv_tabel_bnd
                Me.id_bnd.Text = .CurrentRow.Cells("id_bnd").Value.ToString()
                Me.total_bnod.Text = .CurrentRow.Cells("total_all").Value.ToString()
                Me.DataGridView2.Rows(0).Cells(2).Value = .CurrentRow.Cells("col_1").Value.ToString()
                Me.DataGridView2.Rows(1).Cells(2).Value = .CurrentRow.Cells("col_2").Value.ToString()
                Me.DataGridView2.Rows(2).Cells(2).Value = .CurrentRow.Cells("col_3").Value.ToString()
                Me.DataGridView2.Rows(3).Cells(2).Value = .CurrentRow.Cells("col_4").Value.ToString()
                Me.DataGridView2.Rows(4).Cells(2).Value = .CurrentRow.Cells("col_5").Value.ToString()
                Me.DataGridView2.Rows(5).Cells(2).Value = .CurrentRow.Cells("col_6").Value.ToString()
                Me.DataGridView2.Rows(6).Cells(2).Value = .CurrentRow.Cells("col_7").Value.ToString()
                Me.DataGridView2.Rows(7).Cells(2).Value = .CurrentRow.Cells("col_8").Value.ToString()
                Me.DataGridView2.Rows(8).Cells(2).Value = .CurrentRow.Cells("col_9").Value.ToString()
                Me.DataGridView2.Rows(9).Cells(2).Value = .CurrentRow.Cells("col_10").Value.ToString()
                Me.DataGridView2.Rows(10).Cells(2).Value = .CurrentRow.Cells("col_11").Value.ToString()
                Me.DataGridView2.Rows(11).Cells(2).Value = .CurrentRow.Cells("col_12").Value.ToString()
                Me.DataGridView2.Rows(12).Cells(2).Value = .CurrentRow.Cells("col_13").Value.ToString()
                Me.DataGridView2.Rows(13).Cells(2).Value = .CurrentRow.Cells("col_14").Value.ToString()
                Me.DataGridView2.Rows(14).Cells(2).Value = .CurrentRow.Cells("col_15").Value.ToString()
                Me.DataGridView2.Rows(15).Cells(2).Value = .CurrentRow.Cells("col_16").Value.ToString()
                Me.DataGridView2.Rows(16).Cells(2).Value = .CurrentRow.Cells("col_17").Value.ToString()
                Me.DataGridView2.Rows(17).Cells(2).Value = .CurrentRow.Cells("col_18").Value.ToString()
                Me.DataGridView2.Rows(18).Cells(2).Value = .CurrentRow.Cells("col_19").Value.ToString()
                Me.DataGridView2.Rows(19).Cells(2).Value = .CurrentRow.Cells("col_20").Value.ToString()
                Me.DataGridView2.Rows(20).Cells(2).Value = .CurrentRow.Cells("col_21").Value.ToString()
                Me.DataGridView2.Rows(21).Cells(2).Value = .CurrentRow.Cells("col_22").Value.ToString()
                Me.DataGridView2.Rows(22).Cells(2).Value = .CurrentRow.Cells("col_23").Value.ToString()
                Me.DataGridView2.Rows(23).Cells(2).Value = .CurrentRow.Cells("col_24").Value.ToString()
                Me.DataGridView2.Rows(24).Cells(2).Value = .CurrentRow.Cells("col_25").Value.ToString()
                Me.DataGridView2.Rows(25).Cells(2).Value = .CurrentRow.Cells("col_26").Value.ToString()
                Me.DataGridView2.Rows(26).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_1").Value.ToString()
                Me.DataGridView2.Rows(27).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_2").Value.ToString()
                Me.DataGridView2.Rows(28).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_3").Value.ToString()
                Me.DataGridView2.Rows(29).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_4").Value.ToString()
                Me.DataGridView2.Rows(30).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_5").Value.ToString()
                Me.DataGridView2.Rows(31).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_6").Value.ToString()
                Me.DataGridView2.Rows(32).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_7").Value.ToString()
                Me.DataGridView2.Rows(33).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_8").Value.ToString()
                Me.DataGridView2.Rows(34).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_9").Value.ToString()
                Me.DataGridView2.Rows(35).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_10").Value.ToString()

                BtnNewAdd.Visible = False
                BtnEdit.Visible = True
                BtnDelete.Visible = True
                'add_edite = "Edite"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        Update_tabel_bnd_taswy(id_bnd.Value, num_taswy_txt.Text, DataGridView2.Rows(0).Cells(2).Value,
                             DataGridView2.Rows(1).Cells(2).Value, DataGridView2.Rows(2).Cells(2).Value,
                             DataGridView2.Rows(3).Cells(2).Value, DataGridView2.Rows(4).Cells(2).Value,
                             DataGridView2.Rows(5).Cells(2).Value, DataGridView2.Rows(6).Cells(2).Value,
                             DataGridView2.Rows(7).Cells(2).Value, DataGridView2.Rows(8).Cells(2).Value,
                             DataGridView2.Rows(9).Cells(2).Value, DataGridView2.Rows(10).Cells(2).Value,
                             DataGridView2.Rows(11).Cells(2).Value, DataGridView2.Rows(12).Cells(2).Value,
                            DataGridView2.Rows(13).Cells(2).Value, DataGridView2.Rows(14).Cells(2).Value,
                            DataGridView2.Rows(15).Cells(2).Value, DataGridView2.Rows(16).Cells(2).Value,
                            DataGridView2.Rows(17).Cells(2).Value, DataGridView2.Rows(18).Cells(2).Value,
                            DataGridView2.Rows(19).Cells(2).Value, DataGridView2.Rows(20).Cells(2).Value,
                            DataGridView2.Rows(21).Cells(2).Value, DataGridView2.Rows(22).Cells(2).Value,
                            DataGridView2.Rows(23).Cells(2).Value, DataGridView2.Rows(24).Cells(2).Value,
                            DataGridView2.Rows(25).Cells(2).Value, DataGridView2.Rows(26).Cells(2).Value,
                            DataGridView2.Rows(27).Cells(2).Value, DataGridView2.Rows(28).Cells(2).Value,
                            DataGridView2.Rows(29).Cells(2).Value, DataGridView2.Rows(30).Cells(2).Value,
                            DataGridView2.Rows(31).Cells(2).Value, DataGridView2.Rows(32).Cells(2).Value,
                            DataGridView2.Rows(33).Cells(2).Value, DataGridView2.Rows(34).Cells(2).Value, DataGridView2.Rows(35).Cells(2).Value, total_bnod.Value)

        id_bnd.Value = Max_id_bnd() + 1
        num_taswy_txt.Text = Max_taswy_bnd()
        num_taswy = Convert.ToInt32(num_taswy)
        total_dgv_tabel_bnd()

        SelectAll_tabel_bnd(dgv_tabel_bnd, num_taswy)
        total_dgv_tabel_bnd()
        BtnNewAdd.Visible = True
        BtnEdit.Visible = False
        BtnDelete.Visible = False
        add_edite = "addd"
        Update_tabel_names_col_total_to_zero()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        SelectAll_tabel_bnd_all_taswy(ListBox1)
        id_bnd.Value = Max_id_bnd() + 1
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try

            num_taswy = ListBox1.SelectedValue
            If num_taswy >= 0 Then
                num_taswy_txt.Text = num_taswy.ToString()
                SelectAll_tabel_bnd_one_taswy(dgv_tabel_bnd, num_taswy)
                total_dgv_tabel_bnd()
                BtnNewAdd.Visible = True
                BtnEdit.Visible = False
                add_edite = "addd"
                id_bnd.Value = Max_id_bnd() + 1
            Else

            End If
    
        Catch ex As Exception

        End Try
  
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_tabel_bnd_rec(id_bnd.Value)

            SelectAll_tabel_bnd(dgv_tabel_bnd, num_taswy)
            id_bnd.Value = Max_id_bnd() + 1
            Label7.Text = Count_num_taswy_bnd().ToString()
            total_dgv_tabel_bnd()

            total_bnod.Value = 0

            Update_tabel_names_col_total_to_zero()
            SelectAll_tabel_names_col_total(DataGridView2)
            BtnDelete.Visible = False
            Update_tabel_names_col_total_to_zero()
        End If

    End Sub

    

    Private Sub el_mablgh_KeyPress(sender As Object, e As KeyPressEventArgs) Handles el_mablgh.KeyPress
        noused_char(e)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form_edite_bnd_name.ShowDialog()
    End Sub

    Private Sub el_mablgh_KeyDown(sender As Object, e As KeyEventArgs) Handles el_mablgh.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.el_mablgh.Text = vbNullString Then
                Me.el_mablgh.Text = 0
            End If

            If add_edite = "addd" And id_col.Text <> "" Then
                Dim elmblgh1 As Double
                elmblgh1 = Convert.ToDouble(el_mablgh.Text)
                Update_tabel_names_col_total(elmblgh1, id_col.Text)

                'SelectAll_tabel_names_col_total(DataGridView2)
                'run total
                '==========



                Me.el_mablgh.Text = 0

                'SelectAll_tabel_names_col_total(DataGridView2)
                total_bndd()
            Else


                'Dim no_row As Integer
                'no_row = Convert.ToInt32(id_col.Text)

                'DataGridView2.Rows(no_row - 1).Cells(2).Value = Convert.ToDouble(el_mablgh.Text)

                ''run total
                ''==========
                'total_bndd()

                'Me.el_mablgh.Text = vbNullString

                'DataGridView2.Rows(no_row - 1).Cells(2).Selected = True

            End If
            '======
            textbox_to_deciemal(el_mablgh)

        End If
    End Sub


 
    'Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs)
    '    Button9_Click(sender, e)
    'End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'If Panel3.Visible = True Then


        '    Me.el_mablgh.Text = vbNullString
        '    id_col.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString()
        '    name_col_total.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString()
        '    If DataGridView2.CurrentRow.Cells(2).Value = 0 Then
        '        Me.el_mablgh.Text = vbNullString
        '        Me.el_mablgh.Focus()
        '        Me.el_mablgh.Select()
        '    Else
        '        Me.el_mablgh.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString()
        '        Me.el_mablgh.Focus()



        '    End If


        '    el_mablgh.Enabled = True
        '    el_mablgh.Focus()
        '    el_mablgh.BackColor = Color.Gold
        '    Me.el_mablgh.Select()

        '    'Me.AutoScroll = False


        'End If

    End Sub

    Private Sub DataGridView2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Up Then
            Button9_Click(sender, e)
        End If
    End Sub



    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        Button9_Click(sender, e)
    End Sub

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit
        'Me.el_mablgh.Text = vbNullString
        'id_col.Text = DataGridView2.CurrentRow.Cells(0).Value.ToString()
        'name_col_total.Text = DataGridView2.CurrentRow.Cells(1).Value.ToString()
        'If DataGridView2.CurrentRow.Cells(2).Value = 0 Then
        '    Me.el_mablgh.Text = vbNullString
        '    Me.el_mablgh.Focus()
        '    Me.el_mablgh.Select()
        'Else
        '    Me.el_mablgh.Text = DataGridView2.CurrentRow.Cells(2).Value.ToString()
        '    Me.el_mablgh.Focus()



        'End If


        'el_mablgh.Enabled = True
        'el_mablgh.Focus()
        'el_mablgh.BackColor = Color.Gold
        'Me.el_mablgh.Select()

    End Sub

    Private Sub DataGridView2_KeyDown_1(sender As Object, e As KeyEventArgs) Handles DataGridView2.KeyDown
        Button9_Click(sender, e)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Me.AutoScroll = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Panel3.Visible = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Panel3.Visible = True
    End Sub


    Private Sub dgv_tabel_bnd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tabel_bnd.CellContentClick
        Try


            With dgv_tabel_bnd
                Me.id_bnd.Text = .CurrentRow.Cells("id_bnd").Value.ToString()
                Me.total_bnod.Text = .CurrentRow.Cells("total_all").Value.ToString()
                Me.DataGridView2.Rows(0).Cells(2).Value = .CurrentRow.Cells("col_1").Value.ToString()
                Me.DataGridView2.Rows(1).Cells(2).Value = .CurrentRow.Cells("col_2").Value.ToString()
                Me.DataGridView2.Rows(2).Cells(2).Value = .CurrentRow.Cells("col_3").Value.ToString()
                Me.DataGridView2.Rows(3).Cells(2).Value = .CurrentRow.Cells("col_4").Value.ToString()
                Me.DataGridView2.Rows(4).Cells(2).Value = .CurrentRow.Cells("col_5").Value.ToString()
                Me.DataGridView2.Rows(5).Cells(2).Value = .CurrentRow.Cells("col_6").Value.ToString()
                Me.DataGridView2.Rows(6).Cells(2).Value = .CurrentRow.Cells("col_7").Value.ToString()
                Me.DataGridView2.Rows(7).Cells(2).Value = .CurrentRow.Cells("col_8").Value.ToString()
                Me.DataGridView2.Rows(8).Cells(2).Value = .CurrentRow.Cells("col_9").Value.ToString()
                Me.DataGridView2.Rows(9).Cells(2).Value = .CurrentRow.Cells("col_10").Value.ToString()
                Me.DataGridView2.Rows(10).Cells(2).Value = .CurrentRow.Cells("col_11").Value.ToString()
                Me.DataGridView2.Rows(11).Cells(2).Value = .CurrentRow.Cells("col_12").Value.ToString()
                Me.DataGridView2.Rows(12).Cells(2).Value = .CurrentRow.Cells("col_13").Value.ToString()
                Me.DataGridView2.Rows(13).Cells(2).Value = .CurrentRow.Cells("col_14").Value.ToString()
                Me.DataGridView2.Rows(14).Cells(2).Value = .CurrentRow.Cells("col_15").Value.ToString()
                Me.DataGridView2.Rows(15).Cells(2).Value = .CurrentRow.Cells("col_16").Value.ToString()
                Me.DataGridView2.Rows(16).Cells(2).Value = .CurrentRow.Cells("col_17").Value.ToString()
                Me.DataGridView2.Rows(17).Cells(2).Value = .CurrentRow.Cells("col_18").Value.ToString()
                Me.DataGridView2.Rows(18).Cells(2).Value = .CurrentRow.Cells("col_19").Value.ToString()
                Me.DataGridView2.Rows(19).Cells(2).Value = .CurrentRow.Cells("col_20").Value.ToString()
                Me.DataGridView2.Rows(20).Cells(2).Value = .CurrentRow.Cells("col_21").Value.ToString()
                Me.DataGridView2.Rows(21).Cells(2).Value = .CurrentRow.Cells("col_22").Value.ToString()
                Me.DataGridView2.Rows(22).Cells(2).Value = .CurrentRow.Cells("col_23").Value.ToString()
                Me.DataGridView2.Rows(23).Cells(2).Value = .CurrentRow.Cells("col_24").Value.ToString()
                Me.DataGridView2.Rows(24).Cells(2).Value = .CurrentRow.Cells("col_25").Value.ToString()
                Me.DataGridView2.Rows(25).Cells(2).Value = .CurrentRow.Cells("col_26").Value.ToString()
                Me.DataGridView2.Rows(26).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_1").Value.ToString()
                Me.DataGridView2.Rows(27).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_2").Value.ToString()
                Me.DataGridView2.Rows(28).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_3").Value.ToString()
                Me.DataGridView2.Rows(29).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_4").Value.ToString()
                Me.DataGridView2.Rows(30).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_5").Value.ToString()
                Me.DataGridView2.Rows(31).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_6").Value.ToString()
                Me.DataGridView2.Rows(32).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_7").Value.ToString()
                Me.DataGridView2.Rows(33).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_8").Value.ToString()
                Me.DataGridView2.Rows(34).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_9").Value.ToString()
                Me.DataGridView2.Rows(35).Cells(2).Value = .CurrentRow.Cells("bnd_adafy_10").Value.ToString()

                BtnNewAdd.Visible = False
                BtnEdit.Visible = True
                BtnDelete.Visible = True
                'add_edite = "Edite"
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



   
End Class