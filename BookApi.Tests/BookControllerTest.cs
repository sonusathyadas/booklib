using Xunit;
using Moq;
using BookApi.Controllers;
using BookApi.Models;
using BookApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BookApi.Tests.Controllers
{
    public class BooksControllerTests
    {
        [Fact]
        public async Task CreateBook_ReturnsCreatedAtAction_WithBook()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            var book = new Book { ID = 1, Title = "Test Book", Author = "Author" };
            mockRepo.Setup(r => r.AddBookAsync(It.IsAny<Book>())).ReturnsAsync(book);

            var controller = new BooksController(mockRepo.Object);

            // Act
            var result = await controller.CreateBook(book);

            // Assert
            var createdResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            var returnValue = Assert.IsType<Book>(createdResult.Value);
            Assert.Equal(book.ID, returnValue.ID);
            Assert.Equal(book.Title, returnValue.Title);
            Assert.Equal(book.Author, returnValue.Author);

            mockRepo.Verify(r => r.AddBookAsync(It.Is<Book>(b => b == book)), Times.Once);
        }

        [Fact]
        public async Task GetBooks_ReturnsOk_WithListOfBooks()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            var books = new List<Book> { new Book { ID = 1, Title = "Book1", Author = "Author1" } };
            mockRepo.Setup(r => r.GetAllBooksAsync()).ReturnsAsync(books);
            var controller = new BooksController(mockRepo.Object);

            // Act
            var result = await controller.GetBooks();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsAssignableFrom<IEnumerable<Book>>(okResult.Value);
            Assert.Single(returnValue);
        }

        [Fact]
        public async Task GetBook_ReturnsOk_WhenBookExists()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            var book = new Book { ID = 1, Title = "Book1", Author = "Author1" };
            mockRepo.Setup(r => r.GetBookByIdAsync(1)).ReturnsAsync(book);
            var controller = new BooksController(mockRepo.Object);

            // Act
            var result = await controller.GetBook(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<Book>(okResult.Value);
            Assert.Equal(1, returnValue.ID);
        }

        [Fact]
        public async Task GetBook_ReturnsNotFound_WhenBookDoesNotExist()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            mockRepo.Setup(r => r.GetBookByIdAsync(1)).ReturnsAsync((Book)null);
            var controller = new BooksController(mockRepo.Object);

            // Act
            var result = await controller.GetBook(1);

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        [Fact]
        public async Task UpdateBook_ReturnsNoContent_WhenSuccessful()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            var book = new Book { ID = 1, Title = "Book1", Author = "Author1" };
            mockRepo.Setup(r => r.UpdateBookAsync(book)).ReturnsAsync(book);
            var controller = new BooksController(mockRepo.Object);

            // Act
            var result = await controller.UpdateBook(1, book);

            // Assert
            Assert.IsType<NoContentResult>(result);
            mockRepo.Verify(r => r.UpdateBookAsync(book), Times.Once);
        }

        [Fact]
        public async Task UpdateBook_ReturnsBadRequest_WhenIdMismatch()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            var book = new Book { ID = 2, Title = "Book1", Author = "Author1" };
            var controller = new BooksController(mockRepo.Object);

            // Act
            var result = await controller.UpdateBook(1, book);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task DeleteBook_ReturnsNoContent_WhenBookExists()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            var book = new Book { ID = 1, Title = "Book1", Author = "Author1" };
            mockRepo.Setup(r => r.GetBookByIdAsync(1)).ReturnsAsync(book);
            mockRepo.Setup(r => r.DeleteBookAsync(1)).Returns(Task.CompletedTask);
            var controller = new BooksController(mockRepo.Object);

            // Act
            var result = await controller.DeleteBook(1);

            // Assert
            Assert.IsType<NoContentResult>(result);
            mockRepo.Verify(r => r.DeleteBookAsync(1), Times.Once);
        }

        [Fact]
        public async Task DeleteBook_ReturnsNotFound_WhenBookDoesNotExist()
        {
            // Arrange
            var mockRepo = new Mock<IBookRepository>();
            mockRepo.Setup(r => r.GetBookByIdAsync(1)).ReturnsAsync((Book)null);
            var controller = new BooksController(mockRepo.Object);

            // Act
            var result = await controller.DeleteBook(1);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}