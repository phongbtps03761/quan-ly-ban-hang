Public Class frmFacebook
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    End Sub
    Private Sub frmFacebook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://www.facebook.com")
    End Sub
End Class