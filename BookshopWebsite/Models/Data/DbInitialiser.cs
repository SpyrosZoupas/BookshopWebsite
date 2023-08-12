namespace BookshopWebsite.Models.Data
{
    public class DbInitialiser
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookshopDbContext>();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(Authors.Select(c => c.Value));
                }

                if (!context.Books.Any())
                {
                    context.Books.AddRange
                    (
                         new Book { Title = "The fellowship of the ring", Price = 10, InStock = true, ImageUrl = "", Category = Categories["Fiction"], Author = Authors["J.R.R. Tolkien"] },
                         new Book { Title = "Harry Potter and the Sorcerer's Stone", Price = 12, InStock = true, ImageUrl = "", Category = Categories["Fiction"], Author = Authors["J.K. Rowling"] },
                         new Book { Title = "1984", Price = 8, InStock = true, ImageUrl = "", Category = Categories["Fiction"], Author = Authors["George Orwell"] },
                         new Book { Title = "Murder on the Orient Express", Price = 9, InStock = true, ImageUrl = "", Category = Categories["Mystery"], Author = Authors["Agatha Christie"] },
                         new Book { Title = "The Shining", Price = 11, InStock = true, ImageUrl = "", Category = Categories["Fiction"], Author = Authors["Stephen King"] },
                         new Book { Title = "Pride and Prejudice", Price = 7, InStock = true, ImageUrl = "", Category = Categories["Fiction"], Author = Authors["Jane Austen"] },
                         new Book { Title = "The Adventures of Huckleberry Finn", Price = 9, InStock = true, ImageUrl = "", Category = Categories["Fiction"], Author = Authors["Mark Twain"] },
                         new Book { Title = "To Kill a Mockingbird", Price = 10, InStock = true, ImageUrl = "", Category = Categories["Fiction"], Author = Authors["Harper Lee"] },
                         new Book { Title = "The Old Man and the Sea", Price = 8, InStock = true, ImageUrl = "", Category = Categories["Fiction"], Author = Authors["Ernest Hemingway"] },
                         new Book { Title = "War and Peace", Price = 15, InStock = true, ImageUrl = "", Category = Categories["History"], Author = Authors["Leo Tolstoy"] }
                    );
                }

                context.SaveChanges();

            }
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { Name = "Fiction" },
                        new Category { Name = "Mystery" },
                        new Category { Name = "Biography" },
                        new Category { Name = "Science Fiction" },
                        new Category { Name = "History" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.Name, genre);
                    }
                }

                return categories;
            }
        }

        private static Dictionary<string, Author>? authors;

        public static Dictionary<string, Author> Authors
        {
            get
            {
                if (authors == null)
                {
                    var genresList = new Author[]
                    {
                          new Author { Name = "J.R.R. Tolkien" },
                          new Author { Name = "J.K. Rowling" },
                          new Author { Name = "George Orwell" },
                          new Author { Name = "Agatha Christie" },
                          new Author { Name = "Stephen King" },
                          new Author { Name = "Jane Austen" },
                          new Author { Name = "Mark Twain" },
                          new Author { Name = "Harper Lee" },
                          new Author { Name = "Ernest Hemingway" },
                          new Author { Name = "Leo Tolstoy" }
                    };

                    authors = new Dictionary<string, Author>();

                    foreach (Author genre in genresList)
                    {
                        authors.Add(genre.Name, genre);
                    }
                }

                return authors;
            }
        }
    }
}
