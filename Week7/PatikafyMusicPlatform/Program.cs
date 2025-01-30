using PatikafyMusicPlatform;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Artist> artists = new List<Artist>
        {
            new Artist("Ajda Pekkan", "Pop", 1968, 20),
            new Artist("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10),
            new Artist("Funda Arar", "Pop", 1999, 3),
            new Artist("Sertab Erener", "Pop", 1994, 5),
            new Artist("Sıla", "Pop", 2009, 3),
            new Artist("Serdar Ortaç", "Pop", 1994, 10),
            new Artist("Tarkan", "Pop", 1992, 40),
            new Artist("Hande Yener", "Pop", 1999, 7),
            new Artist("Hadise", "Pop", 2005, 5),
            new Artist("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10),
            new Artist("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2)
        };

        // 1. Adı 'S' ile başlayan şarkıcılar
        Console.WriteLine("Adı S ile başlayan sanatçılar");
        var startingS = artists.Where(artist => artist.Name.StartsWith("S"));

        foreach (var artist in startingS)
        {
            Console.WriteLine(artist.Name);
        }
        Console.WriteLine("-------------------------------------------------------------------------------------------");

        // 2. Albüm satışları 10 milyonun üzerinde olan şarkıcılar
        Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
        var sales = artists.Where(artist => artist.AlbumSales > 10);

        foreach (var artist in sales)
        {
            Console.WriteLine($"{artist.Name} - {artist.AlbumSales}");
        }

        Console.WriteLine("------------------------------------------------------------------------------------------");

        // 3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar (Çıkış yılına göre sıralı)
        Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar.( Çıkış yılı - Alfabetik Sıra)");
        var popSinger = artists.Where(artist => artist.ReleaseYear < 2000 && artist.Type.Contains("Pop"))
                               .OrderBy(artist => artist.Name)
                               .GroupBy(artist => artist.ReleaseYear);
        foreach (var group in popSinger)
        {
            foreach (var artist in group)
            {
                Console.WriteLine($"{artist.ReleaseYear} - {artist.Name}");
            }
        }

        Console.WriteLine("----------------------------------------------------------------------------------------");

        // 4. En çok albüm satan şarkıcı
        
        var bestSelling = artists.OrderByDescending(s => s.AlbumSales).First();
        Console.WriteLine("En çok albüm satan şarkıcı: " + bestSelling.Name);

        Console.WriteLine("----------------------------------------------------------------------------------------");
        // 5. En yeni ve en eski çıkış yapan şarkıcı
        var newest = artists.OrderByDescending(s => s.ReleaseYear).First();
        var latest = artists.OrderBy(s => s.ReleaseYear).First();
        Console.WriteLine($"En yeni çıkış yapan şarkıcı: {newest.Name}");
        Console.WriteLine($"En eski çıkış yapan şarkıcı: {latest.Name}");
    }
}
