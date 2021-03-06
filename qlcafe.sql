USE [QLCafe]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 10/13/2021 7:46:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaSP] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaHD] [int] NOT NULL,
 CONSTRAINT [PK_CTHD] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/13/2021 7:46:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayMua] [date] NULL,
	[TongTien] [int] NOT NULL,
	[DiaChiGiaoHang] [nchar](10) NULL,
	[MaKM] [int] NULL,
	[DaMua] [bit] NOT NULL,
	[UserNameKH] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 10/13/2021 7:46:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKM] [int] IDENTITY(1,1) NOT NULL,
	[TenKM] [nvarchar](50) NOT NULL,
	[NoiDungKM] [nvarchar](max) NOT NULL,
	[GiamGia] [int] NOT NULL,
	[NgayBD] [date] NOT NULL,
	[NgayKT] [date] NOT NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSP]    Script Date: 10/13/2021 7:46:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSP](
	[MaLoaiSP] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[TenLoai] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_LoaiSP] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 10/13/2021 7:46:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[GiaSP] [money] NOT NULL,
	[MaLoaiSP] [int] NOT NULL,
	[HinhAnh] [nvarchar](max) NOT NULL,
	[ThongTinChiTiet] [ntext] NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 10/13/2021 7:46:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[UserNameKH] [varchar](50) NOT NULL,
	[PassWordKH] [varchar](50) NOT NULL,
	[TenKH] [nvarchar](255) NOT NULL,
	[SDT] [int] NOT NULL,
	[PhanQuyen] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoanKH] PRIMARY KEY CLUSTERED 
