using Microsoft.EntityFrameworkCore.Migrations;

namespace OneFPS.Data.Migrations
{
    public partial class ScheduleReportManagerEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduleReportManagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransMissionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParameterJson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartPage = table.Column<int>(type: "int", nullable: false),
                    EndPage = table.Column<int>(type: "int", nullable: false),
                    UseReportPageSize = table.Column<int>(type: "int", nullable: false),
                    FileStoragePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportFrequancyId = table.Column<int>(type: "int", nullable: false),
                    ReportFileSettingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleReportManagers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleReportManagers");
        }
    }
}
