using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice.StudentTeacherModels
{   //BasePerson -> Özelliklerin aktarıldığı Base Class - Miras veren
    //Student -> Özelliklerin alan Derived Class - Türetilmiş Class - Miras Alan
    internal class Student : BasePerson
    {
        //Öğrenci için ilave propertyler
        private int _studentNumber;
        public int StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }
        //Öğrenci için ilave metot 
        public void StudentInfo()
        {
            PersonInfo(); //metot içinde başka metot çağırma
            Console.WriteLine($" Olan öğrencinin numarası {StudentNumber}");
            
        }

    }
}
