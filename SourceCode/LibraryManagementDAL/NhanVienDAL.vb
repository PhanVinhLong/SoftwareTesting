Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports LibraryManagementDTO
Imports Utility

Public Class NhanVienDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function Insert(nhanVien As NhanVienDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblNhanVien] ([TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien]) "
        sqlQuery &= "VALUES (@TenDangNhap, @HoTen, @MatKhau, @MaLoaiNhanVien) "

        nhanVien.MatKhau = ConvertToMd5(nhanVien.MatKhau)

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TenDangNhap", nhanVien.TenDangNhap)
                    .Parameters.AddWithValue("@HoTen", nhanVien.HoTen)
                    .Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau)
                    .Parameters.AddWithValue("@MaLoaiNhanVien", nhanVien.MaLoaiNhanVien)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectALL(ByRef listNhanVien As List(Of NhanVienDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien] "
        sqlQuery &= "FROM [tblNhanVien] "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        listNhanVien.Clear()
                        While reader.Read()
                            listNhanVien.Add(New NhanVienDTO(reader("TenDangNhap"), reader("HoTen"), reader("MatKhau"), reader("MaLoaiNhanVien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy tất cả nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByMaLoaiNhanVien(iMaLoaiNhanVien As Integer, ByRef listNhanVien As List(Of NhanVienDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien] "
        sqlQuery &= "FROM [tblNhanVien] "
        sqlQuery &= "WHERE [MaLoaiNhanVien] = @MaLoaiNhanVien "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaLoaiNhanVien", iMaLoaiNhanVien)
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        listNhanVien.Clear()
                        While reader.Read()
                            listNhanVien.Add(New NhanVienDTO(reader("TenDangNhap"), reader("HoTen"), reader("MatKhau"), reader("MaLoaiNhanVien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy tất cả nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByUsername(strTenDangNhap As String) As NhanVienDTO
        Dim nhanVien As NhanVienDTO = New NhanVienDTO()
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien] "
        sqlQuery &= "FROM [tblNhanVien] "
        sqlQuery &= "WHERE [TenDangNhap] = @TenDangNhap "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TenDangNhap", strTenDangNhap)
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    While dataReader.Read
                        nhanVien = New NhanVienDTO(dataReader("TenDangNhap"), dataReader("HoTen"), "1", dataReader("MaLoaiNhanVien"))
                    End While
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                End Try
            End Using
        End Using
        Return nhanVien
    End Function

    Public Function Update(nhanVien As NhanVienDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "UPDATE [tblNhanVien] "
        sqlQuery &= "SET [MaLoaiNhanVien] = @MaLoaiNhanVien, "
        sqlQuery &= "    [HoTen] = @HoTen "

        If Not (String.IsNullOrWhiteSpace(nhanVien.MatKhau)) Then
            sqlQuery &= "    ,[MatKhau] = @MatKhau "
            ' Covert mat khau thanh md5
            nhanVien.MatKhau = ConvertToMd5(nhanVien.MatKhau)
        Else
            nhanVien.MatKhau = " "
        End If

        sqlQuery &= "WHERE [TenDangNhap] = @TenDangNhap "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TenDangNhap", nhanVien.TenDangNhap)
                    .Parameters.AddWithValue("@HoTen", nhanVien.HoTen)
                    .Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau)
                    .Parameters.AddWithValue("@MaLoaiNhanVien", nhanVien.MaLoaiNhanVien)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Cập nhật nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(strTenDangNhap As String) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblNhanVien] "
        sqlQuery &= "WHERE [TenDangNhap] = @TenDangNhap "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TenDangNhap", strTenDangNhap)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function IsNotExistUserName(strTenDangNhap As String) As Boolean
        Dim count As Integer = 0
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) FROM [tblNhanVien] "
        sqlQuery &= "WHERE [TenDangNhap] = @TenDangNhap "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TenDangNhap", strTenDangNhap)
                End With
                Try
                    connection.Open()
                    count = command.ExecuteScalar()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                End Try
            End Using
        End Using
        Return If(count = 1, False, True)
    End Function

    Public Function IsCorrectLogin(strTenDangNhap As String, strMatKhau As String) As Boolean
        Dim count As Integer = 0
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) FROM [tblNhanVien] "
        sqlQuery &= "WHERE [TenDangNhap] = @TenDangNhap "
        sqlQuery &= "      AND [MatKhau] = @MatKhau"

        strMatKhau = ConvertToMd5(strMatKhau)

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TenDangNhap", strTenDangNhap)
                    .Parameters.AddWithValue("@MatKhau", strMatKhau)
                End With
                Try
                    connection.Open()
                    count = command.ExecuteScalar()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                End Try
            End Using
        End Using
        Return If(count = 1, True, False)
    End Function

    Public Function EncryptData(ByVal data As String) As Byte()
        Dim md5Hasher As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim hashedBytes As Byte()
        Dim encoder As New System.Text.UTF8Encoding()
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data))
        Return hashedBytes
    End Function

    Public Function ConvertToMd5(ByVal data As String) As String
        Return BitConverter.ToString(EncryptData(data)).Replace("-", "").ToLower()
    End Function
End Class
