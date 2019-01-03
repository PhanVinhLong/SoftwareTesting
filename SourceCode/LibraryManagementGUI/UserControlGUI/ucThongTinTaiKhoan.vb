Imports LibraryManagementBUS
Imports LibraryManagementDTO

Public Class ucThongTinTaiKhoan
    Dim loaiNhanVienBUS As LoaiNhanVienBUS
    Dim nhanVien As NhanVienDTO
    Dim nhanVienBUS As NhanVienBUS
    Private Sub ucThongTinTaiKhoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaiNhanVienBUS = New LoaiNhanVienBUS()
        nhanVienBUS = New NhanVienBUS()
        nhanVien = GlobalControl.ReturnNhanVien
        txtTenDangNhap.EditValue = nhanVien.TenDangNhap
        txtHoTen.EditValue = nhanVien.HoTen
        txtLoaiNhanVien.EditValue = loaiNhanVienBUS.GetName(nhanVien.MaLoaiNhanVien)
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Kiem tra pass
        If String.IsNullOrWhiteSpace(txtMatKhau.EditValue) And String.IsNullOrWhiteSpace(txtReMatKhau.EditValue) Then
            nhanVien.MatKhau = " "
            txtMatKhau.EditValue = " "
            txtReMatKhau.EditValue = " "
        End If
        '--
        If txtMatKhau.EditValue <> txtReMatKhau.EditValue Then
            MessageBox.Show("Mật khẩu mới không khớp. Vui lòng nhập lại")
            Return
        End If
        '--
        If nhanVienBUS.IsValidMatKhau(txtMatKhau.EditValue) = False Then
            MessageBox.Show("Mật khẩu ít nhất 6 ký tự 0-9, a-z, A-Z")
            Return
        End If
        nhanVien.MatKhau = txtMatKhau.EditValue

        '----
        nhanVien.HoTen = txtHoTen.EditValue
        If nhanVienBUS.Update(nhanVien).FlagResult = False Then
            MessageBox.Show("Cập nhật thông tin không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Cập nhật thông tin tài khoản không thành công")
        Else
            MessageBox.Show("Cập nhật thông tin thành công")
            GlobalControl.ChangeStatus("Cập nhật thông tin tài khoản thành công")
        End If
        txtMatKhau.EditValue = Nothing
        txtReMatKhau.EditValue = Nothing
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
