using FinalProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Concrete
{
    internal class Phone : BaseMachine
    {
        public bool IsTrLıcense { get; set; }
        public override void GetProductName()
        {
            Console.WriteLine($"Telefonunuzun Adı --> {Name}");
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"TR Lisansı var mı {(IsTrLıcense ? "Evet" : "Hayır")}");
        }

    }
}
