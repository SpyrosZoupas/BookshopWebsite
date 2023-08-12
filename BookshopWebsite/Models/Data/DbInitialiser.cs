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
                    context.Categories.AddRange
                    (
                        new Category { Name = "Fiction" },
                        new Category { Name = "Mystery" },
                        new Category { Name = "Biography" },
                        new Category { Name = "Science Fiction" },
                        new Category { Name = "History" }
                    );               
                }

                context.SaveChanges();

                if (!context.Authors.Any())
                {
                    context.Authors.AddRange
                    (
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
                    );
                }

                context.SaveChanges();

                if (!context.Books.Any())
                {
                    context.Books.AddRange
                    (
                         new Book { Title = "The fellowship of the ring", Price = 10, InStock = true, ImageUrl = "" },
                         new Book { Title = "Harry Potter and the Sorcerer's Stone", Price = 12, InStock = true, ImageUrl = "" },
                         new Book {Title = "1984", Price = 8, InStock = true, ImageUrl = "" },
                         new Book {Title = "Murder on the Orient Express", Price = 9, InStock = true, ImageUrl = "" },
                         new Book {Title = "The Shining", Price = 11, InStock = true, ImageUrl = "" },
                         new Book {Title = "Pride and Prejudice", Price = 7, InStock = true, ImageUrl = "" },
                         new Book {Title = "The Adventures of Huckleberry Finn", Price = 9, InStock = true, ImageUrl = "" },
                         new Book {Title = "To Kill a Mockingbird", Price = 10, InStock = true, ImageUrl = "" },
                         new Book {Title = "The Old Man and the Sea", Price = 8, InStock = true, ImageUrl = "" },
                         new Book { Title = "War and Peace", Price = 15, InStock = true, ImageUrl = "" }
                    );
                }

                context.SaveChanges();

            }
        }
    }
}
