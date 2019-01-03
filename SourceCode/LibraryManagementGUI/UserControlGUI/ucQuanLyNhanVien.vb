Imports DevExpress.XtraEditors.Controls
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucQuanLyNhanVien
    Dim loaiNhanVienBUS As LoaiNhanVienBUS
    Dim nhanVienBUS As NhanVienBUS
    Dim nhanVien As NhanVienDTO
    Dim result As Result

    Private Sub ucQuanLyNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo
        nhanVienBUS = New NhanVienBUS()
        loaiNhanVienBUS = New LoaiNhanVienBUS()

        ' Lấy dữ liệu lue
        Dim listLoaiNhanVien = New List(Of LoaiNhanVienDTO)
        result = loaiNhanVienBUS.SelectALL(listLoaiNhanVien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Loại nhân viên không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        '--
        lueLoaiNhanVien.Properties.ShowHeader = False
        lueLoaiNhanVien.Properties.ShowFooter = False
        lueLoaiNhanVien.Properties.DataSource = New BindingSource(listLoaiNhanVien, String.Empty)
        lueLoaiNhanVien.Properties.DisplayMember = "TenLoaiNhanVien"
        lueLoaiNhanVien.Properties.ValueMember = "MaLoaiNhanVien"
        lueLoaiNhanVien.Properties.TextEditStyle = TextEditStyles.Standard
        lueLoaiNhanVien.Properties.SearchMode = SearchMode.AutoFilter
        ' Xoá cột ValueMember
        lueLoaiNhanVien.Properties.PopulateColumns()
        lueLoaiNhanVien.Properties.Columns(0).Visible = False
        '----
        lueChonLoaiNhanVien.Properties.ShowHeader = False
        lueChonLoaiNhanVien.Properties.ShowFooter = False
        lueChonLoaiNhanVien.Properties.DataSource = New BindingSource(listLoaiNhanVien, String.Empty)
        lueChonLoaiNhanVien.Properties.DisplayMember = "TenLoaiNhanVien"
        lueChonLoaiNhanVien.Properties.ValueMember = "MaLoaiNhanVien"
        lueChonLoaiNhanVien.Properties.TextEditStyle = TextEditStyles.Standard
        lueChonLoaiNhanVien.Properties.SearchMode = SearchMode.AutoFilter
        ' Xoá cột ValueMember
        lueChonLoaiNhanVien.Properties.PopulateColumns()
        lueChonLoaiNhanVien.Properties.Columns(0).Visible = False

        CaiDatGridControl(GetListNhanVien())
    End Sub

    Private Sub CaiDatGridControl(listNhanVien As List(Of NhanVienDTO))
        grcDanhSachNhanVien.SuspendLayout() ' Tạm dừng hiển thị GridView
        ' Cài đặt cho GridControl và GridView
        grvDanhSachTacGia.BestFitColumns()
        grvDanhSachTacGia.Columns.Clear()
        grcDanhSachNhanVien.DataSource = listNhanVien
        grvDanhSachTacGia.OptionsBehavior.Editable = False
        grvDanhSachTacGia.OptionsFind.AlwaysVisible = False
        grvDanhSachTacGia.OptionsView.ShowGroupPanel = False
        grvDanhSachTacGia.OptionsFind.FindDelay = 0

        grvDanhSachTacGia.Columns("MatKhau").Visible = False
        grvDanhSachTacGia.Columns("TenDangNhap").Caption = "Tên đăng nhập"
        grvDanhSachTacGia.Columns("HoTen").Caption = "Họ tên"
        grvDanhSachTacGia.Columns("MaLoaiNhanVien").Caption = "Loại nhân viên"
        grcDanhSachNhanVien.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Function GetListNhanVien(iMaLoaiNhanVien As Integer) As List(Of NhanVienDTO)
        Dim listNhanVien = New List(Of NhanVienDTO)
        Dim result As Result
        result = nhanVienBUS.SelectByMaLoaiNhanVien(iMaLoaiNhanVien, listNhanVien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Nhân viên theo mã loại nhân viên không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Return listNhanVien
    End Function

    Private Function GetListNhanVien() As List(Of NhanVienDTO)
        Dim listNhanVien = New List(Of NhanVienDTO)
        Dim result As Result
        result = nhanVienBUS.SelectALL(listNhanVien)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Nhân viên theo mã loại nhân viên không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Return listNhanVien
    End Function

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachTacGia.ApplyFindFilter(filterString)
    End Sub

    Private Sub lueChonLoaiNhanVien_EditValueChanged(sender As Object, e As EventArgs) Handles lueChonLoaiNhanVien.EditValueChanged
        If String.IsNullOrWhiteSpace(lueChonLoaiNhanVien.EditValue) Then
            Return
        End If
        Dim maLoaiNhanVien As Integer
        maLoaiNhanVien = lueChonLoaiNhanVien.EditValue
        CaiDatGridControl(GetListNhanVien(maLoaiNhanVien))
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        txtTimKiem.EditValue = String.Empty
        CaiDatGridControl(GetListNhanVien())
    End Sub

    Private Sub LoadNhanVien(nhanVien As NhanVienDTO)
        txtTenDangNhap.EditValue = nhanVien.TenDangNhap
        txtHoTen.EditValue = nhanVien.HoTen
        lueLoaiNhanVien.EditValue = nhanVien.MaLoaiNhanVien
        If nhanVien.TenDangNhap = "admin" Or nhanVien.TenDangNhap = GlobalControl.ReturnNhanVien.TenDangNhap Then
            lueLoaiNhanVien.Enabled = False
            btnXoa.Enabled = False
        Else
            lueLoaiNhanVien.Enabled = True
            btnXoa.Enabled = True
        End If
    End Sub

    Private Sub grvDanhSachTacGia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSachTacGia.FocusedRowChanged
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachTacGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachTacGia.RowCount) Then
            Try
                Dim nhanVien = CType(grvDanhSachTacGia.GetRow(currenRowIndex), NhanVienDTO)
                LoadNhanVien(nhanVien)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachTacGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachTacGia.RowCount) Then
            Try
                Dim nhanVien = New NhanVienDTO

                ' Chuyển data từ GUI thành DTO

                ' Kiem tra pass
                If String.IsNullOrWhiteSpace(txtMatKhau.EditValue) And String.IsNullOrWhiteSpace(txtReMatKhau.EditValue) Then
                    nhanVien.MatKhau = " "
                    txtMatKhau.EditValue = " "
                    txtReMatKhau.EditValue = " "
                End If
                '--
                If txtMatKhau.EditValue <> txtReMatKhau.EditValue Then
                    MessageBox.Show("Mật khẩu mới không khớp. Vui lòng nhập lại")
                    GlobalControl.ChangeStatus("Mật khẩu mới không khớp")
                    Return
                End If
                '--
                If nhanVienBUS.IsValidMatKhau(txtMatKhau.EditValue) = False Then
                    MessageBox.Show("Mật khẩu ít nhất 6 ký tự 0-9, a-z, A-Z")
                    GlobalControl.ChangeStatus("Mật khẩu ít nhất 6 ký tự 0-9, a-z, A-Z")
                    Return
                End If
                '--
                If nhanVienBUS.IsValidTenDangNhap(txtHoTen.EditValue) = False Then
                    MessageBox.Show("Họ tên không đúng")
                    GlobalControl.ChangeStatus("Họ tên không đúng")
                    Return
                End If
                nhanVien.MatKhau = txtMatKhau.EditValue
                nhanVien.TenDangNhap = txtTenDangNhap.EditValue
                nhanVien.HoTen = txtHoTen.EditValue
                nhanVien.MaLoaiNhanVien = lueLoaiNhanVien.EditValue

                ' Thêm dữ liệu vào database
                Dim result As Result
                result = nhanVienBUS.Update(nhanVien)
                If (result.FlagResult) Then
                    MessageBox.Show("Cập nhật thông tin Nhân viên thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GlobalControl.ChangeStatus("Cập nhật thông tin Nhân viên thành công")
                    Reset()
                Else
                    MessageBox.Show("Cập nhật thông tin Nhân viên không thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GlobalControl.ChangeStatus("Cập nhật thông tin Nhân viên không thành công")
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub Reset()
        ' Xoá ô tìm kiếm
        txtTimKiem.EditValue = Nothing

        ' Load lại data
        CaiDatGridControl(GetListNhanVien())
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachTacGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachTacGia.RowCount) Then
            Try
                Dim docGia = CType(grvDanhSachTacGia.GetRow(currenRowIndex), DocGiaDTO)
                LoadNhanVien(nhanVien)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Lấy dòng hiện tại
        Dim currentRowIndex As Integer
        currentRowIndex = grvDanhSachTacGia.FocusedRowHandle

        If (-1 < currentRowIndex < grvDanhSachTacGia.RowCount) Then
            Select Case MessageBox.Show("Bạn chắc chắn muốn xoá Nhân viên " & txtHoTen.EditValue & " (" & txtTenDangNhap.EditValue & ")?", "Xoá Nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case DialogResult.Yes
                    Try
                        Dim result As Result
                        result = nhanVienBUS.Delete(txtTenDangNhap.EditValue)
                        If (result.FlagResult = True) Then
                            MessageBox.Show("Xóa Nhân viên thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            GlobalControl.ChangeStatus("Xóa Nhân viên thành công")
                            Reset()
                            If (currentRowIndex >= grvDanhSachTacGia.RowCount) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                grvDanhSachTacGia.FocusedRowHandle = currentRowIndex
                            End If
                        Else
                            MessageBox.Show("Xóa Nhân viên không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            GlobalControl.ChangeStatus("Xóa Nhân viên không thành công")
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case DialogResult.No
                    Return
            End Select
        End If
    End Sub
End Class
