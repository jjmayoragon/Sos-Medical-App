using Microsoft.EntityFrameworkCore.Migrations;

namespace SosWebApp.Migrations
{
    public partial class AddAmbulanceIdFKToGuardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmbulanceId",
                table: "Guards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guards_AmbulanceId",
                table: "Guards",
                column: "AmbulanceId",
                unique: true,
                filter: "[AmbulanceId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Guards_Ambulances_AmbulanceId",
                table: "Guards",
                column: "AmbulanceId",
                principalTable: "Ambulances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guards_Ambulances_AmbulanceId",
                table: "Guards");

            migrationBuilder.DropIndex(
                name: "IX_Guards_AmbulanceId",
                table: "Guards");

            migrationBuilder.DropColumn(
                name: "AmbulanceId",
                table: "Guards");
        }
    }
}
