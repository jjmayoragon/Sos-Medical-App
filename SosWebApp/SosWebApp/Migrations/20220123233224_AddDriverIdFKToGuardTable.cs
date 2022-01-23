using Microsoft.EntityFrameworkCore.Migrations;

namespace SosWebApp.Migrations
{
    public partial class AddDriverIdFKToGuardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DriverId",
                table: "Guards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guards_DriverId",
                table: "Guards",
                column: "DriverId",
                unique: true,
                filter: "[DriverId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Guards_Drivers_DriverId",
                table: "Guards",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guards_Drivers_DriverId",
                table: "Guards");

            migrationBuilder.DropIndex(
                name: "IX_Guards_DriverId",
                table: "Guards");

            migrationBuilder.DropColumn(
                name: "DriverId",
                table: "Guards");
        }
    }
}
