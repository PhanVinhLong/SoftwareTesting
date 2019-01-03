Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucThemLoaiDocGia
    Private loaiDocGiaBUS As LoaiDocGiaBUS
    Private thamSoBUS As ThamSoBUS

    Private Sub ucThemLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo
        loaiDocGiaBUS = New LoaiDocGiaBUS()
        thamSoBUS = New ThamSoBUS()

        ' Lấy mã loại độc giả kế tiếp
        Dim nextMaLoaiDocGia As Integer = Nothing
        Dim result As Result
        result = loaiDocGiaBUS.BuildMaLoaiDocGia(nextMaLoaiDocGia)
        If (result.FlagResult = True) Then
            txtMaLoaiDocGia.EditValue = nextMaLoaiDocGia
        Else
            MessageBox.Show("Lấy mã loại độc giả kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If

        ' Kiểm tra quy định
        KiemTraQuyDinh()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim loaiDocGia As LoaiDocGiaDTO = New LoaiDocGiaDTO()

        ' Chuyển data từ GUI thành DTO
        loaiDocGia.MaLoaiDocGia = Convert.ToInt32(txtMaLoaiDocGia.EditValue)
        loaiDocGia.TenLoaiDocGia = txtTenLoaiDocGia.EditValue

        ' Kiểm tra tính đúng đắn dữ liệu
        If (loaiDocGiaBUS.IsValidTenLoaiDocGia(loaiDocGia) = False) Then
            MessageBox.Show("Tên Loại độc giả không đúng")
            txtTenLoaiDocGia.Focus()
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = loaiDocGiaBUS.Insert(loaiDocGia)
        If (result.FlagResult) Then
            MessageBox.Show("Thêm Loại độc giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalControl.ChangeStatus("Thêm Loại độc giả thành công")
        Else
            MessageBox.Show("Thêm Loại độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Thêm Loại độc giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
        End If

        ' Lấy mã loại độc giả kế tiếp
        Dim nextMaLoaiDocGia As Integer = Nothing
        result = loaiDocGiaBUS.BuildMaLoaiDocGia(nextMaLoaiDocGia)
        If (result.FlagResult = True) Then
            txtMaLoaiDocGia.EditValue = nextMaLoaiDocGia
            txtTenLoaiDocGia.EditValue = Nothing
            KiemTraQuyDinh()
        Else
            MessageBox.Show("Lấy mã loại độc giả kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThemVaDong_Click(sender As Object, e As EventArgs) Handles btnThemVaDong.Click
        Dim loaiDocGia As LoaiDocGiaDTO = New LoaiDocGiaDTO()

        ' Chuyển data từ GUI thành DTO
        loaiDocGia.MaLoaiDocGia = Convert.ToInt32(txtMaLoaiDocGia.EditValue)
        loaiDocGia.TenLoaiDocGia = txtTenLoaiDocGia.EditValue

        ' Kiểm tra tính đúng đắn dữ liệu
        If (loaiDocGiaBUS.IsValidTenLoaiDocGia(loaiDocGia) = False) Then
            MessageBox.Show("Tên Loại độc giả không đúng!")
            txtTenLoaiDocGia.Focus()
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = loaiDocGiaBUS.Insert(loaiDocGia)
        If (result.FlagResult) Then
            MessageBox.Show("Thêm Loại độc giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalControl.ChangeStatus("Thêm Loại độc giả thành công")
            Me.Parent.Dispose()
        Else
            MessageBox.Show("Thêm Loại độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Thêm Loại độc giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub KiemTraQuyDinh()
        ' Lấy giá trị tham số
        Dim thamSo = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Hiển thị thông tin số loại độc giả
        Dim soLoaiDocGia As Integer
        soLoaiDocGia = loaiDocGiaBUS.Dem()
        lblGioiHanLoaiDocGia.Text = "* Số Loại độc giả/ Tối đa: " & soLoaiDocGia & "/" & thamSo.SoLuongLoaiDocGia
        If (soLoaiDocGia >= thamSo.SoLuongLoaiDocGia) Then
            lblCanhBao.Visible = True
            txtTenLoaiDocGia.Enabled = False
            btnThem.Enabled = False
            btnThemVaDong.Enabled = False
        End If
    End Sub
End Class