(
	[UserNameKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (1, 10, 13)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (1, 2, 15)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (1, 1, 18)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (2, 1, 8)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (2, 1, 10)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (2, 10, 12)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (2, 10, 13)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (2, 1, 15)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (2, 12, 17)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (2, 1, 18)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (2, 1, 21)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (3, 1, 10)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (3, 1, 20)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (8, 1, 9)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (8, 3, 14)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (9, 2, 11)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (9, 3, 14)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (9, 12, 16)
INSERT [dbo].[CTHD] ([MaSP], [SoLuong], [MaHD]) VALUES (11, 2, 11)
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (8, CAST(N'2021-10-23' AS Date), 160000, N'bảo uyên  ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (9, CAST(N'2021-10-05' AS Date), 100000, N'bảo uyên  ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (10, CAST(N'2021-10-05' AS Date), 660000, N'23        ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (11, CAST(N'2021-10-05' AS Date), 260000, N'123       ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (12, CAST(N'2021-10-05' AS Date), 1600000, N'sad       ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (13, CAST(N'2021-10-05' AS Date), 3100000, N'sda       ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (14, CAST(N'2021-10-05' AS Date), 450000, N'das       ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (15, CAST(N'2021-10-05' AS Date), 460000, N'sad       ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (16, CAST(N'2021-10-05' AS Date), 1200000, N'dasd      ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (17, CAST(N'2021-10-12' AS Date), 2160000, N'123       ', NULL, 1, N'1')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (18, NULL, 0, NULL, NULL, 0, N'dsada')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (19, NULL, 0, NULL, NULL, 0, N'uyencutephomaique')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (20, CAST(N'2021-10-11' AS Date), 170000, N'Uyên cute ', NULL, 1, N'uyencutephomaique2')
INSERT [dbo].[HoaDon] ([MaHD], [NgayMua], [TongTien], [DiaChiGiaoHang], [MaKM], [DaMua], [UserNameKH]) VALUES (21, NULL, 0, NULL, NULL, 0, N'yusuki')
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[KhuyenMai] ON 

INSERT [dbo].[KhuyenMai] ([MaKM], [TenKM], [NoiDungKM], [GiamGia], [NgayBD], [NgayKT]) VALUES (3, N'Khuyến mãi xuân', N'Khuyến mãi mùa xuân', 10, CAST(N'2020-01-01' AS Date), CAST(N'2020-03-30' AS Date))
INSERT [dbo].[KhuyenMai] ([MaKM], [TenKM], [NoiDungKM], [GiamGia], [NgayBD], [NgayKT]) VALUES (5, N'Khuyến mãi khai trương', N'Khuyến mãi khai trương', 20, CAST(N'2020-06-01' AS Date), CAST(N'2020-06-15' AS Date))
SET IDENTITY_INSERT [dbo].[KhuyenMai] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiSP] ON 

INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai]) VALUES (1, N'Hòa Tan')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai]) VALUES (2, N'Rang Xay')
INSERT [dbo].[LoaiSP] ([MaLoaiSP], [TenLoai]) VALUES (7, N'Hòa Tan 2')
SET IDENTITY_INSERT [dbo].[LoaiSP] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (1, N'TheCoffeHouse1', 150000.0000, 2, N'RangXay1.jpg', N'111 Loại cafe tới từ The Coffee Houseeeeeeeeeeeeeeeeeeee')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (2, N'TheCoffeHouse2', 180000.0000, 2, N'RangXay2.jpg', N'1 Loại cafe tới từ The Coffee House')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (3, N'HighLand3', 170000.0000, 1, N'RangXay7.jpg', N'1 Loại cafe tới từ HighLand')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (4, N'HighLand4', 180000.0000, 2, N'RangXay4.jpg', N'1 Loại cafe tới từ HighLand')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (5, N'HighLand5', 190000.0000, 2, N'RangXay5.jpg', N'1 Loại cafe tới từ HighLand')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (6, N'HighLand6', 200000.0000, 2, N'RangXay6.jpg', N'1 Loại cafe tới từ HighLand')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (7, N'HighLand7', 210000.0000, 2, N'RangXay7.jpg', N'1 Loại cafe tới từ HighLand')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (8, N'CafeSua1', 50000.0000, 1, N'HoaTan1.jpg', N'1 loại cafe sữa từ hãng gì đấy không biết')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (9, N'Espresso', 100000.0000, 1, N'HoaTan2.jpg', N'1 loại cafe espresso từ hãng gì đấy không biết')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (10, N'CafeSua2', 70000.0000, 1, N'HoaTan3.jpg', N'1 loại cafe sữa từ hãng HighLand')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (11, N'CafeDen1', 30000.0000, 1, N'HoaTan4.jpg', N'1 loại cafe đen từ hãng HighLand')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (12, N'CafeSua3', 80000.0000, 1, N'HoaTan5.jpg', N'1 Loại cafe tới từ The Coffee House')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (15, N'NEwSP2', 222222222.0000, 1, N'HoaTan2.jpg', N'hòa tann tan tan')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (16, N'HighLand12', 20000.0000, 2, N'HoaTan3.jpg', N'nothing to say')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (17, N'HighLand13', 13.0000, 1, N'HoaTan3.jpg', N'sss')
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [GiaSP], [MaLoaiSP], [HinhAnh], [ThongTinChiTiet]) VALUES (18, N'HighLand14', 14.0000, 2, N'HoaTan2.jpg', N'HighLand14')
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
INSERT [dbo].[TaiKhoan] ([UserNameKH], [PassWordKH], [TenKH], [SDT], [PhanQuyen]) VALUES (N'1', N'c4ca4238a0b923820dcc509a6f75849b', N'test nào', 4444, 0)
INSERT [dbo].[TaiKhoan] ([UserNameKH], [PassWordKH], [TenKH], [SDT], [PhanQuyen]) VALUES (N'2', N'c4ca4238a0b923820dcc509a6f75849b', N'2', 2, 1)
INSERT [dbo].[TaiKhoan] ([UserNameKH], [PassWordKH], [TenKH], [SDT], [PhanQuyen]) VALUES (N'dsada', N'c4ca4238a0b923820dcc509a6f75849b', N'dsadas', 23123, 0)
INSERT [dbo].[TaiKhoan] ([UserNameKH], [PassWordKH], [TenKH], [SDT], [PhanQuyen]) VALUES (N'uyencutephomaique', N'14a490bf8eee2e7781a9c7986ce06fbe', N'Uyên cute phô mai que', 999, 0)
INSERT [dbo].[TaiKhoan] ([UserNameKH], [PassWordKH], [TenKH], [SDT], [PhanQuyen]) VALUES (N'uyencutephomaique2', N'b3ec19455dc4cabfb71953dd0674b86d', N'Uyên cute phô mai que', 99999, 0)
INSERT [dbo].[TaiKhoan] ([UserNameKH], [PassWordKH], [TenKH], [SDT], [PhanQuyen]) VALUES (N'yusuki', N'c4ca4238a0b923820dcc509a6f75849b', N'yusuki', 88, 1)
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HoaDon]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhuyenMai] FOREIGN KEY([MaKM])
REFERENCES [dbo].[KhuyenMai] ([MaKM])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhuyenMai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_TaiKhoanKH] FOREIGN KEY([UserNameKH])
REFERENCES [dbo].[TaiKhoan] ([UserNameKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_TaiKhoanKH]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSP] FOREIGN KEY([MaLoaiSP])
REFERENCES [dbo].[LoaiSP] ([MaLoaiSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSP]
GO
