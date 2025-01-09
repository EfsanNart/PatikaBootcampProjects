using Library;

namespace LibraryApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Using default constructor
            //New: Creates an object of the Book class
            Book book1 = new Book()
            {
                Name = "Sabırsız Yürek",
                WriterName = "Stefan  ",
                WriterSurname = "Zweig",
                Publisher = "Alfa Yayınları",
                NumberOfPages = 464,
                
            };
            //Using parameterized constructors
            Book book2 = new Book("Sefiller","Victor Hugo",1724,"Can Yayınları");

            //Book information
            book1.Bookİnfo();
            book2.Bookİnfo();

        }
    }
}