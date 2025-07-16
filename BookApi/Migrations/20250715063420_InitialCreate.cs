using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    PublishedYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Language = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Author", "Genre", "Language", "PublishedYear", "Title" },
                values: new object[,]
                {
                    { 1, "Harper Lee", "Fiction", "English", 1960, "To Kill a Mockingbird" },
                    { 2, "George Orwell", "Dystopian", "English", 1949, "1984" },
                    { 3, "Jane Austen", "Romance", "English", 1813, "Pride and Prejudice" },
                    { 4, "F. Scott Fitzgerald", "Tragedy", "English", 1925, "The Great Gatsby" },
                    { 5, "Herman Melville", "Adventure", "English", 1851, "Moby-Dick" },
                    { 6, "Leo Tolstoy", "Historical", "Russian", 1869, "War and Peace" },
                    { 7, "J.D. Salinger", "Fiction", "English", 1951, "The Catcher in the Rye" },
                    { 8, "J.R.R. Tolkien", "Fantasy", "English", 1937, "The Hobbit" },
                    { 9, "Fyodor Dostoevsky", "Philosophical", "Russian", 1866, "Crime and Punishment" },
                    { 10, "Fyodor Dostoevsky", "Philosophical", "Russian", 1880, "The Brothers Karamazov" },
                    { 11, "Aldous Huxley", "Dystopian", "English", 1932, "Brave New World" },
                    { 12, "J.R.R. Tolkien", "Fantasy", "English", 1954, "The Lord of the Rings" },
                    { 13, "Charlotte Brontë", "Gothic", "English", 1847, "Jane Eyre" },
                    { 14, "Emily Brontë", "Gothic", "English", 1847, "Wuthering Heights" },
                    { 15, "Homer", "Epic", "Greek", -800, "The Odyssey" },
                    { 16, "Dante Alighieri", "Epic", "Italian", 1320, "The Divine Comedy" },
                    { 17, "Miguel de Cervantes", "Satire", "Spanish", 1605, "Don Quixote" },
                    { 18, "Paulo Coelho", "Quest", "Portuguese", 1988, "The Alchemist" },
                    { 19, "Leo Tolstoy", "Realist", "Russian", 1877, "Anna Karenina" },
                    { 20, "John Steinbeck", "Novel", "English", 1939, "The Grapes of Wrath" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
