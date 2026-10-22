Imports System.Data.OleDb

Module Module_drab


    '=================

    Public Function Max_Table_drab2()
        Dim Number As Integer = 1
        Try
            Dim cmd As New OleDbCommand("Select Max(id_drab) From add_new_drab_tabel ", con)
            If con.State = 1 Then con.Close()
            con.Open()
            Number = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Number = 1
            con.Close()
        End Try
        Return Number
    End Function
    '===========

    '====================
    Public Function Max_rec_drab2()
        Dim Number As Integer = 1
        Try
            Dim cmd As New OleDbCommand("Select Max(num_rec) From add_new_drab_tabel ", con)
            If con.State = 1 Then con.Close()
            con.Open()
            Number = cmd.ExecuteScalar
            con.Close()
        Catch ex As Exception
            Number = 1
            con.Close()
        End Try
        Return Number
    End Function
    '=================
    Public Sub Delete_add_drab(ByVal dgv_add_drab As DataGridView)
        Dim Position As Integer = dgv_add_drab.CurrentRow.Index
        Dim ID_Position As Integer = dgv_add_drab.Rows(Position).Cells("id_drab").Value
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From add_new_drab_tabel Where id_drab = @id_drab"
            .Parameters.Clear()
            .Parameters.AddWithValue("@id_drab", OleDbType.Integer).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    '========
    'Public Sub Insert_add_drab(ByVal id_drab As Integer, ByVal num_rec As Integer, ByVal shatb_no As String, ByVal shatb_number As Integer,
    '                            ByVal num_ked As Integer, ByVal kasb As Double, ByVal kasb_amr_dafa As String,
    '                            ByVal kasb_date As String, ByVal damgha_total As Double, ByVal damgha_amr_dafa As String,
    '                            ByVal damgha_date As String, ByVal arbah_t_total As Double,
    '                            ByVal arbah_t_amr_dafa As String, ByVal arbah_t_date As String,
    '                            ByVal nwaya_total As Double, ByVal nwaya_amr_dafa As String,
    '                            ByVal nwaya_date As String, ByVal tanmea_total As Double,
    '                            ByVal tanmea_amr_dafa As String, ByVal tanmea_date As String,
    '                            ByVal kema_mdfa_total As Double, ByVal kema_mdfa_amr_dafa As String, ByVal kema_mdfa_date As String,
    '                            ByVal tot_tot_kasb As Double, ByVal tot_tot_damgha As Double,
    '                            ByVal tot_tot_arbah_t As Double, ByVal tot_tot_nwaya As Double,
    '                            ByVal tot_tot_tanmea As Double, ByVal tot_tot_kema_mdfa As Double, ByVal date_drab As DateTime, ByVal total_drab As Double)

    '    Dim Cmd As New OleDbCommand
    '    With Cmd
    '        .Connection = con
    '        .CommandType = CommandType.Text
    '        .CommandText = "INSERT INTO add_drab (id_drab,num_rec, shatb_no, shatb_number, num_ked, kasb, kasb_amr_dafa, kasb_date, " &
    '                       "damgha_total, damgha_amr_dafa, damgha_date, arbah_t_total, arbah_t_amr_dafa, arbah_t_date, " &
    '                       "nwaya_total, nwaya_amr_dafa, nwaya_date, tanmea_total, tanmea_amr_dafa, tanmea_date, " &
    '                       "kema_mdfa_total, kema_mdfa_amr_dafa, kema_mdfa_date, tot_tot_kasb, tot_tot_damgha, " &
    '                       "tot_tot_arbah_t, tot_tot_nwaya, tot_tot_tanmea, tot_tot_kema_mdfa,date_drab,total_drab) " &
    '                       "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?,?,?)"

    '        .Parameters.AddWithValue("?", id_drab)
    '        .Parameters.AddWithValue("?", num_rec)
    '        .Parameters.AddWithValue("?", shatb_no)
    '        .Parameters.AddWithValue("?", shatb_number)
    '        .Parameters.AddWithValue("?", num_ked)
    '        .Parameters.AddWithValue("?", kasb)
    '        .Parameters.AddWithValue("?", kasb_amr_dafa)
    '        .Parameters.AddWithValue("?", kasb_date)
    '        .Parameters.AddWithValue("?", damgha_total)
    '        .Parameters.AddWithValue("?", damgha_amr_dafa)
    '        .Parameters.AddWithValue("?", damgha_date)
    '        .Parameters.AddWithValue("?", arbah_t_total)
    '        .Parameters.AddWithValue("?", arbah_t_amr_dafa)
    '        .Parameters.AddWithValue("?", arbah_t_date)
    '        .Parameters.AddWithValue("?", nwaya_total)
    '        .Parameters.AddWithValue("?", nwaya_amr_dafa)
    '        .Parameters.AddWithValue("?", nwaya_date)
    '        .Parameters.AddWithValue("?", tanmea_total)
    '        .Parameters.AddWithValue("?", tanmea_amr_dafa)
    '        .Parameters.AddWithValue("?", tanmea_date)
    '        .Parameters.AddWithValue("?", kema_mdfa_total)
    '        .Parameters.AddWithValue("?", kema_mdfa_amr_dafa)
    '        .Parameters.AddWithValue("?", kema_mdfa_date)
    '        .Parameters.AddWithValue("?", tot_tot_kasb)
    '        .Parameters.AddWithValue("?", tot_tot_damgha)
    '        .Parameters.AddWithValue("?", tot_tot_arbah_t)
    '        .Parameters.AddWithValue("?", tot_tot_nwaya)
    '        .Parameters.AddWithValue("?", tot_tot_tanmea)
    '        .Parameters.AddWithValue("?", tot_tot_kema_mdfa)
    '        .Parameters.AddWithValue("?", date_drab)
    '        .Parameters.AddWithValue("?", total_drab)
    '    End With

    '    If con.State = ConnectionState.Open Then con.Close()
    '    con.Open()
    '    Cmd.ExecuteNonQuery()
    '    con.Close()

    '    Cmd = Nothing
    'End Sub
    '=======================
    Public Sub add_new_drab_tabel(ByVal id_drab As Integer, ByVal num_rec As Integer, ByVal shatb_no As String, ByVal num_ked As Integer, ByVal shatb_number As String, ByVal date_drab As DateTime, ByVal total_drab As Double)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO add_new_drab_tabel(id_drab,num_rec, shatb_no, shatb_number, num_ked, " &
                           "date_drab,total_drab) " &
                           "VALUES (?, ?, ?, ?, ?, ?, ?)"

            .Parameters.AddWithValue("?", id_drab)
            .Parameters.AddWithValue("?", num_rec)
            .Parameters.AddWithValue("?", shatb_no)
            .Parameters.AddWithValue("?", shatb_number)
            .Parameters.AddWithValue("?", num_ked)
            .Parameters.AddWithValue("?", date_drab)
            .Parameters.AddWithValue("?", total_drab)
        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '==========
    Public Sub Insert_kasb_drab_tabel(ByVal shatb_number As String, ByVal kasb As Double, ByVal kasb_amr_dafa As String, ByVal kasb_date As String, ByVal tot_tot_kasb As Double, ByVal num_rec_kasb As Integer)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO kasb_drab_tabel ( shatb_number, kasb, kasb_amr_dafa,kasb_date,tot_tot_kasb,num_rec_kasb) " &
                           "VALUES (?, ?, ?, ?, ?,?)"

            .Parameters.AddWithValue("?", shatb_number)

            .Parameters.AddWithValue("?", kasb)
            .Parameters.AddWithValue("?", kasb_amr_dafa)
            .Parameters.AddWithValue("?", kasb_date)
            .Parameters.AddWithValue("?", tot_tot_kasb)
            .Parameters.AddWithValue("?", num_rec_kasb)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '========
    Public Sub Insert_damgha_drab_tabel(ByVal shatb_number As String, ByVal damgha_total As Double, ByVal damgha_amr_dafa As String, ByVal damgha_date As String, ByVal tot_tot_damgha As Double, ByVal num_rec_damgha As Integer)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO damgha_drab_tabel (shatb_number, damgha_total,damgha_amr_dafa,damgha_date,tot_tot_damgha,num_rec_damgha) " & "VALUES (?, ?, ?, ?, ?,?)"

            .Parameters.AddWithValue("?", shatb_number)
            .Parameters.AddWithValue("?", damgha_total)
            .Parameters.AddWithValue("?", damgha_amr_dafa)
            .Parameters.AddWithValue("?", damgha_date)
            .Parameters.AddWithValue("?", tot_tot_damgha)
            .Parameters.AddWithValue("?", num_rec_damgha)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '=========================
    Public Sub Insert_arbah_drab_tabel(ByVal shatb_number As String, ByVal arbah_t_total As Double, ByVal arbah_t_amr_dafa As String, ByVal arbah_t_date As String, ByVal tot_tot_arbah_t As Double, ByVal num_rec_arbah As Integer)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO arbah_drab_tabel ( shatb_number,arbah_t_total, arbah_t_amr_dafa, arbah_t_date, tot_tot_arbah_t,num_rec_arbah) " &
                           "VALUES (?, ?, ?, ?, ?,?)"


            .Parameters.AddWithValue("?", shatb_number)

            .Parameters.AddWithValue("?", arbah_t_total)
            .Parameters.AddWithValue("?", arbah_t_amr_dafa)
            .Parameters.AddWithValue("?", arbah_t_date)

            .Parameters.AddWithValue("?", tot_tot_arbah_t)
            .Parameters.AddWithValue("?", num_rec_arbah)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '====================
    Public Sub Insert_nwaya_drab_tabel(ByVal shatb_number As String, ByVal nwaya_total As Double, ByVal nwaya_amr_dafa As String, ByVal nwaya_date As String, ByVal tot_tot_nwaya As Double, ByVal num_rec_nway As Integer)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO nwaya_drab_tabel ( shatb_number, nwaya_total, nwaya_amr_dafa, nwaya_date ,tot_tot_nwaya,num_rec_nway) " & "VALUES (?, ?, ?, ?, ?,?)"


            .Parameters.AddWithValue("?", shatb_number)
            .Parameters.AddWithValue("?", nwaya_total)
            .Parameters.AddWithValue("?", nwaya_amr_dafa)
            .Parameters.AddWithValue("?", nwaya_date)
            .Parameters.AddWithValue("?", tot_tot_nwaya)
            .Parameters.AddWithValue("?", num_rec_nway)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '===============
    Public Sub Insert_tanmea_drab_tabel(ByVal shatb_number As String, ByVal tanmea_total As Double, ByVal tanmea_amr_dafa As String, ByVal tanmea_date As String, ByVal tot_tot_tanmea As Double, ByVal num_rec_tanma As Integer)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO tanmea_drab_tabel ( shatb_number,tanmea_total, tanmea_amr_dafa, tanmea_date,tot_tot_tanmea,num_rec_tanma) " & "VALUES (?, ?, ?, ?, ?,?)"

            .Parameters.AddWithValue("?", shatb_number)
            .Parameters.AddWithValue("?", tanmea_total)
            .Parameters.AddWithValue("?", tanmea_amr_dafa)
            .Parameters.AddWithValue("?", tanmea_date)
            .Parameters.AddWithValue("?", tot_tot_tanmea)
            .Parameters.AddWithValue("?", num_rec_tanma)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '===================
    Public Sub Insert_kema_mdfa_drab_tabel(ByVal shatb_number As String, ByVal kema_mdfa_total As Double, ByVal kema_mdfa_amr_dafa As String, ByVal kema_mdfa_date As String, ByVal tot_tot_kema_mdfa As Double, ByVal num_rec_kema As Integer)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "INSERT INTO kema_mdfa_drab_tabel (shatb_number,kema_mdfa_total, kema_mdfa_amr_dafa, kema_mdfa_date ,tot_tot_kema_mdfa,num_rec_kema) " & "VALUES (?, ?, ?, ?, ?,?)"

            .Parameters.AddWithValue("?", shatb_number)
            .Parameters.AddWithValue("?", kema_mdfa_total)
            .Parameters.AddWithValue("?", kema_mdfa_amr_dafa)
            .Parameters.AddWithValue("?", kema_mdfa_date)
            .Parameters.AddWithValue("?", tot_tot_kema_mdfa)
            .Parameters.AddWithValue("?", num_rec_kema)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '==============
    'Public Sub Update_add_drab(ByVal id_drab As Integer, ByVal shatb_no As String, ByVal shatb_number As Integer,
    '                        ByVal num_ked As Integer, ByVal kasb As Double, ByVal kasb_amr_dafa As String,
    '                        ByVal kasb_date As String, ByVal damgha_total As Double, ByVal damgha_amr_dafa As String,
    '                        ByVal damgha_date As String, ByVal arbah_t_total As Double,
    '                        ByVal arbah_t_amr_dafa As String, ByVal arbah_t_date As String,
    '                        ByVal nwaya_total As Double, ByVal nwaya_amr_dafa As String,
    '                        ByVal nwaya_date As String, ByVal tanmea_total As Double,
    '                        ByVal tanmea_amr_dafa As String, ByVal tanmea_date As String,
    '                        ByVal kema_mdfa_total As Double, ByVal kema_mdfa_amr_dafa As String, ByVal kema_mdfa_date As String,
    '                        ByVal date_drab As DateTime, ByVal total_drab As Double)

    '    Dim Cmd As New OleDbCommand
    '    With Cmd
    '        .Connection = con
    '        .CommandType = CommandType.Text
    '        .CommandText = "UPDATE add_drab SET " &
    '                       "shatb_no=?, shatb_number=?, num_ked=?, kasb=?, kasb_amr_dafa=?, kasb_date=?, " &
    '                       "damgha_total=?, damgha_amr_dafa=?, damgha_date=?, arbah_t_total=?, arbah_t_amr_dafa=?, arbah_t_date=?, " &
    '                       "nwaya_total=?, nwaya_amr_dafa=?, nwaya_date=?, tanmea_total=?, tanmea_amr_dafa=?, tanmea_date=?, " &
    '                       "kema_mdfa_total=?, kema_mdfa_amr_dafa=?, kema_mdfa_date=?, " &
    '                       "date_drab=?,total_drab=?" &
    '                       "WHERE id_drab=?"

    '        ' أضف القيم بالترتيب الصحيح
    '        .Parameters.AddWithValue("?", shatb_no)
    '        .Parameters.AddWithValue("?", shatb_number)
    '        .Parameters.AddWithValue("?", num_ked)
    '        .Parameters.AddWithValue("?", kasb)
    '        .Parameters.AddWithValue("?", kasb_amr_dafa)
    '        .Parameters.AddWithValue("?", kasb_date)
    '        .Parameters.AddWithValue("?", damgha_total)
    '        .Parameters.AddWithValue("?", damgha_amr_dafa)
    '        .Parameters.AddWithValue("?", damgha_date)
    '        .Parameters.AddWithValue("?", arbah_t_total)
    '        .Parameters.AddWithValue("?", arbah_t_amr_dafa)
    '        .Parameters.AddWithValue("?", arbah_t_date)
    '        .Parameters.AddWithValue("?", nwaya_total)
    '        .Parameters.AddWithValue("?", nwaya_amr_dafa)
    '        .Parameters.AddWithValue("?", nwaya_date)
    '        .Parameters.AddWithValue("?", tanmea_total)
    '        .Parameters.AddWithValue("?", tanmea_amr_dafa)
    '        .Parameters.AddWithValue("?", tanmea_date)
    '        .Parameters.AddWithValue("?", kema_mdfa_total)
    '        .Parameters.AddWithValue("?", kema_mdfa_amr_dafa)
    '        .Parameters.AddWithValue("?", kema_mdfa_date)

    '        .Parameters.AddWithValue("?", date_drab)
    '        .Parameters.AddWithValue("?", total_drab)
    '        .Parameters.AddWithValue("?", id_drab) ' الشرط الأساسي للتعديل
    '    End With

    '    If con.State = ConnectionState.Open Then con.Close()
    '    con.Open()
    '    Cmd.ExecuteNonQuery()
    '    con.Close()

    '    Cmd = Nothing
    'End Sub

    '===================================
    Public Sub Update_add_new_drab_tabel(ByVal num_rec As Integer, ByVal shatb_no As String, ByVal num_ked As Integer, ByVal shatb_number As String, ByVal date_drab As DateTime, ByVal total_drab As Double, ByVal id_drab As Integer)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE add_new_drab_tabel SET num_rec = ?, shatb_no = ?, num_ked = ?, shatb_number = ?, date_drab = ?, total_drab = ? WHERE id_drab = ?"


            .Parameters.AddWithValue("?", num_rec)
            .Parameters.AddWithValue("?", shatb_no)
            .Parameters.AddWithValue("?", num_ked)
            .Parameters.AddWithValue("?", shatb_number)
            .Parameters.AddWithValue("?", date_drab)
            .Parameters.AddWithValue("?", total_drab)
            .Parameters.AddWithValue("?", id_drab)
        End With
        Debug.Print("SQL: " & Cmd.CommandText)
        For Each p In Cmd.Parameters
            Debug.Print("Parameter: " & p.Value)
        Next
        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '===================================
    Public Sub Update_kasb_drab_tabel(ByVal shatb_number As String, ByVal kasb As Double, ByVal kasb_amr_dafa As String, ByVal kasb_date As String, ByVal num_rec_kasb As Integer, ByVal shatb_numberW As String)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE kasb_drab_tabel SET shatb_number=?, kasb=?, kasb_amr_dafa=?, kasb_date=?,num_rec_kasb=? WHERE shatb_number=?"


            .Parameters.AddWithValue("?", shatb_number)
            .Parameters.AddWithValue("?", kasb)
            .Parameters.AddWithValue("?", kasb_amr_dafa)
            .Parameters.AddWithValue("?", kasb_date)
            .Parameters.AddWithValue("?", num_rec_kasb)
            .Parameters.AddWithValue("?", shatb_numberW)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '===================
    Public Sub Update_damgha_drab_tabel(ByVal shatb_number As String, ByVal damgha_total As Double, ByVal damgha_amr_dafa As String, ByVal damgha_date As String, ByVal num_rec_damgha As Integer, ByVal shatb_numberw As String)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE damgha_drab_tabel SET  shatb_number=?, damgha_total=?, damgha_amr_dafa=?, damgha_date=?,num_rec_damgha=? WHERE shatb_number=?"

            ' أضف القيم بالترتيب الصحيح

            .Parameters.AddWithValue("?", shatb_number)

            .Parameters.AddWithValue("?", damgha_total)
            .Parameters.AddWithValue("?", damgha_amr_dafa)
            .Parameters.AddWithValue("?", damgha_date)
            .Parameters.AddWithValue("?", num_rec_damgha)
            .Parameters.AddWithValue("?", shatb_numberw)


        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '============
    Public Sub Update_arbah_drab_tabel(ByVal shatb_number As String, ByVal arbah_t_total As Double, ByVal arbah_t_amr_dafa As String, ByVal arbah_t_date As String, ByVal num_rec_arbah As Integer, ByVal shatb_numberw As String)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE arbah_drab_tabel SET  shatb_number=?, arbah_t_total=?, arbah_t_amr_dafa=?, arbah_t_date=?,num_rec_arbah=? WHERE shatb_number=?"

            ' أضف القيم بالترتيب الصحيح

            .Parameters.AddWithValue("?", shatb_number)

            .Parameters.AddWithValue("?", arbah_t_total)
            .Parameters.AddWithValue("?", arbah_t_amr_dafa)
            .Parameters.AddWithValue("?", arbah_t_date)

            .Parameters.AddWithValue("?", num_rec_arbah)
            .Parameters.AddWithValue("?", shatb_numberw)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '=============
    Public Sub Update_nwaya_drab_tabel(ByVal shatb_number As String, ByVal nwaya_total As Double, ByVal nwaya_amr_dafa As String, ByVal nwaya_date As String, ByVal num_rec_nway As Integer, ByVal shatb_numberw As String)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE nwaya_drab_tabel SET  shatb_number=?, nwaya_total=?, nwaya_amr_dafa=?, nwaya_date=?,num_rec_nway=? WHERE shatb_number=?"

            ' أضف القيم بالترتيب الصحيح

            .Parameters.AddWithValue("?", shatb_number)

            .Parameters.AddWithValue("?", nwaya_total)
            .Parameters.AddWithValue("?", nwaya_amr_dafa)
            .Parameters.AddWithValue("?", nwaya_date)

            .Parameters.AddWithValue("?", num_rec_nway)
            .Parameters.AddWithValue("?", shatb_numberw)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '==============
    Public Sub Update_tanmea_drab_tabel(ByVal shatb_number As String, ByVal tanmea_total As Double, ByVal tanmea_amr_dafa As String, ByVal tanmea_date As String, ByVal num_rec_tanma As Integer, ByVal shatb_numberw As String)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE tanmea_drab_tabel SET   shatb_number=?, tanmea_total=?, tanmea_amr_dafa=?, tanmea_date=?,num_rec_tanma=? WHERE shatb_number=?"

            ' أضف القيم بالترتيب الصحيح

            .Parameters.AddWithValue("?", shatb_number)

            .Parameters.AddWithValue("?", tanmea_total)
            .Parameters.AddWithValue("?", tanmea_amr_dafa)
            .Parameters.AddWithValue("?", tanmea_date)

            .Parameters.AddWithValue("?", num_rec_tanma)
            .Parameters.AddWithValue("?", shatb_numberw)
        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '=================
    Public Sub Update_kema_mdfa_drab_tabel(ByVal shatb_number As String, ByVal kema_mdfa_total As Double, ByVal kema_mdfa_amr_dafa As String, ByVal kema_mdfa_date As String, ByVal num_rec_kema As Integer, ByVal shatb_numberw As String)

        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE kema_mdfa_drab_tabel SET shatb_number=?, kema_mdfa_total=?, kema_mdfa_amr_dafa=?, kema_mdfa_date=?,num_rec_kema=? WHERE shatb_number=?"

            ' أضف القيم بالترتيب الصحيح

            .Parameters.AddWithValue("?", shatb_number)

            .Parameters.AddWithValue("?", kema_mdfa_total)
            .Parameters.AddWithValue("?", kema_mdfa_amr_dafa)
            .Parameters.AddWithValue("?", kema_mdfa_date)

            .Parameters.AddWithValue("?", num_rec_kema)
            .Parameters.AddWithValue("?", shatb_numberw)

        End With

        If con.State = ConnectionState.Open Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '============
    'Public dt_select_drab_all As New DataTable

    'Public Sub SelectAll_add_drab(dgv As DataGridView, ByVal date1 As DateTime)
    '    Dim da As New OleDbDataAdapter
    '    dt_select_drab_all.Clear()
    '    'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
    '    Dim CMDSEARCH As New OleDbCommand("select * from add_drab WHERE date_drab >= @date1", con)
    '    CMDSEARCH.Parameters.Clear()
    '    CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
    '    Try
    '        If con.State = 1 Then con.Close()
    '        con.Open()
    '        dt_select_drab_all.Load(CMDSEARCH.ExecuteReader)
    '        con.Close()
    '        CMDSEARCH = Nothing
    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(Err.Description, MsgBoxStyle.Information)
    '    Finally
    '        If con.State = ConnectionState.Open Then con.Close()
    '    End Try
    '    'da.Fill(dt_select_drab_all)
    '    dgv.DataSource = dt_select_drab_all
    'End Sub
    '========================================
    Public dt_select_drab_all2 As New DataTable

    Public Sub SelectAll_add_drab2(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_drab_all2.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT " &
    "add_new_drab_tabel.*," &
    "kasb_drab_tabel.kasb," &
    "kasb_drab_tabel.kasb_amr_dafa," &
    "kasb_drab_tabel.kasb_date," &
    "kasb_drab_tabel.tot_tot_kasb," &
    "damgha_drab_tabel.damgha_total," &
    "damgha_drab_tabel.damgha_amr_dafa," &
    "damgha_drab_tabel.damgha_date," &
    "damgha_drab_tabel.tot_tot_damgha," &
    "arbah_drab_tabel.arbah_t_total," &
    "arbah_drab_tabel.arbah_t_amr_dafa," &
    "arbah_drab_tabel.arbah_t_date," &
    "arbah_drab_tabel.tot_tot_arbah_t," &
    "nwaya_drab_tabel.nwaya_total," &
    "nwaya_drab_tabel.nwaya_amr_dafa," &
    "nwaya_drab_tabel.nwaya_date," &
    "nwaya_drab_tabel.tot_tot_nwaya," &
    "tanmea_drab_tabel.tanmea_total," &
    "tanmea_drab_tabel.tanmea_amr_dafa," &
    "tanmea_drab_tabel.tanmea_date," &
    "tanmea_drab_tabel.tot_tot_tanmea," &
    "kema_mdfa_drab_tabel.kema_mdfa_total," &
    "kema_mdfa_drab_tabel.kema_mdfa_amr_dafa," &
    "kema_mdfa_drab_tabel.kema_mdfa_date," &
    "kema_mdfa_drab_tabel.tot_tot_kema_mdfa FROM ((((((add_new_drab_tabel " &
    "LEFT JOIN kasb_drab_tabel ON add_new_drab_tabel.shatb_number = kasb_drab_tabel.shatb_number)" &
"LEFT JOIN damgha_drab_tabel ON add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number)" &
"LEFT JOIN arbah_drab_tabel ON add_new_drab_tabel.shatb_number = arbah_drab_tabel.shatb_number)" &
"LEFT JOIN nwaya_drab_tabel ON add_new_drab_tabel.shatb_number = nwaya_drab_tabel.shatb_number)" &
"LEFT JOIN tanmea_drab_tabel ON add_new_drab_tabel.shatb_number = tanmea_drab_tabel.shatb_number)" &
"LEFT JOIN kema_mdfa_drab_tabel ON add_new_drab_tabel.shatb_number = kema_mdfa_drab_tabel.shatb_number) WHERE date_drab >= @date1", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_drab_all2.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_drab_all2
    End Sub
    '============
    'Public Sub Update_add_drab2(ByVal kasb_amr_dafa As String, ByVal kasb_date As String, ByVal damgha_amr_dafa As String, ByVal damgha_date As String, ByVal arbah_t_amr_dafa As String, ByVal arbah_t_date As String, ByVal nwaya_amr_dafa As String, ByVal nwaya_date As String, ByVal tanmea_amr_dafa As String, ByVal tanmea_date As String, ByVal kema_mdfa_amr_dafa As String, ByVal kema_mdfa_date As String, ByVal tot_tot_kasb As Double, ByVal tot_tot_damgha As Double, ByVal tot_tot_arbah_t As Double, ByVal tot_tot_nwaya As Double, ByVal tot_tot_tanmea As Double, ByVal tot_tot_kema_mdfa As Double, ByVal num_rec As Integer)
    '    Dim Cmd As New OleDbCommand
    '    With Cmd
    '        .Connection = con
    '        .CommandType = CommandType.Text
    '        .CommandText = "Update add_drab Set kasb_amr_dafa = @kasb_amr_dafa,kasb_date = @kasb_date,damgha_amr_dafa = @damgha_amr_dafa,damgha_date = @damgha_date,arbah_t_amr_dafa = @arbah_t_amr_dafa,arbah_t_date = @arbah_t_date,nwaya_amr_dafa = @nwaya_amr_dafa,nwaya_date = @nwaya_date,tanmea_amr_dafa = @tanmea_amr_dafa,tanmea_date = @tanmea_date,kema_mdfa_amr_dafa = @kema_mdfa_amr_dafa,kema_mdfa_date = @kema_mdfa_date,tot_tot_kasb = @tot_tot_kasb,tot_tot_damgha = @tot_tot_damgha,tot_tot_arbah_t = @tot_tot_arbah_t,tot_tot_nwaya = @tot_tot_nwaya,tot_tot_tanmea = @tot_tot_tanmea,tot_tot_kema_mdfa = @tot_tot_kema_mdfa Where num_rec = @num_rec"
    '        .Parameters.Clear()
    '        .Parameters.AddWithValue("@kasb_amr_dafa", OleDbType.VarWChar).Value = kasb_amr_dafa
    '        .Parameters.AddWithValue("@kasb_date", OleDbType.VarWChar).Value = kasb_date
    '        .Parameters.AddWithValue("@damgha_amr_dafa", OleDbType.VarWChar).Value = damgha_amr_dafa
    '        .Parameters.AddWithValue("@damgha_date", OleDbType.VarWChar).Value = damgha_date
    '        .Parameters.AddWithValue("@arbah_t_amr_dafa", OleDbType.VarWChar).Value = arbah_t_amr_dafa
    '        .Parameters.AddWithValue("@arbah_t_date", OleDbType.VarWChar).Value = arbah_t_date
    '        .Parameters.AddWithValue("@nwaya_amr_dafa", OleDbType.VarWChar).Value = nwaya_amr_dafa
    '        .Parameters.AddWithValue("@nwaya_date", OleDbType.VarWChar).Value = nwaya_date
    '        .Parameters.AddWithValue("@tanmea_amr_dafa", OleDbType.VarWChar).Value = tanmea_amr_dafa
    '        .Parameters.AddWithValue("@tanmea_date", OleDbType.VarWChar).Value = tanmea_date
    '        .Parameters.AddWithValue("@kema_mdfa_amr_dafa", OleDbType.VarWChar).Value = kema_mdfa_amr_dafa
    '        .Parameters.AddWithValue("@kema_mdfa_date", OleDbType.VarWChar).Value = kema_mdfa_date

    '        .Parameters.AddWithValue("@tot_tot_kasb", OleDbType.Double).Value = tot_tot_kasb
    '        .Parameters.AddWithValue("@tot_tot_damgha", OleDbType.Double).Value = tot_tot_damgha
    '        .Parameters.AddWithValue("@tot_tot_arbah_t", OleDbType.Double).Value = tot_tot_arbah_t
    '        .Parameters.AddWithValue("@tot_tot_nwaya", OleDbType.Double).Value = tot_tot_nwaya
    '        .Parameters.AddWithValue("@tot_tot_tanmea", OleDbType.Double).Value = tot_tot_tanmea
    '        .Parameters.AddWithValue("@tot_tot_kema_mdfa", OleDbType.Double).Value = tot_tot_kema_mdfa

    '        .Parameters.AddWithValue("@num_rec", OleDbType.Integer).Value = num_rec
    '    End With
    '    If con.State = 1 Then con.Close()
    '    con.Open()
    '    Cmd.ExecuteNonQuery()
    '    con.Close()
    '    MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
    '    Cmd = Nothing
    'End Sub
    '====================
    Public Sub Update_total_kasb_drab_tabel(ByVal kasb_amr_dafa As String, ByVal kasb_date As String, ByVal tot_tot_kasb As Double, ByVal num_rec_kasb As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update kasb_drab_tabel Set kasb_amr_dafa = @kasb_amr_dafa,kasb_date = @kasb_date ,tot_tot_kasb = @tot_tot_kasb Where num_rec_kasb = @num_rec_kasb"
            .Parameters.Clear()
            .Parameters.AddWithValue("@kasb_amr_dafa", OleDbType.VarWChar).Value = kasb_amr_dafa
            .Parameters.AddWithValue("@kasb_date", OleDbType.VarWChar).Value = kasb_date

            .Parameters.AddWithValue("@tot_tot_kasb", OleDbType.Double).Value = tot_tot_kasb

            .Parameters.AddWithValue("@num_rec_kasb", OleDbType.Integer).Value = num_rec_kasb
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '===============================
    Public Sub Update_total_damgha_drab_tabel(ByVal damgha_amr_dafa As String, ByVal damgha_date As String, ByVal tot_tot_damgha As Double, ByVal num_rec_damgha As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update damgha_drab_tabel Set damgha_amr_dafa = @damgha_amr_dafa,damgha_date = @damgha_date ,tot_tot_damgha = @tot_tot_damgha Where num_rec_damgha = @num_rec_damgha"
            .Parameters.Clear()
            .Parameters.AddWithValue("@damgha_amr_dafa", OleDbType.VarWChar).Value = damgha_amr_dafa
            .Parameters.AddWithValue("@damgha_date", OleDbType.VarWChar).Value = damgha_date

            .Parameters.AddWithValue("@tot_tot_damgha", OleDbType.Double).Value = tot_tot_damgha

            .Parameters.AddWithValue("@num_rec_damgha", OleDbType.Integer).Value = num_rec_damgha
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '====================
    Public Sub Update_total_arbah_drab_tabel(ByVal arbah_t_amr_dafa As String, ByVal arbah_t_date As String, ByVal tot_tot_arbah_t As Double, ByVal num_rec_arbah As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update arbah_drab_tabel Set arbah_t_amr_dafa = @arbah_t_amr_dafa,arbah_t_date = @arbah_t_date ,tot_tot_arbah_t = @tot_tot_arbah_t Where num_rec_arbah = @num_rec_arbah"
            .Parameters.Clear()
            .Parameters.AddWithValue("@arbah_t_amr_dafa", OleDbType.VarWChar).Value = arbah_t_amr_dafa
            .Parameters.AddWithValue("@arbah_t_date", OleDbType.VarWChar).Value = arbah_t_date

            .Parameters.AddWithValue("@tot_tot_arbah_t", OleDbType.Double).Value = tot_tot_arbah_t

            .Parameters.AddWithValue("@num_rec_arbah", OleDbType.Integer).Value = num_rec_arbah
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '======================
    Public Sub Update_total_nwaya_drab_tabel(ByVal nwaya_amr_dafa As String, ByVal nwaya_date As String, ByVal tot_tot_nwaya As Double, ByVal num_rec_nway As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update nwaya_drab_tabel Set nwaya_amr_dafa = @nwaya_amr_dafa,nwaya_date = @nwaya_date ,tot_tot_nwaya = @tot_tot_nwaya Where num_rec_nway = @num_rec_nway"
            .Parameters.Clear()
            .Parameters.AddWithValue("@nwaya_amr_dafa", OleDbType.VarWChar).Value = nwaya_amr_dafa
            .Parameters.AddWithValue("@nwaya_date", OleDbType.VarWChar).Value = nwaya_date

            .Parameters.AddWithValue("@tot_tot_nwaya", OleDbType.Double).Value = tot_tot_nwaya

            .Parameters.AddWithValue("@num_rec_nway", OleDbType.Integer).Value = num_rec_nway
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '=============================
    Public Sub Update_total_tanmea_drab_tabel(ByVal tanmea_amr_dafa As String, ByVal tanmea_date As String, ByVal tot_tot_tanmea As Double, ByVal num_rec_tanma As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update tanmea_drab_tabel Set tanmea_amr_dafa = @tanmea_amr_dafa,tanmea_date = @tanmea_date ,tot_tot_tanmea = @tot_tot_tanmea Where num_rec_tanma = @num_rec_tanma"
            .Parameters.Clear()
            .Parameters.AddWithValue("@tanmea_amr_dafa", OleDbType.VarWChar).Value = tanmea_amr_dafa
            .Parameters.AddWithValue("@tanmea_date", OleDbType.VarWChar).Value = tanmea_date

            .Parameters.AddWithValue("@tot_tot_tanmea", OleDbType.Double).Value = tot_tot_tanmea

            .Parameters.AddWithValue("@num_rec_tanma", OleDbType.Integer).Value = num_rec_tanma
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub
    '=======================
    Public Sub Update_total_kema_mdfa_drab_tabel(ByVal kema_mdfa_amr_dafa As String, ByVal kema_mdfa_date As String, ByVal tot_tot_kema_mdfa As Double, ByVal num_rec_kema As Integer)
        Dim Cmd As New OleDbCommand
        With Cmd
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Update kema_mdfa_drab_tabel Set kema_mdfa_amr_dafa = @kema_mdfa_amr_dafa,kema_mdfa_date = @kema_mdfa_date ,tot_tot_kema_mdfa = @tot_tot_kema_mdfa Where num_rec_kema = @num_rec_kema"
            .Parameters.Clear()
            .Parameters.AddWithValue("@kema_mdfa_amr_dafa", OleDbType.VarWChar).Value = kema_mdfa_amr_dafa
            .Parameters.AddWithValue("@kema_mdfa_date", OleDbType.VarWChar).Value = kema_mdfa_date

            .Parameters.AddWithValue("@tot_tot_kema_mdfa", OleDbType.Double).Value = tot_tot_kema_mdfa

            .Parameters.AddWithValue("@num_rec_kema", OleDbType.Integer).Value = num_rec_kema
        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd.ExecuteNonQuery()
        con.Close()

        Cmd = Nothing
    End Sub

    '=============
    Public dt_select_drab As New DataTable
    Public Sub select_drab(ByVal id_drab As Integer)
        dt_select_no_kash.Clear()
        Dim Cmd As New OleDbCommand("select * from add_drab ", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            '.Parameters.AddWithValue("@no_kshf", OleDbType.Integer).Value = no_kash
            dt_select_no_kash.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '==============================================
    Public dt_select_kasb As New DataTable

    Public Sub Select_kasb(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_kasb.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT kasb_drab_tabel.*, add_new_drab_tabel.shatb_no,add_new_drab_tabel.date_drab, add_new_drab_tabel.total_drab FROM add_new_drab_tabel INNER JOIN kasb_drab_tabel ON add_new_drab_tabel.shatb_number = kasb_drab_tabel.shatb_number WHERE date_drab >= @date1 and kasb >0", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_kasb.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_kasb
    End Sub
    '==============================================
    Public dt_select_damgha_total As New DataTable

    Public Sub Select_damgha_total(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_damgha_total.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT damgha_drab_tabel.*, add_new_drab_tabel.shatb_no,add_new_drab_tabel.date_drab, add_new_drab_tabel.total_drab FROM add_new_drab_tabel INNER JOIN damgha_drab_tabel ON add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number WHERE date_drab >= @date1 and damgha_total >0", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_damgha_total.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_damgha_total
    End Sub
    '================================
    '==============================================
    Public dt_select_arbah_t_total As New DataTable

    Public Sub Select_arbah_t_total(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_arbah_t_total.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT arbah_drab_tabel.*, add_new_drab_tabel.shatb_no,add_new_drab_tabel.date_drab, add_new_drab_tabel.total_drab FROM add_new_drab_tabel INNER JOIN arbah_drab_tabel ON add_new_drab_tabel.shatb_number = arbah_drab_tabel.shatb_number WHERE date_drab >= @date1 and arbah_t_total >0", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_arbah_t_total.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_arbah_t_total
    End Sub
    '==============================================
    Public dt_select_nwaya_total As New DataTable

    Public Sub Select_nwaya_total(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_nwaya_total.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT nwaya_drab_tabel.*, add_new_drab_tabel.shatb_no,add_new_drab_tabel.date_drab, add_new_drab_tabel.total_drab FROM add_new_drab_tabel INNER JOIN nwaya_drab_tabel ON add_new_drab_tabel.shatb_number = nwaya_drab_tabel.shatb_number WHERE date_drab >= @date1 and nwaya_total >0", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_nwaya_total.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_nwaya_total
    End Sub
    '==============================================
    Public dt_select_tanmea_total As New DataTable

    Public Sub Select_tanmea_total(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_tanmea_total.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT tanmea_drab_tabel.*, add_new_drab_tabel.shatb_no,add_new_drab_tabel.date_drab, add_new_drab_tabel.total_drab FROM add_new_drab_tabel INNER JOIN tanmea_drab_tabel ON add_new_drab_tabel.shatb_number = tanmea_drab_tabel.shatb_number WHERE date_drab >= @date1 and tanmea_total >0", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_tanmea_total.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_tanmea_total
    End Sub
    '================================
    '==============================================
    Public dt_select_kema_mdfa_total As New DataTable

    Public Sub Select_kema_mdfa_total(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_kema_mdfa_total.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT kema_mdfa_drab_tabel.*, add_new_drab_tabel.shatb_no,add_new_drab_tabel.date_drab,  add_new_drab_tabel.total_drab FROM add_new_drab_tabel INNER JOIN kema_mdfa_drab_tabel ON add_new_drab_tabel.shatb_number = kema_mdfa_drab_tabel.shatb_number WHERE date_drab >= @date1 and kema_mdfa_total >0", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_kema_mdfa_total.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_kema_mdfa_total
    End Sub
    '================================
    '================================
    '================================
    ' select shatb
    Public dt_select_shatb As New DataTable
    Public Sub select_shatb(ByVal shatb_number As String)
        dt_select_shatb.Clear()
        Dim Cmd As New OleDbCommand("select * from add_new_drab_tabel where shatb_number = @shatb_number", con)
        With Cmd
            .Connection = con
            con.Open()
            .Parameters.Clear()
            .Parameters.AddWithValue("@shatb_number", OleDbType.Integer).Value = shatb_number
            dt_select_shatb.Load(Cmd.ExecuteReader)

        End With
        con.Close()
        Cmd = Nothing
    End Sub
    '==============================
    Public dt_select_kasb_no_amr As New DataTable

    Public Sub Select_kasb_no_amr(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_kasb_no_amr.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT kasb_drab_tabel.*, add_new_drab_tabel.shatb_no, add_new_drab_tabel.total_drab FROM add_new_drab_tabel INNER JOIN kasb_drab_tabel ON add_new_drab_tabel.shatb_number = kasb_drab_tabel.shatb_number WHERE date_drab >= @date1 and kasb >0 AND kasb_drab_tabel.kasb_amr_dafa = '0'  ", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_kasb_no_amr.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_kasb_no_amr
    End Sub
    '    ===============================
    Public dt_select_damgha_total_no_amr As New DataTable

    Public Sub Select_damgha_total_no_amr(dgv As DataGridView, ByVal date1 As DateTime)
        Dim da As New OleDbDataAdapter
        dt_select_damgha_total_no_amr.Clear()
        'da = New OleDbDataAdapter("select * from add_drab WHERE date_drab = @date1", con)
        'Dim CMDSEARCH As New OleDbCommand("SELECT damgha_drab_tabel.*, add_new_drab_tabel.shatb_no, add_new_drab_tabel.total_drab, damgha_drab_tabel.damgha_amr_dafa FROM add_new_drab_tabel INNER JOIN damgha_drab_tabel ON add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number WHERE(((add_new_drab_tabel.[date_drab])>=[@date1]) AND ((damgha_drab_tabel.[damgha_total])>0) AND ((damgha_drab_tabel.damgha_amr_dafa)= 0)) ", con)
        Dim CMDSEARCH As New OleDbCommand("SELECT damgha_drab_tabel.*, add_new_drab_tabel.shatb_no, add_new_drab_tabel.total_drab, damgha_drab_tabel.damgha_amr_dafa FROM add_new_drab_tabel INNER JOIN damgha_drab_tabel ON add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number WHERE add_new_drab_tabel.[date_drab] >= @date1 AND damgha_drab_tabel.[damgha_total] > 0 AND damgha_drab_tabel.damgha_amr_dafa = '0'", con)
        '        Dim CMDSEARCH As New OleDbCommand("
        'SELECT 
        '    damgha_drab_tabel.*, 
        '    add_new_drab_tabel.shatb_no, 
        '    add_new_drab_tabel.total_drab, 
        '    damgha_drab_tabel.damgha_amr_dafa 
        'FROM 
        '    add_new_drab_tabel 
        'INNER JOIN 
        '    damgha_drab_tabel 
        'ON 
        '    add_new_drab_tabel.shatb_number = damgha_drab_tabel.shatb_number 
        'WHERE 
        '    add_new_drab_tabel.[date_drab] >= @date1 AND 
        '    damgha_drab_tabel.[damgha_total] > 0 AND 
        '    damgha_drab_tabel.damgha_amr_dafa = 0", con)

        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@date_drab", OleDbType.Date).Value = "#" & date1 & "#"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            dt_select_damgha_total_no_amr.Load(CMDSEARCH.ExecuteReader)
            con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
        'da.Fill(dt_select_drab_all)
        dgv.DataSource = dt_select_damgha_total_no_amr
    End Sub
    '==============
    '=========================================================================
    'delete _all_drab
    Public Sub delete_all_drab()


        Dim Cmd_Delete_all As New OleDbCommand
        With Cmd_Delete_all
            .Connection = con
            .CommandType = CommandType.Text
            .CommandText = "Delete * From add_new_drab_tabel where id_drab>1 "
            .Parameters.Clear()

        End With
        If con.State = 1 Then con.Close()
        con.Open()
        Cmd_Delete_all.ExecuteNonQuery()
        con.Close()
        MsgBox("تم حذف .", MsgBoxStyle.Information, "حذف")
        Cmd_Delete_all = Nothing
    End Sub
    '==============================================
End Module
