using BookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book { ID = 1, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedYear = 1960, Language = "English", Genre = "Fiction" },
                new Book { ID = 2, Title = "1984", Author = "George Orwell", PublishedYear = 1949, Language = "English", Genre = "Dystopian" },
                new Book { ID = 3, Title = "Pride and Prejudice", Author = "Jane Austen", PublishedYear = 1813, Language = "English", Genre = "Romance" },
                new Book { ID = 4, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublishedYear = 1925, Language = "English", Genre = "Tragedy" },
                new Book { ID = 5, Title = "Moby-Dick", Author = "Herman Melville", PublishedYear = 1851, Language = "English", Genre = "Adventure" },
                new Book { ID = 6, Title = "War and Peace", Author = "Leo Tolstoy", PublishedYear = 1869, Language = "Russian", Genre = "Historical" },
                new Book { ID = 7, Title = "The Catcher in the Rye", Author = "J.D. Salinger", PublishedYear = 1951, Language = "English", Genre = "Fiction" },
                new Book { ID = 8, Title = "The Hobbit", Author = "J.R.R. Tolkien", PublishedYear = 1937, Language = "English", Genre = "Fantasy" },
                new Book { ID = 9, Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", PublishedYear = 1866, Language = "Russian", Genre = "Philosophical" },
                new Book { ID = 10, Title = "The Brothers Karamazov", Author = "Fyodor Dostoevsky", PublishedYear = 1880, Language = "Russian", Genre = "Philosophical" },
                new Book { ID = 11, Title = "Brave New World", Author = "Aldous Huxley", PublishedYear = 1932, Language = "English", Genre = "Dystopian" },
                new Book { ID = 12, Title = "The Lord of the Rings", Author = "J.R.R. Tolkien", PublishedYear = 1954, Language = "English", Genre = "Fantasy" },
                new Book { ID = 13, Title = "Jane Eyre", Author = "Charlotte Brontë", PublishedYear = 1847, Language = "English", Genre = "Gothic" },
                new Book { ID = 14, Title = "Wuthering Heights", Author = "Emily Brontë", PublishedYear = 1847, Language = "English", Genre = "Gothic" },
                new Book { ID = 15, Title = "The Odyssey", Author = "Homer", PublishedYear = -800, Language = "Greek", Genre = "Epic" },
                new Book { ID = 16, Title = "The Divine Comedy", Author = "Dante Alighieri", PublishedYear = 1320, Language = "Italian", Genre = "Epic" },
                new Book { ID = 17, Title = "Don Quixote", Author = "Miguel de Cervantes", PublishedYear = 1605, Language = "Spanish", Genre = "Satire" },
                new Book { ID = 18, Title = "The Alchemist", Author = "Paulo Coelho", PublishedYear = 1988, Language = "Portuguese", Genre = "Quest" },
                new Book { ID = 19, Title = "Anna Karenina", Author = "Leo Tolstoy", PublishedYear = 1877, Language = "Russian", Genre = "Realist" },
                new Book { ID = 20, Title = "The Grapes of Wrath", Author = "John Steinbeck", PublishedYear = 1939, Language = "English", Genre = "Novel" }
            );
        }
    }
}