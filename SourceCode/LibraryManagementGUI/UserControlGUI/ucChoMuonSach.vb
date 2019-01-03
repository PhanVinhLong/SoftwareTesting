Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucChoMuonSach
    Private sachBUS As SachBUS
    Private theLoaiBUS As TheLoaiBUS
    Private tacGiaBUS As TacGiaBUS
    Private trangThaiBUS As TrangThaiBUS
    Private tacGiaSachBUS As TacGiaSachBUS
    Private theLoaiSachBUS As TheLoaiSachBUS
    Private listSachChon As List(Of SachDTO)
    Private docGia As DocGiaDTO

    Private docGiaBUS As DocGiaBUS
    Private loaiDocGiaBUS As LoaiDocGiaBUS

    Private phieuMuonBUS As PhieuMuonBUS
    Private chiTietPhieuMuonBUS As ChiTietPhieuMuonBUS

    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub ucChoMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Khởi tạo giá trị
        sachBUS = New SachBUS()
        theLoaiBUS = New TheLoaiBUS()
        tacGiaBUS = New TacGiaBUS()
        trangThaiBUS = New TrangThaiBUS()
        tacGiaSachBUS = New TacGiaSachBUS()
        theLoaiSachBUS = New TheLoaiSachBUS()
        listSachChon = New List(Of SachDTO)

        docGiaBUS = New DocGiaBUS()
        loaiDocGiaBUS = New LoaiDocGiaBUS()
        thamSoBUS = New ThamSoBUS()

        phieuMuonBUS = New PhieuMuonBUS()
        chiTietPhieuMuonBUS = New ChiTietPhieuMuonBUS()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Lấy danh sách các thuộc tính lọc (lookupedit)
        Dim listLoaiDocGia As List(Of LoaiDocGiaDTO) = New List(Of LoaiDocGiaDTO)
        result = loaiDocGiaBUS.SelectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Loại độc giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lấy danh sách Loại độc giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lueChonLoaiDocGia.Properties.ShowHeader = False
        lueChonLoaiDocGia.Properties.ShowFooter = False
        lueChonLoaiDocGia.Properties.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        lueChonLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia"
        lueChonLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia"

        ' Xoá cột ValueMember của ChonLoaiDocGia và LoaiDocGia
        lueChonLoaiDocGia.Properties.PopulateColumns()
        lueChonLoaiDocGia.Properties.Columns("MaLoaiDocGia").Visible = False

        ' Đặt giá trị mặc định cho ChonLoaiDocGia
        lueChonLoaiDocGia.EditValue = 1

        ' Load dữ liệu cho GridView
        LoadListDocGia()

        '-----------------------------

        ' Lấy danh sách các thuộc tính lọc (lookupedit)
        Dim listTheLoai = New List(Of TheLoaiDTO)
        result = theLoaiBUS.SelectAll(listTheLoai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Thể loại không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lấy danh sách Loại độc giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        '----
        Dim listTacGia = New List(Of TacGiaDTO)
        result = tacGiaBUS.SelectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Tác giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lấy danh sách Tác giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        '----
        Dim listTrangThai = New List(Of TrangThaiDTO)
        result = trangThaiBUS.SelectALL(listTrangThai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Trạng thái không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lấy danh sách Trạng thái không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lueLocTheLoai.Properties.ShowHeader = False
        lueLocTheLoai.Properties.ShowFooter = False
        lueLocTheLoai.Properties.DataSource = New BindingSource(listTheLoai, String.Empty)
        lueLocTheLoai.Properties.DisplayMember = "TenTheLoai"
        lueLocTheLoai.Properties.ValueMember = "MaTheLoai"
        lueLocTheLoai.Properties.TextEditStyle = TextEditStyles.Standard
        lueLocTheLoai.Properties.SearchMode = SearchMode.AutoFilter
        '----
        lueLocTacGia.Properties.ShowHeader = False
        lueLocTacGia.Properties.ShowFooter = False
        lueLocTacGia.Properties.DataSource = New BindingSource(listTacGia, String.Empty)
        lueLocTacGia.Properties.DisplayMember = "TenTacGia"
        lueLocTacGia.Properties.ValueMember = "MaTacGia"
        lueLocTacGia.Properties.TextEditStyle = TextEditStyles.Standard
        lueLocTacGia.Properties.SearchMode = SearchMode.AutoFilter

        ' Xoá cột ValueMember
        lueLocTheLoai.Properties.PopulateColumns()
        lueLocTheLoai.Properties.Columns(0).Visible = False
        '--------
        lueLocTacGia.Properties.PopulateColumns()
        lueLocTacGia.Properties.Columns(0).Visible = False

        ' Đặt giá trị mặc định cho Lọc năm xuất bản
        dteLocNamXuatBan.EditValue = Now
        dteLocNamXuatBan.Properties.EditMask = "yyyy"
        dteLocNamXuatBan.Properties.EditFormat.FormatString = "yyyy"
        dteLocNamXuatBan.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteLocNamXuatBan.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearsGroupView
        dteLocNamXuatBan.Properties.DisplayFormat.FormatString = "yyyy"

        ' Đặt giá trị mặc định
        lueLocTheLoai.EditValue = 1
        lueLocTacGia.EditValue = 1

        ' Load dữ liệu cho GridView
        LoadGridSach(GetListSach(-1, -1, -1, -1))

        ' Đặt giá trị mặc định cho Ngày nhập
        dteNgayNhap.Properties.EditMask = "dd/MM/yyyy"
        dteNgayNhap.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNgayNhap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        dteNgayNhap.EditValue = Now
    End Sub

    Private Sub CaiDatGridControlDocGia(listDocGia As List(Of DocGiaDTO))
        grcDanhSachDocGia.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachDocGia.BestFitColumns()
        grvDanhSachDocGia.Columns.Clear()
        grcDanhSachDocGia.DataSource = listDocGia
        grvDanhSachDocGia.OptionsBehavior.Editable = False
        grvDanhSachDocGia.OptionsFind.AlwaysVisible = False
        grvDanhSachDocGia.OptionsView.ShowGroupPanel = False
        grvDanhSachDocGia.OptionsFind.FindDelay = 0

        ' Đổi tên cột
        grvDanhSachDocGia.Columns("MaDocGia").Caption = "Mã độc giả"
        grvDanhSachDocGia.Columns("HoTen").Caption = "Họ tên"
        grvDanhSachDocGia.Columns("NgaySinh").Caption = "Ngày sinh"
        grvDanhSachDocGia.Columns("Email").Caption = "Email"
        grvDanhSachDocGia.Columns("DiaChi").Caption = "Địa chỉ"
        grvDanhSachDocGia.Columns("NgayLapThe").Caption = "Ngày lập thẻ"
        grvDanhSachDocGia.Columns("NgayHetHan").Caption = "Ngày hết hạn"

        grcDanhSachDocGia.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Sub LoadListDocGia()
        Dim listDocGia = New List(Of DocGiaDTO)
        Dim result As Result
        result = docGiaBUS.SelectAll(listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lấy danh sách Tác giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        CaiDatGridControlDocGia(listDocGia)
    End Sub

    Private Sub txtTimKiemDocGia_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiemDocGia.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiemDocGia.EditValue & """"
        grvDanhSachDocGia.ApplyFindFilter(filterString)
    End Sub

    Private Sub grvDanhSachDocGia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSachDocGia.FocusedRowChanged
        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            docGia = CType(grvDanhSachDocGia.GetRow(currenRowIndex), DocGiaDTO)
            LoadTenSach(lblSachMuonQuaHan, docGiaBUS.SachMuonHetHan(docGia))
            LoadTenSach(lblSachMuonConHan, docGiaBUS.SachMuonConHan(docGia))
            gcDocGia.Text = docGia.HoTen & " - " & docGia.MaDocGia
        End If
    End Sub

    Private Sub ResetInfoDocGia()
        ' Xoá ô tìm kiếm
        txtTimKiemDocGia.EditValue = Nothing

        ' Load lại data
        LoadListDocGia()

        ' Lấy dòng hiện tại
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachDocGia.FocusedRowHandle

        ' Thay đổi data ô thông tin độc giả
        If (-1 < currenRowIndex < grvDanhSachDocGia.RowCount) Then
            Try
                docGia = CType(grvDanhSachDocGia.GetRow(currenRowIndex), DocGiaDTO)
                LoadTenSach(lblSachMuonQuaHan, docGiaBUS.SachMuonHetHan(docGia))
                LoadTenSach(lblSachMuonConHan, docGiaBUS.SachMuonConHan(docGia))
                gcDocGia.Text = docGia.HoTen & " - " & docGia.MaDocGia
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub LoadTenSach(label As LabelControl, listSach As List(Of SachDTO))
        If listSach.Count < 1 Then
            label.Text = "Không có"
            Return
        End If
        label.Text = String.Empty
        For Each sach In listSach
            label.Text &= sach.TenSach & " (" & sach.MaSach & "), "
        Next
    End Sub

    Private Sub btnTaiLaiDocGia_Click(sender As Object, e As EventArgs) Handles btnTaiLaiDocGia.Click
        ResetInfoDocGia()
    End Sub

    Private Sub lueChonLoaiDocGia_EditValueChanged(sender As Object, e As EventArgs) Handles lueChonLoaiDocGia.EditValueChanged
        Try
            Dim maLoaiDocGia As Integer
            maLoaiDocGia = Convert.ToInt32(lueChonLoaiDocGia.EditValue)
            LoadListDocGia(maLoaiDocGia)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub LoadListDocGia(maLoaiDocGia As Integer)
        Dim listDocGia As List(Of DocGiaDTO) = New List(Of DocGiaDTO)
        Dim result As Result
        result = docGiaBUS.SellectByLoaiDocGia(maLoaiDocGia, listDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách tất cả Độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lấy danh sách tất cả Độc giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        CaiDatGridControlDocGia(listDocGia)
    End Sub

    '------------------------------------------------

    Private Sub LoadGridSach(listSach As List(Of SachDTO))
        Dim hienThiSachBUS = New HienThiSachBUS()
        Dim listHienThiSach As List(Of HienThiSachDTO)
        listHienThiSach = hienThiSachBUS.ConvertListData(listSach)
        grcDanhSachSach.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachSach.BestFitColumns()
        grvDanhSachSach.Columns.Clear()
        grcDanhSachSach.DataSource = listHienThiSach
        grvDanhSachSach.OptionsBehavior.Editable = False
        grvDanhSachSach.OptionsFind.AlwaysVisible = False
        grvDanhSachSach.OptionsView.ShowGroupPanel = False
        grvDanhSachSach.OptionsFind.FindDelay = 0
        grvDanhSachDocGia.BestFitColumns()
        grvDanhSachSach.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect ' Thêm dòng check cho multiselect
        grvDanhSachSach.OptionsSelection.MultiSelect = True ' Bật chế độ multiselect

        ' Thay đổi tên cột
        grvDanhSachSach.Columns("MaSach").Caption = "Mã sách"
        grvDanhSachSach.Columns("TenSach").Caption = "Tên sách"
        grvDanhSachSach.Columns("NamXuatBan").Caption = "Năm xuất bản"
        grvDanhSachSach.Columns("NhaXuatBan").Caption = "Nhà xuất bản"
        grvDanhSachSach.Columns("TriGia").Caption = "Trị giá"
        grvDanhSachSach.Columns("NgayNhap").Caption = "Ngày nhập"
        grvDanhSachSach.Columns("TrangThai").Caption = "Trạng thái"
        grvDanhSachSach.Columns("TacGia").Caption = "Tác giả"
        grvDanhSachSach.Columns("TheLoai").Caption = "Thể loại"

        grcDanhSachSach.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Function GetListSach(iMaTheLoai As Integer, iMaTacGia As Integer, iMaTrangThai As Integer, iNamXuatBan As Integer) As List(Of SachDTO)
        Dim listSach = New List(Of SachDTO)
        Dim result As Result
        ' Chỉ lấy sách đang sẵn sàng để mượn
        iMaTrangThai = 1
        result = sachBUS.SelectByCondition(iMaTheLoai, iMaTacGia, iMaTrangThai, iNamXuatBan, listSach)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Sách theo điều kiện không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lấy danh sách Sách theo điều kiện không thành công")
            System.Console.WriteLine(result.SystemMessage)
        End If
        Return listSach
    End Function

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachSach.ApplyFindFilter(filterString)
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        txtTimKiem.EditValue = Nothing
        ckeTheLoai.Checked = False
        ckeTacGia.Checked = False
        ckeNamXuatBan.Checked = False
        LoadGridSach(GetListSach(-1, -1, 1, -1))
    End Sub

    Private Sub grvDanhSachSach_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grvDanhSachSach.SelectionChanged
        lblSachDaChon.Text = String.Empty
        listSachChon.Clear()
        For Each rowIndex As Integer In grvDanhSachSach.GetSelectedRows
            Dim sach = sachBUS.SelectByMaSach(CType(grvDanhSachSach.GetRow(rowIndex), HienThiSachDTO).MaSach)
            listSachChon.Add(sach)
            lblSachDaChon.Text &= sach.TenSach & " (" & sach.MaSach & "), "
        Next
    End Sub

    Private Sub btnLoc_Click(sender As Object, e As EventArgs) Handles btnLoc.Click
        ' Khai báo
        Dim iMaTheLoai As Integer
        Dim iMaTacGia As Integer
        Dim iNamXuatBan As Integer

        ' Lấy dữ liệu từ GUI
        If ckeTheLoai.Checked = False Then
            iMaTheLoai = -1
        Else
            iMaTheLoai = lueLocTheLoai.EditValue
        End If
        If ckeTacGia.Checked = False Then
            iMaTacGia = -1
        Else
            iMaTacGia = lueLocTacGia.EditValue
        End If
        If ckeNamXuatBan.Checked = False Then
            iNamXuatBan = -1
        Else
            iNamXuatBan = dteLocNamXuatBan.EditValue.Year
        End If

        ' Lọc data
        LoadGridSach(GetListSach(iMaTheLoai, iMaTacGia, 1, iNamXuatBan))
    End Sub

    Private Sub ChoMuonSach()
        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Kiểm tra
        If dteNgayNhap.EditValue > Now Then
            MessageBox.Show("Ngày nhập không đúng")
            GlobalControl.ChangeStatus("Ngày nhập không đúng")
            Return
        End If
        ' ----
        If listSachChon.Count < 1 Then
            MessageBox.Show("Bạn chưa chọn sách nào")
            GlobalControl.ChangeStatus("Bạn chưa chọn sách nà")
            Return
        End If
        ' ----
        If docGia.MaDocGia = Nothing Then
            MessageBox.Show("Bạn chưa chọn độc giả")
            GlobalControl.ChangeStatus("Bạn chưa chọn độc giả")
            Return
        End If
        '----
        For Each sach In listSachChon
            If sachBUS.NgayMuonCuoi(sach) > dteNgayNhap.EditValue Then
                MessageBox.Show("Ngày mượn không thể nhỏ hơn ngày mượn cuối cùng hoặc ngày nhập sách")
                GlobalControl.ChangeStatus("Ngày mượn không thể nhỏ hơn ngày mượn cuối cùng hoặc ngày nhập sách")
                Return
            End If
        Next

        ' Lấy Data phiếu mượn kế tiếp
        Dim phieuMuon = New PhieuMuonDTO()
        Dim nextMaPhieuMuon As Integer = Nothing
        Dim result As Result
        result = phieuMuonBUS.BuildMaPhieuMuon(nextMaPhieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy Mã phiếu mượn kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            GlobalControl.ChangeStatus("Lấy Mã phiếu mượn kế tiếp không thành công")
            Return
        Else
            phieuMuon.MaPhieuMuon = nextMaPhieuMuon
            phieuMuon.MaDocGia = docGia.MaDocGia
            phieuMuon.NgayMuon = dteNgayNhap.EditValue
        End If

        ' Thêm dữ liệu vào database cho Phiếu mượn
        result = phieuMuonBUS.Insert(phieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Phiếu mượn không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            GlobalControl.ChangeStatus("Thêm Phiếu mượn không thành công")
            Return
        End If

        ' Lấy Data list Danh sách Chi tiết phiếu mượn
        Dim listChiTietPhieuMuon = New List(Of ChiTietPhieuMuonDTO)
        listChiTietPhieuMuon.Clear()
        For Each sach As SachDTO In listSachChon
            listChiTietPhieuMuon.Add(New ChiTietPhieuMuonDTO(nextMaPhieuMuon, sach.MaSach))
        Next

        ' Thêm dữ liệu vào database cho List Chi tiết phiếu mượn
        result = chiTietPhieuMuonBUS.InsertList(listChiTietPhieuMuon)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Chi tiết phiếu mượn không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            GlobalControl.ChangeStatus("Thêm Chi tiết phiếu mượn không thành công")
            Return
        End If

        ' Thay đổi trạng thái sách
        For Each sach In listSachChon
            sach.MaTrangThai = 2
            result = sachBUS.Update(sach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật trạng thái Sách lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GlobalControl.ChangeStatus("Cập nhật trạng thái Sách lỗi")
                Return
            End If
        Next
        If MessageBox.Show("Đã Lập phiếu mượn. Bạn có muốn In Phiếu mượn?", "In phiếu mượn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim hienThiSachBUS = New HienThiSachBUS()
            Dim listHienThiSach As List(Of HienThiSachDTO)
            listHienThiSach = hienThiSachBUS.ConvertListData(listSachChon)
            Using frmPrint As frmPrint = New frmPrint(GlobalControl.ReturnNhanVien, phieuMuon, listHienThiSach)
                frmPrint.ShowDialog()
            End Using
            GlobalControl.ChangeStatus("Đã In phiếu mượn")
        Else
            GlobalControl.ChangeStatus("Đã Lập phiếu mượn")
        End If
    End Sub


    Private Sub btnChoMuon_Click(sender As Object, e As EventArgs) Handles btnChoMuon.Click
        ChoMuonSach()

        ' Reset dữ liệu
        LoadGridSach(GetListSach(-1, -1, 1, -1))
        ResetInfoDocGia()
        listSachChon.Clear()
        lblSachDaChon.Text = "Chưa chọn sách"
        dteNgayNhap.EditValue = Now
    End Sub

    Private Sub btnChoMuonVaDong_Click(sender As Object, e As EventArgs) Handles btnChoMuonVaDong.Click
        ChoMuonSach()
        Me.Parent.Dispose()
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
