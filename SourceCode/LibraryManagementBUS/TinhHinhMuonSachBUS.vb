Imports System.Text.RegularExpressions
Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class TinhHinhMuonSachBUS
    Private tinhHinhMuonSachDAL As TinhHinhMuonSachDAL

    Public Sub New()
        tinhHinhMuonSachDAL = New TinhHinhMuonSachDAL()
    End Sub

    Public Sub New(connectionString As String)
        tinhHinhMuonSachDAL = New TinhHinhMuonSachDAL(connectionString)
    End Sub

    Public Function SelectAll(iThang As Integer, iNam As Integer) As List(Of TinhHinhMuonSachDTO)
        Return tinhHinhMuonSachDAL.SelectAll(iThang, iNam)
    End Function
End Class
