using UsingConstructor;

public class Program
{
    public static void Main(string[] args)
    {
        // Default Constructor kullanımı
        Baby baby1 = new Baby();
        baby1.Name = "Ron";
        baby1.Surname = "Weasley";
        Console.WriteLine($"Bebek 1: Ad={baby1.Name}, Soyad={baby1.Surname}, Doğum Tarihi={baby1.BirthDate}");

        //  Parametreli Constructor kullanımı
        Baby baby2 = new Baby("Elif", "Aybal");
        Console.WriteLine($"Bebek 2: Ad={baby2.Name}, Soyad={baby2.Surname}, Doğum Tarihi={baby2.BirthDate}");

        Console.ReadLine(); // Konsolun açık kalması için
    }
}