using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice.StudentTeacherModels
{
    //BasePerson -> Özelliklerin aktarıldığı Base Class - Miras veren
    //Student -> Özelliklerin alan Derived Class - Türetilmiş Class - Miras Alan
    internal class Teacher : BasePerson
    {
        //Öğretmen için ilave propertyler
        private decimal _salaryInfo; //maaş bilgisi için decimal tanımlama
        public decimal SalaryInfo
        {
            get { return _salaryInfo; }
            set { _salaryInfo = value; }

        }
        //Öğretmen için ilave metot
        public void TeacherInfo()
        {
            PersonInfo(); //Metot içinde başka metot çağırma
            Console.WriteLine($" Olan Öğretmenin maaşı {SalaryInfo} Tl'dir.");
        }
    }
}