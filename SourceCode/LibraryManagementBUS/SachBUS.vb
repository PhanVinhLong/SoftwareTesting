Imports System.Text.RegularExpressions
Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class SachBUS
    Private sachDAL As SachDAL

    Public Sub New()
        sachDAL = New SachDAL()
    End Sub

    Public Sub New(connectionString As String)
        sachDAL = New SachDAL(connectionString)
    End Sub

    Public Function IsValidTenSach(sach As SachDTO) As Boolean
        If (sach.TenSach = Nothing) Then
            Return False
        ElseIf (sach.TenSach.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function IsValidNamXuatBan(sach As SachDTO) As Boolean
        Dim thamSoDAL = New ThamSoDAL
        Dim thamSo = New ThamSoDTO
        thamSoDAL.GetData(thamSo)
        If (sach.NamXuatBan > Now.Year Or sach.NamXuatBan - Now.Year > 8) Then
            Return False
        End If
        Return True
    End Function

    Public Function IsValidTriGia(sach As SachDTO) As Boolean
        If (sach.TriGia < 0) Then
            Return False
        End If
        Return True
    End Function

    Public Function BuildMaSach(ByRef nextMaSach As Integer) As Result
        Return sachDAL.BuildMaSach(nextMaSach)
    End Function

    Public Function Insert(sach As SachDTO) As Result

        Return sachDAL.Insert(sach)
    End Function

    Public Function SelectAll(ByRef listSach As List(Of SachDTO)) As Result
        Return sachDAL.SelectAll(listSach)
    End Function

    Public Function SelectByMaSach(iMaSach As Integer) As SachDTO
        Return sachDAL.SelectByMaSach(iMaSach)
    End Function

    Public Function SelectByCondition(iMaTheLoai As Integer, iMaTacGia As Integer, iMaTrangThai As Integer, iNamXuatBan As Integer, ByRef listSach As List(Of SachDTO)) As Result
        Return sachDAL.SelectByCondition(iMaTheLoai, iMaTacGia, iMaTrangThai, iNamXuatBan, listSach)
    End Function

    Public Function DemPhieuMuon(iMaSach As Integer) As Integer
        Return sachDAL.DemPhieuMuon(iMaSach)
    End Function

    Public Function Update(sach As SachDTO) As Result
        Return sachDAL.Update(sach)
    End Function

    Public Function Delete(iMaSach As Integer) As Result
        Return sachDAL.Delete(iMaSach)
    End Function

    Public Function NgayHetHan(sach As SachDTO) As DateTime
        Return sachDAL.NgayHetHan(sach)
    End Function

    Public Function MaPhieuMuonCuoi(sach As SachDTO) As Integer
        Return sachDAL.MaPhieuMuonCuoi(sach)
    End Function

    Public Function NgayMuonCuoi(sach As SachDTO) As DateTime
        Return sachDAL.NgayMuonCuoi(sach)
    End Function

    Public Function DeleteLichSuMuonTra(iMaSach As Integer) As Result
        Return sachDAL.DeleteLichSuMuonTra(iMaSach)
    End Function
End Class
