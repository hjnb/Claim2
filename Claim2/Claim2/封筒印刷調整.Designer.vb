<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 封筒印刷調整
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
        Me.dgvHuto = New System.Windows.Forms.DataGridView()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvHuto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHuto
        '
        Me.dgvHuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHuto.Location = New System.Drawing.Point(32, 67)
        Me.dgvHuto.Name = "dgvHuto"
        Me.dgvHuto.RowTemplate.Height = 21
        Me.dgvHuto.Size = New System.Drawing.Size(436, 232)
        Me.dgvHuto.TabIndex = 0
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(374, 16)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(94, 33)
        Me.btnRegist.TabIndex = 1
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "封筒の文字位置設定"
        '
        '封筒印刷調整
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 326)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.dgvHuto)
        Me.Name = "封筒印刷調整"
        Me.Text = "封筒印刷調整"
        CType(Me.dgvHuto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvHuto As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
