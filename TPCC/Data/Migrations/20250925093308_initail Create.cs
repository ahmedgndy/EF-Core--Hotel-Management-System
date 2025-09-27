using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPC.Data.Migrations
{
    /// <inheritdoc />
    public partial class initailCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FrequentGuests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoyaltyPoints = table.Column<int>(type: "int", nullable: false),
                    MembershipLevel = table.Column<int>(type: "int", nullable: false),
                    LastStayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrequentGuests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VIPGuests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VipCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VIPGuests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrequentGuestId = table.Column<int>(type: "int", nullable: true),
                    VIPGuestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_FrequentGuests_FrequentGuestId",
                        column: x => x.FrequentGuestId,
                        principalTable: "FrequentGuests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reservation_VIPGuests_VIPGuestId",
                        column: x => x.VIPGuestId,
                        principalTable: "VIPGuests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_FrequentGuestId",
                table: "Reservation",
                column: "FrequentGuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_VIPGuestId",
                table: "Reservation",
                column: "VIPGuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "FrequentGuests");

            migrationBuilder.DropTable(
                name: "VIPGuests");
        }
    }
}
