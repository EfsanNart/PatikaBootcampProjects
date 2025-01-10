using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Square : BaseGeometricShape
    {
        //Kare sınıfımızın constructor'ı
        public Square(int width, int height)
        {
            Width = width; 
            Height = height;
        }
    }
}
