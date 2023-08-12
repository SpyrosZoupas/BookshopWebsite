using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookshopWebsite.Migrations
{
    /// <inheritdoc />
    public partial class Migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Age", "Birthday", "Deathday", "Description", "Name", "Nationality" },
                values: new object[,]
                {
                    { 1, 0, null, null, null, "J.R.R. Tolkien", null },
                    { 2, 0, null, null, null, "J.K. Rowling", null },
                    { 3, 0, null, null, null, "George Orwell", null },
                    { 4, 0, null, null, null, "Agatha Christie", null },
                    { 5, 0, null, null, null, "Stephen King", null },
                    { 6, 0, null, null, null, "Jane Austen", null },
                    { 7, 0, null, null, null, "Mark Twain", null },
                    { 8, 0, null, null, null, "Harper Lee", null },
                    { 9, 0, null, null, null, "Ernest Hemingway", null },
                    { 10, 0, null, null, null, "Leo Tolstoy", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Fiction" },
                    { 2, null, "Mystery" },
                    { 3, null, "Biography" },
                    { 4, null, "Science Fiction" },
                    { 5, null, "History" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "CategoryId", "Description", "ImageUrl", "InStock", "NumberOfPages", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, null, "", true, null, 10m, null, "The fellowship of the ring" },
                    { 2, 2, 1, null, "", true, null, 12m, null, "Harry Potter and the Sorcerer's Stone" },
                    { 3, 3, 1, null, "", true, null, 8m, null, "1984" },
                    { 4, 4, 2, null, "", true, null, 9m, null, "Murder on the Orient Express" },
                    { 5, 5, 1, null, "", true, null, 11m, null, "The Shining" },
                    { 6, 6, 1, null, "", true, null, 7m, null, "Pride and Prejudice" },
                    { 7, 7, 1, null, "", true, null, 9m, null, "The Adventures of Huckleberry Finn" },
                    { 8, 8, 1, null, "", true, null, 10m, null, "To Kill a Mockingbird" },
                    { 9, 9, 1, null, "", true, null, 8m, null, "The Old Man and the Sea" },
                    { 10, 10, 5, null, "", true, null, 15m, null, "War and Peace" }
                });
        }
    }
}
