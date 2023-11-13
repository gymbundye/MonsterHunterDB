
using Microsoft.EntityFrameworkCore;

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
    }
}