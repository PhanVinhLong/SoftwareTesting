Public Class ChiTietPhieuTraDTO
    Private iMaPhieuTra As Integer
    Private iMaSach As Integer
    Private iMaPhieuMuon As Integer
    Private iSoNgayTraTre As Integer

    Public Sub New()
    End Sub

    Public Sub New(iMaPhieuTra As Integer, iMaSach As Integer, iMaPhieuMuon As Integer, iSoNgayTraTre As Integer)
        Me.iMaPhieuTra = iMaPhieuTra
        Me.iMaSach = iMaSach
        Me.iMaPhieuMuon = iMaPhieuMuon
        Me.iSoNgayTraTre = iSoNgayTraTre
    End Sub

    Public Property MaPhieuTra As Integer
        Get
            Return iMaPhieuTra
        End Get
        Set(value As Integer)
            iMaPhieuTra = value
        End Set
    End Property

    Public Property MaSach As Integer
        Get
            Return iMaSach
        End Get
        Set(value As Integer)
            iMaSach = value
        End Set
    End Property

    Public Property SoNgayTraTre As Integer
        Get
            Return iSoNgayTraTre
        End Get
        Set(value As Integer)
            iSoNgayTraTre = value
        End Set
    End Property

    Public Property MaPhieuMuon As Integer
        Get
            Return iMaPhieuMuon
        End Get
        Set(value As Integer)
            iMaPhieuMuon = value
        End Set
    End Property
End Class
