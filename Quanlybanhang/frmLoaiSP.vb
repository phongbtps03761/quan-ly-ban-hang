Public Class frmLoaiSP
    Private _DBAccess As New DataBaseAccess
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub
    'dinh nghia load du lieu len DGV
    Private Sub LoadDataOnGridView()
        Dim sqlQuery As String = String.Format("SELECT MA_LOAI,TEN_LOAI FROM dbo.LOAI_SANPHAM")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvLoaiSP.DataSource = dTable
        With dgvLoaiSP
            .Columns(0).HeaderText = "Mã loại"
            .Columns(1).HeaderText = "Tên loại sản phẩm"
            .Columns(0).Width = 100
            .Columns(1).Width = 150
        End With
    End Sub
    'Dinh nghia ham them ban ghi khach hang vao dtb
    Private Function insertCustommer() As Boolean
        Dim sqlQuery As String = "INSERT INTO LOAI_SANPHAM (MA_LOAI, TEN_LOAI)"
        sqlQuery += String.Format("Values ('{0}',N'{1}')", txbMaLoai.Text, txbTenLoai.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    'dinh nghia ham kiem tra gia tri truoc khi insert
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txbMaLoai.Text) OrElse String.IsNullOrEmpty(txbTenLoai.Text))
    End Function

    'su kien clear textbox
    Private Sub ClearBtn()
        txbMaLoai.Text = ""
        txbTenLoai.Text = ""
        txbMaLoai.Focus()
    End Sub
    'su kien nut thêm
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If IsEmpty() Then
            MessageBox.Show("Hãy nhập giá trị vào trước khi ghi vào database")
        Else
            If insertCustommer() Then ' Nếu insert thành công thì thông báo
                MessageBox.Show("Thêm dữ liệu thành công", "Information", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Lỗi Thêm dữ liệu", "Error", MessageBoxButtons.OK)
            End If
        End If
        LoadDataOnGridView()
        ClearBtn()
    End Sub

    'su kien click trên dgv
    Private Sub dgvLoaiSP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiSP.CellContentClick
        Dim click As Integer = dgvLoaiSP.CurrentCell.RowIndex
        txbMaLoai.Text = dgvLoaiSP.Item(0, click).Value
        txbTenLoai.Text = dgvLoaiSP.Item(1, click).Value
    End Sub
    'dinh nghia ham sua thong tin bang ghi vao dtb
    Private Function EditKindProduct() As Boolean
        Dim sqlquery As String = String.Format("UPDATE LOAI_SANPHAM SET TEN_LOAI=N'{0}' where MA_LOAI = '{1}'", txbTenLoai.Text, txbMaLoai.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)
    End Function
    'SU KIEN NUT SUA
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txbMaLoai.ReadOnly = True
            btnSua.Text = "Update"
            txbTenLoai.Focus()
        ElseIf btnSua.Text = "Update" Then
            If IsEmpty() Then
                MessageBox.Show("Hãy nhập giá trị vào ")
            Else
                If EditKindProduct() Then ' Nếu insert thành công thì thông báo
                    MessageBox.Show("Update dữ liệu thành công", "Information", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Lỗi  dữ liệu", "Error", MessageBoxButtons.OK)
                End If
            End If
            txbMaLoai.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadDataOnGridView()
            ClearBtn()
        End If
    End Sub
    'DINH NGHIA HAM XOA THONG TIN
    Private Function DelKindProduct() As Boolean
        Dim sqlQuery As String = String.Format("DELETE FROM LOAI_SANPHAM WHERE MA_LOAI = '{0}' OR TEN_Loai = N'{1}'", txbMaLoai.Text, txbTenLoai.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function

    'SU KIEN NUT XOA
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resulft = DialogResult.Yes Then
            DelKindProduct()
            MessageBox.Show("Xóa thành công")
            LoadDataOnGridView()
        End If
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Close()
    End Sub
End Class