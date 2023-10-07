using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Movie_Tunes.Migrations
{
    /// <inheritdoc />
    public partial class M00 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sinopse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Classificação = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrilhasSonoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnoLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrilhasSonorasId = table.Column<int>(type: "int", nullable: false),
                    TrilhaSonorasId = table.Column<int>(type: "int", nullable: true),
                    FilmesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrilhasSonoras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrilhasSonoras_Filmes_FilmesId",
                        column: x => x.FilmesId,
                        principalTable: "Filmes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TrilhasSonoras_TrilhasSonoras_TrilhaSonorasId",
                        column: x => x.TrilhaSonorasId,
                        principalTable: "TrilhasSonoras",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrilhasSonoras_FilmesId",
                table: "TrilhasSonoras",
                column: "FilmesId");

            migrationBuilder.CreateIndex(
                name: "IX_TrilhasSonoras_TrilhaSonorasId",
                table: "TrilhasSonoras",
                column: "TrilhaSonorasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrilhasSonoras");

            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
