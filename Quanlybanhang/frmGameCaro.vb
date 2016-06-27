Public Class frmGameCaro
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    End Sub

    Private Sub frmGameCaro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://gameflash.vn/games/co-caro.swf")
    End Sub
End Class