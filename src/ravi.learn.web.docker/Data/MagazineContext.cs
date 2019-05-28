using Microsoft.EntityFrameworkCore;
using ravi.learn.web.docker.Models;

namespace ravi.learn.web.docker.Data
{
    public class MagazineContext : DbContext
    {
        public MagazineContext(DbContextOptions<MagazineContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Magazine> Magazine { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Magazine>().HasData(
                new Magazine { Id = 1, Name = "MSDN MAgazine" },
                new Magazine { Id = 2, Name = "Docker for Dummies" },
                new Magazine { Id = 3, Name = "EF Core for experts" }
                );
        }
    }
}
