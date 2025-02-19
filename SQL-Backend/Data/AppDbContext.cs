using SQL_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace SQL_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Classes> Classes { get; set; }
        public DbSet<Students> Students { get; set; } 
        public DbSet<Teachers> Teachers { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>()
                .HasOne(o => o.)
        }*/
    }
}
