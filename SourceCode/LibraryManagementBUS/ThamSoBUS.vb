Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class ThamSoBUS
    Private thamSoDAL As ThamSoDAL

    Public Sub New()
        thamSoDAL = New ThamSoDAL
    End Sub

    Public Sub New(ConnectionString)
        thamSoDAL = New ThamSoDAL(ConnectionString)
    End Sub

    Public Function GetData(ByRef thamSo As ThamSoDTO) As Result
        Return thamSoDAL.GetData(thamSo)
    End Function

    Public Function Update(iTuoiToiThieu As Integer, iTuoiToiDa As Integer, iThoiHanSuDung As Integer, iGioiHanNamXuatBan As Integer, iSoLuongTacGia As Integer, iSoLuongSachMuonToiDa As Integer, iSoNgayMuonToiDa As Integer, iSoLuongTheLoai As Integer, iSoLuongLoaiDocGia As Integer) As Result
        Return thamSoDAL.Update(iTuoiToiThieu, iTuoiToiDa, iThoiHanSuDung, iGioiHanNamXuatBan, iSoLuongTacGia, iSoLuongSachMuonToiDa, iSoNgayMuonToiDa, iSoLuongTheLoai, iSoLuongLoaiDocGia)
    End Function
End Class
