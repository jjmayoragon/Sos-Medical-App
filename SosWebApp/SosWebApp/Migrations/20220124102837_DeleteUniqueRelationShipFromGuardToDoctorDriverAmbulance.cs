using Microsoft.EntityFrameworkCore.Migrations;

namespace SosWebApp.Migrations
{
    public partial class DeleteUniqueRelationShipFromGuardToDoctorDriverAmbulance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guards_AmbulanceId",
                table: "Guards");

            migrationBuilder.DropIndex(
                name: "IX_Guards_DoctorId",
                table: "Guards");

            migrationBuilder.DropIndex(
                name: "IX_Guards_DriverId",
                table: "Guards");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_AmbulanceId",
                table: "Guards",
                column: "AmbulanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_DoctorId",
                table: "Guards",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_DriverId",
                table: "Guards",
                column: "DriverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Guards_AmbulanceId",
                table: "Guards");

            migrationBuilder.DropIndex(
                name: "IX_Guards_DoctorId",
                table: "Guards");

            migrationBuilder.DropIndex(
                name: "IX_Guards_DriverId",
                table: "Guards");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_AmbulanceId",
                table: "Guards",
                column: "AmbulanceId",
                unique: true,
                filter: "[AmbulanceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_DoctorId",
                table: "Guards",
                column: "DoctorId",
                unique: true,
                filter: "[DoctorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Guards_DriverId",
                table: "Guards",
                column: "DriverId",
                unique: true,
                filter: "[DriverId] IS NOT NULL");
        }
    }
}
