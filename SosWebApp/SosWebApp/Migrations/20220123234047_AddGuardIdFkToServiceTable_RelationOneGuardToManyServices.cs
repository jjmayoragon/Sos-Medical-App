using Microsoft.EntityFrameworkCore.Migrations;

namespace SosWebApp.Migrations
{
    public partial class AddGuardIdFkToServiceTable_RelationOneGuardToManyServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuardId",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_GuardId",
                table: "Services",
                column: "GuardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Guards_GuardId",
                table: "Services",
                column: "GuardId",
                principalTable: "Guards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Guards_GuardId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_GuardId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "GuardId",
                table: "Services");
        }
    }
}
