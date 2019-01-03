Public Class NhanVienDTO
    Private strTenDangNhap As String
    Private strHoTen As String
    Private strMatKhau As String
    Private iMaLoaiNhanVien As Integer

    Public Sub New()
    End Sub

    Public Sub New(strTenDangNhap As String, strHoTen As String, strMatKhau As String, iMaLoaiNhanVien As Integer)
        Me.strTenDangNhap = strTenDangNhap
        Me.strHoTen = strHoTen
        Me.strMatKhau = strMatKhau
        Me.iMaLoaiNhanVien = iMaLoaiNhanVien
    End Sub

    Public Property TenDangNhap As String
        Get
            Return strTenDangNhap
        End Get
        Set(value As String)
            strTenDangNhap = value
        End Set
    End Property

    Public Property HoTen As String
        Get
            Return strHoTen
        End Get
        Set(value As String)
            strHoTen = value
        End Set
    End Property

    Public Property MatKhau As String
        Get
            Return strMatKhau
        End Get
        Set(value As String)
            strMatKhau = value
        End Set
    End Property

    Public Property MaLoaiNhanVien As Integer
        Get
            Return iMaLoaiNhanVien
        End Get
        Set(value As Integer)
            iMaLoaiNhanVien = value
        End Set
    End Property
End Class
