using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Location> Locations { get; set; }

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
