Public Class try_form




    Public Sub DataGridViewHeaderTxxtedit(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Id").HeaderText = "Id"
                .Columns("No_55").HeaderText = "55 ع . ح"
                .Columns("no_kshf").HeaderText = "رقم الكشف"
                .Columns("Name_Emp").HeaderText = "الاسم"
                .Columns("Name_school").HeaderText = "المدرسة"
                .Columns("Salary_ass").HeaderText = "المرتب الاساسى"
                .Columns("Dayes").HeaderText = "عدد الايام"
                .Columns("Mkf").HeaderText = "المكافاة"
                .Columns("Badl_safer").HeaderText = "بدل سفر"
                .Columns("Entklat").HeaderText = "انتقالات"
                .Columns("total").HeaderText = "جملة"
                .Columns("Mashat").HeaderText = "معاشات"
                .Columns("Mashat8").HeaderText = "مهن 2%"
                .Columns("Darabb").HeaderText = "ضرائب"
                .Columns("nkaba").HeaderText = "معاشات 1%"
                .Columns("Mhann").HeaderText = "م 1% "

                .Columns("Mastshfa").HeaderText = "مستشفى"
                .Columns("Damghh").HeaderText = "دمغه"
                .Columns("Earaadta").HeaderText = "ايرادات"
                .Columns("box20").HeaderText = "صندوق %20"
                .Columns("Total_Mostkta").HeaderText = "جملة المستقطع"
                .Columns("Saffy").HeaderText = "الصافى"
                .Columns("Id_Mkf").HeaderText = "Id_Mkf"
                .Columns("date1").HeaderText = "التاريخ"
                .Columns("id_no").HeaderText = "رقم القومى"
                '.Columns("name_pay").Visible = False
                '.Columns("al_kta").Visible = False
                '.Columns("no_emb").Visible = False
                .Columns("nakab_yes_no").Visible = False
                .Columns("No_55").DefaultCellStyle.BackColor = Color.Yellow
                .Columns("Total_Mostkta").DefaultCellStyle.BackColor = Color.Yellow
                '========================
                .Columns(20).DefaultCellStyle.BackColor = Color.Yellow
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                .ScrollBars = ScrollBars.Both
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowsDefaultCellStyle.BackColor = Color.Black
                .RowsDefaultCellStyle.ForeColor = Color.Green
                .RowsDefaultCellStyle.SelectionBackColor = Color.Red
                '====
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
                '====
                .RowHeadersDefaultCellStyle.ForeColor = Color.White
                .RowHeadersDefaultCellStyle.BackColor = Color.Navy

            End With
        End If
    End Sub
    '=====================================


    Private Sub try_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''اضافة شهور فى الlistbox
        '=========================
        Dim dt As DateTime
        dt = Convert.ToDateTime("01/01/2020")
        For i = 1 To 24
            Dim dts As String

            dts = dt.ToString("MMMM")

            dt = dt.AddMonths(1)

            ListBox1.Items.Add(dts)
            i += 1
        Next
        '=========================================
        'اضافة الايام
        Dim dt_days As DateTime
        dt_days = Convert.ToDateTime("01/01/2020")
        For i = 1 To 61
            Dim dts_day As String

            dts_day = dt.ToString("dd")

            dt = dt.AddDays(1)

            ListBox2.Items.Add(dts_day)
            i += 1
        Next
    End Sub
    Public Sub movelistbox(ByVal source As ListBox, ByVal des As ListBox)
        Dim sorce_item As ListBox.SelectedObjectCollection = ListBox33.SelectedItems

        For Each item In sorce_item
            If source.Items.Count > 0 Then
                source.SelectedItem = True


            End If

            des.Items.Add(item)

        Next item
        Do While source.SelectedItems.Count > 0
            source.Items.Remove(source.SelectedItems(0))


        Loop
        '======================================================================



    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        movelistbox(ListBox33, ListBox44)
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Dim MyArray(ListBox33.Items.Count - 1) As String

        ListBox33.Items.CopyTo(MyArray, 0)

        Array.Sort(MyArray)

        For i As Integer = 0 To ListBox33.Items.Count - 1

            CheckedListBox1.Items.Add(MyArray(i))
        Next i
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim no_k As Integer
        no_k = Max_no_kshf()
        select_no_kash_view(no_k)
        DataGridView1.DataSource = dt_select_no_kash_view

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DataGridViewHeaderTxxtedit(DataGridView1)
        DataGridView1.Columns(20).Selected = True
        '  Dim v As Integer







    End Sub

End Class