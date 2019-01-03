Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucQuanLyTacGia
    Private tacGiaBUS As TacGiaBUS
    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub ucQuanLyTacGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        tacGiaBUS = New TacGiaBUS()
        thamSoBUS = New ThamSoBUS()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        LoadListTacGia()
    End Sub

    Private Sub CaiDatGridControl(listTacGia As List(Of TacGiaDTO))
        grcDanhSachTacGia.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachTacGia.Columns.Clear()
        grcDanhSachTacGia.DataSource = listTacGia
        grvDanhSachTacGia.OptionsBehavior.Editable = False

        ' Chỉnh độ rộng cột
        grvDanhSachTacGia.Columns("MaTacGia").Width = 40
        grvDanhSachTacGia.Columns("TenTacGia").Width = 100

        ' Đổi tên cột
        grvDanhSachTacGia.Columns("MaTacGia").Caption = "Mã tác giả"
        grvDanhSachTacGia.Columns("TenTacGia").Caption = "Tên tác giả"

        grcDanhSachTacGia.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Sub Reset()
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachTacGia.FocusedRowHandle

        ' Thay đổi data ô thông tin tác giả
        If (-1 < currenRowIndex < grvDanhSachTacGia.RowCount) Then
            LoadListTacGia()
            Dim tacGia = CType(grvDanhSachTacGia.GetRow(currenRowIndex), TacGiaDTO)
            LoadTacGia(tacGia)
            grvDanhSachTacGia.FocusedRowHandle = (currenRowIndex)
        End If
    End Sub

    Private Sub LoadListTacGia()
        Dim listTacGia As List(Of TacGiaDTO) = New List(Of TacGiaDTO)
        Dim result As Result
        result = tacGiaBUS.SelectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tất cả tác giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        CaiDatGridControl(listTacGia)
    End Sub

    Private Sub LoadTacGia(tacGia As TacGiaDTO)
        txtMaTacGia.EditValue = tacGia.MaTacGia
        txtTenTacGia.EditValue = tacGia.TenTacGia
    End Sub

    Private Sub grvDanhSachTacGia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSachTacGia.FocusedRowChanged
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachTacGia.FocusedRowHandle

        ' Thay đổi data ô thông tin tác giả
        If (-1 < currenRowIndex < grvDanhSachTacGia.RowCount) Then
            Try
                Dim tacGia = CType(grvDanhSachTacGia.GetRow(currenRowIndex), TacGiaDTO)
                LoadTacGia(tacGia)
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
        currenRowIndex = grvDanhSachTacGia.FocusedRowHandle

        ' Thay đổi data ô thông tin tác giả
        If (-1 < currenRowIndex < grvDanhSachTacGia.RowCount) Then
            Try
                Dim tacGia As TacGiaDTO = New TacGiaDTO

                ' Chuyển data từ GUI thành DTO
                tacGia.MaTacGia = txtMaTacGia.EditValue
                tacGia.TenTacGia = txtTenTacGia.EditValue

                ' Kiểm tra tính đúng đắn dữ liệu

                ' Thêm dữ liệu vào database
                Dim result As Result
                result = tacGiaBUS.Update(tacGia)
                If (result.FlagResult) Then
                    MessageBox.Show("Cập nhật thông tin Tác giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GlobalControl.ChangeStatus("Cập nhật thông tin Tác giả thành công")
                    Reset()
                Else
                    MessageBox.Show("Cập nhật thông tin Tác giả không thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    GlobalControl.ChangeStatus("Cập nhật thông tin Tác giả không thành công")
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
        currentRowIndex = grvDanhSachTacGia.FocusedRowHandle

        If (-1 < currentRowIndex < grvDanhSachTacGia.RowCount) Then
            Select Case MessageBox.Show("Bạn chắc chắn muốn xoá Tác giả " & txtTenTacGia.EditValue & " với Mã số " & txtMaTacGia.EditValue & "?", "Xoá Tác giả", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case DialogResult.Yes
                    Try
                        Dim soBanGhi As Integer
                        tacGiaBUS.DemBanGhi(soBanGhi)
                        If (soBanGhi > 0) Then
                            GlobalControl.ChangeStatus("Còn " & soBanGhi & " thuộc  tác giả " & txtTenTacGia.EditValue)
                            MessageBox.Show("Bạn phải xoá TẤT CẢ (" & soBanGhi & ") Sách có Tác giả là " & txtTenTacGia.EditValue & " trước khi xoá Tác giả này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                        Dim result As Result
                        result = tacGiaBUS.Delete(txtMaTacGia.EditValue)
                        If (result.FlagResult = True) Then
                            MessageBox.Show("Xóa Tác giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            GlobalControl.ChangeStatus("Xóa Tác giả thành công")
                            Reset()
                            If (currentRowIndex >= grvDanhSachTacGia.RowCount) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                grvDanhSachTacGia.FocusedRowHandle = (currentRowIndex)
                            End If
                        Else
                            MessageBox.Show("Xóa Tác giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            GlobalControl.ChangeStatus("Xóa Tác giả không thành công")
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
