using FrontendBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontendBackend.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Projects> Projects { get; set; }

    }
}
