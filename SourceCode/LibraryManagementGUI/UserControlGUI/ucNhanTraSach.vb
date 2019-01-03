Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucNhanTraSach
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

    Private phieuTraBUS As PhieuTraBUS
    Private chiTietPhieuTraBUS As ChiTietPhieuTraBUS

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

        phieuTraBUS = New PhieuTraBUS()
        chiTietPhieuTraBUS = New ChiTietPhieuTraBUS()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Lấy danh sách các thuộc tính lọc (lookupedit)
        Dim listLoaiDocGia As List(Of LoaiDocGiaDTO) = New List(Of LoaiDocGiaDTO)
        result = loaiDocGiaBUS.SelectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Loại độc giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        lueChonLoaiDocGia.Properties.ShowHeader = False
        lueChonLoaiDocGia.Properties.ShowFooter = False
        lueChonLoaiDocGia.Properties.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        lueChonLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia"
        lueChonLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia"
        lueChonLoaiDocGia.Properties.TextEditStyle = TextEditStyles.Standard
        lueChonLoaiDocGia.Properties.SearchMode = SearchMode.AutoFilter

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
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        '----
        Dim listTacGia = New List(Of TacGiaDTO)
        result = tacGiaBUS.SelectAll(listTacGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Tác giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        '----
        Dim listTrangThai = New List(Of TrangThaiDTO)
        result = trangThaiBUS.SelectALL(listTrangThai)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Trạng thái không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ' Load dữ liệu cho GridView
        LoadListSach()

        ' Đặt giá trị mặc định cho Ngày nhập
        dteNgayTra.Properties.EditMask = "dd/MM/yyyy"
        dteNgayTra.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNgayTra.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        dteNgayTra.EditValue = Now
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
        grvDanhSachDocGia.BestFitColumns()

        ' Chỉnh độ rộng cột
        grvDanhSachDocGia.Columns("MaDocGia").Width = 70
        grvDanhSachDocGia.Columns("HoTen").Width = 120
        grvDanhSachDocGia.Columns("NgaySinh").Width = 70
        grvDanhSachDocGia.Columns("Email").Width = 120
        grvDanhSachDocGia.Columns("DiaChi").Width = 140
        grvDanhSachDocGia.Columns("NgayLapThe").Width = 70
        grvDanhSachDocGia.Columns("NgayHetHan").Width = 70

        ' Ẩn cột
        'grvDanhSachDocGia.Columns("MaDocLoaiGia").Visible = False

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
            LoadListSach()
        End If
    End Sub

    Private Sub ResetDocGia()
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
                LoadListSach()
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
        ResetDocGia()
    End Sub

    '------------------------------------------------

    Private Sub CaiDatGridControl(listSach As List(Of SachDTO))
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
        grvDanhSachSach.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        grvDanhSachSach.OptionsSelection.MultiSelect = True
        grvDanhSachDocGia.BestFitColumns()

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

    Private Sub Reset()
        Dim currenRowIndex As Integer
        currenRowIndex = grvDanhSachSach.FocusedRowHandle

        ' Thay đổi data ô thông tin sách
        If (-1 < currenRowIndex < grvDanhSachSach.RowCount) Then
            LoadListSach()
            Dim sach = sachBUS.SelectByMaSach(CType(grvDanhSachSach.GetRow(currenRowIndex), HienThiSachDTO).MaSach)
            LoadSach(sach)
            grvDanhSachSach.FocusedRowHandle = currenRowIndex
        End If

        ' Xoá ô tìm kiếm
        txtTimKiem.EditValue = Nothing
    End Sub

    Private Sub LoadListSach()
        Dim listSach = New List(Of SachDTO)
        listSach = docGiaBUS.SachMuon(docGia)

        CaiDatGridControl(listSach)
    End Sub

    Private Sub LoadSach(sach As SachDTO)

    End Sub

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachSach.ApplyFindFilter(filterString)
    End Sub

    Private Sub btnTimKiem_Click(sender As Object, e As EventArgs)
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachSach.ApplyFindFilter(filterString)
    End Sub

    Private Sub btnTaiLai_Click(sender As Object, e As EventArgs) Handles btnTaiLai.Click
        Reset()
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

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub

    Private Sub btnNhanSach_Click(sender As Object, e As EventArgs) Handles btnNhanSach.Click
        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Kiểm tra
        If listSachChon.Count < 1 Then
            MessageBox.Show("Bạn chưa chọn sách")
            Return
        End If

        For Each sach As SachDTO In listSachChon
            If sachBUS.NgayHetHan(sach).AddDays(-thamSo.SoNgayMuonToiDa) > dteNgayTra.EditValue Then
                MessageBox.Show("Ngày trả không thể nhỏ hơn ngày mượn của sách (" & sach.TenSach & ")", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GlobalControl.ChangeStatus("Ngày trả không thể nhỏ hơn ngày mượn của sách (" & sach.TenSach & ")")
                Return
            End If
        Next

        ' Lấy Data phiếu trả
        Dim phieuTra = New PhieuTraDTO()
        Dim nextMaPhieuTra As Integer = Nothing
        Dim result As Result
        result = phieuTraBUS.BuildMaPhieuTra(nextMaPhieuTra)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy Mã phiếu trả kế tiếp không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        Else
            phieuTra.MaPhieuTra = nextMaPhieuTra
            phieuTra.MaDocGia = docGia.MaDocGia
            phieuTra.NgayTra = dteNgayTra.EditValue
        End If

        ' Lấy Data list Danh sách Chi tiết phiếu trả
        Dim soNgayTraTre As Integer
        Dim listChiTietPhieuTra = New List(Of ChiTietPhieuTraDTO)
        Dim maPhieuMuon As Integer
        listChiTietPhieuTra.Clear()
        For Each sach As SachDTO In listSachChon
            soNgayTraTre = (Now - sachBUS.NgayHetHan(sach)).Days
            soNgayTraTre = If(soNgayTraTre < 0, 0, soNgayTraTre)
            maPhieuMuon = sachBUS.MaPhieuMuonCuoi(sach)
            listChiTietPhieuTra.Add(New ChiTietPhieuTraDTO(nextMaPhieuTra, sach.MaSach, maPhieuMuon, soNgayTraTre))
        Next

        ' Thêm dữ liệu vào database cho Phiếu trả
        result = phieuTraBUS.Insert(phieuTra)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Phiếu trả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ' Thêm dữ liệu vào database cho List Chi tiết phiếu trả
        result = chiTietPhieuTraBUS.InsertList(listChiTietPhieuTra)
        If (result.FlagResult = False) Then
            MessageBox.Show("Thêm Chi tiết phiếu trả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        ' Thay đổi trạng thái sách
        For Each sach In listSachChon
            sach.MaTrangThai = 1
            result = sachBUS.Update(sach)
            If (result.FlagResult = False) Then
                MessageBox.Show("Cập nhật trạng thái Sách lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next
        GlobalControl.ChangeStatus("Đã Lập phiếu mượn")
        If MessageBox.Show("Đã Lập phiếu trả sách. Bạn có muốn In Phiếu trả sách?", "In phiếu trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim hienThiSachBUS = New HienThiSachBUS()
            Dim listHienThiSach As List(Of HienThiSachDTO)
            listHienThiSach = hienThiSachBUS.ConvertListData(listSachChon)
            Using frmPrint As frmPrint = New frmPrint(GlobalControl.ReturnNhanVien, phieuTra, listHienThiSach)
                frmPrint.ShowDialog()
            End Using
            GlobalControl.ChangeStatus("Đã In phiếu trả")
        Else
            GlobalControl.ChangeStatus("Đã Lập phiếu trả")
        End If

        ' Reset dữ liệu
        ResetDocGia()
        listSachChon.Clear()
        lblSachDaChon.Text = "Chưa chọn sách"
        dteNgayTra.EditValue = Now
    End Sub
End Class
