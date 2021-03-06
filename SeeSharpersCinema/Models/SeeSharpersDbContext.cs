using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models
{
    public class SeeSharpersDbContext : DbContext
    {
        public SeeSharpersDbContext(DbContextOptions<SeeSharpersDbContext> options) : base(options) { }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
