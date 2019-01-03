<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucQuanLyLoaiDocGia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucQuanLyLoaiDocGia))
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.grvDanhSachLoaiDocGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grcDanhSachLoaiDocGia = New DevExpress.XtraGrid.GridControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTimKiem = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.grvDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCapNhat
        '
        Me.btnCapNhat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCapNhat.ImageOptions.ImageUri.Uri = "CustomizeGrid;Size16x16;Office2013"
        Me.btnCapNhat.Location = New System.Drawing.Point(17, 13)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(97, 28)
        Me.btnCapNhat.TabIndex = 29
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnXoa.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnXoa.Location = New System.Drawing.Point(139, 60)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(97, 28)
        Me.btnXoa.TabIndex = 30
        Me.btnXoa.Text = "Xoá"
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(139, 13)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(97, 28)
        Me.btnDong.TabIndex = 31
        Me.btnDong.Text = "Đóng"
        '
        'grvDanhSachLoaiDocGia
        '
        Me.grvDanhSachLoaiDocGia.GridControl = Me.grcDanhSachLoaiDocGia
        Me.grvDanhSachLoaiDocGia.Name = "grvDanhSachLoaiDocGia"
        '
        'grcDanhSachLoaiDocGia
        '
        Me.grcDanhSachLoaiDocGia.Location = New System.Drawing.Point(20, 59)
        Me.grcDanhSachLoaiDocGia.MainView = Me.grvDanhSachLoaiDocGia
        Me.grcDanhSachLoaiDocGia.Name = "grcDanhSachLoaiDocGia"
        Me.grcDanhSachLoaiDocGia.Size = New System.Drawing.Size(257, 172)
        Me.grcDanhSachLoaiDocGia.TabIndex = 27
        Me.grcDanhSachLoaiDocGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachLoaiDocGia})
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã loại độc giả"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(17, 76)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên loại độc giả"
        '
        'txtMaLoaiDocGia
        '
        Me.txtMaLoaiDocGia.Enabled = False
        Me.txtMaLoaiDocGia.Location = New System.Drawing.Point(108, 39)
        Me.txtMaLoaiDocGia.Name = "txtMaLoaiDocGia"
        Me.txtMaLoaiDocGia.Size = New System.Drawing.Size(125, 20)
        Me.txtMaLoaiDocGia.TabIndex = 2
        '
        'txtTenLoaiDocGia
        '
        Me.txtTenLoaiDocGia.Location = New System.Drawing.Point(108, 73)
        Me.txtTenLoaiDocGia.Name = "txtTenLoaiDocGia"
        Me.txtTenLoaiDocGia.Size = New System.Drawing.Size(125, 20)
        Me.txtTenLoaiDocGia.TabIndex = 3
        '
        'btnTaiLai
        '
        Me.btnTaiLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnTaiLai.ImageOptions.ImageUri.Uri = "Reset;Size16x16;Office2013"
        Me.btnTaiLai.Location = New System.Drawing.Point(17, 60)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(97, 28)
        Me.btnTaiLai.TabIndex = 32
        Me.btnTaiLai.Text = "Tải lại"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(80, 9)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(141, 20)
        Me.txtTimKiem.TabIndex = 18
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Image = CType(resources.GetObject("LabelControl10.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl10.Appearance.Options.UseImage = True
        Me.LabelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl10.Location = New System.Drawing.Point(13, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "Tìm kiếm"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.txtTimKiem)
        Me.PanelControl2.Location = New System.Drawing.Point(20, 17)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(257, 36)
        Me.PanelControl2.TabIndex = 33
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.btnTaiLai)
        Me.PanelControl3.Controls.Add(Me.btnCapNhat)
        Me.PanelControl3.Controls.Add(Me.btnXoa)
        Me.PanelControl3.Controls.Add(Me.btnDong)
        Me.PanelControl3.Location = New System.Drawing.Point(283, 17)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(251, 102)
        Me.PanelControl3.TabIndex = 34
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtTenLoaiDocGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtMaLoaiDocGia)
        Me.GroupControl1.Location = New System.Drawing.Point(283, 125)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(251, 106)
        Me.GroupControl1.TabIndex = 35
        Me.GroupControl1.Text = "Chi tiết loại độc giả"
        '
        'ucQuanLyLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.grcDanhSachLoaiDocGia)
        Me.Name = "ucQuanLyLoaiDocGia"
        Me.Size = New System.Drawing.Size(556, 249)
        CType(Me.grvDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachLoaiDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grvDanhSachLoaiDocGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grcDanhSachLoaiDocGia As DevExpress.XtraGrid.GridControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaLoaiDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenLoaiDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnTaiLai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTimKiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
