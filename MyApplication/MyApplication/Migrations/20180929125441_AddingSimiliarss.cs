using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApplication.Migrations
{
    public partial class AddingSimiliarss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BronInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BronEnum = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    ImageText = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true),
                    AboutTourNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BronInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimiliarTours",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutTourIcon = table.Column<string>(nullable: true),
                    AboutTourText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimiliarTours", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BronInfos");

            migrationBuilder.DropTable(
                name: "SimiliarTours");
        }
    }
}
