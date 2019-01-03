Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class ChiTietPhieuMuonBUS
    Private chiTietPhieuMuonDAL As ChiTietPhieuMuonDAL

    Public Sub New()
        chiTietPhieuMuonDAL = New ChiTietPhieuMuonDAL()
    End Sub

    Public Sub New(connectionString As String)
        chiTietPhieuMuonDAL = New ChiTietPhieuMuonDAL(connectionString)
    End Sub

    Public Function Insert(chiTietPhieuMuon As ChiTietPhieuMuonDTO) As Result
        Return chiTietPhieuMuonDAL.Insert(chiTietPhieuMuon)
    End Function

    Public Function InsertList(listChiTietPhieuMuon As List(Of ChiTietPhieuMuonDTO)) As Result
        Return chiTietPhieuMuonDAL.InsertList(listChiTietPhieuMuon)
    End Function

    Public Function DeleteByMaSach(iMaSach As Integer) As Result
        Return chiTietPhieuMuonDAL.DeleteByMaSach(iMaSach)
    End Function

    Public Function DeleteByMaPhieuMuon(iMaPhieuMuon As Integer) As Result
        Return chiTietPhieuMuonDAL.DeleteByMaPhieuMuon(iMaPhieuMuon)
    End Function
End Class
