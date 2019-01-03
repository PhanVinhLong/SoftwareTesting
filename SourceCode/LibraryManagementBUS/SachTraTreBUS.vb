Imports System.Text.RegularExpressions
Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class SachTraTreBUS
    Private sachTraTreDAL As SachTraTreDAL

    Public Sub New()
        sachTraTreDAL = New SachTraTreDAL()
    End Sub

    Public Sub New(connectionString As String)
        sachTraTreDAL = New SachTraTreDAL(connectionString)
    End Sub

    Public Function SelectAll(dtNgayTongKe As DateTime) As List(Of SachTraTreDTO)
        Return sachTraTreDAL.SelectAll(dtNgayTongKe)
    End Function
End Class
