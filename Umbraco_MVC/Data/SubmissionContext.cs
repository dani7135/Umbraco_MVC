using Microsoft.EntityFrameworkCore;
using Umbraco_MVC.Models;

namespace Umbraco_MVC.Data
{
    public class SubmissionContext : DbContext
    {

        public SubmissionContext(DbContextOptions<SubmissionContext> options)
        : base(options)
        { }
        public DbSet<Submission> Submissions { get; set; }

    }
}
