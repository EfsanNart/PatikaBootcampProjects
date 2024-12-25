
using System; // Bu  ifade system ad alanını programa dahil eder, bu ad alanı temel .Net sınıflarını içerir

namespace VariablesPratice //namespace kodu düzenlemek ve isim çakışmalarını önlemek için kullanılan kapsayıcıdır.
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan veriyi alıyorum
            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");

            Console.Write("T.C. Kimlik Numarası: ");
            string tcKimlik = Convert.ToString(Console.ReadLine()); //matematiksel bir işlemde kullanılmadığı için string

            Console.Write("Adı: ");
            string ad = Convert.ToString(Console.ReadLine());

            Console.Write("Soyadı: ");
            string soyad = Convert.ToString(Console.ReadLine());

            Console.Write("Telefon Numarası: ");
            string telefonNumarasi = Convert.ToString(Console.ReadLine()); // Yine aynı şekilde matematiksel bir işlemde kullanılmadığı için string

            Console.Write("Yaş: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.Write("İlk Aldığı Ürünün Fiyatı: ");
            int ilkUrunFiyati = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Aldığı Ürünün Fiyatı: ");
            int ikinciUrunFiyati = Convert.ToInt32(Console.ReadLine());


            int toplamHarcama = ilkUrunFiyati + ikinciUrunFiyati;
            int patikaPuan = toplamHarcama / 10;   // integer tercih ettim çünkü matematiksel işlem yapıyoruz


            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine($"{tcKimlik} TC numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
            Console.WriteLine($"{telefonNumarasi} telefon numarasına bildirim mesajı gönderilmiştir.");
            Console.WriteLine($"{toplamHarcama} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {patikaPuan} TL'dir.");

        }
    }
}



