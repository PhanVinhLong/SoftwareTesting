<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucThongKeTraSachTre
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucThongKeTraSachTre))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dteThoiGian = New DevExpress.XtraEditors.DateEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.btnDong = New DevExpress.XtraEditors.SimpleButton()
        Me.btnIn = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTimKiem = New DevExpress.XtraEditors.TextEdit()
        Me.grcDanhSachThongKe = New DevExpress.XtraGrid.GridControl()
        Me.grvDanhSachThongKe = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.TinhHinhMuonSachDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dteThoiGian.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteThoiGian.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grcDanhSachThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDanhSachThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TinhHinhMuonSachDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Image = CType(resources.GetObject("LabelControl1.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl1.Appearance.Options.UseImage = True
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(218, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(109, 20)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "Thời gian thống kê"
        '
        'dteThoiGian
        '
        Me.dteThoiGian.EditValue = Nothing
        Me.dteThoiGian.Location = New System.Drawing.Point(331, 9)
        Me.dteThoiGian.Name = "dteThoiGian"
        Me.dteThoiGian.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteThoiGian.Size = New System.Drawing.Size(91, 20)
        Me.dteThoiGian.TabIndex = 25
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.btnDong)
        Me.PanelControl2.Controls.Add(Me.btnIn)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.dteThoiGian)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.txtTimKiem)
        Me.PanelControl2.Location = New System.Drawing.Point(20, 15)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(661, 36)
        Me.PanelControl2.TabIndex = 38
        '
        'btnDong
        '
        Me.btnDong.ImageOptions.ImageUri.Uri = "Close;Size16x16;Office2013"
        Me.btnDong.Location = New System.Drawing.Point(583, 7)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(61, 23)
        Me.btnDong.TabIndex = 28
        Me.btnDong.Text = "Đóng"
        '
        'btnIn
        '
        Me.btnIn.ImageOptions.ImageUri.Uri = "Print;Size16x16;Office2013"
        Me.btnIn.Location = New System.Drawing.Point(485, 7)
        Me.btnIn.Name = "btnIn"
        Me.btnIn.Size = New System.Drawing.Size(91, 23)
        Me.btnIn.TabIndex = 27
        Me.btnIn.Text = "In thống kê"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Image = CType(resources.GetObject("LabelControl10.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl10.Appearance.Options.UseImage = True
        Me.LabelControl10.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl10.Location = New System.Drawing.Point(3, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(61, 20)
        Me.LabelControl10.TabIndex = 24
        Me.LabelControl10.Text = "Tìm kiếm"
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(68, 9)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(87, 20)
        Me.txtTimKiem.TabIndex = 18
        '
        'grcDanhSachThongKe
        '
        Me.grcDanhSachThongKe.Location = New System.Drawing.Point(20, 57)
        Me.grcDanhSachThongKe.MainView = Me.grvDanhSachThongKe
        Me.grcDanhSachThongKe.Name = "grcDanhSachThongKe"
        Me.grcDanhSachThongKe.Size = New System.Drawing.Size(661, 135)
        Me.grcDanhSachThongKe.TabIndex = 37
        Me.grcDanhSachThongKe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvDanhSachThongKe})
        '
        'grvDanhSachThongKe
        '
        Me.grvDanhSachThongKe.GridControl = Me.grcDanhSachThongKe
        Me.grvDanhSachThongKe.Name = "grvDanhSachThongKe"
        '
        'ChartControl1
        '
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(20, 198)
        Me.ChartControl1.Name = "ChartControl1"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.ChartControl1.Size = New System.Drawing.Size(661, 395)
        Me.ChartControl1.TabIndex = 39
        '
        'TinhHinhMuonSachDTOBindingSource
        '
        Me.TinhHinhMuonSachDTOBindingSource.DataSource = GetType(LibraryManagementDTO.TinhHinhMuonSachDTO)
        '
        'ucThongKeTraSachTre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.grcDanhSachThongKe)
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "ucThongKeTraSachTre"
        Me.Size = New System.Drawing.Size(710, 615)
        CType(Me.dteThoiGian.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteThoiGian.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTimKiem.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grcDanhSachThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDanhSachThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TinhHinhMuonSachDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteThoiGian As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnDong As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTimKiem As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grcDanhSachThongKe As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDanhSachThongKe As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents TinhHinhMuonSachDTOBindingSource As BindingSource
End Class
