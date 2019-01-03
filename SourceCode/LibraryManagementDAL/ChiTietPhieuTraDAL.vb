Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class ChiTietPhieuTraDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function Insert(chiTietPhieuTra As ChiTietPhieuTraDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblChiTietPhieuTra]([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) "
        sqlQuery &= "VALUES(@MaPhieuTra, @MaSach, @MaPhieuMuon, @SoNgayTraTre) "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaPhieuTra", chiTietPhieuTra.MaPhieuTra)
                    .Parameters.AddWithValue("@MaSach", chiTietPhieuTra.MaSach)
                    .Parameters.AddWithValue("@SoNgayTraTre", chiTietPhieuTra.SoNgayTraTre)
                    .Parameters.AddWithValue("@MaPhieuMuon", chiTietPhieuTra.MaPhieuMuon)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Chi tiết phiếu trả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function InsertList(listChiTietPhieuTra As List(Of ChiTietPhieuTraDTO)) As Result
        Dim result As Result
        For Each chiTietPhieuTra In listChiTietPhieuTra
            result = Insert(chiTietPhieuTra)
            If result.FlagResult = False Then
                Return result
            End If
        Next
        Return New Result(True)
    End Function

    Public Function DeleteByMaSach(iMaSach As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblChiTietPhieuTra] "
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
                    Return New Result(False, "Xoá chi tiết phiếu trả theo mã sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function DeleteByMaPhieuTra(iMaPhieuTra As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblChiTietPhieuTra] "
        sqlQuery &= "WHERE [MaPhieuTra] = @MaPhieuTra"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaPhieuTra", iMaPhieuTra)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Xoá chi tiết phiếu trả theo mã phiếu trả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
