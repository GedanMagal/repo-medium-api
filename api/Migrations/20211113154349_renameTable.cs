using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class renameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Gategories_CategoryId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gategories",
                table: "Gategories");

            migrationBuilder.RenameTable(
                name: "Gategories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Categories_CategoryId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Gategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gategories",
                table: "Gategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Gategories_CategoryId",
                table: "Movies",
                column: "CategoryId",
                principalTable: "Gategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
