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
                    ActorID = table.Column<int>(type: "int", nullable: false),
                    MovieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMovies", x => new { x.ActorID, x.MovieID });
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Actors_ActorsId",
                        column: x => x.ActorID,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Movies_MoviesId",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_MovieID",
                table: "ActorsMovies",
                column: "MovieID");
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
                name: "MovieID",
                table: "Actors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_MovieID",
                table: "Actors",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_MoviesId",
                table: "Actors",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "MovieID");
        }
    }
}
