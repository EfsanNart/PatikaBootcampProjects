using Microsoft.EntityFrameworkCore;
using Survivor.Entities;

namespace Survivor.Data
{
    public class SurvivorDbContext: DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options) { }

        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();

        public DbSet<CompetitorsEntity> Competitors => Set<CompetitorsEntity>();
    }
}
