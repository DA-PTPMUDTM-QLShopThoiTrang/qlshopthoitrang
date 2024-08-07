CREATE DATABASE [db_thoitrangtreem]
USE [db_thoitrangtreem]
GO
/****** Object:  Table [dbo].[chitietdonhang]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chitietdonhang](
	[SanPham_id] [int] NOT NULL,
	[DonHang_id] [int] NOT NULL,
	[gia] [float] NOT NULL,
	[soluong] [int] NOT NULL,
 CONSTRAINT [pk_chitietdonhang] PRIMARY KEY CLUSTERED 
(
	[SanPham_id] ASC,
	[DonHang_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[danhgiasanpham]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[danhgiasanpham](
	[KhachHang_id] [int] NOT NULL,
	[sosao] [float] NULL DEFAULT (NULL),
	[binhluan] [nvarchar](255) NULL DEFAULT (NULL),
	[SanPham_id] [int] NOT NULL,
	[DonHang_id] [int] NOT NULL,
	[ngaytao] [datetime] NULL DEFAULT (NULL),
 CONSTRAINT [pk_danhgiasanpham] PRIMARY KEY CLUSTERED 
(
	[KhachHang_id] ASC,
	[DonHang_id] ASC,
	[SanPham_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[danhmuc]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[danhmuc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[diachi]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[diachi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sdt] [varchar](13) NOT NULL,
	[diachi] [nvarchar](255) NOT NULL,
	[diachicuthe] [nvarchar](255) NOT NULL,
	[KhachHang_id] [int] NULL,
	[macdinh] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DM_ManHinh]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DM_ManHinh](
	[MaManHinh] [nvarchar](50) NOT NULL,
	[TenManHinh] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[donhang]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[donhang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tongtien] [float] NOT NULL,
	[ngaytao] [datetime] NULL DEFAULT (getdate()),
	[ngaysua] [datetime] NULL DEFAULT (NULL),
	[TrangThaiDonHang_id] [int] NULL DEFAULT (NULL),
	[KhachHang_id] [int] NULL DEFAULT (NULL),
	[diachi] [nvarchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[giohang]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[giohang](
	[KhachHang_id] [int] NOT NULL,
	[KichCoSanPham_id] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[ngaythem] [datetime] NULL,
 CONSTRAINT [pk_giohang] PRIMARY KEY CLUSTERED 
(
	[KhachHang_id] ASC,
	[KichCoSanPham_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[khachhang]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[khachhang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[matkhau] [varchar](255) NOT NULL,
	[sdt] [varchar](13) NULL DEFAULT (NULL),
	[ten] [nvarchar](100) NULL DEFAULT (NULL),
	[forgotToken] [varchar](555) NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[khuyenmai]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[khuyenmai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](255) NULL DEFAULT (NULL),
	[phantram] [float] NOT NULL,
	[thoigian_bd] [datetime] NOT NULL,
	[thoigian_kt] [datetime] NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kichcosanpham]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kichcosanpham](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kichco] [varchar](50) NOT NULL,
	[soluong] [int] NOT NULL,
	[SanPham_id] [int] NULL DEFAULT (NULL),
	[LoaiSanPham_id] [int] NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[loaisanpham]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[loaisanpham](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mausac] [nvarchar](50) NOT NULL,
	[hinhanh] [text] NOT NULL,
	[SanPham_id] [int] NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_NguoiDung]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDung](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](100) NULL,
	[HoatDong] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_NguoiDungNhomNguoiDung]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NguoiDungNhomNguoiDung](
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MaNhomNguoiDung] [nvarchar](20) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
 CONSTRAINT [pk_nguoidungnhomnguoidung] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhomNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_NhomNguoiDung]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_NhomNguoiDung](
	[MaNhom] [nvarchar](20) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QL_PhanQuyen]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QL_PhanQuyen](
	[MaNhomNguoiDung] [nvarchar](20) NOT NULL,
	[MaManHinh] [nvarchar](50) NOT NULL,
	[CoQuyen] [bit] NOT NULL,
 CONSTRAINT [pk_QL_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[MaNhomNguoiDung] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sanpham]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sanpham](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](250) NOT NULL,
	[mota] [nvarchar](1000) NULL DEFAULT (NULL),
	[gia] [float] NOT NULL,
	[gioitinh] [nvarchar](10) NOT NULL DEFAULT ('unisex'),
	[ngaytao] [datetime] NOT NULL DEFAULT (getdate()),
	[DanhMuc_id] [int] NOT NULL,
	[KhuyenMai_id] [int] NULL DEFAULT (NULL),
	[anhdaidien] [text] NULL DEFAULT (NULL),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[trangthaidonhang]    Script Date: 30/07/2024 10:58:55 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trangthaidonhang](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[trangthai] [nvarchar](55) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[chitietdonhang] ([SanPham_id], [DonHang_id], [gia], [soluong]) VALUES (20, 65, 73470, 3)
INSERT [dbo].[chitietdonhang] ([SanPham_id], [DonHang_id], [gia], [soluong]) VALUES (20, 69, 73470, 1)
INSERT [dbo].[chitietdonhang] ([SanPham_id], [DonHang_id], [gia], [soluong]) VALUES (20, 70, 73470, 1)
INSERT [dbo].[chitietdonhang] ([SanPham_id], [DonHang_id], [gia], [soluong]) VALUES (111, 67, 119400, 1)
INSERT [dbo].[chitietdonhang] ([SanPham_id], [DonHang_id], [gia], [soluong]) VALUES (111, 71, 119400, 1)
INSERT [dbo].[chitietdonhang] ([SanPham_id], [DonHang_id], [gia], [soluong]) VALUES (115, 66, 119400, 1)
INSERT [dbo].[chitietdonhang] ([SanPham_id], [DonHang_id], [gia], [soluong]) VALUES (118, 68, 119400, 4)
INSERT [dbo].[danhgiasanpham] ([KhachHang_id], [sosao], [binhluan], [SanPham_id], [DonHang_id], [ngaytao]) VALUES (28, 4, N'Sản phẩm đẹp.', 20, 65, CAST(N'2024-05-24 20:37:39.000' AS DateTime))
INSERT [dbo].[danhgiasanpham] ([KhachHang_id], [sosao], [binhluan], [SanPham_id], [DonHang_id], [ngaytao]) VALUES (28, 5, N'Tốt', 115, 66, CAST(N'2024-05-24 20:38:54.000' AS DateTime))
INSERT [dbo].[danhgiasanpham] ([KhachHang_id], [sosao], [binhluan], [SanPham_id], [DonHang_id], [ngaytao]) VALUES (28, 3, N'Tạm được', 111, 67, CAST(N'2024-05-24 20:38:47.000' AS DateTime))
INSERT [dbo].[danhgiasanpham] ([KhachHang_id], [sosao], [binhluan], [SanPham_id], [DonHang_id], [ngaytao]) VALUES (28, 2, N'Tệ', 118, 68, CAST(N'2024-05-24 20:38:40.000' AS DateTime))
INSERT [dbo].[danhgiasanpham] ([KhachHang_id], [sosao], [binhluan], [SanPham_id], [DonHang_id], [ngaytao]) VALUES (29, 3, N'3432432', 20, 69, CAST(N'2024-05-24 20:43:27.000' AS DateTime))
INSERT [dbo].[danhgiasanpham] ([KhachHang_id], [sosao], [binhluan], [SanPham_id], [DonHang_id], [ngaytao]) VALUES (29, 3, N'ádadad', 20, 70, CAST(N'2024-05-24 20:43:22.000' AS DateTime))
INSERT [dbo].[danhgiasanpham] ([KhachHang_id], [sosao], [binhluan], [SanPham_id], [DonHang_id], [ngaytao]) VALUES (29, 3, N'Áo phông unisex trẻ em 3TS24S003SG631', 111, 71, CAST(N'2024-05-24 20:43:19.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[danhmuc] ON 

INSERT [dbo].[danhmuc] ([id], [ten]) VALUES (1, N'Áo')
INSERT [dbo].[danhmuc] ([id], [ten]) VALUES (2, N'Quần')
INSERT [dbo].[danhmuc] ([id], [ten]) VALUES (3, N'Nón')
INSERT [dbo].[danhmuc] ([id], [ten]) VALUES (4, N'Giày')
INSERT [dbo].[danhmuc] ([id], [ten]) VALUES (5, N'Phụ kiện')
SET IDENTITY_INSERT [dbo].[danhmuc] OFF
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH01', N'Danh mục màn hình')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH02', N'Danh mục người dùng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH03', N'Danh mục nhóm người dùng')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH04', N'Phân quyền')
INSERT [dbo].[DM_ManHinh] ([MaManHinh], [TenManHinh]) VALUES (N'MH05', N'Thêm người  dùng vào nhóm')
SET IDENTITY_INSERT [dbo].[donhang] ON 

INSERT [dbo].[donhang] ([id], [tongtien], [ngaytao], [ngaysua], [TrangThaiDonHang_id], [KhachHang_id], [diachi]) VALUES (65, 220410, CAST(N'2024-04-16 22:35:58.000' AS DateTime), CAST(N'2024-04-20 22:35:58.000' AS DateTime), 3, 28, N'1312312313, ádfsadf, Thành phố Hải Phòng, Quận Lê Chân, Phường Lam Sơn')
INSERT [dbo].[donhang] ([id], [tongtien], [ngaytao], [ngaysua], [TrangThaiDonHang_id], [KhachHang_id], [diachi]) VALUES (66, 119400, CAST(N'2024-05-24 20:37:57.000' AS DateTime), CAST(N'2024-05-24 20:38:30.000' AS DateTime), 3, 28, N'1312312313, ádfsadf, Thành phố Hải Phòng, Quận Lê Chân, Phường Lam Sơn')
INSERT [dbo].[donhang] ([id], [tongtien], [ngaytao], [ngaysua], [TrangThaiDonHang_id], [KhachHang_id], [diachi]) VALUES (67, 119400, CAST(N'2024-05-24 20:38:04.000' AS DateTime), CAST(N'2024-05-24 20:38:28.000' AS DateTime), 3, 28, N'1312312313, ádfsadf, Thành phố Hải Phòng, Quận Lê Chân, Phường Lam Sơn')
INSERT [dbo].[donhang] ([id], [tongtien], [ngaytao], [ngaysua], [TrangThaiDonHang_id], [KhachHang_id], [diachi]) VALUES (68, 477600, CAST(N'2024-05-24 20:38:13.000' AS DateTime), CAST(N'2024-05-24 20:38:26.000' AS DateTime), 3, 28, N'1312312313, ádfsadf, Thành phố Hải Phòng, Quận Lê Chân, Phường Lam Sơn')
INSERT [dbo].[donhang] ([id], [tongtien], [ngaytao], [ngaysua], [TrangThaiDonHang_id], [KhachHang_id], [diachi]) VALUES (69, 73470, CAST(N'2024-05-24 20:41:13.000' AS DateTime), CAST(N'2024-05-24 20:43:05.000' AS DateTime), 3, 29, N'23123123332, sdafasdf, Thành phố Hồ Chí Minh, Quận Gò Vấp, Phường 17')
INSERT [dbo].[donhang] ([id], [tongtien], [ngaytao], [ngaysua], [TrangThaiDonHang_id], [KhachHang_id], [diachi]) VALUES (70, 73470, CAST(N'2024-05-24 20:41:22.000' AS DateTime), CAST(N'2024-05-24 20:41:58.000' AS DateTime), 3, 29, N'23123123332, sdafasdf, Thành phố Hồ Chí Minh, Quận Gò Vấp, Phường 17')
INSERT [dbo].[donhang] ([id], [tongtien], [ngaytao], [ngaysua], [TrangThaiDonHang_id], [KhachHang_id], [diachi]) VALUES (71, 119400, CAST(N'2024-05-24 20:41:43.000' AS DateTime), CAST(N'2024-05-24 20:41:55.000' AS DateTime), 3, 29, N'23123123332, sdafasdf, Thành phố Hồ Chí Minh, Quận Gò Vấp, Phường 17')
SET IDENTITY_INSERT [dbo].[donhang] OFF
SET IDENTITY_INSERT [dbo].[khachhang] ON 

INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (2, N'admin@gmail.com', N'admin', N'0123413', N'admin', NULL)
INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (16, N'vu@gmail.com', N'$2y$10$o0hGnxCMoUuPNPQurcTX5.69ZZlOZXO4Ur1EuK8TOIJumhlQG6KNq', N'012314132', N'Nguyễn Vu', NULL)
INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (21, N'user1@gmail.com', N'$2y$10$vJfTP8Q8o5Ibo4j936uSZe4xteTxeyuwkVVRHVs.QZXCNG/U8jV1y', NULL, N'Nguyen Van B', NULL)
INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (22, N'vu1@gmail.com', N'$2y$10$FxD/.v1PkFrqTHK.AwvFgebWiZsqUEMFqsltItP9uPn3s1L3/3bEK', NULL, N'Nguyen Vu', NULL)
INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (23, N'vu2@gmail.com', N'$2y$10$rnQ0.LSs2owCiW2ms.ULNee0TeJsIySGg17ki9z5Ub.jAHHn38sEy', NULL, N'Vu Truong', N'4d53382d71cc8789f4ca48d01b370c837069d693')
INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (24, N'vu3@gmail.com', N'$2y$10$R2tEnRlzHDd05dGuMGkt9.N9AD4EUkX6f5M16qm5C/SR8b.T6S8AK', NULL, N'ABCDEFGH', NULL)
INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (28, N'user101@gmail.com', N'$2y$10$Y9vTqFcsB.u3NjiOmDVd4uappmufibXUr04WukrgzRTBZgDKCPZNi', NULL, N'user10100000', NULL)
INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (29, N'user102@gmail.com', N'$2y$10$O1TIotv8ZKxJ2GWveaU5E.7CIYPjsnVNCAQJiW4XasndE.kL0kVGa', NULL, N'user1020000', NULL)
INSERT [dbo].[khachhang] ([id], [email], [matkhau], [sdt], [ten], [forgotToken]) VALUES (37, N'nguyenvu492003@gmail.com', N'$2y$10$91rDKyaZbKMHy.XVlhl/eOtwuk2E2y2xFAvwhci8wRXlkFv02/nHq', NULL, N'Truong vu', NULL)
SET IDENTITY_INSERT [dbo].[khachhang] OFF
SET IDENTITY_INSERT [dbo].[khuyenmai] ON 

INSERT [dbo].[khuyenmai] ([id], [ten], [phantram], [thoigian_bd], [thoigian_kt]) VALUES (5, N'Khuyến mãi 5', 9.98, CAST(N'2024-02-11 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[khuyenmai] ([id], [ten], [phantram], [thoigian_bd], [thoigian_kt]) VALUES (27, N'Khuyến mãi 27', 50, CAST(N'2024-04-20 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[khuyenmai] ([id], [ten], [phantram], [thoigian_bd], [thoigian_kt]) VALUES (28, N'Khuyến mãi 28', 40, CAST(N'2024-05-03 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[khuyenmai] ([id], [ten], [phantram], [thoigian_bd], [thoigian_kt]) VALUES (29, N'Khuyến mãi 29', 10, CAST(N'2024-05-12 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[khuyenmai] ([id], [ten], [phantram], [thoigian_bd], [thoigian_kt]) VALUES (30, N'Khuyến mãi 30', 7, CAST(N'2024-05-19 00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[khuyenmai] ([id], [ten], [phantram], [thoigian_bd], [thoigian_kt]) VALUES (31, N'Khuyến mãi 31', 12, CAST(N'2024-05-25 00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[khuyenmai] OFF
SET IDENTITY_INSERT [dbo].[kichcosanpham] ON 

INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (7, N'S', 1233, 19, 5)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (8, N'M', 32, 19, 5)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (9, N'L', 2, 19, 5)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (10, N'S', 12, 19, 6)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (11, N'M', 1, 19, 6)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (12, N'L', 5, 19, 6)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (13, N'S', 327, 19, 7)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (16, N'S', 0, 20, 8)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (17, N'M', 0, 20, 8)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (18, N'L', 4, 20, 8)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (19, N'S', 6, 20, 9)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (20, N'M', 2, 20, 9)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (21, N'L', 20, 20, 9)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (22, N'S', 8, 20, 10)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (23, N'M', 15, 20, 10)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (24, N'L', 44, 20, 10)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (111, N'98', 0, 41, 63)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (112, N'99', 9, 41, 63)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (113, N'100', 1, 41, 63)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (114, N'98', 1, 41, 64)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (115, N'99', 0, 41, 64)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (116, N'100', 3, 41, 64)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (117, N'98', 4, 41, 65)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (118, N'99', 0, 41, 65)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (119, N'100', 0, 41, 65)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (120, N'99', 1, 42, 66)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (121, N'100', 34, 42, 66)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (122, N'99', 3, 42, 67)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (123, N'100', 4, 42, 67)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (124, N'99', 1, 43, 68)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (125, N'100', 23, 43, 68)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (126, N'99', 1, 43, 69)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (127, N'100', 5, 43, 69)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (128, N'99', 12, 43, 70)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (129, N'100', 3, 43, 70)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (130, N'98', 1, 44, 71)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (131, N'99', 4, 44, 71)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (132, N'100', 3, 44, 71)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (133, N'98', 2, 44, 72)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (134, N'99', 3, 44, 72)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (135, N'100', 2, 44, 72)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (136, N'99', 3, 45, 73)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (137, N'100', 3, 45, 73)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (138, N'101', 32, 45, 73)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (139, N'99', 1, 46, 74)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (140, N'100', 3, 46, 74)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (141, N'101', 2, 46, 74)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (142, N'99', 3, 46, 75)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (143, N'100', 5, 46, 75)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (144, N'99', 2, 47, 76)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (145, N'100', 4, 47, 76)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (146, N'99', 3, 47, 77)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (147, N'100', 6, 47, 77)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (148, N'101', 23, 47, 77)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (149, N'99', 1, 48, 78)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (150, N'100', 2, 48, 78)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (151, N'101', 4, 48, 78)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (152, N'99', 4, 48, 79)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (153, N'100', 4, 48, 79)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (154, N'101', 3, 48, 79)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (155, N'99', 12, 49, 80)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (156, N'99', 0, 50, 81)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (157, N'100', 3, 50, 81)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (158, N'101', 4, 50, 81)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (159, N'99', 4, 50, 82)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (160, N'100', 6, 50, 82)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (161, N'99', 5, 51, 83)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (162, N'100', 3, 51, 83)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (163, N'101', 2, 51, 83)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (164, N'99', 3, 52, 84)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (165, N'100', 6, 52, 84)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (166, N'99', 7, 52, 85)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (167, N'100', 5, 52, 85)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (168, N'101', 2, 52, 85)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (169, N'99', 4, 53, 86)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (170, N'98', 7, 53, 87)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (171, N'99', 7, 53, 87)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (172, N'99', 6, 54, 88)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (173, N'100', 2, 54, 88)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (174, N'99', 3, 54, 89)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (175, N'100', 5, 54, 89)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (176, N'99', 6, 55, 90)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (177, N'100', 12, 55, 90)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (178, N'101', 34, 55, 90)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (179, N'102', 33, 55, 90)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (180, N'99', 6, 56, 91)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (181, N'100', 3, 56, 91)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (182, N'102', 3, 56, 91)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (183, N'99', 5, 57, 92)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (184, N'100', 3, 57, 92)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (185, N'99', 4, 57, 93)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (186, N'100', 3, 57, 93)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (187, N'102', 3, 57, 93)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (188, N'99', 6, 58, 94)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (189, N'100', 4, 59, 95)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (190, N'99', 213, 59, 96)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (191, N'99', 5, 59, 97)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (192, N'100', 6, 59, 97)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (193, N'101', 34, 59, 97)
GO
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (194, N'1', 2, 60, 98)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (195, N'1', 333, 60, 99)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (196, N'4/6', 4, 61, 100)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (197, N'7/9', 6, 61, 100)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (198, N'10/12', 12, 61, 100)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (199, N'4/6', 4, 61, 101)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (200, N'7/9', 45, 61, 101)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (201, N'10/12', 12, 61, 101)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (202, N'4/6', 4, 61, 102)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (203, N'7/9', 21, 61, 102)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (204, N'10/12', 23, 61, 102)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (206, N'1', 2, 63, 104)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (207, N'1', 2, 64, 105)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (208, N'30', 3, 65, 106)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (209, N'31', 2, 65, 106)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (210, N'32', 5, 65, 106)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (211, N'29', 4, 65, 107)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (212, N'30', 7, 65, 107)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (218, N'30', 7, 67, 110)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (219, N'31', 4, 67, 110)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (220, N'31', 4, 67, 111)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (221, N'32', 4, 67, 111)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (222, N'1', 23, 68, 112)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (223, N'1', 2, 68, 113)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (224, N'1', 33, 69, 114)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (225, N'1', 34, 69, 115)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (226, N'99', 12, 70, 116)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (227, N'100', 3, 70, 116)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (236, N'1', 1, 64, 125)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (237, N'1', 1, 72, 126)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (238, N'2', 2, 72, 126)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (240, N'2', 3, 72, 127)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (241, N'34', 4, 72, 127)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (242, N'90', 10, 73, 128)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (243, N'2/3', 12, 74, 129)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (244, N'1', 12, 75, 130)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (245, N'1', 12, 76, 131)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (246, N'1', 110, 77, 132)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (247, N'1', 110, 78, 133)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (248, N'90', 22, 79, 134)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (249, N'90', 22, 80, 135)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (250, N'90', 4, 81, 136)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (251, N'91', 12, 82, 137)
INSERT [dbo].[kichcosanpham] ([id], [kichco], [soluong], [SanPham_id], [LoaiSanPham_id]) VALUES (252, N'test', 2, 64, 138)
SET IDENTITY_INSERT [dbo].[kichcosanpham] OFF
SET IDENTITY_INSERT [dbo].[loaisanpham] ON 

INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (5, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimg_021-1.jfif-Sun%20Feb%2004%202024%2017%3A07%3A09%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=3dfbf373-546b-4b66-92ec-11ad4c9d8a67', 19)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (6, N'Ðỏ', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimg_021-2.jfif-Sun%20Feb%2004%202024%2017%3A07%3A24%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=dd56cda9-07d9-415f-951e-5127c6f92c22', 19)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (7, N'Trắng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimg_021-3.jfif-Sun%20Feb%2004%202024%2017%3A07%3A40%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=ee2ebf8e-f709-4d81-9bb9-8b925e0a0262', 19)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (8, N'Đỏ', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimg_023-1.jfif-Sun%20Feb%2004%202024%2017%3A08%3A45%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=dbe60c21-4abf-4814-a020-4fcec46fc702', 20)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (9, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimg_023-2.jfif-Sun%20Feb%2004%202024%2017%3A08%3A59%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=4d5d9fc9-9a00-4b86-8a2e-7fec186499cd', 20)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (10, N'Trắng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimg_023-3.jfif-Sun%20Feb%2004%202024%2017%3A09%3A14%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=36b6fae1-a6b7-49dd-adb5-dcda493be722', 20)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (63, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.1.webp-Thu%20May%2002%202024%2015%3A53%3A04%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=6e4af672-48bc-410b-b1db-bbf1c3d7d0f7', 41)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (64, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.2.webp-Thu%20May%2002%202024%2015%3A53%3A38%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=6df0fb1b-c699-4d9d-92f0-26b5c27c9375', 41)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (65, N'Trắng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.3.webp-Thu%20May%2002%202024%2015%3A53%3A54%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=20117a4b-7619-4286-85f8-2daae4f9da64', 41)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (66, N'Xám', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh2.1.webp-Thu%20May%2002%202024%2016%3A00%3A33%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=d9b9bc5e-fda6-4ef6-b309-0ec18b0709f4', 42)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (67, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh2.2.webp-Thu%20May%2002%202024%2016%3A00%3A47%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=9e935e6e-b7d1-4721-bc26-11c33592e70e', 42)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (68, N'Tím', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh3.1.webp-Thu%20May%2002%202024%2016%3A02%3A27%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=337fe735-f801-4c4b-a4b9-0775fde72e28', 43)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (69, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh3.2.webp-Thu%20May%2002%202024%2016%3A03%3A16%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=e3184342-d7ca-410c-a59f-4178525ee07d', 43)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (70, N'Trắng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh3.3.webp-Thu%20May%2002%202024%2016%3A03%3A34%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=9cabdac1-d42f-4520-b0da-384ecca3a020', 43)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (71, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh4.1.webp-Thu%20May%2002%202024%2016%3A04%3A50%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=03115d5c-be46-4d5d-a4f1-46adcb2b70cc', 44)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (72, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh4.2.webp-Thu%20May%2002%202024%2016%3A05%3A07%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=e7fb7ce0-565b-4adb-a2dc-15ae998eb356', 44)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (73, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh5.1.webp-Thu%20May%2002%202024%2016%3A06%3A20%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=54dc1d17-1019-48fb-bf50-1df2bba0939a', 45)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (74, N'Xanh duong', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh6.1.webp-Thu%20May%2002%202024%2016%3A07%3A39%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=de9e59f1-7adf-4ced-9797-2da326d3a620', 46)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (75, N'Xanh lá ', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh6.2.webp-Thu%20May%2002%202024%2016%3A07%3A53%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=19a20f54-c466-47ec-be33-1952daaadbf8', 46)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (76, N'Xanh dương', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh7.1.webp-Thu%20May%2002%202024%2016%3A11%3A07%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=bdead8fc-5aa6-4549-8b30-13ace6bf5a32', 47)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (77, N'Vàng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh7.2.webp-Thu%20May%2002%202024%2016%3A11%3A20%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=6fdd3b23-8881-4353-8daf-7fdf7ea5c31b', 47)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (78, N'Xanh den', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.1.webp-Thu%20May%2002%202024%2016%3A12%3A28%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=35a92e99-ed33-4966-a4b8-6c2069a5de96', 48)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (79, N'Nâu Trắng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.2.webp-Thu%20May%2002%202024%2016%3A12%3A42%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=83e36a1c-f410-408b-9aec-4a8e4e62a56c', 48)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (80, N'X', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.3.webp-Thu%20May%2002%202024%2016%3A14%3A25%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=81fe28d8-e564-49ca-a67c-c5e205440476', 49)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (81, N'Hồng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.4.webp-Thu%20May%2002%202024%2018%3A49%3A43%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=f58d1b6c-8a22-49fd-b193-3bf014918ee8', 50)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (82, N'Tím', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.5.webp-Thu%20May%2002%202024%2018%3A50%3A02%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=79d8b698-a9c6-40e5-b9cf-af4125becbd8', 50)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (83, N'Hồng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.6.webp-Thu%20May%2002%202024%2018%3A50%3A52%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=30098593-c946-441b-a096-36df00c37ec9', 51)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (84, N'Tím', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.7.webp-Thu%20May%2002%202024%2018%3A52%3A15%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=9a403820-7765-41d3-9ef6-b4568a10de37', 52)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (85, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.8.webp-Thu%20May%2002%202024%2018%3A52%3A24%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=cbf886fa-1e2d-4f4b-80be-0fa05b803326', 52)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (86, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.9.webp-Thu%20May%2002%202024%2018%3A54%3A04%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=2d63dca3-2640-4c62-a8fc-934c56c3b3b2', 53)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (87, N'Tím', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.1.webp-Thu%20May%2002%202024%2018%3A54%3A11%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=e87077aa-e64f-42af-92bc-d2667d3160f4', 53)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (88, N'Hồng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.3.webp-Thu%20May%2002%202024%2018%3A55%3A09%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=697a7ae9-6100-4ced-b869-618ff9f84518', 54)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (89, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.2.webp-Thu%20May%2002%202024%2018%3A55%3A28%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=1c2cf5cb-9440-432d-8f5a-3d21ca53a82d', 54)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (90, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.4.webp-Thu%20May%2002%202024%2018%3A56%3A09%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=146bdb74-13d1-4121-ae73-9edeb309cc41', 55)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (91, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.5.webp-Thu%20May%2002%202024%2018%3A57%3A30%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=4b7ee749-84f5-4a69-8e50-75910a3bfcee', 56)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (92, N'Be', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.7.webp-Thu%20May%2002%202024%2018%3A58%3A38%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=15a73735-639f-476f-817c-002786efbd35', 57)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (93, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.6.webp-Thu%20May%2002%202024%2018%3A59%3A02%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=4904c0d2-9060-47c7-922f-b73acb3d6231', 57)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (94, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.8.webp-Thu%20May%2002%202024%2018%3A59%3A46%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=2aaa6429-ec01-4c31-b8da-a76be70b5f1d', 58)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (95, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.1.webp-Thu%20May%2002%202024%2019%3A03%3A05%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=635f2e27-6f31-4074-ac60-961976990be1', 59)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (96, N'Be', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.2.webp-Thu%20May%2002%202024%2019%3A03%3A12%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=3af6c627-7220-48e7-9ebc-2f0665a66bd5', 59)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (97, N'Hồng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.webp-Thu%20May%2002%202024%2019%3A03%3A20%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=da40bac5-58ec-48a0-b93f-e9458ae4317d', 59)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (98, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.4.webp-Thu%20May%2002%202024%2019%3A20%3A02%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=4eb5572b-694c-47f1-9021-82bfe47800c8', 60)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (99, N'Xám', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.5.webp-Thu%20May%2002%202024%2019%3A20%3A20%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=aff4f2b6-e09c-4aef-bbda-569b72af5c17', 60)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (100, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.6.webp-Thu%20May%2002%202024%2019%3A21%3A37%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=e5114dd2-e39c-4dad-8361-6d992e533c6b', 61)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (101, N'Ð?', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.7.webp-Thu%20May%2002%202024%2019%3A21%3A56%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=36e507e3-8aa9-4527-bb93-429aa2e537d7', 61)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (102, N'Trắng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.8.webp-Thu%20May%2002%202024%2019%3A22%3A17%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=12c63304-ae1c-42ca-9cfd-3fdc09d83f0f', 61)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (104, N's', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.1.webp-Sun%20May%2012%202024%2012%3A21%3A05%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=3acc54c2-632f-42fc-9580-2821833931be', 63)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (105, N'1', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimage_black.jpg-Sun%20May%2012%202024%2012%3A51%3A01%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=76b0b77a-8dca-415e-98b8-760177fc04e7', 64)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (106, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.91.webp-Sun%20May%2012%202024%2013%3A02%3A46%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=19765c7e-c775-480d-a686-f146c1caf18e', 65)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (107, N'Xanh nh?t', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.92.webp-Sun%20May%2012%202024%2013%3A03%3A03%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=b4578228-20fb-4a8c-947f-5720975ab437', 65)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (110, N'Hồng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.94.webp-Sun%20May%2012%202024%2013%3A06%3A34%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=6f5acd8e-1ea1-4363-a42d-360445f417e6', 67)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (111, N'Xám', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.95.webp-Sun%20May%2012%202024%2013%3A06%3A47%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=09172f61-cc61-4896-b9db-4d5fab06e5f7', 67)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (112, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.97.webp-Sun%20May%2012%202024%2013%3A08%3A43%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=621f80f5-94dc-404f-8c5b-7d6c6beeab85', 68)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (113, N'Tím', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.96.webp-Sun%20May%2012%202024%2013%3A08%3A54%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=dcdf9b0a-79ee-4010-929b-d37c735ee722', 68)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (114, N'Trắng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9891.webp-Sun%20May%2012%202024%2013%3A10%3A58%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=7f46322e-ef0f-4adb-a75c-40f931c66581', 69)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (115, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.989.webp-Sun%20May%2012%202024%2013%3A11%3A09%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=85706139-4305-40a0-b973-afecc89c7e43', 69)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (116, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.1.webp-Sat%20May%2025%202024%2011%3A14%3A44%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=dd269497-715b-4b36-8bb2-dd1a3f5982de', 70)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (117, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.2.webp-Sat%20May%2025%202024%2011%3A15%3A53%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=ef5620fb-d856-434b-9139-55a305e1c52f', 70)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (125, N'đen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.2.webp-Sun%20May%2026%202024%2021%3A53%3A48%20GMT%2B0700%20(Indochina%20Time)?alt=media&token=3b3af381-c859-46f9-8095-22e96a3fd7da', 64)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (126, N'Trang', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9891.webp-Sun%20May%2026%202024%2022%3A06%3A45%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=28dc2251-7ac9-4316-8654-1e33063d8c8d', 72)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (127, N'den', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.2.webp-Sun%20May%2026%202024%2022%3A07%3A33%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=47aeb472-a48d-4c89-9ab6-cf2a7c7735e0', 72)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (128, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9892.webp-Sun%20Jun%2002%202024%2021%3A30%3A36%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=798e4bf1-b8b6-4ddc-8527-f229ac12ab84', 73)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (129, N'Xám', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9893.webp-Sun%20Jun%2002%202024%2021%3A31%3A52%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=437458a8-fc41-4570-9edf-882e2b305401', 74)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (130, N'Hồng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9894.webp-Sun%20Jun%2002%202024%2021%3A32%3A59%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=f47f053c-a987-43bb-a907-d3a19f1466b3', 75)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (131, N'Hồng', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9894.webp-Sun%20Jun%2002%202024%2021%3A32%3A59%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=f47f053c-a987-43bb-a907-d3a19f1466b3', 76)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (132, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9895.webp-Sun%20Jun%2002%202024%2021%3A34%3A09%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=8bf9ce6a-226e-4c10-a41b-9fa1488fcd02', 77)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (133, N'Xanh', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9895.webp-Sun%20Jun%2002%202024%2021%3A34%3A09%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=8bf9ce6a-226e-4c10-a41b-9fa1488fcd02', 78)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (134, N'Be', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9897.webp-Sun%20Jun%2002%202024%2021%3A35%3A27%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=fe307e47-889a-4a33-a3da-adfc8eb8908d', 79)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (135, N'Be', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9897.webp-Sun%20Jun%2002%202024%2021%3A35%3A27%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=fe307e47-889a-4a33-a3da-adfc8eb8908d', 80)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (136, N'Ðen', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9898.webp-Sun%20Jun%2002%202024%2021%3A36%3A44%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=328d1216-8a69-4b11-ab60-3a2fe0e1d917', 81)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (137, N'Xám', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9899.webp-Sun%20Jun%2002%202024%2021%3A37%3A38%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=475d9e1c-8693-439c-80fc-096b26b913c0', 82)
INSERT [dbo].[loaisanpham] ([id], [mausac], [hinhanh], [SanPham_id]) VALUES (138, N'test', N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh5.1.webp-Sun%20Jun%2002%202024%2021%3A51%3A12%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=27a499b9-9c6e-4f7f-8e5e-cf79b9bbde57', 64)
SET IDENTITY_INSERT [dbo].[loaisanpham] OFF
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'user1', N'user1', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'user2', N'user2', 1)
INSERT [dbo].[QL_NguoiDung] ([TenDangNhap], [MatKhau], [HoatDong]) VALUES (N'user3', N'user3', 1)
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'admin', N'NHD01', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'user1', N'NHD02', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'user2', N'NHD03', N'')
INSERT [dbo].[QL_NguoiDungNhomNguoiDung] ([TenDangNhap], [MaNhomNguoiDung], [GhiChu]) VALUES (N'user3', N'NHD03', N'')
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHD01', N'Admin', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHD02', N'Nhân viên thu ngân', NULL)
INSERT [dbo].[QL_NhomNguoiDung] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHD03', N'Nhân viên nhân sự', NULL)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD01', N'MH01', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD01', N'MH02', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD01', N'MH03', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD01', N'MH04', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD01', N'MH05', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD02', N'MH01', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD02', N'MH02', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD02', N'MH03', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD03', N'MH01', 0)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD03', N'MH02', 1)
INSERT [dbo].[QL_PhanQuyen] ([MaNhomNguoiDung], [MaManHinh], [CoQuyen]) VALUES (N'NHD03', N'MH03', 1)
SET IDENTITY_INSERT [dbo].[sanpham] ON 

INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (19, N'Áo phông unisex trẻ em CANIFA in Chip &amp; Dale 100% cotton, cổ tròn tra bo, tay cộc', N'Sản phẩm Áo phông unisex trẻ em CANIFA in Chip &amp; Dale  100% cotton, cổ tròn tra bo, tay cộc 3TS23S003 được thiết kế, sản xuất và phân phối độc quyền bởi CANIFA - thương hiệu thời trang Việt Nam được nhiều khách hàng tin tưởng sử dụng từ năm 2001. Với hệ thống hơn 100 cửa hàng và đại lý phân phối khắp toàn quốc.', 200000, N'unisex', CAST(N'2024-02-04 17:08:01.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimg_021-3.jfif-Sun%20Feb%2004%202024%2017%3A07%3A40%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=ee2ebf8e-f709-4d81-9bb9-8b925e0a0262')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (20, N'Áo phông bé gái CANIFA cotton USA in hình Mickey dẽ thương cổ tròn cộc tay màu trắng đỏ xanh', N'MICKEY COLLECTION - TRUYỀN CẢM HỨNG MẠNH MẼ TINH THẦN LẠC QUAN ĐẾN HÀNG TRIỆU KHÁCH HÀNG Kể từ năm 1928 tới nay, Mickey vẫn luôn là chú chuột được yêu thích nhất trên toàn thế giới với dáng điệu đáng yêu, vui vẻ, lạc quan và luôn ham mê khám phá. Nhân dịp kỉ niệm 90 năm sinh nhật chú chuột Mickey, CANIFA tiếp tục cho ra mắt bộ sưu tập áo phông gia đình cực cool với thiết kế hình in độc quyền, đáng yêu với màu sắc nổi bật cho cả gia đình. Rất thích hợp mặc trong những buổi dã ngoại cuối tuần để c', 79000, N'nữ', CAST(N'2024-02-04 17:09:30.000' AS DateTime), 1, 30, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fimg_023-3.jfif-Sun%20Feb%2004%202024%2017%3A09%3A14%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=36b6fae1-a6b7-49dd-adb5-dcda493be722')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (41, N'Áo phông unisex trẻ em 3TS24S003SG631', N'Chất liệu: 100% cotton.\r\nHướng dẫn sử dụng: \r\nGiặt máy ở chế độ nhẹ, nhiệt độ thường.\r\nKhông sử dụng hóa chất tẩy có chứa Clo.\r\nPhơi trong bóng mát.\r\nSấy thùng, chế độ nhẹ nhàng.\r\nLà ở nhiệt độ trung bình 150 độ C.\r\nGiặt với sản phẩm cùng màu.\r\nKhông là lên chi tiết trang trí.', 199000, N'unisex', CAST(N'2024-05-02 15:54:26.000' AS DateTime), 1, 28, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.3.webp-Thu%20May%2002%202024%2015%3A53%3A54%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=20117a4b-7619-4286-85f8-2daae4f9da64')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (42, N'Áo phông bé trai in Marvel 2TS24S008', N'Áo phông bé trai in hình nhân vật Marvel khỏe khoắn, chất liệu cotton thoáng mát mềm mại, hình in mạnh mẽ phù hợp cho sở thích của các bé.', 249000, N'nam', CAST(N'2024-05-02 16:01:03.000' AS DateTime), 1, 28, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh2.2.webp-Thu%20May%2002%202024%2016%3A00%3A47%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=9e935e6e-b7d1-4721-bc26-11c33592e70e')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (43, N'Áo phông unisex trẻ em cotton có hình in 3TS24S006', N'Áo phông unisex trẻ em cotton có hình in, chất liệu cotton thoáng mát, phom dáng over thoải mái cho cả 2 đối tượng. Màu sắc cá tính phù hợp cho cả 2 đối tượng sử dụng.\r\nChất liệu: 100% cotton.\r\nHướng dẫn sử dụng: \r\nGiặt máy ở chế độ nhẹ, nhiệt độ thường.\r\nKhông sử dụng hóa chất tẩy có chứa Clo.\r\nPhơi trong bóng mát.\r\nSấy khô ở nhiệt độ thấp.\r\nLà ở nhiệt độ thấp 110 độ C.\r\nGiặt với sản phẩm cùng màu.\r\nKhông là lên chi tiết trang trí.', 299000, N'unisex', CAST(N'2024-05-02 16:03:46.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh3.3.webp-Thu%20May%2002%202024%2016%3A03%3A34%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=9cabdac1-d42f-4520-b0da-384ecca3a020')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (44, N'Áo phông unisex trẻ em cotton có hình in 3TS24S006', N'Áo phông unisex trẻ em cotton có hình in, chất liệu cotton thoáng mát, phom dáng over thoải mái cho cả 2 đối tượng. Màu sắc cá tính phù hợp cho cả 2 đối tượng sử dụng.', 239200, N'unisex', CAST(N'2024-05-02 16:05:23.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh4.2.webp-Thu%20May%2002%202024%2016%3A05%3A07%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=e7fb7ce0-565b-4adb-a2dc-15ae998eb356')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (45, N'Áo phông bé trai mix màu 2TS24C001', N'Áo phông bé trai mix màu.\r\nChất liệu: 100% cotton.\r\nHướng dẫn sử dụng:\r\nGiặt máy ở nhiệt độ thường, không ngâm.\r\nKhông sử dụng hóa chất tẩy có chứa Clo.\r\nPhơi ngay khi giặt xong.\r\nKhông sử dụng máy sấy.\r\nLà ở nhiệt độ thấp 110 độ C.\r\nGiặt với sản phẩm cùng màu.\r\nKhông là lên chi tiết trang trí.', 269000, N'nam', CAST(N'2024-05-02 16:06:31.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh5.1.webp-Thu%20May%2002%202024%2016%3A06%3A20%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=54dc1d17-1019-48fb-bf50-1df2bba0939a')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (46, N'Áo phông bé trai cotton cổ tròn có hình in 2TS23S011', N'Áo phông chất liệu 100% cotton, cổ tròn tra bo, tay cộc.\r\nChất liệu: 100% cotton\r\nHướng dẫn sử dụng: \r\nGiặt máy ở chế độ nhẹ, nhiệt độ thường.\r\nKhông sử dụng hóa chất tẩy có chứa Clo.\r\nPhơi trong bóng mát.\r\nSấy thùng, chế độ nhẹ nhàng.\r\nLà ở nhiệt độ trung bình 150 độ C.\r\nGiặt với sản phẩm cùng màu.\r\nKhông là lên chi tiết trang trí.', 199000, N'nam', CAST(N'2024-05-02 16:08:29.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh6.2.webp-Thu%20May%2002%202024%2016%3A07%3A53%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=19a20f54-c466-47ec-be33-1952daaadbf8')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (47, N'Áo ba lỗ bé trai có hình in 2TA24S001', N'Áo ba lỗ bé trai, chất liệu cotton pha, phom dáng cơ bản phù hợp cho các bé, hình in ngộ nghĩnh đáng yêu phù hợp với sở thích của các bạn nhỏ.', 149000, N'nam', CAST(N'2024-05-02 16:11:34.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh7.2.webp-Thu%20May%2002%202024%2016%3A11%3A20%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=6fdd3b23-8881-4353-8daf-7fdf7ea5c31b')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (48, N'Áo phông dài tay bé trai cotton USA phối màu tay áo 2TL23W002', N'Áo phông dài tay bé trai phối màu tay áo,phom dáng cơ bản thoải mái, hình in khỏekhoắn năng động phù hợp cho sự vận động của trẻ nhỏ.\r\nChất liệu cotton USA.', 124500, N'nam', CAST(N'2024-05-02 16:12:56.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.2.webp-Thu%20May%2002%202024%2016%3A12%3A42%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=83e36a1c-f410-408b-9aec-4a8e4e62a56c')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (49, N'Áo len bé trai cổ tròn in họa tiết 2TE22W010', N'Áo len cổ tròn, thân trên phối màu dệt hoạ tiết.', 174500, N'nam', CAST(N'2024-05-02 16:14:35.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.3.webp-Thu%20May%2002%202024%2016%3A14%3A25%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=81fe28d8-e564-49ca-a67c-c5e205440476')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (50, N'Áo phông bé gái cotton USA có hình in 1TS24S012', N'Áo phông bé trai, chất liệu 100% cotton mềm mại, phom dáng basic cơ bản. Hình in tự do phù hợp với sở thích của các bé.', 149000, N'nữ', CAST(N'2024-05-02 18:50:18.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.5.webp-Thu%20May%2002%202024%2018%3A50%3A02%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=79d8b698-a9c6-40e5-b9cf-af4125becbd8')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (51, N'Áo phông bé gái in Wolfoo 1TS24S006', N'Áo phông bé gái in Wolfoo', 169000, N'nữ', CAST(N'2024-05-02 18:51:07.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.6.webp-Thu%20May%2002%202024%2018%3A50%3A52%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=30098593-c946-441b-a096-36df00c37ec9')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (52, N'Áo nỉ bé gái in hình Elsa &amp; Anna 1TW23W014', N'Áo nỉ bé gái in hình Elsa &amp; Anna. Có lớp lưới dưới gấu phù hợp với các bé điệu đà, nữ tính.\r\nPhom regular, chất liệu cotton pha tạo cảm giác thoải mái và dễ chịu cả ngày.', 279300, N'nữ', CAST(N'2024-05-02 18:52:38.000' AS DateTime), 1, 31, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh8.8.webp-Thu%20May%2002%202024%2018%3A52%3A24%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=cbf886fa-1e2d-4f4b-80be-0fa05b803326')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (53, N'Quần giả váy bé gái 1BS24S004', N'Quần giả váy bé gái', 279000, N'nữ', CAST(N'2024-05-02 18:54:24.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.1.webp-Thu%20May%2002%202024%2018%3A54%3A11%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=e87077aa-e64f-42af-92bc-d2667d3160f4')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (54, N'Quần soóc bé gái cạp chun có túi bên 1BS24S001', N'Quần soóc bé gái, chất liệu cotton pha, phom dáng cơ bản thuận tiện cho các bé sử dụng trong nhiều hoàn cảnh.', 129000, N'nữ', CAST(N'2024-05-02 18:55:36.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.3.webp-Thu%20May%2002%202024%2018%3A55%3A09%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=697a7ae9-6100-4ced-b869-618ff9f84518')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (55, N'Quần dài bé gái phối sườn 1BP23C002', N'Quần dài bé gái phối sườn, dáng xuông thể thao. Phù hợp phối với nhiều loại trang phục năng động cho bé gái.\r\nSự kết hợp của 2 thành phần sợi cotton và polyester giúp sản phẩm giữ form dáng tốt nhưng vẫn đảm bảo độ xốp và thoáng khí. Màu sắc bền đẹp và độ bền của sản phẩm cao.', 359200, N'nữ', CAST(N'2024-05-02 18:56:25.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.4.webp-Thu%20May%2002%202024%2018%3A56%3A09%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=146bdb74-13d1-4121-ae73-9edeb309cc41')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (56, N'Quần jeans bé trai 2BJ24S001', N'Quần jeans bé trai', 299000, N'nam', CAST(N'2024-05-02 18:57:47.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.5.webp-Thu%20May%2002%202024%2018%3A57%3A30%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=4b7ee749-84f5-4a69-8e50-75910a3bfcee')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (57, N'Quần soóc bé tra 2BS24C003', N'Quần soóc bé trai', 349000, N'nam', CAST(N'2024-05-02 18:59:18.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.7.webp-Thu%20May%2002%202024%2018%3A58%3A38%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=15a73735-639f-476f-817c-002786efbd35')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (58, N'Quần jeans bé trai cotton cạp chun dáng jogger', N'Quần jeans chất liệu cotton, cạp chun luồn dây dệt, gấu bo chun, dáng jogger.', 299000, N'nam', CAST(N'2024-05-02 18:59:51.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.8.webp-Thu%20May%2002%202024%2018%3A59%3A46%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=2aaa6429-ec01-4c31-b8da-a76be70b5f1d')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (59, N'Quần nỉ unisex trẻ em chun gấu', N'Quần nỉ unisex trẻ em, phom dáng basic có chun gấu, chất liệu vảy cá mỏng thoải mái cho trẻ vận động và sử dụng cho nhiều hoàn cảnh.\r\nChất liệu polyester pha spandex.', 174300, N'nam', CAST(N'2024-05-02 19:03:34.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.webp-Thu%20May%2002%202024%2019%3A03%3A20%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=da40bac5-58ec-48a0-b93f-e9458ae4317d')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (60, N'Khăn len unisex trẻ em dệt chữ 3AC23W003', N'Khăn quàng dệt chữ phối màu 2 đầu khăn. Chất liệu mềm mại ấm áp, màu sắc đa dạng.\r\nChất liệu sợi acrylic kết hợp polyester\r\nmỏng nhẹ mềm mại, có khả năng giữ ấm tốt.', 199200, N'unisex', CAST(N'2024-05-02 19:20:33.000' AS DateTime), 5, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.5.webp-Thu%20May%2002%202024%2019%3A20%3A20%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=aff4f2b6-e09c-4aef-bbda-569b72af5c17')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (61, N'Tất bé trai cổ cao có hình in 2AK22C002', N'Tất chất liệu cotton pha.', 27300, N'unisex', CAST(N'2024-05-02 19:22:33.000' AS DateTime), 5, 29, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.8.webp-Thu%20May%2002%202024%2019%3A22%3A17%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&token=12c63304-ae1c-42ca-9cfd-3fdc09d83f0f')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (63, N'san pham a b c d e f', N'sdafsdf', 12345, N'unisex', CAST(N'2024-05-12 12:21:10.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.1.webp-Sun%20May%2012%202024%2012%3A20%3A59%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=ccd3dcdc-2947-4095-b1b2-10d31dcc0028')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (64, N'áo thun nam nữ', N'ádasdsad', 12, N'unisex', CAST(N'2024-05-12 12:51:05.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2F2302.w026.n002.3120B.p1.3120.jpg-Sun%20May%2012%202024%2012%3A50%3A50%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=5cba5511-dc92-46aa-b808-0fde5aee1ba6')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (65, N'Giày Thể Thao Trẻ Em Bitis Hunter HSB000300', N'Các bé trai ngày nay cũng có nhu cầu được “diện” những đôi giày thời thượng để tự tin dạo phố, tuy nhiên bố mẹ lại chưa biết chọn mẫu giày nào cho con. Đừng lo, gợi ý đến bạn mẫu Giày Thể Thao Trẻ Em Biti&#039;s Hunter HSB000300, tìm hiểu ngay nhé!', 644000, N'unisex', CAST(N'2024-05-12 13:03:21.000' AS DateTime), 4, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9.webp-Sun%20May%2012%202024%2013%3A02%3A08%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=356eda8a-e9d1-41dc-9fb7-3da6b0cf38a2')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (67, N'Giày Thể Thao Bé Gái Biti&#039;s BSG002600', N'Các bé gái ngày nay cũng có nhu cầu được “diện” những đôi giày thời thượng để tự tin dạo phố, tuy nhiên bố mẹ lại chưa biết chọn mẫu giày nào cho con. Đừng lo, gợi ý đến bạn mẫu Giày Thể Thao Bé Gái Biti&#039;s BSG002600, tìm hiểu ngay nhé!', 447000, N'nữ', CAST(N'2024-05-12 13:06:59.000' AS DateTime), 4, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.93.webp-Sun%20May%2012%202024%2013%3A06%3A31%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=0ee6faeb-8ca4-4a00-9b8f-0fe5786099a1')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (68, N'Nón Thể Thao Bé Gái Under Armour Play Up - Xanh Dương', N'Hoàn thiện outfit của bé gái với chiếc mũ xinh xắn Play Up. Chất vải polyester cho cảm giác cứng cáp mà thoải mái suốt cả ngày. Logo thêu nổi tạo phong cách đáng yêu, cùng vành mũ cong vừa che nắng vừa trendy.', 29700, N'nữ', CAST(N'2024-05-12 13:09:00.000' AS DateTime), 3, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.97.webp-Sun%20May%2012%202024%2013%3A08%3A39%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=3ae9b910-b58e-4748-a5f3-1a7c4dba648e')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (69, N'Nón Trẻ Em Adidas Originals Youth', N'Bổ sung vào phong cách trượt ván hằng ngày của bạn với nón Adidas dành cho lứa tuổi thiếu niên . Với các chi tiết đồ họa lấy cảm hứng từ metaverse, chiếc nón này toát lên sự trẻ trung và tinh thần phiêu lưu. Chất liệu vải cotton nguyên chất bền và thoải mái, thiết kế vành mũ bao quanh mang lại cho bạn hình dáng cổ điển đó.\r\n\r\nĐược làm bằng một loạt vật liệu tái chế với hàm lượng ít nhất 40%, sản phẩm này là một trong những giải pháp của chúng tôi giúp chấm dứt vấn đề về rác thải nhựa.', 399000, N'nam', CAST(N'2024-05-12 13:11:14.000' AS DateTime), 3, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.98.webp-Sun%20May%2012%202024%2013%3A10%3A53%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=12a223da-4d26-4187-a6a6-e88730552930')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (70, N'Áo phông unisex trẻ em 3TS24S003SGdsd', N'Áo phông unisex trẻ em 3TS24S003SGdsd', 3400000, N'nam', CAST(N'2024-05-25 11:15:22.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh1.1.webp-Sat%20May%2025%202024%2011%3A14%3A34%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=6d93bfeb-1b9d-443c-bcd3-2b55978d6d11')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (72, N'Áo phông unisex trẻ em 3TS24S003SG631', N'sdfdsf', 123, N'unisex', CAST(N'2024-05-26 22:07:01.000' AS DateTime), 1, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9891.webp-Sun%20May%2026%202024%2022%3A06%3A39%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=57c82c72-30c4-423a-9d69-905573a849c7')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (73, N'Quần jeans bé trai dáng suông', N'Quần jeans chất liệu cotton pha, được mài rách\r\nDáng regular, cạp thường, có khóa kim loại', 99000, N'nam', CAST(N'2024-06-02 21:30:50.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9892.webp-Sun%20Jun%2002%202024%2021%3A30%3A29%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=a30c6e1b-2b8e-4207-a67e-677ed02cd42e')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (74, N'Set 5 đôi tất trẻ em', N'Chất liệu sợi cotton pha polyester mềm mại, dễ sử dụng.', 69000, N'unisex', CAST(N'2024-06-02 21:32:08.000' AS DateTime), 5, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9893.webp-Sun%20Jun%2002%202024%2021%3A31%3A45%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=26d58490-29f2-43f3-85b6-382ea9c64089')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (75, N'Combo 2 khăn mặt cotton 50x30cm', N'Combo 2 khăn mặt cotton 50x30cm', 60000, N'unisex', CAST(N'2024-06-02 21:33:08.000' AS DateTime), 5, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9894.webp-Sun%20Jun%2002%202024%2021%3A32%3A46%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=b87ef0e0-2579-4409-8279-59da9bbdff7e')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (76, N'Combo 2 khăn mặt cotton 50x30cm', N'Combo 2 khăn mặt cotton 50x30cm', 60000, N'unisex', CAST(N'2024-06-02 21:33:19.000' AS DateTime), 5, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9894.webp-Sun%20Jun%2002%202024%2021%3A32%3A46%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=b87ef0e0-2579-4409-8279-59da9bbdff7e')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (77, N'Combo 2 khẩu trang unisex trẻ em 2 lớp', N'Khẩu trang 2 lớp, pack 2 chiếc khác màu.', 50000, N'unisex', CAST(N'2024-06-02 21:34:16.000' AS DateTime), 5, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9895.webp-Sun%20Jun%2002%202024%2021%3A34%3A03%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=2aa28383-bf36-49f5-8cd4-5fef9a03509a')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (78, N'Combo 2 khẩu trang unisex trẻ em 2 lớp', N'Khẩu trang 2 lớp, pack 2 chiếc khác màu.', 50000, N'unisex', CAST(N'2024-06-02 21:34:19.000' AS DateTime), 5, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9895.webp-Sun%20Jun%2002%202024%2021%3A34%3A03%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=2aa28383-bf36-49f5-8cd4-5fef9a03509a')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (79, N'Quần soóc bé gái cạp chun có hình in', N'Quần soóc chất liệu cotton pha, cạp chun luồn dây dệt, đính patch trang trí.', 149000, N'nữ', CAST(N'2024-06-02 21:35:41.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9896.webp-Sun%20Jun%2002%202024%2021%3A35%3A22%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=faccf565-1b8e-4ff9-b081-1a0505275741')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (80, N'Quần soóc bé gái cạp chun có hình in', N'Quần soóc chất liệu cotton pha, cạp chun luồn dây dệt, đính patch trang trí.', 149000, N'nữ', CAST(N'2024-06-02 21:35:44.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9896.webp-Sun%20Jun%2002%202024%2021%3A35%3A22%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=faccf565-1b8e-4ff9-b081-1a0505275741')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (81, N'Quần soóc bé gái cotton cạp chun phối bèo', N'Quần shorts jeans bé gái, dáng hơi A, cạp bèo, chất liệu dầy dặn, thoải mái, dễ chịu cho người mặc, phù hợp với đi chơi, đi học.\r\nĐược giặt mềm thành phẩm để mang lại cảm giác mềm mại, thoải mái.\r\nChất liệu 100% cotton thân thiện với môi trường. Độ bền tốt. Thấm hút tốt, không gây hại cho sức khỏe. Thoáng mát khi mặc.', 89000, N'nữ', CAST(N'2024-06-02 21:36:52.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9898.webp-Sun%20Jun%2002%202024%2021%3A36%3A38%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=4bfe04d5-6961-4c16-bb6f-fb4683cf4fcb')
INSERT [dbo].[sanpham] ([id], [ten], [mota], [gia], [gioitinh], [ngaytao], [DanhMuc_id], [KhuyenMai_id], [anhdaidien]) VALUES (82, N'Quần nỉ nam gấu chun có chốt chặn', N'Quần nỉ nam form regular mang phong cách năng động, cá tính. Phần cuối của ống may thêm chun túm có chốt chặn. Quần được thiết kế nhiều túi mang đến sự tiện dụng cho người mặc.\r\nCông nghệ dệt interlock mang lại bề mặt vải có độ đàn hồi cao, vải có độ dày nhưng vẫn đảm bảo sự thông thoáng. Sự kết hợp của 2 thành phần Cotton và nylon giúp cho sản phẩm có độ bền và giữ form tốt.', 120000, N'nam', CAST(N'2024-06-02 21:37:45.000' AS DateTime), 2, NULL, N'https://firebasestorage.googleapis.com/v0/b/fashion-app-84f9f.appspot.com/o/images%2Fh9.9.9899.webp-Sun%20Jun%2002%202024%2021%3A37%3A32%20GMT%2B0700%20(Gi%E1%BB%9D%20%C4%90%C3%B4ng%20D%C6%B0%C6%A1ng)?alt=media&amp;token=7bf09194-0506-422c-a252-a8520c6bbb12')
SET IDENTITY_INSERT [dbo].[sanpham] OFF
SET IDENTITY_INSERT [dbo].[trangthaidonhang] ON 

INSERT [dbo].[trangthaidonhang] ([id], [trangthai]) VALUES (1, N'Chờ xác nhận')
INSERT [dbo].[trangthaidonhang] ([id], [trangthai]) VALUES (2, N'Chờ giao hàng')
INSERT [dbo].[trangthaidonhang] ([id], [trangthai]) VALUES (3, N'Hoàn thành')
INSERT [dbo].[trangthaidonhang] ([id], [trangthai]) VALUES (4, N'Ðã hủy')
SET IDENTITY_INSERT [dbo].[trangthaidonhang] OFF
ALTER TABLE [dbo].[diachi] ADD  DEFAULT (NULL) FOR [KhachHang_id]
GO
ALTER TABLE [dbo].[diachi] ADD  DEFAULT (NULL) FOR [macdinh]
GO
ALTER TABLE [dbo].[giohang] ADD  DEFAULT (NULL) FOR [ngaythem]
GO
ALTER TABLE [dbo].[chitietdonhang]  WITH CHECK ADD  CONSTRAINT [fk_chitietdonhang_donhang] FOREIGN KEY([DonHang_id])
REFERENCES [dbo].[donhang] ([id])
GO
ALTER TABLE [dbo].[chitietdonhang] CHECK CONSTRAINT [fk_chitietdonhang_donhang]
GO
ALTER TABLE [dbo].[chitietdonhang]  WITH CHECK ADD  CONSTRAINT [fk_chitietdonhang_kichcosanpham] FOREIGN KEY([SanPham_id])
REFERENCES [dbo].[kichcosanpham] ([id])
GO
ALTER TABLE [dbo].[chitietdonhang] CHECK CONSTRAINT [fk_chitietdonhang_kichcosanpham]
GO
ALTER TABLE [dbo].[danhgiasanpham]  WITH CHECK ADD  CONSTRAINT [fk_danhgiasanpham_khachhang] FOREIGN KEY([KhachHang_id])
REFERENCES [dbo].[khachhang] ([id])
GO
ALTER TABLE [dbo].[danhgiasanpham] CHECK CONSTRAINT [fk_danhgiasanpham_khachhang]
GO
ALTER TABLE [dbo].[diachi]  WITH CHECK ADD  CONSTRAINT [FK_DiaChi_KhachHang] FOREIGN KEY([KhachHang_id])
REFERENCES [dbo].[khachhang] ([id])
GO
ALTER TABLE [dbo].[diachi] CHECK CONSTRAINT [FK_DiaChi_KhachHang]
GO
ALTER TABLE [dbo].[donhang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_TrangThaiDonHang] FOREIGN KEY([TrangThaiDonHang_id])
REFERENCES [dbo].[trangthaidonhang] ([id])
GO
ALTER TABLE [dbo].[donhang] CHECK CONSTRAINT [FK_DonHang_TrangThaiDonHang]
GO
ALTER TABLE [dbo].[donhang]  WITH CHECK ADD  CONSTRAINT [PK_DonHang_KhachHang] FOREIGN KEY([KhachHang_id])
REFERENCES [dbo].[khachhang] ([id])
GO
ALTER TABLE [dbo].[donhang] CHECK CONSTRAINT [PK_DonHang_KhachHang]
GO
ALTER TABLE [dbo].[giohang]  WITH CHECK ADD  CONSTRAINT [FK_giohang_khachhang] FOREIGN KEY([KhachHang_id])
REFERENCES [dbo].[khachhang] ([id])
GO
ALTER TABLE [dbo].[giohang] CHECK CONSTRAINT [FK_giohang_khachhang]
GO
ALTER TABLE [dbo].[giohang]  WITH CHECK ADD  CONSTRAINT [FK_giohang_kichcosanpham] FOREIGN KEY([KichCoSanPham_id])
REFERENCES [dbo].[kichcosanpham] ([id])
GO
ALTER TABLE [dbo].[giohang] CHECK CONSTRAINT [FK_giohang_kichcosanpham]
GO
ALTER TABLE [dbo].[kichcosanpham]  WITH CHECK ADD  CONSTRAINT [fk_KichCoSanPham_LoaiSanPham] FOREIGN KEY([LoaiSanPham_id])
REFERENCES [dbo].[loaisanpham] ([id])
GO
ALTER TABLE [dbo].[kichcosanpham] CHECK CONSTRAINT [fk_KichCoSanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[loaisanpham]  WITH CHECK ADD  CONSTRAINT [fk_loaisanpham_sanpham] FOREIGN KEY([SanPham_id])
REFERENCES [dbo].[sanpham] ([id])
GO
ALTER TABLE [dbo].[loaisanpham] CHECK CONSTRAINT [fk_loaisanpham_sanpham]
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [fk_nguoidungnhomnguoidung_nguoidung] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[QL_NguoiDung] ([TenDangNhap])
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung] CHECK CONSTRAINT [fk_nguoidungnhomnguoidung_nguoidung]
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung]  WITH CHECK ADD  CONSTRAINT [fk_nguoidungnhomnguoidung_nhomnguoidung] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[QL_NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[QL_NguoiDungNhomNguoiDung] CHECK CONSTRAINT [fk_nguoidungnhomnguoidung_nhomnguoidung]
GO
ALTER TABLE [dbo].[QL_PhanQuyen]  WITH CHECK ADD  CONSTRAINT [fk_PhanQuyen_DM_ManHinh] FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[DM_ManHinh] ([MaManHinh])
GO
ALTER TABLE [dbo].[QL_PhanQuyen] CHECK CONSTRAINT [fk_PhanQuyen_DM_ManHinh]
GO
ALTER TABLE [dbo].[QL_PhanQuyen]  WITH CHECK ADD  CONSTRAINT [fk_PhanQuyen_nhomnguoidung] FOREIGN KEY([MaNhomNguoiDung])
REFERENCES [dbo].[QL_NhomNguoiDung] ([MaNhom])
GO
ALTER TABLE [dbo].[QL_PhanQuyen] CHECK CONSTRAINT [fk_PhanQuyen_nhomnguoidung]
GO
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_KhuyenMai] FOREIGN KEY([KhuyenMai_id])
REFERENCES [dbo].[khuyenmai] ([id])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [FK_SanPham_KhuyenMai]
GO
ALTER TABLE [dbo].[sanpham]  WITH CHECK ADD  CONSTRAINT [sanpham_ibfk_1] FOREIGN KEY([DanhMuc_id])
REFERENCES [dbo].[danhmuc] ([id])
GO
ALTER TABLE [dbo].[sanpham] CHECK CONSTRAINT [sanpham_ibfk_1]
GO
