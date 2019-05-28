using Microsoft.EntityFrameworkCore.Migrations;

namespace ravi.learn.web.docker.Migrations
{
    public partial class initSqlLite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magazine",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazine", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "MSDN MAgazine" });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Docker for Dummies" });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "EF Core for experts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magazine");
        }
    }
}
