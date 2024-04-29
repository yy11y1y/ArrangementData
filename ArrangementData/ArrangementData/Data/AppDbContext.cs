using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace ArrangementData.Data
{
    public class AppDbContext : DbContext
    {
   
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }

        public DbSet<Arrange> Arranges { get; set; }
        public DbSet<Calen> Calens { get; set; }
    }
}
