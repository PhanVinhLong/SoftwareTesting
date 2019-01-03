Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Design
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility

Public Class ucThongKeTinhHinhMuonSach
    Private tinhHinhMuonSachBUS As TinhHinhMuonSachBUS

    Private Sub ucThongKeTinhHinhMuonSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tinhHinhMuonSachBUS = New TinhHinhMuonSachBUS()

        'Cài đặt cho thời gian thống kê
        dteThangNam.EditValue = Now
        dteThangNam.Properties.EditMask = "M/yyyy"
        dteThangNam.Properties.EditFormat.FormatString = "M/yyyy"
        dteThangNam.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteThangNam.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.YearView
        dteThangNam.Properties.DisplayFormat.FormatString = "M/yyyy"

        ' Cài đặt chart

    End Sub

    Private Sub CaiDatGridControl(listTinhHinhMuonSach As List(Of TinhHinhMuonSachDTO))
        grcDanhSachThongKe.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachThongKe.BestFitColumns()
        grvDanhSachThongKe.Columns.Clear()
        grcDanhSachThongKe.DataSource = listTinhHinhMuonSach
        grvDanhSachThongKe.OptionsBehavior.Editable = False
        grvDanhSachThongKe.OptionsFind.AlwaysVisible = False
        grvDanhSachThongKe.OptionsView.ShowGroupPanel = False
        grvDanhSachThongKe.OptionsFind.FindDelay = 0

        grvDanhSachThongKe.Columns("TenTheLoai").Caption = "Tên thể loại"
        grvDanhSachThongKe.Columns("SoLuotMuon").Caption = "Số lần mượn"
        grvDanhSachThongKe.Columns("TiLe").Caption = "Tỉ lệ"

        grcDanhSachThongKe.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachThongKe.ApplyFindFilter(filterString)
    End Sub

    Private Sub dteThangNam_EditValueChanged(sender As Object, e As EventArgs) Handles dteThangNam.EditValueChanged
        Dim tongSo As Integer = 0
        If dteThangNam.EditValue <> Nothing Then
            Dim listTinhHinh = New List(Of TinhHinhMuonSachDTO)
            listTinhHinh = tinhHinhMuonSachBUS.SelectAll(dteThangNam.EditValue.Month, dteThangNam.EditValue.Year)
            CaiDatGridControl(listTinhHinh)

            ChartControl1.Series.Clear()
            Dim series1 As New Series("TỈ LỆ MƯỢN SÁCH", ViewType.Pie)
            tongSo = 0
            For Each data As TinhHinhMuonSachDTO In listTinhHinh
                series1.Points.Add(New SeriesPoint(data.TenTheLoai, data.TiLe))
                tongSo += data.SoLuotMuon
            Next
            lblTongSo.Text = "Tổng số lượt mượn: " & tongSo
            ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartControl1.Series.Add(series1)
            series1.Label.TextPattern = "{A}: {VP:p0}"


        End If
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Dim listTinhHinhMuonSach As List(Of TinhHinhMuonSachDTO)
        listTinhHinhMuonSach = tinhHinhMuonSachBUS.SelectAll(dteThangNam.EditValue.Month, dteThangNam.EditValue.Year)
        Using frmPrint As frmPrint = New frmPrint(dteThangNam.EditValue, listTinhHinhMuonSach)
            GlobalControl.ChangeStatus("Đã In thống kê")
            frmPrint.ShowDialog()
        End Using
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
