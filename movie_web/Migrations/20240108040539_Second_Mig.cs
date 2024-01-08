using Microsoft.EntityFrameworkCore.Migrations;

namespace movie_web.Migrations
{
    public partial class Second_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_Actor_ActorID1",
                table: "Actor_Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_Movie_ActorID",
                table: "Actor_Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Cenima_CinamaID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CinamaID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Actor_Movie_ActorID1",
                table: "Actor_Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cenima",
                table: "Cenima");

            migrationBuilder.DropColumn(
                name: "CinamaID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ActorID1",
                table: "Actor_Movie");

            migrationBuilder.RenameTable(
                name: "Cenima",
                newName: "Cinema");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Movie",
                newName: "ImageURL");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CinemaID",
                table: "Movie",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_Movie_MovieID",
                table: "Actor_Movie",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_Actor_ActorID",
                table: "Actor_Movie",
                column: "ActorID",
                principalTable: "Actor",
                principalColumn: "ActorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_Movie_MovieID",
                table: "Actor_Movie",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Cinema_CinemaID",
                table: "Movie",
                column: "CinemaID",
                principalTable: "Cinema",
                principalColumn: "CinemaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_Actor_ActorID",
                table: "Actor_Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_Movie_MovieID",
                table: "Actor_Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Cinema_CinemaID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CinemaID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Actor_Movie_MovieID",
                table: "Actor_Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cinema",
                table: "Cinema");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Cinema",
                newName: "Cenima");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Movie",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<int>(
                name: "CinamaID",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActorID1",
                table: "Actor_Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cenima",
                table: "Cenima",
                column: "CinemaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CinamaID",
                table: "Movie",
                column: "CinamaID");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_Movie_ActorID1",
                table: "Actor_Movie",
                column: "ActorID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_Actor_ActorID1",
                table: "Actor_Movie",
                column: "ActorID1",
                principalTable: "Actor",
                principalColumn: "ActorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_Movie_ActorID",
                table: "Actor_Movie",
                column: "ActorID",
                principalTable: "Movie",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Cenima_CinamaID",
                table: "Movie",
                column: "CinamaID",
                principalTable: "Cenima",
                principalColumn: "CinemaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
