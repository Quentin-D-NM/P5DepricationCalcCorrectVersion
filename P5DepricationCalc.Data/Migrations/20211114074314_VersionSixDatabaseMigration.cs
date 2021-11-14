using Microsoft.EntityFrameworkCore.Migrations;

namespace P5DepricationCalc.Data.Migrations
{
    public partial class VersionSixDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MyAssets",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "YearlyDeprecation",
                table: "MyAssets",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearlyDeprecation",
                table: "MyAssets");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MyAssets",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
