using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class MovieApplicationContext : DbContext
    {
        //constructor
        public MovieApplicationContext (DbContextOptions<MovieApplicationContext> options) : base (options)
        {
            //leave blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData
                (
                    new ApplicationResponse
                    {
                        applicationID = 1,
                        Category = "Action",
                        Title = "Die Hard",
                        Year = 1988,
                        Director = "John McTernan",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "Cade Gardanier",
                        Notes = "Best Christmas Movie",
                    },
                    new ApplicationResponse
                    {
                        applicationID = 2,
                        Category = "Sports",
                        Title = "Remember The Titans",
                        Year = 2000,
                        Director = "Boaz Yakin",
                        Rating = "PG",
                        Edited = false,
                        Lent = "Cade Gardanier",
                        Notes = "Good film",
                    },
                    new ApplicationResponse
                    {
                        applicationID = 3,
                        Category = "War",
                        Title = "Saving Private Ryan",
                        Year = 1998,
                        Director = "Steven Spielberg",
                        Rating = "R",
                        Edited = true,
                        Lent = "Cade Gardanier",
                        Notes = "might want it edited",
                    }
                );
        }
    }
}
