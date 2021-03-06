USE [master]
GO
/****** Object:  Database [mefhfjgfj]    Script Date: 12.10.2018 18:37:50 ******/
CREATE DATABASE [mefhfjgfj]
GO
ALTER DATABASE [mefhfjgfj] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mefhfjgfj].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mefhfjgfj] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mefhfjgfj] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mefhfjgfj] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mefhfjgfj] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mefhfjgfj] SET ARITHABORT OFF 
GO
ALTER DATABASE [mefhfjgfj] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mefhfjgfj] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mefhfjgfj] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mefhfjgfj] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mefhfjgfj] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mefhfjgfj] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mefhfjgfj] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mefhfjgfj] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mefhfjgfj] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mefhfjgfj] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mefhfjgfj] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mefhfjgfj] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mefhfjgfj] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [mefhfjgfj] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mefhfjgfj] SET  MULTI_USER 
GO
ALTER DATABASE [mefhfjgfj] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mefhfjgfj] SET ENCRYPTION ON
GO
ALTER DATABASE [mefhfjgfj] SET QUERY_STORE = OFF
GO
USE [mefhfjgfj]
GO
ALTER DATABASE SCOPED CONFIGURATION SET DISABLE_BATCH_MODE_ADAPTIVE_JOINS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET DISABLE_BATCH_MODE_MEMORY_GRANT_FEEDBACK = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET DISABLE_INTERLEAVED_EXECUTION_TVF = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ELEVATE_ONLINE = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ELEVATE_RESUMABLE = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET GLOBAL_TEMPORARY_TABLE_AUTO_DROP = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET ISOLATE_SECURITY_POLICY_CARDINALITY = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET OPTIMIZE_FOR_AD_HOC_WORKLOADS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET XTP_PROCEDURE_EXECUTION_STATISTICS = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET XTP_QUERY_EXECUTION_STATISTICS = OFF;
GO
USE [mefhfjgfj]
GO
/****** Object:  Schema [Event]    Script Date: 12.10.2018 18:38:01 ******/
CREATE SCHEMA [Event]
GO
/****** Object:  Schema [GroupTour]    Script Date: 12.10.2018 18:38:02 ******/
CREATE SCHEMA [GroupTour]
GO
/****** Object:  Schema [HotelList]    Script Date: 12.10.2018 18:38:03 ******/
CREATE SCHEMA [HotelList]
GO
/****** Object:  Schema [Insuarance]    Script Date: 12.10.2018 18:38:04 ******/
CREATE SCHEMA [Insuarance]
GO
/****** Object:  Schema [OnlinePayment]    Script Date: 12.10.2018 18:38:04 ******/
CREATE SCHEMA [OnlinePayment]
GO
/****** Object:  Schema [Tour]    Script Date: 12.10.2018 18:38:05 ******/
CREATE SCHEMA [Tour]
GO
/****** Object:  Schema [Transfer]    Script Date: 12.10.2018 18:38:06 ******/
CREATE SCHEMA [Transfer]
GO
/****** Object:  Schema [Transport]    Script Date: 12.10.2018 18:38:06 ******/
CREATE SCHEMA [Transport]
GO
/****** Object:  Schema [User]    Script Date: 12.10.2018 18:38:07 ******/
CREATE SCHEMA [User]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12.10.2018 18:38:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Abouts]    Script Date: 12.10.2018 18:38:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abouts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[SubText] [nvarchar](max) NULL,
 CONSTRAINT [PK_Abouts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advices]    Script Date: 12.10.2018 18:38:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Text] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
 CONSTRAINT [PK_Advices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 12.10.2018 18:38:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12.10.2018 18:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12.10.2018 18:38:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12.10.2018 18:38:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12.10.2018 18:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12.10.2018 18:38:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 12.10.2018 18:38:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Azerbaijans]    Script Date: 12.10.2018 18:38:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Azerbaijans](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourIcon] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourTitle] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAction] [nvarchar](max) NULL,
	[TourDuration] [nvarchar](max) NULL,
	[TourIdId] [int] NULL,
	[TourId1] [int] NULL,
 CONSTRAINT [PK_Azerbaijans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AzeTitleSubTitles]    Script Date: 12.10.2018 18:38:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AzeTitleSubTitles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstSlide] [nvarchar](max) NULL,
	[FirstSlideText] [nvarchar](max) NULL,
	[SecondSlide] [nvarchar](max) NULL,
	[SecondSlideText] [nvarchar](max) NULL,
	[ThirdSlide] [nvarchar](max) NULL,
	[ThirdSlideText] [nvarchar](max) NULL,
	[FourthSlide] [nvarchar](max) NULL,
	[FourthSlideText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_AzeTitleSubTitles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BakuJaras]    Script Date: 12.10.2018 18:38:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BakuJaras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[TourSecondAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[EventId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_BakuJaras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BilgehDescriptions]    Script Date: 12.10.2018 18:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BilgehDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboutHotel] [nvarchar](max) NULL,
 CONSTRAINT [PK_BilgehDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BilgehPages]    Script Date: 12.10.2018 18:38:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BilgehPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[TourAdditionalSecond] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_BilgehPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BronBilgehs]    Script Date: 12.10.2018 18:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BronBilgehs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_BronBilgehs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BronHotels]    Script Date: 12.10.2018 18:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BronHotels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Price] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[TypeOf] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_BronHotels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BronInfos]    Script Date: 12.10.2018 18:38:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BronInfos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BronEnum] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_BronInfos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BronLankarans]    Script Date: 12.10.2018 18:38:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BronLankarans](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_BronLankarans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BronNaftalans]    Script Date: 12.10.2018 18:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BronNaftalans](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
 CONSTRAINT [PK_BronNaftalans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BronTitles]    Script Date: 12.10.2018 18:38:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BronTitles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourIncludedText] [nvarchar](max) NULL,
	[TourIncludedIcon] [nvarchar](max) NULL,
 CONSTRAINT [PK_BronTitles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compliances]    Script Date: 12.10.2018 18:38:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compliances](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[SubText] [nvarchar](max) NULL,
	[AboutId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_Compliances] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 12.10.2018 18:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[lat] [float] NULL,
	[lng] [float] NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cruizs]    Script Date: 12.10.2018 18:38:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cruizs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[UserId] [int] NOT NULL,
	[ServiceId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_Cruizs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emergencies]    Script Date: 12.10.2018 18:38:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emergencies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Subtitle] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_Emergencies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Festivals]    Script Date: 12.10.2018 18:38:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Festivals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[TourSecondAdditional] [nvarchar](max) NULL,
	[EventId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_Festivals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FireMountainDescriptions]    Script Date: 12.10.2018 18:38:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FireMountainDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourInclude] [nvarchar](max) NULL,
 CONSTRAINT [PK_FireMountainDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FireMountainPages]    Script Date: 12.10.2018 18:38:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FireMountainPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[TourAdditionalSecond] [nvarchar](max) NULL,
 CONSTRAINT [PK_FireMountainPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormulaPages]    Script Date: 12.10.2018 18:38:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormulaPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[TourSecondAdditional] [nvarchar](max) NULL,
	[EventId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_FormulaPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoyGolDescriptions]    Script Date: 12.10.2018 18:38:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoyGolDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourInclude] [nvarchar](max) NULL,
 CONSTRAINT [PK_GoyGolDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoyGolPages]    Script Date: 12.10.2018 18:38:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoyGolPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_GoyGolPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Healths]    Script Date: 12.10.2018 18:38:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Healths](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourIcon] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourTitle] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAction] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
	[TourId] [int] NOT NULL,
 CONSTRAINT [PK_Healths] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HotelListDescriptions]    Script Date: 12.10.2018 18:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HotelListDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HotelLink] [nvarchar](max) NULL,
	[ListHotel] [nvarchar](max) NULL,
 CONSTRAINT [PK_HotelListDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incoming]    Script Date: 12.10.2018 18:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incoming](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourIcon] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourTitle] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAction] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
	[Duration] [nvarchar](max) NULL,
	[TourId] [int] NOT NULL,
 CONSTRAINT [PK_Incoming] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InsuaranceDescriptions]    Script Date: 12.10.2018 18:38:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InsuaranceDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboutInsuarance] [nvarchar](max) NULL,
 CONSTRAINT [PK_InsuaranceDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LankaranDescriptions]    Script Date: 12.10.2018 18:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LankaranDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboutTour] [nvarchar](max) NULL,
 CONSTRAINT [PK_LankaranDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LankaranPages]    Script Date: 12.10.2018 18:38:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LankaranPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[SecondAdditional] [nvarchar](max) NULL,
 CONSTRAINT [PK_LankaranPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MainPages]    Script Date: 12.10.2018 18:38:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MainPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourPrice] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAction] [nvarchar](max) NULL,
	[TourDuration] [nvarchar](max) NULL,
	[TourIdId] [int] NULL,
	[TourId1] [int] NULL,
 CONSTRAINT [PK_MainPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MainPageTitles]    Script Date: 12.10.2018 18:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MainPageTitles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstSlide] [nvarchar](max) NULL,
	[FirstSlideText] [nvarchar](max) NULL,
	[SecondSlide] [nvarchar](max) NULL,
	[SecondSlideText] [nvarchar](max) NULL,
	[ThirdSlide] [nvarchar](max) NULL,
	[ThirdSlideText] [nvarchar](max) NULL,
	[FourthSlide] [nvarchar](max) NULL,
	[FourthSlideText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
 CONSTRAINT [PK_MainPageTitles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 12.10.2018 18:38:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Surname] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](21) NOT NULL,
	[Number] [nvarchar](max) NOT NULL,
	[Messaging] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NaftalanDescriptions]    Script Date: 12.10.2018 18:38:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NaftalanDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Hotels] [nvarchar](max) NULL,
 CONSTRAINT [PK_NaftalanDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NaftalanPages]    Script Date: 12.10.2018 18:38:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NaftalanPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[TourAdditionalSecond] [nvarchar](max) NULL,
 CONSTRAINT [PK_NaftalanPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalInfos]    Script Date: 12.10.2018 18:38:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalInfos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](10) NOT NULL,
	[Surname] [nvarchar](16) NOT NULL,
	[Email] [nvarchar](18) NOT NULL,
	[Number] [int] NOT NULL,
	[PassportNumber] [nvarchar](11) NOT NULL,
	[Birth] [nvarchar](max) NOT NULL,
	[Parent] [int] NOT NULL,
	[Child] [int] NULL,
	[Baby] [int] NULL,
	[Message] [nvarchar](max) NULL,
	[BronHotelId] [int] NOT NULL,
	[DateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PersonalInfos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profiles]    Script Date: 12.10.2018 18:38:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profiles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[SubText] [nvarchar](max) NULL,
	[AboutId] [int] NOT NULL,
 CONSTRAINT [PK_Profiles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QabalaDescriptions]    Script Date: 12.10.2018 18:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QabalaDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboutTour] [nvarchar](max) NULL,
 CONSTRAINT [PK_QabalaDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QabalaPages]    Script Date: 12.10.2018 18:38:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QabalaPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[SecondAdditional] [nvarchar](max) NULL,
 CONSTRAINT [PK_QabalaPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QakhDescriptions]    Script Date: 12.10.2018 18:38:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QakhDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboutTour] [nvarchar](max) NULL,
 CONSTRAINT [PK_QakhDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QakhPages]    Script Date: 12.10.2018 18:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QakhPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[SecondAdditional] [nvarchar](max) NULL,
 CONSTRAINT [PK_QakhPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QubaPageDescriptions]    Script Date: 12.10.2018 18:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QubaPageDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboutQuba] [nvarchar](max) NULL,
 CONSTRAINT [PK_QubaPageDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QubaPages]    Script Date: 12.10.2018 18:38:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QubaPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[SecondAdditional] [nvarchar](max) NULL,
 CONSTRAINT [PK_QubaPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegisterViewModel]    Script Date: 12.10.2018 18:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisterViewModel](
	[Id] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](15) NOT NULL,
	[LastName] [nvarchar](15) NOT NULL,
	[UserName] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[ConfirmPassword] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RegisterViewModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 12.10.2018 18:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[_IsVisible] [bit] NOT NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 12.10.2018 18:38:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Fax] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[OtherAddress] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[Icon] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Instagram] [nvarchar](max) NULL,
	[Twitter] [nvarchar](max) NULL,
	[Linkedin] [nvarchar](max) NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShakiPageDescriptions]    Script Date: 12.10.2018 18:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShakiPageDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TourInclude] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShakiPageDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShakiPages]    Script Date: 12.10.2018 18:38:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShakiPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[TourAdditionalSecond] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShakiPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SimiliarTours]    Script Date: 12.10.2018 18:38:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SimiliarTours](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboutTourIcon] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
 CONSTRAINT [PK_SimiliarTours] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SimpleInformation]    Script Date: 12.10.2018 18:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SimpleInformation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](11) NOT NULL,
	[Surname] [nvarchar](13) NOT NULL,
	[Email] [nvarchar](18) NOT NULL,
	[Number] [int] NOT NULL,
	[Message] [nvarchar](max) NULL,
	[Tour] [nvarchar](max) NOT NULL,
	[DateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SimpleInformation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12.10.2018 18:38:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Surname] [nvarchar](max) NULL,
	[Age] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TitleAndSubTitles]    Script Date: 12.10.2018 18:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TitleAndSubTitles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StaticPage] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[_IsService] [bit] NOT NULL,
 CONSTRAINT [PK_TitleAndSubTitles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransportDescriptions]    Script Date: 12.10.2018 18:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransportDescriptions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[AboutTransport] [nvarchar](max) NULL,
 CONSTRAINT [PK_TransportDescriptions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vips]    Script Date: 12.10.2018 18:38:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vips](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Key] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[SubText] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[OtherPhone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_Vips] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VulkanDescriptions]    Script Date: 12.10.2018 18:38:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VulkanDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AboutTour] [nvarchar](max) NULL,
 CONSTRAINT [PK_VulkanDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VulkanPages]    Script Date: 12.10.2018 18:38:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VulkanPages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[AboutTourText] [nvarchar](max) NULL,
	[AboutTourNumber] [nvarchar](max) NULL,
	[TourImage] [nvarchar](max) NULL,
	[TourName] [nvarchar](max) NULL,
	[TourInformation] [nvarchar](max) NULL,
	[TourVideo] [nvarchar](max) NULL,
	[TourCheckIn] [nvarchar](max) NULL,
	[TourText] [nvarchar](max) NULL,
	[TourTime] [nvarchar](max) NULL,
	[TourAdditional] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[SecondNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[SecondAdditional] [nvarchar](max) NULL,
 CONSTRAINT [PK_VulkanPages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WhyWe]    Script Date: 12.10.2018 18:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WhyWe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[AboutId] [int] NOT NULL,
 CONSTRAINT [PK_WhyWe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Event].[Events]    Script Date: 12.10.2018 18:38:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Event].[Events](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[EventImage] [nvarchar](max) NULL,
	[EventIcon] [nvarchar](max) NULL,
	[EventName] [nvarchar](max) NULL,
	[EventTitle] [nvarchar](max) NULL,
	[EventTime] [nvarchar](max) NULL,
	[EventAction] [nvarchar](max) NULL,
	[Duration] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [GroupTour].[GroupTours]    Script Date: 12.10.2018 18:38:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [GroupTour].[GroupTours](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageText] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_GroupTours] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [HotelList].[HotelLists]    Script Date: 12.10.2018 18:38:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HotelList].[HotelLists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[OtherPhone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
 CONSTRAINT [PK_HotelLists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Insuarance].[Insuarances]    Script Date: 12.10.2018 18:38:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Insuarance].[Insuarances](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[SubText] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[OtherPhone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
 CONSTRAINT [PK_Insuarances] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [OnlinePayment].[OnlinePayments]    Script Date: 12.10.2018 18:38:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [OnlinePayment].[OnlinePayments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CardType] [nvarchar](max) NULL,
	[CardNumber] [nvarchar](max) NULL,
	[ZipCode] [nvarchar](max) NULL,
	[ExpirationDate] [nvarchar](max) NULL,
 CONSTRAINT [PK_OnlinePayments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Tour].[Tours]    Script Date: 12.10.2018 18:38:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Tour].[Tours](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](15) NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[Description] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](60) NOT NULL,
 CONSTRAINT [PK_Tours] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Transfer].[Transfers]    Script Date: 12.10.2018 18:38:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Transfer].[Transfers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](15) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Key] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
	[Number] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[lat] [float] NULL,
	[lng] [float] NULL,
	[UserId] [int] NOT NULL,
	[ServiceId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_Transfers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Transport].[Transports]    Script Date: 12.10.2018 18:38:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Transport].[Transports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[ImageTitle] [nvarchar](max) NULL,
	[Title] [nvarchar](max) NULL,
	[SubTitle] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[OtherPhone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[SiteAddress] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[ServiceId] [int] NOT NULL,
	[TourId] [int] NOT NULL,
	[MessageId] [int] NULL,
 CONSTRAINT [PK_Transports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_Advices_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Advices_ServiceId] ON [dbo].[Advices]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 12.10.2018 18:38:57 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 12.10.2018 18:38:57 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Azerbaijans_TourId1]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Azerbaijans_TourId1] ON [dbo].[Azerbaijans]
