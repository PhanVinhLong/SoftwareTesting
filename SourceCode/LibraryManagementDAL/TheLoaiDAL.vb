Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class TheLoaiDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaTheLoai(ByRef nextMaTheLoai As Integer)
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaTheLoai] "
        sqlQuery &= "FROM [tblTheLoai] "
        sqlQuery &= "ORDER BY [MaTheLoai] DESC "

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
                    Dim maTheLoaiOnDB As String = String.Empty
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maTheLoaiOnDB = dataReader("MaTheLoai")
                        End While
                    End If
                    nextMaTheLoai = maTheLoaiOnDB + 1
                    System.Console.WriteLine(nextMaTheLoai)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã thể loại kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectALL(ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaTheLoai], [TenTheLoai] "
        sqlQuery &= "FROM [tblTheLoai] "

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
                        listTheLoai.Clear()
                        While reader.Read()
                            listTheLoai.Add(New TheLoaiDTO(reader("MaTheLoai"), reader("TenTheLoai")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy tất cả Thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByMaTheLoai(iMaTheLoai As Integer) As TheLoaiDTO
        Dim theLoai = New TheLoaiDTO
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaTheLoai], [TenTheLoai] "
        sqlQuery &= "FROM [tblTheLoai] "
        sqlQuery &= "WHERE [MaTheLoai] = @MaTheLoai "
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", iMaTheLoai)
                End With
                connection.Open()
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                If reader.HasRows = True Then
                    While reader.Read()
                        theLoai = New TheLoaiDTO(reader("MaTheLoai"), reader("TenTheLoai"))
                    End While
                End If
            End Using
        End Using
        Return theLoai
    End Function

    Public Function SelectByMaSach(iMaSach As Integer, ByRef listTheLoai As List(Of TheLoaiDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [tblTheLoai].[MaTheLoai], [TenTheLoai] "
        sqlQuery &= "FROM [tblTheLoai], [tblTheLoaiSach] "
        sqlQuery &= "WHERE [tblTheLoai].[MaTheLoai] = [tblTheLoaiSach].[MaTheLoai] "
        sqlQuery &= "      AND [MaSach] = @MaSach"

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
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        listTheLoai.Clear()
                        While reader.Read()
                            listTheLoai.Add(New TheLoaiDTO(reader("MaTheLoai"), reader("TenTheLoai")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy Thể loại theo Mã sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(theLoai As TheLoaiDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblTheLoai] ([MaTheLoai], [TenTheLoai]) "
        sqlQuery &= "VALUES (@MaTheLoai, @TenTheLoai) "

        Dim nextMaTheLoai = 0
        Dim result As Result
        result = BuildMaTheLoai(nextMaTheLoai)
        If (result.FlagResult = False) Then
            Return result
        End If
        theLoai.MaTheLoai = nextMaTheLoai

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", theLoai.MaTheLoai)
                    .Parameters.AddWithValue("@TenTheLoai", theLoai.TenTheLoai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(theLoai As TheLoaiDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "UPDATE [tblTheLoai] SET "
        sqlQuery &= "[TenTheLoai] = @TenTheLoai "
        sqlQuery &= "WHERE [MaTheLoai] = @MaTheLoai "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", theLoai.MaTheLoai)
                    .Parameters.AddWithValue("@TenTheLoai", theLoai.TenTheLoai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Cập Nhật thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(iMaTheLoai As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblTheLoai] "
        sqlQuery &= "WHERE [MaTheLoai] = @MaTheLoai "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", iMaTheLoai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa Thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Dem() As Integer
        Dim soTheLoai As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) AS SoTheLoai "
        sqlQuery &= "FROM [tblTheLoai] "

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
                        While reader.Read()
                            soTheLoai = reader("SoTheLoai")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return -1
                End Try
            End Using
        End Using
        Return soTheLoai
    End Function

    Public Function DemBanGhi(iMaTheLoai As Integer) As Integer
        Dim soBanGhi As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) AS SoBanGhi "
        sqlQuery &= "FROM [tblTheLoaiSach] "
        sqlQuery &= "WHERE [MaTheLoai] = @MaTheLoai "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", iMaTheLoai)
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            soBanGhi = reader("SoBanGhi")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return -1
                End Try
            End Using
        End Using
        Return soBanGhi
    End Function

    Public Function DemSoLanMuon(iMaTheLoai As Integer, iThang As Integer, iNam As Integer) As Integer
        Dim soLanMuon As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) AS SoLanMuon "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon], [tblTheLoaiSach] "
        sqlQuery &= "WHERE [tblChiTietPhieuMuon].[MaSach] = [tblTheLoaiSach].[MaSach] "
        sqlQuery &= "      AND [tblChiTietPhieuMuon].[MaPhieuMuon] = [tblPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [MaTheLoai] = @MaTheLoai "
        sqlQuery &= "      AND YEAR([NgayMuon]) = @Nam "
        sqlQuery &= "      AND MONTH([NgayMuon]) = @Thang "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", iMaTheLoai)
                    .Parameters.AddWithValue("@Nam", iNam)
                    .Parameters.AddWithValue("@Thang", iThang)
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            soLanMuon = reader("SoLanMuon")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return -1
                End Try
            End Using
        End Using
        Return soLanMuon
    End Function
End Class