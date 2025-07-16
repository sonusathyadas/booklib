# BookLibrary Solution

## Overview
This solution contains two projects for managing and testing a Book API using .NET and Entity Framework:

- **BookApi**: A .NET 8 Web API for CRUD operations on books, using Entity Framework Core with SQLite and the repository pattern.
- **BookApi.Tests**: An xUnit test project for unit and integration testing of the BookApi project.

## Projects

### BookApi
- **Type**: ASP.NET Core Web API (.NET 8)
- **Features**:
  - CRUD endpoints for Book model (ID, Title, Author, PublishedYear, Language, Genre)
  - Entity Framework Core with SQLite
  - Repository pattern for data access
  - Swagger/OpenAPI documentation
- **Structure**:
  - `Controllers/BooksController.cs`: API endpoints
  - `Models/Book.cs`: Book entity
  - `Repositories/IBookRepository.cs`, `BookRepository.cs`: Data access
  - `Data/BookContext.cs`: EF Core context
  - `appsettings.json`: Configuration (connection string)
  - `Program.cs`: App entry point
- **Setup**:
  1. Install .NET 8 SDK and SQLite
  2. Run `dotnet restore` in the BookApi directory
  3. Update `appsettings.json` if needed
  4. Start API: `dotnet run`
  5. API available at `http://localhost:5000`

### BookApi.Tests
- **Type**: xUnit Test Project (.NET 9)
- **Features**:
  - Unit and integration tests for BookApi
  - Uses Moq for mocking dependencies
  - Code coverage via coverlet
- **Structure**:
  - References BookApi project
  - Test classes for controllers, repositories, and models
- **Setup**:
  1. Run `dotnet restore` in BookApi.Tests directory
  2. Run tests: `dotnet test`

## Solution File
- **BookLibrary.sln**: Visual Studio solution file referencing both projects for easy management.

## Contributing
Contributions are welcome. Please submit issues or pull requests for improvements.

## License
MIT License.
