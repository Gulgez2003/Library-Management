namespace LibraryTask.Models.BaseModel
{
    public class Base
    {
        public static int id = 0;
        public int Id { get; set; }

        public Base()
        {
            id++;
            Id = id;
        }
    }
}
