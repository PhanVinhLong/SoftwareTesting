Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucQuanLyLoaiDocGia
    Private loaiDocGiaBUS As LoaiDocGiaBUS
    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub ucQuanLyLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        loaiDocGiaBUS = New LoaiDocGiaBUS()
        thamSoBUS = New ThamSoBUS()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)
        LoadListLoaiDocGia()
    End Sub

    Private Sub CaiDatGridControl(listLoaiDocGia As List(Of LoaiDocGiaDTO))
        grcDanhSachLoaiDocGia.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachLoaiDocGia.Columns.Clear()
        grcDanhSachLoaiDocGia.DataSource = listLoaiDocGia
        grvDanhSachLoaiDocGia.OptionsBehavior.Editable = False

        ' Chỉnh độ rộng cột
        grvDanhSachLoaiDocGia.Columns("MaLoaiDocGia").Width = 60
        grvDanhSachLoaiDocGia.Columns("TenLoaiDocGia").Width = 100

        ' Đổi tên cột
        grvDanhSachLoaiDocGia.Columns("MaLoaiDocGia").Caption = "Mã loại độc giả"
        grvDanhSachLoaiDocGia.Columns("TenLoaiDocGia").Caption = "Tên loại độc giả"
        grcDanhSachLoaiDocGia.ResumeLayout() ' Tiếp tục hiển thị GridView

        ' Cài đặt form
        Me.Location = New Point(0, 0)
    End Sub

    Private Sub Reset()
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachLoaiDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachLoaiDocGia.RowCount) Then
            LoadListLoaiDocGia()
            Dim loaiDocGia = CType(grvDanhSachLoaiDocGia.GetRow(currenRowIndex), LoaiDocGiaDTO)
            LoadLoaiDocGia(loaiDocGia)
            grvDanhSachLoaiDocGia.FocusedRowHandle = currenRowIndex
        End If
    End Sub

    Private Sub LoadListLoaiDocGia()
        Dim listLoaiDocGia As List(Of LoaiDocGiaDTO) = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = loaiDocGiaBUS.SelectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tất cả loại độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        CaiDatGridControl(listLoaiDocGia)
    End Sub

    Private Sub LoadLoaiDocGia(loaiDocGia As LoaiDocGiaDTO)
        txtMaLoaiDocGia.EditValue = loaiDocGia.MaLoaiDocGia
        txtTenLoaiDocGia.EditValue = loaiDocGia.TenLoaiDocGia
    End Sub

    Private Sub grvDanhSachLoaiDocGia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSachLoaiDocGia.FocusedRowChanged
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachLoaiDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachLoaiDocGia.RowCount) Then
            Try
                Dim loaiDocGia = CType(grvDanhSachLoaiDocGia.GetRow(currenRowIndex), LoaiDocGiaDTO)
                LoadLoaiDocGia(loaiDocGia)
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        Reset()
    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachLoaiDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachLoaiDocGia.RowCount) Then
            Try
                Dim loaiDocGia As LoaiDocGiaDTO
                loaiDocGia = New LoaiDocGiaDTO

                ' Chuyển data từ GUI thành DTO
                loaiDocGia.MaLoaiDocGia = txtMaLoaiDocGia.EditValue
                loaiDocGia.TenLoaiDocGia = txtTenLoaiDocGia.EditValue

                ' Kiểm tra tính đúng đắn dữ liệu

                ' Thêm dữ liệu vào database
                Dim result As Result
                result = loaiDocGiaBUS.Update(loaiDocGia)
                If (result.FlagResult) Then
                    MessageBox.Show("Cập nhật thông tin Loại độc giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GlobalControl.ChangeStatus("Cập nhật thông tin Loại độc giả thành công")
                    Reset()
                Else
                    MessageBox.Show("Cập nhật thông tin Loại độc giả không thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GlobalControl.ChangeStatus("Cập nhật thông tin Loại độc giả thành công")
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
        currentRowIndex = grvDanhSachLoaiDocGia.FocusedRowHandle

        If (-1 < currentRowIndex < grvDanhSachLoaiDocGia.RowCount) Then
            Select Case MessageBox.Show("Bạn chắc chắn muốn xoá Loại độc giả " & txtTenLoaiDocGia.EditValue & " với Mã số " & txtMaLoaiDocGia.EditValue & "?", "Xoá Loại độc giả", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case DialogResult.Yes
                    Try
                        Dim soBanGhi As Integer
                        loaiDocGiaBUS.DemBanGhi(soBanGhi)
                        If (soBanGhi > 0) Then
                            MessageBox.Show("Bạn phải xoá TẤT CẢ Độc giả có Loại độc giả là " & txtTenLoaiDocGia.EditValue & " trước khi xoá Loại độc giả này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                        Dim result As Result
                        result = loaiDocGiaBUS.Delete(txtMaLoaiDocGia.EditValue)
                        If (result.FlagResult = True) Then
                            MessageBox.Show("Xóa Loại độc giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            GlobalControl.ChangeStatus("Xóa Loại độc giả thành công")
                            Reset()
                            If (currentRowIndex >= grvDanhSachLoaiDocGia.RowCount) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                grvDanhSachLoaiDocGia.FocusedRowHandle = currentRowIndex
                            End If
                        Else
                            MessageBox.Show("Xóa Loại độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            GlobalControl.ChangeStatus("Xóa Loại độc giả không thành công")
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

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachLoaiDocGia.ApplyFindFilter(filterString)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtTimKiem.EditValue = ""
    End Sub
End Class