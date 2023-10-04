using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestLinux.Migrations
{
    public partial class InspectionVS1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitRemark",
                table: "VisitRemark");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ValueStatement",
                table: "ValueStatement");

            migrationBuilder.RenameTable(
                name: "VisitRemark",
                newName: "VisitRemarks");

            migrationBuilder.RenameTable(
                name: "ValueStatement",
                newName: "CSPValueStatements");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitRemarks",
                table: "VisitRemarks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CSPValueStatements",
                table: "CSPValueStatements",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PostInspectionValueStatements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Statement = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InputType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostInspectionValueStatements", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PostIsnpectionRemarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    ValueStatementId = table.Column<int>(type: "int", nullable: false),
                    RemarksVisitingOfficial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RemarksVerifyingOfficial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostIsnpectionRemarks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PreInspectionValueStatements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Statement = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InputType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreInspectionValueStatements", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PreIsnpectionRemarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VisitId = table.Column<int>(type: "int", nullable: false),
                    ValueStatementId = table.Column<int>(type: "int", nullable: false),
                    RemarksVisitingOfficial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RemarksVerifyingOfficial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreIsnpectionRemarks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostInspectionValueStatements");

            migrationBuilder.DropTable(
                name: "PostIsnpectionRemarks");

            migrationBuilder.DropTable(
                name: "PreInspectionValueStatements");

            migrationBuilder.DropTable(
                name: "PreIsnpectionRemarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitRemarks",
                table: "VisitRemarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CSPValueStatements",
                table: "CSPValueStatements");

            migrationBuilder.RenameTable(
                name: "VisitRemarks",
                newName: "VisitRemark");

            migrationBuilder.RenameTable(
                name: "CSPValueStatements",
                newName: "ValueStatement");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitRemark",
                table: "VisitRemark",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ValueStatement",
                table: "ValueStatement",
                column: "Id");
        }
    }
}
