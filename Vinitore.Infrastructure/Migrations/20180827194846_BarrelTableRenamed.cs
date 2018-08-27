using Microsoft.EntityFrameworkCore.Migrations;

namespace Vinitore.Infrastructure.Migrations
{
    public partial class BarrelTableRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Barrel_wine_WineId",
                schema: "public",
                table: "Barrel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Barrel",
                schema: "public",
                table: "Barrel");

            migrationBuilder.RenameTable(
                name: "Barrel",
                schema: "public",
                newName: "barrel",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_Barrel_WineId",
                schema: "public",
                table: "barrel",
                newName: "IX_barrel_WineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_barrel",
                schema: "public",
                table: "barrel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_barrel_wine_WineId",
                schema: "public",
                table: "barrel",
                column: "WineId",
                principalSchema: "public",
                principalTable: "wine",
                principalColumn: "wine_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_barrel_wine_WineId",
                schema: "public",
                table: "barrel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_barrel",
                schema: "public",
                table: "barrel");

            migrationBuilder.RenameTable(
                name: "barrel",
                schema: "public",
                newName: "Barrel",
                newSchema: "public");

            migrationBuilder.RenameIndex(
                name: "IX_barrel_WineId",
                schema: "public",
                table: "Barrel",
                newName: "IX_Barrel_WineId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Barrel",
                schema: "public",
                table: "Barrel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Barrel_wine_WineId",
                schema: "public",
                table: "Barrel",
                column: "WineId",
                principalSchema: "public",
                principalTable: "wine",
                principalColumn: "wine_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
