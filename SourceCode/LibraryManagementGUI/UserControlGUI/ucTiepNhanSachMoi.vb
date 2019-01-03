Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucTiepNhanSachMoi
    Private sachBUS As SachBUS
    Private tacGiaBUS As TacGiaBUS
    Private theLoaiBUS As TheLoaiBUS
    Private tacGiaSachBUS As TacGiaSachBUS
    Private theLoaiSachBUS As TheLoaiSachBUS
    Private thamSoBUS As ThamSoBUS
    Private lTacGia As List(Of TacGiaDTO)
    Private lTheLoai As List(Of TheLoaiDTO)
    Private result As Result

    Private Sub ucTiepNhanSachMoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        sachBUS = New SachBUS()
        tacGiaBUS = New TacGiaBUS()
        theLoaiBUS = New TheLoaiBUS()
        tacGiaSachBUS = New TacGiaSachBUS()
        theLoaiSachBUS = New TheLoaiSachBUS()
        thamSoBUS = New ThamSoBUS()
        lTacGia = New List(Of TacGiaDTO)
        lTheLoai = New List(Of TheLoaiDTO)
        Dim result As Result

        ' Lấy dữ liệu tham số
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Sinh MaDocGia tiếp theo
        Dim nextMaSach As String = "00000000"
        result = sachBUS.BuildMaSach(nextMaSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Sinh Mã sách không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Parent.Dispose()
            Return
        End If
        txtMaSach.Text = nextMaSach

        ' Cài đặt ô giá trị
        txtTriGia.Properties.Mask.MaskType = Mask.MaskType.Numeric

        ' Lấy danh sách Tác giả
        Dim listTacGia As List(Of TacGiaDTO) = New List(Of TacGiaDTO)
        result = tacGiaBUS.SelectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Tác giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        ' Load grid tác giả
        LoadGridTaGia(listTacGia)

        ' Lấy danh sách Thể loại
        Dim listTheLoai As List(Of TheLoaiDTO) = New List(Of TheLoaiDTO)
        result = theLoaiBUS.SelectAll(listTheLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Thể loại không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        ' Load grid thể loại
        LoadGridTheLoai(listTheLoai)

        ' Đặt giá trị mặc định cho Năm xuất bản
        dteNamXuatBan.EditValue = Now
        dteNamXuatBan.Properties.EditMask = "yyyy"
        dteNamXuatBan.Properties.EditFormat.FormatString = "yyyy"
        dteNamXuatBan.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNamXuatBan.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearsGroupView
        dteNamXuatBan.Properties.DisplayFormat.FormatString = "yyyy"

        ' Đặt giá trị mặc định cho Ngày nhập
        dteNgayNhap.Properties.EditMask = "dd/MM/yyyy"
        dteNgayNhap.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNgayNhap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        dteNgayNhap.EditValue = Now

        ' Hiển thị các quy định
        lblGioiHanNamXuatBan.Text = "* Chỉ nhận sách xuất bản trong " & thamSo.GioiHanNamXuatBan & " năm"
        lblTacGia.Text = "Chưa có tác giả"
        lblTheLoai.Text = "Chưa có thể loại"
    End Sub

    Private Sub LoadGridTaGia(listTacGia As List(Of TacGiaDTO))
        ' Cài đặt cho GridControl và GridView
        grvTacGia.BestFitColumns()
        grvTacGia.Columns.Clear()
        grcTacGia.DataSource = listTacGia
        grvTacGia.OptionsBehavior.Editable = False
        grvTacGia.OptionsFind.AlwaysVisible = False
        grvTacGia.OptionsView.ShowGroupPanel = False
        grvTacGia.OptionsFind.FindDelay = 0
        grvTacGia.BestFitColumns()
        grvTacGia.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect ' Thêm dòng check cho multiselect
        grvTacGia.OptionsSelection.MultiSelect = True ' Bật chế độ multiselect
    End Sub

    Private Sub LoadGridTheLoai(listTheLoai As List(Of TheLoaiDTO))
        ' Cài đặt cho GridControl và GridView
        grvTheLoai.BestFitColumns()
        grvTheLoai.Columns.Clear()
        grcTheLoai.DataSource = listTheLoai
        grvTheLoai.OptionsBehavior.Editable = False
        grvTheLoai.OptionsFind.AlwaysVisible = False
        grvTheLoai.OptionsView.ShowGroupPanel = False
        grvTheLoai.OptionsFind.FindDelay = 0
        grvTheLoai.BestFitColumns()
        grvTheLoai.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect ' Thêm dòng check cho multiselect
        grvTheLoai.OptionsSelection.MultiSelect = True ' Bật chế độ multiselect
    End Sub

    Private Sub dteNamXuatBan_EditValueChanged(sender As Object, e As EventArgs) Handles dteNamXuatBan.EditValueChanged
        If dteNamXuatBan.EditValue = Nothing Then
            dteNamXuatBan.EditValue = Now
        End If
        lblNamXuatBan.Text = "Đã XB " & (Now.Year - dteNamXuatBan.EditValue.Year).ToString & " năm"
    End Sub

    Private Sub TiepNhan()
        Dim sach As SachDTO
        sach = New SachDTO()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Chuyển data từ GUI thành DTO
        sach.MaSach = txtMaSach.EditValue
        sach.TenSach = txtTenSach.EditValue
        sach.NamXuatBan = dteNamXuatBan.EditValue.Year
        sach.NhaXuatBan = If(String.IsNullOrWhiteSpace(txtNhaXuatBan.EditValue) Or txtNhaXuatBan.EditValue = "trống", "trống", txtNhaXuatBan.EditValue)
        sach.TriGia = Convert.ToInt32(txtTriGia.EditValue)
        sach.NgayNhap = dteNgayNhap.EditValue
        sach.MaTrangThai = 1

        ' Kiểm tra tính đúng đắn dữ liệu
        If sachBUS.IsValidTenSach(sach) = False Then
            MessageBox.Show("Tên sách không hợp lệ")
            txtTenSach.Focus()
            Return
        End If
        '----
        If sachBUS.IsValidNamXuatBan(sach) = False Then
            MessageBox.Show("Năm xuất bản không hợp lệ")
            dteNamXuatBan.Focus()
            Return
        End If
        '----
        If sachBUS.IsValidTriGia(sach) = False Then
            MessageBox.Show("Trị giá sách không hợp lệ")
            txtTriGia.Focus()
            Return
        End If
        '----
        If lTheLoai.Count < 1 Then
            MessageBox.Show("Bạn chưa chọn thể loại")
            Return
        End If
        '----
        If lTacGia.Count < 1 Then
            MessageBox.Show("Bạn chưa chọn tác giả")
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = sachBUS.Insert(sach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Sách không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Thêm Sách không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ' Thêm dữ liệu cho thể loại
        Dim listTheLoaiSach = New List(Of TheLoaiSachDTO)
        If lTheLoai.Count < 1 Then
            lblTheLoai.Text = "Chưa chọn thể loại"
        Else
            For Each theLoai In lTheLoai
                listTheLoaiSach.Add(New TheLoaiSachDTO(theLoai.MaTheLoai, Convert.ToInt32(txtMaSach.EditValue)))
            Next
        End If
        result = theLoaiSachBUS.InsertList(listTheLoaiSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Chi tiết thể loại không thành công")
            GlobalControl.ChangeStatus("Thêm Chi tiết thể loại không thành công")
            Return
        End If

        ' Thêm dữ liệu cho tác giả
        Dim listTacGiaSach = New List(Of TacGiaSachDTO)
        If lTacGia.Count < 1 Then
            lblTheLoai.Text = "Chưa chọn tác giả"
        Else
            For Each tacGia In lTacGia
                listTacGiaSach.Add(New TacGiaSachDTO(tacGia.MaTacGia, Convert.ToInt32(txtMaSach.EditValue)))
            Next
        End If
        result = tacGiaSachBUS.InsertList(listTacGiaSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Chi tiết tác giả không thành công")
            GlobalControl.ChangeStatus("Thêm Chi tiết tác giả không thành công")
        End If
        MessageBox.Show("Thêm Sách thành công")
        GlobalControl.ChangeStatus("Thêm Sách thành công")

        ' Sinh MaDocGia tiếp theo
        Dim nextMaSach As String = "00000000"
        result = sachBUS.BuildMaSach(nextMaSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Sinh Mã sách không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Parent.Dispose()
            Return
        End If
        txtMaSach.Text = nextMaSach
    End Sub

    Private Sub btnTiepNhan_Click(sender As Object, e As EventArgs) Handles btnTiepNhan.Click
        TiepNhan()

        ' Reset dữ liệu
        txtTenSach.EditValue = String.Empty
        dteNamXuatBan.EditValue = Now
        txtNhaXuatBan.EditValue = String.Empty
        txtTriGia.EditValue = 0
        dteNgayNhap.EditValue = Now
        lTacGia.Clear()
        lTheLoai.Clear()
        lblTacGia.Text = "Chưa có tác giả"
        lblTheLoai.Text = "Chưa có thể loại"
    End Sub

    Private Sub btnTiepNhanVaDong_Click(sender As Object, e As EventArgs) Handles btnTiepNhanVaDong.Click
        TiepNhan()
        Me.Parent.Dispose()
    End Sub

    Private Sub grvTacGia_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grvTacGia.SelectionChanged
        lblTacGia.Text = String.Empty
        lTacGia.Clear()
        For Each rowIndex As Integer In grvTacGia.GetSelectedRows
            Dim tacGia = tacGiaBUS.SelectByMaTacGia(CType(grvTacGia.GetRow(rowIndex), TacGiaDTO).MaTacGia)
            lTacGia.Add(tacGia)
            lblTacGia.Text &= tacGia.TenTacGia & " (" & tacGia.MaTacGia & "), "
        Next
    End Sub

    Private Sub grvTheLoai_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grvTheLoai.SelectionChanged
        lblTheLoai.Text = String.Empty
        lTheLoai.Clear()
        For Each rowIndex As Integer In grvTheLoai.GetSelectedRows
            Dim theLoai = theLoaiBUS.SelectByMaTheLoai(CType(grvTheLoai.GetRow(rowIndex), TheLoaiDTO).MaTheLoai)
            lTheLoai.Add(theLoai)
            lblTheLoai.Text &= theLoai.TenTheLoai & " (" & theLoai.MaTheLoai & "), "
        Next
    End Sub

    Private Sub txtTimKiemTacGia_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiemTacGia.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiemTacGia.EditValue & """"
        grvTacGia.ApplyFindFilter(filterString)
    End Sub

    Private Sub txtTimKiemTheLoai_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiemTheLoai.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiemTheLoai.EditValue & """"
        grvTheLoai.ApplyFindFilter(filterString)
    End Sub

    Private Sub btnTaiLaiTacGia_Click(sender As Object, e As EventArgs) Handles btnTaiLaiTacGia.Click
        txtTimKiemTacGia.EditValue = ""
    End Sub

    Private Sub txtTaiLaiTheLoai_Click(sender As Object, e As EventArgs) Handles txtTaiLaiTheLoai.Click
        txtTimKiemTheLoai.EditValue = ""
    End Sub
End Class
