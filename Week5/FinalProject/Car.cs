using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Car
    {
   


        public DateTime UretimTarihi { get; private set; }
        public string SeriNumarasi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Car()
        {
            UretimTarihi = DateTime.Now;
        }
    }


}

