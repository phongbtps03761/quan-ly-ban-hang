Public Class frmSanPham
    'Khai bao ket noi dtb
    Private _DBAccess As New DataBaseAccess
    'khai bao bien trang thai kiem tra du lieu dang load 
    Private _isLoadding As Boolean = False
    'dinh ngia load DataOnCombobox
    Private Sub LoadDataOnCombobox()
        Dim sqlQuery As String = "SELECT MA_LOAI, TEN_LOAI FROM LOAI_SANPHAM"
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        cmbMaLoai.DataSource = dTable
        cmbMaLoai.ValueMember = "TEN_LOAI"
        cmbMaLoai.DisplayMember = "MA_LOAI"
    End Sub
    'dinh nghia tim kiem
    Private Sub SearchProduct(value As String)
        Dim sqlQuery As String = String.Format("select MA_SP, TEN_SP, GIA, MA_LOAI from dbo.SANPHAM")
        If cmbTim.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MA_SP like N'{0}%'", value)
        ElseIf cmbTim.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TEN_SP LIKE N'{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvSP.DataSource = dTable
        With dgvSP
            .Columns(0).HeaderText = "Mã sản phẩm"
            .Columns(1).HeaderText = "Tên sản phẩm"
            .Columns(2).HeaderText = "Giá"
            .Columns(3).HeaderText = "Mã loại sản phẩm"
        End With
    End Sub
    'dinh nghia ham insertProduct
    Private Function insertProduct() As Boolean
        Dim sqlQuery As String = "INSERT INTO SANPHAM(MA_SP, TEN_SP, GIA, MA_LOAI)"
        sqlQuery += String.Format("Values ('{0}',N'{1}','{2}','{3}')", txbMaSP.Text, txbTen.Text, txbGia.Text, cmbMaLoai.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    'dinh nghia ham kiem tra loi khi insert
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txbMaSP.Text) OrElse String.IsNullOrEmpty(txbTen.Text) OrElse String.IsNullOrEmpty(txbGia.Text) OrElse String.IsNullOrEmpty(cmbMaLoai.Text))
    End Function
    'dinh nghia load du lieu len DGV
    Private Sub LoadDataOnGridView()
        Dim sqlQuery As String = String.Format("select MA_SP, TEN_SP, GIA, MA_LOAI  from dbo.SANPHAM ")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvSP.DataSource = dTable
        With dgvSP
            .Columns(0).HeaderText = "Mã sản phẩm "
            .Columns(1).HeaderText = "Tên sản phẩm"
            .Columns(2).HeaderText = "Giá"
            .Columns(3).HeaderText = "Mã loại sản phẩm"
            .Columns(0).Width = 120
            .Columns(1).Width = 150
            .Columns(2).Width = 100
            .Columns(3).Width = 120
        End With
    End Sub


    'load ma loai len txbMaloai
    Private Sub LoadID(TenSP As String)
        Dim sqlQuery As String = String.Format("{0}", TenSP)
        txbTenSP.Text = sqlQuery
    End Sub


    'LOAD FORM
    Private Sub frmSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _isLoadding = True
        LoadDataOnGridView()
        LoadDataOnCombobox()
        LoadID(cmbMaLoai.SelectedValue)

        _isLoadding = False
    End Sub
    'su kien cmbTenSP Change
    Private Sub cmbTenSP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaLoai.SelectedIndexChanged
        If Not _isLoadding Then
            LoadID(cmbMaLoai.SelectedValue)
        End If
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSP.CellContentClick
        Dim click As Integer = dgvSP.CurrentCell.RowIndex
        txbMaSP.Text = dgvSP.Item(0, click).Value
        txbTen.Text = dgvSP.Item(1, click).Value
        txbGia.Text = dgvSP.Item(2, click).Value
        cmbMaLoai.Text = dgvSP.Item(3, click).Value
    End Sub
    'clear txb
    Private Sub ClearBtn()
        txbMaSP.Text = ""
        txbTen.Text = ""
        txbGia.Text = ""
        cmbMaLoai.Text = ""
        txbMaSP.Focus()
    End Sub
    'su kien nut insert
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If IsEmpty() Then
            MessageBox.Show("Hãy nhập giá trị vào trước khi ghi vào database")
        Else
            If insertProduct() Then ' Nếu insert thành công thì thông báo
                MessageBox.Show("Thêm dữ liệu thành công", "Information", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Lỗi Thêm dữ liệu", "Error", MessageBoxButtons.OK)
            End If
        End If
        LoadDataOnGridView()
        ClearBtn()
    End Sub

    'Su kien txbTim
    Private Sub txbTim_TextChanged(sender As Object, e As EventArgs) Handles txbTim.TextChanged
        SearchProduct(txbTim.Text)
    End Sub
    'dinh nghia ham sua thong tin bang ghi vao dtb
    Private Function EditProduct() As Boolean
        Dim sqlquery As String = String.Format("UPDATE SANPHAM SET TEN_SP=N'{0}', GIA='{1}', MA_LOAI='{2}' where MA_SP = '{3}'", txbTen.Text, txbGia.Text, cmbMaLoai.Text, txbMaSP.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)
    End Function
    'xu ly su kien nut Sua
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txbMaSP.ReadOnly = True
            btnSua.Text = "Update"
            txbMaSP.Focus()
        ElseIf btnSua.Text = "Update" Then
            If IsEmpty() Then
                MessageBox.Show("Hãy nhập giá trị vào ")
            Else
                If EditProduct() Then ' Nếu insert thành công thì thông báo
                    MessageBox.Show("Update dữ liệu thành công", "Information", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Lỗi  dữ liệu", "Error", MessageBoxButtons.OK)
                End If
            End If
            txbMaSP.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadDataOnGridView()
            ClearBtn()
        End If
    End Sub
    'dinh nghia ham xoa thong tin bang ghi tren dtb
    Private Function DelProduct() As Boolean
        Dim sqlQuery As String = String.Format("delete from SANPHAM where MA_SP = '{0}' OR TEN_SP = N'{1}'", txbMaSP.Text, txbTen.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    ' su kien nut xoa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resulft = DialogResult.Yes Then
            DelProduct()
            MessageBox.Show("Xóa thành công")
            LoadDataOnGridView()
        End If
    End Sub



    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Close()
    End Sub
End Class