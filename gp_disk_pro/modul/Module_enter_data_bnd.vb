Imports System.Data.OleDb
Module Module_enter_data_bnd

    '================================================
    'تحميل datagrid total_bnd
    '==================================
    Public dt_tabel_names_col_total As New DataTable

    Public Sub SelectAll_tabel_names_col_total(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_tabel_names_col_total.Clear()
        da = New OleDbDataAdapter("select * from tabel_names_col_total ORDER BY id_col ", con)

        da.Fill(dt_tabel_names_col_total)
        dgv.DataSource = dt_tabel_names_col_total

        'da.Fill(dt_tabel_names_col_search)
        'dgv.DataSource = dt_tabel_names_col_search

    End Sub
    '================================================
    'تحميل datagrid total_bnd_search
    '==================================
    Public dt_tabel_names_col_search As New DataTable
    Public Sub SelectAll_tabel_names_col_search(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_tabel_names_col_search.Clear()
        da = New OleDbDataAdapter("select * from tabel_names_col_total", con)

        da.Fill(dt_tabel_names_col_search)
        dgv.DataSource = dt_tabel_names_col_search
    End Sub
    '=======================================================

    '=======================================================

    'تحميل المستقطع datagrid_search
    '==================================
    Public dt_tabel_names_mostkta_search As New DataTable
    Public Sub SelectAll_tabel_names_mostkta_search(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_tabel_names_mostkta_search.Clear()
        da = New OleDbDataAdapter("select * from tabel_names_mostkta", con)
        da.Fill(dt_tabel_names_mostkta_search)
        dgv.DataSource = dt_tabel_names_mostkta_search
    End Sub

    '============================================
    'تحميل المستقطع datagrid
    '==================================
    Public dt_tabel_names_mostkta2 As New DataTable
    Public Sub SelectAll_tabel_names_mostkta2(ByVal dgv As DataGridView)
        Dim da As New OleDbDataAdapter
        dt_tabel_names_mostkta2.Clear()
        da = New OleDbDataAdapter("select * from tabel_names_mostkta", con)
        da.Fill(dt_tabel_names_mostkta2)
        dgv.DataSource = dt_tabel_names_mostkta2
    End Sub

    '===============================================
    'max id
    Public Function Max_table_detailes_data_total()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(no_of_kashf) From table_detailes_data_total ", Con)
            If con.State = 1 Then con.Close()
            con.Open()
            Number = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Number = 0
            con.Close()
        End Try
        Return Number
    End Function
    '=======================================
    'update name asthka
    '==================
    Public Sub Update_tabel_names_col_total(ByVal el_mblgh As Double, ByVal id_col As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tabel_names_col_total Set el_mblgh = @el_mblgh Where id_col = @id_col"
            .Parameters.Clear()


            .Parameters.AddWithValue("@el_mblgh", OleDbType.Double).Value = el_mblgh
            .Parameters.AddWithValue("@id_col", OleDbType.Integer).Value = id_col
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    '=====================================================================

    'ط=================================
    Public Sub Update_tabel_names_col_total_to_zero()
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tabel_names_col_total Set el_mblgh = 0 "
            .Parameters.Clear()
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub



    '====================================================================
    'مسح مبالغ كلها
    'ط==================
    'update name asthka
    '==================
    Public Sub Update_and_delete_all_tabel_names_col_total(ByVal el_mblgh As Double)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tabel_names_col_total Set el_mblgh = @el_mblgh "
            .Parameters.Clear()


            .Parameters.AddWithValue("@el_mblgh", OleDbType.Double).Value = el_mblgh

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub

    '===================================================================================
    'مسح مبالغ كلها
    'ط==================
    'update name asthka
    '==================
    Public Sub Update_and_delete_all_tabel_names_mostkta(ByVal elmblgh_mostkta As Double)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tabel_names_mostkta Set elmblgh_mostkta = @elmblgh_mostkta "
            .Parameters.Clear()


            .Parameters.AddWithValue("@elmblgh_mostkta", OleDbType.Double).Value = elmblgh_mostkta

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub


    '========================================
    'inser to bnd
    '===========
    Public Sub Insert_tabel_bnd(ByVal id_bnd As Integer, ByVal no_of_kashf As Integer,
                                ByVal des_bnd As String,
                                ByVal mha_msthka As Double,
                                ByVal agr_wazef As Double,
                                ByVal agr_mkml As Double,
                                ByVal hafz_tayde As Double,
                                ByVal hafez_mkto As Double,
                                ByVal hafez_tkamel As Double,
                                ByVal bdl_akam As Double,
                                ByVal adfya As Double,
                                ByVal agtmai As Double,
                                ByVal mnha As Double,
                                ByVal bdl_nzar As Double,
                                ByVal bdl_tfrgh As Double,
                                ByVal bdl_adwa As Double,
                                ByVal alao_2014 As Double,
                                ByVal alao_2015 As Double,
                                ByVal bdl_moalm As Double,
                                ByVal bdl_etmad As Double,
                                ByVal aba_wzefea As Double,
                                ByVal hafez_ada As Double,
                                ByVal hafz_25 As Double,
                                ByVal mgster As Double,
                                ByVal computer As Double,
                                ByVal doctora As Double,
                                ByVal bnd_adafy_1 As Double,
                                ByVal bnd_adafy_2 As Double,
                                ByVal total_bnd As Double,
                                ByVal bnd_adafy_3 As Double,
                                ByVal bnd_adafy_4 As Double,
                                ByVal bnd_adafy_5 As Double,
                                ByVal bnd_adafy_6 As Double,
                                ByVal bnd_adafy_7 As Double,
                                ByVal bnd_adafy_8 As Double,
                                ByVal bnd_adafy_9 As Double,
                                ByVal bnd_adafy_10 As Double)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into tabel_bnd ( id_bnd,no_of_kashf,des_bnd,mha_msthka,agr_wazef,agr_mkml,hafz_tayde,hafez_mkto,hafez_tkamel,bdl_akam,adfya,agtmai,mnha,bdl_nzar,bdl_tfrgh,bdl_adwa,alao_2014,alao_2015,bdl_moalm,bdl_etmad,aba_wzefea,hafez_ada,hafz_25,mgster,computer,doctora,bnd_adafy_1,bnd_adafy_2,total_bnd,bnd_adafy_3,bnd_adafy_4,bnd_adafy_5,bnd_adafy_6,bnd_adafy_7,bnd_adafy_8,bnd_adafy_9,bnd_adafy_10)values(@id_bnd,@no_of_kashf,@des_bnd,@mha_msthka,@agr_wazef,@agr_mkml,@hafz_tayde,@hafez_mkto,@hafez_tkamel,@bdl_akam,@adfya,@agtmai,@mnha,@bdl_nzar,@bdl_tfrgh,@bdl_adwa,@alao_2014,@alao_2015,@bdl_moalm,@bdl_etmad,@aba_wzefea,@hafez_ada,@hafz_25,@mgster,@computer,@doctora,@bnd_adafy_1,@bnd_adafy_2,@total_bnd,@bnd_adafy_3,@bnd_adafy_4,@bnd_adafy_5,@bnd_adafy_6,@bnd_adafy_7,@bnd_adafy_8,@bnd_adafy_9,@bnd_adafy_10)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = id_bnd
            .Parameters.AddWithValue("@no_of_kashf", OleDbType.Integer).Value = no_of_kashf
            .Parameters.AddWithValue("@des_bnd", OleDbType.VarChar).Value = des_bnd
            .Parameters.AddWithValue("@mha_msthka", OleDbType.Double).Value = mha_msthka
            .Parameters.AddWithValue("@agr_wazef", OleDbType.Double).Value = agr_wazef
            .Parameters.AddWithValue("@agr_mkml", OleDbType.Double).Value = agr_mkml
            .Parameters.AddWithValue("@hafz_tayde", OleDbType.Double).Value = hafz_tayde
            .Parameters.AddWithValue("@hafez_mkto", OleDbType.Double).Value = hafez_mkto

            .Parameters.AddWithValue("@hafez_tkamel", OleDbType.Double).Value = hafez_tkamel

            .Parameters.AddWithValue("@bdl_akam", OleDbType.Double).Value = bdl_akam

            .Parameters.AddWithValue("@adfya", OleDbType.Double).Value = adfya

            .Parameters.AddWithValue("@agtmai", OleDbType.Double).Value = agtmai

            .Parameters.AddWithValue("@mnha", OleDbType.Double).Value = mnha

            .Parameters.AddWithValue("@bdl_nzar", OleDbType.Double).Value = bdl_nzar

            .Parameters.AddWithValue("@bdl_tfrgh", OleDbType.Double).Value = bdl_tfrgh

            .Parameters.AddWithValue("@bdl_adwa", OleDbType.Double).Value = bdl_adwa

            .Parameters.AddWithValue("@alao_2014", OleDbType.Double).Value = alao_2014

            .Parameters.AddWithValue("@alao_2015", OleDbType.Double).Value = alao_2015

            .Parameters.AddWithValue("@bdl_moalm", OleDbType.Double).Value = bdl_moalm

            .Parameters.AddWithValue("@bdl_etmad", OleDbType.Double).Value = bdl_etmad

            .Parameters.AddWithValue("@aba_wzefea", OleDbType.Double).Value = aba_wzefea

            .Parameters.AddWithValue("@hafez_ada", OleDbType.Double).Value = hafez_ada

            .Parameters.AddWithValue("@hafz_25", OleDbType.Double).Value = hafz_25

            .Parameters.AddWithValue("@mgster", OleDbType.Double).Value = mgster

            .Parameters.AddWithValue("@computer", OleDbType.Double).Value = computer

            .Parameters.AddWithValue("@doctora", OleDbType.Double).Value = doctora

            .Parameters.AddWithValue("@bnd_adafy_1", OleDbType.Double).Value = bnd_adafy_1
            .Parameters.AddWithValue("@bnd_adafy_2", OleDbType.Double).Value = bnd_adafy_2
            .Parameters.AddWithValue("@total_bnd", OleDbType.Double).Value = total_bnd
            .Parameters.AddWithValue("@bnd_adafy_3", OleDbType.Double).Value = bnd_adafy_3
            .Parameters.AddWithValue("@bnd_adafy_4", OleDbType.Double).Value = bnd_adafy_4
            .Parameters.AddWithValue("@bnd_adafy_5", OleDbType.Double).Value = bnd_adafy_5
            .Parameters.AddWithValue("@bnd_adafy_6", OleDbType.Double).Value = bnd_adafy_6
            .Parameters.AddWithValue("@bnd_adafy_7", OleDbType.Double).Value = bnd_adafy_7
            .Parameters.AddWithValue("@bnd_adafy_8", OleDbType.Double).Value = bnd_adafy_8
            .Parameters.AddWithValue("@bnd_adafy_9", OleDbType.Double).Value = bnd_adafy_9
            .Parameters.AddWithValue("@bnd_adafy_10", OleDbType.Double).Value = bnd_adafy_10
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '=============================================
    'inset to mostkta
    '================
    '=====================================================================0============================1===================2=======================3==========================4=====================5==========================6=====================7=====================8=====================9=====================10======================11=========================12======================13==========================14=========================15========================16==========================17=======================18==========================19==================20=====================21=======================22=====================23=============================24=========================25=====================26=========================27=========================28====================29===================30===================================31=========================32=======================
    Public Sub Insert_table_bnd_mostkta(ByVal no_of_kashf As Integer, ByVal mashat_9 As Double, ByVal mashat_1 As Double, ByVal m_1 As Double, ByVal nkabt_mhn As Double, ByVal nady As Double, ByVal mostchfa As Double, ByVal tabeka As Double, ByVal s_7 As Double, ByVal lgna As Double, ByVal cndok As Double, ByVal raya_5 As Double, ByVal drab_ksb As Double, ByVal tswa_drab As Double, ByVal ghtoto As Double, ByVal slf_nkba_m As Double, ByVal bnk_naser As Double, ByVal masr_tamen As Double, ByVal zrahen As Double, ByVal mash_ahara As Double, ByVal nfka As Double, ByVal erdat As Double, ByVal atbare As Double, ByVal eskndra As Double, ByVal damgha_adya As Double, ByVal sandok_gzat As Double, ByVal gzat As Double, ByVal mhn_readay As Double, ByVal asnaf_moba As Double, ByVal hafez As Double, ByVal dewn As Double, ByVal total_mostkta_1 As Double, ByVal total_saffy As Double, ByVal id_bnd As Integer, ByVal rabth_talem As Double, ByVal nkba_mhn_tgaryh As Double, ByVal nkba_mhn_agtmea As Double, ByVal tklft_tpa As Double, ByVal erdat_mgls_ghdmat_talem As Double, ByVal krd_hasn_kahra As Double, ByVal krd_hasn_miniy As Double, ByVal orange As Double, ByVal egar_shka As Double, ByVal nkbat_frayh As Double, ByVal bnk_msr_abu_qrqas As Double, ByVal bnk_kahra_miny As Double, ByVal cmn_ktb_hadan As Double, ByVal shark_ltamen As Double, ByVal shark_ltamen_ahly As Double, ByVal cndok_ghadmat_mgls As Double, ByVal shaba_ghash As Double, ByVal gmahed_kanwnen As Double, ByVal rabta_twgeh_alwm As Double, ByVal asr_mntgh_miny As Double, ByVal sednawy As Double, ByVal dman_maly As Double, ByVal bnd_adfy1 As Double, ByVal bnd_adfy2 As Double, ByVal bnd_adafy3 As Double, ByVal bnd_adafy4 As Double, ByVal bnd_adafy5 As Double, ByVal bnd_adafy6 As Double, ByVal bnd_adafy7 As Double, ByVal bnd_adafy8 As Double, ByVal bnd_adafy9 As Double, ByVal bnd_adafy10 As Double)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into table_bnd_mostkta ( no_of_kashf,mashat_9,mashat_1,m_1,nkabt_mhn,nady,mostchfa,tabeka,s_7,lgna,cndok,raya_5,drab_ksb,tswa_drab,ghtoto,slf_nkba_m,bnk_naser,masr_tamen,zrahen,mash_ahara,nfka,erdat,atbare,eskndra,damgha_adya,sandok_gzat,gzat,mhn_readay,asnaf_moba,hafez,dewn,total_mostkta_1,total_saffy,id_bnd,rabth_talem,nkba_mhn_tgaryh,nkba_mhn_agtmea,tklft_tpa,erdat_mgls_ghdmat_talem,krd_hasn_kahra,krd_hasn_miniy,orange,egar_shka,nkbat_frayh,bnk_msr_abu_qrqas,bnk_kahra_miny,cmn_ktb_hadan,shark_ltamen,shark_ltamen_ahly,cndok_ghadmat_mgls,shaba_ghash,gmahed_kanwnen,rabta_twgeh_alwm,asr_mntgh_miny,sednawy,dman_maly,bnd_adfy1,bnd_adfy2,bnd_adafy3,bnd_adafy4,bnd_adafy5,bnd_adafy6,bnd_adafy7,bnd_adafy8,bnd_adafy9,bnd_adafy10)values(@no_of_kashf,@mashat_9,@mashat_1,@m_1,@nkabt_mhn,@nady,@mostchfa,@tabeka,@s_7,@lgna,@cndok,@raya_5,@drab_ksb,@tswa_drab,@ghtoto,@slf_nkba_m,@bnk_naser,@masr_tamen,@zrahen,@mash_ahara,@nfka,@erdat,@atbare,@eskndra,@damgha_adya,@sandok_gzat,@gzat,@mhn_readay,@asnaf_moba,@hafez,@dewn,@total_mostkta_1,@total_saffy,@id_bnd,@rabth_talem,@nkba_mhn_tgaryh,@nkba_mhn_agtmea,@tklft_tpa,@erdat_mgls_ghdmat_talem,@krd_hasn_kahra,@krd_hasn_miniy,@orange,@egar_shka,@nkbat_frayh,@bnk_msr_abu_qrqas,@bnk_kahra_miny,@cmn_ktb_hadan,@shark_ltamen,@shark_ltamen_ahly,@cndok_ghadmat_mgls,@shaba_ghash,@gmahed_kanwnen,@rabta_twgeh_alwm,@asr_mntgh_miny,@sednawy,@dman_maly,@bnd_adfy1,@bnd_adfy2,@bnd_adafy3,@bnd_adafy4,@bnd_adafy5,@bnd_adafy6,@bnd_adafy7,@bnd_adafy8,@bnd_adafy9,@bnd_adafy10)"
            .Parameters.Clear()
            '.Parameters.AddWithValue("@id_bnd_mostkta", OleDbType.Integer).Value = id_bnd_mostkta
            .Parameters.AddWithValue("@no_of_kashf", OleDbType.Integer).Value = no_of_kashf
            .Parameters.AddWithValue("@mashat_9", OleDbType.Double).Value = mashat_9
            .Parameters.AddWithValue("@mashat_1", OleDbType.Double).Value = mashat_1
            .Parameters.AddWithValue("@m_1", OleDbType.Double).Value = m_1
            .Parameters.AddWithValue("@nkabt_mhn", OleDbType.Double).Value = nkabt_mhn

            .Parameters.AddWithValue("@nady", OleDbType.Double).Value = nady

            .Parameters.AddWithValue("@mostchfa", OleDbType.Double).Value = mostchfa

            .Parameters.AddWithValue("@tabeka", OleDbType.Double).Value = tabeka

            .Parameters.AddWithValue("@s_7", OleDbType.Double).Value = s_7
            .Parameters.AddWithValue("@lgna", OleDbType.Double).Value = lgna

            .Parameters.AddWithValue("@cndok", OleDbType.Double).Value = cndok

            .Parameters.AddWithValue("@raya_5", OleDbType.Double).Value = raya_5
            .Parameters.AddWithValue("@drab_ksb", OleDbType.Double).Value = drab_ksb

            .Parameters.AddWithValue("@tswa_drab", OleDbType.Double).Value = tswa_drab

            .Parameters.AddWithValue("@ghtoto", OleDbType.Double).Value = ghtoto

            .Parameters.AddWithValue("@slf_nkba_m", OleDbType.Double).Value = slf_nkba_m

            .Parameters.AddWithValue("@bnk_naser", OleDbType.Double).Value = bnk_naser

            .Parameters.AddWithValue("@masr_tamen", OleDbType.Double).Value = masr_tamen

            .Parameters.AddWithValue("@zrahen", OleDbType.Double).Value = zrahen

            .Parameters.AddWithValue("@mash_ahara", OleDbType.Double).Value = mash_ahara

            .Parameters.AddWithValue("@nfka", OleDbType.Double).Value = nfka

            .Parameters.AddWithValue("@erdat", OleDbType.Double).Value = erdat

            .Parameters.AddWithValue("@atbare", OleDbType.Double).Value = atbare

            .Parameters.AddWithValue("@eskndra", OleDbType.Double).Value = eskndra

            .Parameters.AddWithValue("@damgha_adya", OleDbType.Double).Value = damgha_adya

            .Parameters.AddWithValue("@sandok_gzat", OleDbType.Double).Value = sandok_gzat

            .Parameters.AddWithValue("@gzat", OleDbType.Double).Value = gzat

            .Parameters.AddWithValue("@mhn_readay", OleDbType.Double).Value = mhn_readay

            .Parameters.AddWithValue("@asnaf_moba", OleDbType.Double).Value = asnaf_moba

            .Parameters.AddWithValue("@hafez", OleDbType.Double).Value = hafez

            .Parameters.AddWithValue("@dewn", OleDbType.Double).Value = dewn


            .Parameters.AddWithValue("@total_mostkta_1", OleDbType.Double).Value = total_mostkta_1
            .Parameters.AddWithValue("@total_saffy", OleDbType.Double).Value = total_saffy
            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = id_bnd

            .Parameters.AddWithValue("@rabth_talem", OleDbType.Double).Value = rabth_talem
            .Parameters.AddWithValue("@nkba_mhn_tgaryh", OleDbType.Double).Value = nkba_mhn_tgaryh
            .Parameters.AddWithValue("@nkba_mhn_agtmea", OleDbType.Double).Value = nkba_mhn_agtmea
            .Parameters.AddWithValue("@tklft_tpa", OleDbType.Double).Value = tklft_tpa
            .Parameters.AddWithValue("@erdat_mgls_ghdmat_talem", OleDbType.Double).Value = erdat_mgls_ghdmat_talem
            .Parameters.AddWithValue("@krd_hasn_kahra", OleDbType.Double).Value = krd_hasn_kahra
            .Parameters.AddWithValue("@krd_hasn_miniy", OleDbType.Double).Value = krd_hasn_miniy
            .Parameters.AddWithValue("@orange", OleDbType.Double).Value = orange
            .Parameters.AddWithValue("@egar_shka", OleDbType.Double).Value = egar_shka
            .Parameters.AddWithValue("@nkbat_frayh", OleDbType.Double).Value = nkbat_frayh
            .Parameters.AddWithValue("@bnk_msr_abu_qrqas", OleDbType.Double).Value = bnk_msr_abu_qrqas
            .Parameters.AddWithValue("@bnk_kahra_miny", OleDbType.Double).Value = bnk_kahra_miny
            .Parameters.AddWithValue("@cmn_ktb_hadan", OleDbType.Double).Value = cmn_ktb_hadan
            .Parameters.AddWithValue("@shark_ltamen", OleDbType.Double).Value = shark_ltamen
            .Parameters.AddWithValue("@shark_ltamen_ahly", OleDbType.Double).Value = shark_ltamen_ahly
            .Parameters.AddWithValue("@cndok_ghadmat_mgls", OleDbType.Double).Value = cndok_ghadmat_mgls
            .Parameters.AddWithValue("@shaba_ghash", OleDbType.Double).Value = shaba_ghash
            .Parameters.AddWithValue("@gmahed_kanwnen", OleDbType.Double).Value = gmahed_kanwnen
            .Parameters.AddWithValue("@rabta_twgeh_alwm", OleDbType.Double).Value = rabta_twgeh_alwm
            .Parameters.AddWithValue("@asr_mntgh_miny", OleDbType.Double).Value = asr_mntgh_miny
            .Parameters.AddWithValue("@sednawy", OleDbType.Double).Value = sednawy
            .Parameters.AddWithValue("@dman_maly", OleDbType.Double).Value = dman_maly

            .Parameters.AddWithValue("@bnd_adfy1", OleDbType.Double).Value = bnd_adfy1

            .Parameters.AddWithValue("@bnd_adfy2", OleDbType.Double).Value = bnd_adfy2
            .Parameters.AddWithValue("@bnd_adafy3", OleDbType.Double).Value = bnd_adafy3
            .Parameters.AddWithValue("@bnd_adafy4", OleDbType.Double).Value = bnd_adafy4
            .Parameters.AddWithValue("@bnd_adafy5", OleDbType.Double).Value = bnd_adafy5
            .Parameters.AddWithValue("@bnd_adafy6", OleDbType.Double).Value = bnd_adafy6
            .Parameters.AddWithValue("@bnd_adafy7", OleDbType.Double).Value = bnd_adafy7
            .Parameters.AddWithValue("@bnd_adafy8", OleDbType.Double).Value = bnd_adafy8
            .Parameters.AddWithValue("@bnd_adafy9", OleDbType.Double).Value = bnd_adafy9
            .Parameters.AddWithValue("@bnd_adafy10", OleDbType.Double).Value = bnd_adafy10



        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        Cmd = Nothing
    End Sub

    '========================================
    'select all_bnd_by_no_kshf
    '==============
    Public dt_select_all_bnd_no_kash As New DataTable
    Public Sub SelectSome_selcet_all_bnd(ByVal no_kash As Integer)


        dt_select_all_bnd_no_kash.Clear()
        Dim Cmd As New OleDbCommand("select * from select_all_bnd3 where no_of_kashf = @no_of_kashf", con)

        With Cmd
            .Connection = con
            con.Open()

            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kash
            dt_select_all_bnd_no_kash.Load(Cmd.ExecuteReader)
        End With
        con.Close()
        Cmd = Nothing
    End Sub

    'select sum_all_bnd_by_no_kshf
    '==============
    Public dt_select_all_sum_bnd_no_kash As New DataTable
    Public Sub SelectSome_selcet_all_sum_bnd(ByVal no_kash As Integer)


        dt_select_all_sum_bnd_no_kash.Clear()
        Dim Cmd As New OleDbCommand("select * from total_bnd_sum_all where no_of_kashf = @no_of_kashf", con)

        With Cmd
            .Connection = con
            con.Open()

            .Parameters.Clear()
            .Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kash
            dt_select_all_sum_bnd_no_kash.Load(Cmd.ExecuteReader)
        End With
        con.Close()
        Cmd = Nothing
    End Sub



    'selcet all_bnd_تعريب 
    '====================
    Public Sub DataGridViewHeaderText_all_bnd(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("no_of_kashf").HeaderText = "رقم الكشف"
                '.Columns("date1").HeaderText = "التاريخ"
                .Columns("des_bnd").HeaderText = "الببان /اسم المدرسة"
                .Columns("total_saffy").HeaderText = "الصافى"
                .Columns("total_bnd").HeaderText = "جملة االمستحقات"
                .Columns("total_mostkta_1").HeaderText = "جملة المستقطع"
                .Columns("mha_msthka").HeaderText = "الماهية المستحقة"
             
                .Columns("agr_wazef").HeaderText = "الاجر الوظيف"
                .Columns("agr_mkml").HeaderText = "الاجر المكمل"
                .Columns("hafz_tayde").HeaderText = "الحافز التعويضى"
                .Columns("hafez_mkto").HeaderText = "حافز مقطوع"
                .Columns("hafez_tkamel").HeaderText = "حافز تكميلى "
                .Columns("bdl_akam").HeaderText = "بدل إقامة"
                .Columns("adfya").HeaderText = "إضافية"
                .Columns("agtmai").HeaderText = "اجتماعية"
                .Columns("mnha").HeaderText = "منحة"
                .Columns("bdl_nzar").HeaderText = "بدل نظارة"
                .Columns("bdl_tfrgh").HeaderText = "بدل تفرغ"
                .Columns("bdl_adwa").HeaderText = "بدل عدوى"
                .Columns("alao_2014").HeaderText = "علاوة2014"
                .Columns("alao_2015").HeaderText = "علاوة2015"
                .Columns("bdl_moalm").HeaderText = "بدل معلم"
                .Columns("bdl_etmad").HeaderText = "بدل اعتماد"
                .Columns("aba_wzefea").HeaderText = "أعباء وظيفية"
                .Columns("hafez_ada").HeaderText = "حافز أداء"
                .Columns("hafz_25").HeaderText = "حافز 25%"
                .Columns("mgster").HeaderText = "ماجستير"
                .Columns("computer").HeaderText = "كومبيوتر"
                .Columns("doctora").HeaderText = "دكتوراة"
                .Columns("bnd_adafy_1").HeaderText = "بند اضافى 1"
                .Columns("bnd_adafy_2").HeaderText = "بند اضافى 2"
                .Columns("mashat_9").HeaderText = "9%"
                .Columns("mashat_1").HeaderText = "1%"
                .Columns("m_1").HeaderText = "1%"
                .Columns("nkabt_mhn").HeaderText = "نقابة مهن"
                .Columns("nady").HeaderText = "نادى "
                .Columns("mostchfa").HeaderText = " مستشفى "
                .Columns("tabeka").HeaderText = " تطبيقية"
                .Columns("s_7").HeaderText = "7%"
                .Columns("lgna").HeaderText = "اللجنة"
                .Columns("cndok").HeaderText = "صندوق"
                .Columns("raya_5").HeaderText = "5%"
                .Columns("drab_ksb").HeaderText = "ضريبة كسب"
                .Columns("tswa_drab").HeaderText = "تسوية ضريبية"
                .Columns("ghtoto").HeaderText = "خطوط"
                .Columns("slf_nkba_m").HeaderText = "سلفة نقابةمعلمين"
                .Columns("bnk_naser").HeaderText = "بنك ناصر"
                .Columns("masr_tamen").HeaderText = "مصر للتامين"
                .Columns("zrahen").HeaderText = "زراعيين"
                .Columns("mash_ahara").HeaderText = "معاش اعارة"
                .Columns("nfka").HeaderText = "نفقة"
                .Columns("erdat").HeaderText = "إيرادات"
                .Columns("atbare").HeaderText = "اعتبارية"
                .Columns("eskndra").HeaderText = "اسكندريه"
                .Columns("damgha_adya").HeaderText = "دمغة عادية"
                .Columns("sandok_gzat").HeaderText = "صندوق جزاءات"
                .Columns("gzat").HeaderText = "جزاءات"
                .Columns("mhn_readay").HeaderText = "مهن رياضية"
                .Columns("asnaf_moba").HeaderText = "اصناف مباعة"
                .Columns("hafez").HeaderText = "حافز"
                .Columns("dewn").HeaderText = "دىون"
                '.Columns("bnd_adfy1").HeaderText = "بند اضافى 1"
                '.Columns("bnd_adfy2").HeaderText = "بند اضافى 2"
            End With
        End If
    End Sub
    '==========================================================
    'update details
    '================
    Public Sub Update_table_detailes_data_total(ByVal no_of_kashf As Integer, ByVal date1 As DateTime, ByVal total_mb As Double, ByVal total_mostkta As Double, ByVal saffy As Double, ByVal no_of_kashfW As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update table_detailes_data_total Set no_of_kashf = @no_of_kashf,date1 = @date1,total_mb = @total_mb,total_mostkta = @total_mostkta,saffy = @saffy Where no_of_kashf = @no_of_kashf"
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_of_kashf", OleDbType.Integer).Value = no_of_kashf
            .Parameters.AddWithValue("@date1", OleDbType.Date).Value = date1
            .Parameters.AddWithValue("@total_mb", OleDbType.Double).Value = total_mb
            .Parameters.AddWithValue("@total_mostkta", OleDbType.Double).Value = total_mostkta
            .Parameters.AddWithValue("@saffy", OleDbType.Double).Value = saffy
            .Parameters.AddWithValue("@no_of_kashf", OleDbType.Integer).Value = no_of_kashfW
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        Cmd = Nothing
    End Sub
    '===============================================================
    'max id tabel_bnd
    Public Function Max_tabel_bnd()
        Dim Number As Integer
        Try
            Dim cmd As New OleDbCommand("Select Max(id_bnd) From tabel_bnd ", Con)
            If con.State = 1 Then con.Close()
            con.Open()
            Number = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Number = 0
            con.Close()
        End Try
        Return Number
    End Function


    '================================================================
    'edite
    '=====
    Public Sub Update_tabel_bnd(ByVal id_bnd As Integer, ByVal no_of_kashf As Integer, ByVal des_bnd As String,
        ByVal mha_msthka As Double,
                                ByVal agr_wazef As Double,
                                ByVal agr_mkml As Double,
                                ByVal hafz_tayde As Double,
                                ByVal hafez_mkto As Double,
                                ByVal hafez_tkamel As Double,
                                ByVal bdl_akam As Double,
                                ByVal adfya As Double,
                                ByVal agtmai As Double,
                                ByVal mnha As Double,
                                ByVal bdl_nzar As Double,
                                ByVal bdl_tfrgh As Double,
                                ByVal bdl_adwa As Double,
                                ByVal alao_2014 As Double,
                                ByVal alao_2015 As Double,
                                ByVal bdl_moalm As Double,
                                ByVal bdl_etmad As Double,
                                ByVal aba_wzefea As Double,
                                ByVal hafez_ada As Double,
                                ByVal hafz_25 As Double,
                                ByVal mgster As Double,
                                ByVal computer As Double,
                                ByVal doctora As Double,
                                ByVal bnd_adafy_1 As Double,
                                ByVal bnd_adafy_2 As Double,
                                ByVal total_bnd As Double, ByVal bnd_adafy_3 As Double,
                                ByVal bnd_adafy_4 As Double,
                                ByVal bnd_adafy_5 As Double,
                                ByVal bnd_adafy_6 As Double,
                                ByVal bnd_adafy_7 As Double,
                                ByVal bnd_adafy_8 As Double,
                                ByVal bnd_adafy_9 As Double,
                                ByVal bnd_adafy_10 As Double,
                                ByVal id_bndW As Integer)




        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tabel_bnd Set id_bnd = @id_bnd,no_of_kashf = @no_of_kashf,des_bnd = @des_bnd,mha_msthka = @mha_msthka,agr_wazef = @agr_wazef,agr_mkml = @agr_mkml,hafz_tayde = @hafz_tayde,hafez_mkto = @hafez_mkto,hafez_tkamel = @hafez_tkamel,bdl_akam = @bdl_akam,adfya = @adfya,agtmai = @agtmai,mnha = @mnha,bdl_nzar = @bdl_nzar,bdl_tfrgh = @bdl_tfrgh,bdl_adwa = @bdl_adwa,alao_2014 = @alao_2014,alao_2015 = @alao_2015,bdl_moalm = @bdl_moalm,bdl_etmad = @bdl_etmad,aba_wzefea = @aba_wzefea,hafez_ada = @hafez_ada,hafz_25 = @hafz_25,mgster = @mgster,computer = @computer,doctora = @doctora,bnd_adafy_1 = @bnd_adafy_1,bnd_adafy_2 = @bnd_adafy_2,total_bnd = @total_bnd,bnd_adafy_3=@bnd_adafy_3,bnd_adafy_4=@bnd_adafy_4,bnd_adafy_5=@bnd_adafy_5,bnd_adafy_6=@bnd_adafy_6,bnd_adafy_7=@bnd_adafy_7,bnd_adafy_8=@bnd_adafy_8,bnd_adafy_9=@bnd_adafy_9,bnd_adafy_10=@bnd_adafy_10 Where id_bnd = @id_bnd"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = id_bnd
            .Parameters.AddWithValue("@no_of_kashf", OleDbType.Integer).Value = no_of_kashf
            .Parameters.AddWithValue("@des_bnd", OleDbType.VarChar).Value = des_bnd
            .Parameters.AddWithValue("@mha_msthka", OleDbType.Double).Value = mha_msthka
            .Parameters.AddWithValue("@agr_wazef", OleDbType.Double).Value = agr_wazef
            .Parameters.AddWithValue("@agr_mkml", OleDbType.Double).Value = agr_mkml
            .Parameters.AddWithValue("@hafz_tayde", OleDbType.Double).Value = hafz_tayde
            .Parameters.AddWithValue("@hafez_mkto", OleDbType.Double).Value = hafez_mkto

            .Parameters.AddWithValue("@hafez_tkamel", OleDbType.Double).Value = hafez_tkamel

            .Parameters.AddWithValue("@bdl_akam", OleDbType.Double).Value = bdl_akam

            .Parameters.AddWithValue("@adfya", OleDbType.Double).Value = adfya

            .Parameters.AddWithValue("@agtmai", OleDbType.Double).Value = agtmai

            .Parameters.AddWithValue("@mnha", OleDbType.Double).Value = mnha

            .Parameters.AddWithValue("@bdl_nzar", OleDbType.Double).Value = bdl_nzar

            .Parameters.AddWithValue("@bdl_tfrgh", OleDbType.Double).Value = bdl_tfrgh

            .Parameters.AddWithValue("@bdl_adwa", OleDbType.Double).Value = bdl_adwa

            .Parameters.AddWithValue("@alao_2014", OleDbType.Double).Value = alao_2014

            .Parameters.AddWithValue("@alao_2015", OleDbType.Double).Value = alao_2015

            .Parameters.AddWithValue("@bdl_moalm", OleDbType.Double).Value = bdl_moalm

            .Parameters.AddWithValue("@bdl_etmad", OleDbType.Double).Value = bdl_etmad

            .Parameters.AddWithValue("@aba_wzefea", OleDbType.Double).Value = aba_wzefea

            .Parameters.AddWithValue("@hafez_ada", OleDbType.Double).Value = hafez_ada

            .Parameters.AddWithValue("@hafz_25", OleDbType.Double).Value = hafz_25

            .Parameters.AddWithValue("@mgster", OleDbType.Double).Value = mgster

            .Parameters.AddWithValue("@computer", OleDbType.Double).Value = computer

            .Parameters.AddWithValue("@doctora", OleDbType.Double).Value = doctora

            .Parameters.AddWithValue("@bnd_adafy_1", OleDbType.Double).Value = bnd_adafy_1
            .Parameters.AddWithValue("@bnd_adafy_2", OleDbType.Double).Value = bnd_adafy_2
            .Parameters.AddWithValue("@total_bnd", OleDbType.Double).Value = total_bnd
            .Parameters.AddWithValue("@bnd_adafy_3", OleDbType.Double).Value = bnd_adafy_3
            .Parameters.AddWithValue("@bnd_adafy_4", OleDbType.Double).Value = bnd_adafy_4
            .Parameters.AddWithValue("@bnd_adafy_5", OleDbType.Double).Value = bnd_adafy_5
            .Parameters.AddWithValue("@bnd_adafy_6", OleDbType.Double).Value = bnd_adafy_6
            .Parameters.AddWithValue("@bnd_adafy_7", OleDbType.Double).Value = bnd_adafy_7
            .Parameters.AddWithValue("@bnd_adafy_8", OleDbType.Double).Value = bnd_adafy_8
            .Parameters.AddWithValue("@bnd_adafy_9", OleDbType.Double).Value = bnd_adafy_9
            .Parameters.AddWithValue("@bnd_adafy_10", OleDbType.Double).Value = bnd_adafy_10




            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = id_bndW
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub



    '=========================================================
    'update mostkta bnd
    '===================
    '=====================================================================0===========================1=======================2==========================3====================4====================5===========================6====================7=====================8======================9======================10=======================11======================12==========================13=====================14============================15=======================16=========================17==========================18=====================19=====================20====================21======================22=========================23=========================24===========================25====================26================================27====================28====================29====================30===============================31===============================32=============================33===============       ========34====================================35================================36============================37=======================38========================39==============================40============================41=================================42===========================43=============================44==================================45=================================46==========================47===============================48=============================49===============================50========================51=======================52======================53========================54=========================55==========================56==========================57==========================58=========================59=========================60==============================61====================
    Public Sub Update_table_bnd_mostkta(ByVal no_of_kashf As Integer, ByVal mashat_9 As Double, ByVal mashat_1 As Double, ByVal m_1 As Double, ByVal nkabt_mhn As Double, ByVal nady As Double, ByVal mostchfa As Double, ByVal tabeka As Double, ByVal s_7 As Double, ByVal lgna As Double, ByVal cndok As Double, ByVal raya_5 As Double, ByVal drab_ksb As Double, ByVal tswa_drab As Double, ByVal ghtoto As Double, ByVal slf_nkba_m As Double, ByVal bnk_naser As Double, ByVal masr_tamen As Double, ByVal zrahen As Double, ByVal mash_ahara As Double, ByVal nfka As Double, ByVal erdat As Double, ByVal atbare As Double, ByVal eskndra As Double, ByVal damgha_adya As Double, ByVal sandok_gzat As Double, ByVal gzat As Double, ByVal mhn_readay As Double, ByVal asnaf_moba As Double, ByVal hafez As Double, ByVal dewn As Double, ByVal rabth_talem As Double, ByVal nkba_mhn_tgaryh As Double, ByVal nkba_mhn_agtmea As Double, ByVal tklft_tpa As Double, ByVal erdat_mgls_ghdmat_talem As Double, ByVal krd_hasn_kahra As Double, ByVal krd_hasn_miniy As Double, ByVal orange As Double, ByVal egar_shka As Double, ByVal nkbat_frayh As Double, ByVal bnk_msr_abu_qrqas As Double, ByVal bnk_kahra_miny As Double, ByVal cmn_ktb_hadan As Double, ByVal shark_ltamen As Double, ByVal shark_ltamen_ahly As Double, ByVal cndok_ghadmat_mgls As Double, ByVal shaba_ghash As Double, ByVal gmahed_kanwnen As Double, ByVal rabta_twgeh_alwm As Double, ByVal asr_mntgh_miny As Double, ByVal sednawy As Double, ByVal dman_maly As Double, ByVal bnd_adfy1 As Double, ByVal bnd_adfy2 As Double, ByVal bnd_adafy3 As Double, ByVal bnd_adafy4 As Double, ByVal bnd_adafy5 As Double, ByVal bnd_adafy6 As Double, ByVal bnd_adafy7 As Double, ByVal bnd_adafy8 As Double, ByVal bnd_adafy9 As Double, ByVal bnd_adafy10 As Double, ByVal id_bnd As Integer, ByVal total_mostkta_1 As Double, ByVal total_saffy As Double)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update table_bnd_mostkta Set no_of_kashf = @no_of_kashf,mashat_9 = @mashat_9,mashat_1 = @mashat_1,m_1 = @m_1,nkabt_mhn = @nkabt_mhn,nady = @nady,mostchfa = @mostchfa,tabeka = @tabeka,s_7 = @s_7,lgna = @lgna,cndok = @cndok,raya_5 = @raya_5,drab_ksb = @drab_ksb,tswa_drab = @tswa_drab,ghtoto = @ghtoto,slf_nkba_m = @slf_nkba_m,bnk_naser = @bnk_naser,masr_tamen = @masr_tamen,zrahen = @zrahen,mash_ahara = @mash_ahara,nfka = @nfka,erdat = @erdat,atbare = @atbare,eskndra = @eskndra,damgha_adya = @damgha_adya,sandok_gzat = @sandok_gzat,gzat = @gzat,mhn_readay = @mhn_readay,asnaf_moba = @asnaf_moba,hafez = @hafez,dewn = @dewn,bnd_adfy1 = @bnd_adfy1,bnd_adfy2 = @bnd_adfy2,total_mostkta_1 = @total_mostkta_1,total_saffy = @total_saffy ,rabth_talem =@rabth_talem ,nkba_mhn_tgaryh=@nkba_mhn_tgaryh,nkba_mhn_agtmea=@nkba_mhn_agtmea,tklft_tpa=@tklft_tpa,erdat_mgls_ghdmat_talem=@erdat_mgls_ghdmat_talem,krd_hasn_kahra=@krd_hasn_kahra,krd_hasn_miniy=@krd_hasn_miniy,orange=@orange,egar_shka=@egar_shka,nkbat_frayh=@nkbat_frayh,bnk_msr_abu_qrqas=@bnk_msr_abu_qrqas,bnk_kahra_miny=@bnk_kahra_miny,cmn_ktb_hadan=@cmn_ktb_hadan,shark_ltamen=@shark_ltamen,shark_ltamen_ahly=@shark_ltamen_ahly,cndok_ghadmat_mgls=@cndok_ghadmat_mgls,shaba_ghash=@shaba_ghash,gmahed_kanwnen=@gmahed_kanwnen,rabta_twgeh_alwm=@rabta_twgeh_alwm,asr_mntgh_miny=@asr_mntgh_miny,sednawy=@sednawy,dman_maly=@dman_maly,bnd_adafy3=@bnd_adafy3,bnd_adafy4=@bnd_adafy4,bnd_adafy5=@bnd_adafy5,bnd_adafy6=@bnd_adafy6,bnd_adafy7=@bnd_adafy7,bnd_adafy8=@bnd_adafy8,bnd_adafy9=@bnd_adafy9,bnd_adafy10=@bnd_adafy10  Where id_bnd = @id_bnd"
            .Parameters.Clear()

            .Parameters.AddWithValue("@no_of_kashf", OleDbType.Integer).Value = no_of_kashf
            .Parameters.AddWithValue("@mashat_9", OleDbType.Double).Value = mashat_9
            .Parameters.AddWithValue("@mashat_1", OleDbType.Double).Value = mashat_1
            .Parameters.AddWithValue("@m_1", OleDbType.Double).Value = m_1
            .Parameters.AddWithValue("@nkabt_mhn", OleDbType.Double).Value = nkabt_mhn

            .Parameters.AddWithValue("@nady", OleDbType.Double).Value = nady

            .Parameters.AddWithValue("@mostchfa", OleDbType.Double).Value = mostchfa

            .Parameters.AddWithValue("@tabeka", OleDbType.Double).Value = tabeka

            .Parameters.AddWithValue("@s_7", OleDbType.Double).Value = s_7
            .Parameters.AddWithValue("@lgna", OleDbType.Double).Value = lgna

            .Parameters.AddWithValue("@cndok", OleDbType.Double).Value = cndok

            .Parameters.AddWithValue("@raya_5", OleDbType.Double).Value = raya_5
            .Parameters.AddWithValue("@drab_ksb", OleDbType.Double).Value = drab_ksb

            .Parameters.AddWithValue("@tswa_drab", OleDbType.Double).Value = tswa_drab

            .Parameters.AddWithValue("@ghtoto", OleDbType.Double).Value = ghtoto

            .Parameters.AddWithValue("@slf_nkba_m", OleDbType.Double).Value = slf_nkba_m

            .Parameters.AddWithValue("@bnk_naser", OleDbType.Double).Value = bnk_naser

            .Parameters.AddWithValue("@masr_tamen", OleDbType.Double).Value = masr_tamen

            .Parameters.AddWithValue("@zrahen", OleDbType.Double).Value = zrahen

            .Parameters.AddWithValue("@mash_ahara", OleDbType.Double).Value = mash_ahara

            .Parameters.AddWithValue("@nfka", OleDbType.Double).Value = nfka

            .Parameters.AddWithValue("@erdat", OleDbType.Double).Value = erdat

            .Parameters.AddWithValue("@atbare", OleDbType.Double).Value = atbare

            .Parameters.AddWithValue("@eskndra", OleDbType.Double).Value = eskndra

            .Parameters.AddWithValue("@damgha_adya", OleDbType.Double).Value = damgha_adya

            .Parameters.AddWithValue("@sandok_gzat", OleDbType.Double).Value = sandok_gzat

            .Parameters.AddWithValue("@gzat", OleDbType.Double).Value = gzat

            .Parameters.AddWithValue("@mhn_readay", OleDbType.Double).Value = mhn_readay

            .Parameters.AddWithValue("@asnaf_moba", OleDbType.Double).Value = asnaf_moba

            .Parameters.AddWithValue("@hafez", OleDbType.Double).Value = hafez

            .Parameters.AddWithValue("@dewn", OleDbType.Double).Value = dewn

            .Parameters.AddWithValue("@bnd_adfy1", OleDbType.Double).Value = bnd_adfy1

            .Parameters.AddWithValue("@bnd_adfy2", OleDbType.Double).Value = bnd_adfy2
            .Parameters.AddWithValue("@total_mostkta_1", OleDbType.Double).Value = total_mostkta_1
            .Parameters.AddWithValue("@total_saffy", OleDbType.Double).Value = total_saffy

            .Parameters.AddWithValue("@rabth_talem", OleDbType.Double).Value = rabth_talem
            .Parameters.AddWithValue("@nkba_mhn_tgaryh", OleDbType.Double).Value = nkba_mhn_tgaryh
            .Parameters.AddWithValue("@nkba_mhn_agtmea", OleDbType.Double).Value = nkba_mhn_agtmea
            .Parameters.AddWithValue("@tklft_tpa", OleDbType.Double).Value = tklft_tpa
            .Parameters.AddWithValue("@erdat_mgls_ghdmat_talem", OleDbType.Double).Value = erdat_mgls_ghdmat_talem
            .Parameters.AddWithValue("@krd_hasn_kahra", OleDbType.Double).Value = krd_hasn_kahra
            .Parameters.AddWithValue("@krd_hasn_miniy", OleDbType.Double).Value = krd_hasn_miniy
            .Parameters.AddWithValue("@orange", OleDbType.Double).Value = orange
            .Parameters.AddWithValue("@egar_shka", OleDbType.Double).Value = egar_shka
            .Parameters.AddWithValue("@nkbat_frayh", OleDbType.Double).Value = nkbat_frayh
            .Parameters.AddWithValue("@bnk_msr_abu_qrqas", OleDbType.Double).Value = bnk_msr_abu_qrqas
            .Parameters.AddWithValue("@bnk_kahra_miny", OleDbType.Double).Value = bnk_kahra_miny
            .Parameters.AddWithValue("@cmn_ktb_hadan", OleDbType.Double).Value = cmn_ktb_hadan
            .Parameters.AddWithValue("@shark_ltamen", OleDbType.Double).Value = shark_ltamen
            .Parameters.AddWithValue("@shark_ltamen_ahly", OleDbType.Double).Value = shark_ltamen_ahly
            .Parameters.AddWithValue("@cndok_ghadmat_mgls", OleDbType.Double).Value = cndok_ghadmat_mgls
            .Parameters.AddWithValue("@shaba_ghash", OleDbType.Double).Value = shaba_ghash
            .Parameters.AddWithValue("@gmahed_kanwnen", OleDbType.Double).Value = gmahed_kanwnen
            .Parameters.AddWithValue("@rabta_twgeh_alwm", OleDbType.Double).Value = rabta_twgeh_alwm
            .Parameters.AddWithValue("@asr_mntgh_miny", OleDbType.Double).Value = asr_mntgh_miny
            .Parameters.AddWithValue("@sednawy", OleDbType.Double).Value = sednawy
            .Parameters.AddWithValue("@dman_maly", OleDbType.Double).Value = dman_maly
            .Parameters.AddWithValue("@bnd_adafy3", OleDbType.Double).Value = bnd_adafy3
            .Parameters.AddWithValue("@bnd_adafy4", OleDbType.Double).Value = bnd_adafy4
            .Parameters.AddWithValue("@bnd_adafy5", OleDbType.Double).Value = bnd_adafy5
            .Parameters.AddWithValue("@bnd_adafy6", OleDbType.Double).Value = bnd_adafy6
            .Parameters.AddWithValue("@bnd_adafy7", OleDbType.Double).Value = bnd_adafy7
            .Parameters.AddWithValue("@bnd_adafy8", OleDbType.Double).Value = bnd_adafy8
            .Parameters.AddWithValue("@bnd_adafy9", OleDbType.Double).Value = bnd_adafy9
            .Parameters.AddWithValue("@bnd_adafy10", OleDbType.Double).Value = bnd_adafy10


            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = id_bnd

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub



    '===========================================================
    'delete row
    '==============
    Public Sub Delete_tabel_bnd(ByVal dgv_tabel_bnd As DataGridView)
        Dim Position As Integer = dgv_tabel_bnd.CurrentRow.Index
        Dim ID_Position As Integer = dgv_tabel_bnd.Rows(Position).Cells("id_bnd").Value
        Dim CmdDelete As New OleDbCommand
        With CmdDelete
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From tabel_bnd  Where id_bnd = @id_bnd"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_bnd", OleDbType.Integer).Value = ID_Position
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        CmdDelete.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        CmdDelete = Nothing
    End Sub


    '==========================================================
    'insert new no of kashf to details
    '=======================================
    Public Sub Insert_table_detailes_data_total(ByVal no_of_kashf As Integer, ByVal date1 As DateTime)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into table_detailes_data_total ( no_of_kashf,date1)values(@no_of_kashf,@date1)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@no_of_kashf", OleDbType.Integer).Value = no_of_kashf
            .Parameters.AddWithValue("@date1", OleDbType.Date).Value = date1
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()
        'MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub



    '===========================================================
    'ملى list box
    ' select no_kshf_list_box

    Public Sub SelectSome_Table_all_bnd(ByVal list_box As ListBox)
        Dim dt_no_kshf As New DataTable
        Dim da As New OleDbDataAdapter
        dt_no_kshf.Clear()
        da = New OleDbDataAdapter("select no_of_kashf from table_detailes_data_total", con)
        da.Fill(dt_no_kshf)
        If dt_no_kshf.Rows.Count > 0 Then
            list_box.DataSource = dt_no_kshf
            list_box.DisplayMember = "no_of_kashf"


            list_box.ValueMember = "no_of_kashf"
        Else
            list_box.DataSource = Nothing
        End If
    End Sub
End Module
