using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Abstract
{
    internal abstract class BaseCompanyEmployees //Nesne üretilemez tek görev miras vermek
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        
        public abstract void EmployeeTask(); //EmployeeTask metodunu miras verdiğim classlar içinde ezeceğimi vaad ediyorum 
    }
}
