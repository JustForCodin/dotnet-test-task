using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CsvData> CsvDatas { get; set; }
    }
}
