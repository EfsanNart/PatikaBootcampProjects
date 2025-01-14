using Abstraction.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Concrete
{
    internal class SoftwareDeveloper:BaseCompanyEmployees
    {
        //Ctor
        public SoftwareDeveloper(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public override void EmployeeTask()
        {
            Console.WriteLine("Yazılım geliştirici olarak çalışıyorum");
        }
    }
}
