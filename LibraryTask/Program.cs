using LibraryTask.Implementations;
using LibraryTask.Models;

LibraryService libraryService = new();
OrderService orderService = new OrderService(libraryService);

Console.WriteLine("Welcome to our library!");
Console.WriteLine("Choose the action:");
Console.WriteLine("1. Add book");
Console.WriteLine("2. Get book by id");
Console.WriteLine("3. Get all books");
Console.WriteLine("4. Remove book by id");
Console.WriteLine("5. Order a book by id");
Console.WriteLine("0. Break");
int button = int.Parse(Console.ReadLine());

while (true)
{
    switch (button)
    {
        case (0):
            {
                break;
            }
        case (1):
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Author Name: ");
                string authorName = Console.ReadLine();
                Console.Write("Page Count: ");
                int pageCount = int.Parse(Console.ReadLine());
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Code: ");
                string code = Console.ReadLine();

                Book book = new Book(name, authorName, pageCount, price, code);
                libraryService.AddBook(book);
                break;
            }
        case (2):
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                libraryService.GetBook(id);
                break;
            }
        case (3):
            {
                libraryService.FindAllBooks();
                break;
            }
        case (4):
            {
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                libraryService.RemoveAllBooks(id);
                break;
            }
        case (5):
            {
                Console.WriteLine("Enter '0' to complete the order.");
                double totalPrice = 0;

                while (true)
                {
                    Console.Write("Enter the book ID for your order: ");
                    int id = int.Parse(Console.ReadLine());

                    if (id == 0)
                    {
                        break; 
                    }

                    double bookPrice = orderService.GetTotalPrice(id);

                    if (bookPrice > 0)
                    {
                        totalPrice += bookPrice;
                        Console.WriteLine($"Total order value: {totalPrice}");
                    }
                    else
                    {
                        Console.WriteLine($"Book with ID {id} not found.");
                    }
                }

                Console.WriteLine($"Final total order value: {totalPrice}");
                break;
            }
    }

    Console.WriteLine("Choose the action:");
    Console.WriteLine("1. Add book");
    Console.WriteLine("2. Get book by id");
    Console.WriteLine("3. Get all books");
    Console.WriteLine("4. Remove book by id");
    Console.WriteLine("5. Order a book by id");
    Console.WriteLine("0. Break");
    button = int.Parse(Console.ReadLine());
}
