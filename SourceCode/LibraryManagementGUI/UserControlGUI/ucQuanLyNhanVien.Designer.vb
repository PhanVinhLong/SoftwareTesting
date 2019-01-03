<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucQuanLyNhanVien
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucQuanLyNhanVien))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtHoTen = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenDangNhap = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.grcDanhSachNhanVien = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachTacGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lueLoaiNhanVien = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMatKhau = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReMatKhau = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTimKiem = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        Me.lueChonLoaiNhanVien = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtHoTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grcDanhSachNhanVien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachTacGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueLoaiNhanVien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReMatKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueChonLoaiNhanVien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtReMatKhau)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtMatKhau)
        Me.GroupControl1.Controls.Add(Me.lueLoaiNhanVien)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtHoTen)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtTenDangNhap)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(594, 92)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(261, 166)
        Me.GroupControl1.TabIndex = 16
        Me.GroupControl1.Text = "Thông tin tác giả"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(108, 55)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(140, 20)
        Me.txtHoTen.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tên đăng nhậo"
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Enabled = False
        Me.txtTenDangNhap.Location = New System.Drawing.Point(108, 28)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(140, 20)
        Me.txtTenDangNhap.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Họ tên"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCapNhat)
        Me.PanelControl2.Controls.Add(Me.btnXoa)
        Me.PanelControl2.Controls.Add(Me.btnDong)
        Me.PanelControl2.Location = New System.Drawing.Point(594, 21)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(261, 65)
        Me.PanelControl2.TabIndex = 15
        '
        'btnCapNhat
        '
        Me.btnCapNhat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCapNhat.ImageOptions.ImageUri.Uri = "CustomizeGrid;Size16x16;Office2013"
        Me.btnCapNhat.Location = New System.Drawing.Point(16, 6)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(102, 23)
        Me.btnCapNhat.TabIndex = 9
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnXoa.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnXoa.Location = New System.Drawing.Point(144, 6)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(102, 23)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "Xoá"
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(144, 35)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(102, 23)
        Me.btnDong.TabIndex = 11
        Me.btnDong.Text = "Đóng"
        '
        'grcDanhSachNhanVien
        '
        Me.grcDanhSachNhanVien.Location = New System.Drawing.Point(26, 76)
        Me.grcDanhSachNhanVien.MainView = Me.grvDanhSachTacGia
        Me.grcDanhSachNhanVien.Name = "grcDanhSachNhanVien"
        Me.grcDanhSachNhanVien.Size = New System.Drawing.Size(562, 182)
        Me.grcDanhSachNhanVien.TabIndex = 14
        Me.grcDanhSachNhanVien.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachTacGia})
        '
        'grvDanhSachTacGia
        '
        Me.grvDanhSachTacGia.GridControl = Me.grcDanhSachNhanVien
        Me.grvDanhSachTacGia.Name = "grvDanhSachTacGia"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Loại nhân viên"
        '
        'lueLoaiNhanVien
        '
        Me.lueLoaiNhanVien.Location = New System.Drawing.Point(108, 81)
        Me.lueLoaiNhanVien.Name = "lueLoaiNhanVien"
        Me.lueLoaiNhanVien.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoaiNhanVien.Size = New System.Drawing.Size(140, 20)
        Me.lueLoaiNhanVien.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 110)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Mật khẩu"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(108, 107)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(140, 20)
        Me.txtMatKhau.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 136)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Nhập lại mật khẩu"
        '
        'txtReMatKhau
        '
        Me.txtReMatKhau.Location = New System.Drawing.Point(108, 133)
        Me.txtReMatKhau.Name = "txtReMatKhau"
        Me.txtReMatKhau.Size = New System.Drawing.Size(140, 20)
        Me.txtReMatKhau.TabIndex = 9
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.btnTaiLai)
        Me.PanelControl1.Controls.Add(Me.lueChonLoaiNhanVien)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.txtTimKiem)
        Me.PanelControl1.Location = New System.Drawing.Point(26, 21)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(562, 36)
        Me.PanelControl1.TabIndex = 17
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Image = CType(resources.GetObject("LabelControl10.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl10.Appearance.Options.UseImage = True
        Me.LabelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl10.Location = New System.Drawing.Point(5, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl10.TabIndex = 26
        Me.LabelControl10.Text = "Tìm kiếm"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(72, 9)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(126, 20)
        Me.txtTimKiem.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Loại nhân viên"
        '
        'btnTaiLai
        '
        Me.btnTaiLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnTaiLai.ImageOptions.ImageUri.Uri = "Reset;Size16x16;Office2013"
        Me.btnTaiLai.Location = New System.Drawing.Point(449, 8)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(84, 22)
        Me.btnTaiLai.TabIndex = 28
        Me.btnTaiLai.Text = "Tải lại"
        '
        'lueChonLoaiNhanVien
        '
        Me.lueChonLoaiNhanVien.EditValue = " "
        Me.lueChonLoaiNhanVien.Location = New System.Drawing.Point(327, 9)
        Me.lueChonLoaiNhanVien.Name = "lueChonLoaiNhanVien"
        Me.lueChonLoaiNhanVien.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueChonLoaiNhanVien.Size = New System.Drawing.Size(116, 20)
        Me.lueChonLoaiNhanVien.TabIndex = 27
        '
        'ucQuanLyNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.grcDanhSachNhanVien)
        Me.Name = "ucQuanLyNhanVien"
        Me.Size = New System.Drawing.Size(883, 283)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtHoTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grcDanhSachNhanVien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachTacGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueLoaiNhanVien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReMatKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueChonLoaiNhanVien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtHoTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenDangNhap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grcDanhSachNhanVien As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachTacGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lueLoaiNhanVien As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReMatKhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMatKhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTimKiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTaiLai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lueChonLoaiNhanVien As DevExpress.XtraEditors.LookUpEdit
End Class
