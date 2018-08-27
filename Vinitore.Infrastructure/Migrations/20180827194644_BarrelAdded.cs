using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Vinitore.Infrastructure.Migrations
{
    public partial class BarrelAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Barrel",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    WineId = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    CurrentCapacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barrel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barrel_wine_WineId",
                        column: x => x.WineId,
                        principalSchema: "public",
                        principalTable: "wine",
                        principalColumn: "wine_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Barrel_WineId",
                schema: "public",
                table: "Barrel",
                column: "WineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Barrel",
                schema: "public");
        }
    }
}
