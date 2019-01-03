Public Class TheLoaiSachDTO
    Private iMaTheLoai As Integer
    Private iMaSach As Integer

    Public Sub New()
    End Sub

    Public Sub New(iMaTheLoai As Integer, iMaSach As Integer)
        Me.iMaTheLoai = iMaTheLoai
        Me.iMaSach = iMaSach
    End Sub

    Public Property MaTheLoai As Integer
        Get
            Return iMaTheLoai
        End Get
        Set(value As Integer)
            iMaTheLoai = value
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
