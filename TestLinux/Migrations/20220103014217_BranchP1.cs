using Microsoft.EntityFrameworkCore.Migrations;

namespace TestLinux.Migrations
{
    public partial class BranchP1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "NPALastDay",
                table: "BranchPerformances",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "NPALastFy",
                table: "BranchPerformances",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "NPALastMonth",
                table: "BranchPerformances",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "NPALastQuarter",
                table: "BranchPerformances",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "NPAPrevFy",
                table: "BranchPerformances",
                type: "float",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NPALastDay",
                table: "BranchPerformances");

            migrationBuilder.DropColumn(
                name: "NPALastFy",
                table: "BranchPerformances");

            migrationBuilder.DropColumn(
                name: "NPALastMonth",
                table: "BranchPerformances");

            migrationBuilder.DropColumn(
                name: "NPALastQuarter",
                table: "BranchPerformances");

            migrationBuilder.DropColumn(
                name: "NPAPrevFy",
                table: "BranchPerformances");
        }
    }
}
