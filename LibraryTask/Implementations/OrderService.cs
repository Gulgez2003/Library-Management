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
                // Книга найдена, накапливаем её стоимость
                totalPrice += book.Price;
                return totalPrice;
            }
            else
            {
                // Книга не найдена, можно выбрасывать исключение или возвращать специальное значение
                throw new ArgumentException($"Книга с идентификатором {id} не найдена.");
                // или return 0; // или return double.NaN; в зависимости от логики вашего приложения
            }
        }
    }
}
