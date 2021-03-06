using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Program;
using SeeSharpersCinema.Models.Theater;
using System;
using System.Linq;

namespace SeeSharpersCinema.Models.Database
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


            Cinema cinema1 = new Cinema
                { Name = "Pathé", Address = "Gedempte Zuiderdiep 78", City = "Groningen", Phone = "0885152050", TotalRooms = 10, TotalCapacity = 3000 };
            Room room1 = new Room 
                { Capacity = 300, Cinema = cinema1 };
            TimeSlot timeSlot1 = new TimeSlot
                { SlotStart = new DateTime(2021, 3, 5, 19, 00, 00), SlotEnd = new DateTime(2021, 3, 5, 21, 00, 00) };
            Movie movie1 = new Movie
            {
                Title = "Blackbird",
                PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/32660_128633_ps_sd-high.jpg",
                Duration = 98,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                Language = "Original",
                Technique = "2D",
                Genre = Genre.Drama,
                ViewIndication = ViewIndication.Sixteen,
                Year = 2021,
                Director = "Roger Michell",
                Country = "USA"
            };

            if (!context.PlayLists.Any())
            {
                context.PlayLists.AddRange(
                    new PlayList
                    {
                        Week = 9,
                        TimeSlot = timeSlot1,
                        Movie = movie1
                    }
                );
                context.SaveChanges();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie { 
                        Title = "Blackbird", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/32660_128633_ps_sd-high.jpg", 
                        Duration = 98, 
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Drama, 
                        ViewIndication = ViewIndication.Sixteen, 
                        Year = 2021, 
                        Director = "Roger Michell", 
                        Country = "USA" 
                    },
                    
                    new Movie { 
                        Title = "In the mood for love", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33783_134425_ps_sd-high.jpg", 
                        Duration = 98, 
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Drama, 
                        ViewIndication = ViewIndication.All, 
                        Year = 2020, 
                        Director = "Kar-Wai Wong", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "De slag om de schelde", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/PathePartners/movie-25169-SlagOmDeScheldeDe_Poster_DEF.jpg", 
                        Duration = 124,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Nederlands", 
                        Technique = "2D", 
                        Genre = Genre.Drama, 
                        ViewIndication = ViewIndication.Sixteen, 
                        Year = 2021, 
                        Director = "Matthijs van Heijningen Jr.", 
                        Country = "NL" 
                    },

                    new Movie { 
                        Title = "Ainbo: Heldin van de amazone", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23672_133688_ps_sd-high.jpg", 
                        Duration = 84,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Nederlands", 
                        Technique = "3D", 
                        Genre = Genre.Children, 
                        ViewIndication = ViewIndication.All, 
                        Year = 2020, 
                        Director = "Kar-Wai Wong", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "David Byrne's amerikan utopia", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508//gfx_content/other/api/filmdepot/v1/movie/download/33816_134505_ps_sd-high.jpg", 
                        Duration = 105,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Documentary, 
                        ViewIndication = ViewIndication.All, 
                        Year = 2021, 
                        Director = "Spike Lee", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "The united stats vs. billie holiday", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33645_134768_ps_sd-high.jpg", 
                        Duration = 130,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Drama, 
                        ViewIndication = ViewIndication.Fourteen, 
                        Year = 2021, 
                        Director = "Lee Daniels", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "The croods: a new age (OV)", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23557_133608_ps_sd-high.jpg", 
                        Duration = 95,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "3D", 
                        Genre = Genre.Animation, 
                        ViewIndication = ViewIndication.Six, 
                        Year = 2020, 
                        Director = "Joel Crawford", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "De croods 2: een nieuw begin (NL)", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23557_133608_ps_sd-high.jpg", 
                        Duration = 95,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Nederlands", 
                        Technique = "3D", 
                        Genre = Genre.Children, 
                        ViewIndication = ViewIndication.Six, 
                        Year = 2020, 
                        Director = "Joel Crawford", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "Slalom", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/Slalom.jpg", 
                        Duration = 92,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Drama, 
                        ViewIndication = ViewIndication.Nine, 
                        Year = 2020, 
                        Director = "Charlène Favier", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "Into the labyrinth", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33764_133801_ps_sd-high.jpg", 
                        Duration = 130,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Crime, 
                        ViewIndication = ViewIndication.Nine, 
                        Year = 2021, 
                        Director = "Donato Carrisi", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "Wrong turn", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33804_134756_ps_sd-high.jpg", 
                        Duration = 110,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Horror, 
                        ViewIndication = ViewIndication.Sixteen, 
                        Year = 2020, 
                        Director = "Mike P. Nelson", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "De Flummels", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33774_133282_ps_sd-high.jpg", 
                        Duration = 84,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Nederlands", 
                        Technique = "2D", 
                        Genre = Genre.Children, 
                        ViewIndication = ViewIndication.Six, 
                        Year = 2021, 
                        Director = "David Silverman", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "Nobody", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23923_133307_ps_sd-high.jpg", 
                        Duration = 92,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Thriller, 
                        ViewIndication = ViewIndication.Sixteen, 
                        Year = 2021, 
                        Director = "Ilya Naishuller", 
                        Country = "USA" 
                    },

                    new Movie { 
                        Title = "The Father", 
                        PosterUrl = "https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33495_134471_ps_sd-high.jpg", 
                        Duration = 97,
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc elementum rutrum magna at sagittis. Curabitur viverra hendrerit enim, at gravida elit venenatis vel. Pellentesque aliquam maximus suscipit. Pellentesque et dolor elit. Duis rhoncus interdum quam, maximus pharetra tortor auctor sed. Ut congue molestie nisl ut aliquam.",
                        Language = "Original", 
                        Technique = "2D", 
                        Genre = Genre.Drama, 
                        ViewIndication = ViewIndication.Nine, 
                        Year = 2020, 
                        Director = "Florian Zeller", 
                        Country = "USA" 
                    }

                );
            context.SaveChanges();
            }
        }
    }
}
