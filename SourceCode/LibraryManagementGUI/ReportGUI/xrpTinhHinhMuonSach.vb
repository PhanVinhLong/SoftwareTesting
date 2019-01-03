Imports DevExpress.XtraCharts
Imports LibraryManagementDTO

Public Class xrpTinhHinhMuonSach
    Public Sub Init(ngayLap As DateTime, ngayThongKe As DateTime, list As List(Of TinhHinhMuonSachDTO))
        ObjectDataSource1.DataSource = list

        Dim tongSoLuotMuon As Integer = 0
        For Each tinhHinh In list
            tongSoLuotMuon += tinhHinh.SoLuotMuon
        Next

        dateNgayLap.Text = ngayLap.Day & "/" & ngayLap.Month & "/" & ngayLap.Year
        dateNgayThongKe.Text = ngayThongKe.Month & "/" & ngayThongKe.Year
        txtTotal.Text = tongSoLuotMuon

        Dim series1 As New Series("TỈ LỆ MƯỢN SÁCH", ViewType.Pie)
        For Each data As TinhHinhMuonSachDTO In list
            series1.Points.Add(New SeriesPoint(data.TenTheLoai, data.TiLe))
        Next
        XrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        XrChart1.Series.Add(series1)
        series1.Label.TextPattern = "{A}: {VP:p0}"
    End Sub
End Class