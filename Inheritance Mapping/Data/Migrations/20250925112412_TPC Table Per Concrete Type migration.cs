using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inheritance_Mapping.Data.Migrations
{
    /// <inheritdoc />
    public partial class TPCTablePerConcreteTypemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FrequentGuests_Guests_Id",
                table: "FrequentGuests");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Guests_GuestId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_VIPGuests_Guests_Id",
                table: "VIPGuests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guests",
                table: "Guests");

            migrationBuilder.RenameTable(
                name: "Guests",
                newName: "Guest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guest",
                table: "Guest",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FrequentGuests_Guest_Id",
                table: "FrequentGuests",
                column: "Id",
                principalTable: "Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Guest_GuestId",
                table: "Reservations",
                column: "GuestId",
                principalTable: "Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIPGuests_Guest_Id",
                table: "VIPGuests",
                column: "Id",
                principalTable: "Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FrequentGuests_Guest_Id",
                table: "FrequentGuests");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Guest_GuestId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_VIPGuests_Guest_Id",
                table: "VIPGuests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Guest",
                table: "Guest");

            migrationBuilder.RenameTable(
                name: "Guest",
                newName: "Guests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Guests",
                table: "Guests",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FrequentGuests_Guests_Id",
                table: "FrequentGuests",
                column: "Id",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Guests_GuestId",
                table: "Reservations",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VIPGuests_Guests_Id",
                table: "VIPGuests",
                column: "Id",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
