Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace NumberToWord
	Partial Public Class number_to_word_UserControl1
		Inherits UserControl

        Private currencies As New List(Of CurrencyInfo)()
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub number_to_word_UserControl1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia))
			currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.UAE))
			currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.SaudiArabia))
			currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.Tunisia))
			currencies.Add(New CurrencyInfo(CurrencyInfo.Currencies.Gold))

			cboCurrency.DataSource = currencies

            cboCurrency_DropDownClosed(Nothing, Nothing)
            txtNumber.Text = Form_print_tfrgh.NumericUpDown3.Value.ToString()
		End Sub
		Private Sub cboCurrency_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
			txtNumber_TextChanged(Nothing, Nothing)
		End Sub

		Private Sub txtNumber_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Try
				Dim toWord As New ToWord(Convert.ToDecimal(txtNumber.Text), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
				txtEnglishWord.Text = toWord.ConvertToEnglish()
				txtArabicWord.Text = toWord.ConvertToArabic()
			Catch ex As Exception
				txtEnglishWord.Text = String.Empty
				txtArabicWord.Text = String.Empty
			End Try
		End Sub


		Private Sub txtNumber_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txtNumber.TextChanged
            Try


                Form_print_tfrgh.total_saffy_sanwy()

                Dim toWord As New ToWord(Convert.ToDecimal(txtNumber.Text), currencies(Convert.ToInt32(cboCurrency.SelectedValue)))
                txtEnglishWord.Text = toWord.ConvertToEnglish()
                txtArabicWord.Text = toWord.ConvertToArabic()
            Catch ex As Exception
                txtEnglishWord.Text = String.Empty
                txtArabicWord.Text = String.Empty
            End Try

		End Sub



    End Class
End Namespace
