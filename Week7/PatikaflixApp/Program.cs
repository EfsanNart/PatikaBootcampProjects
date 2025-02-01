using PatikaflixApp.Models;

class Program
{
    static void Main()
    {
        // Dizi listesi oluşturuluyor
        List<Series> series = new List<Series>();

        while (true)
        {
            // Kullanıcıdan dizi bilgileri alınıyor
            Series newSeries = new Series();
            Console.Write("Dizi Adı: ");
            newSeries.Name = Console.ReadLine();
            Console.Write("Yapım Yılı: ");
            newSeries.YearOfConstruction = int.Parse(Console.ReadLine());
            Console.Write("Türü: ");
            newSeries.Type = Console.ReadLine();
            Console.Write("Yayınlanmaya Başlama Yılı: ");
            newSeries.ReleaseYear = int.Parse(Console.ReadLine());
            Console.Write("Yönetmen: ");
            newSeries.DirectorInfo = Console.ReadLine();
            Console.Write("Yayınlandığı İlk Platform: ");
            newSeries.ReleasePlatform = Console.ReadLine();

            // Dizi listeye ekleniyor
            series.Add(newSeries);

            // Kullanıcıya yeni dizi eklemek isteyip istemediği soruluyor
            Console.Write("Yeni bir dizi eklemek istiyor musunuz? (e/h): ");
            if (Console.ReadLine().ToLower() != "e")
                break;
        }

        // Komedi dizileri filtreleniyor ve yeni bir liste oluşturuluyor
        List<ComedySeries> comedySeries = series
            .Where(d => d.Type.ToLower().Contains("komedi")) // Türü komedi içeren diziler seçiliyor
            .Select(d => new ComedySeries { Name = d.Name, Type = d.Type, DirectorInfo = d.DirectorInfo }) // Yeni KomediDizisi nesneleri oluşturuluyor
            .OrderBy(d => d.Name) // Önce dizi adına göre sıralanıyor
            .ThenBy(d => d.DirectorInfo) // Sonra yönetmen adına göre sıralanıyor
            .ToList();

        // Komedi dizileri ekrana yazdırılıyor
        Console.WriteLine("\nKomedi Dizileri Listesi:\n");
        foreach (var dizi in comedySeries)
        {
            Console.WriteLine($"Dizi Adı: {dizi.Name}, Türü: {dizi.Type}, Yönetmen: {dizi.DirectorInfo}");
        }
    }
}
