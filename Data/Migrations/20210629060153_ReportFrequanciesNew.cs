using Microsoft.EntityFrameworkCore.Migrations;

namespace OneFPS.Data.Migrations
{
    public partial class ReportFrequanciesNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Scheduled_Report_ID",
                table: "ReportFrequancies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Scheduled_Report_ID",
                table: "ReportFrequancies");
        }
    }
}
