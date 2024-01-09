using LibraryTask.Interfaces;
using LibraryTask.Models;

namespace LibraryTask.Implementations
{
    public class LibraryService : ILibraryService
    {
        public List<Book> Books = new List<Book>();
        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine("Book Added!");
        }

        public void FindAllBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine("--------------------------------");
                Console.Write("Id: ");
                Console.WriteLine(book.Id);
                Console.Write("Name: ");
                Console.WriteLine(book.Name);
                Console.Write("Author Name: ");
                Console.WriteLine(book.AuthorName);
                Console.Write("Page Count: ");
                Console.WriteLine(book.PageCount);
                Console.Write("Price: ");
                Console.WriteLine(book.Price);
                Console.Write("Code: ");
                Console.WriteLine(book.Code);
                Console.WriteLine("--------------------------------\n");
            }
        }

        public void GetBook(int id)
        {
            foreach (Book book in Books)
            {
                if (book.Id == id)
                {
                    Console.WriteLine("--------------------------------");
                    Console.Write("Id: ");
                    Console.WriteLine(book.Id);
                    Console.Write("Name: ");
                    Console.WriteLine(book.Name);
                    Console.Write("Author Name: ");
                    Console.WriteLine(book.AuthorName);
                    Console.Write("Page Count: ");
                    Console.WriteLine(book.PageCount);
                    Console.Write("Price: ");
                    Console.WriteLine(book.Price);
                    Console.Write("Code: ");
                    Console.WriteLine(book.Code);
                    Console.WriteLine("--------------------------------\n");
                }
                else
                {
                    Console.WriteLine("Book Not Found");
                }
            }
        }

        public void RemoveAllBooks(int id)
        {
            int count = 0;
            foreach (Book book in Books)
            {
                if (book.Id == id)
                {
                    Books.Remove(book);
                    Console.WriteLine("Book removed!");
                    count++;
                    Console.Write("Count of removed books: ");
                    Console.WriteLine(count);
                }
                else
                {
                    Console.WriteLine("Book Not Found");
                }
            }
        }
    }
}
