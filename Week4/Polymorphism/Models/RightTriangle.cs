using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class RightTriangle : BaseGeometricShape
    {
        //Dik üçgenin Constructor'ı
        public RightTriangle(int width,int height)
        {
            Width = width;
            Height = height;
        }
        //Base classda ki CalculateArea metodunu override ettik.
        public override void CalculateArea()
        {
            double area=(Width*Height)/2; // int olan değer direkt double olan değere tür dönüşümü yapılmadan atanabilir çünkü double int türünden daha  
                                          //geniş bir veri türüdür bu tür dönüşüme implicit conversion denilir.
            Console.WriteLine($"Alan --> {area}");                           

        }
    }
}
