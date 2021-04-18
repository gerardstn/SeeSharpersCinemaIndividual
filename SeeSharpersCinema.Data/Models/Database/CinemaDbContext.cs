﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SeeSharpersCinema.Models.Film;
using SeeSharpersCinema.Models.Order;
using SeeSharpersCinema.Models.Program;
using SeeSharpersCinema.Models.Theater;
using SeeSharpersCinema.Models.Website;

namespace SeeSharpersCinema.Models.Database
{
    public class CinemaDbContext : IdentityDbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<ReservedSeat> ReservedSeats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Notice> Notices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>().ToTable("Cinema");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<TimeSlot>().ToTable("TimeSlot");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<PlayList>().ToTable("PlayList");
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<Coupon>().ToTable("Coupon");
            modelBuilder.Entity<Notice>().ToTable("Notice");
            modelBuilder.Entity<ReservedSeat>().ToTable("ReservedSeat");

            modelBuilder.Entity<Cinema>().HasData(FakeData.FakeCinemas);
            modelBuilder.Entity<Room>().HasData(FakeData.FakeRooms);
            modelBuilder.Entity<TimeSlot>().HasData(FakeData.FakeTimeSlots);
            modelBuilder.Entity<Movie>().HasData(FakeData.FakeMovies);
            modelBuilder.Entity<PlayList>().HasData(FakeData.FakePlayLists);
            modelBuilder.Entity<Notice>().HasData(FakeData.FakeNotices);
            modelBuilder.Entity<ReservedSeat>().HasData(FakeData.FakeReservedSeats);
            modelBuilder.Entity<Coupon>().HasData(FakeData.FakeCoupons);


            base.OnModelCreating(modelBuilder);
        }
    }
}