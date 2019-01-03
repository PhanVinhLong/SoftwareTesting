Imports System.Text.RegularExpressions
Imports LibraryManagementDAL
Imports LibraryManagementDTO
Imports Utility

Public Class DocGiaBUS
    Private docGiaDAL As DocGiaDAL

    Public Sub New()
        docGiaDAL = New DocGiaDAL()
    End Sub

    Public Sub New(connectionString As String)
        docGiaDAL = New DocGiaDAL(connectionString)
    End Sub

    Public Function IsValidHoTen(docGia As DocGiaDTO) As Boolean
        If (docGia.HoTen = Nothing) Then
            Return False
        ElseIf (docGia.HoTen.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    Public Function IsValidNgaySinh(docGia As DocGiaDTO) As Boolean
        ' Lấy dữ liệu tham số
        Dim ThamSoBUS As ThamSoBUS = New ThamSoBUS()
        Dim thamSo As ThamSoDTO = New ThamSoDTO()
        ThamSoBUS.GetData(thamSo)
        Dim ages As Integer
        ages = CaculateAges(docGia.NgaySinh)
        If (ages < thamSo.TuoiToiThieu Or ages > thamSo.TuoiToiDa) Then
            Return False
        End If
        Return True
    End Function

    Public Function IsValidEmail(ByRef docGia As DocGiaDTO) As Boolean
        If (String.IsNullOrWhiteSpace(docGia.Email)) Then
            docGia.Email = Nothing
            Return True
        End If
        Dim match As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim reg As Regex = New Regex(match)
        If (reg.IsMatch(docGia.Email)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function IsValidNgayLapThe(docGia As DocGiaDTO)
        If (docGia.NgayLapThe > Now) Then
            Return False
        End If
        Return True
    End Function

    Public Function BuildMaDocGia(ByRef nextMaDocGia As String) As Result
        Return docGiaDAL.BuildMaDocGia(nextMaDocGia)
    End Function

    Public Function Insert(docGia As DocGiaDTO) As Result
        ' Kiểm tra dữ liệu

        ' Thêm vào database
        Return docGiaDAL.Insert(docGia)
    End Function

    Public Function Update(docGia As DocGiaDTO)
        Return docGiaDAL.Update(docGia)
    End Function

    Public Function SelectAll(ByRef listDocGia As List(Of DocGiaDTO))
        Return docGiaDAL.SelectAll(listDocGia)
    End Function

    Public Function SellectByLoaiDocGia(iMaLoaiDocGia As Integer, ByRef listDocGia As List(Of DocGiaDTO))
        Return docGiaDAL.SelectByLoaiDocGia(iMaLoaiDocGia, listDocGia)
    End Function

    Public Function SelectByDocGia(iMaDocGia As Integer) As DocGiaDTO
        Return docGiaDAL.SelectByDocGia(iMaDocGia)
    End Function

    Public Function Delete(iMaDocGia As Integer)
        Return docGiaDAL.Delete(iMaDocGia)
    End Function

    Public Function CaculateAges(ByVal dtBirthDay As DateTime) As Integer
        Dim iYears As Integer
        iYears = Year(Now) - Year(dtBirthDay)
        If DateSerial(Year(Now), Month(dtBirthDay), Day(dtBirthDay)) > Now Then
            ' Subtract a year if birthday hasn't arrived this year
            iYears = iYears - 1
        End If
        Return iYears
    End Function

    Public Function SachMuonHetHan(docGia As DocGiaDTO) As List(Of SachDTO)
        Return docGiaDAL.SachMuonHetHan(docGia)
    End Function

    Public Function SachMuonConHan(docGia As DocGiaDTO) As List(Of SachDTO)
        Return docGiaDAL.SachMuonConHan(docGia)
    End Function

    Public Function SachMuon(docGia As DocGiaDTO) As List(Of SachDTO)
        Return docGiaDAL.SachMuon(docGia)
    End Function
End Class
