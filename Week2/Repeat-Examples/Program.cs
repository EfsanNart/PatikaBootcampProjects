using System;
namespace RepeatExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Task1 Konsola bir satır yazdırmak için kullanılır ve yazdırdıktan sonra bir alt satıra geçer.
            //Console.WriteLine("Merhaba");
            //Console.WriteLine("Nasılsın?");
            //Console.WriteLine("İyiyim");
            //Console.WriteLine("Sen nasılsın?");
            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task2 Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
            //string breed = "Golden Retriever";
            //int age = 5;
            //Console.WriteLine($"cinsi : {breed},yaşı : {age}");

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");


            //task3 Rastgele bir sayı üretip , ekrana yazdırınız.
            //Random random = new Random();
            //int rastegeleSayi = random.Next();
            //Console.WriteLine($"Rastgele sayi : {rastegeleSayi}");

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");


            //task4 Rastgele bir sayı üretip , bu sayının 3'e bölümünden kalanı bulunuz ve ekrana yazdırınız.
            //Random random = new Random();
            //int rastgeleSayi = random.Next();
            //int kalanBulma = rastgeleSayi % 3;
            //Console.WriteLine($"Rastgele sayi : {rastgeleSayi},Bu sayının 3'e bölümünden kalan {kalanBulma}");

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");


            //task5 Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama
            //Console.WriteLine("Lütfen yaşınızı giriniz..");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age < 18)
            //{
            //    Console.WriteLine("-");
            //}
            //else
            //{
            //    Console.WriteLine("+");
            //}

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");


            //task6 Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");


            //}

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task7 Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
            //Console.WriteLine("Lütfen ilk metinsel değeri giriniz..");
            //string firstValue = Console.ReadLine();
            //Console.WriteLine("Lütfen ikinci metinsel değeri giriniz..");
            //string secondValue = Console.ReadLine();
            //string temp = firstValue;
            //firstValue = secondValue;
            //secondValue = temp;
            //Console.WriteLine($"firstValue : {firstValue},secondValue : {secondValue}");


            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task8 Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
            //BenDegerDondurmem();
            //static void BenDegerDondurmem()
            //{

            //    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");

            //}

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task9 İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
            //Console.WriteLine("Lütfen ilk sayıyı giriniz..");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz..");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //int result = Topla(firstNumber, secondNumber);
            //Console.WriteLine($"Toplam : {result}");
            //static int Topla(int firstNumber, int secondNumber)
            //{
            //    return firstNumber + secondNumber;

            //}


            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task10 Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
            //Console.WriteLine("Lütfen true ya da false değerini giriniz..");
            //bool value = Convert.ToBoolean(Console.ReadLine());
            //string result = DegerDondur(value);
            //Console.WriteLine($"Sonuç : {result}");
            //static string DegerDondur(bool value)
            //{
            //    if (value)
            //    {
            //        return "True";

            //    }
            //    else
            //    {
            //        return "False";

            //    }

            //}

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            // task11 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
            //Console.WriteLine("Lütfen ilk kişinin yaşını giriniz..");
            //int firstPerson = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci kişinin yaşını giriniz..");
            //int secondPerson = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen üçüncü kişinin yaşını giriniz..");
            //int thirdPerson = Convert.ToInt32(Console.ReadLine());

            //int result = EnYasli(firstPerson, secondPerson, thirdPerson);
            //Console.WriteLine($"En yaşlı kişinin yaşı : {result}");
            //static int EnYasli(int firstPerson, int secondPerson, int thirdPerson)
            //{
            //    if (firstPerson > secondPerson && firstPerson > thirdPerson)
            //    {
            //        return firstPerson;

            //    }
            //    else if (secondPerson > firstPerson && secondPerson > thirdPerson)
            //    {
            //        return secondPerson;
            //    }
            //    else
            //    {
            //        return thirdPerson;
            //    }
            //}

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task 12 Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
            //Console.WriteLine("Lütfen sayıları giriniz..");
            //int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
            //int result = EnBuyuk(numbers);
            //Console.WriteLine($"En büyük sayı : {result}");
            //static int EnBuyuk(int[] numbers)
            //{
            //    int max = numbers[0];
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        if (numbers[i] > max)
            //        {
            //            max = numbers[i];

            //        }

            //    }
            //    return max;

            //}

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task13  Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
            //Console.WriteLine("Lütfen ilk ismi giriniz..");
            //string firstValue = Console.ReadLine();
            //Console.WriteLine("Lütfen ikinci ismi giriniz..");
            //string secondValue = Console.ReadLine();
            //string result = IsimDegistir(firstValue, secondValue);
            //Console.WriteLine($"firstValue : {result}");
            //static string IsimDegistir(string firstValue, string secondValue)
            //{
            //    string temp = firstValue;
            //    firstValue = secondValue;
            //    secondValue = temp;
            //    return firstValue;

            //}


            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task14 Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
            //Console.WriteLine("Lütfen bir sayı giriniz..");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool result = TekMiCiftMi(number);
            //Console.WriteLine($"Sonuç : {result}");
            //static bool TekMiCiftMi(int number)
            //{
            //    if (number % 2 == 0)
            //    {
            //        return true;


            //    }
            //    return false;
            //}

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task15 Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
            //Console.WriteLine("Lütfen hızı giriniz..");
            //int speed = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Lütfen zamanı giriniz..");
            //int time = Convert.ToInt32(Console.ReadLine());
            //int result = GidilenYol(speed, time);
            //Console.WriteLine($"Gidilen yol : {result}");
            //static int GidilenYol(int speed, int time)
            //{
            //    return speed * time;

            //}


            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task16 Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
            //Console.WriteLine("Lütfen yarıçapı giriniz..");
            //int radius = Convert.ToInt32(Console.ReadLine());
            //double result = Alan(radius);
            //Console.WriteLine($"Dairenin alanı : {result}");
            //static double Alan(int radius)
            //{
            //    return Math.PI * radius * radius;

            //}

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task17 "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
            //string sentence = "Zaman bir GeRi SayIm";
            //Console.WriteLine(sentence.ToUpper());
            //Console.WriteLine(sentence.ToLower());

            //Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");

            //task18 "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
            //string sentence = "    Selamlar   ";
            //sentence = sentence.Trim();
            //Console.WriteLine(sentence);

        }
    }
}