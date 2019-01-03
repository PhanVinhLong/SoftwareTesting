Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class ChiTietPhieuMuonDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function Insert(chiTietPhieuMuon As ChiTietPhieuMuonDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "INSERT INTO [tblChiTietPhieuMuon]([MaPhieuMuon], [MaSach]) "
        sqlQuery &= "VALUES(@MaPhieuMuon, @MaSach) "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaPhieuMuon", chiTietPhieuMuon.MaPhieuMuon)
                    .Parameters.AddWithValue("@MaSach", chiTietPhieuMuon.MaSach)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Thêm Chi tiết phiếu mượn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function InsertList(listChiTietPhieuMuon As List(Of ChiTietPhieuMuonDTO)) As Result
        Dim result As Result
        For Each chiTietPhieuMuon In listChiTietPhieuMuon
            result = Insert(chiTietPhieuMuon)
        Next
        Return New Result(True)
    End Function

    Public Function DeleteByMaSach(iMaSach As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblChiTietPhieuMuon] "
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
                    Return New Result(False, "Xoá chi tiết phiếu mượn theo mã sách không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function DeleteByMaPhieuMuon(iMaPhieuMuon As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [MaPhieuMuon] = @MaPhieuMuon"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaPhieuMuon", iMaPhieuMuon)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    Return New Result(False, "Xoá chi tiết phiếu mượn theo mã phiếu mượn không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function NgayHetHan(chiTietPhieuMuon As ChiTietPhieuMuonDTO) As DateTime
        ' Lấy dữ liệu tham số
        Dim thamSo = New ThamSoDTO
        Dim thamSoDAL = New ThamSoDAL
        thamSoDAL.GetData(thamSo)

        Dim dtNgayHetHan As DateTime

        Dim sqlQuery As String
        sqlQuery = String.Empty
        sqlQuery &= "SELECT [NgayMuon] "
        sqlQuery &= "FROM [tblPhieuMuon], [tblChiTietPhieuMuon] "
        sqlQuery &= "WHERE [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                End With
                connection.Open()
                Dim dataReader As SqlDataReader
                dataReader = command.ExecuteReader()
                If dataReader.HasRows = True Then
                    While dataReader.Read()
                        dtNgayHetHan = dataReader("NgayMuon")
                    End While
                    dtNgayHetHan.AddDays(thamSo.SoNgayMuonToiDa)
                End If
            End Using
        End Using
        Return dtNgayHetHan
    End Function
End Class
