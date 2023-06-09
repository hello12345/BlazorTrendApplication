USE [master]
GO
/****** Object:  Database [trend_Kishan]    Script Date: 4/7/2023 12:11:46 PM ******/
CREATE DATABASE [trend_Kishan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'trend_Kishan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\trend_Kishan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'trend_Kishan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\trend_Kishan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [trend_Kishan] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [trend_Kishan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [trend_Kishan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [trend_Kishan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [trend_Kishan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [trend_Kishan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [trend_Kishan] SET ARITHABORT OFF 
GO
ALTER DATABASE [trend_Kishan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [trend_Kishan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [trend_Kishan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [trend_Kishan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [trend_Kishan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [trend_Kishan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [trend_Kishan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [trend_Kishan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [trend_Kishan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [trend_Kishan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [trend_Kishan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [trend_Kishan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [trend_Kishan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [trend_Kishan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [trend_Kishan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [trend_Kishan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [trend_Kishan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [trend_Kishan] SET RECOVERY FULL 
GO
ALTER DATABASE [trend_Kishan] SET  MULTI_USER 
GO
ALTER DATABASE [trend_Kishan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [trend_Kishan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [trend_Kishan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [trend_Kishan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [trend_Kishan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [trend_Kishan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'trend_Kishan', N'ON'
GO
ALTER DATABASE [trend_Kishan] SET QUERY_STORE = OFF
GO
USE [trend_Kishan]
GO
/****** Object:  Table [dbo].[SharedTrends]    Script Date: 4/7/2023 12:11:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SharedTrends](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [varchar](50) NULL,
	[Message] [varchar](2000) NULL,
	[TrendId] [int] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_SharedTrends] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trends]    Script Date: 4/7/2023 12:11:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trends](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TrendType] [varchar](50) NULL,
	[Title] [varchar](2000) NULL,
	[Introduction] [varchar](2000) NULL,
	[Summary] [varchar](2000) NULL,
	[FileUpload] [varchar](2000) NULL,
	[TargetedViewer] [varchar](2000) NULL,
	[UserId] [int] NULL,
	[Active] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
	[Price] [bigint] NULL,
 CONSTRAINT [PK_Trends] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/7/2023 12:11:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Phone] [bigint] NULL,
	[Active] [bit] NULL,
	[OneTimePassword] [bigint] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
	[DeletedBy] [int] NULL,
	[DeletedDate] [datetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetail]    Script Date: 4/7/2023 12:11:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Description] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
 CONSTRAINT [PK_UserDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SharedTrends] ON 

INSERT [dbo].[SharedTrends] ([Id], [Email], [Message], [TrendId], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (1, N'test123@gmail.com', N'wdwdqwd', 1, 1, CAST(N'2022-02-24T17:48:05.483' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[SharedTrends] ([Id], [Email], [Message], [TrendId], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (2, N'ssdd@gamil.com', N'dwdwd', 2, 1, CAST(N'2022-02-25T18:06:06.207' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[SharedTrends] ([Id], [Email], [Message], [TrendId], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (3, N't1@gamil.com', N'Check this trend', 3, 1, CAST(N'2022-02-25T18:31:04.007' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[SharedTrends] ([Id], [Email], [Message], [TrendId], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (4, N'ssdd@gamil.com', N'sfsef', 1, 1, CAST(N'2022-03-01T15:06:18.363' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[SharedTrends] ([Id], [Email], [Message], [TrendId], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (5, N'test123@gmail.com', N'test', 1, 1, CAST(N'2022-03-02T11:59:18.883' AS DateTime), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[SharedTrends] OFF
GO
SET IDENTITY_INSERT [dbo].[Trends] ON 

INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (1, N'Technology', N'Leptop1', N'Dell Leptop123', N'11th Generation Intel® Core™ i5-11320H
Windows 11 Home Single Language
Intel® Iris® Xe Graphics
16 GB, 2 x 8 GB, DDR4, 3200 MHz
512 GB, M.2, PCIe NVMe, SSD
35.5-cm. display
Starting at 1.46 kg', N'726ecfb9-272b-44e4-9575-0c5f82484c79P10.jpg', N'Developer', 2, 1, NULL, NULL, 1, CAST(N'2023-03-18T18:08:41.247' AS DateTime), NULL, NULL, 30)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (2, N'Fashion', N'Tops', N'Branded', N'Test', N'fashion.jpg', N'Designer', 2, 1, NULL, NULL, 1, CAST(N'2022-02-25T19:27:16.177' AS DateTime), 0, CAST(N'2022-02-23T17:35:30.447' AS DateTime), 20)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (3, N'Jwellry', N'Ring', N'Dimond Ring', NULL, N'jwellry.jpg', N'test', 2, 1, NULL, NULL, 1, CAST(N'2022-02-24T12:23:50.330' AS DateTime), 0, CAST(N'2022-02-23T17:32:59.687' AS DateTime), 30)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (5, N'Fashion', N'test', N'test', NULL, N'P4.png', N'test', 6, 0, 1, CAST(N'2022-02-23T14:50:20.133' AS DateTime), NULL, NULL, NULL, NULL, 12)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (7, N'Technology', N'Bettery device', N'Bettery device', N'test', N'P3.png', N'test', 2, 1, 1, CAST(N'2022-02-24T12:36:10.147' AS DateTime), 1, CAST(N'2022-03-01T15:06:50.983' AS DateTime), NULL, NULL, 40)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (8, N'Fashion', N'Umbrella', N'Umbrella', NULL, N'P4.png', NULL, 2, 1, 1, CAST(N'2022-02-24T12:40:15.893' AS DateTime), NULL, NULL, NULL, NULL, 25)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (10, N'Jwellry', N'Test', N'Test', NULL, N'P7.jpg', NULL, 2, 1, 1, CAST(N'2022-02-24T12:51:02.123' AS DateTime), NULL, NULL, NULL, NULL, 12)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (11, N'Technology', N'Test1', N'Test1', NULL, N'P2.png', N'test', 2, 1, 1, CAST(N'2022-02-24T12:51:49.060' AS DateTime), NULL, NULL, NULL, NULL, 25)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (12, N'Technology', N'T1', N't1', NULL, N'P3.png', NULL, 2, 1, 1, CAST(N'2022-02-24T12:52:42.690' AS DateTime), NULL, NULL, 1, CAST(N'2022-03-01T15:07:09.440' AS DateTime), 40)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (13, N'Fashion', N'Curtain', N'dell ', NULL, N'P5.jpeg', N'test', 6, 1, 1, CAST(N'2022-02-24T14:38:52.380' AS DateTime), NULL, NULL, 0, CAST(N'2022-02-25T17:19:54.553' AS DateTime), 15)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (14, N'Education', N'Book', N'Book', N'Book', N'P8.jpg', N'Student', 2, 1, 1, CAST(N'2022-02-25T18:40:48.037' AS DateTime), 1, CAST(N'2022-02-25T18:53:12.610' AS DateTime), 1, CAST(N'2022-03-30T14:54:36.060' AS DateTime), 10)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (15, N'Technology', N'test', N'test', NULL, N'P5.jpeg', N'Developer', 2, 1, 1, CAST(N'2022-03-02T12:24:47.143' AS DateTime), NULL, NULL, 1, CAST(N'2022-03-30T15:39:33.900' AS DateTime), 12)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (17, N'Fashion', N'hnfghnf', N'nbhgdnbhdfgnbhd', N'dgnbdgfnfdg ', N'4f24cb9f-3dc3-4592-ac84-07cd7553bc76P10.jpg', N'gfbfg', 2, 1, 1, CAST(N'2022-03-21T16:47:42.787' AS DateTime), NULL, NULL, 1, CAST(N'2022-03-30T15:00:42.693' AS DateTime), 40)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (18, N'Fashion', N'Test30_03', N'Test30_03', N'Test30_03', N'349139f2-f7ef-4c59-9374-77872d1c3237P7.jpg', N'test', 2, 1, 1, CAST(N'2022-03-30T14:48:21.000' AS DateTime), NULL, NULL, 1, CAST(N'2022-03-30T14:57:39.550' AS DateTime), 34)
INSERT [dbo].[Trends] ([Id], [TrendType], [Title], [Introduction], [Summary], [FileUpload], [TargetedViewer], [UserId], [Active], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate], [Price]) VALUES (19, N'Technology', N'xfgvxdf', N'bhfb', N'fb', N'', N'', 2, 0, 1, CAST(N'2022-03-30T16:17:30.323' AS DateTime), NULL, NULL, 1, CAST(N'2022-03-30T18:44:07.907' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Trends] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (1, N'Rs', N'R', N'Rs', N'12', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (2, N'Kishan', N'parmar', N'Kishan', N'12345', N'test@gmail.com', 123456789, 1, 0, 1, CAST(N'2022-02-16T18:00:32.723' AS DateTime), 1, CAST(N'2022-02-16T18:01:09.437' AS DateTime), NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (3, N'Test', N'', N'', N'', N'', 0, 1, 0, 1, CAST(N'2022-02-16T18:34:07.897' AS DateTime), 1, CAST(N'2022-02-16T18:34:34.710' AS DateTime), NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (4, N'T1', N'T1', N'T1', N'12', N'T1@gmail.com', 123, 1, 8186, 1, CAST(N'2022-02-17T11:18:59.640' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (6, N'Test123', N'Test123', N'Test123', N'123', N'test123@gmail.com', 9874561231, 1, 2616, 1, CAST(N'2022-02-21T13:09:09.987' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (7, N'T1', N'T1', N'T1', N'123', N't1@gamil.com', 9874561231, 0, 7050, 1, CAST(N'2022-02-21T13:51:57.067' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (8, N'T2', N'T2', N'T2', N'12', N't2@gamil.com', 9874561231, 0, 4824, 1, CAST(N'2022-02-21T13:53:48.850' AS DateTime), NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (9, N'T3', N'T3', N'T3', N'12', N'T3@gmail.cpm', 9874561231, 0, 9373, 1, CAST(N'2022-02-21T16:08:15.667' AS DateTime), 1, CAST(N'2022-02-24T18:39:16.977' AS DateTime), NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (10, N'Dipu', N'Parmar', N'Dipu', N'123', N'dipu@gmail.com', 9874561231, 1, 9292, 1, CAST(N'2022-02-25T17:42:18.363' AS DateTime), 1, CAST(N'2022-02-25T17:43:27.713' AS DateTime), NULL, NULL)
INSERT [dbo].[User] ([Id], [FirstName], [LastName], [UserName], [Password], [Email], [Phone], [Active], [OneTimePassword], [CreatedBy], [CreatedDate], [UpdatedBy], [UpdatedDate], [DeletedBy], [DeletedDate]) VALUES (11, N'Test12312', N'Test123', N'Test12312', N'123', N'test123@gmail.com', 1234567898, 1, 8431, 1, CAST(N'2022-03-02T12:04:17.887' AS DateTime), 1, CAST(N'2022-03-02T12:05:14.167' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[UserDetail] ON 

INSERT [dbo].[UserDetail] ([Id], [Name], [Description], [Email]) VALUES (1, N'Test1', N'test', N'Test@gmail.com')
INSERT [dbo].[UserDetail] ([Id], [Name], [Description], [Email]) VALUES (4, N'Test2', N'test2', N'test@gmail.com')
INSERT [dbo].[UserDetail] ([Id], [Name], [Description], [Email]) VALUES (5, N'hnjfg', N'gh', N'gfnf')
INSERT [dbo].[UserDetail] ([Id], [Name], [Description], [Email]) VALUES (6, N'fwc', N'fsefc', N'dsr')
INSERT [dbo].[UserDetail] ([Id], [Name], [Description], [Email]) VALUES (7, N'gfnf', N'gfnfg', N'gfnf')
SET IDENTITY_INSERT [dbo].[UserDetail] OFF
GO
ALTER TABLE [dbo].[Trends]  WITH CHECK ADD  CONSTRAINT [Fk_Trends] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Trends] CHECK CONSTRAINT [Fk_Trends]
GO
USE [master]
GO
ALTER DATABASE [trend_Kishan] SET  READ_WRITE 
GO
