using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.Assignment6.Migrations
{
    /// <inheritdoc />
    public partial class Oscars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_MoviesId",
                table: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Actors_MoviesId",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "Actors");

            migrationBuilder.AddColumn<int>(
                name: "Oscars",
                table: "Actors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ActorsMovies",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMovies", x => new { x.ActorsId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_MoviesId",
                table: "ActorsMovies",
                column: "MoviesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorsMovies");

            migrationBuilder.DropColumn(
                name: "Oscars",
                table: "Actors");

            migrationBuilder.AddColumn<int>(
                name: "MoviesId",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_MoviesId",
                table: "Actors",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_MoviesId",
                table: "Actors",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id");
        }
    }
}
