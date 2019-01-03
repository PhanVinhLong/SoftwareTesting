Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class TacGiaSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function Insert(tacGiaSach As TacGiaSachDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblTacGiaSach] ([MaTacGia], [MaSach]) "
        sqlQuery &= "VALUES (@MaTacGia, @MaSach) "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaTacGia", tacGiaSach.MaTacGia)
                    .Parameters.AddWithValue("@MaSach", tacGiaSach.MaSach)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Chi tiết tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function InsertList(listTacGiaSach As List(Of TacGiaSachDTO)) As Result
        Dim result As Result
        For Each tacGiaSach In listTacGiaSach
            result = Insert(tacGiaSach)
            If result.FlagResult = False Then
                Return result
            End If
        Next
        Return New Result(True)
    End Function

    Public Function DeleteByMaSach(iMaSach As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblTacGiaSach] "
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
                    Return New Result(False, "Xoá chi tiết tác giả theo mã sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
