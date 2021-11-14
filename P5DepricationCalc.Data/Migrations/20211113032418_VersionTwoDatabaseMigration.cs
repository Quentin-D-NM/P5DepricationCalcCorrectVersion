using Microsoft.EntityFrameworkCore.Migrations;

namespace P5DepricationCalc.Data.Migrations
{
    public partial class VersionTwoDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Assets",
                table: "Assets");

            migrationBuilder.RenameTable(
                name: "Assets",
                newName: "MyAssets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyAssets",
                table: "MyAssets",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyAssets",
                table: "MyAssets");

            migrationBuilder.RenameTable(
                name: "MyAssets",
                newName: "Assets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assets",
                table: "Assets",
                column: "Id");
        }
    }
}
