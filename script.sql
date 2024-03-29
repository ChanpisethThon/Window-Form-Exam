USE [master]
GO
/****** Object:  Database [window_form]    Script Date: 10/27/2023 8:41:07 PM ******/
CREATE DATABASE [window_form]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'window_form', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\window_form.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'window_form_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\window_form_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [window_form] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [window_form].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [window_form] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [window_form] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [window_form] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [window_form] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [window_form] SET ARITHABORT OFF 
GO
ALTER DATABASE [window_form] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [window_form] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [window_form] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [window_form] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [window_form] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [window_form] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [window_form] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [window_form] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [window_form] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [window_form] SET  DISABLE_BROKER 
GO
ALTER DATABASE [window_form] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [window_form] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [window_form] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [window_form] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [window_form] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [window_form] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [window_form] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [window_form] SET RECOVERY FULL 
GO
ALTER DATABASE [window_form] SET  MULTI_USER 
GO
ALTER DATABASE [window_form] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [window_form] SET DB_CHAINING OFF 
GO
ALTER DATABASE [window_form] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [window_form] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [window_form] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [window_form] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'window_form', N'ON'
GO
ALTER DATABASE [window_form] SET QUERY_STORE = OFF
GO
USE [window_form]
GO
/****** Object:  Table [dbo].[TblProduct]    Script Date: 10/27/2023 8:41:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblProduct](
	[ProductID] [int] NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[Barcode] [nvarchar](50) NULL,
	[UnitPrice] [float] NULL,
	[SellPrice] [float] NULL,
	[CategoryID] [int] NULL,
	[QtyInStock] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
	[Photo] [image] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblCategory]    Script Date: 10/27/2023 8:41:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCategory](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TblCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_product]    Script Date: 10/27/2023 8:41:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_product]
AS
SELECT        dbo.TblProduct.ProductID, dbo.TblProduct.ProductName, dbo.TblProduct.Barcode, dbo.TblProduct.UnitPrice, dbo.TblProduct.SellPrice, dbo.TblCategory.CategoryName, dbo.TblProduct.QtyInStock, dbo.TblProduct.CreatedDate, 
                         dbo.TblProduct.UpdatedDate, dbo.TblProduct.Photo
FROM            dbo.TblProduct INNER JOIN
                         dbo.TblCategory ON dbo.TblProduct.CategoryID = dbo.TblCategory.CategoryID
GO
/****** Object:  Table [dbo].[user]    Script Date: 10/27/2023 8:41:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[UserName] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TblProduct] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[TblProduct]  WITH CHECK ADD  CONSTRAINT [FK_TblProduct_TblCategory] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[TblCategory] ([CategoryID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TblProduct] CHECK CONSTRAINT [FK_TblProduct_TblCategory]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
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
         Begin Table = "TblProduct"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "TblCategory"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 126
               Right = 485
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_product'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_product'
GO
USE [master]
GO
ALTER DATABASE [window_form] SET  READ_WRITE 
GO
