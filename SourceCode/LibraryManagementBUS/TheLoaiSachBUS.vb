Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class TheLoaiSachBUS
    Private theLoaiSachDAL As TheLoaiSachDAL

    Public Sub New()
        theLoaiSachDAL = New TheLoaiSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        theLoaiSachDAL = New TheLoaiSachDAL(connectionString)
    End Sub

    Public Function Insert(theLoaiSach As TheLoaiSachDTO) As Result
        Return theLoaiSachDAL.Insert(theLoaiSach)
    End Function

    Public Function InsertList(listTheLoaiSach As List(Of TheLoaiSachDTO)) As Result
        Return theLoaiSachDAL.InsertList(listTheLoaiSach)
    End Function

    Public Function DeleteByMaSach(iMaSach As Integer) As Result
        Return theLoaiSachDAL.DeleteByMaSach(iMaSach)
    End Function
End Class
