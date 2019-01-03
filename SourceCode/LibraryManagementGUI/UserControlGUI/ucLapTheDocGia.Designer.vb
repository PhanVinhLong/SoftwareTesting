<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucLapTheDocGia
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
        Me.lblTuoi = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lueLoaiDocGia = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.dteNgayHetHan = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.dteNgayLapThe = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMaDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtHoTen = New DevExpress.XtraEditors.TextEdit()
        Me.txtDiaChi = New DevExpress.XtraEditors.TextEdit()
        Me.dteNgaySinh = New DevExpress.XtraEditors.DateEdit()
        Me.btnLapTheVaDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLapThe = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblGioiHanTuoi = New DevExpress.XtraEditors.LabelControl()
        Me.lblThoiHanSuDung = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.lueLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayHetHan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayHetHan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayLapThe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgayLapThe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHoTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteNgaySinh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTuoi
        '
        Me.lblTuoi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblTuoi.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblTuoi.Appearance.Options.UseFont = True
        Me.lblTuoi.Appearance.Options.UseForeColor = True
        Me.lblTuoi.Location = New System.Drawing.Point(246, 95)
        Me.lblTuoi.Name = "lblTuoi"
        Me.lblTuoi.Size = New System.Drawing.Size(35, 13)
        Me.lblTuoi.TabIndex = 66
        Me.lblTuoi.Text = "XX tuổi"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl1.TabIndex = 50
        Me.LabelControl1.Text = "Mã độc giả"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(20, 66)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl10.TabIndex = 51
        Me.LabelControl10.Text = "Họ tên *"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(20, 95)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl11.TabIndex = 52
        Me.LabelControl11.Text = "Ngày sinh *"
        '
        'LabelControl12
        '
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(20, 124)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl12.TabIndex = 53
        Me.LabelControl12.Text = "Địa chỉ"
        '
        'lueLoaiDocGia
        '
        Me.lueLoaiDocGia.EditValue = "Loại Độc Giả"
        Me.lueLoaiDocGia.Location = New System.Drawing.Point(412, 121)
        Me.lueLoaiDocGia.Name = "lueLoaiDocGia"
        Me.lueLoaiDocGia.Properties.AutoSearchColumnIndex = 1
        Me.lueLoaiDocGia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLoaiDocGia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lueLoaiDocGia.Size = New System.Drawing.Size(148, 20)
        Me.lueLoaiDocGia.TabIndex = 65
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(324, 37)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl13.TabIndex = 54
        Me.LabelControl13.Text = "Email"
        '
        'dteNgayHetHan
        '
        Me.dteNgayHetHan.EditValue = Nothing
        Me.dteNgayHetHan.Enabled = False
        Me.dteNgayHetHan.Location = New System.Drawing.Point(412, 92)
        Me.dteNgayHetHan.Name = "dteNgayHetHan"
        Me.dteNgayHetHan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayHetHan.Size = New System.Drawing.Size(148, 20)
        Me.dteNgayHetHan.TabIndex = 64
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(324, 66)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl14.TabIndex = 55
        Me.LabelControl14.Text = "Ngày lập thẻ *"
        '
        'dteNgayLapThe
        '
        Me.dteNgayLapThe.EditValue = New Date(2018, 6, 10, 16, 32, 9, 0)
        Me.dteNgayLapThe.Location = New System.Drawing.Point(412, 63)
        Me.dteNgayLapThe.Name = "dteNgayLapThe"
        Me.dteNgayLapThe.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayLapThe.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgayLapThe.Size = New System.Drawing.Size(148, 20)
        Me.dteNgayLapThe.TabIndex = 63
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(324, 95)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl15.TabIndex = 56
        Me.LabelControl15.Text = "Ngày hết hạn"
        '
        'txtMaDocGia
        '
        Me.txtMaDocGia.Enabled = False
        Me.txtMaDocGia.Location = New System.Drawing.Point(93, 34)
        Me.txtMaDocGia.Name = "txtMaDocGia"
        Me.txtMaDocGia.Size = New System.Drawing.Size(148, 20)
        Me.txtMaDocGia.TabIndex = 58
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(412, 34)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(148, 20)
        Me.txtEmail.TabIndex = 62
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(324, 124)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl16.TabIndex = 57
        Me.LabelControl16.Text = "Loại độc giả *"
        '
        'txtHoTen
        '
        Me.txtHoTen.Location = New System.Drawing.Point(93, 63)
        Me.txtHoTen.Name = "txtHoTen"
        Me.txtHoTen.Size = New System.Drawing.Size(148, 20)
        Me.txtHoTen.TabIndex = 59
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Location = New System.Drawing.Point(93, 121)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(148, 20)
        Me.txtDiaChi.TabIndex = 61
        '
        'dteNgaySinh
        '
        Me.dteNgaySinh.EditValue = Nothing
        Me.dteNgaySinh.Location = New System.Drawing.Point(93, 92)
        Me.dteNgaySinh.Name = "dteNgaySinh"
        Me.dteNgaySinh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteNgaySinh.Size = New System.Drawing.Size(148, 20)
        Me.dteNgaySinh.TabIndex = 60
        '
        'btnLapTheVaDong
        '
        Me.btnLapTheVaDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnLapTheVaDong.ImageOptions.ImageUri.Uri = "DoubleNext;Size16x16;Office2013"
        Me.btnLapTheVaDong.Location = New System.Drawing.Point(12, 60)
        Me.btnLapTheVaDong.Name = "btnLapTheVaDong"
        Me.btnLapTheVaDong.Size = New System.Drawing.Size(100, 31)
        Me.btnLapTheVaDong.TabIndex = 47
        Me.btnLapTheVaDong.Text = "Lập thẻ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "và Đóng"
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(12, 12)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(100, 23)
        Me.btnDong.TabIndex = 46
        Me.btnDong.Text = "Đóng"
        '
        'btnLapThe
        '
        Me.btnLapThe.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnLapThe.ImageOptions.ImageUri.Uri = "Add;Size16x16;Office2013"
        Me.btnLapThe.Location = New System.Drawing.Point(12, 115)
        Me.btnLapThe.Name = "btnLapThe"
        Me.btnLapThe.Size = New System.Drawing.Size(100, 23)
        Me.btnLapThe.TabIndex = 45
        Me.btnLapThe.Text = "Lập thẻ"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Controls.Add(Me.btnLapTheVaDong)
        Me.PanelControl1.Controls.Add(Me.btnLapThe)
        Me.PanelControl1.Location = New System.Drawing.Point(607, 15)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(123, 149)
        Me.PanelControl1.TabIndex = 67
        '
        'lblGioiHanTuoi
        '
        Me.lblGioiHanTuoi.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanTuoi.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanTuoi.Appearance.Options.UseFont = True
        Me.lblGioiHanTuoi.Appearance.Options.UseForeColor = True
        Me.lblGioiHanTuoi.Location = New System.Drawing.Point(16, 23)
        Me.lblGioiHanTuoi.Name = "lblGioiHanTuoi"
        Me.lblGioiHanTuoi.Size = New System.Drawing.Size(84, 13)
        Me.lblGioiHanTuoi.TabIndex = 49
        Me.lblGioiHanTuoi.Text = "* Tuổi từ x đến y"
        '
        'lblThoiHanSuDung
        '
        Me.lblThoiHanSuDung.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblThoiHanSuDung.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblThoiHanSuDung.Appearance.Options.UseFont = True
        Me.lblThoiHanSuDung.Appearance.Options.UseForeColor = True
        Me.lblThoiHanSuDung.Location = New System.Drawing.Point(16, 4)
        Me.lblThoiHanSuDung.Name = "lblThoiHanSuDung"
        Me.lblThoiHanSuDung.Size = New System.Drawing.Size(137, 13)
        Me.lblThoiHanSuDung.TabIndex = 48
        Me.lblThoiHanSuDung.Text = "* Thời hạn sử dụng: x tháng"
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.lblThoiHanSuDung)
        Me.PanelControl3.Controls.Add(Me.lblGioiHanTuoi)
        Me.PanelControl3.Location = New System.Drawing.Point(17, 170)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(713, 40)
        Me.PanelControl3.TabIndex = 69
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtMaDocGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.lblTuoi)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.dteNgayLapThe)
        Me.GroupControl1.Controls.Add(Me.dteNgaySinh)
        Me.GroupControl1.Controls.Add(Me.dteNgayHetHan)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.txtDiaChi)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(Me.txtHoTen)
        Me.GroupControl1.Controls.Add(Me.lueLoaiDocGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Location = New System.Drawing.Point(17, 15)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(584, 149)
        Me.GroupControl1.TabIndex = 70
        Me.GroupControl1.Text = "Chi tiết độc giả"
        '
        'ucLapTheDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ucLapTheDocGia"
        Me.Size = New System.Drawing.Size(746, 228)
        CType(Me.lueLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayHetHan.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayHetHan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayLapThe.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgayLapThe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHoTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiaChi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgaySinh.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteNgaySinh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTuoi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueLoaiDocGia As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteNgayHetHan As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteNgayLapThe As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMaDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtHoTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDiaChi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dteNgaySinh As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnLapTheVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLapThe As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblGioiHanTuoi As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblThoiHanSuDung As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
