using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> coffees = new List<string>();

        Console.Write("Kaç kahve ismi girmek istiyorsunuz? ");
        int adet = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < adet; i++)
        {
            string coffe;
            while (true)
            {
                Console.Write($"Kahve {i + 1} : ");
                coffe = Console.ReadLine();

                // Sayı içeriyorsa tekrar giriş iste
                if (ContainsNumber(coffe))
                {
                    Console.WriteLine("⚠ Lütfen sadece harf içeren bir kahve ismi girin!");
                }
                else
                {
                    break;
                }
            }

            coffees.Add(coffe);
        }

        // Listeyi yazdır
        Console.WriteLine("\nGirilen Kahve İsimleri:");
        foreach (var coffe in coffees)
        {
            Console.WriteLine(coffe);
        }
    }

    // İçinde rakam var mı kontrol eden fonksiyon
    static bool ContainsNumber(string input)
    {
        foreach (char c in input)
        {
            if (char.IsDigit(c))return true;
        }
        return false;
    }
}
