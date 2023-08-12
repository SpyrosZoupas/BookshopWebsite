namespace BookshopWebsite.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book? GetBookById(int id);
    }
}
