<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThongTinTaiKhoan
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenDangNhap = New DevExpress.XtraEditors.TextEdit()
        Me.txtHoTen = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtReMatKhau = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMatKhau = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.txtLoaiNhanVien = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReMatKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoaiNhanVien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtLoaiNhanVien)
        Me.GroupControl1.Controls.Add(Me.btnDong)
        Me.GroupControl1.Controls.Add(Me.btnCapNhat)
        Me.GroupControl1.Controls.Add(Me.txtMatKhau)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtReMatKhau)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtHoTen)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtTenDangNhap)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(21, 14)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(532, 123)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Thông tin tài khoản"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tên đăng nhập"
        '
        'txtTenDangNhap
        '
        Me.txtTenDangNhap.Enabled = False
        Me.txtTenDangNhap.Location = New System.Drawing.Point(112, 27)
        Me.txtTenDangNhap.Name = "txtTenDangNhap"
        Me.txtTenDangNhap.Size = New System.Drawing.Size(123, 20)
        Me.txtTenDangNhap.TabIndex = 1
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(112, 58)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(123, 20)
        Me.txtHoTen.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Họ tên"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 87)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Loại nhân viên"
        '
        'txtReMatKhau
        '
        Me.txtReMatKhau.Location = New System.Drawing.Point(386, 84)
        Me.txtReMatKhau.Name = "txtReMatKhau"
        Me.txtReMatKhau.Size = New System.Drawing.Size(123, 20)
        Me.txtReMatKhau.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(292, 87)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Mật khẩu mới"
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(386, 58)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.Size = New System.Drawing.Size(123, 20)
        Me.txtMatKhau.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(292, 61)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Mật khẩu cũ"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCapNhat.ImageOptions.ImageUri.Uri = "Refresh;Size16x16;Office2013"
        Me.btnCapNhat.Location = New System.Drawing.Point(288, 24)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(106, 23)
        Me.btnCapNhat.TabIndex = 1
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(403, 24)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(106, 23)
        Me.btnDong.TabIndex = 11
        Me.btnDong.Text = "Đóng"
        '
        'txtLoaiNhanVien
        '
        Me.txtLoaiNhanVien.Enabled = False
        Me.txtLoaiNhanVien.Location = New System.Drawing.Point(112, 84)
        Me.txtLoaiNhanVien.Name = "txtLoaiNhanVien"
        Me.txtLoaiNhanVien.Size = New System.Drawing.Size(123, 20)
        Me.txtLoaiNhanVien.TabIndex = 12
        '
        'ucThongTinTaiKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "ucThongTinTaiKhoan"
        Me.Size = New System.Drawing.Size(579, 157)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtTenDangNhap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReMatKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMatKhau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoaiNhanVien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHoTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenDangNhap As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMatKhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReMatKhau As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtLoaiNhanVien As DevExpress.XtraEditors.TextEdit
End Class
