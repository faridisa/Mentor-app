using Mentor_App.Models;
using Microsoft.EntityFrameworkCore;
namespace Mentor_App.Data
{
    public class AbDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<WhyUs> WhyUses { get; set; }
        public AbDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
