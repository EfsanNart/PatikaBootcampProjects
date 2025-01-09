using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private string _color;
        private int _numberOfDoors;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _numberOfDoors = value;
                }
                else
                {
                    Console.WriteLine("Kapı Sayısı yanlış girildi 2 veya 4 olmalıdır.");
                    _numberOfDoors =- 1;
                }
            }
        }
        public Car(string brand, string model, string color, int numberOfDoors)
        {
            Brand = brand;
            Model = model;
            Color = color;
            NumberOfDoors = numberOfDoors;
        }
        public void CarInfo()
        {
            Console.WriteLine($"{Brand} markalı,{Model} model arabanın kapı sayısı {NumberOfDoors} ve rengi {Color}");
        }
    }
}
