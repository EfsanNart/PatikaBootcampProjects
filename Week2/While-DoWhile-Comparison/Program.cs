using System;
namespace Comparison{
    class Program
{
    static void Main()
    {
            Console.Write("Lütfen bir limit değeri giriniz: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWhile Döngüsü:");
            int sayac = 0;
            while (sayac <= limit)
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            }

            Console.WriteLine("\nDo-While Döngüsü:");
            sayac = 0;
            do
            {
                Console.WriteLine("Ben bir Patika'lıyım");
                sayac++;
            } while (sayac <= limit);

           

            // Aralarındaki fark:
            // While döngüsü, koşulu kontrol ettikten sonra çalışır.
            // Eğer koşul baştan sağlanmazsa (örneğin limit -5 ise), while döngüsü hiç çalışmaz.
            // Do-while döngüsü ise koşulu kontrol etmeden önce gövdesini en az bir kez çalıştırır.
            // Bu nedenle, limit -5 olduğunda bile do-while döngüsü bir kez "Ben bir Patika'lıyım" yazdıracaktır.
        }
    }
}