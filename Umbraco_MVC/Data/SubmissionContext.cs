using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Umbraco_MVC.Models;

namespace Umbraco_MVC.Data
{
    public class SubmissionContext: DbContext
    {
       
            public SubmissionContext(DbContextOptions<SubmissionContext> options)
            : base(options)
            { }
            public DbSet<Submission> Submissions { get; set; }
            public DbSet<SerialNumber> serialNumbers { get; set; }
      
    }
}
