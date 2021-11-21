USE [master]
GO
/****** Object:  Database [KutuphaneYonetimSistemi]    Script Date: 16.11.2021 18:03:55 ******/
CREATE DATABASE [KutuphaneYonetimSistemi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KutuphaneYonetimSistemi', FILENAME = N'F:\SQL SERVER\MSSQL14.SQLEXPRESS\MSSQL\DATA\KutuphaneYonetimSistemi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KutuphaneYonetimSistemi_log', FILENAME = N'F:\SQL SERVER\MSSQL14.SQLEXPRESS\MSSQL\DATA\KutuphaneYonetimSistemi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KutuphaneYonetimSistemi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET ARITHABORT OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET  MULTI_USER 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET QUERY_STORE = OFF
GO
USE [KutuphaneYonetimSistemi]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Ceza]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Ceza](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BaslangicTarihi] [datetime] NOT NULL,
	[BitisTarihi] [datetime] NOT NULL,
	[Para] [decimal](5, 2) NULL,
	[UyeId] [int] NOT NULL,
	[HareketId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Ceza] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Duyuru]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Duyuru](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tarih] [datetime] NOT NULL,
	[Aciklama] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Duyuru] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Hareket]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Hareket](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlisTarihi] [datetime] NOT NULL,
	[IadeTarihi] [datetime] NOT NULL,
	[KitapId] [int] NOT NULL,
	[UyeId] [int] NOT NULL,
	[PersonelId] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Hareket] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Kasa]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Kasa](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ay] [nvarchar](20) NOT NULL,
	[Yil] [nvarchar](4) NOT NULL,
	[Tutar] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Kasa] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Kategori]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Kategori](
	[Kategori] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Kategori] PRIMARY KEY CLUSTERED 
(
	[Kategori] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Kitap]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Kitap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](150) NOT NULL,
	[BasimYili] [nvarchar](4) NOT NULL,
	[YayinEvi] [nvarchar](100) NOT NULL,
	[SayfaSayisi] [smallint] NOT NULL,
	[Durum] [bit] NOT NULL,
	[KategoriId] [int] NOT NULL,
	[YazarId] [int] NOT NULL,
	[KitapFotoUrl] [nvarchar](500) NULL,
 CONSTRAINT [PK_dbo.Tbl_Kitap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Personel]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Tckn] [nvarchar](11) NOT NULL,
	[Telefon] [nvarchar](20) NOT NULL,
	[Adres] [nvarchar](350) NOT NULL,
	[KullaniciAdi] [nvarchar](15) NOT NULL,
	[Sifre] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Uye]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Uye](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](150) NULL,
	[KullaniciAdi] [nvarchar](15) NOT NULL,
	[Sifre] [nvarchar](15) NOT NULL,
	[Fotograf] [nvarchar](500) NOT NULL,
	[Telefon] [nvarchar](20) NOT NULL,
	[Adres] [nvarchar](350) NOT NULL,
	[Okul] [nvarchar](150) NOT NULL,
	[Tckn] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_dbo.Tbl_Uye] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Yazar]    Script Date: 16.11.2021 18:03:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Yazar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Detay] [nvarchar](2500) NULL,
 CONSTRAINT [PK_dbo.Tbl_Yazar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_HareketId]    Script Date: 16.11.2021 18:03:56 ******/
