using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inheritance_Mapping.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixErrors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.CreateSequence(
                name: "GuestSequence");

            migrationBuilder.AlterColumn<string>(
                name: "VipCardNumber",
                table: "VIPGuests",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "VIPGuests",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [GuestSequence]",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "VIPGuests",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "VIPGuests",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "VIPGuests",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "FrequentGuests",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [GuestSequence]",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "FrequentGuests",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "FrequentGuests",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "FrequentGuests",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_VIPGuests_VipCardNumber",
                table: "VIPGuests",
                column: "VipCardNumber",
                unique: true,
                filter: "[VipCardNumber] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VIPGuests_VipCardNumber",
                table: "VIPGuests");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "VIPGuests");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "VIPGuests");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "VIPGuests");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "FrequentGuests");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "FrequentGuests");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "FrequentGuests");

            migrationBuilder.DropSequence(
                name: "GuestSequence");

            migrationBuilder.AlterColumn<string>(
                name: "VipCardNumber",
                table: "VIPGuests",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "VIPGuests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [GuestSequence]");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "FrequentGuests",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [GuestSequence]");

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.Id);
                });

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
    }
}
