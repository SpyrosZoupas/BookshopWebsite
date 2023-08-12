namespace BookshopWebsite.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookshopDbContext _context;

        public CategoryRepository(BookshopDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories() => _context.Categories;
    }
}
