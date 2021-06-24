using Microsoft.EntityFrameworkCore.Migrations;

namespace OneFPS.Data.Migrations
{
    public partial class ReportFileSetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportFileSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDatePrefix = table.Column<bool>(type: "bit", nullable: false),
                    IsDateSuffix = table.Column<bool>(type: "bit", nullable: false),
                    AttechedFileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScheduleReportId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportFileSettings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportFileSettings");
        }
    }
}
