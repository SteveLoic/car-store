using Microsoft.EntityFrameworkCore.Migrations;

namespace digitalcar.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('make1')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('make2')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES('make3')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make1-ModelA', (SELECT ID FROM Makes where Name = 'make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make1-ModelB', (SELECT ID FROM Makes where Name = 'make1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make1-ModelC', (SELECT ID FROM Makes where Name = 'make1'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make2-ModelA', (SELECT ID FROM Makes where Name = 'make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make2-ModelB', (SELECT ID FROM Makes where Name = 'make2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make2-ModelC', (SELECT ID FROM Makes where Name = 'make2'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make3-ModelA', (SELECT ID FROM Makes where Name = 'make3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make3-ModelB', (SELECT ID FROM Makes where Name = 'make3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES('Make3-ModelC', (SELECT ID FROM Makes where Name = 'make3'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes ");
        }
    }
}
