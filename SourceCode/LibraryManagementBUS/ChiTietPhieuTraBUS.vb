Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility


Public Class ChiTietPhieuTraBUS
    Private chiTietPhieuTraDAL As ChiTietPhieuTraDAL

    Public Sub New()
        chiTietPhieuTraDAL = New ChiTietPhieuTraDAL()
    End Sub

    Public Sub New(connectionString As String)
        chiTietPhieuTraDAL = New ChiTietPhieuTraDAL(connectionString)
    End Sub

    Public Function Insert(chiTietPhieuTra As ChiTietPhieuTraDTO) As Result
        Return chiTietPhieuTraDAL.Insert(chiTietPhieuTra)
    End Function

    Public Function InsertList(listChiTietPhieuTra As List(Of ChiTietPhieuTraDTO)) As Result
        Return chiTietPhieuTraDAL.InsertList(listChiTietPhieuTra)
    End Function

    Public Function DeleteByMaSach(iMaSach As Integer) As Result
        Return chiTietPhieuTraDAL.DeleteByMaSach(iMaSach)
    End Function

    Public Function DeleteByMaPhieuTra(iMaPhieuTra As Integer) As Result
        Return chiTietPhieuTraDAL.DeleteByMaPhieuTra(iMaPhieuTra)
    End Function
End Class
