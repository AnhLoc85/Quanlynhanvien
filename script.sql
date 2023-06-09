USE [QuanLyNhanVien]
GO
/****** Object:  Table [dbo].[BaoHiem]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BaoHiem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaBH] [char](10) NOT NULL,
	[TGAD] [date] NULL,
	[MucBaoHiem] [float] NULL,
 CONSTRAINT [PK_BaoHiem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaCV] [char](10) NOT NULL,
	[TenChucVu] [nvarchar](100) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DMHeSoPhuCap]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMHeSoPhuCap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaHSPC] [char](10) NOT NULL,
	[HeSoPhuCap] [float] NULL,
 CONSTRAINT [PK_DMHeSoPhuCap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DMHSLuong]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMHSLuong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaHSL] [char](10) NOT NULL,
	[HeSoLuong] [float] NULL,
 CONSTRAINT [PK_DMHSLuong] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DMLuong]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMLuong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaML] [char](10) NOT NULL,
	[TienLuong] [money] NULL,
	[NgayAD] [date] NULL,
 CONSTRAINT [PK_DMLuong] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DMMucPhuCap]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMMucPhuCap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaPC] [char](10) NOT NULL,
	[KhoanPhuCap] [nchar](50) NULL,
 CONSTRAINT [PK_DMMucPhuCap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DongBaoHiem]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DongBaoHiem](
	[id] [int] NOT NULL,
	[MaNS] [int] NULL,
	[ThoiGian] [date] NULL,
	[TienBH] [money] NULL,
 CONSTRAINT [PK_DongBaoHiem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuongCoBan]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuongCoBan](
	[id] [int] NOT NULL,
	[MaNS] [int] NULL,
	[ThoiGian] [date] NULL,
	[HSL] [float] NULL,
	[Luong] [money] NULL,
	[LuongNS] [money] NULL,
 CONSTRAINT [PK_LuongCoBan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanSu]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanSu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [char](10) NOT NULL,
	[TenNS] [nvarchar](100) NULL,
	[GioiTinh] [bit] NULL,
	[Email] [char](36) NULL,
	[SDT] [char](12) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[NgaySinh] [date] NULL,
	[HinhAnh] [nchar](100) NULL,
	[QueQuan] [nvarchar](200) NULL,
 CONSTRAINT [PK_NhanSu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phat]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaPhat] [char](10) NOT NULL,
	[NoiDung] [nvarchar](200) NULL,
 CONSTRAINT [PK_Phat_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Phat] SET (LOCK_ESCALATION = DISABLE)
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaPB] [char](10) NOT NULL,
	[TenPhongBan] [nvarchar](100) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhuCapNhanSu]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhuCapNhanSu](
	[id] [int] NULL,
	[MaNS] [int] NULL,
	[ThoiGian] [date] NULL,
	[HSPC] [float] NULL,
	[TienPC] [float] NULL,
	[Maphucap] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QTChucVu]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QTChucVu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [int] NULL,
	[MaCV] [int] NULL,
	[MaPB] [int] NULL,
	[TGBatDau] [date] NULL,
	[TGKetThuc] [date] NULL,
 CONSTRAINT [PK_QuaTrinhChucVu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QTCongTac]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QTCongTac](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [int] NULL,
	[MaPB] [int] NULL,
	[TGBatDau] [date] NULL,
	[TGKetThuc] [date] NULL,
 CONSTRAINT [PK_QuaTrinhCongTac] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhDongBH]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhDongBH](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [int] NULL,
	[MaBH] [int] NULL,
	[TGBatDau] [date] NULL,
 CONSTRAINT [PK_QuaTrinhDongBH] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhDongThue]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhDongThue](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [int] NULL,
	[MaThue] [int] NULL,
	[NgayBD] [date] NULL,
 CONSTRAINT [PK_QuaTrinhDongThue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhLuong]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhLuong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [int] NULL,
	[MaHSL] [int] NULL,
	[MaML] [int] NULL,
	[TGBatDau] [date] NULL,
	[TGKetThuc] [date] NULL,
 CONSTRAINT [PK_QuaTrinhLuong] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhPhat]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhPhat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [int] NULL,
	[MaPhat] [int] NULL,
	[TienPhat] [money] NULL,
	[TGPhat] [date] NULL,
 CONSTRAINT [PK_QuaTrinhPhat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhPhuCap]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhPhuCap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [int] NULL,
	[MaPC] [int] NULL,
	[MaHSPC] [int] NULL,
	[TGBatDau] [date] NULL,
	[TGKetThuc] [date] NULL,
 CONSTRAINT [PK_QuaTrinhPhuCap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhThuongPC]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhThuongPC](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNS] [int] NULL,
	[TienThuong] [money] NULL,
	[MaThuong] [int] NULL,
	[TGThuong] [date] NULL,
 CONSTRAINT [PK_QuaTrinhThuongPC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaQuyen] [char](10) NOT NULL,
	[TenQuyen] [nvarchar](100) NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaQuyen] [int] NULL,
	[MaTK] [char](10) NOT NULL,
	[MaNS] [int] NULL,
	[TaiKhoan] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thue]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thue](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaThue] [char](10) NOT NULL,
	[ThueSuat] [int] NOT NULL,
 CONSTRAINT [PK_Thue] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThueNhanSu]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThueNhanSu](
	[id] [int] NOT NULL,
	[MaNS] [int] NULL,
	[Thúeuat] [int] NULL,
	[TienThue] [money] NULL,
 CONSTRAINT [PK_ThueNhanSu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuongPCKhac]    Script Date: 5/16/2023 12:06:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongPCKhac](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaThuong] [char](10) NOT NULL,
	[NoiDung] [nvarchar](200) NULL,
 CONSTRAINT [PK_ThuongPCKhac] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BaoHiem] ON 

INSERT [dbo].[BaoHiem] ([id], [MaBH], [TGAD], [MucBaoHiem]) VALUES (1, N'BH01      ', CAST(N'2021-07-01' AS Date), 10)
SET IDENTITY_INSERT [dbo].[BaoHiem] OFF
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([id], [MaCV], [TenChucVu]) VALUES (1, N'CV01      ', N'Giám đốc')
INSERT [dbo].[ChucVu] ([id], [MaCV], [TenChucVu]) VALUES (2, N'CV02      ', N'Phó giám đốc')
INSERT [dbo].[ChucVu] ([id], [MaCV], [TenChucVu]) VALUES (3, N'CV03      ', N'Trưởng phòng')
INSERT [dbo].[ChucVu] ([id], [MaCV], [TenChucVu]) VALUES (4, N'CV04      ', N'Phó phòng')
INSERT [dbo].[ChucVu] ([id], [MaCV], [TenChucVu]) VALUES (5, N'CV05      ', N'Nhân viên')
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[DMHeSoPhuCap] ON 

INSERT [dbo].[DMHeSoPhuCap] ([id], [MaHSPC], [HeSoPhuCap]) VALUES (1, N'HSPC01    ', 2.5)
INSERT [dbo].[DMHeSoPhuCap] ([id], [MaHSPC], [HeSoPhuCap]) VALUES (2, N'HSPC02    ', 3.2)
INSERT [dbo].[DMHeSoPhuCap] ([id], [MaHSPC], [HeSoPhuCap]) VALUES (3, N'HSPC03    ', 3.5)
INSERT [dbo].[DMHeSoPhuCap] ([id], [MaHSPC], [HeSoPhuCap]) VALUES (4, N'HSPC04    ', 4)
SET IDENTITY_INSERT [dbo].[DMHeSoPhuCap] OFF
GO
SET IDENTITY_INSERT [dbo].[DMHSLuong] ON 

INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (1, N'HSL01     ', 2.6)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (2, N'HSL02     ', 2.7)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (3, N'HSL03     ', 2.8)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (5, N'HSL04     ', 3)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (8, N'HSL05     ', 3.4)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (9, N'HSL06     ', 3.5)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (10, N'HSL07     ', 4)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (11, N'HSL08     ', 5)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (12, N'HSL09     ', 6)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (13, N'HSL10     ', 7)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (14, N'HSL11     ', 8)
INSERT [dbo].[DMHSLuong] ([id], [MaHSL], [HeSoLuong]) VALUES (15, N'HSL12     ', 9)
SET IDENTITY_INSERT [dbo].[DMHSLuong] OFF
GO
SET IDENTITY_INSERT [dbo].[DMLuong] ON 

INSERT [dbo].[DMLuong] ([id], [MaML], [TienLuong], [NgayAD]) VALUES (1, N'ML01      ', 1490008.0000, CAST(N'2019-01-07' AS Date))
INSERT [dbo].[DMLuong] ([id], [MaML], [TienLuong], [NgayAD]) VALUES (2, N'ML02      ', 1800000.0000, CAST(N'2023-01-07' AS Date))
SET IDENTITY_INSERT [dbo].[DMLuong] OFF
GO
SET IDENTITY_INSERT [dbo].[DMMucPhuCap] ON 

INSERT [dbo].[DMMucPhuCap] ([id], [MaPC], [KhoanPhuCap]) VALUES (1, N'PC01      ', N'Xăng xe                                           ')
INSERT [dbo].[DMMucPhuCap] ([id], [MaPC], [KhoanPhuCap]) VALUES (2, N'PC02      ', N'Ăn uống                                           ')
INSERT [dbo].[DMMucPhuCap] ([id], [MaPC], [KhoanPhuCap]) VALUES (3, N'PC03      ', N'Phụ cấp chức vụ                                   ')
INSERT [dbo].[DMMucPhuCap] ([id], [MaPC], [KhoanPhuCap]) VALUES (4, N'PC04      ', N'Phụ cấp trách nhiệm                               ')
SET IDENTITY_INSERT [dbo].[DMMucPhuCap] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanSu] ON 

INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (1, N'NS001     ', N'Nguyễn Thanh Ý', 1, N'thanhy@gmail.com                    ', N'0303364402  ', N'Nguyễn Trọng Lội HCM', CAST(N'2001-11-09' AS Date), N'/assets/img/avatars/y1.jpg                                                                          ', N'Bình Định')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (2, N'NS002     ', N'Mai Anh Lộc', 1, N'culoc147@gmail.com                  ', N'0394456540  ', N'Huỳnh Thiện Lộc Tân Phú HCM', CAST(N'2001-02-24' AS Date), N'/assets/img/avatars/loc1.png                                                                        ', N'Đăk Lăk')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (3, N'NS003     ', N'Lê Thị Bảo Yến', 0, N'baoyen@gmail.com                    ', N'0345697865  ', NULL, CAST(N'2001-04-10' AS Date), N'/assets/img/avatars/yen2.jpg                                                                        ', N'Đăk Lăk')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (4, N'NS004     ', N'Thái Lai', 1, N'thailai@gmail.com                   ', N'0903599007  ', NULL, CAST(N'2001-05-28' AS Date), N'/assets/img/avatars/lai3.jpg                                                                        ', N'Bình Định')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (6, N'NS005     ', N'Võ Trần Uy', 1, N'votranuy2001@gmail.com              ', N'0359897445  ', N'947/33 Lạc Long Quân', CAST(N'2001-09-30' AS Date), N'/assets/img/avatars/uy1.jpg                                                                         ', N'Quãng Ngãi')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (7, N'NS006     ', N'Phạm Thị Thảo Huyền ', 0, N'thaohuyen@gmail.com                 ', N'0349765875  ', NULL, CAST(N'2001-03-10' AS Date), N'/assets/img/avatars/y1.jpg                                                                          ', N'Lâm Đồng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (8, N'NS007     ', N'Trần Lê Tiến Hòa', 1, N'tienhoa@gmail.com                   ', N'0986485888  ', N'chung cư Hòa Bình', CAST(N'2001-02-25' AS Date), N'/assets/img/avatars/hoa1.jpg                                                                        ', N'Quảng Trị')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (9, N'NS008     ', N'Nguyễn Đỗ Nhất Vũ', 1, N'nhatvu@gmail.com                    ', N'0356894584  ', NULL, CAST(N'2001-07-14' AS Date), N'/assets/img/avatars/vu1.jpg                                                                         ', N'Quãng Ngãi')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (10, N'NS010     ', N'Nhân sự 10', 1, N'Nhansu10@gmail.com                  ', N'0332129101  ', NULL, CAST(N'1999-06-28' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Thái Nguyên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (11, N'NS011     ', N'Nhân sự 11', 1, N'Nhansu11@gmail.com                  ', N'0365625959  ', NULL, CAST(N'1993-08-04' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Ninh Thuận')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (12, N'NS012     ', N'Nhân sự 12', 1, N'Nhansu12@gmail.com                  ', N'0339036418  ', NULL, CAST(N'1994-09-20' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hồ Chí Minh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (13, N'NS013     ', N'Nhân sự 13', 1, N'Nhansu13@gmail.com                  ', N'0310953819  ', NULL, CAST(N'1998-04-10' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Cao Bằng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (14, N'NS014     ', N'Nhân sự 14', 1, N'Nhansu14@gmail.com                  ', N'0347202888  ', NULL, CAST(N'1991-08-27' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Nghệ An')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (15, N'NS015     ', N'Nhân sự 15', 1, N'Nhansu15@gmail.com                  ', N'0365753377  ', NULL, CAST(N'1997-06-10' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Khánh Hòa')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (16, N'NS016     ', N'Nhân sự 16', 1, N'Nhansu16@gmail.com                  ', N'0335951242  ', NULL, CAST(N'1990-01-24' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Nam')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (17, N'NS017     ', N'Nhân sự 17', 1, N'Nhansu17@gmail.com                  ', N'0313588355  ', NULL, CAST(N'1998-10-19' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Cần Thơ')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (18, N'NS018     ', N'Nhân sự 18', 1, N'Nhansu18@gmail.com                  ', N'0359143920  ', NULL, CAST(N'1999-05-13' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Cà Mau')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (19, N'NS019     ', N'Nhân sự 19', 1, N'Nhansu19@gmail.com                  ', N'0365972989  ', NULL, CAST(N'2000-03-08' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Nghệ An')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (20, N'NS020     ', N'Nhân sự 20', 1, N'Nhansu20@gmail.com                  ', N'0363535577  ', NULL, CAST(N'1999-06-11' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Thái Bình')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (21, N'NS021     ', N'Nhân sự 21', 1, N'Nhansu21@gmail.com                  ', N'031487336   ', NULL, CAST(N'1990-05-07' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Ninh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (22, N'NS022     ', N'Nhân sự 22', 1, N'Nhansu22@gmail.com                  ', N'0317391906  ', NULL, CAST(N'2002-08-18' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hà Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (23, N'NS023     ', N'Nhân sự 23', 1, N'Nhansu23@gmail.com                  ', N'0316348139  ', NULL, CAST(N'1997-11-17' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Trà Vinh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (24, N'NS024     ', N'Nhân sự 24', 1, N'Nhansu24@gmail.com                  ', N'0368305493  ', NULL, CAST(N'1990-09-23' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bến Tre')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (25, N'NS025     ', N'Nhân sự 25', 1, N'Nhansu25@gmail.com                  ', N'0377806417  ', NULL, CAST(N'2000-04-04' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hà Nam')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (26, N'NS026     ', N'Nhân sự 26', 1, N'Nhansu26@gmail.com                  ', N'0359025573  ', NULL, CAST(N'1997-08-03' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Nam')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (27, N'NS027     ', N'Nhân sự 27', 1, N'Nhansu27@gmail.com                  ', N'0310649014  ', NULL, CAST(N'1998-01-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Thái Nguyên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (28, N'NS028     ', N'Nhân sự 28', 1, N'Nhansu28@gmail.com                  ', N'0330074303  ', NULL, CAST(N'1998-02-07' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Kon Tum')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (29, N'NS029     ', N'Nhân sự 29', 1, N'Nhansu29@gmail.com                  ', N'0338278272  ', NULL, CAST(N'1990-06-08' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hải Dương')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (30, N'NS030     ', N'Nhân sự 30', 1, N'Nhansu30@gmail.com                  ', N'0335924500  ', NULL, CAST(N'1993-12-05' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Thái Nguyên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (31, N'NS031     ', N'Nhân sự 31', 1, N'Nhansu31@gmail.com                  ', N'0347583439  ', NULL, CAST(N'2002-01-05' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bình Phước')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (32, N'NS032     ', N'Nhân sự 32', 1, N'Nhansu32@gmail.com                  ', N'037697718   ', NULL, CAST(N'1990-11-17' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bạc Liêu')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (33, N'NS033     ', N'Nhân sự 33', 1, N'Nhansu33@gmail.com                  ', N'0322469187  ', NULL, CAST(N'1993-07-12' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bình Dương')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (34, N'NS034     ', N'Nhân sự 34', 1, N'Nhansu34@gmail.com                  ', N'0374427302  ', NULL, CAST(N'1998-09-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Yên Bái')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (35, N'NS035     ', N'Nhân sự 35', 1, N'Nhansu35@gmail.com                  ', N'032143187   ', NULL, CAST(N'1994-09-20' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bình Dương')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (36, N'NS036     ', N'Nhân sự 36', 1, N'Nhansu36@gmail.com                  ', N'0334940613  ', NULL, CAST(N'1990-07-22' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Kiên Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (37, N'NS037     ', N'Nhân sự 37', 1, N'Nhansu37@gmail.com                  ', N'0376850845  ', NULL, CAST(N'1994-11-20' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Phú Thọ')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (38, N'NS038     ', N'Nhân sự 38', 1, N'Nhansu38@gmail.com                  ', N'0345018452  ', NULL, CAST(N'1995-05-16' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hưng Yên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (39, N'NS039     ', N'Nhân sự 39', 1, N'Nhansu39@gmail.com                  ', N'0337242625  ', NULL, CAST(N'2000-07-08' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Lâm Đồng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (40, N'NS040     ', N'Nhân sự 40', 1, N'Nhansu40@gmail.com                  ', N'0366646695  ', NULL, CAST(N'1990-01-13' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bình Dương')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (41, N'NS041     ', N'Nhân sự 41', 1, N'Nhansu41@gmail.com                  ', N'0379170415  ', NULL, CAST(N'1993-10-26' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hưng Yên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (42, N'NS042     ', N'Nhân sự 42', 1, N'Nhansu42@gmail.com                  ', N'0345124457  ', NULL, CAST(N'1992-10-23' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bình Dương')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (43, N'NS043     ', N'Nhân sự 43', 1, N'Nhansu43@gmail.com                  ', N'0328969091  ', NULL, CAST(N'1996-10-07' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Thái Nguyên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (44, N'NS044     ', N'Nhân sự 44', 1, N'Nhansu44@gmail.com                  ', N'0352309291  ', NULL, CAST(N'2001-11-09' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Kiên Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (45, N'NS045     ', N'Nhân sự 45', 1, N'Nhansu45@gmail.com                  ', N'0364606054  ', NULL, CAST(N'1993-10-15' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Cao Bằng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (46, N'NS046     ', N'Nhân sự 46', 1, N'Nhansu46@gmail.com                  ', N'0389007874  ', NULL, CAST(N'1997-09-24' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Bình')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (47, N'NS047     ', N'Nhân sự 47', 1, N'Nhansu47@gmail.com                  ', N'0360722248  ', NULL, CAST(N'1994-02-14' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Khánh Hòa')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (48, N'NS048     ', N'Nhân sự 48', 1, N'Nhansu48@gmail.com                  ', N'0396583431  ', NULL, CAST(N'1993-05-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Phú Yên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (49, N'NS049     ', N'Nhân sự 49', 1, N'Nhansu49@gmail.com                  ', N'0360162832  ', NULL, CAST(N'2001-03-27' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Tiền Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (50, N'NS050     ', N'Nhân sự 50', 1, N'Nhansu50@gmail.com                  ', N'0350522879  ', NULL, CAST(N'1996-02-21' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Lai Châu')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (51, N'NS051     ', N'Nhân sự 51', 1, N'Nhansu51@gmail.com                  ', N'0381217659  ', NULL, CAST(N'2001-03-24' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hòa Bình')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (52, N'NS052     ', N'Nhân sự 52', 1, N'Nhansu52@gmail.com                  ', N'0332355994  ', NULL, CAST(N'1991-08-04' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hồ Chí Minh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (53, N'NS053     ', N'Nhân sự 53', 1, N'Nhansu53@gmail.com                  ', N'0333499536  ', NULL, CAST(N'1996-10-01' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Khánh Hòa')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (54, N'NS054     ', N'Nhân sự 54', 1, N'Nhansu54@gmail.com                  ', N'0328477066  ', NULL, CAST(N'1994-01-22' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Đắk Lắk')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (55, N'NS055     ', N'Nhân sự 55', 1, N'Nhansu55@gmail.com                  ', N'0318068667  ', NULL, CAST(N'1998-04-19' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Tiền Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (56, N'NS056     ', N'Nhân sự 56', 1, N'Nhansu56@gmail.com                  ', N'0346817052  ', NULL, CAST(N'1994-06-24' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Tây Ninh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (57, N'NS057     ', N'Nhân sự 57', 1, N'Nhansu57@gmail.com                  ', N'0364530688  ', NULL, CAST(N'1999-07-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hà Tĩnh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (58, N'NS058     ', N'Nhân sự 58', 1, N'Nhansu58@gmail.com                  ', N'0378650404  ', NULL, CAST(N'1998-10-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Kon Tum')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (59, N'NS059     ', N'Nhân sự 59', 1, N'Nhansu59@gmail.com                  ', N'031473441   ', NULL, CAST(N'1994-12-03' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Kiên Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (60, N'NS060     ', N'Nhân sự 60', 1, N'Nhansu60@gmail.com                  ', N'0366850220  ', NULL, CAST(N'1999-01-14' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Đắk Lắk')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (61, N'NS061     ', N'Nhân sự 61', 1, N'Nhansu61@gmail.com                  ', N'0373416784  ', NULL, CAST(N'1994-01-10' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Nam Định')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (62, N'NS062     ', N'Nhân sự 62', 1, N'Nhansu62@gmail.com                  ', N'0397684717  ', NULL, CAST(N'1993-09-14' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Đắk Nông')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (63, N'NS063     ', N'Nhân sự 63', 1, N'Nhansu63@gmail.com                  ', N'0323885298  ', NULL, CAST(N'1993-08-12' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hải Dương')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (64, N'NS064     ', N'Nhân sự 64', 1, N'Nhansu64@gmail.com                  ', N'0364104249  ', NULL, CAST(N'1992-06-16' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Trà Vinh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (65, N'NS065     ', N'Nhân sự 65', 1, N'Nhansu65@gmail.com                  ', N'0318507394  ', NULL, CAST(N'1991-11-20' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Bình')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (66, N'NS066     ', N'Nhân sự 66', 1, N'Nhansu66@gmail.com                  ', N'0321927656  ', NULL, CAST(N'1996-04-04' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Trà Vinh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (67, N'NS067     ', N'Nhân sự 67', 1, N'Nhansu67@gmail.com                  ', N'0366708315  ', NULL, CAST(N'1996-11-04' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bình Định')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (68, N'NS068     ', N'Nhân sự 68', 1, N'Nhansu68@gmail.com                  ', N'0372532914  ', NULL, CAST(N'1999-04-05' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Nghệ An')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (69, N'NS069     ', N'Nhân sự 69', 1, N'Nhansu69@gmail.com                  ', N'039307584   ', NULL, CAST(N'1990-07-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Đắk Nông')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (70, N'NS070     ', N'Nhân sự 70', 1, N'Nhansu70@gmail.com                  ', N'0371166968  ', NULL, CAST(N'1993-03-13' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Lào Cai')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (71, N'NS071     ', N'Nhân sự 71', 1, N'Nhansu71@gmail.com                  ', N'0350173225  ', NULL, CAST(N'1993-12-24' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Lạng Sơn')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (72, N'NS072     ', N'Nhân sự 72', 0, N'Nhansu72@gmail.com                  ', N'0391395692  ', NULL, CAST(N'2001-05-13' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hải Dương')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (73, N'NS073     ', N'Nhân sự 73', 1, N'Nhansu73@gmail.com                  ', N'0379151183  ', NULL, CAST(N'1990-11-07' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Gia Lai')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (74, N'NS074     ', N'Nhân sự 74', 1, N'Nhansu74@gmail.com                  ', N'034630550   ', NULL, CAST(N'2001-04-07' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Khánh Hòa')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (75, N'NS075     ', N'Nhân sự 75', 0, N'Nhansu75@gmail.com                  ', N'0343453963  ', NULL, CAST(N'1999-03-23' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Sóc Trăng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (76, N'NS076     ', N'Nhân sự 76', 1, N'Nhansu76@gmail.com                  ', N'0363155814  ', NULL, CAST(N'1992-10-02' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Tuyên Quang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (77, N'NS077     ', N'Nhân sự 77', 1, N'Nhansu77@gmail.com                  ', N'0362435727  ', NULL, CAST(N'1991-03-12' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bến Tre')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (78, N'NS078     ', N'Nhân sự 78', 0, N'Nhansu78@gmail.com                  ', N'0317698486  ', NULL, CAST(N'1995-04-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hưng Yên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (79, N'NS079     ', N'Nhân sự 79', 0, N'Nhansu79@gmail.com                  ', N'0348970140  ', NULL, CAST(N'1998-05-16' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Phú Yên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (80, N'NS080     ', N'Nhân sự 80', 0, N'Nhansu80@gmail.com                  ', N'0322814846  ', NULL, CAST(N'1996-11-12' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hưng Yên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (81, N'NS081     ', N'Nhân sự 81', 0, N'Nhansu81@gmail.com                  ', N'0351617200  ', NULL, CAST(N'1991-12-15' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Phú Thọ')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (82, N'NS082     ', N'Nhân sự 82', 1, N'Nhansu82@gmail.com                  ', N'032557661   ', NULL, CAST(N'1991-05-03' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Thái Bình')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (83, N'NS083     ', N'Nhân sự 83', 0, N'Nhansu83@gmail.com                  ', N'0312823325  ', NULL, CAST(N'1992-04-18' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Ngãi')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (84, N'NS084     ', N'Nhân sự 84', 1, N'Nhansu84@gmail.com                  ', N'0378613898  ', NULL, CAST(N'1995-03-05' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Lâm Đồng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (85, N'NS085     ', N'Nhân sự 85', 1, N'Nhansu85@gmail.com                  ', N'0365005102  ', NULL, CAST(N'1993-09-08' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Tiền Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (86, N'NS086     ', N'Nhân sự 86', 1, N'Nhansu86@gmail.com                  ', N'0391688446  ', NULL, CAST(N'1999-09-21' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hà Tĩnh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (87, N'NS087     ', N'Nhân sự 87', 0, N'Nhansu87@gmail.com                  ', N'0385362590  ', NULL, CAST(N'1994-09-03' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Kiên Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (88, N'NS088     ', N'Nhân sự 88', 1, N'Nhansu88@gmail.com                  ', N'0381847120  ', NULL, CAST(N'2002-01-11' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Cao Bằng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (89, N'NS089     ', N'Nhân sự 89', 0, N'Nhansu89@gmail.com                  ', N'0354957336  ', NULL, CAST(N'1997-02-02' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bình Phước')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (90, N'NS090     ', N'Nhân sự 90', 1, N'Nhansu90@gmail.com                  ', N'0340319404  ', NULL, CAST(N'1997-08-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Ninh Bình')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (91, N'NS091     ', N'Nhân sự 91', 1, N'Nhansu91@gmail.com                  ', N'0326598878  ', NULL, CAST(N'1993-11-25' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Đà Nẵng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (92, N'NS092     ', N'Nhân sự 92', 1, N'Nhansu92@gmail.com                  ', N'0336200731  ', NULL, CAST(N'2002-12-23' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hồ Chí Minh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (93, N'NS093     ', N'Nhân sự 93', 1, N'Nhansu93@gmail.com                  ', N'0335945823  ', NULL, CAST(N'1990-02-12' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Nam')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (94, N'NS094     ', N'Nhân sự 94', 0, N'Nhansu94@gmail.com                  ', N'0372952566  ', NULL, CAST(N'1997-02-19' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hà Giang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (95, N'NS095     ', N'Nhân sự 95', 0, N'Nhansu95@gmail.com                  ', N'0311333396  ', NULL, CAST(N'2000-08-27' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bạc Liêu')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (96, N'NS096     ', N'Nhân sự 96', 0, N'Nhansu96@gmail.com                  ', N'0320521558  ', NULL, CAST(N'1996-06-08' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Yên Bái')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (97, N'NS097     ', N'Nhân sự 97', 1, N'Nhansu97@gmail.com                  ', N'0311147233  ', NULL, CAST(N'1996-01-27' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Hưng Yên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (98, N'NS098     ', N'Nhân sự 98', 1, N'Nhansu98@gmail.com                  ', N'0320003104  ', NULL, CAST(N'1990-01-20' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Bình')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (99, N'NS099     ', N'Nhân sự 99', 1, N'Nhansu99@gmail.com                  ', N'0376071120  ', NULL, CAST(N'1992-01-18' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Điện Biên')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (100, N'NS100     ', N'Nhân sự 100', 0, N'Nhansu100@gmail.com                 ', N'0388188898  ', NULL, CAST(N'2001-08-20' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bình Dương')
GO
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (101, N'NS101     ', N'Nhân sự 101', 1, N'Nhansu101@gmail.com                 ', N'0320155943  ', NULL, CAST(N'1998-09-16' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Vĩnh Phúc')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (102, N'NS102     ', N'Nhân sự 102', 0, N'Nhansu102@gmail.com                 ', N'0358616836  ', NULL, CAST(N'1993-10-16' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Lâm Đồng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (103, N'NS103     ', N'Nhân sự 103', 1, N'Nhansu103@gmail.com                 ', N'0381662610  ', NULL, CAST(N'1999-08-14' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Bắc Ninh')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (104, N'NS104     ', N'Nhân sự 104', 1, N'Nhansu104@gmail.com                 ', N'0347312736  ', NULL, CAST(N'2001-01-26' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Tuyên Quang')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (105, N'NS105     ', N'Nhân sự 105', 1, N'Nhansu105@gmail.com                 ', N'035336882   ', NULL, CAST(N'1994-06-06' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Cao Bằng')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (106, N'NS106     ', N'Nhân sự 106', 1, N'Nhansu106@gmail.com                 ', N'0383970974  ', NULL, CAST(N'1995-03-23' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Ninh Thuận')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (107, N'NS107     ', N'Nhân sự 107', 0, N'Nhansu107@gmail.com                 ', N'0362760249  ', NULL, CAST(N'2000-08-06' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Quảng Nam')
INSERT [dbo].[NhanSu] ([id], [MaNS], [TenNS], [GioiTinh], [Email], [SDT], [DiaChi], [NgaySinh], [HinhAnh], [QueQuan]) VALUES (108, N'NS108     ', N'Nhân sự 108', 1, N'Nhansu108@gmail.com                 ', N'031365772   ', NULL, CAST(N'2000-04-18' AS Date), N'/assets/img/avatars/ava.jpg                                                                         ', N'Nam Định')
SET IDENTITY_INSERT [dbo].[NhanSu] OFF
GO
SET IDENTITY_INSERT [dbo].[Phat] ON 

INSERT [dbo].[Phat] ([id], [MaPhat], [NoiDung]) VALUES (1, N'P01       ', N'Nghỉ không phép')
INSERT [dbo].[Phat] ([id], [MaPhat], [NoiDung]) VALUES (2, N'P02       ', N'Đi làm trễ')
INSERT [dbo].[Phat] ([id], [MaPhat], [NoiDung]) VALUES (3, N'P03       ', N'Làm việc riêng')
SET IDENTITY_INSERT [dbo].[Phat] OFF
GO
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([id], [MaPB], [TenPhongBan]) VALUES (1, N'PB01      ', N'Nhân sự')
INSERT [dbo].[PhongBan] ([id], [MaPB], [TenPhongBan]) VALUES (2, N'PB02      ', N'Tài chính')
INSERT [dbo].[PhongBan] ([id], [MaPB], [TenPhongBan]) VALUES (3, N'PB03      ', N'Kế hoạch')
INSERT [dbo].[PhongBan] ([id], [MaPB], [TenPhongBan]) VALUES (4, N'PB04      ', N'Marketting')
INSERT [dbo].[PhongBan] ([id], [MaPB], [TenPhongBan]) VALUES (5, N'PB05      ', N'Hành chính')
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
GO
SET IDENTITY_INSERT [dbo].[QTChucVu] ON 

INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (1, 2, 1, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (2, 1, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (3, 3, 2, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (4, 4, 1, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (6, 6, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (7, 7, 1, 4, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (8, 8, 1, 5, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (9, 9, 2, 4, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (10, 10, 2, 5, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (11, 11, 3, 5, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (12, 12, 3, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (13, 13, 3, 4, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (14, 14, 4, 5, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (15, 15, 2, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (16, 16, 4, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (17, 17, 4, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (18, 18, 4, 4, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (19, 19, 4, 5, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (20, 20, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (21, 21, 5, 5, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (22, 22, 5, 5, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (23, 23, 5, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (24, 24, 5, 3, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (25, 25, 5, 5, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (26, 26, 5, 3, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (27, 27, 5, 5, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (28, 28, 4, 4, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (29, 29, 2, 2, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (30, 30, 5, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (31, 31, 5, 4, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (32, 32, 5, 3, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (33, 33, 5, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (34, 34, 5, 3, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (35, 35, 5, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (36, 36, 5, 5, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (37, 37, 3, 2, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (38, 38, 5, 4, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (39, 39, 5, 4, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (40, 40, 5, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (41, 41, 4, 2, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (42, 42, 5, 4, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (43, 43, 4, 4, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (44, 44, 5, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (45, 45, 5, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (46, 46, 5, 2, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (47, 47, 5, 5, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (48, 48, 5, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (49, 49, 5, 4, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (50, 50, 5, 2, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (51, 51, 5, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (52, 52, 5, 2, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (53, 53, 5, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (54, 54, 5, 2, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (55, 55, 5, 2, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (56, 56, 5, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (57, 57, 5, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (58, 58, 5, 5, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (59, 59, 5, 4, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (60, 60, 5, 2, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (61, 61, 5, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (62, 62, 5, 5, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (63, 63, 5, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (64, 64, 5, 5, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (65, 65, 5, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (66, 66, 5, 4, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (67, 67, 5, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (68, 68, 5, 4, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (69, 69, 5, 4, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (70, 70, 5, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (71, 71, 5, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (72, 72, 5, 4, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (73, 73, 5, 5, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (74, 74, 5, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (75, 75, 5, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (76, 76, 5, 4, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (77, 77, 5, 5, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (78, 78, 5, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (79, 79, 5, 5, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (80, 80, 5, 5, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (81, 81, 5, 2, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (82, 82, 5, 2, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (83, 83, 5, 1, CAST(N'2021-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (84, 84, 5, 4, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (85, 85, 5, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (86, 86, 5, 2, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (87, 87, 5, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (88, 88, 5, 1, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (89, 89, 5, 3, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (90, 90, 5, 4, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (91, 91, 5, 3, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (92, 92, 5, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (93, 93, 5, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (94, 94, 5, 2, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (95, 95, 5, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (96, 96, 5, 4, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (97, 97, 5, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (98, 98, 5, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (99, 99, 5, 4, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (100, 100, 5, 4, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
GO
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (101, 101, 5, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (102, 102, 5, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (103, 103, 5, 4, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (104, 104, 5, 5, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (105, 105, 5, 4, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (106, 106, 5, 5, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (107, 107, 5, 2, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTChucVu] ([id], [MaNS], [MaCV], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (108, 108, 5, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
SET IDENTITY_INSERT [dbo].[QTChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[QTCongTac] ON 

INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (1, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (2, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (3, 10, 5, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (4, 11, 5, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (5, 12, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (6, 13, 4, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (7, 14, 5, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (8, 15, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (9, 16, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (10, 17, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (11, 18, 4, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (12, 19, 5, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (13, 20, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (14, 21, 5, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (15, 22, 5, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (16, 23, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (17, 24, 3, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (18, 25, 5, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (19, 26, 3, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (20, 27, 5, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (21, 28, 4, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (22, 29, 2, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (23, 30, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (24, 31, 4, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (25, 32, 3, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (26, 33, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (27, 34, 3, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (28, 35, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (29, 36, 5, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (30, 37, 2, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (31, 38, 4, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (32, 39, 4, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (33, 40, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (34, 41, 2, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (35, 42, 4, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (36, 43, 4, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (37, 44, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (38, 45, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (39, 46, 2, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (40, 47, 5, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (41, 48, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (42, 49, 4, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (43, 50, 2, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (44, 51, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (45, 52, 2, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (46, 53, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (47, 54, 2, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (48, 55, 2, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (49, 56, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (50, 57, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (51, 58, 5, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (52, 59, 4, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (53, 60, 2, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (54, 61, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (55, 62, 5, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (56, 63, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (57, 64, 5, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (58, 65, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (59, 66, 4, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (60, 67, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (61, 68, 4, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (62, 69, 4, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (63, 70, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (64, 71, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (65, 72, 4, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (66, 73, 5, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (67, 74, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (68, 75, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (69, 76, 4, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (70, 77, 5, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (71, 78, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (72, 79, 5, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (73, 80, 5, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (74, 81, 2, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (75, 82, 2, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (76, 83, 1, CAST(N'2021-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (77, 84, 4, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (78, 85, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (79, 86, 2, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (80, 87, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (81, 88, 1, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (82, 89, 3, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (83, 90, 4, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (84, 91, 3, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (85, 92, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (86, 93, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (87, 94, 2, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (88, 95, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (89, 96, 4, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (90, 97, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (91, 98, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (92, 99, 4, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (93, 100, 4, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (94, 101, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (95, 102, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (96, 103, 4, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (97, 104, 5, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (98, 105, 4, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (99, 106, 5, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
GO
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (100, 107, 2, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (101, 108, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (103, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (104, 4, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (105, 6, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (106, 7, 4, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (107, 8, 5, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QTCongTac] ([id], [MaNS], [MaPB], [TGBatDau], [TGKetThuc]) VALUES (108, 9, 4, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
SET IDENTITY_INSERT [dbo].[QTCongTac] OFF
GO
SET IDENTITY_INSERT [dbo].[QuaTrinhDongBH] ON 

INSERT [dbo].[QuaTrinhDongBH] ([id], [MaNS], [MaBH], [TGBatDau]) VALUES (1, 1, NULL, CAST(N'2121-01-01' AS Date))
INSERT [dbo].[QuaTrinhDongBH] ([id], [MaNS], [MaBH], [TGBatDau]) VALUES (2, 2, NULL, CAST(N'2121-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[QuaTrinhDongBH] OFF
GO
SET IDENTITY_INSERT [dbo].[QuaTrinhDongThue] ON 

INSERT [dbo].[QuaTrinhDongThue] ([id], [MaNS], [MaThue], [NgayBD]) VALUES (1, 1, NULL, CAST(N'2121-01-01' AS Date))
INSERT [dbo].[QuaTrinhDongThue] ([id], [MaNS], [MaThue], [NgayBD]) VALUES (2, 2, NULL, CAST(N'2121-01-01' AS Date))
SET IDENTITY_INSERT [dbo].[QuaTrinhDongThue] OFF
GO
SET IDENTITY_INSERT [dbo].[QuaTrinhLuong] ON 

INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (1, 1, 15, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (2, 2, 15, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (3, 3, 14, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (4, 4, 15, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (5, 6, 14, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (6, 7, 15, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (7, 8, 15, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (8, 9, 14, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (9, 10, 14, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (10, 11, 11, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (11, 12, 11, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (12, 13, 11, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (13, 14, 9, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (14, 15, 14, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (15, 16, 9, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (16, 17, 9, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (17, 18, 9, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (18, 19, 9, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (19, 20, 11, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (20, 21, 5, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (21, 22, 5, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (22, 23, 5, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (23, 24, 5, 1, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (24, 25, 5, 1, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (25, 26, 5, 1, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (26, 27, 5, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (27, 28, 9, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (28, 29, 14, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (29, 30, 5, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (30, 31, 5, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (31, 32, 5, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (32, 33, 5, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (33, 34, 5, 1, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (34, 35, 5, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (35, 36, 5, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (36, 37, 11, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (37, 38, 5, 1, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (38, 39, 5, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (39, 40, 5, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (40, 41, 9, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (41, 42, 5, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (42, 43, 9, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (43, 44, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (44, 45, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (45, 46, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (46, 47, 1, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (47, 48, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (48, 49, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (49, 50, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (50, 51, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (51, 52, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (52, 53, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (53, 54, 1, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (54, 55, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (55, 56, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (56, 57, 1, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (57, 58, 1, 1, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (58, 59, 1, 1, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (59, 60, 1, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (60, 61, 1, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (61, 62, 1, 1, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (62, 63, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (63, 64, 1, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (64, 65, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (65, 66, 1, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (66, 67, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (67, 68, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (68, 69, 1, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (69, 70, 1, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (70, 71, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (71, 72, 1, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (72, 73, 1, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (73, 74, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (74, 75, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (75, 76, 1, 1, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (76, 77, 1, 1, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (77, 78, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (78, 79, 1, 1, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (79, 80, 1, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (80, 81, 1, 1, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (81, 82, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (82, 83, 1, 1, CAST(N'2021-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (83, 84, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (84, 85, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (85, 86, 1, 1, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (86, 87, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (87, 88, 1, 1, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (88, 89, 1, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (89, 90, 1, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (90, 91, 1, 1, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (91, 92, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (92, 93, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (93, 94, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (94, 95, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (95, 96, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (96, 97, 1, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (97, 98, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (98, 99, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (99, 100, 1, 1, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
GO
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (100, 101, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (101, 102, 1, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (102, 103, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (103, 104, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (104, 105, 1, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (105, 106, 1, 1, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (106, 107, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhLuong] ([id], [MaNS], [MaHSL], [MaML], [TGBatDau], [TGKetThuc]) VALUES (107, 108, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
SET IDENTITY_INSERT [dbo].[QuaTrinhLuong] OFF
GO
SET IDENTITY_INSERT [dbo].[QuaTrinhPhat] ON 

INSERT [dbo].[QuaTrinhPhat] ([id], [MaNS], [MaPhat], [TienPhat], [TGPhat]) VALUES (1, 1, NULL, NULL, NULL)
INSERT [dbo].[QuaTrinhPhat] ([id], [MaNS], [MaPhat], [TienPhat], [TGPhat]) VALUES (2, 2, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[QuaTrinhPhat] OFF
GO
SET IDENTITY_INSERT [dbo].[QuaTrinhPhuCap] ON 

INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (1, 1, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (2, 2, 1, 2, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (4, 3, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (5, 4, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (6, 6, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (7, 7, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (8, 8, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (9, 9, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (10, 10, 1, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (11, 11, 1, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (12, 12, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (13, 13, 1, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (14, 14, 1, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (15, 15, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (16, 16, 1, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (17, 17, 1, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (18, 18, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (19, 19, 1, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (20, 20, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (21, 21, 1, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (22, 22, 1, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (23, 23, 1, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (24, 24, 1, 1, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (25, 25, 1, 1, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (26, 26, 1, 1, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (27, 27, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (28, 28, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (29, 29, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (30, 30, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (31, 31, 1, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (32, 32, 1, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (33, 33, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (34, 34, 1, 1, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (35, 35, 1, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (36, 36, 1, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (37, 37, 1, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (38, 38, 1, 1, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (39, 39, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (40, 40, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (41, 41, 1, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (42, 42, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (43, 43, 1, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (44, 44, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (45, 45, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (46, 46, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (47, 47, 1, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (48, 48, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (49, 49, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (50, 50, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (51, 51, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (52, 52, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (53, 53, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (54, 54, 1, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (55, 55, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (56, 56, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (57, 57, 1, 1, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (58, 58, 1, 1, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (59, 59, 1, 1, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (60, 60, 1, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (61, 61, 1, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (62, 62, 1, 1, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (63, 63, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (64, 64, 1, 1, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (65, 65, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (66, 66, 1, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (67, 67, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (68, 68, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (69, 69, 1, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (70, 70, 1, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (71, 71, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (72, 72, 1, 1, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (73, 73, 1, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (74, 74, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (75, 75, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (76, 76, 1, 1, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (77, 77, 1, 1, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (78, 78, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (79, 79, 1, 1, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (80, 80, 1, 1, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (81, 81, 1, 1, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (82, 82, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (83, 83, 1, 1, CAST(N'2021-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (84, 84, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (85, 85, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (86, 86, 1, 1, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (87, 87, 1, 1, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (88, 88, 1, 1, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (89, 89, 1, 1, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (90, 90, 1, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (91, 91, 1, 1, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (92, 92, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (93, 93, 1, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (94, 94, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (95, 95, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (96, 96, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (97, 97, 1, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (98, 98, 1, 1, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (99, 99, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (100, 100, 1, 1, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
GO
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (101, 101, 1, 1, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (102, 102, 1, 1, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (103, 103, 1, 1, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (104, 104, 1, 1, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (105, 105, 1, 1, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (106, 106, 1, 1, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (107, 107, 1, 1, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (108, 108, 1, 1, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (110, 10, 2, 3, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (111, 11, 2, 3, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (112, 12, 2, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (113, 13, 2, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (114, 14, 2, 3, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (115, 15, 2, 3, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (116, 16, 2, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (117, 17, 2, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (118, 18, 2, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (119, 19, 2, 3, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (120, 20, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (121, 21, 2, 3, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (122, 22, 2, 3, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (123, 23, 2, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (124, 24, 2, 3, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (125, 25, 2, 3, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (126, 26, 2, 3, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (127, 27, 2, 3, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (128, 28, 2, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (129, 29, 2, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (130, 30, 2, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (131, 31, 2, 3, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (132, 32, 2, 3, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (133, 33, 2, 3, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (134, 34, 2, 3, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (135, 35, 2, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (136, 36, 2, 3, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (137, 37, 2, 3, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (138, 38, 2, 3, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (139, 39, 2, 3, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (140, 40, 2, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (141, 41, 2, 3, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (142, 42, 2, 3, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (143, 43, 2, 3, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (144, 44, 2, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (145, 45, 2, 3, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (146, 46, 2, 3, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (147, 47, 2, 3, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (148, 48, 2, 3, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (149, 49, 2, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (150, 50, 2, 3, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (151, 51, 2, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (152, 52, 2, 3, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (153, 53, 2, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (154, 54, 2, 3, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (155, 55, 2, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (156, 56, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (157, 57, 2, 3, CAST(N'2022-06-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (158, 58, 2, 3, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (159, 59, 2, 3, CAST(N'2021-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (160, 60, 2, 3, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (161, 61, 2, 3, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (162, 62, 2, 3, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (163, 63, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (164, 64, 2, 3, CAST(N'2021-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (165, 65, 2, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (166, 66, 2, 3, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (167, 67, 2, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (168, 68, 2, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (169, 69, 2, 3, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (170, 70, 2, 3, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (171, 71, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (172, 72, 2, 3, CAST(N'2022-04-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (173, 73, 2, 3, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (174, 74, 2, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (175, 75, 2, 3, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (176, 76, 2, 3, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (177, 77, 2, 3, CAST(N'2022-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (178, 78, 2, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (179, 79, 2, 3, CAST(N'2021-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (180, 80, 2, 3, CAST(N'2022-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (181, 81, 2, 3, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (182, 82, 2, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (183, 83, 2, 3, CAST(N'2021-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (184, 84, 2, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (185, 85, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (186, 86, 2, 3, CAST(N'2021-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (187, 87, 2, 3, CAST(N'2021-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (188, 88, 2, 3, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (189, 89, 2, 3, CAST(N'2022-09-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (190, 90, 2, 3, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (191, 91, 2, 3, CAST(N'2022-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (192, 92, 2, 3, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (193, 93, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (194, 94, 2, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (195, 95, 2, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (196, 96, 2, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (197, 97, 2, 3, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (198, 98, 2, 3, CAST(N'2022-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (199, 99, 2, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (200, 100, 2, 3, CAST(N'2021-10-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (201, 101, 2, 3, CAST(N'2021-11-01' AS Date), CAST(N'2023-12-31' AS Date))
GO
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (202, 102, 2, 3, CAST(N'2022-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (203, 103, 2, 3, CAST(N'2021-05-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (204, 104, 2, 3, CAST(N'2022-07-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (205, 105, 2, 3, CAST(N'2022-12-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (206, 106, 2, 3, CAST(N'2022-02-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (207, 107, 2, 3, CAST(N'2021-03-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (208, 108, 2, 3, CAST(N'2022-08-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (210, 2, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (211, 1, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (212, 3, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (213, 4, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (214, 6, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (215, 7, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (216, 8, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (217, 9, 3, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (218, 2, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (219, 1, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (220, 3, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (221, 4, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (222, 6, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (223, 7, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (224, 8, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (225, 9, 2, 3, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (226, 2, 4, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (227, 1, 4, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-01-01' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (228, 3, 4, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (229, 4, 4, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (230, 6, 4, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (231, 7, 4, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (232, 8, 4, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[QuaTrinhPhuCap] ([id], [MaNS], [MaPC], [MaHSPC], [TGBatDau], [TGKetThuc]) VALUES (233, 9, 4, 1, CAST(N'2021-01-01' AS Date), CAST(N'2023-12-31' AS Date))
SET IDENTITY_INSERT [dbo].[QuaTrinhPhuCap] OFF
GO
SET IDENTITY_INSERT [dbo].[Quyen] ON 

INSERT [dbo].[Quyen] ([id], [MaQuyen], [TenQuyen]) VALUES (1, N'Q01       ', N'Giám đốc')
INSERT [dbo].[Quyen] ([id], [MaQuyen], [TenQuyen]) VALUES (2, N'Q02       ', N'Trưởng phòng')
INSERT [dbo].[Quyen] ([id], [MaQuyen], [TenQuyen]) VALUES (3, N'Q03       ', N'Nhân viên')
SET IDENTITY_INSERT [dbo].[Quyen] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([id], [MaQuyen], [MaTK], [MaNS], [TaiKhoan], [MatKhau]) VALUES (1, 1, N'TK01      ', 1, N'Truongphong01', N'123456')
INSERT [dbo].[TaiKhoan] ([id], [MaQuyen], [MaTK], [MaNS], [TaiKhoan], [MatKhau]) VALUES (2, 2, N'TK02      ', 2, N'GiamDoc01', N'123456')
INSERT [dbo].[TaiKhoan] ([id], [MaQuyen], [MaTK], [MaNS], [TaiKhoan], [MatKhau]) VALUES (3, NULL, N'TK03      ', NULL, N'Truongphong02', N'123456')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[Thue] ON 

INSERT [dbo].[Thue] ([id], [MaThue], [ThueSuat]) VALUES (7, N'T01       ', 5)
INSERT [dbo].[Thue] ([id], [MaThue], [ThueSuat]) VALUES (8, N'T02       ', 10)
INSERT [dbo].[Thue] ([id], [MaThue], [ThueSuat]) VALUES (9, N'T03       ', 15)
INSERT [dbo].[Thue] ([id], [MaThue], [ThueSuat]) VALUES (10, N'T04       ', 20)
INSERT [dbo].[Thue] ([id], [MaThue], [ThueSuat]) VALUES (11, N'T05       ', 25)
INSERT [dbo].[Thue] ([id], [MaThue], [ThueSuat]) VALUES (12, N'T06       ', 30)
INSERT [dbo].[Thue] ([id], [MaThue], [ThueSuat]) VALUES (13, N'T07       ', 35)
SET IDENTITY_INSERT [dbo].[Thue] OFF
GO
SET IDENTITY_INSERT [dbo].[ThuongPCKhac] ON 

INSERT [dbo].[ThuongPCKhac] ([id], [MaThuong], [NoiDung]) VALUES (1, N'TH01      ', N'Tăng ca')
INSERT [dbo].[ThuongPCKhac] ([id], [MaThuong], [NoiDung]) VALUES (2, N'TH02      ', N'Làm ngày lễ')
INSERT [dbo].[ThuongPCKhac] ([id], [MaThuong], [NoiDung]) VALUES (3, N'THG01     ', N'Tiếp khách hàng')
INSERT [dbo].[ThuongPCKhac] ([id], [MaThuong], [NoiDung]) VALUES (4, N'THG02     ', N'Di chuyển')
SET IDENTITY_INSERT [dbo].[ThuongPCKhac] OFF
GO
ALTER TABLE [dbo].[DongBaoHiem]  WITH CHECK ADD  CONSTRAINT [FK_DongBaoHiem_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[DongBaoHiem] CHECK CONSTRAINT [FK_DongBaoHiem_NhanSu]
GO
ALTER TABLE [dbo].[LuongCoBan]  WITH CHECK ADD  CONSTRAINT [FK_LuongCoBan_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[LuongCoBan] CHECK CONSTRAINT [FK_LuongCoBan_NhanSu]
GO
ALTER TABLE [dbo].[PhuCapNhanSu]  WITH CHECK ADD  CONSTRAINT [FK_PhuCapNhanSu_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[PhuCapNhanSu] CHECK CONSTRAINT [FK_PhuCapNhanSu_NhanSu]
GO
ALTER TABLE [dbo].[QTChucVu]  WITH CHECK ADD  CONSTRAINT [FK_QTChucVu_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([id])
GO
ALTER TABLE [dbo].[QTChucVu] CHECK CONSTRAINT [FK_QTChucVu_PhongBan]
GO
ALTER TABLE [dbo].[QTChucVu]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhChucVu_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([id])
GO
ALTER TABLE [dbo].[QTChucVu] CHECK CONSTRAINT [FK_QuaTrinhChucVu_ChucVu]
GO
ALTER TABLE [dbo].[QTChucVu]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhChucVu_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[QTChucVu] CHECK CONSTRAINT [FK_QuaTrinhChucVu_NhanSu]
GO
ALTER TABLE [dbo].[QTCongTac]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhCongTac_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[QTCongTac] CHECK CONSTRAINT [FK_QuaTrinhCongTac_NhanSu]
GO
ALTER TABLE [dbo].[QTCongTac]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhCongTac_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([id])
GO
ALTER TABLE [dbo].[QTCongTac] CHECK CONSTRAINT [FK_QuaTrinhCongTac_PhongBan]
GO
ALTER TABLE [dbo].[QuaTrinhDongBH]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhDongBH_BaoHiem] FOREIGN KEY([MaBH])
REFERENCES [dbo].[BaoHiem] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhDongBH] CHECK CONSTRAINT [FK_QuaTrinhDongBH_BaoHiem]
GO
ALTER TABLE [dbo].[QuaTrinhDongBH]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhDongBH_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhDongBH] CHECK CONSTRAINT [FK_QuaTrinhDongBH_NhanSu]
GO
ALTER TABLE [dbo].[QuaTrinhDongThue]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhDongThue_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhDongThue] CHECK CONSTRAINT [FK_QuaTrinhDongThue_NhanSu]
GO
ALTER TABLE [dbo].[QuaTrinhDongThue]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhDongThue_Thue] FOREIGN KEY([MaThue])
REFERENCES [dbo].[Thue] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhDongThue] CHECK CONSTRAINT [FK_QuaTrinhDongThue_Thue]
GO
ALTER TABLE [dbo].[QuaTrinhLuong]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhLuong_DMHSLuong] FOREIGN KEY([MaHSL])
REFERENCES [dbo].[DMHSLuong] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhLuong] CHECK CONSTRAINT [FK_QuaTrinhLuong_DMHSLuong]
GO
ALTER TABLE [dbo].[QuaTrinhLuong]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhLuong_DMLuong] FOREIGN KEY([MaML])
REFERENCES [dbo].[DMLuong] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhLuong] CHECK CONSTRAINT [FK_QuaTrinhLuong_DMLuong]
GO
ALTER TABLE [dbo].[QuaTrinhLuong]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhLuong_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhLuong] CHECK CONSTRAINT [FK_QuaTrinhLuong_NhanSu]
GO
ALTER TABLE [dbo].[QuaTrinhPhat]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhPhat_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhPhat] CHECK CONSTRAINT [FK_QuaTrinhPhat_NhanSu]
GO
ALTER TABLE [dbo].[QuaTrinhPhat]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhPhat_Phat1] FOREIGN KEY([MaPhat])
REFERENCES [dbo].[Phat] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhPhat] CHECK CONSTRAINT [FK_QuaTrinhPhat_Phat1]
GO
ALTER TABLE [dbo].[QuaTrinhPhuCap]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhPhuCap_DMHeSoPhuCap] FOREIGN KEY([MaHSPC])
REFERENCES [dbo].[DMHeSoPhuCap] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhPhuCap] CHECK CONSTRAINT [FK_QuaTrinhPhuCap_DMHeSoPhuCap]
GO
ALTER TABLE [dbo].[QuaTrinhPhuCap]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhPhuCap_DMMucPhuCap] FOREIGN KEY([MaPC])
REFERENCES [dbo].[DMMucPhuCap] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhPhuCap] CHECK CONSTRAINT [FK_QuaTrinhPhuCap_DMMucPhuCap]
GO
ALTER TABLE [dbo].[QuaTrinhPhuCap]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhPhuCap_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhPhuCap] CHECK CONSTRAINT [FK_QuaTrinhPhuCap_NhanSu]
GO
ALTER TABLE [dbo].[QuaTrinhThuongPC]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhThuongPC_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhThuongPC] CHECK CONSTRAINT [FK_QuaTrinhThuongPC_NhanSu]
GO
ALTER TABLE [dbo].[QuaTrinhThuongPC]  WITH CHECK ADD  CONSTRAINT [FK_QuaTrinhThuongPC_ThuongPCKhac] FOREIGN KEY([MaThuong])
REFERENCES [dbo].[ThuongPCKhac] ([id])
GO
ALTER TABLE [dbo].[QuaTrinhThuongPC] CHECK CONSTRAINT [FK_QuaTrinhThuongPC_ThuongPCKhac]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanSu]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_Quyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([id])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_Quyen]
GO
ALTER TABLE [dbo].[ThueNhanSu]  WITH CHECK ADD  CONSTRAINT [FK_ThueNhanSu_NhanSu] FOREIGN KEY([MaNS])
REFERENCES [dbo].[NhanSu] ([id])
GO
ALTER TABLE [dbo].[ThueNhanSu] CHECK CONSTRAINT [FK_ThueNhanSu_NhanSu]
GO
