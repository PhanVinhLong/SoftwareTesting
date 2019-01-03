Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class LoaiDocGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaLoaiDocGia(ByRef nextMaLoaiDocGia As Integer)
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaLoaiDocGia] "
        sqlQuery &= "FROM [tblLoaiDocGia] "
        sqlQuery &= "ORDER BY [MaLoaiDocGia] DESC "

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
                    Dim maLoaiDocGiaOnDB As String = 0
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maLoaiDocGiaOnDB = dataReader("MaLoaiDocGia")
                        End While
                    End If
                    nextMaLoaiDocGia = maLoaiDocGiaOnDB + 1
                    System.Console.WriteLine(nextMaLoaiDocGia)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy MaLoaiDocGia kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectALL(ByRef listLoaiDocGia As List(Of LoaiDocGiaDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaLoaiDocGia], [TenLoaiDocGia] "
        sqlQuery &= "FROM [tblLoaiDocGia] "

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
                        listLoaiDocGia.Clear()
                        While reader.Read()
                            listLoaiDocGia.Add(New LoaiDocGiaDTO(reader("MaLoaiDocGia"), reader("TenLoaiDocGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy tất cả LoaiDocGia không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(loaiDocGia As LoaiDocGiaDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblLoaiDocGia] ([MaLoaiDocGia], [TenLoaiDocGia]) "
        sqlQuery &= "VALUES (@MaLoaiDocGia, @TenLoaiDocGia) "

        Dim nextMaLoaiDocGia = 0
        Dim result As Result
        result = BuildMaLoaiDocGia(nextMaLoaiDocGia)
        If (result.FlagResult = False) Then
            Return result
        End If
        loaiDocGia.MaLoaiDocGia = nextMaLoaiDocGia

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaLoaiDocGia", loaiDocGia.MaLoaiDocGia)
                    .Parameters.AddWithValue("@TenLoaiDocGia", loaiDocGia.TenLoaiDocGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Loại độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(loaiDocGia As LoaiDocGiaDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "UPDATE [tblLoaiDocGia] SET"
        sqlQuery &= "[TenLoaiDocGia] = @TenLoaiDocGia "
        sqlQuery &= "WHERE [MaLoaiDocGia] = @MaLoaiDocGia "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaLoaiDocGia", loaiDocGia.MaLoaiDocGia)
                    .Parameters.AddWithValue("@TenLoaiDocGia", loaiDocGia.TenLoaiDocGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Cập Loại độc giả sinh không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(iMaLoaiDocGia As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblLoaiDocGia] "
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
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa Loại độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Dem() As Integer
        Dim soLoaiDocGia As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) AS SoLoaiDocGia "
        sqlQuery &= "FROM [tblLoaiDocGia] "

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
                            soLoaiDocGia = reader("SoLoaiDocGia")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return -1
                End Try
            End Using
        End Using
        Return soLoaiDocGia
    End Function

    Public Function DemBanGhi(iMaLoaiDocGia As Integer) As Integer
        Dim soBanGhi As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) AS SoBanGhi "
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
