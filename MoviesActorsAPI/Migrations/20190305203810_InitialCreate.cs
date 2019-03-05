using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesActorsAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    ReleaseYear = table.Column<int>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    Stars = table.Column<int>(nullable: false),
                    Runtime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
