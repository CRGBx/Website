using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestLinux.Migrations
{
    public partial class Grievance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Grievances",
                type: "varchar(95)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "BrReplyDate",
                table: "Grievances",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrReplyId",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CheckerReply",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckerReplyDate",
                table: "Grievances",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CheckerReplyId",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "HOReply",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "HOReplyDate",
                table: "Grievances",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HOReplyId",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ROReply",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "ROReplyDate",
                table: "Grievances",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ROReplyId",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrReplyDate",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "BrReplyId",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "CheckerReply",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "CheckerReplyDate",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "CheckerReplyId",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "HOReply",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "HOReplyDate",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "HOReplyId",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "ROReply",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "ROReplyDate",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "ROReplyId",
                table: "Grievances");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Grievances",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(95)")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
