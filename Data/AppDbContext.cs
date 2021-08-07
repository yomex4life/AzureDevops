using System;
using colourapiaugtwentyone.Models;
using Microsoft.EntityFrameworkCore;

namespace colourapiaugtwentyone.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Colour> Colours { get; set; }
    }
}
