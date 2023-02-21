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
        public DbSet<Category> Categories { get; set; }

        //seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure"},
                new Category { CategoryID = 2, CategoryName = "Sports"},
                new Category { CategoryID = 3, CategoryName = "War"},
                new Category { CategoryID = 4, CategoryName = "Comedy"},
                new Category { CategoryID = 5, CategoryName = "Drama"},
                new Category { CategoryID = 6, CategoryName = "Family"},
                new Category { CategoryID = 7, CategoryName = "Horror/Suspense"},
                new Category { CategoryID = 8, CategoryName = "Miscellaneous"},
                new Category { CategoryID = 9, CategoryName = "Television"},
                new Category { CategoryID = 10, CategoryName = "VHS"}

            );

            mb.Entity<ApplicationResponse>().HasData
                (
                    new ApplicationResponse
                    {
                        applicationID = 1,
                        CategoryID = 1,
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
                        CategoryID = 2,
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
                        CategoryID = 3,
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
