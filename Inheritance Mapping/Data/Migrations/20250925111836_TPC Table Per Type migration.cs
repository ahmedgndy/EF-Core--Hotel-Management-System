using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inheritance_Mapping.Data.Migrations
{
    /// <inheritdoc />
    public partial class TPCTablePerTypemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "LastStayDate",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "LoyaltyPoints",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "MembershipLevel",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "VipCardNumber",
                table: "Guests");

            migrationBuilder.CreateTable(
                name: "FrequentGuests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    LoyaltyPoints = table.Column<int>(type: "int", nullable: false),
                    MembershipLevel = table.Column<int>(type: "int", nullable: false),
                    LastStayDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrequentGuests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FrequentGuests_Guests_Id",
                        column: x => x.Id,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VIPGuests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    VipCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPGuests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VIPGuests_Guests_Id",
                        column: x => x.Id,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FrequentGuests");

            migrationBuilder.DropTable(
                name: "VIPGuests");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Guests",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastStayDate",
                table: "Guests",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LoyaltyPoints",
                table: "Guests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MembershipLevel",
                table: "Guests",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VipCardNumber",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
