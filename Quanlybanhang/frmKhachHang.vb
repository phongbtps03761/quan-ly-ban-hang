
Public Class frmKhachHang
    ' dinh nghia su dung file DBA
    Private _DBAccess As New DataBaseAccess
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataOnGridView()
    End Sub
    'dinh nghia load du lieu len DGV
    Private Sub LoadDataOnGridView()
        Dim sqlQuery As String = String.Format("select MA_KH, TEN_KH, EMAIL, DIACHI from dbo.KHACHHANG ")
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvKH.DataSource = dTable
        With dgvKH
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
    'dinh nghia tim kiem
    Private Sub SearchCustommer(value As String)
        Dim sqlQuery As String = String.Format("select MA_KH, TEN_KH, EMAIL, DIACHI from dbo.KHACHHANG")
        If cmbTim.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MA_KH like N'{0}%'", value)
        ElseIf cmbTim.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TEN_KH LIKE N'{0}%'", value)
        End If
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvKH.DataSource = dTable
        With dgvKH
            .Columns(0).HeaderText = "Mã khách hàng"
            .Columns(1).HeaderText = "Tên khách hàng"
            .Columns(2).HeaderText = "Email"
            .Columns(3).HeaderText = "Địa chỉ"
        End With
    End Sub
    'Dinh nghia ham them ban ghi khach hang vao dtb
    Private Function insertCustommer() As Boolean
        Dim sqlQuery As String = "INSERT INTO KHACHHANG(MA_KH, TEN_KH, Email, DIACHI)"
        sqlQuery += String.Format("Values ('{0}',N'{1}',N'{2}',N'{3}')", txbMaKH.Text, txbTen.Text, txbEmail.Text, txbDiachi.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    'dinh nghia ham kiem tra gia tri truoc khi insert
    Private Function IsEmpty() As Boolean
        Return (String.IsNullOrEmpty(txbMaKH.Text) OrElse String.IsNullOrEmpty(txbTen.Text) OrElse String.IsNullOrEmpty(txbEmail.Text) OrElse String.IsNullOrEmpty(txbDiachi.Text))
    End Function
    'su ly su kien tim kiem
    Private Sub txbTim_TextChanged(sender As Object, e As EventArgs) Handles txbTim.TextChanged
        SearchCustommer(txbTim.Text)
    End Sub
    'su ly su kien insert vao dtb
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
    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKH.CellContentClick
        If dgvKH.SelectedCells.Count > 0 Then
            Dim MaKH As Integer = dgvKH.CurrentRow.Cells(0).Value.ToString
            Dim TenKH As String = dgvKH.CurrentRow.Cells(1).Value.ToString
            Dim Email As String = dgvKH.CurrentRow.Cells(2).Value.ToString
            Dim DiaChi As String = dgvKH.CurrentRow.Cells(3).Value.ToString

            txbMaKH.Text = Val(MaKH)
            txbTen.Text = TenKH
            txbEmail.Text = Email
            txbDiachi.Text = DiaChi
        End If

    End Sub
    'clear txb
    Private Sub ClearBtn()
        txbMaKH.Text = ""
        txbTen.Text = ""
        txbEmail.Text = ""
        txbDiachi.Text = ""
        txbMaKH.Focus()
    End Sub

    'dinh nghia ham sua thong tin bang ghi vao dtb
    Private Function EditCustommer() As Boolean
        Dim sqlquery As String = String.Format("UPDATE KHACHHANG SET TEN_KH=N'{0}', Email=N'{1}', DIACHI=N'{2}' where MA_KH = '{3}'", txbTen.Text, txbEmail.Text, txbDiachi.Text, txbMaKH.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)
    End Function
    'xu ly su kien nut Sua
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txbMaKH.ReadOnly = True
            btnSua.Text = "Update"
            txbMaKH.Focus()
        ElseIf btnSua.Text = "Update" Then
            If IsEmpty() Then
                MessageBox.Show("Hãy nhập giá trị vào ")
            Else
                If EditCustommer() Then ' Nếu insert thành công thì thông báo
                    MessageBox.Show("Update dữ liệu thành công", "Information", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("Lỗi  dữ liệu", "Error", MessageBoxButtons.OK)
                End If
            End If
            txbMaKH.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadDataOnGridView()
            ClearBtn()
        End If
    End Sub

    'dinh nghia ham xoa thong tin bang ghi tren dtb
    Private Function DelCustommer() As Boolean
        Dim sqlQuery As String = String.Format("delete from khachhang where MA_KH = '{0}' OR TEN_KH = N'{1}'", txbMaKH.Text, txbTen.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlQuery)
    End Function
    ' su kien nut xoa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resulft = DialogResult.Yes Then
            DelCustommer()
            MessageBox.Show("Xóa thành công")
            LoadDataOnGridView()
        End If
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Close()
    End Sub
End Class
