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
                        new Book
                        {
                            Title = "The fellowship of the ring",
                            Description = "The first volume in J.R.R. Tolkien's epic fantasy trilogy...",
                            NumberOfPages = "423 pages",
                            ReleaseDate = "July 29, 1954",
                            Price = 10,
                            InStock = true,
                            ImageUrl = "~/images/fellowship_of_the_ring.jpg",
                            Category = Categories["Fiction"],
                            Author = Authors["J.R.R. Tolkien"]
                        },
                        new Book
                        {
                            Title = "Harry Potter and the Sorcerer's Stone",
                            Description = "The first book in the Harry Potter series...",
                            NumberOfPages = "309 pages",
                            ReleaseDate = "June 26, 1997",
                            Price = 12,
                            InStock = false,
                            ImageUrl = "~/images/harry_potter_and_the_sorcerers_stone.jpg",
                            Category = Categories["Fiction"],
                            Author = Authors["J.K. Rowling"]
                        },
                        new Book
                        {
                            Title = "1984",
                            Description = "A dystopian novel by George Orwell...",
                            NumberOfPages = "328 pages",
                            ReleaseDate = "June 8, 1949",
                            Price = 8,
                            InStock = true,
                            ImageUrl = "~/images/1984.jpg",
                            Category = Categories["Fiction"],
                            Author = Authors["George Orwell"]
                        },
                        new Book
                        {
                            Title = "Murder on the Orient Express",
                            Description = "A famous detective novel by Agatha Christie...",
                            NumberOfPages = "256 pages",
                            ReleaseDate = "January 1, 1934",
                            Price = 9,
                            InStock = true,
                            ImageUrl = "~/images/murder_on_the_orient_express.jpg",
                            Category = Categories["Mystery"],
                            Author = Authors["Agatha Christie"]
                        },
                        new Book
                        {
                            Title = "The Shining",
                            Description = "A horror novel by Stephen King...",
                            NumberOfPages = "447 pages",
                            ReleaseDate = "January 28, 1977",
                            Price = 11,
                            InStock = false,
                            ImageUrl = "~/images/the_shining.jpg",
                            Category = Categories["Fiction"],
                            Author = Authors["Stephen King"]
                        },
                        new Book
                        {
                            Title = "Pride and Prejudice",
                            Description = "A classic novel by Jane Austen...",
                            NumberOfPages = "279 pages",
                            ReleaseDate = "January 28, 1813",
                            Price = 7,
                            InStock = true,
                            ImageUrl = "~/images/pride_and_prejudice.jpg",
                            Category = Categories["Fiction"],
                            Author = Authors["Jane Austen"]
                        },
                        new Book
                        {
                            Title = "The Adventures of Huckleberry Finn",
                            Description = "An adventure novel by Mark Twain...",
                            NumberOfPages = "366 pages",
                            ReleaseDate = "December 10, 1884",
                            Price = 9,
                            InStock = true,
                            ImageUrl = "~/images/the_adventures_of_huckleberry_finn.jpg",
                            Category = Categories["Fiction"],
                            Author = Authors["Mark Twain"]
                        },
                        new Book
                        {
                            Title = "To Kill a Mockingbird",
                            Description = "A classic novel by Harper Lee...",
                            NumberOfPages = "281 pages",
                            ReleaseDate = "July 11, 1960",
                            Price = 10,
                            InStock = false,
                            ImageUrl = "~/images/to_kill_a_mockingbird.jpg",
                            Category = Categories["Fiction"],
                            Author = Authors["Harper Lee"]
                        },
                        new Book
                        {
                            Title = "The Old Man and the Sea",
                            Description = "A novella by Ernest Hemingway...",
                            NumberOfPages = "127 pages",
                            ReleaseDate = "September 1, 1952",
                            Price = 8,
                            InStock = true,
                            ImageUrl = "~/images/the_old_man_and_the_sea.jpg",
                            Category = Categories["Fiction"],
                            Author = Authors["Ernest Hemingway"]
                        },
                        new Book
                        {
                            Title = "War and Peace",
                            Description = "A historical novel by Leo Tolstoy...",
                            NumberOfPages = "1225 pages",
                            ReleaseDate = "January 1869",
                            Price = 15,
                            InStock = true,
                            ImageUrl = "~/images/war_and_peace.jpg",
                            Category = Categories["History"],
                            Author = Authors["Leo Tolstoy"]
                        },
                        new Book
                        {
                            Title = "The return of the king",
                            Description = "The third volume in J.R.R. Tolkien's epic fantasy trilogy...",
                            NumberOfPages = "416 pages",
                            ReleaseDate = "October 20, 1955",
                            Price = 17,
                            InStock = true,
                            ImageUrl = "~/images/return_of_the_king.png",
                            Category = Categories["Fiction"],
                            Author = Authors["J.R.R. Tolkien"]
                        }

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
                        new Category { Name = "Fiction", Description = "A literary genre that encompasses a wide variety of imaginative works" },
                        new Category { Name = "Mystery", Description = "A genre focused on solving a puzzle or crime" },
                        new Category { Name = "Biography", Description = "A genre of written media that focuses on the lives of individuals" },
                        new Category { Name = "Science Fiction", Description = "A genre that explores speculative concepts, often futuristic or futuristic technologies" },
                        new Category { Name = "History", Description = "A genre that provides accounts and explanations of past events" }
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
                          new Author { Name = "J.R.R. Tolkien", Description = "English writer, poet, philologist, and academic", Nationality = "English", Age = 81, Birthday = "January 3, 1892", Deathday = "September 2, 1973" },
                          new Author { Name = "J.K. Rowling", Description = "British author, philanthropist, film producer, television producer, and screenwriter", Nationality = "British", Age = 56, Birthday = "July 31, 1965", Deathday = "" },
                          new Author { Name = "George Orwell", Description = "English novelist, essayist, journalist, and critic", Nationality = "English", Age = 46, Birthday = "June 25, 1903", Deathday = "January 21, 1950" },
                          new Author { Name = "Agatha Christie", Description = "English writer known for her detective novels", Nationality = "English", Age = 85, Birthday = "September 15, 1890", Deathday = "January 12, 1976" },
                          new Author { Name = "Stephen King", Description = "American author of horror, supernatural fiction, suspense, and fantasy novels", Nationality = "American", Age = 74, Birthday = "September 21, 1947", Deathday = "" },
                          new Author { Name = "Jane Austen", Description = "English novelist known primarily for her six major novels, which interpret, critique and comment upon the British landed gentry at the end of the 18th century", Nationality = "English", Age = 41, Birthday = "December 16, 1775", Deathday = "July 18, 1817" },
                          new Author { Name = "Mark Twain", Description = "American writer, humorist, entrepreneur, publisher, and lecturer", Nationality = "American", Age = 74, Birthday = "November 30, 1835", Deathday = "April 21, 1910" },
                          new Author { Name = "Harper Lee", Description = "American novelist best known for her 1960 Pulitzer Prize-winning novel 'To Kill a Mockingbird'", Nationality = "American", Age = 89, Birthday = "April 28, 1926", Deathday = "February 19, 2016" },
                          new Author { Name = "Ernest Hemingway", Description = "American novelist, short-story writer, journalist, and sportsman", Nationality = "American", Age = 61, Birthday = "July 21, 1899", Deathday = "July 2, 1961" },
                          new Author { Name = "Leo Tolstoy", Description = "Russian novelist, philosopher, and playwright", Nationality = "Russian", Age = 82, Birthday = "September 9, 1828", Deathday = "November 20, 1910" }

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
