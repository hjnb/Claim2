Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices

Public Class 請求先ﾏｽﾀ

    Private searchForm As 検索

    ''' <summary>
    ''' 行ヘッダーのカレントセルを表す三角マークを非表示に設定する為のクラス。
    ''' </summary>
    ''' <remarks></remarks>
    Public Class dgvRowHeaderCell

        'DataGridViewRowHeaderCell を継承
        Inherits DataGridViewRowHeaderCell

        'DataGridViewHeaderCell.Paint をオーバーライドして行ヘッダーを描画
        Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, _
           ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, _
           ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, _
           ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, _
           ByVal paintParts As DataGridViewPaintParts)
            '標準セルの描画からセル内容の背景だけ除いた物を描画(-5)
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, _
                     formattedValue, errorText, cellStyle, advancedBorderStyle, _
                     Not DataGridViewPaintParts.ContentBackground)
        End Sub

    End Class

    ''' <summary>
    ''' keyDownイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 請求先ﾏｽﾀ_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 請求先ﾏｽﾀ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '画面サイズ等
        Me.WindowState = FormWindowState.Maximized
        Me.KeyPreview = True

        initDgvNamM()
        displayDgvNamM()
        initPrintState()
    End Sub

    ''' <summary>
    ''' 印刷ラジオボタン初期値設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initPrintState()
        Dim state As String = Util.getIniString("System", "Printer", topForm.iniFilePath)
        If state = "Y" Then
            rbtnPrint.Checked = True
        Else
            rbtnPreview.Checked = True
        End If
    End Sub

    ''' <summary>
    ''' ﾌﾟﾚﾋﾞｭｰラジオボタン値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbtnPreview_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbtnPreview.CheckedChanged
        If rbtnPreview.Checked = True Then
            Util.putIniString("System", "Printer", "N", topForm.iniFilePath)
        End If
    End Sub

    ''' <summary>
    ''' 印刷ラジオボタン値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbtnPrint_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbtnPrint.CheckedChanged
        If rbtnPrint.Checked = True Then
            Util.putIniString("System", "Printer", "Y", topForm.iniFilePath)
        End If
    End Sub

    ''' <summary>
    ''' データグリッドビュー初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDgvNamM()
        Util.EnableDoubleBuffering(dgvNamM)

        With dgvNamM
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .BorderStyle = BorderStyle.FixedSingle
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersWidth = 30
            .RowTemplate.Height = 19
            .RowTemplate.HeaderCell = New dgvRowHeaderCell() '行ヘッダの三角マークを非表示に
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .ShowCellToolTips = True
            .EnableHeadersVisualStyles = False
            .Font = New Font("ＭＳ Ｐゴシック", 9)
            .ReadOnly = False
        End With
    End Sub

    ''' <summary>
    ''' マスタデータ表示
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub displayDgvNamM()
        'クリア
        dgvNamM.Columns.Clear()

        'データ取得、表示
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Claim2)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select Tai, Nam, Kana, Post, Jyu1, Jyu2, SPost, SJyu1, SJyu2, SNam, STel1, STel2, SFax, SText from Nam order by Kana"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "NamM")
        Dim dt As DataTable = ds.Tables("NamM")
        dgvNamM.DataSource = dt
        dgvNamM.ClearSelection()

        '列追加
        dt.Columns.Add("Huto", GetType(Boolean)) '封筒
        For Each row As DataGridViewRow In dgvNamM.Rows
            row.Cells("Huto").Value = False
        Next

        '幅設定等
        With dgvNamM

            .Columns("Post").Visible = False
            .Columns("Jyu1").Visible = False
            .Columns("Jyu2").Visible = False
            .Columns("SFax").Visible = False

            With .Columns("Huto")
                .DisplayIndex = 0
                .HeaderText = "封"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 30
            End With
            With .Columns("Tai")
                .HeaderText = "退"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 30
                .ReadOnly = True
            End With
            With .Columns("Nam")
                .HeaderText = "患者名"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
                .ReadOnly = True
            End With
            With .Columns("Kana")
                .HeaderText = "ｶﾅ"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 60
                .ReadOnly = True
            End With
            With .Columns("SPost")
                .HeaderText = "請求先 〒"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 80
                .ReadOnly = True
            End With
            With .Columns("SJyu1")
                .HeaderText = "住所１"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 160
                .ReadOnly = True
            End With
            With .Columns("SJyu2")
                .HeaderText = "住所２"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 160
                .ReadOnly = True
            End With
            With .Columns("SNam")
                .HeaderText = "請求先名"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
                .ReadOnly = True
            End With
            With .Columns("STel1")
                .HeaderText = "電話１"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
                .ReadOnly = True
            End With
            With .Columns("STel2")
                .HeaderText = "電話２"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 90
                .ReadOnly = True
            End With
            With .Columns("SText")
                .HeaderText = "備考"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 200
                .ReadOnly = True
            End With
        End With

    End Sub

    ''' <summary>
    ''' 入力内容クリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInput()
        NamBox.Text = ""
        KanaBox.Text = ""
        PostBox.Text = ""
        Jyu1Box.Text = ""
        Jyu2Box.Text = ""
        chkTai.Checked = False
        SPostBox.Text = ""
        SJyu1Box.Text = ""
        SJyu2Box.Text = ""
        SNamBox.Text = ""
        STel1Box.Text = ""
        STel2Box.Text = ""
        SFaxBox.Text = ""
        STextBox.Text = ""
    End Sub

    ''' <summary>
    ''' 選択行データ表示
    ''' </summary>
    ''' <param name="selectedRow"></param>
    ''' <remarks></remarks>
    Public Sub displayInfo(selectedRow As DataGridViewRow)
        Dim nam As String = Util.checkDBNullValue(selectedRow.Cells("Nam").Value)
        Dim kana As String = Util.checkDBNullValue(selectedRow.Cells("Kana").Value)
        Dim post As String = Util.checkDBNullValue(selectedRow.Cells("Post").Value)
        Dim jyu1 As String = Util.checkDBNullValue(selectedRow.Cells("Jyu1").Value)
        Dim jyu2 As String = Util.checkDBNullValue(selectedRow.Cells("Jyu2").Value)
        Dim tai As String = selectedRow.Cells("Tai").Value
        Dim sPost As String = Util.checkDBNullValue(selectedRow.Cells("SPost").Value)
        Dim sJyu1 As String = Util.checkDBNullValue(selectedRow.Cells("SJyu1").Value)
        Dim sJyu2 As String = Util.checkDBNullValue(selectedRow.Cells("SJyu2").Value)
        Dim sNam As String = Util.checkDBNullValue(selectedRow.Cells("SNam").Value)
        Dim sTel1 As String = Util.checkDBNullValue(selectedRow.Cells("STel1").Value)
        Dim sTel2 As String = Util.checkDBNullValue(selectedRow.Cells("STel2").Value)
        Dim sFax As String = Util.checkDBNullValue(selectedRow.Cells("SFax").Value)
        Dim sText As String = Util.checkDBNullValue(selectedRow.Cells("SText").Value)

        clearInput()

        NamBox.Text = nam
        KanaBox.Text = kana
        PostBox.Text = post
        Jyu1Box.Text = jyu1
        Jyu2Box.Text = jyu2
        chkTai.Checked = If(tai = 1, True, False)
        SPostBox.Text = sPost
        SJyu1Box.Text = sJyu1
        SJyu2Box.Text = sJyu2
        SNamBox.Text = sNam
        STel1Box.Text = sTel1
        STel2Box.Text = sTel2
        SFaxBox.Text = sFax
        STextBox.Text = sText
    End Sub

    Private Sub dgvNamM_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvNamM.CellFormatting
        If e.RowIndex >= 0 Then
            Dim columnName As String = dgvNamM.Columns(e.ColumnIndex).Name
            If columnName = "Tai" Then
                If e.Value = 1 Then
                    e.Value = "退"
                Else
                    e.Value = ""
                End If
                e.FormattingApplied = True
            End If

        End If
    End Sub

    Private Sub dgvNamM_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvNamM.CellMouseClick
        If e.RowIndex >= 0 Then
            '選択データ表示
            displayInfo(dgvNamM.Rows(e.RowIndex))
        End If
    End Sub

    ''' <summary>
    ''' CellPaintingイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvMaster_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvNamM.CellPainting
        '行ヘッダーかどうか調べる
        If e.ColumnIndex < 0 AndAlso e.RowIndex >= 0 Then
            'セルを描画する
            e.Paint(e.ClipBounds, DataGridViewPaintParts.All)

            '行番号を描画する範囲を決定する
            'e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
            Dim indexRect As Rectangle = e.CellBounds
            indexRect.Inflate(-2, -2)
            '行番号を描画する
            TextRenderer.DrawText(e.Graphics, _
                (e.RowIndex + 1).ToString(), _
                e.CellStyle.Font, _
                indexRect, _
                e.CellStyle.ForeColor, _
                TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
            '描画が完了したことを知らせる
            e.Handled = True
        End If

        '選択したセルに枠を付ける
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 AndAlso (e.PaintParts And DataGridViewPaintParts.Background) = DataGridViewPaintParts.Background Then
            e.Graphics.FillRectangle(New SolidBrush(e.CellStyle.BackColor), e.CellBounds)

            If (e.PaintParts And DataGridViewPaintParts.SelectionBackground) = DataGridViewPaintParts.SelectionBackground AndAlso (e.State And DataGridViewElementStates.Selected) = DataGridViewElementStates.Selected Then
                e.Graphics.DrawRectangle(New Pen(Color.Black, 2I), e.CellBounds.X + 1I, e.CellBounds.Y + 1I, e.CellBounds.Width - 3I, e.CellBounds.Height - 3I)
            End If

            Dim pParts As DataGridViewPaintParts = e.PaintParts And Not DataGridViewPaintParts.Background
            e.Paint(e.ClipBounds, pParts)
            e.Handled = True
        End If
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click
        '氏名
        Dim nam As String = NamBox.Text
        If nam = "" Then
            MsgBox("氏名を入力して下さい。", MsgBoxStyle.Exclamation)
            NamBox.Focus()
            Return
        End If
        'カナ
        Dim kana As String = KanaBox.Text
        kana = StrConv(kana, VbStrConv.Narrow)
        If kana = "" Then
            MsgBox("ｶﾅを入力して下さい。", MsgBoxStyle.Exclamation)
            KanaBox.Focus()
            Return
        End If
        '〒
        Dim post As String = PostBox.Text
        '住所１
        Dim jyu1 As String = Jyu1Box.Text
        '住所２
        Dim jyu2 As String = Jyu2Box.Text
        '退院
        Dim tai As Integer = If(chkTai.Checked, 1, 0)
        '請求先〒
        Dim sPost As String = SPostBox.Text
        '請求先住所１
        Dim sJyu1 As String = SJyu1Box.Text
        '請求先住所２
        Dim sJyu2 As String = SJyu2Box.Text
        '請求先名
        Dim sNam As String = SNamBox.Text
        '請求先電話1
        Dim sTel1 As String = STel1Box.Text
        '請求先電話2
        Dim sTel2 As String = STel2Box.Text
        '請求先Fax
        Dim sFax As String = SFaxBox.Text
        '備考
        Dim sText As String = STextBox.Text

        '登録
        Dim addFlg As Boolean = False
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Claim2)
        Dim sql As String = "select * from Nam where Kana = '" & kana & "'"
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount <= 0 Then
            addFlg = True
            rs.AddNew()
        End If
        rs.Fields("Nam").Value = nam
        rs.Fields("Kana").Value = kana
        rs.Fields("Post").Value = post
        rs.Fields("Jyu1").Value = jyu1
        rs.Fields("Jyu2").Value = jyu2
        rs.Fields("SPost").Value = sPost
        rs.Fields("SJyu1").Value = sJyu1
        rs.Fields("SJyu2").Value = sJyu2
        rs.Fields("SNam").Value = sNam
        rs.Fields("STel1").Value = sTel1
        rs.Fields("STel2").Value = sTel2
        rs.Fields("SFax").Value = sFax
        rs.Fields("SText").Value = sText
        rs.Update()
        rs.Close()
        cn.Close()

        If addFlg Then
            MsgBox("追加しました。", MsgBoxStyle.Information)
        Else
            MsgBox("変更しました。", MsgBoxStyle.Information)
        End If

        '再表示
        clearInput()
        displayDgvNamM()

        '事前に入力していたデータを選択、表示
        Dim targetNam As String = nam
        For i As Integer = 0 To dgvNamM.Rows.Count - 1
            Dim dgvNam As String = Util.checkDBNullValue(dgvNamM("Nam", i).Value)
            If dgvNam = targetNam Then
                displayInfo(dgvNamM.Rows(i))
                dgvNamM.Rows(i).Selected = True
                dgvNamM.FirstDisplayedScrollingRowIndex = i
            End If
        Next

    End Sub

    ''' <summary>
    ''' 削除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        'カナ
        Dim kana As String = KanaBox.Text
        If kana = "" Then
            MsgBox("削除対象データを選択して下さい。", MsgBoxStyle.Exclamation)
            Return
        End If

        '削除処理
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Claim2)
        Dim sql As String = "select * from Nam where Kana = '" & kana & "'"
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount <= 0 Then
            rs.Close()
            cn.Close()
            MsgBox("カナ： " & kana & " は登録されていません。", MsgBoxStyle.Exclamation)
            Return
        Else
            Dim result As DialogResult = MessageBox.Show("削除してよろしいですか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = Windows.Forms.DialogResult.Yes Then
                rs.Delete()
                rs.Update()
                rs.Close()
                cn.Close()

                MsgBox("削除しました。", MsgBoxStyle.Information)

                '再表示
                clearInput()
                displayDgvNamM()
            Else
                rs.Close()
                cn.Close()
            End If
        End If

    End Sub

    ''' <summary>
    ''' 印刷ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        '件数
        Dim rowsCount As Integer = dgvNamM.Rows.Count

        '現在日付
        Dim nowYmd As String = DateTime.Now.ToString("yyyy/MM/dd")

        '貼り付けデータ作成
        Dim dataList As New List(Of String(,))
        Dim dataArray(41, 11) As String
        Dim arrayRowIndex As Integer = 0
        For i As Integer = 0 To rowsCount - 1
            If arrayRowIndex = 42 Then
                dataList.Add(dataArray.Clone())
                Array.Clear(dataArray, 0, dataArray.Length)
                arrayRowIndex = 0
            End If

            'No.
            dataArray(arrayRowIndex, 0) = i + 1
            '退
            Dim tai As String = Util.checkDBNullValue(dgvNamM("Tai", i).Value)
            dataArray(arrayRowIndex, 1) = If(tai = "1", "退", "")
            '患者名
            dataArray(arrayRowIndex, 2) = Util.checkDBNullValue(dgvNamM("Nam", i).Value)
            'ｶﾅ
            dataArray(arrayRowIndex, 3) = Util.checkDBNullValue(dgvNamM("Kana", i).Value)
            '空白1
            dataArray(arrayRowIndex, 4) = ""
            '空白2
            dataArray(arrayRowIndex, 5) = ""
            '〒
            dataArray(arrayRowIndex, 6) = Util.checkDBNullValue(dgvNamM("SPost", i).Value)
            '住所1
            dataArray(arrayRowIndex, 7) = Util.checkDBNullValue(dgvNamM("SJyu1", i).Value)
            '住所2
            dataArray(arrayRowIndex, 8) = Util.checkDBNullValue(dgvNamM("SJyu2", i).Value)
            '請求先名
            dataArray(arrayRowIndex, 9) = Util.checkDBNullValue(dgvNamM("SNam", i).Value)
            '電話1
            dataArray(arrayRowIndex, 10) = Util.checkDBNullValue(dgvNamM("STel1", i).Value)
            '電話2
            dataArray(arrayRowIndex, 11) = Util.checkDBNullValue(dgvNamM("STel2", i).Value)

            arrayRowIndex += 1
        Next
        dataList.Add(dataArray.Clone())

        'エクセル
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePath)
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets("請求先改")
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '日付
        oSheet.Range("I2").Value = nowYmd & "　作成"

        '必要枚数コピペ
        For i As Integer = 0 To dataList.Count - 2
            Dim xlPasteRange As Excel.Range = oSheet.Range("A" & (48 + (47 * i))) 'ペースト先
            oSheet.Rows("1:47").copy(xlPasteRange)
            oSheet.HPageBreaks.Add(oSheet.Range("A" & (48 + (47 * i)))) '改ページ
        Next

        'データ貼り付け
        For i As Integer = 0 To dataList.Count - 1
            oSheet.Range("M" & (2 + 47 * i)).Value = (i + 1) & " 頁"
            oSheet.Range("B" & (5 + 47 * i), "M" & (46 + 47 * i)).Value = dataList(i)
        Next

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '変更保存確認ダイアログ非表示
        objExcel.DisplayAlerts = False

        '印刷
        If rbtnPrint.Checked = True Then
            oSheet.PrintOut()
        ElseIf rbtnPreview.Checked = True Then
            objExcel.Visible = True
            oSheet.PrintPreview(1)
        End If

        ' EXCEL解放
        objExcel.Quit()
        Marshal.ReleaseComObject(objWorkBook)
        Marshal.ReleaseComObject(objExcel)
        oSheet = Nothing
        objWorkBook = Nothing
        objExcel = Nothing
    End Sub

    ''' <summary>
    ''' 封筒ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnHuto_Click(sender As System.Object, e As System.EventArgs) Handles btnHuto.Click
        '印刷データ作成
        Dim dataList As New List(Of String())
        For Each row As DataGridViewRow In dgvNamM.Rows
            Dim checked As Boolean = row.Cells("Huto").Value
            If checked Then
                '郵便番号
                Dim post As String = Util.checkDBNullValue(row.Cells("SPost").Value)
                '住所1
                Dim jyu1 As String = Util.checkDBNullValue(row.Cells("SJyu1").Value)
                '住所2
                Dim jyu2 As String = Util.checkDBNullValue(row.Cells("SJyu2").Value)
                '名前
                Dim nam As String = Util.checkDBNullValue(row.Cells("SNam").Value) & "　様"
                '患者名
                Dim sText As String = Util.checkDBNullValue(row.Cells("Nam").Value) & "　様分"

                dataList.Add({post, jyu1, jyu2, nam, sText})
            End If
        Next

        If rbtnNaga3.Checked Then
            '長形3号印刷
            printNaga3(dataList)
        ElseIf rbtnNaga4.Checked Then
            '長形4号印刷
            printNaga4(dataList)
        End If
    End Sub

    ''' <summary>
    ''' 長形3号印刷
    ''' </summary>
    ''' <param name="dataList">印刷者リスト</param>
    ''' <remarks></remarks>
    Private Sub printNaga3(dataList As List(Of String()))
        'エクセル
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePath)
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets("長形３号改")
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '削除
        oSheet.Range("J2").Value = ""
        oSheet.Range("E8").Value = ""
        oSheet.Range("E9").Value = ""
        oSheet.Range("H21").Value = ""
        oSheet.Range("J21").Value = ""

        '必要枚数コピペ
        For i As Integer = 0 To dataList.Count - 2
            Dim xlPasteRange As Excel.Range = oSheet.Range("A" & (44 + (43 * i))) 'ペースト先
            oSheet.Rows("1:43").copy(xlPasteRange)
            oSheet.HPageBreaks.Add(oSheet.Range("A" & (44 + (43 * i)))) '改ページ
        Next

        'データ書き込み
        For i As Integer = 0 To dataList.Count - 1
            Dim info As String() = dataList(i)
            Dim post As String = info(0) '郵便番号
            Dim jyu1 As String = info(1) '住所1
            Dim jyu2 As String = info(2) '住所2
            Dim nam As String = info(3) '宛名
            Dim sText As String = info(4) '患者名

            oSheet.Range("J" & (2 + 43 * i)).Value = post
            oSheet.Range("E" & (8 + 43 * i)).Value = jyu1
            oSheet.Range("E" & (9 + 43 * i)).Value = jyu2
            oSheet.Range("E" & (11 + 43 * i)).Value = nam
            oSheet.Range("J" & (15 + 43 * i)).Value = sText
        Next

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '変更保存確認ダイアログ非表示
        objExcel.DisplayAlerts = False

        '印刷
        If rbtnPrint.Checked = True Then
            oSheet.PrintOut()
        ElseIf rbtnPreview.Checked = True Then
            objExcel.Visible = True
            oSheet.PrintPreview(1)
        End If

        ' EXCEL解放
        objExcel.Quit()
        Marshal.ReleaseComObject(objWorkBook)
        Marshal.ReleaseComObject(objExcel)
        oSheet = Nothing
        objWorkBook = Nothing
        objExcel = Nothing
    End Sub

    ''' <summary>
    ''' 長形4号印刷
    ''' </summary>
    ''' <param name="dataList"></param>
    ''' <remarks></remarks>
    Private Sub printNaga4(dataList As List(Of String()))
        'エクセル
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(TopForm.excelFilePath)
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets("長形４号改")
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        '削除
        oSheet.Range("F2").Value = ""
        oSheet.Range("C7").Value = ""
        oSheet.Range("C8").Value = ""
        oSheet.Range("C10").Value = ""
        oSheet.Range("G19").Value = ""

        '必要枚数コピペ
        For i As Integer = 0 To dataList.Count - 2
            Dim xlPasteRange As Excel.Range = oSheet.Range("A" & (29 + (28 * i))) 'ペースト先
            oSheet.Rows("1:28").copy(xlPasteRange)
            oSheet.HPageBreaks.Add(oSheet.Range("A" & (29 + (28 * i)))) '改ページ
        Next

        'データ書き込み
        For i As Integer = 0 To dataList.Count - 1
            Dim info As String() = dataList(i)
            Dim post As String = info(0) '郵便番号
            Dim jyu1 As String = info(1) '住所1
            Dim jyu2 As String = info(2) '住所2
            Dim nam As String = info(3) '宛名
            Dim sText As String = info(4) '備考

            oSheet.Range("F" & (2 + 28 * i)).Value = post
            oSheet.Range("C" & (7 + 28 * i)).Value = jyu1
            oSheet.Range("C" & (8 + 28 * i)).Value = jyu2
            oSheet.Range("C" & (10 + 28 * i)).Value = nam
            oSheet.Range("G" & (13 + 28 * i)).Value = sText
        Next

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '変更保存確認ダイアログ非表示
        objExcel.DisplayAlerts = False

        '印刷
        If rbtnPrint.Checked = True Then
            oSheet.PrintOut()
        ElseIf rbtnPreview.Checked = True Then
            objExcel.Visible = True
            oSheet.PrintPreview(1)
        End If

        ' EXCEL解放
        objExcel.Quit()
        Marshal.ReleaseComObject(objWorkBook)
        Marshal.ReleaseComObject(objExcel)
        oSheet = Nothing
        objWorkBook = Nothing
        objExcel = Nothing
    End Sub

    ''' <summary>
    ''' 対象の頭文字までスクロール
    ''' </summary>
    ''' <param name="initialChar">頭文字</param>
    ''' <remarks></remarks>
    Private Sub initialSearch(initialChar As String)
        displayDgvNamM()
        Dim rowsCount As Integer = dgvNamM.Rows.Count
        For i As Integer = 0 To rowsCount - 1
            Dim kana As String = Util.checkDBNullValue(dgvNamM("Kana", i).Value)
            If System.Text.RegularExpressions.Regex.IsMatch(kana, "^" & initialChar) Then
                dgvNamM.Rows(i).Cells("Nam").Selected = True
                dgvNamM.FirstDisplayedScrollingRowIndex = i
                displayInfo(dgvNamM.Rows(i))
                Exit For
            End If
        Next
    End Sub

    ''' <summary>
    ''' ｱ～ﾜボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearchKana_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchA.Click, btnSearchKA.Click, btnSearchSA.Click, btnSearchTA.Click, btnSearchNA.Click, btnSearchHA.Click, btnSearchMA.Click, btnSearchYA.Click, btnSearchRA.Click, btnSearchWA.Click
        Dim searchText As String = StrConv(sender.text, VbStrConv.Narrow)
        initialSearch(searchText)
    End Sub

    ''' <summary>
    ''' 検索ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        searchForm = New 検索(dgvNamM)
        searchForm.Owner = Me
        searchForm.ShowDialog()
        searchForm.Dispose()
    End Sub
End Class