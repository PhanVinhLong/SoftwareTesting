Imports LibraryManagementDTO

Public Class frmPrint
    Public Sub New(ngayThongKe As DateTime, list As List(Of TinhHinhMuonSachDTO))
        InitializeComponent()

        Dim report = New xrpTinhHinhMuonSach()
        report.Init(Now, ngayThongKe, list)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub

    Public Sub New(ngayThongKe As DateTime, list As List(Of SachTraTreDTO))
        InitializeComponent()

        Dim report = New xrpThongKeSachTraTre()
        report.Init(Now, ngayThongKe, list)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub

    Public Sub New(nhanVien As NhanVienDTO, phieuMuon As PhieuMuonDTO, listSach As List(Of HienThiSachDTO))
        InitializeComponent()

        Dim report = New xrpPhieuMuonSach(nhanVien, phieuMuon, listSach)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub

    Public Sub New(nhanVien As NhanVienDTO, phieuTra As PhieuTraDTO, listSach As List(Of HienThiSachDTO))
        InitializeComponent()

        Dim report = New xrpPhieuTraSach(nhanVien, phieuTra, listSach)
        DocumentViewer.DocumentSource = report
        report.CreateDocument()
    End Sub
End Class