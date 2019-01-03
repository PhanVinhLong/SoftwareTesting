Imports System.Text.RegularExpressions
Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class TrangThaiBUS
    Private trangThaiDAL As TrangThaiDAL

    Public Sub New()
        trangThaiDAL = New TrangThaiDAL()
    End Sub

    Public Sub New(connectionString As String)
        trangThaiDAL = New TrangThaiDAL(connectionString)
    End Sub

    Public Function IsValidTenTrangThai(trangThai As TrangThaiDTO)
        If trangThai.TenTrangThai.Length < 1 Then
            Return False
        End If
        Return True
    End Function

    Public Function BuildMaTrangThai(ByRef nextMaTrangThai As Integer)
        Return trangThaiDAL.BuildMaTrangThai(nextMaTrangThai)
    End Function

    Public Function SelectALL(ByRef listTrangThai As List(Of TrangThaiDTO)) As Result
        Return trangThaiDAL.SelectALL(listTrangThai)
    End Function

    Public Function SelectByMaTrangThai(iMaTrangThai As Integer) As TrangThaiDTO
        Return trangThaiDAL.SelectByMaTrangThai(iMaTrangThai)
    End Function

    Public Function SelectByMaSach(iMaSach As Integer) As TrangThaiDTO
        Return trangThaiDAL.SelectByMaSach(iMaSach)
    End Function

    Public Function Insert(trangThai As TrangThaiDTO) As Result
        Return trangThaiDAL.Insert(trangThai)
    End Function

    Public Function Update(trangThai As TrangThaiDTO) As Result
        Return trangThaiDAL.Update(trangThai)
    End Function

    Public Function Delete(iMaTrangThai As Integer) As Result
        Return trangThaiDAL.Delete(iMaTrangThai)
    End Function

    Public Function Dem() As Integer
        Return trangThaiDAL.Dem()
    End Function

    Public Function DemBanGhi(iMaTrangThai As Integer) As Integer
        Return trangThaiDAL.DemBanGhi(iMaTrangThai)
    End Function
End Class
