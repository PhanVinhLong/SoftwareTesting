Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class TheLoaiBUS
    Private theLoaiDAL As TheLoaiDAL

    Public Sub New()
        theLoaiDAL = New TheLoaiDAL()
    End Sub

    Public Sub New(connectionString As String)
        theLoaiDAL = New TheLoaiDAL(connectionString)
    End Sub

    Public Function IsValidTenTheLoai(theLoai As TheLoaiDTO)
        If (theLoai.TenTheLoai.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function BuildMaTheLoai(ByRef nextMaTheLoai As Integer) As Result
        Return theLoaiDAL.BuildMaTheLoai(nextMaTheLoai)
    End Function

    Public Function SelectAll(ByRef listTheLoai As List(Of TheLoaiDTO)) As Result

        Return theLoaiDAL.SelectALL(listTheLoai)
    End Function

    Public Function SelectByMaTheLoai(iMaTheLoai As Integer) As TheLoaiDTO

        Return theLoaiDAL.SelectByMaTheLoai(iMaTheLoai)
    End Function

    Public Function SelectByMaSach(iMaSach As Integer, ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Return theLoaiDAL.SelectByMaSach(iMaSach, listTheLoai)
    End Function

    Public Function Insert(theLoai As TheLoaiDTO) As Result
        Return theLoaiDAL.Insert(theLoai)
    End Function

    Public Function Update(theLoai As TheLoaiDTO) As Result
        Return theLoaiDAL.Update(theLoai)
    End Function

    Public Function Delete(iMaTheLoai As Integer) As Result
        Return theLoaiDAL.Delete(iMaTheLoai)
    End Function

    Public Function Dem() As Integer
        Return theLoaiDAL.Dem()
    End Function

    Public Function DemBanGhi(iMaTheLoai As Integer) As Integer
        Return theLoaiDAL.DemBanGhi(iMaTheLoai)
    End Function
End Class
