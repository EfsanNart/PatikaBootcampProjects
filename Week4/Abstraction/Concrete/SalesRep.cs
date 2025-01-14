using Abstraction.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Concrete
{
    internal class SalesRep:BaseCompanyEmployees
    {
        //Ctor
        public SalesRep(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public override void EmployeeTask()
        {
            Console.WriteLine("Satış temsilcisi olarak çalışıyorum");
        }
    }
}
