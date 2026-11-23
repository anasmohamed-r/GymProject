using GymProject.Entites;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymProject.Context
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQL2025;DataBase=Gym;Trusted_Connection=true;TrustServerCertificate=true ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Member> Members { get; set; }

        public DbSet<Memberships> Memberships { get; set; }

        public DbSet<Plan> Plans { get; set; }

        public DbSet<Session> sessions { get; set; }
        }
}
