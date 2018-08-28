using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Vinitore.Infrastructure.Migrations.Vinitore
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "wine",
                schema: "public",
                columns: table => new
                {
                    wine_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wine", x => x.wine_id);
                });

            migrationBuilder.CreateTable(
                name: "barrel",
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
                    table.PrimaryKey("PK_barrel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_barrel_wine_WineId",
                        column: x => x.WineId,
                        principalSchema: "public",
                        principalTable: "wine",
                        principalColumn: "wine_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_barrel_WineId",
                schema: "public",
                table: "barrel",
                column: "WineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "barrel",
                schema: "public");

            migrationBuilder.DropTable(
                name: "wine",
                schema: "public");
        }
    }
}
