using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesActorsAPI.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverUrl",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrailerUrl",
                table: "Movie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverUrl",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "TrailerUrl",
                table: "Movie");
        }
    }
}
