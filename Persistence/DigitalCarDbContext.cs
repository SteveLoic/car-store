using digitalcar.Controllers.Models;
using Microsoft.EntityFrameworkCore;

namespace digitalcar.Persistence
{
    public class DigitalCarDbContext : DbContext
    {
        public DigitalCarDbContext(DbContextOptions<DigitalCarDbContext> options) : base(options)
        {

        }

        public DbSet<Make> Makes { get; set; }
    }
}




