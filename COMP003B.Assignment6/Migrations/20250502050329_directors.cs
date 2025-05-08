using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.Assignment6.Migrations
{
    /// <inheritdoc />
    public partial class Directors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Directors_DirectorID",
                table: "Directors");

            migrationBuilder.DropTable(
                name: "ActorsMovies");

            migrationBuilder.DropIndex(
                name: "IX_Directors_DirectorID",
                table: "Directors");

            migrationBuilder.AddColumn<int>(
                name: "ActorID",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DirectorID",
                table: "Directors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ActorID",
                table: "Movies",
                column: "ActorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieID",
                table: "Movies",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_DirectorID",
                table: "Directors",
                column: "DirectorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Directors_DirectorID",
                table: "Directors",
                column: "DirectorID",
                principalTable: "Directors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Actors_ActorsId",
                table: "Movies",
                column: "ActorsId",
                principalTable: "Actors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Movies_MoviesId",
                table: "Movies",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Directors_DirectorsId",
                table: "Directors");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Actors_ActorsId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Movies_MoviesId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ActorsId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MoviesId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Directors_DirectorsId",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "ActorsId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "DirectorsId",
                table: "Directors");

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
                name: "IX_Directors_DirectorID",
                table: "Directors",
                column: "DirectorID");

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_MoviesId",
                table: "ActorsMovies",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Directors_DirectorID",
                table: "Directors",
                column: "DirectorID",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
