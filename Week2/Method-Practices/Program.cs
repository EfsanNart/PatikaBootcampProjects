using System;
namespace MethodPractises
{
    class Program
    {
        static void Main(string[] args)

        {   // Değer döndürmeyen bir metodu çağırma
            FavoriteLyricSong();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("2'ye bölümden kalan: " + RandomNumber());
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Çarpım: " + Multiply(5, 6));
            Console.WriteLine("-----------------------------");
            Welcome("Hakan", "Alkan");
        }

        // Değer döndürmeyen bir metot tanımlama
        static void FavoriteLyricSong()
        {
            Console.WriteLine("Bana ancak dilsiz anlattı dili olanın dile getiremediklerini");
        }
        
        // Değer döndüren bir metot tanımlama
        // RandomNumber() metodu 2'ye bölümünden kalanı döndürür
        public static int RandomNumber()
        {
            Random random = new Random();
            int rastegeleSayi= random.Next();
            return rastegeleSayi % 2;
        }
        //Parametre Alan ve Geriye Değer Döndüren Bir Metot
        //Parametre olarak aldığı iki sayının çarpımını geriye dönsün.
        public static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //Parametre Alan ve Geriye Değer Döndürmeyen bir Metot
        //Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
        public static void Welcome(string name, string surname)
        {
            Console.WriteLine($"Hoş Geldiniz {name} {surname}");
        }
    }
}