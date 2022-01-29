using Microsoft.EntityFrameworkCore.Migrations;

namespace SosWebApp.Migrations
{
    public partial class ModifyForeignKeyREQUIREDFIdGuardFromService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Guards_GuardId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "GuardId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Guards_GuardId",
                table: "Services",
                column: "GuardId",
                principalTable: "Guards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Guards_GuardId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "GuardId",
                table: "Services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Guards_GuardId",
                table: "Services",
                column: "GuardId",
                principalTable: "Guards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
