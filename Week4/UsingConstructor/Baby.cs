using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UsingConstructor
{
    internal class Baby
    {
        public string _name;
        public string _surname;
        public DateTime _birthDate;

        //Default contructor
        public Baby()
        {   //OverLoading 
            //Eğer özel bir constructor tanımlarsak ve boş bir new ile kullanılacak constructora ihtiyaç duyarsak bunu tanımlarız
            _name = "Unknown";
            _surname = "Unknown";
            BirthProcess();
        }
        //Parametreli constructor
        public Baby(string name, string surname)
        { 
            _name = name;
            _surname = surname;
            BirthProcess();
        }
        public void BirthProcess()
        {    //2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.
            _birthDate = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }
    }
}
