<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucThemTheLoai
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTenTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.txtMaTheLoai = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThemVaDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.lblCanhBao = New DevExpress.XtraEditors.LabelControl()
        Me.lblGioiHanSoLuong = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTenTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaTheLoai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.lblCanhBao)
        Me.PanelControl1.Controls.Add(Me.lblGioiHanSoLuong)
        Me.PanelControl1.Location = New System.Drawing.Point(19, 13)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(438, 150)
        Me.PanelControl1.TabIndex = 9
        '
        'txtTenTheLoai
        '
        Me.txtTenTheLoai.Location = New System.Drawing.Point(129, 65)
        Me.txtTenTheLoai.Name = "txtTenTheLoai"
        Me.txtTenTheLoai.Size = New System.Drawing.Size(135, 20)
        Me.txtTenTheLoai.TabIndex = 3
        '
        'txtMaTheLoai
        '
        Me.txtMaTheLoai.Enabled = False
        Me.txtMaTheLoai.Location = New System.Drawing.Point(129, 36)
        Me.txtMaTheLoai.Name = "txtMaTheLoai"
        Me.txtMaTheLoai.Size = New System.Drawing.Size(135, 20)
        Me.txtMaTheLoai.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(24, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Tên thể loại sách"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Mã thể loại sách"
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnDong.ImageOptions.ImageUri.Uri = "Cancel;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(12, 6)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(92, 23)
        Me.btnDong.TabIndex = 14
        Me.btnDong.Text = "Đóng"
        '
        'btnThemVaDong
        '
        Me.btnThemVaDong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnThemVaDong.ImageOptions.ImageUri.Uri = "Last;Size16x16;Office2013"
        Me.btnThemVaDong.Location = New System.Drawing.Point(12, 46)
        Me.btnThemVaDong.Name = "btnThemVaDong"
        Me.btnThemVaDong.Size = New System.Drawing.Size(92, 32)
        Me.btnThemVaDong.TabIndex = 13
        Me.btnThemVaDong.Text = "Thêm" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "và Đóng"
        '
        'btnThem
        '
        Me.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnThem.ImageOptions.ImageUri.Uri = "Add;Size16x16;Office2013"
        Me.btnThem.Location = New System.Drawing.Point(12, 94)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(92, 23)
        Me.btnThem.TabIndex = 12
        Me.btnThem.Text = "Thêm"
        '
        'lblCanhBao
        '
        Me.lblCanhBao.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblCanhBao.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lblCanhBao.Appearance.Options.UseFont = True
        Me.lblCanhBao.Appearance.Options.UseForeColor = True
        Me.lblCanhBao.Location = New System.Drawing.Point(27, 128)
        Me.lblCanhBao.Name = "lblCanhBao"
        Me.lblCanhBao.Size = New System.Drawing.Size(181, 13)
        Me.lblCanhBao.TabIndex = 11
        Me.lblCanhBao.Text = "* Số lượng Thể loại sách đã đạt tối đa"
        Me.lblCanhBao.Visible = False
        '
        'lblGioiHanSoLuong
        '
        Me.lblGioiHanSoLuong.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblGioiHanSoLuong.Appearance.ForeColor = System.Drawing.Color.Gray
        Me.lblGioiHanSoLuong.Appearance.Options.UseFont = True
        Me.lblGioiHanSoLuong.Appearance.Options.UseForeColor = True
        Me.lblGioiHanSoLuong.Location = New System.Drawing.Point(27, 112)
        Me.lblGioiHanSoLuong.Name = "lblGioiHanSoLuong"
        Me.lblGioiHanSoLuong.Size = New System.Drawing.Size(147, 13)
        Me.lblGioiHanSoLuong.TabIndex = 10
        Me.lblGioiHanSoLuong.Text = "* Số Thể loại sách/ Tối đa: X/Y"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnDong)
        Me.PanelControl2.Controls.Add(Me.btnThemVaDong)
        Me.PanelControl2.Controls.Add(Me.btnThem)
        Me.PanelControl2.Location = New System.Drawing.Point(307, 10)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(117, 131)
        Me.PanelControl2.TabIndex = 15
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtTenTheLoai)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtMaTheLoai)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 10)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(287, 97)
        Me.GroupControl1.TabIndex = 16
        Me.GroupControl1.Text = "Chi tiết thể loại"
        '
        'ucThemTheLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ucThemTheLoai"
        Me.Size = New System.Drawing.Size(478, 178)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTenTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaTheLoai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTenTheLoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMaTheLoai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThemVaDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCanhBao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblGioiHanSoLuong As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
