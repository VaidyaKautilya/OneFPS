using Microsoft.EntityFrameworkCore.Migrations;

namespace OneFPS.Data.Migrations
{
    public partial class ScheduleManages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportEmailSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recipients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Has_Attachment_Link = table.Column<bool>(type: "bit", nullable: false),
                    ScheduleReportManagerId = table.Column<int>(type: "int", nullable: true),
                    Scheduled_Report_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportEmailSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportEmailSettings_ScheduleReportManagers_ScheduleReportManagerId",
                        column: x => x.ScheduleReportManagerId,
                        principalTable: "ScheduleReportManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchedulerManagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Last_Run_Status = table.Column<int>(type: "int", nullable: false),
                    Export_ID = table.Column<int>(type: "int", nullable: false),
                    Scheduled_Report_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchedulerManagers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportEmailSettings_ScheduleReportManagerId",
                table: "ReportEmailSettings",
                column: "ScheduleReportManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportEmailSettings");

            migrationBuilder.DropTable(
                name: "SchedulerManagers");
        }
    }
}
