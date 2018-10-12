using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApplication.Migrations
{
    public partial class UpToDataa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BronHotelId",
                table: "PersonalInfos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInfos_BronHotelId",
                table: "PersonalInfos",
                column: "BronHotelId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInfos_BronHotels_BronHotelId",
                table: "PersonalInfos",
                column: "BronHotelId",
                principalTable: "BronHotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInfos_BronHotels_BronHotelId",
                table: "PersonalInfos");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInfos_BronHotelId",
                table: "PersonalInfos");

            migrationBuilder.DropColumn(
                name: "BronHotelId",
                table: "PersonalInfos");
        }
    }
}
