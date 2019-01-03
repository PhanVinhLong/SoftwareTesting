Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class SachTraTreDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function SelectAll(dtNgayThongKe As DateTime) As List(Of SachTraTreDTO)
        Dim sachDAL = New SachDAL()
        Dim listSach = New List(Of SachDTO)
        Dim listSachTraTre = New List(Of SachTraTreDTO)

        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [TenSach], [NgayMuon], [SoNgayTraTre] "
        sqlQuery &= "FROM [tblSach], [tblPhieuMuon], [tblChiTietPhieuMuon], [tblPhieuTra], [tblChiTietPhieuTra] "
        sqlQuery &= "WHERE [SoNgayTraTre] > 0 "
        sqlQuery &= "      AND [tblSach].[MaSach] = [tblChiTietPhieuMuon].[MaSach] "
        sqlQuery &= "      AND [tblChiTietPhieuTra].[MaSach] = [tblChiTietPhieuMuon].[MaSach] "
        sqlQuery &= "      AND [tblPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuMuon].[MaPhieuMuon] "
        sqlQuery &= "      AND [tblChiTietPhieuMuon].[MaPhieuMuon] = [tblChiTietPhieuTra].[MaPhieuMuon] "
        sqlQuery &= "      AND [tblChiTietPhieuTra].[MaPhieuTra] = [tblPhieuTra].[MaPhieuTra] "
        sqlQuery &= "      AND DAY([NgayTra]) =  DAY(@NgayThongKe) "
        sqlQuery &= "      AND MONTH([NgayTra]) =  MONTH(@NgayThongKe) "
        sqlQuery &= "      AND YEAR([NgayTra]) =  YEAR(@NgayThongKe) "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@NgayThongKe", dtNgayThongKe)
                End With
                connection.Open()
                Dim reader As SqlDataReader
                reader = command.ExecuteReader()
                If reader.HasRows = True Then
                    listSachTraTre.Clear()
                    While reader.Read()
                        listSachTraTre.Add(New SachTraTreDTO(reader("TenSach"), reader("NgayMuon"), reader("SoNgayTraTre")))
                    End While
                End If
            End Using
        End Using
        Return listSachTraTre
    End Function
End Class
