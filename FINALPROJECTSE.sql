USE [FINALPROJECTSE]
GO
/****** Object:  Table [dbo].[tb_Chungtu]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Chungtu](
	[ID] [nvarchar](50) NULL,
	[LoaiCT] [nvarchar](50) NULL,
	[SCT] [nvarchar](50) NULL,
	[Ngaynhap] [date] NULL,
	[SCT2] [nvarchar](50) NULL,
	[Ngayxuat] [date] NULL,
	[MaDV1] [nvarchar](50) NULL,
	[MaDV2] [nvarchar](50) NULL,
	[MaCT] [nvarchar](50) NULL,
	[trangthai] [nvarchar](50) NULL,
	[ghichu] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[tongtien] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Chungtuchitiet]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Chungtuchitiet](
	[IDChitiet] [nvarchar](50) NULL,
	[IDChungtu] [nvarchar](50) NULL,
	[IDSP] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[dongia] [int] NULL,
	[nhacungcap] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Congty]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Congty](
	[MaCT] [nchar](10) NOT NULL,
	[TenCT] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Donvi]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Donvi](
	[MADV] [nchar](10) NOT NULL,
	[tenDV] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[maCT] [nchar](10) NULL,
	[kho] [bit] NULL,
	[kyhieu] [nchar](10) NULL,
 CONSTRAINT [PK_tb_Donvi] PRIMARY KEY CLUSTERED 
(
	[MADV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_DVT]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_DVT](
	[ID] [nchar](10) NULL,
	[ten] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Giohang]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Giohang](
	[IDGH] [int] NULL,
	[MaTaiKhoan] [nvarchar](50) NULL,
	[MaSanPham] [nvarchar](50) NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[Soluong] [int] NULL,
	[gia] [int] NULL,
	[tongtien] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Nhacungcap]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Nhacungcap](
	[MANCC] [nvarchar](50) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
	[dienthoai] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Nhacungcap] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ProductPage]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ProductPage](
	[ProductID] [nvarchar](50) NULL,
	[ProductName] [nvarchar](50) NULL,
	[price] [int] NULL,
	[discount] [int] NULL,
	[xuatxu] [nvarchar](50) NULL,
	[thumb] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Sanpham]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Sanpham](
	[MaSP] [nvarchar](50) NULL,
	[TenSP] [nvarchar](50) NULL,
	[donvitinh] [int] NULL,
	[dongia] [int] NULL,
	[nhacungcap] [nvarchar](50) NULL,
	[xuatxu] [nvarchar](50) NULL,
	[thumb] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Xuatxu]    Script Date: 5/7/2023 12:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Xuatxu](
	[MaXX] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT16042022001', N'NMH', N'NM20220416001', CAST(N'2022-04-16' AS Date), NULL, NULL, N'KCT001', NULL, N'CNMN', N'Đang vận chuyển', N'Nhập kho quý 4', 10, 245000000)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT16042022002', N'NMH', N'NM20220416002', CAST(N'2022-04-16' AS Date), NULL, NULL, N'CSSG001   ', NULL, N'CNMN', N'Đã đến', N'Nhập kho quý 4', 20, 300000000)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT10032022001', N'NMH', N'NM20220310001', CAST(N'2022-03-10' AS Date), NULL, NULL, N'KCT002', NULL, N'CNMB', N'Đã vận chuyển', N'Nhập kho quý 3', 15, 260000000)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT202305177000', N'NMH', N'NM202305177000', CAST(N'2023-05-17' AS Date), N'', CAST(N'1900-01-01' AS Date), N'KCT002    ', N'', N'CNMN      ', N'Đã đến', N'Nhập kho mới', 6, 179000000)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT202303064086', N'NMH', N'NM202303064086', CAST(N'2023-03-06' AS Date), N'', CAST(N'1900-01-01' AS Date), N'CSSG001   ', N'', N'CNMN      ', N'Đã đến', N'Nhập kho quý 3', 6, 207000000)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT20230507/XMH/372', N'XMH', N'', CAST(N'1900-01-01' AS Date), N'XMH20230507372', CAST(N'2023-05-07' AS Date), N'', N'KCT001', N'CNMN      ', N'Đang vận chuyển', N'', 10, 294000000)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT20230506/XMH/504', N'XMH', N'', CAST(N'1900-01-01' AS Date), N'XMH20230506504', CAST(N'2023-05-06' AS Date), N'', N'KCT002', N'CNMB      ', N'Đang vận chuyển', N'', 8, 201000000)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT20230507/XMH/150', N'XMH', N'', CAST(N'1900-01-01' AS Date), N'XMH20230507150', CAST(N'2023-05-07' AS Date), N'', N'CSSG001', N'CNMB      ', N'Đã đến', N'', 7, 169000000)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT20230507/XMH/562', N'XMH', N'', CAST(N'1900-01-01' AS Date), N'XMH20230507562', CAST(N'2023-05-07' AS Date), N'', N'KCT002', N'CNMN      ', N'Đang vận chuyển', N'', 6, 211252484)
INSERT [dbo].[tb_Chungtu] ([ID], [LoaiCT], [SCT], [Ngaynhap], [SCT2], [Ngayxuat], [MaDV1], [MaDV2], [MaCT], [trangthai], [ghichu], [soluong], [tongtien]) VALUES (N'CT202305068557', N'NMH', N'NM202305068557', CAST(N'2023-05-06' AS Date), N'', CAST(N'1900-01-01' AS Date), N'CSSG001   ', N'', N'CNMB      ', N'Đã đến', N'Nhập kho quý 5', 12, 429000000)
GO
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20220416/NMH/001', N'NM20220416001', N'SSGF001', 4, 128000000, N'Công ty TNHH Hữu Phát')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20220416/NMH/001', N'NM20220416001', N'IPPM012', 1, 32000000, N'Công Ty DTVT Tín Hữu')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20220416/NMH/001', N'NM20220416001', N'LAS2012', 1, 25000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20220416/NMH/001', N'NM20220416001', N'LLG5001', 2, 60000000, N'Công ty TNHH Hữu Phát')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230430/NM/4269', N'NM202304304269', N'IPNM011', 2, 48000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230430/NM/4269', N'NM202304304269', N'LLG5001', 4, 120000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'@0', N'@1', N'@2', 3, 72000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'@0', N'@1', N'@2', 4, 128000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/790', N'XMH20230506790', N'IPPM012', 1, 32000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/790', N'XMH20230506790', N'IPPM013', 1, 37000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/790', N'XMH20230506790', N'TSS2020', 12, 276000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/414', N'XMH20230506414', N'SSZF001', 2, 66000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/414', N'XMH20230506414', N'LAS2012', 3, 75000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/414', N'XMH20230506414', N'TSS2020', 4, 92000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/414', N'XMH20230506414', N'IPPM013', 2, 74000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/NM/8557', N'NM202305068557', N'IPPM012', 3, 96000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/NM/8557', N'NM202305068557', N'IPPM013', 4, 148000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/NM/8557', N'NM202305068557', N'IPPM013', 5, 185000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/285', N'XMH20230506285', N'IPNM011', 2, 48000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/285', N'XMH20230506285', N'IPPM012', 3, 96000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/285', N'XMH20230506285', N'IPPM013', 4, 148000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/504', N'XMH20230506504', N'IPNM011', 3, 72000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/504', N'XMH20230506504', N'TSS2020', 4, 92000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/504', N'XMH20230506504', N'IPPM013', 1, 37000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/372', N'XMH20230507372', N'IPPM012', 1, 32000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/372', N'XMH20230507372', N'TSS2020', 4, 92000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/372', N'XMH20230507372', N'IPPM013', 2, 74000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/372', N'XMH20230507372', N'SSGF001', 3, 96000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/150', N'XMH20230507150', N'IPNM011', 2, 48000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/150', N'XMH20230507150', N'LAS2012', 3, 75000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/150', N'XMH20230507150', N'TSS2020', 2, 46000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/562', N'XMH20230507562', N'IPPM013', 2, 74000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230507/XMH/562', N'XMH20230507562', N'TAP2020', 4, 137252484, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230430/NM/9631', N'NM202304309631', N'IPPM012', 3, 96000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230430/NM/9631', N'NM202304309631', N'LLG5001', 2, 60000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230430/NM/4008', N'NM202304304008', N'LLG5001', 5, 150000000, N'Công Ty DTVT Samba')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230430/NM/3154', N'NM202304303154', N'IPPM012', 3, 96000000, N'Công Ty DTVT Tín Hữu')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230430/NM/3154', N'NM202304303154', N'IPPM013', 2, 74000000, N'Công Ty DTVT Tín Hữu')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230430/NM/3154', N'NM202304303154', N'IPNM011', 4, 96000000, N'Công Ty DTVT Tín Hữu')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230517/NM/7000', N'NM202305177000', N'LLG5001', 3, 90000000, N'Công ty TNHH Hữu Phát')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230517/NM/7000', N'NM202305177000', N'IPPM012', 2, 64000000, N'Công ty TNHH Hữu Phát')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230517/NM/7000', N'NM202305177000', N'LAS2012', 1, 25000000, N'Công ty TNHH Hữu Phát')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230306/NM/4086', N'NM202303064086', N'IPPM012', 3, 96000000, N'Công ty TNHH Hữu Phát')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230306/NM/4086', N'NM202303064086', N'IPPM013', 2, 74000000, N'Công ty TNHH Hữu Phát')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230306/NM/4086', N'NM202303064086', N'IPPM013', 1, 37000000, N'Công ty TNHH Hữu Phát')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/997', N'XMH20230506997', N'IPPM012', 4, 128000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/997', N'XMH20230506997', N'IPNM011', 2, 48000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/128', N'XMH20230506128', N'IPPM012', 3, 96000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/726', N'XMH20230506726', N'IPPM012', 3, 96000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/726', N'XMH20230506726', N'TSS2020', 4, 92000000, N'')
INSERT [dbo].[tb_Chungtuchitiet] ([IDChitiet], [IDChungtu], [IDSP], [soluong], [dongia], [nhacungcap]) VALUES (N'20230506/XMH/726', N'XMH20230506726', N'IPPM013', 2, 74000000, N'')
GO
INSERT [dbo].[tb_Congty] ([MaCT], [TenCT], [diachi], [dienthoai]) VALUES (N'CNMB      ', N'CHI NHÁNH MIỀN BẮC', N'', N'')
INSERT [dbo].[tb_Congty] ([MaCT], [TenCT], [diachi], [dienthoai]) VALUES (N'CNMN      ', N'CHI NHÁNH MIỀN NAM', N'', N'')
INSERT [dbo].[tb_Congty] ([MaCT], [TenCT], [diachi], [dienthoai]) VALUES (N'CNMT      ', N'CHI NHÁNH MIỀN TRUNG', N'', N'')
INSERT [dbo].[tb_Congty] ([MaCT], [TenCT], [diachi], [dienthoai]) VALUES (N'CT001     ', N'CÔNG TY TNHH THƯƠNG MẠI ĐIỆN TỬ ĐIỀN QUÂN', NULL, NULL)
GO
INSERT [dbo].[tb_Donvi] ([MADV], [tenDV], [diachi], [dienthoai], [email], [maCT], [kho], [kyhieu]) VALUES (N'CSSG001   ', N'CellphoneS Quận 8', N'Quận 8, TPHCM', N'09282983', N'bdjd@gmail.com', N'CNMN      ', 1, N'CSSG      ')
INSERT [dbo].[tb_Donvi] ([MADV], [tenDV], [diachi], [dienthoai], [email], [maCT], [kho], [kyhieu]) VALUES (N'KCT001    ', N'KHO CÔNG TY 1', N'Quận 12, TPHCM', N'98249138', N'dfj@gmail.com', N'CNMN      ', 1, N'KCTN      ')
INSERT [dbo].[tb_Donvi] ([MADV], [tenDV], [diachi], [dienthoai], [email], [maCT], [kho], [kyhieu]) VALUES (N'KCT002    ', N'KHO CÔNG TY 2', N'Chùa Láng, Hà Nội', N'93894893', N'jdjf@gmail.com', N'CNMB      ', 1, N'KCTB      ')
GO
INSERT [dbo].[tb_Nhacungcap] ([MANCC], [TENNCC], [diachi], [dienthoai], [email]) VALUES (N'CTHP', N'Công ty TNHH Hữu Phát', N'Quận 9', N'092939829', N'ndjfn@gmail.com')
INSERT [dbo].[tb_Nhacungcap] ([MANCC], [TENNCC], [diachi], [dienthoai], [email]) VALUES (N'CTSB', N'Công Ty DTVT Samba', N'Anh ', N'983028801', N'ndfj@email.com')
INSERT [dbo].[tb_Nhacungcap] ([MANCC], [TENNCC], [diachi], [dienthoai], [email]) VALUES (N'CTTH', N'Công Ty DTVT Tín Hữu', N'Ba Đình', N'982083910', N'ndjll@gmail.com')
GO
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'SSGF001', N'Samsung Galaxy Fold 1', 1, 32000000, N'Công ty TNHH Hữu Phát', N'Hàn Quốc', N'SSGF001.jpeg')
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'IPNM011', N'Iphone 11', 1, 24000000, N'Công Ty DTVT Tín Hữu', N'Mỹ', N'IPNM011.jpeg')
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'IPPM012', N'Iphone 12 promax', 1, 32000000, N'Công Ty DTVT Tín Hữu', N'Mỹ', N'IPPM012.jpeg')
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'SSZF001', N'Samsung Z Flip 2022', 1, 33000000, N'Công Ty DTVT Samba', N'Hàn Quốc', N'SSZF001.jpeg')
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'IPPM013', N'Iphone 13 promax', 1, 37000000, N'Công Ty DTVT Samba', N'Trung Quốc', N'IPPM013.jpeg')
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'LAS2012', N'Asus Tuf Gaming', 1, 25000000, N'Công Ty DTVT Samba', N'Anh', N'LAS2012.jpeg')
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'TSS2020', N'Máy tính bảng Samsung ', 1, 23000000, N'Công ty TNHH Hữu Phát', N'Hàn Quốc', N'TSS2020.jpeg')
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'TAP2020', N'Ipad 2022', 1, 34313121, N'Công Ty DTVT Samba', N'Mỹ', N'TAP2020.jpeg')
INSERT [dbo].[tb_Sanpham] ([MaSP], [TenSP], [donvitinh], [dongia], [nhacungcap], [xuatxu], [thumb]) VALUES (N'SSZF3', N'Samsung Z Flip 3', 1, 3400000, N'Công Ty DTVT Samba', N'Hàn Quốc', N'')
GO
