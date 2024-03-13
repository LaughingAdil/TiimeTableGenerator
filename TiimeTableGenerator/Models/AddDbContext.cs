using Microsoft.EntityFrameworkCore;

namespace TiimeTableGenerator.Models
{
    public class AddDbContext : DbContext
    {
        public DbSet<TimeTableInput> TimeTableInputTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }

    }
}
