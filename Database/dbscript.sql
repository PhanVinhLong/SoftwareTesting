WHILE EXISTS(select NULL from sys.databases where name='LibraryManagement')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'LibraryManagement') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [LibraryManagement]
END
GO

CREATE DATABASE [LibraryManagement]
GO

USE [LibraryManagement]
GO
/****** Object:  Table [dbo].[tblChiTietPhieuMuon]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuMuon](
	[MaPhieuMuon] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietPhieuTra]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuTra](
	[MaPhieuTra] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
	[MaPhieuMuon] [int] NOT NULL,
	[SoNgayTraTre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocGia]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocGia](
	[MaDocGia] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [datetime2](7) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[NgayLapThe] [datetime2](7) NOT NULL,
	[NgayHetHan] [datetime2](7) NOT NULL,
	[MaLoaiDocGia] [int] NOT NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiDocGia]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiDocGia](
	[MaLoaiDocGia] [int] NOT NULL,
	[TenLoaiDocGia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiNhanVien]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiNhanVien](
	[MaLoaiNhanVien] [int] NOT NULL,
	[TenLoaiNhanVien] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[MatKhau] [nchar](32) NOT NULL,
	[MaLoaiNhanVien] [int] NOT NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuMuon]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuMuon](
	[MaPhieuMuon] [int] NOT NULL,
	[MaDocGia] [nchar](10) NOT NULL,
	[NgayMuon] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuTra]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuTra](
	[MaPhieuTra] [int] NOT NULL,
	[MaDocGia] [nchar](10) NOT NULL,
	[NgayTra] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuTra] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[MaSach] [int] NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[NamXuatBan] [int] NOT NULL,
	[NhaXuatBan] [nvarchar](50) NULL,
	[TriGia] [int] NOT NULL,
	[NgayNhap] [datetime2](7) NOT NULL,
	[MaTrangThai] [int] NOT NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTacGia]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTacGia](
	[MaTacGia] [int] NOT NULL,
	[TenTacGia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTacGiaSach]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTacGiaSach](
	[MaTacGia] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblThamSo]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblThamSo](
	[TuoiToiThieu] [int] NOT NULL,
	[TuoiToiDa] [int] NOT NULL,
	[ThoiHanSuDung] [int] NOT NULL,
	[GioiHanNamXuatBan] [int] NOT NULL,
	[SoLuongTacGia] [int] NOT NULL,
	[SoLuongSachMuonToiDa] [int] NOT NULL,
	[NgayMuonToiDa] [int] NOT NULL,
	[SoLuongTheLoai] [int] NOT NULL,
	[SoLuongLoaiDocGia] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTheLoai]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTheLoai](
	[MaTheLoai] [int] NOT NULL,
	[TenTheLoai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTheLoaiSach]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTheLoaiSach](
	[MaTheLoai] [int] NOT NULL,
	[MaSach] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC,
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTrangThai]    Script Date: 7/3/2018 12:16:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTrangThai](
	[MaTrangThai] [int] NOT NULL,
	[TenTrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblTrangThai] PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (1, 1)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (1, 2)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (2, 4)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (3, 3)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (3, 5)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (4, 6)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (5, 6)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (6, 1)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (6, 2)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (6, 3)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (6, 4)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (6, 5)
INSERT [dbo].[tblChiTietPhieuMuon] ([MaPhieuMuon], [MaSach]) VALUES (6, 6)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (1, 6, 4, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (2, 1, 1, 7)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (2, 2, 1, 7)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (2, 3, 3, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (2, 4, 2, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (2, 5, 3, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (2, 6, 5, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (3, 1, 6, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (3, 2, 6, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (3, 3, 6, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (3, 4, 6, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (3, 5, 6, 0)
INSERT [dbo].[tblChiTietPhieuTra] ([MaPhieuTra], [MaSach], [MaPhieuMuon], [SoNgayTraTre]) VALUES (3, 6, 6, 0)
INSERT [dbo].[tblDocGia] ([MaDocGia], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) VALUES (N'18000001  ', N'Nguyễn Công Minh', CAST(N'1998-06-09T21:04:07.3233333' AS DateTime2), N'Dĩ An, Bình Dương', N'minh123@gmail.com', CAST(N'2018-06-10T21:04:07.3233333' AS DateTime2), CAST(N'2019-06-10T21:04:07.3233333' AS DateTime2), 2)
INSERT [dbo].[tblDocGia] ([MaDocGia], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) VALUES (N'18000002  ', N'Nguyễn Văn Tèo', CAST(N'1998-06-02T11:01:35.2366667' AS DateTime2), N'Hải Châu, Đà Nẵng', N'dlas@yahoo.com', CAST(N'2017-06-12T11:01:35.2400000' AS DateTime2), CAST(N'2017-12-12T11:01:35.2400000' AS DateTime2), 1)
INSERT [dbo].[tblDocGia] ([MaDocGia], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) VALUES (N'18000003  ', N'Trần Công Minh', CAST(N'1998-02-22T11:02:20.6366667' AS DateTime2), N'Bình Định', N'minhas@gmail.com', CAST(N'2015-02-11T11:02:20.6366667' AS DateTime2), CAST(N'2015-08-11T11:02:20.6366667' AS DateTime2), 2)
INSERT [dbo].[tblDocGia] ([MaDocGia], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) VALUES (N'18000004  ', N'Trần Thị Trai', CAST(N'1994-06-11T11:04:17.4700000' AS DateTime2), N'Hệ Mặt Trời', N'sunsee@yahoo.com', CAST(N'2018-06-12T11:04:17.4733333' AS DateTime2), CAST(N'2018-12-12T11:04:17.4733333' AS DateTime2), 1)
INSERT [dbo].[tblDocGia] ([MaDocGia], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) VALUES (N'18000005  ', N'Phan Vĩnh Long', CAST(N'1998-06-24T13:43:48.7966667' AS DateTime2), N'sda', N'ayiu@gm.com', CAST(N'2018-06-25T13:43:48.8000000' AS DateTime2), CAST(N'2018-12-25T13:43:48.8000000' AS DateTime2), 2)
INSERT [dbo].[tblDocGia] ([MaDocGia], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) VALUES (N'18000006  ', N'Trần Thị B', CAST(N'1998-06-25T23:47:19.1133333' AS DateTime2), N'Hà Nội', N'hnb@ds.vn', CAST(N'2018-06-26T23:47:19.1166667' AS DateTime2), CAST(N'2018-12-26T23:47:19.1166667' AS DateTime2), 1)
INSERT [dbo].[tblDocGia] ([MaDocGia], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) VALUES (N'18000007  ', N'Phan Lê Nhật', CAST(N'1998-02-09T00:06:42.9033333' AS DateTime2), N'Thanh Hoá', N'lnpth@gmail.com', CAST(N'2018-06-20T00:06:42.9100000' AS DateTime2), CAST(N'2018-12-27T00:06:42.9100000' AS DateTime2), 2)
INSERT [dbo].[tblDocGia] ([MaDocGia], [HoTen], [NgaySinh], [DiaChi], [Email], [NgayLapThe], [NgayHetHan], [MaLoaiDocGia]) VALUES (N'18000008  ', N'Nguyễn Hoàng', CAST(N'1995-03-18T09:21:33.1600000' AS DateTime2), N'Quận 9, HCM', N'qnhcmnh@gmail.com', CAST(N'2018-06-27T09:21:33.1666667' AS DateTime2), CAST(N'2018-12-27T09:21:33.1666667' AS DateTime2), 1)
INSERT [dbo].[tblLoaiDocGia] ([MaLoaiDocGia], [TenLoaiDocGia]) VALUES (1, N'Học Sinh')
INSERT [dbo].[tblLoaiDocGia] ([MaLoaiDocGia], [TenLoaiDocGia]) VALUES (2, N'Sinh Viên')
INSERT [dbo].[tblLoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (1, N'Quản trị viên')
INSERT [dbo].[tblLoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (2, N'Nhân viên')
INSERT [dbo].[tblLoaiNhanVien] ([MaLoaiNhanVien], [TenLoaiNhanVien]) VALUES (3, N'Chưa xác nhận')
INSERT [dbo].[tblNhanVien] ([TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien]) VALUES (N'admin', N'Phan Vĩnh Long', N'e10adc3949ba59abbe56e057f20f883e', 1)
INSERT [dbo].[tblNhanVien] ([TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien]) VALUES (N'nguoila01', N'Nguyễn Thị B', N'33325728e806105fdf4f9c675b69a61f', 3)
INSERT [dbo].[tblNhanVien] ([TenDangNhap], [HoTen], [MatKhau], [MaLoaiNhanVien]) VALUES (N'nhanvien01', N'Nguyễn Văn A', N'940fd5c028a9b60b8dba28e37f04fb9b', 2)
INSERT [dbo].[tblPhieuMuon] ([MaPhieuMuon], [MaDocGia], [NgayMuon]) VALUES (1, N'18000001  ', CAST(N'2018-06-21T23:36:25.8533333' AS DateTime2))
INSERT [dbo].[tblPhieuMuon] ([MaPhieuMuon], [MaDocGia], [NgayMuon]) VALUES (2, N'18000001  ', CAST(N'2018-07-02T23:37:17.6500000' AS DateTime2))
INSERT [dbo].[tblPhieuMuon] ([MaPhieuMuon], [MaDocGia], [NgayMuon]) VALUES (3, N'18000001  ', CAST(N'2018-07-02T23:37:34.7166667' AS DateTime2))
INSERT [dbo].[tblPhieuMuon] ([MaPhieuMuon], [MaDocGia], [NgayMuon]) VALUES (4, N'18000002  ', CAST(N'2018-07-02T23:40:00.8233333' AS DateTime2))
INSERT [dbo].[tblPhieuMuon] ([MaPhieuMuon], [MaDocGia], [NgayMuon]) VALUES (5, N'18000001  ', CAST(N'2018-07-02T23:40:37.6500000' AS DateTime2))
INSERT [dbo].[tblPhieuMuon] ([MaPhieuMuon], [MaDocGia], [NgayMuon]) VALUES (6, N'18000003  ', CAST(N'2018-07-02T23:42:32.3333333' AS DateTime2))
INSERT [dbo].[tblPhieuTra] ([MaPhieuTra], [MaDocGia], [NgayTra]) VALUES (1, N'18000002  ', CAST(N'2018-07-02T23:40:24.0300000' AS DateTime2))
INSERT [dbo].[tblPhieuTra] ([MaPhieuTra], [MaDocGia], [NgayTra]) VALUES (2, N'18000001  ', CAST(N'2018-07-02T23:41:38.3000000' AS DateTime2))
INSERT [dbo].[tblPhieuTra] ([MaPhieuTra], [MaDocGia], [NgayTra]) VALUES (3, N'18000003  ', CAST(N'2018-07-02T23:48:21.9733333' AS DateTime2))
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai]) VALUES (1, N'Clean Code', 2010, N'Tuổi trẻ', 320000, CAST(N'2018-05-24T21:21:08.4033333' AS DateTime2), 1)
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai]) VALUES (2, N'Khi lỗi thuộc về những vì sao', 2013, N'Kim Đồng', 120000, CAST(N'2018-05-16T15:30:47.5966667' AS DateTime2), 1)
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai]) VALUES (3, N'Tuổi trẻ đáng giá bao nhiêu', 2015, N'Kim Đồng', 120000, CAST(N'2018-05-04T08:43:34.9533333' AS DateTime2), 1)
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai]) VALUES (4, N'Cuộc đời là những chuyến đi', 2015, N'NXB Tổng hợp HCM', 120301, CAST(N'2018-06-03T09:44:29.7800000' AS DateTime2), 1)
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai]) VALUES (5, N'Khám phá sức mạnh bản thân', 2015, N'XNB Tổng hợp HCM', 44000, CAST(N'2018-06-05T09:22:41.0533333' AS DateTime2), 1)
INSERT [dbo].[tblSach] ([MaSach], [TenSach], [NamXuatBan], [NhaXuatBan], [TriGia], [NgayNhap], [MaTrangThai]) VALUES (6, N'Đi', 2016, N'NXB', 12111, CAST(N'2018-07-02T23:38:13.9400000' AS DateTime2), 1)
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (1, N'Mario Puzo')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (2, N'Thomas L. Friedman')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (3, N'Dale Carnegie')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (4, N'Stephen Hawking')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (5, N'Viktor Emil Frankl')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (7, N'Dương Tôn Đảm')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (8, N'Hà Mạnh Linh')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (9, N'Lê Hoàng Tuấn')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (10, N'Phạm Thi Vương')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (11, N'Trần Anh Dũng')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (12, N'Phan Nguyệt Minh')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (13, N'Lê Thanh Trọng')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (14, N'Vũ Thanh Nguyên')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (15, N'Nguyễn Công Hoan')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (16, N'Phan Trung Hiếu')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (17, N'Lê Đình Tuấn')
INSERT [dbo].[tblTacGia] ([MaTacGia], [TenTacGia]) VALUES (18, N'Bảo Trâm')
INSERT [dbo].[tblTacGiaSach] ([MaTacGia], [MaSach]) VALUES (1, 1)
INSERT [dbo].[tblTacGiaSach] ([MaTacGia], [MaSach]) VALUES (1, 2)
INSERT [dbo].[tblTacGiaSach] ([MaTacGia], [MaSach]) VALUES (2, 1)
INSERT [dbo].[tblTacGiaSach] ([MaTacGia], [MaSach]) VALUES (4, 6)
INSERT [dbo].[tblTacGiaSach] ([MaTacGia], [MaSach]) VALUES (5, 4)
INSERT [dbo].[tblTacGiaSach] ([MaTacGia], [MaSach]) VALUES (5, 5)
INSERT [dbo].[tblTacGiaSach] ([MaTacGia], [MaSach]) VALUES (7, 6)
INSERT [dbo].[tblTacGiaSach] ([MaTacGia], [MaSach]) VALUES (17, 3)
INSERT [dbo].[tblThamSo] ([TuoiToiThieu], [TuoiToiDa], [ThoiHanSuDung], [GioiHanNamXuatBan], [SoLuongTacGia], [SoLuongSachMuonToiDa], [NgayMuonToiDa], [SoLuongTheLoai], [SoLuongLoaiDocGia]) VALUES (55, 55, 6, 8, 100, 5, 4, 3, 2)
INSERT [dbo].[tblTheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (1, N'Giáo trình')
INSERT [dbo].[tblTheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (2, N'Trinh thám')
INSERT [dbo].[tblTheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (3, N'Tiểu thuyết')
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (1, 1)
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (1, 5)
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (1, 6)
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (2, 2)
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (2, 3)
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (2, 4)
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (2, 5)
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (3, 2)
INSERT [dbo].[tblTheLoaiSach] ([MaTheLoai], [MaSach]) VALUES (3, 4)
INSERT [dbo].[tblTrangThai] ([MaTrangThai], [TenTrangThai]) VALUES (1, N'Có thể mượn')
INSERT [dbo].[tblTrangThai] ([MaTrangThai], [TenTrangThai]) VALUES (2, N'Đang được mượn')
ALTER TABLE [dbo].[tblChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuMuon_tblPhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[tblPhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuon] CHECK CONSTRAINT [FK_tblChiTietPhieuMuon_tblPhieuMuon]
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuMuon_tblSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tblSach] ([MaSach])
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuon] CHECK CONSTRAINT [FK_tblChiTietPhieuMuon_tblSach]
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuTra_tblPhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[tblPhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra] CHECK CONSTRAINT [FK_tblChiTietPhieuTra_tblPhieuMuon]
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuTra_tblPhieuTra] FOREIGN KEY([MaPhieuTra])
REFERENCES [dbo].[tblPhieuTra] ([MaPhieuTra])
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra] CHECK CONSTRAINT [FK_tblChiTietPhieuTra_tblPhieuTra]
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuTra_tblSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tblSach] ([MaSach])
GO
ALTER TABLE [dbo].[tblChiTietPhieuTra] CHECK CONSTRAINT [FK_tblChiTietPhieuTra_tblSach]
GO
ALTER TABLE [dbo].[tblDocGia]  WITH CHECK ADD  CONSTRAINT [FK_tblDocGia_tblLoaiDocGia] FOREIGN KEY([MaLoaiDocGia])
REFERENCES [dbo].[tblLoaiDocGia] ([MaLoaiDocGia])
GO
ALTER TABLE [dbo].[tblDocGia] CHECK CONSTRAINT [FK_tblDocGia_tblLoaiDocGia]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblLoaiNhanVien] FOREIGN KEY([MaLoaiNhanVien])
REFERENCES [dbo].[tblLoaiNhanVien] ([MaLoaiNhanVien])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblLoaiNhanVien]
GO
ALTER TABLE [dbo].[tblPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuMuon_tblDocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[tblDocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[tblPhieuMuon] CHECK CONSTRAINT [FK_tblPhieuMuon_tblDocGia]
GO
ALTER TABLE [dbo].[tblPhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_tblPhieuTra_tblDocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[tblDocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[tblPhieuTra] CHECK CONSTRAINT [FK_tblPhieuTra_tblDocGia]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblTrangThai] FOREIGN KEY([MaTrangThai])
REFERENCES [dbo].[tblTrangThai] ([MaTrangThai])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblTrangThai]
GO
ALTER TABLE [dbo].[tblTacGiaSach]  WITH CHECK ADD  CONSTRAINT [FK_tblTacGiaSach_tblSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tblSach] ([MaSach])
GO
ALTER TABLE [dbo].[tblTacGiaSach] CHECK CONSTRAINT [FK_tblTacGiaSach_tblSach]
GO
ALTER TABLE [dbo].[tblTacGiaSach]  WITH CHECK ADD  CONSTRAINT [FK_tblTacGiaSach_tblTacGia] FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[tblTacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[tblTacGiaSach] CHECK CONSTRAINT [FK_tblTacGiaSach_tblTacGia]
GO
ALTER TABLE [dbo].[tblTheLoaiSach]  WITH CHECK ADD  CONSTRAINT [FK_tblTheLoaiSach_tblSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[tblSach] ([MaSach])
GO
ALTER TABLE [dbo].[tblTheLoaiSach] CHECK CONSTRAINT [FK_tblTheLoaiSach_tblSach]
GO
ALTER TABLE [dbo].[tblTheLoaiSach]  WITH CHECK ADD  CONSTRAINT [FK_tblTheLoaiSach_tblTheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[tblTheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[tblTheLoaiSach] CHECK CONSTRAINT [FK_tblTheLoaiSach_tblTheLoai]
GO
USE [master]
GO
ALTER DATABASE [LibraryManagement] SET  READ_WRITE 
GO
