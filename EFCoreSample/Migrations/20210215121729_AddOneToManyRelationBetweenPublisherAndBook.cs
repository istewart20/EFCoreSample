using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSample.Migrations
{
    public partial class AddOneToManyRelationBetweenPublisherAndBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PropertyId",
                table: "Books",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PropertyId",
                table: "Books",
                column: "PropertyId",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PropertyId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PropertyId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "Books");
        }
    }
}
