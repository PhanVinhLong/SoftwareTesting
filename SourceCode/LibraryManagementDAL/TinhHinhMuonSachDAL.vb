Imports System.Configuration
Imports System.Data.SqlClient
Imports LibraryManagementDTO
Imports Utility

Public Class TinhHinhMuonSachDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub

    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function SelectAll(iThang As Integer, iNam As Integer) As List(Of TinhHinhMuonSachDTO)
        Dim theLoaiDAL = New TheLoaiDAL()
        Dim listTheLoai = New List(Of TheLoaiDTO)
        Dim listTinhHinh = New List(Of TinhHinhMuonSachDTO)
        theLoaiDAL.SelectALL(listTheLoai)
        Dim tongSoLanMuon As Integer = 0

        For Each theLoai In listTheLoai
            tongSoLanMuon += theLoaiDAL.DemSoLanMuon(theLoai.MaTheLoai, iThang, iNam)
        Next
        For Each theLoai In listTheLoai
            Dim soLanMuon As Integer = theLoaiDAL.DemSoLanMuon(theLoai.MaTheLoai, iThang, iNam)
            Dim tiLe As Integer = If(tongSoLanMuon < 1, 0, (soLanMuon * 100) / tongSoLanMuon)
            listTinhHinh.Add(New TinhHinhMuonSachDTO(theLoai.TenTheLoai, soLanMuon, tiLe))
        Next
        Return listTinhHinh
    End Function
End Class
