Public Class HienThiSachDTO
    Private iMaSach As Integer
    Private strTenSach As String
    Private iNamXuatBan As Integer
    Private strNhaXuatBan As String
    Private iTriGia As Integer
    Private dateNgayNhap As DateTime
    Private strTrangThai As String
    Private strTacGia As String
    Private strTheLoai As String

    Public Sub New()
    End Sub

    Public Sub New(iMaSach As Integer, strTenSach As String, iNamXuatBan As Integer, strNhaXuatBan As String, iTriGia As Integer, dateNgayNhap As DateTime, strTrangThai As String, strTacGia As String, strTheLoai As String)
        Me.iMaSach = iMaSach
        Me.strTenSach = strTenSach
        Me.iNamXuatBan = iNamXuatBan
        Me.strNhaXuatBan = strNhaXuatBan
        Me.iTriGia = iTriGia
        Me.dateNgayNhap = dateNgayNhap
        Me.strTrangThai = strTrangThai
        Me.strTacGia = strTacGia
        Me.strTheLoai = strTheLoai
    End Sub

    Public Property MaSach As Integer
        Get
            Return iMaSach
        End Get
        Set(value As Integer)
            iMaSach = value
        End Set
    End Property

    Public Property TenSach As String
        Get
            Return strTenSach
        End Get
        Set(value As String)
            strTenSach = value
        End Set
    End Property

    Public Property NamXuatBan As Integer
        Get
            Return iNamXuatBan
        End Get
        Set(value As Integer)
            iNamXuatBan = value
        End Set
    End Property

    Public Property NhaXuatBan As String
        Get
            Return strNhaXuatBan
        End Get
        Set(value As String)
            strNhaXuatBan = value
        End Set
    End Property

    Public Property TriGia As Integer
        Get
            Return iTriGia
        End Get
        Set(value As Integer)
            iTriGia = value
        End Set
    End Property

    Public Property NgayNhap As Date
        Get
            Return dateNgayNhap
        End Get
        Set(value As Date)
            dateNgayNhap = value
        End Set
    End Property

    Public Property TrangThai As String
        Get
            Return strTrangThai
        End Get
        Set(value As String)
            strTrangThai = value
        End Set
    End Property

    Public Property TacGia As String
        Get
            Return strTacGia
        End Get
        Set(value As String)
            strTacGia = value
        End Set
    End Property

    Public Property TheLoai As String
        Get
            Return strTheLoai
        End Get
        Set(value As String)
            strTheLoai = value
        End Set
    End Property
End Class
