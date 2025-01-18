using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Abstract
{
    internal abstract class BaseMachine
    {
        public DateTime ProductionDate { get; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }
        public BaseMachine()
        {
            ProductionDate = DateTime.Now;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Üretim tarihi {ProductionDate.ToShortDateString()}\nSeri Numarası{SerialNumber}\nAdı {Name}\nAçıklama {Description}\nİşletim Sistemi {OperatingSystem}");

        }
        public abstract void GetProductName();
    }
}
