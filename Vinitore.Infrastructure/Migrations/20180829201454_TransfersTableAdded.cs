using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Vinitore.Infrastructure.Migrations
{
    public partial class TransfersTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transfers",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    WineId = table.Column<int>(nullable: false),
                    BarrelFromId = table.Column<int>(nullable: false),
                    BarrelToId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_transfers_barrel_BarrelFromId",
                        column: x => x.BarrelFromId,
                        principalSchema: "public",
                        principalTable: "barrel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transfers_barrel_BarrelToId",
                        column: x => x.BarrelToId,
                        principalSchema: "public",
                        principalTable: "barrel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transfers_wine_WineId",
                        column: x => x.WineId,
                        principalSchema: "public",
                        principalTable: "wine",
                        principalColumn: "wine_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_transfers_BarrelFromId",
                schema: "public",
                table: "transfers",
                column: "BarrelFromId");

            migrationBuilder.CreateIndex(
                name: "IX_transfers_BarrelToId",
                schema: "public",
                table: "transfers",
                column: "BarrelToId");

            migrationBuilder.CreateIndex(
                name: "IX_transfers_WineId",
                schema: "public",
                table: "transfers",
                column: "WineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transfers",
                schema: "public");
        }
    }
}
