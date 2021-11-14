using Microsoft.EntityFrameworkCore.Migrations;

namespace P5DepricationCalc.Data.Migrations
{
    public partial class VersionFiveDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "GraphVis",
                table: "MyAssets",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GraphVis",
                table: "MyAssets");
        }
    }
}
