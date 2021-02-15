using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSample.Migrations
{
    public partial class AddCategoryData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO dbo.Categories VALUES ('Cat1')");
            migrationBuilder.Sql("INSERT INTO dbo.Categories VALUES ('Cat2')");
            migrationBuilder.Sql("INSERT INTO dbo.Categories VALUES ('Cat3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM dbo.Categories WHERE Name = 'Cat1'");
            migrationBuilder.Sql("DELETE FROM dbo.Categories WHERE Name = 'Cat2'");
            migrationBuilder.Sql("DELETE FROM dbo.Categories WHERE Name = 'Cat3'");
        }
    }
}
