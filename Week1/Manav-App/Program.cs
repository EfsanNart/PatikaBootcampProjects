using System;
namespace PatikaBootcampTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya manavına hoşgeldiniz..");
            Console.WriteLine("Elma = 2 TL");
            Console.WriteLine("Armut = 3 TL");
            Console.WriteLine("Çilek = 2 TL");
            Console.WriteLine("Muz = 3 TL");
            Console.WriteLine("Diğer bütün meyveler = 4 TL");
            Console.WriteLine("\nHangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
            string secim = Console.ReadLine().ToLower(); // Küçük harfe çeviriyoruz

            switch (secim)
            {
                case "elma":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;
                case "armut":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;
                case "çilek":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
                    break;
                case "muz":
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
                    break;
                default:
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
                    break;
            }
            /* Eğer kontrol edilen koşul sayısı az ise switch-case kullanımı daha  okunaklı oluyor. 
             * Ayrıca, birden fazla durum için aynı işlemi yapmak gerekiyorsa mesela case "elma": case "çilek": gibi, switch-case  avantajlı.
             * Ama daha karmaşık koşullar veya birden fazla mantıksal ifade gerektiğinde (örneğin, if (secim == "muz" && fiyat < 5) gibi)
             * if-else daha avantajlı. Bu task'de ise sabit ve belirli değerlerle çalıştığımız için switch-case kullanmak daha mantıklı */


            //if (secim == "elma")
            //{
            //    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
            //}
            //else if (secim == "armut")
            //{
            //    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
            //}
            //else if (secim == "çilek")
            //{
            //    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
            //}
            //else if (secim == "muz")
            //{
            //    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
            //}
            //else
            //{
            //    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");

            //}


        }
    }
}