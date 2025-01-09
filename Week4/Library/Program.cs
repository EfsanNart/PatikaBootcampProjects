using Library;

namespace LibraryApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Name = "Sabırsız Yürek",
                WriterName = "Stefan  ",
                WriterSurname = "Zweig",
                Publisher = "Alfa Yayınları",
                NumberOfPages = 464,
                
            };
            Book book2 = new Book("Sefiller","Victor Hugo",1724,"Can Yayınları");


            //Book information
            book1.Bookİnfo();
            book2.Bookİnfo();

        }
    }
}