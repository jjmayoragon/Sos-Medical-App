using Microsoft.EntityFrameworkCore.Migrations;

namespace SosWebApp.Migrations
{
    public partial class AddTriageCodeIdFkToServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TriageCodeId",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_TriageCodeId",
                table: "Services",
                column: "TriageCodeId",
                unique: true,
                filter: "[TriageCodeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_TriageCodes_TriageCodeId",
                table: "Services",
                column: "TriageCodeId",
                principalTable: "TriageCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_TriageCodes_TriageCodeId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_TriageCodeId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "TriageCodeId",
                table: "Services");
        }
    }
}
