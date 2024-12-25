using System;
namespace ForPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1 Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırma
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            }
            Console.WriteLine("\n----------------------------------------");
            //1 ile 20 arasındaki sayıları konsol ekranına yazdırma
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n----------------------------------------");
            //1 ile 20 arasındaki çift sayıları konsol ekranına yazdırma
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("\n----------------------------------------");
            //50 ile 150 arasındaki sayıların toplamını ekrana yazdırma
            int toplam = 0;
            for (int i = 50; i <= 150; i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);
            //1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            Console.WriteLine("\n----------------------------------------");
            int teklerinToplami = 0;
            int ciftlerinToplami = 0;
            for (int i = 1; i <= 120; i++)
            {
                if (i % 2 == 0)
                {
                    ciftlerinToplami += i;
                }
                else
                {
                    teklerinToplami += i;
                }

            }
            Console.WriteLine($"Teklerin Toplamı: {teklerinToplami}" );
            Console.WriteLine("Çiftlerin Toplamı: " + ciftlerinToplami);
        }
    }
}

