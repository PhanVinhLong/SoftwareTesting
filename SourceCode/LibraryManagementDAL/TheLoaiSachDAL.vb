Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class TheLoaiSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function Insert(theLoaiSach As TheLoaiSachDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblTheLoaiSach]([MaTheLoai], [MaSach]) "
        sqlQuery &= "VALUES(@MaTheLoai, @MaSach) "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTheLoai", theLoaiSach.MaTheLoai)
                    .Parameters.AddWithValue("@MaSach", theLoaiSach.MaSach)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Chi tiết thể loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function InsertList(listTheLoaiSach As List(Of TheLoaiSachDTO)) As Result
        Dim result As Result
        For Each theLoaiSach In listTheLoaiSach
            result = Insert(theLoaiSach)
        Next
        Return New Result(True)
    End Function

    Public Function DeleteByMaSach(iMaSach As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblTheLoaiSach] "
        sqlQuery &= "WHERE [MaSach] = @MaSach"

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
                    Return New Result(False, "Xoá chi tiết thể loại theo mã sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
