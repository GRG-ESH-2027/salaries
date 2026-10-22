Public Class Form_select_text

    '=====================================
    Public Sub textbox_to_deciemal(ByVal textbox As TextBox)
        If textbox.Text = "" Then
            textbox.Text = 0
        Else
            textbox.Text = Format(Double.Parse(textbox.Text), "########0.00")
        End If
    End Sub
    '=================
    Sub noused_char(ByVal e As KeyPressEventArgs)
        If e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9" Or e.KeyChar = "." Or e.KeyChar = "+" Or e.KeyChar = "-" Or e.KeyChar = "*" Or e.KeyChar = "/" Or e.KeyChar = ControlChars.Back Or e.KeyChar = "v" Or e.KeyChar = ControlChars.CrLf Then
            Exit Sub
        Else
            e.KeyChar = ""
            'MessageBox.Show((e.KeyChar).ToString())
            'cal_form.RichTextBox1.Text = (e.KeyChar).ToString()
        End If
    End Sub


    '====================

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, TextBox1.AcceptsTabChanged
        TextBox1.Text = ""
        Me.no1.Text = vbNullString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.no1.Text = vbNullString
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        textbox_to_deciemal(TextBox1)

        'TextBox1.SelectedText = TextBox1.Text.Length()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = TextBox1.Text.Length

        Clipboard.SetText(TextBox1.Text)
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = TextBox1.Text.Length

        Clipboard.SetText(TextBox1.Text)
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        no1.Value = Clipboard.GetText()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        noused_char(e)
    End Sub
End Class
