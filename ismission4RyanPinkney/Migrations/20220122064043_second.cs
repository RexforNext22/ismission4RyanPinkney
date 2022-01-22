using Microsoft.EntityFrameworkCore.Migrations;

namespace ismission4RyanPinkney.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    movie_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    sTitle = table.Column<string>(nullable: false),
                    sYear = table.Column<string>(nullable: false),
                    sDirector = table.Column<string>(nullable: false),
                    sCategory = table.Column<string>(nullable: false),
                    sRating = table.Column<string>(nullable: false),
                    bIsEdited = table.Column<bool>(nullable: false),
                    sLentToName = table.Column<string>(nullable: true),
                    sNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.movie_id);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movie_id", "bIsEdited", "sCategory", "sDirector", "sLentToName", "sNotes", "sRating", "sTitle", "sYear" },
                values: new object[] { 1, false, "Action/Adventure", "Joss Whedon", "", "", "PG-13", "Avenger, The", "2012" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movie_id", "bIsEdited", "sCategory", "sDirector", "sLentToName", "sNotes", "sRating", "sTitle", "sYear" },
                values: new object[] { 2, false, "Action/Adventure", "Tim Burton", "", "", "PG-13", "Batman", "1989" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "movie_id", "bIsEdited", "sCategory", "sDirector", "sLentToName", "sNotes", "sRating", "sTitle", "sYear" },
                values: new object[] { 3, false, "Action/Adventure", "Joel Schumacher", "", "", "PG-13", "Batman & Robin", "1997" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
