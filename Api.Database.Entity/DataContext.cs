using Microsoft.EntityFrameworkCore;

namespace Api.Database.Entity
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<BaseEntity> Submissions { get; set; }
    }
}
