using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SeeSharpersCinema.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            CinemaDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<CinemaDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie
                    {
                        MovieId = 1,
                        Title ="Movie1",
                        Duration = 90,
                        Language = "English",
                        Description = "Very lovely movie",
                        ViewIndication = "Violence",
                        Genre = Genre.Action,
                        Year = 1980,
                        Director = "Johnny Cash",
                        Country = "United States"
                    },

                    new Movie
                    {
                        MovieId = 2,
                        Title = "Movie2",
                        Duration = 120,
                        Language = "English",
                        Description = "Horreble movie",
                        ViewIndication = "Violence",
                        Genre = Genre.Horror,
                        Year = 1989,
                        Director = "Stephen King",
                        Country = "United States"
                    },

                    new Movie
                    {
                        MovieId = 3,
                        Title = "Movie3",
                        Duration = 130,
                        Language = "English",
                        Description = "Sweet movie",
                        ViewIndication = "Nudity",
                        Genre = Genre.Romance,
                        Year = 2000,
                        Director = "Ellen Degenerosity",
                        Country = "United Kingdom"
                    }
                );
            context.SaveChanges();
            }
        }
    }
}