CREATE NONCLUSTERED INDEX [IX_HareketId] ON [dbo].[Tbl_Ceza]
(
	[HareketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UyeId]    Script Date: 16.11.2021 18:03:56 ******/
CREATE NONCLUSTERED INDEX [IX_UyeId] ON [dbo].[Tbl_Ceza]
(
	[UyeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_KitapId]    Script Date: 16.11.2021 18:03:56 ******/
CREATE NONCLUSTERED INDEX [IX_KitapId] ON [dbo].[Tbl_Hareket]
(
	[KitapId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PersonelId]    Script Date: 16.11.2021 18:03:56 ******/
CREATE NONCLUSTERED INDEX [IX_PersonelId] ON [dbo].[Tbl_Hareket]
(
	[PersonelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_UyeId]    Script Date: 16.11.2021 18:03:56 ******/
CREATE NONCLUSTERED INDEX [IX_UyeId] ON [dbo].[Tbl_Hareket]
(
	[UyeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_KategoriId]    Script Date: 16.11.2021 18:03:56 ******/
CREATE NONCLUSTERED INDEX [IX_KategoriId] ON [dbo].[Tbl_Kitap]
(
	[KategoriId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_YazarId]    Script Date: 16.11.2021 18:03:56 ******/
CREATE NONCLUSTERED INDEX [IX_YazarId] ON [dbo].[Tbl_Kitap]
(
	[YazarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Ceza]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tbl_Ceza_dbo.Tbl_Hareket_HareketId] FOREIGN KEY([HareketId])
REFERENCES [dbo].[Tbl_Hareket] ([Id])
GO
ALTER TABLE [dbo].[Tbl_Ceza] CHECK CONSTRAINT [FK_dbo.Tbl_Ceza_dbo.Tbl_Hareket_HareketId]
GO
ALTER TABLE [dbo].[Tbl_Ceza]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tbl_Ceza_dbo.Tbl_Uye_UyeId] FOREIGN KEY([UyeId])
REFERENCES [dbo].[Tbl_Uye] ([Id])
GO
ALTER TABLE [dbo].[Tbl_Ceza] CHECK CONSTRAINT [FK_dbo.Tbl_Ceza_dbo.Tbl_Uye_UyeId]
GO
ALTER TABLE [dbo].[Tbl_Hareket]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tbl_Hareket_dbo.Tbl_Kitap_KitapId] FOREIGN KEY([KitapId])
REFERENCES [dbo].[Tbl_Kitap] ([Id])
GO
ALTER TABLE [dbo].[Tbl_Hareket] CHECK CONSTRAINT [FK_dbo.Tbl_Hareket_dbo.Tbl_Kitap_KitapId]
GO
ALTER TABLE [dbo].[Tbl_Hareket]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tbl_Hareket_dbo.Tbl_Personel_PersonelId] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Tbl_Personel] ([Id])
GO
ALTER TABLE [dbo].[Tbl_Hareket] CHECK CONSTRAINT [FK_dbo.Tbl_Hareket_dbo.Tbl_Personel_PersonelId]
GO
ALTER TABLE [dbo].[Tbl_Hareket]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tbl_Hareket_dbo.Tbl_Uye_UyeId] FOREIGN KEY([UyeId])
REFERENCES [dbo].[Tbl_Uye] ([Id])
GO
ALTER TABLE [dbo].[Tbl_Hareket] CHECK CONSTRAINT [FK_dbo.Tbl_Hareket_dbo.Tbl_Uye_UyeId]
GO
ALTER TABLE [dbo].[Tbl_Kitap]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tbl_Kitap_dbo.Tbl_Kategori_KategoriId] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Tbl_Kategori] ([Kategori])
GO
ALTER TABLE [dbo].[Tbl_Kitap] CHECK CONSTRAINT [FK_dbo.Tbl_Kitap_dbo.Tbl_Kategori_KategoriId]
GO
ALTER TABLE [dbo].[Tbl_Kitap]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Tbl_Kitap_dbo.Tbl_Yazar_YazarId] FOREIGN KEY([YazarId])
REFERENCES [dbo].[Tbl_Yazar] ([Id])
GO
ALTER TABLE [dbo].[Tbl_Kitap] CHECK CONSTRAINT [FK_dbo.Tbl_Kitap_dbo.Tbl_Yazar_YazarId]
GO
USE [master]
GO
ALTER DATABASE [KutuphaneYonetimSistemi] SET  READ_WRITE 
GO
