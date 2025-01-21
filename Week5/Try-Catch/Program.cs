using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            //kullanıcıdan sayı alıp karesini hesaplıyorum
            try
            {
                Console.Write("Lütfen bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());//kullanıcıdan alınan string değeri tam sayıya dönüştürmeye çalışır
                int kare = sayi * sayi;
                Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
                break;//geçerli giriş olunca döngüden çık
            }
            //kullanıcı geçersiz giriş yaparsa FormatException  oluşur ve catch blogu calışır
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }
        }

    }
}
