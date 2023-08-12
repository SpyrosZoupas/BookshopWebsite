namespace BookshopWebsite.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
    }
}
