
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
                    new Monster { Id = 1, FirstName = "Ortensia", LastName = "Daniellot", MonsterName = "methodology", Type = "Marketing", Description = "Suspendisse potenti. Cras in purus eu magna vulputate luctus." },
                    new Monster { Id = 2, FirstName = "Barbi", LastName = "Leinster", MonsterName = "service-desk", Type = "Sales", Description = "Curabitur gravida nisi at nibh. In hac habitasse platea dictumst." },
                    new Monster { Id = 3, FirstName = "Chloe", LastName = "Ucceli", MonsterName = "mobile", Type = "Accounting", Description = "Vivamus tortor. Duis mattis egestas metus." },
                    new Monster { Id = 4, FirstName = "Reggie", LastName = "Catterell", MonsterName = "Open-source", Type = "Accounting", Description = "Aenean lectus." },
                    new Monster { Id = 5, FirstName = "Ramsay", LastName = "Beamand", MonsterName = "exuding", Type = "Product Management", Description = "Vivamus in felis eu sapien cursus vestibulum. Proin eu mi." },
                    new Monster { Id = 6, FirstName = "Jorie", LastName = "Haulkham", MonsterName = "mobile", Type = "Human Resources", Description = "Vestibulum ante ipsum primis  faucibus orci luctus et ultrices posuere cubilia Curae; Donec." },
                    new Monster { Id = 7, FirstName = "Alejoa", LastName = "Ord", MonsterName = "Quality-focused", Type = "Research and Development", Description = "Quisque erat eros" },
                    new Monster { Id = 8, FirstName = "Vasily", LastName = "Celes", MonsterName = "Multi-lateral", Type = "Support", Description = "Phasellus sit amet erat." },
                    new Monster { Id = 9, FirstName = "Marcille", LastName = "Messingham", MonsterName = "task-force", Type = "Human Resources", Description = "Aliquam augue quam" },
                    new Monster { Id = 10, FirstName = "Kellia", LastName = "Crimes", MonsterName = "array", Type = "Human Resources", Description = "Aliquam non mauris. Morbi non lectus." },
                    new Monster { Id = 11, FirstName = "Dyane", LastName = "Close", MonsterName = "Grass-roots", Type = "Engineering", Description = "Cras pellentesque volutpat dui." },
                    new Monster { Id = 12, FirstName = "Clarinda", LastName = "Cowwell", MonsterName = "solution", Type = "Research and Development", Description = "Proin risus. Praesent lectus." },
                    new Monster { Id = 13, FirstName = "Ginger", LastName = "Isacoff", MonsterName = "time-frame", Type = "Human Resources", Description = "Quisque id justo sit amet sapien dignissim vestibulum. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nulla dapibus dolor vel est." },
                    new Monster { Id = 14, FirstName = "Lita", LastName = "Kinahan", MonsterName = "toolset", Type = "Human Resources", Description = "Vestibulum ante ipsum primis  faucibus orci luctus et ultrices posuere cubilia Curae; Donec " },
                    new Monster { Id = 15, FirstName = "Fulton", LastName = "Hartland", MonsterName = "Implemented", Type = "Support", Description = "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Mauris viverra diam vitae quam. Suspendisse potenti." },
                    new Monster { Id = 16, FirstName = "Dev", LastName = "Dietzler", MonsterName = "multi-tasking", Type = "Services", Description = "Cras pellentesque volutpat dui.Maecenas tristique" },
                    new Monster { Id = 17, FirstName = "Aubrie", LastName = "Brandoni", MonsterName = "executive", Type = "Services", Description = "Nam dui." },
                    new Monster { Id = 18, FirstName = "Carlynne", LastName = "Ruslen", MonsterName = "bifurcated", Type = "Support", Description = "Aliquam erat volutpat." },
                    new Monster { Id = 19, FirstName = "Zitella", LastName = "Mudle", MonsterName = "Robust", Type = "Training", Description = "Nam dui." },
                    new Monster { Id = 20, FirstName = "Beatrisa", LastName = "La Vigne", MonsterName = "database", Type = "Engineering", Description = "Etiam faucibus cursus urna." },
                    new Monster { Id = 21, FirstName = "Phaedra", LastName = "Huntingdon", MonsterName = "policy", Type = "Accounting", Description = "Aliquam augue quam" },
                    new Monster { Id = 22, FirstName = "Vinni", LastName = "Petrusch", MonsterName = "motivating", Type = "Training", Description = "Donec dapibus. Duis at velit eu est congue elementum." },
                    new Monster { Id = 23, FirstName = "Boy", LastName = "Nolder", MonsterName = "benchmark", Type = "Human Resources", Description = "In sagittis dui vel nisl. Duis ac nibh." },
                    new Monster { Id = 24, FirstName = "Emlynn", LastName = "Feathersby", MonsterName = "Total", Type = "Services", Description = "Pellentesque eget nunc." },
                    new Monster { Id = 25, FirstName = "Franz", LastName = "Louys", MonsterName = "website", Type = "Marketing", Description = "Maecenas rhoncus aliquam lacus." }
                    );
        }
    }
}