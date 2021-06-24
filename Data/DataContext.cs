using Microsoft.EntityFrameworkCore;

namespace OneFPS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions opt) : base(opt)
        {

        }
    }
}
