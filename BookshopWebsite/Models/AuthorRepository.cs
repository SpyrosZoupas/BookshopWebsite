using BookshopWebsite.Models.Data;

namespace BookshopWebsite.Models
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookshopDbContext _context;

        public AuthorRepository(BookshopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Author> GetAuthors() => _context.Authors;
    }
}
