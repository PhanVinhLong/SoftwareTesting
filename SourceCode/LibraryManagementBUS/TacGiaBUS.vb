Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class TacGiaBUS
    Private tacGiaDAL As TacGiaDAL

    Public Sub New()
        tacGiaDAL = New TacGiaDAL()
    End Sub

    Public Sub New(connectionString As String)
        tacGiaDAL = New TacGiaDAL(connectionString)
    End Sub

    Public Function IsValidTenTacGia(tacGia As TacGiaDTO)
        If (tacGia.TenTacGia.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function BuildMaTacGia(ByRef nextMaTacGia As Integer) As Result
        Return tacGiaDAL.BuildMaTacGia(nextMaTacGia)
    End Function

    Public Function SelectAll(ByRef listTacGia As List(Of TacGiaDTO)) As Result

        Return tacGiaDAL.SelectALL(listTacGia)
    End Function

    Public Function SelectByMaTacGia(iMaTacGia As Integer) As TacGiaDTO

        Return tacGiaDAL.SelectByMaTacGia(iMaTacGia)
    End Function

    Public Function SelectByMaSach(iMaSach As Integer, ByRef listTacGia As List(Of TacGiaDTO)) As Result
        Return tacGiaDAL.SelectByMaSach(iMaSach, listTacGia)
    End Function

    Public Function Insert(tacGia As TacGiaDTO) As Result
        Return tacGiaDAL.Insert(tacGia)
    End Function

    Public Function Update(tacGia As TacGiaDTO) As Result
        Return tacGiaDAL.Update(tacGia)
    End Function

    Public Function Delete(iMaTacGia As Integer) As Result
        Return tacGiaDAL.Delete(iMaTacGia)
    End Function

    Public Function Dem() As Integer
        Return tacGiaDAL.Dem()
    End Function

    Public Function DemBanGhi(iMaTacGia As Integer) As Integer
        Return tacGiaDAL.DemBanGhi(iMaTacGia)
    End Function
End Class
