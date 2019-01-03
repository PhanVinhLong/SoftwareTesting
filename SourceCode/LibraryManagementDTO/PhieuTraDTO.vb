Public Class PhieuTraDTO
    Private iMaPhieuTra As Integer
    Private strMaDocGia As String
    Private dateNgayTra As DateTime

    Public Sub New()
    End Sub

    Public Sub New(iMaPhieuTra As Integer, strMaDocGia As String, dateNgayTra As DateTime)
        Me.iMaPhieuTra = iMaPhieuTra
        Me.strMaDocGia = strMaDocGia
        Me.dateNgayTra = dateNgayTra
    End Sub

    Public Property MaPhieuTra As Integer
        Get
            Return iMaPhieuTra
        End Get
        Set(value As Integer)
            iMaPhieuTra = value
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

    Public Property NgayTra As Date
        Get
            Return dateNgayTra
        End Get
        Set(value As Date)
            dateNgayTra = value
        End Set
    End Property
End Class
