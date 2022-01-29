using Microsoft.EntityFrameworkCore.Migrations;

namespace SosWebApp.Migrations
{
    public partial class DeleteUniqueRelationshipBetweenTriageCodeAndService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Services_TriageCodeId",
                table: "Services");

            migrationBuilder.CreateIndex(
                name: "IX_Services_TriageCodeId",
                table: "Services",
                column: "TriageCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Services_TriageCodeId",
                table: "Services");

            migrationBuilder.CreateIndex(
                name: "IX_Services_TriageCodeId",
                table: "Services",
                column: "TriageCodeId",
                unique: true,
                filter: "[TriageCodeId] IS NOT NULL");
        }
    }
}
