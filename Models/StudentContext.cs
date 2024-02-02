using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.CaseNotes)
                .WithOne(c => c.Student)
                .HasForeignKey(c => c.StudentId);

            modelBuilder.Seed();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<CaseNote> CaseNotes { get; set; }  
    }
}