(
	[TourId1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Azerbaijans_TourIdId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Azerbaijans_TourIdId] ON [dbo].[Azerbaijans]
(
	[TourIdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BakuJaras_EventId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_BakuJaras_EventId] ON [dbo].[BakuJaras]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_BakuJaras_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_BakuJaras_MessageId] ON [dbo].[BakuJaras]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Compliances_AboutId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Compliances_AboutId] ON [dbo].[Compliances]
(
	[AboutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Compliances_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Compliances_MessageId] ON [dbo].[Compliances]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Contacts_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Contacts_MessageId] ON [dbo].[Contacts]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cruizs_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Cruizs_MessageId] ON [dbo].[Cruizs]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cruizs_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Cruizs_ServiceId] ON [dbo].[Cruizs]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Emergencies_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Emergencies_MessageId] ON [dbo].[Emergencies]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Emergencies_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Emergencies_ServiceId] ON [dbo].[Emergencies]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Festivals_EventId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Festivals_EventId] ON [dbo].[Festivals]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Festivals_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Festivals_MessageId] ON [dbo].[Festivals]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FormulaPages_EventId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_FormulaPages_EventId] ON [dbo].[FormulaPages]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FormulaPages_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_FormulaPages_MessageId] ON [dbo].[FormulaPages]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Healths_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Healths_ServiceId] ON [dbo].[Healths]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Healths_TourId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Healths_TourId] ON [dbo].[Healths]
