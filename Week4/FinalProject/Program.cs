using FinalProject.Abstract;
using FinalProject.Concrete;
public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1'e,Bilgisayar üretmek için 2'ye basın..");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Phone phone = new Phone();
                Console.WriteLine("Seri Numarası: ");
                phone.SerialNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ad :");
                phone.Name = Console.ReadLine();
                Console.Write("Açıklama : ");
                phone.Description = Console.ReadLine();
                Console.Write("İşletim Sistemi ");
                phone.OperatingSystem = Console.ReadLine();
                Console.Write("TR Lisanslı mı ? (true/false):");
                phone.IsTrLıcense = Convert.ToBoolean(Console.ReadLine());
                Console.Write("Ürün başarıyla üretildi !");
                phone.PrintInfo();


            }
            else if (secim == 2)
            {
                Computer computer = new Computer();
                Console.Write("Seri Numarası: ");
                computer.SerialNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ad: ");
                computer.Name = Console.ReadLine();
                Console.Write("Açıklama: ");
                computer.Description = Console.ReadLine();
                Console.Write("İşletim Sistemi: ");
                computer.OperatingSystem = Console.ReadLine();
                Console.Write("USB Giriş Sayısı (2 veya 4): ");
                computer.NumberOfUsbPorts = Convert.ToInt32(Console.ReadLine());
                Console.Write("Bluetooth var mı? (true/false): ");
                computer.IsBluetoothSupported = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Ürün başarıyla üretildi!");
                computer.PrintInfo();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }
            Console.Write("Başka bir ürün üretmek istiyor musunuz? (evet/hayır): ");
            string devamMi = Console.ReadLine().ToLower();
            if (devamMi != "evet")
            {
                Console.WriteLine("İyi günler!");
                break;
            }
        }
    }
}