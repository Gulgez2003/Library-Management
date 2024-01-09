# Library Management System

This console application is a simple Library Management System that allows users to perform various actions related to managing a library. Users can add books to the library, retrieve information about books by their ID, display all books in the library, remove books by their ID, and order books with an associated total order value.

## Usage

The main menu presents the following options:

- **1. Add book:** Allows the user to add a new book to the library by providing details such as name, author name, page count, price, and code.
- **2. Get book by id:** Retrieves information about a book by entering its ID.
- **3. Get all books:** Displays information about all the books in the library.
- **4. Remove book by id:** Removes a book from the library by entering its ID.
- **5. Order a book by id:** Allows users to order books by entering their IDs. The total order value is calculated, and the user can complete the order by entering '0'.
- **0. Break:** Exits the application.

## Methods

### 1. AddBook

- **Description:** Adds a new book to the library.
- **Parameters:**
  - `book` (type `Book`): The book object to be added to the library.

### 2. FindAllBooks

- **Description:** Displays information about all books in the library.
- **Parameters:** None

### 3. GetBook

- **Description:** Retrieves information about a specific book in the library based on its ID.
- **Parameters:**
  - `id` (type `int`): The ID of the book to be retrieved.

### 4. RemoveAllBooks

- **Description:** Removes all occurrences of a specific book from the library based on its ID.
- **Parameters:**
  - `id` (type `int`): The ID of the book to be removed.

## Notes

- Ensure valid input when using methods that require parameters, such as book details or book IDs, to prevent errors.
- The class uses a `List<Book>` to store the collection of books.
- Displayed information includes book ID, name, author name, page count, price, and code.
