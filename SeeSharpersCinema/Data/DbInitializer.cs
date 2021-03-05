using SeeSharpersCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeeSharpersCinema.Data
{
    public class DbInitializer
    {
        public static void Initialize (SeeSharpersCinemaContext context)
        { 
            context.Database.EnsureCreated();
            
            if (context.Movies.Any())
            {
                return;
            }           
            var movies = new Movie[]
            {
                new Movie{Title="Blackbird", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/32660_128633_ps_sd-high.jpg", Duration=98, Language="Original", Technique="2D",  Genres=Genre.Drama, ViewIndications=ViewIndication.Sixteen, Year=2021, Director="Roger Michell", Country="USA"  },
                new Movie{Title="In the mood for love", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33783_134425_ps_sd-high.jpg", Duration=98, Language="Original", Technique="2D",  Genres=Genre.Drama , ViewIndications=ViewIndication.All, Year=2020, Director="Kar-Wai Wong", Country="USA"  },
                new Movie{Title="De slag om de schelde", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/PathePartners/movie-25169-SlagOmDeScheldeDe_Poster_DEF.jpg", Duration=124, Language="Nederlands", Technique="2D", Genres=Genre.Drama , ViewIndications=ViewIndication.Sixteen, Year=2021, Director="Matthijs van Heijningen Jr.", Country="NL"  },
                new Movie{Title="Ainbo: Heldin van de amazone", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23672_133688_ps_sd-high.jpg", Duration=84, Language="Nederlands", Technique="3D", Genres=Genre.Children , ViewIndications=ViewIndication.All, Year=2020, Director="Kar-Wai Wong", Country="USA"  },
                new Movie{Title="David Byrne's amerikan utopia", PosterUrl="https://media.pathe.nl/thumb/360x508//gfx_content/other/api/filmdepot/v1/movie/download/33816_134505_ps_sd-high.jpg", Duration=105, Language="Original", Technique="2D", Genres=Genre.Documentary , ViewIndications=ViewIndication.All, Year=2021, Director="Spike Lee", Country="USA"  },
                new Movie{Title="The united stats vs. billie holiday", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33645_134768_ps_sd-high.jpg", Duration=130, Language="Original", Technique="2D", Genres=Genre.Drama , ViewIndications=ViewIndication.Fourteen, Year=2021, Director="Lee Daniels", Country="USA"  },
                new Movie{Title="The croods: a new age (OV)", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23557_133608_ps_sd-high.jpg", Duration=95, Language="Original", Technique="3D", Genres=Genre.Animation , ViewIndications=ViewIndication.Six, Year=2020, Director="Joel Crawford", Country="USA"  },
                new Movie{Title="De croods 2: een nieuw begin (NL)", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23557_133608_ps_sd-high.jpg", Duration=95, Language="Nederlands", Technique="3D", Genres=Genre.Children , ViewIndications=ViewIndication.Six, Year=2020, Director="Joel Crawford", Country="USA"  },
                new Movie{Title="Slalom", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/Slalom.jpg", Duration=92, Language="Original", Technique="2D", Genres=Genre.Drama , ViewIndications=ViewIndication.Nine, Year=2020, Director="Charlène Favier", Country="USA"  },
                new Movie{Title="Into the labyrinth", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33764_133801_ps_sd-high.jpg", Duration=130, Language="Original", Technique="2D", Genres=Genre.Crime, ViewIndications=ViewIndication.Nine, Year=2021, Director="Donato Carrisi", Country="USA"  },
                new Movie{Title="Wrong turn", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33804_134756_ps_sd-high.jpg", Duration=110, Language="Original", Technique="2D", Genres=Genre.Horror, ViewIndications=ViewIndication.Sixteen, Year=2020, Director="Mike P. Nelson", Country="USA"  },
                new Movie{Title="De Flummels", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33774_133282_ps_sd-high.jpg", Duration=84, Language="Nederlands", Technique="2D", Genres=Genre.Children, ViewIndications=ViewIndication.Six, Year=2021, Director="David Silverman", Country="USA"  },
                new Movie{Title="Nobody", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/23923_133307_ps_sd-high.jpg", Duration=92, Language="Original", Technique="2D", Genres=Genre.Thriller, ViewIndications=ViewIndication.Sixteen, Year=2021, Director="Ilya Naishuller", Country="USA"  },
                new Movie{Title="The Father", PosterUrl="https://media.pathe.nl/thumb/360x508/gfx_content/other/api/filmdepot/v1/movie/download/33495_134471_ps_sd-high.jpg", Duration=97, Language="Original", Technique="2D", Genres=Genre.Drama, ViewIndications=ViewIndication.Nine, Year=2020, Director="Florian Zeller", Country="USA"  }
            };

            foreach (Movie m in movies)
            {
                context.Movies.Add(m);
            }
            context.SaveChanges();
        }
    }
}