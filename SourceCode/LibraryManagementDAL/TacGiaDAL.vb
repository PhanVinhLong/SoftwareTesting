Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class TacGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaTacGia(ByRef nextMaTacGia As Integer)
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaTacGia] "
        sqlQuery &= "FROM [tblTacGia] "
        sqlQuery &= "ORDER BY [MaTacGia] DESC "

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
                    Dim maTacGiaOnDB As String = String.Empty
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maTacGiaOnDB = dataReader("MaTacGia")
                        End While
                    End If
                    nextMaTacGia = maTacGiaOnDB + 1
                    System.Console.WriteLine(nextMaTacGia)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã tác giả kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectALL(ByRef listTacGia As List(Of TacGiaDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaTacGia], [TenTacGia] "
        sqlQuery &= "FROM [tblTacGia] "

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
                        listTacGia.Clear()
                        While reader.Read()
                            listTacGia.Add(New TacGiaDTO(reader("MaTacGia"), reader("TenTacGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy tất cả Tác Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByMaTacGia(iMaTacGia As Integer) As TacGiaDTO
        Dim tacGia = New TacGiaDTO
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaTacGia], [TenTacGia] "
        sqlQuery &= "FROM [tblTacGia] "
        sqlQuery &= "WHERE [MaTacGia] = @MaTacGia"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTacGia", iMaTacGia)
                End With
                connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                If reader.HasRows = True Then
                    While reader.Read()
                        tacGia = New TacGiaDTO(reader("MaTacGia"), reader("TenTacGia"))
                    End While
                End If
            End Using
        End Using
        Return tacGia
    End Function

    Public Function SelectByMaSach(iMaSach As Integer, ByRef listTacGia As List(Of TacGiaDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [tblTacGia].[MaTacGia], [TenTacGia] "
        sqlQuery &= "FROM [tblTacGia], [tblTacGiaSach] "
        sqlQuery &= "WHERE [tblTacGia].[MaTacGia] = [tblTacGiaSach].[MaTacGia] "
        sqlQuery &= "      AND [MaSach] = @MaSach "

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
                        listTacGia.Clear()
                        While reader.Read()
                            listTacGia.Add(New TacGiaDTO(reader("MaTacGia"), reader("TenTacGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy Tác giả theo Mã sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(tacGia As TacGiaDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblTacGia] ([MaTacGia], [TenTacGia]) "
        sqlQuery &= "VALUES (@MaTacGia, @TenTacGia) "

        Dim nextMaTacGia = 0
        Dim result As Result
        result = BuildMaTacGia(nextMaTacGia)
        If (result.FlagResult = False) Then
            Return result
        End If
        tacGia.MaTacGia = nextMaTacGia

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTacGia", tacGia.MaTacGia)
                    .Parameters.AddWithValue("@TenTacGia", tacGia.TenTacGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(tacGia As TacGiaDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "UPDATE [tblTacGia] "
        sqlQuery &= "SET [TenTacGia] = @TenTacGia "
        sqlQuery &= "WHERE [MaTacGia] = @MaTacGia "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTacGia", tacGia.MaTacGia)
                    .Parameters.AddWithValue("@TenTacGia", tacGia.TenTacGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Cập nhật Tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(iMaTacGia As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblTacGia] "
        sqlQuery &= "WHERE [MaTacGia] = @MaTacGia "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTacGia", iMaTacGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa Tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Dem() As Integer
        Dim soTacGia As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) AS SoTacGia "
        sqlQuery &= "FROM [tblTacGia] "

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
                            soTacGia = reader("SoTacGia")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return -1
                End Try
            End Using
        End Using
        Return soTacGia
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

End Class
