Imports LibraryManagementDAL
Imports LibraryManagementDTO

Public Class HienThiSachBUS
    Private hienThiSachDAL As HienThiSachDAL

    Public Sub New()
        hienThiSachDAL = New HienThiSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        hienThiSachDAL = New HienThiSachDAL(connectionString)
    End Sub

    Public Function ConvertListData(listSach As List(Of SachDTO)) As List(Of HienThiSachDTO)
        Return hienThiSachDAL.ConvertListData(listSach)
    End Function
End Class
