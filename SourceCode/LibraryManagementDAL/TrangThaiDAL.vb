Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class TrangThaiDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaTrangThai(ByRef nextMaTrangThai As Integer)
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaTrangThai] "
        sqlQuery &= "FROM [tblTrangThai] "
        sqlQuery &= "ORDER BY [MaTrangThai] DESC "

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
                    Dim maTrangThaiOnDB As String = String.Empty
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maTrangThaiOnDB = dataReader("MaTrangThai")
                        End While
                    End If
                    nextMaTrangThai = maTrangThaiOnDB + 1
                    System.Console.WriteLine(nextMaTrangThai)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã trạng thái kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectALL(ByRef listTrangThai As List(Of TrangThaiDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaTrangThai], [TenTrangThai] "
        sqlQuery &= "FROM [tblTrangThai] "

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
                        listTrangThai.Clear()
                        While reader.Read()
                            listTrangThai.Add(New TrangThaiDTO(reader("MaTrangThai"), reader("TenTrangThai")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy tất cả Trạng thái không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function SelectByMaTrangThai(iMaTrangThai As Integer) As TrangThaiDTO
        Dim trangThai = New TrangThaiDTO
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaTrangThai], [TenTrangThai] "
        sqlQuery &= "FROM [tblTrangThai] "
        sqlQuery &= "WHERE [MaTrangThai] = @MaTrangThai "
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTrangThai", iMaTrangThai)
                End With
                connection.Open()
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                If reader.HasRows = True Then
                    While reader.Read()
                        trangThai = New TrangThaiDTO(reader("MaTrangThai"), reader("TenTrangThai"))
                    End While
                End If
            End Using
        End Using
        Return trangThai
    End Function

    Public Function SelectByMaSach(iMaSach As Integer) As TrangThaiDTO
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [tblTrangThai].[MaTrangThai], [TenTrangThai] "
        sqlQuery &= "FROM [tblTrangThai], [tblSach] "
        sqlQuery &= "WHERE [tblTrangThai].[MaTrangThai] = [tblSach].[MaTrangThai] "
        sqlQuery &= "      AND [MaSach] = @MaSach"

        Dim trangThai As TrangThaiDTO = New TrangThaiDTO()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaSach", iMaSach)
                End With
                connection.Open()
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                If reader.HasRows = True Then
                    While reader.Read()
                        trangThai = New TrangThaiDTO(reader("MaTrangThai"), reader("TenTrangThai"))
                    End While
                End If
            End Using
        End Using
        Return trangThai
    End Function

    Public Function Insert(trangThai As TrangThaiDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblTrangThai] ([MaTrangThai], [TenTrangThai]) "
        sqlQuery &= "VALUES (@MaTrangThai, @TenTrangThai) "

        Dim nextMaTrangThai = 0
        Dim result As Result
        result = BuildMaTrangThai(nextMaTrangThai)
        If (result.FlagResult = False) Then
            Return result
        End If
        trangThai.MaTrangThai = nextMaTrangThai

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTrangThai", trangThai.MaTrangThai)
                    .Parameters.AddWithValue("@TenTrangThai", trangThai.TenTrangThai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Trạng thái không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(trangThai As TrangThaiDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "UPDATE [tblTrangThai] SET "
        sqlQuery &= "[TenTrangThai] = @TenTrangThai "
        sqlQuery &= "WHERE [MaTrangThai] = @MaTrangThai "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTrangThai", trangThai.MaTrangThai)
                    .Parameters.AddWithValue("@TenTrangThai", trangThai.TenTrangThai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Cập nhật Trạng thái không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(iMaTrangThai As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblTrangThai] "
        sqlQuery &= "WHERE [MaTrangThai] = @MaTrangThai "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTrangThai", iMaTrangThai)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa Trạng thái không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Dem() As Integer
        Dim soTrangThai As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) AS SoTrangThai "
        sqlQuery &= "FROM [tblTrangThai] "

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
                            soTrangThai = reader("SoTrangThai")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return -1
                End Try
            End Using
        End Using
        Return soTrangThai
    End Function

    Public Function DemBanGhi(iMaTrangThai As Integer) As Integer
        Dim soBanGhi As Integer
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT COUNT (*) AS SoBanGhi "
        sqlQuery &= "FROM [tblSach] "
        sqlQuery &= "WHERE [MaTrangThai] = @MaTheLoai "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTrangThai", iMaTrangThai)
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
