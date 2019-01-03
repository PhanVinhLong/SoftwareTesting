Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucThemTheLoai
    Private theLoaiBUS As TheLoaiBUS
    Private thamSoBUS As ThamSoBUS

    Private Sub ucThemTheLoai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo
        theLoaiBUS = New TheLoaiBUS()
        thamSoBUS = New ThamSoBUS()

        ' Lấy Mã thể loại kế tiếp
        Dim nextMaTheLoai As Integer = Nothing
        Dim result As Result
        result = theLoaiBUS.BuildMaTheLoai(nextMaTheLoai)
        If (result.FlagResult = True) Then
            txtMaTheLoai.EditValue = nextMaTheLoai
        Else
            MessageBox.Show("Lấy Mã thể loại kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        ' Kiểm tra quy định
        KiemTraQuyDinh()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim theLoai As TheLoaiDTO = New TheLoaiDTO()

        ' Chuyển data từ GUI thành DTO
        theLoai.MaTheLoai = Convert.ToInt32(txtMaTheLoai.EditValue)
        theLoai.TenTheLoai = txtTenTheLoai.EditValue

        ' Kiểm tra tính đúng đắn dữ liệu
        If (theLoaiBUS.IsValidTenTheLoai(theLoai) = False) Then
            MessageBox.Show("Tên Thể loại không đúng!")
            txtTenTheLoai.Focus()
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = theLoaiBUS.Insert(theLoai)
        If (result.FlagResult) Then
            MessageBox.Show("Thêm Thể loại thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalControl.ChangeStatus("Thêm Thể loại thành công")
        Else
            MessageBox.Show("Thêm Thể loại không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Thêm Thể loại không thành công")
            System.Console.WriteLine(result.SystemMessage)
        End If

        ' Lấy mã loại độc giả kế tiếp
        Dim nextMaTheLoai As Integer = Nothing
        result = theLoaiBUS.BuildMaTheLoai(nextMaTheLoai)
        If (result.FlagResult = True) Then
            txtMaTheLoai.EditValue = nextMaTheLoai
            txtTenTheLoai.EditValue = Nothing
            KiemTraQuyDinh()
        Else
            MessageBox.Show("Lấy Mã thể loại kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnThemVaDong_Click(sender As Object, e As EventArgs) Handles btnThemVaDong.Click
        Dim theLoai As TheLoaiDTO = New TheLoaiDTO()

        ' Chuyển data từ GUI thành DTO
        theLoai.MaTheLoai = Convert.ToInt32(txtMaTheLoai.EditValue)
        theLoai.TenTheLoai = txtTenTheLoai.EditValue

        ' Kiểm tra tính đúng đắn dữ liệu
        If (theLoaiBUS.IsValidTenTheLoai(theLoai) = False) Then
            MessageBox.Show("Tên Thể loại không đúng!")
            txtTenTheLoai.Focus()
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = theLoaiBUS.Insert(theLoai)
        If (result.FlagResult) Then
            MessageBox.Show("Thêm Thể loại thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Thêm Thể loại không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
        Me.Parent.Dispose()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub KiemTraQuyDinh()
        ' Lấy giá trị tham số
        Dim thamSo = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Hiển thị thông tin số loại độc giả
        Dim soTheLoai As Integer
        soTheLoai = theLoaiBUS.Dem()
        lblGioiHanSoLuong.Text = "* Số Thể loại/ Tối đa: " & soTheLoai & "/" & thamSo.SoLuongTheLoai
        If (soTheLoai >= thamSo.SoLuongTheLoai) Then
            lblCanhBao.Visible = True
            txtTenTheLoai.Enabled = False
            btnThem.Enabled = False
            btnThemVaDong.Enabled = False
        End If

    End Sub
End Class
