Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucLapTheDocGia
    Private docGiaBUS As DocGiaBUS
    Private loaiDocGiaBUS As LoaiDocGiaBUS
    Private thamSoBUS As ThamSoBUS
    Private result As Result

    Private Sub ucLapTheDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cài đặt UC

        ' Khởi tạo giá trị
        docGiaBUS = New DocGiaBUS()
        loaiDocGiaBUS = New LoaiDocGiaBUS()
        thamSoBUS = New ThamSoBUS()
        Dim result As Result

        ' Lấy dữ liệu tham số
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Sinh MaDocGia tiếp theo
        Dim nextMaDocGia As String = "00000000"
        result = docGiaBUS.BuildMaDocGia(nextMaDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Sinh Mã độc giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Sinh Mã độc giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Me.Parent.Dispose()
            Return
        End If
        txtMaDocGia.Text = nextMaDocGia

        ' Lấy danh sách LoaiDocGia
        Dim listLoaiDocGia As List(Of LoaiDocGiaDTO) = New List(Of LoaiDocGiaDTO)
        result = loaiDocGiaBUS.SelectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách Loại độc giả không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Lấy danh sách Loại độc giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If
        lueLoaiDocGia.Properties.ShowHeader = False
        lueLoaiDocGia.Properties.ShowFooter = False
        lueLoaiDocGia.Properties.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        lueLoaiDocGia.Properties.DisplayMember = "TenLoaiDocGia"
        lueLoaiDocGia.Properties.ValueMember = "MaLoaiDocGia"
        lueLoaiDocGia.Properties.TextEditStyle = TextEditStyles.Standard
        lueLoaiDocGia.Properties.SearchMode = SearchMode.AutoFilter

        ' Xoá cột ValueMember của LoaiDocGia
        lueLoaiDocGia.Properties.PopulateColumns()
        lueLoaiDocGia.Properties.Columns("MaLoaiDocGia").Visible = False

        ' Đặt giá trị mặc định cho LoaiDocGia
        lueLoaiDocGia.EditValue = 1

        ' Đặt giá trị mặc định cho NgaySinh
        dteNgaySinh.Properties.EditMask = "dd/MM/yyyy"
        dteNgaySinh.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Dim DateTime = System.DateTime.Now.AddYears(-20).AddDays(-1)
        dteNgaySinh.EditValue = DateTime

        ' Đặt giá trị mặc định cho NgayLapThe
        dteNgayLapThe.Properties.EditMask = "dd/MM/yyyy"
        dteNgayLapThe.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNgayLapThe.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        DateTime = System.DateTime.Now
        dteNgayLapThe.EditValue = DateTime

        ' Đặt giá trị mặc định cho NgayHetHan
        dteNgayHetHan.Properties.EditMask = "dd/MM/yyyy"
        dteNgayHetHan.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteNgayHetHan.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        DateTime = dteNgayLapThe.EditValue.AddMonths(thamSo.ThoiHanSuDung)
        dteNgayHetHan.EditValue = DateTime

        ' Hiển thị các quy định
        lblThoiHanSuDung.Text = "* Thời hạn sử dụng: " & thamSo.ThoiHanSuDung & " tháng"
        lblGioiHanTuoi.Text = "* Tuổi từ " & thamSo.TuoiToiThieu & " đến " & thamSo.TuoiToiDa
    End Sub

    Private Sub dteNgaySinh_EditValueChanged(sender As Object, e As EventArgs) Handles dteNgaySinh.EditValueChanged
        docGiaBUS = New DocGiaBUS()
        lblTuoi.Text = docGiaBUS.CaculateAges(dteNgaySinh.EditValue) & " tuổi"
    End Sub

    Private Sub dtNgayLapThe_EditValueChanged(sender As Object, e As EventArgs)
        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        '
        Dim DateTime = dteNgayLapThe.EditValue.AddMonths(thamSo.ThoiHanSuDung)
        dteNgayHetHan.EditValue = DateTime
    End Sub

    Private Sub btnLapThe_Click(sender As Object, e As EventArgs) Handles btnLapThe.Click
        Dim docGia As DocGiaDTO
        docGia = New DocGiaDTO()

        ' Lấy dữ liệu tham số
        thamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoBUS.GetData(thamSo)

        ' Chuyển data từ GUI thành DTO
        docGia.HoTen = txtHoTen.EditValue
        docGia.NgaySinh = dteNgaySinh.EditValue
        docGia.DiaChi = txtDiaChi.EditValue
        docGia.Email = txtEmail.EditValue
        docGia.NgayLapThe = dteNgayLapThe.EditValue
        docGia.NgayHetHan = dteNgayHetHan.EditValue
        docGia.MaLoaiDocGia = lueLoaiDocGia.EditValue

        ' Kiểm tra tính đúng đắn dữ liệu
        If (docGiaBUS.IsValidHoTen(docGia) = False) Then
            MessageBox.Show("Tên độc giả không hợp lệ!")
            GlobalControl.ChangeStatus("Tên độc giả không hợp lệ")
            txtHoTen.Focus()
            Return
        End If
        '------
        If (docGiaBUS.IsValidNgayLapThe(docGia) = False) Then
            MessageBox.Show("Ngày lập thẻ không hợp lệ!")
            GlobalControl.ChangeStatus("Ngày lập thẻ không hợp lệ")
            dteNgayLapThe.Focus()
            Return
        End If
        '------
        If (docGiaBUS.IsValidNgaySinh(docGia) = False) Then
            MessageBox.Show("Ngày sinh không hợp lệ!")
            GlobalControl.ChangeStatus("Ngày sinh không hợp lệ")
            dteNgaySinh.Focus()
            Return
        End If
        '------
        If (docGiaBUS.IsValidEmail(docGia) = False) Then
            MessageBox.Show("Email không hợp lệ!")
            dteNgayLapThe.Focus()
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = docGiaBUS.Insert(docGia)
        If (result.FlagResult) Then
            MessageBox.Show("Thêm Độc giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Sinh MaDocGia tiếp theo
            Dim nextMaDocGia As String = "00000000"
            result = docGiaBUS.BuildMaDocGia(nextMaDocGia)
            If (result.FlagResult = False) Then
                MessageBox.Show("Sinh MaDocGia không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                GlobalControl.ChangeStatus("Sinh MaDocGia không thành công")
                System.Console.WriteLine(result.SystemMessage)
                Me.Parent.Dispose()
                Return
            End If
            txtMaDocGia.Text = nextMaDocGia

            ' Reset dữ liệu
            txtHoTen.EditValue = String.Empty
            dteNgaySinh.EditValue = System.DateTime.Now.AddYears(-20).AddDays(-1)
            txtDiaChi.EditValue = String.Empty
            txtEmail.EditValue = String.Empty
            dteNgayLapThe.EditValue = System.DateTime.Now
            dteNgayLapThe.EditValue.AddMonths(thamSo.ThoiHanSuDung)
        Else
            MessageBox.Show("Thêm Độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Thêm Độc giả không thành côn")
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnLapTheVaDong_Click(sender As Object, e As EventArgs) Handles btnLapTheVaDong.Click
        Dim docGia As DocGiaDTO
        docGia = New DocGiaDTO()

        ' Chuyển data từ GUI thành DTO

        docGia.HoTen = txtHoTen.EditValue
        docGia.NgaySinh = dteNgaySinh.EditValue
        docGia.DiaChi = txtDiaChi.EditValue
        docGia.Email = txtEmail.EditValue
        docGia.NgayLapThe = dteNgayLapThe.EditValue
        docGia.NgayHetHan = dteNgayHetHan.EditValue
        docGia.MaLoaiDocGia = lueLoaiDocGia.EditValue

        ' Kiểm tra tính đúng đắn dữ liệu
        If (docGiaBUS.IsValidHoTen(docGia) = False) Then
            MessageBox.Show("Tên độc giả không đúng!")
            GlobalControl.ChangeStatus("Tên độc giả không đúng")
            txtHoTen.Focus()
            Return
        End If

        ' Thêm dữ liệu vào database
        Dim result As Result
        result = docGiaBUS.Insert(docGia)
        If (result.FlagResult) Then
            MessageBox.Show("Thêm Độc giả thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GlobalControl.ChangeStatus("Thêm Độc giả thành công")
            Me.Parent.Dispose()
        Else
            MessageBox.Show("Thêm Độc giả không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GlobalControl.ChangeStatus("Thêm Độc giả không thành công")
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
