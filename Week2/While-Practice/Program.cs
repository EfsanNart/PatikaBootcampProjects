using System;
namespace WhilePractice
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
                counter++;
            }
            Console.WriteLine("\n----------------------------------------");
            //1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("\n----------------------------------------");
            //1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            int j = 1;
            while (j <= 20)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }
            Console.WriteLine("\n----------------------------------------");
            //50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            int sayi = 50;
            int toplam = 0;
            while (sayi <= 150)
            {
                toplam += sayi;
                sayi++;
            }
            Console.WriteLine(toplam);
            Console.WriteLine("\n----------------------------------------");
            //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            int k = 1;
            int tekToplam = 0;
            int ciftToplam = 0;
            while (k <= 120)
            {
                if (k % 2 == 0)
                {
                    ciftToplam += k;
                }
                else
                {
                    tekToplam += k;
                }
                k++;
            }
            Console.WriteLine($"Tek Sayıların Toplamı: {tekToplam}" );
            Console.WriteLine($"Çift Sayıların Toplamı: {ciftToplam}");
        }
    }
}
