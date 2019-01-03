Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class PhieuTraDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function BuildMaPhieuTra(ByRef nextMaPhieuTra As Integer) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "SELECT TOP 1 [MaPhieuTra] "
        sqlQuery &= "FROM [tblPhieuTra] "
        sqlQuery &= "ORDER BY [MaPhieuTra] DESC "

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
                    Dim maPhieuTraOnDB As Integer = 0
                    If dataReader.HasRows = True Then
                        While dataReader.Read()
                            maPhieuTraOnDB = dataReader("MaPhieuTra")
                        End While
                    End If
                    nextMaPhieuTra = maPhieuTraOnDB + 1
                    System.Console.WriteLine(nextMaPhieuTra)
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy Mã phiếu trả kế tiếp không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Insert(phieuTra As PhieuTraDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblPhieuTra] ([MaPhieuTra], [MaDocGia], [NgayTra]) "
        sqlQuery &= "VALUES (@MaPhieuTra, @MaDocGia, @NgayTra) "

        Dim nextMaPhieuTra = 0
        Dim result As Result
        result = BuildMaPhieuTra(nextMaPhieuTra)
        If (result.FlagResult = False) Then
            Return result
        End If
        phieuTra.MaPhieuTra = nextMaPhieuTra

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaPhieuTra", phieuTra.MaPhieuTra)
                    .Parameters.AddWithValue("@MaDocGia", phieuTra.MaDocGia)
                    .Parameters.AddWithValue("@NgayTra", phieuTra.NgayTra)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Phiếu trả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function DeleteByMaDocGia(iMaDocGia As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblPhieuTra] "
        sqlQuery &= "WHERE [MaDocGia] = @MaDocGia "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaDocGia", iMaDocGia)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa Phiếu trả theo độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
