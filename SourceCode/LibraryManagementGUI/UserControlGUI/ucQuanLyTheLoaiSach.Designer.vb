<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucQuanLyTheLoaiSach
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
        Me.grcDanhSachTheLoai = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachTheLoai = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCapNhat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.txtMaTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.txtTenTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.grcDanhSachTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachTheLoai, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtMaTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grcDanhSachTheLoai
        '
        Me.grcDanhSachTheLoai.Location = New System.Drawing.Point(23, 21)
        Me.grcDanhSachTheLoai.MainView = Me.grvDanhSachTheLoai
        Me.grcDanhSachTheLoai.Name = "grcDanhSachTheLoai"
        Me.grcDanhSachTheLoai.Size = New System.Drawing.Size(264, 173)
        Me.grcDanhSachTheLoai.TabIndex = 6
        Me.grcDanhSachTheLoai.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachTheLoai})
        '
        'grvDanhSachTheLoai
        '
        Me.grvDanhSachTheLoai.GridControl = Me.grcDanhSachTheLoai
        Me.grvDanhSachTheLoai.Name = "grvDanhSachTheLoai"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnCapNhat)
        Me.PanelControl1.Controls.Add(Me.btnXoa)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Location = New System.Drawing.Point(297, 21)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(254, 71)
        Me.PanelControl1.TabIndex = 7
        '
        'btnCapNhat
        '
        Me.btnCapNhat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCapNhat.ImageOptions.ImageUri.Uri = "CustomizeGrid;Size16x16;Office2013"
        Me.btnCapNhat.Location = New System.Drawing.Point(18, 19)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(100, 32)
        Me.btnCapNhat.TabIndex = 9
        Me.btnCapNhat.Text = "Cập nhật"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.ForeColor = System.Drawing.Color.Red
        Me.btnXoa.Appearance.Options.UseForeColor = True
        Me.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnXoa.ImageOptions.ImageUri.Uri = "Delete;Size16x16;Office2013"
        Me.btnXoa.Location = New System.Drawing.Point(140, 39)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(100, 23)
        Me.btnXoa.TabIndex = 10
        Me.btnXoa.Text = "Xoá"
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(140, 8)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(100, 23)
        Me.btnDong.TabIndex = 11
        Me.btnDong.Text = "Đóng"
        '
        'txtMaTheLoai
        '
        Me.txtMaTheLoai.Enabled = False
        Me.txtMaTheLoai.Location = New System.Drawing.Point(111, 36)
        Me.txtMaTheLoai.Name = "txtMaTheLoai"
        Me.txtMaTheLoai.Size = New System.Drawing.Size(125, 20)
        Me.txtMaTheLoai.TabIndex = 4
        '
        'txtTenTheLoai
        '
        Me.txtTenTheLoai.Location = New System.Drawing.Point(111, 66)
        Me.txtTenTheLoai.Name = "txtTenTheLoai"
        Me.txtTenTheLoai.Size = New System.Drawing.Size(125, 20)
        Me.txtTenTheLoai.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên thể loại"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(22, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã thể loại"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtMaTheLoai)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtTenTheLoai)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(297, 98)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(254, 96)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Chi tiết thể loại"
        '
        'ucQuanLyTheLoaiSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grcDanhSachTheLoai)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ucQuanLyTheLoaiSach"
        Me.Size = New System.Drawing.Size(574, 216)
        CType(Me.grcDanhSachTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachTheLoai, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtMaTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grcDanhSachTheLoai As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachTheLoai As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtMaTheLoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTenTheLoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCapNhat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
