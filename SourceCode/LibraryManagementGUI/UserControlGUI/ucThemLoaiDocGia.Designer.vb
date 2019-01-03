<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThemLoaiDocGia
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
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThemVaDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCanhBao = New DevExpress.XtraEditors.LabelControl()
        Me.lblGioiHanLoaiDocGia = New DevExpress.XtraEditors.LabelControl()
        Me.txtTenLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaLoaiDocGia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(10, 7)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(84, 23)
        Me.btnDong.TabIndex = 14
        Me.btnDong.Text = "Đóng"
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.ImageOptions.ImageUri.Uri = "Last;Size16x16;Office2013"
        Me.btnThemVaDong.Location = New System.Drawing.Point(10, 44)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(84, 32)
        Me.btnThemVaDong.TabIndex = 13
        Me.btnThemVaDong.Text = "Thêm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "và Đóng"
        '
        'btnThem
        '
        Me.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnThem.ImageOptions.ImageUri.Uri = "Add;Size16x16;Office2013"
        Me.btnThem.Location = New System.Drawing.Point(10, 91)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(84, 23)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm"
        '
        'lblCanhBao
        '
        Me.lblCanhBao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblCanhBao.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCanhBao.Appearance.Options.UseFont = True
        Me.lblCanhBao.Appearance.Options.UseForeColor = True
        Me.lblCanhBao.Location = New System.Drawing.Point(36, 124)
        Me.lblCanhBao.Name = "lblCanhBao"
        Me.lblCanhBao.Size = New System.Drawing.Size(172, 13)
        Me.lblCanhBao.TabIndex = 11
        Me.lblCanhBao.Text = "* Số lượng loại độc giả đã đạt tối đa"
        Me.lblCanhBao.Visible = False
        '
        'lblGioiHanLoaiDocGia
        '
        Me.lblGioiHanLoaiDocGia.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanLoaiDocGia.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanLoaiDocGia.Appearance.Options.UseFont = True
        Me.lblGioiHanLoaiDocGia.Appearance.Options.UseForeColor = True
        Me.lblGioiHanLoaiDocGia.Location = New System.Drawing.Point(36, 106)
        Me.lblGioiHanLoaiDocGia.Name = "lblGioiHanLoaiDocGia"
        Me.lblGioiHanLoaiDocGia.Size = New System.Drawing.Size(141, 13)
        Me.lblGioiHanLoaiDocGia.TabIndex = 10
        Me.lblGioiHanLoaiDocGia.Text = "* Số Loại độc giả/ Tối đa: X/Y"
        '
        'txtTenLoaiDocGia
        '
        Me.txtTenLoaiDocGia.Location = New System.Drawing.Point(133, 61)
        Me.txtTenLoaiDocGia.Name = "txtTenLoaiDocGia"
        Me.txtTenLoaiDocGia.Size = New System.Drawing.Size(139, 20)
        Me.txtTenLoaiDocGia.TabIndex = 3
        '
        'txtMaLoaiDocGia
        '
        Me.txtMaLoaiDocGia.Enabled = False
        Me.txtMaLoaiDocGia.Location = New System.Drawing.Point(133, 33)
        Me.txtMaLoaiDocGia.Name = "txtMaLoaiDocGia"
        Me.txtMaLoaiDocGia.Size = New System.Drawing.Size(139, 20)
        Me.txtMaLoaiDocGia.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(29, 64)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên loại độc giả"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(29, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã loại độc giả"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnDong)
        Me.PanelControl2.Controls.Add(Me.btnThem)
        Me.PanelControl2.Controls.Add(Me.btnThemVaDong)
        Me.PanelControl2.Location = New System.Drawing.Point(328, 8)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(104, 123)
        Me.PanelControl2.TabIndex = 15
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl1)
        Me.PanelControl3.Controls.Add(Me.PanelControl2)
        Me.PanelControl3.Controls.Add(Me.lblGioiHanLoaiDocGia)
        Me.PanelControl3.Controls.Add(Me.lblCanhBao)
        Me.PanelControl3.Location = New System.Drawing.Point(15, 13)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(444, 140)
        Me.PanelControl3.TabIndex = 16
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtTenLoaiDocGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtMaLoaiDocGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(11, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(311, 90)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Chi tiết độc giả"
        '
        'ucThemLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl3)
        Me.Name = "ucThemLoaiDocGia"
        Me.Size = New System.Drawing.Size(480, 166)
        CType(Me.txtTenLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaLoaiDocGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCanhBao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGioiHanLoaiDocGia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTenLoaiDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaLoaiDocGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
