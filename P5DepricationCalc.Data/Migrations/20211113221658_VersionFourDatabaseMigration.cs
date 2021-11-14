using Microsoft.EntityFrameworkCore.Migrations;

namespace P5DepricationCalc.Data.Migrations
{
    public partial class VersionFourDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MyAssets",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "MyAssets");
        }
    }
}
