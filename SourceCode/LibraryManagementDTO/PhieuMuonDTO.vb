Public Class PhieuMuonDTO
    Private iMaPhieuMuon As Integer
    Private strMaDocGia As String
    Private dateNgayMuon As DateTime

    Public Sub New()
    End Sub

    Public Sub New(iMaPhieuMuon As Integer, strMaDocGia As String, dateNgayMuon As DateTime)
        Me.iMaPhieuMuon = iMaPhieuMuon
        Me.strMaDocGia = strMaDocGia
        Me.dateNgayMuon = dateNgayMuon
    End Sub

    Public Property MaPhieuMuon As Integer
        Get
            Return iMaPhieuMuon
        End Get
        Set(value As Integer)
            iMaPhieuMuon = value
        End Set
    End Property

    Public Property MaDocGia As String
        Get
            Return strMaDocGia
        End Get
        Set(value As String)
            strMaDocGia = value
        End Set
    End Property

    Public Property NgayMuon As Date
        Get
            Return dateNgayMuon
        End Get
        Set(value As Date)
            dateNgayMuon = value
        End Set
    End Property
End Class
