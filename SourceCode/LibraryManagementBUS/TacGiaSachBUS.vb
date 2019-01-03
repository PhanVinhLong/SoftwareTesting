Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class TacGiaSachBUS
    Private tacGiaSachDAL As TacGiaSachDAL

    Public Sub New()
        tacGiaSachDAL = New TacGiaSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        tacGiaSachDAL = New TacGiaSachDAL(connectionString)
    End Sub

    Public Function Insert(tacGiaSach As TacGiaSachDTO) As Result
        Return tacGiaSachDAL.Insert(tacGiaSach)
    End Function

    Public Function InsertList(listTacGiaSach As List(Of TacGiaSachDTO)) As Result
        Return tacGiaSachDAL.InsertList(listTacGiaSach)
    End Function

    Public Function DeleteByMaSach(iMaSach As Integer) As Result
        Return tacGiaSachDAL.DeleteByMaSach(iMaSach)
    End Function
End Class
