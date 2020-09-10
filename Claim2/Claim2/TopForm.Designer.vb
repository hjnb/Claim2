<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnClaim2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.topPicture = New System.Windows.Forms.PictureBox()
        CType(Me.topPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 69)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(237, 69)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(89, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(237, 69)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnClaim2
        '
        Me.btnClaim2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnClaim2.Location = New System.Drawing.Point(89, 196)
        Me.btnClaim2.Name = "btnClaim2"
        Me.btnClaim2.Size = New System.Drawing.Size(237, 69)
        Me.btnClaim2.TabIndex = 2
        Me.btnClaim2.Text = "請求先ﾏｽﾀ"
        Me.btnClaim2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(89, 468)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(237, 69)
        Me.Button5.TabIndex = 6
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(89, 400)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(237, 69)
        Me.Button6.TabIndex = 5
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(89, 332)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(237, 69)
        Me.Button7.TabIndex = 4
        Me.Button7.UseVisualStyleBackColor = True
        '
        'topPicture
        '
        Me.topPicture.Location = New System.Drawing.Point(451, 60)
        Me.topPicture.Name = "topPicture"
        Me.topPicture.Size = New System.Drawing.Size(98, 96)
        Me.topPicture.TabIndex = 7
        Me.topPicture.TabStop = False
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 578)
        Me.Controls.Add(Me.topPicture)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnClaim2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "TopForm"
        Me.Text = "請求書"
        CType(Me.topPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnClaim2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents topPicture As System.Windows.Forms.PictureBox

End Class
