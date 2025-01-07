using UsingConstructor;

public class Program
{
    public static void Main(string[] args)
    {
        // Default Constructor kullanımı
        Baby baby1 = new Baby();
        baby1._name = "Ron";
        baby1._surname = "Weasley";
        Console.WriteLine($"Bebek 1: Ad={baby1._name}, Soyad={baby1._surname}, Doğum Tarihi={baby1._birthDate}");

        //  Parametreli Constructor kullanımı
        Baby baby2 = new Baby("Elif", "Aybal");
        Console.WriteLine($"Bebek 2: Ad={baby2._name}, Soyad={baby2._surname}, Doğum Tarihi={baby2._birthDate}");

        Console.ReadLine(); // Konsolun açık kalması için
    }
}