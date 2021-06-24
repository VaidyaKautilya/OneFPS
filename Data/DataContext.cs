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
    }
}
