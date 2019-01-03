Public Class SachTraTreDTO
    Private strTenSach As String
    Private dtNgayMuon As DateTime
    Private iSoNgayTraTre As Integer

    Public Sub New()
    End Sub

    Public Sub New(strTenSach As String, dtNgayMuon As DateTime, iSoNgayTraTre As Integer)
        Me.strTenSach = strTenSach
        Me.dtNgayMuon = dtNgayMuon
        Me.iSoNgayTraTre = iSoNgayTraTre
    End Sub

    Public Property TenSach As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property NgayMuon As DateTime
        Get
            Return dtNgayMuon
        End Get
        Set(value As DateTime)
            dtNgayMuon = value
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

    Public Function Clone() As SachTraTreDTO
        Return Me.MemberwiseClone()
    End Function
End Class
