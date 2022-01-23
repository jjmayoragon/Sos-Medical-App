using Microsoft.EntityFrameworkCore.Migrations;

namespace SosWebApp.Migrations
{
    public partial class AddDoctorIdFKtoGuardTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Guards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guards_DoctorId",
                table: "Guards",
                column: "DoctorId",
                unique: true,
                filter: "[DoctorId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Guards_Doctors_DoctorId",
                table: "Guards",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guards_Doctors_DoctorId",
                table: "Guards");

            migrationBuilder.DropIndex(
                name: "IX_Guards_DoctorId",
                table: "Guards");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Guards");
        }
    }
}
