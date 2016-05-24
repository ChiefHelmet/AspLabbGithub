using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb3Two.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Labb3Two.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (
                var context =
                    new ApplicationDbContext(
                        serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Movie.Any())
                {
                    return; //DB has been seeded (kinky! :O  ;P )
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Invasion USA",
                        ReleaseDate = DateTime.Parse("1986-1-11"),
                        Genre = "Action",
                        Price = 7.99M
                    },
                    
                    new Movie
                    {
                        Title = "The osteoporosis-Dance",
                        ReleaseDate = DateTime.Parse("1998-1-11"),
                        Genre = "Instructional Video",
                        Price = 8.99M
                    },
                    
                    new Movie
                    {
                        Title = "Birth Of A Nation",
                        ReleaseDate = DateTime.Parse("1915-1-11"),
                        Genre = "Studies Of Ethnical Sciences",
                        Price = 9.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
