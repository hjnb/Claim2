Public Class 封筒印刷調整

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.KeyPreview = True
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 封筒印刷調整_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub initDgvHuto()
        'Util.EnableDoubleBuffering(dgvHuto)

        'With dgvHuto
        '    .AllowUserToAddRows = False '行追加禁止
        '    .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
        '    .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
        '    .AllowUserToDeleteRows = False '行削除禁止
        '    .BorderStyle = BorderStyle.FixedSingle
        '    .MultiSelect = False
        '    .SelectionMode = DataGridViewSelectionMode.CellSelect
        '    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        '    .DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
        '    .DefaultCellStyle.ForeColor = Color.Black
        '    .DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Control)
        '    .DefaultCellStyle.SelectionForeColor = Color.Black
        '    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        '    .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        '    .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    .RowHeadersWidth = 30
        '    .RowTemplate.Height = 19
        '    .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
        '    .ShowCellToolTips = True
        '    .EnableHeadersVisualStyles = False
        '    .Font = New Font("ＭＳ Ｐゴシック", 9)
        '    .ReadOnly = False
        'End With
    End Sub
End Class