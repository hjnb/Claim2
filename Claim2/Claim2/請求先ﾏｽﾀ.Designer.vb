<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 請求先ﾏｽﾀ
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NamBox = New System.Windows.Forms.TextBox()
        Me.KanaBox = New System.Windows.Forms.TextBox()
        Me.Jyu1Box = New System.Windows.Forms.TextBox()
        Me.PostBox = New System.Windows.Forms.TextBox()
        Me.Jyu2Box = New System.Windows.Forms.TextBox()
        Me.STel1Box = New System.Windows.Forms.TextBox()
        Me.SNamBox = New System.Windows.Forms.TextBox()
        Me.SJyu2Box = New System.Windows.Forms.TextBox()
        Me.SJyu1Box = New System.Windows.Forms.TextBox()
        Me.SPostBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.STel2Box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SFaxBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.STextBox = New System.Windows.Forms.TextBox()
        Me.chkTai = New System.Windows.Forms.CheckBox()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnHuto = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtnPrint = New System.Windows.Forms.RadioButton()
        Me.rbtnPreview = New System.Windows.Forms.RadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbtn3 = New System.Windows.Forms.RadioButton()
        Me.rbtn4 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "患者名"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "カナ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "〒"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "住所２"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "住所１"
        '
        'NamBox
        '
        Me.NamBox.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NamBox.Location = New System.Drawing.Point(131, 55)
        Me.NamBox.Name = "NamBox"
        Me.NamBox.Size = New System.Drawing.Size(134, 21)
        Me.NamBox.TabIndex = 5
        '
        'KanaBox
        '
        Me.KanaBox.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.KanaBox.Location = New System.Drawing.Point(131, 87)
        Me.KanaBox.Name = "KanaBox"
        Me.KanaBox.Size = New System.Drawing.Size(94, 21)
        Me.KanaBox.TabIndex = 6
        '
        'Jyu1Box
        '
        Me.Jyu1Box.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Jyu1Box.Location = New System.Drawing.Point(131, 151)
        Me.Jyu1Box.Name = "Jyu1Box"
        Me.Jyu1Box.Size = New System.Drawing.Size(237, 21)
        Me.Jyu1Box.TabIndex = 8
        '
        'PostBox
        '
        Me.PostBox.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.PostBox.Location = New System.Drawing.Point(131, 119)
        Me.PostBox.Name = "PostBox"
        Me.PostBox.Size = New System.Drawing.Size(94, 21)
        Me.PostBox.TabIndex = 7
        '
        'Jyu2Box
        '
        Me.Jyu2Box.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Jyu2Box.Location = New System.Drawing.Point(131, 183)
        Me.Jyu2Box.Name = "Jyu2Box"
        Me.Jyu2Box.Size = New System.Drawing.Size(237, 21)
        Me.Jyu2Box.TabIndex = 9
        '
        'STel1Box
        '
        Me.STel1Box.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.STel1Box.Location = New System.Drawing.Point(491, 183)
        Me.STel1Box.Name = "STel1Box"
        Me.STel1Box.Size = New System.Drawing.Size(100, 21)
        Me.STel1Box.TabIndex = 19
        '
        'SNamBox
        '
        Me.SNamBox.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SNamBox.Location = New System.Drawing.Point(491, 151)
        Me.SNamBox.Name = "SNamBox"
        Me.SNamBox.Size = New System.Drawing.Size(137, 21)
        Me.SNamBox.TabIndex = 18
        '
        'SJyu2Box
        '
        Me.SJyu2Box.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SJyu2Box.Location = New System.Drawing.Point(491, 119)
        Me.SJyu2Box.Name = "SJyu2Box"
        Me.SJyu2Box.Size = New System.Drawing.Size(237, 21)
        Me.SJyu2Box.TabIndex = 17
        '
        'SJyu1Box
        '
        Me.SJyu1Box.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SJyu1Box.Location = New System.Drawing.Point(491, 87)
        Me.SJyu1Box.Name = "SJyu1Box"
        Me.SJyu1Box.Size = New System.Drawing.Size(237, 21)
        Me.SJyu1Box.TabIndex = 16
        '
        'SPostBox
        '
        Me.SPostBox.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SPostBox.Location = New System.Drawing.Point(491, 55)
        Me.SPostBox.Name = "SPostBox"
        Me.SPostBox.Size = New System.Drawing.Size(94, 21)
        Me.SPostBox.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(437, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "電話１"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(408, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "請求先名"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label8.Location = New System.Drawing.Point(408, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 14)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "住所２"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(408, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 14)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "住所１"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label10.Location = New System.Drawing.Point(408, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "請求先　〒"
        '
        'STel2Box
        '
        Me.STel2Box.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.STel2Box.Location = New System.Drawing.Point(655, 183)
        Me.STel2Box.Name = "STel2Box"
        Me.STel2Box.Size = New System.Drawing.Size(100, 21)
        Me.STel2Box.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.Location = New System.Drawing.Point(601, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 14)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "電話２"
        '
        'SFaxBox
        '
        Me.SFaxBox.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.SFaxBox.Location = New System.Drawing.Point(815, 183)
        Me.SFaxBox.Name = "SFaxBox"
        Me.SFaxBox.Size = New System.Drawing.Size(100, 21)
        Me.SFaxBox.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label12.Location = New System.Drawing.Point(773, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 14)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Fax"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.Location = New System.Drawing.Point(437, 219)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 14)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "備考"
        '
        'STextBox
        '
        Me.STextBox.Font = New System.Drawing.Font("MS UI Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.STextBox.Location = New System.Drawing.Point(491, 216)
        Me.STextBox.Name = "STextBox"
        Me.STextBox.Size = New System.Drawing.Size(342, 21)
        Me.STextBox.TabIndex = 25
        '
        'chkTai
        '
        Me.chkTai.AutoSize = True
        Me.chkTai.Location = New System.Drawing.Point(131, 222)
        Me.chkTai.Name = "chkTai"
        Me.chkTai.Size = New System.Drawing.Size(48, 16)
        Me.chkTai.TabIndex = 26
        Me.chkTai.Text = "退院"
        Me.chkTai.UseVisualStyleBackColor = True
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(328, 275)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(71, 29)
        Me.btnRegist.TabIndex = 27
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(398, 275)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 29)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(468, 275)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(71, 29)
        Me.btnPrint.TabIndex = 29
        Me.btnPrint.Text = "印刷"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnHuto
        '
        Me.btnHuto.Location = New System.Drawing.Point(616, 275)
        Me.btnHuto.Name = "btnHuto"
        Me.btnHuto.Size = New System.Drawing.Size(71, 29)
        Me.btnHuto.TabIndex = 30
        Me.btnHuto.Text = "封筒"
        Me.btnHuto.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtnPrint)
        Me.Panel1.Controls.Add(Me.rbtnPreview)
        Me.Panel1.Location = New System.Drawing.Point(702, 275)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(151, 29)
        Me.Panel1.TabIndex = 33
        '
        'rbtnPrint
        '
        Me.rbtnPrint.AutoSize = True
        Me.rbtnPrint.Location = New System.Drawing.Point(88, 7)
        Me.rbtnPrint.Name = "rbtnPrint"
        Me.rbtnPrint.Size = New System.Drawing.Size(47, 16)
        Me.rbtnPrint.TabIndex = 34
        Me.rbtnPrint.TabStop = True
        Me.rbtnPrint.Text = "印刷"
        Me.rbtnPrint.UseVisualStyleBackColor = True
        '
        'rbtnPreview
        '
        Me.rbtnPreview.AutoSize = True
        Me.rbtnPreview.Location = New System.Drawing.Point(15, 7)
        Me.rbtnPreview.Name = "rbtnPreview"
        Me.rbtnPreview.Size = New System.Drawing.Size(63, 16)
        Me.rbtnPreview.TabIndex = 33
        Me.rbtnPreview.TabStop = True
        Me.rbtnPreview.Text = "ﾌﾟﾚﾋﾞｭｰ"
        Me.rbtnPreview.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbtn3)
        Me.Panel2.Controls.Add(Me.rbtn4)
        Me.Panel2.Location = New System.Drawing.Point(601, 310)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 29)
        Me.Panel2.TabIndex = 34
        '
        'rbtn3
        '
        Me.rbtn3.AutoSize = True
        Me.rbtn3.Location = New System.Drawing.Point(88, 7)
        Me.rbtn3.Name = "rbtn3"
        Me.rbtn3.Size = New System.Drawing.Size(65, 16)
        Me.rbtn3.TabIndex = 34
        Me.rbtn3.TabStop = True
        Me.rbtn3.Text = "長形3号"
        Me.rbtn3.UseVisualStyleBackColor = True
        '
        'rbtn4
        '
        Me.rbtn4.AutoSize = True
        Me.rbtn4.Location = New System.Drawing.Point(15, 7)
        Me.rbtn4.Name = "rbtn4"
        Me.rbtn4.Size = New System.Drawing.Size(65, 16)
        Me.rbtn4.TabIndex = 33
        Me.rbtn4.TabStop = True
        Me.rbtn4.Text = "長形4号"
        Me.rbtn4.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(765, 318)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(168, 12)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "※プリンターのプロパティを封筒に※"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 351)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(886, 364)
        Me.DataGridView1.TabIndex = 36
        '
        '請求先ﾏｽﾀ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 750)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnHuto)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.chkTai)
        Me.Controls.Add(Me.STextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.SFaxBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.STel2Box)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.STel1Box)
        Me.Controls.Add(Me.SNamBox)
        Me.Controls.Add(Me.SJyu2Box)
        Me.Controls.Add(Me.SJyu1Box)
        Me.Controls.Add(Me.SPostBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Jyu2Box)
        Me.Controls.Add(Me.Jyu1Box)
        Me.Controls.Add(Me.PostBox)
        Me.Controls.Add(Me.KanaBox)
        Me.Controls.Add(Me.NamBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "請求先ﾏｽﾀ"
        Me.Text = "請求先ﾏｽﾀ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NamBox As System.Windows.Forms.TextBox
    Friend WithEvents KanaBox As System.Windows.Forms.TextBox
    Friend WithEvents Jyu1Box As System.Windows.Forms.TextBox
    Friend WithEvents PostBox As System.Windows.Forms.TextBox
    Friend WithEvents Jyu2Box As System.Windows.Forms.TextBox
    Friend WithEvents STel1Box As System.Windows.Forms.TextBox
    Friend WithEvents SNamBox As System.Windows.Forms.TextBox
    Friend WithEvents SJyu2Box As System.Windows.Forms.TextBox
    Friend WithEvents SJyu1Box As System.Windows.Forms.TextBox
    Friend WithEvents SPostBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents STel2Box As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SFaxBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents STextBox As System.Windows.Forms.TextBox
    Friend WithEvents chkTai As System.Windows.Forms.CheckBox
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnHuto As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbtnPrint As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnPreview As System.Windows.Forms.RadioButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbtn3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
