using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApplication.Migrations
{
    public partial class One : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Event");

            migrationBuilder.EnsureSchema(
                name: "GroupTour");

            migrationBuilder.EnsureSchema(
                name: "HotelList");

            migrationBuilder.EnsureSchema(
                name: "Insuarance");

            migrationBuilder.EnsureSchema(
                name: "OnlinePayment");

            migrationBuilder.EnsureSchema(
                name: "Tour");

            migrationBuilder.EnsureSchema(
                name: "Transfer");

            migrationBuilder.EnsureSchema(
                name: "Transport");

            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    SubText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AzeTitleSubTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstSlide = table.Column<string>(nullable: true),
                    FirstSlideText = table.Column<string>(nullable: true),
                    SecondSlide = table.Column<string>(nullable: true),
                    SecondSlideText = table.Column<string>(nullable: true),
                    ThirdSlide = table.Column<string>(nullable: true),
                    ThirdSlideText = table.Column<string>(nullable: true),
                    FourthSlide = table.Column<string>(nullable: true),
                    FourthSlideText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AzeTitleSubTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BilgehDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutHotel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilgehDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BilgehPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    TourAdditionalSecond = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BilgehPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BronBilgehs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BronBilgehs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BronGoyGols",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BronGoyGols", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BronNaftalans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BronNaftalans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BronOnlyTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutTour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BronOnlyTransfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BronTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TourIncludedText = table.Column<string>(nullable: true),
                    TourIncludedIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BronTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FireMountainDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TourInclude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireMountainDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FireMountainPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TourAdditionalSecond = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FireMountainPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoyGolDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TourInclude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoyGolDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoyGolPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoyGolPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelListDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HotelLink = table.Column<string>(nullable: true),
                    ListHotel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelListDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuaranceDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutInsuarance = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuaranceDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LankaranDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutTour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LankaranDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LankaranPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SecondAdditional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LankaranPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainPageTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstSlide = table.Column<string>(nullable: true),
                    FirstSlideText = table.Column<string>(nullable: true),
                    SecondSlide = table.Column<string>(nullable: true),
                    SecondSlideText = table.Column<string>(nullable: true),
                    ThirdSlide = table.Column<string>(nullable: true),
                    ThirdSlideText = table.Column<string>(nullable: true),
                    FourthSlide = table.Column<string>(nullable: true),
                    FourthSlideText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPageTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    Messaging = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NaftalanDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hotels = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaftalanDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NaftalanPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TourAdditionalSecond = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaftalanPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    PassportNumber = table.Column<string>(nullable: false),
                    Birth = table.Column<string>(nullable: false),
                    Parent = table.Column<int>(nullable: false),
                    Child = table.Column<int>(nullable: true),
                    Baby = table.Column<int>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QabalaDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutTour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QabalaDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QabalaPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SecondAdditional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QabalaPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QakhDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutTour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QakhDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QakhPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SecondAdditional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QakhPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QubaPageDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutQuba = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QubaPageDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QubaPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SecondAdditional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QubaPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    _IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    OtherAddress = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Instagram = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShakiPageDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TourInclude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShakiPageDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShakiPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TourAdditionalSecond = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShakiPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TitleAndSubTitles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StaticPage = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    _IsService = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleAndSubTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportDescriptions",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutTransport = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportDescriptions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "VulkanDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutTour = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VulkanDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VulkanPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    SecondAdditional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VulkanPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Surname = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    PassportNumber = table.Column<string>(nullable: true),
                    Password = table.Column<string>(maxLength: 18, nullable: false),
                    Number = table.Column<string>(nullable: true),
                    _Isbronned = table.Column<bool>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    SubText = table.Column<string>(nullable: true),
                    AboutId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WhyWe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    AboutId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhyWe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhyWe_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compliances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    SubText = table.Column<string>(nullable: true),
                    AboutId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compliances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compliances_Abouts_AboutId",
                        column: x => x.AboutId,
                        principalTable: "Abouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compliances_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    lat = table.Column<double>(nullable: true),
                    lng = table.Column<double>(nullable: true),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Advices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emergencies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Subtitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emergencies_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emergencies_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                schema: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    EventImage = table.Column<string>(nullable: true),
                    EventIcon = table.Column<string>(nullable: true),
                    EventName = table.Column<string>(nullable: true),
                    EventTitle = table.Column<string>(nullable: true),
                    EventTime = table.Column<string>(nullable: true),
                    EventAction = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelLists",
                schema: "HotelList",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    OtherPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelLists_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Insuarances",
                schema: "Insuarance",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    SubText = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    OtherPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insuarances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insuarances_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cruizs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cruizs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cruizs_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cruizs_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cruizs_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vips",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    SubText = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    OtherPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vips", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vips_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vips_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vips_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupTours",
                schema: "GroupTour",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupTours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupTours_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupTours_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupTours_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OnlinePayments",
                schema: "OnlinePayment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CardType = table.Column<string>(nullable: true),
                    CardNumber = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlinePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlinePayments_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                schema: "Tour",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Price = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(maxLength: 60, nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                schema: "Transfer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    lat = table.Column<double>(nullable: true),
                    lng = table.Column<double>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfers_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transfers_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transfers_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BakuJaras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    TourSecondAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    EventId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BakuJaras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BakuJaras_Events_EventId",
                        column: x => x.EventId,
                        principalSchema: "Event",
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BakuJaras_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Festivals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TourSecondAdditional = table.Column<string>(nullable: true),
                    EventId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Festivals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Festivals_Events_EventId",
                        column: x => x.EventId,
                        principalSchema: "Event",
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Festivals_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormulaPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourInformation = table.Column<string>(nullable: true),
                    TourVideo = table.Column<string>(nullable: true),
                    TourCheckIn = table.Column<string>(nullable: true),
                    TourText = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAdditional = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    SecondNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TourSecondAdditional = table.Column<string>(nullable: true),
                    EventId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulaPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormulaPages_Events_EventId",
                        column: x => x.EventId,
                        principalSchema: "Event",
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormulaPages_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Azerbaijans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TourImage = table.Column<string>(nullable: true),
                    TourIcon = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourTitle = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAction = table.Column<string>(nullable: true),
                    TourDuration = table.Column<string>(nullable: true),
                    TourIdId = table.Column<int>(nullable: true),
                    TourId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Azerbaijans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Azerbaijans_Tours_TourId1",
                        column: x => x.TourId1,
                        principalSchema: "Tour",
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Azerbaijans_Tours_TourIdId",
                        column: x => x.TourIdId,
                        principalSchema: "Tour",
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Healths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TourImage = table.Column<string>(nullable: true),
                    TourIcon = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourTitle = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAction = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Healths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Healths_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Healths_Tours_TourId",
                        column: x => x.TourId,
                        principalSchema: "Tour",
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Incoming",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TourImage = table.Column<string>(nullable: true),
                    TourIcon = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourTitle = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAction = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    TourId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incoming", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incoming_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incoming_Tours_TourId",
                        column: x => x.TourId,
                        principalSchema: "Tour",
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MainPages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TourImage = table.Column<string>(nullable: true),
                    TourName = table.Column<string>(nullable: true),
                    TourPrice = table.Column<string>(nullable: true),
                    TourTime = table.Column<string>(nullable: true),
                    TourAction = table.Column<string>(nullable: true),
                    TourDuration = table.Column<string>(nullable: true),
                    TourIdId = table.Column<int>(nullable: true),
                    TourId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainPages_Tours_TourId1",
                        column: x => x.TourId1,
                        principalSchema: "Tour",
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MainPages_Tours_TourIdId",
                        column: x => x.TourIdId,
                        principalSchema: "Tour",
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Transports",
                schema: "Transport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    SubTitle = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    OtherPhone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ServiceId = table.Column<int>(nullable: false),
                    TourId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    MessageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transports_Messages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "Messages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Transports_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transports_Tours_TourId",
                        column: x => x.TourId,
                        principalSchema: "Tour",
                        principalTable: "Tours",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Transports_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "User",
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advices_ServiceId",
                table: "Advices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Azerbaijans_TourId1",
                table: "Azerbaijans",
                column: "TourId1");

            migrationBuilder.CreateIndex(
                name: "IX_Azerbaijans_TourIdId",
                table: "Azerbaijans",
                column: "TourIdId");

            migrationBuilder.CreateIndex(
                name: "IX_BakuJaras_EventId",
                table: "BakuJaras",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BakuJaras_MessageId",
                table: "BakuJaras",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Compliances_AboutId",
                table: "Compliances",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Compliances_MessageId",
                table: "Compliances",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_MessageId",
                table: "Contacts",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Cruizs_MessageId",
                table: "Cruizs",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Cruizs_ServiceId",
                table: "Cruizs",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Cruizs_UserId",
                table: "Cruizs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_MessageId",
                table: "Emergencies",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_ServiceId",
                table: "Emergencies",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Festivals_EventId",
                table: "Festivals",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Festivals_MessageId",
                table: "Festivals",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_FormulaPages_EventId",
                table: "FormulaPages",
                column: "EventId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormulaPages_MessageId",
                table: "FormulaPages",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Healths_ServiceId",
                table: "Healths",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Healths_TourId",
                table: "Healths",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Incoming_ServiceId",
                table: "Incoming",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Incoming_TourId",
                table: "Incoming",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_MainPages_TourId1",
                table: "MainPages",
                column: "TourId1");

            migrationBuilder.CreateIndex(
                name: "IX_MainPages_TourIdId",
                table: "MainPages",
                column: "TourIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_AboutId",
                table: "Profiles",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Vips_MessageId",
                table: "Vips",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Vips_ServiceId",
                table: "Vips",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Vips_UserId",
                table: "Vips",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WhyWe_AboutId",
                table: "WhyWe",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ServiceId",
                schema: "Event",
                table: "Events",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTours_MessageId",
                schema: "GroupTour",
                table: "GroupTours",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTours_ServiceId",
                schema: "GroupTour",
                table: "GroupTours",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTours_UserId",
                schema: "GroupTour",
                table: "GroupTours",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelLists_ServiceId",
                schema: "HotelList",
                table: "HotelLists",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Insuarances_ServiceId",
                schema: "Insuarance",
                table: "Insuarances",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlinePayments_UserId",
                schema: "OnlinePayment",
                table: "OnlinePayments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_UserId",
                schema: "Tour",
                table: "Tours",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_MessageId",
                schema: "Transfer",
                table: "Transfers",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_ServiceId",
                schema: "Transfer",
                table: "Transfers",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_UserId",
                schema: "Transfer",
                table: "Transfers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_MessageId",
                schema: "Transport",
                table: "Transports",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_ServiceId",
                schema: "Transport",
                table: "Transports",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_TourId",
                schema: "Transport",
                table: "Transports",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Transports_UserId",
                schema: "Transport",
                table: "Transports",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advices");

            migrationBuilder.DropTable(
                name: "Azerbaijans");

            migrationBuilder.DropTable(
                name: "AzeTitleSubTitles");

            migrationBuilder.DropTable(
                name: "BakuJaras");

            migrationBuilder.DropTable(
                name: "BilgehDescriptions");

            migrationBuilder.DropTable(
                name: "BilgehPages");

            migrationBuilder.DropTable(
                name: "BronBilgehs");

            migrationBuilder.DropTable(
                name: "BronGoyGols");

            migrationBuilder.DropTable(
                name: "BronNaftalans");

            migrationBuilder.DropTable(
                name: "BronOnlyTransfers");

            migrationBuilder.DropTable(
                name: "BronTitles");

            migrationBuilder.DropTable(
                name: "Compliances");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Cruizs");

            migrationBuilder.DropTable(
                name: "Emergencies");

            migrationBuilder.DropTable(
                name: "Festivals");

            migrationBuilder.DropTable(
                name: "FireMountainDescriptions");

            migrationBuilder.DropTable(
                name: "FireMountainPages");

            migrationBuilder.DropTable(
                name: "FormulaPages");

            migrationBuilder.DropTable(
                name: "GoyGolDescriptions");

            migrationBuilder.DropTable(
                name: "GoyGolPages");

            migrationBuilder.DropTable(
                name: "Healths");

            migrationBuilder.DropTable(
                name: "HotelListDescriptions");

            migrationBuilder.DropTable(
                name: "Incoming");

            migrationBuilder.DropTable(
                name: "InsuaranceDescriptions");

            migrationBuilder.DropTable(
                name: "LankaranDescriptions");

            migrationBuilder.DropTable(
                name: "LankaranPages");

            migrationBuilder.DropTable(
                name: "MainPages");

            migrationBuilder.DropTable(
                name: "MainPageTitles");

            migrationBuilder.DropTable(
                name: "NaftalanDescriptions");

            migrationBuilder.DropTable(
                name: "NaftalanPages");

            migrationBuilder.DropTable(
                name: "PersonalInfos");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "QabalaDescriptions");

            migrationBuilder.DropTable(
                name: "QabalaPages");

            migrationBuilder.DropTable(
                name: "QakhDescriptions");

            migrationBuilder.DropTable(
                name: "QakhPages");

            migrationBuilder.DropTable(
                name: "QubaPageDescriptions");

            migrationBuilder.DropTable(
                name: "QubaPages");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "ShakiPageDescriptions");

            migrationBuilder.DropTable(
                name: "ShakiPages");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "TitleAndSubTitles");

            migrationBuilder.DropTable(
                name: "TransportDescriptions");

            migrationBuilder.DropTable(
                name: "Vips");

            migrationBuilder.DropTable(
                name: "VulkanDescriptions");

            migrationBuilder.DropTable(
                name: "VulkanPages");

            migrationBuilder.DropTable(
                name: "WhyWe");

            migrationBuilder.DropTable(
                name: "GroupTours",
                schema: "GroupTour");

            migrationBuilder.DropTable(
                name: "HotelLists",
                schema: "HotelList");

            migrationBuilder.DropTable(
                name: "Insuarances",
                schema: "Insuarance");

            migrationBuilder.DropTable(
                name: "OnlinePayments",
                schema: "OnlinePayment");

            migrationBuilder.DropTable(
                name: "Transfers",
                schema: "Transfer");

            migrationBuilder.DropTable(
                name: "Transports",
                schema: "Transport");

            migrationBuilder.DropTable(
                name: "Events",
                schema: "Event");

            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Tours",
                schema: "Tour");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "User");
        }
    }
}
