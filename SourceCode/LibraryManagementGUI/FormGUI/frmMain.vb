Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTab
Imports DevExpress.XtraTab.ViewInfo
Imports Utility

Public Class frmMain
    Dim clsAddTab As AddTab = New AddTab()
    Dim frmDangNhap As frmLogin

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmDangNhap = New frmLogin()
    End Sub

    Public Sub New(frm As frmLogin)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        frmDangNhap = frm
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tắt QuickAccessBar của RibbonControl
        xtcMain.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders

        ' Mở UC Thông tin
        clsAddTab.AddTab(xtcMain, "Thông tin", New ucThongTin())

        ' Cài đặt biến global
        GlobalControl.GetControl(txtThongTin, txtLoaiTaiKhoan, txtTenTaiKhoan)
        GlobalControl.ChangeAccouInfo()

        ' Phần dành riêng cho admin
        If GlobalControl.ReturnNhanVien.MaLoaiNhanVien <> 1 Then
            rpgQuanLyNhanVien.Visible = False
            rpgThayDoiQuyDinh.Visible = False
        End If
    End Sub

    Private Sub xtcMain_CloseButtonClick(sender As Object, e As EventArgs) Handles xtcMain.CloseButtonClick
        Dim arg As ClosePageButtonEventArgs = TryCast(e, ClosePageButtonEventArgs)
        TryCast(arg.Page, XtraTabPage).Dispose()
    End Sub

    Private Sub btnThoat_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThoat.ItemClick
        Me.Close()
    End Sub

    Private Sub btnChoMuonSach_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChoMuonSach.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Cho mượn sách" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Cho mượn sách", New ucChoMuonSach())
        End If
    End Sub

    Private Sub btnLapTheDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLapTheDocGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Lập thẻ độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Lập thẻ độc giả", New ucLapTheDocGia())
        End If
    End Sub

    Private Sub btnNhanTraSach_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNhanTraSach.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Nhận trả sách" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Nhận trả sách", New ucNhanTraSach())
        End If
    End Sub

    Private Sub btnQuanLyDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyDocGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý độc giả", New ucQuanLyDocGia())
        End If
    End Sub

    Private Sub btnQuanLyLoaiDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyLoaiDocGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý loại độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý loại độc giả", New ucQuanLyLoaiDocGia())
        End If
    End Sub

    Private Sub btnQuanLySach_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLySach.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý sách" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý sách", New ucQuanLySach())
        End If
    End Sub

    Private Sub btnQuanLyTacGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyTacGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý tác giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý tác giả", New ucQuanLyTacGia())
        End If
    End Sub

    Private Sub btnQuanLyTheLoai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuanLyTheLoai.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý thể loại" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý thể loại", New ucQuanLyTheLoaiSach())
        End If
    End Sub

    Private Sub btnThemLoaiDocGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemLoaiDocGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thêm loại độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thêm loại độc giả", New ucThemLoaiDocGia())
        End If
    End Sub

    Private Sub btnThemTacGia_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemTacGia.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thêm tác giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thêm tác giả", New ucThemTacGia())
        End If
    End Sub

    Private Sub btnThemTheLoai_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemTheLoai.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thêm thể loại" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thêm thể loại", New ucThemTheLoai())
        End If
    End Sub

    Private Sub btnTiepNhanSachMoi_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTiepNhanSachMoi.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Tiếp nhận sách mới" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Tiếp nhận sách mới", New ucTiepNhanSachMoi())
        End If
    End Sub

    Private Sub btnThongTin_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThongTin.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thông tin" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thông tin", New ucThongTin())
        End If
    End Sub

    Private Sub nbiChoMuonSach_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiChoMuonSach.LinkClicked
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Cho mượn sách" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Cho mượn sách", New ucChoMuonSach())
        End If
    End Sub

    Private Sub nbiNhanTraSach_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiNhanTraSach.LinkClicked

    End Sub

    Private Sub nbiTiepNhanSach_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTiepNhanSach.LinkClicked
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Tiếp nhận sách mới" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Tiếp nhận sách mới", New ucTiepNhanSachMoi())
        End If
    End Sub

    Private Sub nbiLapTheDocGia_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiLapTheDocGia.LinkClicked
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Lập thẻ độc giả" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Lập thẻ độc giả", New ucLapTheDocGia())
        End If
    End Sub

    Private Sub btnThayDoiQuyDinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThayDoiQuyDinh.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thay đổi quy định" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thay đổi quy định", New ucThayDoiQuyDinh())
        End If
    End Sub

    Private Sub btnThongKeTinhHinh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThongKeTinhHinh.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thống kê tình hình mượn" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thống kê tình hình mượn", New ucThongKeTinhHinhMuonSach())
        End If
    End Sub

    Private Sub btnThongKeSachTraTre_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThongKeSachTraTre.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thống kê sách trả trễ" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thống kê sách trả trễ", New ucThongKeTraSachTre())
        End If
    End Sub

    Private Sub nbiDoiMatKhau_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiTaiKhoan.LinkClicked
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thông tin tài khoản" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thông tin tài khoản", New ucThongTinTaiKhoan())
        End If
    End Sub

    Private Sub nbiDangXuat_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiDangXuat.LinkClicked
        If MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            frmDangNhap.Visible = True
            Me.Dispose()
        End If
        Return
    End Sub

    Private Sub btnThongTinTaiKhoan_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnThongTinTaiKhoan.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Thông tin tài khoản" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Thông tin tài khoản", New ucThongTinTaiKhoan())
        End If
    End Sub

    Private Sub btnQuanLyNhanVien_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btnQuanLyNhanVien.ItemClick
        Dim t As Integer = 0
        For Each tab As DevExpress.XtraTab.XtraTabPage In xtcMain.TabPages
            If tab.Text = "Quản lý nhân viên" Then
                xtcMain.SelectedTabPage = tab
                t = 1
            End If
        Next
        If t <> 1 Then
            clsAddTab.AddTab(xtcMain, "Quản lý nhân viên", New ucQuanLyNhanVien())
        End If
    End Sub
End Class