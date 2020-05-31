using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Umbraco_MVC.Data;
using System;
using System.Linq;

namespace Umbraco_MVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SubmissionContext(
                serviceProvider.GetRequiredService<DbContextOptions<SubmissionContext>>()))
            {
                if (context.Submissions.Any())
                {
                    return;
                }
                context.Submissions.AddRange(
                    new Submission
                    {
                        Age = DateTime.Parse("1989-2-12"),
                        FirstName = "Anne",
                        LastName = "Bjørnsen",
                        Email = "Ab@1234.com",
                       // SerialNumber = 11111111

                    },
                      new Submission
                      {
                          Age = DateTime.Parse("1984-3-13"),
                          FirstName = "Charlie",
                          LastName = "Davidsen",
                          Email = "CD@5678.dk",
                          //SerialNumber = 41451234

                      },
                      new Submission
                      {
                          Age = DateTime.Parse("1954-3-13"),
                          FirstName = "Emma",
                          LastName = "Fralsen",
                          Email = "Emmse@7268.dk",
                         // SerialNumber = 31452948

                      }

                    );
                context.SaveChanges();
            }
        }
    }
}
