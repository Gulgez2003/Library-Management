using LibraryTask.Interfaces;
using LibraryTask.Models;

namespace LibraryTask.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly LibraryService _libraryService;

        public OrderService(LibraryService libraryService)
        {
            _libraryService = libraryService;
        }
        public double GetTotalPrice(int id)
        {
            double totalPrice = 0;
            Book book = _libraryService.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                totalPrice += book.Price;
                return totalPrice;
            }
            else
            {
                throw new ArgumentException($"Book with identifier {id} not found.");
            }
        }
    }
}
