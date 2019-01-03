Public Class ThamSoDTO
    Private iTuoiToiThieu As Integer
    Private iTuoiToiDa As Integer
    Private iThoiHanSuDung As Integer
    Private iGioiHanNamXuatBan As Integer
    Private iSoLuongTacGia As Integer
    Private iSoLuongSachMuonToiDa As Integer
    Private iSoNgayMuonToiDa As Integer
    Private iSoLuongTheLoai As Integer
    Private iSoLuongLoaiDocGia As Integer

    Public Sub New()
    End Sub

    Public Sub New(iTuoiToiThieu As Integer, iTuoiToiDa As Integer, iThoiHanSuDung As Integer, iGioiHanNamXuatBan As Integer, iSoLuongTacGia As Integer, iSoLuongSachMuonToiDa As Integer, iSoNgayMuonToiDa As Integer, iSoLuongTheLoai As Integer, iSoLuongLoaiDocGia As Integer)
        Me.iTuoiToiThieu = iTuoiToiThieu
        Me.iTuoiToiDa = iTuoiToiDa
        Me.iThoiHanSuDung = iThoiHanSuDung
        Me.iGioiHanNamXuatBan = iGioiHanNamXuatBan
        Me.iSoLuongTacGia = iSoLuongTacGia
        Me.iSoLuongSachMuonToiDa = iSoLuongSachMuonToiDa
        Me.iSoNgayMuonToiDa = iSoNgayMuonToiDa
        Me.iSoLuongTheLoai = iSoLuongTheLoai
        Me.iSoLuongLoaiDocGia = iSoLuongLoaiDocGia
    End Sub

    Public Property TuoiToiThieu As Integer
        Get
            Return iTuoiToiThieu
        End Get
        Set(value As Integer)
            iTuoiToiThieu = value
        End Set
    End Property

    Public Property TuoiToiDa As Integer
        Get
            Return iTuoiToiDa
        End Get
        Set(value As Integer)
            iTuoiToiDa = value
        End Set
    End Property

    Public Property ThoiHanSuDung As Integer
        Get
            Return iThoiHanSuDung
        End Get
        Set(value As Integer)
            iThoiHanSuDung = value
        End Set
    End Property

    Public Property GioiHanNamXuatBan As Integer
        Get
            Return iGioiHanNamXuatBan
        End Get
        Set(value As Integer)
            iGioiHanNamXuatBan = value
        End Set
    End Property

    Public Property SoLuongTacGia As Integer
        Get
            Return iSoLuongTacGia
        End Get
        Set(value As Integer)
            iSoLuongTacGia = value
        End Set
    End Property

    Public Property SoLuongSachMuonToiDa As Integer
        Get
            Return iSoLuongSachMuonToiDa
        End Get
        Set(value As Integer)
            iSoLuongSachMuonToiDa = value
        End Set
    End Property

    Public Property SoNgayMuonToiDa As Integer
        Get
            Return iSoNgayMuonToiDa
        End Get
        Set(value As Integer)
            iSoNgayMuonToiDa = value
        End Set
    End Property

    Public Property SoLuongTheLoai As Integer
        Get
            Return iSoLuongTheLoai
        End Get
        Set(value As Integer)
            iSoLuongTheLoai = value
        End Set
    End Property

    Public Property SoLuongLoaiDocGia As Integer
        Get
            Return iSoLuongLoaiDocGia
        End Get
        Set(value As Integer)
            iSoLuongLoaiDocGia = value
        End Set
    End Property
End Class
