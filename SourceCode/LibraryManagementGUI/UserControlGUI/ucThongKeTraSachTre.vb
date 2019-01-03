Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Design
Imports LibraryManagementBUS
Imports LibraryManagementDTO
Imports Utility
Imports System.Object

Public Class ucThongKeTraSachTre
    Private sachTraTreBUS As SachTraTreBUS

    Private Sub ucThongKeTraSachTre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sachTraTreBUS = New SachTraTreBUS()

        'Cài đặt cho thời gian thống kê
        dteThoiGian.EditValue = Now
        dteThoiGian.Properties.EditMask = "dd/MM/yyyy"
        dteThoiGian.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        dteThoiGian.Properties.DisplayFormat.FormatType = FormatType.DateTime
        dteThoiGian.Properties.VistaCalendarViewStyle = VistaCalendarViewStyle.Default
        dteThoiGian.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"

        ' Cài đặt chart
    End Sub

    Private Sub CaiDatGridControl(listTinhHinhMuonSach As List(Of SachTraTreDTO))
        grcDanhSachThongKe.SuspendLayout() ' Tạm dừng hiển thị GridView

        ' Cài đặt cho GridControl và GridView
        grvDanhSachThongKe.BestFitColumns()
        grvDanhSachThongKe.Columns.Clear()
        grcDanhSachThongKe.DataSource = listTinhHinhMuonSach
        grvDanhSachThongKe.OptionsBehavior.Editable = False
        grvDanhSachThongKe.OptionsFind.AlwaysVisible = False
        grvDanhSachThongKe.OptionsView.ShowGroupPanel = False
        grvDanhSachThongKe.OptionsFind.FindDelay = 0

        grvDanhSachThongKe.Columns("TenSach").Caption = "Tên sách"
        grvDanhSachThongKe.Columns("NgayMuon").Caption = "Ngày mượn"
        grvDanhSachThongKe.Columns("SoNgayTraTre").Caption = "Số ngày trả trễ"

        grcDanhSachThongKe.ResumeLayout() ' Tiếp tục hiển thị GridView
    End Sub

    Private Sub txtTimKiem_EditValueChanged(sender As Object, e As EventArgs) Handles txtTimKiem.EditValueChanged
        Dim filterString As String
        filterString = String.Empty
        filterString = """" & txtTimKiem.EditValue & """"
        grvDanhSachThongKe.ApplyFindFilter(filterString)
    End Sub

    Private Sub dteThoiGian_EditValueChanged(sender As Object, e As EventArgs) Handles dteThoiGian.DateTimeChanged
        sachTraTreBUS = New SachTraTreBUS()
        If dteThoiGian.EditValue <> Nothing Then
            Dim listSachTraTre = New List(Of SachTraTreDTO)
            listSachTraTre = sachTraTreBUS.SelectAll(dteThoiGian.EditValue)
            CaiDatGridControl(listSachTraTre)

            Dim listBieuDo = New List(Of SachTraTreDTO)
            For Each item In listSachTraTre
                If listBieuDo.Count < 1 Then
                    listBieuDo.Add(item.Clone())
                    Continue For
                End If

                Dim flag As Boolean = True
                For Each dt In listBieuDo
                    If dt.TenSach = item.TenSach Then
                        dt.SoNgayTraTre += item.SoNgayTraTre
                        flag = False
                    End If
                Next

                If flag Then
                    listBieuDo.Add(item.Clone())
                End If
            Next

            ChartControl1.Series.Clear()
            Dim series1 As New Series("TỈ LỆ SÁCH TRẢ TRỄ", ViewType.Pie)
            For Each data As SachTraTreDTO In listBieuDo
                series1.Points.Add(New SeriesPoint(data.TenSach, data.SoNgayTraTre))
            Next
            ChartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            ChartControl1.Series.Add(series1)
            series1.Label.TextPattern = "{A}: {VP:p0}"
        End If
    End Sub

    Private Sub btnIn_Click(sender As Object, e As EventArgs) Handles btnIn.Click
        Dim listSachTraTre As List(Of SachTraTreDTO)
        listSachTraTre = sachTraTreBUS.SelectAll(dteThoiGian.EditValue)
        Using frmPrint As frmPrint = New frmPrint(dteThoiGian.EditValue, listSachTraTre)
            GlobalControl.ChangeStatus("Đã In thống kê")
            frmPrint.ShowDialog()
        End Using
    End Sub

    Private Sub btnDong_Click(sender As Object, e As EventArgs) Handles btnDong.Click
        Me.Parent.Dispose()
    End Sub
End Class
