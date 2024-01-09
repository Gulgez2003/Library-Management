using LibraryTask.Models.BaseModel;

namespace LibraryTask.Models
{
    public class Order : Base
    {
        public Order(List<Book> books, double totalPrice, DateTime date):base()
        {
            Books = books;
            TotalPrice = totalPrice;
            Date = date;
        }

        public List<Book> Books { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
