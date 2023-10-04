using Microsoft.EntityFrameworkCore.Migrations;

namespace TestLinux.Migrations
{
    public partial class InspectionRemarks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitRemarks",
                table: "VisitRemarks");

            migrationBuilder.RenameTable(
                name: "VisitRemarks",
                newName: "VisitRemark");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "Grievances",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitRemark",
                table: "VisitRemark",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitRemark",
                table: "VisitRemark");

            migrationBuilder.RenameTable(
                name: "VisitRemark",
                newName: "VisitRemarks");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "Grievances",
                type: "longtext",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitRemarks",
                table: "VisitRemarks",
                column: "Id");
        }
    }
}
