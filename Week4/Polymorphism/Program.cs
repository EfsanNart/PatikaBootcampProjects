using Polymorphism.Models;
public class Program
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(12,8);
        Console.WriteLine("Dikdörtgenin Alanı");
        rectangle.CalculateArea();

        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");

        Square square = new Square(4,6);
        Console.WriteLine("Karenin Alanı");
        square.CalculateArea();

        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------");

        RightTriangle rightTriangle =new RightTriangle(3,9);
        Console.WriteLine("Dik Üçgenin Alanı");
        rightTriangle.CalculateArea();  
    }
}
