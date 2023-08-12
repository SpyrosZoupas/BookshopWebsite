using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookshopWebsite.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deathday = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
