Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucThemTacGia
    Private tacGiaBUS As TacGiaBUS
    Private thamSoBUS As ThamSoBUS

    Private Sub ucThemTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo
        tacGiaBUS = New TacGiaBUS()
        thamSoBUS = New ThamSoBUS()

        ' Lấy Mã thể loại kế tiếp
        Dim nextMaTacGia As Integer = Nothing
        Dim result As Result
        result = tacGiaBUS.BuildMaTacGia(nextMaTacGia)
        If (result.FlagResult = True) Then
            txtMaTacGia.EditValue = nextMaTacGia
        Else
            MessageBox.Show("Lấy Mã tác giả kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        ' Kiểm tra quy định
        KiemTraQuyDinh()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim tacGia As TacGiaDTO = New TacGiaDTO()

        ' Chuyển data từ GUI thành DTO
        tacGia.MaTacGia = Convert.ToInt32(txtMaTacGia.EditValue)
        tacGia.TenTacGia = txtTenTacGia.EditValue

        ' Kiểm tra tính đúng đắn dữ liệu
        If (tacGiaBUS.IsValidTenTacGia(tacGia) = False) Then
            MessageBox.Show("Tên Tác giả không đúng!")
            txtTenTacGia.Focus()
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = tacGiaBUS.Insert(tacGia)
        If (result.FlagResult) Then
            MessageBox.Show("Thêm Tác giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalControl.ChangeStatus("Thêm Tác giả thành công")
        Else
            MessageBox.Show("Thêm Tác giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Thêm Tác giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
        End If

        ' Lấy mã tác giả kế tiếp
        Dim nextMaTacGia As Integer = Nothing
        result = tacGiaBUS.BuildMaTacGia(nextMaTacGia)
        If (result.FlagResult = True) Then
            txtMaTacGia.EditValue = nextMaTacGia
            txtTenTacGia.EditValue = Nothing
            KiemTraQuyDinh()
        Else
            MessageBox.Show("Lấy Mã tác giả kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThemVaDong_Click(sender As Object, e As EventArgs) Handles btnThemVaDong.Click
        Dim tacGia As TacGiaDTO = New TacGiaDTO()

        ' Chuyển data từ GUI thành DTO
        tacGia.MaTacGia = Convert.ToInt32(txtMaTacGia.EditValue)
        tacGia.TenTacGia = txtTenTacGia.EditValue

        ' Kiểm tra tính đúng đắn dữ liệu
        If (tacGiaBUS.IsValidTenTacGia(tacGia) = False) Then
            MessageBox.Show("Tên Tác giả không đúng!")
            txtTenTacGia.Focus()
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = tacGiaBUS.Insert(tacGia)
        If (result.FlagResult) Then
            MessageBox.Show("Thêm Tác giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalControl.ChangeStatus("Thêm Tác giả thành công")
        Else
            MessageBox.Show("Thêm Tác giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Thêm Tác giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
        End If

        Me.Parent.Dispose()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Dispose()
    End Sub

    Private Sub KiemTraQuyDinh()
        ' Lấy giá trị tham số
        Dim thamSo = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Hiển thị thông tin số tác giả
        Dim soTacGia As Integer
        soTacGia = tacGiaBUS.Dem()
        lblGioiHanSoLuong.Text = "* Số Tác giả/ Tối đa: " & soTacGia & "/" & thamSo.SoLuongTacGia
        If (soTacGia >= thamSo.SoLuongTacGia) Then
            lblCanhBao.Visible = True
            txtTenTacGia.Enabled = False
            btnThem.Enabled = False
            btnThemVaDong.Enabled = False
        End If
    End Sub
End Class
