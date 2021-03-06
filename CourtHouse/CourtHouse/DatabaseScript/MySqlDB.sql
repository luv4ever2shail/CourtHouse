USE [master]
GO
/****** Object:  Database [MySqlDB]    Script Date: 2019-03-05 1:55:16 PM ******/
CREATE DATABASE [MySqlDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MySqlDB', FILENAME = N'C:\Users\spatel.SPM\MySqlDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MySqlDB_log', FILENAME = N'C:\Users\spatel.SPM\MySqlDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MySqlDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MySqlDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MySqlDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MySqlDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MySqlDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MySqlDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MySqlDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MySqlDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MySqlDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MySqlDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MySqlDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MySqlDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MySqlDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MySqlDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MySqlDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MySqlDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MySqlDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MySqlDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MySqlDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MySqlDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MySqlDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MySqlDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MySqlDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MySqlDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MySqlDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MySqlDB] SET  MULTI_USER 
GO
ALTER DATABASE [MySqlDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MySqlDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MySqlDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MySqlDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MySqlDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MySqlDB] SET QUERY_STORE = OFF
GO
USE [MySqlDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MySqlDB]
GO
/****** Object:  Table [dbo].[EmployeeLogin]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeLogin](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmpId] [nchar](10) NULL,
	[UserName] [nchar](100) NULL,
	[Password] [nvarchar](max) NOT NULL,
	[EmpName] [varchar](50) NULL,
	[EmpLastname] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evictions]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evictions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FileNo] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [varchar](50) NULL,
	[PostalCode] [varchar](20) NULL,
	[Province] [varchar](30) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[EvictionDate] [nvarchar](50) NULL,
	[OrderNo] [nvarchar](50) NULL,
	[Cancelled] [int] NULL,
	[Stayed] [int] NULL,
	[Filedby] [nvarchar](50) NULL,
	[Datesaved] [datetime] NULL,
	[DateFiled] [datetime] NULL,
 CONSTRAINT [PK_Evictions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WritOfPossesions]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WritOfPossesions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FileNo] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [varchar](50) NULL,
	[PostalCode] [varchar](20) NULL,
	[Province] [varchar](30) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[EvictionDate] [nvarchar](50) NULL,
	[OrderNo] [nvarchar](50) NULL,
	[Cancelled] [int] NULL,
	[Stayed] [int] NULL,
	[Filedby] [nvarchar](50) NULL,
	[Datesaved] [datetime] NULL,
	[DateFiled] [datetime] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EmployeeLogin] ON 

INSERT [dbo].[EmployeeLogin] ([Id], [EmpId], [UserName], [Password], [EmpName], [EmpLastname]) VALUES (1, N'001       ', N'admin                                                                                               ', N'kziWO3/XzdAosc4XprxeJk829AZZJ/McM5Mg9HOc/7s=                                                        ', NULL, NULL)
SET IDENTITY_INSERT [dbo].[EmployeeLogin] OFF
SET IDENTITY_INSERT [dbo].[Evictions] ON 

INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (1, N'201811101001', N'Sam', N'Jones', N'1234 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8077090499', NULL, N'2018-12-19', N'1001', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-10T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (2, N'201811101002', N'Elaine', N'Ulicny', N'1506 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'9811214512', N'', N'2018-12-20', N'1002', 0, 1, N'admin', CAST(N'2018-11-13T12:10:01.413' AS DateTime), CAST(N'2018-09-08T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (3, N'201811101003', N'Mike', N'Lee', N'3500 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8941235221', NULL, N'2018-12-21', N'1003', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-20T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (4, N'201811101004', N'Alice', N'Smith', N'1454 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'1245454115', NULL, N'2018-12-22', N'1004', 0, 1, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-21T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (5, N'201811101005', N'Angel', N'Brown', N'7811 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8121542154', NULL, N'2018-12-23', N'1005', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-11T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (6, N'201811101011', N'Sam', N'Jones', N'1234 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8077090499', NULL, N'2018-12-19', N'1011', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-11-10T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (7, N'201811101012', N'Elaine', N'Ulicny', N'1506 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'9811214512', N'test@gmail.com', N'2018-12-20', N'1012', 0, 1, N'admin', CAST(N'2018-11-13T12:15:09.293' AS DateTime), CAST(N'2018-10-08T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (8, N'201811101013', N'Mike', N'Lee', N'3500 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8941235221', NULL, N'2018-12-21', N'1013', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-10-20T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (9, N'201811101014', N'Alice', N'Smith', N'1454 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'1245454115', NULL, N'2018-12-22', N'1014', 0, 1, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-10-21T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (10, N'201811101015', N'Alice', N'Brown', N'7811 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N' Data Source=spm-sql;Initial Catalog=MySqlDB;User ', N'', N'2018-11-22', N'1015', 1, 0, N'admin', CAST(N'2018-11-13T12:30:21.213' AS DateTime), CAST(N'2018-10-11T10:26:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (25, N'201811101021', N'abc', N'sdfl', N'sdknfsdnfkn''''''''''''''''''''''''''''''''saf', N'skadfsnd', N'sdfk', N'sdkf', N'1234567890', N'sdfksdf', N'2018-11-29', N'14445', 0, 0, N'admin', CAST(N'2018-11-13T09:01:49.890' AS DateTime), CAST(N'2018-11-13T08:39:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (26, N'201811101022', N'Test', N'test', N'test', N'test', N'test', N'test', N'1234567891', N'test', N'2018-11-30', N'1005', 0, 0, N'admin', CAST(N'2018-11-13T12:10:35.177' AS DateTime), CAST(N'2018-11-13T12:10:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (27, N'201811101023', N'testa', N'testa', N'testa', N'windsor', N'n9b1a1', N'ontario', N'1234567890', N'tets@xyz.com', N'2018-11-30', N'10058', 0, 0, N'admin', CAST(N'2018-11-13T12:15:57.023' AS DateTime), CAST(N'2018-11-13T12:15:00.000' AS DateTime))
INSERT [dbo].[Evictions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (28, N'201811101025', N'Test', N'Test', N'12334
victoria avenue', N'windsor', N'n91f13', N'ontario', N'123456789', N'abc@xyz.com', N'2018-12-27', N'12897', 0, 0, N'admin', CAST(N'2018-11-28T10:07:57.487' AS DateTime), CAST(N'2018-11-28T10:07:13.743' AS DateTime))
SET IDENTITY_INSERT [dbo].[Evictions] OFF
SET IDENTITY_INSERT [dbo].[WritOfPossesions] ON 

INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (1, N'201811101006', N'Sam', N'Jones', N'1234 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8077090499', NULL, N'2018/12/19', N'1001', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-15T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (2, N'201811101007', N'Elaine', N'Ulicny', N'1506 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'9811214512', NULL, N'2018/12/20', N'1002', 0, 1, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-12T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (3, N'201811101008', N'Mike', N'Lee', N'3500 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8941235221', NULL, N'2018/12/21', N'1003', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-08T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (4, N'201811101009', N'Alice', N'Smith', N'1454 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'1245454115', NULL, N'2018/12/22', N'1004', 0, 1, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-18T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (5, N'201811101010', N'Angel', N'Brown', N'7811 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8121542154', NULL, N'2018/12/23', N'1005', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-09-20T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (6, N'201811101016', N'Sam', N'Jones', N'1234 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8077090499', NULL, N'2018/12/19', N'1001', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-10-15T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (7, N'201811101017', N'Elaine', N'Ulicny', N'1506 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'9811214512', NULL, N'2018/12/20', N'1002', 0, 1, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-11-12T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (8, N'201811101018', N'Mike', N'Lee', N'3500 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'8941235221', NULL, N'2018/12/21', N'1003', 1, 0, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-11-08T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (9, N'201811101019', N'Alice', N'Smith', N'1454 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'1245454115', NULL, N'2018/12/22', N'1004', 0, 1, N'Shail', CAST(N'2018-09-19T10:26:22.000' AS DateTime), CAST(N'2018-10-18T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (10, N'201811101020', N'Alice', N'Brown', N'7811 Victoria Avenue', N'Windsor', N'N9B 1A1', N'Ontario', N'1234567899', N'', N'2018-12-27', N'1005', 1, 0, N'admin', CAST(N'2018-11-13T12:12:53.277' AS DateTime), CAST(N'2018-10-20T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (13, N'201811101024', N'testwop', N'testwop', N'testwop', N'testwop', N'zxfjsd', N'sdjfn', N'1234567890', N'test@gmail.com', N'2018-11-29', N'10059', 0, 0, N'admin', CAST(N'2018-11-13T12:17:03.843' AS DateTime), CAST(N'2018-11-13T00:00:00.000' AS DateTime))
INSERT [dbo].[WritOfPossesions] ([Id], [FileNo], [FirstName], [LastName], [Address], [City], [PostalCode], [Province], [Phone], [Email], [EvictionDate], [OrderNo], [Cancelled], [Stayed], [Filedby], [Datesaved], [DateFiled]) VALUES (14, N'201811101026', N'test wop', N'test', N'123 victoria avenue', N'windsor', N'n91fr1', N'ontario', N'1234567899', N'abc@xzy.com', N'2018-12-27', N'1290', 0, 0, N'admin', CAST(N'2018-11-28T10:09:28.250' AS DateTime), CAST(N'2018-11-28T10:08:33.660' AS DateTime))
SET IDENTITY_INSERT [dbo].[WritOfPossesions] OFF
/****** Object:  StoredProcedure [dbo].[CountRecords]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[CountRecords]
@type varchar(20)
as
SELECT COUNT(*) FROM
(SELECT *,'Evictions' as Type FROM [dbo].[Evictions]
UNION all
SELECT *,'WOP' as Type FROM [dbo].[WritOfPossesions])A
Where Type = @type
GO
/****** Object:  StoredProcedure [dbo].[CountRecordsBetween]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[CountRecordsBetween]
@type varchar(20),
@datestart date,
@dateto date

as
SELECT COUNT(*) FROM
(SELECT *,'Evictions' as Type FROM [dbo].[Evictions]
UNION all
SELECT *,'WOP' as Type FROM [dbo].[WritOfPossesions])A
Where Type = @type and DateFiled between @datestart and @dateto
GO
/****** Object:  StoredProcedure [dbo].[EvictionsDetails]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE procedure [dbo].[EvictionsDetails]
@filenumber varchar(50)
as

SELECT	*	 
	FROM [MySqlDB].[dbo].[Evictions]
	where FileNo = @filenumber

GO
/****** Object:  StoredProcedure [dbo].[GetAllEvictions]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE procedure [dbo].[GetAllEvictions]

as

SELECT	FileNo,
		FirstName,
		LastName,
		EvictionDate,
		OrderNo,
		CONCAT(FileNo, ' ', FirstName, ' ', LastName, ' ', OrderNo) AS FullSearch		 
	FROM [MySqlDB].[dbo].[Evictions]
ORDER BY FileNo DESC

GO
/****** Object:  StoredProcedure [dbo].[GetAllWOP]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE procedure [dbo].[GetAllWOP]

as

SELECT	FileNo,
		FirstName,
		LastName,
		EvictionDate,
		OrderNo,
		CONCAT(FileNo, ' ', FirstName, ' ', LastName, ' ', OrderNo) AS FullSearch		 
	FROM [MySqlDB].[dbo].[WritOfPossesions]
ORDER BY FileNo DESC

GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeLogininfo]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[GetEmployeeLogininfo]

@username varchar(30),
@password varchar(150)


as

SELECT COUNT(*) FROM [MySqlDB].[dbo].[EmployeeLogin] 
WHERE UserName = @username AND Password = @password



GO
/****** Object:  StoredProcedure [dbo].[GetLastFileNo]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure  [dbo].[GetLastFileNo]
as
SELECT MAX(FileNo) from
(SELECT FileNo FROM [dbo].[Evictions]
UNION all
SELECT FileNo FROM [dbo].[WritOfPossesions])a
GO
/****** Object:  StoredProcedure [dbo].[InsertNewFileNo]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertNewFileNo]
@fileno nvarchar(50),
@datefiled datetime
as

INSERT INTO [MySqlDB].[dbo].[Evictions] (FileNo ,DateFiled) 
VALUES(@fileno,@datefiled)
GO
/****** Object:  StoredProcedure [dbo].[InsertNewFileNoWOP]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[InsertNewFileNoWOP]
@fileno nvarchar(50),
@datefiled datetime
as

INSERT INTO [MySqlDB].[dbo].[WritOfPossesions] (FileNo ,DateFiled) 
VALUES(@fileno,@datefiled)
GO
/****** Object:  StoredProcedure [dbo].[ShowAllRecords]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure  [dbo].[ShowAllRecords]
as
SELECT FileNo,
		FirstName,
		LastName,
		EvictionDate,
		OrderNo,
		DateFiled,
		CONCAT(FileNo, ' ', FirstName, ' ', LastName, ' ', OrderNo) AS FullSearch,
		'Evictions' as Type FROM [dbo].[Evictions]
UNION all
SELECT FileNo,
		FirstName,
		LastName,
		EvictionDate,
		OrderNo,
		DateFiled,
		CONCAT(FileNo, ' ', FirstName, ' ', LastName, ' ', OrderNo) AS FullSearch,
		'WOP' as Type FROM [dbo].[WritOfPossesions]
GO
/****** Object:  StoredProcedure [dbo].[ShowAllRecordsBetween]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure  [dbo].[ShowAllRecordsBetween]
@datestart datetime,
@dateto datetime

as
SELECT * FROM
(SELECT FileNo,
		FirstName,
		LastName,
		EvictionDate,
		OrderNo,
		DateFiled,
		CONCAT(FileNo, ' ', FirstName, ' ', LastName, ' ', OrderNo) AS FullSearch,
		'Evictions' as Type FROM [dbo].[Evictions]
UNION all
SELECT FileNo,
		FirstName,
		LastName,
		EvictionDate,
		OrderNo,
		DateFiled,
		CONCAT(FileNo, ' ', FirstName, ' ', LastName, ' ', OrderNo) AS FullSearch,
		'WOP' as Type FROM [dbo].[WritOfPossesions])a
		where 
		(left(DateFiled,11) BETWEEN @datestart AND @dateto) OR 
		(left(DateFiled,11) BETWEEN @datestart AND @dateto) OR 
		(left(DateFiled,11) <= @datestart AND DateFiled >= @dateto)
		order by DateFiled
GO
/****** Object:  StoredProcedure [dbo].[UpdateEvictions]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[UpdateEvictions]
@file varchar(50),
@firstname nvarchar(50),
@lastname nvarchar(50),
@address nvarchar(100),
@city varchar(50),
@postcode varchar(20),
@province varchar(30),
@contact varchar(50),
@email varchar(100),
@evictiondate nvarchar(50),
@orderno nvarchar(50),
@cancelled int,
@stayed int,
@user nvarchar(50),
@lastsaved datetime
as
UPDATE [MySqlDB].[dbo].[Evictions]
		SET [FirstName]		= @firstname,
			[LastName]		= @lastname,
			[Address]		= @address,
			[City]			= @city,
			[PostalCode]	= @postcode,
			[Province]		= @province,	
			[Phone]			= @contact,
			[Email]			= @email,
			[EvictionDate]	= @evictiondate,
			[OrderNo]		= @orderno,
			[Cancelled]		= @cancelled,
			[Stayed]		= @stayed,
			[Filedby]		= @user,
			[Datesaved]		= @lastsaved
			WHERE [FileNo]	= @file
GO
/****** Object:  StoredProcedure [dbo].[UpdateWOP]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[UpdateWOP]
@file varchar(50),
@firstname nvarchar(50),
@lastname nvarchar(50),
@address nvarchar(100),
@city varchar(50),
@postcode varchar(20),
@province varchar(30),
@contact varchar(50),
@email varchar(100),
@evictiondate nvarchar(50),
@orderno nvarchar(50),
@cancelled int,
@stayed int,
@user nvarchar(50),
@lastsaved datetime
as
UPDATE [MySqlDB].[dbo].[WritOfPossesions]
		SET [FirstName]		= @firstname,
			[LastName]		= @lastname,
			[Address]		= @address,
			[City]			= @city,
			[PostalCode]	= @postcode,
			[Province]		= @province,	
			[Phone]			= @contact,
			[Email]			= @email,
			[EvictionDate]	= @evictiondate,
			[OrderNo]		= @orderno,
			[Cancelled]		= @cancelled,
			[Stayed]		= @stayed,
			[Filedby]		= @user,
			[Datesaved]		= @lastsaved
			WHERE [FileNo]	= @file
GO
/****** Object:  StoredProcedure [dbo].[WOPDetails]    Script Date: 2019-03-05 1:55:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO







CREATE procedure [dbo].[WOPDetails]
@filenumber varchar(50)
as

SELECT	*	 
	FROM [MySqlDB].[dbo].[WritOfPossesions]
	where FileNo = @filenumber

GO
USE [master]
GO
ALTER DATABASE [MySqlDB] SET  READ_WRITE 
GO
