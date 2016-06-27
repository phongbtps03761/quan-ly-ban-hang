Public Class frmHoaDon
    ' dinh nghia su dung file DBA
    Private _DBAccess As New DataBaseAccess
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBillOnGridView()
    End Sub
    'dinh nghia load bill len DGV
    Private Sub LoadBillOnGridView()
        Dim sqlQuery As String = String.Format("select HOADON.SO_HD, MA_KH,chitiethoadon.MA_SP ,NGAY_HD , soluong, gia, SOLUONG* GIA 
From HOADON join CHITIETHOADON on HOADON.SO_HD = CHITIETHOADON.SO_HD 
            join SANPHAM on sanpham.MA_SP = CHITIETHOADON.MA_SP")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvHD.DataSource = dTable
        With dgvHD
            .Columns(0).HeaderText = "Số hóa đơn"
            .Columns(1).HeaderText = "Mã khách hàng"
            .Columns(2).HeaderText = "Mã Sản Phẩm"
            .Columns(3).HeaderText = "Ngày xuất HĐ"
            .Columns(4).HeaderText = "Số lượng"
            .Columns(5).HeaderText = "Giá"
            .Columns(6).HeaderText = "Thành Tiền"
            .Columns(0).Width = 80
            .Columns(1).Width = 80
            .Columns(2).Width = 100
            .Columns(3).Width = 80
            .Columns(4).Width = 80
            .Columns(5).Width = 100
            .Columns(6).Width = 100
        End With
    End Sub
    'dinh nghia insert bill
    Private Function insertBill() As Boolean
        Dim sqlQuery As String = "INSERT INTO HOADON(SO_HD, MA_KH, NGAY_HD)"
        sqlQuery += String.Format("Values ('{0}',N'{1}',N'{2}')", dgvHD.RowCount, txbMaKH.Text, Date.Today)
        sqlQuery += "INSERT INTO CHITIETHOADON(SO_HD,MA_SP,SOLUONG)"
        sqlQuery += String.Format("Values ('{0}',N'{1}',N'{2}')", dgvHD.RowCount, txbMaSP.Text, nudSoluong.Value)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    'dinh nghia load du lieu USER lên DGV
    Private Sub LoadUserOnGridView()
        Dim sqlQuery As String = String.Format("Select MA_KH, TEN_KH, EMAIL, DIACHI from dbo.KHACHHANG ")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvTotal.DataSource = dTable
        With dgvTotal
            .Columns(0).HeaderText = "Custommer ID "
            .Columns(1).HeaderText = "Custommer Name"
            .Columns(2).HeaderText = "Email"
            .Columns(3).HeaderText = "Address"
            .Columns(0).Width = 80
            .Columns(1).Width = 130
            .Columns(2).Width = 150
            .Columns(3).Width = 150
        End With
    End Sub
    'dinh nghia load PRODUCT len DGV
    Private Sub LoadProductOnGridView()
        Dim sqlQuery As String = String.Format("Select MA_SP, TEN_SP, GIA, MA_LOAI  from dbo.SANPHAM ")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvTotal.DataSource = dTable
        With dgvTotal
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

    Private Sub cmbTim_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTim.SelectedIndexChanged
        If cmbTim.SelectedIndex = 0 OrElse cmbTim.SelectedIndex = 1 Then
            LoadUserOnGridView()
        Else
            If cmbTim.SelectedIndex = 2 OrElse cmbTim.SelectedIndex = 3 Then
                LoadProductOnGridView()
            End If
        End If
    End Sub

    Private Sub dgvTotal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTotal.CellContentClick
        Dim click As Integer = dgvTotal.CurrentCell.RowIndex
        If cmbTim.SelectedIndex = 0 OrElse cmbTim.SelectedIndex = 1 Then
            txbMaKH.Text = dgvTotal.Item(0, click).Value
            txbTenKH.Text = dgvTotal.Item(1, click).Value
            txbEmail.Text = dgvTotal.Item(2, click).Value
            txbDiachi.Text = dgvTotal.Item(3, click).Value
        Else
            If cmbTim.SelectedIndex = 2 OrElse cmbTim.SelectedIndex = 3 Then
                txbMaSP.Text = dgvTotal.Item(0, click).Value
                txbTenSP.Text = dgvTotal.Item(1, click).Value
                txbGia.Text = dgvTotal.Item(2, click).Value
                txbMaLoai.Text = dgvTotal.Item(3, click).Value

            End If
        End If
    End Sub
    'load ma loai len txbMaloai
    Private Sub LoadID(TenSP As String)
        Dim sqlQuery As String = String.Format("{0}", TenSP)
        txbTenSP.Text = sqlQuery
    End Sub

    'dinh nghia tim kiem
    Private Sub SearchCustommer(value As String)
        Dim sqlQuery As String = String.Format("Select MA_KH, TEN_KH, EMAIL, DIACHI from dbo.KHACHHANG")
        If cmbTim.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MA_KH Like N'{0}%'", value)
        ElseIf cmbTim.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TEN_KH LIKE N'{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvTotal.DataSource = dTable
        With dgvTotal
            .Columns(0).HeaderText = "Mã khách hàng"
            .Columns(1).HeaderText = "Tên khách hàng"
            .Columns(2).HeaderText = "Email"
            .Columns(3).HeaderText = "Địa chỉ"
        End With
    End Sub
    'dinh nghia tim kiem
    Private Sub SearchProduct(value As String)
        Dim sqlQuery As String = String.Format("select MA_SP, TEN_SP, GIA, MA_LOAI from dbo.SANPHAM")
        If cmbTim.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where MA_SP like N'{0}%'", value)
        ElseIf cmbTim.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where TEN_SP LIKE N'{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvTotal.DataSource = dTable
        With dgvTotal
            .Columns(0).HeaderText = "Mã sản phẩm"
            .Columns(1).HeaderText = "Tên sản phẩm"
            .Columns(2).HeaderText = "Giá"
            .Columns(3).HeaderText = "Mã loại sản phẩm"
        End With
    End Sub

    Private Sub txbTim_TextChanged(sender As Object, e As EventArgs) Handles txbTim.TextChanged
        If cmbTim.SelectedIndex = 0 OrElse cmbTim.SelectedIndex = 1 Then
            SearchCustommer(txbTim.Text)
        ElseIf cmbTim.SelectedIndex = 2 OrElse cmbTim.SelectedIndex = 3 Then
            SearchProduct(txbTim.Text)
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles nudSoluong.ValueChanged
        txbThanhTien.Text = Val(txbGia.Text) * nudSoluong.Value
    End Sub

    'kiem tra su kien truoc khi insert
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txbMaKH.Text) OrElse String.IsNullOrEmpty(txbMaSP.Text) OrElse String.IsNullOrEmpty(nudSoluong.Value))
    End Function

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If IsEmpty() Then
            MessageBox.Show("Hãy nhập giá trị vào trước khi ghi vào database")
        Else
            If insertBill() Then ' Nếu insert thành công thì thông báo
                MessageBox.Show("Thêm dữ liệu thành công", "Information", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Lỗi Thêm dữ liệu", "Error", MessageBoxButtons.OK)
            End If
        End If
        LoadBillOnGridView()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub


End Class