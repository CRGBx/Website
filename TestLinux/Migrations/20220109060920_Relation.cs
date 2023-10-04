using Microsoft.EntityFrameworkCore.Migrations;

namespace TestLinux.Migrations
{
    public partial class Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BrCode",
                table: "Csps",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IIX_Csps_BrCode",
                table: "Csps",
                column: "BrCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Csps_Branches_BrCode",
                table: "Csps",
                column: "BrCode",
                principalTable: "Branches",
                principalColumn: "BrCode",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Csps_Branches_BrCode",
                table: "Csps");

            migrationBuilder.DropIndex(
                name: "IIX_Csps_BrCode",
                table: "Csps");

            migrationBuilder.AlterColumn<string>(
                name: "BrCode",
                table: "Csps",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
