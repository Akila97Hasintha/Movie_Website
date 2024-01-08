using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace movie_web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ActorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictueUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ActorID);
                });

            migrationBuilder.CreateTable(
                name: "Cenima",
                columns: table => new
                {
                    CinemaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cenima", x => x.CinemaID);
                });

            migrationBuilder.CreateTable(
                name: "Produser",
                columns: table => new
                {
                    ProduserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produser", x => x.ProduserID);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieCatagory = table.Column<int>(type: "int", nullable: false),
                    CinemaID = table.Column<int>(type: "int", nullable: false),
                    CinamaID = table.Column<int>(type: "int", nullable: true),
                    ProduserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movie_Cenima_CinamaID",
                        column: x => x.CinamaID,
                        principalTable: "Cenima",
                        principalColumn: "CinemaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movie_Produser_ProduserID",
                        column: x => x.ProduserID,
                        principalTable: "Produser",
                        principalColumn: "ProduserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actor_Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    ActorID = table.Column<int>(type: "int", nullable: false),
                    ActorID1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor_Movie", x => new { x.ActorID, x.MovieID });
                    table.ForeignKey(
                        name: "FK_Actor_Movie_Actor_ActorID1",
                        column: x => x.ActorID1,
                        principalTable: "Actor",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actor_Movie_Movie_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Movie",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_Movie_ActorID1",
                table: "Actor_Movie",
                column: "ActorID1");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CinamaID",
                table: "Movie",
                column: "CinamaID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ProduserID",
                table: "Movie",
                column: "ProduserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actor_Movie");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "Movie");

            migrationBuilder.DropTable(
                name: "Cenima");

            migrationBuilder.DropTable(
                name: "Produser");
        }
    }
}
