
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace MonsterHunterDB.Data
{
    public class MonsterDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MonsterDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("MonsterDB"));
        }

        public DbSet<Monster> Monsters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Monster>()
                .ToTable("Monsters");

            modelBuilder.Entity<Monster>()
                .HasData(
                    new Monster
                    {
                        Id = 1,
                        FirstName = "Vlad",
                        LastName = "Teppes",
                        MonsterName = "Dracula",
                        Type = "Vampire",
                        Description = "Lord of the Night, King of the Vampires."
                    }
                );
        }
    }
}