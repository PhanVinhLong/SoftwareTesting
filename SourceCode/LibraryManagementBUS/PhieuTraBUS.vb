Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class PhieuTraBUS
    Private phieuTraDAL As PhieuTraDAL

    Public Sub New()
        phieuTraDAL = New PhieuTraDAL()
    End Sub

    Public Sub New(connectionString As String)
        phieuTraDAL = New PhieuTraDAL(connectionString)
    End Sub

    Public Function BuildMaPhieuTra(ByRef nextMaPhieuTra As Integer) As Result
        Return phieuTraDAL.BuildMaPhieuTra(nextMaPhieuTra)
    End Function

    Public Function Insert(phieuTra As PhieuTraDTO) As Result
        Return phieuTraDAL.Insert(phieuTra)
    End Function

    Public Function DeleteByMaDocGia(iMaDocGia As Integer) As Result
        Return phieuTraDAL.DeleteByMaDocGia(iMaDocGia)
    End Function
End Class
