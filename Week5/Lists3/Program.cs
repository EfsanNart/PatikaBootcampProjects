using Lists3;
using System;
using System.Collections.Generic;

// Film sınıfım, film adı ve IMDb puanını tutuyor.


class Program
{
    static void Main()
    {
        // Film nesnelerini saklayacak olan liste
        List<Movie> filmler = new List<Movie>();

        // Kullanıcıdan film bilgileri alınır.
        while (true)
        {
            Console.Write("Film Adı: ");
            string isim = Console.ReadLine();

            Console.Write("IMDb Puanı: ");
            double puan = double.Parse(Console.ReadLine());

            // Kullanıcının girdiği bilgilerle bir Film nesnesi oluşturulur ve listeye eklenir.
            filmler.Add(new Movie { Isim = isim, ImdbPuani = puan });

            // Kullanıcıya yeni bir film eklemek isteyip istemediği sorulur.
            Console.Write("Yeni film eklemek istiyor musunuz? (evet/hayır): ");
            if (Console.ReadLine().ToLower() != "evet") break; // 'hayır' girilirse döngü sonlanır.
        }

        // Tüm filmler ekrana yazdırılır.
        Console.WriteLine("\nTüm Filmler:");
        foreach (var film in filmler)
        {
            Console.WriteLine($"{film.Isim} - IMDb: {film.ImdbPuani}");
        }

        // IMDb puanı 4 ile 9 arasında olan filmler ekrana yazdırılır.
        Console.WriteLine("\nIMDb Puanı 4 ile 9 Arasında Olan Filmler:");
        foreach (var film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"{film.Isim} - IMDb: {film.ImdbPuani}");
            }
        }

        // İsmi 'A' harfi ile başlayan filmler ekrana yazdırılır.
        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler:");
        foreach (var film in filmler)
        {
            if (char.ToUpper(film.Isim[0]) == 'A') // İlk harf 'A' ise ekrana yazdırılır.
            {
                Console.WriteLine($"{film.Isim} - IMDb: {film.ImdbPuani}");
            }
        }
    }
}
