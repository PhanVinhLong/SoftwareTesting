<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNhanTraSach
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucNhanTraSach))
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.dteNgayTra = New DevExpress.XtraEditors.DateEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNhanSachVaDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNhanSach = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lblSachDaChon = New DevExpress.XtraEditors.LabelControl()
        Me.gcDocGia = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblSachMuonConHan = New DevExpress.XtraEditors.LabelControl()
        Me.lblSachMuonQuaHan = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTimKiem = New DevExpress.XtraEditors.TextEdit()
        Me.grcDanhSachSach = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachSach = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTaiLaiDocGia = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lueChonLoaiDocGia = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTimKiemDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.grcDanhSachDocGia = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachDocGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dteNgayTra.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayTra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcDocGia.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.lueChonLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTimKiemDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.dteNgayTra)
        Me.GroupControl2.Location = New System.Drawing.Point(666, 106)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(200, 83)
        Me.GroupControl2.TabIndex = 60
        Me.GroupControl2.Text = "Ngày trả"
        '
        'dteNgayTra
        '
        Me.dteNgayTra.EditValue = Nothing
        Me.dteNgayTra.Location = New System.Drawing.Point(23, 35)
        Me.dteNgayTra.Name = "dteNgayTra"
        Me.dteNgayTra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayTra.Size = New System.Drawing.Size(155, 20)
        Me.dteNgayTra.TabIndex = 0
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Controls.Add(Me.btnNhanSachVaDong)
        Me.PanelControl1.Controls.Add(Me.btnNhanSach)
        Me.PanelControl1.Location = New System.Drawing.Point(665, 9)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(202, 91)
        Me.PanelControl1.TabIndex = 59
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(105, 10)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(86, 23)
        Me.btnDong.TabIndex = 2
        Me.btnDong.Text = "Đóng"
        '
        'btnNhanSachVaDong
        '
        Me.btnNhanSachVaDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnNhanSachVaDong.ImageOptions.ImageUri.Uri = "DoubleLast;Size16x16;Office2013"
        Me.btnNhanSachVaDong.Location = New System.Drawing.Point(13, 49)
        Me.btnNhanSachVaDong.Name = "btnNhanSachVaDong"
        Me.btnNhanSachVaDong.Size = New System.Drawing.Size(86, 32)
        Me.btnNhanSachVaDong.TabIndex = 1
        Me.btnNhanSachVaDong.Text = "Nhận sách" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "và đóng"
        '
        'btnNhanSach
        '
        Me.btnNhanSach.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnNhanSach.ImageOptions.ImageUri.Uri = "DoubleNext;Size16x16;Office2013"
        Me.btnNhanSach.Location = New System.Drawing.Point(105, 49)
        Me.btnNhanSach.Name = "btnNhanSach"
        Me.btnNhanSach.Size = New System.Drawing.Size(86, 32)
        Me.btnNhanSach.TabIndex = 0
        Me.btnNhanSach.Text = "Nhận sách"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblSachDaChon)
        Me.GroupControl1.Location = New System.Drawing.Point(23, 475)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(844, 59)
        Me.GroupControl1.TabIndex = 58
        Me.GroupControl1.Text = "Sách đã chọn"
        '
        'lblSachDaChon
        '
        Me.lblSachDaChon.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSachDaChon.Appearance.Options.UseFont = True
        Me.lblSachDaChon.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblSachDaChon.Location = New System.Drawing.Point(5, 30)
        Me.lblSachDaChon.Name = "lblSachDaChon"
        Me.lblSachDaChon.Size = New System.Drawing.Size(816, 13)
        Me.lblSachDaChon.TabIndex = 42
        Me.lblSachDaChon.Text = "Chưa chọn sách"
        '
        'gcDocGia
        '
        Me.gcDocGia.Controls.Add(Me.LabelControl1)
        Me.gcDocGia.Controls.Add(Me.lblSachMuonConHan)
        Me.gcDocGia.Controls.Add(Me.lblSachMuonQuaHan)
        Me.gcDocGia.Controls.Add(Me.LabelControl2)
        Me.gcDocGia.Location = New System.Drawing.Point(23, 195)
        Me.gcDocGia.Name = "gcDocGia"
        Me.gcDocGia.Size = New System.Drawing.Size(844, 87)
        Me.gcDocGia.TabIndex = 57
        Me.gcDocGia.Text = "Sách đang mượn của độc giả"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(5, 29)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Sách mượn quá hạn:"
        '
        'lblSachMuonConHan
        '
        Me.lblSachMuonConHan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSachMuonConHan.Appearance.Options.UseFont = True
        Me.lblSachMuonConHan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblSachMuonConHan.Location = New System.Drawing.Point(125, 56)
        Me.lblSachMuonConHan.Name = "lblSachMuonConHan"
        Me.lblSachMuonConHan.Size = New System.Drawing.Size(696, 13)
        Me.lblSachMuonConHan.TabIndex = 43
        Me.lblSachMuonConHan.Text = "Sách XYZ, Sách ABC"
        '
        'lblSachMuonQuaHan
        '
        Me.lblSachMuonQuaHan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lblSachMuonQuaHan.Appearance.Options.UseFont = True
        Me.lblSachMuonQuaHan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lblSachMuonQuaHan.Location = New System.Drawing.Point(125, 29)
        Me.lblSachMuonQuaHan.Name = "lblSachMuonQuaHan"
        Me.lblSachMuonQuaHan.Size = New System.Drawing.Size(696, 13)
        Me.lblSachMuonQuaHan.TabIndex = 42
        Me.lblSachMuonQuaHan.Text = "Sách XYZ, Sách ABC"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(5, 56)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Sách mượn còn hạn:"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.LabelControl3)
        Me.PanelControl3.Controls.Add(Me.btnTaiLai)
        Me.PanelControl3.Controls.Add(Me.txtTimKiem)
        Me.PanelControl3.Location = New System.Drawing.Point(23, 288)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(844, 37)
        Me.PanelControl3.TabIndex = 56
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Image = CType(resources.GetObject("LabelControl3.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl3.Appearance.Options.UseImage = True
        Me.LabelControl3.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl3.Location = New System.Drawing.Point(8, 7)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl3.TabIndex = 26
        Me.LabelControl3.Text = "Tìm kiếm"
        '
        'btnTaiLai
        '
        Me.btnTaiLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnTaiLai.ImageOptions.ImageUri.Uri = "Reset;Size16x16;Office2013"
        Me.btnTaiLai.Location = New System.Drawing.Point(225, 6)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(113, 21)
        Me.btnTaiLai.TabIndex = 22
        Me.btnTaiLai.Text = "Tải lại"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(75, 7)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(139, 20)
        Me.txtTimKiem.TabIndex = 18
        '
        'grcDanhSachSach
        '
        Me.grcDanhSachSach.Location = New System.Drawing.Point(23, 331)
        Me.grcDanhSachSach.MainView = Me.grvDanhSachSach
        Me.grcDanhSachSach.Name = "grcDanhSachSach"
        Me.grcDanhSachSach.Size = New System.Drawing.Size(844, 138)
        Me.grcDanhSachSach.TabIndex = 55
        Me.grcDanhSachSach.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachSach})
        '
        'grvDanhSachSach
        '
        Me.grvDanhSachSach.GridControl = Me.grcDanhSachSach
        Me.grvDanhSachSach.Name = "grvDanhSachSach"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Controls.Add(Me.btnTaiLaiDocGia)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.lueChonLoaiDocGia)
        Me.PanelControl2.Controls.Add(Me.txtTimKiemDocGia)
        Me.PanelControl2.Location = New System.Drawing.Point(23, 9)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(636, 39)
        Me.PanelControl2.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Loại độc giả"
        '
        'btnTaiLaiDocGia
        '
        Me.btnTaiLaiDocGia.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnTaiLaiDocGia.ImageOptions.ImageUri.Uri = "Reset;Size16x16;Office2013"
        Me.btnTaiLaiDocGia.Location = New System.Drawing.Point(475, 6)
        Me.btnTaiLaiDocGia.Name = "btnTaiLaiDocGia"
        Me.btnTaiLaiDocGia.Size = New System.Drawing.Size(84, 22)
        Me.btnTaiLaiDocGia.TabIndex = 22
        Me.btnTaiLaiDocGia.Text = "Tải lại"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Image = CType(resources.GetObject("LabelControl10.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl10.Appearance.Options.UseImage = True
        Me.LabelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl10.Location = New System.Drawing.Point(8, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "Tìm kiếm"
        '
        'lueChonLoaiDocGia
        '
        Me.lueChonLoaiDocGia.EditValue = " "
        Me.lueChonLoaiDocGia.Location = New System.Drawing.Point(353, 7)
        Me.lueChonLoaiDocGia.Name = "lueChonLoaiDocGia"
        Me.lueChonLoaiDocGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueChonLoaiDocGia.Size = New System.Drawing.Size(116, 20)
        Me.lueChonLoaiDocGia.TabIndex = 1
        '
        'txtTimKiemDocGia
        '
        Me.txtTimKiemDocGia.Location = New System.Drawing.Point(75, 9)
        Me.txtTimKiemDocGia.Name = "txtTimKiemDocGia"
        Me.txtTimKiemDocGia.Size = New System.Drawing.Size(126, 20)
        Me.txtTimKiemDocGia.TabIndex = 18
        '
        'grcDanhSachDocGia
        '
        Me.grcDanhSachDocGia.Location = New System.Drawing.Point(23, 54)
        Me.grcDanhSachDocGia.MainView = Me.grvDanhSachDocGia
        Me.grcDanhSachDocGia.Name = "grcDanhSachDocGia"
        Me.grcDanhSachDocGia.Size = New System.Drawing.Size(636, 135)
        Me.grcDanhSachDocGia.TabIndex = 53
        Me.grcDanhSachDocGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachDocGia})
        '
        'grvDanhSachDocGia
        '
        Me.grvDanhSachDocGia.GridControl = Me.grcDanhSachDocGia
        Me.grvDanhSachDocGia.Name = "grvDanhSachDocGia"
        '
        'ucNhanTraSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gcDocGia)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.grcDanhSachSach)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.grcDanhSachDocGia)
        Me.Name = "ucNhanTraSach"
        Me.Size = New System.Drawing.Size(891, 557)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.dteNgayTra.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayTra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gcDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcDocGia.ResumeLayout(False)
        Me.gcDocGia.PerformLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.lueChonLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTimKiemDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dteNgayTra As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNhanSachVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNhanSach As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblSachDaChon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcDocGia As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSachMuonConHan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSachMuonQuaHan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnTaiLai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTimKiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grcDanhSachSach As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachSach As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Label1 As Label
    Friend WithEvents btnTaiLaiDocGia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueChonLoaiDocGia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTimKiemDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grcDanhSachDocGia As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachDocGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
