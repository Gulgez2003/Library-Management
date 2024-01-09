using LibraryTask.Models.BaseModel;

namespace LibraryTask.Models
{
    public class Book : Base
    {
        public Book(string name, string authorName, int pageCount, double price, string code) : base()
        {
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            Price = price;
            Code = code;
        }

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public double Price { get; set; }
        public string Code { get; set; }
    }
}
