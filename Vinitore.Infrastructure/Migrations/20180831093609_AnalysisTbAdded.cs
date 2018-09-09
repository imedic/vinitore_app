using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Vinitore.Infrastructure.Migrations
{
    public partial class AnalysisTbAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "analysis",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    WineId = table.Column<int>(nullable: false),
                    BarrelId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Alcohol = table.Column<double>(nullable: false),
                    Acid = table.Column<double>(nullable: false),
                    VolatileAcid = table.Column<double>(nullable: false),
                    TotalDryExtract = table.Column<double>(nullable: false),
                    TotalSulphurDioxide = table.Column<double>(nullable: false),
                    FreeSulphurDioxide = table.Column<double>(nullable: false),
                    PH = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analysis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_analysis_barrel_BarrelId",
                        column: x => x.BarrelId,
                        principalSchema: "public",
                        principalTable: "barrel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_analysis_wine_WineId",
                        column: x => x.WineId,
                        principalSchema: "public",
                        principalTable: "wine",
                        principalColumn: "wine_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_analysis_BarrelId",
                schema: "public",
                table: "analysis",
                column: "BarrelId");

            migrationBuilder.CreateIndex(
                name: "IX_analysis_WineId",
                schema: "public",
                table: "analysis",
                column: "WineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "analysis",
                schema: "public");
        }
    }
}
