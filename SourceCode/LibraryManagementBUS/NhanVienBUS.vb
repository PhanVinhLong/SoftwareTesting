Imports System.Text.RegularExpressions
Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class NhanVienBUS
    Private nhanVienDAL As NhanVienDAL

    Public Sub New()
        nhanVienDAL = New NhanVienDAL()
    End Sub

    Public Sub New(connectionString As String)
        nhanVienDAL = New NhanVienDAL(connectionString)
    End Sub

    Public Function IsValidTenDangNhap(strHoTen As String) As Boolean
        If String.IsNullOrWhiteSpace(strHoTen) Then
            Return False
        End If
        If String.IsNullOrWhiteSpace(strHoTen) Then
            Return True
        End If
        Dim regex As Regex = New Regex("[a-zA-Z0-9]{4,}")
        If regex.Match(strHoTen).Success = False Then
            Return False
        End If
        Return True
    End Function

    Public Function IsValidMatKhau(strMatKhau As String) As Boolean
        If String.IsNullOrWhiteSpace(strMatKhau) Then
            Return True
        End If
        Dim regex As Regex = New Regex("[a-zA-Z0-9]{6,}")
        If regex.Match(strMatKhau).Success Then
            Return True
        End If
        Return False
    End Function

    Public Function IsValidHoTen(strHoTen As String) As Boolean
        If String.IsNullOrWhiteSpace(strHoTen) Then
            Return False
        End If
        Return True
    End Function

    Public Function Insert(nhanVien As NhanVienDTO) As Result
        Return nhanVienDAL.Insert(nhanVien)
    End Function

    Public Function Update(nhanVien As NhanVienDTO) As Result
        Return nhanVienDAL.Update(nhanVien)
    End Function

    Public Function SelectALL(ByRef listNhanVien As List(Of NhanVienDTO)) As Result
        Return nhanVienDAL.SelectALL(listNhanVien)
    End Function

    Public Function SelectByMaLoaiNhanVien(iMaLoaiNhanVien As Integer, ByRef listNhanVien As List(Of NhanVienDTO)) As Result
        Return nhanVienDAL.SelectByMaLoaiNhanVien(iMaLoaiNhanVien, listNhanVien)
    End Function

    Public Function SelectByUsername(strTenDangNhap As String) As NhanVienDTO
        Return nhanVienDAL.SelectByUsername(strTenDangNhap)
    End Function

    Public Function IsNotExistUserName(strTenDangNhap As String) As Boolean
        Return nhanVienDAL.IsNotExistUserName(strTenDangNhap)
    End Function

    Public Function IsCorrectLogin(strTenDangNhap As String, strMatKhau As String) As Boolean
        Return nhanVienDAL.IsCorrectLogin(strTenDangNhap, strMatKhau)
    End Function

    Public Function Delete(strTenDangNhap As String) As Result
        Return nhanVienDAL.Delete(strTenDangNhap)
    End Function
End Class
