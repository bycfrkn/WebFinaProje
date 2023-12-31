USE [MvcDbYemekSitesi]
GO
/****** Object:  Table [dbo].[TblDbCorba]    Script Date: 13.06.2023 16:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDbCorba](
	[CorbaId] [int] IDENTITY(1,1) NOT NULL,
	[CorbaAd] [varchar](50) NULL,
	[CorbaFiyat] [int] NULL,
	[CorbaResim] [varchar](max) NULL,
 CONSTRAINT [PK_TblDbCorba] PRIMARY KEY CLUSTERED 
(
	[CorbaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDbIcecekler]    Script Date: 13.06.2023 16:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDbIcecekler](
	[IcecekId] [int] IDENTITY(1,1) NOT NULL,
	[IcecekAd] [varchar](50) NULL,
	[IcecekFiyat] [int] NULL,
	[IcecekResim] [varchar](max) NULL,
 CONSTRAINT [PK_TblDbIcecekler] PRIMARY KEY CLUSTERED 
(
	[IcecekId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDbIzgara]    Script Date: 13.06.2023 16:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDbIzgara](
	[IzgaraId] [int] IDENTITY(1,1) NOT NULL,
	[IzgaraAd] [nchar](10) NULL,
	[IzgaraFiyat] [int] NULL,
	[IzgaraResim] [varchar](max) NULL,
 CONSTRAINT [PK_TblDbIzgara] PRIMARY KEY CLUSTERED 
(
	[IzgaraId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDbKullanici]    Script Date: 13.06.2023 16:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDbKullanici](
	[kullaniciId] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [varchar](50) NULL,
	[kullaniciSoyad] [varchar](50) NULL,
	[KullaniciEmail] [varchar](50) NULL,
	[KullaniciSifre] [varchar](50) NULL,
 CONSTRAINT [PK_TblDbKullanici] PRIMARY KEY CLUSTERED 
(
	[kullaniciId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDbSalata]    Script Date: 13.06.2023 16:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDbSalata](
	[SalataId] [int] IDENTITY(1,1) NOT NULL,
	[SalataAd] [varchar](50) NULL,
	[SalataFiyat] [int] NULL,
	[SalataResim] [varchar](max) NULL,
 CONSTRAINT [PK_TblDbSalata] PRIMARY KEY CLUSTERED 
(
	[SalataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblDbTatli]    Script Date: 13.06.2023 16:21:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDbTatli](
	[TatliId] [int] IDENTITY(1,1) NOT NULL,
	[TatliAD] [varchar](50) NULL,
	[TatliFiyat] [int] NULL,
	[TatliResim] [varchar](max) NULL,
 CONSTRAINT [PK_TblDbTatli] PRIMARY KEY CLUSTERED 
(
	[TatliId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblDbCorba] ON 

INSERT [dbo].[TblDbCorba] ([CorbaId], [CorbaAd], [CorbaFiyat], [CorbaResim]) VALUES (1, N'Ezogelin', 10, N'../Content/Resimler/ezogelin.jpg')
INSERT [dbo].[TblDbCorba] ([CorbaId], [CorbaAd], [CorbaFiyat], [CorbaResim]) VALUES (2, N'Iskembe', 15, N'../Content/Resimler/Iskembe.jpg')
INSERT [dbo].[TblDbCorba] ([CorbaId], [CorbaAd], [CorbaFiyat], [CorbaResim]) VALUES (3, N'Yayla', 10, N'../Content/Resimler/Yayla.jpeg')
INSERT [dbo].[TblDbCorba] ([CorbaId], [CorbaAd], [CorbaFiyat], [CorbaResim]) VALUES (4, N'Dugun Corbasi', 8, N'../Content/Resimler/dugun.jpeg')
SET IDENTITY_INSERT [dbo].[TblDbCorba] OFF
GO
SET IDENTITY_INSERT [dbo].[TblDbIcecekler] ON 

INSERT [dbo].[TblDbIcecekler] ([IcecekId], [IcecekAd], [IcecekFiyat], [IcecekResim]) VALUES (1, N'Ayran', 3, N'../Content/Resimler/ayran.jpg')
INSERT [dbo].[TblDbIcecekler] ([IcecekId], [IcecekAd], [IcecekFiyat], [IcecekResim]) VALUES (2, N'Su', 1, N'../Content/Resimler/su.jpg')
INSERT [dbo].[TblDbIcecekler] ([IcecekId], [IcecekAd], [IcecekFiyat], [IcecekResim]) VALUES (3, N'Fanta', 7, N'../Content/Resimler/Fanta.jpg')
INSERT [dbo].[TblDbIcecekler] ([IcecekId], [IcecekAd], [IcecekFiyat], [IcecekResim]) VALUES (4, N'Cola', 8, N'../Content/Resimler/cola.jpeg')
INSERT [dbo].[TblDbIcecekler] ([IcecekId], [IcecekAd], [IcecekFiyat], [IcecekResim]) VALUES (5, N'Soda', 3, N'../Content/Resimler/soda.jpg')
SET IDENTITY_INSERT [dbo].[TblDbIcecekler] OFF
GO
SET IDENTITY_INSERT [dbo].[TblDbIzgara] ON 

INSERT [dbo].[TblDbIzgara] ([IzgaraId], [IzgaraAd], [IzgaraFiyat], [IzgaraResim]) VALUES (1, N'Doner     ', 6, N'../Content/Resimler/doner.jpeg')
INSERT [dbo].[TblDbIzgara] ([IzgaraId], [IzgaraAd], [IzgaraFiyat], [IzgaraResim]) VALUES (2, N'Iskender  ', 24, N'../Content/Resimler/iskender.jpg')
INSERT [dbo].[TblDbIzgara] ([IzgaraId], [IzgaraAd], [IzgaraFiyat], [IzgaraResim]) VALUES (3, N'Beyti     ', 24, N'../Content/Resimler/beyti.jpeg')
INSERT [dbo].[TblDbIzgara] ([IzgaraId], [IzgaraAd], [IzgaraFiyat], [IzgaraResim]) VALUES (4, N'Adana     ', 25, N'../Content/Resimler/adana.jpg')
INSERT [dbo].[TblDbIzgara] ([IzgaraId], [IzgaraAd], [IzgaraFiyat], [IzgaraResim]) VALUES (5, N'Karisik   ', 35, N'../Content/Resimler/karisik.jpg')
SET IDENTITY_INSERT [dbo].[TblDbIzgara] OFF
GO
SET IDENTITY_INSERT [dbo].[TblDbKullanici] ON 

INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (1, N'F', N'F', N'F', N'F')
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (2, N'f', N'f', N'f@gmail.com', N'1')
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (3, N'ADD', N'AD', N'fADDA@gmail.com', N'3')
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (4, N'ADD', N'f', N'fADDxA@gmail.com', N'2')
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (5, N'ADD', N'f', N'fADDxA@gmail.com', N'2')
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (6, N'LTF', N'BYC', N'fADDZZA@gmail.com', N'2')
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (7, NULL, NULL, NULL, NULL)
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (8, N'FRKN', N'Boyaci', N'boyacifrkn@gmail.com', N'1')
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (9, NULL, NULL, NULL, NULL)
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (10, NULL, NULL, NULL, NULL)
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (11, NULL, NULL, NULL, NULL)
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (12, NULL, NULL, NULL, NULL)
INSERT [dbo].[TblDbKullanici] ([kullaniciId], [KullaniciAd], [kullaniciSoyad], [KullaniciEmail], [KullaniciSifre]) VALUES (13, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TblDbKullanici] OFF
GO
SET IDENTITY_INSERT [dbo].[TblDbSalata] ON 

INSERT [dbo].[TblDbSalata] ([SalataId], [SalataAd], [SalataFiyat], [SalataResim]) VALUES (1, N'Coban', 5, N'../Content/Resimler/cobansalata.jpeg')
INSERT [dbo].[TblDbSalata] ([SalataId], [SalataAd], [SalataFiyat], [SalataResim]) VALUES (2, N'Mevsim', 7, N'../Content/Resimler/mevsim.jpeg')
INSERT [dbo].[TblDbSalata] ([SalataId], [SalataAd], [SalataFiyat], [SalataResim]) VALUES (3, N'Karisik', 6, N'../Content/Resimler/karisik.jpeg')
INSERT [dbo].[TblDbSalata] ([SalataId], [SalataAd], [SalataFiyat], [SalataResim]) VALUES (4, N'Duble', 11, N'../Content/Resimler/dduble.jpg')
SET IDENTITY_INSERT [dbo].[TblDbSalata] OFF
GO
SET IDENTITY_INSERT [dbo].[TblDbTatli] ON 

INSERT [dbo].[TblDbTatli] ([TatliId], [TatliAD], [TatliFiyat], [TatliResim]) VALUES (1, N'Sutlac', 7, N'../Content/Resimler/sutlac.jpeg')
INSERT [dbo].[TblDbTatli] ([TatliId], [TatliAD], [TatliFiyat], [TatliResim]) VALUES (2, N'Kadayif', 8, N'../Content/Resimler/kadayif.jpg')
INSERT [dbo].[TblDbTatli] ([TatliId], [TatliAD], [TatliFiyat], [TatliResim]) VALUES (3, N'Baklava', 9, N'../Content/Resimler/baklava.jpeg')
INSERT [dbo].[TblDbTatli] ([TatliId], [TatliAD], [TatliFiyat], [TatliResim]) VALUES (4, N'Sekerpare', 8, N'../Content/Resimler/sekerpare.jpeg')
SET IDENTITY_INSERT [dbo].[TblDbTatli] OFF
GO
