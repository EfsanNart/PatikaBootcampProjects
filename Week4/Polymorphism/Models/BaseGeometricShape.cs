using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    internal class BaseGeometricShape
    {
        public int Width {  get; set; }
        public int Height { get; set; }
        //Virtual -> Ezilebilir metot
        //Bu metodun çalışma şeklini miras alınan class'ta değiştirebilir veya geliştirebiliriz
        public virtual void CalculateArea()
        {
            int area=Width*Height;
            Console.WriteLine($"Alan --> {area}");

        }
    }
}
