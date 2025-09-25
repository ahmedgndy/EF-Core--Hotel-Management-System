using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPT.Data.Migrations
{
    /// <inheritdoc />
    public partial class initailCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guests", x => x.Id);
                });

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
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservation_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id");
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

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_GuestId",
                table: "Reservation",
                column: "GuestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FrequentGuests");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "VIPGuests");

            migrationBuilder.DropTable(
                name: "Guests");
        }
    }
}
