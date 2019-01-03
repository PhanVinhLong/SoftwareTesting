<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThemTacGia
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
        Me.lblGioiHanSoLuong = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTenTacGia = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaTacGia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTenTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaTacGia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(17, 8)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(94, 23)
        Me.btnDong.TabIndex = 11
        Me.btnDong.Text = "Đóng"
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnThemVaDong.ImageOptions.ImageUri.Uri = "Last;Size16x16;Office2013"
        Me.btnThemVaDong.Location = New System.Drawing.Point(17, 50)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(94, 30)
        Me.btnThemVaDong.TabIndex = 10
        Me.btnThemVaDong.Text = "Thêm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "và Đóng"
        '
        'btnThem
        '
        Me.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnThem.ImageOptions.ImageUri.Uri = "Add;Size16x16;Office2013"
        Me.btnThem.Location = New System.Drawing.Point(17, 100)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(94, 23)
        Me.btnThem.TabIndex = 9
        Me.btnThem.Text = "Thêm"
        '
        'lblCanhBao
        '
        Me.lblCanhBao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblCanhBao.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCanhBao.Appearance.Options.UseFont = True
        Me.lblCanhBao.Appearance.Options.UseForeColor = True
        Me.lblCanhBao.Location = New System.Drawing.Point(14, 131)
        Me.lblCanhBao.Name = "lblCanhBao"
        Me.lblCanhBao.Size = New System.Drawing.Size(153, 13)
        Me.lblCanhBao.TabIndex = 8
        Me.lblCanhBao.Text = "* Số lượng Tác giả đã đạt tối đa"
        Me.lblCanhBao.Visible = False
        '
        'lblGioiHanSoLuong
        '
        Me.lblGioiHanSoLuong.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanSoLuong.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanSoLuong.Appearance.Options.UseFont = True
        Me.lblGioiHanSoLuong.Appearance.Options.UseForeColor = True
        Me.lblGioiHanSoLuong.Location = New System.Drawing.Point(14, 116)
        Me.lblGioiHanSoLuong.Name = "lblGioiHanSoLuong"
        Me.lblGioiHanSoLuong.Size = New System.Drawing.Size(117, 13)
        Me.lblGioiHanSoLuong.TabIndex = 7
        Me.lblGioiHanSoLuong.Text = "* Số tác giả/ Tối đa: X/Y"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnThem)
        Me.PanelControl1.Controls.Add(Me.btnDong)
        Me.PanelControl1.Controls.Add(Me.btnThemVaDong)
        Me.PanelControl1.Location = New System.Drawing.Point(322, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(127, 132)
        Me.PanelControl1.TabIndex = 6
        '
        'txtTenTacGia
        '
        Me.txtTenTacGia.Location = New System.Drawing.Point(115, 67)
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.Size = New System.Drawing.Size(159, 20)
        Me.txtTenTacGia.TabIndex = 3
        '
        'txtMaTacGia
        '
        Me.txtMaTacGia.Enabled = False
        Me.txtMaTacGia.Location = New System.Drawing.Point(115, 39)
        Me.txtMaTacGia.Name = "txtMaTacGia"
        Me.txtMaTacGia.Size = New System.Drawing.Size(159, 20)
        Me.txtMaTacGia.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(20, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên tác giả"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(20, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã tác giả"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtTenTacGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtMaTacGia)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(302, 98)
        Me.GroupControl1.TabIndex = 12
        Me.GroupControl1.Text = "Chi tiết tác giả"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.lblGioiHanSoLuong)
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Controls.Add(Me.lblCanhBao)
        Me.PanelControl2.Location = New System.Drawing.Point(18, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(463, 154)
        Me.PanelControl2.TabIndex = 13
        '
        'ucThemTacGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl2)
        Me.Name = "ucThemTacGia"
        Me.Size = New System.Drawing.Size(501, 182)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.txtTenTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaTacGia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCanhBao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGioiHanSoLuong As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTenTacGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaTacGia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
End Class