(
	[TourId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Incoming_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Incoming_ServiceId] ON [dbo].[Incoming]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Incoming_TourId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Incoming_TourId] ON [dbo].[Incoming]
(
	[TourId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MainPages_TourId1]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_MainPages_TourId1] ON [dbo].[MainPages]
(
	[TourId1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MainPages_TourIdId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_MainPages_TourIdId] ON [dbo].[MainPages]
(
	[TourIdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_PersonalInfos_BronHotelId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_PersonalInfos_BronHotelId] ON [dbo].[PersonalInfos]
(
	[BronHotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Profiles_AboutId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Profiles_AboutId] ON [dbo].[Profiles]
(
	[AboutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Vips_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Vips_MessageId] ON [dbo].[Vips]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Vips_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Vips_ServiceId] ON [dbo].[Vips]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_WhyWe_AboutId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_WhyWe_AboutId] ON [dbo].[WhyWe]
(
	[AboutId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Events_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Events_ServiceId] ON [Event].[Events]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GroupTours_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_GroupTours_MessageId] ON [GroupTour].[GroupTours]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_GroupTours_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_GroupTours_ServiceId] ON [GroupTour].[GroupTours]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_HotelLists_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_HotelLists_ServiceId] ON [HotelList].[HotelLists]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Insuarances_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Insuarances_ServiceId] ON [Insuarance].[Insuarances]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transfers_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Transfers_MessageId] ON [Transfer].[Transfers]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transfers_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Transfers_ServiceId] ON [Transfer].[Transfers]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transports_MessageId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Transports_MessageId] ON [Transport].[Transports]
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transports_ServiceId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Transports_ServiceId] ON [Transport].[Transports]
(
	[ServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transports_TourId]    Script Date: 12.10.2018 18:38:57 ******/
CREATE NONCLUSTERED INDEX [IX_Transports_TourId] ON [Transport].[Transports]
(
	[TourId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PersonalInfos] ADD  DEFAULT ((0)) FOR [BronHotelId]
GO
ALTER TABLE [dbo].[PersonalInfos] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [DateTime]
GO
ALTER TABLE [dbo].[SimpleInformation] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [DateTime]
GO
ALTER TABLE [dbo].[Advices]  WITH CHECK ADD  CONSTRAINT [FK_Advices_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Advices] CHECK CONSTRAINT [FK_Advices_Services_ServiceId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Azerbaijans]  WITH CHECK ADD  CONSTRAINT [FK_Azerbaijans_Tours_TourId1] FOREIGN KEY([TourId1])
REFERENCES [Tour].[Tours] ([Id])
GO
ALTER TABLE [dbo].[Azerbaijans] CHECK CONSTRAINT [FK_Azerbaijans_Tours_TourId1]
GO
ALTER TABLE [dbo].[Azerbaijans]  WITH CHECK ADD  CONSTRAINT [FK_Azerbaijans_Tours_TourIdId] FOREIGN KEY([TourIdId])
REFERENCES [Tour].[Tours] ([Id])
GO
ALTER TABLE [dbo].[Azerbaijans] CHECK CONSTRAINT [FK_Azerbaijans_Tours_TourIdId]
GO
ALTER TABLE [dbo].[BakuJaras]  WITH CHECK ADD  CONSTRAINT [FK_BakuJaras_Events_EventId] FOREIGN KEY([EventId])
REFERENCES [Event].[Events] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BakuJaras] CHECK CONSTRAINT [FK_BakuJaras_Events_EventId]
GO
ALTER TABLE [dbo].[BakuJaras]  WITH CHECK ADD  CONSTRAINT [FK_BakuJaras_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [dbo].[BakuJaras] CHECK CONSTRAINT [FK_BakuJaras_Messages_MessageId]
GO
ALTER TABLE [dbo].[Compliances]  WITH CHECK ADD  CONSTRAINT [FK_Compliances_Abouts_AboutId] FOREIGN KEY([AboutId])
REFERENCES [dbo].[Abouts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compliances] CHECK CONSTRAINT [FK_Compliances_Abouts_AboutId]
GO
ALTER TABLE [dbo].[Compliances]  WITH CHECK ADD  CONSTRAINT [FK_Compliances_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [dbo].[Compliances] CHECK CONSTRAINT [FK_Compliances_Messages_MessageId]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Messages_MessageId]
GO
ALTER TABLE [dbo].[Cruizs]  WITH CHECK ADD  CONSTRAINT [FK_Cruizs_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [dbo].[Cruizs] CHECK CONSTRAINT [FK_Cruizs_Messages_MessageId]
GO
ALTER TABLE [dbo].[Cruizs]  WITH CHECK ADD  CONSTRAINT [FK_Cruizs_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cruizs] CHECK CONSTRAINT [FK_Cruizs_Services_ServiceId]
GO
ALTER TABLE [dbo].[Emergencies]  WITH CHECK ADD  CONSTRAINT [FK_Emergencies_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [dbo].[Emergencies] CHECK CONSTRAINT [FK_Emergencies_Messages_MessageId]
GO
ALTER TABLE [dbo].[Emergencies]  WITH CHECK ADD  CONSTRAINT [FK_Emergencies_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Emergencies] CHECK CONSTRAINT [FK_Emergencies_Services_ServiceId]
GO
ALTER TABLE [dbo].[Festivals]  WITH CHECK ADD  CONSTRAINT [FK_Festivals_Events_EventId] FOREIGN KEY([EventId])
REFERENCES [Event].[Events] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Festivals] CHECK CONSTRAINT [FK_Festivals_Events_EventId]
GO
ALTER TABLE [dbo].[Festivals]  WITH CHECK ADD  CONSTRAINT [FK_Festivals_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [dbo].[Festivals] CHECK CONSTRAINT [FK_Festivals_Messages_MessageId]
GO
ALTER TABLE [dbo].[FormulaPages]  WITH CHECK ADD  CONSTRAINT [FK_FormulaPages_Events_EventId] FOREIGN KEY([EventId])
REFERENCES [Event].[Events] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[FormulaPages] CHECK CONSTRAINT [FK_FormulaPages_Events_EventId]
GO
ALTER TABLE [dbo].[FormulaPages]  WITH CHECK ADD  CONSTRAINT [FK_FormulaPages_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [dbo].[FormulaPages] CHECK CONSTRAINT [FK_FormulaPages_Messages_MessageId]
GO
ALTER TABLE [dbo].[Healths]  WITH CHECK ADD  CONSTRAINT [FK_Healths_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Healths] CHECK CONSTRAINT [FK_Healths_Services_ServiceId]
GO
ALTER TABLE [dbo].[Healths]  WITH CHECK ADD  CONSTRAINT [FK_Healths_Tours_TourId] FOREIGN KEY([TourId])
REFERENCES [Tour].[Tours] ([Id])
GO
ALTER TABLE [dbo].[Healths] CHECK CONSTRAINT [FK_Healths_Tours_TourId]
GO
ALTER TABLE [dbo].[Incoming]  WITH CHECK ADD  CONSTRAINT [FK_Incoming_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Incoming] CHECK CONSTRAINT [FK_Incoming_Services_ServiceId]
GO
ALTER TABLE [dbo].[Incoming]  WITH CHECK ADD  CONSTRAINT [FK_Incoming_Tours_TourId] FOREIGN KEY([TourId])
REFERENCES [Tour].[Tours] ([Id])
GO
ALTER TABLE [dbo].[Incoming] CHECK CONSTRAINT [FK_Incoming_Tours_TourId]
GO
ALTER TABLE [dbo].[MainPages]  WITH CHECK ADD  CONSTRAINT [FK_MainPages_Tours_TourId1] FOREIGN KEY([TourId1])
REFERENCES [Tour].[Tours] ([Id])
GO
ALTER TABLE [dbo].[MainPages] CHECK CONSTRAINT [FK_MainPages_Tours_TourId1]
GO
ALTER TABLE [dbo].[MainPages]  WITH CHECK ADD  CONSTRAINT [FK_MainPages_Tours_TourIdId] FOREIGN KEY([TourIdId])
REFERENCES [Tour].[Tours] ([Id])
GO
ALTER TABLE [dbo].[MainPages] CHECK CONSTRAINT [FK_MainPages_Tours_TourIdId]
GO
ALTER TABLE [dbo].[PersonalInfos]  WITH CHECK ADD  CONSTRAINT [FK_PersonalInfos_BronHotels_BronHotelId] FOREIGN KEY([BronHotelId])
REFERENCES [dbo].[BronHotels] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonalInfos] CHECK CONSTRAINT [FK_PersonalInfos_BronHotels_BronHotelId]
GO
ALTER TABLE [dbo].[Profiles]  WITH CHECK ADD  CONSTRAINT [FK_Profiles_Abouts_AboutId] FOREIGN KEY([AboutId])
REFERENCES [dbo].[Abouts] ([Id])
GO
ALTER TABLE [dbo].[Profiles] CHECK CONSTRAINT [FK_Profiles_Abouts_AboutId]
GO
ALTER TABLE [dbo].[Vips]  WITH CHECK ADD  CONSTRAINT [FK_Vips_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [dbo].[Vips] CHECK CONSTRAINT [FK_Vips_Messages_MessageId]
GO
ALTER TABLE [dbo].[Vips]  WITH CHECK ADD  CONSTRAINT [FK_Vips_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vips] CHECK CONSTRAINT [FK_Vips_Services_ServiceId]
GO
ALTER TABLE [dbo].[WhyWe]  WITH CHECK ADD  CONSTRAINT [FK_WhyWe_Abouts_AboutId] FOREIGN KEY([AboutId])
REFERENCES [dbo].[Abouts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[WhyWe] CHECK CONSTRAINT [FK_WhyWe_Abouts_AboutId]
GO
ALTER TABLE [Event].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Event].[Events] CHECK CONSTRAINT [FK_Events_Services_ServiceId]
GO
ALTER TABLE [GroupTour].[GroupTours]  WITH CHECK ADD  CONSTRAINT [FK_GroupTours_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [GroupTour].[GroupTours] CHECK CONSTRAINT [FK_GroupTours_Messages_MessageId]
GO
ALTER TABLE [GroupTour].[GroupTours]  WITH CHECK ADD  CONSTRAINT [FK_GroupTours_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [GroupTour].[GroupTours] CHECK CONSTRAINT [FK_GroupTours_Services_ServiceId]
GO
ALTER TABLE [HotelList].[HotelLists]  WITH CHECK ADD  CONSTRAINT [FK_HotelLists_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [HotelList].[HotelLists] CHECK CONSTRAINT [FK_HotelLists_Services_ServiceId]
GO
ALTER TABLE [Insuarance].[Insuarances]  WITH CHECK ADD  CONSTRAINT [FK_Insuarances_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Insuarance].[Insuarances] CHECK CONSTRAINT [FK_Insuarances_Services_ServiceId]
GO
ALTER TABLE [Transfer].[Transfers]  WITH CHECK ADD  CONSTRAINT [FK_Transfers_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [Transfer].[Transfers] CHECK CONSTRAINT [FK_Transfers_Messages_MessageId]
GO
ALTER TABLE [Transfer].[Transfers]  WITH CHECK ADD  CONSTRAINT [FK_Transfers_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Transfer].[Transfers] CHECK CONSTRAINT [FK_Transfers_Services_ServiceId]
GO
ALTER TABLE [Transport].[Transports]  WITH CHECK ADD  CONSTRAINT [FK_Transports_Messages_MessageId] FOREIGN KEY([MessageId])
REFERENCES [dbo].[Messages] ([Id])
GO
ALTER TABLE [Transport].[Transports] CHECK CONSTRAINT [FK_Transports_Messages_MessageId]
GO
ALTER TABLE [Transport].[Transports]  WITH CHECK ADD  CONSTRAINT [FK_Transports_Services_ServiceId] FOREIGN KEY([ServiceId])
REFERENCES [dbo].[Services] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Transport].[Transports] CHECK CONSTRAINT [FK_Transports_Services_ServiceId]
GO
ALTER TABLE [Transport].[Transports]  WITH CHECK ADD  CONSTRAINT [FK_Transports_Tours_TourId] FOREIGN KEY([TourId])
REFERENCES [Tour].[Tours] ([Id])
GO
ALTER TABLE [Transport].[Transports] CHECK CONSTRAINT [FK_Transports_Tours_TourId]
GO
USE [master]
GO
ALTER DATABASE [mefhfjgfj] SET  READ_WRITE 
GO
