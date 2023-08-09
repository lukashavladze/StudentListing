using Microsoft.EntityFrameworkCore;

namespace StudentListing.Data
{
    public class StudentListingDbContext : DbContext
    {
        public StudentListingDbContext(DbContextOptions<StudentListingDbContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Professor> Professors { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
