using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApplication.Migrations
{
    public partial class head : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_BronHotelId",
                table: "PersonalInfos",
                column: "BronHotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PersonalInfos_BronHotelId",
                table: "PersonalInfos");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_BronHotelId",
                table: "PersonalInfos",
                column: "BronHotelId",
                unique: true);
        }
    }
}
