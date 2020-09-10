Public Class TopForm

    'データベースのパス
    Public dbFilePath As String = My.Application.Info.DirectoryPath & "\Claim2.mdb"
    Public DB_Claim2 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFilePath

    '画像パス
    Public topImageFilePath As String = My.Application.Info.DirectoryPath & "\Claim2.PNG"

    '各フォーム
    Private claim2MasterForm As 請求先ﾏｽﾀ

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TopForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not System.IO.File.Exists(dbFilePath) Then
            MsgBox("データベースファイルが存在しません。ファイルを配置して下さい。", MsgBoxStyle.Exclamation)
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(topImageFilePath) Then
            MsgBox("トップ画像ファイルが存在しません。ファイルを配置して下さい。", MsgBoxStyle.Exclamation)
            Me.Close()
            Exit Sub
        End If

        '画面サイズ等
        Me.WindowState = FormWindowState.Maximized
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        '画像の配置処理
        topPicture.ImageLocation = topImageFilePath
    End Sub

    ''' <summary>
    ''' 請求先ﾏｽﾀボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnClaim2_Click(sender As System.Object, e As System.EventArgs) Handles btnClaim2.Click
        If IsNothing(claim2MasterForm) OrElse claim2MasterForm.IsDisposed Then
            claim2MasterForm = New 請求先ﾏｽﾀ()
            claim2MasterForm.Show()
        End If
    End Sub

    ''' <summary>
    ''' トップ画像クリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub topPicture_Click(sender As System.Object, e As System.EventArgs) Handles topPicture.Click
        Me.Close()
    End Sub
End Class
