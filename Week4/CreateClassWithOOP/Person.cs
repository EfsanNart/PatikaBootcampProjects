using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassWithOOP
{
    internal class Person
    {
        /* ------------------------------------------------------------------------------------------------------------------------------------------------
         Eğer Ad zaten public bir property olarak tanımlıysa ve doğrudan erişilebilir durumdaysa, 
         bir property'den başka bir property'yi döndürmek genellikle gerekmez örneğin 

         public string Ad { get; set; }
         public string Isim
        {
          get { return Ad; } // Ad property’sini döndür
          set { Ad = value; } // Ad property’sine değer ata } Bu yapı çalışır, ama gereksizdir çünkü Ad zaten erişilebilir durumdadır.
        ----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public string Ad { get; set; } //Senaryoda bizden public tanımlamamız istenildi.
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Branş {  get; set; }
        public string Sınıf {  get; set; }

        public void Ogretmenİnfo()
        {
            Console.WriteLine($"{Ad} {Soyad} adlı öğretmenin doğum tarihi : {DogumTarihi:dd.MM.yyyy} 'dir ve branşı {Branş}'dır.");
        }
        public void Ogrenciİnfo()
        {
            Console.WriteLine($"{Ad} {Soyad} adlı öğrencinin doğum tarihi : {DogumTarihi:dd.MM.yyyy} 'dir ve {Sınıf} sınıfındadır.");
        }
    }
}
