<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucQuanLyTacGia
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
        Me.grcDanhSachTacGia = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachTacGia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtTenTacGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaTacGia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnTaiLai = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.grcDanhSachTacGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachTacGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grcDanhSachTacGia
        '
        Me.grcDanhSachTacGia.Location = New System.Drawing.Point(23, 22)
        Me.grcDanhSachTacGia.MainView = Me.grvDanhSachTacGia
        Me.grcDanhSachTacGia.Name = "grcDanhSachTacGia"
        Me.grcDanhSachTacGia.Size = New System.Drawing.Size(289, 175)
        Me.grcDanhSachTacGia.TabIndex = 6
        Me.grcDanhSachTacGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachTacGia})
        '
        'grvDanhSachTacGia
        '
        Me.grvDanhSachTacGia.GridControl = Me.grcDanhSachTacGia
        Me.grvDanhSachTacGia.Name = "grvDanhSachTacGia"
        '
        'txtTenTacGia
        '
        Me.txtTenTacGia.Location = New System.Drawing.Point(106, 64)
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.Size = New System.Drawing.Size(155, 20)
        Me.txtTenTacGia.TabIndex = 3
        '
        'txtMaTacGia
        '
        Me.txtMaTacGia.Enabled = False
        Me.txtMaTacGia.Location = New System.Drawing.Point(106, 33)
        Me.txtMaTacGia.Name = "txtMaTacGia"
        Me.txtMaTacGia.Size = New System.Drawing.Size(155, 20)
        Me.txtMaTacGia.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên tác giả"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(18, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã tác giả"
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(159, 43)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(102, 23)
        Me.btnDong.TabIndex = 11
        Me.btnDong.Text = "Đóng"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnXoa.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnXoa.Location = New System.Drawing.Point(159, 9)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(102, 23)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "Xoá"
        '
        'btnCapNhat
        '
        Me.btnCapNhat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCapNhat.ImageOptions.ImageUri.Uri = "CustomizeGrid;Size16x16;Office2013"
        Me.btnCapNhat.Location = New System.Drawing.Point(22, 43)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(102, 23)
        Me.btnCapNhat.TabIndex = 9
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnTaiLai
        '
        Me.btnTaiLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnTaiLai.ImageOptions.ImageUri.Uri = "Reset;Size16x16;Office2013"
        Me.btnTaiLai.Location = New System.Drawing.Point(22, 9)
        Me.btnTaiLai.Name = "btnTaiLai"
        Me.btnTaiLai.Size = New System.Drawing.Size(102, 23)
        Me.btnTaiLai.TabIndex = 8
        Me.btnTaiLai.Text = "Tải lại"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnCapNhat)
        Me.PanelControl2.Controls.Add(Me.btnTaiLai)
        Me.PanelControl2.Controls.Add(Me.btnXoa)
        Me.PanelControl2.Controls.Add(Me.btnDong)
        Me.PanelControl2.Location = New System.Drawing.Point(318, 22)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(281, 77)
        Me.PanelControl2.TabIndex = 12
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtTenTacGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtMaTacGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(318, 105)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(281, 92)
        Me.GroupControl1.TabIndex = 13
        Me.GroupControl1.Text = "Thông tin tác giả"
        '
        'ucQuanLyTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.grcDanhSachTacGia)
        Me.Name = "ucQuanLyTacGia"
        Me.Size = New System.Drawing.Size(624, 220)
        CType(Me.grcDanhSachTacGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachTacGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grcDanhSachTacGia As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachTacGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtTenTacGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaTacGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTaiLai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
