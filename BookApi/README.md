# BookApi Project Documentation

## Project Description
BookApi is a RESTful API for managing a library of books. It allows users to perform CRUD operations on books, authors, and genres, supporting features such as search, filtering, and pagination. The project is built using ASP.NET Core Web API and follows modern software engineering practices for scalability and maintainability.

## Project Structure
```
BookApi/
├── Controllers/         # Contains BooksController.cs
├── Models/              # Contains Book.cs
├── Repositories/        # Contains BookRepository.cs, IBookRepository.cs
├── Data/                # Contains BookContext.cs
├── Migrations/          # Entity Framework migrations
├── Program.cs           # Application entry point
├── appsettings.json     # Application configuration
├── books.db             # SQLite database file
└── README.md            # Project documentation
```

## List of Classes and Descriptions
* **BooksController**: Handles API requests for book operations (CRUD, search, filter).
* **Book**: Represents the book entity with properties like Id, Title, Author, Genre, and Year.
* **BookRepository**: Implements data access logic for books using Entity Framework Core.
* **IBookRepository**: Interface defining contract for book repository operations.
* **BookContext**: Entity Framework Core database context for managing book entities and migrations.

## API Endpoints
The following endpoints are available:
- `GET /api/books` - Retrieve all books (supports filtering and pagination)
- `GET /api/books/{id}` - Retrieve a specific book by ID
- `POST /api/books` - Create a new book
- `PUT /api/books/{id}` - Update an existing book
- `DELETE /api/books/{id}` - Delete a book

## Patterns and Practices Used
* **Repository Pattern**: Used for abstracting data access logic in the BookRepository and IBookRepository.
* **Dependency Injection**: Built-in ASP.NET Core DI is used for controllers and repositories.
* **Entity Framework Core**: Used for ORM and database migrations.
* **RESTful API Design**: Follows REST conventions for resource management.
* **Exception Handling**: Standard ASP.NET Core exception handling is used.
* **Logging**: ASP.NET Core logging is enabled for diagnostics.

## Build, Test, Run, and Publish

### Prerequisites
- .NET SDK (6.0 or later)
- SQL Server (or configured database)

### Build
```bash
dotnet build
```

### Test
```bash
dotnet test
```

### Run
```bash
dotnet run
```
The API will be available at `https://localhost:5001` or as configured in `appsettings.json`.

### Publish
```bash
dotnet publish -c Release -o ./publish
```
Deploy the contents of the `publish` folder to your hosting environment.

---
For further details, refer to the inline code comments and documentation within each class.
