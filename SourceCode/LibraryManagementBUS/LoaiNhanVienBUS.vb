Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class LoaiNhanVienBUS
    Private loaiNhanVienDAL As LoaiNhanVienDAL

    Public Sub New()
        loaiNhanVienDAL = New LoaiNhanVienDAL()
    End Sub

    Public Sub New(connectionString As String)
        loaiNhanVienDAL = New LoaiNhanVienDAL(connectionString)
    End Sub

    Public Function SelectALL(ByRef listLoaiNhanVien As List(Of LoaiNhanVienDTO)) As Result
        Return loaiNhanVienDAL.SelectALL(listLoaiNhanVien)
    End Function

    Public Function Delete(iMaNhanVien As Integer) As Result
        Return loaiNhanVienDAL.Delete(iMaNhanVien)
    End Function

    Public Function GetName(iMaLoaiNhanVien As Integer) As String
        Return loaiNhanVienDAL.GetName(iMaLoaiNhanVien)
    End Function
End Class
