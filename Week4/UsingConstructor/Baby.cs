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
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; private set; } // DogumTarihi property sadece bu class içinde set edilebilir olarak tanımladım

        //Default contructor
        public Baby()
        {   //OverLoading 
            //Eğer özel bir constructor tanımlarsak ve boş bir new ile kullanılacak constructora ihtiyaç duyarsak bunu tanımlarız
            Name = "Unknown";
            Surname = "Unknown";
            BirthProcess();
        }
        //Parametreli constructor
        public Baby(string name, string surname)
        {
            Name = name;
            Surname = surname;
            BirthProcess();
        }
        public void BirthProcess()
        {    //2 Constructor içinde ortak olarak bebek nesnesi oluşturulduğunda konsol ekranında bir " Ingaaaa " yazısı görülsün ve Doğum Tarihi o an olarak atansın.
            BirthDate = DateTime.Now;
            Console.WriteLine("Ingaaaa");
        }
    }
}
