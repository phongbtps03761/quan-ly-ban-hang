
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmLichSu
    ' dinh nghia su dung file DBA
    Private _DBAccess As New DataBaseAccess
    'load lich su ban SAN PHAM DGV
    Private Sub LoadHisoryOnGridView()
        Dim sqlQuery As String = String.Format("select SANPHAM.MA_SP, TEN_SP, SUM(SOLUONG) as soluong, GIA , SUM(SOLUONG)* GIA 
                                                   from SANPHAM join CHITIETHOADON on SANPHAM.MA_SP = CHITIETHOADON.MA_SP join HOADON on HOADON.SO_HD = CHITIETHOADON.SO_HD
                                                   WHERE NGAY_HD BETWEEN '{0}' AND '{1}'
                                                   GROUP BY SANPHAM.MA_SP, TEN_SP,GIA order by soluong desc", Format(dtpTu.Value, "MM/dd/yyyy"), Format(dtpDen.Value, "MM/dd/yyyy"))
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvLichSu.DataSource = dTable
        With dgvLichSu
            .Columns(0).HeaderText = "Mã sản phẩm"
            .Columns(1).HeaderText = "Tên sản phẩm"
            .Columns(2).HeaderText = "Số lượng bán ra"
            .Columns(3).HeaderText = "Giá"
            .Columns(4).HeaderText = "Thành tiền"
        End With
    End Sub
    'Load lich su khach mua hang len DGV
    Private Sub LoadCusOnGridView()
        Dim sqlQuery As String = String.Format("select KHACHHANG.MA_KH, Ten_KH,TEN_SP,HOADON.NGAY_HD,SOLUONG,GIA,soluong*GIA
                                                from KHACHHANG join HOADON on KHACHHANG.MA_KH = HOADON.MA_KH join CHITIETHOADON on CHITIETHOADON.SO_HD = HOADON.SO_HD join SANPHAM on SANPHAM.MA_SP = CHITIETHOADON.MA_SP
                                                 WHERE NGAY_HD BETWEEN '{0}' AND '{1}'  
                                                order by KHACHHANG.MA_KH asc", Format(dtpTu.Value, "MM/dd/yyyy"), Format(dtpDen.Value, "MM/dd/yyyy"))
        Dim dTable As DataTable = _DBAccess.GetDataTable(sqlQuery)
        dgvLichSu.DataSource = dTable
        With dgvLichSu
            .Columns(0).HeaderText = "Mã Khách hàng"
            .Columns(1).HeaderText = "Tên khách hàng"
            .Columns(2).HeaderText = "Tên sản phẩm"
            .Columns(3).HeaderText = "Ngày mua"
            .Columns(4).HeaderText = "Số lượng"
            .Columns(5).HeaderText = "Giá"
            .Columns(6).HeaderText = "Thành tiền"
        End With
    End Sub


    'su kien nut xem
    Private Sub btnXem_Click(sender As Object, e As EventArgs) Handles btnXem.Click
        If cmbMode.SelectedIndex = 0 Then 'xem lich su theo san pham ban ra
            LoadHisoryOnGridView()
            Dim tongtien As Integer = 0
            Dim i As Integer = 0
            For i = 0 To dgvLichSu.Rows.Count - 1

                tongtien += dgvLichSu.Rows(i).Cells(4).Value

                lblName.Text = Format(tongtien, "##0,##0")
                lblMa.Text = dgvLichSu.Item(0, 0).Value
                lblTen.Text = dgvLichSu.Item(1, 0).Value
            Next
        ElseIf cmbMode.SelectedIndex = 1 Then 'xem lich su khach hang da mua
            LoadCusOnGridView()
        End If
    End Sub

    'su kien combobox change
    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged


        If cmbMode.SelectedIndex = 0 Then
            dgvLichSu.DataSource = Nothing
            lblType.Text = "Tổng thu nhập:"
            lblName.Text = Nothing
            grbInfo.Text = "Sản phẩm bán chạy nhất"
        ElseIf cmbMode.SelectedIndex = 1 Then
            dgvLichSu.DataSource = Nothing
            lblType.Text = "Tổng chi tiêu:"
            lblName.Text = Nothing
            grbInfo.Text = "Khách hàng chi tiêu nhiều nhất"

        End If
    End Sub

    'su kien nut export file excel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application()
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To dgvLichSu.RowCount - 2
            For j = 0 To dgvLichSu.ColumnCount - 1
                For k As Integer = 1 To dgvLichSu.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgvLichSu.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvLichSu(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.SaveAs("D:\thongke.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("File excel ở  D:\thongke.xlsx")
    End Sub

    'bat loi export 
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class