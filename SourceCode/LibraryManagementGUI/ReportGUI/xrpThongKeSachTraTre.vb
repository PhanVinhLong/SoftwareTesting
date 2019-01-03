Imports DevExpress.XtraCharts
Imports LibraryManagementDTO

Public Class xrpThongKeSachTraTre
    Public Sub Init(ngayLap As DateTime, ngayThongKe As DateTime, list As List(Of SachTraTreDTO))
        ObjectDataSource1.DataSource = list

        dateNgayLap.Text = ngayLap.Day & "/" & ngayLap.Month & "/" & ngayLap.Year
        dateNgayThongKe.Text = ngayThongKe.Day & "/" & ngayThongKe.Month & "/" & ngayThongKe.Year

        Dim series1 As New Series("TỈ LỆ NGÀY TRẢ TRỄ", ViewType.Pie)
        For Each data As SachTraTreDTO In list
            series1.Points.Add(New SeriesPoint(data.TenSach, data.SoNgayTraTre))
        Next
        XrChart1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
        XrChart1.Series.Add(series1)
        series1.Label.TextPattern = "{A}: {VP:p0}"
    End Sub
End Class