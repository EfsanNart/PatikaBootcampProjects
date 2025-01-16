using System;

class Program
{
    static void Main()
    {
        // 10 elemanlı bir dizi tanımlıyoruz
        int[] numbers = new int[10];

        // Diziyi for döngüsü ile, kullanıcıdan alınan değerlerle doldurma
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: "); // Kullanıcıdan sayı alma
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Girilen sayıları ekrana yazdırıyor
        Console.WriteLine("Girilen sayılar:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Kullanıcıdan yeni bir değer alıp diziye ekleme
        Console.Write("Yeni bir sayı girin: ");
        int newValue = Convert.ToInt32(Console.ReadLine());

        // Dizinin boyutunu artırarak yeni elemanı ekleme,genişletme
        Array.Resize(ref numbers, numbers.Length + 1);
        numbers[numbers.Length - 1] = newValue;

        // Diziyi büyükten küçüğe sıralayıp ekrana yazdırma
        Array.Sort(numbers); // Küçükten büyüğe sıralama
        Array.Reverse(numbers); // Diziyi ters çevirerek büyükten küçüğe sıralama

        // Sıralı diziyi ekrana yazdırma
        Console.WriteLine("Büyükten küçüğe sıralı hali:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
