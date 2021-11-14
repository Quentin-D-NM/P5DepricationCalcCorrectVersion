using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P5DepricationCalc.Data.Migrations
{
    public partial class VersionThreeDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateIn",
                table: "MyAssets",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOut",
                table: "MyAssets",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateIn",
                table: "MyAssets");

            migrationBuilder.DropColumn(
                name: "DateOut",
                table: "MyAssets");
        }
    }
}
