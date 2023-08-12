namespace BookshopWebsite.Models
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAuthors();
    }
}
