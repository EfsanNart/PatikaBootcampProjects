using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Context
{
    public class PatikaFirstDbContext : DbContext
    {
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Game Entity Configuration
            modelBuilder.Entity<Game>(entity =>
            {
                entity.HasKey(g => g.Id);
                entity.Property(g => g.Name).IsRequired().HasMaxLength(100);
                entity.Property(g => g.Platform).HasMaxLength(50);
                entity.Property(g => g.Rating).HasPrecision(3, 1);
            });

            // Movie Entity Configuration
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Title).IsRequired().HasMaxLength(150);
                entity.Property(m => m.Genre).HasMaxLength(50);
                entity.Property(m => m.ReleaseYear).IsRequired();
            });

            // ✅ Seed Data - Initial Games
            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Name = "The Witcher 3", Platform = "PC", Rating = 9.5m },
                new Game { Id = 2, Name = "God of War", Platform = "PS5", Rating = 9.8m },
                new Game { Id = 3, Name = "Cyberpunk 2077", Platform = "PC", Rating = 8.0m }
            );

            // ✅ Seed Data - Initial Movies
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010 },
                new Movie { Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008 },
                new Movie { Id = 3, Title = "Interstellar", Genre = "Sci-Fi", ReleaseYear = 2014 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
