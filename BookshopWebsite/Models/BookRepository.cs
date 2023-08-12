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

        public Book? GetBookById(int id) => _context.Books.FirstOrDefault(b => b.BookId == id);
    }
}
