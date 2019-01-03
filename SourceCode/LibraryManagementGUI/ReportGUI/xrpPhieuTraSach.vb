Imports LibraryManagementBUS
Imports LibraryManagementDTO

Public Class xrpPhieuTraSach
    Public Sub New(nhanVien As NhanVienDTO, phieuTra As PhieuTraDTO, listSach As List(Of HienThiSachDTO))
        InitializeComponent()

        Dim docGiaBUS As DocGiaBUS = New DocGiaBUS()
        Dim docGia = docGiaBUS.SelectByDocGia(phieuTra.MaDocGia)

        DSSach.DataSource = listSach
        dateNgayLap.Text = phieuTra.NgayTra.ToShortDateString
        txtMaPhieuMuon.Text = phieuTra.MaPhieuTra
        txtMaDocGia.Text = phieuTra.MaDocGia
        txtHoTen.Text = docGia.HoTen
        txtHoTen2.Text = docGia.HoTen
        txtNhanVien.Text = nhanVien.HoTen
    End Sub
End Class