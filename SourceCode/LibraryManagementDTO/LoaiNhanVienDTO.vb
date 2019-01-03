Public Class LoaiNhanVienDTO
    Private iMaLoaiNhanVien As Integer
    Private strTenLoaiNhanVien As String

    Public Sub New()
    End Sub

    Public Sub New(iMaLoaiNhanVien As Integer, strTenLoaiNhanVien As String)
        Me.iMaLoaiNhanVien = iMaLoaiNhanVien
        Me.strTenLoaiNhanVien = strTenLoaiNhanVien
    End Sub

    Public Property MaLoaiNhanVien As Integer
        Get
            Return iMaLoaiNhanVien
        End Get
        Set(value As Integer)
            iMaLoaiNhanVien = value
        End Set
    End Property

    Public Property TenLoaiNhanVien As String
        Get
            Return strTenLoaiNhanVien
        End Get
        Set(value As String)
            strTenLoaiNhanVien = value
        End Set
    End Property
End Class
