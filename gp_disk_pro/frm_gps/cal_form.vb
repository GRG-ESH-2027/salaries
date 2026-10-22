Public Class cal_form
    Public e_char As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()

    End Sub
    Shared Function IsChar(ByVal ch As Char) As Boolean
        If (AscW(ch) >= 65 AndAlso AscW(ch) <= 90) OrElse (AscW(ch) >= 97 AndAlso AscW(ch) <= 122) Then
            Return True
        Else
            Return False
        End If

    End Function
    Shared Function Purification(ByVal str As String) As Boolean
        For i As Integer = 0 To str.Length - 1
            If IsChar(str.Chars(i)) = True Then
                Return False
            End If
        Next i

        Dim isClac As Integer = 0
        For i As Integer = 0 To str.Length - 1
            If str.Chars(i) = "+"c OrElse str.Chars(i) = "-"c OrElse str.Chars(i) = "*"c OrElse str.Chars(i) = "/"c Then
                isClac += 1
            End If
        Next i

        If isClac > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Shared Function Prograssing(ByVal pr As String) As Double
        Try
            Dim numbersNo As Integer = 0
            Dim shpeNo As Integer = 0
            For i As Integer = 0 To pr.Length - 1 ' لمعرفة عدد الأ}قام وعدد العمليات الحسابية

                If pr.Chars(i) = "+"c OrElse pr.Chars(i) = "-"c OrElse pr.Chars(i) = "*"c OrElse pr.Chars(i) = "/"c Then
                    shpeNo += 1
                End If
            Next i

            numbersNo = shpeNo + 1
            ' إنشاء مصفوفتين للأعداد والعمليات الحسابية
            Dim numFileds(numbersNo - 1) As String
            Dim shpeFileds(shpeNo - 1) As Char
            ' وضع الأرقام بداخل المصفوفة
            Dim [step] As Integer = 0
            For i As Integer = 0 To pr.Length - 1
                If pr.Chars(i) <> "+"c AndAlso pr.Chars(i) <> "-"c AndAlso pr.Chars(i) <> "*"c AndAlso pr.Chars(i) <> "/"c Then
                    numFileds([step]) &= pr.Chars(i)
                Else
                    [step] += 1
                End If
            Next i
            [step] = 0
            For i As Integer = 0 To pr.Length - 1 ' وضع العمليات الحسابية داخل المصفوفة
                If [step] <> shpeFileds.Length Then
                    If pr.Chars(i) = "+"c OrElse pr.Chars(i) = "-"c OrElse pr.Chars(i) = "*"c OrElse pr.Chars(i) = "/"c Then
                        shpeFileds([step]) = pr.Chars(i)
                        [step] += 1
                    End If
                End If
            Next i

            Dim Total As Double = 0.0

            For i As Integer = 0 To shpeFileds.Length - 1 ' لإجراء العمليات المطلوبه
                If i = shpeFileds.Length - 1 Then
                    If i = 0 Then
                        If shpeFileds(i) = "+"c Then
                            Total += Double.Parse(numFileds(numFileds.Length - 2)) + Double.Parse(numFileds(numFileds.Length - 1))
                        ElseIf shpeFileds(i) = "-"c Then
                            Total += Double.Parse(numFileds(numFileds.Length - 2)) - Double.Parse(numFileds(numFileds.Length - 1))
                        ElseIf shpeFileds(i) = "*"c Then
                            Total += Double.Parse(numFileds(numFileds.Length - 2)) * Double.Parse(numFileds(numFileds.Length - 1))
                        ElseIf shpeFileds(i) = "/"c Then
                            Total += Double.Parse(numFileds(numFileds.Length - 2)) / Double.Parse(numFileds(numFileds.Length - 1))
                        End If
                    Else
                        If shpeFileds(i) = "+"c Then
                            Total += Double.Parse(numFileds(numFileds.Length - 1))
                        ElseIf shpeFileds(i) = "-"c Then
                            Total -= Double.Parse(numFileds(numFileds.Length - 1))
                        ElseIf shpeFileds(i) = "*"c Then
                            Total *= Double.Parse(numFileds(numFileds.Length - 1))
                        ElseIf shpeFileds(i) = "/"c Then
                            Total /= Double.Parse(numFileds(numFileds.Length - 1))
                        End If
                    End If
                Else
                    If i = 0 Then
                        If shpeFileds(i) = "+"c Then
                            Total += Double.Parse(numFileds(0)) + Double.Parse(numFileds(1))
                        ElseIf shpeFileds(i) = "-"c Then
                            Total += Double.Parse(numFileds(0)) - Double.Parse(numFileds(1))
                        ElseIf shpeFileds(i) = "*"c Then
                            Total += Double.Parse(numFileds(0)) * Double.Parse(numFileds(1))
                        ElseIf shpeFileds(i) = "/"c Then
                            Total += Double.Parse(numFileds(0)) / Double.Parse(numFileds(1))
                        End If
                    Else
                        If shpeFileds(i) = "+"c Then
                            Total += Double.Parse(numFileds(i + 1))
                        ElseIf shpeFileds(i) = "-"c Then
                            Total -= Double.Parse(numFileds(i + 1))
                        ElseIf shpeFileds(i) = "*"c Then
                            Total *= Double.Parse(numFileds(i + 1))
                        ElseIf shpeFileds(i) = "/"c Then
                            Total /= Double.Parse(numFileds(i + 1))
                        End If
                    End If
                End If
            Next i

            Return Total
        Catch ex As Exception
            'Console.WriteLine(ex.Message)
            'Console.ReadKey()
            MessageBox.Show(ex.Message)
            Return 0.0
        End Try
    End Function



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try


            Dim calculation As String = ""
            For i As Integer = 0 To 0
                calculation = TextBox1.Text
                If calculation = "q" OrElse calculation = "Q" Then
                    Exit For
                End If
                Dim ok As Boolean = Purification(calculation)
                If ok = True Then
                    'Start Prograssing:
                    Dim Total As Double = Prograssing(calculation)
                    'Console.WriteLine("The total Is : {0}", Total)
                    TextBox2.Text = Convert.ToString(Total)
                    Label1.Text = Convert.ToString(Total)
                    RichTextBox1.Text += TextBox1.Text + " =" + Convert.ToString(Total) + vbNewLine + "==========" + vbNewLine
                    'MessageBox.Show(Convert.ToString(Total))
                    'i -= 1
                Else
                    'Console.WriteLine("Please dont enter letters..")
                    'PrintHelpMenu()
                    'Console.ReadKey()
                    'Console.Clear()
                    i -= 1
                End If
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text += "0"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text += "1"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Text += "2"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text += "3"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text += "4"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text += "5"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text += "6"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text += "7"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text += "8"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text += "9"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text += "+"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text += "-"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text += "*"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text += "/"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim calculation As String = ""
        For i As Integer = 0 To 0
            calculation = TextBox1.Text
            If calculation = "q" OrElse calculation = "Q" Then
                Exit For
            End If
            Dim ok As Boolean = Purification(calculation)
            If ok = True Then
                'Start Prograssing:
                Dim Total As Double = Prograssing(calculation)
                'Console.WriteLine("The total Is : {0}", Total)
                TextBox2.Text = Convert.ToString(Total)
                Label1.Text = Convert.ToString(Total)
                'MessageBox.Show(Convert.ToString(Total))
                'i -= 1
            Else

                i -= 1
            End If
        Next i
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Clear()
        TextBox2.Clear()
        Label1.Text = "0"

    End Sub

    Private Sub Button14_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim pr As String = TextBox1.Text

        If pr.Chars(pr.Length - 1) = "-" Or pr.Chars(pr.Length - 1) = "+" Or pr.Chars(pr.Length - 1) = "/" Then

            TextBox1.Text = pr.Substring(0, pr.Length - 1)
            char_as("*")

        Else

            char_as("*")
        End If
    End Sub

    Private Sub Button10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Dim pr As String = TextBox1.Text

        If pr.Chars(pr.Length - 1) = "-" Or pr.Chars(pr.Length - 1) = "*" Or pr.Chars(pr.Length - 1) = "/" Then

            TextBox1.Text = pr.Substring(0, pr.Length - 1)
            char_as("+")

        Else

            char_as("+")
        End If


    End Sub

    Private Sub Button15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        Dim pr As String = TextBox1.Text

        If pr.Chars(pr.Length - 1) = "+" Or pr.Chars(pr.Length - 1) = "*" Or pr.Chars(pr.Length - 1) = "/" Then

            TextBox1.Text = pr.Substring(0, pr.Length - 1)
            char_as("-")

        Else

            char_as("-")
        End If
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text += "9"
    End Sub

    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click

        Dim pr As String = TextBox1.Text

        If pr.Chars(pr.Length - 1) = "-" Or pr.Chars(pr.Length - 1) = "*" Or pr.Chars(pr.Length - 1) = "+" Then

            TextBox1.Text = pr.Substring(0, pr.Length - 1)
            char_as("/")

        Else

            char_as("/")
        End If
    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Label1.Text = "0"
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try


            Dim calculation As String = ""
            For i As Integer = 0 To 0
                calculation = TextBox1.Text
                If calculation = "q" OrElse calculation = "Q" Then
                    Exit For
                End If
                Dim ok As Boolean = Purification(calculation)
                If ok = True Then
                    'Start Prograssing:
                    Dim Total As Double = Prograssing(calculation)
                    'Console.WriteLine("The total Is : {0}", Total)
                    TextBox2.Text = Convert.ToString(Total)
                    Label1.Text = Convert.ToString(Total)
                    RichTextBox1.Text += TextBox1.Text + " =" + Convert.ToString(Total) + vbNewLine + "==========" + vbNewLine
                    'MessageBox.Show(Convert.ToString(Total))
                    'i -= 1
                Else

                    i -= 1
                End If
            Next i
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TextBox1.Text += "."
    End Sub



    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If TextBox1.TextLength > 0 Then
            Dim clear As String
            clear = TextBox1.Text
            TextBox1.Text = clear.Substring(0, clear.Length - 1)

        End If
    End Sub


    Shared Function add_string(ByVal pr As String) As Double
        Try
            ' لمعرفة عدد العمليات الحسابية
            Dim shpeNo As Integer = 0
            For i As Integer = 0 To pr.Length - 1
                If pr.Chars(i) = "+"c OrElse pr.Chars(i) = "-"c OrElse pr.Chars(i) = "*"c OrElse pr.Chars(i) = "/"c Then
                    shpeNo += 1
                End If
            Next

            ' عدد الأرقام = عدد العمليات + 1
            Dim numbersNo As Integer = shpeNo + 1
            Dim numFileds(numbersNo - 1) As String
            Dim shpeFileds(shpeNo - 1) As Char

            ' تقسيم النص إلى أرقام وعمليات
            Dim stepIndex As Integer = 0
            Dim opIndex As Integer = 0
            For i As Integer = 0 To pr.Length - 1
                If pr.Chars(i) <> "+"c AndAlso pr.Chars(i) <> "-"c AndAlso pr.Chars(i) <> "*"c AndAlso pr.Chars(i) <> "/"c Then
                    numFileds(stepIndex) &= pr.Chars(i)
                Else
                    shpeFileds(opIndex) = pr.Chars(i)
                    stepIndex += 1
                    opIndex += 1
                End If
            Next

            ' تحويل النصوص إلى أرقام
            Dim numbers(numbersNo - 1) As Double
            For i As Integer = 0 To numbersNo - 1
                Double.TryParse(numFileds(i), numbers(i))
            Next

            ' تنفيذ العمليات الحسابية بالترتيب (من اليسار لليمين)
            Dim result As Double = numbers(0)
            For i As Integer = 0 To shpeNo - 1
                Select Case shpeFileds(i)
                    Case "+"c
                        result += numbers(i + 1)
                    Case "-"c
                        result -= numbers(i + 1)
                    Case "*"c
                        result *= numbers(i + 1)
                    Case "/"c
                        If numbers(i + 1) <> 0 Then
                            result /= numbers(i + 1)
                        Else
                            Throw New DivideByZeroException("القسمة على صفر غير مسموحة")
                        End If
                End Select
            Next

            Return result
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
            Return 0
        End Try
    End Function






    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        noused_char(e)
        If e.KeyChar = "+" Then

            e_char = e.KeyChar
            e.KeyChar = ""

            Button10_Click_1(sender, e)

        ElseIf e.KeyChar = "-" Then

            e_char = e.KeyChar
            e.KeyChar = ""

            Button15_Click_1(sender, e)

        ElseIf e.KeyChar = "*" Then

            e_char = e.KeyChar
            e.KeyChar = ""

            Button14_Click_1(sender, e)
        ElseIf e.KeyChar = "/" Then
            e_char = e.KeyChar
            e.KeyChar = ""

            Button16_Click_1(sender, e)
        Else

        End If


        TextBox1.Focus()
        TextBox1.SelectionStart = TextBox1.Text.Length
        'End If

    End Sub





    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then

            Button1_Click(sender, e)
            TextBox1.Focus()
        End If
        '==================
        If e.KeyCode = Keys.Delete Then

            TextBox1.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Public Sub char_as(ByVal charc As String)
        If TextBox1.TextLength > 0 Then
            'Dim numbersNo As Integer = 0
            Dim pr As String = TextBox1.Text



            If pr.Chars(pr.Length - 1) = charc Then

                TextBox1.Text = pr.Substring(0, pr.Length - 1)
                TextBox1.Text += charc

            ElseIf pr.Chars(pr.Length - 1) = charc And pr.Chars(0) = charc Then

                TextBox1.Text = pr.Substring(1, pr.Length - 1)
                TextBox1.Text = pr.Substring(0, pr.Length - 1)
            ElseIf pr.Chars(0) = charc Then
                TextBox1.Text = pr.Substring(1, pr.Length - 1)
            Else
                TextBox1.Text += charc
            End If
            If pr.Chars(0) = charc Then

                TextBox1.Text = pr.Substring(1, pr.Length - 1)

            End If
            'End If
            'MessageBox.Show(Convert.ToString(pr.Chars(pr.Length - 1)))
        End If
    End Sub
End Class
