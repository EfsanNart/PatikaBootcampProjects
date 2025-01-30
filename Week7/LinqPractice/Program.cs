using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            numbers.Add(rnd.Next(-50, 50));
        }

        Console.WriteLine("Rastgele Sayılar: " + string.Join(", ", numbers));

        var evenNumbers = numbers.Where(n => n % 2 == 0);
        var oddNumbers = numbers.Where(n => n % 2 != 0);
        var negativeNumbers = numbers.Where(n => n < 0);
        var positiveNumbers = numbers.Where(n => n > 0);
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22);
        var squaredNumbers = numbers.Select(n => n * n).ToList();

        Console.WriteLine($"\nÇift Sayılar: {string.Join(", ", evenNumbers)}");
        Console.WriteLine($"Tek Sayılar: {string.Join(", ", oddNumbers)}");
        Console.WriteLine($"Negatif Sayılar: {string.Join(", ", negativeNumbers)}");
        Console.WriteLine($"Pozitif Sayılar: {string.Join(", ", positiveNumbers)}");
        Console.WriteLine($"15'ten büyük ve 22'den küçük sayılar: {string.Join(", ", rangeNumbers)}");
        Console.WriteLine($"Her bir sayının karesi: {string.Join(", ", squaredNumbers)}");
    }
}