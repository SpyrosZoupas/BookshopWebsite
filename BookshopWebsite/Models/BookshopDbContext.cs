using Microsoft.EntityFrameworkCore;

namespace BookshopWebsite.Models
{
    public class BookshopDbContext : DbContext
    {
        public BookshopDbContext(DbContextOptions<BookshopDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
