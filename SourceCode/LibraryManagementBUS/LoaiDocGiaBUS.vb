Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class LoaiDocGiaBUS
    Private loaiDocGiaDAL As LoaiDocGiaDAL

    Public Sub New()
        loaiDocGiaDAL = New LoaiDocGiaDAL()
    End Sub

    Public Sub New(connectionString As String)
        loaiDocGiaDAL = New LoaiDocGiaDAL(connectionString)
    End Sub

    Public Function IsValidTenLoaiDocGia(loaiDocGia As LoaiDocGiaDTO)
        If (loaiDocGia.TenLoaiDocGia.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function BuildMaLoaiDocGia(ByRef nextMaLoaiDocGia As Integer) As Result
        Return loaiDocGiaDAL.BuildMaLoaiDocGia(nextMaLoaiDocGia)
    End Function

    Public Function SelectAll(ByRef listLoaiDocGia As List(Of LoaiDocGiaDTO)) As Result

        Return loaiDocGiaDAL.SelectALL(listLoaiDocGia)
    End Function

    Public Function Insert(loaiDocGia As LoaiDocGiaDTO) As Result
        Return loaiDocGiaDAL.Insert(loaiDocGia)
    End Function

    Public Function Update(loaiDocGia As LoaiDocGiaDTO) As Result
        Return loaiDocGiaDAL.Update(loaiDocGia)
    End Function

    Public Function Delete(iMaLoaiDocGia As Integer) As Result
        Return loaiDocGiaDAL.Delete(iMaLoaiDocGia)
    End Function

    Public Function Dem() As Integer
        Return loaiDocGiaDAL.Dem()
    End Function

    Public Function DemBanGhi(iMaLoaiDocGia As Integer) As Integer
        Return loaiDocGiaDAL.DemBanGhi(iMaLoaiDocGia)
    End Function
End Class
