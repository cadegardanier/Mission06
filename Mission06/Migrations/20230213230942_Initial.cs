using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    applicationID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<short>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.applicationID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "applicationID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action", "John McTernan", false, "Cade Gardanier", "Best Christmas Movie", "PG-13", "Die Hard", (short)1988 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "applicationID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Sports", "Boaz Yakin", false, "Cade Gardanier", "Good film", "PG", "Remember The Titans", (short)2000 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "applicationID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "War", "Steven Spielberg", true, "Cade Gardanier", "might want it edited", "R", "Saving Private Ryan", (short)1998 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
