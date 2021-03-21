using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Database;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Repository;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SeeSharpersCinema.IntegrationTests
{
    public class DatabaseTests
    {
        [Fact]
        public void TestDatabase()
        {
            var options = new DbContextOptionsBuilder<CinemaDbContext>()
                .UseInMemoryDatabase(databaseName: "SSCinemaDB")
                .Options;

            using (var context = new CinemaDbContext(options))
            {
                context.Movies.Add(new Movie 
                { 
                    Id = 1, 
                    Title = "TestMovie",
                    PosterUrl = "https://www.nos.nl",
                    Duration = 120,
                    Language = "Original",
                    Technique = "2D",
                    Description = "Lorem ipsum",
                    ViewIndication = ViewIndication.Nine,
                    Genre = Genre.Action,
                    Year = 2020,
                    Director = "FakeDirector",
                    Country = "USA"
                });

                context.Movies.Add(new Movie
                {
                    Id = 2,
                    Title = "TestMovie2",
                    PosterUrl = "https://www.nu.nl",
                    Duration = 140,
                    Language = "NL",
                    Technique = "3D",
                    Description = "Lorem ipsum deos",
                    ViewIndication = ViewIndication.Six,
                    Genre = Genre.Drama,
                    Year = 2021,
                    Director = "FakeDirector2",
                    Country = "NL"
                });

                context.Movies.Add(new Movie
                {
                    Id = 3,
                    Title = "TestMovie3",
                    PosterUrl = "https://www.radar.nl",
                    Duration = 60,
                    Language = "English",
                    Technique = "2D",
                    Description = "Lorem ipsum whatever",
                    ViewIndication = ViewIndication.Eighteen,
                    Genre = Genre.Horror,
                    Year = 2002,
                    Director = "FakeDirector3",
                    Country = "UK"
                });

                context.SaveChanges();
            }

            using (var context = new CinemaDbContext(options))
            {
                var movieRepo = new EFMovieRepository(context);
                IQueryable<Movie> movies = movieRepo.Movies;
                Assert.Equal(3, movies.Count);


            }
        }

    }
}
