Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class HienThiSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function ConvertData(sach As SachDTO) As HienThiSachDTO
        Dim trangThaiDAL As New TrangThaiDAL()
        Dim tacGiaDAL As New TacGiaDAL()
        Dim theLoaiDAL As New TheLoaiDAL()
        Dim trangThai As String = String.Empty
        Dim tacGia As String = String.Empty
        Dim listTacGia As List(Of TacGiaDTO) = New List(Of TacGiaDTO)
        Dim theLoai As String = String.Empty
        Dim listTheLoai As List(Of TheLoaiDTO) = New List(Of TheLoaiDTO)

        trangThai = trangThaiDAL.SelectByMaSach(sach.MaSach).TenTrangThai

        tacGiaDAL.SelectByMaSach(sach.MaSach, listTacGia)
        For Each dr In listTacGia
            If dr.MaTacGia = listTacGia.First.MaTacGia Then
                tacGia = dr.TenTacGia
            Else
                tacGia &= ", " & dr.TenTacGia
            End If
        Next

        theLoaiDAL.SelectByMaSach(sach.MaSach, listTheLoai)
        For Each dr In listTheLoai
            If dr.MaTheLoai = listTheLoai.First.MaTheLoai Then
                theLoai = dr.TenTheLoai
            Else
                theLoai &= ", " & dr.TenTheLoai
            End If
        Next

        Return New HienThiSachDTO(sach.MaSach, sach.TenSach, sach.NamXuatBan, sach.NhaXuatBan, sach.TriGia, sach.NgayNhap, trangThai, tacGia, theLoai)
    End Function

    Public Function ConvertListData(listSach As List(Of SachDTO)) As List(Of HienThiSachDTO)
        Dim listHienThiSach As List(Of HienThiSachDTO) = New List(Of HienThiSachDTO)
        For Each sach In listSach
            listHienThiSach.Add(ConvertData(sach))
        Next
        Return listHienThiSach
    End Function
End Class
