Imports LibraryManagementBUS
Imports LibraryManagementDTO

Public Class ucThayDoiQuyDinh
    Dim thamSoBUS As ThamSoBUS
    Dim tacGiaBUS As TacGiaBUS
    Dim theLoaiBUS As TheLoaiBUS
    Dim loaiDocGiaBUS As LoaiDocGiaBUS
    Dim thamSo As ThamSoDTO

    Private Sub ucThayDoiQuyDinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thamSoBUS = New ThamSoBUS()
        tacGiaBUS = New TacGiaBUS()
        theLoaiBUS = New TheLoaiBUS()
        loaiDocGiaBUS = New LoaiDocGiaBUS()
        thamSo = New ThamSoDTO()
        ReLoad()
    End Sub

    Private Sub ReLoad()
        thamSoBUS.GetData(thamSo)
        txtTuoiToiThieu.EditValue = thamSo.TuoiToiThieu
        txtTuoiToiDa.EditValue = thamSo.TuoiToiDa
        txtThoiHanThe.EditValue = thamSo.ThoiHanSuDung
        txtNamXuatBan.EditValue = thamSo.GioiHanNamXuatBan
        txtSoLuongTheLoai.EditValue = thamSo.SoLuongTheLoai
        txtSachMuonToiDa.EditValue = thamSo.SoLuongSachMuonToiDa
        txtThoiGianMuonToiDa.EditValue = thamSo.SoNgayMuonToiDa
        txtSoLuongTacGia.EditValue = thamSo.SoLuongTacGia
        txtSoLuongLoaiDocGia.EditValue = thamSo.SoLuongLoaiDocGia
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        ReLoad()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        If txtTuoiToiThieu.EditValue > txtTuoiToiDa.EditValue Then
            MessageBox.Show("Tuổi tối thiểu không thể lớn hơn tuổi tối đa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If txtSoLuongTacGia.EditValue < tacGiaBUS.Dem Then
            MessageBox.Show("Số lượng tác giả trong dữ liệu lớn hơn quy định mới. Vui lòng xoá bớt tác giả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtSoLuongTheLoai.EditValue < theLoaiBUS.Dem Then
            MessageBox.Show("Số lượng Thê loại trong dữ liệu lớn hơn quy định mới. Vui lòng xoá bớt thể loại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtSoLuongLoaiDocGia.EditValue < loaiDocGiaBUS.Dem Then
            MessageBox.Show("Số lượng Loại độc giả trong dữ liệu lớn hơn quy định mới. Vui lòng xoá bớt loại độc giả", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If thamSoBUS.Update(txtTuoiToiThieu.EditValue, txtTuoiToiDa.EditValue, txtThoiHanThe.EditValue, txtNamXuatBan.EditValue, txtSoLuongTacGia.EditValue, txtSachMuonToiDa.EditValue, txtThoiGianMuonToiDa.EditValue, txtSoLuongTheLoai.EditValue, txtSoLuongLoaiDocGia.EditValue).FlagResult = False Then
            MessageBox.Show("Cập nhật Quy định không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Cập nhật Quy định không thành công")
            Return
        Else
            MessageBox.Show("Đã cập nhật quy định")
            GlobalControl.ChangeStatus("Cập nhật Quy định thành công")
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
