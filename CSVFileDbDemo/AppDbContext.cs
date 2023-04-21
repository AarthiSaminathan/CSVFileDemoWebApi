using CSVFileDbDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace CSVFileDbDemo
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cities> cities { get; set; }

    }
}
