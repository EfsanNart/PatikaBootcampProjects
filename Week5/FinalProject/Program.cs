using FinalProject;

class Program
{
    static void Main()
    {
        List<Car> cars = new List<Car>();

        while (true)
        {
            baslangic:
            Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
            string cevap = Console.ReadLine().Trim().ToLower();

            if (cevap == "h")
                break;
            else if (cevap != "e")
            {
                Console.WriteLine("Geçersiz giriş! Lütfen 'e' veya 'h' giriniz.");
                goto baslangic;
            }

            Car newCar = new Car();

            Console.Write("Seri Numarası: ");
            newCar.SeriNumarasi = Console.ReadLine().Trim();

            Console.Write("Marka: ");
            newCar.Marka = Console.ReadLine().Trim();

            Console.Write("Model: ");
            newCar.Model = Console.ReadLine().Trim();

            Console.Write("Renk: ");
            newCar.Renk = Console.ReadLine().Trim();

            kapisayisi:
            Console.Write("Kapı Sayısı: ");
            string kapiGiris = Console.ReadLine().Trim();

            if (!int.TryParse(kapiGiris, out int kapiSayisi))
            {
                Console.WriteLine("Hatalı giriş! Lütfen sayısal bir değer giriniz.");
                goto kapisayisi;
            }
            newCar.KapiSayisi = kapiSayisi;

            cars.Add(newCar);
            Console.WriteLine("Araba başarıyla üretildi!\n");
        }

        Console.WriteLine("Üretilen Arabalar:");
        foreach (var car in cars)
        {
            Console.WriteLine($"Seri No: {car.SeriNumarasi}, Marka: {car.Marka}");
        }
    }
}

