using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            SeeSharpersDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<SeeSharpersDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Tickets.Any())
            {
                context.Tickets.AddRange(
                    new Ticket 
                    { 
                        Title = "Aladin", 
                        TimeSlot = DateTime.Parse("2021-10-05 12:30"), 
                        RoomID = 1, 
                        SeatNum = 15, 
                        Discounted = false 
                    },
                    new Ticket 
                    { 
                        Title = "Sleeping Beauty", 
                        TimeSlot = DateTime.Parse("2021-10-05 12:30"), 
                        RoomID = 2, 
                        SeatNum = 15, 
                        Discounted = false 
                    },
                    new Ticket 
                    { 
                        Title = "Sleeping Beauty", 
                        TimeSlot = DateTime.Parse("2021-10-05 12:30"), 
                        RoomID = 2, 
                        SeatNum = 16, 
                        Discounted = false 
                    },
                    new Ticket 
                    { 
                        Title = "Sleeping Beauty", 
                        TimeSlot = DateTime.Parse("2021-10-05 12:30"), 
                        RoomID = 2, 
                        SeatNum = 14, 
                        Discounted = false 
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
