Imports System.Configuration
Imports System.Data.SqlClient
    Imports LibraryManagementDTO
    Imports Utility

Public Class SachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaSach(ByRef nextMaSach As Integer) As Result
        nextMaSach = 0
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaSach] "
        sqlQuery &= "FROM [tblSach] "
        sqlQuery &= "ORDER BY [MaSach] DESC "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    Dim maSachOnDB As Integer = 0
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maSachOnDB = dataReader("MaSach")
                        End While
                    End If
                    nextMaSach = maSachOnDB + 1
                    System.Console.WriteLine(nextMaSach)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã sách kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(sach As SachDTO) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "INSERT INTO [tblSach]([MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai]) "
        sqlQuery &= "VALUES(@MaSach, @TenSach, @NamXuatBan, @NhaXuatBan, @TriGia, @NgayNhap, @MaTrangThai) "

        ' Lấy MaDocGia kế tiếp
        Dim nextMaSach = 0
        BuildMaSach(nextMaSach)
        sach.MaSach = nextMaSach
        sach.MaTrangThai = 1

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", sach.MaSach)
                    .Parameters.AddWithValue("@TenSach", sach.TenSach)
                    .Parameters.AddWithValue("@NamXuatBan", sach.NamXuatBan)
                    .Parameters.AddWithValue("@NhaXuatBan", sach.NhaXuatBan)
                    .Parameters.AddWithValue("@TriGia", sach.TriGia)
                    .Parameters.AddWithValue("@NgayNhap", sach.NgayNhap)
                    .Parameters.AddWithValue("@MaTrangThai", sach.MaTrangThai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Sách không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectAll(ByRef listSach As List(Of SachDTO)) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai] "
        sqlQuery &= "FROM [tblSach] "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            listSach.Add(New SachDTO(dataReader("MaSach"), dataReader("TenSach"), dataReader("NamXuatBan"), dataReader("NhaXuatBan"), dataReader("TriGia"), dataReader("NgayNhap"), dataReader("MaTrangThai")))
                        End While
                    End If
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByMaSach(iMaSach As Integer) As SachDTO
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai] "
        sqlQuery &= "FROM [tblSach] "
        sqlQuery &= "WHERE [MaSach] = @MaSach "

        Dim sach = New SachDTO
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", iMaSach)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        sach = (New SachDTO(dataReader("MaSach"), dataReader("TenSach"), dataReader("NamXuatBan"), dataReader("NhaXuatBan"), dataReader("TriGia"), dataReader("NgayNhap"), dataReader("MaTrangThai")))
                    End While
                End If
            End Using
        End Using
        Return sach
    End Function

    Public Function SelectByCondition(iMaTheLoai As Integer, iMaTacGia As Integer, iMaTrangThai As Integer, iNamXuatBan As Integer, ByRef listSach As List(Of SachDTO)) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT DISTINCT [tblSach].[MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai] "
        sqlQuery &= "FROM [tblSach], [tblTacGiaSach], [tblTheLoaiSach] "
        sqlQuery &= "WHERE [tblSach].[MaSach] = [tblTacGiaSach].[MaSach] "
        sqlQuery &= "      AND [tblSach].[MaSach] = [tblTheLoaiSach].[MaSach] "
        If (iMaTheLoai <> -1) Then
            sqlQuery &= "AND [MaTheLoai] = @MaTheLoai "
        End If
        If (iMaTacGia <> -1) Then
            sqlQuery &= "AND [MaTacGia] = @MaTacGia "
        End If
        If (iMaTrangThai <> -1) Then
            sqlQuery &= "AND [MaTrangThai] = @MaTrangThai "
        End If
        If (iNamXuatBan <> -1) Then
            sqlQuery &= "AND [NamXuatBan] = @NamXuatBan "
        End If

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", iMaTheLoai)
                    .Parameters.AddWithValue("@MaTacGia", iMaTacGia)
                    .Parameters.AddWithValue("@MaTrangThai", iMaTrangThai)
                    .Parameters.AddWithValue("@NamXuatBan", iNamXuatBan)
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            listSach.Add(New SachDTO(dataReader("MaSach"), dataReader("TenSach"), dataReader("NamXuatBan"), dataReader("NhaXuatBan"), dataReader("TriGia"), dataReader("NgayNhap"), dataReader("MaTrangThai")))
                        End While
                    End If
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Sách theo yêu cầu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(sach As SachDTO) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "UPDATE [tblSach] "
        sqlQuery &= "SET [TenSach] = @TenSach, "
        sqlQuery &= "    [NamXuatBan] = @NamXuatBan, "
        sqlQuery &= "    [NhaXuatBan] = @NhaXuatBan, "
        sqlQuery &= "    [TriGia] = @TriGia, "
        sqlQuery &= "    [NgayNhap] = @NgayNhap, "
        sqlQuery &= "    [MaTrangThai] = @MaTrangThai "
        sqlQuery &= "WHERE [MaSach] = @MaSach"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", sach.MaSach)
                    .Parameters.AddWithValue("@TenSach", sach.TenSach)
                    .Parameters.AddWithValue("@NamXuatBan", sach.NamXuatBan)
                    .Parameters.AddWithValue("@NhaXuatBan", sach.NhaXuatBan)
                    .Parameters.AddWithValue("@TriGia", sach.TriGia)
                    .Parameters.AddWithValue("@NgayNhap", sach.NgayNhap)
                    .Parameters.AddWithValue("@MaTrangThai", sach.MaTrangThai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Sửa thông tin Sách không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(iMaSach As Integer) As Result
        Dim tacGiaSachDAL = New TacGiaSachDAL()
        Dim theLoaiSachDAL = New TheLoaiSachDAL()
        Dim result As Result

        ' Xoá chi tiết tác giả
        result = tacGiaSachDAL.DeleteByMaSach(iMaSach)
        If result.FlagResult = False Then
            Return result
        End If

        ' Xoá chi tiết thể loại
        result = theLoaiSachDAL.DeleteByMaSach(iMaSach)
        If result.FlagResult = False Then
            Return result
        End If

        ' Xoá sách
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "DELETE FROM [tblSach] "
        sqlQuery &= "WHERE [MaSach] = @MaSach "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", iMaSach)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xoá Sách không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function DeleteLichSuMuonTra(iMaSach As Integer) As Result
        Dim result As Result

        ' Xoá lịch sử mượn
        Dim sqlQuery As String

        sqlQuery = String.Empty
        sqlQuery &= "DELETE FROM [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [MaSach] = @MaSach "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", iMaSach)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xoá LS không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using

        sqlQuery = String.Empty
        sqlQuery &= "DELETE FROM [tblChiTietPhieuTra] "
        sqlQuery &= "WHERE [MaSach] = @MaSach "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", iMaSach)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xoá LS không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using

        Return New Result(True)
    End Function

    Public Function DemPhieuMuon(iMaSach As Integer) As Integer
        Dim soPhieuMuon As Integer
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT COUNT (*) As SoLanMuon "
        sqlQuery &= "FROM [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [MaSach] = @MaSach "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", iMaSach)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        soPhieuMuon = dataReader("SoLanMuon")
                    End While
                End If
            End Using
        End Using
        Return soPhieuMuon
    End Function

    Public Function MaDocGiaDangMuon(sach As SachDTO) As String
        Dim maDocGia = String.Empty
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT TOP 1 [MaDocGia] "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [MaSach] = @MaSach "
        sqlQuery &= "ORDER BY [NgayMuon] DESC "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", sach.MaSach)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        maDocGia = dataReader("MaDocGia")
                    End While
                End If
            End Using
        End Using
        Return maDocGia
    End Function

    Public Function MaPhieuMuonCuoi(sach As SachDTO) As Integer
        Dim maPhieuMuon As Integer = 0
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT TOP 1 [tblPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [MaSach] = @MaSach "
        sqlQuery &= "ORDER BY [NgayMuon] DESC "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", sach.MaSach)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        maPhieuMuon = dataReader("MaPhieuMuon")
                    End While
                End If
            End Using
        End Using
        Return maPhieuMuon
    End Function

    Public Function NgayHetHan(sach As SachDTO) As DateTime
        ' Lấy dữ liệu tham số
        Dim thamSoDAL = New ThamSoDAL()
        Dim thamSo As ThamSoDTO = New ThamSoDTO
        thamSoDAL.GetData(thamSo)

        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT TOP 1 [NgayMuon] "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [MaSach] = @MaSach "
        sqlQuery &= "ORDER BY [NgayMuon] DESC "

        Dim ngayHetHanTra = New DateTime()
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", sach.MaSach)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        ngayHetHanTra = dataReader("NgayMuon")
                    End While
                End If
            End Using
        End Using
        Return ngayHetHanTra.AddDays(thamSo.SoNgayMuonToiDa)
    End Function

    Public Function NgayMuonCuoi(sach As SachDTO) As DateTime
        Dim ngayMuon As DateTime = sach.NgayNhap
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT TOP 1 [tblPhieuMuon].[NgayMuon] "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [MaSach] = @MaSach "
        sqlQuery &= "ORDER BY [NgayMuon] DESC "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", sach.MaSach)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                Try
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            ngayMuon = dataReader("[NgayMuon]")
                        End While
                    End If
                Catch
                    ngayMuon = sach.NgayNhap
                End Try
            End Using
        End Using
        Return ngayMuon
    End Function
End Class
