using SeeSharpersCinema.Models.Theater;
using System.Collections.Generic;
using System;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Program;

namespace SeeSharpersCinema.Models.Database
{
    public class FakeData
    {
        public static List<Cinema> FakeCinemas
            = new List<Cinema>
            {
                new Cinema { Id = 1, Name = "Pathé", Address= "Gedempte Zuiderdiep 78", City = "Groningen", Phone = "0885152050", TotalRooms = 5, TotalCapacity = 1500 }
            };

        public static List<Room> FakeRooms
            = new List<Room>
            {
                new Room { Id = 1, Capacity = 300, CinemaId = 1 },
                new Room { Id = 2, Capacity = 300, CinemaId = 1 },
                new Room { Id = 3, Capacity = 300, CinemaId = 1 },
                new Room { Id = 4, Capacity = 300, CinemaId = 1 },
                new Room { Id = 5, Capacity = 300, CinemaId = 1 },
                new Room { Id = 6, Capacity = 300, CinemaId = 1 },
                new Room { Id = 7, Capacity = 300, CinemaId = 1 }
            };

        public static List<TimeSlot> FakeTimeSlots
            = new List<TimeSlot>
            { 
                new TimeSlot { Id = 1, Week = 9, SlotStart = new DateTime(2021, 3, 9, 19, 00, 00), SlotEnd = new DateTime(2021, 3, 9, 20, 30, 00), RoomId= 1 },
                new TimeSlot { Id = 2, Week = 9, SlotStart = new DateTime(2021, 3, 10, 21, 00, 00), SlotEnd = new DateTime(2021, 3, 10, 23, 00, 00), RoomId= 1 },
                new TimeSlot { Id = 3, Week = 9, SlotStart = new DateTime(2021, 3, 11, 19, 00, 00), SlotEnd = new DateTime(2021, 3, 11, 20, 30, 00), RoomId= 2 },
                new TimeSlot { Id = 4, Week = 9, SlotStart = new DateTime(2021, 3, 12, 21, 00, 00), SlotEnd = new DateTime(2021, 3, 12, 23, 00, 00), RoomId= 2 },
                new TimeSlot { Id = 5, Week = 9, SlotStart = new DateTime(2021, 3, 13, 19, 00, 00), SlotEnd = new DateTime(2021, 3, 13, 20, 30, 00), RoomId= 3 },
                new TimeSlot { Id = 6, Week = 9, SlotStart = new DateTime(2021, 3, 14, 21, 00, 00), SlotEnd = new DateTime(2021, 3, 14, 23, 00, 00), RoomId= 3 },
                new TimeSlot { Id = 7, Week = 9, SlotStart = new DateTime(2021, 3, 15, 19, 00, 00), SlotEnd = new DateTime(2021, 3, 15, 20, 30, 00), RoomId= 4 },
                new TimeSlot { Id = 8, Week = 9, SlotStart = new DateTime(2021, 3, 16, 21, 00, 00), SlotEnd = new DateTime(2021, 3, 16, 23, 00, 00), RoomId= 4 },
                new TimeSlot { Id = 9, Week = 9, SlotStart = new DateTime(2021, 3, 17, 19, 00, 00), SlotEnd = new DateTime(2021, 3, 17, 20, 30, 00), RoomId= 5 },
                new TimeSlot { Id = 10, Week = 9, SlotStart = new DateTime(2021, 3, 18, 21, 00, 00), SlotEnd = new DateTime(2021, 3, 18, 23, 00, 00), RoomId= 5 },
                new TimeSlot { Id = 11, Week = 9, SlotStart = new DateTime(2021, 3, 19, 19, 00, 00), SlotEnd = new DateTime(2021, 3, 19, 20, 30, 00), RoomId= 6 },
                new TimeSlot { Id = 12, Week = 9, SlotStart = new DateTime(2021, 3, 20, 21, 00, 00), SlotEnd = new DateTime(2021, 3, 20, 23, 00, 00), RoomId= 6 },
                new TimeSlot { Id = 13, Week = 9, SlotStart = new DateTime(2021, 3, 21, 19, 00, 00), SlotEnd = new DateTime(2021, 3, 21, 20, 30, 00), RoomId= 7 },
                new TimeSlot { Id = 14, Week = 9, SlotStart = new DateTime(2021, 3, 22, 21, 00, 00), SlotEnd = new DateTime(2021, 3, 22, 23, 00, 00), RoomId= 7 }

            };

        public static List<Movie> FakeMovies
            = new List<Movie>
            {
                new Movie
                {
                    Id = 1,
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

                new Movie 
                {
                    Id = 2,
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

                new Movie 
                {
                    Id = 3,
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
                    Id = 4,
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
                    Id = 5,
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
                    Id = 6,
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
                    Id = 7,
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
                    Id = 8,
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
                    Id = 9,
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
                    Id = 10,
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
                    Id = 11,
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
                    Id = 12,
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
                    Id = 13,
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
                    Id = 14,
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
            };

        public static List<PlayList> FakePlayLists
            = new List<PlayList>
            {
                new PlayList { Id = 1, MovieId = 1, TimeSlotId = 1 },
                new PlayList { Id = 2, MovieId = 2, TimeSlotId = 2 },
                new PlayList { Id = 3, MovieId = 3, TimeSlotId = 3 },
                new PlayList { Id = 4, MovieId = 4, TimeSlotId = 4 },
                new PlayList { Id = 5, MovieId = 5, TimeSlotId = 5 },
                new PlayList { Id = 6, MovieId = 6, TimeSlotId = 6 },
                new PlayList { Id = 7, MovieId = 7, TimeSlotId = 7 },
                new PlayList { Id = 8, MovieId = 8, TimeSlotId = 8 },
                new PlayList { Id = 9, MovieId = 9, TimeSlotId = 9 },
                new PlayList { Id = 10, MovieId = 10, TimeSlotId = 10 },
                new PlayList { Id = 11, MovieId = 11, TimeSlotId = 11 },
                new PlayList { Id = 12, MovieId = 12, TimeSlotId = 12 },
                new PlayList { Id = 13, MovieId = 13, TimeSlotId = 13 },
                new PlayList { Id = 14, MovieId = 14, TimeSlotId = 14 },
            };
    }
}
