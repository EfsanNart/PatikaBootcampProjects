using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice.StudentTeacherModels
{
    internal class BasePerson
    {   //Base Class için Propertyler
        private string _name;
        private string _surname;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }

        }
        //Konsol ekranına Ad Soyad  yazdıran metot
        public void PersonInfo()
        {
            Console.WriteLine($" Adı : {Name} \n Soyadı : {Surname}");
        }
    }
}
