using LibraryManagementSystem.Models;

class Program
{
    static void Main()
    {
        List<Author> authors = new List<Author>
        {
            new Author(2,"Stefan","Zweig"),
            new Author(5,"Franz","Kafka"),
            new Author(3,"Oğuz","Atay"),
            new Author(4,"Halit Ziya","Uşaklıgil")
        };
        List<Book> books = new List<Book>
        {
            new Book(1,"Sabırsız Yürek",2),
            new Book(2,"Dönüşüm",5),
            new Book(3,"Tutunamayanlar",3),
            new Book(4,"Aşk-ı Memnu",4),
            new Book(5,"Satranç",2)
        };
        var query = from book in books //Burada books listesindeki her bir Book nesnesini book değişkenine atıyoruz. Yani books listesini tek tek geziyoruz.
                    join author in authors // authors listesindeki her bir Author nesnesini author değişkenine atar
                    on book.AuthorId equals author.AuthorId //book.AuthorId ile author.AuthorId eşleşenleri alır.
                    select new // yeni anonim  bir nesne oluşturuyoruz,her eşleşen kitap ve yazar için yeni bir nesne oluşturur.
                    {
                        BookTitle = book.Title,
                        AuthorName = author.Name + " " + author.Surname // Yazarın adı ve soyadını birleştiriyoruz
                    };
        foreach (var item in query)
        {
            Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
        }
    }
}