using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class Rectangle:BaseGeometricShape
    {   //Dikdörtgen sınıfımızın constructor'ı
        public Rectangle(int width,int height)
        {
            Width = width; 
            Height = height;
        }
        
    }
}
