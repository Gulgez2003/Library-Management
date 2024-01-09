using LibraryTask.Models;

namespace LibraryTask.Interfaces
{
    public interface ILibraryService
    {
        public void AddBook(Book book);
        public void GetBook(int id);
        public void FindAllBooks();
        public void RemoveAllBooks(int id);
    }
}
