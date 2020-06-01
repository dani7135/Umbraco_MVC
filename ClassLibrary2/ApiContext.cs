using Api.Database.Entity;
using Microsoft.EntityFrameworkCore;



namespace ClassLibrary2
{
    class ApiContext :DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        public DbSet<BaseEntity> Submissions { get; set; }

        
    }
}
