USE [DtnK22CNT4Lesson07Db]
GO
/****** Object:  Table [dbo].[dtnKhoa]    Script Date: 12/06/2024 3:07:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtnKhoa](
	[DtnMaKH] [nchar](10) NOT NULL,
	[DtnTenMK] [nvarchar](50) NULL,
	[DtnTrangThai] [bit] NULL,
 CONSTRAINT [PK_dtnKhoa] PRIMARY KEY CLUSTERED 
(
	[DtnMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dtnSinhVien]    Script Date: 12/06/2024 3:07:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dtnSinhVien](
	[DtnMaSV] [nvarchar](50) NULL,
	[DtnHoSV] [nvarchar](50) NULL,
	[DtnTenSV] [nvarchar](50) NULL,
	[DtnNgaySinh] [date] NULL,
	[DtnPhai] [bit] NULL,
	[DtnPhone] [nchar](10) NULL,
	[DtnEmail] [nvarchar](50) NULL,
	[DtnMaKH] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[dtnKhoa] ([DtnMaKH], [DtnTenMK], [DtnTrangThai]) VALUES (N'K22CNT2   ', N'K22CNT4', 1)
GO
INSERT [dbo].[dtnSinhVien] ([DtnMaSV], [DtnHoSV], [DtnTenSV], [DtnNgaySinh], [DtnPhai], [DtnPhone], [DtnEmail], [DtnMaKH]) VALUES (N'2210900052', N'Đặng Tài', N'Nguyên', CAST(N'2004-11-14' AS Date), 1, N'096123456 ', N'nguyengmail@gmail.com', N'k22CNT4   ')
GO
