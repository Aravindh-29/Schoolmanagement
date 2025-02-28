using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;

namespace SchoolManagement.Controllers
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure table is created and seeded with initial data
            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "John Doe", Age = 14, Class = "8th Grade" },
                new Student { Id = 2, Name = "Jane Smith", Age = 13, Class = "7th Grade" }
            );
        }
    }
    
}
