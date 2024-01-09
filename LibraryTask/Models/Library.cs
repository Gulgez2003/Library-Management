namespace LibraryTask.Models
{
    public class Library
    {
        public Library(List<Book> books)
        {
            Books = books;
        }

        public List<Book> Books { get; set; }
    }
}
