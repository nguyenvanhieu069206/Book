using Microsoft.EntityFrameworkCore;

namespace Book.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BookItem> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Văn học" },
                new Category { Id = 2, Name = "Khoa học" },
                new Category { Id = 3, Name = "Kỹ năng sống" },
                new Category { Id = 4, Name = "Công nghệ thông tin" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
