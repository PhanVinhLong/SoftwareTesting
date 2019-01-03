Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class PhieuMuonBUS
    Private phieuMuonDAL As PhieuMuonDAL

    Public Sub New()
        phieuMuonDAL = New PhieuMuonDAL()
    End Sub

    Public Sub New(connectionString As String)
        phieuMuonDAL = New PhieuMuonDAL(connectionString)
    End Sub

    Public Function BuildMaPhieuMuon(ByRef nextMaPhieuMuon As Integer) As Result
        Return phieuMuonDAL.BuildMaPhieuMuon(nextMaPhieuMuon)
    End Function

    Public Function Insert(phieuMuon As PhieuMuonDTO) As Result
        Return phieuMuonDAL.Insert(phieuMuon)
    End Function

    Public Function DeleteByMaDocGia(iMaDocGia As Integer) As Result
        Return phieuMuonDAL.DeleteByMaDocGia(iMaDocGia)
    End Function
End Class
