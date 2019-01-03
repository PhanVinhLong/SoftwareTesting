Public Class ChiTietPhieuMuonDTO
    Private iMaPhieuMuon As Integer
    Private iMaSach As Integer

    Public Sub New()
    End Sub

    Public Sub New(iMaPhieuMuon As Integer, iMaSach As Integer)
        Me.iMaPhieuMuon = iMaPhieuMuon
        Me.iMaSach = iMaSach
    End Sub

    Public Property MaPhieuMuon As Integer
        Get
            Return iMaPhieuMuon
        End Get
        Set(value As Integer)
            iMaPhieuMuon = value
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
End Class
