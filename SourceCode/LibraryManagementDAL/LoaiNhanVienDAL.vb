Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class LoaiNhanVienDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function SelectALL(ByRef listLoaiNhanVien As List(Of LoaiNhanVienDTO)) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [MaLoaiNhanVien], [TenLoaiNhanVien] "
        sqlQuery &= "FROM [tblLoaiNhanVien] "

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
                        listLoaiNhanVien.Clear()
                        While reader.Read()
                            listLoaiNhanVien.Add(New LoaiNhanVienDTO(reader("MaLoaiNhanVien"), reader("TenLoaiNhanVien")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Lấy tất cả nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function Delete(iMaNhanVien As Integer) As Result
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "DELETE FROM [tblNhanVien] "
        sqlQuery &= "WHERE [MaNhanVien] = @MaNhanVien "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaNhanVien", iMaNhanVien)
                End With
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                    Return New Result(False, "Xóa nhân viên không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)
    End Function

    Public Function GetName(iMaLoaiNhanVien As Integer) As String
        Dim strTenLoaiNhanVien As String = String.Empty
        Dim sqlQuery As String = String.Empty
        sqlQuery &= "SELECT [TenLoaiNhanVien] "
        sqlQuery &= "FROM [tblLoaiNhanVien] "
        sqlQuery &= "WHERE [MaLoaiNhanVien] = @MaLoaiNhanVien "

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand()
                With command
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = sqlQuery
                    .Parameters.AddWithValue("@MaLoaiNhanVien", iMaLoaiNhanVien)
                End With
                Try
                    connection.Open()
                    Dim reader As SqlDataReader
                    reader = command.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            strTenLoaiNhanVien = reader("TenLoaiNhanVien")
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    connection.Close()
                End Try
            End Using
        End Using
        Return strTenLoaiNhanVien
    End Function
End Class
