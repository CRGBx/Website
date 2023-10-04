using Microsoft.EntityFrameworkCore.Migrations;

namespace TestLinux.Migrations
{
    public partial class Complaints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComplaintChannel",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ComplaintType",
                table: "Grievances",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CSPVisits",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CSPId",
                table: "CSPVisits",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CSPVisits_CSPId",
                table: "CSPVisits",
                column: "CSPId");

            migrationBuilder.CreateIndex(
                name: "IX_CSPVisits_UserId",
                table: "CSPVisits",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CSPVisits_Csps_CSPId",
                table: "CSPVisits",
                column: "CSPId",
                principalTable: "Csps",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CSPVisits_EmployeeMasters_UserId",
                table: "CSPVisits",
                column: "UserId",
                principalTable: "EmployeeMasters",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CSPVisits_Csps_CSPId",
                table: "CSPVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_CSPVisits_EmployeeMasters_UserId",
                table: "CSPVisits");

            migrationBuilder.DropIndex(
                name: "IX_CSPVisits_CSPId",
                table: "CSPVisits");

            migrationBuilder.DropIndex(
                name: "IX_CSPVisits_UserId",
                table: "CSPVisits");

            migrationBuilder.DropColumn(
                name: "ComplaintChannel",
                table: "Grievances");

            migrationBuilder.DropColumn(
                name: "ComplaintType",
                table: "Grievances");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CSPVisits",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CSPId",
                table: "CSPVisits",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
