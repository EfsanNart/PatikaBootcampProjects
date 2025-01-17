using System;
public class Program
{
    public static void Main(string[] args)
    {
        List<string> davetliler = new List<string>()
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        //Listeyi yazdırma
        Console.WriteLine("Davetliler:");
        foreach (var davetli in davetliler)
        {
            
            Console.WriteLine(davetli);
        }
    }
}

