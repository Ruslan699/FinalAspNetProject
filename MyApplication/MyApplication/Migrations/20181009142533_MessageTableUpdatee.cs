using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyApplication.Migrations
{
    public partial class MessageTableUpdatee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cruizs_Users_UserId",
                table: "Cruizs");

            migrationBuilder.DropForeignKey(
                name: "FK_Vips_Users_UserId",
                table: "Vips");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupTours_Users_UserId",
                schema: "GroupTour",
                table: "GroupTours");

            migrationBuilder.DropForeignKey(
                name: "FK_OnlinePayments_Users_UserId",
                schema: "OnlinePayment",
                table: "OnlinePayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Tours_Users_UserId",
                schema: "Tour",
                table: "Tours");

            migrationBuilder.DropForeignKey(
                name: "FK_Transfers_Users_UserId",
                schema: "Transfer",
                table: "Transfers");

            migrationBuilder.DropForeignKey(
                name: "FK_Transports_Users_UserId",
                schema: "Transport",
                table: "Transports");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "User");

            migrationBuilder.DropIndex(
                name: "IX_Transports_UserId",
                schema: "Transport",
                table: "Transports");

            migrationBuilder.DropIndex(
                name: "IX_Transfers_UserId",
                schema: "Transfer",
                table: "Transfers");

            migrationBuilder.DropIndex(
                name: "IX_Tours_UserId",
                schema: "Tour",
                table: "Tours");

            migrationBuilder.DropIndex(
                name: "IX_OnlinePayments_UserId",
                schema: "OnlinePayment",
                table: "OnlinePayments");

            migrationBuilder.DropIndex(
                name: "IX_GroupTours_UserId",
                schema: "GroupTour",
                table: "GroupTours");

            migrationBuilder.DropIndex(
                name: "IX_Vips_UserId",
                table: "Vips");

            migrationBuilder.DropIndex(
                name: "IX_Cruizs_UserId",
                table: "Cruizs");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Transport",
                table: "Transports");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "Tour",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "OnlinePayment",
                table: "OnlinePayments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Vips");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "SimpleInformation",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SimpleInformation",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "SimpleInformation",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "PersonalInfos",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "PersonalInfos",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PersonalInfos",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "PersonalInfos",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                schema: "Transport",
                table: "Transports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                schema: "Tour",
                table: "Tours",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                schema: "OnlinePayment",
                table: "OnlinePayments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Vips",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "SimpleInformation",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 13);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SimpleInformation",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "SimpleInformation",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "PersonalInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "PersonalInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PersonalInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "PersonalInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 18);

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(maxLength: 40, nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Number = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(nullable: true),
                    Password = table.Column<string>(maxLength: 18, nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    Surname = table.Column<string>(maxLength: 20, nullable: false),
                    ZipCode = table.Column<string>(nullable: true),
                    _Isbronned = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transports_UserId",
                schema: "Transport",
                table: "Transports",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_UserId",
                schema: "Transfer",
                table: "Transfers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_UserId",
                schema: "Tour",
                table: "Tours",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlinePayments_UserId",
                schema: "OnlinePayment",
                table: "OnlinePayments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupTours_UserId",
                schema: "GroupTour",
                table: "GroupTours",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vips_UserId",
                table: "Vips",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cruizs_UserId",
                table: "Cruizs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cruizs_Users_UserId",
                table: "Cruizs",
                column: "UserId",
                principalSchema: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vips_Users_UserId",
                table: "Vips",
                column: "UserId",
                principalSchema: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupTours_Users_UserId",
                schema: "GroupTour",
                table: "GroupTours",
                column: "UserId",
                principalSchema: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OnlinePayments_Users_UserId",
                schema: "OnlinePayment",
                table: "OnlinePayments",
                column: "UserId",
                principalSchema: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tours_Users_UserId",
                schema: "Tour",
                table: "Tours",
                column: "UserId",
                principalSchema: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transfers_Users_UserId",
                schema: "Transfer",
                table: "Transfers",
                column: "UserId",
                principalSchema: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transports_Users_UserId",
                schema: "Transport",
                table: "Transports",
                column: "UserId",
                principalSchema: "User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
