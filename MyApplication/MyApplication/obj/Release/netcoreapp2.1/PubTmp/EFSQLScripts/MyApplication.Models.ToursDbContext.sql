IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'Event') IS NULL EXEC(N'CREATE SCHEMA [Event];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'GroupTour') IS NULL EXEC(N'CREATE SCHEMA [GroupTour];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'HotelList') IS NULL EXEC(N'CREATE SCHEMA [HotelList];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'Insuarance') IS NULL EXEC(N'CREATE SCHEMA [Insuarance];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'OnlinePayment') IS NULL EXEC(N'CREATE SCHEMA [OnlinePayment];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'Tour') IS NULL EXEC(N'CREATE SCHEMA [Tour];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'Transfer') IS NULL EXEC(N'CREATE SCHEMA [Transfer];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'Transport') IS NULL EXEC(N'CREATE SCHEMA [Transport];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    IF SCHEMA_ID(N'User') IS NULL EXEC(N'CREATE SCHEMA [User];');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Abouts] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [SubText] nvarchar(max) NULL,
        CONSTRAINT [PK_Abouts] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [AzeTitleSubTitles] (
        [Id] int NOT NULL IDENTITY,
        [FirstSlide] nvarchar(max) NULL,
        [FirstSlideText] nvarchar(max) NULL,
        [SecondSlide] nvarchar(max) NULL,
        [SecondSlideText] nvarchar(max) NULL,
        [ThirdSlide] nvarchar(max) NULL,
        [ThirdSlideText] nvarchar(max) NULL,
        [FourthSlide] nvarchar(max) NULL,
        [FourthSlideText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        CONSTRAINT [PK_AzeTitleSubTitles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [BilgehDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [AboutHotel] nvarchar(max) NULL,
        CONSTRAINT [PK_BilgehDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [BilgehPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [TourAdditionalSecond] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        CONSTRAINT [PK_BilgehPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [BronBilgehs] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_BronBilgehs] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [BronGoyGols] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_BronGoyGols] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [BronNaftalans] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_BronNaftalans] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [BronOnlyTransfers] (
        [Id] int NOT NULL IDENTITY,
        [AboutTour] nvarchar(max) NULL,
        CONSTRAINT [PK_BronOnlyTransfers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [BronTitles] (
        [Id] int NOT NULL IDENTITY,
        [TourIncludedText] nvarchar(max) NULL,
        [TourIncludedIcon] nvarchar(max) NULL,
        CONSTRAINT [PK_BronTitles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [FireMountainDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [TourInclude] nvarchar(max) NULL,
        CONSTRAINT [PK_FireMountainDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [FireMountainPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [TourAdditionalSecond] nvarchar(max) NULL,
        CONSTRAINT [PK_FireMountainPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [GoyGolDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [TourInclude] nvarchar(max) NULL,
        CONSTRAINT [PK_GoyGolDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [GoyGolPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        CONSTRAINT [PK_GoyGolPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [HotelListDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [HotelLink] nvarchar(max) NULL,
        [ListHotel] nvarchar(max) NULL,
        CONSTRAINT [PK_HotelListDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [InsuaranceDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [AboutInsuarance] nvarchar(max) NULL,
        CONSTRAINT [PK_InsuaranceDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [LankaranDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [AboutTour] nvarchar(max) NULL,
        CONSTRAINT [PK_LankaranDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [LankaranPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [SecondAdditional] nvarchar(max) NULL,
        CONSTRAINT [PK_LankaranPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [MainPageTitles] (
        [Id] int NOT NULL IDENTITY,
        [FirstSlide] nvarchar(max) NULL,
        [FirstSlideText] nvarchar(max) NULL,
        [SecondSlide] nvarchar(max) NULL,
        [SecondSlideText] nvarchar(max) NULL,
        [ThirdSlide] nvarchar(max) NULL,
        [ThirdSlideText] nvarchar(max) NULL,
        [FourthSlide] nvarchar(max) NULL,
        [FourthSlideText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        CONSTRAINT [PK_MainPageTitles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Messages] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Surname] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [Number] nvarchar(max) NOT NULL,
        [Messaging] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Messages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [NaftalanDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [Hotels] nvarchar(max) NULL,
        CONSTRAINT [PK_NaftalanDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [NaftalanPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [TourAdditionalSecond] nvarchar(max) NULL,
        CONSTRAINT [PK_NaftalanPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [PersonalInfos] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Surname] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [Number] int NOT NULL,
        [PassportNumber] nvarchar(max) NOT NULL,
        [Birth] nvarchar(max) NOT NULL,
        [Parent] int NOT NULL,
        [Child] int NULL,
        [Baby] int NULL,
        [Message] nvarchar(max) NULL,
        CONSTRAINT [PK_PersonalInfos] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [QabalaDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [AboutTour] nvarchar(max) NULL,
        CONSTRAINT [PK_QabalaDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [QabalaPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [SecondAdditional] nvarchar(max) NULL,
        CONSTRAINT [PK_QabalaPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [QakhDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [AboutTour] nvarchar(max) NULL,
        CONSTRAINT [PK_QakhDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [QakhPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [SecondAdditional] nvarchar(max) NULL,
        CONSTRAINT [PK_QakhPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [QubaPageDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [AboutQuba] nvarchar(max) NULL,
        CONSTRAINT [PK_QubaPageDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [QubaPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [SecondAdditional] nvarchar(max) NULL,
        CONSTRAINT [PK_QubaPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Services] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [_IsVisible] bit NOT NULL,
        CONSTRAINT [PK_Services] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Settings] (
        [Id] int NOT NULL IDENTITY,
        [Email] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [Fax] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [OtherAddress] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Icon] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [Facebook] nvarchar(max) NULL,
        [Instagram] nvarchar(max) NULL,
        [Twitter] nvarchar(max) NULL,
        [Linkedin] nvarchar(max) NULL,
        CONSTRAINT [PK_Settings] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [ShakiPageDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [TourInclude] nvarchar(max) NULL,
        CONSTRAINT [PK_ShakiPageDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [ShakiPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [TourAdditionalSecond] nvarchar(max) NULL,
        CONSTRAINT [PK_ShakiPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Students] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Surname] nvarchar(max) NULL,
        [Age] int NOT NULL,
        CONSTRAINT [PK_Students] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [TitleAndSubTitles] (
        [Id] int NOT NULL IDENTITY,
        [StaticPage] int NOT NULL,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [_IsService] bit NOT NULL,
        CONSTRAINT [PK_TitleAndSubTitles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [TransportDescriptions] (
        [id] int NOT NULL IDENTITY,
        [AboutTransport] nvarchar(max) NULL,
        CONSTRAINT [PK_TransportDescriptions] PRIMARY KEY ([id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [VulkanDescriptions] (
        [Id] int NOT NULL IDENTITY,
        [AboutTour] nvarchar(max) NULL,
        CONSTRAINT [PK_VulkanDescriptions] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [VulkanPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [SecondAdditional] nvarchar(max) NULL,
        CONSTRAINT [PK_VulkanPages] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [User].[Users] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(15) NOT NULL,
        [Surname] nvarchar(20) NOT NULL,
        [Email] nvarchar(40) NOT NULL,
        [Phone] int NOT NULL,
        [PassportNumber] nvarchar(max) NULL,
        [Password] nvarchar(18) NOT NULL,
        [Number] nvarchar(max) NULL,
        [_Isbronned] bit NOT NULL,
        [ZipCode] nvarchar(max) NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Profiles] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [SubText] nvarchar(max) NULL,
        [AboutId] int NOT NULL,
        CONSTRAINT [PK_Profiles] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Profiles_Abouts_AboutId] FOREIGN KEY ([AboutId]) REFERENCES [Abouts] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [WhyWe] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [AboutId] int NOT NULL,
        CONSTRAINT [PK_WhyWe] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_WhyWe_Abouts_AboutId] FOREIGN KEY ([AboutId]) REFERENCES [Abouts] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Compliances] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [SubText] nvarchar(max) NULL,
        [AboutId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_Compliances] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Compliances_Abouts_AboutId] FOREIGN KEY ([AboutId]) REFERENCES [Abouts] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Compliances_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Contacts] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [lat] float NULL,
        [lng] float NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_Contacts] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Contacts_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Advices] (
        [Id] int NOT NULL IDENTITY,
        [Text] nvarchar(max) NULL,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        CONSTRAINT [PK_Advices] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Advices_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Emergencies] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [Subtitle] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_Emergencies] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Emergencies_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Emergencies_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Event].[Events] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [EventImage] nvarchar(max) NULL,
        [EventIcon] nvarchar(max) NULL,
        [EventName] nvarchar(max) NULL,
        [EventTitle] nvarchar(max) NULL,
        [EventTime] nvarchar(max) NULL,
        [EventAction] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        CONSTRAINT [PK_Events] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Events_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [HotelList].[HotelLists] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [OtherPhone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        CONSTRAINT [PK_HotelLists] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_HotelLists_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Insuarance].[Insuarances] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [SubText] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [OtherPhone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        CONSTRAINT [PK_Insuarances] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Insuarances_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Cruizs] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Price] decimal(18, 2) NOT NULL,
        [UserId] int NOT NULL,
        [ServiceId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_Cruizs] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Cruizs_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Cruizs_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Cruizs_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [User].[Users] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Vips] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Key] nvarchar(max) NULL,
        [Value] nvarchar(max) NULL,
        [Text] nvarchar(max) NULL,
        [SubText] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [OtherPhone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        [UserId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_Vips] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Vips_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Vips_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Vips_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [User].[Users] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [GroupTour].[GroupTours] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Name] nvarchar(max) NULL,
        [Price] decimal(18, 2) NOT NULL,
        [Description] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        [UserId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_GroupTours] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_GroupTours_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_GroupTours_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_GroupTours_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [User].[Users] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [OnlinePayment].[OnlinePayments] (
        [Id] int NOT NULL IDENTITY,
        [CardType] nvarchar(max) NULL,
        [CardNumber] nvarchar(max) NULL,
        [ZipCode] nvarchar(max) NULL,
        [ExpirationDate] nvarchar(max) NULL,
        [UserId] int NOT NULL,
        CONSTRAINT [PK_OnlinePayments] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_OnlinePayments_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [User].[Users] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Tour].[Tours] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(15) NOT NULL,
        [Price] decimal(18, 2) NULL,
        [Description] nvarchar(max) NULL,
        [ImagePath] nvarchar(60) NOT NULL,
        [UserId] int NOT NULL,
        CONSTRAINT [PK_Tours] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Tours_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [User].[Users] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Transfer].[Transfers] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(15) NOT NULL,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Key] nvarchar(max) NULL,
        [Value] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [lat] float NULL,
        [lng] float NULL,
        [UserId] int NOT NULL,
        [ServiceId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_Transfers] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Transfers_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Transfers_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Transfers_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [User].[Users] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [BakuJaras] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [TourSecondAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [EventId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_BakuJaras] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_BakuJaras_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event].[Events] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_BakuJaras_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Festivals] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [TourSecondAdditional] nvarchar(max) NULL,
        [EventId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_Festivals] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Festivals_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event].[Events] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Festivals_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [FormulaPages] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [Code] nvarchar(max) NULL,
        [Price] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourInformation] nvarchar(max) NULL,
        [TourVideo] nvarchar(max) NULL,
        [TourCheckIn] nvarchar(max) NULL,
        [TourText] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAdditional] nvarchar(max) NULL,
        [Number] nvarchar(max) NULL,
        [SecondNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [TourSecondAdditional] nvarchar(max) NULL,
        [EventId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_FormulaPages] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_FormulaPages_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event].[Events] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_FormulaPages_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Azerbaijans] (
        [Id] int NOT NULL IDENTITY,
        [TourImage] nvarchar(max) NULL,
        [TourIcon] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourTitle] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAction] nvarchar(max) NULL,
        [TourDuration] nvarchar(max) NULL,
        [TourIdId] int NULL,
        [TourId1] int NULL,
        CONSTRAINT [PK_Azerbaijans] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Azerbaijans_Tours_TourId1] FOREIGN KEY ([TourId1]) REFERENCES [Tour].[Tours] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Azerbaijans_Tours_TourIdId] FOREIGN KEY ([TourIdId]) REFERENCES [Tour].[Tours] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Healths] (
        [Id] int NOT NULL IDENTITY,
        [TourImage] nvarchar(max) NULL,
        [TourIcon] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourTitle] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAction] nvarchar(max) NULL,
        [Duration] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        [TourId] int NOT NULL,
        CONSTRAINT [PK_Healths] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Healths_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Healths_Tours_TourId] FOREIGN KEY ([TourId]) REFERENCES [Tour].[Tours] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Incoming] (
        [Id] int NOT NULL IDENTITY,
        [TourImage] nvarchar(max) NULL,
        [TourIcon] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourTitle] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAction] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        [Duration] nvarchar(max) NULL,
        [TourId] int NOT NULL,
        CONSTRAINT [PK_Incoming] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Incoming_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Incoming_Tours_TourId] FOREIGN KEY ([TourId]) REFERENCES [Tour].[Tours] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [MainPages] (
        [Id] int NOT NULL IDENTITY,
        [TourImage] nvarchar(max) NULL,
        [TourName] nvarchar(max) NULL,
        [TourPrice] nvarchar(max) NULL,
        [TourTime] nvarchar(max) NULL,
        [TourAction] nvarchar(max) NULL,
        [TourDuration] nvarchar(max) NULL,
        [TourIdId] int NULL,
        [TourId1] int NULL,
        CONSTRAINT [PK_MainPages] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_MainPages_Tours_TourId1] FOREIGN KEY ([TourId1]) REFERENCES [Tour].[Tours] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_MainPages_Tours_TourIdId] FOREIGN KEY ([TourIdId]) REFERENCES [Tour].[Tours] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE TABLE [Transport].[Transports] (
        [Id] int NOT NULL IDENTITY,
        [Price] decimal(18, 2) NOT NULL,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        [SubTitle] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [OtherPhone] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [SiteAddress] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        [ServiceId] int NOT NULL,
        [TourId] int NOT NULL,
        [UserId] int NOT NULL,
        [MessageId] int NULL,
        CONSTRAINT [PK_Transports] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Transports_Messages_MessageId] FOREIGN KEY ([MessageId]) REFERENCES [Messages] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Transports_Services_ServiceId] FOREIGN KEY ([ServiceId]) REFERENCES [Services] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Transports_Tours_TourId] FOREIGN KEY ([TourId]) REFERENCES [Tour].[Tours] ([Id]),
        CONSTRAINT [FK_Transports_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [User].[Users] ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Advices_ServiceId] ON [Advices] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Azerbaijans_TourId1] ON [Azerbaijans] ([TourId1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Azerbaijans_TourIdId] ON [Azerbaijans] ([TourIdId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE UNIQUE INDEX [IX_BakuJaras_EventId] ON [BakuJaras] ([EventId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_BakuJaras_MessageId] ON [BakuJaras] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Compliances_AboutId] ON [Compliances] ([AboutId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Compliances_MessageId] ON [Compliances] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Contacts_MessageId] ON [Contacts] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Cruizs_MessageId] ON [Cruizs] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Cruizs_ServiceId] ON [Cruizs] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Cruizs_UserId] ON [Cruizs] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Emergencies_MessageId] ON [Emergencies] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Emergencies_ServiceId] ON [Emergencies] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE UNIQUE INDEX [IX_Festivals_EventId] ON [Festivals] ([EventId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Festivals_MessageId] ON [Festivals] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE UNIQUE INDEX [IX_FormulaPages_EventId] ON [FormulaPages] ([EventId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_FormulaPages_MessageId] ON [FormulaPages] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Healths_ServiceId] ON [Healths] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Healths_TourId] ON [Healths] ([TourId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Incoming_ServiceId] ON [Incoming] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Incoming_TourId] ON [Incoming] ([TourId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_MainPages_TourId1] ON [MainPages] ([TourId1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_MainPages_TourIdId] ON [MainPages] ([TourIdId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Profiles_AboutId] ON [Profiles] ([AboutId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Vips_MessageId] ON [Vips] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Vips_ServiceId] ON [Vips] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Vips_UserId] ON [Vips] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_WhyWe_AboutId] ON [WhyWe] ([AboutId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Events_ServiceId] ON [Event].[Events] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_GroupTours_MessageId] ON [GroupTour].[GroupTours] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_GroupTours_ServiceId] ON [GroupTour].[GroupTours] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_GroupTours_UserId] ON [GroupTour].[GroupTours] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_HotelLists_ServiceId] ON [HotelList].[HotelLists] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Insuarances_ServiceId] ON [Insuarance].[Insuarances] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_OnlinePayments_UserId] ON [OnlinePayment].[OnlinePayments] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Tours_UserId] ON [Tour].[Tours] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Transfers_MessageId] ON [Transfer].[Transfers] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Transfers_ServiceId] ON [Transfer].[Transfers] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Transfers_UserId] ON [Transfer].[Transfers] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Transports_MessageId] ON [Transport].[Transports] ([MessageId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Transports_ServiceId] ON [Transport].[Transports] ([ServiceId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Transports_TourId] ON [Transport].[Transports] ([TourId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    CREATE INDEX [IX_Transports_UserId] ON [Transport].[Transports] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180926130435_One')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180926130435_One', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180928114745_UpToDate')
BEGIN
    CREATE TABLE [BronHotels] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(30) NOT NULL,
        [Price] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        CONSTRAINT [PK_BronHotels] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180928114745_UpToDate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180928114745_UpToDate', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929065550_UpToDataa')
BEGIN
    ALTER TABLE [PersonalInfos] ADD [BronHotelId] int NOT NULL DEFAULT 0;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929065550_UpToDataa')
BEGIN
    CREATE UNIQUE INDEX [IX_PersonalInfos_BronHotelId] ON [PersonalInfos] ([BronHotelId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929065550_UpToDataa')
BEGIN
    ALTER TABLE [PersonalInfos] ADD CONSTRAINT [FK_PersonalInfos_BronHotels_BronHotelId] FOREIGN KEY ([BronHotelId]) REFERENCES [BronHotels] ([Id]) ON DELETE CASCADE;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929065550_UpToDataa')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180929065550_UpToDataa', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929081506_UpToDataab')
BEGIN
    ALTER TABLE [BronHotels] ADD [TypeOf] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929081506_UpToDataab')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180929081506_UpToDataab', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929082251_AddingBronLankaran')
BEGIN
    CREATE TABLE [BronLankarans] (
        [Id] int NOT NULL IDENTITY,
        [ImagePath] nvarchar(max) NULL,
        [ImageTitle] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_BronLankarans] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929082251_AddingBronLankaran')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180929082251_AddingBronLankaran', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929125441_AddingSimiliarss')
BEGIN
    CREATE TABLE [BronInfos] (
        [Id] int NOT NULL IDENTITY,
        [BronEnum] int NOT NULL,
        [ImagePath] nvarchar(max) NULL,
        [ImageText] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        [AboutTourNumber] nvarchar(max) NULL,
        CONSTRAINT [PK_BronInfos] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929125441_AddingSimiliarss')
BEGIN
    CREATE TABLE [SimiliarTours] (
        [Id] int NOT NULL IDENTITY,
        [AboutTourIcon] nvarchar(max) NULL,
        [AboutTourText] nvarchar(max) NULL,
        CONSTRAINT [PK_SimiliarTours] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929125441_AddingSimiliarss')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180929125441_AddingSimiliarss', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929132110_AddingSimpleInfo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180929132110_AddingSimpleInfo', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929140409_AddingSimpleInfosssu')
BEGIN
    CREATE TABLE [SimpleInformation] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Surname] nvarchar(max) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [Number] int NOT NULL,
        [Message] nvarchar(max) NULL,
        CONSTRAINT [PK_SimpleInformation] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180929140409_AddingSimpleInfosssu')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180929140409_AddingSimpleInfosssu', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930064624_TourAddToSimpleInfo')
BEGIN
    ALTER TABLE [SimpleInformation] ADD [Tour] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930064624_TourAddToSimpleInfo')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180930064624_TourAddToSimpleInfo', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930074137_TourAddToSimpleInfoss')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SimpleInformation]') AND [c].[name] = N'Tour');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [SimpleInformation] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [SimpleInformation] ALTER COLUMN [Tour] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930074137_TourAddToSimpleInfoss')
BEGIN
    ALTER TABLE [SimpleInformation] ADD [DateTime] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930074137_TourAddToSimpleInfoss')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180930074137_TourAddToSimpleInfoss', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930110144_delete')
BEGIN
    DROP TABLE [BronGoyGols];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930110144_delete')
BEGIN
    DROP TABLE [BronOnlyTransfers];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930110144_delete')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180930110144_delete', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930133620_deletedd')
BEGIN
    ALTER TABLE [PersonalInfos] ADD [DateTime] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20180930133620_deletedd')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20180930133620_deletedd', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181003124706_HotelResult')
BEGIN
    ALTER TABLE [BronHotels] ADD [Value] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181003124706_HotelResult')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181003124706_HotelResult', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009102409_head')
BEGIN
    CREATE INDEX [IX_PersonalInfos_BronHotelId] ON [PersonalInfos] ([BronHotelId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009102409_head')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181009102409_head', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009140218_MessageTableUpdate')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Messages]') AND [c].[name] = N'Email');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Messages] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Messages] ALTER COLUMN [Email] nvarchar(21) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009140218_MessageTableUpdate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181009140218_MessageTableUpdate', N'2.1.2-rtm-30932');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    ALTER TABLE [Cruizs] DROP CONSTRAINT [FK_Cruizs_Users_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    ALTER TABLE [Vips] DROP CONSTRAINT [FK_Vips_Users_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    ALTER TABLE [GroupTour].[GroupTours] DROP CONSTRAINT [FK_GroupTours_Users_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    ALTER TABLE [OnlinePayment].[OnlinePayments] DROP CONSTRAINT [FK_OnlinePayments_Users_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    ALTER TABLE [Tour].[Tours] DROP CONSTRAINT [FK_Tours_Users_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    ALTER TABLE [Transfer].[Transfers] DROP CONSTRAINT [FK_Transfers_Users_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    ALTER TABLE [Transport].[Transports] DROP CONSTRAINT [FK_Transports_Users_UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DROP TABLE [User].[Users];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DROP INDEX [IX_Transports_UserId] ON [Transport].[Transports];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DROP INDEX [IX_Transfers_UserId] ON [Transfer].[Transfers];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DROP INDEX [IX_Tours_UserId] ON [Tour].[Tours];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DROP INDEX [IX_OnlinePayments_UserId] ON [OnlinePayment].[OnlinePayments];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DROP INDEX [IX_GroupTours_UserId] ON [GroupTour].[GroupTours];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DROP INDEX [IX_Vips_UserId] ON [Vips];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DROP INDEX [IX_Cruizs_UserId] ON [Cruizs];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Transport].[Transports]') AND [c].[name] = N'UserId');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Transport].[Transports] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Transport].[Transports] DROP COLUMN [UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Tour].[Tours]') AND [c].[name] = N'UserId');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Tour].[Tours] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Tour].[Tours] DROP COLUMN [UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[OnlinePayment].[OnlinePayments]') AND [c].[name] = N'UserId');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [OnlinePayment].[OnlinePayments] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [OnlinePayment].[OnlinePayments] DROP COLUMN [UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vips]') AND [c].[name] = N'UserId');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Vips] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Vips] DROP COLUMN [UserId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SimpleInformation]') AND [c].[name] = N'Surname');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [SimpleInformation] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [SimpleInformation] ALTER COLUMN [Surname] nvarchar(13) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SimpleInformation]') AND [c].[name] = N'Name');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [SimpleInformation] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [SimpleInformation] ALTER COLUMN [Name] nvarchar(11) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SimpleInformation]') AND [c].[name] = N'Email');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [SimpleInformation] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [SimpleInformation] ALTER COLUMN [Email] nvarchar(18) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var9 sysname;
    SELECT @var9 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PersonalInfos]') AND [c].[name] = N'Surname');
    IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [PersonalInfos] DROP CONSTRAINT [' + @var9 + '];');
    ALTER TABLE [PersonalInfos] ALTER COLUMN [Surname] nvarchar(15) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var10 sysname;
    SELECT @var10 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PersonalInfos]') AND [c].[name] = N'PassportNumber');
    IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [PersonalInfos] DROP CONSTRAINT [' + @var10 + '];');
    ALTER TABLE [PersonalInfos] ALTER COLUMN [PassportNumber] nvarchar(11) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var11 sysname;
    SELECT @var11 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PersonalInfos]') AND [c].[name] = N'Name');
    IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [PersonalInfos] DROP CONSTRAINT [' + @var11 + '];');
    ALTER TABLE [PersonalInfos] ALTER COLUMN [Name] nvarchar(10) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    DECLARE @var12 sysname;
    SELECT @var12 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[PersonalInfos]') AND [c].[name] = N'Email');
    IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [PersonalInfos] DROP CONSTRAINT [' + @var12 + '];');
    ALTER TABLE [PersonalInfos] ALTER COLUMN [Email] nvarchar(18) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181009142533_MessageTableUpdatee')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181009142533_MessageTableUpdatee', N'2.1.2-rtm-30932');
END;

GO

