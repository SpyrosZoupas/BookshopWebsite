namespace BookshopWebsite.Models.Data
{
    public class DbInitialiser
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BookshopDbContext>();

                context.Database.EnsureCreated();

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange
                    (
                        new Category { CategoryId = 1, Name = "Fiction" },
                        new Category { CategoryId = 2, Name = "Mystery" },
                        new Category { CategoryId = 3, Name = "Biography" },
                        new Category { CategoryId = 4, Name = "Science Fiction" },
                        new Category { CategoryId = 5, Name = "History" }
                    );               
                }

                context.SaveChanges();

                if (!context.Authors.Any())
                {
                    context.Authors.AddRange
                    (
                          new Author { AuthorId = 1, Name = "J.R.R. Tolkien" },
                          new Author { AuthorId = 2, Name = "J.K. Rowling" },
                          new Author { AuthorId = 3, Name = "George Orwell" },
                          new Author { AuthorId = 4, Name = "Agatha Christie" },
                          new Author { AuthorId = 5, Name = "Stephen King" },
                          new Author { AuthorId = 6, Name = "Jane Austen" },
                          new Author { AuthorId = 7, Name = "Mark Twain" },
                          new Author { AuthorId = 8, Name = "Harper Lee" },
                          new Author { AuthorId = 9, Name = "Ernest Hemingway" },
                          new Author { AuthorId = 10, Name = "Leo Tolstoy" }
                    );
                }

                context.SaveChanges();

                if (!context.Books.Any())
                {
                    context.Books.AddRange
                    (
                         new Book { BookId = 1, Title = "The fellowship of the ring", Price = 10, InStock = true, ImageUrl = "", AuthorId = 1, CategoryId = 1 },
                         new Book { BookId = 2, Title = "Harry Potter and the Sorcerer's Stone", Price = 12, InStock = true, ImageUrl = "", AuthorId = 2, CategoryId = 1 },
                         new Book { BookId = 3, Title = "1984", Price = 8, InStock = true, ImageUrl = "", AuthorId = 3, CategoryId = 1 },
                         new Book { BookId = 4, Title = "Murder on the Orient Express", Price = 9, InStock = true, ImageUrl = "", AuthorId = 4, CategoryId = 2 },
                         new Book { BookId = 5, Title = "The Shining", Price = 11, InStock = true, ImageUrl = "", AuthorId = 5, CategoryId = 1 },
                         new Book { BookId = 6, Title = "Pride and Prejudice", Price = 7, InStock = true, ImageUrl = "", AuthorId = 6, CategoryId = 1 },
                         new Book { BookId = 7, Title = "The Adventures of Huckleberry Finn", Price = 9, InStock = true, ImageUrl = "", AuthorId = 7, CategoryId = 1 },
                         new Book { BookId = 8, Title = "To Kill a Mockingbird", Price = 10, InStock = true, ImageUrl = "", AuthorId = 8, CategoryId = 1 },
                         new Book { BookId = 9, Title = "The Old Man and the Sea", Price = 8, InStock = true, ImageUrl = "", AuthorId = 9, CategoryId = 1 },
                         new Book { BookId = 10, Title = "War and Peace", Price = 15, InStock = true, ImageUrl = "", AuthorId = 10, CategoryId = 5 }
                    );
                }

                context.SaveChanges();

            }
        }
    }
}
