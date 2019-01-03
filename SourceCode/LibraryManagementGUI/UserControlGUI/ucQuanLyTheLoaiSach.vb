Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucQuanLyTheLoaiSach
    Private theLoaiBUS As TheLoaiBUS
    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub ucQuanLyTheLoaiSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        theLoaiBUS = New TheLoaiBUS()
        thamSoBUS = New ThamSoBUS()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        LoadListTheLoai()
    End Sub

    Private Sub CaiDatGridControl(listTheLoai As List(Of TheLoaiDTO))
        grcDanhSachTheLoai.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachTheLoai.Columns.Clear()
        grcDanhSachTheLoai.DataSource = listTheLoai
        grvDanhSachTheLoai.OptionsBehavior.Editable = False

        ' Chỉnh độ rộng cột
        grvDanhSachTheLoai.Columns("MaTheLoai").Width = 40
        grvDanhSachTheLoai.Columns("TenTheLoai").Width = 100

        ' Đổi tên cột
        grvDanhSachTheLoai.Columns("MaTheLoai").Caption = "Mã thể loại"
        grvDanhSachTheLoai.Columns("TenTheLoai").Caption = "Tên thể loại"

        grcDanhSachTheLoai.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Sub Reset()
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachTheLoai.FocusedRowHandle

        ' Thay đổi data ô thông tin tác giả
        If (-1 < currenRowIndex < grvDanhSachTheLoai.RowCount) Then
            LoadListTheLoai()
            Dim theLoai = CType(grvDanhSachTheLoai.GetRow(currenRowIndex), TheLoaiDTO)
            LoadTheLoai(theLoai)
            grvDanhSachTheLoai.FocusedRowHandle = (currenRowIndex)
        End If
    End Sub

    Private Sub LoadListTheLoai()
        Dim listTheLoai As List(Of TheLoaiDTO) = New List(Of TheLoaiDTO)
        Dim result As Result
        result = theLoaiBUS.SelectAll(listTheLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tất cả thể loại không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        CaiDatGridControl(listTheLoai)
    End Sub

    Private Sub LoadTheLoai(theLoai As TheLoaiDTO)
        txtMaTheLoai.EditValue = theLoai.MaTheLoai
        txtTenTheLoai.EditValue = theLoai.TenTheLoai
    End Sub

    Private Sub grcDanhSachTheLoai_Click(sender As Object, e As EventArgs) Handles grcDanhSachTheLoai.Click
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachTheLoai.FocusedRowHandle

        ' Thay đổi data ô thông tin tác giả
        If (-1 < currenRowIndex < grvDanhSachTheLoai.RowCount) Then
            Try
                Dim theLoai = CType(grvDanhSachTheLoai.GetRow(currenRowIndex), TheLoaiDTO)
                LoadTheLoai(theLoai)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs)
        Reset()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachTheLoai.FocusedRowHandle

        ' Thay đổi data ô thông tin tác giả
        If (-1 < currenRowIndex < grvDanhSachTheLoai.RowCount) Then
            Try
                Dim theLoai As TheLoaiDTO = New TheLoaiDTO

                ' Chuyển data từ GUI thành DTO
                theLoai.MaTheLoai = txtMaTheLoai.EditValue
                theLoai.TenTheLoai = txtTenTheLoai.EditValue

                ' Kiểm tra tính đúng đắn dữ liệu

                ' Thêm dữ liệu vào database
                Dim result As Result
                result = theLoaiBUS.Update(theLoai)
                If (result.FlagResult) Then
                    MessageBox.Show("Cập nhật thông tin Thể loại thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GlobalControl.ChangeStatus("Cập nhật thông tin Thể loại thành công")
                    Reset()
                Else
                    MessageBox.Show("Cập nhật thông tin Thể loại không thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GlobalControl.ChangeStatus("Cập nhật thông tin Thể loại không thành công")
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Lấy dòng hiện tại
        Dim currentRowIndex As Integer
        currentRowIndex = grvDanhSachTheLoai.FocusedRowHandle

        If (-1 < currentRowIndex < grvDanhSachTheLoai.RowCount) Then
            Select Case MessageBox.Show("Bạn chắc chắn muốn xoá Thể loại " & txtTenTheLoai.EditValue & " với Mã số " & txtMaTheLoai.EditValue & "?", "Xoá Thể loại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case DialogResult.Yes
                    Try
                        Dim soBanGhi As Integer
                        theLoaiBUS.DemBanGhi(txtMaTheLoai.EditValue)
                        If (soBanGhi > 0) Then
                            GlobalControl.ChangeStatus("Còn " & soBanGhi & " sách thuộc thể loại " & txtTenTheLoai.EditValue)
                            MessageBox.Show("Bạn phải xoá TẤT CẢ (" & soBanGhi & ") Sách có Thể loại là " & txtTenTheLoai.EditValue & " trước khi xoá Thể loại này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                        Dim result As Result
                        result = theLoaiBUS.Delete(txtMaTheLoai.EditValue)
                        If (result.FlagResult = True) Then
                            MessageBox.Show("Xóa Thể loại thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            GlobalControl.ChangeStatus("Xóa Thể loại thành công")
                            Reset()
                            If (currentRowIndex >= grvDanhSachTheLoai.RowCount) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                grvDanhSachTheLoai.FocusedRowHandle = (currentRowIndex)
                            End If
                        Else
                            MessageBox.Show("Xóa Thể loại không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            GlobalControl.ChangeStatus("Xóa Thể loại không thành công")
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

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
