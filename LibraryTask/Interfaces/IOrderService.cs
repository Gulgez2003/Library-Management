using LibraryTask.Implementations;

namespace LibraryTask.Interfaces
{
    public interface IOrderService
    {
        public double GetTotalPrice(int id);
    }
}
