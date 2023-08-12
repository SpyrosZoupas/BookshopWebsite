namespace BookshopWebsite.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? NumberOfPages { get; set; }
        public string? ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        public int AuthorId { get; set; }
        public Author Author { get; set; } = default!;

    }
}
