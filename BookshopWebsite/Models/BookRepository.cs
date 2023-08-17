using BookshopWebsite.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace BookshopWebsite.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly BookshopDbContext _context;

        public BookRepository(BookshopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks() => _context.Books;

        public Book? GetBookById(int id) => _context.Books.Include(a => a.Author).Include(c => c.Category).FirstOrDefault(b => b.BookId == id);
    }
}
