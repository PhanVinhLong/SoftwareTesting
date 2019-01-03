Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class ThamSoDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function GetData(ByRef thamSo As ThamSoDTO) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [TuoiToiThieu],[TuoiToiDa],[ThoiHanSuDung],[GioiHanNamXuatBan],[SoLuongTacGia],[SoLuongSachMuonToiDa],[NgayMuonToiDa],[SoLuongTheLoai],[SoLuongLoaiDocGia] "
        sqlQuery &= "FROM [tblThamSo] "

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
                            thamSo = New ThamSoDTO(reader("TuoiToiThieu"), reader("TuoiToiDa"), reader("ThoiHanSuDung"), reader("GioiHanNamXuatBan"), reader("SoLuongTacGia"), reader("SoLuongSachMuonToiDa"), reader("NgayMuonToiDa"), reader("SoLuongTheLoai"), reader("SoLuongLoaiDocGia"))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy dữ liệu ThamSo không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Update(iTuoiToiThieu As Integer, iTuoiToiDa As Integer, iThoiHanSuDung As Integer, iGioiHanNamXuatBan As Integer, iSoLuongTacGia As Integer, iSoLuongSachMuonToiDa As Integer, iSoNgayMuonToiDa As Integer, iSoLuongTheLoai As Integer, iSoLuongLoaiDocGia As Integer) As Result
        Dim sqlQuery As String
        sqlQuery = String.Empty

        sqlQuery &= "UPDATE [tblThamSo] "
        sqlQuery &= "SET [TuoiToiThieu] = @TuoiToiThieu, "
        sqlQuery &= "    [TuoiToiDa] = @TuoiToiDa, "
        sqlQuery &= "    [ThoiHanSuDung] = @ThoiHanSuDung, "
        sqlQuery &= "    [GioiHanNamXuatBan] = @GioiHanNamXuatBan, "
        sqlQuery &= "    [SoLuongTacGia] = @SoLuongTacGia, "
        sqlQuery &= "    [SoLuongSachMuonToiDa] = @SoLuongSachMuonToiDa, "
        sqlQuery &= "    [NgayMuonToiDa] = @NgayMuonToiDa, "
        sqlQuery &= "    [SoLuongTheLoai] = @SoLuongTheLoai, "
        sqlQuery &= "    [SoLuongLoaiDocGia] = @SoLuongLoaiDocGia "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@TuoiToiThieu", iTuoiToiThieu)
                    .Parameters.AddWithValue("@TuoiToiDa", iTuoiToiDa)
                    .Parameters.AddWithValue("@ThoiHanSuDung", iThoiHanSuDung)
                    .Parameters.AddWithValue("@GioiHanNamXuatBan", iGioiHanNamXuatBan)
                    .Parameters.AddWithValue("@SoLuongTacGia", iSoLuongTacGia)
                    .Parameters.AddWithValue("@SoLuongSachMuonToiDa", iSoLuongSachMuonToiDa)
                    .Parameters.AddWithValue("@NgayMuonToiDa", iSoNgayMuonToiDa)
                    .Parameters.AddWithValue("@SoLuongTheLoai", iSoLuongTheLoai)
                    .Parameters.AddWithValue("@SoLuongLoaiDocGia", iSoLuongLoaiDocGia)

                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    connection.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Sửa thông tin Sách không thành công!", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function
End Class
