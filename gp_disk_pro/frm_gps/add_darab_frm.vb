Imports System.Data.OleDb

Public Class add_darab_frm
    '===============
    Public stat_edit As Integer = 3
    '===============
    Public dt_check_shatb_no As New DataTable
    Public Sub check_shatb_no(ByVal id_num_rec As Integer)
        Dim da As New OleDbDataAdapter
        dt_check_shatb_no.Clear()

        Dim Cmd As New OleDbCommand("select * from add_new_drab_tabel where num_rec=@id_num_rec", con)

        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@num_rec", OleDbType.Integer).Value = id_num_rec
            dt_check_shatb_no.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing

        'id_noo_combx.DataSource = dt_auto_id_no
        'id_noo_combx.DisplayMember = "id_no"
        If dt_check_shatb_no.Rows.Count > 0 Then
            If dt_check_shatb_no.Rows(0).Item("shatb_no") = Cmbx_shatb.Text Then
                msg_lbl.Text = dt_check_shatb_no.Rows(0).Item("shatb_no")
            Else
                msg_lbl.Text = "يجب التحقق من الباب الموازنى "
                MessageBox.Show("يجب التحقق من الباب الموازنى ")
            End If


        Else


        End If
    End Sub

    '===============
    Public Sub close_date_amr_dafa()
        kasb_amr_dafa_txt.ReadOnly = True
        damgha_amr_dafa_txt.ReadOnly = True
        arbah_amr_dafa_txt.ReadOnly = True
        nyea_amr_dafa_txt.ReadOnly = True
        tanmea_amr_dafa_txt.ReadOnly = True
        kema_m_amr_dafa_txt.ReadOnly = True
        date_kasb.ReadOnly = True
        Date_damgha.ReadOnly = True
        Date_arbah.ReadOnly = True
        Date_nyea.ReadOnly = True
        Date_tanmea.ReadOnly = True
        Date_kema.ReadOnly = True

    End Sub
    '=========
    Public Sub open_date_amr_dafa()
        kasb_amr_dafa_txt.ReadOnly = False
        damgha_amr_dafa_txt.ReadOnly = False
        arbah_amr_dafa_txt.ReadOnly = False
        nyea_amr_dafa_txt.ReadOnly = False
        tanmea_amr_dafa_txt.ReadOnly = False
        kema_m_amr_dafa_txt.ReadOnly = False
        date_kasb.ReadOnly = False
        Date_damgha.ReadOnly = False
        Date_arbah.ReadOnly = False
        Date_nyea.ReadOnly = False
        Date_tanmea.ReadOnly = False
        Date_kema.ReadOnly = False

    End Sub
    '==========
    Public Sub clear_contral()
        Me.kasb_tot_txt.Text = vbNullString
        Me.damgha_tot_txt.Text = vbNullString
        Me.arbah_tot_txt.Text = vbNullString
        Me.nyea_tot_txt.Text = vbNullString
        Me.tanmea_tot_txt.Text = vbNullString
        Me.kema_m_tot_txt.Text = vbNullString
        Me.kasb_amr_dafa_txt.Text = vbNullString
        Me.damgha_amr_dafa_txt.Text = vbNullString
        Me.arbah_amr_dafa_txt.Text = vbNullString
        Me.nyea_amr_dafa_txt.Text = vbNullString
        Me.nyea_tot_txt.Text = vbNullString
        Me.tanmea_amr_dafa_txt.Text = vbNullString
        Me.kema_m_amr_dafa_txt.Text = vbNullString
        shatb_number_txt.Text = ""
        num_ked_txt.Text = ""
        Me.date_kasb.Text = vbNullString
        Me.Date_damgha.Text = vbNullString
        Me.Date_arbah.Text = vbNullString
        Me.Date_nyea.Text = vbNullString
        Me.Date_tanmea.Text = vbNullString
        Me.Date_kema.Text = vbNullString
        '========================================
        Me.kasb_tot_txt.Enabled = True
        Me.damgha_tot_txt.Enabled = True
        Me.arbah_tot_txt.Enabled = True

        Me.tanmea_tot_txt.Enabled = True
        Me.kema_m_tot_txt.Enabled = True
        Me.kasb_amr_dafa_txt.Enabled = True
        Me.damgha_amr_dafa_txt.Enabled = True
        Me.arbah_amr_dafa_txt.Enabled = True
        Me.nyea_tot_txt.Enabled = True
        Me.nyea_amr_dafa_txt.Enabled = True
        Me.tanmea_amr_dafa_txt.Enabled = True
        Me.kema_m_amr_dafa_txt.Enabled = True
        shatb_number_txt.Enabled = True
        num_ked_txt.Enabled = True
        Me.date_kasb.Enabled = True
        Me.Date_damgha.Enabled = True
        Me.Date_arbah.Enabled = True
        Me.Date_nyea.Enabled = True
        Me.Date_tanmea.Enabled = True
        Me.Date_kema.Enabled = True

    End Sub
    '=========
    Public Sub clear_contral2()
        Me.kasb_tot_txt.Text = vbNullString
        Me.damgha_tot_txt.Text = vbNullString
        Me.arbah_tot_txt.Text = vbNullString
        Me.nyea_tot_txt.Text = vbNullString
        Me.tanmea_tot_txt.Text = vbNullString
        Me.kema_m_tot_txt.Text = vbNullString
        shatb_number_txt.Text = ""
        num_ked_txt.Text = ""
        Me.kasb_tot_txt.Enabled = True
        Me.damgha_tot_txt.Enabled = True
        Me.arbah_tot_txt.Enabled = True

        Me.tanmea_tot_txt.Enabled = True
        Me.kema_m_tot_txt.Enabled = True
        Me.kasb_amr_dafa_txt.Enabled = True
        Me.damgha_amr_dafa_txt.Enabled = True
        Me.arbah_amr_dafa_txt.Enabled = True
        Me.nyea_tot_txt.Enabled = True
        Me.nyea_amr_dafa_txt.Enabled = True
        Me.tanmea_amr_dafa_txt.Enabled = True
        Me.kema_m_amr_dafa_txt.Enabled = True
        Me.date_kasb.Enabled = True
        Me.Date_damgha.Enabled = True
        Me.Date_arbah.Enabled = True
        Me.Date_nyea.Enabled = True
        Me.Date_tanmea.Enabled = True
        Me.Date_kema.Enabled = True
    End Sub

    '================
    Public Sub check_data()
        If Me.date_kasb.Text = vbNullString Then
            Me.date_kasb.Text = "0"
        End If
        If Me.Date_damgha.Text = vbNullString Then
            Me.Date_damgha.Text = "0"
        End If
        If Me.Date_arbah.Text = vbNullString Then
            Me.Date_arbah.Text = "0"
        End If
        If Me.Date_nyea.Text = vbNullString Then
            Me.Date_nyea.Text = "0"
        End If
        If Me.Date_tanmea.Text = vbNullString Then
            Me.Date_tanmea.Text = "0"
        End If
        If Me.Date_kema.Text = vbNullString Then
            Me.Date_kema.Text = "0"
        End If

        '=====================================
        If Me.kasb_tot_txt.Text = vbNullString Then
            Me.kasb_tot_txt.Text = "0"
        End If
        If Me.damgha_tot_txt.Text = vbNullString Then
            Me.damgha_tot_txt.Text = "0"
        End If
        If Me.arbah_tot_txt.Text = vbNullString Then
            Me.arbah_tot_txt.Text = "0"
        End If
        If Me.nyea_tot_txt.Text = vbNullString Then
            Me.nyea_tot_txt.Text = "0"
        End If
        If Me.tanmea_tot_txt.Text = vbNullString Then
            Me.tanmea_tot_txt.Text = "0"
        End If
        If Me.kema_m_tot_txt.Text = vbNullString Then
            Me.kema_m_tot_txt.Text = "0"
        End If
        If Me.kasb_amr_dafa_txt.Text = vbNullString Then
            Me.kasb_amr_dafa_txt.Text = "0"
        End If
        If Me.damgha_amr_dafa_txt.Text = vbNullString Then
            Me.damgha_amr_dafa_txt.Text = "0"
        End If
        If Me.arbah_amr_dafa_txt.Text = vbNullString Then
            Me.arbah_amr_dafa_txt.Text = "0"
        End If
        If Me.nyea_amr_dafa_txt.Text = vbNullString Then
            Me.nyea_amr_dafa_txt.Text = "0"
        End If
        If Me.tanmea_amr_dafa_txt.Text = vbNullString Then
            Me.tanmea_amr_dafa_txt.Text = "0"
        End If
        If Me.kema_m_amr_dafa_txt.Text = vbNullString Then
            Me.kema_m_amr_dafa_txt.Text = "0"
        End If
    End Sub

    '======================
    'Public dt_select_drab_all_total As New DataTable
    'Public dt_select_drab_all_total2 As New DataTable
    'Public Sub SelectAll_add_drab_total(dgv As DataGridView, num_rec As Integer)
    '    Dim da As New OleDbDataAdapter
    '    Dim da2 As New OleDbDataAdapter
    '    dt_select_drab_all_total.Clear()
    '    dt_select_drab_all_total2.Clear()
    '    da = New OleDbDataAdapter("SELECT add_new_drab_tabel.num_rec,add_new_drab_tabel.shatb_no,SUM(kasb_drab_tabel.kasb) AS kasb,SUM(damgha_drab_tabel.damgha_total) AS damgh,SUM(arbah_drab_tabel.arbah_t_total) AS arbah,SUM(tanmea_drab_tabel.tanmea_total) AS tamen,SUM(nwaya_drab_tabel.nwaya_total) AS nwaya,SUM(kema_mdfa_drab_tabel.kema_mdfa_total) AS kema_mdfa FROM()(((((add_new_drab_tabel INNER JOIN arbah_drab_tabel ON add_new_drab_tabel.shatb_number = arbah_drab_tabel.shatb_number) INNER JOIN damgha_drab_tabel ON add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number) INNER JOIN kasb_drab_tabel ON add_new_drab_tabel.shatb_number = kasb_drab_tabel.shatb_number) INNER JOIN kema_mdfa_drab_tabel ON add_new_drab_tabel.shatb_number = kema_mdfa_drab_tabel.shatb_number) INNER JOIN nwaya_drab_tabel ON add_new_drab_tabel.shatb_number = nwaya_drab_tabel.shatb_number) INNER JOIN tanmea_drab_tabel ON add_new_drab_tabel.shatb_number = tanmea_drab_tabel.shatb_number WHERE() add_new_drab_tabel.num_rec = " & num_rec & " GROUP BY add_new_drab_tabel.num_rec, add_new_drab_tabel.shatb_no", con)

    '    da2 = New OleDbDataAdapter("SELECT add_new_drab_tabel.id_drab, add_new_drab_tabel.num_rec, add_new_drab_tabel.shatb_no, add_new_drab_tabel.num_ked, add_new_drab_tabel.shatb_number, add_new_drab_tabel.date_drab, add_new_drab_tabel.total_drab, kasb_drab_tabel.kasb, kasb_drab_tabel.kasb_amr_dafa, kasb_drab_tabel.kasb_date, kasb_drab_tabel.tot_tot_kasb, damgha_drab_tabel.damgha_total, damgha_drab_tabel.damgha_amr_dafa, damgha_drab_tabel.damgha_date, damgha_drab_tabel.tot_tot_damgha, tanmea_drab_tabel.tanmea_total, tanmea_drab_tabel.tanmea_amr_dafa, tanmea_drab_tabel.tanmea_date, tanmea_drab_tabel.tot_tot_tanmea, arbah_drab_tabel.arbah_t_total, arbah_drab_tabel.arbah_t_amr_dafa, arbah_drab_tabel.arbah_t_date, arbah_drab_tabel.tot_tot_arbah_t, nwaya_drab_tabel.nwaya_total, nwaya_drab_tabel.nwaya_amr_dafa, nwaya_drab_tabel.nwaya_date, nwaya_drab_tabel.tot_tot_nwaya, kema_mdfa_drab_tabel.kema_mdfa_total, kema_mdfa_drab_tabel.kema_mdfa_amr_dafa, kema_mdfa_drab_tabel.kema_mdfa_date, kema_mdfa_drab_tabel.tot_tot_kema_mdfa FROM (((((add_new_drab_tabel INNER JOIN arbah_drab_tabel ON add_new_drab_tabel.shatb_number = arbah_drab_tabel.shatb_number) INNER JOIN damgha_drab_tabel ON add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number) INNER JOIN kasb_drab_tabel ON add_new_drab_tabel.shatb_number = kasb_drab_tabel.shatb_number) INNER JOIN kema_mdfa_drab_tabel ON add_new_drab_tabel.shatb_number = kema_mdfa_drab_tabel.shatb_number) INNER JOIN nwaya_drab_tabel ON add_new_drab_tabel.shatb_number = nwaya_drab_tabel.shatb_number) INNER JOIN tanmea_drab_tabel ON add_new_drab_tabel.shatb_number = tanmea_drab_tabel.shatb_number where num_rec = " & num_rec & "", con)

    '    da.Fill(dt_select_drab_all_total)
    '    da2.Fill(dt_select_drab_all_total2)
    '    If dt_select_drab_all_total2.Rows.Count > 0 Then
    '        DataGridView2.DataSource = dt_select_drab_all_total2

    '    Else
    '        DataGridView2.DataSource = Nothing

    '    End If
    '    dgv.DataSource = dt_select_drab_all_total
    'ListBox2.DataSource = Nothing
    'ListBox2.DataSource = dt_select_drab_all_total2
    'ListBox1.DisplayMember = "shatb_number"
    'ListBox2.DisplayMember = "num_ked"

    'ListBox1.ValueMember = "shatb_number"
    'ListBox2.ValueMember = "num_ked"
    'da = New OleDbDataAdapter("SELECT num_rec, shatb_no,Sum(kasb) AS tot_tot_kasb,Sum(damgha_total) AS tot_tot_damgha,Sum(arbah_t_total) AS tot_tot_arbah_t,Sum(nwaya_total) AS ؤ,Sum(tanmea_total) AS tot_tot_tanmea,Sum(kema_mdfa_total) AS tot_tot_kema_mdfa FROM add_drab WHERE num_rec = " & num_rec & " GROUP BY num_rec, shatb_no", con)
    '===================

    ''End Sub
    '===============
    Public dt_select_drab_all_total As New DataTable
    Public dt_select_drab_all_total2 As New DataTable

    Public Sub SelectAll_add_drab_total(dgv As DataGridView, num_rec As Integer)
        Dim da As New OleDbDataAdapter
        Dim da2 As New OleDbDataAdapter
        dt_select_drab_all_total.Clear()
        dt_select_drab_all_total2.Clear()

        Dim query1 As String = "SELECT add_new_drab_tabel.num_rec, add_new_drab_tabel.shatb_no, " &
            "SUM(kasb_drab_tabel.kasb) AS tot_tot_kasb, SUM(damgha_drab_tabel.damgha_total) AS tot_tot_damgha, " &
            "SUM(arbah_drab_tabel.arbah_t_total) AS tot_tot_arbah_t, SUM(tanmea_drab_tabel.tanmea_total) AS tot_tot_tanmea, " &
            "SUM(nwaya_drab_tabel.nwaya_total) AS tot_tot_nwaya, SUM(kema_mdfa_drab_tabel.kema_mdfa_total) AS tot_tot_kema_mdfa " &
            "FROM ((((((add_new_drab_tabel " &
            "LEFT JOIN arbah_drab_tabel ON add_new_drab_tabel.shatb_number = arbah_drab_tabel.shatb_number) " &
            "LEFT JOIN damgha_drab_tabel ON add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number) " &
            "LEFT JOIN kasb_drab_tabel ON add_new_drab_tabel.shatb_number = kasb_drab_tabel.shatb_number) " &
            "LEFT JOIN kema_mdfa_drab_tabel ON add_new_drab_tabel.shatb_number = kema_mdfa_drab_tabel.shatb_number) " &
            "LEFT JOIN nwaya_drab_tabel ON add_new_drab_tabel.shatb_number = nwaya_drab_tabel.shatb_number) " &
            "LEFT JOIN tanmea_drab_tabel ON add_new_drab_tabel.shatb_number = tanmea_drab_tabel.shatb_number) " &
            "WHERE add_new_drab_tabel.num_rec = " & num_rec & " " &
            "GROUP BY add_new_drab_tabel.num_rec, add_new_drab_tabel.shatb_no"


        Dim query2 As String = "SELECT add_new_drab_tabel.id_drab, add_new_drab_tabel.num_rec, add_new_drab_tabel.shatb_no, " &
            "add_new_drab_tabel.num_ked, add_new_drab_tabel.shatb_number, add_new_drab_tabel.date_drab, add_new_drab_tabel.total_drab, " &
            "kasb_drab_tabel.kasb, kasb_drab_tabel.kasb_amr_dafa, kasb_drab_tabel.kasb_date, kasb_drab_tabel.tot_tot_kasb, " &
            "damgha_drab_tabel.damgha_total, damgha_drab_tabel.damgha_amr_dafa, damgha_drab_tabel.damgha_date, damgha_drab_tabel.tot_tot_damgha, " &
            "tanmea_drab_tabel.tanmea_total, tanmea_drab_tabel.tanmea_amr_dafa, tanmea_drab_tabel.tanmea_date, tanmea_drab_tabel.tot_tot_tanmea, " &
            "arbah_drab_tabel.arbah_t_total, arbah_drab_tabel.arbah_t_amr_dafa, arbah_drab_tabel.arbah_t_date, arbah_drab_tabel.tot_tot_arbah_t, " &
            "nwaya_drab_tabel.nwaya_total, nwaya_drab_tabel.nwaya_amr_dafa, nwaya_drab_tabel.nwaya_date, nwaya_drab_tabel.tot_tot_nwaya, " &
            "kema_mdfa_drab_tabel.kema_mdfa_total, kema_mdfa_drab_tabel.kema_mdfa_amr_dafa, kema_mdfa_drab_tabel.kema_mdfa_date, kema_mdfa_drab_tabel.tot_tot_kema_mdfa " &
            "FROM ((((((add_new_drab_tabel " &
            "LEFT JOIN arbah_drab_tabel ON add_new_drab_tabel.shatb_number = arbah_drab_tabel.shatb_number) " &
            "LEFT JOIN damgha_drab_tabel ON add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number) " &
            "LEFT JOIN kasb_drab_tabel ON add_new_drab_tabel.shatb_number = kasb_drab_tabel.shatb_number) " &
            "LEFT JOIN kema_mdfa_drab_tabel ON add_new_drab_tabel.shatb_number = kema_mdfa_drab_tabel.shatb_number) " &
            "LEFT JOIN nwaya_drab_tabel ON add_new_drab_tabel.shatb_number = nwaya_drab_tabel.shatb_number) " &
            "LEFT JOIN tanmea_drab_tabel ON add_new_drab_tabel.shatb_number = tanmea_drab_tabel.shatb_number) " &
            "WHERE add_new_drab_tabel.num_rec = " & num_rec

        da = New OleDbDataAdapter(query1, con)
        da2 = New OleDbDataAdapter(query2, con)

        da.Fill(dt_select_drab_all_total)
        da2.Fill(dt_select_drab_all_total2)

        If dt_select_drab_all_total2.Rows.Count > 0 Then
            DataGridView2.DataSource = dt_select_drab_all_total2
        Else
            DataGridView2.DataSource = Nothing
        End If

        dgv.DataSource = dt_select_drab_all_total
    End Sub



    '===========
    Public dt_select_drab_all_totaltot As New DataTable

    Public Sub SelectAll_add_drab_total_tot(dgv As DataGridView, ByVal date1 As DateTime)
        'Dim da As New OleDbDataAdapter
        dt_select_drab_all_totaltot.Clear()

        'da = New OleDbDataAdapter("SELECT num_rec, shatb_no,Sum(kasb) AS tot_tot_kasb,Sum(damgha_total) AS tot_tot_damgha,Sum(arbah_t_total) AS tot_tot_arbah_t,Sum(nwaya_total) AS tot_tot_nwaya,Sum(tanmea_total) AS tot_tot_tanmea,Sum(kema_mdfa_total) AS tot_tot_kema_mdfa FROM add_drab WHERE num_rec >0 and  date_drab >= @date1 GROUP BY num_rec, shatb_no", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT num_rec, shatb_no,Sum(kasb) AS tot_tot_kasb,Sum(damgha_total) AS tot_tot_damgha,Sum(arbah_t_total) AS tot_tot_arbah_t,Sum(nwaya_total) AS tot_tot_nwaya,Sum(tanmea_total) AS tot_tot_tanmea,Sum(kema_mdfa_total) AS tot_tot_kema_mdfa FROM add_drab WHERE num_rec >0 and  date_drab >= @date1 GROUP BY num_rec, shatb_no", con)
        'da.Fill(dt_select_drab_all_totaltot)
        'dgv.DataSource = dt_select_drab_all_totaltot
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_drab_all_totaltot.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_drab_all_totaltot
    End Sub
    '=======================
    Public dt_select_drab_all_totaltot2 As New DataTable

    Public Sub SelectAll_add_drab_total_tot2(dgv As DataGridView, ByVal date1 As DateTime)
        'Dim da As New OleDbDataAdapter
        dt_select_drab_all_totaltot2.Clear()

        'da = New OleDbDataAdapter("SELECT num_rec, shatb_no,Sum(kasb) AS tot_tot_kasb,Sum(damgha_total) AS tot_tot_damgha,Sum(arbah_t_total) AS tot_tot_arbah_t,Sum(nwaya_total) AS tot_tot_nwaya,Sum(tanmea_total) AS tot_tot_tanmea,Sum(kema_mdfa_total) AS tot_tot_kema_mdfa FROM add_drab WHERE num_rec >0 and  date_drab >= @date1 GROUP BY num_rec, shatb_no", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT num_rec, shatb_no,Sum(kasb) AS tot_tot_kasb,Sum(damgha_total) AS tot_tot_damgha,Sum(arbah_t_total) AS tot_tot_arbah_t,Sum(nwaya_total) AS tot_tot_nwaya,Sum(tanmea_total) AS tot_tot_tanmea,Sum(kema_mdfa_total) AS tot_tot_kema_mdfa FROM add_new_drab_tabel,kasb_drab_tabel,damgha_drab_tabel,arbah_drab_tabel,nwaya_drab_tabel,tanmea_drab_tabel,kema_mdfa_drab_tabel WHERE num_rec >0 and  date_drab >= @date1 GROUP BY num_rec, shatb_no", con)
        'da.Fill(dt_select_drab_all_totaltot)
        'dgv.DataSource = dt_select_drab_all_totaltot
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_drab_all_totaltot2.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_drab_all_totaltot2
    End Sub


    '===================
    Public Sub sum_totoal()

        Dim tota_sff As Double = 0

        Dim kasb_tot, damgha_tot, arbah_tot, nyea_tot, tanmea_tot, kema_m_tot As String

        kasb_tot = kasb_tot_txt.Text
        damgha_tot = damgha_tot_txt.Text
        arbah_tot = arbah_tot_txt.Text
        nyea_tot = nyea_tot_txt.Text
        tanmea_tot = tanmea_tot_txt.Text
        kema_m_tot = kema_m_tot_txt.Text

        If kasb_tot = vbNullString Then
            kasb_tot = "0"
        End If
        If damgha_tot = vbNullString Then
            damgha_tot = "0"
        End If
        If arbah_tot = vbNullString Then
            arbah_tot = "0"
        End If
        If nyea_tot = vbNullString Then
            nyea_tot = "0"
        End If
        If tanmea_tot = vbNullString Then
            tanmea_tot = "0"
        End If
        If kema_m_tot = vbNullString Then
            kema_m_tot = "0"
        End If



        tota_sff = Convert.ToDouble(kasb_tot) + Convert.ToDouble(damgha_tot) + Convert.ToDouble(arbah_tot) + Convert.ToDouble(nyea_tot) + Convert.ToDouble(tanmea_tot) + Convert.ToDouble(kema_m_tot)
        total_drab.Text = tota_sff.ToString()
    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles new_rec_buttm.Click
        clear_contral()

        Dim date_new As Date
        Dim monthh As Integer
        Dim yearss As Integer
        date_new = date_drab.Value
        monthh = date_new.Month
        yearss = date_new.Year
        Dim date_string As String
        date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
        date_new = FormatDateTime(date_string)
        'MessageBox.Show(date_new.ToString())
        SelectAll_add_drab2(dgv_add_drab, date_new)
        dgv_add_drab.DataSource = dt_select_drab_all2
        SelectAll_add_drab_total_tot(DataGridView1, date_new)
        id_m_d.Text = (Max_Table_drab2() + 1).ToString()
        num_rec.Text = (Max_rec_drab2() + 1).ToString()

        BtnNewAdd.Visible = True
        sum_totoal()
        BtnNewAdd.Enabled = True
    End Sub

    Private Sub add_darab_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date_drab.Value = Now
        shatb_number_txt.Focus()
        If Cmbx_shatb.Text = "اول ذاتى" Or Cmbx_shatb.Text = "ثانى ذاتى" Then
            ComboBox1.Text = "صناديق"
        Else

            ComboBox1.Text = "ميزانية"
        End If
        Dim date_new As Date
        Dim monthh As Integer
        Dim yearss As Integer
        date_new = date_drab.Value
        monthh = date_new.Month
        yearss = date_new.Year

        TextBox14.Text = "ضرائب كسب شهر " + monthh.ToString() + " - " + yearss.ToString()
        TextBox12.Text = "ضرائب دمغه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox9.Text = "ارباح تجارية شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox6.Text = "الدمغه النوعيه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox5.Text = "ضرائب رسم تنميه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox4.Text = "القيمة المضافة 20% " + monthh.ToString() + " - " + yearss.ToString()

    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        check_data()

        If shatb_number_txt.Text.Trim = "" Then
            MessageBox.Show("يجب ادخال رقم الشطب")


        ElseIf num_ked_txt.Text.Trim = "" Then
            MessageBox.Show("يجب ادخال رقم القيد")

        ElseIf msg_lbl.Text = "يجب التحقق من الباب الموازنى " Then
            MessageBox.Show("يجب التحقق من الباب الموازنى ")
        Else
            Dim shatb As String
            shatb = shatb_number_txt.Text + ComboBox1.Text

            add_new_drab_tabel(Convert.ToInt32(id_m_d.Text), Convert.ToInt32(num_rec.Text), Cmbx_shatb.Text, Convert.ToInt32(num_ked_txt.Text), shatb, date_drab.Value.Date, Convert.ToDouble(total_drab.Text))
            'If Convert.ToDouble(kasb_tot_txt.Text) > 0 Then
            Insert_kasb_drab_tabel(shatb, Convert.ToDouble(kasb_tot_txt.Text), kasb_amr_dafa_txt.Text, date_kasb.Text, Convert.ToDouble(kasb_tot_txt.Text), Convert.ToInt32(num_rec.Text))

            'End If

            'If Convert.ToDouble(damgha_tot_txt.Text) > 0 Then
            Insert_damgha_drab_tabel(shatb, Convert.ToDouble(damgha_tot_txt.Text), damgha_amr_dafa_txt.Text, Date_damgha.Text, Convert.ToDouble(damgha_tot_txt.Text), Convert.ToInt32(num_rec.Text))

            'End If
            'If Convert.ToDouble(arbah_tot_txt.Text) > 0 Then
            Insert_arbah_drab_tabel(shatb, Convert.ToDouble(arbah_tot_txt.Text), arbah_amr_dafa_txt.Text, Date_arbah.Text, Convert.ToDouble(arbah_tot_txt.Text), Convert.ToInt32(num_rec.Text))

            'End If
            'If Convert.ToDouble(nyea_tot_txt.Text) > 0 Then
            Insert_nwaya_drab_tabel(shatb, Convert.ToDouble(nyea_tot_txt.Text), nyea_amr_dafa_txt.Text, Date_nyea.Text, Convert.ToDouble(nyea_tot_txt.Text), Convert.ToInt32(num_rec.Text))

            'End If
            'If Convert.ToDouble(tanmea_tot_txt.Text) > 0 Then
            Insert_tanmea_drab_tabel(shatb, Convert.ToDouble(tanmea_tot_txt.Text), tanmea_amr_dafa_txt.Text, Date_tanmea.Text, Convert.ToDouble(tanmea_tot_txt.Text), Convert.ToInt32(num_rec.Text))

            'End If
            'If Convert.ToDouble(kema_m_tot_txt.Text) > 0 Then
            Insert_kema_mdfa_drab_tabel(shatb, Convert.ToDouble(kema_m_tot_txt.Text), kema_m_amr_dafa_txt.Text, Date_kema.Text, Convert.ToDouble(kema_m_tot_txt.Text), Convert.ToInt32(num_rec.Text))

            'End If



            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            id_m_d.Text = (Max_Table_drab2() + 1).ToString()
            Dim date_new As Date
            Dim monthh As Integer
            Dim yearss As Integer
            date_new = date_drab.Value
            monthh = date_new.Month
            yearss = date_new.Year
            Dim date_string As String
            date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
            date_new = FormatDateTime(date_string)

            SelectAll_add_drab2(dgv_add_drab, date_new)

            clear_contral()
            sum_totoal()
            shatb_number_txt.Focus()


        End If

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Insert_add_drab(1, 1, "Test", 1, 1, 1.0, "A", Now, 1.0, "B", Now, 1.0, "C", Now,
    '            1.0, "D", Now, 1.0, "E", Now, 1.0, "F", Now,
    '            1.0, 1.0, 1.0, 1.0, 1.0, 1.0, 2 / 2 / 2025, 2)

    'End Sub



    Private Sub kasb_tot_txt_Leave(sender As Object, e As EventArgs) Handles tanmea_tot_txt.Leave, nyea_tot_txt.Leave, kema_m_tot_txt.Leave, kasb_tot_txt.Leave, damgha_tot_txt.Leave, arbah_tot_txt.Leave
        sum_totoal()
    End Sub


    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles dgv_add_drab.Click
        'Try
        clear_contral()
        With dgv_add_drab
            Me.id_m_d.Text = .CurrentRow.Cells("id_drab").Value.ToString()
            Me.num_rec.Text = .CurrentRow.Cells("Column29").Value.ToString()
            Me.Cmbx_shatb.Text = .CurrentRow.Cells("shatb_no").Value.ToString()
            Me.shatb_number_txt.Text = .CurrentRow.Cells("shatb_number").Value.ToString()
            Me.num_ked_txt.Text = .CurrentRow.Cells("num_ked").Value.ToString()
            Me.kasb_tot_txt.Text = .CurrentRow.Cells("kasb").Value.ToString()
            Me.kasb_amr_dafa_txt.Text = .CurrentRow.Cells("kasb_amr_dafa").Value.ToString()
            Me.date_kasb.Text = .CurrentRow.Cells("kasb_date").Value.ToString()
            Me.damgha_tot_txt.Text = .CurrentRow.Cells("damgha_total").Value.ToString()
            Me.damgha_amr_dafa_txt.Text = .CurrentRow.Cells("damgha_amr_dafa").Value.ToString()
            Me.Date_damgha.Text = .CurrentRow.Cells("damgha_date").Value.ToString()
            Me.arbah_tot_txt.Text = .CurrentRow.Cells("arbah_t_total").Value.ToString()

            Me.arbah_amr_dafa_txt.Text = .CurrentRow.Cells("arbah_t_amr_dafa").Value.ToString()
            Me.Date_arbah.Text = .CurrentRow.Cells("arbah_t_date").Value.ToString()
            Me.nyea_tot_txt.Text = .CurrentRow.Cells("nwaya_total").Value.ToString()
            Me.nyea_amr_dafa_txt.Text = .CurrentRow.Cells("nwaya_amr_dafa").Value.ToString()
            Me.Date_nyea.Text = .CurrentRow.Cells("nwaya_date").Value.ToString()

            Me.tanmea_tot_txt.Text = .CurrentRow.Cells("tanmea_total").Value.ToString()
            Me.tanmea_amr_dafa_txt.Text = .CurrentRow.Cells("tanmea_amr_dafa").Value.ToString()
            Me.Date_tanmea.Text = .CurrentRow.Cells("tanmea_date").Value.ToString()

            Me.kema_m_tot_txt.Text = .CurrentRow.Cells("kema_mdfa_total").Value.ToString()
            Me.kema_m_amr_dafa_txt.Text = .CurrentRow.Cells("kema_mdfa_amr_dafa").Value.ToString()
            Me.Date_kema.Text = .CurrentRow.Cells("kema_mdfa_date").Value.ToString()

            Me.date_drab.Value = .CurrentRow.Cells("date_drab2").Value.ToString()
            Me.total_drab.Text = .CurrentRow.Cells("total_drab2").Value.ToString()
            Me.rec_num_all_txt.Text = .CurrentRow.Cells("Column29").Value.ToString()

        End With
        BtnNewAdd.Enabled = False
        BtnEdit.Enabled = True
        sum_totoal()
        BtnDelete.Enabled = True

        stat_edit = 1
        DataGridView2.AutoGenerateColumns = False
        SelectAll_add_drab_total(DataGridView1, Convert.ToInt32(rec_num_all_txt.Text))
        'SelectAll_add_drab_total_tot2(DataGridView1, Convert.ToInt32(rec_num_all_txt.Text))
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        close_date_amr_dafa()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SelectAll_add_drab_total(DataGridView1, Convert.ToInt32(rec_num_all_txt.Text))
        With DataGridView2


            Me.kasb_amr_dafa_txt.Text = .CurrentRow.Cells("kasb_amr_dafa").Value.ToString()
            Me.date_kasb.Text = .CurrentRow.Cells("kasb_date").Value.ToString()

            Me.damgha_amr_dafa_txt.Text = .CurrentRow.Cells("damgha_amr_dafa").Value.ToString()
            Me.Date_damgha.Text = .CurrentRow.Cells("damgha_date").Value.ToString()


            Me.arbah_amr_dafa_txt.Text = .CurrentRow.Cells("arbah_t_amr_dafa").Value.ToString()
            Me.Date_arbah.Text = .CurrentRow.Cells("arbah_t_date").Value.ToString()

            Me.nyea_amr_dafa_txt.Text = .CurrentRow.Cells("nwaya_amr_dafa").Value.ToString()
            Me.Date_nyea.Text = .CurrentRow.Cells("nwaya_date").Value.ToString()

            Me.tanmea_amr_dafa_txt.Text = .CurrentRow.Cells("tanmea_amr_dafa").Value.ToString()
            Me.Date_tanmea.Text = .CurrentRow.Cells("tanmea_date").Value.ToString()


            Me.kema_m_amr_dafa_txt.Text = .CurrentRow.Cells("kema_mdfa_amr_dafa").Value.ToString()
            Me.Date_kema.Text = .CurrentRow.Cells("kema_mdfa_date").Value.ToString()

            stat_edit = 2



        End With

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        check_data()
        'Public Sub Update_add_drab(ByVal kasb_amr_dafa As String, ByVal kasb_date As String, ByVal damgha_amr_dafa As String, ByVal damgha_date As String, ByVal arbah_t_amr_dafa As String, ByVal arbah_t_date As String, ByVal nwaya_amr_dafa As String, ByVal nwaya_date As String, ByVal tanmea_amr_dafa As String, ByVal tanmea_date As String, ByVal kema_mdfa_amr_dafa As String, ByVal kema_mdfa_date As String, ByVal tot_tot_kasb As Double, ByVal tot_tot_damgha As Double, ByVal tot_tot_arbah_t As Double, ByVal tot_tot_nwaya As Double, ByVal tot_tot_tanmea As Double, ByVal tot_tot_kema_mdfa As Double, ByVal num_rec As Integer)
        If stat_edit = 2 Then


            'Update_add_drab2(kasb_amr_dafa_txt.Text, date_kasb.Text, damgha_amr_dafa_txt.Text, Date_damgha.Text, arbah_amr_dafa_txt.Text, Date_arbah.Text, nyea_amr_dafa_txt.Text, Date_nyea.Text, tanmea_amr_dafa_txt.Text, Date_tanmea.Text, kema_m_amr_dafa_txt.Text, Date_kema.Text, Convert.ToDouble(kasb_tot_txt.Text), Convert.ToDouble(damgha_tot_txt.Text), Convert.ToDouble(arbah_tot_txt.Text), Convert.ToDouble(nyea_tot_txt.Text), Convert.ToDouble(tanmea_tot_txt.Text), Convert.ToDouble(kema_m_tot_txt.Text), Convert.ToInt32(rec_num_all_txt.Text))
            'If Convert.ToDouble(kasb_tot_txt.Text) > 0 Then
            Update_total_kasb_drab_tabel(kasb_amr_dafa_txt.Text, date_kasb.Text, Convert.ToDouble(kasb_tot_txt.Text), Convert.ToInt32(num_rec.Text))
            'End If
            'If Convert.ToDouble(damgha_tot_txt.Text) > 0 Then
            Update_total_damgha_drab_tabel(damgha_amr_dafa_txt.Text, Date_damgha.Text, Convert.ToDouble(damgha_tot_txt.Text), Convert.ToInt32(num_rec.Text))
            'End If

            'If Convert.ToDouble(arbah_tot_txt.Text) > 0 Then
            Update_total_arbah_drab_tabel(arbah_amr_dafa_txt.Text, Date_arbah.Text, Convert.ToDouble(arbah_tot_txt.Text), Convert.ToInt32(num_rec.Text))
            'End If
            'If Convert.ToDouble(nyea_tot_txt.Text) > 0 Then
            Update_total_nwaya_drab_tabel(nyea_amr_dafa_txt.Text, Date_nyea.Text, Convert.ToDouble(nyea_tot_txt.Text), Convert.ToInt32(num_rec.Text))
            'End If
            'If Convert.ToDouble(tanmea_tot_txt.Text) > 0 Then
            Update_total_tanmea_drab_tabel(tanmea_amr_dafa_txt.Text, Date_tanmea.Text, Convert.ToDouble(tanmea_tot_txt.Text), Convert.ToInt32(num_rec.Text))
            'End If
            'If Convert.ToDouble(kema_m_tot_txt.Text) > 0 Then
            Update_total_kema_mdfa_drab_tabel(kema_m_amr_dafa_txt.Text, Date_kema.Text, Convert.ToDouble(kema_m_tot_txt.Text), Convert.ToInt32(num_rec.Text))
            'End If


            MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")




            clear_contral()
            BtnNewAdd.Enabled = True
            id_m_d.Text = (Max_Table_drab2() + 1).ToString()
            Dim date_new As Date
            Dim monthh As Integer
            Dim yearss As Integer
            date_new = date_drab.Value
            monthh = date_new.Month
            yearss = date_new.Year
            Dim date_string As String
            date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
            date_new = FormatDateTime(date_string)

            SelectAll_add_drab2(dgv_add_drab, date_new)
            clear_contral()
            sum_totoal()
            stat_edit = 3
       



        ElseIf stat_edit = 1 Then

            Update_add_new_drab_tabel(Convert.ToInt32(num_rec.Text), Cmbx_shatb.Text, Convert.ToInt32(num_ked_txt.Text), shatb_number_txt.Text, date_drab.Value.Date, Convert.ToDouble(total_drab.Text), Convert.ToInt32(id_m_d.Text))
            Update_kasb_drab_tabel(shatb_number_txt.Text, Convert.ToDouble(kasb_tot_txt.Text), kasb_amr_dafa_txt.Text, date_kasb.Text, Convert.ToInt32(num_rec.Text), shatb_number_txt.Text)
            'End If
            'If Convert.ToDouble(damgha_tot_txt.Text) > 0 Then
            Update_damgha_drab_tabel(shatb_number_txt.Text, Convert.ToDouble(damgha_tot_txt.Text), damgha_amr_dafa_txt.Text, Date_damgha.Text, Convert.ToInt32(num_rec.Text), shatb_number_txt.Text)
            'End If
            'If Convert.ToDouble(arbah_tot_txt.Text) > 0 Then
            Update_arbah_drab_tabel(shatb_number_txt.Text, Convert.ToDouble(arbah_tot_txt.Text), arbah_amr_dafa_txt.Text, Date_arbah.Text, Convert.ToInt32(num_rec.Text), shatb_number_txt.Text)
            'End If
            'If Convert.ToDouble(nyea_tot_txt.Text) > 0 Then
            Update_nwaya_drab_tabel(shatb_number_txt.Text, Convert.ToDouble(nyea_tot_txt.Text), nyea_amr_dafa_txt.Text, Date_nyea.Text, Convert.ToInt32(num_rec.Text), shatb_number_txt.Text)
            'End If
            'If Convert.ToDouble(tanmea_tot_txt.Text) > 0 Then
            Update_tanmea_drab_tabel(shatb_number_txt.Text, Convert.ToDouble(tanmea_tot_txt.Text), tanmea_amr_dafa_txt.Text, Date_tanmea.Text, Convert.ToInt32(num_rec.Text), shatb_number_txt.Text)
            'End If
            'If Convert.ToDouble(kema_m_tot_txt.Text) > 0 Then
            Update_kema_mdfa_drab_tabel(shatb_number_txt.Text, Convert.ToDouble(kema_m_tot_txt.Text), kema_m_amr_dafa_txt.Text, Date_kema.Text, Convert.ToInt32(num_rec.Text), shatb_number_txt.Text)
            'End If


            MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
            clear_contral()
            BtnNewAdd.Enabled = True
            id_m_d.Text = (Max_Table_drab2() + 1).ToString()
            Dim date_new As Date
            Dim monthh As Integer
            Dim yearss As Integer
            date_new = date_drab.Value
            monthh = date_new.Month
            yearss = date_new.Year
            Dim date_string As String
            date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
            date_new = FormatDateTime(date_string)

            SelectAll_add_drab2(dgv_add_drab, date_new)
            clear_contral()
            sum_totoal()
            stat_edit = 3

        End If
    End Sub



    Private Sub DataGridView1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles DataGridView1.Click
        Try
            clear_contral2()

            BtnDelete.Enabled = False
            With DataGridView1

                Me.rec_num_all_txt.Text = .CurrentRow.Cells("num_rec2").Value.ToString()

                Me.num_rec.Text = .CurrentRow.Cells("num_rec2").Value.ToString()
                Me.kasb_tot_txt.Text = .CurrentRow.Cells("tot_tot_kasb2").Value.ToString()
                Me.damgha_tot_txt.Text = .CurrentRow.Cells("tot_tot_damgha2").Value.ToString()
                Me.arbah_tot_txt.Text = .CurrentRow.Cells("tot_tot_arbah_t2").Value.ToString()



                Me.nyea_tot_txt.Text = .CurrentRow.Cells("tot_tot_nwaya2").Value.ToString()
                Me.tanmea_tot_txt.Text = .CurrentRow.Cells("tot_tot_tanmea2").Value.ToString()
                Me.kema_m_tot_txt.Text = .CurrentRow.Cells("tot_tot_kema_mdfa2").Value.ToString()

                'Me.kasb_amr_dafa_txt.Text = .CurrentRow.Cells("kasb_amr_dafa2").Value.ToString()
                'Me.date_kasb.Text = .CurrentRow.Cells("kasb_date2").Value.ToString()

                'Me.damgha_amr_dafa_txt.Text = .CurrentRow.Cells("damgha_amr_dafa2").Value.ToString()
                'Me.Date_damgha.Text = .CurrentRow.Cells("damgha_date2").Value.ToString()


                'Me.arbah_amr_dafa_txt.Text = .CurrentRow.Cells("arbah_t_amr_dafa2").Value.ToString()
                'Me.Date_arbah.Text = .CurrentRow.Cells("arbah_t_date2").Value.ToString()

                'Me.nyea_amr_dafa_txt.Text = .CurrentRow.Cells("nwaya_amr_dafa2").Value.ToString()
                'Me.Date_nyea.Text = .CurrentRow.Cells("nwaya_date2").Value.ToString()

                'Me.tanmea_amr_dafa_txt.Text = .CurrentRow.Cells("tanmea_amr_dafa2").Value.ToString()
                'Me.Date_tanmea.Text = .CurrentRow.Cells("tanmea_date2").Value.ToString()


                'Me.kema_m_amr_dafa_txt.Text = .CurrentRow.Cells("kema_mdfa_amr_dafa2").Value.ToString()
                'Me.Date_kema.Text = .CurrentRow.Cells("kema_mdfa_date2").Value.ToString()

                stat_edit = 2



            End With


            BtnEdit.Enabled = True
            BtnNewAdd.Enabled = False

            sum_totoal()
            open_date_amr_dafa()
            '===========================================
            'SelectAll_add_drab_total(dgv_add_drab, Convert.ToInt32(rec_num_all_txt.Text))
            'With dgv_add_drab


            '    Me.kasb_amr_dafa_txt.Text = .CurrentRow.Cells("kasb_amr_dafa").Value.ToString()
            '    Me.date_kasb.Text = .CurrentRow.Cells("kasb_date").Value.ToString()

            '    Me.damgha_amr_dafa_txt.Text = .CurrentRow.Cells("damgha_amr_dafa").Value.ToString()
            '    Me.Date_damgha.Text = .CurrentRow.Cells("damgha_date").Value.ToString()


            '    Me.arbah_amr_dafa_txt.Text = .CurrentRow.Cells("arbah_t_amr_dafa").Value.ToString()
            '    Me.Date_arbah.Text = .CurrentRow.Cells("arbah_t_date").Value.ToString()

            '    Me.nyea_amr_dafa_txt.Text = .CurrentRow.Cells("nwaya_amr_dafa").Value.ToString()
            '    Me.Date_nyea.Text = .CurrentRow.Cells("nwaya_date").Value.ToString()

            '    Me.tanmea_amr_dafa_txt.Text = .CurrentRow.Cells("tanmea_amr_dafa").Value.ToString()
            '    Me.Date_tanmea.Text = .CurrentRow.Cells("tanmea_date").Value.ToString()


            '    Me.kema_m_amr_dafa_txt.Text = .CurrentRow.Cells("kema_mdfa_amr_dafa").Value.ToString()
            '    Me.Date_kema.Text = .CurrentRow.Cells("kema_mdfa_date").Value.ToString()

            '    stat_edit = 2



            'End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_add_drab(dgv_add_drab)
            Dim date_new As Date
            Dim monthh As Integer
            Dim yearss As Integer
            date_new = date_drab.Value
            monthh = date_new.Month
            yearss = date_new.Year
            Dim date_string As String
            date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
            date_new = FormatDateTime(date_string)

            SelectAll_add_drab2(dgv_add_drab, date_new)
            id_m_d.Text = (Max_Table_drab2() + 1).ToString()
            clear_contral()
            sum_totoal()
            BtnDelete.Enabled = False
        End If



    End Sub


    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        close_all()
        drab_print_frm.Icon = Form1.Icon
        drab_print_frm.MdiParent = Form1


        drab_print_frm.Show()
    End Sub

    Private Sub kasb_tot_txt_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tanmea_tot_txt.TextChanged, nyea_tot_txt.TextChanged, kema_m_tot_txt.TextChanged, kasb_tot_txt.TextChanged, damgha_tot_txt.TextChanged, arbah_tot_txt.TextChanged
        sum_totoal()
    End Sub

    Private Sub kasb_tot_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles kasb_tot_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            damgha_tot_txt.Focus()
            damgha_tot_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            shatb_number_txt.Focus()
            shatb_number_txt.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Left Then
            kasb_amr_dafa_txt.Focus()
            kasb_amr_dafa_txt.BackColor = Color.Gold
        End If
    End Sub

    Private Sub damgha_tot_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles damgha_tot_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            arbah_tot_txt.Focus()
            arbah_tot_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            kasb_tot_txt.Focus()
            kasb_tot_txt.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Left Then
            damgha_amr_dafa_txt.Focus()
            damgha_amr_dafa_txt.BackColor = Color.Gold
        End If
    End Sub

    Private Sub arbah_tot_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles arbah_tot_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            nyea_tot_txt.Focus()
            nyea_tot_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            damgha_tot_txt.Focus()
            damgha_tot_txt.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Left Then
            arbah_amr_dafa_txt.Focus()
            arbah_amr_dafa_txt.BackColor = Color.Gold
        End If
    End Sub

    Private Sub nyea_tot_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles nyea_tot_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            tanmea_tot_txt.Focus()
            tanmea_tot_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            arbah_tot_txt.Focus()
            arbah_tot_txt.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Left Then
            nyea_amr_dafa_txt.Focus()
            nyea_amr_dafa_txt.BackColor = Color.Gold
        End If
    End Sub

    Private Sub kema_m_tot_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles kema_m_tot_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            kasb_tot_txt.Focus()
            kasb_tot_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            tanmea_tot_txt.Focus()
            tanmea_tot_txt.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Left Then
            kema_m_amr_dafa_txt.Focus()
            kema_m_amr_dafa_txt.BackColor = Color.Gold
        End If
    End Sub

    Private Sub kasb_amr_dafa_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles kasb_amr_dafa_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            damgha_amr_dafa_txt.Focus()
            damgha_amr_dafa_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            shatb_number_txt.Focus()
            shatb_number_txt.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Left Then
            date_kasb.Focus()
            date_kasb.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Try
            Dim dv As DataView = dt_select_drab_all2.DefaultView
            If shatb_num_txt.TextLength > 0 Then

                dv.RowFilter = " shatb_number=" & shatb_num_txt.Text & " "
            ElseIf ked_num_txt.TextLength > 0 Then

                dv.RowFilter = " num_ked=" & ked_num_txt.Text & " "
                'ElseIf cmb_shatb_no.SelectionLength > 0 Then
                '    dv.RowFilter = " shatb_no LIKE '%" & cmb_shatb_no.Text & "%' "
            ElseIf rec_num_txt.TextLength > 0 Then
                dv.RowFilter = " num_rec=" & rec_num_txt.Text & " "
            ElseIf cmb_shatb_no.Items.Count > 0 Then
                dv.RowFilter = " shatb_no LIKE '%" & cmb_shatb_no.Text & "%' "

            ElseIf shatb_num_txt.TextLength > 0 And ked_num_txt.TextLength > 0 Then
                MessageBox.Show("يجيب اختيار طريقة واحده للبحث")

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTN_ADD.Click
        Try


            If TextBox1.Text.Length > 0 Then


                ListBox1.Items.Add(Convert.ToDouble(TextBox1.Text))
                TextBox1.Text = ""
                TextBox1.Focus()

            End If
            If ListBox1.Items.Count > 1 Then
                Dim TOTAL As Double = 0
                For index = 0 To ListBox1.Items.Count - 1

                    TOTAL += ListBox1.Items.Item(index)
                    'MessageBox.Show((ListBox1.Items.Item(index)).ToString())

                Next
                TextBox2.Text = TOTAL.ToString()

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BTN_CLEAR_ALL_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTN_CLEAR_ALL.Click
        If ListBox1.Items.Count > 0 Then
            ListBox1.Items.Clear()

            TextBox2.Text = ""


        End If

    End Sub

    Private Sub BTN_CLEAR_ONE_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BTN_CLEAR_ONE.Click
        If ListBox1.Items.Count > 0 Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            TextBox2.Text = ""
            Dim TOTAL As Double = 0
            For index = 0 To ListBox1.Items.Count - 1

                TOTAL += ListBox1.Items.Item(index)
                'MessageBox.Show((ListBox1.Items.Item(index)).ToString())


            Next
            TextBox2.Text = TOTAL.ToString()
        End If
    End Sub

    Private Sub shatb_number_txt_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles shatb_number_txt.Validated
        If shatb_number_txt.TextLength > 0 Then
            Dim shatb As String
            shatb = shatb_number_txt.Text + ComboBox1.Text
            select_shatb(shatb)
            If dt_select_shatb.Rows.Count > 0 Then
                msg_lbl.Text = ""
                MessageBox.Show("رقم الشطب - مسجل من قبل  ...!")
                ErrorProvider1.SetError(shatb_number_txt, " مكرر تاكد من رقم الشطب  !...")
                'isvalaied = False
                msg_lbl.Text = "  تاكد من رقم الشطب مكرر  !..  ..؟"
                shatb_number_txt.Focus()

            End If
        End If


    End Sub

    Private Sub btn_export_all_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_export_all.Click
        btn_export_all.Enabled = False
        btn_export_all.Text = "Wait"
        SaveGridToExcel_all_tfrgh(dgv_add_drab)
        btn_export_all.Text = "تصدير البيانات الى اكسيل"
    End Sub

    Private Sub shatb_number_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles shatb_number_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            num_ked_txt.Focus()
            num_ked_txt.BackColor = Color.Gold
        End If


    End Sub

    Private Sub num_ked_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles num_ked_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            kasb_tot_txt.Focus()
            kasb_tot_txt.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Up Then
            shatb_number_txt.Focus()
            shatb_number_txt.BackColor = Color.Gold
        End If
    End Sub



    Private Sub Button1_Click_2(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        clear_contral()
        open_date_amr_dafa()
        Dim date_new As Date
        Dim monthh As Integer
        Dim yearss As Integer
        date_new = date_drab.Value
        monthh = date_new.Month
        yearss = date_new.Year
        Dim date_string As String
        date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
        date_new = FormatDateTime(date_string)
        MessageBox.Show(date_new.ToString())
        SelectAll_add_drab2(dgv_add_drab, date_new)
        dgv_add_drab.DataSource = dt_select_drab_all2
        'SelectAll_add_drab_total_tot2(DataGridView1, date_new)
        id_m_d.Text = (Max_Table_drab2() + 1).ToString()
        num_rec.Text = (Max_rec_drab2() + 1).ToString()

        BtnNewAdd.Visible = True
        sum_totoal()
        BtnNewAdd.Enabled = True

        TextBox14.Text = "ضرائب كسب شهر " + monthh.ToString() + " - " + yearss.ToString()
        TextBox12.Text = "ضرائب دمغه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox9.Text = "ارباح تجارية شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox6.Text = "الدمغه النوعيه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox5.Text = "ضرائب رسم تنميه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox4.Text = "القيمة المضافة 20% " + monthh.ToString() + " - " + yearss.ToString()
    End Sub

    Private Sub tanmea_tot_txt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles tanmea_tot_txt.KeyDown
        If e.KeyCode = Keys.Down Then
            kema_m_tot_txt.Focus()
            kema_m_tot_txt.BackColor = Color.Gold
        End If

        If e.KeyCode = Keys.Up Then
            nyea_tot_txt.Focus()
            nyea_tot_txt.BackColor = Color.Gold
        End If
        If e.KeyCode = Keys.Left Then
            tanmea_amr_dafa_txt.Focus()
            tanmea_amr_dafa_txt.BackColor = Color.Gold
        End If
    End Sub

    Private Sub Cmbx_shatb_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Cmbx_shatb.SelectedIndexChanged
        If Cmbx_shatb.Text = "اول ذاتى" Or Cmbx_shatb.Text = "ثانى ذاتى" Then
            ComboBox1.Text = "صناديق"

        Else

            ComboBox1.Text = "ميزانية"

        End If

        check_shatb_no(Convert.ToInt32(num_rec.Text))
    End Sub


    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        Dim date_new As Date
        Dim monthh As Integer
        Dim yearss As Integer
        date_new = date_drab.Value
        monthh = date_new.Month
        yearss = date_new.Year
        Dim date_string As String
        date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
        date_new = FormatDateTime(date_string)
        Select_kasb_no_amr(DataGridView3, date_new)
    End Sub

    Private Sub Button5_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        Dim date_new As Date
        Dim monthh As Integer
        Dim yearss As Integer
        date_new = date_drab.Value
        monthh = date_new.Month
        yearss = date_new.Year
        Dim date_string As String
        date_string = "01" + "-" + monthh.ToString() + "-" + yearss.ToString()
        date_new = FormatDateTime(date_string)
        Select_damgha_total_no_amr(DataGridView4, date_new)
    End Sub


    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Tab2.SelectedIndexChanged
        ' تأكد أن المستخدم انتقل إلى التبويب رقم 1 (الفهرس يبدأ من 0)
        If Tab2.SelectedIndex = 1 Then
            Dim date_new As Date = date_drab.Value
            Dim date_string As String = "01-" & date_new.Month.ToString("00") & "-" & date_new.Year.ToString()
            date_new = DateTime.ParseExact(date_string, "dd-MM-yyyy", Globalization.CultureInfo.InvariantCulture)

            ' تنفيذ الإجراء المطلوب عند فتح التبويب الاول
            Select_kasb_no_amr(DataGridView3, date_new)
        ElseIf Tab2.SelectedIndex = 2 Then
            Dim date_new As Date = date_drab.Value
            Dim date_string As String = "01-" & date_new.Month.ToString("00") & "-" & date_new.Year.ToString()
            date_new = DateTime.ParseExact(date_string, "dd-MM-yyyy", Globalization.CultureInfo.InvariantCulture)

            ' تنفيذ الإجراء المطلوب عند فتح التبويب الثاني
            Select_damgha_total_no_amr(DataGridView4, date_new)
        ElseIf Tab2.SelectedIndex = 3 Then

        ElseIf Tab2.SelectedIndex = 4 Then
        ElseIf Tab2.SelectedIndex = 5 Then

        End If
    End Sub



    Private Sub date_drab_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles date_drab.ValueChanged
        Dim date_new As Date
        Dim monthh As Integer
        Dim yearss As Integer
        date_new = date_drab.Value
        monthh = date_new.Month
        yearss = date_new.Year
        TextBox14.Text = "ضرائب كسب شهر " + monthh.ToString() + " - " + yearss.ToString()
        TextBox12.Text = "ضرائب دمغه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox9.Text = "ارباح تجارية شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox6.Text = "الدمغه النوعيه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox5.Text = "ضرائب رسم تنميه شهر  " + monthh.ToString() + " - " + yearss.ToString()
        TextBox4.Text = "القيمة المضافة 20% " + monthh.ToString() + " - " + yearss.ToString()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox14.SelectionStart = 0
        TextBox14.SelectionLength = TextBox14.Text.Length

        Clipboard.SetText(TextBox14.Text)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox12.SelectionStart = 0
        TextBox12.SelectionLength = TextBox12.Text.Length

        Clipboard.SetText(TextBox12.Text)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'TextBox9.SelectionStart = 0
        'TextBox9.SelectionLength = TextBox9.Text.Length

        Clipboard.SetText(TextBox9.Text)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox6.SelectionStart = 0
        TextBox6.SelectionLength = TextBox6.Text.Length

        Clipboard.SetText(TextBox6.Text)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox5.SelectionStart = 0
        TextBox5.SelectionLength = TextBox5.Text.Length

        Clipboard.SetText(TextBox5.Text)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox4.SelectionStart = 0
        TextBox4.SelectionLength = TextBox4.Text.Length

        Clipboard.SetText(TextBox4.Text)
    End Sub

    Private Sub shatb_number_txt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shatb_number_txt.Leave
        check_shatb_no(Convert.ToInt32(num_rec.Text))
    End Sub

   
End Class