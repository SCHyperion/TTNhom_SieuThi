USE [master]
GO
/****** Object:  Database [QLSieuThi]    Script Date: 2021/03/17 17:01:10 ******/
CREATE DATABASE [QLSieuThi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSieuThi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSieuThi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSieuThi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSieuThi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QLSieuThi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSieuThi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSieuThi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSieuThi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSieuThi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSieuThi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSieuThi] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSieuThi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSieuThi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSieuThi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSieuThi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSieuThi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSieuThi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSieuThi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSieuThi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSieuThi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSieuThi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSieuThi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSieuThi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSieuThi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSieuThi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSieuThi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLSieuThi] SET  MULTI_USER 
GO
ALTER DATABASE [QLSieuThi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSieuThi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSieuThi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSieuThi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSieuThi] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSieuThi] SET QUERY_STORE = OFF
GO
USE [QLSieuThi]
GO
/****** Object:  Table [dbo].[CTHDBan]    Script Date: 2021/03/17 17:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHDBan](
	[MaHD] [smallint] NOT NULL,
	[MaHang] [smallint] NOT NULL,
	[SoLuong] [smallint] NULL,
 CONSTRAINT [PK_CTHDBan] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHDNhap]    Script Date: 2021/03/17 17:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHDNhap](
	[MaHD] [smallint] NOT NULL,
	[MaHang] [smallint] NOT NULL,
	[GiaNhap] [bigint] NULL,
	[SoLuong] [smallint] NULL,
 CONSTRAINT [PK_CTHDNhap] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDBan]    Script Date: 2021/03/17 17:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDBan](
	[MaHD] [smallint] NOT NULL,
	[MaKH] [smallint] NULL,
	[NgayMua] [date] NULL,
 CONSTRAINT [PK_HDBan] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDNhap]    Script Date: 2021/03/17 17:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDNhap](
	[MaHD] [smallint] NOT NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_HDNhap] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 2021/03/17 17:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [smallint] NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [varchar](15) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 2021/03/17 17:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaHang] [smallint] NOT NULL,
	[TenHang] [nvarchar](100) NULL,
	[GiaBan] [bigint] NULL,
	[SoLuongTon] [smallint] NULL,
 CONSTRAINT [PK_MatHang] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 2021/03/17 17:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [smallint] NOT NULL,
	[TenNV] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDT] [varchar](15) NULL,
	[Luong] [bigint] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 2021/03/17 17:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaNV] [smallint] NOT NULL,
	[MatKhau] [varchar](20) NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTHDBan]  WITH CHECK ADD  CONSTRAINT [FK_CTHDBan_HDBan] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HDBan] ([MaHD])
GO
ALTER TABLE [dbo].[CTHDBan] CHECK CONSTRAINT [FK_CTHDBan_HDBan]
GO
ALTER TABLE [dbo].[CTHDBan]  WITH CHECK ADD  CONSTRAINT [FK_CTHDBan_MatHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHang] ([MaHang])
GO
ALTER TABLE [dbo].[CTHDBan] CHECK CONSTRAINT [FK_CTHDBan_MatHang]
GO
ALTER TABLE [dbo].[CTHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTHDNhap_HDNhap] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HDNhap] ([MaHD])
GO
ALTER TABLE [dbo].[CTHDNhap] CHECK CONSTRAINT [FK_CTHDNhap_HDNhap]
GO
ALTER TABLE [dbo].[CTHDNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTHDNhap_MatHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[MatHang] ([MaHang])
GO
ALTER TABLE [dbo].[CTHDNhap] CHECK CONSTRAINT [FK_CTHDNhap_MatHang]
GO
ALTER TABLE [dbo].[HDBan]  WITH CHECK ADD  CONSTRAINT [FK_HDBan_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HDBan] CHECK CONSTRAINT [FK_HDBan_KhachHang]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QLSieuThi] SET  READ_WRITE 
GO
