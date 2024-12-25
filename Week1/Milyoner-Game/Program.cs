using System;
namespace PatikaBootcampTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilgi Yarışmasına Hoş Geldiniz! Büyük ödül: 1 Milyon TL!\n");
            Console.WriteLine("2 cevap şıklı 3 adet sorumuz var ! \n");
            Console.WriteLine("3 sorudan ilk 2'sini doğru cevaplamanı bekliyoruz aksi takdirde elenmiş oluyorsunuz.. \n");
            // Doğru cevapları sayıyoruz
            int dogruSayisi = 0;

            Console.WriteLine("Soru 1-) Hangisi Harry Potter'ın yakın arkadaşlarından biridir? ");
            Console.WriteLine("a) Ron Weasley  b) Draco Malfoy");
            string cevap1 = Console.ReadLine().ToLower();

            if (cevap1 == "a")
            {
                Console.WriteLine("Doğru cevap!\n");
                dogruSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap!\n");
            }


            Console.WriteLine("Soru 2-) Dönüşüm kitabının yazarı kimdir? ");
            Console.WriteLine("a) Stefan Zweig  b) Franz Kafka");
            string cevap2 = Console.ReadLine().ToLower();

            if (cevap2 == "b")
            {
                Console.WriteLine("Doğru cevap!\n");
                dogruSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap!\n");
            }

            // Eğer kullanıcı ilk iki soruda 2 doğru yapamazsa üçüncü soru sorulmaz
            if (dogruSayisi < 2)
            {
                Console.WriteLine("Maalesef büyük ödülü kazanma şansınız kalmadı.");
                Console.WriteLine($"Toplam Doğru Sayısı: {dogruSayisi}");
                return;
            }


            Console.WriteLine("Soru 3-) Bir dikdörtgenin uzun kenarı 8 cm, kısa kenarı 5 cm'dir. Alanı kaçtır?");
            Console.WriteLine("a) 26cm^2  b) 40cm^2");
            string cevap3 = Console.ReadLine().ToLower();

            if (cevap3 == "b")
            {
                Console.WriteLine("Doğru cevap!\n");
                dogruSayisi++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap!\n");
            }


            if (dogruSayisi >= 2)
            {
                Console.WriteLine("Tebrikler! Büyük ödülü kazandınız!\n");
            }
            else
            {
                Console.WriteLine("Maalesef büyük ödülü kazanamadınız. Daha çok çalışmalısınız!\n");
            }

            Console.WriteLine($"Toplam Doğru Sayısı: {dogruSayisi}"); ;

        }
    }
}
