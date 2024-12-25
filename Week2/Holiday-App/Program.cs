using System;
namespace HolidayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //Ana döngümüz, Kullanıcının birden fazla tatil planlaması yapmasını sağlıyor.
            {
                Console.WriteLine("\nLuxuryWay Tatil Uygulamasına Hoş Geldiniz!");
                Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris, Çeşme");

                string lokasyon;
                int paketFiyati = 0;

                while (true) //Lokasyon seçimi için döngü başlıyor
                {
                    lokasyon = Console.ReadLine().ToLower();

                    if (lokasyon == "bodrum")
                    {
                        paketFiyati = 4000;
                        lokasyon = "Bodrum";//lokasyonu ekranda büyük harfle yazdırmak için çünkü kullanıcıdan küçük harfle alıyoruz.
                        break;
                    }
                    else if (lokasyon == "marmaris")
                    {
                        paketFiyati = 3000;
                        lokasyon = "Marmaris";
                        break;
                    }
                    else if (lokasyon == "çeşme")
                    {
                        paketFiyati = 5000;
                        lokasyon = "Çeşme";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
                    }
                }

                Console.WriteLine($"Seçtiğiniz lokasyon: {lokasyon}");
                Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
                int kisiSayisi;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out kisiSayisi) && kisiSayisi > 0)
                    {
                        break; // Geçerli bir kişi sayısı girildiğinde döngüden çıkar.
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz."); // Hatalı giriş durumunda uyarı mesajı
                    }
                }


                Console.WriteLine("Ulaşım seçeneğinizi belirleyin:");
                Console.WriteLine("1 - Kara yolu: Kişi başı 1500 TL, otobüs veya özel araç ile ulaşım.");
                Console.WriteLine("2 - Hava yolu: Kişi başı 4000 TL, uçak ile seyahat.");
                int ulasimTutari = 0;

                while (true)
                {
                    string ulasimSecimi = Console.ReadLine();

                    if (ulasimSecimi == "1")
                    {
                        ulasimTutari = 1500;
                        break;
                    }
                    else if (ulasimSecimi == "2")
                    {
                        ulasimTutari = 4000;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız. Lütfen 1 veya 2 olarak seçim yapınız.");
                    }
                }

                int toplamTutar = (paketFiyati + ulasimTutari) * kisiSayisi;
                Console.WriteLine($"\nSeçtiğiniz lokasyon: {lokasyon}\nKişi sayısı: {kisiSayisi}\nToplam tatil maliyeti: {toplamTutar} TL\n");

                Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet/Hayır)");
                string devamMi = Console.ReadLine().ToLower();

                if (devamMi != "evet") // Kullanıcı evet dışında bir şey yazarsa döngüden çıkar 
                {
                    Console.WriteLine("İyi günler dileriz!");
                    break;
                }
            }
        }
    }
}