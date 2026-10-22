Namespace NumberToWord
	Partial Public Class number_to_word_UserControl1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.txtArabicWord = New System.Windows.Forms.TextBox()
            Me.txtEnglishWord = New System.Windows.Forms.TextBox()
            Me.txtNumber = New System.Windows.Forms.TextBox()
            Me.cboCurrency = New System.Windows.Forms.ComboBox()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.AutoScroll = True
            Me.panel1.BackColor = System.Drawing.Color.DarkGoldenrod
            Me.panel1.Controls.Add(Me.txtArabicWord)
            Me.panel1.Controls.Add(Me.txtEnglishWord)
            Me.panel1.Controls.Add(Me.txtNumber)
            Me.panel1.Controls.Add(Me.cboCurrency)
            Me.panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.panel1.Location = New System.Drawing.Point(3, 3)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(600, 103)
            Me.panel1.TabIndex = 0
            '
            'txtArabicWord
            '
            Me.txtArabicWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtArabicWord.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtArabicWord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtArabicWord.Location = New System.Drawing.Point(15, 37)
            Me.txtArabicWord.Multiline = True
            Me.txtArabicWord.Name = "txtArabicWord"
            Me.txtArabicWord.ReadOnly = True
            Me.txtArabicWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.txtArabicWord.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtArabicWord.Size = New System.Drawing.Size(582, 29)
            Me.txtArabicWord.TabIndex = 10
            '
            'txtEnglishWord
            '
            Me.txtEnglishWord.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtEnglishWord.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEnglishWord.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.txtEnglishWord.Location = New System.Drawing.Point(15, 72)
            Me.txtEnglishWord.Multiline = True
            Me.txtEnglishWord.Name = "txtEnglishWord"
            Me.txtEnglishWord.ReadOnly = True
            Me.txtEnglishWord.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.txtEnglishWord.Size = New System.Drawing.Size(582, 23)
            Me.txtEnglishWord.TabIndex = 9
            '
            'txtNumber
            '
            Me.txtNumber.ForeColor = System.Drawing.Color.Blue
            Me.txtNumber.Location = New System.Drawing.Point(266, 1)
            Me.txtNumber.Name = "txtNumber"
            Me.txtNumber.Size = New System.Drawing.Size(187, 30)
            Me.txtNumber.TabIndex = 8
            '
            'cboCurrency
            '
            Me.cboCurrency.DisplayMember = "EnglishCurrencyName"
            Me.cboCurrency.FormattingEnabled = True
            Me.cboCurrency.Items.AddRange(New Object() {"Saudi Riyal"})
            Me.cboCurrency.Location = New System.Drawing.Point(459, 0)
            Me.cboCurrency.Name = "cboCurrency"
            Me.cboCurrency.Size = New System.Drawing.Size(138, 31)
            Me.cboCurrency.TabIndex = 7
            Me.cboCurrency.Text = "Saudi Riyal"
            Me.cboCurrency.ValueMember = "CurrencyID"
            '
            'number_to_word_UserControl1
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.AutoScroll = True
            Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "number_to_word_UserControl1"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.Size = New System.Drawing.Size(610, 113)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private txtArabicWord As System.Windows.Forms.TextBox
		Private txtEnglishWord As System.Windows.Forms.TextBox
		Private WithEvents txtNumber As System.Windows.Forms.TextBox
		Private cboCurrency As System.Windows.Forms.ComboBox
	End Class
End Namespace
