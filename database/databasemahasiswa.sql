USE [master]
GO
/****** Object:  Database [db_TAPBD]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'db_TAPBD')
BEGIN
CREATE DATABASE [db_TAPBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_TAPBD', FILENAME = N'D:\TA_PBD\Database\db_TAPBD.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_TAPBD_log', FILENAME = N'D:\TA_PBD\Database\db_TAPBD_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 COLLATE Latin1_General_CI_AS
END

GO
ALTER DATABASE [db_TAPBD] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_TAPBD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_TAPBD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_TAPBD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_TAPBD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_TAPBD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_TAPBD] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_TAPBD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_TAPBD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [db_TAPBD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_TAPBD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_TAPBD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_TAPBD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_TAPBD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_TAPBD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_TAPBD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_TAPBD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_TAPBD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_TAPBD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_TAPBD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_TAPBD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_TAPBD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_TAPBD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_TAPBD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_TAPBD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_TAPBD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_TAPBD] SET  MULTI_USER 
GO
ALTER DATABASE [db_TAPBD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_TAPBD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_TAPBD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_TAPBD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\Winmgmt')
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT SERVICE\SQLWriter')
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT Service\MSSQL$SQLEXPRETT]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT Service\MSSQL$SQLEXPRETT')
CREATE LOGIN [NT Service\MSSQL$SQLEXPRETT] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'NT AUTHORITY\SYSTEM')
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [DESKTOP-GHG5F5H\Dian Novita Sari]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'DESKTOP-GHG5F5H\Dian Novita Sari')
CREATE LOGIN [DESKTOP-GHG5F5H\Dian Novita Sari] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [BUILTIN\Users]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'BUILTIN\Users')
CREATE LOGIN [BUILTIN\Users] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyTsqlExecutionLogin##')
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'î+BzOkg¯ÉÛ}³¸ìS&XmB[GP½¦Ò÷V', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 15/06/2017 08.08.26 ******/
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'##MS_PolicyEventProcessingLogin##')
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'´1Uc	õÍÿØÁPf¶ó/c[êDÅ+Îj&ÖÌ¦Ð', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
ALTER AUTHORIZATION ON DATABASE::[db_TAPBD] TO [sa]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQL$SQLEXPRETT]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [DESKTOP-GHG5F5H\Dian Novita Sari]
GO
USE [db_TAPBD]
GO
/****** Object:  Table [dbo].[tbl_login]    Script Date: 15/06/2017 08.08.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_login]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_login](
	[pengguna] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[kata_sandi] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_tbl_login] PRIMARY KEY CLUSTERED 
(
	[pengguna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tbl_login] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_panitia]    Script Date: 15/06/2017 08.08.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_panitia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_panitia](
	[id_panitia] [varchar](8) COLLATE Latin1_General_CI_AS NOT NULL,
	[nama_panitia] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[jenis_kelamin] [varchar](30) COLLATE Latin1_General_CI_AS NOT NULL,
	[alamat] [varchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[no_telepon] [varchar](15) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_tbl_panitia] PRIMARY KEY CLUSTERED 
(
	[id_panitia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tbl_panitia] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_pendaftaran]    Script Date: 15/06/2017 08.08.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_pendaftaran]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_pendaftaran](
	[id_pendaftaran] [varchar](8) COLLATE Latin1_General_CI_AS NOT NULL,
	[nis] [varchar](8) COLLATE Latin1_General_CI_AS NOT NULL,
	[id_panitia] [varchar](8) COLLATE Latin1_General_CI_AS NOT NULL,
	[tanggal_pendaftaran] [date] NOT NULL,
	[kode_prodi] [varchar](8) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_tbl_pendaftaran_1] PRIMARY KEY CLUSTERED 
(
	[id_pendaftaran] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tbl_pendaftaran] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_prodi]    Script Date: 15/06/2017 08.08.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_prodi]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_prodi](
	[kode_prodi] [varchar](8) COLLATE Latin1_General_CI_AS NOT NULL,
	[nama_prodi] [varchar](30) COLLATE Latin1_General_CI_AS NOT NULL,
	[jenjang_pendidikan] [varchar](8) COLLATE Latin1_General_CI_AS NOT NULL,
	[biaya_pendaftaran] [varchar](30) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_tbl_prodi] PRIMARY KEY CLUSTERED 
(
	[kode_prodi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tbl_prodi] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[tbl_siswapendaftar]    Script Date: 15/06/2017 08.08.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_siswapendaftar]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_siswapendaftar](
	[nis] [varchar](8) COLLATE Latin1_General_CI_AS NOT NULL,
	[nama_siswa] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[jenis_kelamin] [varchar](15) COLLATE Latin1_General_CI_AS NOT NULL,
	[alamat] [varchar](100) COLLATE Latin1_General_CI_AS NOT NULL,
	[tanggal_lahir] [date] NOT NULL,
	[asal_sekolah] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[no_telepon] [varchar](15) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_tbl_siswapendaftar] PRIMARY KEY CLUSTERED 
(
	[nis] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[tbl_siswapendaftar] TO  SCHEMA OWNER 
GO
/****** Object:  View [dbo].[vw_detail_pendaftaran]    Script Date: 15/06/2017 08.08.26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_detail_pendaftaran]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[vw_detail_pendaftaran]
AS
SELECT        dbo.tbl_pendaftaran.id_pendaftaran, dbo.tbl_panitia.id_panitia, dbo.tbl_panitia.nama_panitia, dbo.tbl_siswapendaftar.nis, dbo.tbl_siswapendaftar.nama_siswa, dbo.tbl_siswapendaftar.tanggal_lahir, 
                         dbo.tbl_siswapendaftar.jenis_kelamin, dbo.tbl_siswapendaftar.alamat, dbo.tbl_siswapendaftar.asal_sekolah, dbo.tbl_siswapendaftar.no_telepon, dbo.tbl_prodi.kode_prodi, dbo.tbl_prodi.nama_prodi, 
                         dbo.tbl_prodi.jenjang_pendidikan, dbo.tbl_prodi.biaya_pendaftaran, dbo.tbl_pendaftaran.tanggal_pendaftaran
FROM            dbo.tbl_panitia INNER JOIN
                         dbo.tbl_pendaftaran ON dbo.tbl_panitia.id_panitia = dbo.tbl_pendaftaran.id_panitia INNER JOIN
                         dbo.tbl_prodi ON dbo.tbl_pendaftaran.kode_prodi = dbo.tbl_prodi.kode_prodi INNER JOIN
                         dbo.tbl_siswapendaftar ON dbo.tbl_pendaftaran.nis = dbo.tbl_siswapendaftar.nis
' 
GO
ALTER AUTHORIZATION ON [dbo].[vw_detail_pendaftaran] TO  SCHEMA OWNER 
GO
INSERT [dbo].[tbl_login] ([pengguna], [kata_sandi]) VALUES (N'user', N'123')
INSERT [dbo].[tbl_panitia] ([id_panitia], [nama_panitia], [jenis_kelamin], [alamat], [no_telepon]) VALUES (N'PNT0001', N'Dian Nopita', N'Perempuan', N'kotabumi', N'089605110371')
INSERT [dbo].[tbl_pendaftaran] ([id_pendaftaran], [nis], [id_panitia], [tanggal_pendaftaran], [kode_prodi]) VALUES (N'PDF0001', N'NS0001', N'PNT0001', CAST(0xEC3C0B00 AS Date), N'PRD0001')
INSERT [dbo].[tbl_prodi] ([kode_prodi], [nama_prodi], [jenjang_pendidikan], [biaya_pendaftaran]) VALUES (N'PRD0001', N'Teknik Informatika', N'Srata 1', N'Rp 300000')
INSERT [dbo].[tbl_siswapendaftar] ([nis], [nama_siswa], [jenis_kelamin], [alamat], [tanggal_lahir], [asal_sekolah], [no_telepon]) VALUES (N'NS0001', N'ditha', N'perempuan', N'Lampung selatan', CAST(0x18200B00 AS Date), N'smk yadika bandar lampung', N'0822567445778')
INSERT [dbo].[tbl_siswapendaftar] ([nis], [nama_siswa], [jenis_kelamin], [alamat], [tanggal_lahir], [asal_sekolah], [no_telepon]) VALUES (N'NS0002', N'Dian Novita Sari', N'Perempuan', N'Lampung Utara', CAST(0x8F1F0B00 AS Date), N'SMKN 1 KOTABUMI', N'085768925246')
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbl_pendaftaran_tbl_panitia]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_pendaftaran]'))
ALTER TABLE [dbo].[tbl_pendaftaran]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pendaftaran_tbl_panitia] FOREIGN KEY([id_panitia])
REFERENCES [dbo].[tbl_panitia] ([id_panitia])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbl_pendaftaran_tbl_panitia]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_pendaftaran]'))
ALTER TABLE [dbo].[tbl_pendaftaran] CHECK CONSTRAINT [FK_tbl_pendaftaran_tbl_panitia]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbl_pendaftaran_tbl_prodi]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_pendaftaran]'))
ALTER TABLE [dbo].[tbl_pendaftaran]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pendaftaran_tbl_prodi] FOREIGN KEY([kode_prodi])
REFERENCES [dbo].[tbl_prodi] ([kode_prodi])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbl_pendaftaran_tbl_prodi]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_pendaftaran]'))
ALTER TABLE [dbo].[tbl_pendaftaran] CHECK CONSTRAINT [FK_tbl_pendaftaran_tbl_prodi]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbl_pendaftaran_tbl_siswapendaftar]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_pendaftaran]'))
ALTER TABLE [dbo].[tbl_pendaftaran]  WITH CHECK ADD  CONSTRAINT [FK_tbl_pendaftaran_tbl_siswapendaftar] FOREIGN KEY([nis])
REFERENCES [dbo].[tbl_siswapendaftar] ([nis])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbl_pendaftaran_tbl_siswapendaftar]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_pendaftaran]'))
ALTER TABLE [dbo].[tbl_pendaftaran] CHECK CONSTRAINT [FK_tbl_pendaftaran_tbl_siswapendaftar]
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'vw_detail_pendaftaran', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[33] 2[9] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_panitia"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_pendaftaran"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 186
               Right = 444
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_prodi"
            Begin Extent = 
               Top = 134
               Left = 484
               Bottom = 264
               Right = 676
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tbl_siswapendaftar"
            Begin Extent = 
               Top = 0
               Left = 476
               Bottom = 148
               Right = 646
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail_pendaftaran'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'vw_detail_pendaftaran', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_detail_pendaftaran'
GO
USE [master]
GO
ALTER DATABASE [db_TAPBD] SET  READ_WRITE 
GO
