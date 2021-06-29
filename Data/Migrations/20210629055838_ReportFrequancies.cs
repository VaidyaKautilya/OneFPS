using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OneFPS.Data.Migrations
{
    public partial class ReportFrequancies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportFrequancies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsReattempt = table.Column<bool>(type: "bit", nullable: false),
                    Reattempt_Occurence = table.Column<bool>(type: "bit", nullable: false),
                    Reattempt_Hour = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportFrequancies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleReportManagers_ReportFrequancyId",
                table: "ScheduleReportManagers",
                column: "ReportFrequancyId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleReportManagers_ReportFrequancies_ReportFrequancyId",
                table: "ScheduleReportManagers",
                column: "ReportFrequancyId",
                principalTable: "ReportFrequancies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleReportManagers_ReportFrequancies_ReportFrequancyId",
                table: "ScheduleReportManagers");

            migrationBuilder.DropTable(
                name: "ReportFrequancies");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleReportManagers_ReportFrequancyId",
                table: "ScheduleReportManagers");
        }
    }
}
