using Microsoft.EntityFrameworkCore;
using OneFPS.Entities;

namespace OneFPS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<ScheduleReportManager> ScheduleReportManagers { get; set; }
        public DbSet<ReportFileSetting> ReportFileSettings { get; set; }
        public DbSet<ReportFrequancy> ReportFrequancies { get; set; }
        public DbSet<ReportEmailSetting> ReportEmailSettings { get; set; }
        public DbSet<SchedulerManager> SchedulerManagers { get; set; }
    }
}
