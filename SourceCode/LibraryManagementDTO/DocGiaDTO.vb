Public Class DocGiaDTO
    Private strMaDocGia As String
    Private strHoTen As String
    Private dateNgaySinh As Date
    Private strDiaChi As String
    Private strEmail As String
    Private dateNgayLapThe As Date
    Private dateNgayHetHan As Date
    Private iMaLoaiDocGia As Integer

    Public Sub New()
    End Sub

    Public Sub New(strMaDocGia As String, strHoTen As String, dateNgaySinh As DateTime, strDiaChi As String, strEmail As String, dateNgayLapThe As DateTime, dateNgayHetHan As DateTime, iMaLoaiDocGia As Integer)
        Me.strMaDocGia = strMaDocGia
        Me.strHoTen = strHoTen
        Me.dateNgaySinh = dateNgaySinh
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.dateNgayLapThe = dateNgayLapThe
        Me.dateNgayHetHan = dateNgayHetHan
        Me.iMaLoaiDocGia = iMaLoaiDocGia
    End Sub

    Property MaDocGia As String
        Get
            Return strMaDocGia
        End Get
        Set(value As String)
            strMaDocGia = value
        End Set
    End Property

    Property HoTen As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Property NgaySinh As Date
        Get
            Return dateNgaySinh
        End Get
        Set(value As Date)
            dateNgaySinh = value
        End Set
    End Property

    Property DiaChi As String
        Get
            Return strDiaChi
        End Get
        Set(value As String)
            strDiaChi = value
        End Set
    End Property

    Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Property MaLoaiDocGia As Integer
        Get
            Return iMaLoaiDocGia
        End Get
        Set(value As Integer)
            iMaLoaiDocGia = value
        End Set
    End Property

    Public Property NgayLapThe As Date
        Get
            Return dateNgayLapThe
        End Get
        Set(value As Date)
            dateNgayLapThe = value
        End Set
    End Property

    Public Property NgayHetHan As Date
        Get
            Return dateNgayHetHan
        End Get
        Set(value As Date)
            dateNgayHetHan = value
        End Set
    End Property
End Class
