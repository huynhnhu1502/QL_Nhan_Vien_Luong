USE [QuanLyLuong]
GO
/****** Object:  Table [dbo].[NgachLuong]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NgachLuong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNgach] [varchar](50) NOT NULL,
	[TenNgach] [nvarchar](50) NOT NULL,
	[NienHan] [float] NOT NULL,
	[MoTa] [text] NULL,
 CONSTRAINT [PK_NgachLuong] PRIMARY KEY CLUSTERED 
(
	[MaNgach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonVi]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonVi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaDonVi] [varchar](50) NOT NULL,
	[TenDonVi] [nvarchar](255) NOT NULL,
	[MaLoai] [int] NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[DienThoai] [nvarchar](50) NOT NULL,
	[NamThanhLap] [date] NOT NULL,
	[ChucNang] [text] NOT NULL,
	[NhiemVu] [text] NOT NULL,
 CONSTRAINT [PK_DonVi_1] PRIMARY KEY CLUSTERED 
(
	[MaDonVi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChucVu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaChucVu] [varchar](50) NOT NULL,
	[TenChucVu] [nvarchar](50) NOT NULL,
	[HeSoCV] [float] NOT NULL,
 CONSTRAINT [PK_ChucVu_1] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HeSoLuongPhuCap]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HeSoLuongPhuCap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaHeSo] [varchar](50) NOT NULL,
	[TenHeSo] [nvarchar](50) NOT NULL,
	[HeSo] [float] NOT NULL,
	[MaNgach] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HeSoLuongPhuCap] PRIMARY KEY CLUSTERED 
(
	[MaHeSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiDonVi]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoaiDonVi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [varchar](50) NOT NULL,
	[TenLoai] [nvarchar](255) NOT NULL,
	[MoTa] [text] NOT NULL,
 CONSTRAINT [PK_LoaiDonVi_1] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[HoTen] [nvarchar](255) NOT NULL,
	[MaDonVi] [varchar](50) NOT NULL,
	[MaChucVu] [varchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DanToc] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](50) NOT NULL,
	[CMND] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[HinhAnh] [nvarchar](255) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayNghi] [date] NULL,
	[NgayHuu] [date] NULL,
 CONSTRAINT [PK_NhanVien_1] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LuongThucTe]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LuongThucTe](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaLuong] [varchar](50) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[HeSoLuong] [float] NOT NULL,
	[LuongCoBan] [decimal](18, 0) NOT NULL,
	[LuongThucTe] [decimal](18, 0) NULL,
	[TrangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LuongThucTe] PRIMARY KEY CLUSTERED 
(
	[MaLuong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichSuCongTac]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichSuCongTac](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaCongTac] [varchar](50) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[MaDonVi] [varchar](50) NOT NULL,
	[MaChucVu] [varchar](50) NOT NULL,
	[MaNgach] [varchar](50) NOT NULL,
	[NgayLam] [date] NOT NULL,
	[NgayChuyen] [date] NULL,
 CONSTRAINT [PK_LichSuCongTac_1] PRIMARY KEY CLUSTERED 
(
	[MaCongTac] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LichSuChuyenBac]    Script Date: 11/28/2015 23:16:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LichSuChuyenBac](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](50) NOT NULL,
	[MaHeSo] [varchar](50) NOT NULL,
	[NgayChuyen] [date] NOT NULL,
 CONSTRAINT [PK_LichSuChuyenBac_1] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaHeSo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_HeSoLuongPhuCap_NgachLuong]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[HeSoLuongPhuCap]  WITH CHECK ADD  CONSTRAINT [FK_HeSoLuongPhuCap_NgachLuong] FOREIGN KEY([MaNgach])
REFERENCES [dbo].[NgachLuong] ([MaNgach])
GO
ALTER TABLE [dbo].[HeSoLuongPhuCap] CHECK CONSTRAINT [FK_HeSoLuongPhuCap_NgachLuong]
GO
/****** Object:  ForeignKey [FK_LichSuChuyenBac_HeSoLuongPhuCap]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[LichSuChuyenBac]  WITH CHECK ADD  CONSTRAINT [FK_LichSuChuyenBac_HeSoLuongPhuCap] FOREIGN KEY([MaHeSo])
REFERENCES [dbo].[HeSoLuongPhuCap] ([MaHeSo])
GO
ALTER TABLE [dbo].[LichSuChuyenBac] CHECK CONSTRAINT [FK_LichSuChuyenBac_HeSoLuongPhuCap]
GO
/****** Object:  ForeignKey [FK_LichSuChuyenBac_NhanVien]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[LichSuChuyenBac]  WITH CHECK ADD  CONSTRAINT [FK_LichSuChuyenBac_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LichSuChuyenBac] CHECK CONSTRAINT [FK_LichSuChuyenBac_NhanVien]
GO
/****** Object:  ForeignKey [FK_LichSuCongTac_ChucVu]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[LichSuCongTac]  WITH CHECK ADD  CONSTRAINT [FK_LichSuCongTac_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[LichSuCongTac] CHECK CONSTRAINT [FK_LichSuCongTac_ChucVu]
GO
/****** Object:  ForeignKey [FK_LichSuCongTac_DonVi]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[LichSuCongTac]  WITH CHECK ADD  CONSTRAINT [FK_LichSuCongTac_DonVi] FOREIGN KEY([MaDonVi])
REFERENCES [dbo].[DonVi] ([MaDonVi])
GO
ALTER TABLE [dbo].[LichSuCongTac] CHECK CONSTRAINT [FK_LichSuCongTac_DonVi]
GO
/****** Object:  ForeignKey [FK_LichSuCongTac_NgachLuong]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[LichSuCongTac]  WITH CHECK ADD  CONSTRAINT [FK_LichSuCongTac_NgachLuong] FOREIGN KEY([MaNgach])
REFERENCES [dbo].[NgachLuong] ([MaNgach])
GO
ALTER TABLE [dbo].[LichSuCongTac] CHECK CONSTRAINT [FK_LichSuCongTac_NgachLuong]
GO
/****** Object:  ForeignKey [FK_LichSuCongTac_NhanVien]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[LichSuCongTac]  WITH CHECK ADD  CONSTRAINT [FK_LichSuCongTac_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LichSuCongTac] CHECK CONSTRAINT [FK_LichSuCongTac_NhanVien]
GO
/****** Object:  ForeignKey [FK_LoaiDonVi_DonVi]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[LoaiDonVi]  WITH CHECK ADD  CONSTRAINT [FK_LoaiDonVi_DonVi] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[DonVi] ([MaDonVi])
GO
ALTER TABLE [dbo].[LoaiDonVi] CHECK CONSTRAINT [FK_LoaiDonVi_DonVi]
GO
/****** Object:  ForeignKey [FK_LuongThucTe_NhanVien]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[LuongThucTe]  WITH CHECK ADD  CONSTRAINT [FK_LuongThucTe_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LuongThucTe] CHECK CONSTRAINT [FK_LuongThucTe_NhanVien]
GO
/****** Object:  ForeignKey [FK_NhanVien_ChucVu]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
/****** Object:  ForeignKey [FK_NhanVien_DonVi]    Script Date: 11/28/2015 23:16:11 ******/
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_DonVi] FOREIGN KEY([MaDonVi])
REFERENCES [dbo].[DonVi] ([MaDonVi])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_DonVi]
GO
