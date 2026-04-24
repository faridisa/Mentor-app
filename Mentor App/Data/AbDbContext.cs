using Microsoft.EntityFrameworkCore;
namespace Mentor_App.Data
{
    public class AbDbContext : DbContext
    {
      public AbDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
