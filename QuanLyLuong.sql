
USE [QuanLyLuong]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 10/29/2015 8:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaChucVu] [nvarchar](50) NOT NULL,
	[TenChucVu] [nvarchar](max) NOT NULL,
	[HeSo] [int] NOT NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonVi]    Script Date: 10/29/2015 8:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonVi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaDonVi] [nvarchar](50) NOT NULL,
	[TenDonVi] [nvarchar](max) NOT NULL,
	[MaLoai] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[DienThoai] [nvarchar](max) NOT NULL,
	[NamThanhLap] [date] NOT NULL,
	[ChucNang] [nvarchar](max) NOT NULL,
	[NhiemVu] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DonVi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HeSoLuongPhuCap]    Script Date: 10/29/2015 8:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeSoLuongPhuCap](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNgach] [nvarchar](50) NOT NULL,
	[TenNgach] [nvarchar](max) NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
	[NienHan] [int] NOT NULL,
	[Bac1] [float] NOT NULL,
	[Bac2] [float] NOT NULL,
	[Bac3] [float] NOT NULL,
	[Bac4] [float] NOT NULL,
	[Bac5] [float] NOT NULL,
	[Bac6] [float] NOT NULL,
	[Bac7] [float] NOT NULL,
	[Bac8] [float] NOT NULL,
 CONSTRAINT [PK_HeSoLuongPhuCap] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LichSuChuyenBac]    Script Date: 10/29/2015 8:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuChuyenBac](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaNgach] [nvarchar](50) NOT NULL,
	[BacCu] [int] NOT NULL,
	[BacMoi] [int] NOT NULL,
	[NienHan] [int] NOT NULL,
	[NgayChuyen] [date] NOT NULL,
 CONSTRAINT [PK_LichSuChuyenBac] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LichSuCongTac]    Script Date: 10/29/2015 8:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichSuCongTac](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[MaSo] [nvarchar](50) NOT NULL,
	[MaDonVi] [nvarchar](50) NOT NULL,
	[MaChucVu] [nvarchar](50) NOT NULL,
	[NgayLam] [date] NOT NULL,
	[NgayChuyen] [date] NULL,
 CONSTRAINT [PK_LichSuCongTac] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiDonVi]    Script Date: 10/29/2015 8:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDonVi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaLoai] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](max) NOT NULL,
	[MoTa] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LoaiDonVi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/29/2015 8:26:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](max) NOT NULL,
	[MaDonVi] [nvarchar](50) NOT NULL,
	[MaChucVu] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DanToc] [nvarchar](max) NOT NULL,
	[GioiTinh] [nvarchar](max) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[HinhAnh] [nvarchar](max) NOT NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayNghi] [date] NULL,
	[NgayHuu] [date] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [QuanLyLuong] SET  READ_WRITE 
GO
