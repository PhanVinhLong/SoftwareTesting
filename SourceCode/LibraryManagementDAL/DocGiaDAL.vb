Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class DocGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaDocGia(ByRef nextMaDocGia As String) As Result
        nextMaDocGia = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextMaDocGia = x + "000000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaDocGia]"
        query &= " FROM [tblDocGia]"
        query &= " ORDER BY [MaDocGia] DESC"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    Dim maDocGiaOnDB As String
                    maDocGiaOnDB = Nothing
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maDocGiaOnDB = dataReader("MaDocGia")
                        End While

                        If (maDocGiaOnDB <> Nothing And maDocGiaOnDB.Length >= 8) Then
                            Dim currentYear = Integer.Parse(DateTime.Now.Year.ToString().Substring(2))
                            Dim currentYearOnDB = Integer.Parse(maDocGiaOnDB.Substring(0, 2))
                            Dim year = currentYear
                            If year < currentYearOnDB Then
                                year = currentYearOnDB
                            End If
                            nextMaDocGia = year.ToString()
                            Dim maDocGiaOnDBWithoutYear = maDocGiaOnDB.Substring(2)
                            Dim covertDecimal = Convert.ToDecimal(maDocGiaOnDBWithoutYear)
                            covertDecimal = covertDecimal + 1
                            Dim maDocGiaWithoutYear = covertDecimal.ToString()
                            maDocGiaWithoutYear = maDocGiaWithoutYear.PadLeft(6, "0")
                            nextMaDocGia = nextMaDocGia + maDocGiaWithoutYear
                            System.Console.WriteLine(nextMaDocGia)
                        End If
                    End If

                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Tự động sinh Mã độc giả kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(docGia As DocGiaDTO) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "INSERT INTO [tblDocGia]([MaDocGia] ,[HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) "
        sqlQuery &= "VALUES(@MaDocGia, @HoTen, @NgaySinh, @DiaChi, @Email, @NgayLapThe, @NgayHetHan, @MaLoaiDocGia) "

        ' Lấy MaDocGia kế tiếp
        Dim nextMaDocGia = "00000001"
        BuildMaDocGia(nextMaDocGia)
        docGia.MaDocGia = nextMaDocGia

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", docGia.MaDocGia)
                    .Parameters.AddWithValue("@HoTen", docGia.HoTen)
                    .Parameters.AddWithValue("@NgaySinh", docGia.NgaySinh)
                    .Parameters.AddWithValue("@DiaChi", If(String.IsNullOrWhiteSpace(docGia.DiaChi), "trống", docGia.DiaChi))
                    .Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(docGia.Email), "trống", docGia.Email))
                    .Parameters.AddWithValue("@NgayLapThe", docGia.NgayLapThe)
                    .Parameters.AddWithValue("@NgayHetHan", docGia.NgayHetHan)
                    .Parameters.AddWithValue("@MaLoaiDocGia", docGia.MaLoaiDocGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm DocGia không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectAll(ByRef listDocGia As List(Of DocGiaDTO)) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaDocGia] ,[HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia] "
        sqlQuery &= "FROM [tblDocGia]"

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
                            listDocGia.Add(New DocGiaDTO(dataReader("MaDocGia"), dataReader("HoTen"), dataReader("NgaySinh"), dataReader("DiaChi"), dataReader("Email"), dataReader("NgayLapThe"), dataReader("NgayHetHan"), dataReader("MaLoaiDocGia")))
                        End While
                    End If
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByLoaiDocGia(iMaLoaiDocGia As Integer, ByRef listDocGia As List(Of DocGiaDTO)) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaDocGia] ,[HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia] "
        sqlQuery &= "FROM [tblDocGia] "
        sqlQuery &= "WHERE [MaLoaiDocGia] = @MaLoaiDocGia "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaLoaiDocGia", iMaLoaiDocGia)
                End With
                Try
                    connection.Open()
                    Dim dataReader As SqlDataReader
                    dataReader = command.ExecuteReader()
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            listDocGia.Add(New DocGiaDTO(dataReader("MaDocGia"), dataReader("HoTen"), dataReader("NgaySinh"), dataReader("DiaChi"), dataReader("Email"), dataReader("NgayLapThe"), dataReader("NgayHetHan"), dataReader("MaLoaiDocGia")))
                        End While
                    End If
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Độc giả theo Loại độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByDocGia(iMaDocGia As Integer) As DocGiaDTO
        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaDocGia] ,[HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia] "
        sqlQuery &= "FROM [tblDocGia] "
        sqlQuery &= "WHERE [MaDocGia] = @MaDocGia "

        Dim docGia As DocGiaDTO = New DocGiaDTO
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", iMaDocGia)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        docGia = New DocGiaDTO(dataReader("MaDocGia"), dataReader("HoTen"), dataReader("NgaySinh"), dataReader("DiaChi"), dataReader("Email"), dataReader("NgayLapThe"), dataReader("NgayHetHan"), dataReader("MaLoaiDocGia"))
                    End While
                End If
            End Using
        End Using
        Return docGia
    End Function

    Public Function Update(docGia As DocGiaDTO) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "UPDATE [tblDocGia] SET "
        sqlQuery &= "[HoTen] = @HoTen, "
        sqlQuery &= "[NgaySinh] = @NgaySinh, "
        sqlQuery &= "[DiaChi] = @DiaChi, "
        sqlQuery &= "[Email] = @Email, "
        sqlQuery &= "[NgayLapThe] = @NgayLapThe, "
        sqlQuery &= "[NgayHetHan] = @NgayHetHan, "
        sqlQuery &= "[MaLoaiDocGia] = @MaLoaiDocGia "
        sqlQuery &= "WHERE [MaDocGia] = @MaDocGia"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", docGia.MaDocGia)
                    .Parameters.AddWithValue("@HoTen", docGia.HoTen)
                    .Parameters.AddWithValue("@NgaySinh", docGia.NgaySinh)
                    .Parameters.AddWithValue("@DiaChi", docGia.DiaChi)
                    .Parameters.AddWithValue("@Email", docGia.Email)
                    .Parameters.AddWithValue("@NgayLapThe", docGia.NgayLapThe)
                    .Parameters.AddWithValue("@NgayHetHan", docGia.NgayHetHan)
                    .Parameters.AddWithValue("@MaLoaiDocGia", docGia.MaLoaiDocGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Sửa thông tin Độc giả không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(strMaDocGia As String)
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "DELETE FROM [tblDocGia] "
        sqlQuery &= "WHERE [MaDocGia] = @MaDocGia"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", strMaDocGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xoá Độc giả không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SachMuonHetHan(docGia As DocGiaDTO) As List(Of SachDTO)
        ' Lấy dữ liệu tham số
        Dim thamSo = New ThamSoDTO
        Dim thamSoDAL = New ThamSoDAL
        thamSoDAL.GetData(thamSo)

        Dim sachDAL = New SachDAL()
        Dim chiTietPhieuMuonDAL = New ChiTietPhieuMuonDAL()
        Dim listSach = New List(Of SachDTO)

        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaSach] "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [MaDocGia] = @MaDocGia "
        sqlQuery &= "      AND [NgayMuon] < @NgayMuonHetHan "
        sqlQuery &= "      AND [tblPhieuMuon].[MaPhieuMuon] NOT IN "
        sqlQuery &= "           (SELECT DISTINCT [MaPhieuMuon] "
        sqlQuery &= "           FROM [tblPhieuTra], [tblChiTietPhieuTra] "
        sqlQuery &= "           WHERE [tblPhieuTra].[MaPhieuTra] = [tblChiTietPhieuTra].[MaPhieuTra] "
        sqlQuery &= "                 AND [tblChiTietPhieuTra].[MaSach] = [tblChiTietPhieuMuon].[MaSach] "
        sqlQuery &= "                 AND [tblChiTietPhieuTra].[MaPhieuMuon] = [tblPhieuMuon].[MaPhieuMuon]) "

        Dim ngayMuonHetHan As DateTime = Now
        ngayMuonHetHan = ngayMuonHetHan.AddDays(-thamSo.SoNgayMuonToiDa)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", docGia.MaDocGia)
                    .Parameters.AddWithValue("@NgayMuonHetHan", ngayMuonHetHan)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        listSach.Add(sachDAL.SelectByMaSach(dataReader("MaSach")))
                    End While
                End If
            End Using
        End Using
        Return listSach
    End Function

    Public Function SachMuonConHan(docGia As DocGiaDTO) As List(Of SachDTO)
        ' Lấy dữ liệu tham số
        Dim thamSo = New ThamSoDTO
        Dim thamSoDAL = New ThamSoDAL
        thamSoDAL.GetData(thamSo)

        Dim sachDAL = New SachDAL()
        Dim chiTietPhieuMuonDAL = New ChiTietPhieuMuonDAL()
        Dim listSach = New List(Of SachDTO)

        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaSach] "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [MaDocGia] = @MaDocGia "
        sqlQuery &= "      AND [NgayMuon] >= @NgayMuonHetHan "
        sqlQuery &= "      AND [tblPhieuMuon].[MaPhieuMuon] NOT IN "
        sqlQuery &= "           (SELECT DISTINCT [MaPhieuMuon] "
        sqlQuery &= "           FROM [tblPhieuTra], [tblChiTietPhieuTra] "
        sqlQuery &= "           WHERE [tblPhieuTra].[MaPhieuTra] = [tblChiTietPhieuTra].[MaPhieuTra] "
        sqlQuery &= "                 AND [tblChiTietPhieuTra].[MaSach] = [tblChiTietPhieuMuon].[MaSach] "
        sqlQuery &= "                 AND [tblChiTietPhieuTra].[MaPhieuMuon] = [tblPhieuMuon].[MaPhieuMuon]) "

        Dim ngayMuonHetHan As DateTime = Now
        ngayMuonHetHan = ngayMuonHetHan.AddDays(-thamSo.SoNgayMuonToiDa)
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", docGia.MaDocGia)
                    .Parameters.AddWithValue("@NgayMuonHetHan", ngayMuonHetHan)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        listSach.Add(sachDAL.SelectByMaSach(dataReader("MaSach")))
                    End While
                End If
            End Using
        End Using
        Return listSach
    End Function

    Public Function SachMuon(docGia As DocGiaDTO) As List(Of SachDTO)
        ' Lấy dữ liệu tham số
        Dim thamSo = New ThamSoDTO
        Dim thamSoDAL = New ThamSoDAL
        thamSoDAL.GetData(thamSo)

        Dim sachDAL = New SachDAL()
        Dim chiTietPhieuMuonDAL = New ChiTietPhieuMuonDAL()
        Dim listSach = New List(Of SachDTO)

        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [MaSach] "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [MaDocGia] = @MaDocGia "
        sqlQuery &= "      AND [tblPhieuMuon].[MaPhieuMuon] NOT IN "
        sqlQuery &= "           (SELECT DISTINCT [MaPhieuMuon] "
        sqlQuery &= "           FROM [tblPhieuTra], [tblChiTietPhieuTra] "
        sqlQuery &= "           WHERE [tblPhieuTra].[MaPhieuTra] = [tblChiTietPhieuTra].[MaPhieuTra] "
        sqlQuery &= "                 AND [tblChiTietPhieuTra].[MaSach] = [tblChiTietPhieuMuon].[MaSach] "
        sqlQuery &= "                 AND [tblChiTietPhieuTra].[MaPhieuMuon] = [tblPhieuMuon].[MaPhieuMuon]) "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", docGia.MaDocGia)
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        listSach.Add(sachDAL.SelectByMaSach(dataReader("MaSach")))
                    End While
                End If
            End Using
        End Using
        Return listSach
    End Function
End Class
