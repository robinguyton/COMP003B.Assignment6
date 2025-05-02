using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.Assignment6.Migrations
{
    /// <inheritdoc />
    public partial class newmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Directors_DirectorId",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Directors_DirectorID1",
                table: "Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_DirectorID1",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "DirectorID1",
                table: "Directors");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorID",
                table: "Directors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Directors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_DirectorID",
                table: "Directors",
                column: "DirectorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Directors_DirectorId",
                table: "Actors",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Directors_DirectorID",
                table: "Directors",
                column: "DirectorID",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Directors_DirectorId",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Directors_DirectorID",
                table: "Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.DropIndex(
                name: "IX_Directors_DirectorID",
                table: "Directors");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Directors");

            migrationBuilder.AlterColumn<int>(
                name: "DirectorID",
                table: "Directors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "DirectorID1",
                table: "Directors",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "DirectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Directors_DirectorID1",
                table: "Directors",
                column: "DirectorID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Directors_DirectorId",
                table: "Actors",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "DirectorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Directors_DirectorID1",
                table: "Directors",
                column: "DirectorID1",
                principalTable: "Directors",
                principalColumn: "DirectorID");
        }
    }
}
