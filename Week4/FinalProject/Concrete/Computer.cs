using FinalProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Concrete
{
    internal class Computer : BaseMachine
    {
        private int _numberOfUsbPorts;
        public int NumberOfUsbPorts
        {
            get { return _numberOfUsbPorts; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _numberOfUsbPorts = value;
                }
                else
                {
                    Console.WriteLine("Usb giriş sayısı 2 veya 4 atanabilir !");
                    _numberOfUsbPorts = -1;
                }
            }
        }
        public bool IsBluetoothSupported { get; set; }
        public override void GetProductName()
        {
            Console.WriteLine($"Bilgisayarınızın Adı --> {Name}");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Usb giriş sayısı {NumberOfUsbPorts}\nBluetooth var mı {(IsBluetoothSupported ? "Var" : "Yok")}");
        }


    }
}
