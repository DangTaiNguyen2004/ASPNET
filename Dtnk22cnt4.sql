USE [DtnK22CNT4Lesson11Db]
GO
/****** Object:  Table [dbo].[DtnCategory]    Script Date: 04/07/2024 10:29:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DtnCategory](
	[DtnID] [int] NOT NULL,
	[DtnCateName] [nvarchar](50) NULL,
	[DtnStatus] [bit] NULL,
 CONSTRAINT [PK_DtnCategory] PRIMARY KEY CLUSTERED 
(
	[DtnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DtnProduct]    Script Date: 04/07/2024 10:29:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DtnProduct](
	[Dtnid2210900052] [nvarchar](50) NOT NULL,
	[DtnProName] [nvarchar](50) NULL,
	[DtnQty] [int] NULL,
	[DtnPrice] [float] NULL,
	[DtnCateId] [int] NULL,
	[DtnActive] [bit] NULL,
 CONSTRAINT [PK_DtnProduct] PRIMARY KEY CLUSTERED 
(
	[Dtnid2210900052] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DtnCategory] ([DtnID], [DtnCateName], [DtnStatus]) VALUES (1, N'2210900052', 1)
INSERT [dbo].[DtnCategory] ([DtnID], [DtnCateName], [DtnStatus]) VALUES (2, N'iphone', 0)
GO
INSERT [dbo].[DtnProduct] ([Dtnid2210900052], [DtnProName], [DtnQty], [DtnPrice], [DtnCateId], [DtnActive]) VALUES (N'2210900052', N'Đặng Tài Nguyên', 10, 1000, 1, 1)
GO
