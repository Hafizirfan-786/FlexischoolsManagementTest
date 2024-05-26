using Microsoft.EntityFrameworkCore;
using FlexischoolsManagement.Domain.Entities;

namespace FlexischoolsManagement.Infrastructure.Persistance
{
    public sealed class FlexischoolsManagementDbContext : DbContext
    {
        public FlexischoolsManagementDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<LectureTheatre> LectureTheatres { get; set; }
        public DbSet<Lecture> Lectures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FlexischoolsManagementDbContext).Assembly);
    }
}
