using SeeSharpersCinema.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;

namespace SeeSharpersCinema.Data
{
    public class SeeSharpersCinemaContext : DbContext
    {
        public SeeSharpersCinemaContext(DbContextOptions<SeeSharpersCinemaContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
/*        public DbSet<Genre> Genres { get; set; }
        public DbSet<ViewIndication> viewIndications { get; set; }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
/*          EnumToNumberConverter<Genre, int> genreConverter = new EnumToNumberConverter<Genre, int>();
            EnumToNumberConverter<ViewIndication, int> viewIndicationConverter = new EnumToNumberConverter<ViewIndication,int>();

            modelBuilder.Entity<Movie>().Property(e => e.Genres).HasConversion(genreConverter);
            modelBuilder.Entity<Movie>().Property(e => e.ViewIndications).HasConversion(viewIndicationConverter);*/

            modelBuilder.Entity<Movie>().ToTable("Movie");
/*            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<ViewIndication>().ToTable("ViewIndication");*/
        }
    }
}
