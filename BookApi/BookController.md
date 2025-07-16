# BooksController API Documentation

This document describes the API endpoints provided by the `BooksController` in the BookApi project. The controller manages CRUD operations for books in the library.

## Base Route
`/api/books`

---

## Endpoints

### 1. Get All Books
- **Endpoint:** `GET /api/books`
- **Description:** Retrieves a list of all books.
- **Response:**
  - **200 OK**: Returns an array of book objects.
- **Sample Response:**
```json
[
  {
    "id": 1,
    "title": "Book Title",
    "author": "Author Name",
    "year": 2024
  },
  ...
]
```
- **Sample Usage (curl):**
```bash
curl -X GET http://localhost:5000/api/books
```

---

### 2. Get Book by ID
- **Endpoint:** `GET /api/books/{id}`
- **Description:** Retrieves a book by its ID.
- **Response:**
  - **200 OK**: Returns the book object.
  - **404 Not Found**: If the book does not exist.
- **Sample Response:**
```json
{
  "id": 1,
  "title": "Book Title",
  "author": "Author Name",
  "year": 2024
}
```
- **Sample Usage (curl):**
```bash
curl -X GET http://localhost:5000/api/books/1
```

---

### 3. Create a New Book
- **Endpoint:** `POST /api/books`
- **Description:** Adds a new book to the library.
- **Request Body:**
```json
{
  "title": "New Book",
  "author": "New Author",
  "year": 2025
}
```
- **Response:**
  - **201 Created**: Returns the created book object with its ID.
- **Sample Usage (curl):**
```bash
curl -X POST http://localhost:5000/api/books \
  -H "Content-Type: application/json" \
  -d '{"title":"New Book","author":"New Author","year":2025}'
```

---

### 4. Update a Book
- **Endpoint:** `PUT /api/books/{id}`
- **Description:** Updates an existing book's details.
- **Request Body:**
```json
{
  "id": 1,
  "title": "Updated Title",
  "author": "Updated Author",
  "year": 2025
}
```
- **Response:**
  - **204 No Content**: If update is successful.
  - **400 Bad Request**: If the ID in the URL does not match the ID in the body.
- **Sample Usage (curl):**
```bash
curl -X PUT http://localhost:5000/api/books/1 \
  -H "Content-Type: application/json" \
  -d '{"id":1,"title":"Updated Title","author":"Updated Author","year":2025}'
```

---

### 5. Delete a Book
- **Endpoint:** `DELETE /api/books/{id}`
- **Description:** Deletes a book by its ID.
- **Response:**
  - **204 No Content**: If deletion is successful.
  - **404 Not Found**: If the book does not exist.
- **Sample Usage (curl):**
```bash
curl -X DELETE http://localhost:5000/api/books/1
```

---

## Book Object Format
```json
{
  "id": int,
  "title": string,
  "author": string,
  "year": int
}
```

---

## Notes
- All endpoints return JSON responses.
- Ensure the API server is running and accessible at the specified host and port.
