<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class xrpTinhHinhMuonSach
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrpTinhHinhMuonSach))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.detailTable = New DevExpress.XtraReports.UI.XRTable()
        Me.detailTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.detailTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.GroupHeader2 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.dateNgayThongKe = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.invoiceInfoTable = New DevExpress.XtraReports.UI.XRTable()
        Me.invoiceInfoTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.dateNgayLap = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrChart1 = New DevExpress.XtraReports.UI.XRChart()
        Me.totalTable = New DevExpress.XtraReports.UI.XRTable()
        Me.totalRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.totalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.txtTotal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.headerTable = New DevExpress.XtraReports.UI.XRTable()
        Me.headerTableRow = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productDesctiptionCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.quantityCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.unitPriceCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.lineTotalCaption = New DevExpress.XtraReports.UI.XRTableCell()
        Me.baseControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.evenDetailStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.oddDetailStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ObjectDataSource1 = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.detailTable})
        Me.Detail.HeightF = 39.37505!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StyleName = "baseControlStyle"
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'detailTable
        '
        Me.detailTable.EvenStyleName = "evenDetailStyle"
        Me.detailTable.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
        Me.detailTable.Name = "detailTable"
        Me.detailTable.OddStyleName = "oddDetailStyle"
        Me.detailTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.detailTableRow2})
        Me.detailTable.SizeF = New System.Drawing.SizeF(729.9996!, 39.37505!)
        Me.detailTable.StyleName = "evenDetailStyle"
        Me.detailTable.StylePriority.UseBorderColor = False
        Me.detailTable.StylePriority.UseBorders = False
        Me.detailTable.StylePriority.UseFont = False
        '
        'detailTableRow2
        '
        Me.detailTableRow2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.detailTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.detailTableCell1, Me.detailTableCell2, Me.detailTableCell5})
        Me.detailTableRow2.Name = "detailTableRow2"
        Me.detailTableRow2.StylePriority.UseBorders = False
        Me.detailTableRow2.Weight = 7.35088441202406R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DataSource.CurrentRowIndex] + 1")})
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "1"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 0.090086808902209117R
        '
        'detailTableCell1
        '
        Me.detailTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TenTheLoai]")})
        Me.detailTableCell1.Name = "detailTableCell1"
        Me.detailTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.detailTableCell1.StylePriority.UsePadding = False
        Me.detailTableCell1.StylePriority.UseTextAlignment = False
        Me.detailTableCell1.Text = "ABC"
        Me.detailTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.detailTableCell1.Weight = 0.46351671823645679R
        '
        'detailTableCell2
        '
        Me.detailTableCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SoLuotMuon]")})
        Me.detailTableCell2.Name = "detailTableCell2"
        Me.detailTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.detailTableCell2.StylePriority.UsePadding = False
        Me.detailTableCell2.StylePriority.UseTextAlignment = False
        Me.detailTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.detailTableCell2.Weight = 0.17156192312586824R
        '
        'detailTableCell5
        '
        Me.detailTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TiLe] + '%'")})
        Me.detailTableCell5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.detailTableCell5.Name = "detailTableCell5"
        Me.detailTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 5, 0, 100.0!)
        Me.detailTableCell5.StylePriority.UseFont = False
        Me.detailTableCell5.StylePriority.UsePadding = False
        Me.detailTableCell5.StylePriority.UseTextAlignment = False
        Me.detailTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.detailTableCell5.Weight = 0.17199467510384831R
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 79.16666!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 48.56139!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.StyleName = "baseControlStyle"
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrLabel1, Me.dateNgayThongKe, Me.XrLabel3, Me.invoiceInfoTable})
        Me.GroupHeader2.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("InvoiceNumber", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail
        Me.GroupHeader2.HeightF = 190.1667!
        Me.GroupHeader2.Level = 1
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.StyleName = "baseControlStyle"
        Me.GroupHeader2.StylePriority.UseBackColor = False
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(9.999986!, 10.00001!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(110.0!, 110.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(178.5908!, 9.999986!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(498.3033!, 53.20832!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = " TÌNH HÌNH MƯỢN SÁCH"
        '
        'dateNgayThongKe
        '
        Me.dateNgayThongKe.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.dateNgayThongKe.LocationFloat = New DevExpress.Utils.PointFloat(569.6359!, 63.20832!)
        Me.dateNgayThongKe.Name = "dateNgayThongKe"
        Me.dateNgayThongKe.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dateNgayThongKe.SizeF = New System.Drawing.SizeF(173.3195!, 53.08332!)
        Me.dateNgayThongKe.StylePriority.UseFont = False
        Me.dateNgayThongKe.Text = "12/2018"
        Me.dateNgayThongKe.TextFormatString = "{0:MM/yyyy}"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(125.7062!, 63.20832!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(443.9297!, 53.08333!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "THEO THỂ LOẠI THÁNG"
        '
        'invoiceInfoTable
        '
        Me.invoiceInfoTable.LocationFloat = New DevExpress.Utils.PointFloat(512.5383!, 130.0!)
        Me.invoiceInfoTable.Name = "invoiceInfoTable"
        Me.invoiceInfoTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.invoiceInfoTableRow3})
        Me.invoiceInfoTable.SizeF = New System.Drawing.SizeF(214.1282!, 27.83333!)
        Me.invoiceInfoTable.StylePriority.UseFont = False
        '
        'invoiceInfoTableRow3
        '
        Me.invoiceInfoTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.dateNgayLap})
        Me.invoiceInfoTableRow3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.invoiceInfoTableRow3.Name = "invoiceInfoTableRow3"
        Me.invoiceInfoTableRow3.StylePriority.UseFont = False
        Me.invoiceInfoTableRow3.Weight = 0.4266795832360003R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "Ngày lập:"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell2.Weight = 1.125101946954864R
        '
        'dateNgayLap
        '
        Me.dateNgayLap.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.dateNgayLap.Name = "dateNgayLap"
        Me.dateNgayLap.StylePriority.UseBackColor = False
        Me.dateNgayLap.StylePriority.UseBorders = False
        Me.dateNgayLap.StylePriority.UseFont = False
        Me.dateNgayLap.StylePriority.UseTextAlignment = False
        Me.dateNgayLap.Text = "28/06/2018"
        Me.dateNgayLap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.dateNgayLap.TextFormatString = "{0:dd/MM/yyyy}"
        Me.dateNgayLap.Weight = 1.1656299433761719R
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrChart1, Me.totalTable})
        Me.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail
        Me.GroupFooter1.HeightF = 432.0683!
        Me.GroupFooter1.KeepTogether = True
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBandExceptLastEntry
        Me.GroupFooter1.StyleName = "baseControlStyle"
        '
        'XrChart1
        '
        Me.XrChart1.BorderColor = System.Drawing.Color.Black
        Me.XrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrChart1.Legend.Name = "Default Legend"
        Me.XrChart1.LocationFloat = New DevExpress.Utils.PointFloat(125.7062!, 53.63692!)
        Me.XrChart1.Name = "XrChart1"
        Me.XrChart1.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
        Me.XrChart1.SizeF = New System.Drawing.SizeF(492.002!, 378.4314!)
        '
        'totalTable
        '
        Me.totalTable.ForeColor = System.Drawing.Color.Black
        Me.totalTable.LocationFloat = New DevExpress.Utils.PointFloat(379.9998!, 15.66747!)
        Me.totalTable.Name = "totalTable"
        Me.totalTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.totalRow})
        Me.totalTable.SizeF = New System.Drawing.SizeF(360.0002!, 37.96946!)
        Me.totalTable.StylePriority.UseForeColor = False
        Me.totalTable.StylePriority.UsePadding = False
        '
        'totalRow
        '
        Me.totalRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.totalCaption, Me.txtTotal})
        Me.totalRow.Name = "totalRow"
        Me.totalRow.Weight = 1.4R
        '
        'totalCaption
        '
        Me.totalCaption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCaption.Multiline = True
        Me.totalCaption.Name = "totalCaption"
        Me.totalCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 0, 0, 0, 100.0!)
        Me.totalCaption.StyleName = "evenDetailStyle"
        Me.totalCaption.StylePriority.UseBackColor = False
        Me.totalCaption.StylePriority.UseBorderColor = False
        Me.totalCaption.StylePriority.UseBorders = False
        Me.totalCaption.StylePriority.UseBorderWidth = False
        Me.totalCaption.StylePriority.UseFont = False
        Me.totalCaption.StylePriority.UseForeColor = False
        Me.totalCaption.StylePriority.UsePadding = False
        Me.totalCaption.StylePriority.UseTextAlignment = False
        Me.totalCaption.Text = "TỔNG SỐ LƯỢT MƯỢN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.totalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.totalCaption.Weight = 1.9254900216914666R
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
        Me.txtTotal.StyleName = "evenDetailStyle"
        Me.txtTotal.StylePriority.UseBackColor = False
        Me.txtTotal.StylePriority.UseBorderColor = False
        Me.txtTotal.StylePriority.UseBorders = False
        Me.txtTotal.StylePriority.UseBorderWidth = False
        Me.txtTotal.StylePriority.UseFont = False
        Me.txtTotal.StylePriority.UseForeColor = False
        Me.txtTotal.StylePriority.UsePadding = False
        Me.txtTotal.StylePriority.UseTextAlignment = False
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.txtTotal.Weight = 1.2245757091354574R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.headerTable})
        Me.GroupHeader1.HeightF = 47.08331!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        Me.GroupHeader1.StyleName = "baseControlStyle"
        '
        'headerTable
        '
        Me.headerTable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerTable.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 0!)
        Me.headerTable.Name = "headerTable"
        Me.headerTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.headerTableRow})
        Me.headerTable.SizeF = New System.Drawing.SizeF(729.9998!, 47.08331!)
        Me.headerTable.StylePriority.UseFont = False
        Me.headerTable.StylePriority.UsePadding = False
        '
        'headerTableRow
        '
        Me.headerTableRow.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.headerTableRow.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productDesctiptionCaption, Me.quantityCaption, Me.unitPriceCaption, Me.lineTotalCaption})
        Me.headerTableRow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.headerTableRow.Name = "headerTableRow"
        Me.headerTableRow.StylePriority.UseBorders = False
        Me.headerTableRow.StylePriority.UseFont = False
        Me.headerTableRow.Weight = 10.719222293551759R
        '
        'productDesctiptionCaption
        '
        Me.productDesctiptionCaption.Name = "productDesctiptionCaption"
        Me.productDesctiptionCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.productDesctiptionCaption.StylePriority.UseBackColor = False
        Me.productDesctiptionCaption.StylePriority.UseFont = False
        Me.productDesctiptionCaption.StylePriority.UseForeColor = False
        Me.productDesctiptionCaption.StylePriority.UsePadding = False
        Me.productDesctiptionCaption.StylePriority.UseTextAlignment = False
        Me.productDesctiptionCaption.Text = "STT"
        Me.productDesctiptionCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.productDesctiptionCaption.Weight = 0.18082970838411455R
        '
        'quantityCaption
        '
        Me.quantityCaption.Name = "quantityCaption"
        Me.quantityCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
        Me.quantityCaption.StylePriority.UseBackColor = False
        Me.quantityCaption.StylePriority.UseFont = False
        Me.quantityCaption.StylePriority.UseForeColor = False
        Me.quantityCaption.StylePriority.UsePadding = False
        Me.quantityCaption.StylePriority.UseTextAlignment = False
        Me.quantityCaption.Text = "TÊN THỂ LOẠI"
        Me.quantityCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.quantityCaption.Weight = 0.93040880134004178R
        '
        'unitPriceCaption
        '
        Me.unitPriceCaption.Name = "unitPriceCaption"
        Me.unitPriceCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.unitPriceCaption.StylePriority.UseBackColor = False
        Me.unitPriceCaption.StylePriority.UseFont = False
        Me.unitPriceCaption.StylePriority.UseForeColor = False
        Me.unitPriceCaption.StylePriority.UsePadding = False
        Me.unitPriceCaption.StylePriority.UseTextAlignment = False
        Me.unitPriceCaption.Text = "SỐ LẦN MƯỢN"
        Me.unitPriceCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.unitPriceCaption.Weight = 0.34437318806277967R
        '
        'lineTotalCaption
        '
        Me.lineTotalCaption.Name = "lineTotalCaption"
        Me.lineTotalCaption.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 5, 0, 0, 100.0!)
        Me.lineTotalCaption.StylePriority.UseBackColor = False
        Me.lineTotalCaption.StylePriority.UseFont = False
        Me.lineTotalCaption.StylePriority.UseForeColor = False
        Me.lineTotalCaption.StylePriority.UsePadding = False
        Me.lineTotalCaption.StylePriority.UseTextAlignment = False
        Me.lineTotalCaption.Text = "TỈ LỆ (%)"
        Me.lineTotalCaption.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.lineTotalCaption.Weight = 0.34524235124525154R
        '
        'baseControlStyle
        '
        Me.baseControlStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.baseControlStyle.Name = "baseControlStyle"
        Me.baseControlStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'evenDetailStyle
        '
        Me.evenDetailStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.evenDetailStyle.Name = "evenDetailStyle"
        Me.evenDetailStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'oddDetailStyle
        '
        Me.oddDetailStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.oddDetailStyle.Name = "oddDetailStyle"
        Me.oddDetailStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'ObjectDataSource1
        '
        Me.ObjectDataSource1.DataSource = GetType(LibraryManagementDTO.TinhHinhMuonSachDTO)
        Me.ObjectDataSource1.Name = "ObjectDataSource1"
        '
        'xrpTinhHinhMuonSach
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader2, Me.GroupFooter1, Me.GroupHeader1})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSource1})
        Me.DataSource = Me.ObjectDataSource1
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 79, 49)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.baseControlStyle, Me.evenDetailStyle, Me.oddDetailStyle})
        Me.Version = "17.2"
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invoiceInfoTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrChart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.headerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents detailTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader2 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents totalTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents totalRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents totalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTotal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents headerTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents headerTableRow As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productDesctiptionCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents quantityCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents unitPriceCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lineTotalCaption As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents baseControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents evenDetailStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents oddDetailStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents detailTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents invoiceInfoTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents invoiceInfoTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents dateNgayLap As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dateNgayThongKe As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrChart1 As DevExpress.XtraReports.UI.XRChart
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ObjectDataSource1 As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
End Class
