namespace BookshopWebsite.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Nationality { get; set; }
        public int Age { get; set; }
        public string? Birthday { get; set; }
        public string? Deathday { get; set; }
        public List<Book>? Books { get; set; }

    }
}
