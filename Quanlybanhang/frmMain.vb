Public Class frmMain
    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        frmKhachHang.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbDate.Text = Date.Today.ToString("'Ngày'' 'dd' ''Tháng' ''MM'' 'Năm'' 'yyyy")

    End Sub

    Private Sub LoạiHàngHóaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiHàngHóaToolStripMenuItem.Click
        frmLoaiSP.ShowDialog()
    End Sub

    Private Sub ChiTiếtHàngHóaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHàngHóaToolStripMenuItem.Click
        frmSanPham.ShowDialog()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmHoaDon.ShowDialog()
    End Sub

    Private Sub CaroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CaroToolStripMenuItem1.Click
        frmGameCaro.ShowDialog()
    End Sub

    Private Sub MinhVươngM4UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinhVươngM4UToolStripMenuItem.Click
        frmEDM.ShowDialog()
    End Sub

    Private Sub PhimToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhimToolStripMenuItem.Click
        frmFacebook.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txbTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub LịchSửToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LịchSửToolStripMenuItem.Click
        frmLichSu.ShowDialog()
    End Sub
End Class