using CodeFirstRelation.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelation.Context
{
    public class PatikaCodeFirstDb2 : DbContext
    {
        public PatikaCodeFirstDb2(DbContextOptions<PatikaCodeFirstDb2> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                 new User { Id = 1, UserName = "john_doe", Email = "john@example.com" },
                 new User { Id = 2, UserName = "jane_doe", Email = "jane@example.com" }
            );
            modelBuilder.Entity<Post>().HasData(
                 new Post { Id = 1, Title = "Hello World", Content = "This is my first post!", UserId = 1 },
                 new Post { Id = 2, Title = "EF Core Rocks", Content = "Loving Entity Framework Core!", UserId = 1 },
                 new Post { Id = 3, Title = "Coding is Fun", Content = "I enjoy coding every day!", UserId = 2 }
            );


          


            modelBuilder.Entity<User>()
               .HasMany(u => u.Posts)   // Bir kullanıcının birden fazla postu olabilir
               .WithOne(p => p.User)    // Bir post'un sadece bir kullanıcısı vardır
               .HasForeignKey(p => p.UserId)  // Post tablosunda foreign key olarak UserId bulunur
               .OnDelete(DeleteBehavior.Cascade); // Kullanıcı silinirse postları da silinsin

            base.OnModelCreating(modelBuilder);
        }
    }
}
