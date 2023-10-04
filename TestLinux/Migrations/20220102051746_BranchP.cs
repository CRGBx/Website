using Microsoft.EntityFrameworkCore.Migrations;

namespace TestLinux.Migrations
{
    public partial class BranchP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BranchPerformances",
                columns: table => new
                {
                    BranchCode = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepositPrevFy = table.Column<float>(type: "float", nullable: false),
                    DepositLastFy = table.Column<float>(type: "float", nullable: false),
                    DepositLastQuarter = table.Column<float>(type: "float", nullable: false),
                    DepositLastMonth = table.Column<float>(type: "float", nullable: false),
                    DepositLastDay = table.Column<float>(type: "float", nullable: false),
                    CASAPrevFy = table.Column<float>(type: "float", nullable: false),
                    CASALastFy = table.Column<float>(type: "float", nullable: false),
                    CASALastQuarter = table.Column<float>(type: "float", nullable: false),
                    CASALastMonth = table.Column<float>(type: "float", nullable: false),
                    CASALastDay = table.Column<float>(type: "float", nullable: false),
                    AdvancePrevFy = table.Column<float>(type: "float", nullable: false),
                    AdvanceLastFy = table.Column<float>(type: "float", nullable: false),
                    AdvanceLastQuarter = table.Column<float>(type: "float", nullable: false),
                    AdvanceLastMonth = table.Column<float>(type: "float", nullable: false),
                    AdvanceLastDay = table.Column<float>(type: "float", nullable: false),
                    PerPrevFy = table.Column<float>(type: "float", nullable: false),
                    PerLastFy = table.Column<float>(type: "float", nullable: false),
                    PerLastQuarter = table.Column<float>(type: "float", nullable: false),
                    PerLastMonth = table.Column<float>(type: "float", nullable: false),
                    PerLastDay = table.Column<float>(type: "float", nullable: false),
                    AgriPrevFy = table.Column<float>(type: "float", nullable: false),
                    AgriLastFy = table.Column<float>(type: "float", nullable: false),
                    AgriLastQuarter = table.Column<float>(type: "float", nullable: false),
                    AgriLastMonth = table.Column<float>(type: "float", nullable: false),
                    AgriLastDay = table.Column<float>(type: "float", nullable: false),
                    SMEPrevFy = table.Column<float>(type: "float", nullable: false),
                    SMELastFy = table.Column<float>(type: "float", nullable: false),
                    SMELastQuarter = table.Column<float>(type: "float", nullable: false),
                    SMELastMonth = table.Column<float>(type: "float", nullable: false),
                    SMELastDay = table.Column<float>(type: "float", nullable: false),
                    HLPrevFy = table.Column<float>(type: "float", nullable: false),
                    HLLastFy = table.Column<float>(type: "float", nullable: false),
                    HLLastQuarter = table.Column<float>(type: "float", nullable: false),
                    HLLastMonth = table.Column<float>(type: "float", nullable: false),
                    HLLastDay = table.Column<float>(type: "float", nullable: false),
                    CarPrevFy = table.Column<float>(type: "float", nullable: false),
                    CarLastFy = table.Column<float>(type: "float", nullable: false),
                    CarLastQuarter = table.Column<float>(type: "float", nullable: false),
                    CarLastMonth = table.Column<float>(type: "float", nullable: false),
                    CarLastDay = table.Column<float>(type: "float", nullable: false),
                    PLPrevFy = table.Column<float>(type: "float", nullable: false),
                    PLLastFy = table.Column<float>(type: "float", nullable: false),
                    PLLastQuarter = table.Column<float>(type: "float", nullable: false),
                    PLLastMonth = table.Column<float>(type: "float", nullable: false),
                    PLLastDay = table.Column<float>(type: "float", nullable: false),
                    GoldPrevFy = table.Column<float>(type: "float", nullable: false),
                    GoldLastFy = table.Column<float>(type: "float", nullable: false),
                    GoldLastQuarter = table.Column<float>(type: "float", nullable: false),
                    GoldLastMonth = table.Column<float>(type: "float", nullable: false),
                    GoldLastDay = table.Column<float>(type: "float", nullable: false),
                    KCCPrevFy = table.Column<float>(type: "float", nullable: false),
                    KCCLastFy = table.Column<float>(type: "float", nullable: false),
                    KCCLastQuarter = table.Column<float>(type: "float", nullable: false),
                    KCCLastMonth = table.Column<float>(type: "float", nullable: false),
                    KCCLastDay = table.Column<float>(type: "float", nullable: false),
                    NRLMPrevFy = table.Column<float>(type: "float", nullable: false),
                    NRLMLastFy = table.Column<float>(type: "float", nullable: false),
                    NRLMLastQuarter = table.Column<float>(type: "float", nullable: false),
                    NRLMLastMonth = table.Column<float>(type: "float", nullable: false),
                    NRLMLastDay = table.Column<float>(type: "float", nullable: false),
                    SMELPrevFy = table.Column<float>(type: "float", nullable: false),
                    SMELLastFy = table.Column<float>(type: "float", nullable: false),
                    SMELLastQuarter = table.Column<float>(type: "float", nullable: false),
                    SMELLastMonth = table.Column<float>(type: "float", nullable: false),
                    SMELLastDay = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchPerformances", x => x.BranchCode);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchPerformances");
        }
    }
}
